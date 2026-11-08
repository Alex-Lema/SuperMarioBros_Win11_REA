using System;
using System.IO;
using System.Security.Cryptography;

namespace SuperMarioBros_Win11.Core
{
    /// <summary>
    /// Carga y verifica la imagen ROM original de Super Mario Bros. (iNES Mapper 0 / NROM-256)
    /// conforme a la especificación del Volumen 1 (Sección 1 y 4.1) y Volumen 2 (Sección 6).
    /// </summary>
    public sealed class SmbRomImage
    {
        public const int INesHeaderSize = 16;
        public const int PrgRomSize = 32768; // $8000..$FFFF (32 KB)
        public const int ChrRomSize = 8192;  // $0000..$1FFF (8 KB)
        public const string ExpectedRomSha256 = "f61548fdf1670cffefcc4f0b7bdcdd9eaba0c226e3b74f8666071496988248de";
        public const string ExpectedPrgSha256 = "5374abb64cfb9b5d961856c60166cedc55859164cf2b8867730e144fa2bdd594";

        public string SourcePath { get; }
        public string RomSha256 { get; }
        public string PrgSha256 { get; }
        public bool VerticalMirroring { get; }
        public byte[] PrgRom { get; } = new byte[PrgRomSize];
        public byte[] ChrRom { get; } = new byte[ChrRomSize];

        /// <summary>
        /// Caché pre-decodificada de los 512 tiles 2bpp (512 tiles * 8 filas * 8 columnas = 32,768 bytes, valores 0..3).
        /// Permite al renderizador PPU 2C02 muestrear píxeles sin decodificar bitplanes en cada frame.
        /// </summary>
        public byte[] DecodedChrPixels { get; } = new byte[512 * 64];

        private SmbRomImage(string path, byte[] rawBytes)
        {
            SourcePath = path;
            if (rawBytes.Length < INesHeaderSize + PrgRomSize + ChrRomSize)
            {
                throw new InvalidDataException($"El archivo ROM '{path}' es demasiado pequeño ({rawBytes.Length} bytes). Se esperaban 40,976 bytes.");
            }

            if (rawBytes[0] != 0x4E || rawBytes[1] != 0x45 || rawBytes[2] != 0x53 || rawBytes[3] != 0x1A)
            {
                throw new InvalidDataException("Encabezado iNES inválido: no comienza con 'NES\\x1A' (4E 45 53 1A).");
            }

            VerticalMirroring = (rawBytes[6] & 0x01) != 0;

            Buffer.BlockCopy(rawBytes, INesHeaderSize, PrgRom, 0, PrgRomSize);
            Buffer.BlockCopy(rawBytes, INesHeaderSize + PrgRomSize, ChrRom, 0, ChrRomSize);

            using (var sha = SHA256.Create())
            {
                RomSha256 = Convert.ToHexString(sha.ComputeHash(rawBytes)).ToLowerInvariant();
                PrgSha256 = Convert.ToHexString(sha.ComputeHash(PrgRom)).ToLowerInvariant();
            }

            PredecodeChrTiles();
        }

        private void PredecodeChrTiles()
        {
            for (int tileIdx = 0; tileIdx < 512; tileIdx++)
            {
                int chrBase = tileIdx * 16;
                int pixelBase = tileIdx * 64;
                for (int row = 0; row < 8; row++)
                {
                    byte plane0 = ChrRom[chrBase + row];
                    byte plane1 = ChrRom[chrBase + row + 8];
                    int rowOffset = pixelBase + (row * 8);
                    for (int col = 0; col < 8; col++)
                    {
                        int shift = 7 - col;
                        int bit0 = (plane0 >> shift) & 1;
                        int bit1 = (plane1 >> shift) & 1;
                        DecodedChrPixels[rowOffset + col] = (byte)(bit0 | (bit1 << 1));
                    }
                }
            }
        }

        public static SmbRomImage LoadFromDefaultLocations(string explicitPath = null)
        {
            string[] candidates = new[]
            {
                explicitPath,
                Path.Combine(AppContext.BaseDirectory, "smb.nes"),
                Path.Combine(Environment.CurrentDirectory, "smb.nes"),
                Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "..", "smb.nes"),
                @"c:\Antigravity_Projects\SuperMarioBros_REA\smb.nes"
            };

            foreach (string candidate in candidates)
            {
                if (!string.IsNullOrWhiteSpace(candidate) && File.Exists(candidate))
                {
                    string full = Path.GetFullPath(candidate);
                    return new SmbRomImage(full, File.ReadAllBytes(full));
                }
            }

            throw new FileNotFoundException("No se encontró el archivo 'smb.nes'. Coloque 'smb.nes' junto al ejecutable SuperMarioBros_Win11.exe.");
        }
    }
}
