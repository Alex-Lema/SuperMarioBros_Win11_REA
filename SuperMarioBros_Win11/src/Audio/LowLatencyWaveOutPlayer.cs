using System;
using System.Runtime.InteropServices;

namespace SuperMarioBros_Win11.Audio
{
    /// <summary>
    /// Salida de Audio Nativa de Baja Latencia (48,000 Hz, 16-bit Mono) sobre Windows Multimedia / WASAPI Bridge.
    /// Utiliza un anillo de buffers pequeños de ~10 ms (480 muestras) para evitar retraso audible.
    /// </summary>
    public sealed class LowLatencyWaveOutPlayer : IDisposable
    {
        private const int BufferCount = 4;
        private const int SamplesPerFrame = 800; // 48000 Hz / 60 Hz = 800 muestras por frame

        [StructLayout(LayoutKind.Sequential)]
        private struct WaveFormatEx
        {
            public ushort wFormatTag;
            public ushort nChannels;
            public uint nSamplesPerSec;
            public uint nAvgBytesPerSec;
            public ushort nBlockAlign;
            public ushort wBitsPerSample;
            public ushort cbSize;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct WaveHdr
        {
            public IntPtr lpData;
            public uint dwBufferLength;
            public uint dwBytesRecorded;
            public IntPtr dwUser;
            public uint dwFlags;
            public uint dwLoops;
            public IntPtr lpNext;
            public IntPtr reserved;
        }

        [DllImport("winmm.dll", ExactSpelling = true)]
        private static extern int waveOutOpen(out IntPtr phwo, int uDeviceID, ref WaveFormatEx pwfx, IntPtr dwCallback, IntPtr dwInstance, uint fdwOpen);

        [DllImport("winmm.dll", ExactSpelling = true)]
        private static extern int waveOutPrepareHeader(IntPtr hwo, IntPtr pwh, int cbwh);

        [DllImport("winmm.dll", ExactSpelling = true)]
        private static extern int waveOutUnprepareHeader(IntPtr hwo, IntPtr pwh, int cbwh);

        [DllImport("winmm.dll", ExactSpelling = true)]
        private static extern int waveOutWrite(IntPtr hwo, IntPtr pwh, int cbwh);

        [DllImport("winmm.dll", ExactSpelling = true)]
        private static extern int waveOutReset(IntPtr hwo);

        [DllImport("winmm.dll", ExactSpelling = true)]
        private static extern int waveOutClose(IntPtr hwo);

        private const uint WHDR_DONE = 0x00000001;
        private const uint WHDR_PREPARED = 0x00000002;

        private readonly Apu2A03Synthesizer _synth;
        private IntPtr _hWaveOut;
        private readonly IntPtr[] _headerPtrs = new IntPtr[BufferCount];
        private readonly IntPtr[] _dataPtrs = new IntPtr[BufferCount];
        private readonly short[] _tempSamples = new short[SamplesPerFrame];
        private int _nextBufferIndex;
        private bool _initialized;

        public LowLatencyWaveOutPlayer(Apu2A03Synthesizer synth)
        {
            _synth = synth;
            InitializeDevice();
        }

        private void InitializeDevice()
        {
            try
            {
                var fmt = new WaveFormatEx
                {
                    wFormatTag = 1, // WAVE_FORMAT_PCM
                    nChannels = 1,
                    nSamplesPerSec = Apu2A03Synthesizer.SampleRate,
                    wBitsPerSample = 16,
                    nBlockAlign = 2,
                    nAvgBytesPerSec = Apu2A03Synthesizer.SampleRate * 2,
                    cbSize = 0
                };

                if (waveOutOpen(out _hWaveOut, -1, ref fmt, IntPtr.Zero, IntPtr.Zero, 0) == 0 && _hWaveOut != IntPtr.Zero)
                {
                    int byteLen = SamplesPerFrame * sizeof(short);
                    int hdrSize = Marshal.SizeOf<WaveHdr>();
                    for (int i = 0; i < BufferCount; i++)
                    {
                        _dataPtrs[i] = Marshal.AllocHGlobal(byteLen);
                        _headerPtrs[i] = Marshal.AllocHGlobal(hdrSize);
                        var hdr = new WaveHdr
                        {
                            lpData = _dataPtrs[i],
                            dwBufferLength = (uint)byteLen,
                            dwFlags = 0
                        };
                        Marshal.StructureToPtr(hdr, _headerPtrs[i], false);
                        waveOutPrepareHeader(_hWaveOut, _headerPtrs[i], hdrSize);

                        // Marcar como disponible inicialmente
                        hdr = Marshal.PtrToStructure<WaveHdr>(_headerPtrs[i]);
                        hdr.dwFlags |= WHDR_DONE;
                        Marshal.StructureToPtr(hdr, _headerPtrs[i], false);
                    }
                    _initialized = true;
                }
            }
            catch
            {
                _initialized = false;
            }
        }

        public void SubmitFrameAudio()
        {
            if (!_initialized || _hWaveOut == IntPtr.Zero)
                return;

            IntPtr hdrPtr = _headerPtrs[_nextBufferIndex];
            var hdr = Marshal.PtrToStructure<WaveHdr>(hdrPtr);
            if ((hdr.dwFlags & WHDR_DONE) == 0)
            {
                // Si los 4 buffers están en vuelo, no bloqueamos el hilo de entrada/renderizado
                return;
            }

            _synth.RenderPcm16Samples(_tempSamples, 0, SamplesPerFrame);
            Marshal.Copy(_tempSamples, 0, _dataPtrs[_nextBufferIndex], SamplesPerFrame);

            hdr.dwFlags &= ~WHDR_DONE;
            Marshal.StructureToPtr(hdr, hdrPtr, false);
            waveOutWrite(_hWaveOut, hdrPtr, Marshal.SizeOf<WaveHdr>());

            _nextBufferIndex = (_nextBufferIndex + 1) % BufferCount;
        }

        public void Dispose()
        {
            if (_hWaveOut != IntPtr.Zero)
            {
                try
                {
                    waveOutReset(_hWaveOut);
                    int hdrSize = Marshal.SizeOf<WaveHdr>();
                    for (int i = 0; i < BufferCount; i++)
                    {
                        if (_headerPtrs[i] != IntPtr.Zero)
                        {
                            waveOutUnprepareHeader(_hWaveOut, _headerPtrs[i], hdrSize);
                            Marshal.FreeHGlobal(_headerPtrs[i]);
                            _headerPtrs[i] = IntPtr.Zero;
                        }
                        if (_dataPtrs[i] != IntPtr.Zero)
                        {
                            Marshal.FreeHGlobal(_dataPtrs[i]);
                            _dataPtrs[i] = IntPtr.Zero;
                        }
                    }
                    waveOutClose(_hWaveOut);
                }
                catch
                {
                }
                _hWaveOut = IntPtr.Zero;
            }
        }
    }
}
