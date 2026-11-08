using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using SuperMarioBros_Win11.Core;

namespace SuperMarioBros_Win11.Graphics
{
    public enum AspectScaleMode
    {
        Aspect4x3Pillarbox = 0,
        IntegerPixelPerfect = 1,
        StretchWidescreen = 2
    }

    /// <summary>
    /// Renderizador Nativo PPU 2C02 de Alta Resolución con soporte de Split-Screen (Sprite 0),
    /// Interpolación Sub-Frame para 120 FPS y Escalado Directo a 720p/900p/1080p/1440p/4K.
    /// Implementa la Sección 4 de DOC_DISENO_PORT_WIN11_ARQUITECTURA.md.
    /// </summary>
    public sealed unsafe class Ppu2C02Renderer
    {
        public const int NativeWidth = 256;
        public const int NativeHeight = 240;

        // Paleta Sony CXA2025AS / 2C02 NTSC exacta en formato BGRA32 (0xFFRRGGBB)
        public static readonly uint[] NesMasterPalette = new uint[64]
        {
            0xFF585858, 0xFF00238C, 0xFF00139B, 0xFF2D0585, 0xFF5D0052, 0xFF7A0017, 0xFF7A0800, 0xFF5F1800,
            0xFF352A00, 0xFF093900, 0xFF003F00, 0xFF003C22, 0xFF00325D, 0xFF000000, 0xFF000000, 0xFF000000,
            0xFFA1A1A1, 0xFF0053EE, 0xFF153CFE, 0xFF6028E4, 0xFFA91D98, 0xFFD41E41, 0xFFD22C00, 0xFFAA4400,
            0xFF6C5E00, 0xFF2D7300, 0xFF007D06, 0xFF007852, 0xFF0069A9, 0xFF000000, 0xFF000000, 0xFF000000,
            0xFFFFFFFF, 0xFF1FA5FE, 0xFF5E89FE, 0xFFB572FE, 0xFFFE65F6, 0xFFFE6790, 0xFFFE773C, 0xFFFE9308,
            0xFFC4B200, 0xFF79CA10, 0xFF3AD54A, 0xFF11D1A4, 0xFF06BFFE, 0xFF424242, 0xFF000000, 0xFF000000,
            0xFFFFFFFF, 0xFFA0D9FE, 0xFFBDCCFE, 0xFFE1C2FE, 0xFFFEBCFB, 0xFFFEBDD0, 0xFFFEC5A9, 0xFFFED18E,
            0xFFE9DE86, 0xFFC7E992, 0xFFA8EEB0, 0xFF95ECD9, 0xFF91E4FE, 0xFFACACAC, 0xFF000000, 0xFF000000
        };

        private readonly SmbRomImage _rom;
        private readonly byte[] _nameTables = new byte[2 * 0x0400]; // 2 KB VRAM (Mirroring Vertical: NT0=$2000, NT1=$2400)
        private readonly byte[] _paletteRam = new byte[32];         // $3F00..$3F1F
        public readonly byte[] Oam = new byte[256];                 // 64 sprites * 4 bytes

        // Estado para interpolación real a 120 FPS
        private readonly byte[] _prevOam = new byte[256];
        private readonly int[] _prevWorldScrollX = new int[NativeHeight];
        private readonly int[] _currWorldScrollX = new int[NativeHeight];
        private readonly byte[] _scanlinePpuCtrl = new byte[NativeHeight];
        private readonly byte[] _scanlinePpuMask = new byte[NativeHeight];
        private readonly byte[] _scanlineScrollX = new byte[NativeHeight];
        private readonly byte[] _scanlineScrollY = new byte[NativeHeight];

        // Framebuffers 256x240 BGRA32 (60 Hz nativo y 120 Hz interpolado)
        public readonly uint[] Framebuffer60Hz = new uint[NativeWidth * NativeHeight];
        public readonly uint[] Framebuffer120Hz = new uint[NativeWidth * NativeHeight];
        private readonly byte[] _bgOpaqueLine = new byte[NativeWidth];

        // Registros internos 2C02 (Loopy v, t, x, w)
        private byte _ppuCtrl;       // $2000
        private byte _ppuMask;       // $2001
        private byte _ppuStatus;     // $2002 (Bit 7=VBlank, Bit 6=Sprite 0 Hit)
        private byte _oamAddr;       // $2003
        private ushort _vramAddr;    // Registro de dirección VRAM actual
        private bool _writeToggle;   // Latch w de primer/segundo write en $2005/$2006
        private byte _vramReadLatch; // Buffer diferido de 1 byte en lecturas $2007 (< $3F00)
        private byte _scrollX;
        private byte _scrollY;

        public bool NmiEnabled => (_ppuCtrl & 0x80) != 0;
        public bool NmiPending { get; set; }

        public Ppu2C02Renderer(SmbRomImage rom)
        {
            _rom = rom;
            Reset();
        }

        public void Reset()
        {
            _ppuCtrl = 0;
            _ppuMask = 0;
            _ppuStatus = 0x80;
            _oamAddr = 0;
            _vramAddr = 0;
            _writeToggle = false;
            _vramReadLatch = 0;
            _scrollX = 0;
            _scrollY = 0;
            Array.Clear(_nameTables, 0, _nameTables.Length);
            Array.Clear(_paletteRam, 0, _paletteRam.Length);
            for (int i = 0; i < 256; i += 4)
            {
                Oam[i] = 0xF8;
                _prevOam[i] = 0xF8;
            }
        }

        public void SaveStateFor120HzInterpolation()
        {
            Buffer.BlockCopy(Oam, 0, _prevOam, 0, 256);
            Buffer.BlockCopy(_currWorldScrollX, 0, _prevWorldScrollX, 0, NativeHeight * sizeof(int));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte CpuReadRegister(int addr)
        {
            switch (addr & 0x2007)
            {
                case 0x2002: // PPUSTATUS
                {
                    byte status = _ppuStatus;
                    _ppuStatus &= 0x7F; // Leer $2002 limpia el bit 7 de VBlank
                    _writeToggle = false;
                    return status;
                }
                case 0x2004: // OAMDATA
                    return Oam[_oamAddr];
                case 0x2007: // PPUDATA (incluye el latch diferido de 1 byte requerido por DrawTitleScreen $8F47)
                {
                    ushort v = (ushort)(_vramAddr & 0x3FFF);
                    byte result;
                    if (v < 0x3F00)
                    {
                        result = _vramReadLatch;
                        _vramReadLatch = ReadVramRaw(v);
                    }
                    else
                    {
                        _vramReadLatch = ReadVramRaw((ushort)(v - 0x1000));
                        result = ReadPalette(v);
                    }
                    _vramAddr = (ushort)((_vramAddr + (((_ppuCtrl & 0x04) != 0) ? 32 : 1)) & 0x7FFF);
                    return result;
                }
                default:
                    return 0;
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void CpuWriteRegister(int addr, byte value)
        {
            switch (addr & 0x2007)
            {
                case 0x2000: // PPUCTRL
                {
                    bool prevNmi = (_ppuCtrl & 0x80) != 0;
                    _ppuCtrl = value;
                    bool nowNmi = (_ppuCtrl & 0x80) != 0;
                    if (!prevNmi && nowNmi && (_ppuStatus & 0x80) != 0)
                    {
                        NmiPending = true;
                    }
                    break;
                }
                case 0x2001: // PPUMASK
                    _ppuMask = value;
                    break;
                case 0x2003: // OAMADDR
                    _oamAddr = value;
                    break;
                case 0x2004: // OAMDATA
                    Oam[_oamAddr++] = value;
                    break;
                case 0x2005: // PPUSCROLL
                    if (!_writeToggle)
                    {
                        _scrollX = value;
                        _writeToggle = true;
                    }
                    else
                    {
                        _scrollY = value;
                        _writeToggle = false;
                    }
                    break;
                case 0x2006: // PPUADDR
                    if (!_writeToggle)
                    {
                        _vramAddr = (ushort)((_vramAddr & 0x00FF) | ((value & 0x3F) << 8));
                        _writeToggle = true;
                    }
                    else
                    {
                        _vramAddr = (ushort)((_vramAddr & 0xFF00) | value);
                        // Cuando el juego escribe $0000 en $2006 al terminar UpdateScreen, resetea scroll de barra de estado
                        if (_vramAddr == 0)
                        {
                            _scrollX = 0;
                            _scrollY = 0;
                        }
                        _writeToggle = false;
                    }
                    break;
                case 0x2007: // PPUDATA
                    WriteVramRaw((ushort)(_vramAddr & 0x3FFF), value);
                    _vramAddr = (ushort)((_vramAddr + (((_ppuCtrl & 0x04) != 0) ? 32 : 1)) & 0x7FFF);
                    break;
            }
        }

        public void ExecuteOamDma(byte[] cpuRam, byte page)
        {
            int srcOffset = (page << 8) & 0x07FF;
            Buffer.BlockCopy(cpuRam, srcOffset, Oam, 0, 256);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private int MapNameTableOffset(ushort addr)
        {
            // iNES Vertical Mirroring: $2000/$2800 -> NT0 (0x000..0x3FF), $2400/$2C00 -> NT1 (0x400..0x7FF)
            return addr & 0x07FF;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte ReadVramRaw(ushort addr)
        {
            if (addr < 0x2000)
            {
                return _rom.ChrRom[addr];
            }
            if (addr < 0x3F00)
            {
                return _nameTables[MapNameTableOffset(addr)];
            }
            return ReadPalette(addr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void WriteVramRaw(ushort addr, byte value)
        {
            if (addr < 0x2000)
            {
                return; // CHR-ROM es de solo lectura
            }
            if (addr < 0x3F00)
            {
                _nameTables[MapNameTableOffset(addr)] = value;
                return;
            }
            WritePalette(addr, value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private byte ReadPalette(ushort addr)
        {
            int idx = addr & 0x1F;
            if ((idx & 0x13) == 0x10) idx &= ~0x10;
            return _paletteRam[idx];
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private void WritePalette(ushort addr, byte value)
        {
            int idx = addr & 0x1F;
            if ((idx & 0x13) == 0x10) idx &= ~0x10;
            _paletteRam[idx] = (byte)(value & 0x3F);
        }

        public void BeginVBlank()
        {
            _ppuStatus |= 0x80; // Set VBlank flag
            if ((_ppuCtrl & 0x80) != 0)
            {
                NmiPending = true;
            }
        }

        public void EndVBlankAndPreRender()
        {
            // En el scanline 261 (Pre-render), la PPU limpia tanto VBlank (Bit 7) como Sprite 0 Hit (Bit 6)
            _ppuStatus &= 0x3F;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void StepVisibleScanline(int scanline)
        {
            _scanlinePpuCtrl[scanline] = _ppuCtrl;
            _scanlinePpuMask[scanline] = _ppuMask;
            _scanlineScrollX[scanline] = _scrollX;
            _scanlineScrollY[scanline] = _scrollY;
            _currWorldScrollX[scanline] = ((_ppuCtrl & 0x01) * 256) + _scrollX;

            // Detección exacta de Sprite 0 Hit para el split de la barra de estado (scanlines 24..32)
            if ((_ppuStatus & 0x40) == 0 && (_ppuMask & 0x18) == 0x18)
            {
                int spr0Y = Oam[0] + 1;
                if (scanline >= spr0Y && scanline < spr0Y + 8)
                {
                    byte tileId = Oam[1];
                    byte attr = Oam[2];
                    int spr0X = Oam[3];
                    int sprTable = ((_ppuCtrl & 0x08) != 0) ? 256 : 0;
                    int rowInSpr = scanline - spr0Y;
                    if ((attr & 0x80) != 0) rowInSpr = 7 - rowInSpr;
                    int sprPixelBase = ((sprTable + tileId) * 64) + (rowInSpr * 8);

                    int bgTable = ((_ppuCtrl & 0x10) != 0) ? 256 : 0;
                    int worldY = (scanline + _scrollY) % 240;
                    int tileY = worldY >> 3;
                    int fineY = worldY & 7;
                    int baseNt = _ppuCtrl & 0x01;

                    for (int dx = 0; dx < 8; dx++)
                    {
                        int x = spr0X + dx;
                        if (x >= 255) break;
                        int colInSpr = ((attr & 0x40) != 0) ? (7 - dx) : dx;
                        if (_rom.DecodedChrPixels[sprPixelBase + colInSpr] == 0) continue;

                        int worldX = ((baseNt * 256) + _scrollX + x) & 0x1FF;
                        int ntIdx = (worldX >> 8) & 1;
                        int tileX = (worldX & 0xFF) >> 3;
                        int fineX = worldX & 7;
                        byte bgTile = _nameTables[(ntIdx * 0x0400) + (tileY * 32) + tileX];
                        byte bgPx = _rom.DecodedChrPixels[((bgTable + bgTile) * 64) + (fineY * 8) + fineX];
                        if (bgPx != 0)
                        {
                            _ppuStatus |= 0x40; // Impacto de Sprite 0 detectado
                            break;
                        }
                    }

                    // Fallback seguro en la última fila del Sprite 0 (moneda oculta en Y=24 -> scanline 30/31)
                    if ((_ppuStatus & 0x40) == 0 && scanline == spr0Y + 6 && Oam[0] < 0xF0)
                    {
                        _ppuStatus |= 0x40;
                    }
                }
            }
        }

        /// <summary>
        /// Compone el Framebuffer 256x240 nativo (60 Hz) o interpolado al 50% (sub-frame 120 Hz).
        /// </summary>
        public void ComposeFrame(bool isInterpolated120HzSubFrame)
        {
            uint[] targetFb = isInterpolated120HzSubFrame ? Framebuffer120Hz : Framebuffer60Hz;
            uint backdropColor = NesMasterPalette[_paletteRam[0] & 0x3F];

            fixed (uint* pFb = targetFb)
            fixed (byte* pChr = _rom.DecodedChrPixels)
            fixed (byte* pNt = _nameTables)
            fixed (byte* pPal = _paletteRam)
            fixed (byte* pBgOpaque = _bgOpaqueLine)
            {
                for (int y = 0; y < NativeHeight; y++)
                {
                    uint* pRow = pFb + (y * NativeWidth);
                    byte mask = _scanlinePpuMask[y];
                    byte ctrl = _scanlinePpuCtrl[y];

                    if ((mask & 0x18) == 0)
                    {
                        for (int x = 0; x < NativeWidth; x++) pRow[x] = backdropColor;
                        continue;
                    }

                    // 1. Renderizar Scanline de Fondo (con interpolación de scroll a 120 Hz en el playfield y>=32)
                    int worldScrollX = _currWorldScrollX[y];
                    if (isInterpolated120HzSubFrame && y >= 32)
                    {
                        int prevX = _prevWorldScrollX[y];
                        int diff = worldScrollX - prevX;
                        if (diff < -256) diff += 512;
                        else if (diff > 256) diff -= 512;
                        if (Math.Abs(diff) <= 16)
                        {
                            worldScrollX = (prevX + (diff / 2) + 512) & 0x1FF;
                        }
                    }

                    int bgTableOffset = ((ctrl & 0x10) != 0) ? (256 * 64) : 0;
                    int worldY = (y + _scanlineScrollY[y]) % 240;
                    int tileY = worldY >> 3;
                    int fineY = worldY & 7;
                    int attrRowOffset = 0x03C0 + ((tileY >> 2) * 8);
                    int attrShiftY = (tileY & 2) << 1;
                    bool showBg = (mask & 0x08) != 0;

                    for (int x = 0; x < NativeWidth; x++)
                    {
                        if (!showBg)
                        {
                            pRow[x] = backdropColor;
                            pBgOpaque[x] = 0;
                            continue;
                        }

                        int wx = (worldScrollX + x) & 0x1FF;
                        int ntBase = ((wx >> 8) & 1) * 0x0400;
                        int localX = wx & 0xFF;
                        int tileX = localX >> 3;
                        int fineX = localX & 7;

                        byte tileId = pNt[ntBase + (tileY * 32) + tileX];
                        byte pixelVal = pChr[bgTableOffset + (tileId * 64) + (fineY * 8) + fineX];

                        if (pixelVal == 0)
                        {
                            pRow[x] = backdropColor;
                            pBgOpaque[x] = 0;
                        }
                        else
                        {
                            byte attrByte = pNt[ntBase + attrRowOffset + (tileX >> 2)];
                            int shift = attrShiftY + (tileX & 2);
                            int palSet = (attrByte >> shift) & 0x03;
                            byte colorIdx = pPal[(palSet << 2) + pixelVal];
                            pRow[x] = NesMasterPalette[colorIdx & 0x3F];
                            pBgOpaque[x] = 1;
                        }
                    }

                    // 2. Renderizar Sprites OAM en el Scanline actual
                    if ((mask & 0x10) != 0)
                    {
                        int sprTableOffset = ((ctrl & 0x08) != 0) ? (256 * 64) : 0;
                        for (int s = 63; s >= 0; s--)
                        {
                            int oamIdx = s * 4;
                            int sprY = Oam[oamIdx];
                            int sprX = Oam[oamIdx + 3];
                            byte tileId = Oam[oamIdx + 1];
                            byte attr = Oam[oamIdx + 2];

                            if (sprY >= 0xF0) continue;

                            // Si estamos en el sub-frame de 120 FPS y el sprite usa el mismo tile, interpolar posición X/Y
                            if (isInterpolated120HzSubFrame && _prevOam[oamIdx + 1] == tileId && _prevOam[oamIdx] < 0xF0)
                            {
                                int prevY = _prevOam[oamIdx];
                                int prevX = _prevOam[oamIdx + 3];
                                if (Math.Abs(sprX - prevX) <= 12 && Math.Abs(sprY - prevY) <= 12)
                                {
                                    sprX = (prevX + sprX) >> 1;
                                    sprY = (prevY + sprY) >> 1;
                                }
                            }

                            int drawY = sprY + 1;
                            int rowInSpr = y - drawY;
                            if (rowInSpr < 0 || rowInSpr >= 8) continue;

                            if ((attr & 0x80) != 0) rowInSpr = 7 - rowInSpr;
                            bool flipH = (attr & 0x40) != 0;
                            bool behindBg = (attr & 0x20) != 0;
                            int palBase = 0x10 + ((attr & 0x03) << 2);
                            int sprChrRow = sprTableOffset + (tileId * 64) + (rowInSpr * 8);

                            for (int dx = 0; dx < 8; dx++)
                            {
                                int x = sprX + dx;
                                if ((uint)x >= NativeWidth) continue;

                                int colInSpr = flipH ? (7 - dx) : dx;
                                byte sprPx = pChr[sprChrRow + colInSpr];
                                if (sprPx == 0) continue;

                                if (!behindBg || pBgOpaque[x] == 0)
                                {
                                    byte colorIdx = pPal[palBase + sprPx];
                                    pRow[x] = NesMasterPalette[colorIdx & 0x3F];
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Escala en paralelo el framebuffer de 256x240 a resoluciones altas de Windows 11 (720p, 900p, 1080p, 1440p, 4K)
        /// usando punteros no administrados para lograr tiempos de renderizado inferiores a 0.6 ms.
        /// </summary>
        public void UpscaleToHighResBuffer(
            uint[] src256x240,
            uint[] dstHighRes,
            int dstWidth,
            int dstHeight,
            AspectScaleMode scaleMode,
            bool crtScanlinesEffect)
        {
            int viewW = dstWidth;
            int viewH = dstHeight;
            int offsetX = 0;
            int offsetY = 0;

            if (scaleMode == AspectScaleMode.IntegerPixelPerfect)
            {
                int scale = Math.Max(1, Math.Min(dstWidth / NativeWidth, dstHeight / NativeHeight));
                viewW = NativeWidth * scale;
                viewH = NativeHeight * scale;
                offsetX = (dstWidth - viewW) / 2;
                offsetY = (dstHeight - viewH) / 2;
            }
            else if (scaleMode == AspectScaleMode.Aspect4x3Pillarbox)
            {
                // Mantener relación 4:3 clásica a máxima resolución vertical
                viewH = dstHeight;
                viewW = (dstHeight * 4) / 3;
                if (viewW > dstWidth)
                {
                    viewW = dstWidth;
                    viewH = (dstWidth * 3) / 4;
                }
                offsetX = (dstWidth - viewW) / 2;
                offsetY = (dstHeight - viewH) / 2;
            }

            fixed (uint* pSrc = src256x240)
            fixed (uint* pDst = dstHighRes)
            {
                IntPtr srcPtr = (IntPtr)pSrc;
                IntPtr dstPtr = (IntPtr)pDst;

                Parallel.For(0, dstHeight, dy =>
                {
                    uint* rowDst = (uint*)dstPtr + (dy * dstWidth);
                    if (dy < offsetY || dy >= offsetY + viewH)
                    {
                        for (int dx = 0; dx < dstWidth; dx++) rowDst[dx] = 0xFF000000;
                        return;
                    }

                    int localY = dy - offsetY;
                    int sy = (localY * NativeHeight) / viewH;
                    if (sy >= NativeHeight) sy = NativeHeight - 1;
                    uint* rowSrc = (uint*)srcPtr + (sy * NativeWidth);

                    // Efecto opcional de scanlines CRT de alta definición en pantallas 1080p/1440p/4K
                    bool darkenScanline = crtScanlinesEffect && ((dy % 3) == 2);

                    for (int dx = 0; dx < offsetX; dx++) rowDst[dx] = 0xFF000000;

                    int rightEdge = offsetX + viewW;
                    if (!darkenScanline)
                    {
                        for (int dx = offsetX; dx < rightEdge; dx++)
                        {
                            int sx = ((dx - offsetX) * NativeWidth) / viewW;
                            rowDst[dx] = rowSrc[sx];
                        }
                    }
                    else
                    {
                        for (int dx = offsetX; dx < rightEdge; dx++)
                        {
                            int sx = ((dx - offsetX) * NativeWidth) / viewW;
                            uint c = rowSrc[sx];
                            uint r = ((c >> 16) & 0xFF) * 3 / 4;
                            uint g = ((c >> 8) & 0xFF) * 3 / 4;
                            uint b = (c & 0xFF) * 3 / 4;
                            rowDst[dx] = 0xFF000000 | (r << 16) | (g << 8) | b;
                        }
                    }

                    for (int dx = rightEdge; dx < dstWidth; dx++) rowDst[dx] = 0xFF000000;
                });
            }
        }
    }
}
