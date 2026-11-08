using System;
using System.Runtime.CompilerServices;

namespace SuperMarioBros_Win11.Audio
{
    /// <summary>
    /// Sintetizador de Audio en Tiempo Real de 5 Canales (APU 2A03: Pulse 1, Pulse 2, Triangle, Noise, DMC DAC)
    /// conforme a la Sección 5 de DOC_DISENO_PORT_WIN11_ARQUITECTURA.md y las 18 funciones decompiladas
    /// de SoundEngine ($F2D0..$F8F4) en DOC_DISENO_PORT_WIN11_SUBSISTEMAS_Y_DATOS.md.
    /// </summary>
    public sealed class Apu2A03Synthesizer
    {
        public const int SampleRate = 48000;
        public const double CpuClockHz = 1789773.0;

        private static readonly byte[] LengthTable = new byte[32]
        {
            10, 254, 20,  2, 40,  4, 80,  6, 160,  8, 60, 10, 14, 12, 26, 14,
            12,  16, 24, 18, 48, 20, 96, 22, 192, 24, 72, 26, 16, 28, 32, 30
        };

        private static readonly byte[,] DutySequences = new byte[4, 8]
        {
            { 0, 1, 0, 0, 0, 0, 0, 0 }, // 12.5%
            { 0, 1, 1, 0, 0, 0, 0, 0 }, // 25.0%
            { 0, 1, 1, 1, 1, 0, 0, 0 }, // 50.0%
            { 1, 0, 0, 1, 1, 1, 1, 1 }  // 75.0% invertido
        };

        private static readonly byte[] TriangleSequence = new byte[32]
        {
            15, 14, 13, 12, 11, 10,  9,  8,  7,  6,  5,  4,  3,  2,  1,  0,
             0,  1,  2,  3,  4,  5,  6,  7,  8,  9, 10, 11, 12, 13, 14, 15
        };

        private static readonly int[] NoisePeriodTable = new int[16]
        {
            4, 8, 16, 32, 64, 96, 128, 160, 202, 254, 380, 508, 762, 1016, 2034, 4068
        };

        private struct PulseChannel
        {
            public bool IsChannel1;
            public bool Enabled;
            public int Duty;
            public bool LengthHalt;
            public bool ConstantVolume;
            public int VolumeOrPeriod;
            public bool EnvelopeStart;
            public int EnvelopeDivider;
            public int EnvelopeDecay;
            public bool SweepEnabled;
            public int SweepPeriod;
            public bool SweepNegate;
            public int SweepShift;
            public bool SweepReload;
            public int SweepDivider;
            public int TimerPeriod;
            public double Phase;
            public int DutyStep;
            public int LengthCounter;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetOutput()
            {
                if (!Enabled || LengthCounter == 0 || TimerPeriod < 8 || TimerPeriod > 0x7FF)
                    return 0;
                int target = TimerPeriod + (SweepNegate ? -(TimerPeriod >> SweepShift) : (TimerPeriod >> SweepShift));
                if (target > 0x7FF) return 0;
                if (DutySequences[Duty, DutyStep] == 0) return 0;
                return ConstantVolume ? VolumeOrPeriod : EnvelopeDecay;
            }

            public void ClockEnvelope()
            {
                if (EnvelopeStart)
                {
                    EnvelopeStart = false;
                    EnvelopeDecay = 15;
                    EnvelopeDivider = VolumeOrPeriod;
                }
                else
                {
                    if (EnvelopeDivider > 0)
                    {
                        EnvelopeDivider--;
                    }
                    else
                    {
                        EnvelopeDivider = VolumeOrPeriod;
                        if (EnvelopeDecay > 0) EnvelopeDecay--;
                        else if (LengthHalt) EnvelopeDecay = 15;
                    }
                }
            }

            public void ClockSweepAndLength()
            {
                if (!LengthHalt && LengthCounter > 0)
                    LengthCounter--;

                int change = TimerPeriod >> SweepShift;
                int target = TimerPeriod + (SweepNegate ? (-change - (IsChannel1 ? 1 : 0)) : change);
                bool mute = (TimerPeriod < 8) || (target > 0x7FF);

                if (SweepDivider == 0 && SweepEnabled && SweepShift > 0 && !mute)
                {
                    TimerPeriod = Math.Clamp(target, 0, 0x7FF);
                }
                if (SweepDivider == 0 || SweepReload)
                {
                    SweepDivider = SweepPeriod;
                    SweepReload = false;
                }
                else
                {
                    SweepDivider--;
                }
            }
        }

        private struct TriangleChannel
        {
            public bool Enabled;
            public bool ControlFlag;
            public int LinearReloadValue;
            public int LinearCounter;
            public bool LinearReloadFlag;
            public int TimerPeriod;
            public double Phase;
            public int SeqStep;
            public int LengthCounter;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetOutput()
            {
                if (!Enabled || LengthCounter == 0 || LinearCounter == 0 || TimerPeriod < 2)
                    return 7;
                return TriangleSequence[SeqStep];
            }
        }

        private struct NoiseChannel
        {
            public bool Enabled;
            public bool LengthHalt;
            public bool ConstantVolume;
            public int VolumeOrPeriod;
            public bool EnvelopeStart;
            public int EnvelopeDivider;
            public int EnvelopeDecay;
            public bool ModeFlag;
            public int TimerPeriod;
            public double TimerCounter;
            public int Lfsr;
            public int LengthCounter;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public int GetOutput()
            {
                if (!Enabled || LengthCounter == 0 || (Lfsr & 1) != 0)
                    return 0;
                return ConstantVolume ? VolumeOrPeriod : EnvelopeDecay;
            }
        }

        private PulseChannel _pulse1 = new PulseChannel { IsChannel1 = true };
        private PulseChannel _pulse2 = new PulseChannel { IsChannel1 = false };
        private TriangleChannel _triangle;
        private NoiseChannel _noise = new NoiseChannel { Lfsr = 1, TimerPeriod = 4 };
        private int _dmcDirectLoad;
        private readonly object _sync = new object();

        public bool Muted { get; set; }
        public float MasterVolume { get; set; } = 0.85f;

        public void Reset()
        {
            lock (_sync)
            {
                _pulse1 = new PulseChannel { IsChannel1 = true };
                _pulse2 = new PulseChannel { IsChannel1 = false };
                _triangle = default;
                _noise = new NoiseChannel { Lfsr = 1, TimerPeriod = 4 };
                _dmcDirectLoad = 0;
            }
        }

        public void CpuWriteRegister(int addr, byte val)
        {
            lock (_sync)
            {
                switch (addr)
                {
                    // Pulse 1 ($4000..$4003)
                    case 0x4000:
                        _pulse1.Duty = (val >> 6) & 3;
                        _pulse1.LengthHalt = (val & 0x20) != 0;
                        _pulse1.ConstantVolume = (val & 0x10) != 0;
                        _pulse1.VolumeOrPeriod = val & 0x0F;
                        break;
                    case 0x4001:
                        _pulse1.SweepEnabled = (val & 0x80) != 0;
                        _pulse1.SweepPeriod = (val >> 4) & 7;
                        _pulse1.SweepNegate = (val & 0x08) != 0;
                        _pulse1.SweepShift = val & 7;
                        _pulse1.SweepReload = true;
                        break;
                    case 0x4002:
                        _pulse1.TimerPeriod = (_pulse1.TimerPeriod & 0x700) | val;
                        break;
                    case 0x4003:
                        _pulse1.TimerPeriod = (_pulse1.TimerPeriod & 0x0FF) | ((val & 7) << 8);
                        if (_pulse1.Enabled) _pulse1.LengthCounter = LengthTable[(val >> 3) & 0x1F];
                        _pulse1.DutyStep = 0;
                        _pulse1.EnvelopeStart = true;
                        break;

                    // Pulse 2 ($4004..$4007)
                    case 0x4004:
                        _pulse2.Duty = (val >> 6) & 3;
                        _pulse2.LengthHalt = (val & 0x20) != 0;
                        _pulse2.ConstantVolume = (val & 0x10) != 0;
                        _pulse2.VolumeOrPeriod = val & 0x0F;
                        break;
                    case 0x4005:
                        _pulse2.SweepEnabled = (val & 0x80) != 0;
                        _pulse2.SweepPeriod = (val >> 4) & 7;
                        _pulse2.SweepNegate = (val & 0x08) != 0;
                        _pulse2.SweepShift = val & 7;
                        _pulse2.SweepReload = true;
                        break;
                    case 0x4006:
                        _pulse2.TimerPeriod = (_pulse2.TimerPeriod & 0x700) | val;
                        break;
                    case 0x4007:
                        _pulse2.TimerPeriod = (_pulse2.TimerPeriod & 0x0FF) | ((val & 7) << 8);
                        if (_pulse2.Enabled) _pulse2.LengthCounter = LengthTable[(val >> 3) & 0x1F];
                        _pulse2.DutyStep = 0;
                        _pulse2.EnvelopeStart = true;
                        break;

                    // Triangle ($4008..$400B)
                    case 0x4008:
                        _triangle.ControlFlag = (val & 0x80) != 0;
                        _triangle.LinearReloadValue = val & 0x7F;
                        break;
                    case 0x400A:
                        _triangle.TimerPeriod = (_triangle.TimerPeriod & 0x700) | val;
                        break;
                    case 0x400B:
                        _triangle.TimerPeriod = (_triangle.TimerPeriod & 0x0FF) | ((val & 7) << 8);
                        if (_triangle.Enabled) _triangle.LengthCounter = LengthTable[(val >> 3) & 0x1F];
                        _triangle.LinearReloadFlag = true;
                        break;

                    // Noise ($400C..$400F)
                    case 0x400C:
                        _noise.LengthHalt = (val & 0x20) != 0;
                        _noise.ConstantVolume = (val & 0x10) != 0;
                        _noise.VolumeOrPeriod = val & 0x0F;
                        break;
                    case 0x400E:
                        _noise.ModeFlag = (val & 0x80) != 0;
                        _noise.TimerPeriod = NoisePeriodTable[val & 0x0F];
                        break;
                    case 0x400F:
                        if (_noise.Enabled) _noise.LengthCounter = LengthTable[(val >> 3) & 0x1F];
                        _noise.EnvelopeStart = true;
                        break;

                    // DMC Direct Load ($4011 - usado en SoundEngine $F2D0: DAT_4011 = DAT_07c0)
                    case 0x4011:
                        _dmcDirectLoad = val & 0x7F;
                        break;

                    // APU Status ($4015)
                    case 0x4015:
                        _pulse1.Enabled = (val & 0x01) != 0;
                        if (!_pulse1.Enabled) _pulse1.LengthCounter = 0;
                        _pulse2.Enabled = (val & 0x02) != 0;
                        if (!_pulse2.Enabled) _pulse2.LengthCounter = 0;
                        _triangle.Enabled = (val & 0x04) != 0;
                        if (!_triangle.Enabled) _triangle.LengthCounter = 0;
                        _noise.Enabled = (val & 0x08) != 0;
                        if (!_noise.Enabled) _noise.LengthCounter = 0;
                        break;
                }
            }
        }

        /// <summary>
        /// Avanza los contadores de envolvente (240 Hz) y barrido/duración (120 Hz) de la APU.
        /// Se invoca 4 veces por cada frame de 60 Hz (240 Hz Quarter-Frame).
        /// </summary>
        public void StepFrameCounterQuarter(bool isHalfFrame)
        {
            lock (_sync)
            {
                _pulse1.ClockEnvelope();
                _pulse2.ClockEnvelope();

                // Envolvente del canal de ruido
                if (_noise.EnvelopeStart)
                {
                    _noise.EnvelopeStart = false;
                    _noise.EnvelopeDecay = 15;
                    _noise.EnvelopeDivider = _noise.VolumeOrPeriod;
                }
                else if (_noise.EnvelopeDivider > 0)
                {
                    _noise.EnvelopeDivider--;
                }
                else
                {
                    _noise.EnvelopeDivider = _noise.VolumeOrPeriod;
                    if (_noise.EnvelopeDecay > 0) _noise.EnvelopeDecay--;
                    else if (_noise.LengthHalt) _noise.EnvelopeDecay = 15;
                }

                // Contador lineal del triángulo
                if (_triangle.LinearReloadFlag)
                {
                    _triangle.LinearCounter = _triangle.LinearReloadValue;
                }
                else if (_triangle.LinearCounter > 0)
                {
                    _triangle.LinearCounter--;
                }
                if (!_triangle.ControlFlag)
                {
                    _triangle.LinearReloadFlag = false;
                }

                if (isHalfFrame)
                {
                    _pulse1.ClockSweepAndLength();
                    _pulse2.ClockSweepAndLength();
                    if (!_triangle.ControlFlag && _triangle.LengthCounter > 0)
                        _triangle.LengthCounter--;
                    if (!_noise.LengthHalt && _noise.LengthCounter > 0)
                        _noise.LengthCounter--;
                }
            }
        }

        /// <summary>
        /// Sintetiza muestras PCM de 16 bits con signo a 48,000 Hz aplicando la ecuación no lineal
        /// de mezcla 2A03 documentada en la Sección 5.1 del Volumen 1.
        /// </summary>
        public void RenderPcm16Samples(short[] buffer, int offset, int sampleCount)
        {
            if (Muted)
            {
                Array.Clear(buffer, offset, sampleCount);
                return;
            }

            const double cpuCyclesPerSample = CpuClockHz / SampleRate; // ~37.2869 ciclos CPU / muestra
            const double apuCyclesPerSample = cpuCyclesPerSample * 0.5;

            lock (_sync)
            {
                for (int i = 0; i < sampleCount; i++)
                {
                    // Avanzar fase de Pulse 1
                    if (_pulse1.TimerPeriod >= 8)
                    {
                        _pulse1.Phase += apuCyclesPerSample;
                        double p1Period = _pulse1.TimerPeriod + 1;
                        while (_pulse1.Phase >= p1Period)
                        {
                            _pulse1.Phase -= p1Period;
                            _pulse1.DutyStep = (_pulse1.DutyStep + 1) & 7;
                        }
                    }

                    // Avanzar fase de Pulse 2
                    if (_pulse2.TimerPeriod >= 8)
                    {
                        _pulse2.Phase += apuCyclesPerSample;
                        double p2Period = _pulse2.TimerPeriod + 1;
                        while (_pulse2.Phase >= p2Period)
                        {
                            _pulse2.Phase -= p2Period;
                            _pulse2.DutyStep = (_pulse2.DutyStep + 1) & 7;
                        }
                    }

                    // Avanzar fase de Triangle (corre a velocidad de reloj CPU completo)
                    if (_triangle.TimerPeriod >= 2 && _triangle.LengthCounter > 0 && _triangle.LinearCounter > 0)
                    {
                        _triangle.Phase += cpuCyclesPerSample;
                        double triPeriod = _triangle.TimerPeriod + 1;
                        while (_triangle.Phase >= triPeriod)
                        {
                            _triangle.Phase -= triPeriod;
                            _triangle.SeqStep = (_triangle.SeqStep + 1) & 31;
                        }
                    }

                    // Avanzar LFSR de 15 bits del canal Noise
                    _noise.TimerCounter += cpuCyclesPerSample;
                    double nPeriod = Math.Max(4, _noise.TimerPeriod);
                    while (_noise.TimerCounter >= nPeriod)
                    {
                        _noise.TimerCounter -= nPeriod;
                        int tapBit = _noise.ModeFlag ? ((_noise.Lfsr >> 6) & 1) : ((_noise.Lfsr >> 1) & 1);
                        int feedback = (_noise.Lfsr & 1) ^ tapBit;
                        _noise.Lfsr = (_noise.Lfsr >> 1) | (feedback << 14);
                    }

                    // Mezclador no lineal 2A03 exacto
                    int p1Out = _pulse1.GetOutput();
                    int p2Out = _pulse2.GetOutput();
                    int triOut = _triangle.GetOutput();
                    int noiseOut = _noise.GetOutput();
                    int dmcOut = _dmcDirectLoad;

                    double pulseMix = (p1Out + p2Out > 0)
                        ? (95.88 / ((8128.0 / (p1Out + p2Out)) + 100.0))
                        : 0.0;

                    double tndSum = (triOut / 8227.0) + (noiseOut / 12241.0) + (dmcOut / 22638.0);
                    double tndMix = (tndSum > 0.0)
                        ? (159.79 / ((1.0 / tndSum) + 100.0))
                        : 0.0;

                    double normalized = ((pulseMix + tndMix) * 2.2) - 0.45;
                    int pcm = (int)(normalized * 24000.0 * MasterVolume);
                    if (pcm > short.MaxValue) pcm = short.MaxValue;
                    else if (pcm < short.MinValue) pcm = short.MinValue;

                    buffer[offset + i] = (short)pcm;
                }
            }
        }
    }
}
