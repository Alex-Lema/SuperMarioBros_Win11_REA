using System;
using System.Runtime.CompilerServices;
using SuperMarioBros_Win11.Audio;
using SuperMarioBros_Win11.Graphics;
using SuperMarioBros_Win11.Input;

namespace SuperMarioBros_Win11.Core
{
    /// <summary>
    /// Núcleo de Ejecución Determinista de Super Mario Bros. (2A03 / 6502 + Subsistemas Nativos)
    /// Basado en DOC_DISENO_PORT_WIN11_ARQUITECTURA.md y DOC_DISENO_PORT_WIN11_SUBSISTEMAS_Y_DATOS.md.
    /// Ejecuta las 533 subrutinas y las 18 tablas de JumpEngine ($8E04) sobre SmbMemory ($0000..$07FF).
    /// </summary>
    public sealed class SmbEngineCore
    {
        public const ushort VectorNmi = 0xFFFA;
        public const ushort VectorReset = 0xFFFC;
        public const ushort VectorIrq = 0xFFFE;

        // Flags de estado del procesador 2A03 (sin modo BCD decimal en hardware Ricoh)
        private const byte FlagC = 0x01;
        private const byte FlagZ = 0x02;
        private const byte FlagI = 0x04;
        private const byte FlagD = 0x08;
        private const byte FlagB = 0x10;
        private const byte FlagU = 0x20;
        private const byte FlagV = 0x40;
        private const byte FlagN = 0x80;

        public SmbRomImage Rom { get; }
        public SmbMemory Memory { get; }
        public Ppu2C02Renderer Ppu { get; }
        public Apu2A03Synthesizer Apu { get; }
        public WindowsGamingInputService Input { get; }

        // Registros del núcleo 2A03
        public byte A;
        public byte X;
        public byte Y;
        public byte SP;
        public byte P;
        public ushort PC;
        public long TotalCycles;

        private readonly byte[] _ram;
        private readonly byte[] _prg;

        public SmbEngineCore(
            SmbRomImage rom,
            SmbMemory memory,
            Ppu2C02Renderer ppu,
            Apu2A03Synthesizer apu,
            WindowsGamingInputService input)
        {
            Rom = rom;
            Memory = memory;
            Ppu = ppu;
            Apu = apu;
            Input = input;
            _ram = memory.Raw;
            _prg = rom.PrgRom;
            HardReset();
        }

        /// <summary>
        /// Reinicio en frío (Cold Boot): borra los 2 KB de RAM y ejecuta el vector RESET ($8000).
        /// </summary>
        public void HardReset()
        {
            Array.Clear(_ram, 0, _ram.Length);
            Ppu.Reset();
            Apu.Reset();
            A = 0;
            X = 0;
            Y = 0;
            SP = 0xFD;
            P = FlagI | FlagU;
            PC = ReadU16(VectorReset); // $8000 (Start_RESET)
            TotalCycles = 0;

            // Ejecutar la secuencia de arranque Start_RESET ($8000..$807F) hasta alcanzar EndlessLoop ($807F)
            RunBootSequenceToNmiEnable();
        }

        /// <summary>
        /// Reinicio en caliente (Warm Boot): preserva TopScoreDisplay ($07D7..$07DC) gracias a la firma $07FF == 0xA5
        /// documentada en la decompilación de Ghidra 12.1.4 de Start_RESET ($8000).
        /// </summary>
        public void WarmReset()
        {
            SP = 0xFD;
            P = FlagI | FlagU;
            PC = ReadU16(VectorReset); // $8000 (Start_RESET)
            RunBootSequenceToNmiEnable();
        }

        private void RunBootSequenceToNmiEnable()
        {
            // En Start_RESET ($8000), el juego espera 2 VBlanks leyendo $2002 bit 7 y luego inicializa la RAM y NameTables
            for (int vblankPass = 0; vblankPass < 4 && PC != 0x807F; vblankPass++)
            {
                Ppu.BeginVBlank();
                int safety = 0;
                while (safety++ < 60000 && PC != 0x807F)
                {
                    StepInstruction();
                }
            }
        }

        /// <summary>
        /// Ejecuta exactamente un frame NTSC completo (262 scanlines: 20 VBlank + 1 Pre-render + 240 Visibles = ~29,780.5 ciclos CPU)
        /// disparando NonMaskableInterrupt_NMI ($8082) y componiendo el framebuffer PPU.
        /// </summary>
        public void StepOneFrame60Hz(IntPtr windowHandle, bool savePrevFor120Hz)
        {
            if (savePrevFor120Hz)
            {
                Ppu.SaveStateFor120HzInterpolation();
            }

            // 1. Muestrear entrada con Windows.Gaming.Input + Teclado justo al comienzo del VBlank (mínima latencia)
            Input.PollMinimalLatencyInput(windowHandle);

            // 2. Inicio de VBlank (Scanlines 241..260 = 20 scanlines * 114 ciclos = 2,280 ciclos CPU)
            Ppu.BeginVBlank();
            if (Ppu.NmiPending)
            {
                Ppu.NmiPending = false;
                TriggerNmi();
            }
            ExecuteCpuCycles(2273);
            Apu.StepFrameCounterQuarter(isHalfFrame: false);

            // 3. Scanline 261 (Pre-render: limpia flags VBlank y Sprite 0 Hit en $2002)
            Ppu.EndVBlankAndPreRender();
            ExecuteCpuCycles(114);

            // 4. Scanlines Visibles 0..239 (240 scanlines * ~113.67 ciclos CPU)
            // Sincroniza exactamente el bucle de espera de Sprite 0 ($80E1..$80EC) dentro de NMI ($8082)
            int cycleRemainder = 0;
            for (int scanline = 0; scanline < 240; scanline++)
            {
                Ppu.StepVisibleScanline(scanline);

                int cyclesThisLine = 113;
                cycleRemainder += 2;
                if (cycleRemainder >= 3)
                {
                    cyclesThisLine = 114;
                    cycleRemainder -= 3;
                }

                ExecuteCpuCycles(cyclesThisLine);

                if (scanline == 79) Apu.StepFrameCounterQuarter(isHalfFrame: true);
                else if (scanline == 159) Apu.StepFrameCounterQuarter(isHalfFrame: false);
                else if (scanline == 239) Apu.StepFrameCounterQuarter(isHalfFrame: true);
            }

            // 5. Componer Framebuffer 256x240 nativo (y sub-frame interpolado si 120 FPS está activo)
            if (savePrevFor120Hz)
            {
                Ppu.ComposeFrame(isInterpolated120HzSubFrame: true);
            }
            Ppu.ComposeFrame(isInterpolated120HzSubFrame: false);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExecuteCpuCycles(int targetCycles)
        {
            long end = TotalCycles + targetCycles;
            while (TotalCycles < end)
            {
                if (Ppu.NmiPending)
                {
                    Ppu.NmiPending = false;
                    TriggerNmi();
                }
                StepInstruction();
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void TriggerNmi()
        {
            PushU16(PC);
            PushU8((byte)((P & ~FlagB) | FlagU));
            P |= FlagI;
            PC = ReadU16(VectorNmi); // $8082 (NonMaskableInterrupt_NMI)
            TotalCycles += 7;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte CpuRead(int addr)
        {
            addr &= 0xFFFF;
            if (addr < 0x2000)
            {
                return _ram[addr & 0x07FF];
            }
            if (addr < 0x4000)
            {
                return Ppu.CpuReadRegister(addr);
            }
            if (addr == 0x4016 || addr == 0x4017)
            {
                return Input.CpuReadPort(addr);
            }
            if (addr >= 0x8000)
            {
                return _prg[addr - 0x8000];
            }
            return 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CpuWrite(int addr, byte val)
        {
            addr &= 0xFFFF;
            if (addr < 0x2000)
            {
                _ram[addr & 0x07FF] = val;
                return;
            }
            if (addr < 0x4000)
            {
                Ppu.CpuWriteRegister(addr, val);
                return;
            }
            if (addr == 0x4014)
            {
                // OAM DMA ($4014): copia 256 bytes desde la página indicada (ej. $0200..$02FF)
                Ppu.ExecuteOamDma(_ram, val);
                TotalCycles += 513;
                return;
            }
            if (addr == 0x4016)
            {
                Input.CpuWriteStrobe(val);
                return;
            }
            if (addr >= 0x4000 && addr <= 0x4017)
            {
                Apu.CpuWriteRegister(addr, val);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ushort ReadU16(int addr)
        {
            byte lo = CpuRead(addr);
            byte hi = CpuRead(addr + 1);
            return (ushort)(lo | (hi << 8));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ushort ReadU16ZeroPage(byte zpAddr)
        {
            byte lo = _ram[zpAddr];
            byte hi = _ram[(byte)(zpAddr + 1)];
            return (ushort)(lo | (hi << 8));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void PushU8(byte val)
        {
            _ram[0x0100 | SP] = val;
            SP--;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte PopU8()
        {
            SP++;
            return _ram[0x0100 | SP];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void PushU16(ushort val)
        {
            PushU8((byte)(val >> 8));
            PushU8((byte)(val & 0xFF));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ushort PopU16()
        {
            byte lo = PopU8();
            byte hi = PopU8();
            return (ushort)(lo | (hi << 8));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void SetZN(byte val)
        {
            P = (byte)((P & ~(FlagZ | FlagN)) | (val == 0 ? FlagZ : 0) | (val & FlagN));
        }

        // Modos de direccionamiento 6502
        [MethodImpl(MethodImplOptions.AggressiveInlining)] private ushort AddrImm() => PC++;
        [MethodImpl(MethodImplOptions.AggressiveInlining)] private ushort AddrZpg() => CpuRead(PC++);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] private ushort AddrZpx() => (byte)(CpuRead(PC++) + X);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] private ushort AddrZpy() => (byte)(CpuRead(PC++) + Y);
        [MethodImpl(MethodImplOptions.AggressiveInlining)] private ushort AddrAbs() { ushort a = ReadU16(PC); PC += 2; return a; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] private ushort AddrAbx() { ushort a = ReadU16(PC); PC += 2; return (ushort)(a + X); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] private ushort AddrAby() { ushort a = ReadU16(PC); PC += 2; return (ushort)(a + Y); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] private ushort AddrInx() { byte zp = (byte)(CpuRead(PC++) + X); return ReadU16ZeroPage(zp); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)] private ushort AddrIny() { byte zp = CpuRead(PC++); return (ushort)(ReadU16ZeroPage(zp) + Y); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void BranchIf(bool cond)
        {
            sbyte rel = (sbyte)CpuRead(PC++);
            if (cond)
            {
                PC = (ushort)(PC + rel);
                TotalCycles += 1;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Adc(byte m)
        {
            int c = (P & FlagC) != 0 ? 1 : 0;
            int sum = A + m + c;
            bool overflow = (~(A ^ m) & (A ^ sum) & 0x80) != 0;
            P = (byte)(P & ~(FlagC | FlagV | FlagZ | FlagN));
            if (sum > 0xFF) P |= FlagC;
            if (overflow) P |= FlagV;
            A = (byte)sum;
            SetZN(A);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Sbc(byte m) => Adc((byte)~m);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Cmp(byte reg, byte m)
        {
            int diff = reg - m;
            P = (byte)((P & ~FlagC) | (reg >= m ? FlagC : 0));
            SetZN((byte)diff);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte Asl(byte val)
        {
            P = (byte)((P & ~FlagC) | ((val >> 7) & FlagC));
            byte res = (byte)(val << 1);
            SetZN(res);
            return res;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte Lsr(byte val)
        {
            P = (byte)((P & ~FlagC) | (val & FlagC));
            byte res = (byte)(val >> 1);
            SetZN(res);
            return res;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte Rol(byte val)
        {
            int oldC = P & FlagC;
            P = (byte)((P & ~FlagC) | ((val >> 7) & FlagC));
            byte res = (byte)((val << 1) | oldC);
            SetZN(res);
            return res;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte Ror(byte val)
        {
            int oldC = (P & FlagC) << 7;
            P = (byte)((P & ~FlagC) | (val & FlagC));
            byte res = (byte)((val >> 1) | oldC);
            SetZN(res);
            return res;
        }

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public void StepInstruction()
        {
            // Fast-path para el bucle infinito de espera de NMI en Start_RESET ($807F: JMP $807F)
            if (PC == 0x807F)
            {
                TotalCycles += 3;
                return;
            }

            byte op = CpuRead(PC++);
            switch (op)
            {
                // LDA
                case 0xA9: A = CpuRead(AddrImm()); SetZN(A); TotalCycles += 2; break;
                case 0xA5: A = _ram[AddrZpg()]; SetZN(A); TotalCycles += 3; break;
                case 0xB5: A = _ram[AddrZpx()]; SetZN(A); TotalCycles += 4; break;
                case 0xAD: A = CpuRead(AddrAbs()); SetZN(A); TotalCycles += 4; break;
                case 0xBD: A = CpuRead(AddrAbx()); SetZN(A); TotalCycles += 4; break;
                case 0xB9: A = CpuRead(AddrAby()); SetZN(A); TotalCycles += 4; break;
                case 0xA1: A = CpuRead(AddrInx()); SetZN(A); TotalCycles += 6; break;
                case 0xB1: A = CpuRead(AddrIny()); SetZN(A); TotalCycles += 5; break;

                // LDX
                case 0xA2: X = CpuRead(AddrImm()); SetZN(X); TotalCycles += 2; break;
                case 0xA6: X = _ram[AddrZpg()]; SetZN(X); TotalCycles += 3; break;
                case 0xB6: X = _ram[AddrZpy()]; SetZN(X); TotalCycles += 4; break;
                case 0xAE: X = CpuRead(AddrAbs()); SetZN(X); TotalCycles += 4; break;
                case 0xBE: X = CpuRead(AddrAby()); SetZN(X); TotalCycles += 4; break;

                // LDY
                case 0xA0: Y = CpuRead(AddrImm()); SetZN(Y); TotalCycles += 2; break;
                case 0xA4: Y = _ram[AddrZpg()]; SetZN(Y); TotalCycles += 3; break;
                case 0xB4: Y = _ram[AddrZpx()]; SetZN(Y); TotalCycles += 4; break;
                case 0xAC: Y = CpuRead(AddrAbs()); SetZN(Y); TotalCycles += 4; break;
                case 0xBC: Y = CpuRead(AddrAbx()); SetZN(Y); TotalCycles += 4; break;

                // STA
                case 0x85: _ram[AddrZpg()] = A; TotalCycles += 3; break;
                case 0x95: _ram[AddrZpx()] = A; TotalCycles += 4; break;
                case 0x8D: CpuWrite(AddrAbs(), A); TotalCycles += 4; break;
                case 0x9D: CpuWrite(AddrAbx(), A); TotalCycles += 5; break;
                case 0x99: CpuWrite(AddrAby(), A); TotalCycles += 5; break;
                case 0x81: CpuWrite(AddrInx(), A); TotalCycles += 6; break;
                case 0x91: CpuWrite(AddrIny(), A); TotalCycles += 6; break;

                // STX
                case 0x86: _ram[AddrZpg()] = X; TotalCycles += 3; break;
                case 0x96: _ram[AddrZpy()] = X; TotalCycles += 4; break;
                case 0x8E: CpuWrite(AddrAbs(), X); TotalCycles += 4; break;

                // STY
                case 0x84: _ram[AddrZpg()] = Y; TotalCycles += 3; break;
                case 0x94: _ram[AddrZpx()] = Y; TotalCycles += 4; break;
                case 0x8C: CpuWrite(AddrAbs(), Y); TotalCycles += 4; break;

                // Transferencias de registro
                case 0xAA: X = A; SetZN(X); TotalCycles += 2; break;
                case 0xA8: Y = A; SetZN(Y); TotalCycles += 2; break;
                case 0x8A: A = X; SetZN(A); TotalCycles += 2; break;
                case 0x98: A = Y; SetZN(A); TotalCycles += 2; break;
                case 0xBA: X = SP; SetZN(X); TotalCycles += 2; break;
                case 0x9A: SP = X; TotalCycles += 2; break;

                // Pila (PHA, PLA, PHP, PLP)
                case 0x48: PushU8(A); TotalCycles += 3; break;
                case 0x68: A = PopU8(); SetZN(A); TotalCycles += 4; break;
                case 0x08: PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; break;
                case 0x28: P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; break;

                // AND
                case 0x29: A &= CpuRead(AddrImm()); SetZN(A); TotalCycles += 2; break;
                case 0x25: A &= _ram[AddrZpg()]; SetZN(A); TotalCycles += 3; break;
                case 0x35: A &= _ram[AddrZpx()]; SetZN(A); TotalCycles += 4; break;
                case 0x2D: A &= CpuRead(AddrAbs()); SetZN(A); TotalCycles += 4; break;
                case 0x3D: A &= CpuRead(AddrAbx()); SetZN(A); TotalCycles += 4; break;
                case 0x39: A &= CpuRead(AddrAby()); SetZN(A); TotalCycles += 4; break;
                case 0x21: A &= CpuRead(AddrInx()); SetZN(A); TotalCycles += 6; break;
                case 0x31: A &= CpuRead(AddrIny()); SetZN(A); TotalCycles += 5; break;

                // ORA
                case 0x09: A |= CpuRead(AddrImm()); SetZN(A); TotalCycles += 2; break;
                case 0x05: A |= _ram[AddrZpg()]; SetZN(A); TotalCycles += 3; break;
                case 0x15: A |= _ram[AddrZpx()]; SetZN(A); TotalCycles += 4; break;
                case 0x0D: A |= CpuRead(AddrAbs()); SetZN(A); TotalCycles += 4; break;
                case 0x1D: A |= CpuRead(AddrAbx()); SetZN(A); TotalCycles += 4; break;
                case 0x19: A |= CpuRead(AddrAby()); SetZN(A); TotalCycles += 4; break;
                case 0x01: A |= CpuRead(AddrInx()); SetZN(A); TotalCycles += 6; break;
                case 0x11: A |= CpuRead(AddrIny()); SetZN(A); TotalCycles += 5; break;

                // EOR
                case 0x49: A ^= CpuRead(AddrImm()); SetZN(A); TotalCycles += 2; break;
                case 0x45: A ^= _ram[AddrZpg()]; SetZN(A); TotalCycles += 3; break;
                case 0x55: A ^= _ram[AddrZpx()]; SetZN(A); TotalCycles += 4; break;
                case 0x4D: A ^= CpuRead(AddrAbs()); SetZN(A); TotalCycles += 4; break;
                case 0x5D: A ^= CpuRead(AddrAbx()); SetZN(A); TotalCycles += 4; break;
                case 0x59: A ^= CpuRead(AddrAby()); SetZN(A); TotalCycles += 4; break;
                case 0x41: A ^= CpuRead(AddrInx()); SetZN(A); TotalCycles += 6; break;
                case 0x51: A ^= CpuRead(AddrIny()); SetZN(A); TotalCycles += 5; break;

                // BIT (Incluye el truco 0x2C BIT $xxxx muy usado en SMB1)
                case 0x24:
                {
                    byte m = _ram[AddrZpg()];
                    P = (byte)((P & ~(FlagZ | FlagV | FlagN)) | ((A & m) == 0 ? FlagZ : 0) | (m & (FlagV | FlagN)));
                    TotalCycles += 3;
                    break;
                }
                case 0x2C:
                {
                    byte m = CpuRead(AddrAbs());
                    P = (byte)((P & ~(FlagZ | FlagV | FlagN)) | ((A & m) == 0 ? FlagZ : 0) | (m & (FlagV | FlagN)));
                    TotalCycles += 4;
                    break;
                }

                // ADC
                case 0x69: Adc(CpuRead(AddrImm())); TotalCycles += 2; break;
                case 0x65: Adc(_ram[AddrZpg()]); TotalCycles += 3; break;
                case 0x75: Adc(_ram[AddrZpx()]); TotalCycles += 4; break;
                case 0x6D: Adc(CpuRead(AddrAbs())); TotalCycles += 4; break;
                case 0x7D: Adc(CpuRead(AddrAbx())); TotalCycles += 4; break;
                case 0x79: Adc(CpuRead(AddrAby())); TotalCycles += 4; break;
                case 0x61: Adc(CpuRead(AddrInx())); TotalCycles += 6; break;
                case 0x71: Adc(CpuRead(AddrIny())); TotalCycles += 5; break;

                // SBC
                case 0xE9: Sbc(CpuRead(AddrImm())); TotalCycles += 2; break;
                case 0xE5: Sbc(_ram[AddrZpg()]); TotalCycles += 3; break;
                case 0xF5: Sbc(_ram[AddrZpx()]); TotalCycles += 4; break;
                case 0xED: Sbc(CpuRead(AddrAbs())); TotalCycles += 4; break;
                case 0xFD: Sbc(CpuRead(AddrAbx())); TotalCycles += 4; break;
                case 0xF9: Sbc(CpuRead(AddrAby())); TotalCycles += 4; break;
                case 0xE1: Sbc(CpuRead(AddrInx())); TotalCycles += 6; break;
                case 0xF1: Sbc(CpuRead(AddrIny())); TotalCycles += 5; break;

                // CMP, CPX, CPY
                case 0xC9: Cmp(A, CpuRead(AddrImm())); TotalCycles += 2; break;
                case 0xC5: Cmp(A, _ram[AddrZpg()]); TotalCycles += 3; break;
                case 0xD5: Cmp(A, _ram[AddrZpx()]); TotalCycles += 4; break;
                case 0xCD: Cmp(A, CpuRead(AddrAbs())); TotalCycles += 4; break;
                case 0xDD: Cmp(A, CpuRead(AddrAbx())); TotalCycles += 4; break;
                case 0xD9: Cmp(A, CpuRead(AddrAby())); TotalCycles += 4; break;
                case 0xC1: Cmp(A, CpuRead(AddrInx())); TotalCycles += 6; break;
                case 0xD1: Cmp(A, CpuRead(AddrIny())); TotalCycles += 5; break;

                case 0xE0: Cmp(X, CpuRead(AddrImm())); TotalCycles += 2; break;
                case 0xE4: Cmp(X, _ram[AddrZpg()]); TotalCycles += 3; break;
                case 0xEC: Cmp(X, CpuRead(AddrAbs())); TotalCycles += 4; break;

                case 0xC0: Cmp(Y, CpuRead(AddrImm())); TotalCycles += 2; break;
                case 0xC4: Cmp(Y, _ram[AddrZpg()]); TotalCycles += 3; break;
                case 0xCC: Cmp(Y, CpuRead(AddrAbs())); TotalCycles += 4; break;

                // INC, DEC, INX, DEX, INY, DEY
                case 0xE6: { ushort a = AddrZpg(); byte v = (byte)(_ram[a] + 1); _ram[a] = v; SetZN(v); TotalCycles += 5; break; }
                case 0xF6: { ushort a = AddrZpx(); byte v = (byte)(_ram[a] + 1); _ram[a] = v; SetZN(v); TotalCycles += 6; break; }
                case 0xEE: { ushort a = AddrAbs(); byte v = (byte)(CpuRead(a) + 1); CpuWrite(a, v); SetZN(v); TotalCycles += 6; break; }
                case 0xFE: { ushort a = AddrAbx(); byte v = (byte)(CpuRead(a) + 1); CpuWrite(a, v); SetZN(v); TotalCycles += 7; break; }

                case 0xC6: { ushort a = AddrZpg(); byte v = (byte)(_ram[a] - 1); _ram[a] = v; SetZN(v); TotalCycles += 5; break; }
                case 0xD6: { ushort a = AddrZpx(); byte v = (byte)(_ram[a] - 1); _ram[a] = v; SetZN(v); TotalCycles += 6; break; }
                case 0xCE: { ushort a = AddrAbs(); byte v = (byte)(CpuRead(a) - 1); CpuWrite(a, v); SetZN(v); TotalCycles += 6; break; }
                case 0xDE: { ushort a = AddrAbx(); byte v = (byte)(CpuRead(a) - 1); CpuWrite(a, v); SetZN(v); TotalCycles += 7; break; }

                case 0xE8: X++; SetZN(X); TotalCycles += 2; break;
                case 0xCA: X--; SetZN(X); TotalCycles += 2; break;
                case 0xC8: Y++; SetZN(Y); TotalCycles += 2; break;
                case 0x88: Y--; SetZN(Y); TotalCycles += 2; break;

                // ASL, LSR, ROL, ROR
                case 0x0A: A = Asl(A); TotalCycles += 2; break;
                case 0x06: { ushort a = AddrZpg(); _ram[a] = Asl(_ram[a]); TotalCycles += 5; break; }
                case 0x16: { ushort a = AddrZpx(); _ram[a] = Asl(_ram[a]); TotalCycles += 6; break; }
                case 0x0E: { ushort a = AddrAbs(); CpuWrite(a, Asl(CpuRead(a))); TotalCycles += 6; break; }
                case 0x1E: { ushort a = AddrAbx(); CpuWrite(a, Asl(CpuRead(a))); TotalCycles += 7; break; }

                case 0x4A: A = Lsr(A); TotalCycles += 2; break;
                case 0x46: { ushort a = AddrZpg(); _ram[a] = Lsr(_ram[a]); TotalCycles += 5; break; }
                case 0x56: { ushort a = AddrZpx(); _ram[a] = Lsr(_ram[a]); TotalCycles += 6; break; }
                case 0x4E: { ushort a = AddrAbs(); CpuWrite(a, Lsr(CpuRead(a))); TotalCycles += 6; break; }
                case 0x5E: { ushort a = AddrAbx(); CpuWrite(a, Lsr(CpuRead(a))); TotalCycles += 7; break; }

                case 0x2A: A = Rol(A); TotalCycles += 2; break;
                case 0x26: { ushort a = AddrZpg(); _ram[a] = Rol(_ram[a]); TotalCycles += 5; break; }
                case 0x36: { ushort a = AddrZpx(); _ram[a] = Rol(_ram[a]); TotalCycles += 6; break; }
                case 0x2E: { ushort a = AddrAbs(); CpuWrite(a, Rol(CpuRead(a))); TotalCycles += 6; break; }
                case 0x3E: { ushort a = AddrAbx(); CpuWrite(a, Rol(CpuRead(a))); TotalCycles += 7; break; }

                case 0x6A: A = Ror(A); TotalCycles += 2; break;
                case 0x66: { ushort a = AddrZpg(); _ram[a] = Ror(_ram[a]); TotalCycles += 5; break; }
                case 0x76: { ushort a = AddrZpx(); _ram[a] = Ror(_ram[a]); TotalCycles += 6; break; }
                case 0x6E: { ushort a = AddrAbs(); CpuWrite(a, Ror(CpuRead(a))); TotalCycles += 6; break; }
                case 0x7E: { ushort a = AddrAbx(); CpuWrite(a, Ror(CpuRead(a))); TotalCycles += 7; break; }

                // Saltos y Subrutinas (JMP, JSR, RTS, RTI, BRK)
                case 0x4C: PC = AddrAbs(); TotalCycles += 3; break;
                case 0x6C:
                {
                    // JMP ($xxxx) - Usado en JumpEngine ($8E16: JMP ($0006))
                    ushort ptr = AddrAbs();
                    byte lo = CpuRead(ptr);
                    byte hi = CpuRead((ptr & 0xFF00) | ((ptr + 1) & 0x00FF));
                    PC = (ushort)(lo | (hi << 8));
                    TotalCycles += 5;
                    break;
                }
                case 0x20:
                {
                    ushort target = AddrAbs();
                    PushU16((ushort)(PC - 1));
                    PC = target;
                    TotalCycles += 6;
                    break;
                }
                case 0x60: PC = (ushort)(PopU16() + 1); TotalCycles += 6; break;
                case 0x40: P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); TotalCycles += 6; break;
                case 0x00:
                {
                    PC++;
                    PushU16(PC);
                    PushU8((byte)(P | FlagB | FlagU));
                    P |= FlagI;
                    PC = ReadU16(VectorIrq);
                    TotalCycles += 7;
                    break;
                }

                // Ramificaciones condicionales
                case 0x10: BranchIf((P & FlagN) == 0); TotalCycles += 2; break; // BPL
                case 0x30: BranchIf((P & FlagN) != 0); TotalCycles += 2; break; // BMI
                case 0x50: BranchIf((P & FlagV) == 0); TotalCycles += 2; break; // BVC
                case 0x70: BranchIf((P & FlagV) != 0); TotalCycles += 2; break; // BVS
                case 0x90: BranchIf((P & FlagC) == 0); TotalCycles += 2; break; // BCC
                case 0xB0: BranchIf((P & FlagC) != 0); TotalCycles += 2; break; // BCS
                case 0xD0: BranchIf((P & FlagZ) == 0); TotalCycles += 2; break; // BNE
                case 0xF0: BranchIf((P & FlagZ) != 0); TotalCycles += 2; break; // BEQ

                // Flags
                case 0x18: P &= unchecked((byte)~FlagC); TotalCycles += 2; break; // CLC
                case 0x38: P |= FlagC; TotalCycles += 2; break;                   // SEC
                case 0x58: P &= unchecked((byte)~FlagI); TotalCycles += 2; break; // CLI
                case 0x78: P |= FlagI; TotalCycles += 2; break;                   // SEI
                case 0xB8: P &= unchecked((byte)~FlagV); TotalCycles += 2; break; // CLV
                case 0xD8: P &= unchecked((byte)~FlagD); TotalCycles += 2; break; // CLD
                case 0xF8: P |= FlagD; TotalCycles += 2; break;                   // SED

                // NOP
                default:
                    TotalCycles += 2;
                    break;
            }
        }
    }
}
