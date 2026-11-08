using System;
using System.Runtime.CompilerServices;
using SuperMarioBros_Win11.Recompiled;

namespace SuperMarioBros_Win11.Core
{
    public sealed partial class SmbEngineCore
    {
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private void ExecuteNativeBlock_E000_FFFF(long targetCycles)
        {
            switch (PC)
            {
                case 0xE001:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE067; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE067; }
                    PC = 0xE003; goto case 0xE003;
                case 0xE003:
                    Y = _ram[0x02]; SetZN(Y); TotalCycles += 3; PC = 0xE005;
                    goto case 0xE005;
                case 0xE005:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE007;
                    goto case 0xE007;
                case 0xE006:
                    TotalCycles += 7; PushU16(0xE008); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE007:
                    WriteMem(ReadU16Zp(0x06) + Y, A); TotalCycles += 6; PC = 0xE009;
                    goto case 0xE009;
                case 0xE008:
                    _ram[0xB5] = Asl(_ram[0xB5]); TotalCycles += 5; PC = 0xE00A;
                    goto case 0xE00A;
                case 0xE009:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE00B;
                    goto case 0xE00B;
                case 0xE00A:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE00C;
                    goto case 0xE00C;
                case 0xE00B:
                    Cmp(A, 0x15); TotalCycles += 2; PC = 0xE00D;
                    goto case 0xE00D;
                case 0xE00C:
                    A |= _ram[(byte)(0xB0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE00E;
                    return;
                case 0xE00D:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE01B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE01B; }
                    PC = 0xE00F; goto case 0xE00F;
                case 0xE00F:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0xE011;
                    goto case 0xE011;
                case 0xE010:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xE012;
                    return;
                case 0xE011:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE016; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE016; }
                    PC = 0xE013; goto case 0xE013;
                case 0xE013:
                    TotalCycles += 6; PushU16(0xE015); PC = 0xE18E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE18E;
                case 0xE014:
                    WriteIoReg(0xA9E1, X); TotalCycles += 4; PC = 0xE017;
                    goto case 0xE017;
                case 0xE015:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xA9 + X)))); TotalCycles += 6; PC = 0xE017;
                    goto case 0xE017;
                case 0xE016:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xE018;
                    goto case 0xE018;
                case 0xE017:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xE019;
                    goto case 0xE019;
                case 0xE018:
                    TotalCycles += 6; PushU16(0xE01A); PC = 0xDA11;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE019:
                    A |= ReadMem(ReadU16Zp(0xDA) + Y); SetZN(A); TotalCycles += 5; PC = 0xE01B;
                    goto case 0xE01B;
                case 0xE01B: // === SUBROUTINE: Sub_E01B ===
                    Cmp(A, 0x09); TotalCycles += 2; PC = 0xE01D;
                    goto case 0xE01D;
                case 0xE01C:
                    A |= 0x90; SetZN(A); TotalCycles += 2; PC = 0xE01E;
                    goto case 0xE01E;
                case 0xE01D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE02F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE02F; }
                    PC = 0xE01F; goto case 0xE01F;
                case 0xE01E:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xDFE9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE020; goto case 0xE020;
                case 0xE01F:
                    Cmp(A, 0x11); TotalCycles += 2; PC = 0xE021;
                    goto case 0xE021;
                case 0xE020:
                    A |= ReadMem(ReadU16Zp(0xB0) + Y); SetZN(A); TotalCycles += 5; PC = 0xE022;
                    return;
                case 0xE021:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE02F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE02F; }
                    PC = 0xE023; goto case 0xE023;
                case 0xE023:
                    Cmp(A, 0x0A); TotalCycles += 2; PC = 0xE025;
                    goto case 0xE025;
                case 0xE024:
                    A = Asl(A); TotalCycles += 2; PC = 0xE025;
                    goto case 0xE025;
                case 0xE025:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE02B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE02B; }
                    PC = 0xE027; goto case 0xE027;
                case 0xE027:
                    Cmp(A, 0x0D); TotalCycles += 2; PC = 0xE029;
                    goto case 0xE029;
                case 0xE028:
                    A |= _ram[0x0490]; SetZN(A); TotalCycles += 4; PC = 0xE02B;
                    goto case 0xE02B;
                case 0xE029:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE02F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE02F; }
                    PC = 0xE02B; goto case 0xE02B;
                case 0xE02B:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0xE02D;
                    goto case 0xE02D;
                case 0xE02C:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xE02E;
                    goto case 0xE02E;
                case 0xE02D:
                    _ram[(byte)(0x16 + X)] = A; TotalCycles += 4; PC = 0xE02F;
                    goto case 0xE02F;
                case 0xE02E:
                    { byte z = (byte)(0xB5 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE030;
                    goto case 0xE030;
                case 0xE02F: // === SUBROUTINE: Sub_E02F ===
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE031;
                    goto case 0xE031;
                case 0xE030:
                    { int a = 0xF029 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE033;
                    goto case 0xE033;
                case 0xE031:
                    A &= 0xF0; SetZN(A); TotalCycles += 2; PC = 0xE033;
                    goto case 0xE033;
                case 0xE032:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE03D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE03D; }
                    PC = 0xE034; return;
                case 0xE033:
                    A |= 0x02; SetZN(A); TotalCycles += 2; PC = 0xE035;
                    goto case 0xE035;
                case 0xE035:
                    _ram[(byte)(0x1E + X)] = A; TotalCycles += 4; PC = 0xE037;
                    goto case 0xE037;
                case 0xE036:
                    { int a = 0xCFD6 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE039;
                    goto case 0xE039;
                case 0xE037:
                    { byte z = (byte)(0xCF + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xE039;
                    goto case 0xE039;
                case 0xE039:
                    { byte z = (byte)(0xCF + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xE03B;
                    goto case 0xE03B;
                case 0xE03B:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE03D;
                    goto case 0xE03D;
                case 0xE03C:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE03E;
                    return;
                case 0xE03D:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0xE03F;
                    goto case 0xE03F;
                case 0xE03F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE048; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE048; }
                    PC = 0xE041; goto case 0xE041;
                case 0xE041:
                    A = 0xFD; SetZN(A); TotalCycles += 2; PC = 0xE043;
                    goto case 0xE043;
                case 0xE042:
                    Sbc(ReadMem(0x4EAC + X)); TotalCycles += 4; PC = 0xE045;
                    return;
                case 0xE043:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0xE046;
                    goto case 0xE046;
                case 0xE044:
                    { int a = 0xD007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xE047;
                    return;
                case 0xE046:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE04A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE04A; }
                    PC = 0xE048; goto case 0xE048;
                case 0xE048:
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0xE04A;
                    goto case 0xE04A;
                case 0xE04A:
                    _ram[(byte)(0xA0 + X)] = A; TotalCycles += 4; PC = 0xE04C;
                    goto case 0xE04C;
                case 0xE04B:
                    Y = 0xA0; SetZN(Y); TotalCycles += 2; PC = 0xE04D;
                    goto case 0xE04D;
                case 0xE04C:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xE04E;
                    goto case 0xE04E;
                case 0xE04D:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xE04F;
                    return;
                case 0xE04E:
                    TotalCycles += 6; PushU16(0xE050); PC = 0xE143;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE143;
                case 0xE050:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x10 + X)))); TotalCycles += 6; PC = 0xE052;
                    goto case 0xE052;
                case 0xE051:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE054; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE054; }
                    PC = 0xE053; goto case 0xE053;
                case 0xE052:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xE054;
                    goto case 0xE054;
                case 0xE053:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE054;
                    goto case 0xE054;
                case 0xE054:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE056;
                    goto case 0xE056;
                case 0xE055:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE057;
                    return;
                case 0xE056:
                    Cmp(A, 0x33); TotalCycles += 2; PC = 0xE058;
                    goto case 0xE058;
                case 0xE058:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE060; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE060; }
                    PC = 0xE05A; goto case 0xE05A;
                case 0xE059:
                    _ram[0xC9] = Asl(_ram[0xC9]); TotalCycles += 5; PC = 0xE05B;
                    goto case 0xE05B;
                case 0xE05A:
                    Cmp(A, 0x08); TotalCycles += 2; PC = 0xE05C;
                    goto case 0xE05C;
                case 0xE05B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE05C;
                    goto case 0xE05C;
                case 0xE05C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE060; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE060; }
                    PC = 0xE05E; goto case 0xE05E;
                case 0xE05E:
                    _ram[(byte)(0x46 + X)] = Y; TotalCycles += 4; PC = 0xE060;
                    goto case 0xE060;
                case 0xE05F:
                    _ram[0x88] = Lsr(_ram[0x88]); TotalCycles += 5; PC = 0xE061;
                    goto case 0xE061;
                case 0xE060:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xE061;
                    goto case 0xE061;
                case 0xE061:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x5FBF + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE064;
                    goto case 0xE064;
                case 0xE064:
                    _ram[(byte)(0x58 + X)] = A; TotalCycles += 4; PC = 0xE066;
                    goto case 0xE066;
                case 0xE065:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xE066;
                    goto case 0xE066;
                case 0xE066:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE067:
                    A = _ram[0x04]; SetZN(A); TotalCycles += 3; PC = 0xE069;
                    goto case 0xE069;
                case 0xE069:
                    P |= FlagC; TotalCycles += 2; PC = 0xE06A;
                    goto case 0xE06A;
                case 0xE06A:
                    Sbc(0x08); TotalCycles += 2; PC = 0xE06C;
                    goto case 0xE06C;
                case 0xE06B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE06C;
                    goto case 0xE06C;
                case 0xE06C:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xE06E;
                    goto case 0xE06E;
                case 0xE06D:
                    A |= _ram[0xB0]; SetZN(A); TotalCycles += 3; PC = 0xE06F;
                    return;
                case 0xE06E:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE0E2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0E2; }
                    PC = 0xE070; goto case 0xE070;
                case 0xE070:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE072;
                    goto case 0xE072;
                case 0xE071:
                    { int a = 0x4029 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE074;
                    goto case 0xE074;
                case 0xE072:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0xE074;
                    goto case 0xE074;
                case 0xE073:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xE074:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE0CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0CD; }
                    PC = 0xE076; goto case 0xE076;
                case 0xE076:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE078;
                    goto case 0xE078;
                case 0xE077:
                    { int a = 0x900A + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE07A;
                    return;
                case 0xE078:
                    A = Asl(A); TotalCycles += 2; PC = 0xE079;
                    goto case 0xE079;
                case 0xE079:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE07E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE07E; }
                    PC = 0xE07B; goto case 0xE07B;
                case 0xE07B:
                    TotalCycles += 3; PC = 0xE0FE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE0FE;
                case 0xE07C:
                    { int a = 0xB5E0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xE07F;
                    goto case 0xE07F;
                case 0xE07D:
                    Cmp(X, 0xB5); TotalCycles += 2; PC = 0xE07F;
                    goto case 0xE07F;
                case 0xE07E:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE080;
                    goto case 0xE080;
                case 0xE07F:
                    { int a = 0xF9F0 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE082;
                    goto case 0xE082;
                case 0xE080:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE07B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE07B; }
                    PC = 0xE082; goto case 0xE082;
                case 0xE081:
                    Sbc(_ram[(0x05C9 + Y) & 0x07FF]); TotalCycles += 4; PC = 0xE084;
                    goto case 0xE084;
                case 0xE082:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xE084;
                    goto case 0xE084;
                case 0xE083:
                    A |= _ram[0xF0]; SetZN(A); TotalCycles += 3; PC = 0xE085;
                    return;
                case 0xE084:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE0A5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0A5; }
                    PC = 0xE086; goto case 0xE086;
                case 0xE086:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xE088;
                    goto case 0xE088;
                case 0xE088:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE0A4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0A4; }
                    PC = 0xE08A; goto case 0xE08A;
                case 0xE08A:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE08C;
                    goto case 0xE08C;
                case 0xE08B:
                    { int a = (0x02C9 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xE08E;
                    goto case 0xE08E;
                case 0xE08C:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xE08E;
                    goto case 0xE08E;
                case 0xE08E: // === SUBROUTINE: Sub_E08E ===
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE0A5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0A5; }
                    PC = 0xE090; goto case 0xE090;
                case 0xE08F:
                    A |= _ram[(byte)(0xA9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE091;
                    goto case 0xE091;
                case 0xE090:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0xE092;
                    goto case 0xE092;
                case 0xE091:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE047; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE093; goto case 0xE093;
                case 0xE092:
                    Y = _ram[(byte)(0x16 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xE094;
                    goto case 0xE094;
                case 0xE093:
                    { byte z = (byte)(0xC0 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE095;
                    return;
                case 0xE094:
                    Cmp(Y, 0x12); TotalCycles += 2; PC = 0xE096;
                    goto case 0xE096;
                case 0xE096:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE09A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE09A; }
                    PC = 0xE098; goto case 0xE098;
                case 0xE098:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE09A;
                    goto case 0xE09A;
                case 0xE099:
                    TotalCycles += 7; PushU16(0xE09B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE09A:
                    _ram[(0x0796 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xE09D;
                    goto case 0xE09D;
                case 0xE09B:
                    _ram[(byte)(0x07 + Y)] = X; TotalCycles += 4; PC = 0xE09D;
                    goto case 0xE09D;
                case 0xE09D:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xE09F;
                    goto case 0xE09F;
                case 0xE09F:
                    _ram[(byte)(0x1E + X)] = A; TotalCycles += 4; PC = 0xE0A1;
                    goto case 0xE0A1;
                case 0xE0A0:
                    { int a = 0x4F20 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE0A3;
                    goto case 0xE0A3;
                case 0xE0A1:
                    TotalCycles += 6; PushU16(0xE0A3); PC = 0xE14F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE14F;
                case 0xE0A3:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x60 + X)))); TotalCycles += 6; PC = 0xE0A5;
                    goto case 0xE0A5;
                case 0xE0A4:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE0A5:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE0A7;
                    goto case 0xE0A7;
                case 0xE0A6:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE0A8;
                    goto case 0xE0A8;
                case 0xE0A7:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0xE0A9;
                    goto case 0xE0A9;
                case 0xE0A8:
                    _ram[0xF0] = Asl(_ram[0xF0]); TotalCycles += 5; PC = 0xE0AA;
                    return;
                case 0xE0A9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE0CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0CD; }
                    PC = 0xE0AB; goto case 0xE0AB;
                case 0xE0AB:
                    Cmp(A, 0x12); TotalCycles += 2; PC = 0xE0AD;
                    goto case 0xE0AD;
                case 0xE0AD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE0BD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0BD; }
                    PC = 0xE0AF; goto case 0xE0AF;
                case 0xE0AE:
                    _ram[0x01A9] = Asl(_ram[0x01A9]); TotalCycles += 6; PC = 0xE0B1;
                    goto case 0xE0B1;
                case 0xE0AF:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xE0B1;
                    goto case 0xE0B1;
                case 0xE0B0:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xE0B2;
                    goto case 0xE0B2;
                case 0xE0B1:
                    _ram[(byte)(0x46 + X)] = A; TotalCycles += 4; PC = 0xE0B3;
                    goto case 0xE0B3;
                case 0xE0B2:
                    _ram[0xA9] = Lsr(_ram[0xA9]); TotalCycles += 5; PC = 0xE0B4;
                    goto case 0xE0B4;
                case 0xE0B3:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xE0B5;
                    goto case 0xE0B5;
                case 0xE0B4:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE0B5;
                    goto case 0xE0B5;
                case 0xE0B5:
                    _ram[(byte)(0x58 + X)] = A; TotalCycles += 4; PC = 0xE0B7;
                    goto case 0xE0B7;
                case 0xE0B6:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xE0B7;
                    goto case 0xE0B7;
                case 0xE0B7:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xE0B9;
                    goto case 0xE0B9;
                case 0xE0B8:
                    A |= 0x29; SetZN(A); TotalCycles += 2; PC = 0xE0BA;
                    return;
                case 0xE0B9:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0xE0BB;
                    goto case 0xE0BB;
                case 0xE0BB:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE0CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0CD; }
                    PC = 0xE0BD; goto case 0xE0BD;
                case 0xE0BC:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE05E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE05E; }
                    PC = 0xE0BE; goto case 0xE0BE;
                case 0xE0BD:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xE0BF;
                    goto case 0xE0BF;
                case 0xE0BE:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xE0C0;
                    return;
                case 0xE0BF:
                    TotalCycles += 6; PushU16(0xE0C1); PC = 0xE143;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE143;
                case 0xE0C1:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x10 + X)))); TotalCycles += 6; PC = 0xE0C3;
                    goto case 0xE0C3;
                case 0xE0C2:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE0C5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0C5; }
                    PC = 0xE0C4; goto case 0xE0C4;
                case 0xE0C3:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xE0C5;
                    goto case 0xE0C5;
                case 0xE0C4:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE0C5;
                    goto case 0xE0C5;
                case 0xE0C5:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xE0C6;
                    goto case 0xE0C6;
                case 0xE0C6:
                    Cmp(A, _ram[(byte)(0x46 + X)]); TotalCycles += 4; PC = 0xE0C8;
                    goto case 0xE0C8;
                case 0xE0C7:
                    _ram[0xD0] = Lsr(_ram[0xD0]); TotalCycles += 5; PC = 0xE0C9;
                    return;
                case 0xE0C8:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE0CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0CD; }
                    PC = 0xE0CA; goto case 0xE0CA;
                case 0xE0CA:
                    TotalCycles += 6; PushU16(0xE0CC); PC = 0xE124;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE124;
                case 0xE0CB:
                    Bit(_ram[0xE1]); TotalCycles += 3; PC = 0xE0CD;
                    goto case 0xE0CD;
                case 0xE0CC:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x20 + X)))); TotalCycles += 6; PC = 0xE0CE;
                    return;
                case 0xE0CD:
                    TotalCycles += 6; PushU16(0xE0CF); PC = 0xE14F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE14F;
                case 0xE0CF:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xB5 + X)))); TotalCycles += 6; PC = 0xE0D1;
                    goto case 0xE0D1;
                case 0xE0D0:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE0D2;
                    goto case 0xE0D2;
                case 0xE0D1:
                    { int a = 0x8029 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE0D4;
                    goto case 0xE0D4;
                case 0xE0D2:
                    A &= 0x80; SetZN(A); TotalCycles += 2; PC = 0xE0D4;
                    goto case 0xE0D4;
                case 0xE0D4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE0DB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0DB; }
                    PC = 0xE0D6; goto case 0xE0D6;
                case 0xE0D5:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE0D7;
                    goto case 0xE0D7;
                case 0xE0D6:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE0D8;
                    goto case 0xE0D8;
                case 0xE0D7:
                    TotalCycles += 7; PushU16(0xE0D9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE0D8:
                    _ram[(byte)(0x1E + X)] = A; TotalCycles += 4; PC = 0xE0DA;
                    goto case 0xE0DA;
                case 0xE0D9:
                    { int a = 0xB560 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE0DC;
                    goto case 0xE0DC;
                case 0xE0DA:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE0DB:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE0DD;
                    goto case 0xE0DD;
                case 0xE0DC:
                    { int a = 0xBF29 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE0DF;
                    goto case 0xE0DF;
                case 0xE0DD:
                    A &= 0xBF; SetZN(A); TotalCycles += 2; PC = 0xE0DF;
                    goto case 0xE0DF;
                case 0xE0DF:
                    _ram[(byte)(0x1E + X)] = A; TotalCycles += 4; PC = 0xE0E1;
                    goto case 0xE0E1;
                case 0xE0E0:
                    { int a = 0xB560 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE0E3;
                    goto case 0xE0E3;
                case 0xE0E1:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE0E2:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE0E4;
                    goto case 0xE0E4;
                case 0xE0E3:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE0E5;
                    return;
                case 0xE0E4:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xE0E6;
                    goto case 0xE0E6;
                case 0xE0E6:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE0EC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0EC; }
                    PC = 0xE0E8; goto case 0xE0E8;
                case 0xE0E8:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE0EA;
                    goto case 0xE0EA;
                case 0xE0E9:
                    { int a = 0x38F0 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE0EC;
                    goto case 0xE0EC;
                case 0xE0EA:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE124; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE124; }
                    PC = 0xE0EC; goto case 0xE0EC;
                case 0xE0EB:
                    P |= FlagC; TotalCycles += 2; PC = 0xE0EC;
                    goto case 0xE0EC;
                case 0xE0EC:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE0EE;
                    goto case 0xE0EE;
                case 0xE0ED:
                    { int a = 0x0AA8 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE0F0;
                    goto case 0xE0F0;
                case 0xE0EE:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE0EF;
                    goto case 0xE0EF;
                case 0xE0EF:
                    A = Asl(A); TotalCycles += 2; PC = 0xE0F0;
                    goto case 0xE0F0;
                case 0xE0F0:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE0F9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE0F9; }
                    PC = 0xE0F2; goto case 0xE0F2;
                case 0xE0F2:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE0F4;
                    goto case 0xE0F4;
                case 0xE0F3:
                    { int a = 0x4009 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE0F6;
                    goto case 0xE0F6;
                case 0xE0F4:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xE0F6;
                    goto case 0xE0F6;
                case 0xE0F5:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xE0F6:
                    TotalCycles += 3; PC = 0xE0FC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE0FC;
                case 0xE0F8:
                    Cmp(X, 0xB9); TotalCycles += 2; PC = 0xE0FA;
                    goto case 0xE0FA;
                case 0xE0F9:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x5FB9 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE0FC;
                    goto case 0xE0FC;
                case 0xE0FA:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x15DF + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE0FD;
                    goto case 0xE0FD;
                case 0xE0FC:
                    _ram[(byte)(0x1E + X)] = A; TotalCycles += 4; PC = 0xE0FE;
                    goto case 0xE0FE;
                case 0xE0FD:
                    { int a = 0xCFB5 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE100;
                    goto case 0xE100;
                case 0xE0FE:
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xE100;
                    goto case 0xE100;
                case 0xE100:
                    Cmp(A, 0x20); TotalCycles += 2; PC = 0xE102;
                    goto case 0xE102;
                case 0xE101:
                    TotalCycles += 6; PushU16(0xE103); PC = 0x1F90;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE102:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE123; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE123; }
                    PC = 0xE104; goto case 0xE104;
                case 0xE104:
                    Y = 0x16; SetZN(Y); TotalCycles += 2; PC = 0xE106;
                    goto case 0xE106;
                case 0xE105:
                    { byte z = (byte)(0xA9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE107;
                    return;
                case 0xE106:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xE108;
                    goto case 0xE108;
                case 0xE108:
                    _ram[0xEB] = A; TotalCycles += 3; PC = 0xE10A;
                    goto case 0xE10A;
                case 0xE10A:
                    A = _ram[0xEB]; SetZN(A); TotalCycles += 3; PC = 0xE10C;
                    goto case 0xE10C;
                case 0xE10C:
                    Cmp(A, _ram[(byte)(0x46 + X)]); TotalCycles += 4; PC = 0xE10E;
                    goto case 0xE10E;
                case 0xE10D:
                    _ram[0xD0] = Lsr(_ram[0xD0]); TotalCycles += 5; PC = 0xE10F;
                    return;
                case 0xE10E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE11C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE11C; }
                    PC = 0xE110; goto case 0xE110;
                case 0xE110:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xE112;
                    goto case 0xE112;
                case 0xE111:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xE113;
                    goto case 0xE113;
                case 0xE112:
                    TotalCycles += 6; PushU16(0xE114); PC = 0xE388;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE388;
                case 0xE113:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xE114;
                    return;
                case 0xE115:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE11C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE11C; }
                    PC = 0xE117; goto case 0xE117;
                case 0xE116:
                    A |= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0xE118;
                    goto case 0xE118;
                case 0xE117:
                    TotalCycles += 6; PushU16(0xE119); PC = 0xE1B5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE1B5;
                case 0xE118:
                    A = _ram[(byte)(0xE1 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE11A;
                    goto case 0xE11A;
                case 0xE119:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xD0 + X)))); TotalCycles += 6; PC = 0xE11B;
                    goto case 0xE11B;
                case 0xE11A: // === SUBROUTINE: RelativePlayerPosition ===
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE124; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE124; }
                    PC = 0xE11C; goto case 0xE11C;
                case 0xE11B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE11C;
                    goto case 0xE11C;
                case 0xE11C:
                    _ram[0xEB] = DecVal(_ram[0xEB]); TotalCycles += 5; PC = 0xE11E;
                    goto case 0xE11E;
                case 0xE11E:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE11F;
                    goto case 0xE11F;
                case 0xE11F:
                    Cmp(Y, 0x18); TotalCycles += 2; PC = 0xE121;
                    goto case 0xE121;
                case 0xE120:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE121;
                    goto case 0xE121;
                case 0xE121:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE10A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE10A; }
                    PC = 0xE123; goto case 0xE123;
                case 0xE123: // === SUBROUTINE: RelativeBubblePosition ===
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE124: // === SUBROUTINE: Sub_E124 ===
                    Cmp(X, 0x05); TotalCycles += 2; PC = 0xE126;
                    goto case 0xE126;
                case 0xE125:
                    A |= _ram[0xF0]; SetZN(A); TotalCycles += 3; PC = 0xE127;
                    goto case 0xE127;
                case 0xE126:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE131; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE131; }
                    PC = 0xE128; goto case 0xE128;
                case 0xE127:
                    A |= 0xB5; SetZN(A); TotalCycles += 2; PC = 0xE129;
                    goto case 0xE129;
                case 0xE128:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE12A;
                    goto case 0xE12A;
                case 0xE129:
                    { int a = 0x900A + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE12C;
                    return;
                case 0xE12A:
                    A = Asl(A); TotalCycles += 2; PC = 0xE12B;
                    goto case 0xE12B;
                case 0xE12B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE131; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE131; }
                    PC = 0xE12D; goto case 0xE12D;
                case 0xE12D:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xE12F;
                    goto case 0xE12F;
                case 0xE12F:
                    _ram[0xFF] = A; TotalCycles += 3; PC = 0xE131;
                    goto case 0xE131;
                case 0xE131:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE133;
                    goto case 0xE133;
                case 0xE132:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE134;
                    goto case 0xE134;
                case 0xE133:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xE135;
                    goto case 0xE135;
                case 0xE134:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xE136;
                    goto case 0xE136;
                case 0xE135: // === SUBROUTINE: RelativeMiscPosition ===
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE140; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE140; }
                    PC = 0xE137; goto case 0xE137;
                case 0xE136:
                    A |= 0xA9; SetZN(A); TotalCycles += 2; PC = 0xE138;
                    goto case 0xE138;
                case 0xE137:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE139;
                    goto case 0xE139;
                case 0xE138:
                    TotalCycles += 7; PushU16(0xE13A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE139:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xE13B;
                    goto case 0xE13B;
                case 0xE13A:
                    TotalCycles += 7; PushU16(0xE13C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE13B: // === SUBROUTINE: RelativeEnemyPosition ===
                    Y = 0xFA; SetZN(Y); TotalCycles += 2; PC = 0xE13D;
                    goto case 0xE13D;
                case 0xE13D:
                    TotalCycles += 3; PC = 0xCA37;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE13F:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE140;
                    goto case 0xE140;
                case 0xE140:
                    TotalCycles += 3; PC = 0xDB36;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE141:
                    { byte z = (byte)(0xDB + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xE143;
                    goto case 0xE143;
                case 0xE143: // === SUBROUTINE: Sub_E143 ===
                    A = _ram[(byte)(0x87 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE145;
                    goto case 0xE145;
                case 0xE145:
                    P |= FlagC; TotalCycles += 2; PC = 0xE146;
                    goto case 0xE146;
                case 0xE146:
                    Sbc(_ram[0x86]); TotalCycles += 3; PC = 0xE148;
                    goto case 0xE148;
                case 0xE147:
                    _ram[0x85] = X; TotalCycles += 3; PC = 0xE149;
                    goto case 0xE149;
                case 0xE148:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xE14A;
                    goto case 0xE14A;
                case 0xE149:
                    TotalCycles += 7; PushU16(0xE14B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE14A:
                    A = _ram[(byte)(0x6E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE14C;
                    goto case 0xE14C;
                case 0xE14B:
                    { int a = 0x6DE5; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xE14E;
                    goto case 0xE14E;
                case 0xE14C:
                    Sbc(_ram[0x6D]); TotalCycles += 3; PC = 0xE14E;
                    goto case 0xE14E;
                case 0xE14D:
                    Adc(ReadIoReg(0x2060)); TotalCycles += 4; PC = 0xE150;
                    return;
                case 0xE14E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE14F: // === SUBROUTINE: Sub_E14F ===
                    TotalCycles += 6; PushU16(0xE151); PC = 0xC363;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE152:
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xE154;
                    goto case 0xE154;
                case 0xE154:
                    A &= 0xF0; SetZN(A); TotalCycles += 2; PC = 0xE156;
                    goto case 0xE156;
                case 0xE155:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE160; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE160; }
                    PC = 0xE157; goto case 0xE157;
                case 0xE156:
                    A |= 0x08; SetZN(A); TotalCycles += 2; PC = 0xE158;
                    goto case 0xE158;
                case 0xE157:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE158;
                    goto case 0xE158;
                case 0xE158:
                    _ram[(byte)(0xCF + X)] = A; TotalCycles += 4; PC = 0xE15A;
                    goto case 0xE15A;
                case 0xE15A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE15B: // === SUBROUTINE: Sub_E15B ===
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xE15D;
                    goto case 0xE15D;
                case 0xE15D:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE15E;
                    goto case 0xE15E;
                case 0xE15E:
                    Adc(0x3E); TotalCycles += 2; PC = 0xE160;
                    goto case 0xE160;
                case 0xE15F:
                    { int a = 0x44C9 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xE162;
                    goto case 0xE162;
                case 0xE160:
                    Cmp(A, 0x44); TotalCycles += 2; PC = 0xE162;
                    goto case 0xE162;
                case 0xE162:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE163:
                    TotalCycles += 6; PushU16(0xE165); PC = 0xE15B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE15B;
                case 0xE165:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x90 + X)))); TotalCycles += 6; PC = 0xE167;
                    return;
                case 0xE166:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE182; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE182; }
                    PC = 0xE168; goto case 0xE168;
                case 0xE168:
                    A = _ram[(byte)(0xA0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE16A;
                    goto case 0xE16A;
                case 0xE169:
                    Y = 0x18; SetZN(Y); TotalCycles += 2; PC = 0xE16B;
                    goto case 0xE16B;
                case 0xE16A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE16B;
                    goto case 0xE16B;
                case 0xE16B:
                    Adc(0x02); TotalCycles += 2; PC = 0xE16D;
                    goto case 0xE16D;
                case 0xE16D:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xE16F;
                    goto case 0xE16F;
                case 0xE16F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE182; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE182; }
                    PC = 0xE171; goto case 0xE171;
                case 0xE170:
                    A |= ReadMem(ReadU16Zp(0x20) + Y); SetZN(A); TotalCycles += 5; PC = 0xE172;
                    goto case 0xE172;
                case 0xE171:
                    TotalCycles += 6; PushU16(0xE173); PC = 0xE1AE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE1AE;
                case 0xE172:
                    X = SmbEmbeddedAssets.StaticDataTables[0x70E1]; SetZN(X); TotalCycles += 4; PC = 0xE175;
                    return;
                case 0xE173:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xF0 + X)))); TotalCycles += 6; PC = 0xE175;
                    return;
                case 0xE174:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE182; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE182; }
                    PC = 0xE176; goto case 0xE176;
                case 0xE176:
                    TotalCycles += 6; PushU16(0xE178); PC = 0xE1B5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE1B5;
                case 0xE177:
                    A = _ram[(byte)(0xE1 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE179;
                    goto case 0xE179;
                case 0xE178:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xF0 + X)))); TotalCycles += 6; PC = 0xE17A;
                    return;
                case 0xE179:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE182; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE182; }
                    PC = 0xE17B; goto case 0xE17B;
                case 0xE17B:
                    TotalCycles += 6; PushU16(0xE17D); PC = 0xE14F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE14F;
                case 0xE17D:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xA9 + X)))); TotalCycles += 6; PC = 0xE17F;
                    goto case 0xE17F;
                case 0xE17E:
                    A = 0xFD; SetZN(A); TotalCycles += 2; PC = 0xE180;
                    goto case 0xE180;
                case 0xE17F:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x2095 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE182;
                    goto case 0xE182;
                case 0xE180:
                    _ram[(byte)(0xA0 + X)] = A; TotalCycles += 4; PC = 0xE182;
                    goto case 0xE182;
                case 0xE181:
                    Y = 0x4C; SetZN(Y); TotalCycles += 2; PC = 0xE183;
                    goto case 0xE183;
                case 0xE182:
                    TotalCycles += 3; PC = 0xE0FE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE0FE;
                case 0xE183:
                    { int a = 0x20E0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xE186;
                    goto case 0xE186;
                case 0xE184:
                    Cmp(X, 0x20); TotalCycles += 2; PC = 0xE186;
                    goto case 0xE186;
                case 0xE185:
                    TotalCycles += 6; PushU16(0xE187); PC = 0xE1AE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE1AE;
                case 0xE186:
                    X = SmbEmbeddedAssets.StaticDataTables[0x70E1]; SetZN(X); TotalCycles += 4; PC = 0xE189;
                    goto case 0xE189;
                case 0xE187:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xF0 + X)))); TotalCycles += 6; PC = 0xE189;
                    goto case 0xE189;
                case 0xE188:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE1A7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1A7; }
                    PC = 0xE18A; goto case 0xE18A;
                case 0xE189:
                    A |= ReadMem(0x23C9 + X); SetZN(A); TotalCycles += 4; PC = 0xE18C;
                    goto case 0xE18C;
                case 0xE18A:
                    Cmp(A, 0x23); TotalCycles += 2; PC = 0xE18C;
                    goto case 0xE18C;
                case 0xE18C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE196; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE196; }
                    PC = 0xE18E; goto case 0xE18E;
                case 0xE18D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE18E;
                    goto case 0xE18E;
                case 0xE18E: // === SUBROUTINE: Sub_E18E ===
                    TotalCycles += 6; PushU16(0xE190); PC = 0xD795;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE18F:
                    _ram[(byte)(0xD7 + X)] = A; TotalCycles += 4; PC = 0xE191;
                    goto case 0xE191;
                case 0xE191:
                    A = 0xFC; SetZN(A); TotalCycles += 2; PC = 0xE193;
                    goto case 0xE193;
                case 0xE193:
                    _ram[(byte)(0xA0 + X)] = A; TotalCycles += 4; PC = 0xE195;
                    goto case 0xE195;
                case 0xE194:
                    Y = 0x60; SetZN(Y); TotalCycles += 2; PC = 0xE196;
                    goto case 0xE196;
                case 0xE195:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE196:
                    A = _ram[(0x078A + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE199;
                    goto case 0xE199;
                case 0xE197:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE198;
                    return;
                case 0xE199:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE1A7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1A7; }
                    PC = 0xE19B; goto case 0xE19B;
                case 0xE19B:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE19D;
                    goto case 0xE19D;
                case 0xE19C:
                    { int a = 0x8829 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE19F;
                    goto case 0xE19F;
                case 0xE19D:
                    A &= 0x88; SetZN(A); TotalCycles += 2; PC = 0xE19F;
                    goto case 0xE19F;
                case 0xE19E:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xE19F;
                    goto case 0xE19F;
                case 0xE19F:
                    _ram[(byte)(0x1E + X)] = A; TotalCycles += 4; PC = 0xE1A1;
                    goto case 0xE1A1;
                case 0xE1A0:
                    { int a = 0x4F20 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE1A3;
                    goto case 0xE1A3;
                case 0xE1A1:
                    TotalCycles += 6; PushU16(0xE1A3); PC = 0xE14F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE14F;
                case 0xE1A3:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x4C + X)))); TotalCycles += 6; PC = 0xE1A5;
                    goto case 0xE1A5;
                case 0xE1A4:
                    TotalCycles += 3; PC = 0xE0FE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE0FE;
                case 0xE1A5:
                    { int a = 0xB5E0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xE1A8;
                    goto case 0xE1A8;
                case 0xE1A6:
                    Cmp(X, 0xB5); TotalCycles += 2; PC = 0xE1A8;
                    goto case 0xE1A8;
                case 0xE1A7:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE1A9;
                    goto case 0xE1A9;
                case 0xE1A8:
                    { int a = (0x0109 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xE1AB;
                    goto case 0xE1AB;
                case 0xE1A9:
                    A |= 0x01; SetZN(A); TotalCycles += 2; PC = 0xE1AB;
                    goto case 0xE1AB;
                case 0xE1AA:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xE1AC;
                    goto case 0xE1AC;
                case 0xE1AB:
                    _ram[(byte)(0x1E + X)] = A; TotalCycles += 4; PC = 0xE1AD;
                    goto case 0xE1AD;
                case 0xE1AC:
                    { int a = 0xA960 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE1AF;
                    goto case 0xE1AF;
                case 0xE1AD:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE1AE: // === SUBROUTINE: Sub_E1AE ===
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE1B0;
                    goto case 0xE1B0;
                case 0xE1AF:
                    TotalCycles += 7; PushU16(0xE1B1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE1B0:
                    Y = 0x15; SetZN(Y); TotalCycles += 2; PC = 0xE1B2;
                    goto case 0xE1B2;
                case 0xE1B1:
                    A |= _ram[(byte)(0x4C + X)]; SetZN(A); TotalCycles += 4; PC = 0xE1B3;
                    goto case 0xE1B3;
                case 0xE1B2:
                    TotalCycles += 3; PC = 0xE388;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE388;
                case 0xE1B3:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xE1B4;
                    return;
                case 0xE1B5: // === SUBROUTINE: Sub_E1B5 ===
                    Cmp(A, 0x26); TotalCycles += 2; PC = 0xE1B7;
                    goto case 0xE1B7;
                case 0xE1B6:
                    _ram[0xF0] = Rol(_ram[0xF0]); TotalCycles += 5; PC = 0xE1B8;
                    goto case 0xE1B8;
                case 0xE1B7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE1C7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1C7; }
                    PC = 0xE1B9; goto case 0xE1B9;
                case 0xE1B8:
                    { int a = 0xC2C9; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xE1BB;
                    goto case 0xE1BB;
                case 0xE1B9:
                    Cmp(A, 0xC2); TotalCycles += 2; PC = 0xE1BB;
                    goto case 0xE1BB;
                case 0xE1BB:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE1C7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1C7; }
                    PC = 0xE1BD; goto case 0xE1BD;
                case 0xE1BC:
                    A = Asl(A); TotalCycles += 2; PC = 0xE1BD;
                    goto case 0xE1BD;
                case 0xE1BD:
                    Cmp(A, 0xC3); TotalCycles += 2; PC = 0xE1BF;
                    goto case 0xE1BF;
                case 0xE1BF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE1C7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1C7; }
                    PC = 0xE1C1; goto case 0xE1C1;
                case 0xE1C0:
                    _ram[0xC9] = Asl(_ram[0xC9]); TotalCycles += 5; PC = 0xE1C2;
                    return;
                case 0xE1C1:
                    Cmp(A, 0x5F); TotalCycles += 2; PC = 0xE1C3;
                    goto case 0xE1C3;
                case 0xE1C3:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE1C7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1C7; }
                    PC = 0xE1C5; goto case 0xE1C5;
                case 0xE1C5:
                    Cmp(A, 0x60); TotalCycles += 2; PC = 0xE1C7;
                    goto case 0xE1C7;
                case 0xE1C6:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE1C7:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE1C8: // === SUBROUTINE: Sub_E1C8 ===
                    A = _ram[(byte)(0xD5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE1CA;
                    goto case 0xE1CA;
                case 0xE1C9:
                    Cmp(A, _ram[(byte)(0xC9 + X)]); TotalCycles += 4; PC = 0xE1CB;
                    goto case 0xE1CB;
                case 0xE1CA:
                    Cmp(A, 0x18); TotalCycles += 2; PC = 0xE1CC;
                    goto case 0xE1CC;
                case 0xE1CB:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE1CC;
                    goto case 0xE1CC;
                case 0xE1CC:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE1EF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1EF; }
                    PC = 0xE1CE; goto case 0xE1CE;
                case 0xE1CD:
                    A &= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xE1CF;
                    return;
                case 0xE1CE:
                    TotalCycles += 6; PushU16(0xE1D0); PC = 0xE39C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE39C;
                case 0xE1D1:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE1EF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1EF; }
                    PC = 0xE1D3; goto case 0xE1D3;
                case 0xE1D3:
                    TotalCycles += 6; PushU16(0xE1D5); PC = 0xE1B5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE1B5;
                case 0xE1D4:
                    A = _ram[(byte)(0xE1 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE1D6;
                    goto case 0xE1D6;
                case 0xE1D5:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xF0 + X)))); TotalCycles += 6; PC = 0xE1D7;
                    return;
                case 0xE1D6:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE1EF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1EF; }
                    PC = 0xE1D8; goto case 0xE1D8;
                case 0xE1D8:
                    A = _ram[(byte)(0xA6 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE1DA;
                    goto case 0xE1DA;
                case 0xE1D9:
                    X = _ram[0x30]; SetZN(X); TotalCycles += 3; PC = 0xE1DB;
                    goto case 0xE1DB;
                case 0xE1DA:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE1F4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1F4; }
                    PC = 0xE1DC; goto case 0xE1DC;
                case 0xE1DB:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE1DC;
                    goto case 0xE1DC;
                case 0xE1DC:
                    A = _ram[(byte)(0x3A + X)]; SetZN(A); TotalCycles += 4; PC = 0xE1DE;
                    goto case 0xE1DE;
                case 0xE1DE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE1F4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE1F4; }
                    PC = 0xE1E0; goto case 0xE1E0;
                case 0xE1E0:
                    A = 0xFD; SetZN(A); TotalCycles += 2; PC = 0xE1E2;
                    goto case 0xE1E2;
                case 0xE1E1:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x2695 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE1E4;
                    goto case 0xE1E4;
                case 0xE1E2:
                    _ram[(byte)(0xA6 + X)] = A; TotalCycles += 4; PC = 0xE1E4;
                    goto case 0xE1E4;
                case 0xE1E3:
                    X = _ram[0xA9]; SetZN(X); TotalCycles += 3; PC = 0xE1E5;
                    goto case 0xE1E5;
                case 0xE1E4:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xE1E6;
                    goto case 0xE1E6;
                case 0xE1E5:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xE1E7;
                    return;
                case 0xE1E6:
                    _ram[(byte)(0x3A + X)] = A; TotalCycles += 4; PC = 0xE1E8;
                    goto case 0xE1E8;
                case 0xE1E8:
                    A = _ram[(byte)(0xD5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE1EA;
                    goto case 0xE1EA;
                case 0xE1E9:
                    Cmp(A, _ram[(byte)(0x29 + X)]); TotalCycles += 4; PC = 0xE1EB;
                    goto case 0xE1EB;
                case 0xE1EA:
                    A &= 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE1EC;
                    goto case 0xE1EC;
                case 0xE1EB:
                    P |= FlagD; TotalCycles += 2; PC = 0xE1EC;
                    goto case 0xE1EC;
                case 0xE1EC:
                    _ram[(byte)(0xD5 + X)] = A; TotalCycles += 4; PC = 0xE1EE;
                    goto case 0xE1EE;
                case 0xE1ED:
                    Cmp(A, _ram[(byte)(0x60 + X)]); TotalCycles += 4; PC = 0xE1EF;
                    goto case 0xE1EF;
                case 0xE1EE:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE1EF:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE1F1;
                    goto case 0xE1F1;
                case 0xE1F0:
                    TotalCycles += 7; PushU16(0xE1F2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE1F1:
                    _ram[(byte)(0x3A + X)] = A; TotalCycles += 4; PC = 0xE1F3;
                    goto case 0xE1F3;
                case 0xE1F3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE1F4:
                    A = 0x80; SetZN(A); TotalCycles += 2; PC = 0xE1F6;
                    goto case 0xE1F6;
                case 0xE1F6:
                    _ram[(byte)(0x24 + X)] = A; TotalCycles += 4; PC = 0xE1F8;
                    goto case 0xE1F8;
                case 0xE1F7:
                    Bit(_ram[0xA9]); TotalCycles += 3; PC = 0xE1F9;
                    return;
                case 0xE1F8:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xE1FA;
                    goto case 0xE1FA;
                case 0xE1FA:
                    _ram[0xFF] = A; TotalCycles += 3; PC = 0xE1FC;
                    goto case 0xE1FC;
                case 0xE1FC:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE1FE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE1FF;
                    goto case 0xE1FF;
                case 0xE1FF:
                    _ram[0x0320] = Asl(_ram[0x0320]); TotalCycles += 6; PC = 0xE202;
                    return;
                case 0xE200:
                    TotalCycles += 6; PushU16(0xE202); PC = 0x1403;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE203:
                    A |= _ram[0x0220]; SetZN(A); TotalCycles += 4; PC = 0xE206;
                    return;
                case 0xE204:
                    TotalCycles += 6; PushU16(0xE206); PC = 0x1402;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE207:
                    _ram[0x0220] = Asl(_ram[0x0220]); TotalCycles += 6; PC = 0xE20A;
                    goto case 0xE20A;
                case 0xE208:
                    TotalCycles += 6; PushU16(0xE20A); PC = 0x0902;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE20A:
                    A |= 0x0E; SetZN(A); TotalCycles += 2; PC = 0xE20C;
                    goto case 0xE20C;
                case 0xE20B:
                    _ram[0x0015] = Asl(_ram[0x0015]); TotalCycles += 6; PC = 0xE20E;
                    goto case 0xE20E;
                case 0xE20C:
                    A |= _ram[(byte)(0x00 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE20E;
                    goto case 0xE20E;
                case 0xE20D:
                    TotalCycles += 7; PushU16(0xE20F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE20E:
                    TotalCycles += 7; PushU16(0xE210); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE20F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE210;
                    goto case 0xE210;
                case 0xE210:
                    _ram[0x00] = Asl(_ram[0x00]); TotalCycles += 5; PC = 0xE212;
                    goto case 0xE212;
                case 0xE211:
                    TotalCycles += 7; PushU16(0xE213); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE212:
                    TotalCycles += 7; PushU16(0xE214); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE213:
                    TotalCycles += 6; PushU16(0xE215); PC = 0x000D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE214:
                    A |= _ram[0x0000]; SetZN(A); TotalCycles += 4; PC = 0xE217;
                    goto case 0xE217;
                case 0xE215:
                    TotalCycles += 7; PushU16(0xE217); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE216:
                    TotalCycles += 7; PushU16(0xE218); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE217:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE226; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE219; goto case 0xE219;
                case 0xE218:
                    A |= _ram[0x0000]; SetZN(A); TotalCycles += 4; PC = 0xE21B;
                    goto case 0xE21B;
                case 0xE219:
                    TotalCycles += 7; PushU16(0xE21B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE21A:
                    TotalCycles += 7; PushU16(0xE21C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE21B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE21C;
                    goto case 0xE21C;
                case 0xE21C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE21D;
                    goto case 0xE21D;
                case 0xE21D:
                    _ram[0x04] = Asl(_ram[0x04]); TotalCycles += 5; PC = 0xE21F;
                    goto case 0xE21F;
                case 0xE21F:
                    A = Asl(A); TotalCycles += 2; PC = 0xE220;
                    goto case 0xE220;
                case 0xE220:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE221;
                    return;
                case 0xE222:
                    _ram[0x040D] = Asl(_ram[0x040D]); TotalCycles += 6; PC = 0xE225;
                    goto case 0xE225;
                case 0xE223:
                    A |= _ram[0x0014]; SetZN(A); TotalCycles += 4; PC = 0xE226;
                    return;
                case 0xE225:
                    TotalCycles += 7; PushU16(0xE227); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE227:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE23E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE229; return;
                case 0xE228:
                    A |= _ram[(byte)(0x04 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE22A;
                    return;
                case 0xE22D: // === SUBROUTINE: Sub_E22D ===
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE22E;
                    goto case 0xE22E;
                case 0xE22E:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE22F;
                    goto case 0xE22F;
                case 0xE22F:
                    Adc(0x07); TotalCycles += 2; PC = 0xE231;
                    goto case 0xE231;
                case 0xE231:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE232;
                    goto case 0xE232;
                case 0xE232:
                    Y = 0x02; SetZN(Y); TotalCycles += 2; PC = 0xE234;
                    goto case 0xE234;
                case 0xE234:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE23D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE23D; }
                    PC = 0xE236; goto case 0xE236;
                case 0xE236: // === SUBROUTINE: Sub_E236 ===
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE237;
                    goto case 0xE237;
                case 0xE237:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE238;
                    goto case 0xE238;
                case 0xE238:
                    Adc(0x09); TotalCycles += 2; PC = 0xE23A;
                    goto case 0xE23A;
                case 0xE239:
                    A |= 0xAA; SetZN(A); TotalCycles += 2; PC = 0xE23B;
                    goto case 0xE23B;
                case 0xE23A:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE23B;
                    goto case 0xE23B;
                case 0xE23B:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0xE23D;
                    goto case 0xE23D;
                case 0xE23C:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xE23E;
                    return;
                case 0xE23D:
                    TotalCycles += 6; PushU16(0xE23F); PC = 0xE29C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE29C;
                case 0xE240:
                    TotalCycles += 3; PC = 0xE2DE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE2DE;
                case 0xE241:
                    { int a = 0xA0E2 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xE244;
                    goto case 0xE244;
                case 0xE243: // === SUBROUTINE: Sub_E243 ===
                    Y = 0x48; SetZN(Y); TotalCycles += 2; PC = 0xE245;
                    goto case 0xE245;
                case 0xE244:
                    PushU8(A); TotalCycles += 3; PC = 0xE245;
                    goto case 0xE245;
                case 0xE245:
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0xE247;
                    goto case 0xE247;
                case 0xE246:
                    TotalCycles += 7; PushU16(0xE248); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE247:
                    Y = 0x44; SetZN(Y); TotalCycles += 2; PC = 0xE249;
                    goto case 0xE249;
                case 0xE249:
                    TotalCycles += 3; PC = 0xE252;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE252;
                case 0xE24C: // === SUBROUTINE: Sub_E24C ===
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0xE24E;
                    goto case 0xE24E;
                case 0xE24D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE24E;
                    goto case 0xE24E;
                case 0xE24E:
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0xE250;
                    goto case 0xE250;
                case 0xE24F:
                    TotalCycles += 7; PushU16(0xE251); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE250:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xE252;
                    goto case 0xE252;
                case 0xE252:
                    A = _ram[(byte)(0x87 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE254;
                    goto case 0xE254;
                case 0xE254:
                    P |= FlagC; TotalCycles += 2; PC = 0xE255;
                    goto case 0xE255;
                case 0xE255:
                    Sbc(_ram[0x071C]); TotalCycles += 4; PC = 0xE258;
                    goto case 0xE258;
                case 0xE258:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xE25A;
                    goto case 0xE25A;
                case 0xE259:
                    A |= ReadMem(ReadU16Zp((byte)(0xB5 + X))); SetZN(A); TotalCycles += 6; PC = 0xE25B;
                    goto case 0xE25B;
                case 0xE25A:
                    A = _ram[(byte)(0x6E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE25C;
                    goto case 0xE25C;
                case 0xE25B:
                    _ram[0x02ED] = Ror(_ram[0x02ED]); TotalCycles += 6; PC = 0xE25E;
                    return;
                case 0xE25C:
                    Sbc(_ram[0x071A]); TotalCycles += 4; PC = 0xE25F;
                    goto case 0xE25F;
                case 0xE25F:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE267; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE267; }
                    PC = 0xE261; goto case 0xE261;
                case 0xE260:
                    _ram[0x05] = Asl(_ram[0x05]); TotalCycles += 5; PC = 0xE262;
                    goto case 0xE262;
                case 0xE261:
                    A |= _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0xE263;
                    goto case 0xE263;
                case 0xE262:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0xE264;
                    return;
                case 0xE263:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE267; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE267; }
                    PC = 0xE265; goto case 0xE265;
                case 0xE265:
                    Y = _ram[0x00]; SetZN(Y); TotalCycles += 3; PC = 0xE267;
                    goto case 0xE267;
                case 0xE266:
                    TotalCycles += 7; PushU16(0xE268); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE267:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xE268;
                    goto case 0xE268;
                case 0xE268:
                    A &= _ram[0x03D1]; SetZN(A); TotalCycles += 4; PC = 0xE26B;
                    goto case 0xE26B;
                case 0xE269:
                    Cmp(A, ReadMem(ReadU16Zp(0x03) + Y)); TotalCycles += 5; PC = 0xE26B;
                    goto case 0xE26B;
                case 0xE26B:
                    _ram[(0x03D8 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xE26E;
                    goto case 0xE26E;
                case 0xE26C:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xE26D;
                    return;
                case 0xE26E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE289; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE289; }
                    PC = 0xE270; goto case 0xE270;
                case 0xE26F:
                    A |= ReadMem(0x7C4C + Y); SetZN(A); TotalCycles += 4; PC = 0xE272;
                    return;
                case 0xE270:
                    TotalCycles += 3; PC = 0xE27C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE27C;
                case 0xE273: // === SUBROUTINE: Sub_E273 ===
                    X++; SetZN(X); TotalCycles += 2; PC = 0xE274;
                    goto case 0xE274;
                case 0xE274:
                    TotalCycles += 6; PushU16(0xE276); PC = 0xF1F6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1F6;
                case 0xE275:
                    { byte z = (byte)(0xF1 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xE277;
                    goto case 0xE277;
                case 0xE276:
                    Sbc(ReadMem(ReadU16Zp(0xCA) + Y)); TotalCycles += 5; PC = 0xE278;
                    goto case 0xE278;
                case 0xE277:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE278;
                    goto case 0xE278;
                case 0xE278:
                    Cmp(A, 0xFE); TotalCycles += 2; PC = 0xE27A;
                    goto case 0xE27A;
                case 0xE279:
                    { int a = 0x0DB0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xE27C;
                    goto case 0xE27C;
                case 0xE27A:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE289; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE289; }
                    PC = 0xE27C; goto case 0xE27C;
                case 0xE27B:
                    A |= _ram[0x008A]; SetZN(A); TotalCycles += 4; PC = 0xE27E;
                    goto case 0xE27E;
                case 0xE27C:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE27D;
                    goto case 0xE27D;
                case 0xE27D:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE27E;
                    goto case 0xE27E;
                case 0xE27E:
                    Adc(0x01); TotalCycles += 2; PC = 0xE280;
                    goto case 0xE280;
                case 0xE27F:
                    A |= ReadMem(ReadU16Zp((byte)(0xAA + X))); SetZN(A); TotalCycles += 6; PC = 0xE281;
                    goto case 0xE281;
                case 0xE280:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE281;
                    goto case 0xE281;
                case 0xE281:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xE283;
                    goto case 0xE283;
                case 0xE282:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xE284;
                    return;
                case 0xE283:
                    TotalCycles += 6; PushU16(0xE285); PC = 0xE29C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE29C;
                case 0xE286:
                    TotalCycles += 3; PC = 0xE2DE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE2DE;
                case 0xE287:
                    { int a = 0x8AE2 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xE28A;
                    goto case 0xE28A;
                case 0xE289:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE28A;
                    goto case 0xE28A;
                case 0xE28A:
                    A = Asl(A); TotalCycles += 2; PC = 0xE28B;
                    goto case 0xE28B;
                case 0xE28B:
                    A = Asl(A); TotalCycles += 2; PC = 0xE28C;
                    goto case 0xE28C;
                case 0xE28C:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE28D;
                    goto case 0xE28D;
                case 0xE28D:
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0xE28F;
                    goto case 0xE28F;
                case 0xE28F:
                    _ram[(0x04B0 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE292;
                    goto case 0xE292;
                case 0xE290:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE296; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE292; goto case 0xE292;
                case 0xE292:
                    _ram[(0x04B1 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE295;
                    goto case 0xE295;
                case 0xE293:
                    A = ReadMem(ReadU16Zp(0x04) + Y); SetZN(A); TotalCycles += 5; PC = 0xE295;
                    goto case 0xE295;
                case 0xE295:
                    _ram[(0x04B2 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE298;
                    goto case 0xE298;
                case 0xE298:
                    _ram[(0x04B3 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE29B;
                    goto case 0xE29B;
                case 0xE29B:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE29C: // === SUBROUTINE: Sub_E29C ===
                    _ram[0x00] = X; TotalCycles += 3; PC = 0xE29E;
                    goto case 0xE29E;
                case 0xE29D:
                    TotalCycles += 7; PushU16(0xE29F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE29E:
                    A = _ram[(0x03B8 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE2A1;
                    goto case 0xE2A1;
                case 0xE29F:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xE2A0;
                    return;
                case 0xE2A1:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xE2A3;
                    goto case 0xE2A3;
                case 0xE2A3:
                    A = _ram[(0x03AD + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE2A6;
                    goto case 0xE2A6;
                case 0xE2A4:
                    A = SmbEmbeddedAssets.StaticDataTables[0x0503]; SetZN(A); TotalCycles += 4; PC = 0xE2A7;
                    goto case 0xE2A7;
                case 0xE2A6:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xE2A8;
                    goto case 0xE2A8;
                case 0xE2A7:
                    A |= ReadMem(ReadU16Zp((byte)(0x8A + X))); SetZN(A); TotalCycles += 6; PC = 0xE2A9;
                    goto case 0xE2A9;
                case 0xE2A8:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE2A9;
                    goto case 0xE2A9;
                case 0xE2A9:
                    A = Asl(A); TotalCycles += 2; PC = 0xE2AA;
                    goto case 0xE2AA;
                case 0xE2AA:
                    A = Asl(A); TotalCycles += 2; PC = 0xE2AB;
                    goto case 0xE2AB;
                case 0xE2AB:
                    PushU8(A); TotalCycles += 3; PC = 0xE2AC;
                    goto case 0xE2AC;
                case 0xE2AC:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE2AD;
                    goto case 0xE2AD;
                case 0xE2AD:
                    A = _ram[(0x0499 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE2B0;
                    goto case 0xE2B0;
                case 0xE2AE:
                    WriteMem(0x0A04 + Y, A); TotalCycles += 5; PC = 0xE2B1;
                    goto case 0xE2B1;
                case 0xE2B0:
                    A = Asl(A); TotalCycles += 2; PC = 0xE2B1;
                    goto case 0xE2B1;
                case 0xE2B1:
                    A = Asl(A); TotalCycles += 2; PC = 0xE2B2;
                    goto case 0xE2B2;
                case 0xE2B2:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE2B3;
                    goto case 0xE2B3;
                case 0xE2B3:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0xE2B5;
                    goto case 0xE2B5;
                case 0xE2B4:
                    A |= ReadMem(ReadU16Zp((byte)(0x18 + X))); SetZN(A); TotalCycles += 6; PC = 0xE2B6;
                    goto case 0xE2B6;
                case 0xE2B5:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE2B6;
                    goto case 0xE2B6;
                case 0xE2B6:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x61FD + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE2B9;
                    goto case 0xE2B9;
                case 0xE2B7:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x19E1 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE2BA;
                    goto case 0xE2BA;
                case 0xE2B8:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x99 + X)))); TotalCycles += 6; PC = 0xE2BA;
                    goto case 0xE2BA;
                case 0xE2B9:
                    _ram[(0x04AC + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE2BC;
                    goto case 0xE2BC;
                case 0xE2BA:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x2504]; SetZN(Y); TotalCycles += 4; PC = 0xE2BD;
                    goto case 0xE2BD;
                case 0xE2BC:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0xE2BE;
                    goto case 0xE2BE;
                case 0xE2BD:
                    A |= ReadMem(ReadU16Zp((byte)(0x18 + X))); SetZN(A); TotalCycles += 6; PC = 0xE2BF;
                    goto case 0xE2BF;
                case 0xE2BE:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE2BF;
                    goto case 0xE2BF;
                case 0xE2BF:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x61FF + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE2C2;
                    goto case 0xE2C2;
                case 0xE2C1:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x99 + X)))); TotalCycles += 6; PC = 0xE2C3;
                    goto case 0xE2C3;
                case 0xE2C2:
                    _ram[(0x04AE + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE2C5;
                    goto case 0xE2C5;
                case 0xE2C3:
                    X = SmbEmbeddedAssets.StaticDataTables[0x6804]; SetZN(X); TotalCycles += 4; PC = 0xE2C6;
                    goto case 0xE2C6;
                case 0xE2C5:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xE2C6;
                    goto case 0xE2C6;
                case 0xE2C6:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE2C7;
                    goto case 0xE2C7;
                case 0xE2C7:
                    A = _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xE2C9;
                    goto case 0xE2C9;
                case 0xE2C9:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE2CA;
                    goto case 0xE2CA;
                case 0xE2CA:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x61FD + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE2CD;
                    goto case 0xE2CD;
                case 0xE2CB:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x19E1 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE2CE;
                    goto case 0xE2CE;
                case 0xE2CC:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x99 + X)))); TotalCycles += 6; PC = 0xE2CE;
                    goto case 0xE2CE;
                case 0xE2CD:
                    _ram[(0x04AC + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE2D0;
                    goto case 0xE2D0;
                case 0xE2CE:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x2504]; SetZN(Y); TotalCycles += 4; PC = 0xE2D1;
                    return;
                case 0xE2D0:
                    A = _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xE2D2;
                    goto case 0xE2D2;
                case 0xE2D2:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE2D3;
                    goto case 0xE2D3;
                case 0xE2D3:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x61FF + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE2D6;
                    goto case 0xE2D6;
                case 0xE2D5:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x99 + X)))); TotalCycles += 6; PC = 0xE2D7;
                    goto case 0xE2D7;
                case 0xE2D6:
                    _ram[(0x04AE + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE2D9;
                    goto case 0xE2D9;
                case 0xE2D7:
                    X = ReadIoReg(0x6804); SetZN(X); TotalCycles += 4; PC = 0xE2DA;
                    goto case 0xE2DA;
                case 0xE2D9:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xE2DA;
                    goto case 0xE2DA;
                case 0xE2DA:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE2DB;
                    goto case 0xE2DB;
                case 0xE2DB:
                    X = _ram[0x00]; SetZN(X); TotalCycles += 3; PC = 0xE2DD;
                    goto case 0xE2DD;
                case 0xE2DC:
                    TotalCycles += 7; PushU16(0xE2DE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE2DD:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE2DE:
                    A = _ram[0x071C]; SetZN(A); TotalCycles += 4; PC = 0xE2E1;
                    goto case 0xE2E1;
                case 0xE2E1:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE2E2;
                    goto case 0xE2E2;
                case 0xE2E2:
                    Adc(0x80); TotalCycles += 2; PC = 0xE2E4;
                    goto case 0xE2E4;
                case 0xE2E4:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xE2E6;
                    goto case 0xE2E6;
                case 0xE2E6:
                    A = _ram[0x071A]; SetZN(A); TotalCycles += 4; PC = 0xE2E9;
                    goto case 0xE2E9;
                case 0xE2E9:
                    Adc(0x00); TotalCycles += 2; PC = 0xE2EB;
                    goto case 0xE2EB;
                case 0xE2EA:
                    TotalCycles += 7; PushU16(0xE2EC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE2EB:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xE2ED;
                    goto case 0xE2ED;
                case 0xE2EC:
                    A |= ReadMem(ReadU16Zp((byte)(0xB5 + X))); SetZN(A); TotalCycles += 6; PC = 0xE2EE;
                    goto case 0xE2EE;
                case 0xE2ED:
                    A = _ram[(byte)(0x86 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE2EF;
                    goto case 0xE2EF;
                case 0xE2EE:
                    _ram[0xC5] = X; TotalCycles += 3; PC = 0xE2F0;
                    return;
                case 0xE2EF:
                    Cmp(A, _ram[0x02]); TotalCycles += 3; PC = 0xE2F1;
                    goto case 0xE2F1;
                case 0xE2F1:
                    A = _ram[(byte)(0x6D + X)]; SetZN(A); TotalCycles += 4; PC = 0xE2F3;
                    goto case 0xE2F3;
                case 0xE2F2:
                    Adc(_ram[0x01E5]); TotalCycles += 4; PC = 0xE2F5;
                    goto case 0xE2F5;
                case 0xE2F3:
                    Sbc(_ram[0x01]); TotalCycles += 3; PC = 0xE2F5;
                    goto case 0xE2F5;
                case 0xE2F4:
                    A |= ReadMem(ReadU16Zp((byte)(0x90 + X))); SetZN(A); TotalCycles += 6; PC = 0xE2F6;
                    goto case 0xE2F6;
                case 0xE2F5:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE30C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE30C; }
                    PC = 0xE2F7; goto case 0xE2F7;
                case 0xE2F6:
                    A |= _ram[(byte)(0xB9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE2F8;
                    goto case 0xE2F8;
                case 0xE2F7:
                    A = _ram[(0x04AE + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE2FA;
                    goto case 0xE2FA;
                case 0xE2F8:
                    X = ReadIoReg(0x3004); SetZN(X); TotalCycles += 4; PC = 0xE2FB;
                    goto case 0xE2FB;
                case 0xE2FA:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE309; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE309; }
                    PC = 0xE2FC; goto case 0xE2FC;
                case 0xE2FB:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x7FA9]; SetZN(A); TotalCycles += 4; PC = 0xE2FE;
                    goto case 0xE2FE;
                case 0xE2FC:
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0xE2FE;
                    goto case 0xE2FE;
                case 0xE2FE:
                    X = _ram[(0x04AC + Y) & 0x07FF]; SetZN(X); TotalCycles += 4; PC = 0xE301;
                    goto case 0xE301;
                case 0xE2FF:
                    Y = ReadIoReg(0x3004); SetZN(Y); TotalCycles += 4; PC = 0xE302;
                    return;
                case 0xE301:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE306; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE306; }
                    PC = 0xE303; goto case 0xE303;
                case 0xE303:
                    _ram[(0x04AC + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE306;
                    goto case 0xE306;
                case 0xE304:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x1904]; SetZN(Y); TotalCycles += 4; PC = 0xE307;
                    goto case 0xE307;
                case 0xE306:
                    _ram[(0x04AE + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE309;
                    goto case 0xE309;
                case 0xE307:
                    X = SmbEmbeddedAssets.StaticDataTables[0x2604]; SetZN(X); TotalCycles += 4; PC = 0xE30A;
                    goto case 0xE30A;
                case 0xE309:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xE30B;
                    goto case 0xE30B;
                case 0xE30A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE30B;
                    goto case 0xE30B;
                case 0xE30B:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE30C:
                    A = _ram[(0x04AC + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE30F;
                    goto case 0xE30F;
                case 0xE30D:
                    Y = _ram[0x0004]; SetZN(Y); TotalCycles += 4; PC = 0xE310;
                    goto case 0xE310;
                case 0xE30F:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE322; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE322; }
                    PC = 0xE311; goto case 0xE311;
                case 0xE310:
                    A |= ReadMem(ReadU16Zp(0xC9) + Y); SetZN(A); TotalCycles += 5; PC = 0xE312;
                    goto case 0xE312;
                case 0xE311:
                    Cmp(A, 0xA0); TotalCycles += 2; PC = 0xE313;
                    goto case 0xE313;
                case 0xE312:
                    Y = 0x90; SetZN(Y); TotalCycles += 2; PC = 0xE314;
                    goto case 0xE314;
                case 0xE313:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE322; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE322; }
                    PC = 0xE315; goto case 0xE315;
                case 0xE314:
                    A |= _ram[0x00A9]; SetZN(A); TotalCycles += 4; PC = 0xE317;
                    goto case 0xE317;
                case 0xE315:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE317;
                    goto case 0xE317;
                case 0xE316:
                    TotalCycles += 7; PushU16(0xE318); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE317:
                    X = _ram[(0x04AE + Y) & 0x07FF]; SetZN(X); TotalCycles += 4; PC = 0xE31A;
                    goto case 0xE31A;
                case 0xE318:
                    X = _ram[0x0004]; SetZN(X); TotalCycles += 4; PC = 0xE31B;
                    return;
                case 0xE31A:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE31F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE31F; }
                    PC = 0xE31C; goto case 0xE31C;
                case 0xE31C:
                    _ram[(0x04AE + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE31F;
                    goto case 0xE31F;
                case 0xE31D:
                    X = SmbEmbeddedAssets.StaticDataTables[0x1904]; SetZN(X); TotalCycles += 4; PC = 0xE320;
                    goto case 0xE320;
                case 0xE31F:
                    _ram[(0x04AC + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE322;
                    goto case 0xE322;
                case 0xE320:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x2604]; SetZN(Y); TotalCycles += 4; PC = 0xE323;
                    goto case 0xE323;
                case 0xE322:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xE324;
                    goto case 0xE324;
                case 0xE323:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE324;
                    goto case 0xE324;
                case 0xE324:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE325: // === SUBROUTINE: Sub_E325 ===
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xE327;
                    goto case 0xE327;
                case 0xE326:
                    TotalCycles += 7; PushU16(0xE328); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE327: // === SUBROUTINE: Sub_E327 ===
                    _ram[0x06] = Y; TotalCycles += 3; PC = 0xE329;
                    goto case 0xE329;
                case 0xE328:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xE32A;
                    goto case 0xE32A;
                case 0xE329:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xE32B;
                    goto case 0xE32B;
                case 0xE32A:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xE32C;
                    return;
                case 0xE32B:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0xE32D;
                    goto case 0xE32D;
                case 0xE32D:
                    A = _ram[(0x04AC + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE330;
                    goto case 0xE330;
                case 0xE32E:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x5D04]; SetZN(Y); TotalCycles += 4; PC = 0xE331;
                    goto case 0xE331;
                case 0xE330:
                    Cmp(A, _ram[(0x04AC + X) & 0x07FF]); TotalCycles += 4; PC = 0xE333;
                    goto case 0xE333;
                case 0xE331:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x3004]; SetZN(Y); TotalCycles += 4; PC = 0xE334;
                    goto case 0xE334;
                case 0xE333:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE35F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE35F; }
                    PC = 0xE335; goto case 0xE335;
                case 0xE334:
                    A = Rol(A); TotalCycles += 2; PC = 0xE335;
                    goto case 0xE335;
                case 0xE335:
                    Cmp(A, _ram[(0x04AE + X) & 0x07FF]); TotalCycles += 4; PC = 0xE338;
                    goto case 0xE338;
                case 0xE336: // === SUBROUTINE: PlayerGfxHandler ===
                    X = SmbEmbeddedAssets.StaticDataTables[0x1004]; SetZN(X); TotalCycles += 4; PC = 0xE339;
                    return;
                case 0xE338:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE34C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE34C; }
                    PC = 0xE33A; goto case 0xE33A;
                case 0xE33A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE37E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37E; }
                    PC = 0xE33C; goto case 0xE33C;
                case 0xE33C:
                    A = _ram[(0x04AE + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE33F;
                    goto case 0xE33F;
                case 0xE33D:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5904]; SetZN(X); TotalCycles += 4; PC = 0xE340;
                    goto case 0xE340;
                case 0xE33F:
                    Cmp(A, _ram[(0x04AC + Y) & 0x07FF]); TotalCycles += 4; PC = 0xE342;
                    goto case 0xE342;
                case 0xE340:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x1004]; SetZN(Y); TotalCycles += 4; PC = 0xE343;
                    return;
                case 0xE342:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE37E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37E; }
                    PC = 0xE344; goto case 0xE344;
                case 0xE344:
                    Cmp(A, _ram[(0x04AC + X) & 0x07FF]); TotalCycles += 4; PC = 0xE347;
                    goto case 0xE347;
                case 0xE345:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x3004]; SetZN(Y); TotalCycles += 4; PC = 0xE348;
                    goto case 0xE348;
                case 0xE347:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE37E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37E; }
                    PC = 0xE349; goto case 0xE349;
                case 0xE348:
                    A &= _ram[(byte)(0xA4 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE34A;
                    goto case 0xE34A;
                case 0xE349:
                    Y = _ram[0x06]; SetZN(Y); TotalCycles += 3; PC = 0xE34B;
                    goto case 0xE34B;
                case 0xE34A:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0xE34C;
                    goto case 0xE34C;
                case 0xE34B:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE34C:
                    A = _ram[(0x04AE + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE34F;
                    goto case 0xE34F;
                case 0xE34D:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5D04]; SetZN(X); TotalCycles += 4; PC = 0xE350;
                    goto case 0xE350;
                case 0xE34F:
                    Cmp(A, _ram[(0x04AC + X) & 0x07FF]); TotalCycles += 4; PC = 0xE352;
                    goto case 0xE352;
                case 0xE350:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x1004]; SetZN(Y); TotalCycles += 4; PC = 0xE353;
                    goto case 0xE353;
                case 0xE352:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE37E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37E; }
                    PC = 0xE354; goto case 0xE354;
                case 0xE353:
                    A = Rol(A); TotalCycles += 2; PC = 0xE354;
                    goto case 0xE354;
                case 0xE354:
                    A = _ram[(0x04AE + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE357;
                    goto case 0xE357;
                case 0xE355:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5D04]; SetZN(X); TotalCycles += 4; PC = 0xE358;
                    goto case 0xE358;
                case 0xE357:
                    Cmp(A, _ram[(0x04AC + X) & 0x07FF]); TotalCycles += 4; PC = 0xE35A;
                    goto case 0xE35A;
                case 0xE358:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x3004]; SetZN(Y); TotalCycles += 4; PC = 0xE35B;
                    return;
                case 0xE35A:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE37E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37E; }
                    PC = 0xE35C; goto case 0xE35C;
                case 0xE35C:
                    Y = _ram[0x06]; SetZN(Y); TotalCycles += 3; PC = 0xE35E;
                    goto case 0xE35E;
                case 0xE35D:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0xE35F;
                    goto case 0xE35F;
                case 0xE35E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE35F:
                    Cmp(A, _ram[(0x04AC + X) & 0x07FF]); TotalCycles += 4; PC = 0xE362;
                    goto case 0xE362;
                case 0xE360:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x7004]; SetZN(Y); TotalCycles += 4; PC = 0xE363;
                    return;
                case 0xE362:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE37E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37E; }
                    PC = 0xE364; goto case 0xE364;
                case 0xE364:
                    Cmp(A, _ram[(0x04AE + X) & 0x07FF]); TotalCycles += 4; PC = 0xE367;
                    goto case 0xE367;
                case 0xE365:
                    X = SmbEmbeddedAssets.StaticDataTables[0x1004]; SetZN(X); TotalCycles += 4; PC = 0xE368;
                    goto case 0xE368;
                case 0xE367:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE37E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37E; }
                    PC = 0xE369; goto case 0xE369;
                case 0xE368:
                    A |= _ram[(byte)(0xF0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE36A;
                    return;
                case 0xE369:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE37E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37E; }
                    PC = 0xE36B; goto case 0xE36B;
                case 0xE36B:
                    Cmp(A, _ram[(0x04AE + Y) & 0x07FF]); TotalCycles += 4; PC = 0xE36E;
                    goto case 0xE36E;
                case 0xE36C:
                    X = SmbEmbeddedAssets.StaticDataTables[0x1004]; SetZN(X); TotalCycles += 4; PC = 0xE36F;
                    goto case 0xE36F;
                case 0xE36E:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE37A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37A; }
                    PC = 0xE370; goto case 0xE370;
                case 0xE36F:
                    A = Asl(A); TotalCycles += 2; PC = 0xE370;
                    goto case 0xE370;
                case 0xE370:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE37A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37A; }
                    PC = 0xE372; goto case 0xE372;
                case 0xE371:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE372;
                    goto case 0xE372;
                case 0xE372:
                    A = _ram[(0x04AE + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE375;
                    goto case 0xE375;
                case 0xE373:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5D04]; SetZN(X); TotalCycles += 4; PC = 0xE376;
                    goto case 0xE376;
                case 0xE375:
                    Cmp(A, _ram[(0x04AC + X) & 0x07FF]); TotalCycles += 4; PC = 0xE378;
                    goto case 0xE378;
                case 0xE376:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x3004]; SetZN(Y); TotalCycles += 4; PC = 0xE379;
                    return;
                case 0xE378:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE37E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE37E; }
                    PC = 0xE37A; goto case 0xE37A;
                case 0xE37A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE37B;
                    goto case 0xE37B;
                case 0xE37B:
                    Y = _ram[0x06]; SetZN(Y); TotalCycles += 3; PC = 0xE37D;
                    goto case 0xE37D;
                case 0xE37C:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0xE37E;
                    goto case 0xE37E;
                case 0xE37D:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE37E:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xE37F;
                    goto case 0xE37F;
                case 0xE37F:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE380;
                    goto case 0xE380;
                case 0xE380:
                    _ram[0x07] = DecVal(_ram[0x07]); TotalCycles += 5; PC = 0xE382;
                    goto case 0xE382;
                case 0xE382:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE32D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE32D; }
                    PC = 0xE384; goto case 0xE384;
                case 0xE383:
                    A = 0x38; SetZN(A); TotalCycles += 2; PC = 0xE385;
                    goto case 0xE385;
                case 0xE384:
                    P |= FlagC; TotalCycles += 2; PC = 0xE385;
                    goto case 0xE385;
                case 0xE385: // === SUBROUTINE: Sub_E385 ===
                    Y = _ram[0x06]; SetZN(Y); TotalCycles += 3; PC = 0xE387;
                    goto case 0xE387;
                case 0xE386:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0xE388;
                    goto case 0xE388;
                case 0xE387:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE388: // === SUBROUTINE: Sub_E388 ===
                    PushU8(A); TotalCycles += 3; PC = 0xE389;
                    goto case 0xE389;
                case 0xE389:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE38A;
                    goto case 0xE38A;
                case 0xE38A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE38B;
                    goto case 0xE38B;
                case 0xE38B:
                    Adc(0x01); TotalCycles += 2; PC = 0xE38D;
                    goto case 0xE38D;
                case 0xE38C:
                    A |= ReadMem(ReadU16Zp((byte)(0xAA + X))); SetZN(A); TotalCycles += 6; PC = 0xE38E;
                    goto case 0xE38E;
                case 0xE38D:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE38E;
                    goto case 0xE38E;
                case 0xE38E:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xE38F;
                    goto case 0xE38F;
                case 0xE38F:
                    TotalCycles += 3; PC = 0xE3A5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE3A5;
                case 0xE390:
                    A = _ram[0xE3]; SetZN(A); TotalCycles += 3; PC = 0xE392;
                    goto case 0xE392;
                case 0xE392: // === SUBROUTINE: Sub_E392 ===
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE393;
                    goto case 0xE393;
                case 0xE393:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE394;
                    goto case 0xE394;
                case 0xE394:
                    Adc(0x0D); TotalCycles += 2; PC = 0xE396;
                    goto case 0xE396;
                case 0xE395:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x20AA]; SetZN(A); TotalCycles += 4; PC = 0xE398;
                    return;
                case 0xE396:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE397;
                    goto case 0xE397;
                case 0xE397:
                    Y = 0x1B; SetZN(Y); TotalCycles += 2; PC = 0xE399;
                    goto case 0xE399;
                case 0xE399:
                    TotalCycles += 3; PC = 0xE3A3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE3A3;
                case 0xE39C: // === SUBROUTINE: Sub_E39C ===
                    Y = 0x1A; SetZN(Y); TotalCycles += 2; PC = 0xE39E;
                    goto case 0xE39E;
                case 0xE39E:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE39F;
                    goto case 0xE39F;
                case 0xE39F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3A0;
                    goto case 0xE3A0;
                case 0xE3A0:
                    Adc(0x07); TotalCycles += 2; PC = 0xE3A2;
                    goto case 0xE3A2;
                case 0xE3A2:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE3A3;
                    goto case 0xE3A3;
                case 0xE3A3:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE3A5;
                    goto case 0xE3A5;
                case 0xE3A4:
                    TotalCycles += 7; PushU16(0xE3A6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE3A5:
                    TotalCycles += 6; PushU16(0xE3A7); PC = 0xE3F0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE3F0;
                case 0xE3A6:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE38B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE38B; }
                    PC = 0xE3A8; goto case 0xE3A8;
                case 0xE3A8:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xE3AA;
                    goto case 0xE3AA;
                case 0xE3A9:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3AA;
                    goto case 0xE3AA;
                case 0xE3AA:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xE3AC;
                    goto case 0xE3AC;
                case 0xE3AB:
                    TotalCycles += 7; PushU16(0xE3AD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE3AC:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE3AD:
                    TotalCycles += 7; PushU16(0xE3AF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE3AF:
                    _ram[0x0308] = Asl(_ram[0x0308]); TotalCycles += 6; PC = 0xE3B2;
                    return;
                case 0xE3B0:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3B1;
                    return;
                case 0xE3B5:
                    A |= _ram[0x000D]; SetZN(A); TotalCycles += 4; PC = 0xE3B8;
                    return;
                case 0xE3B6:
                    A |= _ram[0x0308]; SetZN(A); TotalCycles += 4; PC = 0xE3B9;
                    return;
                case 0xE3B7:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3B8;
                    return;
                case 0xE3BC:
                    A |= _ram[0x000D]; SetZN(A); TotalCycles += 4; PC = 0xE3BF;
                    return;
                case 0xE3BD:
                    A |= _ram[0x0308]; SetZN(A); TotalCycles += 4; PC = 0xE3C0;
                    return;
                case 0xE3BE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3BF;
                    return;
                case 0xE3C3:
                    A |= _ram[0x000D]; SetZN(A); TotalCycles += 4; PC = 0xE3C6;
                    goto case 0xE3C6;
                case 0xE3C4:
                    A |= _ram[0x0008]; SetZN(A); TotalCycles += 4; PC = 0xE3C7;
                    goto case 0xE3C7;
                case 0xE3C5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3C6;
                    goto case 0xE3C6;
                case 0xE3C6:
                    TotalCycles += 7; PushU16(0xE3C8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE3C7:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE3CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE3CD; }
                    PC = 0xE3C9; return;
                case 0xE3CD:
                    TotalCycles += 6; PushU16(0xE3CF); PC = 0x0820;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE3CE:
                    TotalCycles += 6; PushU16(0xE3D0); PC = 0x1808;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE3CF:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3D0;
                    goto case 0xE3D0;
                case 0xE3D0:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3D1;
                    goto case 0xE3D1;
                case 0xE3D1:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3D2;
                    goto case 0xE3D2;
                case 0xE3D2:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3D3;
                    return;
                case 0xE3D4:
                    TotalCycles += 6; PushU16(0xE3D6); PC = 0x0820;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE3D5:
                    TotalCycles += 6; PushU16(0xE3D7); PC = 0x1808;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE3D6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3D7;
                    goto case 0xE3D7;
                case 0xE3D7:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3D8;
                    goto case 0xE3D8;
                case 0xE3D8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3D9;
                    goto case 0xE3D9;
                case 0xE3D9:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3DA;
                    return;
                case 0xE3DB:
                    TotalCycles += 6; PushU16(0xE3DD); PC = 0x1820;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE3DC:
                    TotalCycles += 6; PushU16(0xE3DE); PC = 0x1818;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE3DD:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3DE;
                    goto case 0xE3DE;
                case 0xE3DE:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3DF;
                    goto case 0xE3DF;
                case 0xE3DF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3E0;
                    goto case 0xE3E0;
                case 0xE3E0:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3E1;
                    goto case 0xE3E1;
                case 0xE3E1:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3E2;
                    return;
                case 0xE3E4:
                    _ram[0x06] = Asl(_ram[0x06]); TotalCycles += 5; PC = 0xE3E6;
                    goto case 0xE3E6;
                case 0xE3E5:
                    _ram[0x08] = Asl(_ram[0x08]); TotalCycles += 5; PC = 0xE3E7;
                    goto case 0xE3E7;
                case 0xE3E6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE3E7;
                    goto case 0xE3E7;
                case 0xE3E7:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE3B1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE3E9; goto case 0xE3E9;
                case 0xE3E8: // === SUBROUTINE: Sub_E3E8 ===
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE3E9;
                    goto case 0xE3E9;
                case 0xE3E9: // === SUBROUTINE: Sub_E3E9 ===
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE3EB;
                    goto case 0xE3EB;
                case 0xE3EA:
                    TotalCycles += 7; PushU16(0xE3EC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE3EB:
                    Bit(_ram[0x01A9]); TotalCycles += 4; PC = 0xE3EE;
                    goto case 0xE3EE;
                case 0xE3EC: // === SUBROUTINE: Sub_E3EC ===
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xE3EE;
                    goto case 0xE3EE;
                case 0xE3ED:
                    A |= ReadMem(ReadU16Zp((byte)(0xA2 + X))); SetZN(A); TotalCycles += 6; PC = 0xE3EF;
                    goto case 0xE3EF;
                case 0xE3EE:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xE3F0;
                    goto case 0xE3F0;
                case 0xE3EF:
                    TotalCycles += 7; PushU16(0xE3F1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE3F0: // === SUBROUTINE: Sub_E3F0 ===
                    PushU8(A); TotalCycles += 3; PC = 0xE3F1;
                    goto case 0xE3F1;
                case 0xE3F1:
                    _ram[0x04] = Y; TotalCycles += 3; PC = 0xE3F3;
                    goto case 0xE3F3;
                case 0xE3F3:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x63B0 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE3F6;
                    goto case 0xE3F6;
                case 0xE3F4:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE3D9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE3D9; }
                    PC = 0xE3F6; goto case 0xE3F6;
                case 0xE3F6:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE3F7;
                    goto case 0xE3F7;
                case 0xE3F7:
                    Adc(_ram[(byte)(0x86 + X)]); TotalCycles += 4; PC = 0xE3F9;
                    goto case 0xE3F9;
                case 0xE3F8:
                    _ram[0x85] = X; TotalCycles += 3; PC = 0xE3FA;
                    goto case 0xE3FA;
                case 0xE3F9:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0xE3FB;
                    goto case 0xE3FB;
                case 0xE3FA:
                    A |= _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xE3FC;
                    goto case 0xE3FC;
                case 0xE3FB:
                    A = _ram[(byte)(0x6D + X)]; SetZN(A); TotalCycles += 4; PC = 0xE3FD;
                    goto case 0xE3FD;
                case 0xE3FC:
                    Adc(_ram[0x0069]); TotalCycles += 4; PC = 0xE3FF;
                    goto case 0xE3FF;
                case 0xE3FD:
                    Adc(0x00); TotalCycles += 2; PC = 0xE3FF;
                    goto case 0xE3FF;
                case 0xE3FE:
                    TotalCycles += 7; PushU16(0xE400); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE3FF:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0xE401;
                    goto case 0xE401;
                case 0xE400:
                    A |= ReadMem(ReadU16Zp((byte)(0x4A + X))); SetZN(A); TotalCycles += 6; PC = 0xE402;
                    goto case 0xE402;
                case 0xE401:
                    A = Lsr(A); TotalCycles += 2; PC = 0xE402;
                    goto case 0xE402;
                case 0xE402:
                    A |= _ram[0x05]; SetZN(A); TotalCycles += 3; PC = 0xE404;
                    goto case 0xE404;
                case 0xE403:
                    A |= _ram[0x6A]; SetZN(A); TotalCycles += 3; PC = 0xE405;
                    goto case 0xE405;
                case 0xE404:
                    A = Ror(A); TotalCycles += 2; PC = 0xE405;
                    goto case 0xE405;
                case 0xE405:
                    A = Lsr(A); TotalCycles += 2; PC = 0xE406;
                    goto case 0xE406;
                case 0xE406:
                    A = Lsr(A); TotalCycles += 2; PC = 0xE407;
                    goto case 0xE407;
                case 0xE407:
                    A = Lsr(A); TotalCycles += 2; PC = 0xE408;
                    goto case 0xE408;
                case 0xE408:
                    TotalCycles += 6; PushU16(0xE40A); PC = 0x9BE1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE409:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x9B + X)))); TotalCycles += 6; PC = 0xE40B;
                    goto case 0xE40B;
                case 0xE40B:
                    Y = _ram[0x04]; SetZN(Y); TotalCycles += 3; PC = 0xE40D;
                    goto case 0xE40D;
                case 0xE40D:
                    A = _ram[(byte)(0xCE + X)]; SetZN(A); TotalCycles += 4; PC = 0xE40F;
                    goto case 0xE40F;
                case 0xE40E:
                    { int a = 0x7918; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xE411;
                    goto case 0xE411;
                case 0xE40F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE410;
                    goto case 0xE410;
                case 0xE410:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x63CC + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xE413;
                    goto case 0xE413;
                case 0xE411:
                    Cmp(Y, ReadIoReg(0x29E3)); TotalCycles += 4; PC = 0xE414;
                    goto case 0xE414;
                case 0xE413:
                    A &= 0xF0; SetZN(A); TotalCycles += 2; PC = 0xE415;
                    goto case 0xE415;
                case 0xE414:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE44E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE416; goto case 0xE416;
                case 0xE415:
                    P |= FlagC; TotalCycles += 2; PC = 0xE416;
                    goto case 0xE416;
                case 0xE416:
                    Sbc(0x20); TotalCycles += 2; PC = 0xE418;
                    goto case 0xE418;
                case 0xE417:
                    TotalCycles += 6; PushU16(0xE419); PC = 0x0285;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE418:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xE41A;
                    goto case 0xE41A;
                case 0xE41A:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE41B;
                    goto case 0xE41B;
                case 0xE41B:
                    A = ReadMem(ReadU16Zp(0x06) + Y); SetZN(A); TotalCycles += 5; PC = 0xE41D;
                    goto case 0xE41D;
                case 0xE41C:
                    _ram[0x85] = Asl(_ram[0x85]); TotalCycles += 5; PC = 0xE41E;
                    return;
                case 0xE41D:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0xE41F;
                    goto case 0xE41F;
                case 0xE41F:
                    Y = _ram[0x04]; SetZN(Y); TotalCycles += 3; PC = 0xE421;
                    goto case 0xE421;
                case 0xE421:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xE422;
                    goto case 0xE422;
                case 0xE422:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE429; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE429; }
                    PC = 0xE424; goto case 0xE424;
                case 0xE423:
                    A |= _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xE425;
                    goto case 0xE425;
                case 0xE424:
                    A = _ram[(byte)(0xCE + X)]; SetZN(A); TotalCycles += 4; PC = 0xE426;
                    goto case 0xE426;
                case 0xE425:
                    { int a = 0x2B4C; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xE428;
                    goto case 0xE428;
                case 0xE426:
                    TotalCycles += 3; PC = 0xE42B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE42B;
                case 0xE428:
                    Cmp(X, _ram[0xB5]); TotalCycles += 3; PC = 0xE42A;
                    goto case 0xE42A;
                case 0xE429:
                    A = _ram[(byte)(0x86 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE42B;
                    goto case 0xE42B;
                case 0xE42A:
                    _ram[0x29] = X; TotalCycles += 3; PC = 0xE42C;
                    return;
                case 0xE42B:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0xE42D;
                    goto case 0xE42D;
                case 0xE42D:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xE42F;
                    goto case 0xE42F;
                case 0xE42F:
                    A = _ram[0x03]; SetZN(A); TotalCycles += 3; PC = 0xE431;
                    goto case 0xE431;
                case 0xE431:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE433:
                    TotalCycles += 7; PushU16(0xE435); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE434:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE3BA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE436; goto case 0xE436;
                case 0xE435: // === SUBROUTINE: Sub_E435 ===
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0xE437;
                    goto case 0xE437;
                case 0xE436:
                    TotalCycles += 7; PushU16(0xE438); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE437:
                    A = _ram[0x03B9]; SetZN(A); TotalCycles += 4; PC = 0xE43A;
                    goto case 0xE43A;
                case 0xE438:
                    A = ReadMem(0x1803 + Y); SetZN(A); TotalCycles += 4; PC = 0xE43B;
                    goto case 0xE43B;
                case 0xE43A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE43B;
                    goto case 0xE43B;
                case 0xE43B:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x6433 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xE43E;
                    goto case 0xE43E;
                case 0xE43D:
                    Cmp(X, _ram[0xBE]); TotalCycles += 3; PC = 0xE43F;
                    goto case 0xE43F;
                case 0xE43E:
                    X = _ram[(0x039A + Y) & 0x07FF]; SetZN(X); TotalCycles += 4; PC = 0xE441;
                    goto case 0xE441;
                case 0xE43F:
                    SP = X; TotalCycles += 2; PC = 0xE440;
                    return;
                case 0xE441:
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE444;
                    goto case 0xE444;
                case 0xE442:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xE444;
                    goto case 0xE444;
                case 0xE443:
                    _ram[0x84] = Asl(_ram[0x84]); TotalCycles += 5; PC = 0xE445;
                    return;
                case 0xE444:
                    _ram[0x02] = Y; TotalCycles += 3; PC = 0xE446;
                    goto case 0xE446;
                case 0xE446:
                    TotalCycles += 6; PushU16(0xE448); PC = 0xE4AE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE4AE;
                case 0xE447:
                    X = SmbEmbeddedAssets.StaticDataTables[0x2DE4]; SetZN(X); TotalCycles += 4; PC = 0xE44A;
                    goto case 0xE44A;
                case 0xE448:
                    Cmp(X, _ram[0xAD]); TotalCycles += 3; PC = 0xE44A;
                    goto case 0xE44A;
                case 0xE449:
                    A = _ram[0x03AE]; SetZN(A); TotalCycles += 4; PC = 0xE44C;
                    goto case 0xE44C;
                case 0xE44A:
                    X = SmbEmbeddedAssets.StaticDataTables[0x1903]; SetZN(X); TotalCycles += 4; PC = 0xE44D;
                    return;
                case 0xE44C:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE44F;
                    goto case 0xE44F;
                case 0xE44F:
                    _ram[(0x020B + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE452;
                    goto case 0xE452;
                case 0xE452:
                    _ram[(0x0213 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE455;
                    goto case 0xE455;
                case 0xE455:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE456;
                    goto case 0xE456;
                case 0xE456:
                    Adc(0x06); TotalCycles += 2; PC = 0xE458;
                    goto case 0xE458;
                case 0xE457:
                    _ram[0x99] = Asl(_ram[0x99]); TotalCycles += 5; PC = 0xE459;
                    return;
                case 0xE458:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE45B;
                    goto case 0xE45B;
                case 0xE45B:
                    _ram[(0x020F + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE45E;
                    goto case 0xE45E;
                case 0xE45E:
                    _ram[(0x0217 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE461;
                    goto case 0xE461;
                case 0xE461:
                    A = 0x21; SetZN(A); TotalCycles += 2; PC = 0xE463;
                    goto case 0xE463;
                case 0xE462:
                    A &= ReadMem(ReadU16Zp((byte)(0x99 + X))); SetZN(A); TotalCycles += 6; PC = 0xE464;
                    return;
                case 0xE463:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE466;
                    goto case 0xE466;
                case 0xE466:
                    _ram[(0x020A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE469;
                    goto case 0xE469;
                case 0xE467:
                    A = Asl(A); TotalCycles += 2; PC = 0xE468;
                    return;
                case 0xE469:
                    _ram[(0x0212 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE46C;
                    goto case 0xE46C;
                case 0xE46C:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xE46E;
                    goto case 0xE46E;
                case 0xE46D:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xE46E:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE471;
                    goto case 0xE471;
                case 0xE46F:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xE471;
                    goto case 0xE471;
                case 0xE471:
                    _ram[(0x020E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE474;
                    goto case 0xE474;
                case 0xE472:
                    { int a = 0x9902; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xE475;
                    goto case 0xE475;
                case 0xE474:
                    _ram[(0x0216 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE477;
                    goto case 0xE477;
                case 0xE475:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE477;
                    goto case 0xE477;
                case 0xE477:
                    X = 0x05; SetZN(X); TotalCycles += 2; PC = 0xE479;
                    goto case 0xE479;
                case 0xE478:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE47A;
                    goto case 0xE47A;
                case 0xE479:
                    A = 0xE1; SetZN(A); TotalCycles += 2; PC = 0xE47B;
                    goto case 0xE47B;
                case 0xE47A:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x99 + X)))); TotalCycles += 6; PC = 0xE47C;
                    goto case 0xE47C;
                case 0xE47B:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE47E;
                    goto case 0xE47E;
                case 0xE47C:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE47E;
                    goto case 0xE47E;
                case 0xE47E:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE47F;
                    goto case 0xE47F;
                case 0xE47F:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE480;
                    goto case 0xE480;
                case 0xE480:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE481;
                    goto case 0xE481;
                case 0xE481:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE482;
                    goto case 0xE482;
                case 0xE482:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE483;
                    goto case 0xE483;
                case 0xE483:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE479; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE479; }
                    PC = 0xE485; goto case 0xE485;
                case 0xE485:
                    Y = _ram[0x02]; SetZN(Y); TotalCycles += 3; PC = 0xE487;
                    goto case 0xE487;
                case 0xE487:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xE489;
                    goto case 0xE489;
                case 0xE488:
                    TotalCycles += 7; PushU16(0xE48A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE489:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE490; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE490; }
                    PC = 0xE48B; goto case 0xE48B;
                case 0xE48A:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE48C;
                    goto case 0xE48C;
                case 0xE48B:
                    A = 0xE0; SetZN(A); TotalCycles += 2; PC = 0xE48D;
                    goto case 0xE48D;
                case 0xE48C:
                    Cmp(X, 0x99); TotalCycles += 2; PC = 0xE48E;
                    goto case 0xE48E;
                case 0xE48D:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE490;
                    goto case 0xE490;
                case 0xE48E: // === SUBROUTINE: Sub_E48E ===
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE490;
                    goto case 0xE490;
                case 0xE490:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xE492;
                    goto case 0xE492;
                case 0xE491:
                    TotalCycles += 7; PushU16(0xE493); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE492:
                    A = _ram[0x039D]; SetZN(A); TotalCycles += 4; PC = 0xE495;
                    goto case 0xE495;
                case 0xE493:
                    WriteMem(0x3803 + X, A); TotalCycles += 5; PC = 0xE496;
                    goto case 0xE496;
                case 0xE495:
                    P |= FlagC; TotalCycles += 2; PC = 0xE496;
                    goto case 0xE496;
                case 0xE496:
                    Sbc(_ram[(0x0200 + Y) & 0x07FF]); TotalCycles += 4; PC = 0xE499;
                    goto case 0xE499;
                case 0xE497:
                    TotalCycles += 7; PushU16(0xE499); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE499:
                    Cmp(A, 0x64); TotalCycles += 2; PC = 0xE49B;
                    goto case 0xE49B;
                case 0xE49B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE4A2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE4A2; }
                    PC = 0xE49D; goto case 0xE49D;
                case 0xE49C:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE49E;
                    goto case 0xE49E;
                case 0xE49D:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE49F;
                    goto case 0xE49F;
                case 0xE49E:
                    P |= FlagD; TotalCycles += 2; PC = 0xE49F;
                    goto case 0xE49F;
                case 0xE49F:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE4A2;
                    goto case 0xE4A2;
                case 0xE4A0:
                    TotalCycles += 7; PushU16(0xE4A2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4A2:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE4A3;
                    goto case 0xE4A3;
                case 0xE4A3:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE4A4;
                    goto case 0xE4A4;
                case 0xE4A4:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE4A5;
                    goto case 0xE4A5;
                case 0xE4A5:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE4A6;
                    goto case 0xE4A6;
                case 0xE4A6:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xE4A7;
                    goto case 0xE4A7;
                case 0xE4A7:
                    Cmp(X, 0x06); TotalCycles += 2; PC = 0xE4A9;
                    goto case 0xE4A9;
                case 0xE4A8:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xE4AA;
                    return;
                case 0xE4A9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE492; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE492; }
                    PC = 0xE4AB; goto case 0xE4AB;
                case 0xE4AB:
                    Y = _ram[0x00]; SetZN(Y); TotalCycles += 3; PC = 0xE4AD;
                    goto case 0xE4AD;
                case 0xE4AC:
                    TotalCycles += 7; PushU16(0xE4AE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4AD:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE4AE: // === SUBROUTINE: Sub_E4AE ===
                    X = 0x06; SetZN(X); TotalCycles += 2; PC = 0xE4B0;
                    goto case 0xE4B0;
                case 0xE4AF:
                    _ram[0x99] = Asl(_ram[0x99]); TotalCycles += 5; PC = 0xE4B1;
                    goto case 0xE4B1;
                case 0xE4B0:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE4B3;
                    goto case 0xE4B3;
                case 0xE4B1:
                    TotalCycles += 7; PushU16(0xE4B3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4B3:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE4B4;
                    goto case 0xE4B4;
                case 0xE4B4:
                    Adc(0x08); TotalCycles += 2; PC = 0xE4B6;
                    goto case 0xE4B6;
                case 0xE4B5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE4B6;
                    goto case 0xE4B6;
                case 0xE4B6:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE4B7;
                    goto case 0xE4B7;
                case 0xE4B7:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE4B8;
                    goto case 0xE4B8;
                case 0xE4B8:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE4B9;
                    goto case 0xE4B9;
                case 0xE4B9:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE4BA;
                    goto case 0xE4BA;
                case 0xE4BA:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE4BB;
                    goto case 0xE4BB;
                case 0xE4BB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE4B0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE4B0; }
                    PC = 0xE4BD; goto case 0xE4BD;
                case 0xE4BD:
                    Y = _ram[0x02]; SetZN(Y); TotalCycles += 3; PC = 0xE4BF;
                    goto case 0xE4BF;
                case 0xE4BF:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE4C1:
                    TotalCycles += 7; PushU16(0xE4C3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4C3:
                    TotalCycles += 7; PushU16(0xE4C5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4C4:
                    TotalCycles += 7; PushU16(0xE4C6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4C6:
                    TotalCycles += 7; PushU16(0xE4C8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4C8:
                    TotalCycles += 7; PushU16(0xE4CA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4C9:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE4CA;
                    goto case 0xE4CA;
                case 0xE4CA:
                    TotalCycles += 7; PushU16(0xE4CC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4CB:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE4CC;
                    goto case 0xE4CC;
                case 0xE4CC:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE4CD;
                    goto case 0xE4CD;
                case 0xE4CD:
                    TotalCycles += 7; PushU16(0xE4CF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4CE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE4CF;
                    goto case 0xE4CF;
                case 0xE4CF:
                    TotalCycles += 7; PushU16(0xE4D1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4D2:
                    WriteMem(ReadU16Zp((byte)(0x83 + X)), A); TotalCycles += 6; PC = 0xE4D4;
                    goto case 0xE4D4;
                case 0xE4D4:
                    WriteMem(ReadU16Zp((byte)(0x83 + X)), A); TotalCycles += 6; PC = 0xE4D6;
                    return;
                case 0xE4DC: // === SUBROUTINE: Sub_E4DC ===
                    Y = _ram[(0x06F3 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE4DF;
                    goto case 0xE4DF;
                case 0xE4DE:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xE4E0;
                    return;
                case 0xE4DF:
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xE4E2;
                    goto case 0xE4E2;
                case 0xE4E2:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE4EC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE4EC; }
                    PC = 0xE4E4; goto case 0xE4E4;
                case 0xE4E3:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE4E4;
                    goto case 0xE4E4;
                case 0xE4E4:
                    A = _ram[(byte)(0x2A + X)]; SetZN(A); TotalCycles += 4; PC = 0xE4E6;
                    goto case 0xE4E6;
                case 0xE4E5:
                    A = Rol(A); TotalCycles += 2; PC = 0xE4E6;
                    goto case 0xE4E6;
                case 0xE4E6:
                    A &= 0x7F; SetZN(A); TotalCycles += 2; PC = 0xE4E8;
                    goto case 0xE4E8;
                case 0xE4E8:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xE4EA;
                    goto case 0xE4EA;
                case 0xE4E9:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0xE4EB;
                    return;
                case 0xE4EA:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE4F0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE4F0; }
                    PC = 0xE4EC; goto case 0xE4EC;
                case 0xE4EC:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xE4EE;
                    goto case 0xE4EE;
                case 0xE4ED:
                    TotalCycles += 7; PushU16(0xE4EF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE4EE:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE4F7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE4F7; }
                    PC = 0xE4F0; goto case 0xE4F0;
                case 0xE4F0:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xE4F2;
                    goto case 0xE4F2;
                case 0xE4F1:
                    A |= 0x4A; SetZN(A); TotalCycles += 2; PC = 0xE4F3;
                    goto case 0xE4F3;
                case 0xE4F2:
                    A = Lsr(A); TotalCycles += 2; PC = 0xE4F3;
                    goto case 0xE4F3;
                case 0xE4F3:
                    A = Lsr(A); TotalCycles += 2; PC = 0xE4F4;
                    goto case 0xE4F4;
                case 0xE4F4:
                    A &= 0x03; SetZN(A); TotalCycles += 2; PC = 0xE4F6;
                    goto case 0xE4F6;
                case 0xE4F6:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE4F7;
                    goto case 0xE4F7;
                case 0xE4F7:
                    A = _ram[0x03BE]; SetZN(A); TotalCycles += 4; PC = 0xE4FA;
                    goto case 0xE4FA;
                case 0xE4F8:
                    X = ReadMem(0x1803 + Y); SetZN(X); TotalCycles += 4; PC = 0xE4FB;
                    goto case 0xE4FB;
                case 0xE4FA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE4FB;
                    goto case 0xE4FB;
                case 0xE4FB:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x64C4 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE4FE;
                    goto case 0xE4FE;
                case 0xE4FC:
                    Cmp(Y, _ram[0xE4]); TotalCycles += 3; PC = 0xE4FE;
                    goto case 0xE4FE;
                case 0xE4FD:
                    Cmp(X, _ram[0x99]); TotalCycles += 3; PC = 0xE4FF;
                    goto case 0xE4FF;
                case 0xE4FE:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE501;
                    goto case 0xE501;
                case 0xE4FF:
                    TotalCycles += 7; PushU16(0xE501); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE501:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE502;
                    goto case 0xE502;
                case 0xE502:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x64CC + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE505;
                    goto case 0xE505;
                case 0xE503:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x19E4]); TotalCycles += 4; PC = 0xE506;
                    return;
                case 0xE504:
                    Cmp(X, _ram[0x99]); TotalCycles += 3; PC = 0xE506;
                    return;
                case 0xE505:
                    _ram[(0x0204 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE508;
                    goto case 0xE508;
                case 0xE508:
                    A = _ram[0x03B3]; SetZN(A); TotalCycles += 4; PC = 0xE50B;
                    goto case 0xE50B;
                case 0xE50B:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE50C;
                    goto case 0xE50C;
                case 0xE50C:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x64C0 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE50F;
                    goto case 0xE50F;
                case 0xE50D:
                    Cmp(Y, 0xE4); TotalCycles += 2; PC = 0xE50F;
                    goto case 0xE50F;
                case 0xE50E:
                    Cmp(X, _ram[0x99]); TotalCycles += 3; PC = 0xE510;
                    return;
                case 0xE50F:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE512;
                    goto case 0xE512;
                case 0xE512:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE513;
                    goto case 0xE513;
                case 0xE513:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x64C8 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE516;
                    goto case 0xE516;
                case 0xE514:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE515;
                    goto case 0xE515;
                case 0xE515:
                    Cmp(X, _ram[0x99]); TotalCycles += 3; PC = 0xE517;
                    return;
                case 0xE516:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE519;
                    goto case 0xE519;
                case 0xE519:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x64D0 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE51C;
                    goto case 0xE51C;
                case 0xE51A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE500; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE51C; goto case 0xE51C;
                case 0xE51B:
                    Cmp(X, _ram[0x99]); TotalCycles += 3; PC = 0xE51D;
                    goto case 0xE51D;
                case 0xE51C:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE51F;
                    goto case 0xE51F;
                case 0xE51D:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE51F;
                    goto case 0xE51F;
                case 0xE51F:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x64D4 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE522;
                    goto case 0xE522;
                case 0xE521:
                    Cmp(X, _ram[0x99]); TotalCycles += 3; PC = 0xE523;
                    goto case 0xE523;
                case 0xE522:
                    _ram[(0x0205 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE525;
                    goto case 0xE525;
                case 0xE523:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xE525;
                    goto case 0xE525;
                case 0xE525:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x64D8 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE528;
                    goto case 0xE528;
                case 0xE526:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xE527;
                    goto case 0xE527;
                case 0xE527:
                    Cmp(X, _ram[0x99]); TotalCycles += 3; PC = 0xE529;
                    return;
                case 0xE528:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE52B;
                    goto case 0xE52B;
                case 0xE52B:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE52E;
                    goto case 0xE52E;
                case 0xE52C:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xE52E;
                    goto case 0xE52E;
                case 0xE52E:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xE530;
                    goto case 0xE530;
                case 0xE52F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE530;
                    goto case 0xE530;
                case 0xE530:
                    A = _ram[0x03D6]; SetZN(A); TotalCycles += 4; PC = 0xE533;
                    goto case 0xE533;
                case 0xE531:
                    { byte z = (byte)(0x03 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xE533;
                    goto case 0xE533;
                case 0xE533:
                    A &= 0xFC; SetZN(A); TotalCycles += 2; PC = 0xE535;
                    goto case 0xE535;
                case 0xE535:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE540; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE540; }
                    PC = 0xE537; goto case 0xE537;
                case 0xE536:
                    A |= 0xA9; SetZN(A); TotalCycles += 2; PC = 0xE538;
                    goto case 0xE538;
                case 0xE537:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE539;
                    goto case 0xE539;
                case 0xE538:
                    TotalCycles += 7; PushU16(0xE53A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE539:
                    _ram[(byte)(0x2A + X)] = A; TotalCycles += 4; PC = 0xE53B;
                    goto case 0xE53B;
                case 0xE53A:
                    A = Rol(A); TotalCycles += 2; PC = 0xE53B;
                    goto case 0xE53B;
                case 0xE53B:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE53D;
                    goto case 0xE53D;
                case 0xE53C:
                    P |= FlagD; TotalCycles += 2; PC = 0xE53D;
                    goto case 0xE53D;
                case 0xE53D:
                    TotalCycles += 6; PushU16(0xE53F); PC = 0xE5C1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5C1;
                case 0xE53E:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xE5 + X)))); TotalCycles += 6; PC = 0xE540;
                    goto case 0xE540;
                case 0xE53F:
                    Sbc(_ram[0x60]); TotalCycles += 3; PC = 0xE541;
                    goto case 0xE541;
                case 0xE540:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE541:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7750 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xE544;
                    goto case 0xE544;
                case 0xE542:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xE53B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE53B; }
                    PC = 0xE544; goto case 0xE544;
                case 0xE544:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xE540; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE540; }
                    PC = 0xE546; return;
                case 0xE547:
                    P |= FlagD; TotalCycles += 2; PC = 0xE548;
                    return;
                case 0xE549:
                    { byte z = (byte)(0xFB + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xE54B;
                    goto case 0xE54B;
                case 0xE54B: // === SUBROUTINE: Sub_E54B ===
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE54E;
                    goto case 0xE54E;
                case 0xE54C:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xE54E;
                    goto case 0xE54E;
                case 0xE54D:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xE54F;
                    goto case 0xE54F;
                case 0xE54E:
                    A = _ram[0x03AE]; SetZN(A); TotalCycles += 4; PC = 0xE551;
                    goto case 0xE551;
                case 0xE54F:
                    X = SmbEmbeddedAssets.StaticDataTables[0x1903]; SetZN(X); TotalCycles += 4; PC = 0xE552;
                    return;
                case 0xE551:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE554;
                    goto case 0xE554;
                case 0xE554:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE555;
                    goto case 0xE555;
                case 0xE555:
                    Adc(0x08); TotalCycles += 2; PC = 0xE557;
                    goto case 0xE557;
                case 0xE556:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE557;
                    goto case 0xE557;
                case 0xE557:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE55A;
                    goto case 0xE55A;
                case 0xE55A:
                    _ram[(0x020B + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE55D;
                    goto case 0xE55D;
                case 0xE55D:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE55E;
                    goto case 0xE55E;
                case 0xE55E:
                    Adc(0x0C); TotalCycles += 2; PC = 0xE560;
                    goto case 0xE560;
                case 0xE560:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0xE562;
                    goto case 0xE562;
                case 0xE561:
                    A |= _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xE563;
                    return;
                case 0xE562:
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xE564;
                    goto case 0xE564;
                case 0xE564:
                    TotalCycles += 6; PushU16(0xE566); PC = 0xE5C1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5C1;
                case 0xE565:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xE5 + X)))); TotalCycles += 6; PC = 0xE567;
                    goto case 0xE567;
                case 0xE566:
                    Sbc(_ram[0x69]); TotalCycles += 3; PC = 0xE568;
                    goto case 0xE568;
                case 0xE567:
                    Adc(0x08); TotalCycles += 2; PC = 0xE569;
                    goto case 0xE569;
                case 0xE568:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE569;
                    goto case 0xE569;
                case 0xE569:
                    _ram[(0x0208 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE56C;
                    goto case 0xE56C;
                case 0xE56A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE56B;
                    return;
                case 0xE56C:
                    A = _ram[0x010D]; SetZN(A); TotalCycles += 4; PC = 0xE56F;
                    goto case 0xE56F;
                case 0xE56D:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x0501]; SetZN(A); TotalCycles += 4; PC = 0xE570;
                    return;
                case 0xE56E:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xE570;
                    return;
                case 0xE56F:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xE571;
                    goto case 0xE571;
                case 0xE571:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xE573;
                    goto case 0xE573;
                case 0xE572:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xE574;
                    return;
                case 0xE573:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0xE575;
                    goto case 0xE575;
                case 0xE575:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xE577;
                    goto case 0xE577;
                case 0xE577:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE57A;
                    goto case 0xE57A;
                case 0xE57A:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE57D;
                    goto case 0xE57D;
                case 0xE57B:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xE57D;
                    goto case 0xE57D;
                case 0xE57D:
                    _ram[(0x020A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE580;
                    goto case 0xE580;
                case 0xE57E:
                    A = Asl(A); TotalCycles += 2; PC = 0xE57F;
                    return;
                case 0xE580:
                    A = 0x7E; SetZN(A); TotalCycles += 2; PC = 0xE582;
                    goto case 0xE582;
                case 0xE581:
                    { int a = (0x0199 + X) & 0x07FF; _ram[a] = Ror(_ram[a]); } TotalCycles += 7; PC = 0xE584;
                    return;
                case 0xE582:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE585;
                    goto case 0xE585;
                case 0xE583:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE585;
                    goto case 0xE585;
                case 0xE585:
                    _ram[(0x0209 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE588;
                    goto case 0xE588;
                case 0xE586:
                    A |= 0x02; SetZN(A); TotalCycles += 2; PC = 0xE588;
                    goto case 0xE588;
                case 0xE588:
                    A = 0x7F; SetZN(A); TotalCycles += 2; PC = 0xE58A;
                    goto case 0xE58A;
                case 0xE58A:
                    _ram[(0x0205 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE58D;
                    goto case 0xE58D;
                case 0xE58B:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xE58D;
                    goto case 0xE58D;
                case 0xE58D:
                    A = _ram[0x070F]; SetZN(A); TotalCycles += 4; PC = 0xE590;
                    goto case 0xE590;
                case 0xE590:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE5A7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE5A7; }
                    PC = 0xE592; goto case 0xE592;
                case 0xE591:
                    A |= _ram[(byte)(0x98 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE593;
                    goto case 0xE593;
                case 0xE592:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xE593;
                    goto case 0xE593;
                case 0xE593:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE594;
                    goto case 0xE594;
                case 0xE594:
                    Adc(0x0C); TotalCycles += 2; PC = 0xE596;
                    goto case 0xE596;
                case 0xE596:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE597;
                    goto case 0xE597;
                case 0xE597:
                    A = _ram[0x010F]; SetZN(A); TotalCycles += 4; PC = 0xE59A;
                    goto case 0xE59A;
                case 0xE599:
                    A |= ReadMem(ReadU16Zp((byte)(0x0A + X))); SetZN(A); TotalCycles += 6; PC = 0xE59B;
                    goto case 0xE59B;
                case 0xE59A: // === SUBROUTINE: Sub_E59A ===
                    A = Asl(A); TotalCycles += 2; PC = 0xE59B;
                    goto case 0xE59B;
                case 0xE59B:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE59C;
                    goto case 0xE59C;
                case 0xE59C:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6541 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE59F;
                    goto case 0xE59F;
                case 0xE59D:
                    A ^= ReadMem(ReadU16Zp((byte)(0xE5 + X))); SetZN(A); TotalCycles += 6; PC = 0xE59F;
                    goto case 0xE59F;
                case 0xE59E:
                    Sbc(_ram[0x85]); TotalCycles += 3; PC = 0xE5A0;
                    goto case 0xE5A0;
                case 0xE59F:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xE5A1;
                    goto case 0xE5A1;
                case 0xE5A0:
                    TotalCycles += 7; PushU16(0xE5A2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE5A1:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6542 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE5A4;
                    goto case 0xE5A4;
                case 0xE5A3:
                    Sbc(_ram[0x20]); TotalCycles += 3; PC = 0xE5A5;
                    return;
                case 0xE5A4:
                    TotalCycles += 6; PushU16(0xE5A6); PC = 0xEBB2;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBB2;
                case 0xE5A7:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xE5A9;
                    goto case 0xE5A9;
                case 0xE5A8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE5A9;
                    goto case 0xE5A9;
                case 0xE5A9:
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE5AC;
                    goto case 0xE5AC;
                case 0xE5AA:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xE5AC;
                    goto case 0xE5AC;
                case 0xE5AB:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xE5AD;
                    goto case 0xE5AD;
                case 0xE5AC:
                    A = _ram[0x03D1]; SetZN(A); TotalCycles += 4; PC = 0xE5AF;
                    goto case 0xE5AF;
                case 0xE5AD:
                    Cmp(A, ReadMem(ReadU16Zp(0x03) + Y)); TotalCycles += 5; PC = 0xE5AF;
                    goto case 0xE5AF;
                case 0xE5AF:
                    A &= 0x0E; SetZN(A); TotalCycles += 2; PC = 0xE5B1;
                    goto case 0xE5B1;
                case 0xE5B0:
                    _ram[0x04F0] = Asl(_ram[0x04F0]); TotalCycles += 6; PC = 0xE5B3;
                    goto case 0xE5B3;
                case 0xE5B1:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE5C7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE5C7; }
                    PC = 0xE5B3; goto case 0xE5B3;
                case 0xE5B3: // === SUBROUTINE: Sub_E5B3 ===
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE5B5;
                    goto case 0xE5B5;
                case 0xE5B4:
                    P |= FlagD; TotalCycles += 2; PC = 0xE5B5;
                    goto case 0xE5B5;
                case 0xE5B5: // === SUBROUTINE: Sub_E5B5 ===
                    _ram[(0x0214 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE5B8;
                    goto case 0xE5B8;
                case 0xE5B8:
                    _ram[(0x0210 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE5BB;
                    goto case 0xE5BB;
                case 0xE5B9:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE5BD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE5BB; goto case 0xE5BB;
                case 0xE5BB: // === SUBROUTINE: Sub_E5BB ===
                    _ram[(0x020C + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE5BE;
                    goto case 0xE5BE;
                case 0xE5BE: // === SUBROUTINE: Sub_E5BE ===
                    _ram[(0x0208 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE5C1;
                    goto case 0xE5C1;
                case 0xE5BF:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE5C0;
                    return;
                case 0xE5C1: // === SUBROUTINE: Sub_E5C1 ===
                    _ram[(0x0204 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE5C4;
                    goto case 0xE5C4;
                case 0xE5C4:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE5C7;
                    goto case 0xE5C7;
                case 0xE5C5:
                    TotalCycles += 7; PushU16(0xE5C7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE5C7:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE5C8: // === SUBROUTINE: Sub_E5C8 ===
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE5CB;
                    goto case 0xE5CB;
                case 0xE5C9:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xE5CB;
                    goto case 0xE5CB;
                case 0xE5CA:
                    _ram[0x84] = Asl(_ram[0x84]); TotalCycles += 5; PC = 0xE5CC;
                    return;
                case 0xE5CB:
                    _ram[0x02] = Y; TotalCycles += 3; PC = 0xE5CD;
                    goto case 0xE5CD;
                case 0xE5CD:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE5CE;
                    goto case 0xE5CE;
                case 0xE5CE:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE5CF;
                    goto case 0xE5CF;
                case 0xE5CF:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE5D0;
                    goto case 0xE5D0;
                case 0xE5D0:
                    A = _ram[0x03AE]; SetZN(A); TotalCycles += 4; PC = 0xE5D3;
                    goto case 0xE5D3;
                case 0xE5D1:
                    X = ReadIoReg(0x2003); SetZN(X); TotalCycles += 4; PC = 0xE5D4;
                    goto case 0xE5D4;
                case 0xE5D3:
                    TotalCycles += 6; PushU16(0xE5D5); PC = 0xE4AE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE4AE;
                case 0xE5D4:
                    X = SmbEmbeddedAssets.StaticDataTables[0x26E4]; SetZN(X); TotalCycles += 4; PC = 0xE5D7;
                    goto case 0xE5D7;
                case 0xE5D5:
                    Cmp(X, _ram[0xA6]); TotalCycles += 3; PC = 0xE5D7;
                    goto case 0xE5D7;
                case 0xE5D6:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xE5D8;
                    goto case 0xE5D8;
                case 0xE5D7:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE5D8;
                    goto case 0xE5D8;
                case 0xE5D8:
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xE5DA;
                    goto case 0xE5DA;
                case 0xE5DA:
                    TotalCycles += 6; PushU16(0xE5DC); PC = 0xE5BB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5BB;
                case 0xE5DC:
                    Sbc(_ram[0xAC]); TotalCycles += 3; PC = 0xE5DE;
                    goto case 0xE5DE;
                case 0xE5DD:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0xE5E0;
                    goto case 0xE5E0;
                case 0xE5DE:
                    { int a = 0xC007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xE5E1;
                    return;
                case 0xE5E0:
                    Cmp(Y, 0x03); TotalCycles += 2; PC = 0xE5E2;
                    goto case 0xE5E2;
                case 0xE5E2:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE5E9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE5E9; }
                    PC = 0xE5E4; goto case 0xE5E4;
                case 0xE5E3:
                    A |= _ram[0xAC]; SetZN(A); TotalCycles += 3; PC = 0xE5E5;
                    goto case 0xE5E5;
                case 0xE5E4:
                    Y = _ram[0x06CC]; SetZN(Y); TotalCycles += 4; PC = 0xE5E7;
                    goto case 0xE5E7;
                case 0xE5E5:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x7006]); TotalCycles += 4; PC = 0xE5E8;
                    return;
                case 0xE5E6:
                    _ram[0xF0] = Asl(_ram[0xF0]); TotalCycles += 5; PC = 0xE5E8;
                    return;
                case 0xE5E7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE5EB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE5EB; }
                    PC = 0xE5E9; goto case 0xE5E9;
                case 0xE5E9:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE5EB;
                    goto case 0xE5EB;
                case 0xE5EA:
                    P |= FlagD; TotalCycles += 2; PC = 0xE5EB;
                    goto case 0xE5EB;
                case 0xE5EB:
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE5EE;
                    goto case 0xE5EE;
                case 0xE5EC:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xE5EE;
                    goto case 0xE5EE;
                case 0xE5ED:
                    _ram[0x99] = Asl(_ram[0x99]); TotalCycles += 5; PC = 0xE5EF;
                    goto case 0xE5EF;
                case 0xE5EE:
                    _ram[(0x0210 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE5F1;
                    goto case 0xE5F1;
                case 0xE5EF:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE5F3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE5F1; goto case 0xE5F1;
                case 0xE5F1:
                    _ram[(0x0214 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE5F4;
                    goto case 0xE5F4;
                case 0xE5F4:
                    A = 0x5B; SetZN(A); TotalCycles += 2; PC = 0xE5F6;
                    goto case 0xE5F6;
                case 0xE5F6:
                    X = _ram[0x0743]; SetZN(X); TotalCycles += 4; PC = 0xE5F9;
                    goto case 0xE5F9;
                case 0xE5F9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE5FD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE5FD; }
                    PC = 0xE5FB; goto case 0xE5FB;
                case 0xE5FB:
                    A = 0x75; SetZN(A); TotalCycles += 2; PC = 0xE5FD;
                    goto case 0xE5FD;
                case 0xE5FC:
                    Adc(_ram[(byte)(0xA6 + X)]); TotalCycles += 4; PC = 0xE5FE;
                    goto case 0xE5FE;
                case 0xE5FD:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xE5FF;
                    goto case 0xE5FF;
                case 0xE5FE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE5FF;
                    goto case 0xE5FF;
                case 0xE5FF:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE600;
                    goto case 0xE600;
                case 0xE600:
                    TotalCycles += 6; PushU16(0xE602); PC = 0xE5B5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5B5;
                case 0xE601:
                    A = _ram[(byte)(0xE5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE603;
                    goto case 0xE603;
                case 0xE602:
                    Sbc(_ram[0xA9]); TotalCycles += 3; PC = 0xE604;
                    return;
                case 0xE603:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xE605;
                    goto case 0xE605;
                case 0xE605:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE606;
                    goto case 0xE606;
                case 0xE606:
                    TotalCycles += 6; PushU16(0xE608); PC = 0xE5B5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5B5;
                case 0xE607:
                    A = _ram[(byte)(0xE5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE609;
                    goto case 0xE609;
                case 0xE608:
                    Sbc(_ram[0xE8]); TotalCycles += 3; PC = 0xE60A;
                    goto case 0xE60A;
                case 0xE609:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xE60A;
                    goto case 0xE60A;
                case 0xE60A:
                    TotalCycles += 6; PushU16(0xE60C); PC = 0xF1F6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1F6;
                case 0xE60B:
                    { byte z = (byte)(0xF1 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xE60D;
                    goto case 0xE60D;
                case 0xE60C:
                    Sbc(ReadMem(ReadU16Zp(0xCA) + Y)); TotalCycles += 5; PC = 0xE60E;
                    goto case 0xE60E;
                case 0xE60D:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE60E;
                    goto case 0xE60E;
                case 0xE60E:
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE611;
                    goto case 0xE611;
                case 0xE60F:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xE611;
                    goto case 0xE611;
                case 0xE610:
                    _ram[0x0A] = Asl(_ram[0x0A]); TotalCycles += 5; PC = 0xE612;
                    goto case 0xE612;
                case 0xE611:
                    A = Asl(A); TotalCycles += 2; PC = 0xE612;
                    goto case 0xE612;
                case 0xE612:
                    PushU8(A); TotalCycles += 3; PC = 0xE613;
                    goto case 0xE613;
                case 0xE613:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE61A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE61A; }
                    PC = 0xE615; goto case 0xE615;
                case 0xE614:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE616;
                    goto case 0xE616;
                case 0xE615:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE617;
                    goto case 0xE617;
                case 0xE616:
                    P |= FlagD; TotalCycles += 2; PC = 0xE617;
                    goto case 0xE617;
                case 0xE617:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE61A;
                    goto case 0xE61A;
                case 0xE618:
                    TotalCycles += 7; PushU16(0xE61A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE61A:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xE61B;
                    goto case 0xE61B;
                case 0xE61B:
                    A = Asl(A); TotalCycles += 2; PC = 0xE61C;
                    goto case 0xE61C;
                case 0xE61C:
                    PushU8(A); TotalCycles += 3; PC = 0xE61D;
                    goto case 0xE61D;
                case 0xE61D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE624; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE624; }
                    PC = 0xE61F; goto case 0xE61F;
                case 0xE61E:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE620;
                    goto case 0xE620;
                case 0xE61F:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE621;
                    goto case 0xE621;
                case 0xE620:
                    P |= FlagD; TotalCycles += 2; PC = 0xE621;
                    goto case 0xE621;
                case 0xE621:
                    _ram[(0x0204 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE624;
                    goto case 0xE624;
                case 0xE624:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xE625;
                    goto case 0xE625;
                case 0xE625:
                    A = Asl(A); TotalCycles += 2; PC = 0xE626;
                    goto case 0xE626;
                case 0xE626:
                    PushU8(A); TotalCycles += 3; PC = 0xE627;
                    goto case 0xE627;
                case 0xE627:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE62E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE62E; }
                    PC = 0xE629; goto case 0xE629;
                case 0xE628:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE62A;
                    goto case 0xE62A;
                case 0xE629:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE62B;
                    goto case 0xE62B;
                case 0xE62A:
                    P |= FlagD; TotalCycles += 2; PC = 0xE62B;
                    goto case 0xE62B;
                case 0xE62B:
                    _ram[(0x0208 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE62E;
                    goto case 0xE62E;
                case 0xE62C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE62D;
                    return;
                case 0xE62E:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xE62F;
                    goto case 0xE62F;
                case 0xE62F:
                    A = Asl(A); TotalCycles += 2; PC = 0xE630;
                    goto case 0xE630;
                case 0xE630:
                    PushU8(A); TotalCycles += 3; PC = 0xE631;
                    goto case 0xE631;
                case 0xE631:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE638; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE638; }
                    PC = 0xE633; goto case 0xE633;
                case 0xE632:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE634;
                    goto case 0xE634;
                case 0xE633:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE635;
                    goto case 0xE635;
                case 0xE634:
                    P |= FlagD; TotalCycles += 2; PC = 0xE635;
                    goto case 0xE635;
                case 0xE635:
                    _ram[(0x020C + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE638;
                    goto case 0xE638;
                case 0xE638:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xE639;
                    goto case 0xE639;
                case 0xE639:
                    A = Asl(A); TotalCycles += 2; PC = 0xE63A;
                    goto case 0xE63A;
                case 0xE63A:
                    PushU8(A); TotalCycles += 3; PC = 0xE63B;
                    goto case 0xE63B;
                case 0xE63B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE642; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE642; }
                    PC = 0xE63D; goto case 0xE63D;
                case 0xE63C:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE63E;
                    goto case 0xE63E;
                case 0xE63D:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE63F;
                    goto case 0xE63F;
                case 0xE63E:
                    P |= FlagD; TotalCycles += 2; PC = 0xE63F;
                    goto case 0xE63F;
                case 0xE63F:
                    _ram[(0x0210 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE642;
                    goto case 0xE642;
                case 0xE640:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE644; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE644; }
                    PC = 0xE642; goto case 0xE642;
                case 0xE642:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xE643;
                    goto case 0xE643;
                case 0xE643:
                    A = Asl(A); TotalCycles += 2; PC = 0xE644;
                    goto case 0xE644;
                case 0xE644:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE64B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE64B; }
                    PC = 0xE646; goto case 0xE646;
                case 0xE645:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xE647;
                    goto case 0xE647;
                case 0xE646:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xE648;
                    goto case 0xE648;
                case 0xE647:
                    P |= FlagD; TotalCycles += 2; PC = 0xE648;
                    goto case 0xE648;
                case 0xE648:
                    _ram[(0x0214 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE64B;
                    goto case 0xE64B;
                case 0xE64B:
                    A = _ram[0x03D1]; SetZN(A); TotalCycles += 4; PC = 0xE64E;
                    goto case 0xE64E;
                case 0xE64C:
                    Cmp(A, ReadMem(ReadU16Zp(0x03) + Y)); TotalCycles += 5; PC = 0xE64E;
                    goto case 0xE64E;
                case 0xE64E:
                    A = Asl(A); TotalCycles += 2; PC = 0xE64F;
                    goto case 0xE64F;
                case 0xE64F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE654; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE654; }
                    PC = 0xE651; goto case 0xE651;
                case 0xE651:
                    TotalCycles += 6; PushU16(0xE653); PC = 0xE5B3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5B3;
                case 0xE653:
                    Sbc(_ram[0x60]); TotalCycles += 3; PC = 0xE655;
                    goto case 0xE655;
                case 0xE654:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE655:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xE657;
                    goto case 0xE657;
                case 0xE656:
                    A |= 0x4A; SetZN(A); TotalCycles += 2; PC = 0xE658;
                    goto case 0xE658;
                case 0xE657:
                    A = Lsr(A); TotalCycles += 2; PC = 0xE658;
                    goto case 0xE658;
                case 0xE658:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE65C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE65C; }
                    PC = 0xE65A; goto case 0xE65A;
                case 0xE65A:
                    { byte z = (byte)(0xDB + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xE65C;
                    goto case 0xE65C;
                case 0xE65C:
                    A = _ram[(byte)(0xDB + X)]; SetZN(A); TotalCycles += 4; PC = 0xE65E;
                    goto case 0xE65E;
                case 0xE65E:
                    TotalCycles += 6; PushU16(0xE660); PC = 0xE5C1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5C1;
                case 0xE65F:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xE5 + X)))); TotalCycles += 6; PC = 0xE661;
                    goto case 0xE661;
                case 0xE660:
                    Sbc(_ram[0xAD]); TotalCycles += 3; PC = 0xE662;
                    return;
                case 0xE661:
                    A = _ram[0x03B3]; SetZN(A); TotalCycles += 4; PC = 0xE664;
                    goto case 0xE664;
                case 0xE664:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE667;
                    goto case 0xE667;
                case 0xE667:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE668;
                    goto case 0xE668;
                case 0xE668:
                    Adc(0x08); TotalCycles += 2; PC = 0xE66A;
                    goto case 0xE66A;
                case 0xE669:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE66A;
                    goto case 0xE66A;
                case 0xE66A:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE66D;
                    goto case 0xE66D;
                case 0xE66D:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xE66F;
                    goto case 0xE66F;
                case 0xE66F:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE672;
                    goto case 0xE672;
                case 0xE672:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE675;
                    goto case 0xE675;
                case 0xE673:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xE675;
                    goto case 0xE675;
                case 0xE675:
                    A = 0xF7; SetZN(A); TotalCycles += 2; PC = 0xE677;
                    goto case 0xE677;
                case 0xE677:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE67A;
                    goto case 0xE67A;
                case 0xE678:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE67A;
                    goto case 0xE67A;
                case 0xE67A:
                    A = 0xFB; SetZN(A); TotalCycles += 2; PC = 0xE67C;
                    goto case 0xE67C;
                case 0xE67C:
                    _ram[(0x0205 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE67F;
                    goto case 0xE67F;
                case 0xE67D:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xE67F;
                    goto case 0xE67F;
                case 0xE67F:
                    TotalCycles += 3; PC = 0xE6BD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE6BD;
                case 0xE680:
                    A = ReadMem(0x60E6 + X); SetZN(A); TotalCycles += 4; PC = 0xE683;
                    goto case 0xE683;
                case 0xE681:
                    _ram[0x60] = IncVal(_ram[0x60]); TotalCycles += 5; PC = 0xE683;
                    goto case 0xE683;
                case 0xE682: // === SUBROUTINE: Sub_E682 ===
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE683:
                    Adc(ReadMem(ReadU16Zp((byte)(0x62 + X)))); TotalCycles += 6; PC = 0xE685;
                    return;
                case 0xE686: // === SUBROUTINE: Sub_E686 ===
                    Y = _ram[(0x06F3 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE689;
                    goto case 0xE689;
                case 0xE688: // === SUBROUTINE: Sub_E688 ===
                    _ram[0xB5] = Asl(_ram[0xB5]); TotalCycles += 5; PC = 0xE68A;
                    goto case 0xE68A;
                case 0xE689:
                    A = _ram[(byte)(0x2A + X)]; SetZN(A); TotalCycles += 4; PC = 0xE68B;
                    goto case 0xE68B;
                case 0xE68A:
                    A = Rol(A); TotalCycles += 2; PC = 0xE68B;
                    goto case 0xE68B;
                case 0xE68B:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xE68D;
                    goto case 0xE68D;
                case 0xE68D:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE655; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE655; }
                    PC = 0xE68F; goto case 0xE68F;
                case 0xE68E:
                    _ram[0xB5] = DecVal(_ram[0xB5]); TotalCycles += 5; PC = 0xE690;
                    return;
                case 0xE68F:
                    A = _ram[(byte)(0xDB + X)]; SetZN(A); TotalCycles += 4; PC = 0xE691;
                    goto case 0xE691;
                case 0xE691:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE694;
                    goto case 0xE694;
                case 0xE692:
                    TotalCycles += 7; PushU16(0xE694); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE694:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE695;
                    goto case 0xE695;
                case 0xE695:
                    Adc(0x08); TotalCycles += 2; PC = 0xE697;
                    goto case 0xE697;
                case 0xE696:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE697;
                    goto case 0xE697;
                case 0xE697:
                    _ram[(0x0204 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE69A;
                    goto case 0xE69A;
                case 0xE69A:
                    A = _ram[0x03B3]; SetZN(A); TotalCycles += 4; PC = 0xE69D;
                    goto case 0xE69D;
                case 0xE69D:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE6A0;
                    goto case 0xE6A0;
                case 0xE6A0:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE6A3;
                    goto case 0xE6A3;
                case 0xE6A3:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xE6A5;
                    goto case 0xE6A5;
                case 0xE6A4:
                    A |= 0x4A; SetZN(A); TotalCycles += 2; PC = 0xE6A6;
                    goto case 0xE6A6;
                case 0xE6A5:
                    A = Lsr(A); TotalCycles += 2; PC = 0xE6A6;
                    goto case 0xE6A6;
                case 0xE6A6:
                    A &= 0x03; SetZN(A); TotalCycles += 2; PC = 0xE6A8;
                    goto case 0xE6A8;
                case 0xE6A8:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE6A9;
                    goto case 0xE6A9;
                case 0xE6A9:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6682 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE6AC;
                    goto case 0xE6AC;
                case 0xE6AB:
                    _ram[0xC8] = IncVal(_ram[0xC8]); TotalCycles += 5; PC = 0xE6AD;
                    goto case 0xE6AD;
                case 0xE6AC:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE6AD;
                    goto case 0xE6AD;
                case 0xE6AD:
                    TotalCycles += 6; PushU16(0xE6AF); PC = 0xE5C1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5C1;
                case 0xE6AE:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xE5 + X)))); TotalCycles += 6; PC = 0xE6B0;
                    goto case 0xE6B0;
                case 0xE6AF:
                    Sbc(_ram[0x88]); TotalCycles += 3; PC = 0xE6B1;
                    goto case 0xE6B1;
                case 0xE6B0:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xE6B1;
                    goto case 0xE6B1;
                case 0xE6B1:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xE6B3;
                    goto case 0xE6B3;
                case 0xE6B3:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE6B6;
                    goto case 0xE6B6;
                case 0xE6B6:
                    A = 0x82; SetZN(A); TotalCycles += 2; PC = 0xE6B8;
                    goto case 0xE6B8;
                case 0xE6B8:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE6BB;
                    goto case 0xE6BB;
                case 0xE6B9:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xE6BB;
                    goto case 0xE6BB;
                case 0xE6BB:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xE6BD;
                    goto case 0xE6BD;
                case 0xE6BC:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE6BD;
                    goto case 0xE6BD;
                case 0xE6BD:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE6BE:
                    { byte z = (byte)(0x77 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xE6C0;
                    goto case 0xE6C0;
                case 0xE6C0:
                    P |= FlagI; TotalCycles += 2; PC = 0xE6C1;
                    goto case 0xE6C1;
                case 0xE6C1:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x56D6 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xE6C4;
                    goto case 0xE6C4;
                case 0xE6C2:
                    { byte z = (byte)(0xD6 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xE6C4;
                    goto case 0xE6C4;
                case 0xE6C3:
                    { byte z = (byte)(0xD9 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xE6C5;
                    goto case 0xE6C5;
                case 0xE6C4:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x0DD9 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xE6C7;
                    goto case 0xE6C7;
                case 0xE6C5:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x0D8D + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xE6C8;
                    goto case 0xE6C8;
                case 0xE6C6:
                    WriteIoReg(0xE48D, A); TotalCycles += 4; PC = 0xE6C9;
                    goto case 0xE6C9;
                case 0xE6C7:
                    WriteIoReg(0xE4E4, A); TotalCycles += 4; PC = 0xE6CA;
                    goto case 0xE6CA;
                case 0xE6C8:
                    Cmp(X, _ram[0xE4]); TotalCycles += 3; PC = 0xE6CA;
                    goto case 0xE6CA;
                case 0xE6C9:
                    Cmp(X, _ram[0x76]); TotalCycles += 3; PC = 0xE6CB;
                    return;
                case 0xE6CA:
                    { byte z = (byte)(0x77 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xE6CC;
                    goto case 0xE6CC;
                case 0xE6CC:
                    P |= FlagI; TotalCycles += 2; PC = 0xE6CD;
                    goto case 0xE6CD;
                case 0xE6CD:
                    Adc(_ram[(0x0102 + Y) & 0x07FF]); TotalCycles += 4; PC = 0xE6D0;
                    return;
                case 0xE6CF:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE6D1;
                    goto case 0xE6D1;
                case 0xE6D1:
                    A |= ReadMem(ReadU16Zp((byte)(0xAC + X))); SetZN(A); TotalCycles += 6; PC = 0xE6D3;
                    goto case 0xE6D3;
                case 0xE6D2:
                    Y = _ram[0x06EA]; SetZN(Y); TotalCycles += 4; PC = 0xE6D5;
                    goto case 0xE6D5;
                case 0xE6D3:
                     TotalCycles += 2; PC = 0xE6D4;
                    goto case 0xE6D4;
                case 0xE6D4:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xE6D6;
                    goto case 0xE6D6;
                case 0xE6D5:
                    A = _ram[0x03B9]; SetZN(A); TotalCycles += 4; PC = 0xE6D8;
                    goto case 0xE6D8;
                case 0xE6D6:
                    A = ReadMem(0x1803 + Y); SetZN(A); TotalCycles += 4; PC = 0xE6D9;
                    goto case 0xE6D9;
                case 0xE6D8:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE6D9;
                    goto case 0xE6D9;
                case 0xE6D9:
                    Adc(0x08); TotalCycles += 2; PC = 0xE6DB;
                    goto case 0xE6DB;
                case 0xE6DA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE6DB;
                    goto case 0xE6DB;
                case 0xE6DB:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xE6DD;
                    goto case 0xE6DD;
                case 0xE6DD:
                    A = _ram[0x03AE]; SetZN(A); TotalCycles += 4; PC = 0xE6E0;
                    goto case 0xE6E0;
                case 0xE6DE:
                    X = SmbEmbeddedAssets.StaticDataTables[0x0503]; SetZN(X); TotalCycles += 4; PC = 0xE6E1;
                    goto case 0xE6E1;
                case 0xE6E0:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0xE6E2;
                    goto case 0xE6E2;
                case 0xE6E1:
                    A |= _ram[0xA6]; SetZN(A); TotalCycles += 3; PC = 0xE6E3;
                    goto case 0xE6E3;
                case 0xE6E2:
                    X = _ram[0x39]; SetZN(X); TotalCycles += 3; PC = 0xE6E4;
                    goto case 0xE6E4;
                case 0xE6E3:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x4EBD + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE6E6;
                    goto case 0xE6E6;
                case 0xE6E4:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x66CE + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE6E7;
                    goto case 0xE6E7;
                case 0xE6E5:
                    _ram[0x05E6] = DecVal(_ram[0x05E6]); TotalCycles += 6; PC = 0xE6E8;
                    goto case 0xE6E8;
                case 0xE6E6:
                    _ram[0x0D] = IncVal(_ram[0x0D]); TotalCycles += 5; PC = 0xE6E8;
                    goto case 0xE6E8;
                case 0xE6E7:
                    A |= _ram[0x03CA]; SetZN(A); TotalCycles += 4; PC = 0xE6EA;
                    goto case 0xE6EA;
                case 0xE6E8:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE6E9;
                    return;
                case 0xE6EA:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xE6EC;
                    goto case 0xE6EC;
                case 0xE6EC:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE6ED;
                    goto case 0xE6ED;
                case 0xE6ED:
                    PushU8(A); TotalCycles += 3; PC = 0xE6EE;
                    goto case 0xE6EE;
                case 0xE6EE:
                    A = Asl(A); TotalCycles += 2; PC = 0xE6EF;
                    goto case 0xE6EF;
                case 0xE6EF:
                    A = Asl(A); TotalCycles += 2; PC = 0xE6F0;
                    goto case 0xE6F0;
                case 0xE6F0:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE6F1;
                    goto case 0xE6F1;
                case 0xE6F1:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xE6F3;
                    goto case 0xE6F3;
                case 0xE6F2:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xE6F4;
                    return;
                case 0xE6F3:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0xE6F5;
                    goto case 0xE6F5;
                case 0xE6F5:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0xE6F7;
                    goto case 0xE6F7;
                case 0xE6F7:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x66BE + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE6FA;
                    goto case 0xE6FA;
                case 0xE6F8:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x05E6 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xE6FB;
                    goto case 0xE6FB;
                case 0xE6F9:
                    _ram[0x85] = IncVal(_ram[0x85]); TotalCycles += 5; PC = 0xE6FB;
                    goto case 0xE6FB;
                case 0xE6FA:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xE6FC;
                    goto case 0xE6FC;
                case 0xE6FB:
                    TotalCycles += 7; PushU16(0xE6FD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE6FC:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x66BF + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE6FF;
                    goto case 0xE6FF;
                case 0xE6FE:
                    _ram[0x20] = IncVal(_ram[0x20]); TotalCycles += 5; PC = 0xE700;
                    return;
                case 0xE6FF:
                    TotalCycles += 6; PushU16(0xE701); PC = 0xEBB2;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBB2;
                case 0xE702:
                    _ram[0x07] = DecVal(_ram[0x07]); TotalCycles += 5; PC = 0xE704;
                    goto case 0xE704;
                case 0xE704:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE6F7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE6F7; }
                    PC = 0xE706; goto case 0xE706;
                case 0xE705:
                    Sbc(ReadMem(ReadU16Zp(0xAC) + Y)); TotalCycles += 5; PC = 0xE707;
                    goto case 0xE707;
                case 0xE706:
                    Y = _ram[0x06EA]; SetZN(Y); TotalCycles += 4; PC = 0xE709;
                    goto case 0xE709;
                case 0xE707:
                     TotalCycles += 2; PC = 0xE708;
                    goto case 0xE708;
                case 0xE708:
                    _ram[0x68] = Asl(_ram[0x68]); TotalCycles += 5; PC = 0xE70A;
                    goto case 0xE70A;
                case 0xE709:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xE70A;
                    goto case 0xE70A;
                case 0xE70A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE73B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE73B; }
                    PC = 0xE70C; goto case 0xE70C;
                case 0xE70C:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xE70E;
                    goto case 0xE70E;
                case 0xE70E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE73B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE73B; }
                    PC = 0xE710; goto case 0xE710;
                case 0xE710:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xE712;
                    goto case 0xE712;
                case 0xE711:
                    TotalCycles += 7; PushU16(0xE713); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE712:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xE714;
                    goto case 0xE714;
                case 0xE713:
                    A |= 0x4A; SetZN(A); TotalCycles += 2; PC = 0xE715;
                    goto case 0xE715;
                case 0xE714:
                    A = Lsr(A); TotalCycles += 2; PC = 0xE715;
                    goto case 0xE715;
                case 0xE715:
                    A &= 0x03; SetZN(A); TotalCycles += 2; PC = 0xE717;
                    goto case 0xE717;
                case 0xE717:
                    A |= _ram[0x03CA]; SetZN(A); TotalCycles += 4; PC = 0xE71A;
                    goto case 0xE71A;
                case 0xE718:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE719;
                    return;
                case 0xE71A:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE71D;
                    goto case 0xE71D;
                case 0xE71D:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE720;
                    goto case 0xE720;
                case 0xE71E:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xE720;
                    goto case 0xE720;
                case 0xE720:
                    X = _ram[0x00]; SetZN(X); TotalCycles += 3; PC = 0xE722;
                    goto case 0xE722;
                case 0xE721:
                    TotalCycles += 7; PushU16(0xE723); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE722:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE723;
                    goto case 0xE723;
                case 0xE723:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE72B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE72B; }
                    PC = 0xE725; goto case 0xE725;
                case 0xE724:
                    _ram[0x99] = Asl(_ram[0x99]); TotalCycles += 5; PC = 0xE726;
                    goto case 0xE726;
                case 0xE725:
                    _ram[(0x020A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE728;
                    goto case 0xE728;
                case 0xE726:
                    A = Asl(A); TotalCycles += 2; PC = 0xE727;
                    return;
                case 0xE728:
                    _ram[(0x020E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE72B;
                    goto case 0xE72B;
                case 0xE729:
                    { int a = 0xB902; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xE72C;
                    goto case 0xE72C;
                case 0xE72B:
                    A = _ram[(0x0206 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE72E;
                    goto case 0xE72E;
                case 0xE72C:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xE72E;
                    goto case 0xE72E;
                case 0xE72E:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xE730;
                    goto case 0xE730;
                case 0xE72F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xE730:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE733;
                    goto case 0xE733;
                case 0xE731:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xE733;
                    goto case 0xE733;
                case 0xE733:
                    A = _ram[(0x020E + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE736;
                    goto case 0xE736;
                case 0xE734:
                    _ram[0x0102] = Asl(_ram[0x0102]); TotalCycles += 6; PC = 0xE737;
                    goto case 0xE737;
                case 0xE736:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xE738;
                    goto case 0xE738;
                case 0xE737:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xE738:
                    _ram[(0x020E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xE73B;
                    goto case 0xE73B;
                case 0xE739:
                    { int a = 0x4C02; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xE73C;
                    return;
                case 0xE73B:
                    TotalCycles += 3; PC = 0xEB64;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEB64;
                case 0xE740:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE741;
                    return;
                case 0xE742:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x7CAD]; SetZN(Y); TotalCycles += 4; PC = 0xE745;
                    return;
                case 0xE743:
                    A = SmbEmbeddedAssets.StaticDataTables[0x7CFC]; SetZN(A); TotalCycles += 4; PC = 0xE746;
                    goto case 0xE746;
                case 0xE746:
                    X = SmbEmbeddedAssets.StaticDataTables[0x30AF]; SetZN(X); TotalCycles += 4; PC = 0xE749;
                    goto case 0xE749;
                case 0xE748:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE6FB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE6FB; }
                    PC = 0xE74A; return;
                case 0xE749:
                    A = ReadMem(ReadU16Zp(0xFC) + Y); SetZN(A); TotalCycles += 5; PC = 0xE74B;
                    goto case 0xE74B;
                case 0xE74B:
                    A = _ram[0xA6]; SetZN(A); TotalCycles += 3; PC = 0xE74D;
                    return;
                case 0xE74C:
                    X = _ram[0xA7]; SetZN(X); TotalCycles += 3; PC = 0xE74E;
                    goto case 0xE74E;
                case 0xE74E:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE74F;
                    goto case 0xE74F;
                case 0xE74F:
                    A = 0xFC; SetZN(A); TotalCycles += 2; PC = 0xE751;
                    goto case 0xE751;
                case 0xE751:
                    Y = 0xA1; SetZN(Y); TotalCycles += 2; PC = 0xE753;
                    goto case 0xE753;
                case 0xE752:
                    A = ReadMem(ReadU16Zp((byte)(0xA2 + X))); SetZN(A); TotalCycles += 6; PC = 0xE754;
                    return;
                case 0xE753:
                    X = 0xA3; SetZN(X); TotalCycles += 2; PC = 0xE755;
                    goto case 0xE755;
                case 0xE755:
                    Y = _ram[0x69]; SetZN(Y); TotalCycles += 3; PC = 0xE757;
                    goto case 0xE757;
                case 0xE756:
                    Adc(0xA5); TotalCycles += 2; PC = 0xE758;
                    goto case 0xE758;
                case 0xE757:
                    A = _ram[0x6A]; SetZN(A); TotalCycles += 3; PC = 0xE759;
                    return;
                case 0xE758:
                    A = Ror(A); TotalCycles += 2; PC = 0xE759;
                    return;
                case 0xE75A:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE75B;
                    goto case 0xE75B;
                case 0xE75B:
                    A = 0x6B; SetZN(A); TotalCycles += 2; PC = 0xE75D;
                    goto case 0xE75D;
                case 0xE75D:
                    Y = 0x6C; SetZN(Y); TotalCycles += 2; PC = 0xE75F;
                    goto case 0xE75F;
                case 0xE75E:
                    TotalCycles += 5; PC = ReadU16Zp(0xA2); return;
                case 0xE75F:
                    X = 0xA3; SetZN(X); TotalCycles += 2; PC = 0xE761;
                    goto case 0xE761;
                case 0xE761:
                    Y = _ram[0xFC]; SetZN(Y); TotalCycles += 3; PC = 0xE763;
                    return;
                case 0xE764:
                    _ram[(byte)(0x97 + Y)] = X; TotalCycles += 4; PC = 0xE766;
                    goto case 0xE766;
                case 0xE766:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xE767;
                    goto case 0xE767;
                case 0xE767:
                    WriteMem(0xFCFC + Y, A); TotalCycles += 5; PC = 0xE76A;
                    goto case 0xE76A;
                case 0xE76A:
                    SP = X; TotalCycles += 2; PC = 0xE76B;
                    return;
                case 0xE76D:
                    WriteMem(0xFCFC + X, A); TotalCycles += 5; PC = 0xE770;
                    return;
                case 0xE771:
                    WriteIoReg(0x8F8E, X); TotalCycles += 4; PC = 0xE774;
                    return;
                case 0xE772:
                    WriteIoReg(0xFC8F, X); TotalCycles += 4; PC = 0xE775;
                    return;
                case 0xE776:
                    _ram[(byte)(0x94 + X)] = A; TotalCycles += 4; PC = 0xE778;
                    goto case 0xE778;
                case 0xE777:
                    _ram[(byte)(0x94 + X)] = Y; TotalCycles += 4; PC = 0xE779;
                    goto case 0xE779;
                case 0xE778:
                    _ram[(byte)(0x95 + X)] = Y; TotalCycles += 4; PC = 0xE77A;
                    return;
                case 0xE779:
                    _ram[(byte)(0xFC + X)] = A; TotalCycles += 4; PC = 0xE77B;
                    return;
                case 0xE782:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x5EDD + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE785;
                    goto case 0xE785;
                case 0xE783:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x5EDE + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE786;
                    return;
                case 0xE784:
                    { int a = 0xFCDE + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xE787;
                    return;
                case 0xE785:
                    { int a = 0xFCFC + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xE788;
                    return;
                case 0xE78A:
                    Y = _ram[(byte)(0xB5 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xE78C;
                    return;
                case 0xE78B:
                    A = _ram[(byte)(0xFC + X)]; SetZN(A); TotalCycles += 4; PC = 0xE78D;
                    return;
                case 0xE78E:
                    X = _ram[(byte)(0xB3 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xE790;
                    return;
                case 0xE791:
                    A = _ram[(byte)(0xFC + X)]; SetZN(A); TotalCycles += 4; PC = 0xE793;
                    return;
                case 0xE794:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xE807; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE807; }
                    PC = 0xE796; return;
                case 0xE795:
                    Adc(ReadMem(ReadU16Zp(0x72) + Y)); TotalCycles += 5; PC = 0xE797;
                    return;
                case 0xE79A:
                    { int a = 0x6F6E; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xE79D;
                    return;
                case 0xE79B:
                    { int a = 0x6F6F; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xE79E;
                    return;
                case 0xE7A0:
                    Adc(ReadIoReg(0x6F6D)); TotalCycles += 4; PC = 0xE7A3;
                    return;
                case 0xE7A1:
                    Adc(ReadIoReg(0x6F6F)); TotalCycles += 4; PC = 0xE7A4;
                    return;
                case 0xE7A8:
                    { int a = 0xFC6E; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xE7AB;
                    return;
                case 0xE7A9:
                    { int a = 0xFCFC; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xE7AC;
                    return;
                case 0xE7AE:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x7C6D]); TotalCycles += 4; PC = 0xE7B1;
                    return;
                case 0xE7AF:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x7CFC]); TotalCycles += 4; PC = 0xE7B2;
                    return;
                case 0xE7B4:
                    Sbc(_ram[(byte)(0xF5 + X)]); TotalCycles += 4; PC = 0xE7B6;
                    return;
                case 0xE7B5:
                    Sbc(_ram[(byte)(0xFC + X)]); TotalCycles += 4; PC = 0xE7B7;
                    return;
                case 0xE7BA:
                    Sbc(_ram[(byte)(0xF5 + X)]); TotalCycles += 4; PC = 0xE7BC;
                    return;
                case 0xE7BB:
                    Sbc(_ram[(byte)(0xFC + X)]); TotalCycles += 4; PC = 0xE7BD;
                    return;
                case 0xE7BE:
                    Sbc(_ram[(byte)(0xF5 + X)]); TotalCycles += 4; PC = 0xE7C0;
                    return;
                case 0xE7BF:
                    Sbc(_ram[(byte)(0xF4 + X)]); TotalCycles += 4; PC = 0xE7C1;
                    return;
                case 0xE7C4:
                    Sbc(_ram[(byte)(0xF5 + X)]); TotalCycles += 4; PC = 0xE7C6;
                    return;
                case 0xE7C5:
                    Sbc(_ram[(byte)(0xF4 + X)]); TotalCycles += 4; PC = 0xE7C7;
                    return;
                case 0xE7CE:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3BB8 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE7D1;
                    goto case 0xE7D1;
                case 0xE7CF:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xE7D0;
                    return;
                case 0xE7D1:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xE7D2;
                    goto case 0xE7D2;
                case 0xE7D2:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x7CBC + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xE7D5;
                    return;
                case 0xE7D3:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x7CFC + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xE7D6;
                    goto case 0xE7D6;
                case 0xE7D6:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3CBD + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE7D9;
                    goto case 0xE7D9;
                case 0xE7D7:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3CBC + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE7DA;
                    return;
                case 0xE7D8:
                    Y = ReadMem(0x7ABC + X); SetZN(Y); TotalCycles += 4; PC = 0xE7DB;
                    return;
                case 0xE7D9:
                    Y = ReadMem(0x7B7A + X); SetZN(Y); TotalCycles += 4; PC = 0xE7DC;
                    return;
                case 0xE7DE:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xE7DF;
                    goto case 0xE7DF;
                case 0xE7DF:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xE7E0;
                    goto case 0xE7E0;
                case 0xE7E0:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x4ECD]); TotalCycles += 4; PC = 0xE7E3;
                    goto case 0xE7E3;
                case 0xE7E1:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x4ECE]); TotalCycles += 4; PC = 0xE7E4;
                    return;
                case 0xE7E2:
                    { int a = 0xCFCE; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xE7E5;
                    return;
                case 0xE7E3:
                    { int a = 0xCFCF; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xE7E6;
                    goto case 0xE7E6;
                case 0xE7E6:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x517C + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE7E9;
                    goto case 0xE7E9;
                case 0xE7E8:
                    Cmp(A, ReadMem(ReadU16Zp(0x8C) + Y)); TotalCycles += 5; PC = 0xE7EA;
                    return;
                case 0xE7E9:
                    WriteIoReg(0xD2D3, Y); TotalCycles += 4; PC = 0xE7EC;
                    goto case 0xE7EC;
                case 0xE7EC:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x097C + X) & 0x7FFF]); TotalCycles += 4; PC = 0xE7EF;
                    goto case 0xE7EF;
                case 0xE7EF:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xE7F0;
                    return;
                case 0xE7F1:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE7F2;
                    goto case 0xE7F2;
                case 0xE7F2:
                    Cmp(A, _ram[(byte)(0xD4 + X)]); TotalCycles += 4; PC = 0xE7F4;
                    return;
                case 0xE7F8:
                    Cmp(A, _ram[(byte)(0xD4 + X)]); TotalCycles += 4; PC = 0xE7FA;
                    return;
                case 0xE7FD:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE7FE;
                    goto case 0xE7FE;
                case 0xE7FE:
                    Sbc(_ram[0xE5]); TotalCycles += 3; PC = 0xE800;
                    goto case 0xE800;
                case 0xE7FF:
                    Sbc(_ram[0xE6]); TotalCycles += 3; PC = 0xE801;
                    goto case 0xE801;
                case 0xE800:
                    _ram[0xE6] = IncVal(_ram[0xE6]); TotalCycles += 5; PC = 0xE802;
                    return;
                case 0xE801:
                    _ram[0xEB] = IncVal(_ram[0xEB]); TotalCycles += 5; PC = 0xE803;
                    return;
                case 0xE804:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x6DEC]); TotalCycles += 4; PC = 0xE807;
                    goto case 0xE807;
                case 0xE805:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x6DED]); TotalCycles += 4; PC = 0xE808;
                    goto case 0xE808;
                case 0xE806:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x6EED]); TotalCycles += 4; PC = 0xE809;
                    goto case 0xE809;
                case 0xE807:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x6EEE]); TotalCycles += 4; PC = 0xE80A;
                    return;
                case 0xE808:
                    { int a = 0xFCEE; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xE80B;
                    return;
                case 0xE809:
                    { int a = 0xFCFC; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xE80C;
                    goto case 0xE80C;
                case 0xE80C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE7DE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE7DE; }
                    PC = 0xE80E; return;
                case 0xE80D:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE7E6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE7E6; }
                    PC = 0xE80F; return;
                case 0xE811:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x40C1 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xE814;
                    return;
                case 0xE812:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xC0 + X)))); TotalCycles += 6; PC = 0xE814;
                    return;
                case 0xE813:
                    Cmp(Y, 0xC2); TotalCycles += 2; PC = 0xE815;
                    return;
                case 0xE816:
                    Cmp(Y, _ram[0xC3]); TotalCycles += 3; PC = 0xE818;
                    goto case 0xE818;
                case 0xE818:
                    _ram[0xC5] = DecVal(_ram[0xC5]); TotalCycles += 5; PC = 0xE81A;
                    goto case 0xE81A;
                case 0xE819:
                    Cmp(A, _ram[0xC8]); TotalCycles += 3; PC = 0xE81B;
                    return;
                case 0xE81A:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE81B;
                    return;
                case 0xE81D:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x49CA + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xE820;
                    return;
                case 0xE81E:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE81F;
                    goto case 0xE81F;
                case 0xE81F:
                    Cmp(A, 0xC2); TotalCycles += 2; PC = 0xE821;
                    return;
                case 0xE822:
                    Cmp(Y, _ram[0xC3]); TotalCycles += 3; PC = 0xE824;
                    goto case 0xE824;
                case 0xE824:
                    _ram[0xC5] = DecVal(_ram[0xC5]); TotalCycles += 5; PC = 0xE826;
                    goto case 0xE826;
                case 0xE825:
                    Cmp(A, _ram[0xCC]); TotalCycles += 3; PC = 0xE827;
                    return;
                case 0xE826:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x7CCB]); TotalCycles += 4; PC = 0xE829;
                    return;
                case 0xE82A:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xE82B;
                    return;
                case 0xE82C:
                     TotalCycles += 2; PC = 0xE82D;
                    goto case 0xE82D;
                case 0xE82D:
                    Sbc(0xF2); TotalCycles += 2; PC = 0xE82F;
                    return;
                case 0xE834:
                    Sbc(ReadMem(ReadU16Zp(0xF1) + Y)); TotalCycles += 5; PC = 0xE836;
                    goto case 0xE836;
                case 0xE835:
                    Sbc(ReadMem(ReadU16Zp(0xF1) + Y)); TotalCycles += 5; PC = 0xE837;
                    goto case 0xE837;
                case 0xE836:
                    Sbc(ReadMem(ReadU16Zp(0xF1) + Y)); TotalCycles += 5; PC = 0xE838;
                    return;
                case 0xE837:
                    Sbc(ReadMem(ReadU16Zp(0xFC) + Y)); TotalCycles += 5; PC = 0xE839;
                    return;
                case 0xE83A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE82C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE82C; }
                    PC = 0xE83C; return;
                case 0xE83B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE839; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE83D; return;
                case 0xE842:
                    TotalCycles += 7; PushU16(0xE844); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE845:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE846;
                    return;
                case 0xE848:
                     TotalCycles += 2; PC = 0xE849;
                    goto case 0xE849;
                case 0xE849:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE84A;
                    goto case 0xE84A;
                case 0xE84A:
                    PushU8(A); TotalCycles += 3; PC = 0xE84B;
                    goto case 0xE84B;
                case 0xE84B:
                    PushU8(A); TotalCycles += 3; PC = 0xE84C;
                    goto case 0xE84C;
                case 0xE84C:
                    Cmp(Y, _ram[0x00C0]); TotalCycles += 4; PC = 0xE84F;
                    goto case 0xE84F;
                case 0xE84D:
                    Cmp(Y, 0x18); TotalCycles += 2; PC = 0xE84F;
                    goto case 0xE84F;
                case 0xE84E:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE84F;
                    goto case 0xE84F;
                case 0xE84F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE850;
                    goto case 0xE850;
                case 0xE850:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE851;
                    goto case 0xE851;
                case 0xE851:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE877; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE877; }
                    PC = 0xE853; return;
                case 0xE852:
                    Bit(_ram[0xFF]); TotalCycles += 3; PC = 0xE854;
                    goto case 0xE854;
                case 0xE854:
                    PushU8(A); TotalCycles += 3; PC = 0xE855;
                    return;
                case 0xE857:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xE858;
                    goto case 0xE858;
                case 0xE858:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE850; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE850; }
                    PC = 0xE85A; return;
                case 0xE859:
                    { byte z = (byte)(0xFC + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xE85B;
                    goto case 0xE85B;
                case 0xE85B:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE85D;
                    return;
                case 0xE85F:
                    A |= ReadMem(ReadU16Zp((byte)(0x01 + X))); SetZN(A); TotalCycles += 6; PC = 0xE861;
                    return;
                case 0xE860:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0xE862;
                    return;
                case 0xE864:
                    A |= ReadMem(ReadU16Zp((byte)(0x01 + X))); SetZN(A); TotalCycles += 6; PC = 0xE866;
                    return;
                case 0xE865:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE867;
                    return;
                case 0xE868:
                    A &= ReadMem(ReadU16Zp((byte)(0x01 + X))); SetZN(A); TotalCycles += 6; PC = 0xE86A;
                    return;
                case 0xE869:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE86B;
                    goto case 0xE86B;
                case 0xE86B:
                    A |= ReadMem(ReadU16Zp((byte)(0x01 + X))); SetZN(A); TotalCycles += 6; PC = 0xE86D;
                    return;
                case 0xE86C:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE86E;
                    return;
                case 0xE871:
                    A |= ReadMem(ReadU16Zp((byte)(0x01 + X))); SetZN(A); TotalCycles += 6; PC = 0xE873;
                    return;
                case 0xE872:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xE874;
                    return;
                case 0xE876:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE877;
                    goto case 0xE877;
                case 0xE877:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE878;
                    goto case 0xE878;
                case 0xE878:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE879;
                    goto case 0xE879;
                case 0xE879:
                    A |= ReadMem(0x191A + Y); SetZN(A); TotalCycles += 4; PC = 0xE87C;
                    goto case 0xE87C;
                case 0xE87B:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x3518 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE87E;
                    return;
                case 0xE87C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE87D;
                    goto case 0xE87D;
                case 0xE87D: // === SUBROUTINE: Sub_E87D ===
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xE87F;
                    goto case 0xE87F;
                case 0xE87F:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xE881;
                    goto case 0xE881;
                case 0xE881:
                    A = _ram[0x03AE]; SetZN(A); TotalCycles += 4; PC = 0xE884;
                    goto case 0xE884;
                case 0xE882:
                    X = SmbEmbeddedAssets.StaticDataTables[0x0503]; SetZN(X); TotalCycles += 4; PC = 0xE885;
                    goto case 0xE885;
                case 0xE884:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0xE886;
                    goto case 0xE886;
                case 0xE885:
                    A |= _ram[0xBC]; SetZN(A); TotalCycles += 3; PC = 0xE887;
                    goto case 0xE887;
                case 0xE886:
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE889;
                    goto case 0xE889;
                case 0xE887:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xE889;
                    goto case 0xE889;
                case 0xE888:
                    _ram[0x84] = Asl(_ram[0x84]); TotalCycles += 5; PC = 0xE88A;
                    return;
                case 0xE889:
                    _ram[0xEB] = Y; TotalCycles += 3; PC = 0xE88B;
                    goto case 0xE88B;
                case 0xE88B:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xE88D;
                    goto case 0xE88D;
                case 0xE88C:
                    TotalCycles += 7; PushU16(0xE88E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE88D:
                    _ram[0x0109] = A; TotalCycles += 4; PC = 0xE890;
                    goto case 0xE890;
                case 0xE88E:
                    A |= 0x01; SetZN(A); TotalCycles += 2; PC = 0xE890;
                    goto case 0xE890;
                case 0xE88F:
                    A |= ReadMem(ReadU16Zp((byte)(0xB5 + X))); SetZN(A); TotalCycles += 6; PC = 0xE891;
                    goto case 0xE891;
                case 0xE890:
                    A = _ram[(byte)(0x46 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE892;
                    goto case 0xE892;
                case 0xE891:
                    _ram[0x85] = Lsr(_ram[0x85]); TotalCycles += 5; PC = 0xE893;
                    return;
                case 0xE892:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0xE894;
                    goto case 0xE894;
                case 0xE894:
                    A = _ram[(0x03C5 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE897;
                    goto case 0xE897;
                case 0xE895:
                    Cmp(A, _ram[0x03]); TotalCycles += 3; PC = 0xE897;
                    goto case 0xE897;
                case 0xE897:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xE899;
                    goto case 0xE899;
                case 0xE899:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE89B;
                    goto case 0xE89B;
                case 0xE89A:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE89C;
                    goto case 0xE89C;
                case 0xE89B:
                    Cmp(A, 0x0D); TotalCycles += 2; PC = 0xE89D;
                    goto case 0xE89D;
                case 0xE89C:
                    A |= _ram[0x02D0]; SetZN(A); TotalCycles += 4; PC = 0xE89F;
                    goto case 0xE89F;
                case 0xE89D:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE8A9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8A9; }
                    PC = 0xE89F; goto case 0xE89F;
                case 0xE89E:
                    A = Asl(A); TotalCycles += 2; PC = 0xE89F;
                    goto case 0xE89F;
                case 0xE89F:
                    Y = _ram[(byte)(0x58 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xE8A1;
                    goto case 0xE8A1;
                case 0xE8A0:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xE8A1;
                    goto case 0xE8A1;
                case 0xE8A1:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE8A9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8A9; }
                    PC = 0xE8A3; goto case 0xE8A3;
                case 0xE8A2:
                    _ram[0xBC] = Asl(_ram[0xBC]); TotalCycles += 5; PC = 0xE8A4;
                    goto case 0xE8A4;
                case 0xE8A3:
                    Y = _ram[(0x078A + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE8A6;
                    goto case 0xE8A6;
                case 0xE8A4:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE8A5;
                    return;
                case 0xE8A6:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE8A9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8A9; }
                    PC = 0xE8A8; goto case 0xE8A8;
                case 0xE8A7:
                    A |= ReadMem(ReadU16Zp((byte)(0x60 + X))); SetZN(A); TotalCycles += 6; PC = 0xE8A9;
                    goto case 0xE8A9;
                case 0xE8A8:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xE8A9:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE8AB;
                    goto case 0xE8AB;
                case 0xE8AA:
                    { int a = 0xED85 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE8AD;
                    goto case 0xE8AD;
                case 0xE8AB:
                    _ram[0xED] = A; TotalCycles += 3; PC = 0xE8AD;
                    goto case 0xE8AD;
                case 0xE8AC:
                    Sbc(_ram[0x0729]); TotalCycles += 4; PC = 0xE8AF;
                    goto case 0xE8AF;
                case 0xE8AD:
                    A &= 0x1F; SetZN(A); TotalCycles += 2; PC = 0xE8AF;
                    goto case 0xE8AF;
                case 0xE8AF:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xE8B0;
                    goto case 0xE8B0;
                case 0xE8B0:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE8B2;
                    goto case 0xE8B2;
                case 0xE8B1:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE8B3;
                    goto case 0xE8B3;
                case 0xE8B2:
                    Cmp(A, 0x35); TotalCycles += 2; PC = 0xE8B4;
                    goto case 0xE8B4;
                case 0xE8B3:
                    A &= _ram[(byte)(0xD0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE8B5;
                    goto case 0xE8B5;
                case 0xE8B4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE8BE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8BE; }
                    PC = 0xE8B6; goto case 0xE8B6;
                case 0xE8B5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE8B6;
                    goto case 0xE8B6;
                case 0xE8B6:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xE8B8;
                    goto case 0xE8B8;
                case 0xE8B7:
                    TotalCycles += 7; PushU16(0xE8B9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE8B8:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xE8BA;
                    goto case 0xE8BA;
                case 0xE8B9:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xE8BB;
                    return;
                case 0xE8BA:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0xE8BC;
                    goto case 0xE8BC;
                case 0xE8BC:
                    A = 0x15; SetZN(A); TotalCycles += 2; PC = 0xE8BE;
                    goto case 0xE8BE;
                case 0xE8BD:
                    A |= _ram[(byte)(0xC9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE8BF;
                    return;
                case 0xE8BE:
                    Cmp(A, 0x33); TotalCycles += 2; PC = 0xE8C0;
                    goto case 0xE8C0;
                case 0xE8C0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE8D5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8D5; }
                    PC = 0xE8C2; goto case 0xE8C2;
                case 0xE8C2:
                    _ram[0x02] = DecVal(_ram[0x02]); TotalCycles += 5; PC = 0xE8C4;
                    goto case 0xE8C4;
                case 0xE8C4:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xE8C6;
                    goto case 0xE8C6;
                case 0xE8C6:
                    Y = _ram[(0x078A + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xE8C9;
                    goto case 0xE8C9;
                case 0xE8C7:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE8C8;
                    return;
                case 0xE8C9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE8CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8CD; }
                    PC = 0xE8CB; goto case 0xE8CB;
                case 0xE8CB:
                    A |= 0x20; SetZN(A); TotalCycles += 2; PC = 0xE8CD;
                    goto case 0xE8CD;
                case 0xE8CC:
                    TotalCycles += 6; PushU16(0xE8CE); PC = 0x0485;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE8CD:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xE8CF;
                    goto case 0xE8CF;
                case 0xE8CF:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xE8D1;
                    goto case 0xE8D1;
                case 0xE8D0:
                    TotalCycles += 7; PushU16(0xE8D2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xE8D1:
                    _ram[0xED] = Y; TotalCycles += 3; PC = 0xE8D3;
                    goto case 0xE8D3;
                case 0xE8D2:
                    Sbc(_ram[0x00A9]); TotalCycles += 4; PC = 0xE8D5;
                    goto case 0xE8D5;
                case 0xE8D3:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xE8D5;
                    goto case 0xE8D5;
                case 0xE8D4:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE8D5;
                    goto case 0xE8D5;
                case 0xE8D5:
                    Cmp(A, 0x32); TotalCycles += 2; PC = 0xE8D7;
                    goto case 0xE8D7;
                case 0xE8D7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE8E1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8E1; }
                    PC = 0xE8D9; goto case 0xE8D9;
                case 0xE8D8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE8D9;
                    goto case 0xE8D9;
                case 0xE8D9:
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0xE8DB;
                    goto case 0xE8DB;
                case 0xE8DB:
                    X = _ram[0x070E]; SetZN(X); TotalCycles += 4; PC = 0xE8DE;
                    goto case 0xE8DE;
                case 0xE8DC:
                    { int a = 0xBD07; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xE8DF;
                    goto case 0xE8DF;
                case 0xE8DE:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6878 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE8E1;
                    goto case 0xE8E1;
                case 0xE8DF:
                    P |= FlagI; TotalCycles += 2; PC = 0xE8E0;
                    goto case 0xE8E0;
                case 0xE8E0:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xE8E1;
                    goto case 0xE8E1;
                case 0xE8E1:
                    _ram[0xEF] = A; TotalCycles += 3; PC = 0xE8E3;
                    goto case 0xE8E3;
                case 0xE8E3:
                    _ram[0xEC] = Y; TotalCycles += 3; PC = 0xE8E5;
                    goto case 0xE8E5;
                case 0xE8E4:
                    Cmp(X, _ram[0x00A6]); TotalCycles += 4; PC = 0xE8E7;
                    goto case 0xE8E7;
                case 0xE8E5:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xE8E7;
                    goto case 0xE8E7;
                case 0xE8E6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE8E7;
                    goto case 0xE8E7;
                case 0xE8E7:
                    Cmp(A, 0x0C); TotalCycles += 2; PC = 0xE8E9;
                    goto case 0xE8E9;
                case 0xE8E9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE8F2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8F2; }
                    PC = 0xE8EB; goto case 0xE8EB;
                case 0xE8EB:
                    A = _ram[(byte)(0xA0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xE8ED;
                    goto case 0xE8ED;
                case 0xE8EC:
                    Y = 0x30; SetZN(Y); TotalCycles += 2; PC = 0xE8EE;
                    return;
                case 0xE8ED:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE8F2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8F2; }
                    PC = 0xE8EF; goto case 0xE8EF;
                case 0xE8EF:
                    _ram[0x0109] = IncVal(_ram[0x0109]); TotalCycles += 6; PC = 0xE8F2;
                    goto case 0xE8F2;
                case 0xE8F0:
                    A |= 0x01; SetZN(A); TotalCycles += 2; PC = 0xE8F2;
                    goto case 0xE8F2;
                case 0xE8F1:
                    A |= ReadMem(ReadU16Zp((byte)(0xAD + X))); SetZN(A); TotalCycles += 6; PC = 0xE8F3;
                    goto case 0xE8F3;
                case 0xE8F2:
                    A = _ram[0x036A]; SetZN(A); TotalCycles += 4; PC = 0xE8F5;
                    goto case 0xE8F5;
                case 0xE8F3:
                    A = Ror(A); TotalCycles += 2; PC = 0xE8F4;
                    return;
                case 0xE8F5:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE900; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE900; }
                    PC = 0xE8F7; goto case 0xE8F7;
                case 0xE8F6:
                    A |= 0xA0; SetZN(A); TotalCycles += 2; PC = 0xE8F8;
                    goto case 0xE8F8;
                case 0xE8F7:
                    Y = 0x16; SetZN(Y); TotalCycles += 2; PC = 0xE8F9;
                    goto case 0xE8F9;
                case 0xE8F8:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xE8FA;
                    goto case 0xE8FA;
                case 0xE8F9:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xE8FB;
                    goto case 0xE8FB;
                case 0xE8FA:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0xE8FC;
                    goto case 0xE8FC;
                case 0xE8FB:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE8FE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8FE; }
                    PC = 0xE8FD; goto case 0xE8FD;
                case 0xE8FC:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xE8FE;
                    goto case 0xE8FE;
                case 0xE8FD:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xE8FE;
                    goto case 0xE8FE;
                case 0xE8FE:
                    _ram[0xEF] = Y; TotalCycles += 3; PC = 0xE900;
                    goto case 0xE900;
                case 0xE900:
                    Y = _ram[0xEF]; SetZN(Y); TotalCycles += 3; PC = 0xE902;
                    goto case 0xE902;
                case 0xE902:
                    Cmp(Y, 0x06); TotalCycles += 2; PC = 0xE904;
                    goto case 0xE904;
                case 0xE903:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xE905;
                    goto case 0xE905;
                case 0xE904:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE923; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE923; }
                    PC = 0xE906; goto case 0xE906;
                case 0xE905:
                    A |= ReadMem(0x1EB5 + X); SetZN(A); TotalCycles += 4; PC = 0xE908;
                    goto case 0xE908;
                case 0xE906:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xE908;
                    goto case 0xE908;
                case 0xE907:
                    { int a = (0x02C9 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xE90A;
                    goto case 0xE90A;
                case 0xE908:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xE90A;
                    goto case 0xE90A;
                case 0xE90A:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE910; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE910; }
                    PC = 0xE90C; goto case 0xE90C;
                case 0xE90C:
                    X = 0x04; SetZN(X); TotalCycles += 2; PC = 0xE90E;
                    goto case 0xE90E;
                case 0xE90E:
                    _ram[0xEC] = X; TotalCycles += 3; PC = 0xE910;
                    goto case 0xE910;
                case 0xE90F:
                    Cmp(X, ReadIoReg(0x2029)); TotalCycles += 4; PC = 0xE912;
                    goto case 0xE912;
                case 0xE910:
                    A &= 0x20; SetZN(A); TotalCycles += 2; PC = 0xE912;
                    goto case 0xE912;
                case 0xE911:
                    TotalCycles += 6; PushU16(0xE913); PC = 0x470D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE912:
                    A |= _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xE915;
                    goto case 0xE915;
                case 0xE915:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE923; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE923; }
                    PC = 0xE917; goto case 0xE917;
                case 0xE917:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xE919;
                    goto case 0xE919;
                case 0xE918:
                    A |= 0x29; SetZN(A); TotalCycles += 2; PC = 0xE91A;
                    goto case 0xE91A;
                case 0xE919:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xE91B;
                    goto case 0xE91B;
                case 0xE91A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE91B;
                    goto case 0xE91B;
                case 0xE91B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE923; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE923; }
                    PC = 0xE91D; goto case 0xE91D;
                case 0xE91C:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xE91E;
                    return;
                case 0xE91D:
                    A = _ram[0x03]; SetZN(A); TotalCycles += 3; PC = 0xE91F;
                    goto case 0xE91F;
                case 0xE91F:
                    A ^= 0x03; SetZN(A); TotalCycles += 2; PC = 0xE921;
                    goto case 0xE921;
                case 0xE921:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0xE923;
                    goto case 0xE923;
                case 0xE923:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x685B + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE926;
                    goto case 0xE926;
                case 0xE925:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xE926;
                    goto case 0xE926;
                case 0xE926:
                    A |= _ram[0x04]; SetZN(A); TotalCycles += 3; PC = 0xE928;
                    goto case 0xE928;
                case 0xE928:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xE92A;
                    goto case 0xE92A;
                case 0xE92A:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6840 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE92D;
                    goto case 0xE92D;
                case 0xE92B:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xE92C:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xE92D;
                    goto case 0xE92D;
                case 0xE92D:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xE92E;
                    goto case 0xE92E;
                case 0xE92E:
                    Y = _ram[0xEC]; SetZN(Y); TotalCycles += 3; PC = 0xE930;
                    goto case 0xE930;
                case 0xE92F:
                    Cmp(X, ReadIoReg(0x6AAD)); TotalCycles += 4; PC = 0xE932;
                    return;
                case 0xE930:
                    A = _ram[0x036A]; SetZN(A); TotalCycles += 4; PC = 0xE933;
                    goto case 0xE933;
                case 0xE931:
                    A = Ror(A); TotalCycles += 2; PC = 0xE932;
                    return;
                case 0xE933:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE965; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE965; }
                    PC = 0xE935; goto case 0xE935;
                case 0xE934:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE8FF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE936; goto case 0xE936;
                case 0xE935:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xE937;
                    goto case 0xE937;
                case 0xE936:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0xE938;
                    return;
                case 0xE937:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE94C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE94C; }
                    PC = 0xE939; goto case 0xE939;
                case 0xE939:
                    A = _ram[0x0363]; SetZN(A); TotalCycles += 4; PC = 0xE93C;
                    goto case 0xE93C;
                case 0xE93C:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE940; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE940; }
                    PC = 0xE93E; goto case 0xE93E;
                case 0xE93E: // === SUBROUTINE: DrawBlockObjRow ===
                    X = 0xDE; SetZN(X); TotalCycles += 2; PC = 0xE940;
                    goto case 0xE940;
                case 0xE93F:
                    { int a = 0xEDA5 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xE942;
                    goto case 0xE942;
                case 0xE940:
                    A = _ram[0xED]; SetZN(A); TotalCycles += 3; PC = 0xE942;
                    goto case 0xE942;
                case 0xE941:
                    Sbc(ReadIoReg(0x2029)); TotalCycles += 4; PC = 0xE944;
                    goto case 0xE944;
                case 0xE942:
                    A &= 0x20; SetZN(A); TotalCycles += 2; PC = 0xE944;
                    goto case 0xE944;
                case 0xE943:
                    TotalCycles += 6; PushU16(0xE945); PC = 0x03F0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE944:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE949; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE949; }
                    PC = 0xE946; goto case 0xE946;
                case 0xE946:
                    _ram[0x0109] = X; TotalCycles += 4; PC = 0xE949;
                    goto case 0xE949;
                case 0xE947:
                    A |= 0x01; SetZN(A); TotalCycles += 2; PC = 0xE949;
                    goto case 0xE949;
                case 0xE948:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xE94A;
                    return;
                case 0xE949:
                    TotalCycles += 3; PC = 0xEA4B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEA4B;
                case 0xE94B:
                     TotalCycles += 2; PC = 0xE94C;
                    goto case 0xE94C;
                case 0xE94C:
                    A = _ram[0x0363]; SetZN(A); TotalCycles += 4; PC = 0xE94F;
                    goto case 0xE94F;
                case 0xE94F:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0xE951;
                    goto case 0xE951;
                case 0xE950:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0xE952;
                    return;
                case 0xE951:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE955; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE955; }
                    PC = 0xE953; goto case 0xE953;
                case 0xE953:
                    X = 0xE4; SetZN(X); TotalCycles += 2; PC = 0xE955;
                    goto case 0xE955;
                case 0xE954:
                    Cmp(X, _ram[0xA5]); TotalCycles += 3; PC = 0xE956;
                    goto case 0xE956;
                case 0xE955:
                    A = _ram[0xED]; SetZN(A); TotalCycles += 3; PC = 0xE957;
                    goto case 0xE957;
                case 0xE956:
                    Sbc(ReadIoReg(0x2029)); TotalCycles += 4; PC = 0xE959;
                    goto case 0xE959;
                case 0xE957:
                    A &= 0x20; SetZN(A); TotalCycles += 2; PC = 0xE959;
                    goto case 0xE959;
                case 0xE958:
                    TotalCycles += 6; PushU16(0xE95A); PC = 0xEEF0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEEF0;
                case 0xE959:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE949; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE949; }
                    PC = 0xE95B; goto case 0xE95B;
                case 0xE95A:
                    _ram[0x02A5] = IncVal(_ram[0x02A5]); TotalCycles += 6; PC = 0xE95D;
                    goto case 0xE95D;
                case 0xE95B:
                    A = _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xE95D;
                    goto case 0xE95D;
                case 0xE95D:
                    P |= FlagC; TotalCycles += 2; PC = 0xE95E;
                    goto case 0xE95E;
                case 0xE95E:
                    Sbc(0x10); TotalCycles += 2; PC = 0xE960;
                    goto case 0xE960;
                case 0xE95F:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE8E6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE8E6; }
                    PC = 0xE961; return;
                case 0xE960:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xE962;
                    goto case 0xE962;
                case 0xE962:
                    TotalCycles += 3; PC = 0xE946;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE946;
                case 0xE963:
                    _ram[0xE9] = Lsr(_ram[0xE9]); TotalCycles += 5; PC = 0xE965;
                    goto case 0xE965;
                case 0xE964:
                    Sbc(0xE0); TotalCycles += 2; PC = 0xE966;
                    goto case 0xE966;
                case 0xE965:
                    Cmp(X, 0x24); TotalCycles += 2; PC = 0xE967;
                    goto case 0xE967;
                case 0xE966:
                    Bit(_ram[0xD0]); TotalCycles += 3; PC = 0xE968;
                    goto case 0xE968;
                case 0xE967:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE97A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE97A; }
                    PC = 0xE969; goto case 0xE969;
                case 0xE968:
                    A |= ReadMem(ReadU16Zp(0xC0) + Y); SetZN(A); TotalCycles += 5; PC = 0xE96A;
                    goto case 0xE96A;
                case 0xE969:
                    Cmp(Y, 0x05); TotalCycles += 2; PC = 0xE96B;
                    goto case 0xE96B;
                case 0xE96A:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xE96C;
                    goto case 0xE96C;
                case 0xE96B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE977; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE977; }
                    PC = 0xE96D; goto case 0xE96D;
                case 0xE96C:
                    A = Asl(A); TotalCycles += 2; PC = 0xE96D;
                    goto case 0xE96D;
                case 0xE96D:
                    X = 0x30; SetZN(X); TotalCycles += 2; PC = 0xE96F;
                    goto case 0xE96F;
                case 0xE96E:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xE919; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE919; }
                    PC = 0xE970; return;
                case 0xE96F:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xE971;
                    goto case 0xE971;
                case 0xE971:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0xE973;
                    goto case 0xE973;
                case 0xE973:
                    A = 0x05; SetZN(A); TotalCycles += 2; PC = 0xE975;
                    goto case 0xE975;
                case 0xE974:
                    A |= _ram[0x85]; SetZN(A); TotalCycles += 3; PC = 0xE976;
                    goto case 0xE976;
                case 0xE975:
                    _ram[0xEC] = A; TotalCycles += 3; PC = 0xE977;
                    goto case 0xE977;
                case 0xE976:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x4A4C]); TotalCycles += 4; PC = 0xE979;
                    goto case 0xE979;
                case 0xE977:
                    TotalCycles += 3; PC = 0xE9CA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE9CA;
                case 0xE978:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xE979;
                    goto case 0xE979;
                case 0xE979:
                    Sbc(0xE0); TotalCycles += 2; PC = 0xE97B;
                    goto case 0xE97B;
                case 0xE97A:
                    Cmp(X, 0x90); TotalCycles += 2; PC = 0xE97C;
                    goto case 0xE97C;
                case 0xE97B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE94D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE97D; return;
                case 0xE97C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE990; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE990; }
                    PC = 0xE97E; goto case 0xE97E;
                case 0xE97E:
                    A = _ram[0xED]; SetZN(A); TotalCycles += 3; PC = 0xE980;
                    goto case 0xE980;
                case 0xE97F:
                    Sbc(ReadIoReg(0x2029)); TotalCycles += 4; PC = 0xE982;
                    goto case 0xE982;
                case 0xE980:
                    A &= 0x20; SetZN(A); TotalCycles += 2; PC = 0xE982;
                    goto case 0xE982;
                case 0xE981:
                    TotalCycles += 6; PushU16(0xE983); PC = 0x09D0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE982:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE98D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE98D; }
                    PC = 0xE984; goto case 0xE984;
                case 0xE983:
                    A |= 0xAD; SetZN(A); TotalCycles += 2; PC = 0xE985;
                    return;
                case 0xE984:
                    A = _ram[0x078F]; SetZN(A); TotalCycles += 4; PC = 0xE987;
                    goto case 0xE987;
                case 0xE987:
                    Cmp(A, 0x10); TotalCycles += 2; PC = 0xE989;
                    goto case 0xE989;
                case 0xE988:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE93A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xE98A; return;
                case 0xE989:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE98D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE98D; }
                    PC = 0xE98B; goto case 0xE98B;
                case 0xE98B:
                    X = 0x96; SetZN(X); TotalCycles += 2; PC = 0xE98D;
                    goto case 0xE98D;
                case 0xE98C:
                    _ram[(byte)(0x4C + Y)] = X; TotalCycles += 4; PC = 0xE98E;
                    return;
                case 0xE98D:
                    TotalCycles += 3; PC = 0xEA37;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEA37;
                case 0xE98F:
                     TotalCycles += 2; PC = 0xE990;
                    goto case 0xE990;
                case 0xE990:
                    A = _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xE992;
                    goto case 0xE992;
                case 0xE992:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0xE994;
                    goto case 0xE994;
                case 0xE994:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xE9A6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9A6; }
                    PC = 0xE996; goto case 0xE996;
                case 0xE995:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE957; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE957; }
                    PC = 0xE997; return;
                case 0xE996:
                    Cmp(Y, 0x02); TotalCycles += 2; PC = 0xE998;
                    goto case 0xE998;
                case 0xE998:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xE9A6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9A6; }
                    PC = 0xE99A; goto case 0xE99A;
                case 0xE99A:
                    X = 0x5A; SetZN(X); TotalCycles += 2; PC = 0xE99C;
                    goto case 0xE99C;
                case 0xE99C:
                    Y = _ram[0xEF]; SetZN(Y); TotalCycles += 3; PC = 0xE99E;
                    goto case 0xE99E;
                case 0xE99E:
                    Cmp(Y, 0x02); TotalCycles += 2; PC = 0xE9A0;
                    goto case 0xE9A0;
                case 0xE9A0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE9A6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9A6; }
                    PC = 0xE9A2; goto case 0xE9A2;
                case 0xE9A2:
                    X = 0x7E; SetZN(X); TotalCycles += 2; PC = 0xE9A4;
                    goto case 0xE9A4;
                case 0xE9A3:
                    { int a = (0x02E6 + X) & 0x07FF; _ram[a] = Ror(_ram[a]); } TotalCycles += 7; PC = 0xE9A6;
                    goto case 0xE9A6;
                case 0xE9A4:
                    _ram[0x02] = IncVal(_ram[0x02]); TotalCycles += 5; PC = 0xE9A6;
                    goto case 0xE9A6;
                case 0xE9A6:
                    A = _ram[0xEC]; SetZN(A); TotalCycles += 3; PC = 0xE9A8;
                    goto case 0xE9A8;
                case 0xE9A7:
                    Cmp(X, _ram[0x04C9]); TotalCycles += 4; PC = 0xE9AA;
                    goto case 0xE9AA;
                case 0xE9A8:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0xE9AA;
                    goto case 0xE9AA;
                case 0xE9AA:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE9CA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9CA; }
                    PC = 0xE9AC; goto case 0xE9AC;
                case 0xE9AB:
                    { int a = 0x72A2 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xE9AE;
                    goto case 0xE9AE;
                case 0xE9AC:
                    X = 0x72; SetZN(X); TotalCycles += 2; PC = 0xE9AE;
                    goto case 0xE9AE;
                case 0xE9AE:
                    _ram[0x02] = IncVal(_ram[0x02]); TotalCycles += 5; PC = 0xE9B0;
                    goto case 0xE9B0;
                case 0xE9B0: // === SUBROUTINE: Sub_E9B0 ===
                    Y = _ram[0xEF]; SetZN(Y); TotalCycles += 3; PC = 0xE9B2;
                    goto case 0xE9B2;
                case 0xE9B2:
                    Cmp(Y, 0x02); TotalCycles += 2; PC = 0xE9B4;
                    goto case 0xE9B4;
                case 0xE9B4:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE9BA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9BA; }
                    PC = 0xE9B6; goto case 0xE9B6;
                case 0xE9B6:
                    X = 0x66; SetZN(X); TotalCycles += 2; PC = 0xE9B8;
                    goto case 0xE9B8;
                case 0xE9B7:
                    _ram[0xE6] = Ror(_ram[0xE6]); TotalCycles += 5; PC = 0xE9B9;
                    return;
                case 0xE9B8:
                    _ram[0x02] = IncVal(_ram[0x02]); TotalCycles += 5; PC = 0xE9BA;
                    goto case 0xE9BA;
                case 0xE9BA:
                    Cmp(Y, 0x06); TotalCycles += 2; PC = 0xE9BC;
                    goto case 0xE9BC;
                case 0xE9BB:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xE9BD;
                    return;
                case 0xE9BC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE9CA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9CA; }
                    PC = 0xE9BE; goto case 0xE9BE;
                case 0xE9BE:
                    X = 0x54; SetZN(X); TotalCycles += 2; PC = 0xE9C0;
                    goto case 0xE9C0;
                case 0xE9C0:
                    A = _ram[0xED]; SetZN(A); TotalCycles += 3; PC = 0xE9C2;
                    goto case 0xE9C2;
                case 0xE9C1:
                    Sbc(ReadIoReg(0x2029)); TotalCycles += 4; PC = 0xE9C4;
                    goto case 0xE9C4;
                case 0xE9C2:
                    A &= 0x20; SetZN(A); TotalCycles += 2; PC = 0xE9C4;
                    goto case 0xE9C4;
                case 0xE9C3:
                    TotalCycles += 6; PushU16(0xE9C5); PC = 0x04D0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xE9C4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE9CA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9CA; }
                    PC = 0xE9C6; goto case 0xE9C6;
                case 0xE9C6:
                    X = 0x8A; SetZN(X); TotalCycles += 2; PC = 0xE9C8;
                    goto case 0xE9C8;
                case 0xE9C7:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xE9C8;
                    goto case 0xE9C8;
                case 0xE9C8:
                    _ram[0x02] = DecVal(_ram[0x02]); TotalCycles += 5; PC = 0xE9CA;
                    goto case 0xE9CA;
                case 0xE9CA:
                    Y = _ram[0x08]; SetZN(Y); TotalCycles += 3; PC = 0xE9CC;
                    goto case 0xE9CC;
                case 0xE9CB:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE9CC;
                    goto case 0xE9CC;
                case 0xE9CC:
                    A = _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xE9CE;
                    goto case 0xE9CE;
                case 0xE9CE:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xE9D0;
                    goto case 0xE9D0;
                case 0xE9CF:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xE9D1;
                    return;
                case 0xE9D0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE9DE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9DE; }
                    PC = 0xE9D2; goto case 0xE9D2;
                case 0xE9D2:
                    A = _ram[0xED]; SetZN(A); TotalCycles += 3; PC = 0xE9D4;
                    goto case 0xE9D4;
                case 0xE9D3:
                    Sbc(ReadIoReg(0x24F0)); TotalCycles += 4; PC = 0xE9D6;
                    goto case 0xE9D6;
                case 0xE9D4:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE9FA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9FA; }
                    PC = 0xE9D6; goto case 0xE9D6;
                case 0xE9D5:
                    Bit(_ram[0x29]); TotalCycles += 3; PC = 0xE9D7;
                    goto case 0xE9D7;
                case 0xE9D6:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xE9D8;
                    goto case 0xE9D8;
                case 0xE9D7:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xE9D8;
                    goto case 0xE9D8;
                case 0xE9D8:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xE9DA; goto case 0xE9DA;
                case 0xE9D9:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x34A2 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xE9DC;
                    goto case 0xE9DC;
                case 0xE9DA:
                    X = 0xB4; SetZN(X); TotalCycles += 2; PC = 0xE9DC;
                    goto case 0xE9DC;
                case 0xE9DB:
                    Y = _ram[(byte)(0xD0 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xE9DD;
                    return;
                case 0xE9DC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE9FA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9FA; }
                    PC = 0xE9DE; goto case 0xE9DE;
                case 0xE9DE:
                    Cmp(X, 0x48); TotalCycles += 2; PC = 0xE9E0;
                    goto case 0xE9E0;
                case 0xE9DF:
                    PushU8(A); TotalCycles += 3; PC = 0xE9E0;
                    goto case 0xE9E0;
                case 0xE9E0:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xE9FA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9FA; }
                    PC = 0xE9E2; goto case 0xE9E2;
                case 0xE9E1:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xE9E2;
                    goto case 0xE9E2;
                case 0xE9E2:
                    A = _ram[(0x0796 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xE9E5;
                    goto case 0xE9E5;
                case 0xE9E3:
                    _ram[(byte)(0x07 + Y)] = X; TotalCycles += 4; PC = 0xE9E5;
                    goto case 0xE9E5;
                case 0xE9E5:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xE9E7;
                    goto case 0xE9E7;
                case 0xE9E6:
                    A |= _ram[0xB0]; SetZN(A); TotalCycles += 3; PC = 0xE9E8;
                    goto case 0xE9E8;
                case 0xE9E7:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xE9E9; goto case 0xE9E9;
                case 0xE9E8:
                    { int a = 0x3CE0; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xE9EB;
                    goto case 0xE9EB;
                case 0xE9E9:
                    Cmp(X, 0x3C); TotalCycles += 2; PC = 0xE9EB;
                    goto case 0xE9EB;
                case 0xE9EB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xE9FA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9FA; }
                    PC = 0xE9ED; goto case 0xE9ED;
                case 0xE9EC:
                    A |= _ram[0x01C9]; SetZN(A); TotalCycles += 4; PC = 0xE9EF;
                    goto case 0xE9EF;
                case 0xE9ED:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xE9EF;
                    goto case 0xE9EF;
                case 0xE9EE:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0xE9F0;
                    goto case 0xE9F0;
                case 0xE9EF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xE9F1; goto case 0xE9F1;
                case 0xE9F0:
                    _ram[0xE6] = Lsr(_ram[0xE6]); TotalCycles += 5; PC = 0xE9F2;
                    return;
                case 0xE9F1:
                    _ram[0x02] = IncVal(_ram[0x02]); TotalCycles += 5; PC = 0xE9F3;
                    goto case 0xE9F3;
                case 0xE9F3:
                    _ram[0x02] = IncVal(_ram[0x02]); TotalCycles += 5; PC = 0xE9F5;
                    goto case 0xE9F5;
                case 0xE9F5:
                    _ram[0x02] = IncVal(_ram[0x02]); TotalCycles += 5; PC = 0xE9F7;
                    goto case 0xE9F7;
                case 0xE9F7:
                    TotalCycles += 3; PC = 0xEA29;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEA29;
                case 0xE9F8:
                    A &= 0xEA; SetZN(A); TotalCycles += 2; PC = 0xE9FA;
                    goto case 0xE9FA;
                case 0xE9F9:
                     TotalCycles += 2; PC = 0xE9FA;
                    goto case 0xE9FA;
                case 0xE9FA:
                    A = _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xE9FC;
                    goto case 0xE9FC;
                case 0xE9FC:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0xE9FE;
                    goto case 0xE9FE;
                case 0xE9FD:
                    _ram[0xF0] = Asl(_ram[0xF0]); TotalCycles += 5; PC = 0xE9FF;
                    return;
                case 0xE9FE:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xEA00; goto case 0xEA00;
                case 0xEA00:
                    Cmp(A, 0x08); TotalCycles += 2; PC = 0xEA02;
                    goto case 0xEA02;
                case 0xEA01:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEA02;
                    goto case 0xEA02;
                case 0xEA02:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xEA04; goto case 0xEA04;
                case 0xEA04:
                    Cmp(A, 0x0C); TotalCycles += 2; PC = 0xEA06;
                    goto case 0xEA06;
                case 0xEA06:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xEA08; goto case 0xEA08;
                case 0xEA08:
                    Cmp(A, 0x18); TotalCycles += 2; PC = 0xEA0A;
                    goto case 0xEA0A;
                case 0xEA09:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEA0A;
                    goto case 0xEA0A;
                case 0xEA0A:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xEA0C; goto case 0xEA0C;
                case 0xEA0C:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xEA0E;
                    goto case 0xEA0E;
                case 0xEA0D:
                    TotalCycles += 7; PushU16(0xEA0F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEA0E:
                    Cmp(A, 0x15); TotalCycles += 2; PC = 0xEA10;
                    goto case 0xEA10;
                case 0xEA0F:
                    A |= _ram[(byte)(0xD0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEA11;
                    goto case 0xEA11;
                case 0xEA10:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEA22; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA22; }
                    PC = 0xEA12; goto case 0xEA12;
                case 0xEA11:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xE9DB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xE9DB; }
                    PC = 0xEA13; goto case 0xEA13;
                case 0xEA12:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEA13;
                    goto case 0xEA13;
                case 0xEA13:
                    A = _ram[0x075F]; SetZN(A); TotalCycles += 4; PC = 0xEA16;
                    goto case 0xEA16;
                case 0xEA16:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0xEA18;
                    goto case 0xEA18;
                case 0xEA18:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xEA1A; goto case 0xEA1A;
                case 0xEA19:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x22A2 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEA1C;
                    goto case 0xEA1C;
                case 0xEA1A:
                    X = 0xA2; SetZN(X); TotalCycles += 2; PC = 0xEA1C;
                    goto case 0xEA1C;
                case 0xEA1B:
                    X = 0xA9; SetZN(X); TotalCycles += 2; PC = 0xEA1D;
                    return;
                case 0xEA1C:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xEA1E;
                    goto case 0xEA1E;
                case 0xEA1E:
                    _ram[0xEC] = A; TotalCycles += 3; PC = 0xEA20;
                    goto case 0xEA20;
                case 0xEA1F:
                    Cmp(X, _ram[0x05D0]); TotalCycles += 4; PC = 0xEA22;
                    goto case 0xEA22;
                case 0xEA20:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xEA22; goto case 0xEA22;
                case 0xEA21:
                    A |= _ram[(byte)(0xA5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEA23;
                    goto case 0xEA23;
                case 0xEA22:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xEA24;
                    goto case 0xEA24;
                case 0xEA23:
                    A |= 0x39; SetZN(A); TotalCycles += 2; PC = 0xEA25;
                    goto case 0xEA25;
                case 0xEA24:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x6876 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEA27;
                    goto case 0xEA27;
                case 0xEA25:
                    { byte z = (byte)(0xE8 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xEA27;
                    goto case 0xEA27;
                case 0xEA26:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xEA27;
                    goto case 0xEA27;
                case 0xEA27:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xEA29; goto case 0xEA29;
                case 0xEA28:
                    { int a = 0xEDA5; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xEA2B;
                    goto case 0xEA2B;
                case 0xEA29:
                    A = _ram[0xED]; SetZN(A); TotalCycles += 3; PC = 0xEA2B;
                    goto case 0xEA2B;
                case 0xEA2A:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x2029]); TotalCycles += 4; PC = 0xEA2D;
                    goto case 0xEA2D;
                case 0xEA2B:
                    A &= 0xA0; SetZN(A); TotalCycles += 2; PC = 0xEA2D;
                    goto case 0xEA2D;
                case 0xEA2C:
                    Y = 0x0D; SetZN(Y); TotalCycles += 2; PC = 0xEA2E;
                    return;
                case 0xEA2D:
                    A |= _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xEA30;
                    goto case 0xEA30;
                case 0xEA30:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEA37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA37; }
                    PC = 0xEA32; goto case 0xEA32;
                case 0xEA31:
                    A |= _ram[0x8A]; SetZN(A); TotalCycles += 3; PC = 0xEA33;
                    goto case 0xEA33;
                case 0xEA32:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xEA33;
                    goto case 0xEA33;
                case 0xEA33:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEA34;
                    goto case 0xEA34;
                case 0xEA34:
                    Adc(0x06); TotalCycles += 2; PC = 0xEA36;
                    goto case 0xEA36;
                case 0xEA35:
                    _ram[0xAA] = Asl(_ram[0xAA]); TotalCycles += 5; PC = 0xEA37;
                    goto case 0xEA37;
                case 0xEA36:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xEA37;
                    goto case 0xEA37;
                case 0xEA37:
                    A = _ram[0xED]; SetZN(A); TotalCycles += 3; PC = 0xEA39;
                    goto case 0xEA39;
                case 0xEA38:
                    Sbc(ReadIoReg(0x2029)); TotalCycles += 4; PC = 0xEA3B;
                    goto case 0xEA3B;
                case 0xEA39:
                    A &= 0x20; SetZN(A); TotalCycles += 2; PC = 0xEA3B;
                    goto case 0xEA3B;
                case 0xEA3A:
                    TotalCycles += 6; PushU16(0xEA3C); PC = 0x0EF0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xEA3B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEA4B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA4B; }
                    PC = 0xEA3D; goto case 0xEA3D;
                case 0xEA3C:
                    { int a = 0xEFA5; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xEA3F;
                    goto case 0xEA3F;
                case 0xEA3D:
                    A = _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xEA3F;
                    goto case 0xEA3F;
                case 0xEA3F:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0xEA41;
                    goto case 0xEA41;
                case 0xEA41:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEA4B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA4B; }
                    PC = 0xEA43; goto case 0xEA43;
                case 0xEA42:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEA43;
                    goto case 0xEA43;
                case 0xEA43:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xEA45;
                    goto case 0xEA45;
                case 0xEA44:
                    A |= ReadMem(ReadU16Zp((byte)(0x8C + X))); SetZN(A); TotalCycles += 6; PC = 0xEA46;
                    goto case 0xEA46;
                case 0xEA45:
                    _ram[0x0109] = Y; TotalCycles += 4; PC = 0xEA48;
                    goto case 0xEA48;
                case 0xEA46:
                    A |= 0x01; SetZN(A); TotalCycles += 2; PC = 0xEA48;
                    goto case 0xEA48;
                case 0xEA47:
                    A |= ReadMem(ReadU16Zp((byte)(0x88 + X))); SetZN(A); TotalCycles += 6; PC = 0xEA49;
                    goto case 0xEA49;
                case 0xEA48:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xEA49;
                    goto case 0xEA49;
                case 0xEA49:
                    _ram[0xEC] = Y; TotalCycles += 3; PC = 0xEA4B;
                    goto case 0xEA4B;
                case 0xEA4A:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x6BA4]); TotalCycles += 4; PC = 0xEA4D;
                    goto case 0xEA4D;
                case 0xEA4B:
                    Y = _ram[0xEB]; SetZN(Y); TotalCycles += 3; PC = 0xEA4D;
                    goto case 0xEA4D;
                case 0xEA4D:
                    TotalCycles += 6; PushU16(0xEA4F); PC = 0xEBAA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBAA;
                case 0xEA4E:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xEA4F;
                    return;
                case 0xEA50:
                    TotalCycles += 6; PushU16(0xEA52); PC = 0xEBAA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBAA;
                case 0xEA51:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xEA52;
                    return;
                case 0xEA53:
                    TotalCycles += 6; PushU16(0xEA55); PC = 0xEBAA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBAA;
                case 0xEA54:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xEA55;
                    return;
                case 0xEA56:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xEA58;
                    goto case 0xEA58;
                case 0xEA57:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEA58;
                    goto case 0xEA58;
                case 0xEA58:
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xEA5B;
                    goto case 0xEA5B;
                case 0xEA59:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xEA5B;
                    goto case 0xEA5B;
                case 0xEA5A:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xEA5C;
                    return;
                case 0xEA5B:
                    A = _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xEA5D;
                    goto case 0xEA5D;
                case 0xEA5D:
                    Cmp(A, 0x08); TotalCycles += 2; PC = 0xEA5F;
                    goto case 0xEA5F;
                case 0xEA5E:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEA5F;
                    goto case 0xEA5F;
                case 0xEA5F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEA64; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA64; }
                    PC = 0xEA61; goto case 0xEA61;
                case 0xEA61:
                    TotalCycles += 3; PC = 0xEB64;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEB64;
                case 0xEA64:
                    A = _ram[0x0109]; SetZN(A); TotalCycles += 4; PC = 0xEA67;
                    goto case 0xEA67;
                case 0xEA65:
                    A |= 0x01; SetZN(A); TotalCycles += 2; PC = 0xEA67;
                    goto case 0xEA67;
                case 0xEA66:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0xEA68;
                    goto case 0xEA68;
                case 0xEA67:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEAA6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEAA6; }
                    PC = 0xEA69; goto case 0xEA69;
                case 0xEA68:
                    A &= _ram[(0x02B9 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEA6B;
                    return;
                case 0xEA69:
                    A = _ram[(0x0202 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEA6C;
                    goto case 0xEA6C;
                case 0xEA6C:
                    A |= 0x80; SetZN(A); TotalCycles += 2; PC = 0xEA6E;
                    goto case 0xEA6E;
                case 0xEA6E:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEA6F;
                    goto case 0xEA6F;
                case 0xEA6F:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEA70;
                    goto case 0xEA70;
                case 0xEA70:
                    TotalCycles += 6; PushU16(0xEA72); PC = 0xE5B5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5B5;
                case 0xEA71:
                    A = _ram[(byte)(0xE5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEA73;
                    goto case 0xEA73;
                case 0xEA72:
                    Sbc(_ram[0x88]); TotalCycles += 3; PC = 0xEA74;
                    goto case 0xEA74;
                case 0xEA73:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xEA74;
                    goto case 0xEA74;
                case 0xEA74:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xEA75;
                    goto case 0xEA75;
                case 0xEA75:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xEA76;
                    goto case 0xEA76;
                case 0xEA76:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xEA77;
                    goto case 0xEA77;
                case 0xEA77:
                    A = _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xEA79;
                    goto case 0xEA79;
                case 0xEA79:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xEA7B;
                    goto case 0xEA7B;
                case 0xEA7A:
                    A |= _ram[0xF0]; SetZN(A); TotalCycles += 3; PC = 0xEA7C;
                    goto case 0xEA7C;
                case 0xEA7B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEA8A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA8A; }
                    PC = 0xEA7D; goto case 0xEA7D;
                case 0xEA7C:
                    A |= _ram[0x01C9]; SetZN(A); TotalCycles += 4; PC = 0xEA7F;
                    goto case 0xEA7F;
                case 0xEA7D:
                    Cmp(A, 0x11); TotalCycles += 2; PC = 0xEA7F;
                    goto case 0xEA7F;
                case 0xEA7E:
                    A |= ReadMem(ReadU16Zp(0xF0) + Y); SetZN(A); TotalCycles += 5; PC = 0xEA80;
                    goto case 0xEA80;
                case 0xEA7F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEA8A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA8A; }
                    PC = 0xEA81; goto case 0xEA81;
                case 0xEA80:
                    A |= 0xC9; SetZN(A); TotalCycles += 2; PC = 0xEA82;
                    goto case 0xEA82;
                case 0xEA81:
                    Cmp(A, 0x15); TotalCycles += 2; PC = 0xEA83;
                    goto case 0xEA83;
                case 0xEA82:
                    A |= _ram[(byte)(0xB0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEA84;
                    goto case 0xEA84;
                case 0xEA83:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEA8A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA8A; }
                    PC = 0xEA85; goto case 0xEA85;
                case 0xEA84:
                    A |= _ram[0x8A]; SetZN(A); TotalCycles += 3; PC = 0xEA86;
                    goto case 0xEA86;
                case 0xEA85:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xEA86;
                    goto case 0xEA86;
                case 0xEA86:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEA87;
                    goto case 0xEA87;
                case 0xEA87:
                    Adc(0x08); TotalCycles += 2; PC = 0xEA89;
                    goto case 0xEA89;
                case 0xEA88:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEA89;
                    goto case 0xEA89;
                case 0xEA89:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xEA8A;
                    goto case 0xEA8A;
                case 0xEA8A:
                    A = _ram[(0x0201 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEA8D;
                    goto case 0xEA8D;
                case 0xEA8B:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xEA8D;
                    goto case 0xEA8D;
                case 0xEA8D:
                    PushU8(A); TotalCycles += 3; PC = 0xEA8E;
                    goto case 0xEA8E;
                case 0xEA8E:
                    A = _ram[(0x0205 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEA91;
                    goto case 0xEA91;
                case 0xEA8F:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xEA91;
                    goto case 0xEA91;
                case 0xEA91:
                    PushU8(A); TotalCycles += 3; PC = 0xEA92;
                    goto case 0xEA92;
                case 0xEA92:
                    A = _ram[(0x0211 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEA95;
                    goto case 0xEA95;
                case 0xEA93:
                    A |= ReadMem(ReadU16Zp(0x02) + Y); SetZN(A); TotalCycles += 5; PC = 0xEA95;
                    goto case 0xEA95;
                case 0xEA95:
                    _ram[(0x0201 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xEA98;
                    goto case 0xEA98;
                case 0xEA96:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xEA98;
                    goto case 0xEA98;
                case 0xEA98:
                    A = _ram[(0x0215 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEA9B;
                    goto case 0xEA9B;
                case 0xEA99:
                    A |= _ram[(byte)(0x02 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEA9B;
                    goto case 0xEA9B;
                case 0xEA9B:
                    _ram[(0x0205 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xEA9E;
                    goto case 0xEA9E;
                case 0xEA9C:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xEA9E;
                    goto case 0xEA9E;
                case 0xEA9E:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEA9F;
                    goto case 0xEA9F;
                case 0xEA9F:
                    _ram[(0x0215 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEAA2;
                    goto case 0xEAA2;
                case 0xEAA0:
                    A |= _ram[(byte)(0x02 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEAA2;
                    goto case 0xEAA2;
                case 0xEAA2:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEAA3;
                    goto case 0xEAA3;
                case 0xEAA3:
                    _ram[(0x0211 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEAA6;
                    goto case 0xEAA6;
                case 0xEAA4:
                    A |= ReadMem(ReadU16Zp(0x02) + Y); SetZN(A); TotalCycles += 5; PC = 0xEAA6;
                    goto case 0xEAA6;
                case 0xEAA6:
                    A = _ram[0x036A]; SetZN(A); TotalCycles += 4; PC = 0xEAA9;
                    goto case 0xEAA9;
                case 0xEAA7:
                    A = Ror(A); TotalCycles += 2; PC = 0xEAA8;
                    return;
                case 0xEAA9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEA61; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEA61; }
                    PC = 0xEAAB; goto case 0xEAAB;
                case 0xEAAA:
                    X = _ram[(byte)(0xA5 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xEAAC;
                    return;
                case 0xEAAB:
                    A = _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xEAAD;
                    goto case 0xEAAD;
                case 0xEAAD:
                    X = _ram[0xEC]; SetZN(X); TotalCycles += 3; PC = 0xEAAF;
                    goto case 0xEAAF;
                case 0xEAAE:
                    Cmp(X, _ram[0x05C9]); TotalCycles += 4; PC = 0xEAB1;
                    goto case 0xEAB1;
                case 0xEAAF:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xEAB1;
                    goto case 0xEAB1;
                case 0xEAB0:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xEAB2;
                    return;
                case 0xEAB1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEAB6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEAB6; }
                    PC = 0xEAB3; goto case 0xEAB3;
                case 0xEAB3:
                    TotalCycles += 3; PC = 0xEB64;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEB64;
                case 0xEAB6:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0xEAB8;
                    goto case 0xEAB8;
                case 0xEAB8:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEAD7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEAD7; }
                    PC = 0xEABA; goto case 0xEABA;
                case 0xEAB9:
                    A |= ReadMem(0x0DC9 + X); SetZN(A); TotalCycles += 4; PC = 0xEABC;
                    goto case 0xEABC;
                case 0xEABA:
                    Cmp(A, 0x0D); TotalCycles += 2; PC = 0xEABC;
                    goto case 0xEABC;
                case 0xEABB:
                    A |= _ram[0x01F0]; SetZN(A); TotalCycles += 4; PC = 0xEABE;
                    goto case 0xEABE;
                case 0xEABC:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEAD7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEAD7; }
                    PC = 0xEABE; goto case 0xEABE;
                case 0xEABD:
                    A |= ReadMem(0x0CC9 + Y); SetZN(A); TotalCycles += 4; PC = 0xEAC0;
                    goto case 0xEAC0;
                case 0xEABE:
                    Cmp(A, 0x0C); TotalCycles += 2; PC = 0xEAC0;
                    goto case 0xEAC0;
                case 0xEAC0:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEAD7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEAD7; }
                    PC = 0xEAC2; goto case 0xEAC2;
                case 0xEAC1:
                    A |= _ram[(byte)(0xC9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEAC3;
                    return;
                case 0xEAC2:
                    Cmp(A, 0x12); TotalCycles += 2; PC = 0xEAC4;
                    goto case 0xEAC4;
                case 0xEAC4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEACA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEACA; }
                    PC = 0xEAC6; goto case 0xEAC6;
                case 0xEAC6:
                    Cmp(X, 0x05); TotalCycles += 2; PC = 0xEAC8;
                    goto case 0xEAC8;
                case 0xEAC7:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xEAC9;
                    goto case 0xEAC9;
                case 0xEAC8:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEB12; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB12; }
                    PC = 0xEACA; goto case 0xEACA;
                case 0xEAC9:
                    PushU8(A); TotalCycles += 3; PC = 0xEACA;
                    goto case 0xEACA;
                case 0xEACA:
                    Cmp(A, 0x15); TotalCycles += 2; PC = 0xEACC;
                    goto case 0xEACC;
                case 0xEACB:
                    A |= _ram[(byte)(0xD0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEACD;
                    goto case 0xEACD;
                case 0xEACC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEAD3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEAD3; }
                    PC = 0xEACE; goto case 0xEACE;
                case 0xEACD:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xEACF;
                    return;
                case 0xEACE:
                    A = 0x42; SetZN(A); TotalCycles += 2; PC = 0xEAD0;
                    goto case 0xEAD0;
                case 0xEAD0:
                    _ram[(0x0216 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEAD3;
                    goto case 0xEAD3;
                case 0xEAD1:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xEAD3;
                    goto case 0xEAD3;
                case 0xEAD3:
                    Cmp(X, 0x02); TotalCycles += 2; PC = 0xEAD5;
                    goto case 0xEAD5;
                case 0xEAD5:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEB12; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB12; }
                    PC = 0xEAD7; goto case 0xEAD7;
                case 0xEAD7:
                    A = _ram[0x036A]; SetZN(A); TotalCycles += 4; PC = 0xEADA;
                    goto case 0xEADA;
                case 0xEAD8:
                    A = Ror(A); TotalCycles += 2; PC = 0xEAD9;
                    return;
                case 0xEADA:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEB12; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB12; }
                    PC = 0xEADC; goto case 0xEADC;
                case 0xEADB:
                    { byte z = (byte)(0xB9 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xEADD;
                    return;
                case 0xEADC:
                    A = _ram[(0x0202 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEADF;
                    goto case 0xEADF;
                case 0xEADF:
                    A &= 0xA3; SetZN(A); TotalCycles += 2; PC = 0xEAE1;
                    goto case 0xEAE1;
                case 0xEAE1:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEAE4;
                    goto case 0xEAE4;
                case 0xEAE4:
                    _ram[(0x020A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEAE7;
                    goto case 0xEAE7;
                case 0xEAE5:
                    A = Asl(A); TotalCycles += 2; PC = 0xEAE6;
                    return;
                case 0xEAE7:
                    _ram[(0x0212 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEAEA;
                    goto case 0xEAEA;
                case 0xEAEA:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xEAEC;
                    goto case 0xEAEC;
                case 0xEAEB:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xEAEC:
                    Cmp(X, 0x05); TotalCycles += 2; PC = 0xEAEE;
                    goto case 0xEAEE;
                case 0xEAED:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xEAEF;
                    return;
                case 0xEAEE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEAF2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEAF2; }
                    PC = 0xEAF0; goto case 0xEAF0;
                case 0xEAF0:
                    A |= 0x80; SetZN(A); TotalCycles += 2; PC = 0xEAF2;
                    goto case 0xEAF2;
                case 0xEAF2:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEAF5;
                    goto case 0xEAF5;
                case 0xEAF3:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xEAF5;
                    goto case 0xEAF5;
                case 0xEAF5:
                    _ram[(0x020E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEAF8;
                    goto case 0xEAF8;
                case 0xEAF6:
                    { int a = 0x9902; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xEAF9;
                    goto case 0xEAF9;
                case 0xEAF8:
                    _ram[(0x0216 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEAFB;
                    goto case 0xEAFB;
                case 0xEAF9:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xEAFB;
                    goto case 0xEAFB;
                case 0xEAFB:
                    Cmp(X, 0x04); TotalCycles += 2; PC = 0xEAFD;
                    goto case 0xEAFD;
                case 0xEAFD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEB12; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB12; }
                    PC = 0xEAFF; goto case 0xEAFF;
                case 0xEAFF:
                    A = _ram[(0x020A + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEB02;
                    goto case 0xEB02;
                case 0xEB00:
                    A = Asl(A); TotalCycles += 2; PC = 0xEB01;
                    return;
                case 0xEB02:
                    A |= 0x80; SetZN(A); TotalCycles += 2; PC = 0xEB04;
                    goto case 0xEB04;
                case 0xEB04:
                    _ram[(0x020A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB07;
                    goto case 0xEB07;
                case 0xEB05:
                    A = Asl(A); TotalCycles += 2; PC = 0xEB06;
                    return;
                case 0xEB07:
                    _ram[(0x0212 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB0A;
                    goto case 0xEB0A;
                case 0xEB0A:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xEB0C;
                    goto case 0xEB0C;
                case 0xEB0B:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xEB0C:
                    _ram[(0x020E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB0F;
                    goto case 0xEB0F;
                case 0xEB0D:
                    { int a = 0x9902; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xEB10;
                    goto case 0xEB10;
                case 0xEB0F:
                    _ram[(0x0216 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB12;
                    goto case 0xEB12;
                case 0xEB10:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xEB12;
                    goto case 0xEB12;
                case 0xEB12:
                    A = _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xEB14;
                    goto case 0xEB14;
                case 0xEB14:
                    Cmp(A, 0x11); TotalCycles += 2; PC = 0xEB16;
                    goto case 0xEB16;
                case 0xEB15:
                    A |= ReadMem(ReadU16Zp(0xD0) + Y); SetZN(A); TotalCycles += 5; PC = 0xEB17;
                    goto case 0xEB17;
                case 0xEB16:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEB4E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB4E; }
                    PC = 0xEB18; goto case 0xEB18;
                case 0xEB17:
                    { byte z = (byte)(0xAD + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xEB19;
                    goto case 0xEB19;
                case 0xEB18:
                    A = _ram[0x0109]; SetZN(A); TotalCycles += 4; PC = 0xEB1B;
                    goto case 0xEB1B;
                case 0xEB19:
                    A |= 0x01; SetZN(A); TotalCycles += 2; PC = 0xEB1B;
                    goto case 0xEB1B;
                case 0xEB1A:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0xEB1C;
                    goto case 0xEB1C;
                case 0xEB1B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEB3E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB3E; }
                    PC = 0xEB1D; goto case 0xEB1D;
                case 0xEB1C:
                    A &= ReadMem(ReadU16Zp((byte)(0xB9 + X))); SetZN(A); TotalCycles += 6; PC = 0xEB1E;
                    return;
                case 0xEB1D:
                    A = _ram[(0x0212 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEB20;
                    goto case 0xEB20;
                case 0xEB20:
                    A &= 0x81; SetZN(A); TotalCycles += 2; PC = 0xEB22;
                    goto case 0xEB22;
                case 0xEB21:
                    WriteMem(ReadU16Zp((byte)(0x99 + X)), A); TotalCycles += 6; PC = 0xEB23;
                    return;
                case 0xEB22:
                    _ram[(0x0212 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB25;
                    goto case 0xEB25;
                case 0xEB25:
                    A = _ram[(0x0216 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEB28;
                    goto case 0xEB28;
                case 0xEB26:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xEB28;
                    goto case 0xEB28;
                case 0xEB28:
                    A |= 0x41; SetZN(A); TotalCycles += 2; PC = 0xEB2A;
                    goto case 0xEB2A;
                case 0xEB29:
                    A ^= ReadMem(ReadU16Zp((byte)(0x99 + X))); SetZN(A); TotalCycles += 6; PC = 0xEB2B;
                    goto case 0xEB2B;
                case 0xEB2A:
                    _ram[(0x0216 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB2D;
                    goto case 0xEB2D;
                case 0xEB2B:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xEB2D;
                    goto case 0xEB2D;
                case 0xEB2D:
                    X = _ram[0x078F]; SetZN(X); TotalCycles += 4; PC = 0xEB30;
                    goto case 0xEB30;
                case 0xEB30:
                    Cmp(X, 0x10); TotalCycles += 2; PC = 0xEB32;
                    goto case 0xEB32;
                case 0xEB31:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEAE3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xEB33; goto case 0xEB33;
                case 0xEB32:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEB64; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB64; }
                    PC = 0xEB34; goto case 0xEB34;
                case 0xEB33:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xEACE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEACE; }
                    PC = 0xEB35; goto case 0xEB35;
                case 0xEB34:
                    _ram[(0x020E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB37;
                    goto case 0xEB37;
                case 0xEB35:
                    { int a = 0x2902; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xEB38;
                    goto case 0xEB38;
                case 0xEB37:
                    A &= 0x81; SetZN(A); TotalCycles += 2; PC = 0xEB39;
                    goto case 0xEB39;
                case 0xEB38:
                    WriteMem(ReadU16Zp((byte)(0x99 + X)), A); TotalCycles += 6; PC = 0xEB3A;
                    goto case 0xEB3A;
                case 0xEB39:
                    _ram[(0x020A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB3C;
                    goto case 0xEB3C;
                case 0xEB3A:
                    A = Asl(A); TotalCycles += 2; PC = 0xEB3B;
                    return;
                case 0xEB3C:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEB64; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB64; }
                    PC = 0xEB3E; goto case 0xEB3E;
                case 0xEB3D:
                    _ram[0xB9] = Rol(_ram[0xB9]); TotalCycles += 5; PC = 0xEB3F;
                    return;
                case 0xEB3E:
                    A = _ram[(0x0202 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEB41;
                    goto case 0xEB41;
                case 0xEB41:
                    A &= 0x81; SetZN(A); TotalCycles += 2; PC = 0xEB43;
                    goto case 0xEB43;
                case 0xEB42:
                    WriteMem(ReadU16Zp((byte)(0x99 + X)), A); TotalCycles += 6; PC = 0xEB44;
                    return;
                case 0xEB43:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB46;
                    goto case 0xEB46;
                case 0xEB46:
                    A = _ram[(0x0206 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEB49;
                    goto case 0xEB49;
                case 0xEB47:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xEB49;
                    goto case 0xEB49;
                case 0xEB49:
                    A |= 0x41; SetZN(A); TotalCycles += 2; PC = 0xEB4B;
                    goto case 0xEB4B;
                case 0xEB4A:
                    A ^= ReadMem(ReadU16Zp((byte)(0x99 + X))); SetZN(A); TotalCycles += 6; PC = 0xEB4C;
                    goto case 0xEB4C;
                case 0xEB4B:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB4E;
                    goto case 0xEB4E;
                case 0xEB4C:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xEB4E;
                    goto case 0xEB4E;
                case 0xEB4E:
                    A = _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xEB50;
                    goto case 0xEB50;
                case 0xEB50:
                    Cmp(A, 0x18); TotalCycles += 2; PC = 0xEB52;
                    goto case 0xEB52;
                case 0xEB51:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEB52;
                    goto case 0xEB52;
                case 0xEB52:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEB64; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB64; }
                    PC = 0xEB54; goto case 0xEB54;
                case 0xEB53:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEAFE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xEB55; return;
                case 0xEB54:
                    A = 0x82; SetZN(A); TotalCycles += 2; PC = 0xEB56;
                    goto case 0xEB56;
                case 0xEB56:
                    _ram[(0x020A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB59;
                    goto case 0xEB59;
                case 0xEB57:
                    A = Asl(A); TotalCycles += 2; PC = 0xEB58;
                    return;
                case 0xEB59:
                    _ram[(0x0212 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB5C;
                    goto case 0xEB5C;
                case 0xEB5C:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xEB5E;
                    goto case 0xEB5E;
                case 0xEB5D:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xEB5E:
                    _ram[(0x020E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB61;
                    goto case 0xEB61;
                case 0xEB5F:
                    { int a = 0x9902; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xEB62;
                    goto case 0xEB62;
                case 0xEB61:
                    _ram[(0x0216 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEB64;
                    goto case 0xEB64;
                case 0xEB62:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xEB64;
                    goto case 0xEB64;
                case 0xEB64:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xEB66;
                    goto case 0xEB66;
                case 0xEB65:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEB66;
                    goto case 0xEB66;
                case 0xEB66:
                    A = _ram[0x03D1]; SetZN(A); TotalCycles += 4; PC = 0xEB69;
                    goto case 0xEB69;
                case 0xEB67:
                    Cmp(A, ReadMem(ReadU16Zp(0x03) + Y)); TotalCycles += 5; PC = 0xEB69;
                    goto case 0xEB69;
                case 0xEB69:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEB6A;
                    goto case 0xEB6A;
                case 0xEB6A:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEB6B;
                    goto case 0xEB6B;
                case 0xEB6B:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEB6C;
                    goto case 0xEB6C;
                case 0xEB6C:
                    PushU8(A); TotalCycles += 3; PC = 0xEB6D;
                    goto case 0xEB6D;
                case 0xEB6D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEB74; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB74; }
                    PC = 0xEB6F; goto case 0xEB6F;
                case 0xEB6E:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xEB70;
                    return;
                case 0xEB6F:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xEB71;
                    goto case 0xEB71;
                case 0xEB71:
                    TotalCycles += 6; PushU16(0xEB73); PC = 0xEBC1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBC1;
                case 0xEB72:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xEB + X)))); TotalCycles += 6; PC = 0xEB74;
                    goto case 0xEB74;
                case 0xEB74:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEB75;
                    goto case 0xEB75;
                case 0xEB75:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEB76;
                    goto case 0xEB76;
                case 0xEB76:
                    PushU8(A); TotalCycles += 3; PC = 0xEB77;
                    goto case 0xEB77;
                case 0xEB77:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEB7E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB7E; }
                    PC = 0xEB79; goto case 0xEB79;
                case 0xEB78:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xEB7A;
                    goto case 0xEB7A;
                case 0xEB79:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xEB7B;
                    goto case 0xEB7B;
                case 0xEB7A:
                    TotalCycles += 7; PushU16(0xEB7C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEB7B:
                    TotalCycles += 6; PushU16(0xEB7D); PC = 0xEBC1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBC1;
                case 0xEB7C:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xEB + X)))); TotalCycles += 6; PC = 0xEB7E;
                    goto case 0xEB7E;
                case 0xEB7E:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEB7F;
                    goto case 0xEB7F;
                case 0xEB7F:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEB80;
                    goto case 0xEB80;
                case 0xEB80:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEB81;
                    goto case 0xEB81;
                case 0xEB81:
                    PushU8(A); TotalCycles += 3; PC = 0xEB82;
                    goto case 0xEB82;
                case 0xEB82:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEB89; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB89; }
                    PC = 0xEB84; goto case 0xEB84;
                case 0xEB83:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xEB85;
                    goto case 0xEB85;
                case 0xEB84:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0xEB86;
                    goto case 0xEB86;
                case 0xEB85:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEBA7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEBA7; }
                    PC = 0xEB87; return;
                case 0xEB86:
                    TotalCycles += 6; PushU16(0xEB88); PC = 0xEBB7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBB7;
                case 0xEB89:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEB8A;
                    goto case 0xEB8A;
                case 0xEB8A:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEB8B;
                    goto case 0xEB8B;
                case 0xEB8B:
                    PushU8(A); TotalCycles += 3; PC = 0xEB8C;
                    goto case 0xEB8C;
                case 0xEB8C:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEB93; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEB93; }
                    PC = 0xEB8E; goto case 0xEB8E;
                case 0xEB8D:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xEB8F;
                    goto case 0xEB8F;
                case 0xEB8E:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xEB90;
                    goto case 0xEB90;
                case 0xEB8F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEB90;
                    goto case 0xEB90;
                case 0xEB90:
                    TotalCycles += 6; PushU16(0xEB92); PC = 0xEBB7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBB7;
                case 0xEB93:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEB94;
                    goto case 0xEB94;
                case 0xEB94:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEB95;
                    goto case 0xEB95;
                case 0xEB95:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEBA9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEBA9; }
                    PC = 0xEB97; goto case 0xEB97;
                case 0xEB97:
                    TotalCycles += 6; PushU16(0xEB99); PC = 0xEBB7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBB7;
                case 0xEB9A:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEB9C;
                    goto case 0xEB9C;
                case 0xEB9B:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xEB9D;
                    return;
                case 0xEB9C:
                    Cmp(A, 0x0C); TotalCycles += 2; PC = 0xEB9E;
                    goto case 0xEB9E;
                case 0xEB9E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEBA9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEBA9; }
                    PC = 0xEBA0; goto case 0xEBA0;
                case 0xEB9F:
                    A |= 0xB5; SetZN(A); TotalCycles += 2; PC = 0xEBA1;
                    goto case 0xEBA1;
                case 0xEBA0:
                    A = _ram[(byte)(0xB6 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEBA2;
                    goto case 0xEBA2;
                case 0xEBA1:
                    X = _ram[(byte)(0xC9 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xEBA3;
                    return;
                case 0xEBA2:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xEBA4;
                    goto case 0xEBA4;
                case 0xEBA4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEBA9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEBA9; }
                    PC = 0xEBA6; goto case 0xEBA6;
                case 0xEBA6:
                    TotalCycles += 6; PushU16(0xEBA8); PC = 0xC998;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xEBA7:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xEBA8;
                    goto case 0xEBA8;
                case 0xEBA8:
                    Cmp(A, 0x60); TotalCycles += 2; PC = 0xEBAA;
                    goto case 0xEBAA;
                case 0xEBA9:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEBAA: // === SUBROUTINE: Sub_EBAA ===
                    A = SmbEmbeddedAssets.StaticDataTables[(0x673E + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEBAD;
                    goto case 0xEBAD;
                case 0xEBAB:
                    { int a = 0x85E7 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xEBAE;
                    goto case 0xEBAE;
                case 0xEBAD:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xEBAF;
                    goto case 0xEBAF;
                case 0xEBAE:
                    TotalCycles += 7; PushU16(0xEBB0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEBAF:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x673F + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEBB2;
                    goto case 0xEBB2;
                case 0xEBB2: // === SUBROUTINE: Sub_EBB2 ===
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xEBB4;
                    goto case 0xEBB4;
                case 0xEBB3:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xEBB5;
                    return;
                case 0xEBB4:
                    TotalCycles += 3; PC = 0xF282;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF282;
                case 0xEBB7: // === SUBROUTINE: Sub_EBB7 ===
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEBB8;
                    goto case 0xEBB8;
                case 0xEBB8:
                    Adc(_ram[(0x06E5 + X) & 0x07FF]); TotalCycles += 4; PC = 0xEBBB;
                    goto case 0xEBBB;
                case 0xEBB9:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xEBBB;
                    goto case 0xEBBB;
                case 0xEBBA:
                    _ram[0xA8] = Asl(_ram[0xA8]); TotalCycles += 5; PC = 0xEBBC;
                    goto case 0xEBBC;
                case 0xEBBB:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xEBBC;
                    goto case 0xEBBC;
                case 0xEBBC:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xEBBE;
                    goto case 0xEBBE;
                case 0xEBBD:
                    P |= FlagD; TotalCycles += 2; PC = 0xEBBE;
                    goto case 0xEBBE;
                case 0xEBBE:
                    TotalCycles += 3; PC = 0xE5C1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5C1;
                case 0xEBBF:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xE5 + X)))); TotalCycles += 6; PC = 0xEBC1;
                    goto case 0xEBC1;
                case 0xEBC0:
                    Sbc(_ram[0x18]); TotalCycles += 3; PC = 0xEBC2;
                    goto case 0xEBC2;
                case 0xEBC1: // === SUBROUTINE: Sub_EBC1 ===
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEBC2;
                    goto case 0xEBC2;
                case 0xEBC2:
                    Adc(_ram[(0x06E5 + X) & 0x07FF]); TotalCycles += 4; PC = 0xEBC5;
                    goto case 0xEBC5;
                case 0xEBC3:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xEBC5;
                    goto case 0xEBC5;
                case 0xEBC4:
                    _ram[0xA8] = Asl(_ram[0xA8]); TotalCycles += 5; PC = 0xEBC6;
                    goto case 0xEBC6;
                case 0xEBC5:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xEBC6;
                    goto case 0xEBC6;
                case 0xEBC6:
                    TotalCycles += 6; PushU16(0xEBC8); PC = 0xEC4A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEC4A;
                case 0xEBC7:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEBC8;
                    goto case 0xEBC8;
                case 0xEBC8:
                    Cmp(X, _ram[0x0099]); TotalCycles += 4; PC = 0xEBCB;
                    return;
                case 0xEBC9:
                    _ram[(0x0210 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEBCC;
                    goto case 0xEBCC;
                case 0xEBCA:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEBCE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEBCE; }
                    PC = 0xEBCC; goto case 0xEBCC;
                case 0xEBCC:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEBCD: // === SUBROUTINE: Sub_EBCD ===
                    _ram[0x85] = A; TotalCycles += 3; PC = 0xEBCF;
                    goto case 0xEBCF;
                case 0xEBCE:
                    _ram[0x86] = A; TotalCycles += 3; PC = 0xEBD0;
                    goto case 0xEBD0;
                case 0xEBCF:
                    _ram[0x86] = X; TotalCycles += 3; PC = 0xEBD1;
                    goto case 0xEBD1;
                case 0xEBD0:
                    _ram[0xAD] = X; TotalCycles += 3; PC = 0xEBD2;
                    goto case 0xEBD2;
                case 0xEBD1: // === SUBROUTINE: Sub_EBD1 ===
                    A = _ram[0x03BC]; SetZN(A); TotalCycles += 4; PC = 0xEBD4;
                    goto case 0xEBD4;
                case 0xEBD2:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x0503 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xEBD5;
                    return;
                case 0xEBD4:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xEBD6;
                    goto case 0xEBD6;
                case 0xEBD6:
                    A = _ram[0x03B1]; SetZN(A); TotalCycles += 4; PC = 0xEBD9;
                    goto case 0xEBD9;
                case 0xEBD7:
                    A = ReadMem(ReadU16Zp(0x03) + Y); SetZN(A); TotalCycles += 5; PC = 0xEBD9;
                    goto case 0xEBD9;
                case 0xEBD9:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0xEBDB;
                    goto case 0xEBDB;
                case 0xEBDA:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xEBDC;
                    return;
                case 0xEBDB:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xEBDD;
                    goto case 0xEBDD;
                case 0xEBDD:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xEBDF;
                    goto case 0xEBDF;
                case 0xEBDF:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEBE0;
                    goto case 0xEBE0;
                case 0xEBE0:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0xEBE2;
                    goto case 0xEBE2;
                case 0xEBE2:
                    Y = _ram[(0x06EC + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xEBE5;
                    goto case 0xEBE5;
                case 0xEBE3:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x2206]); TotalCycles += 4; PC = 0xEBE6;
                    goto case 0xEBE6;
                case 0xEBE4:
                    _ram[0xA2] = Asl(_ram[0xA2]); TotalCycles += 5; PC = 0xEBE6;
                    goto case 0xEBE6;
                case 0xEBE5:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xEBE7;
                    goto case 0xEBE7;
                case 0xEBE6:
                    TotalCycles += 7; PushU16(0xEBE8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEBE7:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6BCD + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEBEA;
                    goto case 0xEBEA;
                case 0xEBE8:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x05EB]); TotalCycles += 4; PC = 0xEBEB;
                    goto case 0xEBEB;
                case 0xEBEA:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xEBEC;
                    goto case 0xEBEC;
                case 0xEBEB:
                    TotalCycles += 7; PushU16(0xEBED); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEBEC:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6BCE + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEBEF;
                    goto case 0xEBEF;
                case 0xEBED:
                    { int a = 0x20EB; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xEBF0;
                    return;
                case 0xEBEF:
                    TotalCycles += 6; PushU16(0xEBF1); PC = 0xEBB2;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBB2;
                case 0xEBF2:
                    Cmp(X, 0x04); TotalCycles += 2; PC = 0xEBF4;
                    goto case 0xEBF4;
                case 0xEBF4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEBE7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEBE7; }
                    PC = 0xEBF6; goto case 0xEBF6;
                case 0xEBF5:
                    Sbc(ReadMem(ReadU16Zp(0xA6) + Y)); TotalCycles += 5; PC = 0xEBF7;
                    goto case 0xEBF7;
                case 0xEBF6:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xEBF8;
                    goto case 0xEBF8;
                case 0xEBF7:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEBF8;
                    goto case 0xEBF8;
                case 0xEBF8:
                    Y = _ram[(0x06EC + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xEBFB;
                    goto case 0xEBFB;
                case 0xEBF9:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x2D06]); TotalCycles += 4; PC = 0xEBFC;
                    goto case 0xEBFC;
                case 0xEBFA:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xEBFC;
                    goto case 0xEBFC;
                case 0xEBFB:
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0xEBFE;
                    goto case 0xEBFE;
                case 0xEBFC:
                    { int a = 0xC907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xEBFF;
                    goto case 0xEBFF;
                case 0xEBFE:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xEC00;
                    goto case 0xEC00;
                case 0xEBFF:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0xEC01;
                    goto case 0xEC01;
                case 0xEC00:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEC0A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEC0A; }
                    PC = 0xEC02; goto case 0xEC02;
                case 0xEC01:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEC02;
                    goto case 0xEC02;
                case 0xEC02:
                    A = 0x86; SetZN(A); TotalCycles += 2; PC = 0xEC04;
                    goto case 0xEC04;
                case 0xEC03:
                    _ram[0x99] = X; TotalCycles += 3; PC = 0xEC05;
                    goto case 0xEC05;
                case 0xEC04:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC07;
                    goto case 0xEC07;
                case 0xEC05:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xEC07;
                    goto case 0xEC07;
                case 0xEC07:
                    _ram[(0x0205 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC0A;
                    goto case 0xEC0A;
                case 0xEC08:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xEC0A;
                    goto case 0xEC0A;
                case 0xEC0A:
                    A = _ram[(0x03E8 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEC0D;
                    goto case 0xEC0D;
                case 0xEC0B:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xEC0C;
                    return;
                case 0xEC0D:
                    Cmp(A, 0xC4); TotalCycles += 2; PC = 0xEC0F;
                    goto case 0xEC0F;
                case 0xEC0E:
                    Cmp(Y, _ram[0xD0]); TotalCycles += 3; PC = 0xEC10;
                    goto case 0xEC10;
                case 0xEC0F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEC35; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEC35; }
                    PC = 0xEC11; goto case 0xEC11;
                case 0xEC10:
                    Bit(_ram[0xA9]); TotalCycles += 3; PC = 0xEC12;
                    return;
                case 0xEC11:
                    A = 0x87; SetZN(A); TotalCycles += 2; PC = 0xEC13;
                    goto case 0xEC13;
                case 0xEC13:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEC14;
                    goto case 0xEC14;
                case 0xEC14:
                    TotalCycles += 6; PushU16(0xEC16); PC = 0xE5BB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5BB;
                case 0xEC16:
                    Sbc(_ram[0x88]); TotalCycles += 3; PC = 0xEC18;
                    goto case 0xEC18;
                case 0xEC17:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xEC18;
                    goto case 0xEC18;
                case 0xEC18:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xEC1A;
                    goto case 0xEC1A;
                case 0xEC1A:
                    X = _ram[0x074E]; SetZN(X); TotalCycles += 4; PC = 0xEC1D;
                    goto case 0xEC1D;
                case 0xEC1B:
                    { int a = 0xCA07; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xEC1E;
                    goto case 0xEC1E;
                case 0xEC1D:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xEC1E;
                    goto case 0xEC1E;
                case 0xEC1E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEC21; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEC21; }
                    PC = 0xEC20; goto case 0xEC20;
                case 0xEC1F:
                    A |= ReadMem(ReadU16Zp((byte)(0x4A + X))); SetZN(A); TotalCycles += 6; PC = 0xEC21;
                    goto case 0xEC21;
                case 0xEC20:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEC21;
                    goto case 0xEC21;
                case 0xEC21:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xEC23;
                    goto case 0xEC23;
                case 0xEC22:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEC23;
                    goto case 0xEC23;
                case 0xEC23:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC26;
                    goto case 0xEC26;
                case 0xEC26:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xEC28;
                    goto case 0xEC28;
                case 0xEC27:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xEC28:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC2B;
                    goto case 0xEC2B;
                case 0xEC29:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xEC2B;
                    goto case 0xEC2B;
                case 0xEC2B:
                    A |= 0x80; SetZN(A); TotalCycles += 2; PC = 0xEC2D;
                    goto case 0xEC2D;
                case 0xEC2D:
                    _ram[(0x020E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC30;
                    goto case 0xEC30;
                case 0xEC2E:
                    { int a = 0x2902; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xEC31;
                    return;
                case 0xEC30:
                    A &= 0x83; SetZN(A); TotalCycles += 2; PC = 0xEC32;
                    goto case 0xEC32;
                case 0xEC32:
                    _ram[(0x020A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC35;
                    goto case 0xEC35;
                case 0xEC33:
                    A = Asl(A); TotalCycles += 2; PC = 0xEC34;
                    return;
                case 0xEC35:
                    A = _ram[0x03D4]; SetZN(A); TotalCycles += 4; PC = 0xEC38;
                    goto case 0xEC38;
                case 0xEC38:
                    PushU8(A); TotalCycles += 3; PC = 0xEC39;
                    goto case 0xEC39;
                case 0xEC39:
                    A &= 0x04; SetZN(A); TotalCycles += 2; PC = 0xEC3B;
                    goto case 0xEC3B;
                case 0xEC3B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEC45; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEC45; }
                    PC = 0xEC3D; goto case 0xEC3D;
                case 0xEC3C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEC3D;
                    goto case 0xEC3D;
                case 0xEC3D:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xEC3F;
                    goto case 0xEC3F;
                case 0xEC3E:
                    P |= FlagD; TotalCycles += 2; PC = 0xEC3F;
                    goto case 0xEC3F;
                case 0xEC3F:
                    _ram[(0x0204 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC42;
                    goto case 0xEC42;
                case 0xEC42:
                    _ram[(0x020C + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC45;
                    goto case 0xEC45;
                case 0xEC45:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEC46;
                    goto case 0xEC46;
                case 0xEC46: // === SUBROUTINE: Sub_EC46 ===
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xEC48;
                    goto case 0xEC48;
                case 0xEC47:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEC48;
                    goto case 0xEC48;
                case 0xEC48:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEC52; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEC52; }
                    PC = 0xEC4A; goto case 0xEC4A;
                case 0xEC49:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEC4A;
                    goto case 0xEC4A;
                case 0xEC4A: // === SUBROUTINE: Sub_EC4A ===
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xEC4C;
                    goto case 0xEC4C;
                case 0xEC4B:
                    P |= FlagD; TotalCycles += 2; PC = 0xEC4C;
                    goto case 0xEC4C;
                case 0xEC4C:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC4F;
                    goto case 0xEC4F;
                case 0xEC4D:
                    TotalCycles += 7; PushU16(0xEC4F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEC4F:
                    _ram[(0x0208 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC52;
                    goto case 0xEC52;
                case 0xEC50:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEC51;
                    return;
                case 0xEC52:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEC53: // === SUBROUTINE: Sub_EC53 ===
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xEC55;
                    goto case 0xEC55;
                case 0xEC55:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xEC57;
                    goto case 0xEC57;
                case 0xEC56:
                    TotalCycles += 7; PushU16(0xEC58); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEC57:
                    A = 0x75; SetZN(A); TotalCycles += 2; PC = 0xEC59;
                    goto case 0xEC59;
                case 0xEC58:
                    Adc(_ram[(byte)(0xA4 + X)]); TotalCycles += 4; PC = 0xEC5A;
                    goto case 0xEC5A;
                case 0xEC59:
                    Y = _ram[0x0E]; SetZN(Y); TotalCycles += 3; PC = 0xEC5B;
                    goto case 0xEC5B;
                case 0xEC5A:
                    _ram[0x05C0] = Asl(_ram[0x05C0]); TotalCycles += 6; PC = 0xEC5D;
                    goto case 0xEC5D;
                case 0xEC5B:
                    Cmp(Y, 0x05); TotalCycles += 2; PC = 0xEC5D;
                    goto case 0xEC5D;
                case 0xEC5C:
                    A |= _ram[0xF0]; SetZN(A); TotalCycles += 3; PC = 0xEC5E;
                    goto case 0xEC5E;
                case 0xEC5D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEC65; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEC65; }
                    PC = 0xEC5F; goto case 0xEC5F;
                case 0xEC5E:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xEC60;
                    return;
                case 0xEC5F:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xEC61;
                    goto case 0xEC61;
                case 0xEC61:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xEC63;
                    goto case 0xEC63;
                case 0xEC62:
                    TotalCycles += 7; PushU16(0xEC64); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEC63:
                    A = 0x84; SetZN(A); TotalCycles += 2; PC = 0xEC65;
                    goto case 0xEC65;
                case 0xEC64:
                    _ram[0xBC] = Y; TotalCycles += 3; PC = 0xEC66;
                    goto case 0xEC66;
                case 0xEC65:
                    Y = _ram[(0x06EC + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xEC68;
                    goto case 0xEC68;
                case 0xEC66:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x4806]); TotalCycles += 4; PC = 0xEC69;
                    goto case 0xEC69;
                case 0xEC67:
                    _ram[0xC8] = Asl(_ram[0xC8]); TotalCycles += 5; PC = 0xEC69;
                    goto case 0xEC69;
                case 0xEC68:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEC69;
                    goto case 0xEC69;
                case 0xEC69:
                    TotalCycles += 6; PushU16(0xEC6B); PC = 0xE5BB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5BB;
                case 0xEC6B:
                    Sbc(_ram[0xA5]); TotalCycles += 3; PC = 0xEC6D;
                    goto case 0xEC6D;
                case 0xEC6C:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xEC6E;
                    goto case 0xEC6E;
                case 0xEC6D:
                    A |= 0x0A; SetZN(A); TotalCycles += 2; PC = 0xEC6F;
                    goto case 0xEC6F;
                case 0xEC6E:
                    A = Asl(A); TotalCycles += 2; PC = 0xEC6F;
                    goto case 0xEC6F;
                case 0xEC6F:
                    A = Asl(A); TotalCycles += 2; PC = 0xEC70;
                    goto case 0xEC70;
                case 0xEC70:
                    A = Asl(A); TotalCycles += 2; PC = 0xEC71;
                    goto case 0xEC71;
                case 0xEC71:
                    A = Asl(A); TotalCycles += 2; PC = 0xEC72;
                    goto case 0xEC72;
                case 0xEC72:
                    A &= 0xC0; SetZN(A); TotalCycles += 2; PC = 0xEC74;
                    goto case 0xEC74;
                case 0xEC73:
                    Cmp(Y, 0x05); TotalCycles += 2; PC = 0xEC75;
                    goto case 0xEC75;
                case 0xEC74:
                    A |= _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xEC76;
                    goto case 0xEC76;
                case 0xEC75:
                    TotalCycles += 7; PushU16(0xEC77); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEC76:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEC77;
                    goto case 0xEC77;
                case 0xEC77:
                    TotalCycles += 6; PushU16(0xEC79); PC = 0xE5BB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5BB;
                case 0xEC79:
                    Sbc(_ram[0x88]); TotalCycles += 3; PC = 0xEC7B;
                    goto case 0xEC7B;
                case 0xEC7A:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xEC7B;
                    goto case 0xEC7B;
                case 0xEC7B:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xEC7C;
                    goto case 0xEC7C;
                case 0xEC7C:
                    A = _ram[0x03BC]; SetZN(A); TotalCycles += 4; PC = 0xEC7F;
                    goto case 0xEC7F;
                case 0xEC7D:
                    Y = ReadMem(0x2003 + X); SetZN(Y); TotalCycles += 4; PC = 0xEC80;
                    goto case 0xEC80;
                case 0xEC7F:
                    TotalCycles += 6; PushU16(0xEC81); PC = 0xE5C1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5C1;
                case 0xEC80:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xE5 + X)))); TotalCycles += 6; PC = 0xEC82;
                    goto case 0xEC82;
                case 0xEC81:
                    Sbc(_ram[0xAD]); TotalCycles += 3; PC = 0xEC83;
                    goto case 0xEC83;
                case 0xEC82:
                    A = _ram[0x03B1]; SetZN(A); TotalCycles += 4; PC = 0xEC85;
                    goto case 0xEC85;
                case 0xEC83:
                    A = ReadMem(ReadU16Zp(0x03) + Y); SetZN(A); TotalCycles += 5; PC = 0xEC85;
                    goto case 0xEC85;
                case 0xEC85:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC88;
                    goto case 0xEC88;
                case 0xEC88:
                    A = _ram[(0x03F1 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEC8B;
                    goto case 0xEC8B;
                case 0xEC89:
                    Sbc(ReadMem(ReadU16Zp(0x03) + Y)); TotalCycles += 5; PC = 0xEC8B;
                    goto case 0xEC8B;
                case 0xEC8B:
                    P |= FlagC; TotalCycles += 2; PC = 0xEC8C;
                    goto case 0xEC8C;
                case 0xEC8C:
                    Sbc(_ram[0x071C]); TotalCycles += 4; PC = 0xEC8F;
                    goto case 0xEC8F;
                case 0xEC8F:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xEC91;
                    goto case 0xEC91;
                case 0xEC90:
                    TotalCycles += 7; PushU16(0xEC92); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEC91:
                    P |= FlagC; TotalCycles += 2; PC = 0xEC92;
                    goto case 0xEC92;
                case 0xEC92:
                    Sbc(_ram[0x03B1]); TotalCycles += 4; PC = 0xEC95;
                    goto case 0xEC95;
                case 0xEC93:
                    A = ReadMem(ReadU16Zp(0x03) + Y); SetZN(A); TotalCycles += 5; PC = 0xEC95;
                    goto case 0xEC95;
                case 0xEC95:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0xEC97;
                    goto case 0xEC97;
                case 0xEC96:
                    TotalCycles += 7; PushU16(0xEC98); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEC97:
                    Adc(0x06); TotalCycles += 2; PC = 0xEC99;
                    goto case 0xEC99;
                case 0xEC98:
                    _ram[0x99] = Asl(_ram[0x99]); TotalCycles += 5; PC = 0xEC9A;
                    return;
                case 0xEC99:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEC9C;
                    goto case 0xEC9C;
                case 0xEC9C:
                    A = _ram[0x03BD]; SetZN(A); TotalCycles += 4; PC = 0xEC9F;
                    goto case 0xEC9F;
                case 0xEC9D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1903 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xECA0;
                    goto case 0xECA0;
                case 0xEC9F:
                    _ram[(0x0208 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xECA2;
                    goto case 0xECA2;
                case 0xECA0:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xECA1;
                    return;
                case 0xECA2:
                    _ram[(0x020C + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xECA5;
                    goto case 0xECA5;
                case 0xECA5:
                    A = _ram[0x03B2]; SetZN(A); TotalCycles += 4; PC = 0xECA8;
                    goto case 0xECA8;
                case 0xECA8:
                    _ram[(0x020B + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xECAB;
                    goto case 0xECAB;
                case 0xECAB:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xECAD;
                    goto case 0xECAD;
                case 0xECAC:
                    TotalCycles += 7; PushU16(0xECAE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xECAD:
                    P |= FlagC; TotalCycles += 2; PC = 0xECAE;
                    goto case 0xECAE;
                case 0xECAE:
                    Sbc(_ram[0x03B2]); TotalCycles += 4; PC = 0xECB1;
                    goto case 0xECB1;
                case 0xECB1:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0xECB3;
                    goto case 0xECB3;
                case 0xECB2:
                    TotalCycles += 7; PushU16(0xECB4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xECB3:
                    Adc(0x06); TotalCycles += 2; PC = 0xECB5;
                    goto case 0xECB5;
                case 0xECB4:
                    _ram[0x99] = Asl(_ram[0x99]); TotalCycles += 5; PC = 0xECB6;
                    return;
                case 0xECB5:
                    _ram[(0x020F + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xECB8;
                    goto case 0xECB8;
                case 0xECB8:
                    A = _ram[0x03D4]; SetZN(A); TotalCycles += 4; PC = 0xECBB;
                    goto case 0xECBB;
                case 0xECBB:
                    TotalCycles += 6; PushU16(0xECBD); PC = 0xEC46;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEC46;
                case 0xECBC:
                    _ram[0xEC] = Lsr(_ram[0xEC]); TotalCycles += 5; PC = 0xECBE;
                    goto case 0xECBE;
                case 0xECBD:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x54AD]); TotalCycles += 4; PC = 0xECC0;
                    return;
                case 0xECBE:
                    A = _ram[0x03D4]; SetZN(A); TotalCycles += 4; PC = 0xECC1;
                    goto case 0xECC1;
                case 0xECC1:
                    A = Asl(A); TotalCycles += 2; PC = 0xECC2;
                    goto case 0xECC2;
                case 0xECC2:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xECC9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xECC9; }
                    PC = 0xECC4; goto case 0xECC4;
                case 0xECC3:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xECC5;
                    goto case 0xECC5;
                case 0xECC4:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xECC6;
                    goto case 0xECC6;
                case 0xECC5:
                    P |= FlagD; TotalCycles += 2; PC = 0xECC6;
                    goto case 0xECC6;
                case 0xECC6:
                    TotalCycles += 6; PushU16(0xECC8); PC = 0xE5C1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5C1;
                case 0xECC7:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xE5 + X)))); TotalCycles += 6; PC = 0xECC9;
                    goto case 0xECC9;
                case 0xECC8:
                    Sbc(_ram[0xA5]); TotalCycles += 3; PC = 0xECCA;
                    goto case 0xECCA;
                case 0xECC9:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xECCB;
                    goto case 0xECCB;
                case 0xECCA:
                    TotalCycles += 7; PushU16(0xECCC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xECCB:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xECDD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xECDD; }
                    PC = 0xECCD; goto case 0xECCD;
                case 0xECCC:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEC87; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xECCE; return;
                case 0xECCD:
                    A = _ram[(0x0203 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xECD0;
                    goto case 0xECD0;
                case 0xECD0:
                    Cmp(A, _ram[(0x0207 + Y) & 0x07FF]); TotalCycles += 4; PC = 0xECD3;
                    goto case 0xECD3;
                case 0xECD3:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xECDD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xECDD; }
                    PC = 0xECD5; goto case 0xECD5;
                case 0xECD4:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xECD5;
                    goto case 0xECD5;
                case 0xECD5:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xECD7;
                    goto case 0xECD7;
                case 0xECD6:
                    P |= FlagD; TotalCycles += 2; PC = 0xECD7;
                    goto case 0xECD7;
                case 0xECD7:
                    _ram[(0x0204 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xECDA;
                    goto case 0xECDA;
                case 0xECDA:
                    _ram[(0x020C + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xECDD;
                    goto case 0xECDD;
                case 0xECDD:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xECDE:
                    Y = _ram[(0x06F1 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xECE1;
                    goto case 0xECE1;
                case 0xECDF:
                    Sbc(ReadMem(ReadU16Zp(0x06) + Y)); TotalCycles += 5; PC = 0xECE1;
                    goto case 0xECE1;
                case 0xECE0:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xECE2;
                    goto case 0xECE2;
                case 0xECE1:
                    A = _ram[0x03BA]; SetZN(A); TotalCycles += 4; PC = 0xECE4;
                    goto case 0xECE4;
                case 0xECE2:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xECE3;
                    return;
                case 0xECE4:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xECE7;
                    goto case 0xECE7;
                case 0xECE5:
                    TotalCycles += 7; PushU16(0xECE7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xECE7:
                    A = _ram[0x03AF]; SetZN(A); TotalCycles += 4; PC = 0xECEA;
                    goto case 0xECEA;
                case 0xECEA:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xECED;
                    goto case 0xECED;
                case 0xECED: // === SUBROUTINE: Sub_ECED ===
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xECEF;
                    goto case 0xECEF;
                case 0xECEE:
                    A |= 0x4A; SetZN(A); TotalCycles += 2; PC = 0xECF0;
                    goto case 0xECF0;
                case 0xECEF:
                    A = Lsr(A); TotalCycles += 2; PC = 0xECF0;
                    goto case 0xECF0;
                case 0xECF0:
                    A = Lsr(A); TotalCycles += 2; PC = 0xECF1;
                    goto case 0xECF1;
                case 0xECF1:
                    PushU8(A); TotalCycles += 3; PC = 0xECF2;
                    goto case 0xECF2;
                case 0xECF2:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0xECF4;
                    goto case 0xECF4;
                case 0xECF3:
                    A |= ReadMem(ReadU16Zp((byte)(0x49 + X))); SetZN(A); TotalCycles += 6; PC = 0xECF5;
                    return;
                case 0xECF4:
                    A ^= 0x64; SetZN(A); TotalCycles += 2; PC = 0xECF6;
                    goto case 0xECF6;
                case 0xECF6:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xECF9;
                    goto case 0xECF9;
                case 0xECF7:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xECF9;
                    goto case 0xECF9;
                case 0xECF9:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xECFA;
                    goto case 0xECFA;
                case 0xECFA:
                    A = Lsr(A); TotalCycles += 2; PC = 0xECFB;
                    goto case 0xECFB;
                case 0xECFB:
                    A = Lsr(A); TotalCycles += 2; PC = 0xECFC;
                    goto case 0xECFC;
                case 0xECFC:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xECFE;
                    goto case 0xECFE;
                case 0xECFE:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xED02; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xED02; }
                    PC = 0xED00; goto case 0xED00;
                case 0xED00:
                    A |= 0xC0; SetZN(A); TotalCycles += 2; PC = 0xED02;
                    goto case 0xED02;
                case 0xED01:
                    Cmp(Y, 0x99); TotalCycles += 2; PC = 0xED03;
                    return;
                case 0xED02:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED05;
                    goto case 0xED05;
                case 0xED05:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xED06:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xED07;
                    return;
                case 0xED08:
                    _ram[0xBC] = Ror(_ram[0xBC]); TotalCycles += 5; PC = 0xED0A;
                    goto case 0xED0A;
                case 0xED09:
                    Y = _ram[(0x06EC + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xED0C;
                    goto case 0xED0C;
                case 0xED0A:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x3506]); TotalCycles += 4; PC = 0xED0D;
                    goto case 0xED0D;
                case 0xED0B:
                    _ram[0xB5] = Asl(_ram[0xB5]); TotalCycles += 5; PC = 0xED0D;
                    goto case 0xED0D;
                case 0xED0C:
                    A = _ram[(byte)(0x24 + X)]; SetZN(A); TotalCycles += 4; PC = 0xED0E;
                    goto case 0xED0E;
                case 0xED0D:
                    Bit(_ram[0xF6]); TotalCycles += 3; PC = 0xED0F;
                    goto case 0xED0F;
                case 0xED0E:
                    { byte z = (byte)(0x24 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xED10;
                    goto case 0xED10;
                case 0xED0F:
                    Bit(_ram[0x4A]); TotalCycles += 3; PC = 0xED11;
                    goto case 0xED11;
                case 0xED10:
                    A = Lsr(A); TotalCycles += 2; PC = 0xED11;
                    goto case 0xED11;
                case 0xED11:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0xED13;
                    goto case 0xED13;
                case 0xED13:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xED15;
                    goto case 0xED15;
                case 0xED15:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xED61; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xED61; }
                    PC = 0xED17; goto case 0xED17;
                case 0xED16:
                    A = Lsr(A); TotalCycles += 2; PC = 0xED17;
                    goto case 0xED17;
                case 0xED17: // === SUBROUTINE: Sub_ED17 ===
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xED18;
                    goto case 0xED18;
                case 0xED18:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6D06 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xED1B;
                    goto case 0xED1B;
                case 0xED19:
                    _ram[0xED] = Asl(_ram[0xED]); TotalCycles += 5; PC = 0xED1B;
                    goto case 0xED1B;
                case 0xED1A:
                    Sbc(ReadIoReg(0x20C8)); TotalCycles += 4; PC = 0xED1D;
                    return;
                case 0xED1B:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xED1C;
                    goto case 0xED1C;
                case 0xED1C:
                    TotalCycles += 6; PushU16(0xED1E); PC = 0xE5BB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5BB;
                case 0xED1E:
                    Sbc(_ram[0x88]); TotalCycles += 3; PC = 0xED20;
                    goto case 0xED20;
                case 0xED1F:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xED20;
                    goto case 0xED20;
                case 0xED20:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xED22;
                    goto case 0xED22;
                case 0xED21:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xED22;
                    goto case 0xED22;
                case 0xED22:
                    A = _ram[0x03BA]; SetZN(A); TotalCycles += 4; PC = 0xED25;
                    goto case 0xED25;
                case 0xED23:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xED24;
                    return;
                case 0xED25:
                    P |= FlagC; TotalCycles += 2; PC = 0xED26;
                    goto case 0xED26;
                case 0xED26:
                    Sbc(0x04); TotalCycles += 2; PC = 0xED28;
                    goto case 0xED28;
                case 0xED28:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED2B;
                    goto case 0xED2B;
                case 0xED29:
                    TotalCycles += 7; PushU16(0xED2B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xED2B:
                    _ram[(0x0208 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED2E;
                    goto case 0xED2E;
                case 0xED2C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xED2D;
                    return;
                case 0xED2E:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xED2F;
                    goto case 0xED2F;
                case 0xED2F:
                    Adc(0x08); TotalCycles += 2; PC = 0xED31;
                    goto case 0xED31;
                case 0xED30:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xED31;
                    goto case 0xED31;
                case 0xED31:
                    _ram[(0x0204 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED34;
                    goto case 0xED34;
                case 0xED34:
                    _ram[(0x020C + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED37;
                    goto case 0xED37;
                case 0xED37:
                    A = _ram[0x03AF]; SetZN(A); TotalCycles += 4; PC = 0xED3A;
                    goto case 0xED3A;
                case 0xED3A:
                    P |= FlagC; TotalCycles += 2; PC = 0xED3B;
                    goto case 0xED3B;
                case 0xED3B:
                    Sbc(0x04); TotalCycles += 2; PC = 0xED3D;
                    goto case 0xED3D;
                case 0xED3D:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED40;
                    goto case 0xED40;
                case 0xED40:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED43;
                    goto case 0xED43;
                case 0xED43:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xED44;
                    goto case 0xED44;
                case 0xED44:
                    Adc(0x08); TotalCycles += 2; PC = 0xED46;
                    goto case 0xED46;
                case 0xED45:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xED46;
                    goto case 0xED46;
                case 0xED46:
                    _ram[(0x020B + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED49;
                    goto case 0xED49;
                case 0xED49:
                    _ram[(0x020F + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED4C;
                    goto case 0xED4C;
                case 0xED4C:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xED4E;
                    goto case 0xED4E;
                case 0xED4E:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED51;
                    goto case 0xED51;
                case 0xED51:
                    A = 0x82; SetZN(A); TotalCycles += 2; PC = 0xED53;
                    goto case 0xED53;
                case 0xED53:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED56;
                    goto case 0xED56;
                case 0xED54:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xED56;
                    goto case 0xED56;
                case 0xED56:
                    A = 0x42; SetZN(A); TotalCycles += 2; PC = 0xED58;
                    goto case 0xED58;
                case 0xED58:
                    _ram[(0x020A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED5B;
                    goto case 0xED5B;
                case 0xED59:
                    A = Asl(A); TotalCycles += 2; PC = 0xED5A;
                    return;
                case 0xED5B:
                    A = 0xC2; SetZN(A); TotalCycles += 2; PC = 0xED5D;
                    goto case 0xED5D;
                case 0xED5D:
                    _ram[(0x020E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED60;
                    goto case 0xED60;
                case 0xED5E:
                    { int a = 0x6002; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xED61;
                    goto case 0xED61;
                case 0xED60:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xED61:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xED63;
                    goto case 0xED63;
                case 0xED62:
                    TotalCycles += 7; PushU16(0xED64); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xED63:
                    _ram[(byte)(0x24 + X)] = A; TotalCycles += 4; PC = 0xED65;
                    goto case 0xED65;
                case 0xED64:
                    Bit(_ram[0x60]); TotalCycles += 3; PC = 0xED66;
                    goto case 0xED66;
                case 0xED65:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xED66: // === SUBROUTINE: Sub_ED66 ===
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xED69;
                    goto case 0xED69;
                case 0xED67:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xED69;
                    goto case 0xED69;
                case 0xED68:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xED6A;
                    return;
                case 0xED69:
                    A = 0x5B; SetZN(A); TotalCycles += 2; PC = 0xED6B;
                    goto case 0xED6B;
                case 0xED6B:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xED6C;
                    goto case 0xED6C;
                case 0xED6C:
                    TotalCycles += 6; PushU16(0xED6E); PC = 0xE5B5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5B5;
                case 0xED6D:
                    A = _ram[(byte)(0xE5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xED6F;
                    goto case 0xED6F;
                case 0xED6E:
                    Sbc(_ram[0xC8]); TotalCycles += 3; PC = 0xED70;
                    goto case 0xED70;
                case 0xED6F:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xED70;
                    goto case 0xED70;
                case 0xED70:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xED72;
                    goto case 0xED72;
                case 0xED72:
                    TotalCycles += 6; PushU16(0xED74); PC = 0xE5B5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5B5;
                case 0xED73:
                    A = _ram[(byte)(0xE5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xED75;
                    goto case 0xED75;
                case 0xED74:
                    Sbc(_ram[0x88]); TotalCycles += 3; PC = 0xED76;
                    goto case 0xED76;
                case 0xED75:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xED76;
                    goto case 0xED76;
                case 0xED76:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xED77;
                    goto case 0xED77;
                case 0xED77:
                    A = _ram[0x03AE]; SetZN(A); TotalCycles += 4; PC = 0xED7A;
                    goto case 0xED7A;
                case 0xED78:
                    X = SmbEmbeddedAssets.StaticDataTables[0x1903]; SetZN(X); TotalCycles += 4; PC = 0xED7B;
                    return;
                case 0xED7A:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED7D;
                    goto case 0xED7D;
                case 0xED7D:
                    _ram[(0x020F + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED80;
                    goto case 0xED80;
                case 0xED80:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xED81;
                    goto case 0xED81;
                case 0xED81:
                    Adc(0x08); TotalCycles += 2; PC = 0xED83;
                    goto case 0xED83;
                case 0xED82:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xED83;
                    goto case 0xED83;
                case 0xED83:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED86;
                    goto case 0xED86;
                case 0xED86:
                    _ram[(0x0213 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED89;
                    goto case 0xED89;
                case 0xED89:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xED8A;
                    goto case 0xED8A;
                case 0xED8A:
                    Adc(0x08); TotalCycles += 2; PC = 0xED8C;
                    goto case 0xED8C;
                case 0xED8B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xED8C;
                    goto case 0xED8C;
                case 0xED8C:
                    _ram[(0x020B + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED8F;
                    goto case 0xED8F;
                case 0xED8F:
                    _ram[(0x0217 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xED92;
                    goto case 0xED92;
                case 0xED92:
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xED94;
                    goto case 0xED94;
                case 0xED94:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xED95;
                    goto case 0xED95;
                case 0xED95:
                    PushU8(A); TotalCycles += 3; PC = 0xED96;
                    goto case 0xED96;
                case 0xED96:
                    Cmp(X, 0x20); TotalCycles += 2; PC = 0xED98;
                    goto case 0xED98;
                case 0xED97:
                    TotalCycles += 6; PushU16(0xED99); PC = 0x02B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xED98:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xED9C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xED9C; }
                    PC = 0xED9A; goto case 0xED9A;
                case 0xED9A:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xED9C;
                    goto case 0xED9C;
                case 0xED9B:
                    P |= FlagD; TotalCycles += 2; PC = 0xED9C;
                    goto case 0xED9C;
                case 0xED9C:
                    TotalCycles += 6; PushU16(0xED9E); PC = 0xE5BE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5BE;
                case 0xED9D:
                    X = ReadMem(0x68E5 + Y); SetZN(X); TotalCycles += 4; PC = 0xEDA0;
                    goto case 0xEDA0;
                case 0xED9E:
                    Sbc(_ram[0x68]); TotalCycles += 3; PC = 0xEDA0;
                    goto case 0xEDA0;
                case 0xED9F:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEDA0;
                    goto case 0xEDA0;
                case 0xEDA0:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEDA1;
                    goto case 0xEDA1;
                case 0xEDA1:
                    Adc(0x80); TotalCycles += 2; PC = 0xEDA3;
                    goto case 0xEDA3;
                case 0xEDA3:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xEDA4;
                    goto case 0xEDA4;
                case 0xEDA4:
                    Cmp(X, 0x20); TotalCycles += 2; PC = 0xEDA6;
                    goto case 0xEDA6;
                case 0xEDA5:
                    TotalCycles += 6; PushU16(0xEDA7); PC = 0x02B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xEDA6:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEDAA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEDAA; }
                    PC = 0xEDA8; goto case 0xEDA8;
                case 0xEDA8:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xEDAA;
                    goto case 0xEDAA;
                case 0xEDA9:
                    P |= FlagD; TotalCycles += 2; PC = 0xEDAA;
                    goto case 0xEDAA;
                case 0xEDAA:
                    _ram[(0x020C + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDAD;
                    goto case 0xEDAD;
                case 0xEDAD:
                    _ram[(0x0210 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDB0;
                    goto case 0xEDB0;
                case 0xEDAE:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEDB2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xEDB0; goto case 0xEDB0;
                case 0xEDB0:
                    _ram[(0x0214 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDB3;
                    goto case 0xEDB3;
                case 0xEDB3:
                    A = _ram[0x03D1]; SetZN(A); TotalCycles += 4; PC = 0xEDB6;
                    goto case 0xEDB6;
                case 0xEDB4:
                    Cmp(A, ReadMem(ReadU16Zp(0x03) + Y)); TotalCycles += 5; PC = 0xEDB6;
                    goto case 0xEDB6;
                case 0xEDB6:
                    PushU8(A); TotalCycles += 3; PC = 0xEDB7;
                    goto case 0xEDB7;
                case 0xEDB7:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xEDB9;
                    goto case 0xEDB9;
                case 0xEDB8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEDB9;
                    goto case 0xEDB9;
                case 0xEDB9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEDC3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEDC3; }
                    PC = 0xEDBB; goto case 0xEDBB;
                case 0xEDBA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEDBB;
                    goto case 0xEDBB;
                case 0xEDBB:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xEDBD;
                    goto case 0xEDBD;
                case 0xEDBC:
                    P |= FlagD; TotalCycles += 2; PC = 0xEDBD;
                    goto case 0xEDBD;
                case 0xEDBD:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDC0;
                    goto case 0xEDC0;
                case 0xEDBE:
                    TotalCycles += 7; PushU16(0xEDC0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEDC0:
                    _ram[(0x020C + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDC3;
                    goto case 0xEDC3;
                case 0xEDC3:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEDC4;
                    goto case 0xEDC4;
                case 0xEDC4:
                    PushU8(A); TotalCycles += 3; PC = 0xEDC5;
                    goto case 0xEDC5;
                case 0xEDC5:
                    A &= 0x04; SetZN(A); TotalCycles += 2; PC = 0xEDC7;
                    goto case 0xEDC7;
                case 0xEDC7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEDD1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEDD1; }
                    PC = 0xEDC9; goto case 0xEDC9;
                case 0xEDC8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEDC9;
                    goto case 0xEDC9;
                case 0xEDC9:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xEDCB;
                    goto case 0xEDCB;
                case 0xEDCA:
                    P |= FlagD; TotalCycles += 2; PC = 0xEDCB;
                    goto case 0xEDCB;
                case 0xEDCB:
                    _ram[(0x0204 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDCE;
                    goto case 0xEDCE;
                case 0xEDCE:
                    _ram[(0x0210 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDD1;
                    goto case 0xEDD1;
                case 0xEDCF:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEDD3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xEDD1; goto case 0xEDD1;
                case 0xEDD1:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xEDD2;
                    goto case 0xEDD2;
                case 0xEDD2:
                    A &= 0x02; SetZN(A); TotalCycles += 2; PC = 0xEDD4;
                    goto case 0xEDD4;
                case 0xEDD4:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEDDE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEDDE; }
                    PC = 0xEDD6; goto case 0xEDD6;
                case 0xEDD5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEDD6;
                    goto case 0xEDD6;
                case 0xEDD6:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xEDD8;
                    goto case 0xEDD8;
                case 0xEDD7:
                    P |= FlagD; TotalCycles += 2; PC = 0xEDD8;
                    goto case 0xEDD8;
                case 0xEDD8:
                    _ram[(0x0208 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDDB;
                    goto case 0xEDDB;
                case 0xEDD9:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEDDA;
                    return;
                case 0xEDDB:
                    _ram[(0x0214 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDDE;
                    goto case 0xEDDE;
                case 0xEDDE:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xEDE0;
                    goto case 0xEDE0;
                case 0xEDDF:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEDE0;
                    goto case 0xEDE0;
                case 0xEDE0:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEDE1: // === SUBROUTINE: Sub_EDE1 ===
                    Y = _ram[0xB5]; SetZN(Y); TotalCycles += 3; PC = 0xEDE3;
                    goto case 0xEDE3;
                case 0xEDE2:
                    A = _ram[(byte)(0x88 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEDE4;
                    goto case 0xEDE4;
                case 0xEDE3:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xEDE4;
                    goto case 0xEDE4;
                case 0xEDE4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEE06; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEE06; }
                    PC = 0xEDE6; goto case 0xEDE6;
                case 0xEDE5:
                    TotalCycles += 6; PushU16(0xEDE7); PC = 0xD3AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xEDE6:
                    A = _ram[0x03D3]; SetZN(A); TotalCycles += 4; PC = 0xEDE9;
                    goto case 0xEDE9;
                case 0xEDE9:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xEDEB;
                    goto case 0xEDEB;
                case 0xEDEA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEDEB;
                    goto case 0xEDEB;
                case 0xEDEB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEE06; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEE06; }
                    PC = 0xEDED; goto case 0xEDED;
                case 0xEDEC:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x6EBC + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEDEF;
                    goto case 0xEDEF;
                case 0xEDED:
                    Y = _ram[(0x06EE + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xEDF0;
                    goto case 0xEDF0;
                case 0xEDEE:
                    { int a = 0xAD06; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xEDF1;
                    goto case 0xEDF1;
                case 0xEDEF:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xEDF1;
                    goto case 0xEDF1;
                case 0xEDF0:
                    A = _ram[0x03B0]; SetZN(A); TotalCycles += 4; PC = 0xEDF3;
                    goto case 0xEDF3;
                case 0xEDF1:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEDF6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEDF6; }
                    PC = 0xEDF3; goto case 0xEDF3;
                case 0xEDF3:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDF6;
                    goto case 0xEDF6;
                case 0xEDF6:
                    A = _ram[0x03BB]; SetZN(A); TotalCycles += 4; PC = 0xEDF9;
                    goto case 0xEDF9;
                case 0xEDF9:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEDFC;
                    goto case 0xEDFC;
                case 0xEDFA:
                    TotalCycles += 7; PushU16(0xEDFC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEDFC:
                    A = 0x74; SetZN(A); TotalCycles += 2; PC = 0xEDFE;
                    goto case 0xEDFE;
                case 0xEDFE:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEE01;
                    goto case 0xEE01;
                case 0xEDFF:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xEE01;
                    goto case 0xEE01;
                case 0xEE01:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xEE03;
                    goto case 0xEE03;
                case 0xEE03:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEE06;
                    goto case 0xEE06;
                case 0xEE06:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEE07:
                    TotalCycles += 6; PushU16(0xEE09); PC = 0xC828;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xEE08:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xEE09;
                    goto case 0xEE09;
                case 0xEE09:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEE0A;
                    goto case 0xEE0A;
                case 0xEE0A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEE0B;
                    goto case 0xEE0B;
                case 0xEE0B:
                    TotalCycles += 7; PushU16(0xEE0D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEE0C:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xEE0D:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xEE67; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xEE0F; return;
                case 0xEE0E:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xEE0F;
                    return;
                case 0xEE10:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xEE11;
                    goto case 0xEE11;
                case 0xEE11:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xEE12;
                    goto case 0xEE12;
                case 0xEE12:
                    P |= FlagI; TotalCycles += 2; PC = 0xEE13;
                    goto case 0xEE13;
                case 0xEE13:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEE14:
                    Y = 0xB0; SetZN(Y); TotalCycles += 2; PC = 0xEE16;
                    goto case 0xEE16;
                case 0xEE15:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEDCF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEDCF; }
                    PC = 0xEE17; goto case 0xEE17;
                case 0xEE16:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xEE17;
                    goto case 0xEE17;
                case 0xEE17:
                    TotalCycles += 7; PushU16(0xEE19); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEE18:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xEE1A;
                    return;
                case 0xEE1C:
                    A |= _ram[0x06]; SetZN(A); TotalCycles += 3; PC = 0xEE1E;
                    return;
                case 0xEE1D:
                    _ram[0x07] = Asl(_ram[0x07]); TotalCycles += 5; PC = 0xEE1F;
                    goto case 0xEE1F;
                case 0xEE1F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEE20;
                    goto case 0xEE20;
                case 0xEE20:
                    A |= 0x0A; SetZN(A); TotalCycles += 2; PC = 0xEE22;
                    return;
                case 0xEE21:
                    A = Asl(A); TotalCycles += 2; PC = 0xEE22;
                    return;
                case 0xEE24:
                    A |= _ram[0x070E]; SetZN(A); TotalCycles += 4; PC = 0xEE27;
                    goto case 0xEE27;
                case 0xEE25:
                    _ram[0x000F] = Asl(_ram[0x000F]); TotalCycles += 6; PC = 0xEE28;
                    goto case 0xEE28;
                case 0xEE27:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEE3A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xEE29; return;
                case 0xEE28:
                    A |= ReadMem(ReadU16Zp(0x12) + Y); SetZN(A); TotalCycles += 5; PC = 0xEE2A;
                    return;
                case 0xEE2C:
                    A |= _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEE2E;
                    return;
                case 0xEE2D:
                    { byte z = (byte)(0x17 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xEE2F;
                    goto case 0xEE2F;
                case 0xEE2F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEE30;
                    goto case 0xEE30;
                case 0xEE30:
                    A |= ReadMem(0x1B1A + Y); SetZN(A); TotalCycles += 4; PC = 0xEE33;
                    return;
                case 0xEE34:
                    A |= ReadMem(0x1F1E + X); SetZN(A); TotalCycles += 4; PC = 0xEE37;
                    goto case 0xEE37;
                case 0xEE35:
                    { int a = 0x201F + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xEE38;
                    goto case 0xEE38;
                case 0xEE37:
                    TotalCycles += 6; PushU16(0xEE39); PC = 0x2221;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xEE38:
                    A &= ReadMem(ReadU16Zp((byte)(0x22 + X))); SetZN(A); TotalCycles += 6; PC = 0xEE3A;
                    return;
                case 0xEE3B:
                    Bit(_ram[0x25]); TotalCycles += 3; PC = 0xEE3D;
                    goto case 0xEE3D;
                case 0xEE3C:
                    A &= _ram[0x26]; SetZN(A); TotalCycles += 3; PC = 0xEE3E;
                    return;
                case 0xEE3D:
                    _ram[0x27] = Rol(_ram[0x27]); TotalCycles += 5; PC = 0xEE3F;
                    goto case 0xEE3F;
                case 0xEE3F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEE40;
                    goto case 0xEE40;
                case 0xEE40:
                    A |= 0x28; SetZN(A); TotalCycles += 2; PC = 0xEE42;
                    goto case 0xEE42;
                case 0xEE41:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xEE42;
                    goto case 0xEE42;
                case 0xEE42:
                    A &= 0x2A; SetZN(A); TotalCycles += 2; PC = 0xEE44;
                    return;
                case 0xEE43:
                    A = Rol(A); TotalCycles += 2; PC = 0xEE44;
                    return;
                case 0xEE45:
                    Bit(_ram[0x002D]); TotalCycles += 4; PC = 0xEE48;
                    goto case 0xEE48;
                case 0xEE46:
                    A &= _ram[0x0108]; SetZN(A); TotalCycles += 4; PC = 0xEE49;
                    goto case 0xEE49;
                case 0xEE47:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEE48;
                    goto case 0xEE48;
                case 0xEE48:
                    A |= 0x0A; SetZN(A); TotalCycles += 2; PC = 0xEE4A;
                    return;
                case 0xEE49:
                    A = Asl(A); TotalCycles += 2; PC = 0xEE4A;
                    return;
                case 0xEE4C:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xEE7A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xEE4E; goto case 0xEE4E;
                case 0xEE4D:
                    Bit(_ram[0x002D]); TotalCycles += 4; PC = 0xEE50;
                    goto case 0xEE50;
                case 0xEE4E:
                    A &= _ram[0x0108]; SetZN(A); TotalCycles += 4; PC = 0xEE51;
                    goto case 0xEE51;
                case 0xEE4F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEE50;
                    goto case 0xEE50;
                case 0xEE50:
                    A |= 0x0A; SetZN(A); TotalCycles += 2; PC = 0xEE52;
                    return;
                case 0xEE51:
                    A = Asl(A); TotalCycles += 2; PC = 0xEE52;
                    return;
                case 0xEE53:
                    { int a = 0x2C2F; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xEE56;
                    goto case 0xEE56;
                case 0xEE55:
                    Bit(_ram[0x002D]); TotalCycles += 4; PC = 0xEE58;
                    goto case 0xEE58;
                case 0xEE56:
                    A &= _ram[0x0108]; SetZN(A); TotalCycles += 4; PC = 0xEE59;
                    goto case 0xEE59;
                case 0xEE57:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEE58;
                    goto case 0xEE58;
                case 0xEE58:
                    A |= 0x28; SetZN(A); TotalCycles += 2; PC = 0xEE5A;
                    goto case 0xEE5A;
                case 0xEE59:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xEE5A;
                    goto case 0xEE5A;
                case 0xEE5A:
                    A &= 0x2A; SetZN(A); TotalCycles += 2; PC = 0xEE5C;
                    return;
                case 0xEE5B:
                    A = Rol(A); TotalCycles += 2; PC = 0xEE5C;
                    return;
                case 0xEE5E:
                    A ^= ReadMem(0x0908 + X); SetZN(A); TotalCycles += 4; PC = 0xEE61;
                    goto case 0xEE61;
                case 0xEE5F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEE60;
                    goto case 0xEE60;
                case 0xEE60:
                    A |= 0x0A; SetZN(A); TotalCycles += 2; PC = 0xEE62;
                    return;
                case 0xEE61:
                    A = Asl(A); TotalCycles += 2; PC = 0xEE62;
                    return;
                case 0xEE64:
                    A |= ReadIoReg(0x5F5E); SetZN(A); TotalCycles += 4; PC = 0xEE67;
                    return;
                case 0xEE65:
                    { int a = 0xFC5F + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xEE68;
                    return;
                case 0xEE69:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEE6A;
                    goto case 0xEE6A;
                case 0xEE6A:
                    A |= 0x58; SetZN(A); TotalCycles += 2; PC = 0xEE6C;
                    goto case 0xEE6C;
                case 0xEE6B:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xEE6C;
                    goto case 0xEE6C;
                case 0xEE6C:
                    A ^= ReadMem(0x5A5A + Y); SetZN(A); TotalCycles += 4; PC = 0xEE6F;
                    goto case 0xEE6F;
                case 0xEE6F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEE70;
                    goto case 0xEE70;
                case 0xEE70:
                    A |= 0x28; SetZN(A); TotalCycles += 2; PC = 0xEE72;
                    goto case 0xEE72;
                case 0xEE71:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xEE72;
                    goto case 0xEE72;
                case 0xEE72:
                    A &= 0x2A; SetZN(A); TotalCycles += 2; PC = 0xEE74;
                    return;
                case 0xEE73:
                    A = Rol(A); TotalCycles += 2; PC = 0xEE74;
                    return;
                case 0xEE75:
                    { int a = 0xFC0F; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xEE78;
                    return;
                case 0xEE7E:
                    A &= _ram[(byte)(0xFC + X)]; SetZN(A); TotalCycles += 4; PC = 0xEE80;
                    return;
                case 0xEE83:
                    { byte z = (byte)(0x37 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xEE85;
                    goto case 0xEE85;
                case 0xEE85:
                    P |= FlagC; TotalCycles += 2; PC = 0xEE86;
                    goto case 0xEE86;
                case 0xEE86:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x7CFC + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEE89;
                    return;
                case 0xEE93:
                    A &= ReadMem(0x3F3E + X); SetZN(A); TotalCycles += 4; PC = 0xEE96;
                    goto case 0xEE96;
                case 0xEE94:
                    { int a = 0x403F + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xEE97;
                    return;
                case 0xEE96:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xEE9C:
                    A ^= ReadMem(ReadU16Zp((byte)(0x42 + X))); SetZN(A); TotalCycles += 6; PC = 0xEE9E;
                    return;
                case 0xEEA6:
                    A ^= _ram[0xFC]; SetZN(A); TotalCycles += 3; PC = 0xEEA8;
                    return;
                case 0xEEB5:
                    PushU8(A); TotalCycles += 3; PC = 0xEEB6;
                    goto case 0xEEB6;
                case 0xEEB6:
                    A ^= 0xFC; SetZN(A); TotalCycles += 2; PC = 0xEEB8;
                    return;
                case 0xEEBD:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEE50; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEE50; }
                    PC = 0xEEBF; return;
                case 0xEEBE:
                    WriteMem(ReadU16Zp(0xFC) + Y, A); TotalCycles += 6; PC = 0xEEC0;
                    return;
                case 0xEED9:
                    TotalCycles += 7; PushU16(0xEEDB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEEDA:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xEEDC;
                    goto case 0xEEDC;
                case 0xEEDB:
                    TotalCycles += 3; PC = 0x4E4D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xEEDC:
                    A ^= ReadIoReg(0x4E4E); SetZN(A); TotalCycles += 4; PC = 0xEEDF;
                    goto case 0xEEDF;
                case 0xEEDD:
                    _ram[0x004E] = Lsr(_ram[0x004E]); TotalCycles += 6; PC = 0xEEE0;
                    goto case 0xEEE0;
                case 0xEEDE:
                    _ram[0x0100] = Lsr(_ram[0x0100]); TotalCycles += 6; PC = 0xEEE1;
                    goto case 0xEEE1;
                case 0xEEDF:
                    TotalCycles += 7; PushU16(0xEEE1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEEE0:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xEEE2;
                    goto case 0xEEE2;
                case 0xEEE1:
                    TotalCycles += 3; PC = 0x4A4D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xEEE2:
                    A ^= ReadIoReg(0x4A4A); SetZN(A); TotalCycles += 4; PC = 0xEEE5;
                    return;
                case 0xEEE3:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEEE4;
                    goto case 0xEEE4;
                case 0xEEE4:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEEE5;
                    return;
                case 0xEEE7:
                    A &= ReadMem(ReadU16Zp(0x46) + Y); SetZN(A); TotalCycles += 5; PC = 0xEEE9;
                    goto case 0xEEE9;
                case 0xEEE8:
                    _ram[0xAD] = Lsr(_ram[0xAD]); TotalCycles += 5; PC = 0xEEEA;
                    return;
                case 0xEEE9: // === SUBROUTINE: Sub_EEE9 ===
                    A = _ram[0x079E]; SetZN(A); TotalCycles += 4; PC = 0xEEEC;
                    goto case 0xEEEC;
                case 0xEEEC:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEEF3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEEF3; }
                    PC = 0xEEEE; goto case 0xEEEE;
                case 0xEEED:
                    A |= _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0xEEEF;
                    goto case 0xEEEF;
                case 0xEEEE:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xEEF0;
                    goto case 0xEEF0;
                case 0xEEEF:
                    A |= 0x4A; SetZN(A); TotalCycles += 2; PC = 0xEEF1;
                    goto case 0xEEF1;
                case 0xEEF0:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEEF1;
                    goto case 0xEEF1;
                case 0xEEF1:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEF33; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF33; }
                    PC = 0xEEF3; goto case 0xEEF3;
                case 0xEEF2:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xEEF3:
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0xEEF5;
                    goto case 0xEEF5;
                case 0xEEF4:
                    _ram[0x03C9] = Asl(_ram[0x03C9]); TotalCycles += 6; PC = 0xEEF7;
                    goto case 0xEEF7;
                case 0xEEF5:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0xEEF7;
                    goto case 0xEEF7;
                case 0xEEF7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEF40; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF40; }
                    PC = 0xEEF9; goto case 0xEEF9;
                case 0xEEF9:
                    A = _ram[0x070B]; SetZN(A); TotalCycles += 4; PC = 0xEEFC;
                    goto case 0xEEFC;
                case 0xEEFC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEF3A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF3A; }
                    PC = 0xEEFE; goto case 0xEEFE;
                case 0xEEFE:
                    Y = _ram[0x0704]; SetZN(Y); TotalCycles += 4; PC = 0xEF01;
                    goto case 0xEF01;
                case 0xEF01:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEF34; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF34; }
                    PC = 0xEF03; goto case 0xEF03;
                case 0xEF02:
                    A &= ReadMem(ReadU16Zp(0xA5) + Y); SetZN(A); TotalCycles += 5; PC = 0xEF04;
                    goto case 0xEF04;
                case 0xEF03:
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xEF05;
                    goto case 0xEF05;
                case 0xEF04:
                    A |= _ram[(0x00C9 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEF07;
                    goto case 0xEF07;
                case 0xEF05:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xEF07;
                    goto case 0xEF07;
                case 0xEF06:
                    TotalCycles += 7; PushU16(0xEF08); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEF07:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEF34; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF34; }
                    PC = 0xEF09; goto case 0xEF09;
                case 0xEF09:
                    TotalCycles += 6; PushU16(0xEF0B); PC = 0xEF34;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEF34;
                case 0xEF0C:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xEF0E;
                    goto case 0xEF0E;
                case 0xEF0D:
                    A |= 0x29; SetZN(A); TotalCycles += 2; PC = 0xEF0F;
                    return;
                case 0xEF0E:
                    A &= 0x04; SetZN(A); TotalCycles += 2; PC = 0xEF10;
                    goto case 0xEF10;
                case 0xEF10:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEF33; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF33; }
                    PC = 0xEF12; goto case 0xEF12;
                case 0xEF11:
                    A &= ReadMem(ReadU16Zp((byte)(0xAA + X))); SetZN(A); TotalCycles += 6; PC = 0xEF13;
                    goto case 0xEF13;
                case 0xEF12:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xEF13;
                    goto case 0xEF13;
                case 0xEF13:
                    Y = _ram[0x06E4]; SetZN(Y); TotalCycles += 4; PC = 0xEF16;
                    goto case 0xEF16;
                case 0xEF14:
                    Cmp(X, _ram[0x06]); TotalCycles += 3; PC = 0xEF16;
                    goto case 0xEF16;
                case 0xEF15:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xEF17;
                    return;
                case 0xEF16:
                    A = _ram[0x33]; SetZN(A); TotalCycles += 3; PC = 0xEF18;
                    goto case 0xEF18;
                case 0xEF18:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEF19;
                    goto case 0xEF19;
                case 0xEF19:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEF1F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF1F; }
                    PC = 0xEF1B; goto case 0xEF1B;
                case 0xEF1B:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEF1C;
                    goto case 0xEF1C;
                case 0xEF1C:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEF1D;
                    goto case 0xEF1D;
                case 0xEF1D:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEF1E;
                    goto case 0xEF1E;
                case 0xEF1E:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xEF1F;
                    goto case 0xEF1F;
                case 0xEF1F:
                    A = _ram[0x0754]; SetZN(A); TotalCycles += 4; PC = 0xEF22;
                    goto case 0xEF22;
                case 0xEF22:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEF2D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF2D; }
                    PC = 0xEF24; goto case 0xEF24;
                case 0xEF23:
                    A |= 0xB9; SetZN(A); TotalCycles += 2; PC = 0xEF25;
                    goto case 0xEF25;
                case 0xEF24:
                    A = _ram[(0x0219 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEF27;
                    goto case 0xEF27;
                case 0xEF25:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x4D02 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEF28;
                    goto case 0xEF28;
                case 0xEF27:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x6EB5]); TotalCycles += 4; PC = 0xEF2A;
                    goto case 0xEF2A;
                case 0xEF28:
                    A = _ram[(byte)(0xEE + X)]; SetZN(A); TotalCycles += 4; PC = 0xEF2A;
                    goto case 0xEF2A;
                case 0xEF29:
                    _ram[0x07F0] = IncVal(_ram[0x07F0]); TotalCycles += 6; PC = 0xEF2C;
                    goto case 0xEF2C;
                case 0xEF2A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEF33; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF33; }
                    PC = 0xEF2C; goto case 0xEF2C;
                case 0xEF2C:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xEF2D;
                    goto case 0xEF2D;
                case 0xEF2D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6EE7 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEF30;
                    goto case 0xEF30;
                case 0xEF2F:
                    _ram[0x0199] = IncVal(_ram[0x0199]); TotalCycles += 6; PC = 0xEF32;
                    return;
                case 0xEF30:
                    _ram[(0x0219 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xEF33;
                    goto case 0xEF33;
                case 0xEF31:
                    A |= ReadMem(0x6002 + Y); SetZN(A); TotalCycles += 4; PC = 0xEF34;
                    goto case 0xEF34;
                case 0xEF33:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEF34: // === SUBROUTINE: Sub_EF34 ===
                    TotalCycles += 6; PushU16(0xEF36); PC = 0xEFEC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEFEC;
                case 0xEF35:
                    Cmp(X, ReadIoReg(0x4CEF)); TotalCycles += 4; PC = 0xEF38;
                    goto case 0xEF38;
                case 0xEF37:
                    TotalCycles += 3; PC = 0xEF45;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEF45;
                case 0xEF38:
                    A ^= _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xEF3A;
                    goto case 0xEF3A;
                case 0xEF3A:
                    TotalCycles += 6; PushU16(0xEF3C); PC = 0xF0B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF0B0;
                case 0xEF3B:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEF2D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF2D; }
                    PC = 0xEF3D; goto case 0xEF3D;
                case 0xEF3C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEF8A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF8A; }
                    PC = 0xEF3E; goto case 0xEF3E;
                case 0xEF3D:
                    TotalCycles += 3; PC = 0xEF45;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEF45;
                case 0xEF3E:
                    A ^= _ram[0xEF]; SetZN(A); TotalCycles += 3; PC = 0xEF40;
                    goto case 0xEF40;
                case 0xEF40:
                    Y = 0x0E; SetZN(Y); TotalCycles += 2; PC = 0xEF42;
                    goto case 0xEF42;
                case 0xEF41:
                    _ram[0x07B9] = Asl(_ram[0x07B9]); TotalCycles += 6; PC = 0xEF44;
                    goto case 0xEF44;
                case 0xEF42:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6E07 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEF45;
                    goto case 0xEF45;
                case 0xEF44:
                    { int a = 0xD58D; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xEF47;
                    goto case 0xEF47;
                case 0xEF45:
                    _ram[0x06D5] = A; TotalCycles += 4; PC = 0xEF48;
                    goto case 0xEF48;
                case 0xEF46:
                    Cmp(A, _ram[(byte)(0x06 + X)]); TotalCycles += 4; PC = 0xEF48;
                    goto case 0xEF48;
                case 0xEF47:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xEF49;
                    return;
                case 0xEF48:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xEF4A;
                    goto case 0xEF4A;
                case 0xEF4A:
                    TotalCycles += 6; PushU16(0xEF4C); PC = 0xEFBE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEFBE;
                case 0xEF4B:
                    X = ReadMem(0x20EF + Y); SetZN(X); TotalCycles += 4; PC = 0xEF4E;
                    goto case 0xEF4E;
                case 0xEF4D:
                    TotalCycles += 6; PushU16(0xEF4F); PC = 0xF0E9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF0E9;
                case 0xEF4E:
                    Sbc(0xF0); TotalCycles += 2; PC = 0xEF50;
                    goto case 0xEF50;
                case 0xEF4F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEEFE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEEFE; }
                    PC = 0xEF51; goto case 0xEF51;
                case 0xEF50:
                    A = _ram[0x0711]; SetZN(A); TotalCycles += 4; PC = 0xEF53;
                    goto case 0xEF53;
                case 0xEF51:
                    A |= ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xEF53;
                    goto case 0xEF53;
                case 0xEF53:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEF7A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF7A; }
                    PC = 0xEF55; goto case 0xEF55;
                case 0xEF54:
                    A &= _ram[0xA0]; SetZN(A); TotalCycles += 3; PC = 0xEF56;
                    goto case 0xEF56;
                case 0xEF55:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xEF57;
                    goto case 0xEF57;
                case 0xEF56:
                    TotalCycles += 7; PushU16(0xEF58); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEF57:
                    A = _ram[0x0781]; SetZN(A); TotalCycles += 4; PC = 0xEF5A;
                    goto case 0xEF5A;
                case 0xEF58:
                    WriteMem(ReadU16Zp((byte)(0x07 + X)), A); TotalCycles += 6; PC = 0xEF5A;
                    goto case 0xEF5A;
                case 0xEF5A:
                    Cmp(A, _ram[0x0711]); TotalCycles += 4; PC = 0xEF5D;
                    goto case 0xEF5D;
                case 0xEF5B:
                    A |= ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xEF5D;
                    goto case 0xEF5D;
                case 0xEF5D:
                    _ram[0x0711] = Y; TotalCycles += 4; PC = 0xEF60;
                    goto case 0xEF60;
                case 0xEF5E:
                    A |= ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xEF60;
                    goto case 0xEF60;
                case 0xEF60:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xEF7A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF7A; }
                    PC = 0xEF62; goto case 0xEF62;
                case 0xEF61:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEF62;
                    goto case 0xEF62;
                case 0xEF62:
                    _ram[0x0711] = A; TotalCycles += 4; PC = 0xEF65;
                    goto case 0xEF65;
                case 0xEF63:
                    A |= ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xEF65;
                    goto case 0xEF65;
                case 0xEF65:
                    Y = 0x07; SetZN(Y); TotalCycles += 2; PC = 0xEF67;
                    goto case 0xEF67;
                case 0xEF67:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6E07 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEF6A;
                    goto case 0xEF6A;
                case 0xEF69:
                    { int a = 0xD58D; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xEF6C;
                    goto case 0xEF6C;
                case 0xEF6A:
                    _ram[0x06D5] = A; TotalCycles += 4; PC = 0xEF6D;
                    goto case 0xEF6D;
                case 0xEF6B:
                    Cmp(A, _ram[(byte)(0x06 + X)]); TotalCycles += 4; PC = 0xEF6D;
                    goto case 0xEF6D;
                case 0xEF6C:
                    _ram[0xA0] = Asl(_ram[0xA0]); TotalCycles += 5; PC = 0xEF6E;
                    return;
                case 0xEF6D:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xEF6F;
                    goto case 0xEF6F;
                case 0xEF6F:
                    A = _ram[0x57]; SetZN(A); TotalCycles += 3; PC = 0xEF71;
                    goto case 0xEF71;
                case 0xEF71:
                    A |= _ram[0x0C]; SetZN(A); TotalCycles += 3; PC = 0xEF73;
                    goto case 0xEF73;
                case 0xEF73:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEF76; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF76; }
                    PC = 0xEF75; goto case 0xEF75;
                case 0xEF74:
                    A |= ReadMem(ReadU16Zp((byte)(0x88 + X))); SetZN(A); TotalCycles += 6; PC = 0xEF76;
                    goto case 0xEF76;
                case 0xEF75:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xEF76;
                    goto case 0xEF76;
                case 0xEF76:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xEF77;
                    goto case 0xEF77;
                case 0xEF77:
                    TotalCycles += 6; PushU16(0xEF79); PC = 0xEFBE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEFBE;
                case 0xEF78:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x2DEF + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xEF7B;
                    goto case 0xEF7B;
                case 0xEF7A:
                    A = _ram[0x03D0]; SetZN(A); TotalCycles += 4; PC = 0xEF7D;
                    goto case 0xEF7D;
                case 0xEF7B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEF80; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF80; }
                    PC = 0xEF7D; goto case 0xEF7D;
                case 0xEF7D:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEF7E;
                    goto case 0xEF7E;
                case 0xEF7E:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEF7F;
                    goto case 0xEF7F;
                case 0xEF7F:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEF80;
                    goto case 0xEF80;
                case 0xEF80:
                    A = Lsr(A); TotalCycles += 2; PC = 0xEF81;
                    goto case 0xEF81;
                case 0xEF81:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xEF83;
                    goto case 0xEF83;
                case 0xEF82:
                    TotalCycles += 7; PushU16(0xEF84); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEF83:
                    X = 0x03; SetZN(X); TotalCycles += 2; PC = 0xEF85;
                    goto case 0xEF85;
                case 0xEF85:
                    A = _ram[0x06E4]; SetZN(A); TotalCycles += 4; PC = 0xEF88;
                    goto case 0xEF88;
                case 0xEF86:
                    Cmp(X, _ram[0x06]); TotalCycles += 3; PC = 0xEF88;
                    goto case 0xEF88;
                case 0xEF87:
                    _ram[0x18] = Asl(_ram[0x18]); TotalCycles += 5; PC = 0xEF89;
                    goto case 0xEF89;
                case 0xEF88:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEF89;
                    goto case 0xEF89;
                case 0xEF89:
                    Adc(0x18); TotalCycles += 2; PC = 0xEF8B;
                    goto case 0xEF8B;
                case 0xEF8A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEF8B;
                    goto case 0xEF8B;
                case 0xEF8B:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xEF8C;
                    goto case 0xEF8C;
                case 0xEF8C:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xEF8E;
                    goto case 0xEF8E;
                case 0xEF8D:
                    P |= FlagD; TotalCycles += 2; PC = 0xEF8E;
                    goto case 0xEF8E;
                case 0xEF8E:
                    _ram[0x00] = Lsr(_ram[0x00]); TotalCycles += 5; PC = 0xEF90;
                    goto case 0xEF90;
                case 0xEF8F:
                    TotalCycles += 7; PushU16(0xEF91); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEF90:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xEF95; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF95; }
                    PC = 0xEF92; goto case 0xEF92;
                case 0xEF92:
                    TotalCycles += 6; PushU16(0xEF94); PC = 0xE5C1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xE5C1;
                case 0xEF93:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xE5 + X)))); TotalCycles += 6; PC = 0xEF95;
                    goto case 0xEF95;
                case 0xEF94:
                    Sbc(_ram[0x98]); TotalCycles += 3; PC = 0xEF96;
                    goto case 0xEF96;
                case 0xEF95:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xEF96;
                    goto case 0xEF96;
                case 0xEF96:
                    P |= FlagC; TotalCycles += 2; PC = 0xEF97;
                    goto case 0xEF97;
                case 0xEF97:
                    Sbc(0x08); TotalCycles += 2; PC = 0xEF99;
                    goto case 0xEF99;
                case 0xEF98:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xEF99;
                    goto case 0xEF99;
                case 0xEF99:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xEF9A;
                    goto case 0xEF9A;
                case 0xEF9A:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xEF9B;
                    goto case 0xEF9B;
                case 0xEF9B:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEF8C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEF8C; }
                    PC = 0xEF9D; goto case 0xEF9D;
                case 0xEF9D:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEF9E: // === SUBROUTINE: Sub_EF9E ===
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xEF9F;
                    goto case 0xEF9F;
                case 0xEF9F:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0xEFA1;
                    goto case 0xEFA1;
                case 0xEFA0:
                    TotalCycles += 7; PushU16(0xEFA2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEFA1:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEFA4: // === SUBROUTINE: Sub_EFA4 ===
                    X = 0x05; SetZN(X); TotalCycles += 2; PC = 0xEFA6;
                    goto case 0xEFA6;
                case 0xEFA5:
                    A |= _ram[0xBD]; SetZN(A); TotalCycles += 3; PC = 0xEFA7;
                    return;
                case 0xEFA6:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6F9E + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEFA9;
                    goto case 0xEFA9;
                case 0xEFA9:
                    _ram[(byte)(0x02 + X)] = A; TotalCycles += 4; PC = 0xEFAB;
                    goto case 0xEFAB;
                case 0xEFAB:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xEFAC;
                    goto case 0xEFAC;
                case 0xEFAC:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xEFA6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEFA6; }
                    PC = 0xEFAE; goto case 0xEFAE;
                case 0xEFAD:
                    P |= FlagD; TotalCycles += 2; PC = 0xEFAE;
                    goto case 0xEFAE;
                case 0xEFAE:
                    X = 0xB8; SetZN(X); TotalCycles += 2; PC = 0xEFB0;
                    goto case 0xEFB0;
                case 0xEFAF:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xEFB0;
                    goto case 0xEFB0;
                case 0xEFB0:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xEFB2;
                    goto case 0xEFB2;
                case 0xEFB2:
                    TotalCycles += 6; PushU16(0xEFB4); PC = 0xEFDC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEFDC;
                case 0xEFB5:
                    A = _ram[0x0226]; SetZN(A); TotalCycles += 4; PC = 0xEFB8;
                    goto case 0xEFB8;
                case 0xEFB6:
                    _ram[0x02] = Rol(_ram[0x02]); TotalCycles += 5; PC = 0xEFB8;
                    goto case 0xEFB8;
                case 0xEFB8:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xEFBA;
                    goto case 0xEFBA;
                case 0xEFB9:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xEFBA:
                    _ram[0x0222] = A; TotalCycles += 4; PC = 0xEFBD;
                    goto case 0xEFBD;
                case 0xEFBD:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEFBE: // === SUBROUTINE: Sub_EFBE ===
                    _ram[0x07] = A; TotalCycles += 3; PC = 0xEFC0;
                    goto case 0xEFC0;
                case 0xEFC0:
                    A = _ram[0x03AD]; SetZN(A); TotalCycles += 4; PC = 0xEFC3;
                    goto case 0xEFC3;
                case 0xEFC1:
                    A = SmbEmbeddedAssets.StaticDataTables[0x0D03]; SetZN(A); TotalCycles += 4; PC = 0xEFC4;
                    goto case 0xEFC4;
                case 0xEFC3:
                    _ram[0x0755] = A; TotalCycles += 4; PC = 0xEFC6;
                    goto case 0xEFC6;
                case 0xEFC4:
                    A ^= _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0xEFC6;
                    goto case 0xEFC6;
                case 0xEFC6:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0xEFC8;
                    goto case 0xEFC8;
                case 0xEFC7:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0xEFC9;
                    goto case 0xEFC9;
                case 0xEFC8:
                    A = _ram[0x03B8]; SetZN(A); TotalCycles += 4; PC = 0xEFCB;
                    goto case 0xEFCB;
                case 0xEFC9:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xEFCA;
                    return;
                case 0xEFCB:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xEFCD;
                    goto case 0xEFCD;
                case 0xEFCD:
                    A = _ram[0x33]; SetZN(A); TotalCycles += 3; PC = 0xEFCF;
                    goto case 0xEFCF;
                case 0xEFCF:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0xEFD1;
                    goto case 0xEFD1;
                case 0xEFD1:
                    A = _ram[0x03C4]; SetZN(A); TotalCycles += 4; PC = 0xEFD4;
                    goto case 0xEFD4;
                case 0xEFD2:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0xEFD4;
                    goto case 0xEFD4;
                case 0xEFD4:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xEFD6;
                    goto case 0xEFD6;
                case 0xEFD6:
                    X = _ram[0x06D5]; SetZN(X); TotalCycles += 4; PC = 0xEFD9;
                    goto case 0xEFD9;
                case 0xEFD7:
                    Cmp(A, _ram[(byte)(0x06 + X)]); TotalCycles += 4; PC = 0xEFD9;
                    goto case 0xEFD9;
                case 0xEFD8:
                    _ram[0xAC] = Asl(_ram[0xAC]); TotalCycles += 5; PC = 0xEFDA;
                    goto case 0xEFDA;
                case 0xEFD9:
                    Y = _ram[0x06E4]; SetZN(Y); TotalCycles += 4; PC = 0xEFDC;
                    goto case 0xEFDC;
                case 0xEFDA:
                    Cmp(X, _ram[0x06]); TotalCycles += 3; PC = 0xEFDC;
                    goto case 0xEFDC;
                case 0xEFDB:
                    _ram[0xBD] = Asl(_ram[0xBD]); TotalCycles += 5; PC = 0xEFDD;
                    return;
                case 0xEFDC: // === SUBROUTINE: Sub_EFDC ===
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6E17 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEFDF;
                    goto case 0xEFDF;
                case 0xEFDE:
                    _ram[0x0085] = IncVal(_ram[0x0085]); TotalCycles += 6; PC = 0xEFE1;
                    goto case 0xEFE1;
                case 0xEFDF:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xEFE1;
                    goto case 0xEFE1;
                case 0xEFE0:
                    TotalCycles += 7; PushU16(0xEFE2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xEFE1:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6E18 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xEFE4;
                    goto case 0xEFE4;
                case 0xEFE2:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xEFE3;
                    goto case 0xEFE3;
                case 0xEFE3:
                    { int a = 0xB220; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xEFE6;
                    return;
                case 0xEFE4:
                    TotalCycles += 6; PushU16(0xEFE6); PC = 0xEBB2;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xEBB2;
                case 0xEFE7:
                    _ram[0x07] = DecVal(_ram[0x07]); TotalCycles += 5; PC = 0xEFE9;
                    goto case 0xEFE9;
                case 0xEFE9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xEFDC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEFDC; }
                    PC = 0xEFEB; goto case 0xEFEB;
                case 0xEFEA:
                    Sbc(ReadMem(ReadU16Zp(0x60) + Y)); TotalCycles += 5; PC = 0xEFEC;
                    goto case 0xEFEC;
                case 0xEFEB:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xEFEC: // === SUBROUTINE: Sub_EFEC ===
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xEFEE;
                    goto case 0xEFEE;
                case 0xEFED:
                    A |= _ram[(0x03C9 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xEFF0;
                    goto case 0xEFF0;
                case 0xEFEE:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xEFF0;
                    goto case 0xEFF0;
                case 0xEFF0:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF044; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF044; }
                    PC = 0xEFF2; goto case 0xEFF2;
                case 0xEFF2:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xEFF4;
                    goto case 0xEFF4;
                case 0xEFF4:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF034; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF034; }
                    PC = 0xEFF6; goto case 0xEFF6;
                case 0xEFF5:
                    { int a = (0x01C9 + X) & 0x07FF; _ram[a] = Rol(_ram[a]); } TotalCycles += 7; PC = 0xEFF8;
                    goto case 0xEFF8;
                case 0xEFF6:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xEFF8;
                    goto case 0xEFF8;
                case 0xEFF7:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0xEFF9;
                    goto case 0xEFF9;
                case 0xEFF8:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF00B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF00B; }
                    PC = 0xEFFA; goto case 0xEFFA;
                case 0xEFF9:
                    A |= ReadMem(ReadU16Zp(0xAD) + Y); SetZN(A); TotalCycles += 5; PC = 0xEFFB;
                    return;
                case 0xEFFA:
                    A = _ram[0x0704]; SetZN(A); TotalCycles += 4; PC = 0xEFFD;
                    goto case 0xEFFD;
                case 0xEFFD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF050; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF050; }
                    PC = 0xEFFF; goto case 0xEFFF;
                case 0xEFFE:
                    A ^= ReadMem(ReadU16Zp(0xA0) + Y); SetZN(A); TotalCycles += 5; PC = 0xF000;
                    goto case 0xF000;
                case 0xEFFF:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0xF001;
                    goto case 0xF001;
                case 0xF000:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xF002;
                    return;
                case 0xF001:
                    A = _ram[0x0714]; SetZN(A); TotalCycles += 4; PC = 0xF004;
                    goto case 0xF004;
                case 0xF004:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF028; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF028; }
                    PC = 0xF006; goto case 0xF006;
                case 0xF006:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xF008;
                    goto case 0xF008;
                case 0xF007:
                    TotalCycles += 7; PushU16(0xF009); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF008:
                    TotalCycles += 3; PC = 0xF028;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF028;
                case 0xF009:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xF00A;
                    goto case 0xF00A;
                case 0xF00A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEFAC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xEFAC; }
                    PC = 0xF00C; goto case 0xF00C;
                case 0xF00B:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0xF00D;
                    goto case 0xF00D;
                case 0xF00C:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xF00E;
                    return;
                case 0xF00D:
                    A = _ram[0x0714]; SetZN(A); TotalCycles += 4; PC = 0xF010;
                    goto case 0xF010;
                case 0xF010:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF028; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF028; }
                    PC = 0xF012; goto case 0xF012;
                case 0xF011:
                    { byte z = (byte)(0xA0 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xF013;
                    return;
                case 0xF012:
                    Y = 0x02; SetZN(Y); TotalCycles += 2; PC = 0xF014;
                    goto case 0xF014;
                case 0xF014:
                    A = _ram[0x57]; SetZN(A); TotalCycles += 3; PC = 0xF016;
                    goto case 0xF016;
                case 0xF016:
                    A |= _ram[0x0C]; SetZN(A); TotalCycles += 3; PC = 0xF018;
                    goto case 0xF018;
                case 0xF018:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF028; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF028; }
                    PC = 0xF01A; goto case 0xF01A;
                case 0xF019:
                    _ram[0x00AD] = Asl(_ram[0x00AD]); TotalCycles += 6; PC = 0xF01C;
                    return;
                case 0xF01A:
                    A = _ram[0x0700]; SetZN(A); TotalCycles += 4; PC = 0xF01D;
                    goto case 0xF01D;
                case 0xF01B:
                    TotalCycles += 7; PushU16(0xF01D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF01D:
                    Cmp(A, 0x09); TotalCycles += 2; PC = 0xF01F;
                    goto case 0xF01F;
                case 0xF01E:
                    A |= 0x90; SetZN(A); TotalCycles += 2; PC = 0xF020;
                    return;
                case 0xF01F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF03C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF03C; }
                    PC = 0xF021; goto case 0xF021;
                case 0xF021:
                    A = _ram[0x45]; SetZN(A); TotalCycles += 3; PC = 0xF023;
                    goto case 0xF023;
                case 0xF022:
                    A ^= _ram[0x25]; SetZN(A); TotalCycles += 3; PC = 0xF024;
                    return;
                case 0xF023:
                    A &= _ram[0x33]; SetZN(A); TotalCycles += 3; PC = 0xF025;
                    goto case 0xF025;
                case 0xF025:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF03C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF03C; }
                    PC = 0xF027; goto case 0xF027;
                case 0xF026:
                    A |= _ram[(byte)(0xC8 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF028;
                    goto case 0xF028;
                case 0xF027:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xF028;
                    goto case 0xF028;
                case 0xF028:
                    TotalCycles += 6; PushU16(0xF02A); PC = 0xF091;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF091;
                case 0xF029:
                    WriteMem(ReadU16Zp(0xF0) + Y, A); TotalCycles += 6; PC = 0xF02B;
                    goto case 0xF02B;
                case 0xF02A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEFD5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF02C; goto case 0xF02C;
                case 0xF02B:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF02D;
                    goto case 0xF02D;
                case 0xF02C:
                    TotalCycles += 7; PushU16(0xF02E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF02D:
                    _ram[0x070D] = A; TotalCycles += 4; PC = 0xF030;
                    goto case 0xF030;
                case 0xF02E:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x3907]; SetZN(A); TotalCycles += 4; PC = 0xF031;
                    return;
                case 0xF030:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6E07 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF033;
                    goto case 0xF033;
                case 0xF032:
                    { int a = 0xA060; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xF035;
                    return;
                case 0xF033:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF034:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xF036;
                    goto case 0xF036;
                case 0xF036:
                    TotalCycles += 6; PushU16(0xF038); PC = 0xF091;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF091;
                case 0xF037:
                    WriteMem(ReadU16Zp(0xF0) + Y, A); TotalCycles += 6; PC = 0xF039;
                    goto case 0xF039;
                case 0xF038:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF086; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF086; }
                    PC = 0xF03A; return;
                case 0xF039:
                    TotalCycles += 3; PC = 0xF062;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF062;
                case 0xF03B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEFDD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF03D; return;
                case 0xF03C:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xF03E;
                    goto case 0xF03E;
                case 0xF03E:
                    TotalCycles += 6; PushU16(0xF040); PC = 0xF091;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF091;
                case 0xF03F:
                    WriteMem(ReadU16Zp(0xF0) + Y, A); TotalCycles += 6; PC = 0xF041;
                    goto case 0xF041;
                case 0xF040:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF08E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF042; goto case 0xF042;
                case 0xF041:
                    TotalCycles += 3; PC = 0xF068;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF068;
                case 0xF042:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xF043;
                    goto case 0xF043;
                case 0xF043:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEFE5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF045; goto case 0xF045;
                case 0xF044:
                    Y = 0x05; SetZN(Y); TotalCycles += 2; PC = 0xF046;
                    goto case 0xF046;
                case 0xF045:
                    A |= _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0xF047;
                    return;
                case 0xF046:
                    A = _ram[0x9F]; SetZN(A); TotalCycles += 3; PC = 0xF048;
                    goto case 0xF048;
                case 0xF048:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF028; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF028; }
                    PC = 0xF04A; goto case 0xF04A;
                case 0xF049:
                    { int a = 0x9120 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF04C;
                    goto case 0xF04C;
                case 0xF04A:
                    TotalCycles += 6; PushU16(0xF04C); PC = 0xF091;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF091;
                case 0xF04B:
                    WriteMem(ReadU16Zp(0xF0) + Y, A); TotalCycles += 6; PC = 0xF04D;
                    goto case 0xF04D;
                case 0xF04C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF09A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF09A; }
                    PC = 0xF04E; goto case 0xF04E;
                case 0xF04D:
                    TotalCycles += 3; PC = 0xF06D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF06D;
                case 0xF04E:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x20F0]); TotalCycles += 4; PC = 0xF051;
                    goto case 0xF051;
                case 0xF04F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xEFF1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF051; goto case 0xF051;
                case 0xF050:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xF052;
                    goto case 0xF052;
                case 0xF051:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xF053;
                    goto case 0xF053;
                case 0xF052:
                    TotalCycles += 6; PushU16(0xF054); PC = 0xF091;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF091;
                case 0xF053:
                    WriteMem(ReadU16Zp(0xF0) + Y, A); TotalCycles += 6; PC = 0xF055;
                    goto case 0xF055;
                case 0xF054:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF003; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF056; return;
                case 0xF055:
                    A = _ram[0x0782]; SetZN(A); TotalCycles += 4; PC = 0xF058;
                    goto case 0xF058;
                case 0xF058:
                    A |= _ram[0x070D]; SetZN(A); TotalCycles += 4; PC = 0xF05B;
                    goto case 0xF05B;
                case 0xF059:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x5007]; SetZN(A); TotalCycles += 4; PC = 0xF05C;
                    return;
                case 0xF05B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF068; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF068; }
                    PC = 0xF05D; goto case 0xF05D;
                case 0xF05D:
                    A = _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0xF05F;
                    goto case 0xF05F;
                case 0xF05E:
                    A = Asl(A); TotalCycles += 2; PC = 0xF05F;
                    goto case 0xF05F;
                case 0xF05F:
                    A = Asl(A); TotalCycles += 2; PC = 0xF060;
                    goto case 0xF060;
                case 0xF060:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF068; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF068; }
                    PC = 0xF062; goto case 0xF062;
                case 0xF061:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xF063;
                    goto case 0xF063;
                case 0xF062: // === SUBROUTINE: Sub_F062 ===
                    A = _ram[0x070D]; SetZN(A); TotalCycles += 4; PC = 0xF065;
                    goto case 0xF065;
                case 0xF063:
                    A |= ReadIoReg(0x4C07); SetZN(A); TotalCycles += 4; PC = 0xF066;
                    goto case 0xF066;
                case 0xF065:
                    TotalCycles += 3; PC = 0xF0D0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF0D0;
                case 0xF066:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF058; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF058; }
                    PC = 0xF068; goto case 0xF068;
                case 0xF067:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF012; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF012; }
                    PC = 0xF069; return;
                case 0xF068:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xF06A;
                    goto case 0xF06A;
                case 0xF06A:
                    TotalCycles += 3; PC = 0xF06F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF06F;
                case 0xF06C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF017; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF06E; return;
                case 0xF06D:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xF06F;
                    goto case 0xF06F;
                case 0xF06F:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xF071;
                    goto case 0xF071;
                case 0xF070:
                    TotalCycles += 7; PushU16(0xF072); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF071:
                    TotalCycles += 6; PushU16(0xF073); PC = 0xF062;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF062;
                case 0xF073:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF0BD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF0BD; }
                    PC = 0xF075; goto case 0xF075;
                case 0xF074:
                    PushU8(A); TotalCycles += 3; PC = 0xF075;
                    goto case 0xF075;
                case 0xF075:
                    A = _ram[0x0781]; SetZN(A); TotalCycles += 4; PC = 0xF078;
                    goto case 0xF078;
                case 0xF076:
                    WriteMem(ReadU16Zp((byte)(0x07 + X)), A); TotalCycles += 6; PC = 0xF078;
                    goto case 0xF078;
                case 0xF078:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF08F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF08F; }
                    PC = 0xF07A; goto case 0xF07A;
                case 0xF079:
                    A |= _ram[(byte)(0xAD + X)]; SetZN(A); TotalCycles += 4; PC = 0xF07B;
                    return;
                case 0xF07A:
                    A = _ram[0x070C]; SetZN(A); TotalCycles += 4; PC = 0xF07D;
                    goto case 0xF07D;
                case 0xF07D:
                    _ram[0x0781] = A; TotalCycles += 4; PC = 0xF080;
                    goto case 0xF080;
                case 0xF07E:
                    WriteMem(ReadU16Zp((byte)(0x07 + X)), A); TotalCycles += 6; PC = 0xF080;
                    goto case 0xF080;
                case 0xF080:
                    A = _ram[0x070D]; SetZN(A); TotalCycles += 4; PC = 0xF083;
                    goto case 0xF083;
                case 0xF081:
                    A |= _ram[0x0007]; SetZN(A); TotalCycles += 4; PC = 0xF084;
                    goto case 0xF084;
                case 0xF083:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF084;
                    goto case 0xF084;
                case 0xF084:
                    Adc(0x01); TotalCycles += 2; PC = 0xF086;
                    goto case 0xF086;
                case 0xF085:
                    A |= ReadMem(ReadU16Zp((byte)(0xC5 + X))); SetZN(A); TotalCycles += 6; PC = 0xF087;
                    goto case 0xF087;
                case 0xF086:
                    Cmp(A, _ram[0x00]); TotalCycles += 3; PC = 0xF088;
                    goto case 0xF088;
                case 0xF087:
                    TotalCycles += 7; PushU16(0xF089); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF088:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF08C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF08C; }
                    PC = 0xF08A; goto case 0xF08A;
                case 0xF08A:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF08C;
                    goto case 0xF08C;
                case 0xF08B:
                    TotalCycles += 7; PushU16(0xF08D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF08C:
                    _ram[0x070D] = A; TotalCycles += 4; PC = 0xF08F;
                    goto case 0xF08F;
                case 0xF08D:
                    A |= ReadIoReg(0x6807); SetZN(A); TotalCycles += 4; PC = 0xF090;
                    goto case 0xF090;
                case 0xF08F:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xF090;
                    goto case 0xF090;
                case 0xF090:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF091: // === SUBROUTINE: Sub_F091 ===
                    A = _ram[0x0754]; SetZN(A); TotalCycles += 4; PC = 0xF094;
                    goto case 0xF094;
                case 0xF094:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF09B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF09B; }
                    PC = 0xF096; goto case 0xF096;
                case 0xF095:
                    A |= _ram[0x98]; SetZN(A); TotalCycles += 3; PC = 0xF097;
                    goto case 0xF097;
                case 0xF096:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF097;
                    goto case 0xF097;
                case 0xF097:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF098;
                    goto case 0xF098;
                case 0xF098:
                    Adc(0x08); TotalCycles += 2; PC = 0xF09A;
                    goto case 0xF09A;
                case 0xF099:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF09A;
                    goto case 0xF09A;
                case 0xF09A:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF09B;
                    goto case 0xF09B;
                case 0xF09B:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF09C:
                    TotalCycles += 7; PushU16(0xF09E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF09D:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0xF09F;
                    goto case 0xF09F;
                case 0xF09E:
                    TotalCycles += 7; PushU16(0xF0A0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF09F:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0xF0A1;
                    goto case 0xF0A1;
                case 0xF0A0:
                    TotalCycles += 7; PushU16(0xF0A2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF0A1:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xF0A3;
                    goto case 0xF0A3;
                case 0xF0A3:
                    TotalCycles += 7; PushU16(0xF0A5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF0A4:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xF0A6;
                    return;
                case 0xF0A7:
                    TotalCycles += 7; PushU16(0xF0A9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF0A9:
                    TotalCycles += 7; PushU16(0xF0AB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF0AB:
                    TotalCycles += 7; PushU16(0xF0AD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF0AD:
                    TotalCycles += 7; PushU16(0xF0AF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF0AF:
                    TotalCycles += 7; PushU16(0xF0B1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF0B0: // === SUBROUTINE: Sub_F0B0 ===
                    Y = _ram[0x070D]; SetZN(Y); TotalCycles += 4; PC = 0xF0B3;
                    goto case 0xF0B3;
                case 0xF0B1:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x2507]; SetZN(A); TotalCycles += 4; PC = 0xF0B4;
                    goto case 0xF0B4;
                case 0xF0B3:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xF0B5;
                    goto case 0xF0B5;
                case 0xF0B4:
                    A |= 0x29; SetZN(A); TotalCycles += 2; PC = 0xF0B6;
                    return;
                case 0xF0B5:
                    A &= 0x03; SetZN(A); TotalCycles += 2; PC = 0xF0B7;
                    goto case 0xF0B7;
                case 0xF0B7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF0C6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF0C6; }
                    PC = 0xF0B9; goto case 0xF0B9;
                case 0xF0B8:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x40C8]; SetZN(A); TotalCycles += 4; PC = 0xF0BB;
                    goto case 0xF0BB;
                case 0xF0B9: // === SUBROUTINE: Sub_F0B9 ===
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xF0BA;
                    goto case 0xF0BA;
                case 0xF0BA:
                    Cmp(Y, 0x0A); TotalCycles += 2; PC = 0xF0BC;
                    goto case 0xF0BC;
                case 0xF0BB:
                    A = Asl(A); TotalCycles += 2; PC = 0xF0BC;
                    goto case 0xF0BC;
                case 0xF0BC:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF0C3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF0C3; }
                    PC = 0xF0BE; goto case 0xF0BE;
                case 0xF0BD:
                    A |= _ram[0xA0]; SetZN(A); TotalCycles += 3; PC = 0xF0BF;
                    goto case 0xF0BF;
                case 0xF0BE:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xF0C0;
                    goto case 0xF0C0;
                case 0xF0BF:
                    TotalCycles += 7; PushU16(0xF0C1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF0C0:
                    _ram[0x070B] = Y; TotalCycles += 4; PC = 0xF0C3;
                    goto case 0xF0C3;
                case 0xF0C3: // === SUBROUTINE: Sub_F0C3 ===
                    _ram[0x070D] = Y; TotalCycles += 4; PC = 0xF0C6;
                    goto case 0xF0C6;
                case 0xF0C4: // === SUBROUTINE: Sub_F0C4 ===
                    A |= SmbEmbeddedAssets.StaticDataTables[0x2D07]; SetZN(A); TotalCycles += 4; PC = 0xF0C7;
                    return;
                case 0xF0C6:
                    A = _ram[0x0754]; SetZN(A); TotalCycles += 4; PC = 0xF0C9;
                    goto case 0xF0C9;
                case 0xF0C9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF0D7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF0D7; }
                    PC = 0xF0CB; goto case 0xF0CB;
                case 0xF0CB:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x709C + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF0CE;
                    goto case 0xF0CE;
                case 0xF0CD:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF06F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF06F; }
                    PC = 0xF0CF; return;
                case 0xF0CE:
                    Y = 0x0F; SetZN(Y); TotalCycles += 2; PC = 0xF0D0;
                    goto case 0xF0D0;
                case 0xF0D0:
                    A = Asl(A); TotalCycles += 2; PC = 0xF0D1;
                    goto case 0xF0D1;
                case 0xF0D1:
                    A = Asl(A); TotalCycles += 2; PC = 0xF0D2;
                    goto case 0xF0D2;
                case 0xF0D2:
                    A = Asl(A); TotalCycles += 2; PC = 0xF0D3;
                    goto case 0xF0D3;
                case 0xF0D3:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x6E07 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF0D6;
                    goto case 0xF0D6;
                case 0xF0D5:
                    { int a = 0x9860; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xF0D8;
                    goto case 0xF0D8;
                case 0xF0D6:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF0D7:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF0D8;
                    goto case 0xF0D8;
                case 0xF0D8:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF0D9;
                    goto case 0xF0D9;
                case 0xF0D9:
                    Adc(0x0A); TotalCycles += 2; PC = 0xF0DB;
                    goto case 0xF0DB;
                case 0xF0DA:
                    A = Asl(A); TotalCycles += 2; PC = 0xF0DB;
                    goto case 0xF0DB;
                case 0xF0DB:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xF0DC;
                    goto case 0xF0DC;
                case 0xF0DC:
                    Y = 0x09; SetZN(Y); TotalCycles += 2; PC = 0xF0DE;
                    goto case 0xF0DE;
                case 0xF0DD:
                    A |= 0xBD; SetZN(A); TotalCycles += 2; PC = 0xF0DF;
                    return;
                case 0xF0DE:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x709C + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF0E1;
                    goto case 0xF0E1;
                case 0xF0E0:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF0B2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF0E2; return;
                case 0xF0E1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF0E5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF0E5; }
                    PC = 0xF0E3; goto case 0xF0E3;
                case 0xF0E3:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xF0E5;
                    goto case 0xF0E5;
                case 0xF0E4:
                    A |= ReadMem(ReadU16Zp((byte)(0xB9 + X))); SetZN(A); TotalCycles += 6; PC = 0xF0E6;
                    return;
                case 0xF0E5:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6E07 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF0E8;
                    goto case 0xF0E8;
                case 0xF0E7:
                    { int a = 0xAC60; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xF0EA;
                    goto case 0xF0EA;
                case 0xF0E8:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF0E9: // === SUBROUTINE: Sub_F0E9 ===
                    Y = _ram[0x06E4]; SetZN(Y); TotalCycles += 4; PC = 0xF0EC;
                    goto case 0xF0EC;
                case 0xF0EA:
                    Cmp(X, _ram[0x06]); TotalCycles += 3; PC = 0xF0EC;
                    goto case 0xF0EC;
                case 0xF0EB:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xF0ED;
                    goto case 0xF0ED;
                case 0xF0EC:
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0xF0EE;
                    goto case 0xF0EE;
                case 0xF0ED:
                    _ram[0x03C9] = Asl(_ram[0x03C9]); TotalCycles += 6; PC = 0xF0F0;
                    goto case 0xF0F0;
                case 0xF0EE:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0xF0F0;
                    goto case 0xF0F0;
                case 0xF0F0:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF105; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF105; }
                    PC = 0xF0F2; goto case 0xF0F2;
                case 0xF0F2:
                    A = _ram[0x06D5]; SetZN(A); TotalCycles += 4; PC = 0xF0F5;
                    goto case 0xF0F5;
                case 0xF0F3:
                    Cmp(A, _ram[(byte)(0x06 + X)]); TotalCycles += 4; PC = 0xF0F5;
                    goto case 0xF0F5;
                case 0xF0F4:
                    _ram[0xC9] = Asl(_ram[0xC9]); TotalCycles += 5; PC = 0xF0F6;
                    goto case 0xF0F6;
                case 0xF0F5:
                    Cmp(A, 0x50); TotalCycles += 2; PC = 0xF0F7;
                    goto case 0xF0F7;
                case 0xF0F6:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xF0E8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF0E8; }
                    PC = 0xF0F8; goto case 0xF0F8;
                case 0xF0F7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF117; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF117; }
                    PC = 0xF0F9; goto case 0xF0F9;
                case 0xF0F8:
                    { int a = 0xB8C9 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xF0FB;
                    goto case 0xF0FB;
                case 0xF0F9:
                    Cmp(A, 0xB8); TotalCycles += 2; PC = 0xF0FB;
                    goto case 0xF0FB;
                case 0xF0FA:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xF0FB;
                    goto case 0xF0FB;
                case 0xF0FB:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF117; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF117; }
                    PC = 0xF0FD; goto case 0xF0FD;
                case 0xF0FD:
                    Cmp(A, 0xC0); TotalCycles += 2; PC = 0xF0FF;
                    goto case 0xF0FF;
                case 0xF0FE:
                    Cmp(Y, 0xF0); TotalCycles += 2; PC = 0xF100;
                    goto case 0xF100;
                case 0xF0FF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF117; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF117; }
                    PC = 0xF101; goto case 0xF101;
                case 0xF100:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xF102;
                    goto case 0xF102;
                case 0xF101:
                    Cmp(A, 0xC8); TotalCycles += 2; PC = 0xF103;
                    goto case 0xF103;
                case 0xF102:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xF103;
                    goto case 0xF103;
                case 0xF103:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF129; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF129; }
                    PC = 0xF105; goto case 0xF105;
                case 0xF104:
                    Bit(_ram[0xB9]); TotalCycles += 3; PC = 0xF106;
                    return;
                case 0xF105:
                    A = _ram[(0x0212 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xF108;
                    goto case 0xF108;
                case 0xF108:
                    A &= 0x3F; SetZN(A); TotalCycles += 2; PC = 0xF10A;
                    goto case 0xF10A;
                case 0xF10A:
                    _ram[(0x0212 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF10D;
                    goto case 0xF10D;
                case 0xF10D:
                    A = _ram[(0x0216 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xF110;
                    goto case 0xF110;
                case 0xF10E:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xF110;
                    goto case 0xF110;
                case 0xF110:
                    A &= 0x3F; SetZN(A); TotalCycles += 2; PC = 0xF112;
                    goto case 0xF112;
                case 0xF112:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xF114;
                    goto case 0xF114;
                case 0xF113:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF114:
                    _ram[(0x0216 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF117;
                    goto case 0xF117;
                case 0xF115:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xF117;
                    goto case 0xF117;
                case 0xF117:
                    A = _ram[(0x021A + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xF11A;
                    goto case 0xF11A;
                case 0xF11A:
                    A &= 0x3F; SetZN(A); TotalCycles += 2; PC = 0xF11C;
                    goto case 0xF11C;
                case 0xF11C:
                    _ram[(0x021A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF11F;
                    goto case 0xF11F;
                case 0xF11F:
                    A = _ram[(0x021E + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xF122;
                    goto case 0xF122;
                case 0xF120:
                    { int a = 0x2902 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xF123;
                    return;
                case 0xF122:
                    A &= 0x3F; SetZN(A); TotalCycles += 2; PC = 0xF124;
                    goto case 0xF124;
                case 0xF124:
                    A |= 0x40; SetZN(A); TotalCycles += 2; PC = 0xF126;
                    goto case 0xF126;
                case 0xF125:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF126:
                    _ram[(0x021E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF129;
                    goto case 0xF129;
                case 0xF127:
                    { int a = 0x6002 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xF12A;
                    goto case 0xF12A;
                case 0xF129:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF12A: // === SUBROUTINE: Sub_F12A ===
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xF12C;
                    goto case 0xF12C;
                case 0xF12B:
                    TotalCycles += 7; PushU16(0xF12D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF12C:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xF12E;
                    goto case 0xF12E;
                case 0xF12D:
                    TotalCycles += 7; PushU16(0xF12F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF12E:
                    TotalCycles += 3; PC = 0xF142;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF142;
                case 0xF130:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF132;
                    goto case 0xF132;
                case 0xF131: // === SUBROUTINE: Sub_F131 ===
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xF133;
                    goto case 0xF133;
                case 0xF132:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xF134;
                    goto case 0xF134;
                case 0xF133:
                    TotalCycles += 6; PushU16(0xF135); PC = 0xF1A8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1A8;
                case 0xF134:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF135;
                    goto case 0xF135;
                case 0xF135:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF137;
                    return;
                case 0xF136:
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0xF138;
                    goto case 0xF138;
                case 0xF138:
                    TotalCycles += 3; PC = 0xF142;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF142;
                case 0xF13A:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF13C;
                    goto case 0xF13C;
                case 0xF13B: // === SUBROUTINE: Sub_F13B ===
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xF13D;
                    goto case 0xF13D;
                case 0xF13C:
                    TotalCycles += 7; PushU16(0xF13E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF13D:
                    TotalCycles += 6; PushU16(0xF13F); PC = 0xF1A8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1A8;
                case 0xF13E:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF13F;
                    goto case 0xF13F;
                case 0xF13F:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF141;
                    return;
                case 0xF140:
                    Y = 0x02; SetZN(Y); TotalCycles += 2; PC = 0xF142;
                    goto case 0xF142;
                case 0xF142:
                    TotalCycles += 6; PushU16(0xF144); PC = 0xF171;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF171;
                case 0xF143:
                    Adc(ReadMem(ReadU16Zp(0xF1) + Y)); TotalCycles += 5; PC = 0xF145;
                    goto case 0xF145;
                case 0xF144:
                    Sbc(ReadMem(ReadU16Zp(0xA6) + Y)); TotalCycles += 5; PC = 0xF146;
                    goto case 0xF146;
                case 0xF145:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xF147;
                    goto case 0xF147;
                case 0xF146:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF147;
                    goto case 0xF147;
                case 0xF147:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF148: // === SUBROUTINE: Sub_F148 ===
                    Y = 0x02; SetZN(Y); TotalCycles += 2; PC = 0xF14A;
                    goto case 0xF14A;
                case 0xF14A:
                    TotalCycles += 6; PushU16(0xF14C); PC = 0xF1A8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1A8;
                case 0xF14B:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF14C;
                    goto case 0xF14C;
                case 0xF14C:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF14E;
                    goto case 0xF14E;
                case 0xF14D:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0xF14F;
                    goto case 0xF14F;
                case 0xF14E:
                    _ram[0x4C] = Asl(_ram[0x4C]); TotalCycles += 5; PC = 0xF150;
                    return;
                case 0xF14F:
                    TotalCycles += 3; PC = 0xF142;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF142;
                case 0xF151:
                    Sbc(ReadMem(ReadU16Zp(0xA9) + Y)); TotalCycles += 5; PC = 0xF153;
                    goto case 0xF153;
                case 0xF152: // === SUBROUTINE: Sub_F152 ===
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xF154;
                    goto case 0xF154;
                case 0xF153:
                    A |= ReadMem(ReadU16Zp((byte)(0xA0 + X))); SetZN(A); TotalCycles += 6; PC = 0xF155;
                    goto case 0xF155;
                case 0xF154:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xF156;
                    goto case 0xF156;
                case 0xF155:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xF157;
                    goto case 0xF157;
                case 0xF156:
                    TotalCycles += 3; PC = 0xF165;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF165;
                case 0xF157:
                    Adc(_ram[0xF1]); TotalCycles += 3; PC = 0xF159;
                    goto case 0xF159;
                case 0xF158:
                    Sbc(ReadMem(ReadU16Zp(0xA9) + Y)); TotalCycles += 5; PC = 0xF15A;
                    goto case 0xF15A;
                case 0xF159: // === SUBROUTINE: Sub_F159 ===
                    A = 0x09; SetZN(A); TotalCycles += 2; PC = 0xF15B;
                    goto case 0xF15B;
                case 0xF15A:
                    A |= 0xA0; SetZN(A); TotalCycles += 2; PC = 0xF15C;
                    return;
                case 0xF15B:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xF15D;
                    goto case 0xF15D;
                case 0xF15D:
                    TotalCycles += 6; PushU16(0xF15F); PC = 0xF165;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF165;
                case 0xF15E:
                    Adc(_ram[0xF1]); TotalCycles += 3; PC = 0xF160;
                    goto case 0xF160;
                case 0xF15F:
                    Sbc(ReadMem(ReadU16Zp(0xE8) + Y)); TotalCycles += 5; PC = 0xF161;
                    goto case 0xF161;
                case 0xF160:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xF161;
                    goto case 0xF161;
                case 0xF161:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xF162;
                    goto case 0xF162;
                case 0xF162:
                    A = 0x09; SetZN(A); TotalCycles += 2; PC = 0xF164;
                    goto case 0xF164;
                case 0xF163:
                    A |= 0xC8; SetZN(A); TotalCycles += 2; PC = 0xF165;
                    goto case 0xF165;
                case 0xF164:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xF165;
                    goto case 0xF165;
                case 0xF165: // === SUBROUTINE: Sub_F165 ===
                    _ram[0x00] = X; TotalCycles += 3; PC = 0xF167;
                    goto case 0xF167;
                case 0xF166:
                    TotalCycles += 7; PushU16(0xF168); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF167:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF168;
                    goto case 0xF168;
                case 0xF168:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0xF16A;
                    goto case 0xF16A;
                case 0xF169:
                    TotalCycles += 7; PushU16(0xF16B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF16A:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xF16B;
                    goto case 0xF16B;
                case 0xF16B:
                    TotalCycles += 6; PushU16(0xF16D); PC = 0xF171;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF171;
                case 0xF16C:
                    Adc(ReadMem(ReadU16Zp(0xF1) + Y)); TotalCycles += 5; PC = 0xF16E;
                    goto case 0xF16E;
                case 0xF16D:
                    Sbc(ReadMem(ReadU16Zp(0xA6) + Y)); TotalCycles += 5; PC = 0xF16F;
                    goto case 0xF16F;
                case 0xF16E:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xF170;
                    goto case 0xF170;
                case 0xF16F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF170;
                    goto case 0xF170;
                case 0xF170:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF171: // === SUBROUTINE: Sub_F171 ===
                    A = _ram[(byte)(0xCE + X)]; SetZN(A); TotalCycles += 4; PC = 0xF173;
                    goto case 0xF173;
                case 0xF172:
                    { int a = 0xB899; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xF175;
                    return;
                case 0xF173:
                    _ram[(0x03B8 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF176;
                    goto case 0xF176;
                case 0xF174:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xF175;
                    return;
                case 0xF176:
                    A = _ram[(byte)(0x86 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF178;
                    goto case 0xF178;
                case 0xF177:
                    _ram[0x38] = X; TotalCycles += 3; PC = 0xF179;
                    goto case 0xF179;
                case 0xF178:
                    P |= FlagC; TotalCycles += 2; PC = 0xF179;
                    goto case 0xF179;
                case 0xF179:
                    Sbc(_ram[0x071C]); TotalCycles += 4; PC = 0xF17C;
                    goto case 0xF17C;
                case 0xF17C:
                    _ram[(0x03AD + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF17F;
                    goto case 0xF17F;
                case 0xF17D:
                    A = ReadIoReg(0x6003); SetZN(A); TotalCycles += 4; PC = 0xF180;
                    goto case 0xF180;
                case 0xF17F:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF180: // === SUBROUTINE: Sub_F180 ===
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xF182;
                    goto case 0xF182;
                case 0xF181:
                    TotalCycles += 7; PushU16(0xF183); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF182:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xF184;
                    goto case 0xF184;
                case 0xF183:
                    TotalCycles += 7; PushU16(0xF185); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF184:
                    TotalCycles += 3; PC = 0xF1C0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1C0;
                case 0xF185:
                    Cmp(Y, 0xF1); TotalCycles += 2; PC = 0xF187;
                    goto case 0xF187;
                case 0xF186:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF188;
                    goto case 0xF188;
                case 0xF187: // === SUBROUTINE: Sub_F187 ===
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xF189;
                    goto case 0xF189;
                case 0xF188:
                    TotalCycles += 7; PushU16(0xF18A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF189:
                    TotalCycles += 6; PushU16(0xF18B); PC = 0xF1A8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1A8;
                case 0xF18A:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF18B;
                    goto case 0xF18B;
                case 0xF18B:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF18D;
                    return;
                case 0xF18C:
                    Y = 0x02; SetZN(Y); TotalCycles += 2; PC = 0xF18E;
                    goto case 0xF18E;
                case 0xF18E:
                    TotalCycles += 3; PC = 0xF1C0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1C0;
                case 0xF18F:
                    Cmp(Y, 0xF1); TotalCycles += 2; PC = 0xF191;
                    goto case 0xF191;
                case 0xF190:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF192;
                    goto case 0xF192;
                case 0xF191: // === SUBROUTINE: Sub_F191 ===
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xF193;
                    goto case 0xF193;
                case 0xF192:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xF194;
                    goto case 0xF194;
                case 0xF193:
                    TotalCycles += 6; PushU16(0xF195); PC = 0xF1A8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1A8;
                case 0xF194:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF195;
                    goto case 0xF195;
                case 0xF195:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF197;
                    return;
                case 0xF196:
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0xF198;
                    goto case 0xF198;
                case 0xF198:
                    TotalCycles += 3; PC = 0xF1C0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1C0;
                case 0xF199:
                    Cmp(Y, 0xF1); TotalCycles += 2; PC = 0xF19B;
                    goto case 0xF19B;
                case 0xF19A:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF19C;
                    return;
                case 0xF19B: // === SUBROUTINE: Sub_F19B ===
                    Y = 0x02; SetZN(Y); TotalCycles += 2; PC = 0xF19D;
                    goto case 0xF19D;
                case 0xF19D:
                    TotalCycles += 6; PushU16(0xF19F); PC = 0xF1A8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1A8;
                case 0xF19E:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF19F;
                    goto case 0xF19F;
                case 0xF19F:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xF1A1;
                    goto case 0xF1A1;
                case 0xF1A0:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0xF1A2;
                    goto case 0xF1A2;
                case 0xF1A1:
                    _ram[0x4C] = Asl(_ram[0x4C]); TotalCycles += 5; PC = 0xF1A3;
                    goto case 0xF1A3;
                case 0xF1A2:
                    TotalCycles += 3; PC = 0xF1C0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1C0;
                case 0xF1A3:
                    Cmp(Y, 0xF1); TotalCycles += 2; PC = 0xF1A5;
                    return;
                case 0xF1A4:
                    Sbc(ReadMem(ReadU16Zp(0x07) + Y)); TotalCycles += 5; PC = 0xF1A6;
                    goto case 0xF1A6;
                case 0xF1A6:
                    { byte z = (byte)(0x0D + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xF1A8;
                    goto case 0xF1A8;
                case 0xF1A7:
                    A |= _ram[0x008A]; SetZN(A); TotalCycles += 4; PC = 0xF1AA;
                    goto case 0xF1AA;
                case 0xF1A8: // === SUBROUTINE: Sub_F1A8 ===
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xF1A9;
                    goto case 0xF1A9;
                case 0xF1A9:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF1AA;
                    goto case 0xF1AA;
                case 0xF1AA:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x71A5 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF1AD;
                    goto case 0xF1AD;
                case 0xF1AB:
                    A = _ram[0xF1]; SetZN(A); TotalCycles += 3; PC = 0xF1AD;
                    goto case 0xF1AD;
                case 0xF1AC:
                    Sbc(ReadMem(ReadU16Zp(0xAA) + Y)); TotalCycles += 5; PC = 0xF1AE;
                    goto case 0xF1AE;
                case 0xF1AD:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xF1AE;
                    goto case 0xF1AE;
                case 0xF1AE:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF1AF: // === SUBROUTINE: Sub_F1AF ===
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xF1B1;
                    goto case 0xF1B1;
                case 0xF1B0:
                    A |= ReadMem(ReadU16Zp((byte)(0xA0 + X))); SetZN(A); TotalCycles += 6; PC = 0xF1B2;
                    goto case 0xF1B2;
                case 0xF1B1:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xF1B3;
                    goto case 0xF1B3;
                case 0xF1B2:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xF1B4;
                    goto case 0xF1B4;
                case 0xF1B3:
                    TotalCycles += 3; PC = 0xF1BA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1BA;
                case 0xF1B4:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xF1B5;
                    goto case 0xF1B5;
                case 0xF1B5:
                    Sbc(ReadMem(ReadU16Zp(0xA9) + Y)); TotalCycles += 5; PC = 0xF1B7;
                    goto case 0xF1B7;
                case 0xF1B6: // === SUBROUTINE: Sub_F1B6 ===
                    A = 0x09; SetZN(A); TotalCycles += 2; PC = 0xF1B8;
                    goto case 0xF1B8;
                case 0xF1B7:
                    A |= 0xA0; SetZN(A); TotalCycles += 2; PC = 0xF1B9;
                    return;
                case 0xF1B8:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xF1BA;
                    goto case 0xF1BA;
                case 0xF1BA:
                    _ram[0x00] = X; TotalCycles += 3; PC = 0xF1BC;
                    goto case 0xF1BC;
                case 0xF1BB:
                    TotalCycles += 7; PushU16(0xF1BD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF1BC:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF1BD;
                    goto case 0xF1BD;
                case 0xF1BD:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0xF1BF;
                    goto case 0xF1BF;
                case 0xF1BE:
                    TotalCycles += 7; PushU16(0xF1C0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF1BF:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xF1C0;
                    goto case 0xF1C0;
                case 0xF1C0:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF1C1;
                    goto case 0xF1C1;
                case 0xF1C1:
                    PushU8(A); TotalCycles += 3; PC = 0xF1C2;
                    goto case 0xF1C2;
                case 0xF1C2:
                    TotalCycles += 6; PushU16(0xF1C4); PC = 0xF1D7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1D7;
                case 0xF1C4:
                    Sbc(ReadMem(ReadU16Zp(0x0A) + Y)); TotalCycles += 5; PC = 0xF1C6;
                    goto case 0xF1C6;
                case 0xF1C5:
                    A = Asl(A); TotalCycles += 2; PC = 0xF1C6;
                    goto case 0xF1C6;
                case 0xF1C6:
                    A = Asl(A); TotalCycles += 2; PC = 0xF1C7;
                    goto case 0xF1C7;
                case 0xF1C7:
                    A = Asl(A); TotalCycles += 2; PC = 0xF1C8;
                    goto case 0xF1C8;
                case 0xF1C8:
                    A = Asl(A); TotalCycles += 2; PC = 0xF1C9;
                    goto case 0xF1C9;
                case 0xF1C9:
                    A |= _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xF1CB;
                    goto case 0xF1CB;
                case 0xF1CA:
                    TotalCycles += 7; PushU16(0xF1CC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF1CB:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xF1CD;
                    goto case 0xF1CD;
                case 0xF1CC:
                    TotalCycles += 7; PushU16(0xF1CE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF1CD:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xF1CE;
                    goto case 0xF1CE;
                case 0xF1CE:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF1CF;
                    goto case 0xF1CF;
                case 0xF1CF:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xF1D1;
                    goto case 0xF1D1;
                case 0xF1D0:
                    TotalCycles += 7; PushU16(0xF1D2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF1D1:
                    _ram[(0x03D0 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF1D4;
                    goto case 0xF1D4;
                case 0xF1D2:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF1D7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF1D7; }
                    PC = 0xF1D4; goto case 0xF1D4;
                case 0xF1D4:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xF1D6;
                    goto case 0xF1D6;
                case 0xF1D5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF1D6;
                    goto case 0xF1D6;
                case 0xF1D6:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF1D7: // === SUBROUTINE: Sub_F1D7 ===
                    TotalCycles += 6; PushU16(0xF1D9); PC = 0xF1F6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF1F6;
                case 0xF1D8:
                    { byte z = (byte)(0xF1 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xF1DA;
                    goto case 0xF1DA;
                case 0xF1D9:
                    Sbc(ReadMem(ReadU16Zp(0x4A) + Y)); TotalCycles += 5; PC = 0xF1DB;
                    goto case 0xF1DB;
                case 0xF1DA:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF1DB;
                    goto case 0xF1DB;
                case 0xF1DB:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF1DC;
                    goto case 0xF1DC;
                case 0xF1DC:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF1DD;
                    goto case 0xF1DD;
                case 0xF1DD:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF1DE;
                    goto case 0xF1DE;
                case 0xF1DE:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xF1E0;
                    goto case 0xF1E0;
                case 0xF1DF:
                    TotalCycles += 7; PushU16(0xF1E1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF1E0:
                    TotalCycles += 3; PC = 0xF239;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF239;
                case 0xF1E1:
                    A &= ReadMem(0x7FF2 + Y); SetZN(A); TotalCycles += 4; PC = 0xF1E4;
                    return;
                case 0xF1E9:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0xF1EB;
                    return;
                case 0xF1EA:
                    TotalCycles += 7; PushU16(0xF1EC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF1EC:
                    Cmp(Y, 0xE0); TotalCycles += 2; PC = 0xF1EE;
                    goto case 0xF1EE;
                case 0xF1ED:
                    Cmp(X, 0xF0); TotalCycles += 2; PC = 0xF1EF;
                    goto case 0xF1EF;
                case 0xF1EE:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF1E8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF1F0; return;
                case 0xF1EF:
                    P |= FlagD; TotalCycles += 2; PC = 0xF1F0;
                    return;
                case 0xF1F1:
                    { int a = (0x07FF + X) & 0x07FF; _ram[a] = IncVal(_ram[a]); } TotalCycles += 7; PC = 0xF1F4;
                    return;
                case 0xF1F6: // === SUBROUTINE: Sub_F1F6 ===
                    _ram[0x04] = X; TotalCycles += 3; PC = 0xF1F8;
                    goto case 0xF1F8;
                case 0xF1F8:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xF1FA;
                    goto case 0xF1FA;
                case 0xF1F9:
                    A |= ReadMem(ReadU16Zp((byte)(0xB9 + X))); SetZN(A); TotalCycles += 6; PC = 0xF1FB;
                    return;
                case 0xF1FA:
                    A = _ram[(0x071C + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xF1FD;
                    goto case 0xF1FD;
                case 0xF1FD:
                    P |= FlagC; TotalCycles += 2; PC = 0xF1FE;
                    goto case 0xF1FE;
                case 0xF1FE:
                    Sbc(_ram[(byte)(0x86 + X)]); TotalCycles += 4; PC = 0xF200;
                    goto case 0xF200;
                case 0xF1FF:
                    _ram[0x85] = X; TotalCycles += 3; PC = 0xF201;
                    return;
                case 0xF200:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0xF202;
                    goto case 0xF202;
                case 0xF202:
                    A = _ram[(0x071A + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xF205;
                    goto case 0xF205;
                case 0xF205:
                    Sbc(_ram[(byte)(0x6D + X)]); TotalCycles += 4; PC = 0xF207;
                    goto case 0xF207;
                case 0xF206:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x73BE]); TotalCycles += 4; PC = 0xF209;
                    goto case 0xF209;
                case 0xF207:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x71F3 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xF20A;
                    goto case 0xF20A;
                case 0xF209:
                    Sbc(ReadMem(ReadU16Zp(0xC9) + Y)); TotalCycles += 5; PC = 0xF20B;
                    goto case 0xF20B;
                case 0xF20A:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xF20C;
                    goto case 0xF20C;
                case 0xF20B:
                    TotalCycles += 7; PushU16(0xF20D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF20C:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF21E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF21E; }
                    PC = 0xF20E; goto case 0xF20E;
                case 0xF20D:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF1CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF1CD; }
                    PC = 0xF20F; return;
                case 0xF20E:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x71F4 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xF211;
                    goto case 0xF211;
                case 0xF210:
                    Sbc(ReadMem(ReadU16Zp(0xC9) + Y)); TotalCycles += 5; PC = 0xF212;
                    goto case 0xF212;
                case 0xF211:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xF213;
                    goto case 0xF213;
                case 0xF212:
                    A |= ReadMem(ReadU16Zp((byte)(0x10 + X))); SetZN(A); TotalCycles += 6; PC = 0xF214;
                    goto case 0xF214;
                case 0xF213:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF21E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF21E; }
                    PC = 0xF215; goto case 0xF215;
                case 0xF214:
                    A |= 0xA9; SetZN(A); TotalCycles += 2; PC = 0xF216;
                    goto case 0xF216;
                case 0xF215:
                    A = 0x38; SetZN(A); TotalCycles += 2; PC = 0xF217;
                    goto case 0xF217;
                case 0xF216:
                    P |= FlagC; TotalCycles += 2; PC = 0xF217;
                    goto case 0xF217;
                case 0xF217:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0xF219;
                    goto case 0xF219;
                case 0xF218:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xF21A;
                    goto case 0xF21A;
                case 0xF219:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xF21B;
                    goto case 0xF21B;
                case 0xF21A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF21B;
                    goto case 0xF21B;
                case 0xF21B:
                    TotalCycles += 6; PushU16(0xF21D); PC = 0xF26D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF26D;
                case 0xF21C:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x3DF2]); TotalCycles += 4; PC = 0xF21F;
                    return;
                case 0xF21E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x71E3 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF221;
                    goto case 0xF221;
                case 0xF220:
                    Sbc(ReadMem(ReadU16Zp(0xA6) + Y)); TotalCycles += 5; PC = 0xF222;
                    return;
                case 0xF221:
                    X = _ram[0x04]; SetZN(X); TotalCycles += 3; PC = 0xF223;
                    goto case 0xF223;
                case 0xF223:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xF225;
                    goto case 0xF225;
                case 0xF224:
                    TotalCycles += 7; PushU16(0xF226); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF225:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF22A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF22A; }
                    PC = 0xF227; goto case 0xF227;
                case 0xF227:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xF228;
                    goto case 0xF228;
                case 0xF228:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF1FA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF1FA; }
                    PC = 0xF22A; goto case 0xF22A;
                case 0xF229:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF28B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF28B; }
                    PC = 0xF22B; goto case 0xF22B;
                case 0xF22A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF22B:
                    TotalCycles += 7; PushU16(0xF22D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF22C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF22D;
                    return;
                case 0xF22E:
                    _ram[0x070F] = Asl(_ram[0x070F]); TotalCycles += 6; PC = 0xF231;
                    return;
                case 0xF232:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0xF234;
                    return;
                case 0xF233:
                    TotalCycles += 7; PushU16(0xF235); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF235:
                    TotalCycles += 7; PushU16(0xF237); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF238:
                    TotalCycles += 7; PushU16(0xF23A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF239:
                    _ram[0x04] = X; TotalCycles += 3; PC = 0xF23B;
                    goto case 0xF23B;
                case 0xF23B:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xF23D;
                    goto case 0xF23D;
                case 0xF23C:
                    A |= ReadMem(ReadU16Zp((byte)(0xB9 + X))); SetZN(A); TotalCycles += 6; PC = 0xF23E;
                    return;
                case 0xF23D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7237 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF240;
                    goto case 0xF240;
                case 0xF240:
                    P |= FlagC; TotalCycles += 2; PC = 0xF241;
                    goto case 0xF241;
                case 0xF241:
                    Sbc(_ram[(byte)(0xCE + X)]); TotalCycles += 4; PC = 0xF243;
                    goto case 0xF243;
                case 0xF242:
                    _ram[0x0785] = DecVal(_ram[0x0785]); TotalCycles += 6; PC = 0xF245;
                    goto case 0xF245;
                case 0xF243:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0xF245;
                    goto case 0xF245;
                case 0xF245:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xF247;
                    goto case 0xF247;
                case 0xF246:
                    A |= ReadMem(ReadU16Zp((byte)(0xF5 + X))); SetZN(A); TotalCycles += 6; PC = 0xF248;
                    goto case 0xF248;
                case 0xF247:
                    Sbc(_ram[(byte)(0xB5 + X)]); TotalCycles += 4; PC = 0xF249;
                    goto case 0xF249;
                case 0xF248:
                    A = _ram[(byte)(0xBE + X)]; SetZN(A); TotalCycles += 4; PC = 0xF24A;
                    return;
                case 0xF249:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x7234 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xF24C;
                    goto case 0xF24C;
                case 0xF24C:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xF24E;
                    goto case 0xF24E;
                case 0xF24D:
                    TotalCycles += 7; PushU16(0xF24F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF24E:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF260; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF260; }
                    PC = 0xF250; goto case 0xF250;
                case 0xF24F:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF20F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF251; goto case 0xF251;
                case 0xF250:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x7235 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xF253;
                    goto case 0xF253;
                case 0xF251:
                    A &= _ram[(byte)(0xF2 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF253;
                    goto case 0xF253;
                case 0xF253:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xF255;
                    goto case 0xF255;
                case 0xF254:
                    A |= ReadMem(ReadU16Zp((byte)(0x10 + X))); SetZN(A); TotalCycles += 6; PC = 0xF256;
                    goto case 0xF256;
                case 0xF255:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF260; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF260; }
                    PC = 0xF257; goto case 0xF257;
                case 0xF256:
                    A |= 0xA9; SetZN(A); TotalCycles += 2; PC = 0xF258;
                    goto case 0xF258;
                case 0xF257:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0xF259;
                    goto case 0xF259;
                case 0xF258:
                    TotalCycles += 6; PushU16(0xF25A); PC = 0x0685;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF259:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0xF25B;
                    goto case 0xF25B;
                case 0xF25A:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xF25C;
                    return;
                case 0xF25B:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xF25D;
                    goto case 0xF25D;
                case 0xF25D:
                    TotalCycles += 6; PushU16(0xF25F); PC = 0xF26D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF26D;
                case 0xF25E:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x3DF2]); TotalCycles += 4; PC = 0xF261;
                    return;
                case 0xF260:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x722B + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF263;
                    goto case 0xF263;
                case 0xF263:
                    X = _ram[0x04]; SetZN(X); TotalCycles += 3; PC = 0xF265;
                    goto case 0xF265;
                case 0xF265:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xF267;
                    goto case 0xF267;
                case 0xF266:
                    TotalCycles += 7; PushU16(0xF268); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF267:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF26C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF26C; }
                    PC = 0xF269; goto case 0xF269;
                case 0xF269:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xF26A;
                    goto case 0xF26A;
                case 0xF26A:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF23D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF23D; }
                    PC = 0xF26C; goto case 0xF26C;
                case 0xF26B:
                    Cmp(A, ReadMem(ReadU16Zp(0x60) + Y)); TotalCycles += 5; PC = 0xF26D;
                    goto case 0xF26D;
                case 0xF26C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF26D: // === SUBROUTINE: Sub_F26D ===
                    _ram[0x05] = A; TotalCycles += 3; PC = 0xF26F;
                    goto case 0xF26F;
                case 0xF26E:
                    A |= _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0xF270;
                    return;
                case 0xF26F:
                    A = _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0xF271;
                    goto case 0xF271;
                case 0xF271:
                    Cmp(A, _ram[0x06]); TotalCycles += 3; PC = 0xF273;
                    goto case 0xF273;
                case 0xF272:
                    _ram[0xB0] = Asl(_ram[0xB0]); TotalCycles += 5; PC = 0xF274;
                    return;
                case 0xF273:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF281; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF281; }
                    PC = 0xF275; goto case 0xF275;
                case 0xF275:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF276;
                    goto case 0xF276;
                case 0xF276:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF277;
                    goto case 0xF277;
                case 0xF277:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF278;
                    goto case 0xF278;
                case 0xF278:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0xF27A;
                    goto case 0xF27A;
                case 0xF27A:
                    Cmp(Y, 0x01); TotalCycles += 2; PC = 0xF27C;
                    goto case 0xF27C;
                case 0xF27B:
                    A |= ReadMem(ReadU16Zp((byte)(0xB0 + X))); SetZN(A); TotalCycles += 6; PC = 0xF27D;
                    return;
                case 0xF27C:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF280; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF280; }
                    PC = 0xF27E; goto case 0xF27E;
                case 0xF27E:
                    Adc(_ram[0x05]); TotalCycles += 3; PC = 0xF280;
                    goto case 0xF280;
                case 0xF27F:
                    A |= _ram[0xAA]; SetZN(A); TotalCycles += 3; PC = 0xF281;
                    goto case 0xF281;
                case 0xF280:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xF281;
                    goto case 0xF281;
                case 0xF281:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF282:
                    A = _ram[0x03]; SetZN(A); TotalCycles += 3; PC = 0xF284;
                    goto case 0xF284;
                case 0xF284:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF285;
                    goto case 0xF285;
                case 0xF285:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF286;
                    goto case 0xF286;
                case 0xF286:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xF288;
                    goto case 0xF288;
                case 0xF287:
                    TotalCycles += 7; PushU16(0xF289); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF288:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF296; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF296; }
                    PC = 0xF28A; goto case 0xF28A;
                case 0xF28A:
                    _ram[(0x0205 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF28D;
                    goto case 0xF28D;
                case 0xF28B:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xF28D;
                    goto case 0xF28D;
                case 0xF28D:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0xF28F;
                    goto case 0xF28F;
                case 0xF28E:
                    A |= ReadMem(ReadU16Zp((byte)(0x99 + X))); SetZN(A); TotalCycles += 6; PC = 0xF290;
                    goto case 0xF290;
                case 0xF28F:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF292;
                    goto case 0xF292;
                case 0xF290:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xF292;
                    goto case 0xF292;
                case 0xF292:
                    A = 0x40; SetZN(A); TotalCycles += 2; PC = 0xF294;
                    goto case 0xF294;
                case 0xF293:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF294:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF2A0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF2A0; }
                    PC = 0xF296; goto case 0xF296;
                case 0xF295:
                    A = Asl(A); TotalCycles += 2; PC = 0xF296;
                    goto case 0xF296;
                case 0xF296:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF299;
                    goto case 0xF299;
                case 0xF297:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xF299;
                    goto case 0xF299;
                case 0xF299:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0xF29B;
                    goto case 0xF29B;
                case 0xF29A: // === SUBROUTINE: Sub_F29A ===
                    A |= ReadMem(ReadU16Zp((byte)(0x99 + X))); SetZN(A); TotalCycles += 6; PC = 0xF29C;
                    goto case 0xF29C;
                case 0xF29B:
                    _ram[(0x0205 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF29E;
                    goto case 0xF29E;
                case 0xF29C:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xF29E;
                    goto case 0xF29E;
                case 0xF29E:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF2A0;
                    goto case 0xF2A0;
                case 0xF29F:
                    TotalCycles += 7; PushU16(0xF2A1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF2A0:
                    A |= _ram[0x04]; SetZN(A); TotalCycles += 3; PC = 0xF2A2;
                    goto case 0xF2A2;
                case 0xF2A2:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF2A5;
                    goto case 0xF2A5;
                case 0xF2A5:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF2A8;
                    goto case 0xF2A8;
                case 0xF2A6:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0xF2A8;
                    goto case 0xF2A8;
                case 0xF2A8:
                    A = _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xF2AA;
                    goto case 0xF2AA;
                case 0xF2AA:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF2AD;
                    goto case 0xF2AD;
                case 0xF2AB:
                    TotalCycles += 7; PushU16(0xF2AD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF2AD:
                    _ram[(0x0204 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF2B0;
                    goto case 0xF2B0;
                case 0xF2B0:
                    A = _ram[0x05]; SetZN(A); TotalCycles += 3; PC = 0xF2B2;
                    goto case 0xF2B2;
                case 0xF2B1:
                    A |= _ram[0x99]; SetZN(A); TotalCycles += 3; PC = 0xF2B3;
                    return;
                case 0xF2B2:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF2B5;
                    goto case 0xF2B5;
                case 0xF2B5:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF2B6;
                    goto case 0xF2B6;
                case 0xF2B6:
                    Adc(0x08); TotalCycles += 2; PC = 0xF2B8;
                    goto case 0xF2B8;
                case 0xF2B7:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF2B8;
                    goto case 0xF2B8;
                case 0xF2B8:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF2BB;
                    goto case 0xF2BB;
                case 0xF2BB:
                    A = _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xF2BD;
                    goto case 0xF2BD;
                case 0xF2BD:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF2BE;
                    goto case 0xF2BE;
                case 0xF2BE:
                    Adc(0x08); TotalCycles += 2; PC = 0xF2C0;
                    goto case 0xF2C0;
                case 0xF2BF:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF2C0;
                    goto case 0xF2C0;
                case 0xF2C0:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xF2C2;
                    goto case 0xF2C2;
                case 0xF2C2:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF2C3;
                    goto case 0xF2C3;
                case 0xF2C3:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF2C4;
                    goto case 0xF2C4;
                case 0xF2C4:
                    Adc(0x08); TotalCycles += 2; PC = 0xF2C6;
                    goto case 0xF2C6;
                case 0xF2C5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF2C6;
                    goto case 0xF2C6;
                case 0xF2C6:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF2C7;
                    goto case 0xF2C7;
                case 0xF2C7:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xF2C8;
                    goto case 0xF2C8;
                case 0xF2C8:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xF2C9;
                    goto case 0xF2C9;
                case 0xF2C9:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF2D0: // === SUBROUTINE: SoundEngine ===
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0xF2D3;
                    goto case 0xF2D3;
                case 0xF2D1:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xF2DA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF2D3; goto case 0xF2D3;
                case 0xF2D3: // === SUBROUTINE: Sub_F2D3 ===
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF2D9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF2D9; }
                    PC = 0xF2D5; goto case 0xF2D5;
                case 0xF2D5:
                    WriteIoReg(0x4015, A); TotalCycles += 4; PC = 0xF2D8;
                    goto case 0xF2D8;
                case 0xF2D6:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF2D8;
                    goto case 0xF2D8;
                case 0xF2D7:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF2D8:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF2D9:
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0xF2DB;
                    goto case 0xF2DB;
                case 0xF2DB:
                    WriteIoReg(0x4017, A); TotalCycles += 4; PC = 0xF2DE;
                    goto case 0xF2DE;
                case 0xF2DD:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF2DE:
                    A = 0x0F; SetZN(A); TotalCycles += 2; PC = 0xF2E0;
                    goto case 0xF2E0;
                case 0xF2E0:
                    WriteIoReg(0x4015, A); TotalCycles += 4; PC = 0xF2E3;
                    goto case 0xF2E3;
                case 0xF2E1:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF2E3;
                    goto case 0xF2E3;
                case 0xF2E2:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF2E3:
                    A = _ram[0x07C6]; SetZN(A); TotalCycles += 4; PC = 0xF2E6;
                    goto case 0xF2E6;
                case 0xF2E4:
                    _ram[0x07] = DecVal(_ram[0x07]); TotalCycles += 5; PC = 0xF2E6;
                    goto case 0xF2E6;
                case 0xF2E6:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF2EE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF2EE; }
                    PC = 0xF2E8; goto case 0xF2E8;
                case 0xF2E7:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xF2E9;
                    return;
                case 0xF2E8:
                    A = _ram[0xFA]; SetZN(A); TotalCycles += 3; PC = 0xF2EA;
                    goto case 0xF2EA;
                case 0xF2EA:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xF2EC;
                    goto case 0xF2EC;
                case 0xF2EB:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0xF2ED;
                    goto case 0xF2ED;
                case 0xF2EC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF34B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF34B; }
                    PC = 0xF2EE; goto case 0xF2EE;
                case 0xF2ED:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x32AD + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF2F0;
                    return;
                case 0xF2EE:
                    A = _ram[0x07B2]; SetZN(A); TotalCycles += 4; PC = 0xF2F1;
                    goto case 0xF2F1;
                case 0xF2F1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF316; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF316; }
                    PC = 0xF2F3; goto case 0xF2F3;
                case 0xF2F3:
                    A = _ram[0xFA]; SetZN(A); TotalCycles += 3; PC = 0xF2F5;
                    goto case 0xF2F5;
                case 0xF2F5:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF35D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF35D; }
                    PC = 0xF2F7; goto case 0xF2F7;
                case 0xF2F6:
                    _ram[0x8D] = Ror(_ram[0x8D]); TotalCycles += 5; PC = 0xF2F8;
                    return;
                case 0xF2F7:
                    _ram[0x07B2] = A; TotalCycles += 4; PC = 0xF2FA;
                    goto case 0xF2FA;
                case 0xF2FA:
                    _ram[0x07C6] = A; TotalCycles += 4; PC = 0xF2FD;
                    goto case 0xF2FD;
                case 0xF2FB:
                    _ram[0x07] = DecVal(_ram[0x07]); TotalCycles += 5; PC = 0xF2FD;
                    goto case 0xF2FD;
                case 0xF2FD:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF2FF;
                    goto case 0xF2FF;
                case 0xF2FE:
                    TotalCycles += 7; PushU16(0xF300); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF2FF:
                    WriteIoReg(0x4015, A); TotalCycles += 4; PC = 0xF302;
                    goto case 0xF302;
                case 0xF300:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF302;
                    goto case 0xF302;
                case 0xF301:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF302:
                    _ram[0xF1] = A; TotalCycles += 3; PC = 0xF304;
                    goto case 0xF304;
                case 0xF303:
                    Sbc(ReadMem(ReadU16Zp(0x85) + Y)); TotalCycles += 5; PC = 0xF305;
                    return;
                case 0xF304:
                    _ram[0xF2] = A; TotalCycles += 3; PC = 0xF306;
                    goto case 0xF306;
                case 0xF306:
                    _ram[0xF3] = A; TotalCycles += 3; PC = 0xF308;
                    goto case 0xF308;
                case 0xF308:
                    A = 0x0F; SetZN(A); TotalCycles += 2; PC = 0xF30A;
                    goto case 0xF30A;
                case 0xF30A:
                    WriteIoReg(0x4015, A); TotalCycles += 4; PC = 0xF30D;
                    goto case 0xF30D;
                case 0xF30B:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF30D;
                    goto case 0xF30D;
                case 0xF30C:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF30D:
                    A = 0x2A; SetZN(A); TotalCycles += 2; PC = 0xF30F;
                    goto case 0xF30F;
                case 0xF30E:
                    A = Rol(A); TotalCycles += 2; PC = 0xF30F;
                    goto case 0xF30F;
                case 0xF30F:
                    _ram[0x07BB] = A; TotalCycles += 4; PC = 0xF312;
                    goto case 0xF312;
                case 0xF312:
                    A = 0x44; SetZN(A); TotalCycles += 2; PC = 0xF314;
                    goto case 0xF314;
                case 0xF314:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF327; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF327; }
                    PC = 0xF316; goto case 0xF316;
                case 0xF315:
                    A |= ReadMem(ReadU16Zp(0xAD) + Y); SetZN(A); TotalCycles += 5; PC = 0xF317;
                    return;
                case 0xF316:
                    A = _ram[0x07BB]; SetZN(A); TotalCycles += 4; PC = 0xF319;
                    goto case 0xF319;
                case 0xF319:
                    Cmp(A, 0x24); TotalCycles += 2; PC = 0xF31B;
                    goto case 0xF31B;
                case 0xF31A:
                    Bit(_ram[0xF0]); TotalCycles += 3; PC = 0xF31C;
                    goto case 0xF31C;
                case 0xF31B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF325; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF325; }
                    PC = 0xF31D; goto case 0xF31D;
                case 0xF31C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF31D;
                    goto case 0xF31D;
                case 0xF31D:
                    Cmp(A, 0x1E); TotalCycles += 2; PC = 0xF31F;
                    goto case 0xF31F;
                case 0xF31E:
                    { int a = 0xF1F0 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xF321;
                    goto case 0xF321;
                case 0xF31F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF312; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF312; }
                    PC = 0xF321; goto case 0xF321;
                case 0xF320:
                    Sbc(ReadMem(ReadU16Zp(0xC9) + Y)); TotalCycles += 5; PC = 0xF322;
                    goto case 0xF322;
                case 0xF321:
                    Cmp(A, 0x18); TotalCycles += 2; PC = 0xF323;
                    goto case 0xF323;
                case 0xF322:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF323;
                    goto case 0xF323;
                case 0xF323:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF32E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF32E; }
                    PC = 0xF325; goto case 0xF325;
                case 0xF324:
                    A |= 0xA9; SetZN(A); TotalCycles += 2; PC = 0xF326;
                    return;
                case 0xF325:
                    A = 0x64; SetZN(A); TotalCycles += 2; PC = 0xF327;
                    goto case 0xF327;
                case 0xF327:
                    X = 0x84; SetZN(X); TotalCycles += 2; PC = 0xF329;
                    goto case 0xF329;
                case 0xF328:
                    _ram[0xA0] = Y; TotalCycles += 3; PC = 0xF32A;
                    return;
                case 0xF329:
                    Y = 0x7F; SetZN(Y); TotalCycles += 2; PC = 0xF32B;
                    goto case 0xF32B;
                case 0xF32B:
                    TotalCycles += 6; PushU16(0xF32D); PC = 0xF388;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF388;
                case 0xF32C:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xF32D;
                    return;
                case 0xF32E:
                    _ram[0x07BB] = DecVal(_ram[0x07BB]); TotalCycles += 6; PC = 0xF331;
                    goto case 0xF331;
                case 0xF331:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF35D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF35D; }
                    PC = 0xF333; goto case 0xF333;
                case 0xF332:
                    A = Rol(A); TotalCycles += 2; PC = 0xF333;
                    goto case 0xF333;
                case 0xF333:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF335;
                    goto case 0xF335;
                case 0xF334:
                    TotalCycles += 7; PushU16(0xF336); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF335:
                    WriteIoReg(0x4015, A); TotalCycles += 4; PC = 0xF338;
                    goto case 0xF338;
                case 0xF336:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF338;
                    goto case 0xF338;
                case 0xF337:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF338:
                    A = _ram[0x07B2]; SetZN(A); TotalCycles += 4; PC = 0xF33B;
                    goto case 0xF33B;
                case 0xF33B:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xF33D;
                    goto case 0xF33D;
                case 0xF33D:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF344; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF344; }
                    PC = 0xF33F; goto case 0xF33F;
                case 0xF33E:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xF340;
                    goto case 0xF340;
                case 0xF33F:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF341;
                    goto case 0xF341;
                case 0xF340:
                    TotalCycles += 7; PushU16(0xF342); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF341:
                    _ram[0x07C6] = A; TotalCycles += 4; PC = 0xF344;
                    goto case 0xF344;
                case 0xF342:
                    _ram[0x07] = DecVal(_ram[0x07]); TotalCycles += 5; PC = 0xF344;
                    goto case 0xF344;
                case 0xF344:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF346;
                    goto case 0xF346;
                case 0xF345:
                    TotalCycles += 7; PushU16(0xF347); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF346:
                    _ram[0x07B2] = A; TotalCycles += 4; PC = 0xF349;
                    goto case 0xF349;
                case 0xF349:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF35D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF35D; }
                    PC = 0xF34B; goto case 0xF34B;
                case 0xF34B:
                    TotalCycles += 6; PushU16(0xF34D); PC = 0xF41B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF41B;
                case 0xF34E:
                    TotalCycles += 6; PushU16(0xF350); PC = 0xF57C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF57C;
                case 0xF350:
                    Sbc(_ram[(byte)(0x20 + X)]); TotalCycles += 4; PC = 0xF352;
                    return;
                case 0xF351:
                    TotalCycles += 6; PushU16(0xF353); PC = 0xF667;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF667;
                case 0xF353:
                    { byte z = (byte)(0x20 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xF355;
                    goto case 0xF355;
                case 0xF354:
                    TotalCycles += 6; PushU16(0xF356); PC = 0xF694;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF694;
                case 0xF355:
                    _ram[(byte)(0xF6 + X)] = Y; TotalCycles += 4; PC = 0xF357;
                    goto case 0xF357;
                case 0xF356:
                    { byte z = (byte)(0xA9 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xF358;
                    goto case 0xF358;
                case 0xF357:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF359;
                    goto case 0xF359;
                case 0xF358:
                    TotalCycles += 7; PushU16(0xF35A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF359:
                    _ram[0xFB] = A; TotalCycles += 3; PC = 0xF35B;
                    goto case 0xF35B;
                case 0xF35B:
                    _ram[0xFC] = A; TotalCycles += 3; PC = 0xF35D;
                    goto case 0xF35D;
                case 0xF35D:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF35F;
                    goto case 0xF35F;
                case 0xF35E:
                    TotalCycles += 7; PushU16(0xF360); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF35F:
                    _ram[0xFF] = A; TotalCycles += 3; PC = 0xF361;
                    goto case 0xF361;
                case 0xF361:
                    _ram[0xFE] = A; TotalCycles += 3; PC = 0xF363;
                    goto case 0xF363;
                case 0xF362:
                    { int a = 0xFD85 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF365;
                    goto case 0xF365;
                case 0xF363:
                    _ram[0xFD] = A; TotalCycles += 3; PC = 0xF365;
                    goto case 0xF365;
                case 0xF364:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7A85 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xF367;
                    goto case 0xF367;
                case 0xF365:
                    _ram[0xFA] = A; TotalCycles += 3; PC = 0xF367;
                    goto case 0xF367;
                case 0xF367:
                    Y = _ram[0x07C0]; SetZN(Y); TotalCycles += 4; PC = 0xF36A;
                    goto case 0xF36A;
                case 0xF368:
                    Cmp(Y, 0x07); TotalCycles += 2; PC = 0xF36A;
                    goto case 0xF36A;
                case 0xF36A:
                    A = _ram[0xF4]; SetZN(A); TotalCycles += 3; PC = 0xF36C;
                    goto case 0xF36C;
                case 0xF36C:
                    A &= 0x03; SetZN(A); TotalCycles += 2; PC = 0xF36E;
                    goto case 0xF36E;
                case 0xF36E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF377; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF377; }
                    PC = 0xF370; goto case 0xF370;
                case 0xF370:
                    _ram[0x07C0] = IncVal(_ram[0x07C0]); TotalCycles += 6; PC = 0xF373;
                    goto case 0xF373;
                case 0xF371:
                    Cmp(Y, 0x07); TotalCycles += 2; PC = 0xF373;
                    goto case 0xF373;
                case 0xF373:
                    Cmp(Y, 0x30); TotalCycles += 2; PC = 0xF375;
                    goto case 0xF375;
                case 0xF374:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF306; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF306; }
                    PC = 0xF376; goto case 0xF376;
                case 0xF375:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF37D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF37D; }
                    PC = 0xF377; goto case 0xF377;
                case 0xF376:
                    _ram[0x98] = Asl(_ram[0x98]); TotalCycles += 5; PC = 0xF378;
                    goto case 0xF378;
                case 0xF377:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF378;
                    goto case 0xF378;
                case 0xF378:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF37D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF37D; }
                    PC = 0xF37A; goto case 0xF37A;
                case 0xF37A:
                    _ram[0x07C0] = DecVal(_ram[0x07C0]); TotalCycles += 6; PC = 0xF37D;
                    goto case 0xF37D;
                case 0xF37B:
                    Cmp(Y, 0x07); TotalCycles += 2; PC = 0xF37D;
                    goto case 0xF37D;
                case 0xF37D:
                    WriteIoReg(0x4011, Y); TotalCycles += 4; PC = 0xF380;
                    goto case 0xF380;
                case 0xF37E:
                    A |= ReadMem(ReadU16Zp(0x40) + Y); SetZN(A); TotalCycles += 5; PC = 0xF380;
                    goto case 0xF380;
                case 0xF37F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF380:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF381: // === SUBROUTINE: PlayBrickShatter ===
                    WriteIoReg(0x4001, Y); TotalCycles += 4; PC = 0xF384;
                    goto case 0xF384;
                case 0xF382:
                    A |= ReadMem(ReadU16Zp((byte)(0x40 + X))); SetZN(A); TotalCycles += 6; PC = 0xF384;
                    goto case 0xF384;
                case 0xF383:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF384:
                    WriteIoReg(0x4000, X); TotalCycles += 4; PC = 0xF387;
                    goto case 0xF387;
                case 0xF385:
                    TotalCycles += 7; PushU16(0xF387); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF386:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF387:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF388: // === SUBROUTINE: PlaySqu2Sfx ===
                    TotalCycles += 6; PushU16(0xF38A); PC = 0xF381;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF381;
                case 0xF389:
                    WriteMem(ReadU16Zp((byte)(0xF3 + X)), A); TotalCycles += 6; PC = 0xF38B;
                    goto case 0xF38B;
                case 0xF38B: // === SUBROUTINE: FUN_f38b ===
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xF38D;
                    goto case 0xF38D;
                case 0xF38C:
                    TotalCycles += 7; PushU16(0xF38E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF38D:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF38E;
                    goto case 0xF38E;
                case 0xF38E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7F01 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF391;
                    goto case 0xF391;
                case 0xF38F:
                    A |= ReadMem(ReadU16Zp((byte)(0xFF + X))); SetZN(A); TotalCycles += 6; PC = 0xF391;
                    goto case 0xF391;
                case 0xF391:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF39E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF39E; }
                    PC = 0xF393; goto case 0xF393;
                case 0xF393:
                    WriteMem(0x4002 + X, A); TotalCycles += 5; PC = 0xF396;
                    goto case 0xF396;
                case 0xF395:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF396:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7F00 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF399;
                    goto case 0xF399;
                case 0xF397:
                    TotalCycles += 7; PushU16(0xF399); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF399:
                    A |= 0x08; SetZN(A); TotalCycles += 2; PC = 0xF39B;
                    goto case 0xF39B;
                case 0xF39A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF39B;
                    goto case 0xF39B;
                case 0xF39B:
                    WriteMem(0x4003 + X, A); TotalCycles += 5; PC = 0xF39E;
                    goto case 0xF39E;
                case 0xF39D:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF39E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF39F: // === SUBROUTINE: PlaySfx1 ===
                    WriteIoReg(0x4004, X); TotalCycles += 4; PC = 0xF3A2;
                    goto case 0xF3A2;
                case 0xF3A1:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF3A2:
                    WriteIoReg(0x4005, Y); TotalCycles += 4; PC = 0xF3A5;
                    goto case 0xF3A5;
                case 0xF3A3:
                    A |= _ram[0x40]; SetZN(A); TotalCycles += 3; PC = 0xF3A5;
                    goto case 0xF3A5;
                case 0xF3A4:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF3A5:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF3A6: // === SUBROUTINE: PlaySmallJump ===
                    TotalCycles += 6; PushU16(0xF3A8); PC = 0xF39F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF39F;
                case 0xF3A9: // === SUBROUTINE: PlayBigJump ===
                    X = 0x04; SetZN(X); TotalCycles += 2; PC = 0xF3AB;
                    goto case 0xF3AB;
                case 0xF3AB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF38D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF38D; }
                    PC = 0xF3AD; goto case 0xF3AD;
                case 0xF3AC:
                    Cmp(X, 0xA2); TotalCycles += 2; PC = 0xF3AE;
                    goto case 0xF3AE;
                case 0xF3AD: // === SUBROUTINE: PlayBump ===
                    X = 0x08; SetZN(X); TotalCycles += 2; PC = 0xF3AF;
                    goto case 0xF3AF;
                case 0xF3AE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF3AF;
                    goto case 0xF3AF;
                case 0xF3AF:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF38D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF38D; }
                    PC = 0xF3B1; return;
                case 0xF3B3:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF3B4;
                    goto case 0xF3B4;
                case 0xF3B4:
                    _ram[(byte)(0x95 + Y)] = X; TotalCycles += 4; PC = 0xF3B6;
                    goto case 0xF3B6;
                case 0xF3B5:
                    _ram[(byte)(0x94 + X)] = A; TotalCycles += 4; PC = 0xF3B7;
                    return;
                case 0xF3B6:
                    _ram[(byte)(0x92 + X)] = Y; TotalCycles += 4; PC = 0xF3B8;
                    goto case 0xF3B8;
                case 0xF3B8:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF34A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF3BA; goto case 0xF3BA;
                case 0xF3B9:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF355; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF355; }
                    PC = 0xF3BB; return;
                case 0xF3BA:
                    SP = X; TotalCycles += 2; PC = 0xF3BB;
                    return;
                case 0xF3BC:
                    _ram[(byte)(0x93 + X)] = A; TotalCycles += 4; PC = 0xF3BE;
                    return;
                case 0xF3BF:
                    A = 0x40; SetZN(A); TotalCycles += 2; PC = 0xF3C1;
                    goto case 0xF3C1;
                case 0xF3C0:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF3C1:
                    _ram[0x07BB] = A; TotalCycles += 4; PC = 0xF3C4;
                    goto case 0xF3C4;
                case 0xF3C4:
                    A = 0x62; SetZN(A); TotalCycles += 2; PC = 0xF3C6;
                    goto case 0xF3C6;
                case 0xF3C6:
                    TotalCycles += 6; PushU16(0xF3C8); PC = 0xF38B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF38B;
                case 0xF3C9:
                    X = 0x99; SetZN(X); TotalCycles += 2; PC = 0xF3CB;
                    goto case 0xF3CB;
                case 0xF3CA:
                    WriteMem(0x25D0 + Y, A); TotalCycles += 5; PC = 0xF3CD;
                    goto case 0xF3CD;
                case 0xF3CB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF3F2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3F2; }
                    PC = 0xF3CD; goto case 0xF3CD;
                case 0xF3CC:
                    A &= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xF3CE;
                    goto case 0xF3CE;
                case 0xF3CD:
                    A = 0x26; SetZN(A); TotalCycles += 2; PC = 0xF3CF;
                    goto case 0xF3CF;
                case 0xF3CE:
                    _ram[0xD0] = Rol(_ram[0xD0]); TotalCycles += 5; PC = 0xF3D0;
                    return;
                case 0xF3CF:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF3D3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3D3; }
                    PC = 0xF3D1; goto case 0xF3D1;
                case 0xF3D1:
                    A = 0x18; SetZN(A); TotalCycles += 2; PC = 0xF3D3;
                    goto case 0xF3D3;
                case 0xF3D2:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF3D3;
                    goto case 0xF3D3;
                case 0xF3D3:
                    X = 0x82; SetZN(X); TotalCycles += 2; PC = 0xF3D5;
                    goto case 0xF3D5;
                case 0xF3D5:
                    Y = 0xA7; SetZN(Y); TotalCycles += 2; PC = 0xF3D7;
                    goto case 0xF3D7;
                case 0xF3D7:
                    TotalCycles += 6; PushU16(0xF3D9); PC = 0xF388;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF388;
                case 0xF3D8:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xF3D9;
                    return;
                case 0xF3DA:
                    A = 0x28; SetZN(A); TotalCycles += 2; PC = 0xF3DC;
                    goto case 0xF3DC;
                case 0xF3DB:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xF3DC;
                    goto case 0xF3DC;
                case 0xF3DC:
                    _ram[0x07BB] = A; TotalCycles += 4; PC = 0xF3DF;
                    goto case 0xF3DF;
                case 0xF3DF:
                    A = _ram[0x07BB]; SetZN(A); TotalCycles += 4; PC = 0xF3E2;
                    goto case 0xF3E2;
                case 0xF3E2:
                    Cmp(A, 0x25); TotalCycles += 2; PC = 0xF3E4;
                    goto case 0xF3E4;
                case 0xF3E3:
                    A &= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xF3E5;
                    goto case 0xF3E5;
                case 0xF3E4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF3EC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3EC; }
                    PC = 0xF3E6; goto case 0xF3E6;
                case 0xF3E5:
                    _ram[0xA2] = Asl(_ram[0xA2]); TotalCycles += 5; PC = 0xF3E7;
                    return;
                case 0xF3E6:
                    X = 0x5F; SetZN(X); TotalCycles += 2; PC = 0xF3E8;
                    goto case 0xF3E8;
                case 0xF3E8:
                    Y = 0xF6; SetZN(Y); TotalCycles += 2; PC = 0xF3EA;
                    goto case 0xF3EA;
                case 0xF3E9:
                    { byte z = (byte)(0xD0 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xF3EB;
                    goto case 0xF3EB;
                case 0xF3EA:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF3F4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3F4; }
                    PC = 0xF3EC; goto case 0xF3EC;
                case 0xF3EB:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF3EC;
                    goto case 0xF3EC;
                case 0xF3EC:
                    Cmp(A, 0x20); TotalCycles += 2; PC = 0xF3EE;
                    goto case 0xF3EE;
                case 0xF3ED:
                    TotalCycles += 6; PushU16(0xF3EF); PC = 0x29D0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF3EE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF419; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF419; }
                    PC = 0xF3F0; goto case 0xF3F0;
                case 0xF3EF:
                    A &= 0xA2; SetZN(A); TotalCycles += 2; PC = 0xF3F1;
                    goto case 0xF3F1;
                case 0xF3F0:
                    X = 0x48; SetZN(X); TotalCycles += 2; PC = 0xF3F2;
                    goto case 0xF3F2;
                case 0xF3F1:
                    PushU8(A); TotalCycles += 3; PC = 0xF3F2;
                    goto case 0xF3F2;
                case 0xF3F2:
                    Y = 0xBC; SetZN(Y); TotalCycles += 2; PC = 0xF3F4;
                    goto case 0xF3F4;
                case 0xF3F3:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x0120 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xF3F6;
                    return;
                case 0xF3F4:
                    TotalCycles += 6; PushU16(0xF3F6); PC = 0xF381;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF381;
                case 0xF3F5:
                    WriteMem(ReadU16Zp((byte)(0xF3 + X)), A); TotalCycles += 6; PC = 0xF3F7;
                    goto case 0xF3F7;
                case 0xF3F7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF419; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF419; }
                    PC = 0xF3F9; goto case 0xF3F9;
                case 0xF3F8:
                    TotalCycles += 6; PushU16(0xF3FA); PC = 0x05A9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF3F9:
                    A = 0x05; SetZN(A); TotalCycles += 2; PC = 0xF3FB;
                    goto case 0xF3FB;
                case 0xF3FA:
                    A |= _ram[0xA0]; SetZN(A); TotalCycles += 3; PC = 0xF3FC;
                    goto case 0xF3FC;
                case 0xF3FB:
                    Y = 0x99; SetZN(Y); TotalCycles += 2; PC = 0xF3FD;
                    goto case 0xF3FD;
                case 0xF3FC:
                    _ram[(0x04D0 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xF3FF;
                    goto case 0xF3FF;
                case 0xF3FD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF403; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF403; }
                    PC = 0xF3FF; goto case 0xF3FF;
                case 0xF3FF:
                    A = 0x0A; SetZN(A); TotalCycles += 2; PC = 0xF401;
                    goto case 0xF401;
                case 0xF400:
                    A = Asl(A); TotalCycles += 2; PC = 0xF401;
                    goto case 0xF401;
                case 0xF401:
                    Y = 0x93; SetZN(Y); TotalCycles += 2; PC = 0xF403;
                    goto case 0xF403;
                case 0xF403:
                    X = 0x9E; SetZN(X); TotalCycles += 2; PC = 0xF405;
                    goto case 0xF405;
                case 0xF405:
                    _ram[0x07BB] = A; TotalCycles += 4; PC = 0xF408;
                    goto case 0xF408;
                case 0xF408:
                    A = 0x0C; SetZN(A); TotalCycles += 2; PC = 0xF40A;
                    goto case 0xF40A;
                case 0xF40A:
                    TotalCycles += 6; PushU16(0xF40C); PC = 0xF388;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF388;
                case 0xF40B:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xF40C;
                    return;
                case 0xF40D:
                    A = _ram[0x07BB]; SetZN(A); TotalCycles += 4; PC = 0xF410;
                    goto case 0xF410;
                case 0xF410:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0xF412;
                    goto case 0xF412;
                case 0xF411:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xF413;
                    goto case 0xF413;
                case 0xF412:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF419; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF419; }
                    PC = 0xF414; goto case 0xF414;
                case 0xF413:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xF415;
                    return;
                case 0xF414:
                    A = 0xBB; SetZN(A); TotalCycles += 2; PC = 0xF416;
                    goto case 0xF416;
                case 0xF416:
                    WriteIoReg(0x4001, A); TotalCycles += 4; PC = 0xF419;
                    goto case 0xF419;
                case 0xF417:
                    A |= ReadMem(ReadU16Zp((byte)(0x40 + X))); SetZN(A); TotalCycles += 6; PC = 0xF419;
                    goto case 0xF419;
                case 0xF418:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF419:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF47B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF47B; }
                    PC = 0xF41B; goto case 0xF41B;
                case 0xF41A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF41B: // === SUBROUTINE: ContinueSfx1 ===
                    Y = _ram[0xFF]; SetZN(Y); TotalCycles += 3; PC = 0xF41D;
                    goto case 0xF41D;
                case 0xF41D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF43F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF43F; }
                    PC = 0xF41F; goto case 0xF41F;
                case 0xF41E:
                    TotalCycles += 6; PushU16(0xF420); PC = 0xF184;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF184;
                case 0xF41F:
                    _ram[0xF1] = Y; TotalCycles += 3; PC = 0xF421;
                    goto case 0xF421;
                case 0xF420:
                    Sbc(ReadMem(ReadU16Zp(0x30) + Y)); TotalCycles += 5; PC = 0xF422;
                    goto case 0xF422;
                case 0xF421:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF3CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3CD; }
                    PC = 0xF423; goto case 0xF423;
                case 0xF422:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xF423;
                    goto case 0xF423;
                case 0xF423:
                    _ram[0xFF] = Lsr(_ram[0xFF]); TotalCycles += 5; PC = 0xF425;
                    goto case 0xF425;
                case 0xF425:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF3D1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3D1; }
                    PC = 0xF427; goto case 0xF427;
                case 0xF426:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xF427;
                    goto case 0xF427;
                case 0xF427:
                    _ram[0xFF] = Lsr(_ram[0xFF]); TotalCycles += 5; PC = 0xF429;
                    goto case 0xF429;
                case 0xF429:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF3FF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3FF; }
                    PC = 0xF42B; goto case 0xF42B;
                case 0xF42B:
                    _ram[0xFF] = Lsr(_ram[0xFF]); TotalCycles += 5; PC = 0xF42D;
                    goto case 0xF42D;
                case 0xF42D:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF45B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF45B; }
                    PC = 0xF42F; goto case 0xF42F;
                case 0xF42E:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x7F46]); TotalCycles += 4; PC = 0xF431;
                    goto case 0xF431;
                case 0xF42F:
                    _ram[0xFF] = Lsr(_ram[0xFF]); TotalCycles += 5; PC = 0xF431;
                    goto case 0xF431;
                case 0xF431:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF47D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF47D; }
                    PC = 0xF433; goto case 0xF433;
                case 0xF432:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF433;
                    goto case 0xF433;
                case 0xF433:
                    _ram[0xFF] = Lsr(_ram[0xFF]); TotalCycles += 5; PC = 0xF435;
                    goto case 0xF435;
                case 0xF435:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF4B6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF4B6; }
                    PC = 0xF437; goto case 0xF437;
                case 0xF437:
                    _ram[0xFF] = Lsr(_ram[0xFF]); TotalCycles += 5; PC = 0xF439;
                    goto case 0xF439;
                case 0xF439:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF3F9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3F9; }
                    PC = 0xF43B; goto case 0xF43B;
                case 0xF43A:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x7F46 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xF43D;
                    goto case 0xF43D;
                case 0xF43B:
                    _ram[0xFF] = Lsr(_ram[0xFF]); TotalCycles += 5; PC = 0xF43D;
                    goto case 0xF43D;
                case 0xF43D:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF3BF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3BF; }
                    PC = 0xF43F; goto case 0xF43F;
                case 0xF43F:
                    A = _ram[0xF1]; SetZN(A); TotalCycles += 3; PC = 0xF441;
                    goto case 0xF441;
                case 0xF440:
                    Sbc(ReadMem(ReadU16Zp(0xF0) + Y)); TotalCycles += 5; PC = 0xF442;
                    return;
                case 0xF441:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF45A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF45A; }
                    PC = 0xF443; goto case 0xF443;
                case 0xF443:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF3DF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3DF; }
                    PC = 0xF445; goto case 0xF445;
                case 0xF444:
                    SP = X; TotalCycles += 2; PC = 0xF445;
                    goto case 0xF445;
                case 0xF445:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF446;
                    goto case 0xF446;
                case 0xF446:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF3DF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF3DF; }
                    PC = 0xF448; goto case 0xF448;
                case 0xF448:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF449;
                    goto case 0xF449;
                case 0xF449:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF40D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF40D; }
                    PC = 0xF44B; goto case 0xF44B;
                case 0xF44B:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF44C;
                    goto case 0xF44C;
                case 0xF44C:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF469; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF469; }
                    PC = 0xF44E; goto case 0xF44E;
                case 0xF44E:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF44F;
                    goto case 0xF44F;
                case 0xF44F:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF48D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF48D; }
                    PC = 0xF451; goto case 0xF451;
                case 0xF451:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF452;
                    goto case 0xF452;
                case 0xF452:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF4BB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF4BB; }
                    PC = 0xF454; goto case 0xF454;
                case 0xF454:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF455;
                    goto case 0xF455;
                case 0xF455:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF40D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF40D; }
                    PC = 0xF457; goto case 0xF457;
                case 0xF456:
                    X = _ram[(byte)(0x4A + Y)]; SetZN(X); TotalCycles += 4; PC = 0xF458;
                    goto case 0xF458;
                case 0xF457:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF458;
                    goto case 0xF458;
                case 0xF458:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF4A2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF4A2; }
                    PC = 0xF45A; goto case 0xF45A;
                case 0xF459:
                    PushU8(A); TotalCycles += 3; PC = 0xF45A;
                    goto case 0xF45A;
                case 0xF45A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF45B:
                    A = 0x0E; SetZN(A); TotalCycles += 2; PC = 0xF45D;
                    goto case 0xF45D;
                case 0xF45C:
                    { int a = 0xBB8D; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xF45F;
                    return;
                case 0xF45D:
                    _ram[0x07BB] = A; TotalCycles += 4; PC = 0xF460;
                    goto case 0xF460;
                case 0xF460:
                    Y = 0x9C; SetZN(Y); TotalCycles += 2; PC = 0xF462;
                    goto case 0xF462;
                case 0xF462:
                    X = 0x9E; SetZN(X); TotalCycles += 2; PC = 0xF464;
                    goto case 0xF464;
                case 0xF464:
                    A = 0x26; SetZN(A); TotalCycles += 2; PC = 0xF466;
                    goto case 0xF466;
                case 0xF465:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xF467;
                    goto case 0xF467;
                case 0xF466:
                    TotalCycles += 6; PushU16(0xF468); PC = 0xF388;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF388;
                case 0xF467:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xF468;
                    return;
                case 0xF469:
                    Y = _ram[0x07BB]; SetZN(Y); TotalCycles += 4; PC = 0xF46C;
                    goto case 0xF46C;
                case 0xF46C:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x73B0 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF46F;
                    goto case 0xF46F;
                case 0xF46D:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF462; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF462; }
                    PC = 0xF46F; goto case 0xF46F;
                case 0xF46F:
                    WriteIoReg(0x4000, A); TotalCycles += 4; PC = 0xF472;
                    goto case 0xF472;
                case 0xF470:
                    TotalCycles += 7; PushU16(0xF472); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF471:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF472:
                    Cmp(Y, 0x06); TotalCycles += 2; PC = 0xF474;
                    goto case 0xF474;
                case 0xF473:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xF475;
                    goto case 0xF475;
                case 0xF474:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF47B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF47B; }
                    PC = 0xF476; goto case 0xF476;
                case 0xF475:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xF477;
                    return;
                case 0xF476:
                    A = 0x9E; SetZN(A); TotalCycles += 2; PC = 0xF478;
                    goto case 0xF478;
                case 0xF478:
                    WriteIoReg(0x4002, A); TotalCycles += 4; PC = 0xF47B;
                    goto case 0xF47B;
                case 0xF47A:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF47B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF4A2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF4A2; }
                    PC = 0xF47D; goto case 0xF47D;
                case 0xF47C:
                    A &= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xF47E;
                    goto case 0xF47E;
                case 0xF47D:
                    A = 0x0E; SetZN(A); TotalCycles += 2; PC = 0xF47F;
                    goto case 0xF47F;
                case 0xF47E:
                    { int a = 0xCBA0; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xF481;
                    goto case 0xF481;
                case 0xF47F:
                    Y = 0xCB; SetZN(Y); TotalCycles += 2; PC = 0xF481;
                    goto case 0xF481;
                case 0xF481:
                    X = 0x9F; SetZN(X); TotalCycles += 2; PC = 0xF483;
                    goto case 0xF483;
                case 0xF483:
                    _ram[0x07BB] = A; TotalCycles += 4; PC = 0xF486;
                    goto case 0xF486;
                case 0xF486:
                    A = 0x28; SetZN(A); TotalCycles += 2; PC = 0xF488;
                    goto case 0xF488;
                case 0xF487:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xF488;
                    goto case 0xF488;
                case 0xF488:
                    TotalCycles += 6; PushU16(0xF48A); PC = 0xF388;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF388;
                case 0xF489:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xF48A;
                    return;
                case 0xF48B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF4A2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF4A2; }
                    PC = 0xF48D; goto case 0xF48D;
                case 0xF48C:
                    A |= _ram[(byte)(0xAC + X)]; SetZN(A); TotalCycles += 4; PC = 0xF48E;
                    return;
                case 0xF48D:
                    Y = _ram[0x07BB]; SetZN(Y); TotalCycles += 4; PC = 0xF490;
                    goto case 0xF490;
                case 0xF490:
                    Cmp(Y, 0x08); TotalCycles += 2; PC = 0xF492;
                    goto case 0xF492;
                case 0xF491:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF492;
                    goto case 0xF492;
                case 0xF492:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF49D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF49D; }
                    PC = 0xF494; goto case 0xF494;
                case 0xF493:
                    A |= 0xA9; SetZN(A); TotalCycles += 2; PC = 0xF495;
                    goto case 0xF495;
                case 0xF494:
                    A = 0xA0; SetZN(A); TotalCycles += 2; PC = 0xF496;
                    goto case 0xF496;
                case 0xF495:
                    Y = 0x8D; SetZN(Y); TotalCycles += 2; PC = 0xF497;
                    return;
                case 0xF496:
                    WriteIoReg(0x4002, A); TotalCycles += 4; PC = 0xF499;
                    goto case 0xF499;
                case 0xF498:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF499:
                    A = 0x9F; SetZN(A); TotalCycles += 2; PC = 0xF49B;
                    goto case 0xF49B;
                case 0xF49B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF49F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF49F; }
                    PC = 0xF49D; goto case 0xF49D;
                case 0xF49D:
                    A = 0x90; SetZN(A); TotalCycles += 2; PC = 0xF49F;
                    goto case 0xF49F;
                case 0xF49E:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF42D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF42D; }
                    PC = 0xF4A0; goto case 0xF4A0;
                case 0xF49F:
                    WriteIoReg(0x4000, A); TotalCycles += 4; PC = 0xF4A2;
                    goto case 0xF4A2;
                case 0xF4A0:
                    TotalCycles += 7; PushU16(0xF4A2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF4A1:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF4A2:
                    _ram[0x07BB] = DecVal(_ram[0x07BB]); TotalCycles += 6; PC = 0xF4A5;
                    goto case 0xF4A5;
                case 0xF4A5:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF4B5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF4B5; }
                    PC = 0xF4A7; goto case 0xF4A7;
                case 0xF4A6:
                    _ram[0x00A2] = Asl(_ram[0x00A2]); TotalCycles += 6; PC = 0xF4A9;
                    goto case 0xF4A9;
                case 0xF4A7: // === SUBROUTINE: PlayPipeDownInj ===
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xF4A9;
                    goto case 0xF4A9;
                case 0xF4A8:
                    TotalCycles += 7; PushU16(0xF4AA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF4A9:
                    _ram[0xF1] = X; TotalCycles += 3; PC = 0xF4AB;
                    goto case 0xF4AB;
                case 0xF4AA:
                    Sbc(ReadMem(ReadU16Zp(0xA2) + Y)); TotalCycles += 5; PC = 0xF4AC;
                    goto case 0xF4AC;
                case 0xF4AB:
                    X = 0x0E; SetZN(X); TotalCycles += 2; PC = 0xF4AD;
                    goto case 0xF4AD;
                case 0xF4AC:
                    _ram[0x058E] = Asl(_ram[0x058E]); TotalCycles += 6; PC = 0xF4AF;
                    goto case 0xF4AF;
                case 0xF4AD:
                    WriteIoReg(0x4015, X); TotalCycles += 4; PC = 0xF4B0;
                    goto case 0xF4B0;
                case 0xF4AE:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF4B0;
                    goto case 0xF4B0;
                case 0xF4AF:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF4B0:
                    X = 0x0F; SetZN(X); TotalCycles += 2; PC = 0xF4B2;
                    goto case 0xF4B2;
                case 0xF4B2:
                    WriteIoReg(0x4015, X); TotalCycles += 4; PC = 0xF4B5;
                    goto case 0xF4B5;
                case 0xF4B3:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF4B5;
                    goto case 0xF4B5;
                case 0xF4B4:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF4B5:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF4B6:
                    A = 0x2F; SetZN(A); TotalCycles += 2; PC = 0xF4B8;
                    goto case 0xF4B8;
                case 0xF4B8:
                    _ram[0x07BB] = A; TotalCycles += 4; PC = 0xF4BB;
                    goto case 0xF4BB;
                case 0xF4BB:
                    A = _ram[0x07BB]; SetZN(A); TotalCycles += 4; PC = 0xF4BE;
                    goto case 0xF4BE;
                case 0xF4BE:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF4BF;
                    goto case 0xF4BF;
                case 0xF4BF:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF4D1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF4D1; }
                    PC = 0xF4C1; goto case 0xF4C1;
                case 0xF4C0:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF50C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF50C; }
                    PC = 0xF4C2; goto case 0xF4C2;
                case 0xF4C1:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF4C2;
                    goto case 0xF4C2;
                case 0xF4C2:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF4D1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF4D1; }
                    PC = 0xF4C4; goto case 0xF4C4;
                case 0xF4C3:
                    A |= _ram[0x0229]; SetZN(A); TotalCycles += 4; PC = 0xF4C6;
                    goto case 0xF4C6;
                case 0xF4C4:
                    A &= 0x02; SetZN(A); TotalCycles += 2; PC = 0xF4C6;
                    goto case 0xF4C6;
                case 0xF4C6:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF4D1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF4D1; }
                    PC = 0xF4C8; goto case 0xF4C8;
                case 0xF4C7:
                    A |= 0xA0; SetZN(A); TotalCycles += 2; PC = 0xF4C9;
                    goto case 0xF4C9;
                case 0xF4C8:
                    Y = 0x91; SetZN(Y); TotalCycles += 2; PC = 0xF4CA;
                    goto case 0xF4CA;
                case 0xF4C9:
                    WriteMem(ReadU16Zp(0xA2) + Y, A); TotalCycles += 6; PC = 0xF4CB;
                    goto case 0xF4CB;
                case 0xF4CA:
                    X = 0x9A; SetZN(X); TotalCycles += 2; PC = 0xF4CC;
                    goto case 0xF4CC;
                case 0xF4CB:
                    SP = X; TotalCycles += 2; PC = 0xF4CC;
                    goto case 0xF4CC;
                case 0xF4CC:
                    A = 0x44; SetZN(A); TotalCycles += 2; PC = 0xF4CE;
                    goto case 0xF4CE;
                case 0xF4CE:
                    TotalCycles += 6; PushU16(0xF4D0); PC = 0xF388;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF388;
                case 0xF4CF:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xF4D0;
                    return;
                case 0xF4D1:
                    TotalCycles += 3; PC = 0xF4A2;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF4A2;
                case 0xF4D2:
                    X = 0xF4; SetZN(X); TotalCycles += 2; PC = 0xF4D4;
                    goto case 0xF4D4;
                case 0xF4D4:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xF4D5;
                    return;
                case 0xF4D7:
                    { byte z = (byte)(0x4E + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xF4D9;
                    return;
                case 0xF4D8:
                    { int a = 0x4C44; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xF4DB;
                    return;
                case 0xF4DA:
                    TotalCycles += 3; PC = 0x4C52;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF4DC:
                    TotalCycles += 3; PC = 0x3E48;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF4DD:
                    PushU8(A); TotalCycles += 3; PC = 0xF4DE;
                    goto case 0xF4DE;
                case 0xF4DE:
                    { int a = 0x3E36 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xF4E1;
                    goto case 0xF4E1;
                case 0xF4DF:
                    { byte z = (byte)(0x3E + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xF4E1;
                    goto case 0xF4E1;
                case 0xF4E0:
                    { int a = 0x3036 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xF4E3;
                    goto case 0xF4E3;
                case 0xF4E1:
                    { byte z = (byte)(0x30 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xF4E3;
                    goto case 0xF4E3;
                case 0xF4E2:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF50C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF50C; }
                    PC = 0xF4E4; goto case 0xF4E4;
                case 0xF4E3:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xF4E4;
                    goto case 0xF4E4;
                case 0xF4E4:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF4E5;
                    goto case 0xF4E5;
                case 0xF4E5:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xF531; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF531; }
                    PC = 0xF4E7; return;
                case 0xF4E6:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF4E7;
                    return;
                case 0xF4EC:
                    Bit(ReadIoReg(0x3A24)); TotalCycles += 4; PC = 0xF4EF;
                    return;
                case 0xF4ED:
                    Bit(_ram[0x3A]); TotalCycles += 3; PC = 0xF4EF;
                    return;
                case 0xF4F2:
                    Bit(ReadIoReg(0x2C22)); TotalCycles += 4; PC = 0xF4F5;
                    return;
                case 0xF4F4:
                    Bit(_ram[0x0422]); TotalCycles += 4; PC = 0xF4F7;
                    return;
                case 0xF4FB:
                    Bit(_ram[0x16]); TotalCycles += 3; PC = 0xF4FD;
                    return;
                case 0xF4FC:
                    { byte z = (byte)(0x04 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xF4FE;
                    goto case 0xF4FE;
                case 0xF4FE:
                    Bit(_ram[0x26]); TotalCycles += 3; PC = 0xF500;
                    goto case 0xF500;
                case 0xF4FF:
                    _ram[0x18] = Rol(_ram[0x18]); TotalCycles += 5; PC = 0xF501;
                    return;
                case 0xF500:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF501;
                    return;
                case 0xF502:
                    _ram[0x28] = Rol(_ram[0x28]); TotalCycles += 5; PC = 0xF504;
                    return;
                case 0xF503:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xF504;
                    return;
                case 0xF506:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xF507;
                    goto case 0xF507;
                case 0xF507:
                    A = Rol(A); TotalCycles += 2; PC = 0xF508;
                    return;
                case 0xF50A:
                    A = Rol(A); TotalCycles += 2; PC = 0xF50B;
                    goto case 0xF50B;
                case 0xF50B:
                    Bit(_ram[0x041E]); TotalCycles += 4; PC = 0xF50E;
                    goto case 0xF50E;
                case 0xF50C:
                    { int a = 0x2C04 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xF50F;
                    goto case 0xF50F;
                case 0xF50E:
                    Bit(ReadIoReg(0x202E)); TotalCycles += 4; PC = 0xF511;
                    return;
                case 0xF50F:
                    _ram[0x0420] = Rol(_ram[0x0420]); TotalCycles += 6; PC = 0xF512;
                    goto case 0xF512;
                case 0xF510:
                    TotalCycles += 6; PushU16(0xF512); PC = 0x2E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF512:
                    { int a = 0x2230; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xF515;
                    return;
                case 0xF513:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF537; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF537; }
                    PC = 0xF515; return;
                case 0xF516:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF54A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF54A; }
                    PC = 0xF518; goto case 0xF518;
                case 0xF518:
                    A = 0x35; SetZN(A); TotalCycles += 2; PC = 0xF51A;
                    goto case 0xF51A;
                case 0xF519:
                    A &= _ram[(byte)(0xA2 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF51B;
                    goto case 0xF51B;
                case 0xF51A:
                    X = 0x8D; SetZN(X); TotalCycles += 2; PC = 0xF51C;
                    goto case 0xF51C;
                case 0xF51B:
                    _ram[0x04D0] = A; TotalCycles += 4; PC = 0xF51E;
                    goto case 0xF51E;
                case 0xF51C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF522; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF522; }
                    PC = 0xF51E; goto case 0xF51E;
                case 0xF51E:
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0xF520;
                    goto case 0xF520;
                case 0xF51F:
                    _ram[0xA2] = Asl(_ram[0xA2]); TotalCycles += 5; PC = 0xF521;
                    goto case 0xF521;
                case 0xF520:
                    X = 0x98; SetZN(X); TotalCycles += 2; PC = 0xF522;
                    goto case 0xF522;
                case 0xF521:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF522;
                    goto case 0xF522;
                case 0xF522:
                    _ram[0x07BD] = A; TotalCycles += 4; PC = 0xF525;
                    goto case 0xF525;
                case 0xF523:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2007 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF526;
                    return;
                case 0xF525:
                    Y = 0x7F; SetZN(Y); TotalCycles += 2; PC = 0xF527;
                    goto case 0xF527;
                case 0xF527:
                    A = 0x42; SetZN(A); TotalCycles += 2; PC = 0xF529;
                    goto case 0xF529;
                case 0xF529:
                    TotalCycles += 6; PushU16(0xF52B); PC = 0xF3A6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF3A6;
                case 0xF52A:
                    X = _ram[0xF3]; SetZN(X); TotalCycles += 3; PC = 0xF52C;
                    goto case 0xF52C;
                case 0xF52C:
                    A = _ram[0x07BD]; SetZN(A); TotalCycles += 4; PC = 0xF52F;
                    goto case 0xF52F;
                case 0xF52D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x4907 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF530;
                    goto case 0xF530;
                case 0xF52F:
                    Cmp(A, 0x30); TotalCycles += 2; PC = 0xF531;
                    goto case 0xF531;
                case 0xF530:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF502; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF502; }
                    PC = 0xF532; goto case 0xF532;
                case 0xF531:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF538; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF538; }
                    PC = 0xF533; goto case 0xF533;
                case 0xF532:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xF534;
                    return;
                case 0xF533:
                    A = 0x54; SetZN(A); TotalCycles += 2; PC = 0xF535;
                    goto case 0xF535;
                case 0xF535:
                    WriteIoReg(0x4006, A); TotalCycles += 4; PC = 0xF538;
                    goto case 0xF538;
                case 0xF536:
                    _ram[0x40] = Asl(_ram[0x40]); TotalCycles += 5; PC = 0xF538;
                    goto case 0xF538;
                case 0xF537:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF538:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF568; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF568; }
                    PC = 0xF53A; goto case 0xF53A;
                case 0xF539:
                    { int a = 0x20A9; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xF53C;
                    goto case 0xF53C;
                case 0xF53A:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0xF53C;
                    goto case 0xF53C;
                case 0xF53B:
                    TotalCycles += 6; PushU16(0xF53D); PC = 0xBD8D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF53C:
                    _ram[0x07BD] = A; TotalCycles += 4; PC = 0xF53F;
                    goto case 0xF53F;
                case 0xF53D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2007 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF540;
                    goto case 0xF540;
                case 0xF53F:
                    Y = 0x94; SetZN(Y); TotalCycles += 2; PC = 0xF541;
                    goto case 0xF541;
                case 0xF540:
                    _ram[(byte)(0xA9 + X)] = Y; TotalCycles += 4; PC = 0xF542;
                    goto case 0xF542;
                case 0xF541:
                    A = 0x5E; SetZN(A); TotalCycles += 2; PC = 0xF543;
                    goto case 0xF543;
                case 0xF542:
                    { int a = 0x0BD0 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xF545;
                    goto case 0xF545;
                case 0xF543:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF550; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF550; }
                    PC = 0xF545; goto case 0xF545;
                case 0xF545:
                    A = _ram[0x07BD]; SetZN(A); TotalCycles += 4; PC = 0xF548;
                    goto case 0xF548;
                case 0xF546:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x4907 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF549;
                    goto case 0xF549;
                case 0xF548:
                    Cmp(A, 0x18); TotalCycles += 2; PC = 0xF54A;
                    goto case 0xF54A;
                case 0xF549:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF54A;
                    goto case 0xF54A;
                case 0xF54A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF568; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF568; }
                    PC = 0xF54C; goto case 0xF54C;
                case 0xF54C:
                    Y = 0x93; SetZN(Y); TotalCycles += 2; PC = 0xF54E;
                    goto case 0xF54E;
                case 0xF54E:
                    A = 0x18; SetZN(A); TotalCycles += 2; PC = 0xF550;
                    goto case 0xF550;
                case 0xF54F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF550;
                    goto case 0xF550;
                case 0xF550:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF5D1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5D1; }
                    PC = 0xF552; goto case 0xF552;
                case 0xF552:
                    A = 0x36; SetZN(A); TotalCycles += 2; PC = 0xF554;
                    goto case 0xF554;
                case 0xF553:
                    { byte z = (byte)(0x8D + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xF555;
                    goto case 0xF555;
                case 0xF554:
                    _ram[0x07BD] = A; TotalCycles += 4; PC = 0xF557;
                    goto case 0xF557;
                case 0xF555:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2D07 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF558;
                    goto case 0xF558;
                case 0xF557:
                    A = _ram[0x07BD]; SetZN(A); TotalCycles += 4; PC = 0xF55A;
                    goto case 0xF55A;
                case 0xF558:
                    A = ReadMem(0x4A07 + X); SetZN(A); TotalCycles += 4; PC = 0xF55B;
                    goto case 0xF55B;
                case 0xF55A:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF55B;
                    goto case 0xF55B;
                case 0xF55B:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF568; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF568; }
                    PC = 0xF55D; goto case 0xF55D;
                case 0xF55D:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF55E;
                    goto case 0xF55E;
                case 0xF55E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x74D9 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF561;
                    goto case 0xF561;
                case 0xF55F:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x22F4 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF562;
                    goto case 0xF562;
                case 0xF561:
                    X = 0x5D; SetZN(X); TotalCycles += 2; PC = 0xF563;
                    goto case 0xF563;
                case 0xF562:
                    A ^= ReadMem(0x7FA0 + X); SetZN(A); TotalCycles += 4; PC = 0xF565;
                    goto case 0xF565;
                case 0xF563:
                    Y = 0x7F; SetZN(Y); TotalCycles += 2; PC = 0xF565;
                    goto case 0xF565;
                case 0xF565:
                    TotalCycles += 6; PushU16(0xF567); PC = 0xF3A6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF3A6;
                case 0xF566:
                    X = _ram[0xF3]; SetZN(X); TotalCycles += 3; PC = 0xF568;
                    goto case 0xF568;
                case 0xF568:
                    _ram[0x07BD] = DecVal(_ram[0x07BD]); TotalCycles += 6; PC = 0xF56B;
                    goto case 0xF56B;
                case 0xF569:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x5007 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF56C;
                    goto case 0xF56C;
                case 0xF56B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF57B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF57B; }
                    PC = 0xF56D; goto case 0xF56D;
                case 0xF56C:
                    _ram[0x00A2] = Asl(_ram[0x00A2]); TotalCycles += 6; PC = 0xF56F;
                    goto case 0xF56F;
                case 0xF56D:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xF56F;
                    goto case 0xF56F;
                case 0xF56E:
                    TotalCycles += 7; PushU16(0xF570); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF56F:
                    _ram[0xF2] = X; TotalCycles += 3; PC = 0xF571;
                    goto case 0xF571;
                case 0xF571: // === SUBROUTINE: PlayCoinGrab ===
                    X = 0x0D; SetZN(X); TotalCycles += 2; PC = 0xF573;
                    goto case 0xF573;
                case 0xF572:
                    A |= _ram[0x058E]; SetZN(A); TotalCycles += 4; PC = 0xF575;
                    goto case 0xF575;
                case 0xF573:
                    WriteIoReg(0x4015, X); TotalCycles += 4; PC = 0xF576;
                    goto case 0xF576;
                case 0xF574:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF576;
                    goto case 0xF576;
                case 0xF575:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF576:
                    X = 0x0F; SetZN(X); TotalCycles += 2; PC = 0xF578;
                    goto case 0xF578;
                case 0xF578:
                    WriteIoReg(0x4015, X); TotalCycles += 4; PC = 0xF57B;
                    goto case 0xF57B;
                case 0xF579:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF57B;
                    goto case 0xF57B;
                case 0xF57A:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF57B:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF57C: // === SUBROUTINE: PlayTimerTick ===
                    A = _ram[0xF2]; SetZN(A); TotalCycles += 3; PC = 0xF57E;
                    goto case 0xF57E;
                case 0xF57E:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0xF580;
                    goto case 0xF580;
                case 0xF57F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF580:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF5E7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5E7; }
                    PC = 0xF582; goto case 0xF582;
                case 0xF581:
                    Adc(_ram[0xA4]); TotalCycles += 3; PC = 0xF583;
                    goto case 0xF583;
                case 0xF582:
                    Y = _ram[0xFE]; SetZN(Y); TotalCycles += 3; PC = 0xF584;
                    goto case 0xF584;
                case 0xF583:
                    { int a = 0x20F0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF586;
                    goto case 0xF586;
                case 0xF584:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF5A6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5A6; }
                    PC = 0xF586; goto case 0xF586;
                case 0xF585:
                    TotalCycles += 6; PushU16(0xF587); PC = 0xF284;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF284;
                case 0xF586:
                    _ram[0xF2] = Y; TotalCycles += 3; PC = 0xF588;
                    goto case 0xF588;
                case 0xF588:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF5C8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5C8; }
                    PC = 0xF58A; goto case 0xF58A;
                case 0xF589:
                    { int a = 0xFE46 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xF58C;
                    goto case 0xF58C;
                case 0xF58A:
                    _ram[0xFE] = Lsr(_ram[0xFE]); TotalCycles += 5; PC = 0xF58C;
                    goto case 0xF58C;
                case 0xF58B:
                    { int a = 0x8AB0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF58E;
                    goto case 0xF58E;
                case 0xF58C:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF518; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF518; }
                    PC = 0xF58E; goto case 0xF58E;
                case 0xF58D:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xF58E;
                    goto case 0xF58E;
                case 0xF58E:
                    _ram[0xFE] = Lsr(_ram[0xFE]); TotalCycles += 5; PC = 0xF590;
                    goto case 0xF590;
                case 0xF58F:
                    { int a = 0x6AB0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF592;
                    goto case 0xF592;
                case 0xF590:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF5FC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5FC; }
                    PC = 0xF592; goto case 0xF592;
                case 0xF591:
                    A = Ror(A); TotalCycles += 2; PC = 0xF592;
                    goto case 0xF592;
                case 0xF592:
                    _ram[0xFE] = Lsr(_ram[0xFE]); TotalCycles += 5; PC = 0xF594;
                    goto case 0xF594;
                case 0xF593:
                    { int a = 0x6AB0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF596;
                    goto case 0xF596;
                case 0xF594:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF600; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF600; }
                    PC = 0xF596; goto case 0xF596;
                case 0xF595:
                    A = Ror(A); TotalCycles += 2; PC = 0xF596;
                    goto case 0xF596;
                case 0xF596:
                    _ram[0xFE] = Lsr(_ram[0xFE]); TotalCycles += 5; PC = 0xF598;
                    goto case 0xF598;
                case 0xF597:
                    { int a = 0xA0B0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF59A;
                    goto case 0xF59A;
                case 0xF598:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF53A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF53A; }
                    PC = 0xF59A; goto case 0xF59A;
                case 0xF599:
                    Y = 0x46; SetZN(Y); TotalCycles += 2; PC = 0xF59B;
                    goto case 0xF59B;
                case 0xF59A:
                    _ram[0xFE] = Lsr(_ram[0xFE]); TotalCycles += 5; PC = 0xF59C;
                    goto case 0xF59C;
                case 0xF59B:
                    { int a = 0x80B0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF59E;
                    goto case 0xF59E;
                case 0xF59C:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF51E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF51E; }
                    PC = 0xF59E; goto case 0xF59E;
                case 0xF59E:
                    _ram[0xFE] = Lsr(_ram[0xFE]); TotalCycles += 5; PC = 0xF5A0;
                    goto case 0xF5A0;
                case 0xF59F:
                    { int a = 0xB0B0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF5A2;
                    goto case 0xF5A2;
                case 0xF5A0:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF552; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF552; }
                    PC = 0xF5A2; goto case 0xF5A2;
                case 0xF5A1:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF5E9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF5A3; goto case 0xF5A3;
                case 0xF5A2:
                    _ram[0xFE] = Lsr(_ram[0xFE]); TotalCycles += 5; PC = 0xF5A4;
                    goto case 0xF5A4;
                case 0xF5A3:
                    { int a = 0x3CB0 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF5A6;
                    goto case 0xF5A6;
                case 0xF5A4:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF5E2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5E2; }
                    PC = 0xF5A6; goto case 0xF5A6;
                case 0xF5A6:
                    A = _ram[0xF2]; SetZN(A); TotalCycles += 3; PC = 0xF5A8;
                    goto case 0xF5A8;
                case 0xF5A8:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF5C1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5C1; }
                    PC = 0xF5AA; goto case 0xF5AA;
                case 0xF5AA:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF5D3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5D3; }
                    PC = 0xF5AC; goto case 0xF5AC;
                case 0xF5AC:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF5AD;
                    goto case 0xF5AD;
                case 0xF5AD:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF5C2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5C2; }
                    PC = 0xF5AF; goto case 0xF5AF;
                case 0xF5AF:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF5B0;
                    goto case 0xF5B0;
                case 0xF5B0:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF60F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF60F; }
                    PC = 0xF5B2; goto case 0xF5B2;
                case 0xF5B1:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x304A + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF5B4;
                    return;
                case 0xF5B2:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF5B3;
                    goto case 0xF5B3;
                case 0xF5B3:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF60F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF60F; }
                    PC = 0xF5B5; goto case 0xF5B5;
                case 0xF5B5:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF5B6;
                    goto case 0xF5B6;
                case 0xF5B6:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF545; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF545; }
                    PC = 0xF5B8; goto case 0xF5B8;
                case 0xF5B7:
                    WriteIoReg(0xB04A, A); TotalCycles += 4; PC = 0xF5BA;
                    return;
                case 0xF5B8:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF5B9;
                    goto case 0xF5B9;
                case 0xF5B9:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF5C2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5C2; }
                    PC = 0xF5BB; goto case 0xF5BB;
                case 0xF5BB:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF5BC;
                    goto case 0xF5BC;
                case 0xF5BC:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF557; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF557; }
                    PC = 0xF5BE; goto case 0xF5BE;
                case 0xF5BD:
                    WriteMem(0xB04A + Y, A); TotalCycles += 5; PC = 0xF5C0;
                    goto case 0xF5C0;
                case 0xF5BE:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF5BF;
                    goto case 0xF5BF;
                case 0xF5BF:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF5E7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5E7; }
                    PC = 0xF5C1; goto case 0xF5C1;
                case 0xF5C0:
                    _ram[0x60] = Rol(_ram[0x60]); TotalCycles += 5; PC = 0xF5C2;
                    goto case 0xF5C2;
                case 0xF5C1:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF5C2:
                    TotalCycles += 3; PC = 0xF52C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF52C;
                case 0xF5C3:
                    Bit(ReadIoReg(0x4CF5)); TotalCycles += 4; PC = 0xF5C6;
                    goto case 0xF5C6;
                case 0xF5C4:
                    Sbc(_ram[(byte)(0x4C + X)]); TotalCycles += 4; PC = 0xF5C6;
                    goto case 0xF5C6;
                case 0xF5C5:
                    TotalCycles += 3; PC = 0xF568;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF568;
                case 0xF5C6:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xF5C7;
                    goto case 0xF5C7;
                case 0xF5C7:
                    Sbc(_ram[(byte)(0xA9 + X)]); TotalCycles += 4; PC = 0xF5C9;
                    goto case 0xF5C9;
                case 0xF5C8:
                    A = 0x38; SetZN(A); TotalCycles += 2; PC = 0xF5CA;
                    goto case 0xF5CA;
                case 0xF5C9:
                    P |= FlagC; TotalCycles += 2; PC = 0xF5CA;
                    goto case 0xF5CA;
                case 0xF5CA:
                    _ram[0x07BD] = A; TotalCycles += 4; PC = 0xF5CD;
                    goto case 0xF5CD;
                case 0xF5CB:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2007 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF5CE;
                    goto case 0xF5CE;
                case 0xF5CD:
                    Y = 0xC4; SetZN(Y); TotalCycles += 2; PC = 0xF5CF;
                    goto case 0xF5CF;
                case 0xF5CE:
                    Cmp(Y, _ram[0xA9]); TotalCycles += 3; PC = 0xF5D0;
                    goto case 0xF5D0;
                case 0xF5CF:
                    A = 0x18; SetZN(A); TotalCycles += 2; PC = 0xF5D1;
                    goto case 0xF5D1;
                case 0xF5D0:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF5D1;
                    goto case 0xF5D1;
                case 0xF5D1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF5DE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5DE; }
                    PC = 0xF5D3; goto case 0xF5D3;
                case 0xF5D3:
                    A = _ram[0x07BD]; SetZN(A); TotalCycles += 4; PC = 0xF5D6;
                    goto case 0xF5D6;
                case 0xF5D4:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x4907 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF5D7;
                    goto case 0xF5D7;
                case 0xF5D6:
                    Cmp(A, 0x08); TotalCycles += 2; PC = 0xF5D8;
                    goto case 0xF5D8;
                case 0xF5D7:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF5D8;
                    goto case 0xF5D8;
                case 0xF5D8:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF568; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF568; }
                    PC = 0xF5DA; goto case 0xF5DA;
                case 0xF5D9:
                    WriteIoReg(0xA4A0, X); TotalCycles += 4; PC = 0xF5DC;
                    goto case 0xF5DC;
                case 0xF5DA:
                    Y = 0xA4; SetZN(Y); TotalCycles += 2; PC = 0xF5DC;
                    goto case 0xF5DC;
                case 0xF5DB:
                    Y = _ram[0xA9]; SetZN(Y); TotalCycles += 3; PC = 0xF5DD;
                    return;
                case 0xF5DC:
                    A = 0x5A; SetZN(A); TotalCycles += 2; PC = 0xF5DE;
                    goto case 0xF5DE;
                case 0xF5DE:
                    X = 0x9F; SetZN(X); TotalCycles += 2; PC = 0xF5E0;
                    goto case 0xF5E0;
                case 0xF5E0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF565; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF565; }
                    PC = 0xF5E2; goto case 0xF5E2;
                case 0xF5E2:
                    A = 0x30; SetZN(A); TotalCycles += 2; PC = 0xF5E4;
                    goto case 0xF5E4;
                case 0xF5E3:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF572; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF572; }
                    PC = 0xF5E5; goto case 0xF5E5;
                case 0xF5E4:
                    _ram[0x07BD] = A; TotalCycles += 4; PC = 0xF5E7;
                    goto case 0xF5E7;
                case 0xF5E5:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2D07 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF5E8;
                    goto case 0xF5E8;
                case 0xF5E7:
                    A = _ram[0x07BD]; SetZN(A); TotalCycles += 4; PC = 0xF5EA;
                    goto case 0xF5EA;
                case 0xF5E8:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2207 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF5EB;
                    return;
                case 0xF5EA:
                    X = 0x03; SetZN(X); TotalCycles += 2; PC = 0xF5EC;
                    goto case 0xF5EC;
                case 0xF5EC:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF5ED;
                    goto case 0xF5ED;
                case 0xF5ED:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF5C5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5C5; }
                    PC = 0xF5EF; goto case 0xF5EF;
                case 0xF5EE:
                    { byte z = (byte)(0xCA + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xF5F0;
                    goto case 0xF5F0;
                case 0xF5EF:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xF5F0;
                    goto case 0xF5F0;
                case 0xF5F0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF5EC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5EC; }
                    PC = 0xF5F2; goto case 0xF5F2;
                case 0xF5F2:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF5F3;
                    goto case 0xF5F3;
                case 0xF5F3:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x74D3 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF5F6;
                    goto case 0xF5F6;
                case 0xF5F6:
                    X = 0x82; SetZN(X); TotalCycles += 2; PC = 0xF5F8;
                    goto case 0xF5F8;
                case 0xF5F8:
                    Y = 0x7F; SetZN(Y); TotalCycles += 2; PC = 0xF5FA;
                    goto case 0xF5FA;
                case 0xF5FA:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF5E0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5E0; }
                    PC = 0xF5FC; goto case 0xF5FC;
                case 0xF5FB:
                    Cmp(X, _ram[0xA9]); TotalCycles += 3; PC = 0xF5FD;
                    goto case 0xF5FD;
                case 0xF5FC:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0xF5FE;
                    goto case 0xF5FE;
                case 0xF5FD:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF5CF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5CF; }
                    PC = 0xF5FF; return;
                case 0xF5FE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF602; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF602; }
                    PC = 0xF600; goto case 0xF600;
                case 0xF600:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0xF602;
                    goto case 0xF602;
                case 0xF601:
                    TotalCycles += 6; PushU16(0xF603); PC = 0xBD8D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF602:
                    _ram[0x07BD] = A; TotalCycles += 4; PC = 0xF605;
                    goto case 0xF605;
                case 0xF603:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2907 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF606;
                    return;
                case 0xF605:
                    A = 0x7F; SetZN(A); TotalCycles += 2; PC = 0xF607;
                    goto case 0xF607;
                case 0xF607:
                    WriteIoReg(0x4005, A); TotalCycles += 4; PC = 0xF60A;
                    goto case 0xF60A;
                case 0xF608:
                    A |= _ram[0x40]; SetZN(A); TotalCycles += 3; PC = 0xF60A;
                    goto case 0xF60A;
                case 0xF609:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF60A:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF60C;
                    goto case 0xF60C;
                case 0xF60B:
                    TotalCycles += 7; PushU16(0xF60D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF60C:
                    _ram[0x07BE] = A; TotalCycles += 4; PC = 0xF60F;
                    goto case 0xF60F;
                case 0xF60D:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x6E07 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xF610;
                    goto case 0xF610;
                case 0xF60F:
                    _ram[0x07BE] = IncVal(_ram[0x07BE]); TotalCycles += 6; PC = 0xF612;
                    goto case 0xF612;
                case 0xF610:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x2D07 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xF613;
                    goto case 0xF613;
                case 0xF612:
                    A = _ram[0x07BE]; SetZN(A); TotalCycles += 4; PC = 0xF615;
                    goto case 0xF615;
                case 0xF613:
                    X = ReadMem(0x4A07 + Y); SetZN(X); TotalCycles += 4; PC = 0xF616;
                    goto case 0xF616;
                case 0xF615:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF616;
                    goto case 0xF616;
                case 0xF616:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF617;
                    goto case 0xF617;
                case 0xF617:
                    Cmp(Y, _ram[0x07BD]); TotalCycles += 4; PC = 0xF61A;
                    goto case 0xF61A;
                case 0xF618:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7007 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF61B;
                    return;
                case 0xF61A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF628; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF628; }
                    PC = 0xF61C; goto case 0xF61C;
                case 0xF61C:
                    A = 0x9D; SetZN(A); TotalCycles += 2; PC = 0xF61E;
                    goto case 0xF61E;
                case 0xF61D:
                    _ram[(0x048D + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xF620;
                    goto case 0xF620;
                case 0xF61E:
                    WriteIoReg(0x4004, A); TotalCycles += 4; PC = 0xF621;
                    goto case 0xF621;
                case 0xF620:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF621:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x74F8 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF624;
                    goto case 0xF624;
                case 0xF622:
                    P |= FlagD; TotalCycles += 2; PC = 0xF623;
                    return;
                case 0xF624:
                    TotalCycles += 6; PushU16(0xF626); PC = 0xF3A9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF3A9;
                case 0xF625:
                    A = 0xF3; SetZN(A); TotalCycles += 2; PC = 0xF627;
                    goto case 0xF627;
                case 0xF627:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF628:
                    TotalCycles += 3; PC = 0xF56D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF56D;
                case 0xF629:
                    Adc(_ram[0x01F5]); TotalCycles += 4; PC = 0xF62C;
                    goto case 0xF62C;
                case 0xF62A:
                    Sbc(_ram[(byte)(0x01 + X)]); TotalCycles += 4; PC = 0xF62C;
                    goto case 0xF62C;
                case 0xF62B:
                    A |= ReadMem(ReadU16Zp((byte)(0x0E + X))); SetZN(A); TotalCycles += 6; PC = 0xF62D;
                    goto case 0xF62D;
                case 0xF62C:
                    _ram[0x050E] = Asl(_ram[0x050E]); TotalCycles += 6; PC = 0xF62F;
                    return;
                case 0xF62D:
                    _ram[0x030D] = Asl(_ram[0x030D]); TotalCycles += 6; PC = 0xF630;
                    goto case 0xF630;
                case 0xF62E:
                    A |= _ram[0x060B]; SetZN(A); TotalCycles += 4; PC = 0xF631;
                    return;
                case 0xF630:
                    _ram[0x0C] = Asl(_ram[0x0C]); TotalCycles += 5; PC = 0xF632;
                    return;
                case 0xF633:
                    A = Asl(A); TotalCycles += 2; PC = 0xF634;
                    goto case 0xF634;
                case 0xF634:
                    A |= 0x03; SetZN(A); TotalCycles += 2; PC = 0xF636;
                    goto case 0xF636;
                case 0xF636:
                    A |= _ram[0x0508]; SetZN(A); TotalCycles += 4; PC = 0xF639;
                    goto case 0xF639;
                case 0xF637:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF638;
                    goto case 0xF638;
                case 0xF638:
                    A |= _ram[0x0406]; SetZN(A); TotalCycles += 4; PC = 0xF63B;
                    goto case 0xF63B;
                case 0xF639:
                    _ram[0x0C] = Asl(_ram[0x0C]); TotalCycles += 5; PC = 0xF63B;
                    goto case 0xF63B;
                case 0xF63B:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0xF63D;
                    goto case 0xF63D;
                case 0xF63C:
                    TotalCycles += 6; PushU16(0xF63E); PC = 0xBF8D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF63D:
                    _ram[0x07BF] = A; TotalCycles += 4; PC = 0xF640;
                    goto case 0xF640;
                case 0xF640:
                    A = _ram[0x07BF]; SetZN(A); TotalCycles += 4; PC = 0xF643;
                    goto case 0xF643;
                case 0xF643:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF644;
                    goto case 0xF644;
                case 0xF644:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF658; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF658; }
                    PC = 0xF646; goto case 0xF646;
                case 0xF646:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF647;
                    goto case 0xF647;
                case 0xF647:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x762B + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xF64A;
                    goto case 0xF64A;
                case 0xF649:
                    { byte z = (byte)(0xB9 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xF64B;
                    goto case 0xF64B;
                case 0xF64A:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7FEA + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF64D;
                    goto case 0xF64D;
                case 0xF64B:
                     TotalCycles += 2; PC = 0xF64C;
                    return;
                case 0xF64D:
                    WriteIoReg(0x400C, A); TotalCycles += 4; PC = 0xF650;
                    goto case 0xF650;
                case 0xF64F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF650:
                    WriteIoReg(0x400E, X); TotalCycles += 4; PC = 0xF653;
                    goto case 0xF653;
                case 0xF651:
                    { int a = 0xA940; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xF654;
                    goto case 0xF654;
                case 0xF652:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF653:
                    A = 0x18; SetZN(A); TotalCycles += 2; PC = 0xF655;
                    goto case 0xF655;
                case 0xF654:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF655;
                    goto case 0xF655;
                case 0xF655:
                    WriteIoReg(0x400F, A); TotalCycles += 4; PC = 0xF658;
                    goto case 0xF658;
                case 0xF657:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF658:
                    _ram[0x07BF] = DecVal(_ram[0x07BF]); TotalCycles += 6; PC = 0xF65B;
                    goto case 0xF65B;
                case 0xF65B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF666; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF666; }
                    PC = 0xF65D; goto case 0xF65D;
                case 0xF65C:
                    A |= 0xA9; SetZN(A); TotalCycles += 2; PC = 0xF65E;
                    goto case 0xF65E;
                case 0xF65D:
                    A = 0xF0; SetZN(A); TotalCycles += 2; PC = 0xF65F;
                    goto case 0xF65F;
                case 0xF65E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF5ED; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF5ED; }
                    PC = 0xF660; return;
                case 0xF65F:
                    WriteIoReg(0x400C, A); TotalCycles += 4; PC = 0xF662;
                    goto case 0xF662;
                case 0xF661:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF662:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF664;
                    goto case 0xF664;
                case 0xF663:
                    TotalCycles += 7; PushU16(0xF665); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF664:
                    _ram[0xF3] = A; TotalCycles += 3; PC = 0xF666;
                    goto case 0xF666;
                case 0xF666:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF667: // === SUBROUTINE: PlayBlast ===
                    Y = _ram[0xFD]; SetZN(Y); TotalCycles += 3; PC = 0xF669;
                    goto case 0xF669;
                case 0xF668:
                    Sbc(ReadMem(0x0AF0 + X)); TotalCycles += 4; PC = 0xF66B;
                    goto case 0xF66B;
                case 0xF669:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF675; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF675; }
                    PC = 0xF66B; goto case 0xF66B;
                case 0xF66A:
                    A = Asl(A); TotalCycles += 2; PC = 0xF66B;
                    goto case 0xF66B;
                case 0xF66B:
                    _ram[0xF3] = Y; TotalCycles += 3; PC = 0xF66D;
                    goto case 0xF66D;
                case 0xF66D:
                    _ram[0xFD] = Lsr(_ram[0xFD]); TotalCycles += 5; PC = 0xF66F;
                    goto case 0xF66F;
                case 0xF66E:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x4AB0 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xF671;
                    goto case 0xF671;
                case 0xF66F:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF63B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF63B; }
                    PC = 0xF671; goto case 0xF671;
                case 0xF670:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xF671;
                    goto case 0xF671;
                case 0xF671:
                    _ram[0xFD] = Lsr(_ram[0xFD]); TotalCycles += 5; PC = 0xF673;
                    goto case 0xF673;
                case 0xF672:
                    Sbc(ReadMem(0x0BB0 + X)); TotalCycles += 4; PC = 0xF675;
                    goto case 0xF675;
                case 0xF673:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF680; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF680; }
                    PC = 0xF675; goto case 0xF675;
                case 0xF675:
                    A = _ram[0xF3]; SetZN(A); TotalCycles += 3; PC = 0xF677;
                    goto case 0xF677;
                case 0xF677:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF67F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF67F; }
                    PC = 0xF679; goto case 0xF679;
                case 0xF678:
                    _ram[0x4A] = Asl(_ram[0x4A]); TotalCycles += 5; PC = 0xF67A;
                    goto case 0xF67A;
                case 0xF679:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF67A;
                    goto case 0xF67A;
                case 0xF67A:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF640; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF640; }
                    PC = 0xF67C; goto case 0xF67C;
                case 0xF67B:
                    Cmp(Y, _ram[0x4A]); TotalCycles += 3; PC = 0xF67D;
                    goto case 0xF67D;
                case 0xF67C:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF67D;
                    goto case 0xF67D;
                case 0xF67D:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF685; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF685; }
                    PC = 0xF67F; goto case 0xF67F;
                case 0xF67E:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0xF680;
                    goto case 0xF680;
                case 0xF67F:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF680:
                    A = 0x40; SetZN(A); TotalCycles += 2; PC = 0xF682;
                    goto case 0xF682;
                case 0xF681:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF682:
                    _ram[0x07BF] = A; TotalCycles += 4; PC = 0xF685;
                    goto case 0xF685;
                case 0xF685:
                    A = _ram[0x07BF]; SetZN(A); TotalCycles += 4; PC = 0xF688;
                    goto case 0xF688;
                case 0xF688:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF689;
                    goto case 0xF689;
                case 0xF689:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF68A;
                    goto case 0xF68A;
                case 0xF68A:
                    X = 0x0F; SetZN(X); TotalCycles += 2; PC = 0xF68C;
                    goto case 0xF68C;
                case 0xF68C:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7FC9 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF68F;
                    goto case 0xF68F;
                case 0xF68D:
                    Cmp(A, 0xFF); TotalCycles += 2; PC = 0xF68F;
                    goto case 0xF68F;
                case 0xF68F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF64D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF64D; }
                    PC = 0xF691; goto case 0xF691;
                case 0xF690:
                    Y = ReadMem(0x3A4C + X); SetZN(Y); TotalCycles += 4; PC = 0xF693;
                    return;
                case 0xF691:
                    TotalCycles += 3; PC = 0xF73A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF73A;
                case 0xF694: // === SUBROUTINE: PlayPowerUpGrab ===
                    A = _ram[0xFC]; SetZN(A); TotalCycles += 3; PC = 0xF696;
                    goto case 0xF696;
                case 0xF696:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF6A4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6A4; }
                    PC = 0xF698; goto case 0xF698;
                case 0xF698:
                    A = _ram[0xFB]; SetZN(A); TotalCycles += 3; PC = 0xF69A;
                    goto case 0xF69A;
                case 0xF69A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF6C8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6C8; }
                    PC = 0xF69C; goto case 0xF69C;
                case 0xF69B:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x31AD]); TotalCycles += 4; PC = 0xF69E;
                    return;
                case 0xF69C:
                    A = _ram[0x07B1]; SetZN(A); TotalCycles += 4; PC = 0xF69F;
                    goto case 0xF69F;
                case 0xF69D:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF69F;
                    goto case 0xF69F;
                case 0xF69F:
                    A |= _ram[0xF4]; SetZN(A); TotalCycles += 3; PC = 0xF6A1;
                    goto case 0xF6A1;
                case 0xF6A1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF691; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF691; }
                    PC = 0xF6A3; goto case 0xF6A3;
                case 0xF6A2:
                    { int a = 0x8D60; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xF6A5;
                    goto case 0xF6A5;
                case 0xF6A3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF6A4:
                    _ram[0x07B1] = A; TotalCycles += 4; PC = 0xF6A7;
                    goto case 0xF6A7;
                case 0xF6A5:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF6A7;
                    goto case 0xF6A7;
                case 0xF6A7:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xF6A9;
                    goto case 0xF6A9;
                case 0xF6A8:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0xF6AA;
                    goto case 0xF6AA;
                case 0xF6A9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF6B1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6B1; }
                    PC = 0xF6AB; goto case 0xF6AB;
                case 0xF6AA:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xF6AC;
                    return;
                case 0xF6AB:
                    TotalCycles += 6; PushU16(0xF6AD); PC = 0xF4A7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF4A7;
                case 0xF6AE:
                    TotalCycles += 6; PushU16(0xF6B0); PC = 0xF571;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF571;
                case 0xF6AF:
                    Adc(ReadMem(ReadU16Zp(0xF5) + Y)); TotalCycles += 5; PC = 0xF6B1;
                    goto case 0xF6B1;
                case 0xF6B0:
                    Sbc(_ram[(byte)(0xA6 + X)]); TotalCycles += 4; PC = 0xF6B2;
                    return;
                case 0xF6B1:
                    X = _ram[0xF4]; SetZN(X); TotalCycles += 3; PC = 0xF6B3;
                    goto case 0xF6B3;
                case 0xF6B3:
                    _ram[0x07C5] = X; TotalCycles += 4; PC = 0xF6B6;
                    goto case 0xF6B6;
                case 0xF6B4:
                    Cmp(A, _ram[0x07]); TotalCycles += 3; PC = 0xF6B6;
                    goto case 0xF6B6;
                case 0xF6B6:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xF6B8;
                    goto case 0xF6B8;
                case 0xF6B7:
                    TotalCycles += 7; PushU16(0xF6B9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF6B8:
                    _ram[0x07C4] = Y; TotalCycles += 4; PC = 0xF6BB;
                    goto case 0xF6BB;
                case 0xF6B9:
                    Cmp(Y, _ram[0x07]); TotalCycles += 3; PC = 0xF6BB;
                    goto case 0xF6BB;
                case 0xF6BB:
                    _ram[0xF4] = Y; TotalCycles += 3; PC = 0xF6BD;
                    goto case 0xF6BD;
                case 0xF6BD:
                    Cmp(A, 0x40); TotalCycles += 2; PC = 0xF6BF;
                    goto case 0xF6BF;
                case 0xF6BE:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF6BF:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF6F1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6F1; }
                    PC = 0xF6C1; goto case 0xF6C1;
                case 0xF6C0:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF664; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF664; }
                    PC = 0xF6C2; goto case 0xF6C2;
                case 0xF6C1:
                    X = 0x08; SetZN(X); TotalCycles += 2; PC = 0xF6C3;
                    goto case 0xF6C3;
                case 0xF6C2:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF6C3;
                    goto case 0xF6C3;
                case 0xF6C3:
                    _ram[0x07C4] = X; TotalCycles += 4; PC = 0xF6C6;
                    goto case 0xF6C6;
                case 0xF6C4:
                    Cmp(Y, _ram[0x07]); TotalCycles += 3; PC = 0xF6C6;
                    goto case 0xF6C6;
                case 0xF6C6:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF6F1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6F1; }
                    PC = 0xF6C8; goto case 0xF6C8;
                case 0xF6C7:
                    A &= 0xC9; SetZN(A); TotalCycles += 2; PC = 0xF6C9;
                    return;
                case 0xF6C8:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0xF6CA;
                    goto case 0xF6CA;
                case 0xF6CA:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF6CF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6CF; }
                    PC = 0xF6CC; goto case 0xF6CC;
                case 0xF6CC:
                    TotalCycles += 6; PushU16(0xF6CE); PC = 0xF4A7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF4A7;
                case 0xF6CF:
                    Y = 0x10; SetZN(Y); TotalCycles += 2; PC = 0xF6D1;
                    goto case 0xF6D1;
                case 0xF6D0:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF65E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF65E; }
                    PC = 0xF6D2; return;
                case 0xF6D1:
                    _ram[0x07C7] = Y; TotalCycles += 4; PC = 0xF6D4;
                    goto case 0xF6D4;
                case 0xF6D4:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xF6D6;
                    goto case 0xF6D6;
                case 0xF6D5:
                    TotalCycles += 7; PushU16(0xF6D7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF6D6:
                    _ram[0x07B1] = Y; TotalCycles += 4; PC = 0xF6D9;
                    goto case 0xF6D9;
                case 0xF6D7:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF6D9;
                    goto case 0xF6D9;
                case 0xF6D9:
                    _ram[0xF4] = A; TotalCycles += 3; PC = 0xF6DB;
                    goto case 0xF6DB;
                case 0xF6DB:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0xF6DD;
                    goto case 0xF6DD;
                case 0xF6DC:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0xF6DE;
                    goto case 0xF6DE;
                case 0xF6DD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF6ED; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6ED; }
                    PC = 0xF6DF; goto case 0xF6DF;
                case 0xF6DE:
                    { int a = 0xC7EE; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xF6E1;
                    return;
                case 0xF6DF:
                    _ram[0x07C7] = IncVal(_ram[0x07C7]); TotalCycles += 6; PC = 0xF6E2;
                    goto case 0xF6E2;
                case 0xF6E2:
                    Y = _ram[0x07C7]; SetZN(Y); TotalCycles += 4; PC = 0xF6E5;
                    goto case 0xF6E5;
                case 0xF6E5:
                    Cmp(Y, 0x32); TotalCycles += 2; PC = 0xF6E7;
                    goto case 0xF6E7;
                case 0xF6E7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF6F5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6F5; }
                    PC = 0xF6E9; goto case 0xF6E9;
                case 0xF6E9:
                    Y = 0x11; SetZN(Y); TotalCycles += 2; PC = 0xF6EB;
                    goto case 0xF6EB;
                case 0xF6EA:
                    A |= ReadMem(ReadU16Zp(0xD0) + Y); SetZN(A); TotalCycles += 5; PC = 0xF6EC;
                    goto case 0xF6EC;
                case 0xF6EB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF6D1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6D1; }
                    PC = 0xF6ED; goto case 0xF6ED;
                case 0xF6EC:
                    Cmp(X, _ram[0xA0]); TotalCycles += 3; PC = 0xF6EE;
                    goto case 0xF6EE;
                case 0xF6ED:
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0xF6EF;
                    goto case 0xF6EF;
                case 0xF6EE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF6EF;
                    goto case 0xF6EF;
                case 0xF6EF:
                    _ram[0xF7] = Y; TotalCycles += 3; PC = 0xF6F1;
                    goto case 0xF6F1;
                case 0xF6F1:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xF6F2;
                    goto case 0xF6F2;
                case 0xF6F2:
                    A = Lsr(A); TotalCycles += 2; PC = 0xF6F3;
                    goto case 0xF6F3;
                case 0xF6F3:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF6F1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6F1; }
                    PC = 0xF6F5; goto case 0xF6F5;
                case 0xF6F5:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x790C + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF6F8;
                    goto case 0xF6F8;
                case 0xF6F7:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x39A8 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF6FA;
                    goto case 0xF6FA;
                case 0xF6F8:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF6F9;
                    goto case 0xF6F9;
                case 0xF6F9:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x790D + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF6FC;
                    goto case 0xF6FC;
                case 0xF6FA:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x05F9]; SetZN(A); TotalCycles += 4; PC = 0xF6FD;
                    goto case 0xF6FD;
                case 0xF6FB:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7085 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF6FE;
                    goto case 0xF6FE;
                case 0xF6FC:
                    _ram[0xF0] = A; TotalCycles += 3; PC = 0xF6FE;
                    goto case 0xF6FE;
                case 0xF6FD:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF6B8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6B8; }
                    PC = 0xF6FF; goto case 0xF6FF;
                case 0xF6FE:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x790E + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF701;
                    goto case 0xF701;
                case 0xF6FF:
                    { int a = 0x85F9; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xF702;
                    goto case 0xF702;
                case 0xF700:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7585 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF703;
                    goto case 0xF703;
                case 0xF701:
                    _ram[0xF5] = A; TotalCycles += 3; PC = 0xF703;
                    goto case 0xF703;
                case 0xF702:
                    Sbc(_ram[(byte)(0xB9 + X)]); TotalCycles += 4; PC = 0xF704;
                    return;
                case 0xF703:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x790F + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF706;
                    goto case 0xF706;
                case 0xF705:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7685 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF708;
                    goto case 0xF708;
                case 0xF706:
                    _ram[0xF6] = A; TotalCycles += 3; PC = 0xF708;
                    goto case 0xF708;
                case 0xF707:
                    { byte z = (byte)(0xB9 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xF709;
                    goto case 0xF709;
                case 0xF708:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7910 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF70B;
                    goto case 0xF70B;
                case 0xF709:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF704; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF70B; goto case 0xF70B;
                case 0xF70A:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7985 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF70D;
                    goto case 0xF70D;
                case 0xF70B:
                    _ram[0xF9] = A; TotalCycles += 3; PC = 0xF70D;
                    goto case 0xF70D;
                case 0xF70C:
                    Sbc(ReadMem(0x11B9 + Y)); TotalCycles += 4; PC = 0xF70F;
                    goto case 0xF70F;
                case 0xF70D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7911 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF710;
                    goto case 0xF710;
                case 0xF70E:
                    A |= ReadMem(ReadU16Zp(0xF9) + Y); SetZN(A); TotalCycles += 5; PC = 0xF710;
                    goto case 0xF710;
                case 0xF70F:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7885 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF712;
                    goto case 0xF712;
                case 0xF710:
                    _ram[0xF8] = A; TotalCycles += 3; PC = 0xF712;
                    goto case 0xF712;
                case 0xF711:
                    P |= FlagD; TotalCycles += 2; PC = 0xF712;
                    goto case 0xF712;
                case 0xF712:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7912 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF715;
                    goto case 0xF715;
                case 0xF714:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x308D + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF717;
                    return;
                case 0xF715:
                    _ram[0x07B0] = A; TotalCycles += 4; PC = 0xF718;
                    goto case 0xF718;
                case 0xF716:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF71F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF718; goto case 0xF718;
                case 0xF718:
                    _ram[0x07C1] = A; TotalCycles += 4; PC = 0xF71B;
                    goto case 0xF71B;
                case 0xF719:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x07 + X)))); TotalCycles += 6; PC = 0xF71B;
                    goto case 0xF71B;
                case 0xF71B:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xF71D;
                    goto case 0xF71D;
                case 0xF71C:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0xF71E;
                    goto case 0xF71E;
                case 0xF71D:
                    _ram[0x07B4] = A; TotalCycles += 4; PC = 0xF720;
                    goto case 0xF720;
                case 0xF71E:
                    Y = _ram[(byte)(0x07 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xF720;
                    goto case 0xF720;
                case 0xF720:
                    _ram[0x07B6] = A; TotalCycles += 4; PC = 0xF723;
                    goto case 0xF723;
                case 0xF721:
                    X = _ram[(byte)(0x07 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xF723;
                    goto case 0xF723;
                case 0xF723:
                    _ram[0x07B9] = A; TotalCycles += 4; PC = 0xF726;
                    goto case 0xF726;
                case 0xF724:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0D07 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF727;
                    goto case 0xF727;
                case 0xF726:
                    _ram[0x07BA] = A; TotalCycles += 4; PC = 0xF729;
                    goto case 0xF729;
                case 0xF727:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xF728;
                    return;
                case 0xF729:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF72B;
                    goto case 0xF72B;
                case 0xF72A:
                    TotalCycles += 7; PushU16(0xF72C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF72B:
                    _ram[0xF7] = A; TotalCycles += 3; PC = 0xF72D;
                    goto case 0xF72D;
                case 0xF72D:
                    _ram[0x07CA] = A; TotalCycles += 4; PC = 0xF730;
                    goto case 0xF730;
                case 0xF72E:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xF72F;
                    return;
                case 0xF730:
                    A = 0x0B; SetZN(A); TotalCycles += 2; PC = 0xF732;
                    goto case 0xF732;
                case 0xF732:
                    WriteIoReg(0x4015, A); TotalCycles += 4; PC = 0xF735;
                    goto case 0xF735;
                case 0xF733:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF735;
                    goto case 0xF735;
                case 0xF734:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF735:
                    A = 0x0F; SetZN(A); TotalCycles += 2; PC = 0xF737;
                    goto case 0xF737;
                case 0xF737:
                    WriteIoReg(0x4015, A); TotalCycles += 4; PC = 0xF73A;
                    goto case 0xF73A;
                case 0xF738:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF73A;
                    goto case 0xF73A;
                case 0xF739:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF73A:
                    _ram[0x07B4] = DecVal(_ram[0x07B4]); TotalCycles += 6; PC = 0xF73D;
                    goto case 0xF73D;
                case 0xF73B:
                    Y = _ram[(byte)(0x07 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xF73D;
                    goto case 0xF73D;
                case 0xF73D:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF79E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF79E; }
                    PC = 0xF73F; goto case 0xF73F;
                case 0xF73F:
                    Y = _ram[0xF7]; SetZN(Y); TotalCycles += 3; PC = 0xF741;
                    goto case 0xF741;
                case 0xF741:
                    _ram[0xF7] = IncVal(_ram[0xF7]); TotalCycles += 5; PC = 0xF743;
                    goto case 0xF743;
                case 0xF743:
                    A = ReadMem(ReadU16Zp(0xF5) + Y); SetZN(A); TotalCycles += 5; PC = 0xF745;
                    goto case 0xF745;
                case 0xF744:
                    Sbc(_ram[(byte)(0xF0 + X)]); TotalCycles += 4; PC = 0xF746;
                    return;
                case 0xF745:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF74B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF74B; }
                    PC = 0xF747; goto case 0xF747;
                case 0xF747:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF786; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF786; }
                    PC = 0xF749; goto case 0xF749;
                case 0xF748:
                    A &= ReadMem(0x2FD0 + X); SetZN(A); TotalCycles += 4; PC = 0xF74B;
                    goto case 0xF74B;
                case 0xF749:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF77A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF77A; }
                    PC = 0xF74B; goto case 0xF74B;
                case 0xF74B:
                    A = _ram[0x07B1]; SetZN(A); TotalCycles += 4; PC = 0xF74E;
                    goto case 0xF74E;
                case 0xF74C:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF74E;
                    goto case 0xF74E;
                case 0xF74E:
                    Cmp(A, 0x40); TotalCycles += 2; PC = 0xF750;
                    goto case 0xF750;
                case 0xF74F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF750:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF757; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF757; }
                    PC = 0xF752; goto case 0xF752;
                case 0xF751:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0xF753;
                    goto case 0xF753;
                case 0xF752:
                    A = _ram[0x07C5]; SetZN(A); TotalCycles += 4; PC = 0xF755;
                    goto case 0xF755;
                case 0xF753:
                    Cmp(A, _ram[0x07]); TotalCycles += 3; PC = 0xF755;
                    goto case 0xF755;
                case 0xF755:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF774; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF774; }
                    PC = 0xF757; goto case 0xF757;
                case 0xF756:
                    A |= _ram[(0x0429 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xF759;
                    goto case 0xF759;
                case 0xF757:
                    A &= 0x04; SetZN(A); TotalCycles += 2; PC = 0xF759;
                    goto case 0xF759;
                case 0xF759:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF777; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF777; }
                    PC = 0xF75B; goto case 0xF75B;
                case 0xF75B:
                    A = _ram[0xF4]; SetZN(A); TotalCycles += 3; PC = 0xF75D;
                    goto case 0xF75D;
                case 0xF75D:
                    A &= 0x5F; SetZN(A); TotalCycles += 2; PC = 0xF75F;
                    goto case 0xF75F;
                case 0xF75F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF774; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF774; }
                    PC = 0xF761; goto case 0xF761;
                case 0xF761:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xF763;
                    goto case 0xF763;
                case 0xF762:
                    TotalCycles += 7; PushU16(0xF764); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF763:
                    _ram[0xF4] = A; TotalCycles += 3; PC = 0xF765;
                    goto case 0xF765;
                case 0xF765:
                    _ram[0x07B1] = A; TotalCycles += 4; PC = 0xF768;
                    goto case 0xF768;
                case 0xF766:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF768;
                    goto case 0xF768;
                case 0xF768:
                    WriteIoReg(0x4008, A); TotalCycles += 4; PC = 0xF76B;
                    goto case 0xF76B;
                case 0xF769:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF76A;
                    goto case 0xF76A;
                case 0xF76A:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF76B:
                    A = 0x90; SetZN(A); TotalCycles += 2; PC = 0xF76D;
                    goto case 0xF76D;
                case 0xF76C:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xF6FB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF6FB; }
                    PC = 0xF76E; goto case 0xF76E;
                case 0xF76D:
                    WriteIoReg(0x4000, A); TotalCycles += 4; PC = 0xF770;
                    goto case 0xF770;
                case 0xF76E:
                    TotalCycles += 7; PushU16(0xF770); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF76F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF770:
                    WriteIoReg(0x4004, A); TotalCycles += 4; PC = 0xF773;
                    goto case 0xF773;
                case 0xF772:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF773:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF774:
                    TotalCycles += 3; PC = 0xF6D4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF6D4;
                case 0xF776:
                    { byte z = (byte)(0x4C + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xF778;
                    goto case 0xF778;
                case 0xF777:
                    TotalCycles += 3; PC = 0xF6A4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF6A4;
                case 0xF778:
                    Y = _ram[0xF6]; SetZN(Y); TotalCycles += 3; PC = 0xF77A;
                    goto case 0xF77A;
                case 0xF779:
                    { byte z = (byte)(0x20 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xF77B;
                    return;
                case 0xF77A:
                    TotalCycles += 6; PushU16(0xF77C); PC = 0xF8CB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF8CB;
                case 0xF77C:
                    P |= FlagD; TotalCycles += 2; PC = 0xF77D;
                    goto case 0xF77D;
                case 0xF77D:
                    _ram[0x07B3] = A; TotalCycles += 4; PC = 0xF780;
                    goto case 0xF780;
                case 0xF780:
                    Y = _ram[0xF7]; SetZN(Y); TotalCycles += 3; PC = 0xF782;
                    goto case 0xF782;
                case 0xF782:
                    _ram[0xF7] = IncVal(_ram[0xF7]); TotalCycles += 5; PC = 0xF784;
                    goto case 0xF784;
                case 0xF784:
                    A = ReadMem(ReadU16Zp(0xF5) + Y); SetZN(A); TotalCycles += 5; PC = 0xF786;
                    goto case 0xF786;
                case 0xF785:
                    Sbc(_ram[(byte)(0xA6 + X)]); TotalCycles += 4; PC = 0xF787;
                    return;
                case 0xF786:
                    X = _ram[0xF2]; SetZN(X); TotalCycles += 3; PC = 0xF788;
                    goto case 0xF788;
                case 0xF788:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF798; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF798; }
                    PC = 0xF78A; goto case 0xF78A;
                case 0xF789:
                    { int a = 0xA920; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xF78C;
                    return;
                case 0xF78A:
                    TotalCycles += 6; PushU16(0xF78C); PC = 0xF3A9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF3A9;
                case 0xF78B:
                    A = 0xF3; SetZN(A); TotalCycles += 2; PC = 0xF78D;
                    goto case 0xF78D;
                case 0xF78D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF792; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF792; }
                    PC = 0xF78F; goto case 0xF78F;
                case 0xF78F:
                    TotalCycles += 6; PushU16(0xF791); PC = 0xF8D8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF8D8;
                case 0xF790:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xF791;
                    goto case 0xF791;
                case 0xF791:
                    P |= FlagD; TotalCycles += 2; PC = 0xF792;
                    goto case 0xF792;
                case 0xF792:
                    _ram[0x07B5] = A; TotalCycles += 4; PC = 0xF795;
                    goto case 0xF795;
                case 0xF793:
                    A = _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF795;
                    goto case 0xF795;
                case 0xF795:
                    TotalCycles += 6; PushU16(0xF797); PC = 0xF39F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF39F;
                case 0xF798:
                    A = _ram[0x07B3]; SetZN(A); TotalCycles += 4; PC = 0xF79B;
                    goto case 0xF79B;
                case 0xF79B:
                    _ram[0x07B4] = A; TotalCycles += 4; PC = 0xF79E;
                    goto case 0xF79E;
                case 0xF79C:
                    Y = _ram[(byte)(0x07 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xF79E;
                    goto case 0xF79E;
                case 0xF79E:
                    A = _ram[0xF2]; SetZN(A); TotalCycles += 3; PC = 0xF7A0;
                    goto case 0xF7A0;
                case 0xF7A0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF7BC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF7BC; }
                    PC = 0xF7A2; goto case 0xF7A2;
                case 0xF7A2:
                    A = _ram[0x07B1]; SetZN(A); TotalCycles += 4; PC = 0xF7A5;
                    goto case 0xF7A5;
                case 0xF7A3:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF7A5;
                    goto case 0xF7A5;
                case 0xF7A5:
                    A &= 0x91; SetZN(A); TotalCycles += 2; PC = 0xF7A7;
                    goto case 0xF7A7;
                case 0xF7A6:
                    WriteMem(ReadU16Zp(0xD0) + Y, A); TotalCycles += 6; PC = 0xF7A8;
                    return;
                case 0xF7A7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF7BC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF7BC; }
                    PC = 0xF7A9; goto case 0xF7A9;
                case 0xF7A9:
                    Y = _ram[0x07B5]; SetZN(Y); TotalCycles += 4; PC = 0xF7AC;
                    goto case 0xF7AC;
                case 0xF7AA:
                    A = _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF7AC;
                    goto case 0xF7AC;
                case 0xF7AC:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF7B1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF7B1; }
                    PC = 0xF7AE; goto case 0xF7AE;
                case 0xF7AE:
                    _ram[0x07B5] = DecVal(_ram[0x07B5]); TotalCycles += 6; PC = 0xF7B1;
                    goto case 0xF7B1;
                case 0xF7AF:
                    A = _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0xF7B1;
                    goto case 0xF7B1;
                case 0xF7B1:
                    TotalCycles += 6; PushU16(0xF7B3); PC = 0xF8F4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF8F4;
                case 0xF7B3:
                    P |= FlagD; TotalCycles += 2; PC = 0xF7B4;
                    goto case 0xF7B4;
                case 0xF7B4:
                    WriteIoReg(0x4004, A); TotalCycles += 4; PC = 0xF7B7;
                    goto case 0xF7B7;
                case 0xF7B6:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF7B7:
                    X = 0x7F; SetZN(X); TotalCycles += 2; PC = 0xF7B9;
                    goto case 0xF7B9;
                case 0xF7B9:
                    WriteIoReg(0x4005, X); TotalCycles += 4; PC = 0xF7BC;
                    goto case 0xF7BC;
                case 0xF7BA:
                    A |= _ram[0x40]; SetZN(A); TotalCycles += 3; PC = 0xF7BC;
                    goto case 0xF7BC;
                case 0xF7BB:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF7BC:
                    Y = _ram[0xF8]; SetZN(Y); TotalCycles += 3; PC = 0xF7BE;
                    goto case 0xF7BE;
                case 0xF7BD:
                    P |= FlagD; TotalCycles += 2; PC = 0xF7BE;
                    goto case 0xF7BE;
                case 0xF7BE:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF81A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF81A; }
                    PC = 0xF7C0; goto case 0xF7C0;
                case 0xF7C0:
                    _ram[0x07B6] = DecVal(_ram[0x07B6]); TotalCycles += 6; PC = 0xF7C3;
                    goto case 0xF7C3;
                case 0xF7C1:
                    X = _ram[(byte)(0x07 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xF7C3;
                    goto case 0xF7C3;
                case 0xF7C3: // === SUBROUTINE: Sub_F7C3 ===
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF7F7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF7F7; }
                    PC = 0xF7C5; goto case 0xF7C5;
                case 0xF7C5:
                    Y = _ram[0xF8]; SetZN(Y); TotalCycles += 3; PC = 0xF7C7;
                    goto case 0xF7C7;
                case 0xF7C6:
                    P |= FlagD; TotalCycles += 2; PC = 0xF7C7;
                    goto case 0xF7C7;
                case 0xF7C7:
                    _ram[0xF8] = IncVal(_ram[0xF8]); TotalCycles += 5; PC = 0xF7C9;
                    goto case 0xF7C9;
                case 0xF7C8:
                    P |= FlagD; TotalCycles += 2; PC = 0xF7C9;
                    goto case 0xF7C9;
                case 0xF7C9:
                    A = ReadMem(ReadU16Zp(0xF5) + Y); SetZN(A); TotalCycles += 5; PC = 0xF7CB;
                    goto case 0xF7CB;
                case 0xF7CA:
                    Sbc(_ram[(byte)(0xD0 + X)]); TotalCycles += 4; PC = 0xF7CC;
                    return;
                case 0xF7CB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF7DC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF7DC; }
                    PC = 0xF7CD; goto case 0xF7CD;
                case 0xF7CD:
                    A = 0x83; SetZN(A); TotalCycles += 2; PC = 0xF7CF;
                    goto case 0xF7CF;
                case 0xF7CF:
                    WriteIoReg(0x4000, A); TotalCycles += 4; PC = 0xF7D2;
                    goto case 0xF7D2;
                case 0xF7D0:
                    TotalCycles += 7; PushU16(0xF7D2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF7D1:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF7D2:
                    A = 0x94; SetZN(A); TotalCycles += 2; PC = 0xF7D4;
                    goto case 0xF7D4;
                case 0xF7D3:
                    _ram[(byte)(0x8D + X)] = Y; TotalCycles += 4; PC = 0xF7D5;
                    goto case 0xF7D5;
                case 0xF7D4:
                    WriteIoReg(0x4001, A); TotalCycles += 4; PC = 0xF7D7;
                    goto case 0xF7D7;
                case 0xF7D5:
                    A |= ReadMem(ReadU16Zp((byte)(0x40 + X))); SetZN(A); TotalCycles += 6; PC = 0xF7D7;
                    goto case 0xF7D7;
                case 0xF7D6:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF7D7:
                    _ram[0x07CA] = A; TotalCycles += 4; PC = 0xF7DA;
                    goto case 0xF7DA;
                case 0xF7D8:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xF7D9;
                    return;
                case 0xF7DA:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF7C5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF7C5; }
                    PC = 0xF7DC; goto case 0xF7DC;
                case 0xF7DB:
                    Sbc(0x20); TotalCycles += 2; PC = 0xF7DD;
                    goto case 0xF7DD;
                case 0xF7DC:
                    TotalCycles += 6; PushU16(0xF7DE); PC = 0xF8C5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF8C5;
                case 0xF7DD:
                    Cmp(A, _ram[0xF8]); TotalCycles += 3; PC = 0xF7DF;
                    goto case 0xF7DF;
                case 0xF7DE:
                    P |= FlagD; TotalCycles += 2; PC = 0xF7DF;
                    goto case 0xF7DF;
                case 0xF7DF:
                    _ram[0x07B6] = A; TotalCycles += 4; PC = 0xF7E2;
                    goto case 0xF7E2;
                case 0xF7E0:
                    X = _ram[(byte)(0x07 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xF7E2;
                    goto case 0xF7E2;
                case 0xF7E2:
                    Y = _ram[0xF1]; SetZN(Y); TotalCycles += 3; PC = 0xF7E4;
                    goto case 0xF7E4;
                case 0xF7E3:
                    Sbc(ReadMem(ReadU16Zp(0xD0) + Y)); TotalCycles += 5; PC = 0xF7E5;
                    return;
                case 0xF7E4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF81A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF81A; }
                    PC = 0xF7E6; goto case 0xF7E6;
                case 0xF7E6:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xF7E7;
                    goto case 0xF7E7;
                case 0xF7E7:
                    A &= 0x3E; SetZN(A); TotalCycles += 2; PC = 0xF7E9;
                    goto case 0xF7E9;
                case 0xF7E8:
                    { int a = 0x8B20 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xF7EB;
                    return;
                case 0xF7E9:
                    TotalCycles += 6; PushU16(0xF7EB); PC = 0xF38B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF38B;
                case 0xF7EC:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF7F1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF7F1; }
                    PC = 0xF7EE; goto case 0xF7EE;
                case 0xF7EE:
                    TotalCycles += 6; PushU16(0xF7F0); PC = 0xF8D8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF8D8;
                case 0xF7EF:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xF7F0;
                    goto case 0xF7F0;
                case 0xF7F0:
                    P |= FlagD; TotalCycles += 2; PC = 0xF7F1;
                    goto case 0xF7F1;
                case 0xF7F1:
                    _ram[0x07B7] = A; TotalCycles += 4; PC = 0xF7F4;
                    goto case 0xF7F4;
                case 0xF7F4:
                    TotalCycles += 6; PushU16(0xF7F6); PC = 0xF381;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF381;
                case 0xF7F5:
                    WriteMem(ReadU16Zp((byte)(0xF3 + X)), A); TotalCycles += 6; PC = 0xF7F7;
                    goto case 0xF7F7;
                case 0xF7F7:
                    A = _ram[0xF1]; SetZN(A); TotalCycles += 3; PC = 0xF7F9;
                    goto case 0xF7F9;
                case 0xF7F8:
                    Sbc(ReadMem(ReadU16Zp(0xD0) + Y)); TotalCycles += 5; PC = 0xF7FA;
                    return;
                case 0xF7F9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF81A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF81A; }
                    PC = 0xF7FB; goto case 0xF7FB;
                case 0xF7FB:
                    A = _ram[0x07B1]; SetZN(A); TotalCycles += 4; PC = 0xF7FE;
                    goto case 0xF7FE;
                case 0xF7FC:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF7FE;
                    goto case 0xF7FE;
                case 0xF7FE:
                    A &= 0x91; SetZN(A); TotalCycles += 2; PC = 0xF800;
                    goto case 0xF800;
                case 0xF7FF:
                    WriteMem(ReadU16Zp(0xD0) + Y, A); TotalCycles += 6; PC = 0xF801;
                    goto case 0xF801;
                case 0xF800:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF810; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF810; }
                    PC = 0xF802; goto case 0xF802;
                case 0xF801:
                    { int a = 0xB7AC; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xF804;
                    return;
                case 0xF802:
                    Y = _ram[0x07B7]; SetZN(Y); TotalCycles += 4; PC = 0xF805;
                    goto case 0xF805;
                case 0xF805:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF80A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF80A; }
                    PC = 0xF807; goto case 0xF807;
                case 0xF807:
                    _ram[0x07B7] = DecVal(_ram[0x07B7]); TotalCycles += 6; PC = 0xF80A;
                    goto case 0xF80A;
                case 0xF80A:
                    TotalCycles += 6; PushU16(0xF80C); PC = 0xF8F4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF8F4;
                case 0xF80C:
                    P |= FlagD; TotalCycles += 2; PC = 0xF80D;
                    goto case 0xF80D;
                case 0xF80D:
                    WriteIoReg(0x4000, A); TotalCycles += 4; PC = 0xF810;
                    goto case 0xF810;
                case 0xF80E:
                    TotalCycles += 7; PushU16(0xF810); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF80F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF810:
                    A = _ram[0x07CA]; SetZN(A); TotalCycles += 4; PC = 0xF813;
                    goto case 0xF813;
                case 0xF811:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xF812;
                    return;
                case 0xF813:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF817; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF817; }
                    PC = 0xF815; goto case 0xF815;
                case 0xF815:
                    A = 0x7F; SetZN(A); TotalCycles += 2; PC = 0xF817;
                    goto case 0xF817;
                case 0xF817:
                    WriteIoReg(0x4001, A); TotalCycles += 4; PC = 0xF81A;
                    goto case 0xF81A;
                case 0xF818:
                    A |= ReadMem(ReadU16Zp((byte)(0x40 + X))); SetZN(A); TotalCycles += 6; PC = 0xF81A;
                    goto case 0xF81A;
                case 0xF819:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF81A:
                    A = _ram[0xF9]; SetZN(A); TotalCycles += 3; PC = 0xF81C;
                    goto case 0xF81C;
                case 0xF81B:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x39CE + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF81E;
                    return;
                case 0xF81C:
                    _ram[0x07B9] = DecVal(_ram[0x07B9]); TotalCycles += 6; PC = 0xF81F;
                    goto case 0xF81F;
                case 0xF81D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x5007 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF820;
                    goto case 0xF820;
                case 0xF81F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF86D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF86D; }
                    PC = 0xF821; goto case 0xF821;
                case 0xF820:
                    TotalCycles += 3; PC = 0xF9A4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF9A4;
                case 0xF821:
                    Y = _ram[0xF9]; SetZN(Y); TotalCycles += 3; PC = 0xF823;
                    goto case 0xF823;
                case 0xF822:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x79E6 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF825;
                    goto case 0xF825;
                case 0xF823:
                    _ram[0xF9] = IncVal(_ram[0xF9]); TotalCycles += 5; PC = 0xF825;
                    goto case 0xF825;
                case 0xF824:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x75B1 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF827;
                    goto case 0xF827;
                case 0xF825:
                    A = ReadMem(ReadU16Zp(0xF5) + Y); SetZN(A); TotalCycles += 5; PC = 0xF827;
                    goto case 0xF827;
                case 0xF826:
                    Sbc(_ram[(byte)(0xF0 + X)]); TotalCycles += 4; PC = 0xF828;
                    goto case 0xF828;
                case 0xF827:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF86A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF86A; }
                    PC = 0xF829; goto case 0xF829;
                case 0xF828:
                    A ^= ReadMem(ReadU16Zp((byte)(0x10 + X))); SetZN(A); TotalCycles += 6; PC = 0xF82A;
                    return;
                case 0xF829:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF83E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF83E; }
                    PC = 0xF82B; goto case 0xF82B;
                case 0xF82B:
                    TotalCycles += 6; PushU16(0xF82D); PC = 0xF8CB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF8CB;
                case 0xF82D:
                    P |= FlagD; TotalCycles += 2; PC = 0xF82E;
                    goto case 0xF82E;
                case 0xF82E:
                    _ram[0x07B8] = A; TotalCycles += 4; PC = 0xF831;
                    goto case 0xF831;
                case 0xF82F:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xF830;
                    return;
                case 0xF831:
                    A = 0x1F; SetZN(A); TotalCycles += 2; PC = 0xF833;
                    goto case 0xF833;
                case 0xF833:
                    WriteIoReg(0x4008, A); TotalCycles += 4; PC = 0xF836;
                    goto case 0xF836;
                case 0xF834:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF835;
                    goto case 0xF835;
                case 0xF835:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF836:
                    Y = _ram[0xF9]; SetZN(Y); TotalCycles += 3; PC = 0xF838;
                    goto case 0xF838;
                case 0xF837:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x79E6 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF83A;
                    goto case 0xF83A;
                case 0xF838:
                    _ram[0xF9] = IncVal(_ram[0xF9]); TotalCycles += 5; PC = 0xF83A;
                    goto case 0xF83A;
                case 0xF839:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x75B1 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xF83C;
                    goto case 0xF83C;
                case 0xF83A:
                    A = ReadMem(ReadU16Zp(0xF5) + Y); SetZN(A); TotalCycles += 5; PC = 0xF83C;
                    goto case 0xF83C;
                case 0xF83B:
                    Sbc(_ram[(byte)(0xF0 + X)]); TotalCycles += 4; PC = 0xF83D;
                    goto case 0xF83D;
                case 0xF83C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF86A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF86A; }
                    PC = 0xF83E; goto case 0xF83E;
                case 0xF83D:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x2D20]); TotalCycles += 4; PC = 0xF840;
                    return;
                case 0xF83E:
                    TotalCycles += 6; PushU16(0xF840); PC = 0xF3AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF3AD;
                case 0xF83F:
                    A = SmbEmbeddedAssets.StaticDataTables[0x2EF3]; SetZN(A); TotalCycles += 4; PC = 0xF842;
                    goto case 0xF842;
                case 0xF841:
                    X = _ram[0x07B8]; SetZN(X); TotalCycles += 4; PC = 0xF844;
                    goto case 0xF844;
                case 0xF842:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xF843;
                    return;
                case 0xF844:
                    _ram[0x07B9] = X; TotalCycles += 4; PC = 0xF847;
                    goto case 0xF847;
                case 0xF845:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2D07 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF848;
                    goto case 0xF848;
                case 0xF847:
                    A = _ram[0x07B1]; SetZN(A); TotalCycles += 4; PC = 0xF84A;
                    goto case 0xF84A;
                case 0xF848:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF84A;
                    goto case 0xF84A;
                case 0xF84A:
                    A &= 0x6E; SetZN(A); TotalCycles += 2; PC = 0xF84C;
                    goto case 0xF84C;
                case 0xF84B:
                    _ram[0x06D0] = Ror(_ram[0x06D0]); TotalCycles += 6; PC = 0xF84E;
                    goto case 0xF84E;
                case 0xF84C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF854; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF854; }
                    PC = 0xF84E; goto case 0xF84E;
                case 0xF84D:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xF84F;
                    return;
                case 0xF84E:
                    A = _ram[0xF4]; SetZN(A); TotalCycles += 3; PC = 0xF850;
                    goto case 0xF850;
                case 0xF850:
                    A &= 0x0A; SetZN(A); TotalCycles += 2; PC = 0xF852;
                    goto case 0xF852;
                case 0xF851:
                    A = Asl(A); TotalCycles += 2; PC = 0xF852;
                    goto case 0xF852;
                case 0xF852:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF86D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF86D; }
                    PC = 0xF854; goto case 0xF854;
                case 0xF853:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x498A + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF856;
                    return;
                case 0xF854:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xF855;
                    goto case 0xF855;
                case 0xF855:
                    Cmp(A, 0x12); TotalCycles += 2; PC = 0xF857;
                    goto case 0xF857;
                case 0xF857:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF868; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF868; }
                    PC = 0xF859; goto case 0xF859;
                case 0xF859:
                    A = _ram[0x07B1]; SetZN(A); TotalCycles += 4; PC = 0xF85C;
                    goto case 0xF85C;
                case 0xF85A:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF85C;
                    goto case 0xF85C;
                case 0xF85C:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xF85E;
                    goto case 0xF85E;
                case 0xF85D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF85E;
                    goto case 0xF85E;
                case 0xF85E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF864; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF864; }
                    PC = 0xF860; goto case 0xF860;
                case 0xF860:
                    A = 0x0F; SetZN(A); TotalCycles += 2; PC = 0xF862;
                    goto case 0xF862;
                case 0xF862:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF86A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF86A; }
                    PC = 0xF864; goto case 0xF864;
                case 0xF863:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xF865;
                    return;
                case 0xF864:
                    A = 0x1F; SetZN(A); TotalCycles += 2; PC = 0xF866;
                    goto case 0xF866;
                case 0xF866:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF86A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF86A; }
                    PC = 0xF868; goto case 0xF868;
                case 0xF868:
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0xF86A;
                    goto case 0xF86A;
                case 0xF86A:
                    WriteIoReg(0x4008, A); TotalCycles += 4; PC = 0xF86D;
                    goto case 0xF86D;
                case 0xF86B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF86C;
                    goto case 0xF86C;
                case 0xF86C:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF86D:
                    A = _ram[0xF4]; SetZN(A); TotalCycles += 3; PC = 0xF86F;
                    goto case 0xF86F;
                case 0xF86F:
                    A &= 0xF3; SetZN(A); TotalCycles += 2; PC = 0xF871;
                    goto case 0xF871;
                case 0xF871:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF8C4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8C4; }
                    PC = 0xF873; goto case 0xF873;
                case 0xF872:
                    A ^= ReadMem(ReadU16Zp(0xCE) + Y); SetZN(A); TotalCycles += 5; PC = 0xF874;
                    goto case 0xF874;
                case 0xF873:
                    _ram[0x07BA] = DecVal(_ram[0x07BA]); TotalCycles += 6; PC = 0xF876;
                    goto case 0xF876;
                case 0xF874:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xF875;
                    return;
                case 0xF876:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF8C4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8C4; }
                    PC = 0xF878; goto case 0xF878;
                case 0xF877:
                    TotalCycles += 3; PC = 0xB0AC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF878:
                    Y = _ram[0x07B0]; SetZN(Y); TotalCycles += 4; PC = 0xF87B;
                    goto case 0xF87B;
                case 0xF879:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF882; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF882; }
                    PC = 0xF87B; goto case 0xF87B;
                case 0xF87B:
                    _ram[0x07B0] = IncVal(_ram[0x07B0]); TotalCycles += 6; PC = 0xF87E;
                    goto case 0xF87E;
                case 0xF87C:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF885; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF885; }
                    PC = 0xF87E; goto case 0xF87E;
                case 0xF87E:
                    A = ReadMem(ReadU16Zp(0xF5) + Y); SetZN(A); TotalCycles += 5; PC = 0xF880;
                    goto case 0xF880;
                case 0xF87F:
                    Sbc(_ram[(byte)(0xD0 + X)]); TotalCycles += 4; PC = 0xF881;
                    goto case 0xF881;
                case 0xF880:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF88A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF88A; }
                    PC = 0xF882; goto case 0xF882;
                case 0xF881:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF882;
                    goto case 0xF882;
                case 0xF882:
                    A = _ram[0x07C1]; SetZN(A); TotalCycles += 4; PC = 0xF885;
                    goto case 0xF885;
                case 0xF883:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x07 + X)))); TotalCycles += 6; PC = 0xF885;
                    goto case 0xF885;
                case 0xF885:
                    _ram[0x07B0] = A; TotalCycles += 4; PC = 0xF888;
                    goto case 0xF888;
                case 0xF886:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF88F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF888; goto case 0xF888;
                case 0xF888:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF878; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF878; }
                    PC = 0xF88A; goto case 0xF88A;
                case 0xF889:
                    { int a = 0xC520; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xF88C;
                    goto case 0xF88C;
                case 0xF88A:
                    TotalCycles += 6; PushU16(0xF88C); PC = 0xF8C5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF8C5;
                case 0xF88B:
                    Cmp(A, _ram[0xF8]); TotalCycles += 3; PC = 0xF88D;
                    goto case 0xF88D;
                case 0xF88C:
                    P |= FlagD; TotalCycles += 2; PC = 0xF88D;
                    goto case 0xF88D;
                case 0xF88D:
                    _ram[0x07BA] = A; TotalCycles += 4; PC = 0xF890;
                    goto case 0xF890;
                case 0xF88E:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xF88F;
                    return;
                case 0xF890:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xF891;
                    goto case 0xF891;
                case 0xF891:
                    A &= 0x3E; SetZN(A); TotalCycles += 2; PC = 0xF893;
                    goto case 0xF893;
                case 0xF892:
                    { int a = 0x24F0 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xF895;
                    goto case 0xF895;
                case 0xF893:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF8B9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8B9; }
                    PC = 0xF895; goto case 0xF895;
                case 0xF894:
                    Bit(_ram[0xC9]); TotalCycles += 3; PC = 0xF896;
                    goto case 0xF896;
                case 0xF895:
                    Cmp(A, 0x30); TotalCycles += 2; PC = 0xF897;
                    goto case 0xF897;
                case 0xF896:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF888; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF888; }
                    PC = 0xF898; goto case 0xF898;
                case 0xF897:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF8B1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8B1; }
                    PC = 0xF899; goto case 0xF899;
                case 0xF898:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF899;
                    goto case 0xF899;
                case 0xF899:
                    Cmp(A, 0x20); TotalCycles += 2; PC = 0xF89B;
                    goto case 0xF89B;
                case 0xF89A:
                    TotalCycles += 6; PushU16(0xF89C); PC = 0x0CF0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF89B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF8A9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8A9; }
                    PC = 0xF89D; goto case 0xF89D;
                case 0xF89D:
                    A &= 0x10; SetZN(A); TotalCycles += 2; PC = 0xF89F;
                    goto case 0xF89F;
                case 0xF89E:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF890; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF890; }
                    PC = 0xF8A0; goto case 0xF8A0;
                case 0xF89F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF8B9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8B9; }
                    PC = 0xF8A1; goto case 0xF8A1;
                case 0xF8A0:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF8A1;
                    goto case 0xF8A1;
                case 0xF8A1:
                    A = 0x1C; SetZN(A); TotalCycles += 2; PC = 0xF8A3;
                    goto case 0xF8A3;
                case 0xF8A3:
                    X = 0x03; SetZN(X); TotalCycles += 2; PC = 0xF8A5;
                    goto case 0xF8A5;
                case 0xF8A5:
                    Y = 0x18; SetZN(Y); TotalCycles += 2; PC = 0xF8A7;
                    goto case 0xF8A7;
                case 0xF8A6:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF8A7;
                    goto case 0xF8A7;
                case 0xF8A7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF8BB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8BB; }
                    PC = 0xF8A9; goto case 0xF8A9;
                case 0xF8A9:
                    A = 0x1C; SetZN(A); TotalCycles += 2; PC = 0xF8AB;
                    goto case 0xF8AB;
                case 0xF8AB:
                    X = 0x0C; SetZN(X); TotalCycles += 2; PC = 0xF8AD;
                    goto case 0xF8AD;
                case 0xF8AD:
                    Y = 0x18; SetZN(Y); TotalCycles += 2; PC = 0xF8AF;
                    goto case 0xF8AF;
                case 0xF8AE:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF8AF;
                    goto case 0xF8AF;
                case 0xF8AF:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF8BB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8BB; }
                    PC = 0xF8B1; goto case 0xF8B1;
                case 0xF8B0:
                    A = Asl(A); TotalCycles += 2; PC = 0xF8B1;
                    goto case 0xF8B1;
                case 0xF8B1:
                    A = 0x1C; SetZN(A); TotalCycles += 2; PC = 0xF8B3;
                    goto case 0xF8B3;
                case 0xF8B3:
                    X = 0x03; SetZN(X); TotalCycles += 2; PC = 0xF8B5;
                    goto case 0xF8B5;
                case 0xF8B5:
                    Y = 0x58; SetZN(Y); TotalCycles += 2; PC = 0xF8B7;
                    goto case 0xF8B7;
                case 0xF8B6:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xF8B7;
                    goto case 0xF8B7;
                case 0xF8B7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF8BB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8BB; }
                    PC = 0xF8B9; goto case 0xF8B9;
                case 0xF8B9:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0xF8BB;
                    goto case 0xF8BB;
                case 0xF8BA:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF849; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF8BC; return;
                case 0xF8BB:
                    WriteIoReg(0x400C, A); TotalCycles += 4; PC = 0xF8BE;
                    goto case 0xF8BE;
                case 0xF8BD:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF8BE:
                    WriteIoReg(0x400E, X); TotalCycles += 4; PC = 0xF8C1;
                    goto case 0xF8C1;
                case 0xF8BF:
                    { int a = 0x8C40; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xF8C2;
                    return;
                case 0xF8C0:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF8C1:
                    WriteIoReg(0x400F, Y); TotalCycles += 4; PC = 0xF8C4;
                    goto case 0xF8C4;
                case 0xF8C3:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF8C4:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF8C5: // === SUBROUTINE: HandleAreaMusicLoopB ===
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xF8C6;
                    goto case 0xF8C6;
                case 0xF8C6:
                    A = Ror(A); TotalCycles += 2; PC = 0xF8C7;
                    goto case 0xF8C7;
                case 0xF8C7:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xF8C8;
                    goto case 0xF8C8;
                case 0xF8C8:
                    A = Rol(A); TotalCycles += 2; PC = 0xF8C9;
                    goto case 0xF8C9;
                case 0xF8C9:
                    A = Rol(A); TotalCycles += 2; PC = 0xF8CA;
                    goto case 0xF8CA;
                case 0xF8CA:
                    A = Rol(A); TotalCycles += 2; PC = 0xF8CB;
                    goto case 0xF8CB;
                case 0xF8CB: // === SUBROUTINE: HandleAltMusic ===
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0xF8CD;
                    goto case 0xF8CD;
                case 0xF8CD:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF8CE;
                    goto case 0xF8CE;
                case 0xF8CE:
                    Adc(_ram[0xF0]); TotalCycles += 3; PC = 0xF8D0;
                    goto case 0xF8D0;
                case 0xF8CF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF93E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF93E; }
                    PC = 0xF8D1; goto case 0xF8D1;
                case 0xF8D0:
                    Adc(_ram[0x07C4]); TotalCycles += 4; PC = 0xF8D3;
                    goto case 0xF8D3;
                case 0xF8D1:
                    Cmp(Y, _ram[0x07]); TotalCycles += 3; PC = 0xF8D3;
                    goto case 0xF8D3;
                case 0xF8D3:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xF8D4;
                    goto case 0xF8D4;
                case 0xF8D4:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7F66 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF8D7;
                    goto case 0xF8D7;
                case 0xF8D5:
                    _ram[0xFF] = Ror(_ram[0xFF]); TotalCycles += 5; PC = 0xF8D7;
                    goto case 0xF8D7;
                case 0xF8D7:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF8D8: // === SUBROUTINE: LoadEventMusic ===
                    A = _ram[0x07B1]; SetZN(A); TotalCycles += 4; PC = 0xF8DB;
                    goto case 0xF8DB;
                case 0xF8D9:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF8DB;
                    goto case 0xF8DB;
                case 0xF8DB:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xF8DD;
                    goto case 0xF8DD;
                case 0xF8DC:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF8DD;
                    goto case 0xF8DD;
                case 0xF8DD:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF8E3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8E3; }
                    PC = 0xF8DF; goto case 0xF8DF;
                case 0xF8DF:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xF8E1;
                    goto case 0xF8E1;
                case 0xF8E1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF8EF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8EF; }
                    PC = 0xF8E3; goto case 0xF8E3;
                case 0xF8E3:
                    A = _ram[0xF4]; SetZN(A); TotalCycles += 3; PC = 0xF8E5;
                    goto case 0xF8E5;
                case 0xF8E5:
                    A &= 0x7D; SetZN(A); TotalCycles += 2; PC = 0xF8E7;
                    goto case 0xF8E7;
                case 0xF8E6:
                    Adc(_ram[(0x04F0 + X) & 0x07FF]); TotalCycles += 4; PC = 0xF8E9;
                    goto case 0xF8E9;
                case 0xF8E7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF8ED; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8ED; }
                    PC = 0xF8E9; goto case 0xF8E9;
                case 0xF8E9:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xF8EB;
                    goto case 0xF8EB;
                case 0xF8EA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF8EB;
                    goto case 0xF8EB;
                case 0xF8EB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF8EF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8EF; }
                    PC = 0xF8ED; goto case 0xF8ED;
                case 0xF8ED:
                    A = 0x28; SetZN(A); TotalCycles += 2; PC = 0xF8EF;
                    goto case 0xF8EF;
                case 0xF8EE:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xF8EF;
                    goto case 0xF8EF;
                case 0xF8EF:
                    X = 0x82; SetZN(X); TotalCycles += 2; PC = 0xF8F1;
                    goto case 0xF8F1;
                case 0xF8F1:
                    Y = 0x7F; SetZN(Y); TotalCycles += 2; PC = 0xF8F3;
                    goto case 0xF8F3;
                case 0xF8F3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF8F4: // === SUBROUTINE: LoadAreaMusic ===
                    A = _ram[0x07B1]; SetZN(A); TotalCycles += 4; PC = 0xF8F7;
                    goto case 0xF8F7;
                case 0xF8F5:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xF8F7;
                    goto case 0xF8F7;
                case 0xF8F7:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xF8F9;
                    goto case 0xF8F9;
                case 0xF8F8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF8F9;
                    goto case 0xF8F9;
                case 0xF8F9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF8FF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF8FF; }
                    PC = 0xF8FB; goto case 0xF8FB;
                case 0xF8FB:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7F96 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF8FE;
                    goto case 0xF8FE;
                case 0xF8FC:
                    _ram[(byte)(0xFF + Y)] = X; TotalCycles += 4; PC = 0xF8FE;
                    goto case 0xF8FE;
                case 0xF8FE:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF8FF:
                    A = _ram[0xF4]; SetZN(A); TotalCycles += 3; PC = 0xF901;
                    goto case 0xF901;
                case 0xF901:
                    A &= 0x7D; SetZN(A); TotalCycles += 2; PC = 0xF903;
                    goto case 0xF903;
                case 0xF902:
                    Adc(_ram[(0x04F0 + X) & 0x07FF]); TotalCycles += 4; PC = 0xF905;
                    goto case 0xF905;
                case 0xF903:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xF909; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF909; }
                    PC = 0xF905; goto case 0xF905;
                case 0xF905:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7F9A + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF908;
                    goto case 0xF908;
                case 0xF906:
                    SP = X; TotalCycles += 2; PC = 0xF907;
                    return;
                case 0xF908:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF909:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7FA2 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF90C;
                    goto case 0xF90C;
                case 0xF90A:
                    X = 0xFF; SetZN(X); TotalCycles += 2; PC = 0xF90C;
                    goto case 0xF90C;
                case 0xF90C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xF90D:
                    A = _ram[0x59]; SetZN(A); TotalCycles += 3; PC = 0xF90F;
                    return;
                case 0xF90E:
                    A ^= ReadMem(0x6454 + Y); SetZN(A); TotalCycles += 4; PC = 0xF911;
                    goto case 0xF911;
                case 0xF911:
                    A ^= ReadMem(0x313C + Y); SetZN(A); TotalCycles += 4; PC = 0xF914;
                    return;
                case 0xF913:
                    A &= ReadMem(ReadU16Zp(0x4B) + Y); SetZN(A); TotalCycles += 5; PC = 0xF915;
                    goto case 0xF915;
                case 0xF915:
                    Adc(0x5E); TotalCycles += 2; PC = 0xF917;
                    goto case 0xF917;
                case 0xF916:
                    { int a = 0x4F46 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xF919;
                    goto case 0xF919;
                case 0xF917:
                    _ram[0x4F] = Lsr(_ram[0x4F]); TotalCycles += 5; PC = 0xF919;
                    goto case 0xF919;
                case 0xF919:
                    { byte z = (byte)(0x8D + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xF91B;
                    goto case 0xF91B;
                case 0xF91A:
                    WriteIoReg(0x4B36, A); TotalCycles += 4; PC = 0xF91D;
                    goto case 0xF91D;
                case 0xF91B:
                    { byte z = (byte)(0x4B + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xF91D;
                    goto case 0xF91D;
                case 0xF91D:
                    WriteIoReg(0x6969, A); TotalCycles += 4; PC = 0xF920;
                    return;
                case 0xF91E:
                    Adc(0x69); TotalCycles += 2; PC = 0xF920;
                    return;
                case 0xF91F:
                    Adc(0x6F); TotalCycles += 2; PC = 0xF921;
                    goto case 0xF921;
                case 0xF921:
                    Adc(_ram[(byte)(0x6F + X)]); TotalCycles += 4; PC = 0xF923;
                    return;
                case 0xF925:
                    Adc(_ram[(byte)(0x6F + X)]); TotalCycles += 4; PC = 0xF927;
                    return;
                case 0xF928:
                    WriteMem(ReadU16Zp((byte)(0x87 + X)), A); TotalCycles += 6; PC = 0xF92A;
                    goto case 0xF92A;
                case 0xF92A:
                    WriteMem(ReadU16Zp((byte)(0x8D + X)), A); TotalCycles += 6; PC = 0xF92C;
                    goto case 0xF92C;
                case 0xF92B:
                    WriteIoReg(0x6969, A); TotalCycles += 4; PC = 0xF92E;
                    return;
                case 0xF92C:
                    Adc(0x69); TotalCycles += 2; PC = 0xF92E;
                    return;
                case 0xF92D:
                    Adc(0x93); TotalCycles += 2; PC = 0xF92F;
                    goto case 0xF92F;
                case 0xF92F:
                    WriteMem(0x9F93 + Y, A); TotalCycles += 5; PC = 0xF932;
                    return;
                case 0xF933:
                    WriteMem(0x9F93 + Y, A); TotalCycles += 5; PC = 0xF936;
                    goto case 0xF936;
                case 0xF936:
                    WriteMem(ReadU16Zp((byte)(0x87 + X)), A); TotalCycles += 6; PC = 0xF938;
                    goto case 0xF938;
                case 0xF938:
                    WriteMem(ReadU16Zp((byte)(0x8D + X)), A); TotalCycles += 6; PC = 0xF93A;
                    return;
                case 0xF939:
                    WriteIoReg(0x9993, A); TotalCycles += 4; PC = 0xF93C;
                    return;
                case 0xF93B:
                    WriteMem(0x9F93 + Y, A); TotalCycles += 5; PC = 0xF93E;
                    goto case 0xF93E;
                case 0xF93E:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF93F;
                    return;
                case 0xF942:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF943;
                    goto case 0xF943;
                case 0xF943:
                    TotalCycles += 6; PushU16(0xF945); PC = 0xF9B8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xF9B8;
                case 0xF944:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xF945;
                    goto case 0xF945;
                case 0xF945:
                    Sbc(ReadMem(0x1A2E + Y)); TotalCycles += 4; PC = 0xF948;
                    goto case 0xF948;
                case 0xF946:
                    { int a = 0x401A; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xF949;
                    goto case 0xF949;
                case 0xF948:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xF949:
                    TotalCycles += 6; PushU16(0xF94B); PC = 0xFCB0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF94A:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xF948; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF948; }
                    PC = 0xF94C; goto case 0xF94C;
                case 0xF94C:
                    A &= ReadMem(0x2021 + X); SetZN(A); TotalCycles += 4; PC = 0xF94F;
                    goto case 0xF94F;
                case 0xF94D:
                    A &= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xF94F;
                    goto case 0xF94F;
                case 0xF94E:
                    TotalCycles += 6; PushU16(0xF950); PC = 0xFCC4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF94F:
                    Cmp(Y, _ram[0xFC]); TotalCycles += 3; PC = 0xF951;
                    return;
                case 0xF952:
                    A |= ReadMem(0x1118 + X); SetZN(A); TotalCycles += 4; PC = 0xF955;
                    goto case 0xF955;
                case 0xF953:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF954;
                    goto case 0xF954;
                case 0xF954:
                    A |= ReadMem(ReadU16Zp(0xFD) + Y); SetZN(A); TotalCycles += 5; PC = 0xF956;
                    goto case 0xF956;
                case 0xF955:
                    Sbc(_ram[(0x0000 + X) & 0x07FF]); TotalCycles += 4; PC = 0xF958;
                    goto case 0xF958;
                case 0xF956:
                    TotalCycles += 7; PushU16(0xF958); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF957:
                    TotalCycles += 7; PushU16(0xF959); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF958:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF959;
                    return;
                case 0xF95B:
                    TotalCycles += 7; PushU16(0xF95D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF95C:
                    TotalCycles += 7; PushU16(0xF95E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF95D:
                    Y = _ram[0xFB]; SetZN(Y); TotalCycles += 3; PC = 0xF95F;
                    return;
                case 0xF961:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF92B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF92B; }
                    PC = 0xF963; goto case 0xF963;
                case 0xF962:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xF963;
                    goto case 0xF963;
                case 0xF963:
                    { int a = 0x1424 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF966;
                    goto case 0xF966;
                case 0xF964:
                    Bit(_ram[0x14]); TotalCycles += 3; PC = 0xF966;
                    goto case 0xF966;
                case 0xF966:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF967;
                    goto case 0xF967;
                case 0xF967:
                    A ^= _ram[0xFC]; SetZN(A); TotalCycles += 3; PC = 0xF969;
                    goto case 0xF969;
                case 0xF969:
                    { int a = 0x0814 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xF96C;
                    return;
                case 0xF96B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF96C;
                    return;
                case 0xF96D:
                    Sbc(ReadMem(0x70A0 + X)); TotalCycles += 4; PC = 0xF970;
                    goto case 0xF970;
                case 0xF96E:
                    Y = 0x70; SetZN(Y); TotalCycles += 2; PC = 0xF970;
                    goto case 0xF970;
                case 0xF96F:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xF9D9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF971; goto case 0xF971;
                case 0xF970:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xF971;
                    goto case 0xF971;
                case 0xF971:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xF972;
                    goto case 0xF972;
                case 0xF972:
                    A ^= ReadMem(ReadU16Zp(0xFE) + Y); SetZN(A); TotalCycles += 5; PC = 0xF974;
                    goto case 0xF974;
                case 0xF973:
                    { int a = 0x244C + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xF976;
                    goto case 0xF976;
                case 0xF974:
                    TotalCycles += 3; PC = 0x1824;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF975:
                    Bit(_ram[0x18]); TotalCycles += 3; PC = 0xF977;
                    goto case 0xF977;
                case 0xF976:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF977;
                    goto case 0xF977;
                case 0xF977:
                    A |= ReadMem(ReadU16Zp((byte)(0xFA + X))); SetZN(A); TotalCycles += 6; PC = 0xF979;
                    goto case 0xF979;
                case 0xF979:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x381C]; SetZN(A); TotalCycles += 4; PC = 0xF97C;
                    goto case 0xF97C;
                case 0xF97B:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xF97C;
                    goto case 0xF97C;
                case 0xF97C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF97D;
                    goto case 0xF97D;
                case 0xF97D:
                    A ^= 0xFA; SetZN(A); TotalCycles += 2; PC = 0xF97F;
                    goto case 0xF97F;
                case 0xF97F:
                    TotalCycles += 6; PushU16(0xF981); PC = 0x7012;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xF981:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xF99B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF99B; }
                    PC = 0xF983; goto case 0xF983;
                case 0xF982:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF983;
                    goto case 0xF983;
                case 0xF983:
                    Adc(_ram[(byte)(0xFA + X)]); TotalCycles += 4; PC = 0xF985;
                    return;
                case 0xF986:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF9CC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF9CC; }
                    PC = 0xF988; goto case 0xF988;
                case 0xF988:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF989;
                    goto case 0xF989;
                case 0xF989:
                    WriteMem(0x11FA + X, A); TotalCycles += 5; PC = 0xF98C;
                    goto case 0xF98C;
                case 0xF98B:
                    A |= ReadMem(ReadU16Zp(0x0A) + Y); SetZN(A); TotalCycles += 5; PC = 0xF98D;
                    return;
                case 0xF98C:
                    A = Asl(A); TotalCycles += 2; PC = 0xF98D;
                    return;
                case 0xF98E:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF98F;
                    return;
                case 0xF991:
                    A &= ReadIoReg(0x5810); SetZN(A); TotalCycles += 4; PC = 0xF994;
                    goto case 0xF994;
                case 0xF992:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xF9EC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF994; goto case 0xF994;
                case 0xF993:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xF994;
                    goto case 0xF994;
                case 0xF994:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF995;
                    return;
                case 0xF998:
                    A |= _ram[0x003F]; SetZN(A); TotalCycles += 4; PC = 0xF99B;
                    goto case 0xF99B;
                case 0xF99A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF99B;
                    goto case 0xF99B;
                case 0xF99B:
                    Sbc(ReadMem(0x15FA + Y)); TotalCycles += 4; PC = 0xF99E;
                    goto case 0xF99E;
                case 0xF99D:
                    A |= _ram[(byte)(0x0D + X)]; SetZN(A); TotalCycles += 4; PC = 0xF99F;
                    goto case 0xF99F;
                case 0xF99E:
                    A |= _ram[0x0021]; SetZN(A); TotalCycles += 4; PC = 0xF9A1;
                    goto case 0xF9A1;
                case 0xF99F:
                    A &= ReadMem(ReadU16Zp((byte)(0x18 + X))); SetZN(A); TotalCycles += 6; PC = 0xF9A1;
                    goto case 0xF9A1;
                case 0xF9A0:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF9A1;
                    goto case 0xF9A1;
                case 0xF9A1:
                    A &= _ram[0xFB]; SetZN(A); TotalCycles += 3; PC = 0xF9A3;
                    goto case 0xF9A3;
                case 0xF9A3:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF9A4;
                    goto case 0xF9A4;
                case 0xF9A4:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xFA20; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFA20; }
                    PC = 0xF9A6; goto case 0xF9A6;
                case 0xF9A6:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF9A7;
                    return;
                case 0xF9A9:
                    A |= ReadMem(0x540F + Y); SetZN(A); TotalCycles += 4; PC = 0xF9AC;
                    goto case 0xF9AC;
                case 0xF9AC:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF9AD;
                    return;
                case 0xF9AF:
                    { int a = 0x2B12 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xF9B2;
                    goto case 0xF9B2;
                case 0xF9B2:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF9B3;
                    return;
                case 0xF9B5:
                    { int a = 0x2D0F + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xF9B8;
                    goto case 0xF9B8;
                case 0xF9B7:
                    A &= ReadIoReg(0x2C84); SetZN(A); TotalCycles += 4; PC = 0xF9BA;
                    goto case 0xF9BA;
                case 0xF9B8:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xF9BA;
                    goto case 0xF9BA;
                case 0xF9B9:
                    Bit(ReadIoReg(0x2C2C)); TotalCycles += 4; PC = 0xF9BC;
                    return;
                case 0xF9BA:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x022C]); TotalCycles += 4; PC = 0xF9BD;
                    return;
                case 0xF9BB:
                    Bit(_ram[0x0482]); TotalCycles += 4; PC = 0xF9BE;
                    goto case 0xF9BE;
                case 0xF9BE:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0504]); TotalCycles += 4; PC = 0xF9C1;
                    goto case 0xF9C1;
                case 0xF9C0:
                    _ram[0x2C] = A; TotalCycles += 3; PC = 0xF9C2;
                    goto case 0xF9C2;
                case 0xF9C1:
                    Bit(ReadIoReg(0x2C84)); TotalCycles += 4; PC = 0xF9C4;
                    goto case 0xF9C4;
                case 0xF9C2:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xF9C4;
                    goto case 0xF9C4;
                case 0xF9C3:
                    Bit(ReadIoReg(0x2A2C)); TotalCycles += 4; PC = 0xF9C6;
                    goto case 0xF9C6;
                case 0xF9C4:
                    Bit(ReadIoReg(0x2A2A)); TotalCycles += 4; PC = 0xF9C7;
                    goto case 0xF9C7;
                case 0xF9C5:
                    A = Rol(A); TotalCycles += 2; PC = 0xF9C6;
                    goto case 0xF9C6;
                case 0xF9C6:
                    A = Rol(A); TotalCycles += 2; PC = 0xF9C7;
                    goto case 0xF9C7;
                case 0xF9C7:
                    A = Rol(A); TotalCycles += 2; PC = 0xF9C8;
                    return;
                case 0xF9CA:
                    A = Rol(A); TotalCycles += 2; PC = 0xF9CB;
                    return;
                case 0xF9CC:
                    _ram[0x2A] = A; TotalCycles += 3; PC = 0xF9CE;
                    goto case 0xF9CE;
                case 0xF9CD:
                    A = Rol(A); TotalCycles += 2; PC = 0xF9CE;
                    goto case 0xF9CE;
                case 0xF9CE:
                    _ram[0x2A] = Y; TotalCycles += 3; PC = 0xF9D0;
                    goto case 0xF9D0;
                case 0xF9CF:
                    A = Rol(A); TotalCycles += 2; PC = 0xF9D0;
                    goto case 0xF9D0;
                case 0xF9D0:
                    A = Rol(A); TotalCycles += 2; PC = 0xF9D1;
                    goto case 0xF9D1;
                case 0xF9D1:
                    TotalCycles += 7; PushU16(0xF9D3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xF9D5:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF9D6;
                    return;
                case 0xF9D8:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF9D9;
                    return;
                case 0xF9DA:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xF9DB;
                    return;
                case 0xF9DC:
                    A |= ReadMem(0x1D1D + X); SetZN(A); TotalCycles += 4; PC = 0xF9DF;
                    goto case 0xF9DF;
                case 0xF9DD:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x141D + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF9E0;
                    goto case 0xF9E0;
                case 0xF9DE:
                    A |= ReadMem(0x1D94 + X); SetZN(A); TotalCycles += 4; PC = 0xF9E1;
                    goto case 0xF9E1;
                case 0xF9DF:
                    _ram[(byte)(0x1D + X)] = Y; TotalCycles += 4; PC = 0xF9E1;
                    goto case 0xF9E1;
                case 0xF9E0:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x141D + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF9E3;
                    return;
                case 0xF9E1:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x1C94 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xF9E4;
                    goto case 0xF9E4;
                case 0xF9E2:
                    _ram[(byte)(0x9C + X)] = Y; TotalCycles += 4; PC = 0xF9E4;
                    goto case 0xF9E4;
                case 0xF9E4:
                    _ram[(byte)(0x1D + X)] = Y; TotalCycles += 4; PC = 0xF9E6;
                    goto case 0xF9E6;
                case 0xF9E5:
                    A |= ReadMem(0x1886 + X); SetZN(A); TotalCycles += 4; PC = 0xF9E8;
                    goto case 0xF9E8;
                case 0xF9E6:
                    _ram[0x18] = X; TotalCycles += 3; PC = 0xF9E8;
                    goto case 0xF9E8;
                case 0xF9E7:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xF9E8;
                    goto case 0xF9E8;
                case 0xF9E8:
                    _ram[0x26] = A; TotalCycles += 3; PC = 0xF9EA;
                    goto case 0xF9EA;
                case 0xF9E9:
                    _ram[0x30] = Rol(_ram[0x30]); TotalCycles += 5; PC = 0xF9EB;
                    goto case 0xF9EB;
                case 0xF9EA:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF970; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF970; }
                    PC = 0xF9EC; return;
                case 0xF9EB:
                    _ram[0x04] = Y; TotalCycles += 3; PC = 0xF9ED;
                    goto case 0xF9ED;
                case 0xF9ED:
                    _ram[0x30] = Rol(_ram[0x30]); TotalCycles += 5; PC = 0xF9EF;
                    goto case 0xF9EF;
                case 0xF9EE:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF976; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF976; }
                    PC = 0xF9F0; return;
                case 0xF9EF:
                    _ram[0x14] = X; TotalCycles += 3; PC = 0xF9F1;
                    goto case 0xF9F1;
                case 0xF9F1:
                    _ram[0x22] = A; TotalCycles += 3; PC = 0xF9F3;
                    goto case 0xF9F3;
                case 0xF9F3:
                    Bit(_ram[0x0484]); TotalCycles += 4; PC = 0xF9F6;
                    return;
                case 0xF9F4:
                    _ram[0x04] = Y; TotalCycles += 3; PC = 0xF9F6;
                    return;
                case 0xF9F7:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x5021]); TotalCycles += 4; PC = 0xF9FA;
                    goto case 0xF9FA;
                case 0xF9F8:
                    A &= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0xF9FA;
                    goto case 0xF9FA;
                case 0xF9F9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF9BF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xF9FB; goto case 0xF9FB;
                case 0xF9FA:
                    Cmp(Y, _ram[0xD0]); TotalCycles += 3; PC = 0xF9FC;
                    goto case 0xF9FC;
                case 0xF9FB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xFA2E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFA2E; }
                    PC = 0xF9FD; goto case 0xF9FD;
                case 0xF9FC:
                    A &= ReadMem(ReadU16Zp(0xD0) + Y); SetZN(A); TotalCycles += 5; PC = 0xF9FE;
                    goto case 0xF9FE;
                case 0xF9FD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xF9C3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF9C3; }
                    PC = 0xF9FF; goto case 0xF9FF;
                case 0xF9FE:
                    Cmp(Y, _ram[0xD0]); TotalCycles += 3; PC = 0xFA00;
                    goto case 0xFA00;
                case 0xF9FF:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xFA01; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFA01; }
                    PC = 0xFA01; goto case 0xFA01;
                case 0xFA00:
                    TotalCycles += 7; PushU16(0xFA02); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFA01:
                    _ram[0x2C] = A; TotalCycles += 3; PC = 0xFA03;
                    return;
                case 0xFA02:
                    Bit(_ram[0x0422]); TotalCycles += 4; PC = 0xFA05;
                    goto case 0xFA05;
                case 0xFA05:
                    _ram[0x26] = Y; TotalCycles += 3; PC = 0xFA07;
                    goto case 0xFA07;
                case 0xFA06:
                    _ram[0x2A] = Rol(_ram[0x2A]); TotalCycles += 5; PC = 0xFA08;
                    return;
                case 0xFA07:
                    A = Rol(A); TotalCycles += 2; PC = 0xFA08;
                    return;
                case 0xFA09:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFA0A;
                    goto case 0xFA0A;
                case 0xFA0A:
                    _ram[0x04] = Rol(_ram[0x04]); TotalCycles += 5; PC = 0xFA0C;
                    return;
                case 0xFA11:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xFA13:
                    { byte z = (byte)(0x84 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFA15;
                    return;
                case 0xFA14:
                    _ram[0x3A] = Y; TotalCycles += 3; PC = 0xFA16;
                    return;
                case 0xFA18:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0530]); TotalCycles += 4; PC = 0xFA1B;
                    goto case 0xFA1B;
                case 0xFA19:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xF9A0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xF9A0; }
                    PC = 0xFA1B; goto case 0xFA1B;
                case 0xFA1A:
                    _ram[0x2A] = A; TotalCycles += 3; PC = 0xFA1C;
                    goto case 0xFA1C;
                case 0xFA1B:
                    A = Rol(A); TotalCycles += 2; PC = 0xFA1C;
                    goto case 0xFA1C;
                case 0xFA1C:
                    TotalCycles += 7; PushU16(0xFA1E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFA1D:
                    A ^= ReadMem(0x4D55 + X); SetZN(A); TotalCycles += 4; PC = 0xFA20;
                    goto case 0xFA20;
                case 0xFA1E:
                    A ^= _ram[(byte)(0x4D + X)]; SetZN(A); TotalCycles += 4; PC = 0xFA20;
                    goto case 0xFA20;
                case 0xFA1F:
                    A ^= _ram[0x0115]; SetZN(A); TotalCycles += 4; PC = 0xFA22;
                    goto case 0xFA22;
                case 0xFA20:
                    A |= _ram[(byte)(0x19 + X)]; SetZN(A); TotalCycles += 4; PC = 0xFA22;
                    goto case 0xFA22;
                case 0xFA21:
                    A |= ReadMem(0x1596 + Y); SetZN(A); TotalCycles += 4; PC = 0xFA24;
                    goto case 0xFA24;
                case 0xFA22:
                    _ram[(byte)(0x15 + Y)] = X; TotalCycles += 4; PC = 0xFA24;
                    goto case 0xFA24;
                case 0xFA23:
                    A |= _ram[(byte)(0xD5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xFA25;
                    return;
                case 0xFA24:
                    Cmp(A, _ram[(byte)(0xE3 + X)]); TotalCycles += 4; PC = 0xFA26;
                    return;
                case 0xFA27:
                    A &= ReadIoReg(0x2BA6); SetZN(A); TotalCycles += 4; PC = 0xFA2A;
                    return;
                case 0xFA28:
                    X = _ram[0x2B]; SetZN(X); TotalCycles += 3; PC = 0xFA2A;
                    return;
                case 0xFA2D:
                    A ^= ReadMem(0x2285 + Y); SetZN(A); TotalCycles += 4; PC = 0xFA30;
                    return;
                case 0xFA2E:
                    _ram[0x22] = A; TotalCycles += 3; PC = 0xFA30;
                    return;
                case 0xFA32:
                    _ram[0x1E] = Y; TotalCycles += 3; PC = 0xFA34;
                    return;
                case 0xFA33:
                    { int a = 0x8222 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFA36;
                    goto case 0xFA36;
                case 0xFA36:
                    TotalCycles += 6; PushU16(0xFA38); PC = 0x041E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFA37:
                    { int a = 0x8704 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFA3A;
                    return;
                case 0xFA3B:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0234]); TotalCycles += 4; PC = 0xFA3E;
                    goto case 0xFA3E;
                case 0xFA3E:
                    { byte z = (byte)(0x04 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFA40;
                    goto case 0xFA40;
                case 0xFA40:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFA76; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFA42; return;
                case 0xFA43:
                    Bit(ReadIoReg(0x2604)); TotalCycles += 4; PC = 0xFA46;
                    goto case 0xFA46;
                case 0xFA45:
                    _ram[0x2A] = Rol(_ram[0x2A]); TotalCycles += 5; PC = 0xFA47;
                    goto case 0xFA47;
                case 0xFA46:
                    A = Rol(A); TotalCycles += 2; PC = 0xFA47;
                    goto case 0xFA47;
                case 0xFA47:
                    _ram[0x22] = A; TotalCycles += 3; PC = 0xFA49;
                    goto case 0xFA49;
                case 0xFA49:
                    _ram[0x04] = Y; TotalCycles += 3; PC = 0xFA4B;
                    return;
                case 0xFA4D:
                    P |= FlagC; TotalCycles += 2; PC = 0xFA4E;
                    goto case 0xFA4E;
                case 0xFA4E:
                    { byte z = (byte)(0x32 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFA50;
                    return;
                case 0xFA53:
                    Bit(_ram[0x26]); TotalCycles += 3; PC = 0xFA55;
                    goto case 0xFA55;
                case 0xFA54:
                    _ram[0x2C] = Rol(_ram[0x2C]); TotalCycles += 5; PC = 0xFA56;
                    return;
                case 0xFA55:
                    Bit(ReadIoReg(0x2604)); TotalCycles += 4; PC = 0xFA58;
                    goto case 0xFA58;
                case 0xFA57:
                    _ram[0x2C] = Rol(_ram[0x2C]); TotalCycles += 5; PC = 0xFA59;
                    goto case 0xFA59;
                case 0xFA58:
                    Bit(_ram[0x0030]); TotalCycles += 4; PC = 0xFA5B;
                    goto case 0xFA5B;
                case 0xFA59:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFA5B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFA5B; }
                    PC = 0xFA5B; goto case 0xFA5B;
                case 0xFA5A:
                    TotalCycles += 7; PushU16(0xFA5C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFA5B:
                    A |= _ram[0xB4]; SetZN(A); TotalCycles += 3; PC = 0xFA5D;
                    return;
                case 0xFA5C:
                    Y = _ram[(byte)(0xB2 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xFA5E;
                    goto case 0xFA5E;
                case 0xFA5E:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xFA8B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFA8B; }
                    PC = 0xFA60; goto case 0xFA60;
                case 0xFA60:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x1C84]; SetZN(Y); TotalCycles += 4; PC = 0xFA63;
                    return;
                case 0xFA61:
                    _ram[0x9C] = Y; TotalCycles += 3; PC = 0xFA63;
                    return;
                case 0xFA64:
                    X = 0x84; SetZN(X); TotalCycles += 2; PC = 0xFA66;
                    goto case 0xFA66;
                case 0xFA65:
                    _ram[0x94] = Y; TotalCycles += 3; PC = 0xFA67;
                    return;
                case 0xFA66:
                    _ram[(byte)(0x9C + X)] = Y; TotalCycles += 4; PC = 0xFA68;
                    return;
                case 0xFA69:
                    _ram[0x14] = A; TotalCycles += 3; PC = 0xFA6B;
                    return;
                case 0xFA6C:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xFA6E;
                    goto case 0xFA6E;
                case 0xFA6D:
                    Bit(_ram[0x0685]); TotalCycles += 4; PC = 0xFA70;
                    return;
                case 0xFA6E:
                    _ram[0x1E] = A; TotalCycles += 3; PC = 0xFA70;
                    return;
                case 0xFA6F:
                    { int a = 0x2C82 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFA72;
                    goto case 0xFA72;
                case 0xFA71:
                    Bit(ReadIoReg(0x2C84)); TotalCycles += 4; PC = 0xFA74;
                    goto case 0xFA74;
                case 0xFA72:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xFA74;
                    goto case 0xFA74;
                case 0xFA73:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x041E]); TotalCycles += 4; PC = 0xFA76;
                    return;
                case 0xFA74:
                    { int a = (0x0484 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xFA77;
                    return;
                case 0xFA75:
                    _ram[0x04] = Y; TotalCycles += 3; PC = 0xFA77;
                    return;
                case 0xFA79:
                    P |= FlagC; TotalCycles += 2; PC = 0xFA7A;
                    goto case 0xFA7A;
                case 0xFA7A:
                    { byte z = (byte)(0x32 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFA7C;
                    return;
                case 0xFA82:
                    _ram[0x64] = X; TotalCycles += 3; PC = 0xFA84;
                    goto case 0xFA84;
                case 0xFA84:
                    TotalCycles += 7; PushU16(0xFA86); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFA85:
                    A |= _ram[0xB4]; SetZN(A); TotalCycles += 3; PC = 0xFA87;
                    return;
                case 0xFA86:
                    Y = _ram[(byte)(0xB2 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xFA88;
                    goto case 0xFA88;
                case 0xFA88:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xFAB5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFA8A; goto case 0xFA8A;
                case 0xFA8A:
                    Y = ReadIoReg(0x3784); SetZN(Y); TotalCycles += 4; PC = 0xFA8D;
                    goto case 0xFA8D;
                case 0xFA8B:
                    _ram[0x37] = Y; TotalCycles += 3; PC = 0xFA8D;
                    goto case 0xFA8D;
                case 0xFA8D:
                    X = _ram[(byte)(0xB6 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xFA8F;
                    goto case 0xFA8F;
                case 0xFA8E:
                    X = _ram[(byte)(0x45 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xFA90;
                    goto case 0xFA90;
                case 0xFA8F:
                    A ^= _ram[0x85]; SetZN(A); TotalCycles += 3; PC = 0xFA91;
                    return;
                case 0xFA90:
                    _ram[0x14] = A; TotalCycles += 3; PC = 0xFA92;
                    return;
                case 0xFA95:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xFA97;
                    goto case 0xFA97;
                case 0xFA96:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x024E]); TotalCycles += 4; PC = 0xFA99;
                    goto case 0xFA99;
                case 0xFA97:
                    { int a = 0x4E82; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xFA9A;
                    goto case 0xFA9A;
                case 0xFA99:
                    { int a = 0x4E84; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xFA9C;
                    return;
                case 0xFA9A:
                    _ram[0x4E] = Y; TotalCycles += 3; PC = 0xFA9C;
                    return;
                case 0xFA9B:
                    { int a = 0x8422; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xFA9E;
                    return;
                case 0xFA9D:
                    _ram[0x04] = Y; TotalCycles += 3; PC = 0xFA9F;
                    goto case 0xFA9F;
                case 0xFA9F:
                    _ram[0x32] = A; TotalCycles += 3; PC = 0xFAA1;
                    goto case 0xFAA1;
                case 0xFAA1:
                    _ram[0x30] = A; TotalCycles += 3; PC = 0xFAA3;
                    goto case 0xFAA3;
                case 0xFAA2:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFA2A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFAA4; goto case 0xFAA4;
                case 0xFAA3:
                    _ram[0x2C] = X; TotalCycles += 3; PC = 0xFAA5;
                    return;
                case 0xFAA4:
                    Bit(_ram[0x0004]); TotalCycles += 4; PC = 0xFAA7;
                    goto case 0xFAA7;
                case 0xFAA6:
                    TotalCycles += 7; PushU16(0xFAA8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFAA7:
                    A |= _ram[0xA4]; SetZN(A); TotalCycles += 3; PC = 0xFAA9;
                    goto case 0xFAA9;
                case 0xFAA8:
                    Y = _ram[0x05]; SetZN(Y); TotalCycles += 3; PC = 0xFAAA;
                    return;
                case 0xFAA9:
                    A |= _ram[0x9E]; SetZN(A); TotalCycles += 3; PC = 0xFAAB;
                    goto case 0xFAAB;
                case 0xFAAB:
                    A |= _ram[0x9D]; SetZN(A); TotalCycles += 3; PC = 0xFAAD;
                    goto case 0xFAAD;
                case 0xFAAC:
                    WriteMem(0x8485 + X, A); TotalCycles += 5; PC = 0xFAAF;
                    return;
                case 0xFAAD:
                    _ram[0x84] = A; TotalCycles += 3; PC = 0xFAAF;
                    return;
                case 0xFAAE:
                    _ram[0x14] = Y; TotalCycles += 3; PC = 0xFAB0;
                    goto case 0xFAB0;
                case 0xFAB0:
                    _ram[0x24] = A; TotalCycles += 3; PC = 0xFAB2;
                    goto case 0xFAB2;
                case 0xFAB1:
                    Bit(_ram[0x28]); TotalCycles += 3; PC = 0xFAB3;
                    goto case 0xFAB3;
                case 0xFAB2:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFAB3;
                    goto case 0xFAB3;
                case 0xFAB3:
                    Bit(ReadIoReg(0x2282)); TotalCycles += 4; PC = 0xFAB6;
                    goto case 0xFAB6;
                case 0xFAB6:
                    _ram[0x22] = Y; TotalCycles += 3; PC = 0xFAB8;
                    return;
                case 0xFAB9:
                    A &= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0xFABB;
                    goto case 0xFABB;
                case 0xFABA:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xFA80; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFABC; goto case 0xFABC;
                case 0xFABB:
                    Cmp(Y, _ram[0xD0]); TotalCycles += 3; PC = 0xFABD;
                    goto case 0xFABD;
                case 0xFABC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xFAEF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFAEF; }
                    PC = 0xFABE; goto case 0xFABE;
                case 0xFABD:
                    A &= ReadMem(ReadU16Zp(0xD0) + Y); SetZN(A); TotalCycles += 5; PC = 0xFABF;
                    goto case 0xFABF;
                case 0xFABE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xFA84; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFA84; }
                    PC = 0xFAC0; goto case 0xFAC0;
                case 0xFABF:
                    Cmp(Y, _ram[0xD0]); TotalCycles += 3; PC = 0xFAC1;
                    goto case 0xFAC1;
                case 0xFAC0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xFAC2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFAC2; return;
                case 0xFAC1:
                    TotalCycles += 7; PushU16(0xFAC3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFAC3:
                    Bit(ReadIoReg(0x2C84)); TotalCycles += 4; PC = 0xFAC6;
                    goto case 0xFAC6;
                case 0xFAC4:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xFAC6;
                    goto case 0xFAC6;
                case 0xFAC5:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x022C]); TotalCycles += 4; PC = 0xFAC8;
                    goto case 0xFAC8;
                case 0xFAC6:
                    Bit(ReadIoReg(0x2C82)); TotalCycles += 4; PC = 0xFAC9;
                    goto case 0xFAC9;
                case 0xFAC8:
                    Bit(_ram[0x0430]); TotalCycles += 4; PC = 0xFACB;
                    return;
                case 0xFAC9:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFACF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFACF; }
                    PC = 0xFACB; return;
                case 0xFACC:
                    Bit(ReadIoReg(0x2604)); TotalCycles += 4; PC = 0xFACF;
                    goto case 0xFACF;
                case 0xFACE:
                    _ram[0x86] = Rol(_ram[0x86]); TotalCycles += 5; PC = 0xFAD0;
                    return;
                case 0xFACF:
                    _ram[0x22] = X; TotalCycles += 3; PC = 0xFAD1;
                    goto case 0xFAD1;
                case 0xFAD1:
                    TotalCycles += 7; PushU16(0xFAD3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFAD2:
                    Y = _ram[0x25]; SetZN(Y); TotalCycles += 3; PC = 0xFAD4;
                    goto case 0xFAD4;
                case 0xFAD3:
                    A &= _ram[0x25]; SetZN(A); TotalCycles += 3; PC = 0xFAD5;
                    goto case 0xFAD5;
                case 0xFAD4:
                    A &= _ram[0xA4]; SetZN(A); TotalCycles += 3; PC = 0xFAD6;
                    goto case 0xFAD6;
                case 0xFAD5:
                    Y = _ram[0x29]; SetZN(Y); TotalCycles += 3; PC = 0xFAD7;
                    goto case 0xFAD7;
                case 0xFAD6:
                    A &= 0xA2; SetZN(A); TotalCycles += 2; PC = 0xFAD8;
                    goto case 0xFAD8;
                case 0xFAD7:
                    X = 0x1D; SetZN(X); TotalCycles += 2; PC = 0xFAD9;
                    return;
                case 0xFAD8:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x159C + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xFADB;
                    return;
                case 0xFADA:
                    _ram[(byte)(0x82 + X)] = A; TotalCycles += 4; PC = 0xFADC;
                    goto case 0xFADC;
                case 0xFADC:
                    Bit(_ram[0x042C]); TotalCycles += 4; PC = 0xFADF;
                    goto case 0xFADF;
                case 0xFADD:
                    Bit(ReadIoReg(0x2C04)); TotalCycles += 4; PC = 0xFAE0;
                    return;
                case 0xFADF:
                    Bit(ReadIoReg(0x2C04)); TotalCycles += 4; PC = 0xFAE2;
                    goto case 0xFAE2;
                case 0xFAE1:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0530]); TotalCycles += 4; PC = 0xFAE4;
                    return;
                case 0xFAE2:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFA69; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFA69; }
                    PC = 0xFAE4; return;
                case 0xFAE3:
                    _ram[0x34] = A; TotalCycles += 3; PC = 0xFAE5;
                    return;
                case 0xFAE7:
                    TotalCycles += 7; PushU16(0xFAE9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFAE8:
                    Y = _ram[0x25]; SetZN(Y); TotalCycles += 3; PC = 0xFAEA;
                    goto case 0xFAEA;
                case 0xFAE9:
                    A &= _ram[0x25]; SetZN(A); TotalCycles += 3; PC = 0xFAEB;
                    goto case 0xFAEB;
                case 0xFAEA:
                    A &= _ram[0xA4]; SetZN(A); TotalCycles += 3; PC = 0xFAEC;
                    goto case 0xFAEC;
                case 0xFAEB:
                    Y = _ram[0xA8]; SetZN(Y); TotalCycles += 3; PC = 0xFAED;
                    return;
                case 0xFAEC:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xFAED;
                    return;
                case 0xFAEF:
                    _ram[0x0E] = A; TotalCycles += 3; PC = 0xFAF1;
                    return;
                case 0xFAF0:
                    { int a = 0x841A; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xFAF3;
                    goto case 0xFAF3;
                case 0xFAF2:
                    _ram[0x24] = Y; TotalCycles += 3; PC = 0xFAF4;
                    goto case 0xFAF4;
                case 0xFAF3:
                    Bit(_ram[0x85]); TotalCycles += 3; PC = 0xFAF5;
                    return;
                case 0xFAF4:
                    _ram[0x22] = A; TotalCycles += 3; PC = 0xFAF6;
                    return;
                case 0xFAF7:
                    _ram[0x0C] = Y; TotalCycles += 3; PC = 0xFAF9;
                    return;
                case 0xFAFB:
                    _ram[0x34] = Y; TotalCycles += 3; PC = 0xFAFD;
                    return;
                case 0xFAFF:
                    Bit(ReadIoReg(0x3484)); TotalCycles += 4; PC = 0xFB02;
                    goto case 0xFB02;
                case 0xFB00:
                    _ram[0x34] = Y; TotalCycles += 3; PC = 0xFB02;
                    goto case 0xFB02;
                case 0xFB02:
                    _ram[0x3A] = X; TotalCycles += 3; PC = 0xFB04;
                    return;
                case 0xFB05:
                    TotalCycles += 7; PushU16(0xFB07); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFB06:
                    Y = 0x21; SetZN(Y); TotalCycles += 2; PC = 0xFB08;
                    goto case 0xFB08;
                case 0xFB07:
                    A &= ReadMem(ReadU16Zp((byte)(0x21 + X))); SetZN(A); TotalCycles += 6; PC = 0xFB09;
                    goto case 0xFB09;
                case 0xFB08:
                    A &= ReadMem(ReadU16Zp((byte)(0xA0 + X))); SetZN(A); TotalCycles += 6; PC = 0xFB0A;
                    goto case 0xFB0A;
                case 0xFB09:
                    Y = 0x21; SetZN(Y); TotalCycles += 2; PC = 0xFB0B;
                    return;
                case 0xFB0A:
                    A &= ReadMem(ReadU16Zp((byte)(0x2B + X))); SetZN(A); TotalCycles += 6; PC = 0xFB0C;
                    goto case 0xFB0C;
                case 0xFB0C:
                    A |= _ram[0xA3]; SetZN(A); TotalCycles += 3; PC = 0xFB0E;
                    return;
                case 0xFB0F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFB10;
                    goto case 0xFB10;
                case 0xFB10:
                    _ram[0x18] = Y; TotalCycles += 3; PC = 0xFB12;
                    goto case 0xFB12;
                case 0xFB11:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFB12;
                    goto case 0xFB12;
                case 0xFB12:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFB13;
                    return;
                case 0xFB14:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFB15;
                    goto case 0xFB15;
                case 0xFB15:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFB16;
                    return;
                case 0xFB17:
                    _ram[0x3A] = X; TotalCycles += 3; PC = 0xFB19;
                    return;
                case 0xFB1A:
                    A &= ReadMem(ReadU16Zp(0x90) + Y); SetZN(A); TotalCycles += 5; PC = 0xFB1C;
                    goto case 0xFB1C;
                case 0xFB1B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xFB4E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFB4E; }
                    PC = 0xFB1D; goto case 0xFB1D;
                case 0xFB1C:
                    A &= ReadMem(ReadU16Zp(0x90) + Y); SetZN(A); TotalCycles += 5; PC = 0xFB1E;
                    goto case 0xFB1E;
                case 0xFB1D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xFB50; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFB1F; goto case 0xFB1F;
                case 0xFB1E:
                    A &= ReadMem(ReadU16Zp(0x71) + Y); SetZN(A); TotalCycles += 5; PC = 0xFB20;
                    goto case 0xFB20;
                case 0xFB1F:
                    Adc(ReadMem(ReadU16Zp(0x31) + Y)); TotalCycles += 5; PC = 0xFB21;
                    goto case 0xFB21;
                case 0xFB20:
                    A &= ReadMem(ReadU16Zp(0x90) + Y); SetZN(A); TotalCycles += 5; PC = 0xFB22;
                    goto case 0xFB22;
                case 0xFB21:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xFAB3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFAB3; }
                    PC = 0xFB23; goto case 0xFB23;
                case 0xFB22:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xFAB4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFB24; goto case 0xFB24;
                case 0xFB23:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xFB25; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFB25; return;
                case 0xFB24:
                    TotalCycles += 7; PushU16(0xFB26); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFB27:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xFB29;
                    goto case 0xFB29;
                case 0xFB28:
                    Bit(ReadIoReg(0x2285)); TotalCycles += 4; PC = 0xFB2B;
                    goto case 0xFB2B;
                case 0xFB29:
                    _ram[0x22] = A; TotalCycles += 3; PC = 0xFB2B;
                    goto case 0xFB2B;
                case 0xFB2B:
                    _ram[0x24] = Y; TotalCycles += 3; PC = 0xFB2D;
                    return;
                case 0xFB2C:
                    Bit(_ram[0x82]); TotalCycles += 3; PC = 0xFB2E;
                    goto case 0xFB2E;
                case 0xFB2E:
                    _ram[0x36] = Rol(_ram[0x36]); TotalCycles += 5; PC = 0xFB30;
                    return;
                case 0xFB2F:
                    { byte z = (byte)(0x04 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFB31;
                    goto case 0xFB31;
                case 0xFB31:
                    { byte z = (byte)(0x86 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFB33;
                    goto case 0xFB33;
                case 0xFB32:
                    _ram[0x26] = X; TotalCycles += 3; PC = 0xFB34;
                    goto case 0xFB34;
                case 0xFB33:
                    _ram[0x00] = Rol(_ram[0x00]); TotalCycles += 5; PC = 0xFB35;
                    goto case 0xFB35;
                case 0xFB34:
                    TotalCycles += 7; PushU16(0xFB36); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFB35:
                    Y = ReadIoReg(0x5D27); SetZN(Y); TotalCycles += 4; PC = 0xFB38;
                    goto case 0xFB38;
                case 0xFB37:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x1E1D + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xFB3A;
                    goto case 0xFB3A;
                case 0xFB38:
                    A |= ReadMem(0x2D9E + X); SetZN(A); TotalCycles += 4; PC = 0xFB3B;
                    goto case 0xFB3B;
                case 0xFB3A:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x1FAC]; SetZN(A); TotalCycles += 4; PC = 0xFB3D;
                    goto case 0xFB3D;
                case 0xFB3B:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x059F]; SetZN(Y); TotalCycles += 4; PC = 0xFB3E;
                    return;
                case 0xFB3D:
                    _ram[0x14] = A; TotalCycles += 3; PC = 0xFB3F;
                    return;
                case 0xFB40:
                    TotalCycles += 6; PushU16(0xFB42); PC = 0x2284;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFB41:
                    _ram[0x22] = Y; TotalCycles += 3; PC = 0xFB43;
                    goto case 0xFB43;
                case 0xFB43:
                    Bit(_ram[0x061E]); TotalCycles += 4; PC = 0xFB46;
                    return;
                case 0xFB44:
                    { int a = 0x821E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFB47;
                    goto case 0xFB47;
                case 0xFB45:
                    { int a = 0x2C82 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFB48;
                    goto case 0xFB48;
                case 0xFB47:
                    Bit(_ram[0x062C]); TotalCycles += 4; PC = 0xFB4A;
                    return;
                case 0xFB48:
                    Bit(_ram[0x041E]); TotalCycles += 4; PC = 0xFB4B;
                    return;
                case 0xFB49:
                    { int a = 0x8704 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFB4C;
                    goto case 0xFB4C;
                case 0xFB4C:
                    A = Rol(A); TotalCycles += 2; PC = 0xFB4D;
                    goto case 0xFB4D;
                case 0xFB4D:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xFB4E:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xFB4F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xFB51:
                    { byte z = (byte)(0x82 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFB53;
                    return;
                case 0xFB54:
                    Bit(ReadIoReg(0x2604)); TotalCycles += 4; PC = 0xFB57;
                    goto case 0xFB57;
                case 0xFB56:
                    _ram[0x86] = Rol(_ram[0x86]); TotalCycles += 5; PC = 0xFB58;
                    return;
                case 0xFB57:
                    _ram[0x22] = X; TotalCycles += 3; PC = 0xFB59;
                    goto case 0xFB59;
                case 0xFB59:
                    TotalCycles += 7; PushU16(0xFB5B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFB5E:
                    Sbc(_ram[(byte)(0xF1 + X)]); TotalCycles += 4; PC = 0xFB60;
                    goto case 0xFB60;
                case 0xFB5F:
                    Sbc(ReadMem(ReadU16Zp(0xAC) + Y)); TotalCycles += 5; PC = 0xFB61;
                    return;
                case 0xFB60:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x1E27]; SetZN(Y); TotalCycles += 4; PC = 0xFB63;
                    goto case 0xFB63;
                case 0xFB63:
                    WriteMem(0x1885 + X, A); TotalCycles += 5; PC = 0xFB66;
                    return;
                case 0xFB64:
                    _ram[0x18] = A; TotalCycles += 3; PC = 0xFB66;
                    return;
                case 0xFB65:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFB66;
                    return;
                case 0xFB67:
                    { int a = 0x2284 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFB6A;
                    goto case 0xFB6A;
                case 0xFB68:
                    _ram[0x22] = Y; TotalCycles += 3; PC = 0xFB6A;
                    goto case 0xFB6A;
                case 0xFB6A:
                    A = Rol(A); TotalCycles += 2; PC = 0xFB6B;
                    return;
                case 0xFB6E:
                    Bit(ReadIoReg(0x222C)); TotalCycles += 4; PC = 0xFB71;
                    return;
                case 0xFB6F:
                    Bit(_ram[0x0422]); TotalCycles += 4; PC = 0xFB72;
                    goto case 0xFB72;
                case 0xFB72:
                    _ram[0x04] = X; TotalCycles += 3; PC = 0xFB74;
                    return;
                case 0xFB75:
                    A = Rol(A); TotalCycles += 2; PC = 0xFB76;
                    goto case 0xFB76;
                case 0xFB76:
                    { byte z = (byte)(0x04 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFB78;
                    goto case 0xFB78;
                case 0xFB78:
                    { byte z = (byte)(0x87 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFB7A;
                    goto case 0xFB7A;
                case 0xFB7A:
                    { byte z = (byte)(0x34 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFB7C;
                    goto case 0xFB7C;
                case 0xFB7C:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFB04; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFB7E; goto case 0xFB7E;
                case 0xFB7D:
                    _ram[0x2C] = X; TotalCycles += 3; PC = 0xFB7F;
                    return;
                case 0xFB7E:
                    Bit(_ram[0x0004]); TotalCycles += 4; PC = 0xFB81;
                    goto case 0xFB81;
                case 0xFB80:
                    TotalCycles += 7; PushU16(0xFB82); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFB81:
                    TotalCycles += 7; PushU16(0xFB83); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFB82:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xFB83;
                    goto case 0xFB83;
                case 0xFB83:
                    A = Ror(A); TotalCycles += 2; PC = 0xFB84;
                    goto case 0xFB84;
                case 0xFB84:
                    TotalCycles += 5; PC = ReadU16Zp(0x45); return;
                case 0xFB85:
                    A ^= _ram[0xA2]; SetZN(A); TotalCycles += 3; PC = 0xFB87;
                    goto case 0xFB87;
                case 0xFB86:
                    X = 0x31; SetZN(X); TotalCycles += 2; PC = 0xFB88;
                    goto case 0xFB88;
                case 0xFB87:
                    A &= ReadMem(ReadU16Zp(0xB0) + Y); SetZN(A); TotalCycles += 5; PC = 0xFB89;
                    goto case 0xFB89;
                case 0xFB88:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xFB7B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFB8A; goto case 0xFB8A;
                case 0xFB89:
                    Sbc(ReadMem(ReadU16Zp(0xED) + Y)); TotalCycles += 5; PC = 0xFB8B;
                    return;
                case 0xFB8A:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x22EB]); TotalCycles += 4; PC = 0xFB8D;
                    goto case 0xFB8D;
                case 0xFB8C:
                    X = 0x1D; SetZN(X); TotalCycles += 2; PC = 0xFB8E;
                    return;
                case 0xFB8D:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x159C + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xFB90;
                    goto case 0xFB90;
                case 0xFB8F:
                    _ram[(byte)(0x86 + X)] = A; TotalCycles += 4; PC = 0xFB91;
                    return;
                case 0xFB90:
                    _ram[0x04] = X; TotalCycles += 3; PC = 0xFB92;
                    goto case 0xFB92;
                case 0xFB92:
                    _ram[0x22] = A; TotalCycles += 3; PC = 0xFB94;
                    return;
                case 0xFB98:
                    _ram[0x2A] = Rol(_ram[0x2A]); TotalCycles += 5; PC = 0xFB9A;
                    goto case 0xFB9A;
                case 0xFB99:
                    A = Rol(A); TotalCycles += 2; PC = 0xFB9A;
                    goto case 0xFB9A;
                case 0xFB9A:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xFB9C;
                    return;
                case 0xFB9B:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0622]); TotalCycles += 4; PC = 0xFB9E;
                    return;
                case 0xFB9D:
                    _ram[0x14] = X; TotalCycles += 3; PC = 0xFB9F;
                    goto case 0xFB9F;
                case 0xFB9F:
                    A ^= ReadMem(ReadU16Zp(0x90) + Y); SetZN(A); TotalCycles += 5; PC = 0xFBA1;
                    goto case 0xFBA1;
                case 0xFBA0:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xFBD3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFBD3; }
                    PC = 0xFBA2; goto case 0xFBA2;
                case 0xFBA1:
                    A &= ReadMem(ReadU16Zp(0x11) + Y); SetZN(A); TotalCycles += 5; PC = 0xFBA3;
                    goto case 0xFBA3;
                case 0xFBA2:
                    A |= ReadMem(ReadU16Zp(0x00) + Y); SetZN(A); TotalCycles += 5; PC = 0xFBA4;
                    return;
                case 0xFBA3:
                    TotalCycles += 7; PushU16(0xFBA5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFBA6:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBA7;
                    return;
                case 0xFBA8:
                    _ram[0x22] = Rol(_ram[0x22]); TotalCycles += 5; PC = 0xFBAA;
                    goto case 0xFBAA;
                case 0xFBAA:
                    Bit(_ram[0x22]); TotalCycles += 3; PC = 0xFBAC;
                    goto case 0xFBAC;
                case 0xFBAC:
                    _ram[0x22] = Rol(_ram[0x22]); TotalCycles += 5; PC = 0xFBAE;
                    goto case 0xFBAE;
                case 0xFBAE:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBAF;
                    return;
                case 0xFBB0:
                    A = Rol(A); TotalCycles += 2; PC = 0xFBB1;
                    return;
                case 0xFBB2:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBB3;
                    return;
                case 0xFBB4:
                    _ram[0x22] = Rol(_ram[0x22]); TotalCycles += 5; PC = 0xFBB6;
                    goto case 0xFBB6;
                case 0xFBB6:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBB7;
                    return;
                case 0xFBB8:
                    _ram[0x22] = Rol(_ram[0x22]); TotalCycles += 5; PC = 0xFBBA;
                    goto case 0xFBBA;
                case 0xFBBA:
                    Bit(_ram[0x22]); TotalCycles += 3; PC = 0xFBBC;
                    goto case 0xFBBC;
                case 0xFBBC:
                    _ram[0x22] = Rol(_ram[0x22]); TotalCycles += 5; PC = 0xFBBE;
                    goto case 0xFBBE;
                case 0xFBBE:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBBF;
                    return;
                case 0xFBC0:
                    A = Rol(A); TotalCycles += 2; PC = 0xFBC1;
                    return;
                case 0xFBC2:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBC3;
                    return;
                case 0xFBC4:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xFBC6;
                    goto case 0xFBC6;
                case 0xFBC5:
                    TotalCycles += 6; PushU16(0xFBC7); PC = 0x2026;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBC6:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xFBC8;
                    goto case 0xFBC8;
                case 0xFBC7:
                    TotalCycles += 6; PushU16(0xFBC9); PC = 0x2024;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBC8:
                    Bit(_ram[0x20]); TotalCycles += 3; PC = 0xFBCA;
                    goto case 0xFBCA;
                case 0xFBC9:
                    TotalCycles += 6; PushU16(0xFBCB); PC = 0x2026;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBCA:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xFBCC;
                    goto case 0xFBCC;
                case 0xFBCB:
                    TotalCycles += 6; PushU16(0xFBCD); PC = 0x2028;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBCC:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBCD;
                    goto case 0xFBCD;
                case 0xFBCD:
                    TotalCycles += 6; PushU16(0xFBCF); PC = 0x2026;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBCE:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xFBD0;
                    goto case 0xFBD0;
                case 0xFBCF:
                    TotalCycles += 6; PushU16(0xFBD1); PC = 0x2028;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBD0:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBD1;
                    goto case 0xFBD1;
                case 0xFBD1:
                    TotalCycles += 6; PushU16(0xFBD3); PC = 0x2026;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBD2:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xFBD4;
                    goto case 0xFBD4;
                case 0xFBD3:
                    TotalCycles += 6; PushU16(0xFBD5); PC = 0x2024;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBD4:
                    Bit(_ram[0x20]); TotalCycles += 3; PC = 0xFBD6;
                    goto case 0xFBD6;
                case 0xFBD5:
                    TotalCycles += 6; PushU16(0xFBD7); PC = 0x2026;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBD6:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xFBD8;
                    goto case 0xFBD8;
                case 0xFBD7:
                    TotalCycles += 6; PushU16(0xFBD9); PC = 0x2024;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBD8:
                    Bit(_ram[0x20]); TotalCycles += 3; PC = 0xFBDA;
                    goto case 0xFBDA;
                case 0xFBD9:
                    TotalCycles += 6; PushU16(0xFBDB); PC = 0x2026;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBDA:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xFBDC;
                    goto case 0xFBDC;
                case 0xFBDB:
                    TotalCycles += 6; PushU16(0xFBDD); PC = 0x2028;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBDC:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBDD;
                    goto case 0xFBDD;
                case 0xFBDD:
                    TotalCycles += 6; PushU16(0xFBDF); PC = 0x2026;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBDE:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xFBE0;
                    goto case 0xFBE0;
                case 0xFBDF:
                    TotalCycles += 6; PushU16(0xFBE1); PC = 0x2028;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBE0:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBE1;
                    goto case 0xFBE1;
                case 0xFBE1:
                    TotalCycles += 6; PushU16(0xFBE3); PC = 0x2026;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBE2:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xFBE4;
                    goto case 0xFBE4;
                case 0xFBE3:
                    TotalCycles += 6; PushU16(0xFBE5); PC = 0x2824;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFBE4:
                    Bit(_ram[0x28]); TotalCycles += 3; PC = 0xFBE6;
                    goto case 0xFBE6;
                case 0xFBE5:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBE6;
                    goto case 0xFBE6;
                case 0xFBE6:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC10; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC10; }
                    PC = 0xFBE8; return;
                case 0xFBE7:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBE8;
                    return;
                case 0xFBE9:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBEA;
                    goto case 0xFBEA;
                case 0xFBEA:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC14; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFBEC; goto case 0xFBEC;
                case 0xFBEB:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBEC;
                    goto case 0xFBEC;
                case 0xFBEC:
                    { int a = 0x3028; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xFBEF;
                    goto case 0xFBEF;
                case 0xFBED:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBEE;
                    goto case 0xFBEE;
                case 0xFBEE:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC18; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC18; }
                    PC = 0xFBF0; goto case 0xFBF0;
                case 0xFBEF:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBF0;
                    goto case 0xFBF0;
                case 0xFBF0:
                    { int a = 0x2C28; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xFBF3;
                    goto case 0xFBF3;
                case 0xFBF1:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBF2;
                    goto case 0xFBF2;
                case 0xFBF2:
                    Bit(ReadIoReg(0x2E28)); TotalCycles += 4; PC = 0xFBF5;
                    goto case 0xFBF5;
                case 0xFBF3:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBF4;
                    goto case 0xFBF4;
                case 0xFBF4:
                    { int a = 0x3028; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xFBF7;
                    goto case 0xFBF7;
                case 0xFBF5:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBF6;
                    goto case 0xFBF6;
                case 0xFBF6:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC20; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC20; }
                    PC = 0xFBF8; return;
                case 0xFBF7:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBF8;
                    return;
                case 0xFBF9:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBFA;
                    goto case 0xFBFA;
                case 0xFBFA:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC24; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC24; }
                    PC = 0xFBFC; goto case 0xFBFC;
                case 0xFBFB:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBFC;
                    goto case 0xFBFC;
                case 0xFBFC:
                    { int a = 0x3028; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xFBFF;
                    goto case 0xFBFF;
                case 0xFBFD:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFBFE;
                    goto case 0xFBFE;
                case 0xFBFE:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC28; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC28; }
                    PC = 0xFC00; goto case 0xFC00;
                case 0xFBFF:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFC00;
                    goto case 0xFC00;
                case 0xFC00:
                    { int a = 0x2C28; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xFC03;
                    goto case 0xFC03;
                case 0xFC01:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFC02;
                    goto case 0xFC02;
                case 0xFC02:
                    Bit(ReadIoReg(0x2E28)); TotalCycles += 4; PC = 0xFC05;
                    goto case 0xFC05;
                case 0xFC03:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFC04;
                    goto case 0xFC04;
                case 0xFC04:
                    _ram[0x0400] = Rol(_ram[0x0400]); TotalCycles += 6; PC = 0xFC07;
                    goto case 0xFC07;
                case 0xFC05:
                    TotalCycles += 7; PushU16(0xFC07); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFC07:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC77; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC77; }
                    PC = 0xFC09; goto case 0xFC09;
                case 0xFC08:
                    { int a = 0x6E6C; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC0B;
                    goto case 0xFC0B;
                case 0xFC09:
                    TotalCycles += 5; PC = ReadU16Zp(0x6E); return;
                case 0xFC0A:
                    { int a = 0x7270; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC0D;
                    goto case 0xFC0D;
                case 0xFC0B:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC7F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC7F; }
                    PC = 0xFC0D; goto case 0xFC0D;
                case 0xFC0D:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC7D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFC0F; goto case 0xFC0F;
                case 0xFC0E:
                    { int a = 0x6E70; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC11;
                    goto case 0xFC11;
                case 0xFC0F:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC7F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC7F; }
                    PC = 0xFC11; goto case 0xFC11;
                case 0xFC10:
                    { int a = 0x6E6C; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC13;
                    goto case 0xFC13;
                case 0xFC11:
                    TotalCycles += 5; PC = ReadU16Zp(0x6E); return;
                case 0xFC12:
                    { int a = 0x7270; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC15;
                    goto case 0xFC15;
                case 0xFC13:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC87; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC87; }
                    PC = 0xFC15; goto case 0xFC15;
                case 0xFC15:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC85; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC85; }
                    PC = 0xFC17; goto case 0xFC17;
                case 0xFC16:
                    { int a = 0x6C6E; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC19;
                    goto case 0xFC19;
                case 0xFC17:
                    { int a = 0x6E6C; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC1A;
                    goto case 0xFC1A;
                case 0xFC18:
                    TotalCycles += 5; PC = ReadU16Zp(0x6E); return;
                case 0xFC19:
                    { int a = 0x6E70; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC1C;
                    goto case 0xFC1C;
                case 0xFC1A:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC8A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC8A; }
                    PC = 0xFC1C; goto case 0xFC1C;
                case 0xFC1B:
                    { int a = 0x6E70; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC1E;
                    goto case 0xFC1E;
                case 0xFC1C:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC8C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFC1E; goto case 0xFC1E;
                case 0xFC1D:
                    { int a = 0x6E6C; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC20;
                    goto case 0xFC20;
                case 0xFC1E:
                    TotalCycles += 5; PC = ReadU16Zp(0x6E); return;
                case 0xFC1F:
                    { int a = 0x6E6C; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC22;
                    goto case 0xFC22;
                case 0xFC20:
                    TotalCycles += 5; PC = ReadU16Zp(0x6E); return;
                case 0xFC21:
                    { int a = 0x6E70; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC24;
                    goto case 0xFC24;
                case 0xFC22:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC92; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC92; }
                    PC = 0xFC24; goto case 0xFC24;
                case 0xFC23:
                    { int a = 0x6E70; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC26;
                    goto case 0xFC26;
                case 0xFC24:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xFC94; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC94; }
                    PC = 0xFC26; goto case 0xFC26;
                case 0xFC25:
                    { int a = 0x766C; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xFC28;
                    goto case 0xFC28;
                case 0xFC26:
                    TotalCycles += 5; PC = ReadU16Zp(0x76); return;
                case 0xFC27:
                    { byte z = (byte)(0x78 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xFC29;
                    goto case 0xFC29;
                case 0xFC28:
                    P |= FlagI; TotalCycles += 2; PC = 0xFC29;
                    goto case 0xFC29;
                case 0xFC29:
                    { byte z = (byte)(0x74 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xFC2B;
                    goto case 0xFC2B;
                case 0xFC2B:
                    { byte z = (byte)(0x74 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xFC2D;
                    return;
                case 0xFC2F:
                    { byte z = (byte)(0x78 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xFC31;
                    goto case 0xFC31;
                case 0xFC30:
                    P |= FlagI; TotalCycles += 2; PC = 0xFC31;
                    goto case 0xFC31;
                case 0xFC31:
                    { byte z = (byte)(0x74 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xFC33;
                    goto case 0xFC33;
                case 0xFC33:
                    { byte z = (byte)(0x74 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xFC35;
                    return;
                case 0xFC37:
                    _ram[0x1A] = Y; TotalCycles += 3; PC = 0xFC39;
                    return;
                case 0xFC3A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFC3B;
                    goto case 0xFC3B;
                case 0xFC3B:
                    TotalCycles += 6; PushU16(0xFC3D); PC = 0x1E84;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFC3C:
                    _ram[0x1E] = Y; TotalCycles += 3; PC = 0xFC3E;
                    return;
                case 0xFC3D:
                    { int a = 0x1C83 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFC40;
                    goto case 0xFC40;
                case 0xFC40:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFC41;
                    goto case 0xFC41;
                case 0xFC41:
                    _ram[0x1C] = Rol(_ram[0x1C]); TotalCycles += 5; PC = 0xFC43;
                    return;
                case 0xFC46:
                    Bit(_ram[0x0404]); TotalCycles += 4; PC = 0xFC49;
                    return;
                case 0xFC4C:
                    _ram[0x1C] = Y; TotalCycles += 3; PC = 0xFC4E;
                    return;
                case 0xFC4F:
                    _ram[0x2A] = Rol(_ram[0x2A]); TotalCycles += 5; PC = 0xFC51;
                    goto case 0xFC51;
                case 0xFC50:
                    A = Rol(A); TotalCycles += 2; PC = 0xFC51;
                    goto case 0xFC51;
                case 0xFC51:
                    _ram[0x84] = Rol(_ram[0x84]); TotalCycles += 5; PC = 0xFC53;
                    goto case 0xFC53;
                case 0xFC52:
                    _ram[0x24] = Y; TotalCycles += 3; PC = 0xFC54;
                    goto case 0xFC54;
                case 0xFC53:
                    Bit(_ram[0x28]); TotalCycles += 3; PC = 0xFC55;
                    goto case 0xFC55;
                case 0xFC54:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFC55;
                    goto case 0xFC55;
                case 0xFC55:
                    Bit(_ram[0x80]); TotalCycles += 3; PC = 0xFC57;
                    return;
                case 0xFC58:
                    TotalCycles += 7; PushU16(0xFC5A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFC5A:
                    A |= _ram[0x94]; SetZN(A); TotalCycles += 3; PC = 0xFC5C;
                    goto case 0xFC5C;
                case 0xFC5B:
                    _ram[(byte)(0x05 + X)] = Y; TotalCycles += 4; PC = 0xFC5D;
                    goto case 0xFC5D;
                case 0xFC5C:
                    A |= _ram[0x0D]; SetZN(A); TotalCycles += 3; PC = 0xFC5E;
                    return;
                case 0xFC5D:
                    A |= _ram[0x069F]; SetZN(A); TotalCycles += 4; PC = 0xFC60;
                    return;
                case 0xFC5F:
                    { int a = 0x989C + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFC62;
                    goto case 0xFC62;
                case 0xFC61:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xFC62;
                    goto case 0xFC62;
                case 0xFC62:
                    WriteMem(0x2282 + X, A); TotalCycles += 5; PC = 0xFC65;
                    return;
                case 0xFC6A:
                    _ram[0x14] = Y; TotalCycles += 3; PC = 0xFC6C;
                    goto case 0xFC6C;
                case 0xFC6C:
                    _ram[0x1E] = X; TotalCycles += 3; PC = 0xFC6E;
                    return;
                case 0xFC6D:
                    { int a = 0x1680 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFC70;
                    return;
                case 0xFC6F:
                    { byte z = (byte)(0x80 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFC71;
                    return;
                case 0xFC72:
                    WriteMem(ReadU16Zp((byte)(0x1C + X)), A); TotalCycles += 6; PC = 0xFC74;
                    goto case 0xFC74;
                case 0xFC74:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC7A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFC76; goto case 0xFC76;
                case 0xFC76:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFCA8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFC78; return;
                case 0xFC77:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC7D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFC79; goto case 0xFC79;
                case 0xFC79:
                    { int a = (0x0432 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xFC7C;
                    return;
                case 0xFC7F:
                    TotalCycles += 6; PushU16(0xFC81); PC = 0x0434;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFC85:
                    { byte z = (byte)(0x04 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFC87;
                    goto case 0xFC87;
                case 0xFC87:
                    _ram[0x36] = Y; TotalCycles += 3; PC = 0xFC89;
                    goto case 0xFC89;
                case 0xFC88: // === SUBROUTINE: Sub_FC88 ===
                    { byte z = (byte)(0x00 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFC8A;
                    goto case 0xFC8A;
                case 0xFC89:
                    TotalCycles += 7; PushU16(0xFC8B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFC8A:
                    _ram[0xA4] = Lsr(_ram[0xA4]); TotalCycles += 5; PC = 0xFC8C;
                    return;
                case 0xFC8B:
                    Y = _ram[0x64]; SetZN(Y); TotalCycles += 3; PC = 0xFC8D;
                    goto case 0xFC8D;
                case 0xFC8D:
                    Y = _ram[0x48]; SetZN(Y); TotalCycles += 3; PC = 0xFC8F;
                    goto case 0xFC8F;
                case 0xFC8E:
                    PushU8(A); TotalCycles += 3; PC = 0xFC8F;
                    goto case 0xFC8F;
                case 0xFC8F:
                    X = _ram[0x66]; SetZN(X); TotalCycles += 3; PC = 0xFC91;
                    goto case 0xFC91;
                case 0xFC90:
                    _ram[0xA6] = Ror(_ram[0xA6]); TotalCycles += 5; PC = 0xFC92;
                    goto case 0xFC92;
                case 0xFC91:
                    X = _ram[0x4A]; SetZN(X); TotalCycles += 3; PC = 0xFC93;
                    goto case 0xFC93;
                case 0xFC92:
                    A = Lsr(A); TotalCycles += 2; PC = 0xFC93;
                    goto case 0xFC93;
                case 0xFC93:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xFC94;
                    goto case 0xFC94;
                case 0xFC94:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xFC95;
                    goto case 0xFC95;
                case 0xFC95:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xFC96;
                    goto case 0xFC96;
                case 0xFC96:
                    A = Ror(A); TotalCycles += 2; PC = 0xFC97;
                    return;
                case 0xFC99:
                    WriteMem(ReadU16Zp((byte)(0x2A + X)), A); TotalCycles += 6; PC = 0xFC9B;
                    return;
                case 0xFC9A:
                    A = Rol(A); TotalCycles += 2; PC = 0xFC9B;
                    return;
                case 0xFCA0:
                    Bit(_ram[0x0464]); TotalCycles += 4; PC = 0xFCA3;
                    return;
                case 0xFCA6:
                    _ram[0x0446] = Rol(_ram[0x0446]); TotalCycles += 6; PC = 0xFCA9;
                    goto case 0xFCA9;
                case 0xFCA7:
                    _ram[0x04] = Lsr(_ram[0x04]); TotalCycles += 5; PC = 0xFCA9;
                    goto case 0xFCA9;
                case 0xFCA9:
                    _ram[0x46] = Lsr(_ram[0x46]); TotalCycles += 5; PC = 0xFCAB;
                    return;
                case 0xFCAA:
                    _ram[0x04] = Lsr(_ram[0x04]); TotalCycles += 5; PC = 0xFCAC;
                    return;
                case 0xFCAE:
                    _ram[0x22] = Y; TotalCycles += 3; PC = 0xFCB0;
                    return;
                case 0xFCB2:
                    _ram[0x0C] = Asl(_ram[0x0C]); TotalCycles += 5; PC = 0xFCB4;
                    return;
                case 0xFCB7:
                    _ram[0x2C] = X; TotalCycles += 3; PC = 0xFCB9;
                    return;
                case 0xFCB8:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0722]); TotalCycles += 4; PC = 0xFCBB;
                    return;
                case 0xFCBC:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xFCBD:
                    _ram[0x0214] = Asl(_ram[0x0214]); TotalCycles += 6; PC = 0xFCC0;
                    goto case 0xFCC0;
                case 0xFCC0:
                    Bit(_ram[0x86]); TotalCycles += 3; PC = 0xFCC2;
                    goto case 0xFCC2;
                case 0xFCC1:
                    _ram[0x2C] = X; TotalCycles += 3; PC = 0xFCC3;
                    goto case 0xFCC3;
                case 0xFCC2:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0724]); TotalCycles += 4; PC = 0xFCC5;
                    return;
                case 0xFCC3:
                    Bit(_ram[0x87]); TotalCycles += 3; PC = 0xFCC5;
                    return;
                case 0xFCC6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xFCC7;
                    goto case 0xFCC7;
                case 0xFCC7:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xFCE1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFCE1; }
                    PC = 0xFCC9; goto case 0xFCC9;
                case 0xFCC8:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFCC9;
                    goto case 0xFCC9;
                case 0xFCC9:
                    { int a = 0x8628 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFCCC;
                    goto case 0xFCCC;
                case 0xFCCA:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFCCB;
                    goto case 0xFCCB;
                case 0xFCCB:
                    _ram[0x30] = X; TotalCycles += 3; PC = 0xFCCD;
                    goto case 0xFCCD;
                case 0xFCCC:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFCFE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFCFE; }
                    PC = 0xFCCE; return;
                case 0xFCCD:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC4F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC4F; }
                    PC = 0xFCCF; return;
                case 0xFCD0:
                    TotalCycles += 7; PushU16(0xFCD2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFCD1:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x5DD5]); TotalCycles += 4; PC = 0xFCD4;
                    return;
                case 0xFCD2:
                    Cmp(A, _ram[(byte)(0xDD + X)]); TotalCycles += 4; PC = 0xFCD4;
                    return;
                case 0xFCD3:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x6DE3 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xFCD6;
                    goto case 0xFCD6;
                case 0xFCD5:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x3BF5]); TotalCycles += 4; PC = 0xFCD8;
                    goto case 0xFCD8;
                case 0xFCD6:
                    Sbc(_ram[(byte)(0xBB + X)]); TotalCycles += 4; PC = 0xFCD8;
                    goto case 0xFCD8;
                case 0xFCD8:
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xFCDA;
                    goto case 0xFCDA;
                case 0xFCDA:
                    Cmp(A, _ram[(byte)(0xDB + X)]); TotalCycles += 4; PC = 0xFCDC;
                    goto case 0xFCDC;
                case 0xFCDC:
                    Sbc(_ram[0xED]); TotalCycles += 3; PC = 0xFCDE;
                    return;
                case 0xFCDD:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x3DF3]); TotalCycles += 4; PC = 0xFCE0;
                    return;
                case 0xFCDF:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x51B3 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xFCE2;
                    goto case 0xFCE2;
                case 0xFCE1:
                    Cmp(A, ReadMem(ReadU16Zp(0xD9) + Y)); TotalCycles += 5; PC = 0xFCE3;
                    return;
                case 0xFCE2:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x69DF + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xFCE5;
                    goto case 0xFCE5;
                case 0xFCE4:
                    Sbc(0xF1); TotalCycles += 2; PC = 0xFCE6;
                    return;
                case 0xFCE5:
                    Sbc(ReadMem(ReadU16Zp(0xF7) + Y)); TotalCycles += 5; PC = 0xFCE7;
                    return;
                case 0xFCEC:
                    TotalCycles += 7; PushU16(0xFCEE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFCED:
                    _ram[0x04] = X; TotalCycles += 3; PC = 0xFCEF;
                    return;
                case 0xFCF3:
                    _ram[0x34] = X; TotalCycles += 3; PC = 0xFCF5;
                    goto case 0xFCF5;
                case 0xFCF5:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xFCF7;
                    return;
                case 0xFCF6:
                    Bit(_ram[0x0404]); TotalCycles += 4; PC = 0xFCF9;
                    return;
                case 0xFCFD:
                    Bit(_ram[0x86]); TotalCycles += 3; PC = 0xFCFF;
                    return;
                case 0xFCFE:
                    _ram[0x32] = X; TotalCycles += 3; PC = 0xFD00;
                    goto case 0xFD00;
                case 0xFD00:
                    _ram[0x2C] = Y; TotalCycles += 3; PC = 0xFD02;
                    return;
                case 0xFD01:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0604]); TotalCycles += 4; PC = 0xFD04;
                    return;
                case 0xFD03:
                    _ram[0x04] = X; TotalCycles += 3; PC = 0xFD05;
                    return;
                case 0xFD06:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFD07;
                    goto case 0xFD07;
                case 0xFD07:
                    { int a = 0x8628 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFD0A;
                    goto case 0xFD0A;
                case 0xFD08:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFD09;
                    goto case 0xFD09;
                case 0xFD09:
                    _ram[0x36] = X; TotalCycles += 3; PC = 0xFD0B;
                    return;
                case 0xFD0A:
                    { byte z = (byte)(0x87 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFD0C;
                    goto case 0xFD0C;
                case 0xFD0C:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFD3E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFD0E; goto case 0xFD0E;
                case 0xFD0D:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFD3F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFD3F; }
                    PC = 0xFD0F; return;
                case 0xFD0E:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFC90; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFC90; }
                    PC = 0xFD10; goto case 0xFD10;
                case 0xFD10:
                    Bit(_ram[0x0482]); TotalCycles += 4; PC = 0xFD13;
                    goto case 0xFD13;
                case 0xFD13:
                    Bit(ReadIoReg(0x2662)); TotalCycles += 4; PC = 0xFD16;
                    goto case 0xFD16;
                case 0xFD15:
                    _ram[0x10] = Rol(_ram[0x10]); TotalCycles += 5; PC = 0xFD17;
                    goto case 0xFD17;
                case 0xFD16:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xFD40; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFD18; return;
                case 0xFD17:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFD18;
                    return;
                case 0xFD1C:
                    Bit(ReadIoReg(0x2662)); TotalCycles += 4; PC = 0xFD1F;
                    goto case 0xFD1F;
                case 0xFD1E:
                    _ram[0x10] = Rol(_ram[0x10]); TotalCycles += 5; PC = 0xFD20;
                    goto case 0xFD20;
                case 0xFD1F:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xFD49; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFD21; return;
                case 0xFD20:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFD21;
                    return;
                case 0xFD24:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xFD25;
                    goto case 0xFD25;
                case 0xFD25:
                    { int a = 0x185E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFD28;
                    goto case 0xFD28;
                case 0xFD26:
                    { int a = 0x6018 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFD29;
                    return;
                case 0xFD27:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFD28;
                    goto case 0xFD28;
                case 0xFD28:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xFD2D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xFD2E;
                    goto case 0xFD2E;
                case 0xFD2E:
                    { int a = 0x185E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFD31;
                    goto case 0xFD31;
                case 0xFD2F:
                    { int a = 0x6018 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFD32;
                    return;
                case 0xFD30:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFD31;
                    goto case 0xFD31;
                case 0xFD31:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xFD33:
                    _ram[0x04] = X; TotalCycles += 3; PC = 0xFD35;
                    return;
                case 0xFD37:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFD38;
                    goto case 0xFD38;
                case 0xFD38:
                    { byte z = (byte)(0x84 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFD3A;
                    return;
                case 0xFD39:
                    _ram[0x14] = Y; TotalCycles += 3; PC = 0xFD3B;
                    return;
                case 0xFD3C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFD3D;
                    goto case 0xFD3D;
                case 0xFD3D:
                    _ram[0x060C] = Asl(_ram[0x060C]); TotalCycles += 6; PC = 0xFD40;
                    return;
                case 0xFD3F:
                    { byte z = (byte)(0x83 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFD41;
                    return;
                case 0xFD42:
                    TotalCycles += 6; PushU16(0xFD44); PC = 0x1C1E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFD43:
                    { int a = 0x281C + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFD46;
                    goto case 0xFD46;
                case 0xFD45:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFD46;
                    goto case 0xFD46;
                case 0xFD46:
                    _ram[0x87] = Rol(_ram[0x87]); TotalCycles += 5; PC = 0xFD48;
                    goto case 0xFD48;
                case 0xFD48:
                    Bit(_ram[0x1A]); TotalCycles += 3; PC = 0xFD4A;
                    return;
                case 0xFD4B:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xFDAF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFDAF; }
                    PC = 0xFD4D; goto case 0xFD4D;
                case 0xFD4D:
                    _ram[0x0480] = Asl(_ram[0x0480]); TotalCycles += 6; PC = 0xFD50;
                    return;
                case 0xFD51:
                    TotalCycles += 7; PushU16(0xFD53); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFD53:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFD54;
                    return;
                case 0xFD55:
                    TotalCycles += 6; PushU16(0xFD57); PC = 0x2622;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFD57:
                    _ram[0x28] = Rol(_ram[0x28]); TotalCycles += 5; PC = 0xFD59;
                    goto case 0xFD59;
                case 0xFD58:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFD59;
                    goto case 0xFD59;
                case 0xFD59:
                    WriteMem(ReadU16Zp((byte)(0x2A + X)), A); TotalCycles += 6; PC = 0xFD5B;
                    goto case 0xFD5B;
                case 0xFD5A:
                    A = Rol(A); TotalCycles += 2; PC = 0xFD5B;
                    goto case 0xFD5B;
                case 0xFD5B:
                    A = Rol(A); TotalCycles += 2; PC = 0xFD5C;
                    goto case 0xFD5C;
                case 0xFD5C:
                    A = Rol(A); TotalCycles += 2; PC = 0xFD5D;
                    return;
                case 0xFD5E:
                    A = Rol(A); TotalCycles += 2; PC = 0xFD5F;
                    return;
                case 0xFD61:
                    A = Rol(A); TotalCycles += 2; PC = 0xFD62;
                    return;
                case 0xFD64:
                    _ram[0x34] = X; TotalCycles += 3; PC = 0xFD66;
                    return;
                case 0xFD68:
                    WriteMem(ReadU16Zp((byte)(0x04 + X)), A); TotalCycles += 6; PC = 0xFD6A;
                    return;
                case 0xFD6B:
                    _ram[0x2A] = Rol(_ram[0x2A]); TotalCycles += 5; PC = 0xFD6D;
                    goto case 0xFD6D;
                case 0xFD6C:
                    A = Rol(A); TotalCycles += 2; PC = 0xFD6D;
                    goto case 0xFD6D;
                case 0xFD6D:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0630]); TotalCycles += 4; PC = 0xFD70;
                    return;
                case 0xFD6E:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFCF6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFCF6; }
                    PC = 0xFD70; return;
                case 0xFD6F:
                    _ram[0x34] = X; TotalCycles += 3; PC = 0xFD71;
                    return;
                case 0xFD74:
                    { byte z = (byte)(0x84 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFD76;
                    return;
                case 0xFD75:
                    _ram[0x34] = Y; TotalCycles += 3; PC = 0xFD77;
                    goto case 0xFD77;
                case 0xFD77:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xFD79;
                    goto case 0xFD79;
                case 0xFD79:
                    WriteMem(ReadU16Zp((byte)(0x22 + X)), A); TotalCycles += 6; PC = 0xFD7B;
                    goto case 0xFD7B;
                case 0xFD7B:
                    _ram[0x30] = X; TotalCycles += 3; PC = 0xFD7D;
                    goto case 0xFD7D;
                case 0xFD7C:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFDAC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFD7E; goto case 0xFD7E;
                case 0xFD7D:
                    { int a = 0x8130; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xFD80;
                    return;
                case 0xFD7E:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFD01; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFD01; }
                    PC = 0xFD80; return;
                case 0xFD7F:
                    WriteMem(ReadU16Zp((byte)(0x04 + X)), A); TotalCycles += 6; PC = 0xFD81;
                    return;
                case 0xFD82:
                    _ram[0x2A] = Rol(_ram[0x2A]); TotalCycles += 5; PC = 0xFD84;
                    goto case 0xFD84;
                case 0xFD83:
                    A = Rol(A); TotalCycles += 2; PC = 0xFD84;
                    goto case 0xFD84;
                case 0xFD84:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x062E]); TotalCycles += 4; PC = 0xFD87;
                    goto case 0xFD87;
                case 0xFD85:
                    { int a = 0x3086; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xFD88;
                    return;
                case 0xFD86:
                    _ram[0x30] = X; TotalCycles += 3; PC = 0xFD88;
                    return;
                case 0xFD87:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFD0C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFD0C; }
                    PC = 0xFD89; return;
                case 0xFD8B:
                    { byte z = (byte)(0x84 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFD8D;
                    return;
                case 0xFD8C:
                    _ram[0x34] = Y; TotalCycles += 3; PC = 0xFD8E;
                    goto case 0xFD8E;
                case 0xFD8E:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0xFD90;
                    goto case 0xFD90;
                case 0xFD90:
                    WriteMem(ReadU16Zp((byte)(0x22 + X)), A); TotalCycles += 6; PC = 0xFD92;
                    goto case 0xFD92;
                case 0xFD92:
                    _ram[0x3A] = X; TotalCycles += 3; PC = 0xFD94;
                    return;
                case 0xFD98:
                    WriteMem(ReadU16Zp((byte)(0x40 + X)), A); TotalCycles += 6; PC = 0xFD9A;
                    return;
                case 0xFD99:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xFD9C:
                    WriteMem(ReadU16Zp((byte)(0x3A + X)), A); TotalCycles += 6; PC = 0xFD9E;
                    goto case 0xFD9E;
                case 0xFD9E:
                    _ram[0x36] = X; TotalCycles += 3; PC = 0xFDA0;
                    goto case 0xFDA0;
                case 0xFD9F:
                    { byte z = (byte)(0x36 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFDA1;
                    goto case 0xFDA1;
                case 0xFDA0:
                    { byte z = (byte)(0x36 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFDA2;
                    return;
                case 0xFDA1:
                    { byte z = (byte)(0x82 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFDA3;
                    goto case 0xFDA3;
                case 0xFDA3:
                    { byte z = (byte)(0x81 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFDA5;
                    return;
                case 0xFDA4:
                    WriteMem(ReadU16Zp((byte)(0x3A + X)), A); TotalCycles += 6; PC = 0xFDA6;
                    return;
                case 0xFDA8:
                    WriteMem(ReadU16Zp((byte)(0x36 + X)), A); TotalCycles += 6; PC = 0xFDAA;
                    goto case 0xFDAA;
                case 0xFDA9:
                    { byte z = (byte)(0x86 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFDAB;
                    return;
                case 0xFDAA:
                    _ram[0x34] = X; TotalCycles += 3; PC = 0xFDAC;
                    return;
                case 0xFDAD:
                    _ram[0x2A] = Rol(_ram[0x2A]); TotalCycles += 5; PC = 0xFDAF;
                    goto case 0xFDAF;
                case 0xFDAE:
                    A = Rol(A); TotalCycles += 2; PC = 0xFDAF;
                    goto case 0xFDAF;
                case 0xFDAF:
                    { byte z = (byte)(0x81 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFDB1;
                    return;
                case 0xFDB0:
                    WriteMem(ReadU16Zp((byte)(0x34 + X)), A); TotalCycles += 6; PC = 0xFDB2;
                    return;
                case 0xFDB3:
                    _ram[0x34] = A; TotalCycles += 3; PC = 0xFDB5;
                    goto case 0xFDB5;
                case 0xFDB5:
                    WriteMem(ReadU16Zp((byte)(0x2A + X)), A); TotalCycles += 6; PC = 0xFDB7;
                    goto case 0xFDB7;
                case 0xFDB6:
                    A = Rol(A); TotalCycles += 2; PC = 0xFDB7;
                    goto case 0xFDB7;
                case 0xFDB7:
                    _ram[0x2C] = X; TotalCycles += 3; PC = 0xFDB9;
                    goto case 0xFDB9;
                case 0xFDB8:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0400]); TotalCycles += 4; PC = 0xFDBB;
                    goto case 0xFDBB;
                case 0xFDB9:
                    TotalCycles += 7; PushU16(0xFDBB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFDBA:
                    _ram[0x90] = Y; TotalCycles += 3; PC = 0xFDBC;
                    goto case 0xFDBC;
                case 0xFDBB:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xFD6D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFD6D; }
                    PC = 0xFDBD; goto case 0xFDBD;
                case 0xFDBC:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xFD42; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFD42; }
                    PC = 0xFDBE; goto case 0xFDBE;
                case 0xFDBD:
                    _ram[0x50] = Y; TotalCycles += 3; PC = 0xFDBF;
                    goto case 0xFDBF;
                case 0xFDBE:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xFE10; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFDC0; goto case 0xFDC0;
                case 0xFDBF:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xFD71; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFDC1; goto case 0xFDC1;
                case 0xFDC0:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xFDC2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFDC2; }
                    PC = 0xFDC2; goto case 0xFDC2;
                case 0xFDC1:
                    TotalCycles += 7; PushU16(0xFDC3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFDC2:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xFDC3;
                    goto case 0xFDC3;
                case 0xFDC3:
                    _ram[(byte)(0x94 + Y)] = X; TotalCycles += 4; PC = 0xFDC5;
                    return;
                case 0xFDC4:
                    _ram[(byte)(0x92 + X)] = Y; TotalCycles += 4; PC = 0xFDC6;
                    goto case 0xFDC6;
                case 0xFDC6:
                    _ram[(byte)(0x96 + X)] = Y; TotalCycles += 4; PC = 0xFDC8;
                    goto case 0xFDC8;
                case 0xFDC7:
                    _ram[(byte)(0x58 + Y)] = X; TotalCycles += 4; PC = 0xFDC9;
                    goto case 0xFDC9;
                case 0xFDC8:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xFDC9;
                    goto case 0xFDC9;
                case 0xFDC9:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xFDCA;
                    goto case 0xFDCA;
                case 0xFDCA:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xFDCB;
                    return;
                case 0xFDD0:
                    A = ReadMem(ReadU16Zp((byte)(0xA3 + X))); SetZN(A); TotalCycles += 6; PC = 0xFDD2;
                    goto case 0xFDD2;
                case 0xFDD2:
                    _ram[0xA3] = A; TotalCycles += 3; PC = 0xFDD4;
                    goto case 0xFDD4;
                case 0xFDD4:
                    Cmp(X, 0xA6); TotalCycles += 2; PC = 0xFDD6;
                    return;
                case 0xFDD5:
                    X = _ram[0x23]; SetZN(X); TotalCycles += 3; PC = 0xFDD7;
                    goto case 0xFDD7;
                case 0xFDD7:
                    Cmp(Y, _ram[0x9F]); TotalCycles += 3; PC = 0xFDD9;
                    goto case 0xFDD9;
                case 0xFDD9:
                    WriteMem(0x859F + X, A); TotalCycles += 5; PC = 0xFDDC;
                    return;
                case 0xFDDB:
                    _ram[0x9F] = A; TotalCycles += 3; PC = 0xFDDD;
                    return;
                case 0xFDDE:
                    X = _ram[0x23]; SetZN(X); TotalCycles += 3; PC = 0xFDE0;
                    goto case 0xFDE0;
                case 0xFDE0:
                    Cmp(Y, _ram[0xB5]); TotalCycles += 3; PC = 0xFDE2;
                    goto case 0xFDE2;
                case 0xFDE1:
                    A = _ram[(byte)(0xB1 + X)]; SetZN(A); TotalCycles += 4; PC = 0xFDE3;
                    return;
                case 0xFDE2:
                    A = ReadMem(ReadU16Zp(0xAF) + Y); SetZN(A); TotalCycles += 5; PC = 0xFDE4;
                    goto case 0xFDE4;
                case 0xFDE4:
                    _ram[0xB1] = A; TotalCycles += 3; PC = 0xFDE6;
                    return;
                case 0xFDE5:
                    A = ReadMem(ReadU16Zp(0xAF) + Y); SetZN(A); TotalCycles += 5; PC = 0xFDE7;
                    goto case 0xFDE7;
                case 0xFDE7:
                    A = SmbEmbeddedAssets.StaticDataTables[0x1585]; SetZN(A); TotalCycles += 4; PC = 0xFDEA;
                    return;
                case 0xFDE8:
                    _ram[0x95] = A; TotalCycles += 3; PC = 0xFDEA;
                    return;
                case 0xFDE9:
                    _ram[(byte)(0x9E + X)] = A; TotalCycles += 4; PC = 0xFDEB;
                    goto case 0xFDEB;
                case 0xFDEB:
                    X = 0xAA; SetZN(X); TotalCycles += 2; PC = 0xFDED;
                    goto case 0xFDED;
                case 0xFDEC:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xFDED;
                    goto case 0xFDED;
                case 0xFDED:
                    A = Ror(A); TotalCycles += 2; PC = 0xFDEE;
                    goto case 0xFDEE;
                case 0xFDEE:
                    A = Ror(A); TotalCycles += 2; PC = 0xFDEF;
                    return;
                case 0xFDF0:
                    { int a = 0x849D + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFDF3;
                    return;
                case 0xFDF1:
                    _ram[(0x0484 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xFDF4;
                    return;
                case 0xFDF2:
                    _ram[0x04] = Y; TotalCycles += 3; PC = 0xFDF4;
                    return;
                case 0xFDF7:
                    _ram[0x22] = X; TotalCycles += 3; PC = 0xFDF9;
                    return;
                case 0xFDFC:
                    Bit(ReadIoReg(0x2212)); TotalCycles += 4; PC = 0xFDFF;
                    goto case 0xFDFF;
                case 0xFDFF:
                    A = Rol(A); TotalCycles += 2; PC = 0xFE00;
                    return;
                case 0xFE02:
                    Bit(ReadIoReg(0x221C)); TotalCycles += 4; PC = 0xFE05;
                    goto case 0xFE05;
                case 0xFE05:
                    Bit(ReadIoReg(0x2214)); TotalCycles += 4; PC = 0xFE08;
                    goto case 0xFE08;
                case 0xFE08:
                    Bit(ReadIoReg(0x2212)); TotalCycles += 4; PC = 0xFE0B;
                    goto case 0xFE0B;
                case 0xFE0B:
                    A = Rol(A); TotalCycles += 2; PC = 0xFE0C;
                    return;
                case 0xFE0E:
                    Bit(ReadIoReg(0x221C)); TotalCycles += 4; PC = 0xFE11;
                    goto case 0xFE11;
                case 0xFE11:
                    Bit(ReadIoReg(0x2218)); TotalCycles += 4; PC = 0xFE14;
                    goto case 0xFE14;
                case 0xFE12:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFE13;
                    return;
                case 0xFE14:
                    A = Rol(A); TotalCycles += 2; PC = 0xFE15;
                    goto case 0xFE15;
                case 0xFE15:
                    { byte z = (byte)(0x20 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFE17;
                    goto case 0xFE17;
                case 0xFE16:
                    TotalCycles += 6; PushU16(0xFE18); PC = 0x1828;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFE17:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFE18;
                    goto case 0xFE18;
                case 0xFE18:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFE19;
                    return;
                case 0xFE1A:
                    A = Rol(A); TotalCycles += 2; PC = 0xFE1B;
                    return;
                case 0xFE1D:
                    A = Rol(A); TotalCycles += 2; PC = 0xFE1E;
                    goto case 0xFE1E;
                case 0xFE1E:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFE1F;
                    return;
                case 0xFE20:
                    A = Rol(A); TotalCycles += 2; PC = 0xFE21;
                    return;
                case 0xFE23:
                    A = Rol(A); TotalCycles += 2; PC = 0xFE24;
                    return;
                case 0xFE26:
                    Bit(ReadIoReg(0x220C)); TotalCycles += 4; PC = 0xFE29;
                    goto case 0xFE29;
                case 0xFE29:
                    Bit(ReadIoReg(0x2214)); TotalCycles += 4; PC = 0xFE2C;
                    return;
                case 0xFE2F:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFE41; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFE41; }
                    PC = 0xFE31; return;
                case 0xFE30:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xFE54; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFE32; goto case 0xFE32;
                case 0xFE32:
                    { int a = 0x2216; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xFE35;
                    return;
                case 0xFE33:
                    { byte z = (byte)(0x22 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFE35;
                    return;
                case 0xFE36:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFE37;
                    goto case 0xFE37;
                case 0xFE37:
                    _ram[0x36] = Rol(_ram[0x36]); TotalCycles += 5; PC = 0xFE39;
                    goto case 0xFE39;
                case 0xFE38:
                    { byte z = (byte)(0x16 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFE3A;
                    goto case 0xFE3A;
                case 0xFE39:
                    { byte z = (byte)(0x26 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFE3B;
                    goto case 0xFE3B;
                case 0xFE3A:
                    _ram[0x36] = Rol(_ram[0x36]); TotalCycles += 5; PC = 0xFE3C;
                    return;
                case 0xFE3B:
                    { byte z = (byte)(0x14 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFE3D;
                    goto case 0xFE3D;
                case 0xFE3D:
                    _ram[0x36] = Rol(_ram[0x36]); TotalCycles += 5; PC = 0xFE3F;
                    return;
                case 0xFE3E:
                    { byte z = (byte)(0x12 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFE40;
                    return;
                case 0xFE41:
                    { byte z = (byte)(0x5C + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFE43;
                    return;
                case 0xFE48:
                    WriteMem(ReadU16Zp((byte)(0x1E + X)), A); TotalCycles += 6; PC = 0xFE4A;
                    goto case 0xFE4A;
                case 0xFE49:
                    { int a = 0x851E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFE4C;
                    goto case 0xFE4C;
                case 0xFE4A:
                    { int a = 0x1E85 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFE4D;
                    goto case 0xFE4D;
                case 0xFE4B:
                    _ram[0x1E] = A; TotalCycles += 3; PC = 0xFE4D;
                    goto case 0xFE4D;
                case 0xFE4C:
                    { int a = 0x1281 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFE4F;
                    goto case 0xFE4F;
                case 0xFE4D:
                    WriteMem(ReadU16Zp((byte)(0x12 + X)), A); TotalCycles += 6; PC = 0xFE4F;
                    goto case 0xFE4F;
                case 0xFE4F:
                    _ram[0x14] = X; TotalCycles += 3; PC = 0xFE51;
                    goto case 0xFE51;
                case 0xFE51:
                    WriteMem(ReadU16Zp((byte)(0x2C + X)), A); TotalCycles += 6; PC = 0xFE53;
                    return;
                case 0xFE52:
                    Bit(_ram[0x0422]); TotalCycles += 4; PC = 0xFE55;
                    goto case 0xFE55;
                case 0xFE55:
                    Bit(_ram[0x0422]); TotalCycles += 4; PC = 0xFE58;
                    goto case 0xFE58;
                case 0xFE58:
                    _ram[0x2C] = A; TotalCycles += 3; PC = 0xFE5A;
                    return;
                case 0xFE59:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x0104]); TotalCycles += 4; PC = 0xFE5C;
                    goto case 0xFE5C;
                case 0xFE5B:
                    WriteMem(ReadU16Zp((byte)(0x2E + X)), A); TotalCycles += 6; PC = 0xFE5D;
                    goto case 0xFE5D;
                case 0xFE5C:
                    _ram[0x0624] = Rol(_ram[0x0624]); TotalCycles += 6; PC = 0xFE5F;
                    goto case 0xFE5F;
                case 0xFE5D:
                    Bit(_ram[0x1E]); TotalCycles += 3; PC = 0xFE5F;
                    goto case 0xFE5F;
                case 0xFE5E:
                    { int a = 0x242E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFE61;
                    goto case 0xFE61;
                case 0xFE5F:
                    _ram[0x0624] = Rol(_ram[0x0624]); TotalCycles += 6; PC = 0xFE62;
                    goto case 0xFE62;
                case 0xFE60:
                    Bit(_ram[0x1E]); TotalCycles += 3; PC = 0xFE62;
                    goto case 0xFE62;
                case 0xFE61:
                    { int a = 0x2E85 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFE64;
                    return;
                case 0xFE62:
                    _ram[0x2E] = A; TotalCycles += 3; PC = 0xFE64;
                    return;
                case 0xFE63:
                    { int a = 0x8104; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xFE66;
                    return;
                case 0xFE65:
                    WriteMem(ReadU16Zp((byte)(0x32 + X)), A); TotalCycles += 6; PC = 0xFE67;
                    goto case 0xFE67;
                case 0xFE67:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFE68;
                    return;
                case 0xFE6A:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFE6B;
                    return;
                case 0xFE6C:
                    _ram[0x32] = A; TotalCycles += 3; PC = 0xFE6E;
                    return;
                case 0xFE6F:
                    { byte z = (byte)(0x36 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFE71;
                    goto case 0xFE71;
                case 0xFE70:
                    { byte z = (byte)(0x36 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFE72;
                    goto case 0xFE72;
                case 0xFE71:
                    { byte z = (byte)(0x84 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFE73;
                    return;
                case 0xFE72:
                    _ram[0x3A] = Y; TotalCycles += 3; PC = 0xFE74;
                    goto case 0xFE74;
                case 0xFE74:
                    TotalCycles += 7; PushU16(0xFE76); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFE77:
                    TotalCycles += 3; PC = 0x545C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFE7A:
                    TotalCycles += 3; PC = 0x1C5C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFE82:
                    { int a = 0x4E56 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFE85;
                    goto case 0xFE85;
                case 0xFE83:
                    { byte z = (byte)(0x4E + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xFE85;
                    goto case 0xFE85;
                case 0xFE84:
                    { int a = 0x565E; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xFE87;
                    goto case 0xFE87;
                case 0xFE85:
                    { int a = 0x4E56 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFE88;
                    goto case 0xFE88;
                case 0xFE86:
                    { byte z = (byte)(0x4E + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xFE88;
                    goto case 0xFE88;
                case 0xFE87:
                    _ram[0x065E] = Lsr(_ram[0x065E]); TotalCycles += 6; PC = 0xFE8A;
                    goto case 0xFE8A;
                case 0xFE88:
                    { int a = 0x1E1E + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFE8B;
                    goto case 0xFE8B;
                case 0xFE89:
                    { int a = 0x5E1E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFE8C;
                    goto case 0xFE8C;
                case 0xFE8A:
                    { int a = 0x5E5E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFE8D;
                    goto case 0xFE8D;
                case 0xFE8B:
                    { int a = 0x5E5E + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFE8E;
                    goto case 0xFE8E;
                case 0xFE8C:
                    { int a = 0x5E5E + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFE8F;
                    return;
                case 0xFE8D:
                    { int a = 0x625E + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFE90;
                    return;
                case 0xFE8E:
                    { int a = 0x5A62 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xFE91;
                    goto case 0xFE91;
                case 0xFE91:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xFEF5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFE93; return;
                case 0xFE94:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xFEF8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFEF8; }
                    PC = 0xFE96; return;
                case 0xFE9D:
                    _ram[0x14] = X; TotalCycles += 3; PC = 0xFE9F;
                    goto case 0xFE9F;
                case 0xFE9F:
                    WriteMem(ReadU16Zp((byte)(0x14 + X)), A); TotalCycles += 6; PC = 0xFEA1;
                    return;
                case 0xFEA4:
                    WriteMem(ReadU16Zp((byte)(0x14 + X)), A); TotalCycles += 6; PC = 0xFEA6;
                    return;
                case 0xFEA9:
                    _ram[0x16] = X; TotalCycles += 3; PC = 0xFEAB;
                    goto case 0xFEAB;
                case 0xFEAA:
                    { byte z = (byte)(0x81 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFEAC;
                    goto case 0xFEAC;
                case 0xFEAB:
                    WriteMem(ReadU16Zp((byte)(0x16 + X)), A); TotalCycles += 6; PC = 0xFEAD;
                    return;
                case 0xFEAC:
                    { byte z = (byte)(0x80 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFEAE;
                    goto case 0xFEAE;
                case 0xFEAE:
                    { byte z = (byte)(0x16 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFEB0;
                    goto case 0xFEB0;
                case 0xFEAF:
                    { byte z = (byte)(0x81 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFEB1;
                    goto case 0xFEB1;
                case 0xFEB0:
                    WriteMem(ReadU16Zp((byte)(0x16 + X)), A); TotalCycles += 6; PC = 0xFEB2;
                    goto case 0xFEB2;
                case 0xFEB1:
                    { byte z = (byte)(0x16 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFEB3;
                    goto case 0xFEB3;
                case 0xFEB2:
                    { byte z = (byte)(0x16 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFEB4;
                    goto case 0xFEB4;
                case 0xFEB3:
                    { byte z = (byte)(0x16 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFEB5;
                    goto case 0xFEB5;
                case 0xFEB4:
                    { byte z = (byte)(0x81 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFEB6;
                    goto case 0xFEB6;
                case 0xFEB5:
                    WriteMem(ReadU16Zp((byte)(0x28 + X)), A); TotalCycles += 6; PC = 0xFEB7;
                    return;
                case 0xFEB6:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFEB7;
                    return;
                case 0xFEB9:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFEBA;
                    return;
                case 0xFEBC:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFEBD;
                    return;
                case 0xFEBE:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFEBF;
                    goto case 0xFEBF;
                case 0xFEBF:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFEC0;
                    goto case 0xFEC0;
                case 0xFEC0:
                    WriteMem(ReadU16Zp((byte)(0x28 + X)), A); TotalCycles += 6; PC = 0xFEC2;
                    return;
                case 0xFEC1:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFEC2;
                    return;
                case 0xFEC3:
                    Bit(ReadIoReg(0x2C2C)); TotalCycles += 4; PC = 0xFEC6;
                    goto case 0xFEC6;
                case 0xFEC4:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x042C]); TotalCycles += 4; PC = 0xFEC7;
                    goto case 0xFEC7;
                case 0xFEC5:
                    Bit(ReadIoReg(0x3084)); TotalCycles += 4; PC = 0xFEC8;
                    return;
                case 0xFEC6:
                    _ram[0x30] = Y; TotalCycles += 3; PC = 0xFEC8;
                    return;
                case 0xFEC7:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFE4C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFE4C; }
                    PC = 0xFEC9; return;
                case 0xFECA:
                    _ram[0x0C] = Y; TotalCycles += 3; PC = 0xFECC;
                    return;
                case 0xFECE:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xFE54; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFED0; return;
                case 0xFECF:
                    _ram[0x12] = Y; TotalCycles += 3; PC = 0xFED1;
                    return;
                case 0xFED4:
                    { int a = 0x2622 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFED7;
                    goto case 0xFED7;
                case 0xFED6:
                    _ram[0x18] = Rol(_ram[0x18]); TotalCycles += 5; PC = 0xFED8;
                    goto case 0xFED8;
                case 0xFED7:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFED8;
                    goto case 0xFED8;
                case 0xFED8:
                    { int a = 0x1C04 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFEDB;
                    goto case 0xFEDB;
                case 0xFEDB:
                    TotalCycles += 7; PushU16(0xFEDD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFEDD:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xE3 + X)))); TotalCycles += 6; PC = 0xFEDF;
                    goto case 0xFEDF;
                case 0xFEDF:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x60DE + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xFEE2;
                    return;
                case 0xFEE0:
                    { int a = 0x23E0 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xFEE3;
                    goto case 0xFEE3;
                case 0xFEE1:
                    Cmp(X, 0x23); TotalCycles += 2; PC = 0xFEE3;
                    goto case 0xFEE3;
                case 0xFEE3:
                    Cmp(X, ReadIoReg(0x7475)); TotalCycles += 4; PC = 0xFEE6;
                    goto case 0xFEE6;
                case 0xFEE4:
                    Adc(_ram[(byte)(0x74 + X)]); TotalCycles += 4; PC = 0xFEE6;
                    goto case 0xFEE6;
                case 0xFEE6:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xFEDC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFEE8; goto case 0xFEE8;
                case 0xFEE8:
                    { byte z = (byte)(0xEA + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xFEEA;
                    goto case 0xFEEA;
                case 0xFEE9:
                     TotalCycles += 2; PC = 0xFEEA;
                    goto case 0xFEEA;
                case 0xFEEA:
                    A &= ReadMem(ReadU16Zp(0x2D) + Y); SetZN(A); TotalCycles += 5; PC = 0xFEEC;
                    return;
                case 0xFEEB:
                    A &= _ram[0x0283]; SetZN(A); TotalCycles += 4; PC = 0xFEEE;
                    return;
                case 0xFEF0:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFEF1;
                    return;
                case 0xFEF4:
                    _ram[0x22] = Rol(_ram[0x22]); TotalCycles += 5; PC = 0xFEF6;
                    goto case 0xFEF6;
                case 0xFEF6:
                    { int a = 0x181C + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFEF9;
                    goto case 0xFEF9;
                case 0xFEF8:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFEF9;
                    goto case 0xFEF9;
                case 0xFEF9:
                    { int a = 0x0C22 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFEFC;
                    return;
                case 0xFF00:
                    TotalCycles += 7; PushU16(0xFF02); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF01:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xFF02;
                    goto case 0xFF02;
                case 0xFF02:
                    TotalCycles += 7; PushU16(0xFF04); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF04:
                    TotalCycles += 7; PushU16(0xFF06); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF05:
                    TotalCycles += 7; PushU16(0xFF07); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF07:
                    X = _ram[0x02]; SetZN(X); TotalCycles += 3; PC = 0xFF09;
                    return;
                case 0xFF10:
                    A |= ReadMem(ReadU16Zp((byte)(0xDF + X))); SetZN(A); TotalCycles += 6; PC = 0xFF12;
                    goto case 0xFF12;
                case 0xFF12:
                    A |= ReadMem(ReadU16Zp((byte)(0xC4 + X))); SetZN(A); TotalCycles += 6; PC = 0xFF14;
                    goto case 0xFF14;
                case 0xFF13:
                    Cmp(Y, _ram[0x01]); TotalCycles += 3; PC = 0xFF15;
                    return;
                case 0xFF14:
                    A |= ReadMem(ReadU16Zp((byte)(0xAB + X))); SetZN(A); TotalCycles += 6; PC = 0xFF16;
                    goto case 0xFF16;
                case 0xFF16:
                    A |= ReadMem(ReadU16Zp((byte)(0x93 + X))); SetZN(A); TotalCycles += 6; PC = 0xFF18;
                    goto case 0xFF18;
                case 0xFF18:
                    A |= ReadMem(ReadU16Zp((byte)(0x7C + X))); SetZN(A); TotalCycles += 6; PC = 0xFF1A;
                    goto case 0xFF1A;
                case 0xFF1A:
                    A |= ReadMem(ReadU16Zp((byte)(0x67 + X))); SetZN(A); TotalCycles += 6; PC = 0xFF1C;
                    goto case 0xFF1C;
                case 0xFF1C:
                    A |= ReadMem(ReadU16Zp((byte)(0x53 + X))); SetZN(A); TotalCycles += 6; PC = 0xFF1E;
                    goto case 0xFF1E;
                case 0xFF1E:
                    A |= ReadMem(ReadU16Zp((byte)(0x40 + X))); SetZN(A); TotalCycles += 6; PC = 0xFF20;
                    goto case 0xFF20;
                case 0xFF1F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xFF20:
                    A |= ReadMem(ReadU16Zp((byte)(0x2E + X))); SetZN(A); TotalCycles += 6; PC = 0xFF22;
                    goto case 0xFF22;
                case 0xFF21:
                    _ram[0x0501] = Rol(_ram[0x0501]); TotalCycles += 6; PC = 0xFF24;
                    goto case 0xFF24;
                case 0xFF22:
                    A |= ReadMem(ReadU16Zp((byte)(0x1D + X))); SetZN(A); TotalCycles += 6; PC = 0xFF24;
                    goto case 0xFF24;
                case 0xFF23:
                    A |= ReadMem(0x0D01 + X); SetZN(A); TotalCycles += 4; PC = 0xFF26;
                    goto case 0xFF26;
                case 0xFF24:
                    A |= ReadMem(ReadU16Zp((byte)(0x0D + X))); SetZN(A); TotalCycles += 6; PC = 0xFF26;
                    goto case 0xFF26;
                case 0xFF25:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x7E00]; SetZN(A); TotalCycles += 4; PC = 0xFF28;
                    goto case 0xFF28;
                case 0xFF26:
                    TotalCycles += 7; PushU16(0xFF28); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF27:
                    { int a = 0xEF00 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xFF2A;
                    goto case 0xFF2A;
                case 0xFF28:
                    TotalCycles += 7; PushU16(0xFF2A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF2A:
                    TotalCycles += 7; PushU16(0xFF2C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF2C:
                    TotalCycles += 7; PushU16(0xFF2E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF2D:
                    Cmp(A, _ram[(byte)(0x00 + X)]); TotalCycles += 4; PC = 0xFF2F;
                    goto case 0xFF2F;
                case 0xFF2E:
                    TotalCycles += 7; PushU16(0xFF30); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF2F:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xFF31;
                    goto case 0xFF31;
                case 0xFF30:
                    TotalCycles += 7; PushU16(0xFF32); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF31:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x3300 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xFF34;
                    goto case 0xFF34;
                case 0xFF32:
                    TotalCycles += 7; PushU16(0xFF34); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF34:
                    TotalCycles += 7; PushU16(0xFF36); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF35:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xFF37;
                    goto case 0xFF37;
                case 0xFF36:
                    TotalCycles += 7; PushU16(0xFF38); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF37:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xFF39;
                    return;
                case 0xFF38:
                    TotalCycles += 7; PushU16(0xFF3A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF3A:
                    TotalCycles += 7; PushU16(0xFF3C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF3B:
                    WriteIoReg(0x8600, X); TotalCycles += 4; PC = 0xFF3E;
                    goto case 0xFF3E;
                case 0xFF3C:
                    TotalCycles += 7; PushU16(0xFF3E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF3D:
                    _ram[0x00] = X; TotalCycles += 3; PC = 0xFF3F;
                    return;
                case 0xFF3E:
                    TotalCycles += 7; PushU16(0xFF40); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF40:
                    TotalCycles += 7; PushU16(0xFF42); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF41:
                    { int a = 0x7100 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xFF44;
                    goto case 0xFF44;
                case 0xFF42:
                    TotalCycles += 7; PushU16(0xFF44); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF43:
                    Adc(ReadMem(ReadU16Zp(0x00) + Y)); TotalCycles += 5; PC = 0xFF45;
                    return;
                case 0xFF44:
                    TotalCycles += 7; PushU16(0xFF46); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF46:
                    TotalCycles += 7; PushU16(0xFF48); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF48:
                    TotalCycles += 7; PushU16(0xFF4A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF4A:
                    TotalCycles += 7; PushU16(0xFF4C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF4B:
                    A ^= ReadMem(0x5000 + Y); SetZN(A); TotalCycles += 4; PC = 0xFF4E;
                    goto case 0xFF4E;
                case 0xFF4C:
                    TotalCycles += 7; PushU16(0xFF4E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF4D:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xFF4F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFF4F; return;
                case 0xFF4E:
                    TotalCycles += 7; PushU16(0xFF50); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF50:
                    TotalCycles += 7; PushU16(0xFF52); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF52:
                    TotalCycles += 7; PushU16(0xFF54); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF54:
                    TotalCycles += 7; PushU16(0xFF56); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF55:
                    A &= _ram[(byte)(0x00 + X)]; SetZN(A); TotalCycles += 4; PC = 0xFF57;
                    goto case 0xFF57;
                case 0xFF56:
                    TotalCycles += 7; PushU16(0xFF58); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF57:
                    A = Rol(A); TotalCycles += 2; PC = 0xFF58;
                    goto case 0xFF58;
                case 0xFF58:
                    TotalCycles += 7; PushU16(0xFF5A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF5B:
                    Adc(_ram[(byte)(0x03 + X)]); TotalCycles += 4; PC = 0xFF5D;
                    return;
                case 0xFF5F:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x4F02 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xFF62;
                    goto case 0xFF62;
                case 0xFF62:
                    A |= ReadMem(ReadU16Zp((byte)(0xFC + X))); SetZN(A); TotalCycles += 6; PC = 0xFF64;
                    goto case 0xFF64;
                case 0xFF64:
                    TotalCycles += 7; PushU16(0xFF66); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xFF65:
                    A = Ror(A); TotalCycles += 2; PC = 0xFF66;
                    goto case 0xFF66;
                case 0xFF66:
                    A |= _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0xFF68;
                    return;
                case 0xFF67:
                    A = Asl(A); TotalCycles += 2; PC = 0xFF68;
                    return;
                case 0xFF69:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xFF6A;
                    goto case 0xFF6A;
                case 0xFF6A:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xFF8A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFF6C; return;
                case 0xFF6B:
                    { int a = (0x023C + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xFF6E;
                    return;
                case 0xFF6F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xFF70;
                    goto case 0xFF70;
                case 0xFF70:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xFF92; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFF92; }
                    PC = 0xFF72; goto case 0xFF72;
                case 0xFF71:
                    TotalCycles += 6; PushU16(0xFF73); PC = 0x1840;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xFF72:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xFF73:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFF74;
                    goto case 0xFF74;
                case 0xFF74:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFF82; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFF76; return;
                case 0xFF77:
                    _ram[0x0C] = Asl(_ram[0x0C]); TotalCycles += 5; PC = 0xFF79;
                    goto case 0xFF79;
                case 0xFF79:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFF7A;
                    goto case 0xFF7A;
                case 0xFF7A:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xFF8E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xFF7C; goto case 0xFF7C;
                case 0xFF7C:
                    Bit(_ram[0x08]); TotalCycles += 3; PC = 0xFF7E;
                    goto case 0xFF7E;
                case 0xFF7D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xFF7E;
                    goto case 0xFF7E;
                case 0xFF7E:
                    { byte z = (byte)(0x03 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xFF80;
                    goto case 0xFF80;
                case 0xFF80:
                    A |= 0x06; SetZN(A); TotalCycles += 2; PC = 0xFF82;
                    return;
                case 0xFF81:
                    _ram[0x12] = Asl(_ram[0x12]); TotalCycles += 5; PC = 0xFF83;
                    return;
                case 0xFF84:
                    Bit(_ram[0x0C]); TotalCycles += 3; PC = 0xFF86;
                    goto case 0xFF86;
                case 0xFF86: // === SUBROUTINE: Sub_FF86 ===
                    Bit(_ram[0x02]); TotalCycles += 3; PC = 0xFF88;
                    goto case 0xFF88;
                case 0xFF88:
                    _ram[0x04] = Asl(_ram[0x04]); TotalCycles += 5; PC = 0xFF8A;
                    return;
                case 0xFF8C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFF8D;
                    goto case 0xFF8D;
                case 0xFF8D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xFF8E;
                    return;
                case 0xFF8F:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0xFF91;
                    return;
                case 0xFF92:
                    _ram[0x09] = Asl(_ram[0x09]); TotalCycles += 5; PC = 0xFF94;
                    return;
                case 0xFF93:
                    A |= 0x0C; SetZN(A); TotalCycles += 2; PC = 0xFF95;
                    return;
                case 0xFF96:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xFF97;
                    goto case 0xFF97;
                case 0xFF97:
                    WriteMem(0x9B9A + Y, A); TotalCycles += 5; PC = 0xFF9A;
                    goto case 0xFF9A;
                case 0xFF98:
                    SP = X; TotalCycles += 2; PC = 0xFF99;
                    return;
                case 0xFF9A:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xFF30; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFF30; }
                    PC = 0xFF9C; goto case 0xFF9C;
                case 0xFF9B:
                    _ram[(byte)(0x94 + X)] = Y; TotalCycles += 4; PC = 0xFF9D;
                    goto case 0xFF9D;
                case 0xFF9C:
                    _ram[(byte)(0x95 + X)] = Y; TotalCycles += 4; PC = 0xFF9E;
                    goto case 0xFF9E;
                case 0xFF9D:
                    _ram[(byte)(0x95 + X)] = A; TotalCycles += 4; PC = 0xFF9F;
                    goto case 0xFF9F;
                case 0xFF9E:
                    _ram[(byte)(0x96 + X)] = A; TotalCycles += 4; PC = 0xFFA0;
                    return;
                case 0xFF9F:
                    _ram[(byte)(0x97 + Y)] = X; TotalCycles += 4; PC = 0xFFA1;
                    goto case 0xFFA1;
                case 0xFFA1:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xFFA2;
                    goto case 0xFFA2;
                case 0xFFA2:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xFF35; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xFF35; }
                    PC = 0xFFA4; return;
                case 0xFFA3:
                    WriteMem(ReadU16Zp(0x92) + Y, A); TotalCycles += 6; PC = 0xFFA5;
                    return;
                case 0xFFA9:
                    _ram[(byte)(0x94 + X)] = Y; TotalCycles += 4; PC = 0xFFAB;
                    goto case 0xFFAB;
                case 0xFFAA:
                    _ram[(byte)(0x94 + X)] = Y; TotalCycles += 4; PC = 0xFFAC;
                    goto case 0xFFAC;
                case 0xFFAB:
                    _ram[(byte)(0x94 + X)] = Y; TotalCycles += 4; PC = 0xFFAD;
                    goto case 0xFFAD;
                case 0xFFAC:
                    _ram[(byte)(0x94 + X)] = Y; TotalCycles += 4; PC = 0xFFAE;
                    goto case 0xFFAE;
                case 0xFFAD:
                    _ram[(byte)(0x94 + X)] = Y; TotalCycles += 4; PC = 0xFFAF;
                    goto case 0xFFAF;
                case 0xFFAE:
                    _ram[(byte)(0x95 + X)] = Y; TotalCycles += 4; PC = 0xFFB0;
                    goto case 0xFFB0;
                case 0xFFAF:
                    _ram[(byte)(0x95 + X)] = A; TotalCycles += 4; PC = 0xFFB1;
                    goto case 0xFFB1;
                case 0xFFB0:
                    _ram[(byte)(0x95 + X)] = A; TotalCycles += 4; PC = 0xFFB2;
                    goto case 0xFFB2;
                case 0xFFB1:
                    _ram[(byte)(0x95 + X)] = A; TotalCycles += 4; PC = 0xFFB3;
                    goto case 0xFFB3;
                case 0xFFB2:
                    _ram[(byte)(0x95 + X)] = A; TotalCycles += 4; PC = 0xFFB4;
                    goto case 0xFFB4;
                case 0xFFB3:
                    _ram[(byte)(0x95 + X)] = A; TotalCycles += 4; PC = 0xFFB5;
                    goto case 0xFFB5;
                case 0xFFB4:
                    _ram[(byte)(0x96 + X)] = A; TotalCycles += 4; PC = 0xFFB6;
                    goto case 0xFFB6;
                case 0xFFB5:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFB7;
                    goto case 0xFFB7;
                case 0xFFB6:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFB8;
                    goto case 0xFFB8;
                case 0xFFB7:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFB9;
                    goto case 0xFFB9;
                case 0xFFB8:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFBA;
                    goto case 0xFFBA;
                case 0xFFB9:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFBB;
                    goto case 0xFFBB;
                case 0xFFBA:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFBC;
                    goto case 0xFFBC;
                case 0xFFBB:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFBD;
                    goto case 0xFFBD;
                case 0xFFBC:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFBE;
                    goto case 0xFFBE;
                case 0xFFBD:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFBF;
                    goto case 0xFFBF;
                case 0xFFBE:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFC0;
                    goto case 0xFFC0;
                case 0xFFBF:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFC1;
                    goto case 0xFFC1;
                case 0xFFC0:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFC2;
                    goto case 0xFFC2;
                case 0xFFC1:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFC3;
                    goto case 0xFFC3;
                case 0xFFC2:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFC4;
                    goto case 0xFFC4;
                case 0xFFC3:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFC5;
                    goto case 0xFFC5;
                case 0xFFC4:
                    _ram[(byte)(0x96 + Y)] = X; TotalCycles += 4; PC = 0xFFC6;
                    goto case 0xFFC6;
                case 0xFFC5:
                    _ram[(byte)(0x95 + Y)] = X; TotalCycles += 4; PC = 0xFFC7;
                    goto case 0xFFC7;
                case 0xFFC6:
                    _ram[(byte)(0x95 + X)] = A; TotalCycles += 4; PC = 0xFFC8;
                    goto case 0xFFC8;
                case 0xFFC7:
                    _ram[(byte)(0x94 + X)] = A; TotalCycles += 4; PC = 0xFFC9;
                    return;
                case 0xFFC8:
                    _ram[(byte)(0x93 + X)] = Y; TotalCycles += 4; PC = 0xFFCA;
                    goto case 0xFFCA;
                case 0xFFCA: // === SUBROUTINE: Sub_FFCA ===
                    A |= _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xFFCC;
                    goto case 0xFFCC;
                case 0xFFCB:
                    { byte z = (byte)(0x16 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFFCD;
                    return;
                case 0xFFCC:
                    { byte z = (byte)(0x17 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFFCE;
                    return;
                case 0xFFCF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFFD0;
                    goto case 0xFFD0;
                case 0xFFD0:
                    A |= ReadMem(0x1A19 + Y); SetZN(A); TotalCycles += 4; PC = 0xFFD3;
                    return;
                case 0xFFD1:
                    A |= ReadMem(0x1A1A + Y); SetZN(A); TotalCycles += 4; PC = 0xFFD4;
                    return;
                case 0xFFD5:
                    A |= ReadMem(0x1E1D + X); SetZN(A); TotalCycles += 4; PC = 0xFFD8;
                    goto case 0xFFD8;
                case 0xFFD6:
                    A |= ReadMem(0x1E1E + X); SetZN(A); TotalCycles += 4; PC = 0xFFD9;
                    return;
                case 0xFFD7:
                    { int a = 0x1F1E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFFDA;
                    return;
                case 0xFFD8:
                    { int a = 0x1F1F + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFFDB;
                    return;
                case 0xFFDD:
                    { int a = 0x1C1D + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFFE0;
                    goto case 0xFFE0;
                case 0xFFDE:
                    A |= ReadMem(0x1E1C + X); SetZN(A); TotalCycles += 4; PC = 0xFFE1;
                    return;
                case 0xFFE0:
                    { int a = 0x1F1F + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFFE3;
                    goto case 0xFFE3;
                case 0xFFE3:
                    { int a = 0x1C1D + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFFE6;
                    return;
                case 0xFFE4:
                    A |= ReadMem(0x1A1C + X); SetZN(A); TotalCycles += 4; PC = 0xFFE7;
                    goto case 0xFFE7;
                case 0xFFE7:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFFE8;
                    goto case 0xFFE8;
                case 0xFFE8:
                    { byte z = (byte)(0x14 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFFEA;
                    goto case 0xFFEA;
                case 0xFFEA:
                    A |= _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xFFEC;
                    goto case 0xFFEC;
                case 0xFFEB:
                    { byte z = (byte)(0x16 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFFED;
                    return;
                case 0xFFEC:
                    { byte z = (byte)(0x17 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xFFEE;
                    return;
                case 0xFFEF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xFFF0;
                    goto case 0xFFF0;
                case 0xFFF0: // === SUBROUTINE: IRQ_Handler ===
                    A |= ReadMem(0x1A19 + Y); SetZN(A); TotalCycles += 4; PC = 0xFFF3;
                    return;
                case 0xFFF1:
                    A |= ReadMem(0x1A1A + Y); SetZN(A); TotalCycles += 4; PC = 0xFFF4;
                    return;
                case 0xFFF5:
                    A |= ReadMem(0x1E1D + X); SetZN(A); TotalCycles += 4; PC = 0xFFF8;
                    goto case 0xFFF8;
                case 0xFFF6:
                    A |= ReadMem(0x1E1E + X); SetZN(A); TotalCycles += 4; PC = 0xFFF9;
                    return;
                case 0xFFF7:
                    { int a = 0x1F1E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFFFA;
                    return;
                case 0xFFF8:
                    { int a = 0x821F + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xFFFB;
                    return;
                default:
                    throw new InvalidOperationException($"Address not statically recompiled: 0x{PC:X4}");
            }
        }
    }
}
