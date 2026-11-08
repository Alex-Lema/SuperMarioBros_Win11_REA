using System;
using System.Runtime.CompilerServices;

namespace SuperMarioBros_Win11.Core
{
    /// <summary>
    /// Modelo de Memoria Interna de 2 KB ($0000..$07FF) conforme a la especificación
    /// de DOC_DISENO_PORT_WIN11_ARQUITECTURA.md (Sección 3.1).
    /// </summary>
    public sealed class SmbMemory
    {
        public const int RamSize = 0x0800;
        public readonly byte[] Raw = new byte[RamSize];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte Read(int address) => Raw[address & 0x07FF];

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Write(int address, byte value) => Raw[address & 0x07FF] = value;

        // Variables simbólicas clave documentadas en Volumen 1 (Sección 3.1)
        public byte FrameCounter
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Raw[0x0009];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x0009] = value;
        }

        public byte GameEngineSubroutine
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Raw[0x000E];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x000E] = value;
        }

        public byte Player_State
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Raw[0x001D];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x001D] = value;
        }

        public sbyte Player_X_Speed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (sbyte)Raw[0x0057];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x0057] = (byte)value;
        }

        public byte Player_PageLoc
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Raw[0x006D];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x006D] = value;
        }

        public byte Player_X_Position
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Raw[0x0086];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x0086] = value;
        }

        public sbyte Player_Y_Speed
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => (sbyte)Raw[0x009F];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x009F] = (byte)value;
        }

        public byte Player_Y_HighPos
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Raw[0x00B5];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x00B5] = value;
        }

        public byte Player_Y_Position
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Raw[0x00CE];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x00CE] = value;
        }

        // Colas de disparo de sonido ($00FA..$00FF)
        public byte PauseSoundQueue   { get => Raw[0x00FA]; set => Raw[0x00FA] = value; }
        public byte AreaMusicQueue    { get => Raw[0x00FB]; set => Raw[0x00FB] = value; }
        public byte EventMusicQueue   { get => Raw[0x00FC]; set => Raw[0x00FC] = value; }
        public byte NoiseSoundQueue   { get => Raw[0x00FD]; set => Raw[0x00FD] = value; }
        public byte Square2SoundQueue { get => Raw[0x00FE]; set => Raw[0x00FE] = value; }
        public byte Square1SoundQueue { get => Raw[0x00FF]; set => Raw[0x00FF] = value; }

        // Mandos ($06FC..$06FD)
        public byte SavedJoypad1Bits
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Raw[0x06FC];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x06FC] = value;
        }

        public byte SavedJoypad2Bits
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)] get => Raw[0x06FD];
            [MethodImpl(MethodImplOptions.AggressiveInlining)] set => Raw[0x06FD] = value;
        }

        // Scroll y Pantalla ($073C..$0779)
        public byte ScreenRoutineTask    { get => Raw[0x073C]; set => Raw[0x073C] = value; }
        public byte HorizontalScroll     { get => Raw[0x073F]; set => Raw[0x073F] = value; }
        public byte VerticalScroll       { get => Raw[0x0740]; set => Raw[0x0740] = value; }
        public byte AreaType             { get => Raw[0x074E]; set => Raw[0x074E] = value; }
        public byte PlayerSize           { get => Raw[0x0754]; set => Raw[0x0754] = value; }
        public byte PlayerStatus         { get => Raw[0x0756]; set => Raw[0x0756] = value; }
        public sbyte NumberofLives       { get => (sbyte)Raw[0x075A]; set => Raw[0x075A] = (byte)value; }
        public byte WorldNumber          { get => Raw[0x075F]; set => Raw[0x075F] = value; }
        public byte AreaNumber           { get => Raw[0x0760]; set => Raw[0x0760] = value; }
        public byte OperMode             { get => Raw[0x0770]; set => Raw[0x0770] = value; }
        public byte OperMode_Task        { get => Raw[0x0772]; set => Raw[0x0772] = value; }
        public byte VRAM_Buffer_AddrCtrl { get => Raw[0x0773]; set => Raw[0x0773] = value; }
        public byte DisableScreenFlag    { get => Raw[0x0774]; set => Raw[0x0774] = value; }
        public byte GamePauseStatus      { get => Raw[0x0776]; set => Raw[0x0776] = value; }
        public byte Mirror_PPU_CTRL_REG1 { get => Raw[0x0778]; set => Raw[0x0778] = value; }
        public byte Mirror_PPU_CTRL_REG2 { get => Raw[0x0779]; set => Raw[0x0779] = value; }
        public byte WarmBootValidation   { get => Raw[0x07FF]; set => Raw[0x07FF] = value; }
    }
}
