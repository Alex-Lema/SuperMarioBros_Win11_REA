using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using SuperMarioBros_Win11.Core;
using SuperMarioBros_Win11.Graphics;

namespace SuperMarioBros_Win11.Platform
{
    /// <summary>
    /// Detector de Capacidades de Hardware y Pantalla de Windows 11.
    /// Verifica resoluciones nativas y determina si el ordenador/monitor permite la ejecución real a 120 FPS.
    /// </summary>
    public sealed class HardwareCapabilities
    {
        private const int DESKTOPVERTRES = 117;
        private const int DESKTOPHORZRES = 118;
        private const int VREFRESH = 116;
        private const int ENUM_CURRENT_SETTINGS = -1;

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", ExactSpelling = true)]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", ExactSpelling = true)]
        private static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern bool EnumDisplaySettingsW(IntPtr lpszDeviceName, int iModeNum, IntPtr lpDevMode);

        public int DesktopWidth { get; private set; } = 1920;
        public int DesktopHeight { get; private set; } = 1080;
        public int CurrentRefreshRateHz { get; private set; } = 60;
        public int MaxMonitorRefreshRateHz { get; private set; } = 60;
        public int TotalDisplayModesEnumerated { get; private set; }
        public double BenchmarkPotentialFps { get; private set; }
        public bool HighResolutionTimerAvailable { get; private set; }

        /// <summary>
        /// Indica si el ordenador (monitor + subsistema gráfico + CPU) permite la ejecución a 120 FPS.
        /// </summary>
        public bool Supports120Fps { get; private set; }
        public string CapabilityDiagnosticSummary { get; private set; }

        public static HardwareCapabilities Detect(SmbEngineCore engineForBenchmark, string[] commandLineArgs)
        {
            var caps = new HardwareCapabilities();
            caps.HighResolutionTimerAvailable = Stopwatch.IsHighResolution;

            // 1. Consultar resolución física y frecuencia actual vía GDI GetDeviceCaps
            IntPtr hdc = GetDC(IntPtr.Zero);
            if (hdc != IntPtr.Zero)
            {
                int w = GetDeviceCaps(hdc, DESKTOPHORZRES);
                int h = GetDeviceCaps(hdc, DESKTOPVERTRES);
                int hz = GetDeviceCaps(hdc, VREFRESH);
                ReleaseDC(IntPtr.Zero, hdc);

                if (w >= 640) caps.DesktopWidth = w;
                if (h >= 480) caps.DesktopHeight = h;
                if (hz > 0)
                {
                    caps.CurrentRefreshRateHz = hz;
                    caps.MaxMonitorRefreshRateHz = hz;
                }
            }

            // 2. Enumerar todos los modos de pantalla soportados por el hardware (DEVMODEW = 220 bytes)
            IntPtr devModePtr = Marshal.AllocHGlobal(512);
            try
            {
                for (int i = 0; i < 512; i++) Marshal.WriteByte(devModePtr, i, 0);
                Marshal.WriteInt16(devModePtr, 68, 220); // dmSize = 220 en offset 68 de DEVMODEW

                if (EnumDisplaySettingsW(IntPtr.Zero, ENUM_CURRENT_SETTINGS, devModePtr))
                {
                    int curW = Marshal.ReadInt32(devModePtr, 172);  // dmPelsWidth
                    int curH = Marshal.ReadInt32(devModePtr, 176);  // dmPelsHeight
                    int curHz = Marshal.ReadInt32(devModePtr, 184); // dmDisplayFrequency
                    if (curW >= 640) caps.DesktopWidth = curW;
                    if (curH >= 480) caps.DesktopHeight = curH;
                    if (curHz > 0) caps.CurrentRefreshRateHz = curHz;
                    if (curHz > caps.MaxMonitorRefreshRateHz) caps.MaxMonitorRefreshRateHz = curHz;
                }

                int modeIdx = 0;
                while (EnumDisplaySettingsW(IntPtr.Zero, modeIdx, devModePtr))
                {
                    int modeHz = Marshal.ReadInt32(devModePtr, 184);
                    if (modeHz > caps.MaxMonitorRefreshRateHz && modeHz <= 500)
                    {
                        caps.MaxMonitorRefreshRateHz = modeHz;
                    }
                    modeIdx++;
                }
                caps.TotalDisplayModesEnumerated = modeIdx;
            }
            finally
            {
                Marshal.FreeHGlobal(devModePtr);
            }

            // 3. Micro-benchmark real de CPU + Escalado HD (con calentamiento previo de JIT)
            uint[] benchHighRes = new uint[1280 * 720];
            for (int w = 0; w < 2; w++)
            {
                engineForBenchmark.Ppu.ComposeFrame(isInterpolated120HzSubFrame: false);
                engineForBenchmark.Ppu.UpscaleToHighResBuffer(
                    engineForBenchmark.Ppu.Framebuffer60Hz,
                    benchHighRes,
                    1280,
                    720,
                    AspectScaleMode.Aspect4x3Pillarbox,
                    crtScanlinesEffect: false);
            }
            var sw = Stopwatch.StartNew();
            const int benchFrames = 6;
            for (int i = 0; i < benchFrames; i++)
            {
                engineForBenchmark.Ppu.ComposeFrame(isInterpolated120HzSubFrame: false);
                engineForBenchmark.Ppu.UpscaleToHighResBuffer(
                    engineForBenchmark.Ppu.Framebuffer60Hz,
                    benchHighRes,
                    1280,
                    720,
                    AspectScaleMode.Aspect4x3Pillarbox,
                    crtScanlinesEffect: false);
            }
            sw.Stop();
            double avgFrameMs = Math.Max(0.1, sw.Elapsed.TotalMilliseconds / benchFrames);
            caps.BenchmarkPotentialFps = Math.Round(1000.0 / avgFrameMs, 1);

            bool forceSimulate120Hz = false;
            if (commandLineArgs != null)
            {
                foreach (string arg in commandLineArgs)
                {
                    if (string.Equals(arg, "--simulate-120hz", StringComparison.OrdinalIgnoreCase))
                        forceSimulate120Hz = true;
                }
            }

            // El ordenador permite 120 FPS reales si el panel soporta >=120 Hz y la CPU/GPU sostiene >=140 FPS en el benchmark
            caps.Supports120Fps = forceSimulate120Hz ||
                                  (caps.MaxMonitorRefreshRateHz >= 120 &&
                                   caps.BenchmarkPotentialFps >= 140.0 &&
                                   caps.HighResolutionTimerAvailable);

            caps.CapabilityDiagnosticSummary =
                $"Pantalla: {caps.DesktopWidth}x{caps.DesktopHeight} @ {caps.CurrentRefreshRateHz} Hz " +
                $"(Máx soportado por monitor: {caps.MaxMonitorRefreshRateHz} Hz en {caps.TotalDisplayModesEnumerated} modos) | " +
                $"Rendimiento CPU/Render: ~{caps.BenchmarkPotentialFps:F0} FPS máx ({avgFrameMs:F2} ms/frame) | " +
                $"Soporte 120 FPS: {(caps.Supports120Fps ? "SÍ (Opción habilitada en menú)" : "NO (Monitor limitado a " + caps.MaxMonitorRefreshRateHz + " Hz - Opción oculta)")}";

            return caps;
        }
    }
}
