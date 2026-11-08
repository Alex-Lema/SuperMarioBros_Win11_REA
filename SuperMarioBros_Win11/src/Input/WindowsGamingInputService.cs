using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SuperMarioBros_Win11.Input
{
    /// <summary>
    /// Flags exactos de Windows.Gaming.Input.GamepadButtons extraídos de Windows.Gaming.winmd.
    /// </summary>
    [Flags]
    public enum WgiGamepadButtons : uint
    {
        None            = 0x0000,
        Menu            = 0x0001, // Start
        View            = 0x0002, // Select / Back
        A               = 0x0004,
        B               = 0x0008,
        X               = 0x0010,
        Y               = 0x0020,
        DPadUp          = 0x0040,
        DPadDown        = 0x0080,
        DPadLeft        = 0x0100,
        DPadRight       = 0x0200,
        LeftShoulder    = 0x0400,
        RightShoulder   = 0x0800,
        LeftThumbstick  = 0x1000,
        RightThumbstick = 0x2000
    }

    /// <summary>
    /// Estructura ABI nativa de Windows.Gaming.Input.GamepadReading (64 bytes, alineada a 8 bytes).
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct WgiGamepadReading
    {
        public ulong Timestamp;
        public WgiGamepadButtons Buttons;
        private uint _padding;
        public double LeftTrigger;
        public double RightTrigger;
        public double LeftThumbstickX;
        public double LeftThumbstickY;
        public double RightThumbstickX;
        public double RightThumbstickY;
    }

    public enum WgiSwitchPosition : int
    {
        Center    = 0,
        Up        = 1,
        UpRight   = 2,
        Right     = 3,
        DownRight = 4,
        Down      = 5,
        DownLeft  = 6,
        Left      = 7,
        UpLeft    = 8
    }

    /// <summary>
    /// Subsistema de Entrada de Ultra-Baja Latencia basado en la librería nativa de Windows 11
    /// Windows.Gaming.Input (Windows.Gaming.Input.Gamepad + Windows.Gaming.Input.RawGameController)
    /// mediante invocación directa de vtable WinRT sin asignaciones en el heap.
    /// </summary>
    public sealed unsafe class WindowsGamingInputService : IDisposable
    {
        // Bits del registro NES $06FC / $06FD (Sección 6 de DOC_DISENO_PORT_WIN11_ARQUITECTURA.md)
        public const byte NesBitA      = 0x80;
        public const byte NesBitB      = 0x40;
        public const byte NesBitSelect = 0x20;
        public const byte NesBitStart  = 0x10;
        public const byte NesBitUp     = 0x08;
        public const byte NesBitDown   = 0x04;
        public const byte NesBitLeft   = 0x02;
        public const byte NesBitRight  = 0x01;

        // GUIDs extraídos directamente de C:\Windows\System32\WinMetadata\Windows.Gaming.winmd
        private static readonly Guid IID_IGamepadStatics = new Guid("8bbce529-d49c-39e9-9560-e47dde96b7c8");
        private static readonly Guid IID_IGamepad = new Guid("bc7bb43c-0a69-3903-9e9d-a50f86a45de5");
        private static readonly Guid IID_IRawGameControllerStatics = new Guid("eb8d0792-e95a-4b19-afc7-0a59f8bf759e");
        private static readonly Guid IID_IRawGameController = new Guid("7cad6d91-a7e1-4f71-9a78-33e9c5dfea62");

        [DllImport("combase.dll", ExactSpelling = true)]
        private static extern int RoInitialize(int initType);

        [DllImport("combase.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int WindowsCreateString(string sourceString, uint length, out IntPtr hstring);

        [DllImport("combase.dll", ExactSpelling = true)]
        private static extern int WindowsDeleteString(IntPtr hstring);

        [DllImport("combase.dll", ExactSpelling = true)]
        private static extern int RoGetActivationFactory(IntPtr activatableClassId, ref Guid iid, out IntPtr factory);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern short GetAsyncKeyState(int vKey);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();

        private IntPtr _gamepadStaticsPtr;
        private IntPtr _rawControllerStaticsPtr;
        private bool _wgiInitialized;

        // Estado en tiempo real de mandos y teclado
        public int ConnectedGamepadCount { get; private set; }
        public int ConnectedRawControllerCount { get; private set; }
        public string ActiveControllerSummary { get; private set; } = "Windows.Gaming.Input activo (Esperando mando / Teclado listo)";
        public byte Player1State { get; private set; }
        public byte Player2State { get; private set; }
        public double AnalogDeadzone { get; set; } = 0.24;

        // Registros de desplazamiento serie ($4016 / $4017) de la NES
        private byte _strobeLatch;
        private byte _shiftRegP1;
        private byte _shiftRegP2;

        public WindowsGamingInputService()
        {
            InitializeWindowsGamingInput();
        }

        private void InitializeWindowsGamingInput()
        {
            try
            {
                // RO_INIT_MULTITHREADED = 1 (si el hilo ya es STA devuelve RPC_E_CHANGED_MODE, lo cual es válido)
                RoInitialize(1);

                // 1. Activar Windows.Gaming.Input.Gamepad (IGamepadStatics)
                const string gamepadClass = "Windows.Gaming.Input.Gamepad";
                if (WindowsCreateString(gamepadClass, (uint)gamepadClass.Length, out IntPtr hsGamepad) >= 0)
                {
                    Guid iid = IID_IGamepadStatics;
                    int hr = RoGetActivationFactory(hsGamepad, ref iid, out _gamepadStaticsPtr);
                    WindowsDeleteString(hsGamepad);
                    if (hr >= 0 && _gamepadStaticsPtr != IntPtr.Zero)
                    {
                        _wgiInitialized = true;
                    }
                }

                // 2. Activar Windows.Gaming.Input.RawGameController (IRawGameControllerStatics)
                const string rawClass = "Windows.Gaming.Input.RawGameController";
                if (WindowsCreateString(rawClass, (uint)rawClass.Length, out IntPtr hsRaw) >= 0)
                {
                    Guid iid = IID_IRawGameControllerStatics;
                    RoGetActivationFactory(hsRaw, ref iid, out _rawControllerStaticsPtr);
                    WindowsDeleteString(hsRaw);
                }
            }
            catch
            {
                _wgiInitialized = false;
            }
        }

        /// <summary>
        /// Muestrea instantáneamente los controladores Windows.Gaming.Input y el teclado Win32
        /// justo antes de iniciar el tick de simulación para minimizar el lag de entrada (< 1 us).
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public void PollMinimalLatencyInput(IntPtr mainWindowHandle)
        {
            byte p1 = 0;
            byte p2 = 0;

            // 1. Lectura de Windows.Gaming.Input.Gamepad (IGamepadStatics -> get_Gamepads -> GetCurrentReading)
            int gamepadCount = 0;
            if (_gamepadStaticsPtr != IntPtr.Zero)
            {
                void** staticsVtbl = *(void***)_gamepadStaticsPtr;
                // Slot 10 de IGamepadStatics: get_Gamepads(out IVectorView<Gamepad>)
                var getGamepads = (delegate* unmanaged[Stdcall]<IntPtr, out IntPtr, int>)staticsVtbl[10];
                if (getGamepads(_gamepadStaticsPtr, out IntPtr vectorView) >= 0 && vectorView != IntPtr.Zero)
                {
                    void** vecVtbl = *(void***)vectorView;
                    // Slot 7 de IVectorView<T>: get_Size(out uint)
                    var getSize = (delegate* unmanaged[Stdcall]<IntPtr, out uint, int>)vecVtbl[7];
                    // Slot 6 de IVectorView<T>: GetAt(uint index, out IntPtr item)
                    var getAt = (delegate* unmanaged[Stdcall]<IntPtr, uint, out IntPtr, int>)vecVtbl[6];

                    if (getSize(vectorView, out uint count) >= 0)
                    {
                        gamepadCount = (int)count;
                        if (count > 0 && getAt(vectorView, 0, out IntPtr gp0) >= 0 && gp0 != IntPtr.Zero)
                        {
                            p1 |= ReadWgiGamepadObject(gp0);
                            ReleaseComObject(gp0);
                        }
                        if (count > 1 && getAt(vectorView, 1, out IntPtr gp1) >= 0 && gp1 != IntPtr.Zero)
                        {
                            p2 |= ReadWgiGamepadObject(gp1);
                            ReleaseComObject(gp1);
                        }
                    }
                    ReleaseComObject(vectorView);
                }
            }
            ConnectedGamepadCount = gamepadCount;

            // 2. Si no hay un Gamepad estándar en ranura 1, consultar Windows.Gaming.Input.RawGameController
            int rawCount = 0;
            if (_rawControllerStaticsPtr != IntPtr.Zero)
            {
                void** rawStaticsVtbl = *(void***)_rawControllerStaticsPtr;
                // Slot 10 de IRawGameControllerStatics: get_RawGameControllers(out IVectorView<RawGameController>)
                var getRawControllers = (delegate* unmanaged[Stdcall]<IntPtr, out IntPtr, int>)rawStaticsVtbl[10];
                if (getRawControllers(_rawControllerStaticsPtr, out IntPtr rawVec) >= 0 && rawVec != IntPtr.Zero)
                {
                    void** vecVtbl = *(void***)rawVec;
                    var getSize = (delegate* unmanaged[Stdcall]<IntPtr, out uint, int>)vecVtbl[7];
                    var getAt = (delegate* unmanaged[Stdcall]<IntPtr, uint, out IntPtr, int>)vecVtbl[6];

                    if (getSize(rawVec, out uint rCount) >= 0)
                    {
                        rawCount = (int)rCount;
                        if (gamepadCount == 0 && rCount > 0 && getAt(rawVec, 0, out IntPtr raw0) >= 0 && raw0 != IntPtr.Zero)
                        {
                            p1 |= ReadWgiRawControllerObject(raw0);
                            ReleaseComObject(raw0);
                        }
                    }
                    ReleaseComObject(rawVec);
                }
            }
            ConnectedRawControllerCount = rawCount;

            // 3. Lectura directa sin latencia del teclado cuando la ventana tiene el foco
            if (mainWindowHandle == IntPtr.Zero || GetForegroundWindow() == mainWindowHandle)
            {
                // Botón A (Saltar/Nadar): Espacio, X, K
                if (IsKeyDown(0x20) || IsKeyDown('X') || IsKeyDown('K')) p1 |= NesBitA;
                // Botón B (Correr/Fuego): Left Shift, Z, J
                if (IsKeyDown(0xA0) || IsKeyDown(0x10) || IsKeyDown('Z') || IsKeyDown('J')) p1 |= NesBitB;
                // Select: Tab, Right Shift, Backspace
                if (IsKeyDown(0x09) || IsKeyDown(0xA1) || IsKeyDown(0x08)) p1 |= NesBitSelect;
                // Start: Enter
                if (IsKeyDown(0x0D)) p1 |= NesBitStart;
                // Cruceta direccional: W/A/S/D o Flechas
                if (IsKeyDown('W') || IsKeyDown(0x26)) p1 |= NesBitUp;
                if (IsKeyDown('S') || IsKeyDown(0x28)) p1 |= NesBitDown;
                if (IsKeyDown('A') || IsKeyDown(0x25)) p1 |= NesBitLeft;
                if (IsKeyDown('D') || IsKeyDown(0x27)) p1 |= NesBitRight;

                // Impedir direcciones opuestas simultáneas (Left+Right o Up+Down)
                if ((p1 & (NesBitLeft | NesBitRight)) == (NesBitLeft | NesBitRight))
                    p1 &= unchecked((byte)~NesBitLeft);
                if ((p1 & (NesBitUp | NesBitDown)) == (NesBitUp | NesBitDown))
                    p1 &= unchecked((byte)~NesBitUp);
            }

            Player1State = p1;
            Player2State = p2;

            if ((_strobeLatch & 1) != 0)
            {
                _shiftRegP1 = Player1State;
                _shiftRegP2 = Player2State;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte ReadWgiGamepadObject(IntPtr gamepadObj)
        {
            byte result = 0;
            Guid iid = IID_IGamepad;
            void** unkVtbl = *(void***)gamepadObj;
            var qi = (delegate* unmanaged[Stdcall]<IntPtr, ref Guid, out IntPtr, int>)unkVtbl[0];

            if (qi(gamepadObj, ref iid, out IntPtr iGamepad) >= 0 && iGamepad != IntPtr.Zero)
            {
                void** gpVtbl = *(void***)iGamepad;
                // Slot 8 de IGamepad: GetCurrentReading(out WgiGamepadReading)
                var getReading = (delegate* unmanaged[Stdcall]<IntPtr, out WgiGamepadReading, int>)gpVtbl[8];
                if (getReading(iGamepad, out WgiGamepadReading reading) >= 0)
                {
                    WgiGamepadButtons btns = reading.Buttons;
                    // A o botón inferior salta; B, X o gatillos corren/disparan
                    if ((btns & (WgiGamepadButtons.A | WgiGamepadButtons.RightShoulder)) != 0)
                        result |= NesBitA;
                    if ((btns & (WgiGamepadButtons.X | WgiGamepadButtons.B | WgiGamepadButtons.Y | WgiGamepadButtons.LeftShoulder)) != 0 ||
                        reading.LeftTrigger > 0.25 || reading.RightTrigger > 0.25)
                        result |= NesBitB;
                    if ((btns & WgiGamepadButtons.View) != 0)
                        result |= NesBitSelect;
                    if ((btns & WgiGamepadButtons.Menu) != 0)
                        result |= NesBitStart;

                    // D-Pad + Stick analógico izquierdo
                    if ((btns & WgiGamepadButtons.DPadUp) != 0 || reading.LeftThumbstickY > AnalogDeadzone)
                        result |= NesBitUp;
                    if ((btns & WgiGamepadButtons.DPadDown) != 0 || reading.LeftThumbstickY < -AnalogDeadzone)
                        result |= NesBitDown;
                    if ((btns & WgiGamepadButtons.DPadLeft) != 0 || reading.LeftThumbstickX < -AnalogDeadzone)
                        result |= NesBitLeft;
                    if ((btns & WgiGamepadButtons.DPadRight) != 0 || reading.LeftThumbstickX > AnalogDeadzone)
                        result |= NesBitRight;
                }
                ReleaseComObject(iGamepad);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte ReadWgiRawControllerObject(IntPtr rawObj)
        {
            byte result = 0;
            Guid iid = IID_IRawGameController;
            void** unkVtbl = *(void***)rawObj;
            var qi = (delegate* unmanaged[Stdcall]<IntPtr, ref Guid, out IntPtr, int>)unkVtbl[0];

            if (qi(rawObj, ref iid, out IntPtr iRaw) >= 0 && iRaw != IntPtr.Zero)
            {
                void** rawVtbl = *(void***)iRaw;
                // Slot 6: get_AxisCount, Slot 7: get_ButtonCount, Slot 11: get_SwitchCount, Slot 13: GetCurrentReading
                var getAxisCount = (delegate* unmanaged[Stdcall]<IntPtr, out int, int>)rawVtbl[6];
                var getBtnCount = (delegate* unmanaged[Stdcall]<IntPtr, out int, int>)rawVtbl[7];
                var getSwCount = (delegate* unmanaged[Stdcall]<IntPtr, out int, int>)rawVtbl[11];
                var getReading = (delegate* unmanaged[Stdcall]<IntPtr, uint, byte*, uint, WgiSwitchPosition*, uint, double*, out ulong, int>)rawVtbl[13];

                getAxisCount(iRaw, out int axesLen);
                getBtnCount(iRaw, out int btnLen);
                getSwCount(iRaw, out int swLen);

                axesLen = Math.Clamp(axesLen, 0, 16);
                btnLen = Math.Clamp(btnLen, 0, 32);
                swLen = Math.Clamp(swLen, 0, 8);

                byte* btns = stackalloc byte[32];
                WgiSwitchPosition* switches = stackalloc WgiSwitchPosition[8];
                double* axes = stackalloc double[16];

                if (getReading(iRaw, (uint)btnLen, btns, (uint)swLen, switches, (uint)axesLen, axes, out _) >= 0)
                {
                    if (btnLen > 0 && (btns[0] != 0 || (btnLen > 1 && btns[1] != 0))) result |= NesBitA;
                    if (btnLen > 2 && (btns[2] != 0 || (btnLen > 3 && btns[3] != 0))) result |= NesBitB;
                    if (btnLen > 8 && btns[8] != 0) result |= NesBitSelect;
                    if (btnLen > 9 && btns[9] != 0) result |= NesBitStart;

                    if (swLen > 0)
                    {
                        WgiSwitchPosition sw = switches[0];
                        if (sw == WgiSwitchPosition.Up || sw == WgiSwitchPosition.UpLeft || sw == WgiSwitchPosition.UpRight) result |= NesBitUp;
                        if (sw == WgiSwitchPosition.Down || sw == WgiSwitchPosition.DownLeft || sw == WgiSwitchPosition.DownRight) result |= NesBitDown;
                        if (sw == WgiSwitchPosition.Left || sw == WgiSwitchPosition.UpLeft || sw == WgiSwitchPosition.DownLeft) result |= NesBitLeft;
                        if (sw == WgiSwitchPosition.Right || sw == WgiSwitchPosition.UpRight || sw == WgiSwitchPosition.DownRight) result |= NesBitRight;
                    }

                    if (axesLen >= 2)
                    {
                        double ax = (axes[0] * 2.0) - 1.0;
                        double ay = (axes[1] * 2.0) - 1.0;
                        if (ax < -AnalogDeadzone) result |= NesBitLeft;
                        if (ax > AnalogDeadzone) result |= NesBitRight;
                        if (ay < -AnalogDeadzone) result |= NesBitUp;
                        if (ay > AnalogDeadzone) result |= NesBitDown;
                    }
                }
                ReleaseComObject(iRaw);
            }
            return result;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CpuWriteStrobe(byte value)
        {
            byte prev = _strobeLatch;
            _strobeLatch = value;
            if ((prev & 1) != 0 || (value & 1) != 0)
            {
                _shiftRegP1 = Player1State;
                _shiftRegP2 = Player2State;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte CpuReadPort(int addr)
        {
            if (addr == 0x4016)
            {
                if ((_strobeLatch & 1) != 0) return (byte)((Player1State >> 7) & 1);
                byte bit = (byte)((_shiftRegP1 >> 7) & 1);
                _shiftRegP1 <<= 1;
                return bit;
            }
            if (addr == 0x4017)
            {
                if ((_strobeLatch & 1) != 0) return (byte)((Player2State >> 7) & 1);
                byte bit = (byte)((_shiftRegP2 >> 7) & 1);
                _shiftRegP2 <<= 1;
                return bit;
            }
            return 0;
        }

        public string GetStatusDescription()
        {
            if (!_wgiInitialized)
                return "Windows.Gaming.Input: No disponible | Teclado Win32 Activo";
            return $"Windows.Gaming.Input: {ConnectedGamepadCount} Gamepad(s), {ConnectedRawControllerCount} RawController(s) | Teclado Win32 Activo";
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static bool IsKeyDown(int vKey) => (GetAsyncKeyState(vKey) & 0x8000) != 0;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ReleaseComObject(IntPtr ptr)
        {
            if (ptr != IntPtr.Zero)
            {
                void** vtbl = *(void***)ptr;
                var release = (delegate* unmanaged[Stdcall]<IntPtr, uint>)vtbl[2];
                release(ptr);
            }
        }

        public void Dispose()
        {
            if (_gamepadStaticsPtr != IntPtr.Zero)
            {
                ReleaseComObject(_gamepadStaticsPtr);
                _gamepadStaticsPtr = IntPtr.Zero;
            }
            if (_rawControllerStaticsPtr != IntPtr.Zero)
            {
                ReleaseComObject(_rawControllerStaticsPtr);
                _rawControllerStaticsPtr = IntPtr.Zero;
            }
        }
    }
}
