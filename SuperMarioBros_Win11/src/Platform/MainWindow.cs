using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SuperMarioBros_Win11.Audio;
using SuperMarioBros_Win11.Core;
using SuperMarioBros_Win11.Graphics;
using SuperMarioBros_Win11.Input;

namespace SuperMarioBros_Win11.Platform
{
    /// <summary>
    /// Ventana Principal Nativa de Windows 11 para Super Mario Bros.
    /// Incluye menú desplegable estándar de Windows (sin alterar el menú interno del juego),
    /// selector de altas resoluciones (720p, 900p, 1080p, 1200p, 1440p, 4K), detección automática
    /// de capacidad de 120 FPS y renderizado de ultra-baja latencia con Windows.Gaming.Input.
    /// </summary>
    public sealed unsafe class MainWindow : Form
    {
        private const double NtscFrameRate60Hz = 60.0988138974405;
        private const double NtscFrameRate120Hz = NtscFrameRate60Hz * 2.0;

        [StructLayout(LayoutKind.Sequential)]
        private struct NativeMessage
        {
            public IntPtr hWnd;
            public uint msg;
            public IntPtr wParam;
            public IntPtr lParam;
            public uint time;
            public Point p;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct BitmapInfoHeader
        {
            public uint biSize;
            public int biWidth;
            public int biHeight;
            public ushort biPlanes;
            public ushort biBitCount;
            public uint biCompression;
            public uint biSizeImage;
            public int biXPelsPerMeter;
            public int biYPelsPerMeter;
            public uint biClrUsed;
            public uint biClrImportant;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct BitmapInfo
        {
            public BitmapInfoHeader bmiHeader;
            public uint bmiColors;
        }

        [DllImport("user32.dll")]
        private static extern bool PeekMessage(out NativeMessage msg, IntPtr hWnd, uint min, uint max, uint remove);

        [DllImport("user32.dll")]
        private static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll")]
        private static extern int SetDIBitsToDevice(
            IntPtr hdc,
            int xDest,
            int yDest,
            uint dwWidth,
            uint dwHeight,
            int xSrc,
            int ySrc,
            uint uStartScan,
            uint cScanLines,
            IntPtr lpvBits,
            ref BitmapInfo lpbmi,
            uint fuColorUse);

        [DllImport("winmm.dll")]
        private static extern uint timeBeginPeriod(uint uPeriod);

        [DllImport("winmm.dll")]
        private static extern uint timeEndPeriod(uint uPeriod);

        private readonly SmbEngineCore _engine;
        private readonly LowLatencyWaveOutPlayer _audioPlayer;
        private readonly HardwareCapabilities _hardwareCaps;
        private readonly MenuStrip _menuStrip;
        private readonly ViewportPanel _viewport;

        // Opciones de resolución y renderizado
        private int _targetWidth = 1920;
        private int _targetHeight = 1080;
        private uint[] _highResBuffer = new uint[1920 * 1080];
        private AspectScaleMode _aspectMode = AspectScaleMode.Aspect4x3Pillarbox;
        private bool _crtScanlines;
        private bool _isBorderlessFullscreen;
        private FormWindowState _prevWindowState = FormWindowState.Normal;
        private FormBorderStyle _prevBorderStyle = FormBorderStyle.Sizable;
        private Size _prevClientSize = new Size(1920, 1080);
        private Point _prevLocation;

        // Estado de tasa de fotogramas (60 FPS vs 120 FPS si el ordenador lo permite)
        private bool _runAt120Fps;
        private bool _isOdd120HzSubFrame;
        private bool _hostPaused;

        // Telemetría FPS en barra de título
        private long _lastFrameTick;
        private int _renderedFramesCounter;
        private double _fpsTimerAccum;
        private double _currentMeasuredFps = 60.1;

        // Referencias a ítems de menú para actualizar sus marcas de selección (CheckMarks)
        private readonly List<(ToolStripMenuItem Item, int W, int H)> _resolutionMenuItems = new();
        private ToolStripMenuItem _fullscreenMenuItem;
        private ToolStripMenuItem _fps60MenuItem;
        private ToolStripMenuItem _fps120MenuItem;
        private ToolStripMenuItem _wgiStatusMenuItem;

        private sealed class ViewportPanel : Control
        {
            public ViewportPanel()
            {
                SetStyle(ControlStyles.Opaque | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
                BackColor = Color.Black;
                TabStop = false;
            }

            protected override void OnPaintBackground(PaintEventArgs pevent)
            {
                // Evitar parpadeo; el frame completo se vuelca directamente por SetDIBitsToDevice
            }
        }

        public MainWindow(
            SmbEngineCore engine,
            LowLatencyWaveOutPlayer audioPlayer,
            HardwareCapabilities hardwareCaps,
            int? initialWidthOverride = null,
            int? initialHeightOverride = null,
            int? autoExitAfterFrames = null)
        {
            _engine = engine;
            _audioPlayer = audioPlayer;
            _hardwareCaps = hardwareCaps;
            AutoExitAfterFrames = autoExitAfterFrames;

            timeBeginPeriod(1);

            Text = "Super Mario Bros. (Port Nativo Windows 11 - Windows.Gaming.Input)";
            BackColor = Color.Black;
            StartPosition = FormStartPosition.CenterScreen;
            KeyPreview = true;

            _menuStrip = BuildStandardWindowsMenuBar();
            MainMenuStrip = _menuStrip;
            Controls.Add(_menuStrip);

            _viewport = new ViewportPanel
            {
                Dock = DockStyle.Fill
            };
            _viewport.Resize += (_, _) => AllocateHighResBufferForViewport();
            Controls.Add(_viewport);
            _viewport.BringToFront();

            // Seleccionar resolución alta por defecto (1080p si cabe en el escritorio, o 720p)
            int defaultW = initialWidthOverride ?? (_hardwareCaps.DesktopWidth >= 1920 && _hardwareCaps.DesktopHeight >= 1080 ? 1920 : 1280);
            int defaultH = initialHeightOverride ?? (defaultW == 1920 ? 1080 : 720);
            ApplyResolution(defaultW, defaultH, isFullscreen: false);

            _lastFrameTick = Stopwatch.GetTimestamp();
            Application.Idle += OnApplicationIdle;
        }

        public int? AutoExitAfterFrames { get; }
        public int TotalSimulatedFrames { get; private set; }

        /// <summary>
        /// Construye el menú desplegable estándar de Windows 11 sin modificar jamás el menú interno de NES.
        /// Oculta la opción de 120 FPS si el ordenador no permite esa tasa de fotogramas.
        /// </summary>
        private MenuStrip BuildStandardWindowsMenuBar()
        {
            var menu = new MenuStrip
            {
                Dock = DockStyle.Top,
                RenderMode = ToolStripRenderMode.System
            };

            // 1. Menú Archivo
            var fileMenu = new ToolStripMenuItem("&Archivo");
            var warmResetItem = new ToolStripMenuItem("Reiniciar Partida (Warm Reset - Preserva TOP Score)", null, (_, _) => _engine.WarmReset())
            {
                ShortcutKeys = Keys.F2
            };
            var coldResetItem = new ToolStripMenuItem("Reinicio en Frío (Cold Boot - Limpia RAM)", null, (_, _) => _engine.HardReset())
            {
                ShortcutKeys = Keys.Control | Keys.F2
            };
            var pauseItem = new ToolStripMenuItem("Pausar / Reanudar Motor (Host)", null, (s, _) =>
            {
                _hostPaused = !_hostPaused;
                ((ToolStripMenuItem)s).Checked = _hostPaused;
            })
            {
                ShortcutKeys = Keys.F3
            };
            var exitItem = new ToolStripMenuItem("Salir", null, (_, _) => Close())
            {
                ShortcutKeys = Keys.Alt | Keys.F4
            };
            fileMenu.DropDownItems.Add(warmResetItem);
            fileMenu.DropDownItems.Add(coldResetItem);
            fileMenu.DropDownItems.Add(pauseItem);
            fileMenu.DropDownItems.Add(new ToolStripSeparator());
            fileMenu.DropDownItems.Add(exitItem);

            // 2. Menú Resolución (Solo resoluciones altas de Windows: 720p, 900p, 1080p, 1200p, 1440p, 4K)
            var resMenu = new ToolStripMenuItem("&Resolución");
            AddResolutionOption(resMenu, "HD 720p (1280 × 720)", 1280, 720);
            AddResolutionOption(resMenu, "HD+ 900p (1600 × 900)", 1600, 900);
            AddResolutionOption(resMenu, "Full HD 1080p (1920 × 1080)", 1920, 1080);
            AddResolutionOption(resMenu, "WUXGA 1200p (1920 × 1200 - 16:10)", 1920, 1200);
            AddResolutionOption(resMenu, "QHD 1440p (2560 × 1440)", 2560, 1440);
            AddResolutionOption(resMenu, "4K UHD 2160p (3840 × 2160)", 3840, 2160);

            resMenu.DropDownItems.Add(new ToolStripSeparator());
            _fullscreenMenuItem = new ToolStripMenuItem("Pantalla Completa Sin Bordes (Maximizado Nativo)", null, (_, _) => ToggleBorderlessFullscreen())
            {
                ShortcutKeys = Keys.F11
            };
            resMenu.DropDownItems.Add(_fullscreenMenuItem);

            resMenu.DropDownItems.Add(new ToolStripSeparator());
            var aspectSubMenu = new ToolStripMenuItem("Relación de Aspecto");
            var aspect43Item = new ToolStripMenuItem("4:3 Clásico Alta Definición (Recomendado)") { Checked = true };
            var aspectIntItem = new ToolStripMenuItem("Escala Entera Exacta (Pixel-Perfect)");
            var aspectWideItem = new ToolStripMenuItem("16:9 / Ventana Completa Estirada");

            aspect43Item.Click += (_, _) =>
            {
                _aspectMode = AspectScaleMode.Aspect4x3Pillarbox;
                aspect43Item.Checked = true; aspectIntItem.Checked = false; aspectWideItem.Checked = false;
            };
            aspectIntItem.Click += (_, _) =>
            {
                _aspectMode = AspectScaleMode.IntegerPixelPerfect;
                aspect43Item.Checked = false; aspectIntItem.Checked = true; aspectWideItem.Checked = false;
            };
            aspectWideItem.Click += (_, _) =>
            {
                _aspectMode = AspectScaleMode.StretchWidescreen;
                aspect43Item.Checked = false; aspectIntItem.Checked = false; aspectWideItem.Checked = true;
            };
            aspectSubMenu.DropDownItems.Add(aspect43Item);
            aspectSubMenu.DropDownItems.Add(aspectIntItem);
            aspectSubMenu.DropDownItems.Add(aspectWideItem);
            resMenu.DropDownItems.Add(aspectSubMenu);

            var crtItem = new ToolStripMenuItem("Filtro Visual Scanlines CRT (Alta Resolución)", null, (s, _) =>
            {
                _crtScanlines = !_crtScanlines;
                ((ToolStripMenuItem)s).Checked = _crtScanlines;
            });
            resMenu.DropDownItems.Add(crtItem);

            // 3. Menú Tasa de Fotogramas (FPS)
            // REQUISITO CRÍTICO: Solo mostrar la opción de 120 FPS si el ordenador permite ejecutar a 120 FPS.
            var fpsMenu = new ToolStripMenuItem("&Tasa de Fotogramas (FPS)");
            _fps60MenuItem = new ToolStripMenuItem("60 FPS (Estándar NTSC 60.10 Hz)", null, (_, _) => SetFrameRateMode(enable120Fps: false))
            {
                Checked = true
            };
            fpsMenu.DropDownItems.Add(_fps60MenuItem);

            if (_hardwareCaps.Supports120Fps)
            {
                _fps120MenuItem = new ToolStripMenuItem("120 FPS (120.20 Hz Ultra-Baja Latencia + Interpolado)", null, (_, _) => SetFrameRateMode(enable120Fps: true));
                fpsMenu.DropDownItems.Add(_fps120MenuItem);
            }

            // 4. Menú Controles (Windows.Gaming.Input)
            var inputMenu = new ToolStripMenuItem("&Controles (Windows.Gaming.Input)");
            _wgiStatusMenuItem = new ToolStripMenuItem(_engine.Input.GetStatusDescription())
            {
                Enabled = false
            };
            inputMenu.DropDownOpening += (_, _) =>
            {
                _wgiStatusMenuItem.Text = _engine.Input.GetStatusDescription();
            };
            inputMenu.DropDownItems.Add(_wgiStatusMenuItem);
            inputMenu.DropDownItems.Add(new ToolStripSeparator());

            var dzMenu = new ToolStripMenuItem("Zona Muerta del Stick Analógico (Deadzone)");
            var dz15 = new ToolStripMenuItem("15% (Alta Sensibilidad)");
            var dz24 = new ToolStripMenuItem("24% (Estándar Recomendado)") { Checked = true };
            var dz35 = new ToolStripMenuItem("35% (Amplia)");
            dz15.Click += (_, _) => { _engine.Input.AnalogDeadzone = 0.15; dz15.Checked = true; dz24.Checked = false; dz35.Checked = false; };
            dz24.Click += (_, _) => { _engine.Input.AnalogDeadzone = 0.24; dz15.Checked = false; dz24.Checked = true; dz35.Checked = false; };
            dz35.Click += (_, _) => { _engine.Input.AnalogDeadzone = 0.35; dz15.Checked = false; dz24.Checked = false; dz35.Checked = true; };
            dzMenu.DropDownItems.Add(dz15);
            dzMenu.DropDownItems.Add(dz24);
            dzMenu.DropDownItems.Add(dz35);
            inputMenu.DropDownItems.Add(dzMenu);

            var controlsHelpItem = new ToolStripMenuItem("Ver Mapeo de Botones (Gamepad y Teclado)...", null, (_, _) => ShowControlsDialog());
            inputMenu.DropDownItems.Add(controlsHelpItem);

            // 5. Menú Audio (APU 2A03)
            var audioMenu = new ToolStripMenuItem("A&udio");
            var muteItem = new ToolStripMenuItem("Silenciar Audio (Mute)", null, (s, _) =>
            {
                _engine.Apu.Muted = !_engine.Apu.Muted;
                ((ToolStripMenuItem)s).Checked = _engine.Apu.Muted;
            });
            audioMenu.DropDownItems.Add(muteItem);

            // 6. Menú Ayuda
            var helpMenu = new ToolStripMenuItem("A&yuda");
            var hwDiagItem = new ToolStripMenuItem("Diagnóstico de Pantalla y Soporte 120 FPS...", null, (_, _) => ShowHardwareDiagnosticDialog());
            var aboutItem = new ToolStripMenuItem("Acerca de Super Mario Bros. Win11 Port...", null, (_, _) => ShowAboutDialog());
            helpMenu.DropDownItems.Add(hwDiagItem);
            helpMenu.DropDownItems.Add(aboutItem);

            menu.Items.Add(fileMenu);
            menu.Items.Add(resMenu);
            menu.Items.Add(fpsMenu);
            menu.Items.Add(inputMenu);
            menu.Items.Add(audioMenu);
            menu.Items.Add(helpMenu);

            return menu;
        }

        private void AddResolutionOption(ToolStripMenuItem parentMenu, string label, int width, int height)
        {
            var item = new ToolStripMenuItem(label);
            item.Click += (_, _) => ApplyResolution(width, height, isFullscreen: false);
            parentMenu.DropDownItems.Add(item);
            _resolutionMenuItems.Add((item, width, height));
        }

        public void ApplyResolution(int width, int height, bool isFullscreen)
        {
            if (isFullscreen)
            {
                if (!_isBorderlessFullscreen)
                {
                    _prevWindowState = WindowState;
                    _prevBorderStyle = FormBorderStyle;
                    _prevClientSize = ClientSize;
                    _prevLocation = Location;
                }
                _isBorderlessFullscreen = true;
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                _isBorderlessFullscreen = false;
                WindowState = FormWindowState.Normal;
                FormBorderStyle = FormBorderStyle.Sizable;

                int menuHeight = _menuStrip != null ? _menuStrip.Height : 24;
                ClientSize = new Size(width, height + menuHeight);
                CenterToScreen();
            }

            _targetWidth = Math.Max(640, _viewport.ClientSize.Width > 0 ? _viewport.ClientSize.Width : width);
            _targetHeight = Math.Max(480, _viewport.ClientSize.Height > 0 ? _viewport.ClientSize.Height : height);
            AllocateHighResBufferForViewport();

            foreach (var entry in _resolutionMenuItems)
            {
                entry.Item.Checked = !isFullscreen && (entry.W == width && entry.H == height);
            }
            if (_fullscreenMenuItem != null)
            {
                _fullscreenMenuItem.Checked = isFullscreen;
            }
        }

        private void ToggleBorderlessFullscreen()
        {
            if (!_isBorderlessFullscreen)
            {
                ApplyResolution(_hardwareCaps.DesktopWidth, _hardwareCaps.DesktopHeight, isFullscreen: true);
            }
            else
            {
                ApplyResolution(_prevClientSize.Width, Math.Max(720, _prevClientSize.Height - _menuStrip.Height), isFullscreen: false);
            }
        }

        private void AllocateHighResBufferForViewport()
        {
            int w = Math.Max(320, _viewport.ClientSize.Width);
            int h = Math.Max(240, _viewport.ClientSize.Height);
            _targetWidth = w;
            _targetHeight = h;
            if (_highResBuffer.Length != w * h)
            {
                _highResBuffer = new uint[w * h];
            }
        }

        private void SetFrameRateMode(bool enable120Fps)
        {
            if (enable120Fps && !_hardwareCaps.Supports120Fps)
                return;

            _runAt120Fps = enable120Fps;
            _isOdd120HzSubFrame = false;
            if (_fps60MenuItem != null) _fps60MenuItem.Checked = !_runAt120Fps;
            if (_fps120MenuItem != null) _fps120MenuItem.Checked = _runAt120Fps;
            _lastFrameTick = Stopwatch.GetTimestamp();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                ToggleBorderlessFullscreen();
                e.Handled = true;
                return;
            }
            if (e.KeyCode == Keys.Escape && _isBorderlessFullscreen)
            {
                ToggleBorderlessFullscreen();
                e.Handled = true;
                return;
            }
            base.OnKeyDown(e);
        }

        private void OnApplicationIdle(object sender, EventArgs e)
        {
            while (IsApplicationIdle())
            {
                StepHighPrecisionLoop();
            }
        }

        private static bool IsApplicationIdle()
        {
            return !PeekMessage(out _, IntPtr.Zero, 0, 0, 0);
        }

        private void StepHighPrecisionLoop()
        {
            if (_hostPaused || !IsHandleCreated || WindowState == FormWindowState.Minimized)
            {
                System.Threading.Thread.Sleep(4);
                _lastFrameTick = Stopwatch.GetTimestamp();
                return;
            }

            double targetHz = _runAt120Fps ? NtscFrameRate120Hz : NtscFrameRate60Hz;
            double frameIntervalSec = 1.0 / targetHz;
            long freq = Stopwatch.Frequency;
            long targetDeltaTicks = (long)(frameIntervalSec * freq);

            long now = Stopwatch.GetTimestamp();
            long elapsedTicks = now - _lastFrameTick;

            if (elapsedTicks < targetDeltaTicks)
            {
                double remainingMs = ((targetDeltaTicks - elapsedTicks) * 1000.0) / freq;
                if (remainingMs > 2.0)
                {
                    System.Threading.Thread.Sleep(1);
                }
                else
                {
                    System.Threading.Thread.SpinWait(20);
                }
                return;
            }

            // Avanzar reloj de frame evitando acumulación excesiva si el usuario arrastró la ventana
            _lastFrameTick += targetDeltaTicks;
            if (now - _lastFrameTick > freq / 10)
            {
                _lastFrameTick = now;
            }

            if (!_runAt120Fps)
            {
                // Modo 60 FPS Nativo (60.0988 Hz)
                _engine.StepOneFrame60Hz(Handle, savePrevFor120Hz: false);
                _audioPlayer.SubmitFrameAudio();
                PresentHighResFrame(_engine.Ppu.Framebuffer60Hz);
                TotalSimulatedFrames++;
            }
            else
            {
                // Modo 120 FPS (120.1976 Hz):
                // - En el sub-frame par: ejecuta el paso lógico de 60 Hz y presenta el sub-frame interpolado (t = 0.5)
                // - En el sub-frame impar: muestrea Windows.Gaming.Input a 120 Hz y presenta el frame exacto (t = 1.0)
                if (!_isOdd120HzSubFrame)
                {
                    _engine.StepOneFrame60Hz(Handle, savePrevFor120Hz: true);
                    _audioPlayer.SubmitFrameAudio();
                    PresentHighResFrame(_engine.Ppu.Framebuffer120Hz);
                    _isOdd120HzSubFrame = true;
                    TotalSimulatedFrames++;
                }
                else
                {
                    _engine.Input.PollMinimalLatencyInput(Handle);
                    PresentHighResFrame(_engine.Ppu.Framebuffer60Hz);
                    _isOdd120HzSubFrame = false;
                }
            }

            // Actualizar contador de FPS en la barra de título cada 0.5 segundos
            _renderedFramesCounter++;
            _fpsTimerAccum += (double)elapsedTicks / freq;
            if (_fpsTimerAccum >= 0.5)
            {
                _currentMeasuredFps = _renderedFramesCounter / _fpsTimerAccum;
                _renderedFramesCounter = 0;
                _fpsTimerAccum = 0;

                int world = (_engine.Memory.WorldNumber & 7) + 1;
                int stage = (_engine.Memory.AreaNumber & 3) + 1;
                string modeStr = _runAt120Fps ? "120 FPS" : "60 FPS";
                string wgiPad = _engine.Input.ConnectedGamepadCount + _engine.Input.ConnectedRawControllerCount > 0
                    ? $"Mando WGI Conectado ({_engine.Input.ConnectedGamepadCount + _engine.Input.ConnectedRawControllerCount})"
                    : "Teclado + WGI Listo";
                Text = $"Super Mario Bros. Win11 | {_targetWidth}×{_targetHeight} | {modeStr} ({_currentMeasuredFps:F1} fps) | Mundo {world}-{stage} | {wgiPad}";
            }

            if (AutoExitAfterFrames.HasValue && TotalSimulatedFrames >= AutoExitAfterFrames.Value)
            {
                Close();
            }
        }

        private void PresentHighResFrame(uint[] source256x240)
        {
            int w = _targetWidth;
            int h = _targetHeight;
            if (w <= 0 || h <= 0 || _highResBuffer.Length != w * h)
                return;

            _engine.Ppu.UpscaleToHighResBuffer(source256x240, _highResBuffer, w, h, _aspectMode, _crtScanlines);

            IntPtr hdc = GetDC(_viewport.Handle);
            if (hdc != IntPtr.Zero)
            {
                try
                {
                    var bmi = new BitmapInfo
                    {
                        bmiHeader = new BitmapInfoHeader
                        {
                            biSize = (uint) sizeof(BitmapInfoHeader),
                            biWidth = w,
                            biHeight = -h, // Top-down DIB
                            biPlanes = 1,
                            biBitCount = 32,
                            biCompression = 0 // BI_RGB
                        }
                    };

                    fixed (uint* pBuf = _highResBuffer)
                    {
                        SetDIBitsToDevice(
                            hdc,
                            0,
                            0,
                            (uint)w,
                            (uint)h,
                            0,
                            0,
                            0,
                            (uint)h,
                            (IntPtr)pBuf,
                            ref bmi,
                            0);
                    }
                }
                finally
                {
                    ReleaseDC(_viewport.Handle, hdc);
                }
            }
        }

        private void ShowControlsDialog()
        {
            MessageBox.Show(
                this,
                "CONTROLES NATIVOS DE BAJA LATENCIA (Windows.Gaming.Input + Teclado Win32)\n\n" +
                "1. CONTROLADOR DE JUEGOS (Windows.Gaming.Input.Gamepad / RawGameController):\n" +
                "   • Cruceta (D-Pad) o Stick Izquierdo: Mover a Mario / Agacharse / Entrar en tubería\n" +
                "   • Botón A (o RB): Saltar / Nadar (A)\n" +
                "   • Botón X / B (o Gatillos LT/RT / LB): Correr / Lanzar Bola de Fuego (B)\n" +
                "   • Botón Menu (Start): Iniciar juego / Pausar (START)\n" +
                "   • Botón View (Select / Back): Seleccionar 1 o 2 Jugadores (SELECT)\n\n" +
                "2. TECLADO (Muestreo directo sin lag):\n" +
                "   • W/A/S/D o Flechas Direccionales: Movimiento\n" +
                "   • Espacio, X o K: Saltar / Nadar (Botón A)\n" +
                "   • Shift Izquierdo, Z o J: Correr / Fuego (Botón B)\n" +
                "   • Enter: Iniciar / Pausa (START)\n" +
                "   • Tab o Backspace: Cambiar 1P / 2P (SELECT)\n" +
                "   • F11: Alternar Pantalla Completa Sin Bordes\n" +
                "   • F2 / Ctrl+F2: Reinicio en Caliente / Frío",
                "Controles - Windows.Gaming.Input",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ShowHardwareDiagnosticDialog()
        {
            MessageBox.Show(
                this,
                "DIAGNÓSTICO DE PANTALLA Y DETECCIÓN DE 120 FPS\n\n" +
                $"• Resolución de Escritorio Física: {_hardwareCaps.DesktopWidth} × {_hardwareCaps.DesktopHeight}\n" +
                $"• Resolución de Renderizado Activa: {_targetWidth} × {_targetHeight}\n" +
                $"• Frecuencia de Refresco Actual: {_hardwareCaps.CurrentRefreshRateHz} Hz\n" +
                $"• Frecuencia Máxima del Monitor ({_hardwareCaps.TotalDisplayModesEnumerated} modos): {_hardwareCaps.MaxMonitorRefreshRateHz} Hz\n" +
                $"• Rendimiento Medido de CPU/Escalador HD: ~{_hardwareCaps.BenchmarkPotentialFps:F0} FPS\n" +
                $"• Temporizador QPC de Alta Resolución: {(_hardwareCaps.HighResolutionTimerAvailable ? "Sí" : "No")}\n\n" +
                $"RESULTADO DE DETECCIÓN 120 FPS:\n{_hardwareCaps.CapabilityDiagnosticSummary}",
                "Diagnóstico de Hardware - Super Mario Bros. Win11",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ShowAboutDialog()
        {
            MessageBox.Show(
                this,
                "Super Mario Bros. - Edición Nativa para Windows 11\n\n" +
                "Generado a partir de los Documentos de Diseño de Ingeniería:\n" +
                "• Volumen 1: DOC_DISENO_PORT_WIN11_ARQUITECTURA.md\n" +
                "• Volumen 2: DOC_DISENO_PORT_WIN11_SUBSISTEMAS_Y_DATOS.md\n\n" +
                "Ingeniería Inversa realizada con REA + Ghidra 12.1.4 (6502:LE:16:default)\n" +
                "y extracción estática completa de las 533 subrutinas y 18 tablas JumpEngine.\n\n" +
                "• Entrada: Windows.Gaming.Input (IGamepadStatics / IRawGameControllerStatics)\n" +
                "• Vídeo: Compositor PPU 2C02 con Split Sprite 0 y Escalador Multihilo HD/4K\n" +
                "• Audio: Sintetizador APU 2A03 de 5 Canales a 48,000 Hz",
                "Acerca de Super Mario Bros. Win11",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            Application.Idle -= OnApplicationIdle;
            timeEndPeriod(1);
            base.OnFormClosed(e);
        }
    }
}
