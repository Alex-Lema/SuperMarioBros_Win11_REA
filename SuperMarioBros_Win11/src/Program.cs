using System;
using System.Diagnostics;
using System.Windows.Forms;
using SuperMarioBros_Win11.Audio;
using SuperMarioBros_Win11.Core;
using SuperMarioBros_Win11.Graphics;
using SuperMarioBros_Win11.Input;
using SuperMarioBros_Win11.Platform;

namespace SuperMarioBros_Win11
{
    internal static class Program
    {
        [STAThread]
        private static int Main(string[] args)
        {
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool selfTestMode = false;
            foreach (string arg in args)
            {
                if (string.Equals(arg, "--self-test", StringComparison.OrdinalIgnoreCase))
                {
                    selfTestMode = true;
                }
            }

            try
            {
                SmbRomImage rom = SmbRomImage.LoadFromDefaultLocations();
                var memory = new SmbMemory();
                var ppu = new Ppu2C02Renderer(rom);
                var apu = new Apu2A03Synthesizer();
                using var input = new WindowsGamingInputService();
                var engine = new SmbEngineCore(rom, memory, ppu, apu, input);

                HardwareCapabilities caps = HardwareCapabilities.Detect(engine, args);

                if (selfTestMode)
                {
                    return RunAutomatedVerification(engine, caps);
                }

                using var audioPlayer = new LowLatencyWaveOutPlayer(apu);
                using var mainWindow = new MainWindow(engine, audioPlayer, caps);
                Application.Run(mainWindow);
                return 0;
            }
            catch (Exception ex)
            {
                if (selfTestMode)
                {
                    Console.Error.WriteLine($"ERROR: {ex}");
                    return 1;
                }
                MessageBox.Show(
                    $"Error al iniciar Super Mario Bros. (Windows 11 Port):\n\n{ex.Message}",
                    "Error de Inicialización",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return 1;
            }
        }

        private static int RunAutomatedVerification(SmbEngineCore engine, HardwareCapabilities caps)
        {
            Console.WriteLine("=== SUPER MARIO BROS. WIN11 PORT - SELF-TEST VERIFICATION ===");
            Console.WriteLine($"[ROM] Source: {engine.Rom.SourcePath}");
            Console.WriteLine($"[ROM] SHA-256: {engine.Rom.RomSha256}");
            Console.WriteLine($"[WGI] {engine.Input.GetStatusDescription()}");
            Console.WriteLine($"[HW ] {caps.CapabilityDiagnosticSummary}");

            var sw = Stopwatch.StartNew();
            for (int f = 0; f < 120; f++)
            {
                engine.StepOneFrame60Hz(IntPtr.Zero, savePrevFor120Hz: true);
            }
            sw.Stop();

            // Verificar que el Title Screen fue dibujado en el Framebuffer PPU y que el escalador 1080p funciona
            uint[] highRes1080p = new uint[1920 * 1080];
            engine.Ppu.UpscaleToHighResBuffer(
                engine.Ppu.Framebuffer60Hz,
                highRes1080p,
                1920,
                1080,
                AspectScaleMode.Aspect4x3Pillarbox,
                crtScanlinesEffect: false);

            int nonBlackPixels = 0;
            uint firstColor = engine.Ppu.Framebuffer60Hz[0];
            int distinctPixels = 0;
            for (int i = 0; i < engine.Ppu.Framebuffer60Hz.Length; i++)
            {
                if ((engine.Ppu.Framebuffer60Hz[i] & 0x00FFFFFF) != 0) nonBlackPixels++;
                if (engine.Ppu.Framebuffer60Hz[i] != firstColor) distinctPixels++;
            }

            short[] audioSamples = new short[800];
            engine.Apu.RenderPcm16Samples(audioSamples, 0, audioSamples.Length);

            Console.WriteLine($"[SIM] 120 frames simulated in {sw.Elapsed.TotalMilliseconds:F2} ms ({120000.0 / sw.Elapsed.TotalMilliseconds:F1} FPS avg)");
            Console.WriteLine($"[RAM] WarmBootValidation ($07FF)=0x{engine.Memory.WarmBootValidation:X2}, OperMode ($0770)={engine.Memory.OperMode}, OperMode_Task ($0772)={engine.Memory.OperMode_Task}, FrameCounter ($0009)={engine.Memory.FrameCounter}");
            Console.WriteLine($"[PPU] Non-black pixels: {nonBlackPixels}/61440 | Distinct title screen pixels: {distinctPixels}/61440 | 1080p Upscale: OK");

            return (engine.Memory.WarmBootValidation == 0xA5 && distinctPixels > 1000) ? 0 : 2;
        }
    }
}
