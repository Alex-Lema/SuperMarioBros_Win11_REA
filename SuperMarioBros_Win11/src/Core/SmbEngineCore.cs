using System;
using System.Runtime.CompilerServices;
using SuperMarioBros_Win11.Audio;
using SuperMarioBros_Win11.Graphics;
using SuperMarioBros_Win11.Input;
using SuperMarioBros_Win11.Recompiled;

namespace SuperMarioBros_Win11.Core
{
    /// <summary>
    /// Motor Nativo Recompilado Estáticamente de Super Mario Bros. para Windows 11.
    /// Ejecuta directamente los bloques C# traducidos (SmbRecompiledBank_0..3) y las tablas estáticas
    /// compiladas en SmbEmbeddedAssets sin cargar ningún archivo .nes ni usar un intérprete de opcodes.
    /// </summary>
    public sealed partial class SmbEngineCore
    {
        public const ushort EntryPointReset = 0x8000;
        public const ushort EntryPointNmi = 0x8082;
        public const ushort EntryPointIrq = 0xFFF0;

        private const byte FlagC = 0x01;
        private const byte FlagZ = 0x02;
        private const byte FlagI = 0x04;
        private const byte FlagD = 0x08;
        private const byte FlagB = 0x10;
        private const byte FlagU = 0x20;
        private const byte FlagV = 0x40;
        private const byte FlagN = 0x80;

        public SmbMemory Memory { get; }
        public Ppu2C02Renderer Ppu { get; }
        public Apu2A03Synthesizer Apu { get; }
        public WindowsGamingInputService Input { get; }

        // Registros de estado de la máquina nativa traducida
        public byte A;
        public byte X;
        public byte Y;
        public byte SP;
        public byte P;
        public ushort PC;
        public long TotalCycles;

        private readonly byte[] _ram;

        public SmbEngineCore(
            SmbMemory memory,
            Ppu2C02Renderer ppu,
            Apu2A03Synthesizer apu,
            WindowsGamingInputService input)
        {
            Memory = memory;
            Ppu = ppu;
            Apu = apu;
            Input = input;
            _ram = memory.Raw;
            HardReset();
        }

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
            PC = EntryPointReset; // Start_RESET ($8000)
            TotalCycles = 0;

            RunBootSequenceToNmiEnable();
        }

        public void WarmReset()
        {
            SP = 0xFD;
            P = FlagI | FlagU;
            PC = EntryPointReset; // Start_RESET ($8000)
            RunBootSequenceToNmiEnable();
        }

        private void RunBootSequenceToNmiEnable()
        {
            for (int vblankPass = 0; vblankPass < 4 && PC != 0x807F; vblankPass++)
            {
                Ppu.BeginVBlank();
                ExecuteNativeCycles(60000);
            }
        }

        public void StepOneFrame60Hz(IntPtr windowHandle, bool savePrevFor120Hz)
        {
            if (savePrevFor120Hz)
            {
                Ppu.SaveStateFor120HzInterpolation();
            }

            // 1. Muestreo de entrada de mínima latencia con Windows.Gaming.Input + Teclado
            Input.PollMinimalLatencyInput(windowHandle);

            // 2. Periodo VBlank (20 scanlines) -> dispara NonMaskableInterrupt_NMI ($8082)
            Ppu.BeginVBlank();
            if (Ppu.NmiPending)
            {
                Ppu.NmiPending = false;
                TriggerNmi();
            }
            ExecuteNativeCycles(2273);
            Apu.StepFrameCounterQuarter(isHalfFrame: false);

            // 3. Scanline Pre-Render (261)
            Ppu.EndVBlankAndPreRender();
            ExecuteNativeCycles(114);

            // 4. Scanlines Visibles 0..239 (sincronización de Split-Screen Sprite 0 en scanline 30/31)
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

                ExecuteNativeCycles(cyclesThisLine);

                if (scanline == 79) Apu.StepFrameCounterQuarter(isHalfFrame: true);
                else if (scanline == 159) Apu.StepFrameCounterQuarter(isHalfFrame: false);
                else if (scanline == 239) Apu.StepFrameCounterQuarter(isHalfFrame: true);
            }

            // 5. Componer Framebuffers PPU (60 Hz nativo y 120 Hz interpolado)
            if (savePrevFor120Hz)
            {
                Ppu.ComposeFrame(isInterpolated120HzSubFrame: true);
            }
            Ppu.ComposeFrame(isInterpolated120HzSubFrame: false);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void ExecuteNativeCycles(int cyclesToRun)
        {
            long target = TotalCycles + cyclesToRun;
            while (TotalCycles < target)
            {
                if (Ppu.NmiPending)
                {
                    Ppu.NmiPending = false;
                    TriggerNmi();
                }

                // Despacho directo a los 4 bloques C# recompilados estáticamente
                switch (PC >> 13)
                {
                    case 4: ExecuteNativeBlock_8000_9FFF(target); break;
                    case 5: ExecuteNativeBlock_A000_BFFF(target); break;
                    case 6: ExecuteNativeBlock_C000_DFFF(target); break;
                    case 7: ExecuteNativeBlock_E000_FFFF(target); break;
                    default:
                        throw new InvalidOperationException($"PC fuera de rango de código nativo: 0x{PC:X4}");
                }
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void TriggerNmi()
        {
            PushU16(PC);
            PushU8((byte)((P & ~FlagB) | FlagU));
            P |= FlagI;
            PC = EntryPointNmi; // $8082 (NonMaskableInterrupt_NMI)
            TotalCycles += 7;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte ReadIoReg(int addr)
        {
            if (addr < 0x4000) return Ppu.CpuReadRegister(addr);
            if (addr == 0x4016 || addr == 0x4017) return Input.CpuReadPort(addr);
            return 0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void WriteIoReg(int addr, byte val)
        {
            if (addr < 0x4000)
            {
                Ppu.CpuWriteRegister(addr, val);
                return;
            }
            if (addr == 0x4014)
            {
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
        private byte ReadMem(int addr)
        {
            addr &= 0xFFFF;
            if (addr < 0x2000) return _ram[addr & 0x07FF];
            if (addr >= 0x8000) return SmbEmbeddedAssets.StaticDataTables[addr - 0x8000];
            return ReadIoReg(addr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void WriteMem(int addr, byte val)
        {
            addr &= 0xFFFF;
            if (addr < 0x2000)
            {
                _ram[addr & 0x07FF] = val;
                return;
            }
            WriteIoReg(addr, val);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private ushort ReadU16Zp(byte zpAddr)
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

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void Bit(byte m)
        {
            P = (byte)((P & ~(FlagZ | FlagV | FlagN)) | ((A & m) == 0 ? FlagZ : 0) | (m & (FlagV | FlagN)));
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
        private byte IncVal(byte val)
        {
            byte res = (byte)(val + 1);
            SetZN(res);
            return res;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte DecVal(byte val)
        {
            byte res = (byte)(val - 1);
            SetZN(res);
            return res;
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
    }
}
