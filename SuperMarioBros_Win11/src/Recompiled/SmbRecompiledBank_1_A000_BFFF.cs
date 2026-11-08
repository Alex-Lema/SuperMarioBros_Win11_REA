using System;
using System.Runtime.CompilerServices;
using SuperMarioBros_Win11.Recompiled;

namespace SuperMarioBros_Win11.Core
{
    public sealed partial class SmbEngineCore
    {
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private void ExecuteNativeBlock_A000_BFFF(long targetCycles)
        {
            switch (PC)
            {
                case 0xA003:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA004;
                    return;
                case 0xA009:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA00A;
                    return;
                case 0xA00D:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA00E;
                    return;
                case 0xA013:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x387B + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xA016;
                    return;
                case 0xA015:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA016;
                    return;
                case 0xA017:
                    _ram[0x06CB] = X; TotalCycles += 4; PC = 0xA01A;
                    return;
                case 0xA019:
                    { int a = 0x8E1B; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA01C;
                    return;
                case 0xA01B:
                    _ram[0x050F] = X; TotalCycles += 4; PC = 0xA01E;
                    return;
                case 0xA01D:
                    A |= ReadIoReg(0x3B2B); SetZN(A); TotalCycles += 4; PC = 0xA020;
                    return;
                case 0xA021:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA022;
                    return;
                case 0xA025:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA026;
                    return;
                case 0xA027:
                    P |= FlagC; TotalCycles += 2; PC = 0xA028;
                    return;
                case 0xA02F:
                    TotalCycles += 7; PushU16(0xA031); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA033:
                    Y = ReadMem(0x7BFF + X); SetZN(Y); TotalCycles += 4; PC = 0xA036;
                    return;
                case 0xA037:
                    X = SmbEmbeddedAssets.StaticDataTables[0x0000]; SetZN(X); TotalCycles += 4; PC = 0xA03A;
                    return;
                case 0xA038:
                    TotalCycles += 7; PushU16(0xA03A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA03B:
                    _ram[0x05E8] = X; TotalCycles += 4; PC = 0xA03E;
                    goto case 0xA03E;
                case 0xA03C:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xA03D;
                    goto case 0xA03D;
                case 0xA03D:
                    A |= _ram[0xF9]; SetZN(A); TotalCycles += 3; PC = 0xA03F;
                    goto case 0xA03F;
                case 0xA03E:
                    Sbc(ReadMem(0x1786 + Y)); TotalCycles += 4; PC = 0xA041;
                    goto case 0xA041;
                case 0xA03F:
                    _ram[0x17] = X; TotalCycles += 3; PC = 0xA041;
                    goto case 0xA041;
                case 0xA041:
                    _ram[0x16] = X; TotalCycles += 3; PC = 0xA043;
                    goto case 0xA043;
                case 0xA042:
                    { byte z = (byte)(0x85 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA044;
                    goto case 0xA044;
                case 0xA043:
                    _ram[0x4E] = A; TotalCycles += 3; PC = 0xA045;
                    return;
                case 0xA044:
                    { int a = 0x802B; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA047;
                    return;
                case 0xA048:
                    WriteIoReg(0x8587, X); TotalCycles += 4; PC = 0xA04B;
                    return;
                case 0xA04A:
                    _ram[0xC3] = A; TotalCycles += 3; PC = 0xA04C;
                    goto case 0xA04C;
                case 0xA04C:
                    A |= _ram[0x8B]; SetZN(A); TotalCycles += 3; PC = 0xA04E;
                    return;
                case 0xA054:
                    _ram[0xCB] = X; TotalCycles += 3; PC = 0xA056;
                    goto case 0xA056;
                case 0xA056:
                    _ram[0xD3] = Asl(_ram[0xD3]); TotalCycles += 5; PC = 0xA058;
                    return;
                case 0xA05A:
                    _ram[0x066B] = X; TotalCycles += 4; PC = 0xA05D;
                    return;
                case 0xA05C:
                    { int a = 0x8EA7; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA05F;
                    return;
                case 0xA05E:
                    WriteIoReg(0x29FF, X); TotalCycles += 4; PC = 0xA061;
                    goto case 0xA061;
                case 0xA060:
                    A &= 0x8E; SetZN(A); TotalCycles += 2; PC = 0xA062;
                    return;
                case 0xA061:
                    _ram[0x0152] = X; TotalCycles += 4; PC = 0xA064;
                    return;
                case 0xA063:
                    A |= ReadMem(ReadU16Zp(0x83) + Y); SetZN(A); TotalCycles += 5; PC = 0xA065;
                    goto case 0xA065;
                case 0xA065:
                    _ram[0x030F] = Asl(_ram[0x030F]); TotalCycles += 6; PC = 0xA068;
                    return;
                case 0xA069:
                    { int a = 0x8E2B; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA06C;
                    return;
                case 0xA06B:
                    _ram[0x065B] = X; TotalCycles += 4; PC = 0xA06E;
                    return;
                case 0xA06D:
                    { int a = 0x8ECB; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA070;
                    return;
                case 0xA06F:
                    _ram[0x06FB] = X; TotalCycles += 4; PC = 0xA072;
                    return;
                case 0xA071:
                    { int a = 0x82FB; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA074;
                    return;
                case 0xA078:
                    { int a = 0xE842 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA07B;
                    return;
                case 0xA07A:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xA07B;
                    return;
                case 0xA07C:
                    _ram[0x020F] = X; TotalCycles += 4; PC = 0xA07F;
                    return;
                case 0xA07E:
                    A = Asl(A); TotalCycles += 2; PC = 0xA07F;
                    return;
                case 0xA080:
                    _ram[0x06CB] = Asl(_ram[0x06CB]); TotalCycles += 6; PC = 0xA083;
                    goto case 0xA083;
                case 0xA082:
                    _ram[0x06F9] = Asl(_ram[0x06F9]); TotalCycles += 6; PC = 0xA085;
                    goto case 0xA085;
                case 0xA083:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x080E + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xA086;
                    goto case 0xA086;
                case 0xA084:
                    { int a = 0x8688; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA087;
                    goto case 0xA087;
                case 0xA085:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xA086;
                    goto case 0xA086;
                case 0xA086:
                    _ram[0xA6] = X; TotalCycles += 3; PC = 0xA088;
                    goto case 0xA088;
                case 0xA087:
                    X = _ram[0x06]; SetZN(X); TotalCycles += 3; PC = 0xA089;
                    return;
                case 0xA088:
                    _ram[0xDB] = Asl(_ram[0xDB]); TotalCycles += 5; PC = 0xA08A;
                    return;
                case 0xA08B:
                    X = _ram[(byte)(0x8E + Y)]; SetZN(X); TotalCycles += 4; PC = 0xA08D;
                    return;
                case 0xA08C:
                    WriteIoReg(0xABFF, X); TotalCycles += 4; PC = 0xA08F;
                    goto case 0xA08F;
                case 0xA08F:
                    { int a = 0x42DE; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA092;
                    goto case 0xA092;
                case 0xA090:
                    { int a = 0xC042 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA093;
                    return;
                case 0xA092:
                    Cmp(Y, 0xCB); TotalCycles += 2; PC = 0xA094;
                    goto case 0xA094;
                case 0xA094:
                    { int a = 0x8E5B; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA097;
                    return;
                case 0xA096:
                    WriteIoReg(0xCE1B, X); TotalCycles += 4; PC = 0xA099;
                    return;
                case 0xA098:
                    { int a = 0x854B; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA09B;
                    return;
                case 0xA09A:
                    _ram[0x67] = A; TotalCycles += 3; PC = 0xA09C;
                    goto case 0xA09C;
                case 0xA09C:
                    A ^= _ram[0x0F]; SetZN(A); TotalCycles += 3; PC = 0xA09E;
                    return;
                case 0xA0A0:
                    TotalCycles += 7; PushU16(0xA0A2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA0A2:
                    _ram[0x97] = A; TotalCycles += 3; PC = 0xA0A4;
                    goto case 0xA0A4;
                case 0xA0A4:
                    A |= _ram[0x0F]; SetZN(A); TotalCycles += 3; PC = 0xA0A6;
                    goto case 0xA0A6;
                case 0xA0A6:
                    A = Asl(A); TotalCycles += 2; PC = 0xA0A7;
                    return;
                case 0xA0AA:
                    A = Asl(A); TotalCycles += 2; PC = 0xA0AB;
                    goto case 0xA0AB;
                case 0xA0AB:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xA0AC;
                    goto case 0xA0AC;
                case 0xA0AC:
                    { int a = 0x4A24; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA0AF;
                    goto case 0xA0AF;
                case 0xA0AD:
                    Bit(_ram[0x4A]); TotalCycles += 3; PC = 0xA0AF;
                    goto case 0xA0AF;
                case 0xA0AE:
                    A = Lsr(A); TotalCycles += 2; PC = 0xA0AF;
                    goto case 0xA0AF;
                case 0xA0AF:
                    { int a = 0xAA23 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA0B2;
                    return;
                case 0xA0B1:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xA0B2;
                    return;
                case 0xA0B6:
                    P |= FlagC; TotalCycles += 2; PC = 0xA0B7;
                    return;
                case 0xA0B8:
                    Y = ReadMem(0x3BEB + X); SetZN(Y); TotalCycles += 4; PC = 0xA0BB;
                    return;
                case 0xA0BE:
                    TotalCycles += 7; PushU16(0xA0C0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA0C0:
                    P |= FlagC; TotalCycles += 2; PC = 0xA0C1;
                    return;
                case 0xA0C2: // === SUBROUTINE: Sub_A0C2 ===
                    TotalCycles += 7; PushU16(0xA0C4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA0C4:
                    WriteIoReg(0x80FB, X); TotalCycles += 4; PC = 0xA0C7;
                    return;
                case 0xA0C8:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA0C9;
                    return;
                case 0xA0D0:
                    Y = _ram[(0x00FB + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xA0D3;
                    return;
                case 0xA0D2:
                    TotalCycles += 7; PushU16(0xA0D4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA0D4:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA0D5;
                    return;
                case 0xA0D6:
                    P |= FlagC; TotalCycles += 2; PC = 0xA0D7;
                    return;
                case 0xA0D9:
                    _ram[0x1A] = X; TotalCycles += 3; PC = 0xA0DB;
                    goto case 0xA0DB;
                case 0xA0DB:
                    _ram[0xDB] = Asl(_ram[0xDB]); TotalCycles += 5; PC = 0xA0DD;
                    goto case 0xA0DD;
                case 0xA0DD:
                    _ram[0xDE] = Asl(_ram[0xDE]); TotalCycles += 5; PC = 0xA0DF;
                    return;
                case 0xA0DE:
                    { int a = (0x02C2 + X) & 0x07FF; _ram[a] = DecVal(_ram[a]); } TotalCycles += 7; PC = 0xA0E1;
                    goto case 0xA0E1;
                case 0xA0E1:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xA11E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA11E; }
                    PC = 0xA0E3; return;
                case 0xA0E6:
                    _ram[0x0B] = Asl(_ram[0x0B]); TotalCycles += 5; PC = 0xA0E8;
                    goto case 0xA0E8;
                case 0xA0E8:
                    _ram[0x93] = X; TotalCycles += 3; PC = 0xA0EA;
                    goto case 0xA0EA;
                case 0xA0EA:
                    _ram[0xF0] = Asl(_ram[0xF0]); TotalCycles += 5; PC = 0xA0EC;
                    goto case 0xA0EC;
                case 0xA0EB:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xA126; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA0ED; return;
                case 0xA0EC:
                    A &= _ram[(0x060F + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xA0EF;
                    goto case 0xA0EF;
                case 0xA0EE:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0xA0F0;
                    goto case 0xA0F0;
                case 0xA0EF:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA0F0:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA0F1;
                    return;
                case 0xA0F2:
                    _ram[0xA0] = X; TotalCycles += 3; PC = 0xA0F4;
                    goto case 0xA0F4;
                case 0xA0F3:
                    Y = 0xB9; SetZN(Y); TotalCycles += 2; PC = 0xA0F5;
                    return;
                case 0xA0F4:
                    A = ReadMem(0x27B7 + Y); SetZN(A); TotalCycles += 4; PC = 0xA0F7;
                    goto case 0xA0F7;
                case 0xA0F7:
                    A = ReadMem(0x2B27 + X); SetZN(A); TotalCycles += 4; PC = 0xA0FA;
                    return;
                case 0xA0FB:
                    A = ReadMem(ReadU16Zp((byte)(0x26 + X))); SetZN(A); TotalCycles += 6; PC = 0xA0FD;
                    goto case 0xA0FD;
                case 0xA0FC:
                    _ram[0xA9] = Rol(_ram[0xA9]); TotalCycles += 5; PC = 0xA0FE;
                    goto case 0xA0FE;
                case 0xA0FD:
                    A = 0x26; SetZN(A); TotalCycles += 2; PC = 0xA0FF;
                    goto case 0xA0FF;
                case 0xA0FE:
                    _ram[0xEE] = Rol(_ram[0xEE]); TotalCycles += 5; PC = 0xA100;
                    goto case 0xA100;
                case 0xA0FF:
                    _ram[0x0325] = IncVal(_ram[0x0325]); TotalCycles += 6; PC = 0xA102;
                    return;
                case 0xA100:
                    A &= _ram[0x0B]; SetZN(A); TotalCycles += 3; PC = 0xA102;
                    return;
                case 0xA103:
                    Y = _ram[(byte)(0xFF + X)]; SetZN(Y); TotalCycles += 4; PC = 0xA105;
                    return;
                case 0xA107:
                    { int a = 0x602F + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA10A;
                    goto case 0xA10A;
                case 0xA109:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA10A:
                    Cmp(X, 0x3A); TotalCycles += 2; PC = 0xA10C;
                    goto case 0xA10C;
                case 0xA10C:
                    A = _ram[0xA7]; SetZN(A); TotalCycles += 3; PC = 0xA10E;
                    return;
                case 0xA114:
                    { int a = 0x6842 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA117;
                    goto case 0xA117;
                case 0xA116:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xA117;
                    goto case 0xA117;
                case 0xA117:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xA0D4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA0D4; }
                    PC = 0xA119; goto case 0xA119;
                case 0xA119:
                    A &= _ram[0xA7]; SetZN(A); TotalCycles += 3; PC = 0xA11B;
                    goto case 0xA11B;
                case 0xA11B:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x3227]); TotalCycles += 4; PC = 0xA11E;
                    goto case 0xA11E;
                case 0xA11E:
                    _ram[0xB9] = Rol(_ram[0xB9]); TotalCycles += 5; PC = 0xA120;
                    goto case 0xA120;
                case 0xA11F:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1B26 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA122;
                    return;
                case 0xA120:
                    _ram[0x9B] = Rol(_ram[0x9B]); TotalCycles += 5; PC = 0xA122;
                    return;
                case 0xA123:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xA124;
                    return;
                case 0xA125:
                    A = _ram[(byte)(0x27 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA127;
                    goto case 0xA127;
                case 0xA127:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x3027 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xA12A;
                    return;
                case 0xA129:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xA0E6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA0E6; }
                    PC = 0xA12B; return;
                case 0xA12F:
                    { int a = 0x6B25; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA132;
                    return;
                case 0xA130:
                    A &= _ram[0x6B]; SetZN(A); TotalCycles += 3; PC = 0xA132;
                    return;
                case 0xA133:
                    { int a = 0x0AA5 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA136;
                    goto case 0xA136;
                case 0xA134:
                    A = _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0xA136;
                    goto case 0xA136;
                case 0xA135:
                    A = Asl(A); TotalCycles += 2; PC = 0xA136;
                    goto case 0xA136;
                case 0xA136:
                    { int a = 0x2728; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA139;
                    goto case 0xA139;
                case 0xA137:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xA138;
                    return;
                case 0xA139:
                    { int a = 0xC733; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA13C;
                    return;
                case 0xA13E:
                    { int a = (0x0740 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xA141;
                    goto case 0xA141;
                case 0xA13F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA141:
                    { int a = 0xE730; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA144;
                    return;
                case 0xA142:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xA12B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA144; return;
                case 0xA145:
                    A |= _ram[0x1E]; SetZN(A); TotalCycles += 3; PC = 0xA147;
                    goto case 0xA147;
                case 0xA146:
                    { int a = 0x4424 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA149;
                    return;
                case 0xA147:
                    Bit(_ram[0x44]); TotalCycles += 3; PC = 0xA149;
                    return;
                case 0xA14B:
                    { int a = 0x6A22 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA14E;
                    goto case 0xA14E;
                case 0xA14D:
                    A = Ror(A); TotalCycles += 2; PC = 0xA14E;
                    goto case 0xA14E;
                case 0xA14E:
                    { int a = 0xAB23; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA151;
                    return;
                case 0xA152:
                    A |= 0x1E; SetZN(A); TotalCycles += 2; PC = 0xA154;
                    goto case 0xA154;
                case 0xA153:
                    { int a = 0x6841 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA156;
                    goto case 0xA156;
                case 0xA154:
                    A ^= ReadMem(ReadU16Zp((byte)(0x68 + X))); SetZN(A); TotalCycles += 6; PC = 0xA156;
                    goto case 0xA156;
                case 0xA155:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xA156;
                    goto case 0xA156;
                case 0xA156:
                    { int a = 0x8A2A + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA159;
                    goto case 0xA159;
                case 0xA157:
                    A = Rol(A); TotalCycles += 2; PC = 0xA158;
                    goto case 0xA158;
                case 0xA158:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA159;
                    goto case 0xA159;
                case 0xA159:
                    { int a = 0xA223; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA15C;
                    goto case 0xA15C;
                case 0xA15B:
                    X = 0x2E; SetZN(X); TotalCycles += 2; PC = 0xA15D;
                    return;
                case 0xA15C:
                    { int a = 0xEA32; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA15F;
                    return;
                case 0xA15E:
                     TotalCycles += 2; PC = 0xA15F;
                    return;
                case 0xA162:
                    _ram[0x27] = Ror(_ram[0x27]); TotalCycles += 5; PC = 0xA164;
                    goto case 0xA164;
                case 0xA164:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x6E27]); TotalCycles += 4; PC = 0xA167;
                    goto case 0xA167;
                case 0xA166:
                    { int a = 0x8731; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA169;
                    goto case 0xA169;
                case 0xA167:
                    A &= ReadMem(ReadU16Zp(0x87) + Y); SetZN(A); TotalCycles += 5; PC = 0xA169;
                    goto case 0xA169;
                case 0xA169:
                    { int a = 0xA723; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA16C;
                    return;
                case 0xA172:
                    A |= ReadMem(ReadU16Zp((byte)(0x2E + X))); SetZN(A); TotalCycles += 6; PC = 0xA174;
                    goto case 0xA174;
                case 0xA173:
                    { int a = 0x2B25; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA176;
                    goto case 0xA176;
                case 0xA174:
                    A &= _ram[0x2B]; SetZN(A); TotalCycles += 3; PC = 0xA176;
                    goto case 0xA176;
                case 0xA176:
                    { int a = 0x4B25; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA179;
                    goto case 0xA179;
                case 0xA177:
                    A &= _ram[0x4B]; SetZN(A); TotalCycles += 3; PC = 0xA179;
                    goto case 0xA179;
                case 0xA179:
                    { int a = 0xCB25; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA17C;
                    return;
                case 0xA17A:
                    A &= _ram[0xCB]; SetZN(A); TotalCycles += 3; PC = 0xA17C;
                    return;
                case 0xA180:
                    Sbc(0x87); TotalCycles += 2; PC = 0xA182;
                    return;
                case 0xA186:
                    { byte z = (byte)(0xC7 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xA188;
                    goto case 0xA188;
                case 0xA188:
                    P |= FlagI; TotalCycles += 2; PC = 0xA189;
                    return;
                case 0xA18A:
                    P |= FlagC; TotalCycles += 2; PC = 0xA18B;
                    return;
                case 0xA193:
                    A |= 0x68; SetZN(A); TotalCycles += 2; PC = 0xA195;
                    return;
                case 0xA194:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xA195;
                    return;
                case 0xA1A0:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x1B86 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA1A3;
                    return;
                case 0xA1A1:
                    _ram[0x9B] = X; TotalCycles += 3; PC = 0xA1A3;
                    return;
                case 0xA1A5:
                    { byte z = (byte)(0x07 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xA1A7;
                    goto case 0xA1A7;
                case 0xA1A7:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xA1A8;
                    return;
                case 0xA1AA:
                    WriteMem(0x652E + X, A); TotalCycles += 5; PC = 0xA1AD;
                    goto case 0xA1AD;
                case 0xA1AB:
                    { int a = 0xF065; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA1AE;
                    return;
                case 0xA1AC:
                    Adc(_ram[0xF0]); TotalCycles += 3; PC = 0xA1AE;
                    return;
                case 0xA1AD:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xA1AE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA1AF; return;
                case 0xA1B1:
                    A |= _ram[0x32]; SetZN(A); TotalCycles += 3; PC = 0xA1B3;
                    goto case 0xA1B3;
                case 0xA1B3:
                    _ram[0x33] = Asl(_ram[0x33]); TotalCycles += 5; PC = 0xA1B5;
                    return;
                case 0xA1B7:
                    { int a = 0xDC03; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA1BA;
                    goto case 0xA1BA;
                case 0xA1BA:
                    A ^= ReadMem(ReadU16Zp(0xEE) + Y); SetZN(A); TotalCycles += 5; PC = 0xA1BC;
                    return;
                case 0xA1BB:
                    { int a = 0x7307; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA1BE;
                    goto case 0xA1BE;
                case 0xA1BE:
                    Cmp(X, 0x74); TotalCycles += 2; PC = 0xA1C0;
                    goto case 0xA1C0;
                case 0xA1C0:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1C1;
                    goto case 0xA1C1;
                case 0xA1C1:
                    { int a = 0x9E06 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA1C4;
                    goto case 0xA1C4;
                case 0xA1C2:
                    _ram[0x9E] = Asl(_ram[0x9E]); TotalCycles += 5; PC = 0xA1C4;
                    goto case 0xA1C4;
                case 0xA1C4:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1C5;
                    goto case 0xA1C5;
                case 0xA1C5:
                    { int a = 0xE406; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA1C8;
                    goto case 0xA1C8;
                case 0xA1C6:
                    _ram[0xE4] = Asl(_ram[0xE4]); TotalCycles += 5; PC = 0xA1C8;
                    goto case 0xA1C8;
                case 0xA1C7:
                    Cmp(X, _ram[0x00]); TotalCycles += 3; PC = 0xA1C9;
                    goto case 0xA1C9;
                case 0xA1C8:
                    TotalCycles += 7; PushU16(0xA1CA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA1C9:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xA1CA;
                    goto case 0xA1CA;
                case 0xA1CA:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1CB;
                    goto case 0xA1CB;
                case 0xA1CB:
                    { int a = 0x2E0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA1CE;
                    return;
                case 0xA1CC:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1CD;
                    goto case 0xA1CD;
                case 0xA1CD:
                    { int a = 0x4E89; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA1D0;
                    return;
                case 0xA1CF:
                    { int a = 0x540B; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA1D2;
                    goto case 0xA1D2;
                case 0xA1D2:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1D3;
                    return;
                case 0xA1D4:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA1D5;
                    goto case 0xA1D5;
                case 0xA1D5:
                    Cmp(Y, _ram[0x0A]); TotalCycles += 3; PC = 0xA1D7;
                    return;
                case 0xA1D6:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1D7;
                    return;
                case 0xA1D8:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA1D9;
                    goto case 0xA1D9;
                case 0xA1D9:
                    { int a = 0xC706 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA1DC;
                    goto case 0xA1DC;
                case 0xA1DA:
                    _ram[0xC7] = Asl(_ram[0xC7]); TotalCycles += 5; PC = 0xA1DC;
                    goto case 0xA1DC;
                case 0xA1DC:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1DD;
                    goto case 0xA1DD;
                case 0xA1DD:
                    A |= ReadMem(ReadU16Zp((byte)(0xE0 + X))); SetZN(A); TotalCycles += 6; PC = 0xA1DF;
                    return;
                case 0xA1DE:
                    Cmp(X, 0x02); TotalCycles += 2; PC = 0xA1E0;
                    goto case 0xA1E0;
                case 0xA1E0:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1E1;
                    return;
                case 0xA1E2:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1E3;
                    goto case 0xA1E3;
                case 0xA1E3:
                    WriteMem(ReadU16Zp((byte)(0x60 + X)), A); TotalCycles += 6; PC = 0xA1E5;
                    return;
                case 0xA1E4:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA1E6:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1E7;
                    return;
                case 0xA1E8:
                    A = Asl(A); TotalCycles += 2; PC = 0xA1E9;
                    goto case 0xA1E9;
                case 0xA1E9:
                    { int a = 0x7E87; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA1EC;
                    return;
                case 0xA1EB:
                    { int a = 0xA702 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA1EE;
                    return;
                case 0xA1F9:
                    { int a = 0x7E06 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xA1FC;
                    return;
                case 0xA1FA:
                    _ram[0x7E] = Asl(_ram[0x7E]); TotalCycles += 5; PC = 0xA1FC;
                    return;
                case 0xA1FB:
                    { int a = 0xAE02 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA1FE;
                    return;
                case 0xA1FD:
                    X = SmbEmbeddedAssets.StaticDataTables[0x7E07]; SetZN(X); TotalCycles += 4; PC = 0xA200;
                    goto case 0xA200;
                case 0xA1FF:
                    { int a = 0x0D0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA202;
                    goto case 0xA202;
                case 0xA200:
                    A = Asl(A); TotalCycles += 2; PC = 0xA201;
                    goto case 0xA201;
                case 0xA201:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x4DC4]; SetZN(A); TotalCycles += 4; PC = 0xA204;
                    return;
                case 0xA202:
                    Cmp(Y, _ram[0xCD]); TotalCycles += 3; PC = 0xA204;
                    return;
                case 0xA203:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x4E43]); TotalCycles += 4; PC = 0xA206;
                    goto case 0xA206;
                case 0xA205:
                    { int a = 0xDE09; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA208;
                    return;
                case 0xA206:
                    A |= 0xDE; SetZN(A); TotalCycles += 2; PC = 0xA208;
                    return;
                case 0xA207:
                    { int a = 0xDD0B + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA20A;
                    return;
                case 0xA209:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7E42 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA20C;
                    return;
                case 0xA20B:
                    { int a = 0x5D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA20E;
                    return;
                case 0xA20D:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x7DC7 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA210;
                    return;
                case 0xA20F:
                    Sbc(_ram[(0x075B + X) & 0x07FF]); TotalCycles += 4; PC = 0xA212;
                    goto case 0xA212;
                case 0xA212:
                    A |= _ram[0x32]; SetZN(A); TotalCycles += 3; PC = 0xA214;
                    goto case 0xA214;
                case 0xA214:
                    _ram[0x33] = Asl(_ram[0x33]); TotalCycles += 5; PC = 0xA216;
                    return;
                case 0xA218:
                    { int a = 0x680A + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA21B;
                    return;
                case 0xA219:
                    A = Asl(A); TotalCycles += 2; PC = 0xA21A;
                    goto case 0xA21A;
                case 0xA21A:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xA21B;
                    return;
                case 0xA21C:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xA21D;
                    return;
                case 0xA21E:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xA21F;
                    return;
                case 0xA220:
                    { int a = 0xFE06; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA223;
                    return;
                case 0xA221:
                    _ram[0xFE] = Asl(_ram[0xFE]); TotalCycles += 5; PC = 0xA223;
                    return;
                case 0xA222:
                    { int a = 0x0D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA225;
                    goto case 0xA225;
                case 0xA224:
                    A |= _ram[0x0601]; SetZN(A); TotalCycles += 4; PC = 0xA227;
                    goto case 0xA227;
                case 0xA225:
                    A |= ReadMem(ReadU16Zp((byte)(0x1E + X))); SetZN(A); TotalCycles += 6; PC = 0xA227;
                    goto case 0xA227;
                case 0xA226:
                    { int a = 0x7E0E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA229;
                    return;
                case 0xA227:
                    _ram[0x027E] = Asl(_ram[0x027E]); TotalCycles += 6; PC = 0xA22A;
                    goto case 0xA22A;
                case 0xA228:
                    { int a = 0x9402 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA22B;
                    return;
                case 0xA22A:
                    _ram[(byte)(0x63 + X)] = Y; TotalCycles += 4; PC = 0xA22C;
                    goto case 0xA22C;
                case 0xA22C:
                    Y = _ram[(byte)(0x63 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xA22E;
                    return;
                case 0xA234:
                    { int a = 0x5E0E; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA237;
                    return;
                case 0xA235:
                    _ram[0x025E] = Asl(_ram[0x025E]); TotalCycles += 6; PC = 0xA238;
                    return;
                case 0xA236:
                    { int a = 0x6402 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA239;
                    goto case 0xA239;
                case 0xA239:
                    A &= _ram[(byte)(0x88 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA23B;
                    return;
                case 0xA23A:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xA23B;
                    return;
                case 0xA23C:
                    X = ReadMem(0x0D0E + Y); SetZN(X); TotalCycles += 4; PC = 0xA23F;
                    return;
                case 0xA23D:
                    _ram[0x040D] = Asl(_ram[0x040D]); TotalCycles += 6; PC = 0xA240;
                    goto case 0xA240;
                case 0xA23E:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x2E04]; SetZN(A); TotalCycles += 4; PC = 0xA241;
                    return;
                case 0xA240:
                    X = SmbEmbeddedAssets.StaticDataTables[0x4E02]; SetZN(X); TotalCycles += 4; PC = 0xA243;
                    goto case 0xA243;
                case 0xA242:
                    { int a = 0xCD08; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA245;
                    return;
                case 0xA243:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA244;
                    goto case 0xA244;
                case 0xA244:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x7E4B]); TotalCycles += 4; PC = 0xA247;
                    return;
                case 0xA246:
                    { int a = 0x0D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA249;
                    goto case 0xA249;
                case 0xA248:
                    A |= ReadIoReg(0x6805); SetZN(A); TotalCycles += 4; PC = 0xA24B;
                    goto case 0xA24B;
                case 0xA249:
                    A |= _ram[0x68]; SetZN(A); TotalCycles += 3; PC = 0xA24B;
                    goto case 0xA24B;
                case 0xA24A:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xA24B;
                    goto case 0xA24B;
                case 0xA24B:
                    A &= ReadMem(ReadU16Zp(0x7E) + Y); SetZN(A); TotalCycles += 5; PC = 0xA24D;
                    goto case 0xA24D;
                case 0xA24C:
                    { int a = 0x960A + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA24F;
                    goto case 0xA24F;
                case 0xA24D:
                    A = Asl(A); TotalCycles += 2; PC = 0xA24E;
                    goto case 0xA24E;
                case 0xA24E:
                    _ram[(byte)(0x31 + Y)] = X; TotalCycles += 4; PC = 0xA250;
                    goto case 0xA250;
                case 0xA24F:
                    A &= ReadMem(ReadU16Zp(0xA9) + Y); SetZN(A); TotalCycles += 5; PC = 0xA251;
                    return;
                case 0xA250:
                    A = 0x63; SetZN(A); TotalCycles += 2; PC = 0xA252;
                    goto case 0xA252;
                case 0xA252:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xA253;
                    return;
                case 0xA254:
                    Cmp(A, _ram[(byte)(0x30 + X)]); TotalCycles += 4; PC = 0xA256;
                    goto case 0xA256;
                case 0xA255:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xA245; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA257; return;
                case 0xA256:
                    { int a = 0xE602; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA259;
                    return;
                case 0xA258:
                    _ram[0x62] = IncVal(_ram[0x62]); TotalCycles += 5; PC = 0xA25A;
                    return;
                case 0xA25B:
                    Adc(ReadMem(ReadU16Zp((byte)(0x04 + X)))); TotalCycles += 6; PC = 0xA25D;
                    goto case 0xA25D;
                case 0xA25D:
                    A = ReadMem(ReadU16Zp(0x08) + Y); SetZN(A); TotalCycles += 5; PC = 0xA25F;
                    return;
                case 0xA25E:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA25F;
                    return;
                case 0xA262:
                    _ram[(byte)(0x63 + X)] = Y; TotalCycles += 4; PC = 0xA264;
                    goto case 0xA264;
                case 0xA264:
                    Y = _ram[0x31]; SetZN(Y); TotalCycles += 3; PC = 0xA266;
                    goto case 0xA266;
                case 0xA265:
                    A &= ReadMem(ReadU16Zp(0xE4) + Y); SetZN(A); TotalCycles += 5; PC = 0xA267;
                    goto case 0xA267;
                case 0xA266:
                    Cmp(X, _ram[0x31]); TotalCycles += 3; PC = 0xA268;
                    return;
                case 0xA267:
                    A &= ReadMem(ReadU16Zp(0x04) + Y); SetZN(A); TotalCycles += 5; PC = 0xA269;
                    return;
                case 0xA26A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA26B;
                    return;
                case 0xA26E:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA26F;
                    return;
                case 0xA270:
                    Cmp(A, _ram[0x034B]); TotalCycles += 4; PC = 0xA273;
                    goto case 0xA273;
                case 0xA273:
                    Cmp(X, _ram[0x0E]); TotalCycles += 3; PC = 0xA275;
                    return;
                case 0xA274:
                    { int a = 0x2E03; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA277;
                    goto case 0xA277;
                case 0xA276:
                    { int a = 0x7E01; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA279;
                    goto case 0xA279;
                case 0xA277:
                    A |= ReadMem(ReadU16Zp((byte)(0x7E + X))); SetZN(A); TotalCycles += 6; PC = 0xA279;
                    goto case 0xA279;
                case 0xA278:
                    { int a = 0xBE06 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA27B;
                    return;
                case 0xA279:
                    _ram[0xBE] = Asl(_ram[0xBE]); TotalCycles += 5; PC = 0xA27B;
                    return;
                case 0xA27A:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x5E02 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xA27D;
                    goto case 0xA27D;
                case 0xA27C:
                    { int a = 0xFE06 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA27F;
                    goto case 0xA27F;
                case 0xA27D:
                    _ram[0xFE] = Asl(_ram[0xFE]); TotalCycles += 5; PC = 0xA27F;
                    goto case 0xA27F;
                case 0xA27E:
                    { int a = 0x0D0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA281;
                    goto case 0xA281;
                case 0xA27F:
                    A = Asl(A); TotalCycles += 2; PC = 0xA280;
                    goto case 0xA280;
                case 0xA280:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x4DC4]; SetZN(A); TotalCycles += 4; PC = 0xA283;
                    return;
                case 0xA281:
                    Cmp(Y, _ram[0xCD]); TotalCycles += 3; PC = 0xA283;
                    return;
                case 0xA282:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x4E43]); TotalCycles += 4; PC = 0xA285;
                    goto case 0xA285;
                case 0xA284:
                    { int a = 0xDE09; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA287;
                    return;
                case 0xA285:
                    A |= 0xDE; SetZN(A); TotalCycles += 2; PC = 0xA287;
                    return;
                case 0xA286:
                    { int a = 0xDD0B + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA289;
                    return;
                case 0xA288:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7E42 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA28B;
                    return;
                case 0xA28A:
                    { int a = 0x5D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA28D;
                    return;
                case 0xA28C:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x7DC7 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA28F;
                    return;
                case 0xA28E:
                    Sbc(_ram[(0x079B + X) & 0x07FF]); TotalCycles += 4; PC = 0xA291;
                    goto case 0xA291;
                case 0xA291:
                    A |= _ram[0x32]; SetZN(A); TotalCycles += 3; PC = 0xA293;
                    goto case 0xA293;
                case 0xA293:
                    _ram[0x33] = Asl(_ram[0x33]); TotalCycles += 5; PC = 0xA295;
                    return;
                case 0xA297:
                    { int a = 0x2700 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA29A;
                    goto case 0xA29A;
                case 0xA298:
                    TotalCycles += 7; PushU16(0xA29A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA29A:
                    A = ReadMem(ReadU16Zp(0x65) + Y); SetZN(A); TotalCycles += 5; PC = 0xA29C;
                    return;
                case 0xA29B:
                    Adc(_ram[0x32]); TotalCycles += 3; PC = 0xA29D;
                    goto case 0xA29D;
                case 0xA29D:
                    Adc(_ram[(byte)(0x0A + X)]); TotalCycles += 4; PC = 0xA29F;
                    goto case 0xA29F;
                case 0xA29E:
                    A = Asl(A); TotalCycles += 2; PC = 0xA29F;
                    goto case 0xA29F;
                case 0xA29F:
                    Adc(ReadMem(ReadU16Zp(0x00) + Y)); TotalCycles += 5; PC = 0xA2A1;
                    return;
                case 0xA2A0:
                    TotalCycles += 7; PushU16(0xA2A2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA2A2:
                    A &= ReadMem(ReadU16Zp(0x08) + Y); SetZN(A); TotalCycles += 5; PC = 0xA2A4;
                    goto case 0xA2A4;
                case 0xA2A3:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA2A4;
                    goto case 0xA2A4;
                case 0xA2A4:
                    Cmp(X, _ram[0x18]); TotalCycles += 3; PC = 0xA2A6;
                    return;
                case 0xA2A5:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xA2A6;
                    return;
                case 0xA2A7:
                    { int a = 0x5704 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA2AA;
                    return;
                case 0xA2AC:
                    A = Asl(A); TotalCycles += 2; PC = 0xA2AD;
                    return;
                case 0xA2AE:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA2AF;
                    return;
                case 0xA2B2:
                    A = Asl(A); TotalCycles += 2; PC = 0xA2B3;
                    return;
                case 0xA2B4:
                    A = Asl(A); TotalCycles += 2; PC = 0xA2B5;
                    return;
                case 0xA2B6:
                    A = Asl(A); TotalCycles += 2; PC = 0xA2B7;
                    return;
                case 0xA2BA:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA2BB;
                    return;
                case 0xA2BC:
                    A = Asl(A); TotalCycles += 2; PC = 0xA2BD;
                    goto case 0xA2BD;
                case 0xA2BD:
                    { int a = 0x2408 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA2C0;
                    goto case 0xA2C0;
                case 0xA2BE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA2BF;
                    goto case 0xA2BF;
                case 0xA2BF:
                    Bit(_ram[0x8A]); TotalCycles += 3; PC = 0xA2C1;
                    goto case 0xA2C1;
                case 0xA2C0:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA2C1;
                    goto case 0xA2C1;
                case 0xA2C1:
                    { int a = 0x3E00; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA2C4;
                    goto case 0xA2C4;
                case 0xA2C2:
                    TotalCycles += 7; PushU16(0xA2C4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA2C3:
                    { int a = 0x3840 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xA2C6;
                    return;
                case 0xA2C4:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA2C5:
                    P |= FlagC; TotalCycles += 2; PC = 0xA2C6;
                    return;
                case 0xA2C8:
                    TotalCycles += 7; PushU16(0xA2CA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA2CA:
                    TotalCycles += 7; PushU16(0xA2CC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA2CB:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x4843 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xA2CE;
                    goto case 0xA2CE;
                case 0xA2CD:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xA2CE;
                    goto case 0xA2CE;
                case 0xA2CE:
                    A = Asl(A); TotalCycles += 2; PC = 0xA2CF;
                    goto case 0xA2CF;
                case 0xA2CF:
                    Cmp(A, 0x63); TotalCycles += 2; PC = 0xA2D1;
                    goto case 0xA2D1;
                case 0xA2D1:
                    { int a = 0xFE07; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA2D4;
                    return;
                case 0xA2D3:
                    { int a = 0x2E07 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA2D6;
                    goto case 0xA2D6;
                case 0xA2D5:
                    { int a = 0x6681; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA2D8;
                    return;
                case 0xA2D6:
                    WriteMem(ReadU16Zp((byte)(0x66 + X)), A); TotalCycles += 6; PC = 0xA2D8;
                    return;
                case 0xA2D7:
                    _ram[0x42] = Ror(_ram[0x42]); TotalCycles += 5; PC = 0xA2D9;
                    goto case 0xA2D9;
                case 0xA2D9:
                    A = Ror(A); TotalCycles += 2; PC = 0xA2DA;
                    return;
                case 0xA2DB:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x3E0A + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xA2DE;
                    goto case 0xA2DE;
                case 0xA2DC:
                    A = Asl(A); TotalCycles += 2; PC = 0xA2DD;
                    goto case 0xA2DD;
                case 0xA2DD:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x4800 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xA2E0;
                    return;
                case 0xA2DE:
                    TotalCycles += 7; PushU16(0xA2E0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA2DF:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xA2E0;
                    return;
                case 0xA2E1:
                    P |= FlagD; TotalCycles += 2; PC = 0xA2E2;
                    return;
                case 0xA2E3:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA2E4;
                    goto case 0xA2E4;
                case 0xA2E4:
                    Cmp(X, _ram[0x2E]); TotalCycles += 3; PC = 0xA2E6;
                    return;
                case 0xA2E5:
                    { int a = 0x7E07; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA2E8;
                    return;
                case 0xA2E7:
                    { int a = 0x9E03 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA2EA;
                    return;
                case 0xA2EB:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x5E03 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xA2EE;
                    return;
                case 0xA2ED:
                    { int a = 0xFE07 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA2F0;
                    goto case 0xA2F0;
                case 0xA2EF:
                    { int a = (0x030A + X) & 0x07FF; _ram[a] = IncVal(_ram[a]); } TotalCycles += 7; PC = 0xA2F2;
                    goto case 0xA2F2;
                case 0xA2F0:
                    A = Asl(A); TotalCycles += 2; PC = 0xA2F1;
                    return;
                case 0xA2F2:
                    A = _ram[0x0D]; SetZN(A); TotalCycles += 3; PC = 0xA2F4;
                    return;
                case 0xA2F3:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x4D44]; SetZN(A); TotalCycles += 4; PC = 0xA2F6;
                    return;
                case 0xA2F5:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x4E43]); TotalCycles += 4; PC = 0xA2F8;
                    goto case 0xA2F8;
                case 0xA2F7:
                    { int a = 0xDD09; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA2FA;
                    return;
                case 0xA2F8:
                    A |= 0xDD; SetZN(A); TotalCycles += 2; PC = 0xA2FA;
                    return;
                case 0xA2F9:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x5E42 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA2FC;
                    return;
                case 0xA2FB:
                    { int a = 0xFE0B + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA2FE;
                    return;
                case 0xA2FD:
                    { int a = 0x5D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA300;
                    return;
                case 0xA2FF:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x7DC7 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA302;
                    return;
                case 0xA301:
                    Sbc(_ram[(0x079B + X) & 0x07FF]); TotalCycles += 4; PC = 0xA304;
                    goto case 0xA304;
                case 0xA304:
                    A |= _ram[0x32]; SetZN(A); TotalCycles += 3; PC = 0xA306;
                    goto case 0xA306;
                case 0xA306:
                    _ram[0x33] = Asl(_ram[0x33]); TotalCycles += 5; PC = 0xA308;
                    return;
                case 0xA30A:
                    { int a = 0x0C06 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA30D;
                    goto case 0xA30D;
                case 0xA30B:
                    _ram[0x0C] = Asl(_ram[0x0C]); TotalCycles += 5; PC = 0xA30D;
                    goto case 0xA30D;
                case 0xA30D:
                    WriteMem(ReadU16Zp((byte)(0x39 + X)), A); TotalCycles += 6; PC = 0xA30F;
                    goto case 0xA30F;
                case 0xA30E:
                    A &= ReadMem(0x5C0A + Y); SetZN(A); TotalCycles += 4; PC = 0xA311;
                    goto case 0xA311;
                case 0xA30F:
                    A = Asl(A); TotalCycles += 2; PC = 0xA310;
                    return;
                case 0xA311:
                    A |= ReadMem(ReadU16Zp((byte)(0x89 + X))); SetZN(A); TotalCycles += 6; PC = 0xA313;
                    goto case 0xA313;
                case 0xA313:
                    A = Asl(A); TotalCycles += 2; PC = 0xA314;
                    goto case 0xA314;
                case 0xA314:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x5901]; SetZN(Y); TotalCycles += 4; PC = 0xA317;
                    goto case 0xA317;
                case 0xA315:
                    A |= ReadMem(ReadU16Zp((byte)(0xD9 + X))); SetZN(A); TotalCycles += 6; PC = 0xA317;
                    goto case 0xA317;
                case 0xA316:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7C0A + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xA319;
                    goto case 0xA319;
                case 0xA317:
                    A = Asl(A); TotalCycles += 2; PC = 0xA318;
                    return;
                case 0xA319:
                    A |= ReadMem(ReadU16Zp((byte)(0x2E + X))); SetZN(A); TotalCycles += 6; PC = 0xA31B;
                    return;
                case 0xA31A:
                    { int a = 0xA783; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA31D;
                    goto case 0xA31D;
                case 0xA31D:
                    A |= ReadMem(ReadU16Zp((byte)(0xB7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA31F;
                    goto case 0xA31F;
                case 0xA31F:
                    TotalCycles += 7; PushU16(0xA321); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA321:
                    A |= ReadMem(ReadU16Zp((byte)(0xDE + X))); SetZN(A); TotalCycles += 6; PC = 0xA323;
                    goto case 0xA323;
                case 0xA322:
                    { int a = 0xFE0A + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA325;
                    return;
                case 0xA323:
                    A = Asl(A); TotalCycles += 2; PC = 0xA324;
                    goto case 0xA324;
                case 0xA324:
                    { int a = 0x4E02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA327;
                    return;
                case 0xA326:
                    { int a = 0x5A83; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA329;
                    return;
                case 0xA32B:
                    A = Asl(A); TotalCycles += 2; PC = 0xA32C;
                    goto case 0xA32C;
                case 0xA32C:
                    Adc(0x0A); TotalCycles += 2; PC = 0xA32E;
                    goto case 0xA32E;
                case 0xA32D:
                    A = Asl(A); TotalCycles += 2; PC = 0xA32E;
                    goto case 0xA32E;
                case 0xA32E:
                    { int a = 0xEE02 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA331;
                    return;
                case 0xA330:
                    { int a = 0xFA03; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA333;
                    return;
                case 0xA335:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA336;
                    goto case 0xA336;
                case 0xA336:
                    A |= 0x0A; SetZN(A); TotalCycles += 2; PC = 0xA338;
                    goto case 0xA338;
                case 0xA337:
                    A = Asl(A); TotalCycles += 2; PC = 0xA338;
                    goto case 0xA338;
                case 0xA338:
                    { int a = 0xEE02 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA33B;
                    return;
                case 0xA33A:
                    { int a = 0xFA03; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA33D;
                    return;
                case 0xA33F:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA340;
                    goto case 0xA340;
                case 0xA340:
                    A |= 0x0A; SetZN(A); TotalCycles += 2; PC = 0xA342;
                    return;
                case 0xA341:
                    A = Asl(A); TotalCycles += 2; PC = 0xA342;
                    return;
                case 0xA344:
                    { int a = 0x7E02 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA347;
                    goto case 0xA347;
                case 0xA346:
                    { int a = 0x9E0A + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA349;
                    return;
                case 0xA347:
                    A = Asl(A); TotalCycles += 2; PC = 0xA348;
                    return;
                case 0xA34A:
                    { int a = 0x2E0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA34D;
                    goto case 0xA34D;
                case 0xA34B:
                    A = Asl(A); TotalCycles += 2; PC = 0xA34C;
                    goto case 0xA34C;
                case 0xA34C:
                    { int a = 0x5E86; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA34F;
                    goto case 0xA34F;
                case 0xA34D:
                    _ram[0x5E] = X; TotalCycles += 3; PC = 0xA34F;
                    goto case 0xA34F;
                case 0xA34E:
                    { int a = 0x8E0A + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA351;
                    goto case 0xA351;
                case 0xA34F:
                    A = Asl(A); TotalCycles += 2; PC = 0xA350;
                    goto case 0xA350;
                case 0xA350:
                    WriteIoReg(0xBE06, X); TotalCycles += 4; PC = 0xA353;
                    goto case 0xA353;
                case 0xA351:
                    _ram[0xBE] = Asl(_ram[0xBE]); TotalCycles += 5; PC = 0xA353;
                    goto case 0xA353;
                case 0xA352:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x6E0A + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xA355;
                    return;
                case 0xA353:
                    A = Asl(A); TotalCycles += 2; PC = 0xA354;
                    goto case 0xA354;
                case 0xA354:
                    { int a = 0x3E07; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA357;
                    return;
                case 0xA356:
                    { int a = 0x5E83 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xA359;
                    return;
                case 0xA358:
                    { int a = 0xFE07 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA35B;
                    goto case 0xA35B;
                case 0xA35A:
                    { int a = 0x0D0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA35D;
                    goto case 0xA35D;
                case 0xA35B:
                    A = Asl(A); TotalCycles += 2; PC = 0xA35C;
                    goto case 0xA35C;
                case 0xA35C:
                    A |= ReadIoReg(0x41C4); SetZN(A); TotalCycles += 4; PC = 0xA35F;
                    return;
                case 0xA35D:
                    Cmp(Y, _ram[0x41]); TotalCycles += 3; PC = 0xA35F;
                    return;
                case 0xA35E:
                    A ^= ReadMem(ReadU16Zp((byte)(0x52 + X))); SetZN(A); TotalCycles += 6; PC = 0xA360;
                    goto case 0xA360;
                case 0xA360:
                    A ^= ReadMem(ReadU16Zp(0x52) + Y); SetZN(A); TotalCycles += 5; PC = 0xA362;
                    goto case 0xA362;
                case 0xA362:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x4E43]); TotalCycles += 4; PC = 0xA365;
                    goto case 0xA365;
                case 0xA364:
                    { int a = 0xDE09; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA367;
                    return;
                case 0xA365:
                    A |= 0xDE; SetZN(A); TotalCycles += 2; PC = 0xA367;
                    return;
                case 0xA366:
                    { int a = 0xDD0B + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA369;
                    return;
                case 0xA368:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7E42 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA36B;
                    return;
                case 0xA36A:
                    { int a = 0x5D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA36D;
                    return;
                case 0xA36C:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x7DC7 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA36F;
                    return;
                case 0xA36E:
                    Sbc(_ram[(0x075B + X) & 0x07FF]); TotalCycles += 4; PC = 0xA371;
                    goto case 0xA371;
                case 0xA371:
                    A |= _ram[0x32]; SetZN(A); TotalCycles += 3; PC = 0xA373;
                    goto case 0xA373;
                case 0xA373:
                    _ram[0x33] = Asl(_ram[0x33]); TotalCycles += 5; PC = 0xA375;
                    return;
                case 0xA377:
                    { int a = 0xAE0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA37A;
                    goto case 0xA37A;
                case 0xA378:
                    A = Asl(A); TotalCycles += 2; PC = 0xA379;
                    goto case 0xA379;
                case 0xA379:
                    X = SmbEmbeddedAssets.StaticDataTables[0x3E86]; SetZN(X); TotalCycles += 4; PC = 0xA37C;
                    return;
                case 0xA37A:
                    _ram[0xBE] = X; TotalCycles += 3; PC = 0xA37C;
                    return;
                case 0xA37B:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x7E07 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xA37E;
                    return;
                case 0xA37D:
                    { int a = 0x0D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA380;
                    return;
                case 0xA37F:
                    A |= ReadIoReg(0x2702); SetZN(A); TotalCycles += 4; PC = 0xA382;
                    return;
                case 0xA383:
                    _ram[0x61] = Lsr(_ram[0x61]); TotalCycles += 5; PC = 0xA385;
                    goto case 0xA385;
                case 0xA384:
                    Adc(ReadMem(ReadU16Zp((byte)(0x55 + X)))); TotalCycles += 6; PC = 0xA386;
                    return;
                case 0xA385:
                    A ^= _ram[(byte)(0x62 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA387;
                    goto case 0xA387;
                case 0xA387:
                    { int a = 0x1E0E + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA38A;
                    return;
                case 0xA388:
                    { int a = 0x821E; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA38B;
                    goto case 0xA38B;
                case 0xA389:
                    { int a = 0x6882 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA38C;
                    return;
                case 0xA38B:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xA38C;
                    return;
                case 0xA38F:
                    Adc(ReadMem(0x5E4B + X)); TotalCycles += 4; PC = 0xA392;
                    goto case 0xA392;
                case 0xA391:
                    { int a = 0x7D8E + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA394;
                    return;
                case 0xA392:
                    WriteIoReg(0x4B7D, X); TotalCycles += 4; PC = 0xA395;
                    goto case 0xA395;
                case 0xA393:
                    Adc(ReadMem(0x7E4B + X)); TotalCycles += 4; PC = 0xA396;
                    return;
                case 0xA395:
                    { int a = 0x8482 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA398;
                    return;
                case 0xA397:
                    _ram[0x62] = Y; TotalCycles += 3; PC = 0xA399;
                    goto case 0xA399;
                case 0xA399:
                    _ram[(byte)(0x61 + X)] = Y; TotalCycles += 4; PC = 0xA39B;
                    goto case 0xA39B;
                case 0xA39A:
                    Adc(ReadMem(ReadU16Zp((byte)(0xA4 + X)))); TotalCycles += 6; PC = 0xA39C;
                    goto case 0xA39C;
                case 0xA39B:
                    Y = _ram[0x31]; SetZN(Y); TotalCycles += 3; PC = 0xA39D;
                    goto case 0xA39D;
                case 0xA39C:
                    A &= ReadMem(ReadU16Zp(0xBD) + Y); SetZN(A); TotalCycles += 5; PC = 0xA39E;
                    return;
                case 0xA39D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x4E4B + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA3A0;
                    goto case 0xA3A0;
                case 0xA39F:
                    { int a = 0xFE06; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA3A2;
                    return;
                case 0xA3A0:
                    _ram[0xFE] = Asl(_ram[0xFE]); TotalCycles += 5; PC = 0xA3A2;
                    return;
                case 0xA3A1:
                    { int a = 0x0D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA3A4;
                    goto case 0xA3A4;
                case 0xA3A3:
                    A |= ReadIoReg(0x3406); SetZN(A); TotalCycles += 4; PC = 0xA3A6;
                    goto case 0xA3A6;
                case 0xA3A4:
                    _ram[0x34] = Asl(_ram[0x34]); TotalCycles += 5; PC = 0xA3A6;
                    goto case 0xA3A6;
                case 0xA3A6:
                    A &= ReadMem(ReadU16Zp(0x3E) + Y); SetZN(A); TotalCycles += 5; PC = 0xA3A8;
                    goto case 0xA3A8;
                case 0xA3A7:
                    { int a = 0x640A + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xA3AA;
                    return;
                case 0xA3A8:
                    A = Asl(A); TotalCycles += 2; PC = 0xA3A9;
                    return;
                case 0xA3AB:
                    Adc(_ram[(byte)(0x0A + X)]); TotalCycles += 4; PC = 0xA3AD;
                    return;
                case 0xA3AC:
                    A = Asl(A); TotalCycles += 2; PC = 0xA3AD;
                    return;
                case 0xA3AE:
                    Adc(ReadMem(ReadU16Zp((byte)(0xA4 + X)))); TotalCycles += 6; PC = 0xA3B0;
                    return;
                case 0xA3AF:
                    Y = _ram[0x33]; SetZN(Y); TotalCycles += 3; PC = 0xA3B1;
                    goto case 0xA3B1;
                case 0xA3B1:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5E02]; SetZN(X); TotalCycles += 4; PC = 0xA3B4;
                    goto case 0xA3B4;
                case 0xA3B3:
                    { int a = 0x3E0E + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA3B6;
                    return;
                case 0xA3B4:
                    { int a = 0x823E; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA3B7;
                    return;
                case 0xA3B5:
                    { int a = 0x6482 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xA3B8;
                    return;
                case 0xA3B9:
                    P |= FlagI; TotalCycles += 2; PC = 0xA3BA;
                    return;
                case 0xA3BB:
                    Y = _ram[(byte)(0x36 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xA3BD;
                    goto case 0xA3BD;
                case 0xA3BC:
                    { byte z = (byte)(0xC8 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xA3BE;
                    goto case 0xA3BE;
                case 0xA3BD:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xA3BE;
                    goto case 0xA3BE;
                case 0xA3BE:
                    { byte z = (byte)(0xDD + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xA3C0;
                    return;
                case 0xA3BF:
                    Cmp(A, ReadMem(0x444B + X)); TotalCycles += 4; PC = 0xA3C2;
                    return;
                case 0xA3C3:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xA3C4;
                    return;
                case 0xA3C5:
                    _ram[(byte)(0x63 + X)] = Y; TotalCycles += 4; PC = 0xA3C7;
                    goto case 0xA3C7;
                case 0xA3C7:
                    Y = _ram[0x3E]; SetZN(Y); TotalCycles += 3; PC = 0xA3C9;
                    goto case 0xA3C9;
                case 0xA3C8:
                    { int a = 0x30BA + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xA3CB;
                    goto case 0xA3CB;
                case 0xA3C9:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xA3CA;
                    goto case 0xA3CA;
                case 0xA3CA:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xA395; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA395; }
                    PC = 0xA3CC; goto case 0xA3CC;
                case 0xA3CB:
                    Cmp(A, 0x61); TotalCycles += 2; PC = 0xA3CD;
                    goto case 0xA3CD;
                case 0xA3CC:
                    Adc(ReadMem(ReadU16Zp((byte)(0xCE + X)))); TotalCycles += 6; PC = 0xA3CE;
                    goto case 0xA3CE;
                case 0xA3CD:
                    { int a = 0xDD06; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA3D0;
                    return;
                case 0xA3CE:
                    _ram[0xDD] = Asl(_ram[0xDD]); TotalCycles += 5; PC = 0xA3D0;
                    return;
                case 0xA3CF:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x4E4B + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA3D2;
                    goto case 0xA3D2;
                case 0xA3D1:
                    { int a = 0xDD86; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA3D4;
                    return;
                case 0xA3D2:
                    _ram[0xDD] = X; TotalCycles += 3; PC = 0xA3D4;
                    return;
                case 0xA3D3:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7E4B + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA3D6;
                    return;
                case 0xA3D5:
                    { int a = 0x2E02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA3D8;
                    goto case 0xA3D8;
                case 0xA3D7:
                    { int a = 0x5E86; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA3DA;
                    return;
                case 0xA3D8:
                    _ram[0x5E] = X; TotalCycles += 3; PC = 0xA3DA;
                    return;
                case 0xA3D9:
                    { int a = 0x7E02 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA3DC;
                    goto case 0xA3DC;
                case 0xA3DB:
                    { int a = 0xFE06 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA3DE;
                    return;
                case 0xA3DC:
                    _ram[0xFE] = Asl(_ram[0xFE]); TotalCycles += 5; PC = 0xA3DE;
                    return;
                case 0xA3DD:
                    { int a = 0x1E02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA3E0;
                    goto case 0xA3E0;
                case 0xA3DF:
                    { int a = 0x3E86 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA3E2;
                    return;
                case 0xA3E0:
                    _ram[0x3E] = X; TotalCycles += 3; PC = 0xA3E2;
                    return;
                case 0xA3E1:
                    { int a = 0x5E02 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xA3E4;
                    goto case 0xA3E4;
                case 0xA3E3:
                    { int a = 0x7E06 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA3E6;
                    return;
                case 0xA3E4:
                    _ram[0x7E] = Asl(_ram[0x7E]); TotalCycles += 5; PC = 0xA3E6;
                    return;
                case 0xA3E5:
                    { int a = 0x9E02 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA3E8;
                    goto case 0xA3E8;
                case 0xA3E8:
                    _ram[0xFE] = Asl(_ram[0xFE]); TotalCycles += 5; PC = 0xA3EA;
                    goto case 0xA3EA;
                case 0xA3E9:
                    { int a = 0x0D0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA3EC;
                    goto case 0xA3EC;
                case 0xA3EA:
                    A = Asl(A); TotalCycles += 2; PC = 0xA3EB;
                    goto case 0xA3EB;
                case 0xA3EB:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x4DC4]; SetZN(A); TotalCycles += 4; PC = 0xA3EE;
                    return;
                case 0xA3EC:
                    Cmp(Y, _ram[0xCD]); TotalCycles += 3; PC = 0xA3EE;
                    return;
                case 0xA3ED:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x4E43]); TotalCycles += 4; PC = 0xA3F0;
                    goto case 0xA3F0;
                case 0xA3EF:
                    { int a = 0xDE09; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA3F2;
                    return;
                case 0xA3F0:
                    A |= 0xDE; SetZN(A); TotalCycles += 2; PC = 0xA3F2;
                    return;
                case 0xA3F1:
                    { int a = 0xDD0B + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA3F4;
                    return;
                case 0xA3F3:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7E42 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA3F6;
                    return;
                case 0xA3F5:
                    { int a = 0x5D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA3F8;
                    return;
                case 0xA3F7:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x7DC7 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA3FA;
                    return;
                case 0xA3F9:
                    Sbc(_ram[(0x065B + X) & 0x07FF]); TotalCycles += 4; PC = 0xA3FC;
                    goto case 0xA3FC;
                case 0xA3FB:
                    _ram[0x05] = Asl(_ram[0x05]); TotalCycles += 5; PC = 0xA3FD;
                    return;
                case 0xA3FC:
                    A |= _ram[0x32]; SetZN(A); TotalCycles += 3; PC = 0xA3FE;
                    goto case 0xA3FE;
                case 0xA3FE:
                    _ram[0x33] = Asl(_ram[0x33]); TotalCycles += 5; PC = 0xA400;
                    return;
                case 0xA402:
                    { int a = 0xAE0A + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA405;
                    return;
                case 0xA403:
                    A = Asl(A); TotalCycles += 2; PC = 0xA404;
                    goto case 0xA404;
                case 0xA404:
                    X = _ram[0x0502]; SetZN(X); TotalCycles += 4; PC = 0xA407;
                    goto case 0xA407;
                case 0xA406:
                    A |= ReadIoReg(0x3901); SetZN(A); TotalCycles += 4; PC = 0xA409;
                    return;
                case 0xA407:
                    A |= ReadMem(ReadU16Zp((byte)(0x39 + X))); SetZN(A); TotalCycles += 6; PC = 0xA409;
                    return;
                case 0xA408:
                    A &= ReadMem(0x0D73 + Y); SetZN(A); TotalCycles += 4; PC = 0xA40B;
                    return;
                case 0xA40A:
                    A |= ReadIoReg(0x3903); SetZN(A); TotalCycles += 4; PC = 0xA40D;
                    return;
                case 0xA40C:
                    A &= ReadMem(0x4D7B + Y); SetZN(A); TotalCycles += 4; PC = 0xA40F;
                    return;
                case 0xA40E:
                    A ^= SmbEmbeddedAssets.StaticDataTables[0x5E4B]; SetZN(A); TotalCycles += 4; PC = 0xA411;
                    goto case 0xA411;
                case 0xA410:
                    { int a = 0x1E06 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA413;
                    goto case 0xA413;
                case 0xA411:
                    _ram[0x1E] = Asl(_ram[0x1E]); TotalCycles += 5; PC = 0xA413;
                    goto case 0xA413;
                case 0xA412:
                    { int a = 0xAE8A + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xA415;
                    goto case 0xA415;
                case 0xA413:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA414;
                    goto case 0xA414;
                case 0xA414:
                    X = SmbEmbeddedAssets.StaticDataTables[0x4406]; SetZN(X); TotalCycles += 4; PC = 0xA417;
                    return;
                case 0xA415:
                    _ram[0xC4] = Asl(_ram[0xC4]); TotalCycles += 5; PC = 0xA417;
                    return;
                case 0xA416:
                    Cmp(Y, _ram[0x33]); TotalCycles += 3; PC = 0xA418;
                    goto case 0xA418;
                case 0xA418:
                    { byte z = (byte)(0xFE + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA41A;
                    goto case 0xA41A;
                case 0xA419:
                    { int a = 0x77A5 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA41C;
                    goto case 0xA41C;
                case 0xA41A:
                    A = _ram[0x77]; SetZN(A); TotalCycles += 3; PC = 0xA41C;
                    goto case 0xA41C;
                case 0xA41C:
                    { int a = 0xFE02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA41F;
                    return;
                case 0xA41E:
                    { int a = 0x0D82 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA421;
                    return;
                case 0xA420:
                    A |= ReadIoReg(0x3907); SetZN(A); TotalCycles += 4; PC = 0xA423;
                    return;
                case 0xA422:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x2873 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA425;
                    return;
                case 0xA424:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xA425;
                    return;
                case 0xA426:
                    Sbc(ReadIoReg(0x494B)); TotalCycles += 4; PC = 0xA429;
                    return;
                case 0xA428:
                    A ^= 0xFB; SetZN(A); TotalCycles += 2; PC = 0xA42A;
                    goto case 0xA42A;
                case 0xA42A:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xA42B;
                    return;
                case 0xA42C:
                    { int a = 0x2E0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA42F;
                    return;
                case 0xA42D:
                    A = Asl(A); TotalCycles += 2; PC = 0xA42E;
                    goto case 0xA42E;
                case 0xA42E:
                    { int a = 0x6782; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA431;
                    return;
                case 0xA432:
                    _ram[0x7A] = Y; TotalCycles += 3; PC = 0xA434;
                    return;
                case 0xA435:
                    A &= ReadMem(ReadU16Zp(0x0D) + Y); SetZN(A); TotalCycles += 5; PC = 0xA437;
                    return;
                case 0xA436:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x7E0B]; SetZN(A); TotalCycles += 4; PC = 0xA439;
                    return;
                case 0xA438:
                    { int a = 0x0D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA43B;
                    return;
                case 0xA43A:
                    A |= ReadIoReg(0x390C); SetZN(A); TotalCycles += 4; PC = 0xA43D;
                    return;
                case 0xA43C:
                    A &= ReadMem(0x5E73 + Y); SetZN(A); TotalCycles += 4; PC = 0xA43F;
                    goto case 0xA43F;
                case 0xA43E:
                    { int a = 0xC606 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA441;
                    goto case 0xA441;
                case 0xA43F:
                    _ram[0xC6] = Asl(_ram[0xC6]); TotalCycles += 5; PC = 0xA441;
                    goto case 0xA441;
                case 0xA440:
                    _ram[0x76] = DecVal(_ram[0x76]); TotalCycles += 5; PC = 0xA442;
                    goto case 0xA442;
                case 0xA441:
                    { byte z = (byte)(0x45 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xA443;
                    return;
                case 0xA442:
                    A ^= _ram[0xFF]; SetZN(A); TotalCycles += 3; PC = 0xA444;
                    goto case 0xA444;
                case 0xA444:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x5D0A + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xA447;
                    goto case 0xA447;
                case 0xA445:
                    A = Asl(A); TotalCycles += 2; PC = 0xA446;
                    goto case 0xA446;
                case 0xA446:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7E48 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA449;
                    goto case 0xA449;
                case 0xA447:
                    PushU8(A); TotalCycles += 3; PC = 0xA448;
                    goto case 0xA448;
                case 0xA448:
                    { int a = 0x3D06 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA44B;
                    return;
                case 0xA449:
                    _ram[0x3D] = Asl(_ram[0x3D]); TotalCycles += 5; PC = 0xA44B;
                    return;
                case 0xA44A:
                    A &= ReadMem(0x46CB + X); SetZN(A); TotalCycles += 4; PC = 0xA44D;
                    goto case 0xA44D;
                case 0xA44C:
                    _ram[0x7E] = Lsr(_ram[0x7E]); TotalCycles += 5; PC = 0xA44E;
                    goto case 0xA44E;
                case 0xA44D:
                    { int a = 0x4AAD + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA450;
                    goto case 0xA450;
                case 0xA44E:
                    A = SmbEmbeddedAssets.StaticDataTables[0x7E4A]; SetZN(A); TotalCycles += 4; PC = 0xA451;
                    return;
                case 0xA44F:
                    A = Lsr(A); TotalCycles += 2; PC = 0xA450;
                    goto case 0xA450;
                case 0xA450:
                    { int a = 0x3982 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA453;
                    return;
                case 0xA452:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x29F3 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA455;
                    return;
                case 0xA454:
                    A = 0x7B; SetZN(A); TotalCycles += 2; PC = 0xA456;
                    goto case 0xA456;
                case 0xA456:
                    { int a = 0x9E8A; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA459;
                    return;
                case 0xA457:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xA458;
                    return;
                case 0xA45A:
                    { int a = 0x0D0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA45D;
                    goto case 0xA45D;
                case 0xA45B:
                    A = Asl(A); TotalCycles += 2; PC = 0xA45C;
                    goto case 0xA45C;
                case 0xA45C:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x4DC4]; SetZN(A); TotalCycles += 4; PC = 0xA45F;
                    return;
                case 0xA45D:
                    Cmp(Y, _ram[0xCD]); TotalCycles += 3; PC = 0xA45F;
                    return;
                case 0xA45E:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x4E43]); TotalCycles += 4; PC = 0xA461;
                    goto case 0xA461;
                case 0xA460:
                    { int a = 0xDE09; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA463;
                    return;
                case 0xA461:
                    A |= 0xDE; SetZN(A); TotalCycles += 2; PC = 0xA463;
                    return;
                case 0xA462:
                    { int a = 0xDD0B + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA465;
                    return;
                case 0xA464:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7E42 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA467;
                    return;
                case 0xA466:
                    { int a = 0x5D02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA469;
                    return;
                case 0xA468:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x7DC7 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA46B;
                    goto case 0xA46B;
                case 0xA46A:
                    Sbc(ReadMem(0x1194 + X)); TotalCycles += 4; PC = 0xA46D;
                    return;
                case 0xA46B:
                    _ram[(byte)(0x11 + X)] = Y; TotalCycles += 4; PC = 0xA46D;
                    return;
                case 0xA46C:
                    A |= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA46E;
                    goto case 0xA46E;
                case 0xA46E:
                    _ram[0xFE] = Rol(_ram[0xFE]); TotalCycles += 5; PC = 0xA470;
                    goto case 0xA470;
                case 0xA46F:
                    { int a = 0x2810 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA472;
                    goto case 0xA472;
                case 0xA470:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xA49A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA49A; }
                    PC = 0xA472; goto case 0xA472;
                case 0xA471:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xA472;
                    goto case 0xA472;
                case 0xA472:
                    _ram[(byte)(0x65 + X)] = Y; TotalCycles += 4; PC = 0xA474;
                    goto case 0xA474;
                case 0xA473:
                    Adc(_ram[0x15]); TotalCycles += 3; PC = 0xA475;
                    return;
                case 0xA474:
                    A |= _ram[(byte)(0xEB + X)]; SetZN(A); TotalCycles += 4; PC = 0xA476;
                    return;
                case 0xA478:
                    A ^= ReadMem(ReadU16Zp((byte)(0x4A + X))); SetZN(A); TotalCycles += 6; PC = 0xA47A;
                    goto case 0xA47A;
                case 0xA479:
                    A = Lsr(A); TotalCycles += 2; PC = 0xA47A;
                    goto case 0xA47A;
                case 0xA47A:
                    _ram[(byte)(0x54 + Y)] = X; TotalCycles += 4; PC = 0xA47C;
                    goto case 0xA47C;
                case 0xA47C:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA47D:
                    Y = _ram[0x42]; SetZN(Y); TotalCycles += 3; PC = 0xA47F;
                    return;
                case 0xA481:
                    Sbc(0x19); TotalCycles += 2; PC = 0xA483;
                    goto case 0xA483;
                case 0xA482:
                    A |= ReadMem(0x15F5 + Y); SetZN(A); TotalCycles += 4; PC = 0xA485;
                    goto case 0xA485;
                case 0xA483:
                    Sbc(_ram[(byte)(0x15 + X)]); TotalCycles += 4; PC = 0xA485;
                    goto case 0xA485;
                case 0xA484:
                    A |= _ram[(byte)(0x11 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA486;
                    return;
                case 0xA485:
                    A |= ReadMem(ReadU16Zp(0x80) + Y); SetZN(A); TotalCycles += 5; PC = 0xA487;
                    return;
                case 0xA489:
                    Adc(ReadMem(ReadU16Zp(0x13) + Y)); TotalCycles += 5; PC = 0xA48B;
                    return;
                case 0xA48C:
                    A ^= ReadMem(ReadU16Zp((byte)(0x15 + X))); SetZN(A); TotalCycles += 6; PC = 0xA48E;
                    return;
                case 0xA48D:
                    A |= _ram[(byte)(0x92 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA48F;
                    return;
                case 0xA491:
                    Bit(_ram[0x40]); TotalCycles += 3; PC = 0xA493;
                    goto case 0xA493;
                case 0xA492:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA493:
                    A ^= _ram[(byte)(0x12 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA495;
                    return;
                case 0xA496:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA497:
                    _ram[(byte)(0x12 + X)] = A; TotalCycles += 4; PC = 0xA499;
                    goto case 0xA499;
                case 0xA499:
                    Y = _ram[0x40]; SetZN(Y); TotalCycles += 3; PC = 0xA49B;
                    return;
                case 0xA49A:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA49D:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x40 + X)))); TotalCycles += 6; PC = 0xA49F;
                    return;
                case 0xA49E:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA4A0:
                    Cmp(Y, 0x2C); TotalCycles += 2; PC = 0xA4A2;
                    return;
                case 0xA4A1:
                    Bit(ReadIoReg(0x2F17)); TotalCycles += 4; PC = 0xA4A4;
                    return;
                case 0xA4A5:
                    A ^= 0x13; SetZN(A); TotalCycles += 2; PC = 0xA4A7;
                    return;
                case 0xA4A8:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA4AC:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA4B2:
                    A ^= ReadMem(ReadU16Zp((byte)(0xB9 + X))); SetZN(A); TotalCycles += 6; PC = 0xA4B4;
                    return;
                case 0xA4B3:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x4514 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA4B6;
                    return;
                case 0xA4B5:
                    Cmp(A, _ram[0x12]); TotalCycles += 3; PC = 0xA4B7;
                    goto case 0xA4B7;
                case 0xA4B7:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xA4B8;
                    goto case 0xA4B8;
                case 0xA4B8:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA4BA:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA4BD:
                    P |= FlagI; TotalCycles += 2; PC = 0xA4BE;
                    return;
                case 0xA4C0:
                    _ram[(byte)(0x9F + X)] = Y; TotalCycles += 4; PC = 0xA4C2;
                    goto case 0xA4C2;
                case 0xA4C2:
                    A |= ReadMem(ReadU16Zp(0xDF) + Y); SetZN(A); TotalCycles += 5; PC = 0xA4C4;
                    return;
                case 0xA4C5:
                    { int a = 0x7D11 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA4C8;
                    goto case 0xA4C8;
                case 0xA4C6:
                    A |= ReadMem(ReadU16Zp(0x7D) + Y); SetZN(A); TotalCycles += 5; PC = 0xA4C8;
                    goto case 0xA4C8;
                case 0xA4C7:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x1EC1 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA4CA;
                    return;
                case 0xA4C8: // === SUBROUTINE: Sub_A4C8 ===
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x9E + X)))); TotalCycles += 6; PC = 0xA4CA;
                    return;
                case 0xA4CC:
                    TotalCycles += 6; PushU16(0xA4CE); PC = 0x90FD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA4CD:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x3190 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA4D0;
                    return;
                case 0xA4CE:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xA481; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA481; }
                    PC = 0xA4D0; return;
                case 0xA4CF:
                    A = ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA4D1;
                    goto case 0xA4D1;
                case 0xA4D1:
                    _ram[0x29] = Rol(_ram[0x29]); TotalCycles += 5; PC = 0xA4D3;
                    goto case 0xA4D3;
                case 0xA4D2:
                    A &= 0x91; SetZN(A); TotalCycles += 2; PC = 0xA4D4;
                    goto case 0xA4D4;
                case 0xA4D3:
                    WriteMem(ReadU16Zp(0x7E) + Y, A); TotalCycles += 6; PC = 0xA4D5;
                    return;
                case 0xA4D4:
                    { int a = 0xFE42 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA4D7;
                    goto case 0xA4D7;
                case 0xA4D6:
                    { int a = 0x2840 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA4D9;
                    return;
                case 0xA4D7:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA4D8:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xA4D9;
                    return;
                case 0xA4DA:
                    { int a = 0x2E42; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA4DD;
                    goto case 0xA4DD;
                case 0xA4DC:
                    { int a = 0x57C0; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xA4DF;
                    return;
                case 0xA4DD:
                    Cmp(Y, 0x57); TotalCycles += 2; PC = 0xA4DF;
                    return;
                case 0xA4E1:
                    A &= _ram[0xC7]; SetZN(A); TotalCycles += 3; PC = 0xA4E3;
                    return;
                case 0xA4E5:
                    _ram[0x33] = Y; TotalCycles += 3; PC = 0xA4E7;
                    goto case 0xA4E7;
                case 0xA4E7:
                    TotalCycles += 6; PushU16(0xA4E9); PC = 0x015C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA4E9:
                    A |= ReadMem(ReadU16Zp((byte)(0x77 + X))); SetZN(A); TotalCycles += 6; PC = 0xA4EB;
                    return;
                case 0xA4EC:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xA4ED;
                    return;
                case 0xA4EE:
                    WriteMem(0xAA61 + Y, A); TotalCycles += 5; PC = 0xA4F1;
                    goto case 0xA4F1;
                case 0xA4EF:
                    Adc(ReadMem(ReadU16Zp((byte)(0xAA + X)))); TotalCycles += 6; PC = 0xA4F1;
                    goto case 0xA4F1;
                case 0xA4F0:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xA4F1;
                    goto case 0xA4F1;
                case 0xA4F1:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA4F2:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x6E01 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xA4F5;
                    return;
                case 0xA4F3:
                    A |= ReadMem(ReadU16Zp((byte)(0xEE + X))); SetZN(A); TotalCycles += 6; PC = 0xA4F5;
                    return;
                case 0xA4F4:
                    { int a = 0x4E42; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA4F7;
                    goto case 0xA4F7;
                case 0xA4F6:
                    { int a = 0x69C0; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA4F9;
                    goto case 0xA4F9;
                case 0xA4F7:
                    Cmp(Y, 0x69); TotalCycles += 2; PC = 0xA4F9;
                    goto case 0xA4F9;
                case 0xA4F8:
                    Adc(0x11); TotalCycles += 2; PC = 0xA4FA;
                    goto case 0xA4FA;
                case 0xA4F9:
                    A |= ReadMem(ReadU16Zp(0x7E) + Y); SetZN(A); TotalCycles += 5; PC = 0xA4FB;
                    return;
                case 0xA4FA:
                    { int a = 0xDE42 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xA4FD;
                    goto case 0xA4FD;
                case 0xA4FC:
                    { int a = 0xF840 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA4FF;
                    return;
                case 0xA4FD:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA4FE:
                    P |= FlagD; TotalCycles += 2; PC = 0xA4FF;
                    return;
                case 0xA500:
                    { int a = 0xAEC2; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA503;
                    goto case 0xA503;
                case 0xA502:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5740]; SetZN(X); TotalCycles += 4; PC = 0xA505;
                    return;
                case 0xA503:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA50E:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x6701]); TotalCycles += 4; PC = 0xA511;
                    return;
                case 0xA50F:
                    A |= ReadMem(ReadU16Zp((byte)(0xE7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA511;
                    return;
                case 0xA513:
                    WriteMem(ReadU16Zp((byte)(0x3E + X)), A); TotalCycles += 6; PC = 0xA515;
                    return;
                case 0xA514:
                    { int a = 0x0D42 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xA517;
                    goto case 0xA517;
                case 0xA516:
                    A |= ReadIoReg(0x5E0A); SetZN(A); TotalCycles += 4; PC = 0xA519;
                    goto case 0xA519;
                case 0xA517:
                    A = Asl(A); TotalCycles += 2; PC = 0xA518;
                    goto case 0xA518;
                case 0xA518:
                    { int a = 0x8840 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA51B;
                    return;
                case 0xA519:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA51A:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xA51B;
                    return;
                case 0xA51C:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x6742 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xA51F;
                    return;
                case 0xA520:
                    { int a = 0x3940 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA523;
                    goto case 0xA523;
                case 0xA521:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA522:
                    A &= ReadMem(0x4EE1 + Y); SetZN(A); TotalCycles += 4; PC = 0xA525;
                    goto case 0xA525;
                case 0xA523:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x4E + X)))); TotalCycles += 6; PC = 0xA525;
                    goto case 0xA525;
                case 0xA524:
                    { int a = 0x6900; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA527;
                    goto case 0xA527;
                case 0xA525:
                    TotalCycles += 7; PushU16(0xA527); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA526:
                    Adc(0x60); TotalCycles += 2; PC = 0xA528;
                    return;
                case 0xA527:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA529:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA52A:
                    A = _ram[0x60]; SetZN(A); TotalCycles += 3; PC = 0xA52C;
                    return;
                case 0xA52B:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA52D:
                    A &= ReadMem(ReadU16Zp(0xFE) + Y); SetZN(A); TotalCycles += 5; PC = 0xA52F;
                    goto case 0xA52F;
                case 0xA52E:
                    { int a = 0x6D31 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA531;
                    goto case 0xA531;
                case 0xA52F:
                    A &= ReadMem(ReadU16Zp(0x6D) + Y); SetZN(A); TotalCycles += 5; PC = 0xA531;
                    goto case 0xA531;
                case 0xA530:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x3EC1]); TotalCycles += 4; PC = 0xA533;
                    return;
                case 0xA531:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xBE + X)))); TotalCycles += 6; PC = 0xA533;
                    return;
                case 0xA532:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x6F42 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xA535;
                    goto case 0xA535;
                case 0xA535:
                    TotalCycles += 6; PushU16(0xA537); PC = 0x52FD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA536:
                    Sbc(ReadMem(0x2152 + X)); TotalCycles += 4; PC = 0xA539;
                    return;
                case 0xA538:
                    A &= ReadMem(ReadU16Zp((byte)(0x0F + X))); SetZN(A); TotalCycles += 6; PC = 0xA53A;
                    goto case 0xA53A;
                case 0xA53A:
                    TotalCycles += 6; PushU16(0xA53C); PC = 0x406E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA53B:
                    { int a = 0x5840; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xA53E;
                    return;
                case 0xA53C:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA53D:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xA53E;
                    return;
                case 0xA540:
                    A |= ReadMem(ReadU16Zp((byte)(0x97 + X))); SetZN(A); TotalCycles += 6; PC = 0xA542;
                    goto case 0xA542;
                case 0xA542:
                    TotalCycles += 7; PushU16(0xA544); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA544:
                    WriteMem(ReadU16Zp((byte)(0x97 + X)), A); TotalCycles += 6; PC = 0xA546;
                    goto case 0xA546;
                case 0xA546:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA547:
                    X = _ram[0x41]; SetZN(X); TotalCycles += 3; PC = 0xA549;
                    return;
                case 0xA548:
                    A ^= ReadMem(ReadU16Zp((byte)(0xC7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA54A;
                    goto case 0xA54A;
                case 0xA54A:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA54B:
                    A |= _ram[0x0304]; SetZN(A); TotalCycles += 4; PC = 0xA54E;
                    goto case 0xA54E;
                case 0xA54E:
                    A |= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0xA550;
                    goto case 0xA550;
                case 0xA550:
                    A |= ReadMem(ReadU16Zp((byte)(0x23 + X))); SetZN(A); TotalCycles += 6; PC = 0xA552;
                    goto case 0xA552;
                case 0xA552:
                    A |= ReadMem(ReadU16Zp((byte)(0x27 + X))); SetZN(A); TotalCycles += 6; PC = 0xA554;
                    goto case 0xA554;
                case 0xA554:
                    A |= ReadMem(ReadU16Zp((byte)(0xEC + X))); SetZN(A); TotalCycles += 6; PC = 0xA556;
                    return;
                case 0xA555:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x2C03]); TotalCycles += 4; PC = 0xA558;
                    return;
                case 0xA557:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x43F3]; SetZN(Y); TotalCycles += 4; PC = 0xA55A;
                    return;
                case 0xA55B:
                    P |= FlagI; TotalCycles += 2; PC = 0xA55C;
                    return;
                case 0xA55D:
                    _ram[(byte)(0x43 + X)] = Y; TotalCycles += 4; PC = 0xA55F;
                    return;
                case 0xA567:
                    Bit(ReadIoReg(0x4CF1)); TotalCycles += 4; PC = 0xA56A;
                    return;
                case 0xA568:
                    Sbc(ReadMem(ReadU16Zp(0x4C) + Y)); TotalCycles += 5; PC = 0xA56A;
                    return;
                case 0xA569:
                    TotalCycles += 3; PC = 0x4763;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA56C:
                    TotalCycles += 7; PushU16(0xA56E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA56E:
                    A &= ReadMem(ReadU16Zp((byte)(0x5C + X))); SetZN(A); TotalCycles += 6; PC = 0xA570;
                    goto case 0xA570;
                case 0xA570:
                    A |= ReadMem(ReadU16Zp((byte)(0x7C + X))); SetZN(A); TotalCycles += 6; PC = 0xA572;
                    return;
                case 0xA573:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x6CF1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA576;
                    return;
                case 0xA574:
                    Sbc(ReadMem(ReadU16Zp(0xEC) + Y)); TotalCycles += 5; PC = 0xA576;
                    return;
                case 0xA575:
                    Cmp(X, ReadIoReg(0x4C02)); TotalCycles += 4; PC = 0xA578;
                    goto case 0xA578;
                case 0xA577:
                    TotalCycles += 3; PC = 0xD881;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA578:
                    WriteMem(ReadU16Zp((byte)(0xD8 + X)), A); TotalCycles += 6; PC = 0xA57A;
                    return;
                case 0xA579:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xA57A;
                    return;
                case 0xA57B:
                    Cmp(X, _ram[0x0501]); TotalCycles += 4; PC = 0xA57E;
                    goto case 0xA57E;
                case 0xA57C:
                    A |= ReadMem(ReadU16Zp((byte)(0x0D + X))); SetZN(A); TotalCycles += 6; PC = 0xA57E;
                    goto case 0xA57E;
                case 0xA57D:
                    A |= _ram[0x070D]; SetZN(A); TotalCycles += 4; PC = 0xA580;
                    goto case 0xA580;
                case 0xA57E:
                    A |= ReadIoReg(0x380F); SetZN(A); TotalCycles += 4; PC = 0xA581;
                    return;
                case 0xA580:
                    P |= FlagC; TotalCycles += 2; PC = 0xA581;
                    return;
                case 0xA583:
                    Sbc(_ram[0x054A]); TotalCycles += 4; PC = 0xA586;
                    goto case 0xA586;
                case 0xA584:
                    A = Lsr(A); TotalCycles += 2; PC = 0xA585;
                    goto case 0xA585;
                case 0xA585:
                    A |= ReadMem(0x5FC1 + X); SetZN(A); TotalCycles += 4; PC = 0xA588;
                    goto case 0xA588;
                case 0xA586:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x5F + X)))); TotalCycles += 6; PC = 0xA588;
                    goto case 0xA588;
                case 0xA588:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xA58A;
                    return;
                case 0xA589:
                    Sbc(ReadMem(0x2154 + X)); TotalCycles += 4; PC = 0xA58C;
                    return;
                case 0xA58B:
                    A &= ReadMem(ReadU16Zp((byte)(0x0F + X))); SetZN(A); TotalCycles += 6; PC = 0xA58D;
                    goto case 0xA58D;
                case 0xA58D:
                    _ram[0xA7] = Rol(_ram[0xA7]); TotalCycles += 5; PC = 0xA58F;
                    return;
                case 0xA593:
                    TotalCycles += 6; PushU16(0xA595); PC = 0x0783;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA599:
                    TotalCycles += 6; PushU16(0xA59B); PC = 0x73C7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA59D:
                    Sbc(ReadMem(ReadU16Zp(0x06) + Y)); TotalCycles += 5; PC = 0xA59F;
                    goto case 0xA59F;
                case 0xA59E:
                    _ram[0x31] = Asl(_ram[0x31]); TotalCycles += 5; PC = 0xA5A0;
                    goto case 0xA5A0;
                case 0xA59F:
                    A &= ReadMem(ReadU16Zp(0x39) + Y); SetZN(A); TotalCycles += 5; PC = 0xA5A1;
                    goto case 0xA5A1;
                case 0xA5A0:
                    A &= ReadMem(0x5971 + Y); SetZN(A); TotalCycles += 4; PC = 0xA5A3;
                    goto case 0xA5A3;
                case 0xA5A1:
                    Adc(ReadMem(ReadU16Zp(0x59) + Y)); TotalCycles += 5; PC = 0xA5A3;
                    goto case 0xA5A3;
                case 0xA5A2:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x6771 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA5A5;
                    return;
                case 0xA5A3:
                    Adc(ReadMem(ReadU16Zp(0xE7) + Y)); TotalCycles += 5; PC = 0xA5A5;
                    return;
                case 0xA5A7:
                    Y = 0x47; SetZN(Y); TotalCycles += 2; PC = 0xA5A9;
                    return;
                case 0xA5AA:
                    _ram[0x7C] = X; TotalCycles += 3; PC = 0xA5AC;
                    goto case 0xA5AC;
                case 0xA5AC:
                    Sbc(_ram[0x71]); TotalCycles += 3; PC = 0xA5AE;
                    return;
                case 0xA5AD:
                    Adc(ReadMem(ReadU16Zp(0xE7) + Y)); TotalCycles += 5; PC = 0xA5AF;
                    goto case 0xA5AF;
                case 0xA5AF:
                    A &= ReadMem(ReadU16Zp(0x33) + Y); SetZN(A); TotalCycles += 5; PC = 0xA5B1;
                    goto case 0xA5B1;
                case 0xA5B1:
                    Y = _ram[0x39]; SetZN(Y); TotalCycles += 3; PC = 0xA5B3;
                    goto case 0xA5B3;
                case 0xA5B2:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x2971 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA5B5;
                    goto case 0xA5B5;
                case 0xA5B3:
                    Adc(ReadMem(ReadU16Zp(0xA9) + Y)); TotalCycles += 5; PC = 0xA5B5;
                    goto case 0xA5B5;
                case 0xA5B4:
                    A = 0x71; SetZN(A); TotalCycles += 2; PC = 0xA5B6;
                    return;
                case 0xA5B5:
                    Adc(ReadMem(ReadU16Zp(0xD3) + Y)); TotalCycles += 5; PC = 0xA5B7;
                    return;
                case 0xA5B8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA5B9;
                    return;
                case 0xA5BB:
                    A |= _ram[0x27]; SetZN(A); TotalCycles += 3; PC = 0xA5BD;
                    return;
                case 0xA5BE:
                    A ^= 0x71; SetZN(A); TotalCycles += 2; PC = 0xA5C0;
                    goto case 0xA5C0;
                case 0xA5BF:
                    Adc(ReadMem(ReadU16Zp(0x75) + Y)); TotalCycles += 5; PC = 0xA5C1;
                    goto case 0xA5C1;
                case 0xA5C0:
                    Adc(_ram[(byte)(0x75 + X)]); TotalCycles += 4; PC = 0xA5C2;
                    goto case 0xA5C2;
                case 0xA5C1:
                    Adc(_ram[(byte)(0xE8 + X)]); TotalCycles += 4; PC = 0xA5C3;
                    return;
                case 0xA5C2:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xA5C3;
                    return;
                case 0xA5C6:
                    WriteMem(0xE771 + Y, A); TotalCycles += 5; PC = 0xA5C9;
                    goto case 0xA5C9;
                case 0xA5C7:
                    Adc(ReadMem(ReadU16Zp(0xE7) + Y)); TotalCycles += 5; PC = 0xA5C9;
                    goto case 0xA5C9;
                case 0xA5C9:
                    TotalCycles += 6; PushU16(0xA5CB); PC = 0x72F4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA5CD:
                    A &= ReadMem(ReadU16Zp(0x17) + Y); SetZN(A); TotalCycles += 5; PC = 0xA5CF;
                    goto case 0xA5CF;
                case 0xA5CF:
                    Y = 0x33; SetZN(Y); TotalCycles += 2; PC = 0xA5D1;
                    goto case 0xA5D1;
                case 0xA5D1:
                    TotalCycles += 6; PushU16(0xA5D3); PC = 0x7139;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA5D2:
                    A &= ReadMem(0x7371 + Y); SetZN(A); TotalCycles += 4; PC = 0xA5D5;
                    goto case 0xA5D5;
                case 0xA5D3:
                    Adc(ReadMem(ReadU16Zp(0x73) + Y)); TotalCycles += 5; PC = 0xA5D5;
                    goto case 0xA5D5;
                case 0xA5D5:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xA5D6;
                    goto case 0xA5D6;
                case 0xA5D6:
                    Y = ReadMem(0x3905 + X); SetZN(Y); TotalCycles += 4; PC = 0xA5D9;
                    goto case 0xA5D9;
                case 0xA5D7:
                    A |= _ram[0x39]; SetZN(A); TotalCycles += 3; PC = 0xA5D9;
                    goto case 0xA5D9;
                case 0xA5D8:
                    A &= ReadMem(0x79F1 + Y); SetZN(A); TotalCycles += 4; PC = 0xA5DB;
                    goto case 0xA5DB;
                case 0xA5D9:
                    Sbc(ReadMem(ReadU16Zp(0x79) + Y)); TotalCycles += 5; PC = 0xA5DB;
                    goto case 0xA5DB;
                case 0xA5DA:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x2671 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xA5DD;
                    goto case 0xA5DD;
                case 0xA5DB:
                    Adc(ReadMem(ReadU16Zp(0xA6) + Y)); TotalCycles += 5; PC = 0xA5DD;
                    goto case 0xA5DD;
                case 0xA5DC:
                    X = _ram[0x21]; SetZN(X); TotalCycles += 3; PC = 0xA5DE;
                    return;
                case 0xA5DD:
                    A &= ReadMem(ReadU16Zp((byte)(0xC3 + X))); SetZN(A); TotalCycles += 6; PC = 0xA5DF;
                    goto case 0xA5DF;
                case 0xA5DF:
                    _ram[0xD3] = Asl(_ram[0xD3]); TotalCycles += 5; PC = 0xA5E1;
                    goto case 0xA5E1;
                case 0xA5E1:
                    TotalCycles += 6; PushU16(0xA5E3); PC = 0x00DC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA5E3:
                    TotalCycles += 7; PushU16(0xA5E5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA5E5:
                    TotalCycles += 7; PushU16(0xA5E7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA5E7:
                    X = 0x13; SetZN(X); TotalCycles += 2; PC = 0xA5E9;
                    goto case 0xA5E9;
                case 0xA5E9:
                    A &= ReadMem(ReadU16Zp((byte)(0x5F + X))); SetZN(A); TotalCycles += 6; PC = 0xA5EB;
                    return;
                case 0xA5EC:
                    WriteIoReg(0x9800, Y); TotalCycles += 4; PC = 0xA5EF;
                    return;
                case 0xA5ED:
                    TotalCycles += 7; PushU16(0xA5EF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA5EE:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xA5EF;
                    return;
                case 0xA5F2:
                    Cmp(A, _ram[(0x0361 + Y) & 0x07FF]); TotalCycles += 4; PC = 0xA5F5;
                    goto case 0xA5F5;
                case 0xA5F3:
                    Adc(ReadMem(ReadU16Zp((byte)(0x03 + X)))); TotalCycles += 6; PC = 0xA5F5;
                    goto case 0xA5F5;
                case 0xA5F5:
                    X = 0x07; SetZN(X); TotalCycles += 2; PC = 0xA5F7;
                    return;
                case 0xA5FB:
                    A &= ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0xA5FD;
                    return;
                case 0xA5FE:
                    A &= ReadMem(0x58F1 + Y); SetZN(A); TotalCycles += 4; PC = 0xA601;
                    return;
                case 0xA5FF:
                    Sbc(ReadMem(ReadU16Zp(0x58) + Y)); TotalCycles += 5; PC = 0xA601;
                    return;
                case 0xA600:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xA601;
                    return;
                case 0xA604:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xA605;
                    return;
                case 0xA607:
                    A = ReadMem(ReadU16Zp(0x97) + Y); SetZN(A); TotalCycles += 5; PC = 0xA609;
                    return;
                case 0xA60A:
                    X = _ram[(byte)(0x64 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xA60C;
                    goto case 0xA60C;
                case 0xA60C:
                    Cmp(A, _ram[0x65]); TotalCycles += 3; PC = 0xA60E;
                    return;
                case 0xA60D:
                    Adc(_ram[0xD4]); TotalCycles += 3; PC = 0xA60F;
                    goto case 0xA60F;
                case 0xA60F:
                    _ram[0xE3] = Ror(_ram[0xE3]); TotalCycles += 5; PC = 0xA611;
                    return;
                case 0xA614:
                    WriteIoReg(0xCFC1, A); TotalCycles += 4; PC = 0xA617;
                    goto case 0xA617;
                case 0xA615:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xCF + X)))); TotalCycles += 6; PC = 0xA617;
                    goto case 0xA617;
                case 0xA617:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xA619;
                    return;
                case 0xA618:
                    Sbc(ReadMem(0x3152 + X)); TotalCycles += 4; PC = 0xA61B;
                    return;
                case 0xA61A:
                    A &= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA61C;
                    goto case 0xA61C;
                case 0xA61C:
                    TotalCycles += 6; PushU16(0xA61E); PC = 0x666E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA61D:
                    _ram[0x0766] = Ror(_ram[0x0766]); TotalCycles += 6; PC = 0xA620;
                    goto case 0xA620;
                case 0xA61E:
                    _ram[0x07] = Ror(_ram[0x07]); TotalCycles += 5; PC = 0xA620;
                    goto case 0xA620;
                case 0xA620:
                    WriteMem(ReadU16Zp((byte)(0x36 + X)), A); TotalCycles += 6; PC = 0xA622;
                    goto case 0xA622;
                case 0xA621:
                    { byte z = (byte)(0x01 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xA623;
                    goto case 0xA623;
                case 0xA622:
                    A |= ReadMem(ReadU16Zp((byte)(0x66 + X))); SetZN(A); TotalCycles += 6; PC = 0xA624;
                    goto case 0xA624;
                case 0xA623:
                    _ram[0x00] = Ror(_ram[0x00]); TotalCycles += 5; PC = 0xA625;
                    return;
                case 0xA624:
                    TotalCycles += 7; PushU16(0xA626); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA627:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA628;
                    return;
                case 0xA62D:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xA62E;
                    return;
                case 0xA630:
                    TotalCycles += 6; PushU16(0xA632); PC = 0xF139;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA631:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x1FF1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA634;
                    return;
                case 0xA632:
                    Sbc(ReadMem(ReadU16Zp(0x9F) + Y)); TotalCycles += 5; PC = 0xA634;
                    return;
                case 0xA63D:
                    TotalCycles += 5; PC = ReadU16Zp(0x51); return;
                case 0xA63E:
                    A ^= ReadMem(ReadU16Zp(0x87) + Y); SetZN(A); TotalCycles += 5; PC = 0xA640;
                    return;
                case 0xA641:
                    WriteMem(0xA361 + Y, A); TotalCycles += 5; PC = 0xA644;
                    goto case 0xA644;
                case 0xA642:
                    Adc(ReadMem(ReadU16Zp((byte)(0xA3 + X)))); TotalCycles += 6; PC = 0xA644;
                    goto case 0xA644;
                case 0xA644:
                    _ram[0xB3] = Asl(_ram[0xB3]); TotalCycles += 5; PC = 0xA646;
                    goto case 0xA646;
                case 0xA646:
                    A &= ReadMem(ReadU16Zp((byte)(0x77 + X))); SetZN(A); TotalCycles += 6; PC = 0xA648;
                    return;
                case 0xA64A:
                    A &= ReadMem(ReadU16Zp((byte)(0xF7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA64C;
                    goto case 0xA64C;
                case 0xA64C:
                    A = Rol(A); TotalCycles += 2; PC = 0xA64D;
                    return;
                case 0xA64E:
                    WriteMem(ReadU16Zp((byte)(0x23 + X)), A); TotalCycles += 6; PC = 0xA650;
                    return;
                case 0xA652:
                    TotalCycles += 7; PushU16(0xA654); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA655:
                    Sbc(0x0B); TotalCycles += 2; PC = 0xA657;
                    return;
                case 0xA65A:
                    A &= ReadMem(ReadU16Zp((byte)(0x16 + X))); SetZN(A); TotalCycles += 6; PC = 0xA65C;
                    return;
                case 0xA65B:
                    { byte z = (byte)(0x22 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA65D;
                    return;
                case 0xA65E:
                    A |= _ram[0x8F]; SetZN(A); TotalCycles += 3; PC = 0xA660;
                    goto case 0xA660;
                case 0xA660:
                    A &= _ram[(byte)(0xEC + X)]; SetZN(A); TotalCycles += 4; PC = 0xA662;
                    goto case 0xA662;
                case 0xA661:
                    Cmp(X, ReadIoReg(0x6301)); TotalCycles += 4; PC = 0xA664;
                    goto case 0xA664;
                case 0xA662:
                    A |= ReadMem(ReadU16Zp((byte)(0x63 + X))); SetZN(A); TotalCycles += 6; PC = 0xA664;
                    goto case 0xA664;
                case 0xA664:
                    Y = 0x67; SetZN(Y); TotalCycles += 2; PC = 0xA666;
                    goto case 0xA666;
                case 0xA666:
                    TotalCycles += 6; PushU16(0xA668); PC = 0x0173;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA668:
                    A |= ReadMem(ReadU16Zp((byte)(0x77 + X))); SetZN(A); TotalCycles += 6; PC = 0xA66A;
                    goto case 0xA66A;
                case 0xA66A:
                    A |= ReadMem(ReadU16Zp((byte)(0x83 + X))); SetZN(A); TotalCycles += 6; PC = 0xA66C;
                    goto case 0xA66C;
                case 0xA66C:
                    TotalCycles += 6; PushU16(0xA66E); PC = 0x2087;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA66E:
                    TotalCycles += 6; PushU16(0xA670); PC = 0x20B3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA670:
                    TotalCycles += 6; PushU16(0xA672); PC = 0x20B7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA672:
                    TotalCycles += 6; PushU16(0xA674); PC = 0x01C3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA674:
                    A |= ReadMem(ReadU16Zp((byte)(0xC7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA676;
                    goto case 0xA676;
                case 0xA676:
                    TotalCycles += 7; PushU16(0xA678); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA678:
                    TotalCycles += 6; PushU16(0xA67A); PC = 0x20D7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA67A:
                    TotalCycles += 6; PushU16(0xA67C); PC = 0xA067;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA67C:
                    Y = 0x77; SetZN(Y); TotalCycles += 2; PC = 0xA67E;
                    return;
                case 0xA681:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xA682;
                    return;
                case 0xA683:
                    Sbc(_ram[(byte)(0x65 + X)]); TotalCycles += 4; PC = 0xA685;
                    return;
                case 0xA684:
                    Adc(_ram[0x1C]); TotalCycles += 3; PC = 0xA686;
                    return;
                case 0xA688:
                    P |= FlagC; TotalCycles += 2; PC = 0xA689;
                    goto case 0xA689;
                case 0xA689:
                    WriteIoReg(0xCFC1, A); TotalCycles += 4; PC = 0xA68C;
                    goto case 0xA68C;
                case 0xA68A:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xCF + X)))); TotalCycles += 6; PC = 0xA68C;
                    goto case 0xA68C;
                case 0xA68C:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xA68E;
                    goto case 0xA68E;
                case 0xA68D:
                    Sbc(ReadMem(0x2150 + X)); TotalCycles += 4; PC = 0xA690;
                    return;
                case 0xA68E:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xA6B1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA6B1; }
                    PC = 0xA690; return;
                case 0xA68F:
                    A &= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0xA691;
                    goto case 0xA691;
                case 0xA691:
                    WriteMem(ReadU16Zp((byte)(0x47 + X)), A); TotalCycles += 6; PC = 0xA693;
                    goto case 0xA693;
                case 0xA693:
                    Bit(_ram[0x57]); TotalCycles += 3; PC = 0xA695;
                    goto case 0xA695;
                case 0xA695:
                    TotalCycles += 7; PushU16(0xA697); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA697:
                    A |= ReadMem(ReadU16Zp((byte)(0x77 + X))); SetZN(A); TotalCycles += 6; PC = 0xA699;
                    goto case 0xA699;
                case 0xA699:
                    A |= ReadMem(ReadU16Zp((byte)(0xC9 + X))); SetZN(A); TotalCycles += 6; PC = 0xA69B;
                    goto case 0xA69B;
                case 0xA69A:
                    Cmp(A, 0x71); TotalCycles += 2; PC = 0xA69C;
                    goto case 0xA69C;
                case 0xA69B:
                    Adc(ReadMem(ReadU16Zp(0x68) + Y)); TotalCycles += 5; PC = 0xA69D;
                    return;
                case 0xA69C:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xA69D;
                    return;
                case 0xA6A2:
                    _ram[0x83] = Asl(_ram[0x83]); TotalCycles += 5; PC = 0xA6A4;
                    return;
                case 0xA6A5:
                    A |= ReadMem(ReadU16Zp((byte)(0xD7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA6A7;
                    return;
                case 0xA6A9:
                    TotalCycles += 7; PushU16(0xA6AB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA6AC:
                    TotalCycles += 5; PC = ReadU16Zp(0x02); return;
                case 0xA6B1:
                    A |= ReadMem(ReadU16Zp((byte)(0xE7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA6B3;
                    return;
                case 0xA6B5:
                    Y = 0x57; SetZN(Y); TotalCycles += 2; PC = 0xA6B7;
                    goto case 0xA6B7;
                case 0xA6B7:
                    _ram[0xA7] = Asl(_ram[0xA7]); TotalCycles += 5; PC = 0xA6B9;
                    goto case 0xA6B9;
                case 0xA6B9:
                    A |= ReadMem(ReadU16Zp((byte)(0xD3 + X))); SetZN(A); TotalCycles += 6; PC = 0xA6BB;
                    goto case 0xA6BB;
                case 0xA6BB:
                    TotalCycles += 7; PushU16(0xA6BD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA6BD:
                    A |= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0xA6BF;
                    goto case 0xA6BF;
                case 0xA6BF:
                    WriteMem(ReadU16Zp((byte)(0x67 + X)), A); TotalCycles += 6; PC = 0xA6C1;
                    goto case 0xA6C1;
                case 0xA6C1:
                    TotalCycles += 6; PushU16(0xA6C3); PC = 0x2293;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA6C7:
                    Adc(ReadMem(ReadU16Zp((byte)(0x17 + X)))); TotalCycles += 6; PC = 0xA6C9;
                    goto case 0xA6C9;
                case 0xA6C9:
                    A &= ReadMem(ReadU16Zp((byte)(0x6F + X))); SetZN(A); TotalCycles += 6; PC = 0xA6CB;
                    return;
                case 0xA6CE:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xA6CF;
                    return;
                case 0xA6D0:
                    Sbc(0x61); TotalCycles += 2; PC = 0xA6D2;
                    return;
                case 0xA6D1:
                    Adc(ReadMem(ReadU16Zp((byte)(0xFA + X)))); TotalCycles += 6; PC = 0xA6D3;
                    goto case 0xA6D3;
                case 0xA6D3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA6D9:
                    A |= ReadMem(ReadU16Zp((byte)(0xB7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA6DB;
                    return;
                case 0xA6DC:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xA6DD;
                    return;
                case 0xA6DE:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x6A61 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xA6E1;
                    goto case 0xA6E1;
                case 0xA6DF:
                    Adc(ReadMem(ReadU16Zp((byte)(0xEA + X)))); TotalCycles += 6; PC = 0xA6E1;
                    goto case 0xA6E1;
                case 0xA6E0:
                     TotalCycles += 2; PC = 0xA6E1;
                    goto case 0xA6E1;
                case 0xA6E1:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA6E2:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x07F1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA6E5;
                    goto case 0xA6E5;
                case 0xA6E3:
                    Sbc(ReadMem(ReadU16Zp(0x87) + Y)); TotalCycles += 5; PC = 0xA6E5;
                    goto case 0xA6E5;
                case 0xA6E5:
                    A &= ReadMem(ReadU16Zp((byte)(0xA7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA6E7;
                    goto case 0xA6E7;
                case 0xA6E7:
                    A |= ReadMem(ReadU16Zp((byte)(0xB7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA6E9;
                    goto case 0xA6E9;
                case 0xA6E9:
                    TotalCycles += 6; PushU16(0xA6EB); PC = 0xF139;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA6EA:
                    A &= ReadMem(0x5FF1 + Y); SetZN(A); TotalCycles += 4; PC = 0xA6ED;
                    goto case 0xA6ED;
                case 0xA6EB:
                    Sbc(ReadMem(ReadU16Zp(0x5F) + Y)); TotalCycles += 5; PC = 0xA6ED;
                    goto case 0xA6ED;
                case 0xA6ED:
                    P |= FlagC; TotalCycles += 2; PC = 0xA6EE;
                    goto case 0xA6EE;
                case 0xA6EE:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x2FC1]); TotalCycles += 4; PC = 0xA6F1;
                    goto case 0xA6F1;
                case 0xA6EF:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xAF + X)))); TotalCycles += 6; PC = 0xA6F1;
                    goto case 0xA6F1;
                case 0xA6F1:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xA6F3;
                    goto case 0xA6F3;
                case 0xA6F2:
                    Sbc(ReadMem(0x1190 + X)); TotalCycles += 4; PC = 0xA6F5;
                    return;
                case 0xA6F3:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xA706; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA6F5; return;
                case 0xA6F4:
                    A |= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA6F6;
                    goto case 0xA6F6;
                case 0xA6F6:
                    _ram[0xFE] = Rol(_ram[0xFE]); TotalCycles += 5; PC = 0xA6F8;
                    goto case 0xA6F8;
                case 0xA6F7:
                    { int a = 0x2A10 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA6FA;
                    return;
                case 0xA6F8:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xA724; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA6FA; return;
                case 0xA6F9:
                    A = Rol(A); TotalCycles += 2; PC = 0xA6FA;
                    return;
                case 0xA701:
                    A = Asl(A); TotalCycles += 2; PC = 0xA702;
                    return;
                case 0xA703:
                    A |= ReadMem(0x3640 + Y); SetZN(A); TotalCycles += 4; PC = 0xA706;
                    return;
                case 0xA704:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA705:
                    { byte z = (byte)(0x14 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xA707;
                    goto case 0xA707;
                case 0xA707:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xA74A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA709; return;
                case 0xA708:
                    A ^= ReadMem(ReadU16Zp((byte)(0x82 + X))); SetZN(A); TotalCycles += 6; PC = 0xA70A;
                    goto case 0xA70A;
                case 0xA70A:
                    { byte z = (byte)(0x2B + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA70C;
                    return;
                case 0xA70D:
                    Bit(_ram[0x41]); TotalCycles += 3; PC = 0xA70F;
                    return;
                case 0xA70E:
                    A ^= ReadMem(ReadU16Zp((byte)(0xBB + X))); SetZN(A); TotalCycles += 6; PC = 0xA710;
                    return;
                case 0xA711:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA712;
                    goto case 0xA712;
                case 0xA712:
                    TotalCycles += 7; PushU16(0xA714); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA718:
                    _ram[(byte)(0x67 + X)] = Y; TotalCycles += 4; PC = 0xA71A;
                    return;
                case 0xA71B:
                    Cmp(Y, _ram[0x15]); TotalCycles += 3; PC = 0xA71D;
                    return;
                case 0xA71C:
                    A |= _ram[(byte)(0x53 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA71E;
                    goto case 0xA71E;
                case 0xA71E:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xD2 + X)))); TotalCycles += 6; PC = 0xA720;
                    goto case 0xA720;
                case 0xA720:
                    A ^= ReadMem(ReadU16Zp((byte)(0x12 + X))); SetZN(A); TotalCycles += 6; PC = 0xA722;
                    goto case 0xA722;
                case 0xA722:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x29 + X)))); TotalCycles += 6; PC = 0xA724;
                    return;
                case 0xA723:
                    A &= 0x13; SetZN(A); TotalCycles += 2; PC = 0xA725;
                    goto case 0xA725;
                case 0xA725:
                    _ram[0x17] = A; TotalCycles += 3; PC = 0xA727;
                    return;
                case 0xA72E:
                    A ^= ReadMem(ReadU16Zp((byte)(0xA7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA730;
                    return;
                case 0xA731:
                    { int a = 0xA791; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xA734;
                    return;
                case 0xA732:
                    WriteMem(ReadU16Zp(0xA7) + Y, A); TotalCycles += 6; PC = 0xA734;
                    return;
                case 0xA737:
                    Cmp(A, _ram[0x65]); TotalCycles += 3; PC = 0xA739;
                    goto case 0xA739;
                case 0xA738:
                    Adc(_ram[0xD5]); TotalCycles += 3; PC = 0xA73A;
                    goto case 0xA73A;
                case 0xA739:
                    Cmp(A, _ram[(byte)(0x65 + X)]); TotalCycles += 4; PC = 0xA73B;
                    goto case 0xA73B;
                case 0xA73A:
                    Adc(_ram[0xDD]); TotalCycles += 3; PC = 0xA73C;
                    goto case 0xA73C;
                case 0xA73B:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x634A + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA73E;
                    return;
                case 0xA73C:
                    A = Lsr(A); TotalCycles += 2; PC = 0xA73D;
                    return;
                case 0xA741:
                    WriteIoReg(0xAEC1, A); TotalCycles += 4; PC = 0xA744;
                    return;
                case 0xA742:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xAE + X)))); TotalCycles += 6; PC = 0xA744;
                    return;
                case 0xA743:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5F42]; SetZN(X); TotalCycles += 4; PC = 0xA746;
                    goto case 0xA746;
                case 0xA746:
                    TotalCycles += 6; PushU16(0xA748); PC = 0x90FD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA747:
                    Sbc(ReadMem(0x1190 + X)); TotalCycles += 4; PC = 0xA74A;
                    return;
                case 0xA748:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xA75B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA74A; return;
                case 0xA749:
                    A |= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA74B;
                    goto case 0xA74B;
                case 0xA74B:
                    _ram[0x6E] = Rol(_ram[0x6E]); TotalCycles += 5; PC = 0xA74D;
                    goto case 0xA74D;
                case 0xA74C:
                    { int a = 0x8B10; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xA74F;
                    return;
                case 0xA74D:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xA6DA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA74F; return;
                case 0xA752:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xA753;
                    return;
                case 0xA754:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xA755;
                    return;
                case 0xA758:
                    A = SmbEmbeddedAssets.StaticDataTables[0x78C8]; SetZN(A); TotalCycles += 4; PC = 0xA75B;
                    return;
                case 0xA759:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xA75A;
                    goto case 0xA75A;
                case 0xA75A:
                    P |= FlagD; TotalCycles += 2; PC = 0xA75B;
                    return;
                case 0xA75D:
                    X = ReadMem(0x4343 + Y); SetZN(X); TotalCycles += 4; PC = 0xA760;
                    goto case 0xA760;
                case 0xA760:
                    P |= FlagD; TotalCycles += 2; PC = 0xA761;
                    return;
                case 0xA765:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA766:
                    _ram[0x40] = Y; TotalCycles += 3; PC = 0xA768;
                    return;
                case 0xA767:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA769:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA76A:
                    Y = _ram[0x40]; SetZN(Y); TotalCycles += 3; PC = 0xA76C;
                    return;
                case 0xA76B:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA76D:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA76E:
                    P |= FlagD; TotalCycles += 2; PC = 0xA76F;
                    return;
                case 0xA770:
                    PushU8(A); TotalCycles += 3; PC = 0xA771;
                    goto case 0xA771;
                case 0xA771:
                    Cmp(X, _ram[0x5C]); TotalCycles += 3; PC = 0xA773;
                    goto case 0xA773;
                case 0xA773:
                    A &= ReadMem(0x4083 + Y); SetZN(A); TotalCycles += 4; PC = 0xA776;
                    return;
                case 0xA775:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA777:
                    A ^= ReadMem(ReadU16Zp((byte)(0xB3 + X))); SetZN(A); TotalCycles += 6; PC = 0xA779;
                    goto case 0xA779;
                case 0xA779:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA77A:
                    P |= FlagD; TotalCycles += 2; PC = 0xA77B;
                    return;
                case 0xA77C:
                    PushU8(A); TotalCycles += 3; PC = 0xA77D;
                    goto case 0xA77D;
                case 0xA77D:
                    Cmp(X, _ram[0x5C]); TotalCycles += 3; PC = 0xA77F;
                    goto case 0xA77F;
                case 0xA77F:
                    A &= ReadMem(0x64F8 + Y); SetZN(A); TotalCycles += 4; PC = 0xA782;
                    return;
                case 0xA780:
                    P |= FlagD; TotalCycles += 2; PC = 0xA781;
                    return;
                case 0xA785:
                    Adc(_ram[0x4C]); TotalCycles += 3; PC = 0xA787;
                    goto case 0xA787;
                case 0xA786:
                    TotalCycles += 3; PC = 0x6324;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA787:
                    Bit(_ram[0x63]); TotalCycles += 3; PC = 0xA789;
                    goto case 0xA789;
                case 0xA789:
                    TotalCycles += 7; PushU16(0xA78B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA78B:
                    Adc(_ram[0xC3]); TotalCycles += 3; PC = 0xA78D;
                    return;
                case 0xA790:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x7832]; SetZN(Y); TotalCycles += 4; PC = 0xA793;
                    return;
                case 0xA792:
                    P |= FlagD; TotalCycles += 2; PC = 0xA793;
                    return;
                case 0xA795:
                    X = ReadMem(0x4553 + Y); SetZN(X); TotalCycles += 4; PC = 0xA798;
                    goto case 0xA798;
                case 0xA797:
                    A ^= _ram[0x9D]; SetZN(A); TotalCycles += 3; PC = 0xA799;
                    goto case 0xA799;
                case 0xA798:
                    WriteMem(0xF848 + X, A); TotalCycles += 5; PC = 0xA79B;
                    return;
                case 0xA799:
                    PushU8(A); TotalCycles += 3; PC = 0xA79A;
                    goto case 0xA79A;
                case 0xA79A:
                    P |= FlagD; TotalCycles += 2; PC = 0xA79B;
                    return;
                case 0xA79C:
                    A = Rol(A); TotalCycles += 2; PC = 0xA79D;
                    return;
                case 0xA7A0:
                    { byte z = (byte)(0x43 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xA7A2;
                    goto case 0xA7A2;
                case 0xA7A2:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xA7A3;
                    return;
                case 0xA7A4:
                    P |= FlagD; TotalCycles += 2; PC = 0xA7A5;
                    return;
                case 0xA7A8:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xA7A9;
                    return;
                case 0xA7AA:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x5431 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xA7AD;
                    goto case 0xA7AD;
                case 0xA7AB:
                    A &= ReadMem(ReadU16Zp(0xD4) + Y); SetZN(A); TotalCycles += 5; PC = 0xA7AD;
                    goto case 0xA7AD;
                case 0xA7AD:
                    A ^= _ram[0xFC]; SetZN(A); TotalCycles += 3; PC = 0xA7AF;
                    goto case 0xA7AF;
                case 0xA7AF:
                    A &= ReadMem(ReadU16Zp(0x3C) + Y); SetZN(A); TotalCycles += 5; PC = 0xA7B1;
                    goto case 0xA7B1;
                case 0xA7B1:
                    A = ReadMem(ReadU16Zp(0x78) + Y); SetZN(A); TotalCycles += 5; PC = 0xA7B3;
                    return;
                case 0xA7B2:
                    P |= FlagI; TotalCycles += 2; PC = 0xA7B3;
                    return;
                case 0xA7B4:
                    _ram[0x0338] = Y; TotalCycles += 4; PC = 0xA7B7;
                    return;
                case 0xA7B5:
                    P |= FlagC; TotalCycles += 2; PC = 0xA7B6;
                    return;
                case 0xA7BA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xA7BB;
                    goto case 0xA7BB;
                case 0xA7BB:
                    Adc(ReadMem(ReadU16Zp((byte)(0x28 + X)))); TotalCycles += 6; PC = 0xA7BD;
                    goto case 0xA7BD;
                case 0xA7BC:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xA7BD;
                    goto case 0xA7BD;
                case 0xA7BD:
                    Adc(ReadMem(ReadU16Zp((byte)(0x39 + X)))); TotalCycles += 6; PC = 0xA7BF;
                    goto case 0xA7BF;
                case 0xA7BE:
                    A &= ReadMem(0x5D60 + Y); SetZN(A); TotalCycles += 4; PC = 0xA7C1;
                    goto case 0xA7C1;
                case 0xA7BF:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA7C0:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x6E4A + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA7C3;
                    goto case 0xA7C3;
                case 0xA7C1:
                    A = Lsr(A); TotalCycles += 2; PC = 0xA7C2;
                    goto case 0xA7C2;
                case 0xA7C2:
                    _ram[0x0711] = IncVal(_ram[0x0711]); TotalCycles += 6; PC = 0xA7C5;
                    goto case 0xA7C5;
                case 0xA7C3:
                    A |= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA7C5;
                    goto case 0xA7C5;
                case 0xA7C5:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xA7C6;
                    goto case 0xA7C6;
                case 0xA7C6:
                    A |= ReadMem(0x3EC1 + X); SetZN(A); TotalCycles += 4; PC = 0xA7C9;
                    return;
                case 0xA7C7:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x3E + X)))); TotalCycles += 6; PC = 0xA7C9;
                    return;
                case 0xA7C8:
                    { int a = 0x6F42 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xA7CB;
                    goto case 0xA7CB;
                case 0xA7CB:
                    TotalCycles += 6; PushU16(0xA7CD); PC = 0x52FD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA7CC:
                    Sbc(ReadMem(0x3152 + X)); TotalCycles += 4; PC = 0xA7CF;
                    return;
                case 0xA7CE:
                    A &= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA7D0;
                    goto case 0xA7D0;
                case 0xA7D0:
                    TotalCycles += 6; PushU16(0xA7D2); PC = 0x406E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA7D1:
                    { int a = 0xF740; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xA7D4;
                    goto case 0xA7D4;
                case 0xA7D2:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA7D4:
                    TotalCycles += 6; PushU16(0xA7D6); PC = 0x8407;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA7D6:
                    _ram[0x17] = Y; TotalCycles += 3; PC = 0xA7D8;
                    goto case 0xA7D8;
                case 0xA7D8:
                    TotalCycles += 6; PushU16(0xA7DA); PC = 0x344F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA7E3:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x6761 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA7E6;
                    return;
                case 0xA7E4:
                    Adc(ReadMem(ReadU16Zp((byte)(0xE7 + X)))); TotalCycles += 6; PC = 0xA7E6;
                    return;
                case 0xA7E8:
                    Cmp(X, _ram[0x57]); TotalCycles += 3; PC = 0xA7EA;
                    goto case 0xA7EA;
                case 0xA7EA:
                    TotalCycles += 7; PushU16(0xA7EC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA7EB:
                    TotalCycles += 5; PC = ReadU16Zp(0x73); return;
                case 0xA7EE:
                    Y = 0x53; SetZN(Y); TotalCycles += 2; PC = 0xA7F0;
                    goto case 0xA7F0;
                case 0xA7F0:
                    _ram[0x63] = Asl(_ram[0x63]); TotalCycles += 5; PC = 0xA7F2;
                    return;
                case 0xA7F8:
                    A = ReadMem(ReadU16Zp((byte)(0x33 + X))); SetZN(A); TotalCycles += 6; PC = 0xA7FA;
                    goto case 0xA7FA;
                case 0xA7FA:
                    A |= _ram[0x43]; SetZN(A); TotalCycles += 3; PC = 0xA7FC;
                    goto case 0xA7FC;
                case 0xA7FC:
                    A &= ReadMem(ReadU16Zp((byte)(0x5C + X))); SetZN(A); TotalCycles += 6; PC = 0xA7FE;
                    return;
                case 0xA801:
                    Cmp(Y, ReadIoReg(0x7703)); TotalCycles += 4; PC = 0xA804;
                    return;
                case 0xA805:
                    Y = ReadIoReg(0x3902); SetZN(Y); TotalCycles += 4; PC = 0xA808;
                    goto case 0xA808;
                case 0xA807:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x27F1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA80A;
                    return;
                case 0xA808:
                    Sbc(ReadMem(ReadU16Zp(0xA7) + Y)); TotalCycles += 5; PC = 0xA80A;
                    return;
                case 0xA80D:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xA80E;
                    return;
                case 0xA811:
                    _ram[0xF4] = Rol(_ram[0xF4]); TotalCycles += 5; PC = 0xA813;
                    goto case 0xA813;
                case 0xA813:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x0C02 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xA816;
                    goto case 0xA816;
                case 0xA815:
                    WriteIoReg(0xA881, Y); TotalCycles += 4; PC = 0xA818;
                    return;
                case 0xA816:
                    WriteMem(ReadU16Zp((byte)(0xA8 + X)), A); TotalCycles += 6; PC = 0xA818;
                    return;
                case 0xA817:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xA818;
                    return;
                case 0xA81C:
                    Bit(_ram[0xA7]); TotalCycles += 3; PC = 0xA81E;
                    goto case 0xA81E;
                case 0xA81E:
                    A |= ReadMem(ReadU16Zp((byte)(0xC3 + X))); SetZN(A); TotalCycles += 6; PC = 0xA820;
                    return;
                case 0xA821:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA822;
                    return;
                case 0xA824:
                    A &= ReadMem(ReadU16Zp((byte)(0xA3 + X))); SetZN(A); TotalCycles += 6; PC = 0xA826;
                    return;
                case 0xA827:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0xA829;
                    goto case 0xA829;
                case 0xA829:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x69 + X)))); TotalCycles += 6; PC = 0xA82B;
                    goto case 0xA82B;
                case 0xA82A:
                    Adc(0xF1); TotalCycles += 2; PC = 0xA82C;
                    goto case 0xA82C;
                case 0xA82B:
                    Sbc(ReadMem(ReadU16Zp(0x69) + Y)); TotalCycles += 5; PC = 0xA82D;
                    goto case 0xA82D;
                case 0xA82C:
                    Adc(0x8D); TotalCycles += 2; PC = 0xA82E;
                    goto case 0xA82E;
                case 0xA82D:
                    WriteIoReg(0xCFC1, A); TotalCycles += 4; PC = 0xA830;
                    goto case 0xA830;
                case 0xA82E:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xCF + X)))); TotalCycles += 6; PC = 0xA830;
                    goto case 0xA830;
                case 0xA830:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xA832;
                    goto case 0xA832;
                case 0xA831:
                    Sbc(ReadMem(0x1138 + X)); TotalCycles += 4; PC = 0xA834;
                    return;
                case 0xA832:
                    P |= FlagC; TotalCycles += 2; PC = 0xA833;
                    goto case 0xA833;
                case 0xA833:
                    A |= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA835;
                    goto case 0xA835;
                case 0xA835:
                    _ram[0xAD] = Rol(_ram[0xAD]); TotalCycles += 5; PC = 0xA837;
                    goto case 0xA837;
                case 0xA836:
                    A = ReadIoReg(0x3D40); SetZN(A); TotalCycles += 4; PC = 0xA839;
                    return;
                case 0xA837:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA838:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x7DC7 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA83B;
                    goto case 0xA83B;
                case 0xA83A:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x3195 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA83D;
                    return;
                case 0xA83B:
                    _ram[(byte)(0xB1 + X)] = A; TotalCycles += 4; PC = 0xA83D;
                    return;
                case 0xA83C:
                    A = ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA83E;
                    goto case 0xA83E;
                case 0xA83E:
                    _ram[0x0D] = Rol(_ram[0x0D]); TotalCycles += 5; PC = 0xA840;
                    return;
                case 0xA83F:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x4802]; SetZN(A); TotalCycles += 4; PC = 0xA842;
                    return;
                case 0xA841:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xA842;
                    return;
                case 0xA844:
                    WriteMem(ReadU16Zp((byte)(0x38 + X)), A); TotalCycles += 6; PC = 0xA846;
                    return;
                case 0xA845:
                    P |= FlagC; TotalCycles += 2; PC = 0xA846;
                    return;
                case 0xA847:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x1705]; SetZN(A); TotalCycles += 4; PC = 0xA84A;
                    return;
                case 0xA848:
                    A |= _ram[0x97]; SetZN(A); TotalCycles += 3; PC = 0xA84A;
                    return;
                case 0xA84B:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xA84C;
                    return;
                case 0xA84E:
                    TotalCycles += 6; PushU16(0xA850); PC = 0x06B3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA850:
                    _ram[0xC3] = Asl(_ram[0xC3]); TotalCycles += 5; PC = 0xA852;
                    goto case 0xA852;
                case 0xA852:
                    TotalCycles += 6; PushU16(0xA854); PC = 0x03CC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA853:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x7903]); TotalCycles += 4; PC = 0xA856;
                    goto case 0xA856;
                case 0xA855:
                    Sbc(ReadMem(0x2C91 + Y)); TotalCycles += 4; PC = 0xA858;
                    goto case 0xA858;
                case 0xA856:
                    WriteMem(ReadU16Zp(0x2C) + Y, A); TotalCycles += 6; PC = 0xA858;
                    goto case 0xA858;
                case 0xA857:
                    Bit(ReadIoReg(0x4881)); TotalCycles += 4; PC = 0xA85A;
                    return;
                case 0xA858:
                    WriteMem(ReadU16Zp((byte)(0x48 + X)), A); TotalCycles += 6; PC = 0xA85A;
                    return;
                case 0xA859:
                    PushU8(A); TotalCycles += 3; PC = 0xA85A;
                    return;
                case 0xA85B:
                    A |= ReadIoReg(0x3709); SetZN(A); TotalCycles += 4; PC = 0xA85E;
                    return;
                case 0xA85C:
                    A |= 0x37; SetZN(A); TotalCycles += 2; PC = 0xA85E;
                    return;
                case 0xA862:
                    A &= ReadMem(ReadU16Zp((byte)(0x8C + X))); SetZN(A); TotalCycles += 6; PC = 0xA864;
                    return;
                case 0xA863:
                    WriteIoReg(0xC502, Y); TotalCycles += 4; PC = 0xA866;
                    goto case 0xA866;
                case 0xA865:
                    Cmp(A, _ram[0x79]); TotalCycles += 3; PC = 0xA867;
                    return;
                case 0xA866:
                    Adc(ReadMem(0x31C7 + Y)); TotalCycles += 4; PC = 0xA869;
                    goto case 0xA869;
                case 0xA868:
                    A &= ReadMem(ReadU16Zp(0xF9) + Y); SetZN(A); TotalCycles += 5; PC = 0xA86A;
                    goto case 0xA86A;
                case 0xA869:
                    Sbc(ReadMem(0x3911 + Y)); TotalCycles += 4; PC = 0xA86C;
                    goto case 0xA86C;
                case 0xA86A:
                    A |= ReadMem(ReadU16Zp(0x39) + Y); SetZN(A); TotalCycles += 5; PC = 0xA86C;
                    goto case 0xA86C;
                case 0xA86B:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x29F1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xA86E;
                    goto case 0xA86E;
                case 0xA86C:
                    Sbc(ReadMem(ReadU16Zp(0xA9) + Y)); TotalCycles += 5; PC = 0xA86E;
                    goto case 0xA86E;
                case 0xA86D:
                    A = 0x11; SetZN(A); TotalCycles += 2; PC = 0xA86F;
                    return;
                case 0xA86E:
                    A |= ReadMem(ReadU16Zp(0x6F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA870;
                    goto case 0xA870;
                case 0xA870:
                    Y = _ram[(byte)(0xD3 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xA872;
                    goto case 0xA872;
                case 0xA872:
                    Adc(_ram[0xE3]); TotalCycles += 3; PC = 0xA874;
                    goto case 0xA874;
                case 0xA874:
                    Adc(_ram[0x7D]); TotalCycles += 3; PC = 0xA876;
                    goto case 0xA876;
                case 0xA875:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x3FC1 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA878;
                    goto case 0xA878;
                case 0xA876:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xBF + X)))); TotalCycles += 6; PC = 0xA878;
                    goto case 0xA878;
                case 0xA878:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xA87A;
                    goto case 0xA87A;
                case 0xA879:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x4100 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA87C;
                    goto case 0xA87C;
                case 0xA87A:
                    TotalCycles += 7; PushU16(0xA87C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA87B:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x4C + X)))); TotalCycles += 6; PC = 0xA87D;
                    goto case 0xA87D;
                case 0xA87C:
                    TotalCycles += 3; PC = 0xF400;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA87D:
                    TotalCycles += 7; PushU16(0xA87F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA880:
                    A |= _ram[0x0202]; SetZN(A); TotalCycles += 4; PC = 0xA883;
                    return;
                case 0xA888: // === SUBROUTINE: Sub_A888 ===
                    { int a = 0x5A00 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA88B;
                    return;
                case 0xA889:
                    TotalCycles += 7; PushU16(0xA88B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA88C:
                    A ^= SmbEmbeddedAssets.StaticDataTables[0x7DC7]; SetZN(A); TotalCycles += 4; PC = 0xA88F;
                    goto case 0xA88F;
                case 0xA88E:
                    Sbc(ReadMem(0x5190 + X)); TotalCycles += 4; PC = 0xA891;
                    return;
                case 0xA88F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xA8E2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA8E2; }
                    PC = 0xA891; return;
                case 0xA890:
                    A ^= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA892;
                    goto case 0xA892;
                case 0xA892:
                    _ram[0xEE] = Rol(_ram[0xEE]); TotalCycles += 5; PC = 0xA894;
                    goto case 0xA894;
                case 0xA893:
                    _ram[0x0310] = IncVal(_ram[0x0310]); TotalCycles += 6; PC = 0xA896;
                    goto case 0xA896;
                case 0xA894:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xA8A1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA8A1; }
                    PC = 0xA896; goto case 0xA896;
                case 0xA896:
                    _ram[(byte)(0x33 + X)] = Y; TotalCycles += 4; PC = 0xA898;
                    return;
                case 0xA89C:
                    { byte z = (byte)(0x86 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA89E;
                    return;
                case 0xA89D:
                    _ram[0x44] = X; TotalCycles += 3; PC = 0xA89F;
                    return;
                case 0xA8A1:
                    A = Lsr(A); TotalCycles += 2; PC = 0xA8A2;
                    goto case 0xA8A2;
                case 0xA8A2:
                    { byte z = (byte)(0x69 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA8A4;
                    return;
                case 0xA8A3:
                    Adc(0x42); TotalCycles += 2; PC = 0xA8A5;
                    return;
                case 0xA8A7:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xA8A9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA8A9; return;
                case 0xA8A8:
                    TotalCycles += 7; PushU16(0xA8AA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA8AB:
                    A |= _ram[0xC0]; SetZN(A); TotalCycles += 3; PC = 0xA8AD;
                    return;
                case 0xA8AC:
                    Cmp(Y, 0x1C); TotalCycles += 2; PC = 0xA8AE;
                    return;
                case 0xA8B0:
                    A |= ReadMem(ReadU16Zp(0x36) + Y); SetZN(A); TotalCycles += 5; PC = 0xA8B2;
                    return;
                case 0xA8B1:
                    { byte z = (byte)(0x12 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xA8B3;
                    return;
                case 0xA8B5:
                    WriteMem(ReadU16Zp(0x40) + Y, A); TotalCycles += 6; PC = 0xA8B7;
                    return;
                case 0xA8B6:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA8B8:
                    _ram[(byte)(0x35 + X)] = Y; TotalCycles += 4; PC = 0xA8BA;
                    return;
                case 0xA8B9:
                    A &= _ram[(byte)(0x12 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA8BB;
                    return;
                case 0xA8BD:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xA8BF:
                    Adc(ReadMem(ReadU16Zp((byte)(0x12 + X)))); TotalCycles += 6; PC = 0xA8C1;
                    return;
                case 0xA8C3:
                    _ram[(byte)(0x40 + Y)] = X; TotalCycles += 4; PC = 0xA8C5;
                    return;
                case 0xA8C4:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA8C8:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xA8C9;
                    return;
                case 0xA8CA:
                    A |= ReadMem(ReadU16Zp(0x47) + Y); SetZN(A); TotalCycles += 5; PC = 0xA8CC;
                    return;
                case 0xA8CE:
                    A |= _ram[(byte)(0xCC + X)]; SetZN(A); TotalCycles += 4; PC = 0xA8D0;
                    goto case 0xA8D0;
                case 0xA8CF:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x4F15]); TotalCycles += 4; PC = 0xA8D2;
                    goto case 0xA8D2;
                case 0xA8D0:
                    A |= _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xA8D2;
                    goto case 0xA8D2;
                case 0xA8D2:
                    A |= ReadMem(ReadU16Zp(0x05) + Y); SetZN(A); TotalCycles += 5; PC = 0xA8D4;
                    goto case 0xA8D4;
                case 0xA8D3:
                    A |= _ram[0xC0]; SetZN(A); TotalCycles += 3; PC = 0xA8D5;
                    return;
                case 0xA8D4:
                    Cmp(Y, 0x1F); TotalCycles += 2; PC = 0xA8D6;
                    goto case 0xA8D6;
                case 0xA8D6:
                    A |= _ram[(byte)(0x39 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA8D8;
                    return;
                case 0xA8D7:
                    A &= ReadMem(0x7C12 + Y); SetZN(A); TotalCycles += 4; PC = 0xA8DA;
                    goto case 0xA8DA;
                case 0xA8DA:
                    { byte z = (byte)(0x7F + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA8DC;
                    goto case 0xA8DC;
                case 0xA8DC:
                    A |= ReadMem(ReadU16Zp(0x82) + Y); SetZN(A); TotalCycles += 5; PC = 0xA8DE;
                    goto case 0xA8DE;
                case 0xA8DE:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xA8DF:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xA8E0;
                    return;
                case 0xA8E2:
                    A |= _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA8E4;
                    goto case 0xA8E4;
                case 0xA8E3:
                    { byte z = (byte)(0xC4 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA8E5;
                    return;
                case 0xA8E4:
                    Cmp(Y, _ram[0x17]); TotalCycles += 3; PC = 0xA8E6;
                    return;
                case 0xA8EA:
                    { byte z = (byte)(0x28 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA8EC;
                    goto case 0xA8EC;
                case 0xA8EB:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xA8EC;
                    goto case 0xA8EC;
                case 0xA8EC:
                    _ram[(byte)(0xCE + X)] = Y; TotalCycles += 4; PC = 0xA8EE;
                    goto case 0xA8EE;
                case 0xA8ED:
                    { int a = 0x3D01; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xA8F0;
                    goto case 0xA8F0;
                case 0xA8EE:
                    A |= ReadMem(ReadU16Zp((byte)(0x3D + X))); SetZN(A); TotalCycles += 6; PC = 0xA8F0;
                    goto case 0xA8F0;
                case 0xA8EF:
                    A &= ReadMem(0x5EC1 + X); SetZN(A); TotalCycles += 4; PC = 0xA8F2;
                    return;
                case 0xA8F0:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x5E + X)))); TotalCycles += 6; PC = 0xA8F2;
                    return;
                case 0xA8F1:
                    { int a = 0x8F42 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xA8F4;
                    goto case 0xA8F4;
                case 0xA8F4:
                    TotalCycles += 6; PushU16(0xA8F6); PC = 0x97FD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA8F5:
                    Sbc(ReadMem(0x1197 + X)); TotalCycles += 4; PC = 0xA8F8;
                    return;
                case 0xA8F7:
                    A |= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA8F9;
                    goto case 0xA8F9;
                case 0xA8F9:
                    _ram[0xFE] = Rol(_ram[0xFE]); TotalCycles += 5; PC = 0xA8FB;
                    goto case 0xA8FB;
                case 0xA8FA:
                    { int a = 0x2B10 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA8FD;
                    return;
                case 0xA8FB:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xA928; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA928; }
                    PC = 0xA8FD; return;
                case 0xA902:
                    Cmp(Y, 0x41); TotalCycles += 2; PC = 0xA904;
                    return;
                case 0xA903:
                    A ^= ReadMem(ReadU16Zp((byte)(0xF7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA905;
                    return;
                case 0xA908:
                    Adc(0x0B); TotalCycles += 2; PC = 0xA90A;
                    return;
                case 0xA90D:
                    _ram[0x19] = Lsr(_ram[0x19]); TotalCycles += 5; PC = 0xA90F;
                    return;
                case 0xA90E:
                    A |= ReadMem(0x7193 + Y); SetZN(A); TotalCycles += 4; PC = 0xA911;
                    goto case 0xA911;
                case 0xA910:
                    Adc(ReadMem(ReadU16Zp(0x00) + Y)); TotalCycles += 5; PC = 0xA912;
                    return;
                case 0xA911:
                    TotalCycles += 7; PushU16(0xA913); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA913:
                    _ram[(byte)(0x7C + X)] = Y; TotalCycles += 4; PC = 0xA915;
                    return;
                case 0xA917:
                    A |= ReadMem(ReadU16Zp(0x93) + Y); SetZN(A); TotalCycles += 5; PC = 0xA919;
                    goto case 0xA919;
                case 0xA919:
                    A ^= ReadMem(ReadU16Zp((byte)(0xBF + X))); SetZN(A); TotalCycles += 6; PC = 0xA91B;
                    goto case 0xA91B;
                case 0xA91B:
                    A |= _ram[(byte)(0xFC + X)]; SetZN(A); TotalCycles += 4; PC = 0xA91D;
                    return;
                case 0xA91F:
                    A |= ReadMem(ReadU16Zp(0x2F) + Y); SetZN(A); TotalCycles += 5; PC = 0xA921;
                    goto case 0xA921;
                case 0xA921:
                    _ram[(byte)(0x50 + X)] = A; TotalCycles += 4; PC = 0xA923;
                    return;
                case 0xA922:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xA966; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xA966; }
                    PC = 0xA924; goto case 0xA924;
                case 0xA924:
                    A ^= ReadMem(ReadU16Zp(0x12) + Y); SetZN(A); TotalCycles += 5; PC = 0xA926;
                    goto case 0xA926;
                case 0xA926:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xA927;
                    return;
                case 0xA928:
                    X = _ram[0x12]; SetZN(X); TotalCycles += 3; PC = 0xA92A;
                    return;
                case 0xA92E:
                    _ram[0x43] = Lsr(_ram[0x43]); TotalCycles += 5; PC = 0xA930;
                    return;
                case 0xA932:
                    WriteIoReg(0xB749, A); TotalCycles += 4; PC = 0xA935;
                    return;
                case 0xA933:
                    A ^= 0xB7; SetZN(A); TotalCycles += 2; PC = 0xA935;
                    return;
                case 0xA937:
                    _ram[(byte)(0x49 + X)] = Y; TotalCycles += 4; PC = 0xA939;
                    return;
                case 0xA938:
                    A ^= 0x0B; SetZN(A); TotalCycles += 2; PC = 0xA93A;
                    return;
                case 0xA941:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x2F + X)))); TotalCycles += 6; PC = 0xA943;
                    goto case 0xA943;
                case 0xA943:
                    A |= _ram[(byte)(0x43 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA945;
                    return;
                case 0xA94A:
                    WriteMem(0x154A + X, A); TotalCycles += 5; PC = 0xA94D;
                    goto case 0xA94D;
                case 0xA94B:
                    A = Lsr(A); TotalCycles += 2; PC = 0xA94C;
                    goto case 0xA94C;
                case 0xA94C:
                    A |= _ram[(byte)(0xC1 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA94E;
                    goto case 0xA94E;
                case 0xA94D:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xA1 + X)))); TotalCycles += 6; PC = 0xA94F;
                    goto case 0xA94F;
                case 0xA94E:
                    A = ReadMem(ReadU16Zp((byte)(0x41 + X))); SetZN(A); TotalCycles += 6; PC = 0xA950;
                    return;
                case 0xA94F:
                    A ^= ReadMem(ReadU16Zp((byte)(0xC3 + X))); SetZN(A); TotalCycles += 6; PC = 0xA951;
                    return;
                case 0xA952:
                    { int a = 0x7D01 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA955;
                    goto case 0xA955;
                case 0xA953:
                    A |= ReadMem(ReadU16Zp((byte)(0x7D + X))); SetZN(A); TotalCycles += 6; PC = 0xA955;
                    goto case 0xA955;
                case 0xA954:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x1EC1 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xA957;
                    return;
                case 0xA955:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x9E + X)))); TotalCycles += 6; PC = 0xA957;
                    return;
                case 0xA959:
                    TotalCycles += 6; PushU16(0xA95B); PC = 0x52FD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA95A:
                    Sbc(ReadMem(0x2152 + X)); TotalCycles += 4; PC = 0xA95D;
                    return;
                case 0xA95C:
                    A &= ReadMem(ReadU16Zp((byte)(0x0F + X))); SetZN(A); TotalCycles += 6; PC = 0xA95E;
                    goto case 0xA95E;
                case 0xA95E:
                    TotalCycles += 6; PushU16(0xA960); PC = 0x446E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA95F:
                    _ram[0x0444] = Ror(_ram[0x0444]); TotalCycles += 6; PC = 0xA962;
                    goto case 0xA962;
                case 0xA962:
                    Sbc(ReadMem(ReadU16Zp(0x4C) + Y)); TotalCycles += 5; PC = 0xA964;
                    goto case 0xA964;
                case 0xA963:
                    TotalCycles += 3; PC = 0xAA01;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA964:
                    A |= ReadMem(ReadU16Zp((byte)(0xAA + X))); SetZN(A); TotalCycles += 6; PC = 0xA966;
                    goto case 0xA966;
                case 0xA965:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xA966;
                    goto case 0xA966;
                case 0xA966:
                    A &= _ram[(byte)(0xD9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA968;
                    return;
                case 0xA967:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x6E34 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xA96A;
                    goto case 0xA96A;
                case 0xA969:
                    _ram[0x0020] = IncVal(_ram[0x0020]); TotalCycles += 6; PC = 0xA96C;
                    return;
                case 0xA96A:
                    TotalCycles += 6; PushU16(0xA96C); PC = 0xB308;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA96B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xA96C;
                    return;
                case 0xA971:
                    { int a = 0x5321; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA974;
                    goto case 0xA974;
                case 0xA972:
                    A &= ReadMem(ReadU16Zp((byte)(0x53 + X))); SetZN(A); TotalCycles += 6; PC = 0xA974;
                    goto case 0xA974;
                case 0xA974:
                    TotalCycles += 6; PushU16(0xA976); PC = 0x017C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA976:
                    A |= ReadMem(ReadU16Zp((byte)(0x97 + X))); SetZN(A); TotalCycles += 6; PC = 0xA978;
                    goto case 0xA978;
                case 0xA978:
                    A &= ReadMem(ReadU16Zp((byte)(0xB7 + X))); SetZN(A); TotalCycles += 6; PC = 0xA97A;
                    return;
                case 0xA97C:
                    WriteMem(ReadU16Zp((byte)(0xE7 + X)), A); TotalCycles += 6; PC = 0xA97E;
                    return;
                case 0xA983:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x4502]; SetZN(Y); TotalCycles += 4; PC = 0xA986;
                    goto case 0xA986;
                case 0xA985:
                    Cmp(A, _ram[0x41]); TotalCycles += 3; PC = 0xA987;
                    goto case 0xA987;
                case 0xA986:
                    A ^= ReadMem(ReadU16Zp((byte)(0x49 + X))); SetZN(A); TotalCycles += 6; PC = 0xA988;
                    goto case 0xA988;
                case 0xA987:
                    A ^= 0xE0; SetZN(A); TotalCycles += 2; PC = 0xA989;
                    goto case 0xA989;
                case 0xA988:
                    Cmp(X, 0x58); TotalCycles += 2; PC = 0xA98A;
                    goto case 0xA98A;
                case 0xA989:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xA98A;
                    goto case 0xA98A;
                case 0xA98A:
                    Adc(ReadMem(ReadU16Zp((byte)(0x76 + X)))); TotalCycles += 6; PC = 0xA98C;
                    return;
                case 0xA98B:
                    { byte z = (byte)(0x64 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xA98D;
                    goto case 0xA98D;
                case 0xA98D:
                    _ram[0x65] = A; TotalCycles += 3; PC = 0xA98F;
                    goto case 0xA98F;
                case 0xA98E:
                    Adc(_ram[0x94]); TotalCycles += 3; PC = 0xA990;
                    goto case 0xA990;
                case 0xA98F:
                    _ram[(byte)(0x66 + X)] = Y; TotalCycles += 4; PC = 0xA991;
                    goto case 0xA991;
                case 0xA990:
                    _ram[0xA4] = Ror(_ram[0xA4]); TotalCycles += 5; PC = 0xA992;
                    return;
                case 0xA991:
                    Y = _ram[0x22]; SetZN(Y); TotalCycles += 3; PC = 0xA993;
                    goto case 0xA993;
                case 0xA993:
                    X = _ram[0x03]; SetZN(X); TotalCycles += 3; PC = 0xA995;
                    goto case 0xA995;
                case 0xA995:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xA996;
                    return;
                case 0xA999:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xA99A;
                    return;
                case 0xA99B:
                    _ram[(byte)(0x42 + Y)] = X; TotalCycles += 4; PC = 0xA99D;
                    return;
                case 0xA9A3:
                    { byte z = (byte)(0x21 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xA9A5;
                    return;
                case 0xA9A4:
                    A &= ReadMem(ReadU16Zp((byte)(0xFC + X))); SetZN(A); TotalCycles += 6; PC = 0xA9A6;
                    goto case 0xA9A6;
                case 0xA9A6:
                    _ram[0x26] = Asl(_ram[0x26]); TotalCycles += 5; PC = 0xA9A8;
                    return;
                case 0xA9A7:
                    _ram[0x80] = Rol(_ram[0x80]); TotalCycles += 5; PC = 0xA9A9;
                    goto case 0xA9A9;
                case 0xA9A9:
                    A = Rol(A); TotalCycles += 2; PC = 0xA9AA;
                    goto case 0xA9AA;
                case 0xA9AA:
                    Bit(_ram[0x36]); TotalCycles += 3; PC = 0xA9AC;
                    goto case 0xA9AC;
                case 0xA9AB:
                    { byte z = (byte)(0x01 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xA9AD;
                    goto case 0xA9AD;
                case 0xA9AC:
                    A |= ReadMem(ReadU16Zp((byte)(0x8C + X))); SetZN(A); TotalCycles += 6; PC = 0xA9AE;
                    goto case 0xA9AE;
                case 0xA9AD:
                    WriteIoReg(0xFF00, Y); TotalCycles += 4; PC = 0xA9B0;
                    goto case 0xA9B0;
                case 0xA9AE:
                    TotalCycles += 7; PushU16(0xA9B0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA9B0:
                    A &= _ram[(byte)(0x4E + X)]; SetZN(A); TotalCycles += 4; PC = 0xA9B2;
                    goto case 0xA9B2;
                case 0xA9B1:
                    { int a = 0x55A0; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xA9B4;
                    goto case 0xA9B4;
                case 0xA9B2:
                    Y = 0x55; SetZN(Y); TotalCycles += 2; PC = 0xA9B4;
                    goto case 0xA9B4;
                case 0xA9B3:
                    A ^= _ram[(byte)(0x21 + X)]; SetZN(A); TotalCycles += 4; PC = 0xA9B5;
                    return;
                case 0xA9B4:
                    A &= ReadMem(ReadU16Zp((byte)(0x77 + X))); SetZN(A); TotalCycles += 6; PC = 0xA9B6;
                    goto case 0xA9B6;
                case 0xA9B6:
                    TotalCycles += 6; PushU16(0xA9B8); PC = 0x0787;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA9BB:
                    X = ReadIoReg(0x4C21); SetZN(X); TotalCycles += 4; PC = 0xA9BE;
                    return;
                case 0xA9BC:
                    A &= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xA9BE;
                    return;
                case 0xA9BD:
                    TotalCycles += 3; PC = 0x9F82;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA9C1:
                    Cmp(X, _ram[0x0301]); TotalCycles += 4; PC = 0xA9C4;
                    return;
                case 0xA9C2:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0xA9C4;
                    return;
                case 0xA9C7:
                    WriteIoReg(0xAD4A, A); TotalCycles += 4; PC = 0xA9CA;
                    goto case 0xA9CA;
                case 0xA9C8:
                    A = Lsr(A); TotalCycles += 2; PC = 0xA9C9;
                    goto case 0xA9C9;
                case 0xA9C9:
                    A = _ram[0x0741]; SetZN(A); TotalCycles += 4; PC = 0xA9CC;
                    goto case 0xA9CC;
                case 0xA9CA:
                    A ^= ReadMem(ReadU16Zp((byte)(0x0F + X))); SetZN(A); TotalCycles += 6; PC = 0xA9CC;
                    goto case 0xA9CC;
                case 0xA9CC:
                    X = _ram[0xFD]; SetZN(X); TotalCycles += 3; PC = 0xA9CE;
                    goto case 0xA9CE;
                case 0xA9CD:
                    Sbc(ReadMem(0x5110 + X)); TotalCycles += 4; PC = 0xA9D0;
                    goto case 0xA9D0;
                case 0xA9CE:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xAA21; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xA9D0; goto case 0xA9D0;
                case 0xA9CF:
                    A ^= ReadMem(ReadU16Zp(0x4C) + Y); SetZN(A); TotalCycles += 5; PC = 0xA9D1;
                    goto case 0xA9D1;
                case 0xA9D0:
                    TotalCycles += 3; PC = 0xC700;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xA9D1:
                    TotalCycles += 7; PushU16(0xA9D3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xA9D4:
                    _ram[0x42] = DecVal(_ram[0x42]); TotalCycles += 5; PC = 0xA9D6;
                    return;
                case 0xA9DA:
                    A &= 0x12; SetZN(A); TotalCycles += 2; PC = 0xA9DC;
                    return;
                case 0xA9E0:
                    Adc(0x14); TotalCycles += 2; PC = 0xA9E2;
                    goto case 0xA9E2;
                case 0xA9E2:
                    A = _ram[0x12]; SetZN(A); TotalCycles += 3; PC = 0xA9E4;
                    goto case 0xA9E4;
                case 0xA9E4:
                    Y = _ram[0x42]; SetZN(Y); TotalCycles += 3; PC = 0xA9E6;
                    return;
                case 0xA9E8:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x44 + X)))); TotalCycles += 6; PC = 0xA9EA;
                    goto case 0xA9EA;
                case 0xA9EA:
                    P |= FlagD; TotalCycles += 2; PC = 0xA9EB;
                    goto case 0xA9EB;
                case 0xA9EB:
                    { byte z = (byte)(0x37 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xA9ED;
                    goto case 0xA9ED;
                case 0xA9ED:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x8F + X)))); TotalCycles += 6; PC = 0xA9EF;
                    goto case 0xA9EF;
                case 0xA9EF:
                    P |= FlagC; TotalCycles += 2; PC = 0xA9F0;
                    return;
                case 0xA9F2:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xA9F3;
                    return;
                case 0xA9F4:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xA9F5;
                    return;
                case 0xA9F6:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xA9F7;
                    return;
                case 0xA9F8:
                    Cmp(X, 0x6A); TotalCycles += 2; PC = 0xA9FA;
                    goto case 0xA9FA;
                case 0xA9F9:
                    A = Ror(A); TotalCycles += 2; PC = 0xA9FA;
                    goto case 0xA9FA;
                case 0xA9FA:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xAA66; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAA66; }
                    PC = 0xA9FC; goto case 0xA9FC;
                case 0xA9FB:
                    A = Ror(A); TotalCycles += 2; PC = 0xA9FC;
                    goto case 0xA9FC;
                case 0xA9FC:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x7DC5]); TotalCycles += 4; PC = 0xA9FF;
                    return;
                case 0xA9FD:
                    Cmp(A, _ram[0xFD]); TotalCycles += 3; PC = 0xA9FF;
                    return;
                case 0xA9FE:
                    Sbc(ReadMem(0x3192 + X)); TotalCycles += 4; PC = 0xAA01;
                    return;
                case 0xAA00:
                    A &= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xAA02;
                    goto case 0xAA02;
                case 0xAA02:
                    TotalCycles += 6; PushU16(0xAA04); PC = 0x406E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAA03:
                    _ram[0x0540] = Ror(_ram[0x0540]); TotalCycles += 6; PC = 0xAA06;
                    return;
                case 0xAA04:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAA05:
                    A |= ReadIoReg(0x3702); SetZN(A); TotalCycles += 4; PC = 0xAA08;
                    return;
                case 0xAA09:
                    Cmp(X, _ram[0x0400]); TotalCycles += 4; PC = 0xAA0C;
                    return;
                case 0xAA0A:
                    TotalCycles += 7; PushU16(0xAA0C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA0E:
                    TotalCycles += 7; PushU16(0xAA10); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA0F:
                    TotalCycles += 5; PC = ReadU16Zp(0x00); return;
                case 0xAA10:
                    TotalCycles += 7; PushU16(0xAA12); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA12:
                    TotalCycles += 7; PushU16(0xAA14); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA13:
                    _ram[0xC0] = Asl(_ram[0xC0]); TotalCycles += 5; PC = 0xAA15;
                    return;
                case 0xAA14:
                    Cmp(Y, 0xC7); TotalCycles += 2; PC = 0xAA16;
                    return;
                case 0xAA17:
                    _ram[0x83] = Asl(_ram[0x83]); TotalCycles += 5; PC = 0xAA19;
                    goto case 0xAA19;
                case 0xAA19:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xAA1A;
                    return;
                case 0xAA1B:
                    _ram[(byte)(0x40 + Y)] = X; TotalCycles += 4; PC = 0xAA1D;
                    return;
                case 0xAA1C:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAA1F:
                    _ram[0xC0] = Rol(_ram[0xC0]); TotalCycles += 5; PC = 0xAA21;
                    return;
                case 0xAA20:
                    Cmp(Y, 0x87); TotalCycles += 2; PC = 0xAA22;
                    return;
                case 0xAA24:
                    A ^= ReadMem(ReadU16Zp((byte)(0x39 + X))); SetZN(A); TotalCycles += 6; PC = 0xAA26;
                    goto case 0xAA26;
                case 0xAA25:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x48F1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAA28;
                    return;
                case 0xAA26:
                    Sbc(ReadMem(ReadU16Zp(0xC8) + Y)); TotalCycles += 5; PC = 0xAA28;
                    return;
                case 0xAA27:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xAA28;
                    return;
                case 0xAA36:
                    TotalCycles += 7; PushU16(0xAA38); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA37:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x6C00 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xAA3A;
                    goto case 0xAA3A;
                case 0xAA38:
                    TotalCycles += 7; PushU16(0xAA3A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA39:
                    Cmp(X, _ram[0x0400]); TotalCycles += 4; PC = 0xAA3C;
                    return;
                case 0xAA3A:
                    TotalCycles += 7; PushU16(0xAA3C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA3E:
                    TotalCycles += 7; PushU16(0xAA40); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA3F:
                    _ram[0x21] = X; TotalCycles += 3; PC = 0xAA41;
                    goto case 0xAA41;
                case 0xAA40:
                    A &= ReadMem(ReadU16Zp((byte)(0xA6 + X))); SetZN(A); TotalCycles += 6; PC = 0xAA42;
                    goto case 0xAA42;
                case 0xAA41:
                    X = _ram[0x06]; SetZN(X); TotalCycles += 3; PC = 0xAA43;
                    goto case 0xAA43;
                case 0xAA42:
                    _ram[0xB6] = Asl(_ram[0xB6]); TotalCycles += 5; PC = 0xAA44;
                    goto case 0xAA44;
                case 0xAA43:
                    X = _ram[(byte)(0x24 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xAA45;
                    return;
                case 0xAA44:
                    Bit(_ram[0x5C]); TotalCycles += 3; PC = 0xAA46;
                    return;
                case 0xAA48:
                    TotalCycles += 7; PushU16(0xAA4A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA4A:
                    TotalCycles += 7; PushU16(0xAA4C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA4B:
                    A &= 0xE1; SetZN(A); TotalCycles += 2; PC = 0xAA4D;
                    return;
                case 0xAA4C:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xDC + X)))); TotalCycles += 6; PC = 0xAA4E;
                    goto case 0xAA4E;
                case 0xAA4E:
                    A |= _ram[0xF6]; SetZN(A); TotalCycles += 3; PC = 0xAA50;
                    goto case 0xAA50;
                case 0xAA4F:
                    { byte z = (byte)(0x41 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xAA51;
                    return;
                case 0xAA50:
                    A ^= ReadMem(ReadU16Zp((byte)(0xDC + X))); SetZN(A); TotalCycles += 6; PC = 0xAA52;
                    return;
                case 0xAA53:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xAA54;
                    return;
                case 0xAA56:
                    WriteMem(ReadU16Zp((byte)(0x27 + X)), A); TotalCycles += 6; PC = 0xAA58;
                    return;
                case 0xAA59:
                    TotalCycles += 3; PC = 0x6601;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAA5A:
                    A |= ReadMem(ReadU16Zp((byte)(0x66 + X))); SetZN(A); TotalCycles += 6; PC = 0xAA5C;
                    return;
                case 0xAA5B:
                    _ram[0x74] = Ror(_ram[0x74]); TotalCycles += 5; PC = 0xAA5D;
                    goto case 0xAA5D;
                case 0xAA5D:
                    A |= ReadIoReg(0x3F11); SetZN(A); TotalCycles += 4; PC = 0xAA60;
                    goto case 0xAA60;
                case 0xAA5E:
                    A |= ReadMem(ReadU16Zp(0x3F) + Y); SetZN(A); TotalCycles += 5; PC = 0xAA60;
                    goto case 0xAA60;
                case 0xAA60:
                    A &= _ram[(byte)(0xB6 + X)]; SetZN(A); TotalCycles += 4; PC = 0xAA62;
                    goto case 0xAA62;
                case 0xAA61:
                    X = _ram[(byte)(0x41 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xAA63;
                    goto case 0xAA63;
                case 0xAA62:
                    A ^= ReadMem(ReadU16Zp((byte)(0x2C + X))); SetZN(A); TotalCycles += 6; PC = 0xAA64;
                    return;
                case 0xAA63:
                    Bit(ReadIoReg(0x3682)); TotalCycles += 4; PC = 0xAA66;
                    goto case 0xAA66;
                case 0xAA65:
                    { byte z = (byte)(0x40 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xAA67;
                    return;
                case 0xAA66:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAA69:
                    _ram[0x40] = X; TotalCycles += 3; PC = 0xAA6B;
                    goto case 0xAA6B;
                case 0xAA6A:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAA6B:
                    Sbc(ReadMem(0x3961 + Y)); TotalCycles += 4; PC = 0xAA6E;
                    goto case 0xAA6E;
                case 0xAA6C:
                    Adc(ReadMem(ReadU16Zp((byte)(0x39 + X)))); TotalCycles += 6; PC = 0xAA6E;
                    goto case 0xAA6E;
                case 0xAA6D:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x2CE1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAA70;
                    return;
                case 0xAA6E:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xAC + X)))); TotalCycles += 6; PC = 0xAA70;
                    return;
                case 0xAA6F:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x4604]; SetZN(Y); TotalCycles += 4; PC = 0xAA72;
                    goto case 0xAA72;
                case 0xAA71:
                    _ram[0x41] = DecVal(_ram[0x41]); TotalCycles += 5; PC = 0xAA73;
                    return;
                case 0xAA72:
                    A ^= ReadMem(ReadU16Zp((byte)(0x0C + X))); SetZN(A); TotalCycles += 6; PC = 0xAA74;
                    return;
                case 0xAA75:
                    { byte z = (byte)(0x41 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xAA77;
                    goto case 0xAA77;
                case 0xAA76:
                    A ^= ReadMem(ReadU16Zp((byte)(0x88 + X))); SetZN(A); TotalCycles += 6; PC = 0xAA78;
                    return;
                case 0xAA77:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xAA78;
                    return;
                case 0xAA79:
                    A &= ReadMem(0x7CF1 + Y); SetZN(A); TotalCycles += 4; PC = 0xAA7C;
                    goto case 0xAA7C;
                case 0xAA7A:
                    Sbc(ReadMem(ReadU16Zp(0x7C) + Y)); TotalCycles += 5; PC = 0xAA7C;
                    goto case 0xAA7C;
                case 0xAA7C:
                    TotalCycles += 7; PushU16(0xAA7E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA7E:
                    Adc(ReadMem(ReadU16Zp((byte)(0x9C + X)))); TotalCycles += 6; PC = 0xAA80;
                    goto case 0xAA80;
                case 0xAA80:
                    TotalCycles += 7; PushU16(0xAA82); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA83:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x4500 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xAA86;
                    goto case 0xAA86;
                case 0xAA84:
                    TotalCycles += 7; PushU16(0xAA86); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA85:
                    Cmp(A, _ram[0x65]); TotalCycles += 3; PC = 0xAA87;
                    return;
                case 0xAA86:
                    Adc(_ram[0xDC]); TotalCycles += 3; PC = 0xAA88;
                    goto case 0xAA88;
                case 0xAA88:
                    TotalCycles += 7; PushU16(0xAA8A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAA8D:
                    WriteIoReg(0xCFC1, A); TotalCycles += 4; PC = 0xAA90;
                    goto case 0xAA90;
                case 0xAA8E:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xCF + X)))); TotalCycles += 6; PC = 0xAA90;
                    goto case 0xAA90;
                case 0xAA90:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xAA92;
                    goto case 0xAA92;
                case 0xAA91:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x3155 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xAA94;
                    return;
                case 0xAA92:
                    A ^= _ram[(byte)(0xB1 + X)]; SetZN(A); TotalCycles += 4; PC = 0xAA94;
                    return;
                case 0xAA93:
                    A = ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xAA95;
                    goto case 0xAA95;
                case 0xAA95:
                    _ram[0xCF] = Rol(_ram[0xCF]); TotalCycles += 5; PC = 0xAA97;
                    return;
                case 0xAA9A:
                    A |= _ram[(byte)(0x11 + X)]; SetZN(A); TotalCycles += 4; PC = 0xAA9C;
                    return;
                case 0xAA9B:
                    A |= ReadMem(ReadU16Zp(0x52) + Y); SetZN(A); TotalCycles += 5; PC = 0xAA9D;
                    return;
                case 0xAA9E:
                    WriteMem(0xAC0B + Y, A); TotalCycles += 5; PC = 0xAAA1;
                    return;
                case 0xAAA0:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x5302]; SetZN(Y); TotalCycles += 4; PC = 0xAAA3;
                    goto case 0xAAA3;
                case 0xAAA3:
                    Bit(_ram[0xD6]); TotalCycles += 3; PC = 0xAAA5;
                    return;
                case 0xAAA4:
                    { byte z = (byte)(0x42 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xAAA6;
                    return;
                case 0xAAA7:
                    A &= _ram[0x23]; SetZN(A); TotalCycles += 3; PC = 0xAAA9;
                    goto case 0xAAA9;
                case 0xAAA9:
                    _ram[0xCF] = Y; TotalCycles += 3; PC = 0xAAAB;
                    return;
                case 0xAAAE:
                    A |= ReadMem(0x7861 + Y); SetZN(A); TotalCycles += 4; PC = 0xAAB1;
                    return;
                case 0xAAAF:
                    Adc(ReadMem(ReadU16Zp((byte)(0x78 + X)))); TotalCycles += 6; PC = 0xAAB1;
                    return;
                case 0xAAB0:
                    P |= FlagI; TotalCycles += 2; PC = 0xAAB1;
                    return;
                case 0xAAB4:
                    Bit(ReadIoReg(0x4681)); TotalCycles += 4; PC = 0xAAB7;
                    return;
                case 0xAAB5:
                    WriteMem(ReadU16Zp((byte)(0x46 + X)), A); TotalCycles += 6; PC = 0xAAB7;
                    return;
                case 0xAAB6:
                    _ram[0x64] = Lsr(_ram[0x64]); TotalCycles += 5; PC = 0xAAB8;
                    goto case 0xAAB8;
                case 0xAAB8:
                    A ^= _ram[(byte)(0x65 + X)]; SetZN(A); TotalCycles += 4; PC = 0xAABA;
                    goto case 0xAABA;
                case 0xAAB9:
                    Adc(_ram[0x65]); TotalCycles += 3; PC = 0xAABB;
                    goto case 0xAABB;
                case 0xAABA:
                    Adc(_ram[0x65]); TotalCycles += 3; PC = 0xAABC;
                    goto case 0xAABC;
                case 0xAABB:
                    Adc(_ram[0xEC]); TotalCycles += 3; PC = 0xAABD;
                    return;
                case 0xAABC:
                    Cmp(X, ReadIoReg(0x4774)); TotalCycles += 4; PC = 0xAABF;
                    return;
                case 0xAAC1:
                    A |= _ram[0x63]; SetZN(A); TotalCycles += 3; PC = 0xAAC3;
                    goto case 0xAAC3;
                case 0xAAC3:
                    A &= ReadMem(ReadU16Zp((byte)(0x62 + X))); SetZN(A); TotalCycles += 6; PC = 0xAAC5;
                    goto case 0xAAC5;
                case 0xAAC5:
                    A ^= ReadMem(ReadU16Zp((byte)(0x96 + X))); SetZN(A); TotalCycles += 6; PC = 0xAAC7;
                    return;
                case 0xAAC6:
                    _ram[(byte)(0x22 + Y)] = X; TotalCycles += 4; PC = 0xAAC8;
                    goto case 0xAAC8;
                case 0xAAC8:
                    SP = X; TotalCycles += 2; PC = 0xAAC9;
                    goto case 0xAAC9;
                case 0xAAC9:
                    A ^= ReadMem(ReadU16Zp((byte)(0xCC + X))); SetZN(A); TotalCycles += 6; PC = 0xAACB;
                    return;
                case 0xAACA:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x3903]); TotalCycles += 4; PC = 0xAACD;
                    goto case 0xAACD;
                case 0xAACC:
                    A = ReadMem(0x3991 + Y); SetZN(A); TotalCycles += 4; PC = 0xAACF;
                    goto case 0xAACF;
                case 0xAACD:
                    WriteMem(ReadU16Zp(0x39) + Y, A); TotalCycles += 6; PC = 0xAACF;
                    goto case 0xAACF;
                case 0xAACE:
                    A &= ReadMem(0x63F1 + Y); SetZN(A); TotalCycles += 4; PC = 0xAAD1;
                    goto case 0xAAD1;
                case 0xAACF:
                    Sbc(ReadMem(ReadU16Zp(0x63) + Y)); TotalCycles += 5; PC = 0xAAD1;
                    goto case 0xAAD1;
                case 0xAAD1:
                    _ram[0x67] = Rol(_ram[0x67]); TotalCycles += 5; PC = 0xAAD3;
                    return;
                case 0xAAD5:
                    _ram[0xFC] = Asl(_ram[0xFC]); TotalCycles += 5; PC = 0xAAD7;
                    goto case 0xAAD7;
                case 0xAAD7:
                    A |= ReadMem(ReadU16Zp((byte)(0x18 + X))); SetZN(A); TotalCycles += 6; PC = 0xAAD9;
                    return;
                case 0xAAD8:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xAAD9;
                    return;
                case 0xAADA:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x6907 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xAADD;
                    return;
                case 0xAADC:
                    Sbc(0x04); TotalCycles += 2; PC = 0xAADE;
                    return;
                case 0xAADF:
                    _ram[0x37] = X; TotalCycles += 3; PC = 0xAAE1;
                    return;
                case 0xAAE3:
                    Bit(_ram[0x87]); TotalCycles += 3; PC = 0xAAE5;
                    goto case 0xAAE5;
                case 0xAAE5:
                    _ram[0xAC] = Y; TotalCycles += 3; PC = 0xAAE7;
                    return;
                case 0xAAE6:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x4202]; SetZN(Y); TotalCycles += 4; PC = 0xAAE9;
                    goto case 0xAAE9;
                case 0xAAE9:
                    A ^= ReadMem(ReadU16Zp((byte)(0xC3 + X))); SetZN(A); TotalCycles += 6; PC = 0xAAEB;
                    return;
                case 0xAAEC:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7C71 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xAAEF;
                    goto case 0xAAEF;
                case 0xAAED:
                    Adc(ReadMem(ReadU16Zp(0xFC) + Y)); TotalCycles += 5; PC = 0xAAEF;
                    goto case 0xAAEF;
                case 0xAAEF:
                    A |= ReadMem(ReadU16Zp((byte)(0x7F + X))); SetZN(A); TotalCycles += 6; PC = 0xAAF1;
                    goto case 0xAAF1;
                case 0xAAF1:
                    A = ReadMem(ReadU16Zp(0x9C) + Y); SetZN(A); TotalCycles += 5; PC = 0xAAF3;
                    goto case 0xAAF3;
                case 0xAAF3:
                    TotalCycles += 7; PushU16(0xAAF5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAAF6:
                    X = _ram[(byte)(0x64 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xAAF8;
                    goto case 0xAAF8;
                case 0xAAF8:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x5400]); TotalCycles += 4; PC = 0xAAFB;
                    goto case 0xAAFB;
                case 0xAAF9:
                    TotalCycles += 7; PushU16(0xAAFB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAAFB:
                    _ram[0xE3] = Ror(_ram[0xE3]); TotalCycles += 5; PC = 0xAAFD;
                    return;
                case 0xAB00:
                    WriteIoReg(0xCFC1, A); TotalCycles += 4; PC = 0xAB03;
                    goto case 0xAB03;
                case 0xAB01:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xCF + X)))); TotalCycles += 6; PC = 0xAB03;
                    goto case 0xAB03;
                case 0xAB03:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xAB05;
                    goto case 0xAB05;
                case 0xAB04:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x3150 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xAB07;
                    return;
                case 0xAB05:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAAB8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAAB8; }
                    PC = 0xAB07; return;
                case 0xAB06:
                    A = ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xAB08;
                    goto case 0xAB08;
                case 0xAB08:
                    _ram[0xFC] = Rol(_ram[0xFC]); TotalCycles += 5; PC = 0xAB0A;
                    goto case 0xAB0A;
                case 0xAB0A:
                    TotalCycles += 7; PushU16(0xAB0C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB0E:
                    TotalCycles += 7; PushU16(0xAB10); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB0F:
                    Adc(_ram[0x65]); TotalCycles += 3; PC = 0xAB11;
                    return;
                case 0xAB10:
                    Adc(_ram[0x74]); TotalCycles += 3; PC = 0xAB12;
                    goto case 0xAB12;
                case 0xAB12:
                    _ram[0x83] = Ror(_ram[0x83]); TotalCycles += 5; PC = 0xAB14;
                    return;
                case 0xAB19:
                    TotalCycles += 3; PC = 0xB380;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB380;
                case 0xAB1C:
                    TotalCycles += 6; PushU16(0xAB1E); PC = 0x0BC9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAB1D:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0xAB1F;
                    return;
                case 0xAB20:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAB21;
                    return;
                case 0xAB24:
                    TotalCycles += 7; PushU16(0xAB26); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB25:
                    Bit(ReadIoReg(0x4C80)); TotalCycles += 4; PC = 0xAB28;
                    goto case 0xAB28;
                case 0xAB27:
                    TotalCycles += 3; PC = 0x8C00;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAB28:
                    TotalCycles += 7; PushU16(0xAB2A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB29:
                    WriteIoReg(0xD300, Y); TotalCycles += 4; PC = 0xAB2C;
                    goto case 0xAB2C;
                case 0xAB2A:
                    TotalCycles += 7; PushU16(0xAB2C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB2C:
                    { int a = 0x4AED; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xAB2F;
                    return;
                case 0xAB2D:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x7C4A]); TotalCycles += 4; PC = 0xAB30;
                    goto case 0xAB30;
                case 0xAB2E:
                    A = Lsr(A); TotalCycles += 2; PC = 0xAB2F;
                    return;
                case 0xAB30:
                    TotalCycles += 7; PushU16(0xAB32); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB32:
                    A = ReadMem(ReadU16Zp((byte)(0xEC + X))); SetZN(A); TotalCycles += 6; PC = 0xAB34;
                    goto case 0xAB34;
                case 0xAB33:
                    Cmp(X, ReadIoReg(0x4C01)); TotalCycles += 4; PC = 0xAB36;
                    return;
                case 0xAB34:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xAB36;
                    return;
                case 0xAB35:
                    TotalCycles += 3; PC = 0x5980;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAB37:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x5811 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAB3A;
                    goto case 0xAB3A;
                case 0xAB38:
                    A |= ReadMem(ReadU16Zp(0xD8) + Y); SetZN(A); TotalCycles += 5; PC = 0xAB3A;
                    goto case 0xAB3A;
                case 0xAB39:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xAB3A;
                    goto case 0xAB3A;
                case 0xAB3A:
                    A |= ReadMem(ReadU16Zp(0xDA) + Y); SetZN(A); TotalCycles += 5; PC = 0xAB3C;
                    goto case 0xAB3C;
                case 0xAB3C:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xAB75; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xAB3E; goto case 0xAB3E;
                case 0xAB3E:
                    Y = 0x47; SetZN(Y); TotalCycles += 2; PC = 0xAB40;
                    return;
                case 0xAB41:
                    WriteMem(0xE711 + Y, A); TotalCycles += 5; PC = 0xAB44;
                    goto case 0xAB44;
                case 0xAB42:
                    A |= ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0xAB44;
                    goto case 0xAB44;
                case 0xAB44:
                    A &= ReadMem(ReadU16Zp((byte)(0x3A + X))); SetZN(A); TotalCycles += 6; PC = 0xAB46;
                    goto case 0xAB46;
                case 0xAB46:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xABAF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xAB48; goto case 0xAB48;
                case 0xAB48:
                    TotalCycles += 6; PushU16(0xAB4A); PC = 0x1076;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAB49:
                    { byte z = (byte)(0x10 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xAB4B;
                    return;
                case 0xAB4A:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xABC3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xABC3; }
                    PC = 0xAB4C; goto case 0xAB4C;
                case 0xAB4C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xAB4F:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xAB50;
                    return;
                case 0xAB51:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x2CF1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAB54;
                    goto case 0xAB54;
                case 0xAB52:
                    Sbc(ReadMem(ReadU16Zp(0xAC) + Y)); TotalCycles += 5; PC = 0xAB54;
                    goto case 0xAB54;
                case 0xAB53:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x6900]; SetZN(Y); TotalCycles += 4; PC = 0xAB56;
                    goto case 0xAB56;
                case 0xAB54:
                    TotalCycles += 7; PushU16(0xAB56); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB55:
                    Sbc(0x71); TotalCycles += 2; PC = 0xAB57;
                    return;
                case 0xAB56:
                    Adc(ReadMem(ReadU16Zp(0x0C) + Y)); TotalCycles += 5; PC = 0xAB58;
                    return;
                case 0xAB59:
                    Bit(ReadIoReg(0x4C00)); TotalCycles += 4; PC = 0xAB5C;
                    goto case 0xAB5C;
                case 0xAB5A:
                    TotalCycles += 7; PushU16(0xAB5C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB5B:
                    TotalCycles += 3; PC = 0xC705;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAB5C:
                    A |= _ram[0xC7]; SetZN(A); TotalCycles += 3; PC = 0xAB5E;
                    return;
                case 0xAB5F:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x6CF1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAB62;
                    goto case 0xAB62;
                case 0xAB60:
                    Sbc(ReadMem(ReadU16Zp(0xEC) + Y)); TotalCycles += 5; PC = 0xAB62;
                    goto case 0xAB62;
                case 0xAB61:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x7900]); TotalCycles += 4; PC = 0xAB64;
                    goto case 0xAB64;
                case 0xAB62:
                    TotalCycles += 7; PushU16(0xAB64); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB63:
                    Sbc(ReadMem(0x0C11 + Y)); TotalCycles += 4; PC = 0xAB66;
                    return;
                case 0xAB64:
                    A |= ReadMem(ReadU16Zp(0x0C) + Y); SetZN(A); TotalCycles += 5; PC = 0xAB66;
                    return;
                case 0xAB69:
                    P |= FlagD; TotalCycles += 2; PC = 0xAB6A;
                    goto case 0xAB6A;
                case 0xAB6A:
                    A |= ReadMem(ReadU16Zp(0xFA) + Y); SetZN(A); TotalCycles += 5; PC = 0xAB6C;
                    goto case 0xAB6C;
                case 0xAB6C:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xABED; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xAB6E; return;
                case 0xAB6F:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x3600]; SetZN(Y); TotalCycles += 4; PC = 0xAB72;
                    return;
                case 0xAB70:
                    TotalCycles += 7; PushU16(0xAB72); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAB71:
                    X = _ram[(byte)(0x64 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xAB73;
                    goto case 0xAB73;
                case 0xAB73:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x6301]); TotalCycles += 4; PC = 0xAB76;
                    return;
                case 0xAB74:
                    A |= ReadMem(ReadU16Zp((byte)(0xE3 + X))); SetZN(A); TotalCycles += 6; PC = 0xAB76;
                    return;
                case 0xAB79:
                    WriteIoReg(0xCFC1, A); TotalCycles += 4; PC = 0xAB7C;
                    goto case 0xAB7C;
                case 0xAB7A:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xCF + X)))); TotalCycles += 6; PC = 0xAB7C;
                    goto case 0xAB7C;
                case 0xAB7C:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xAB7E;
                    return;
                case 0xAB7D:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x3152 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xAB80;
                    return;
                case 0xAB7F:
                    A = ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xAB81;
                    goto case 0xAB81;
                case 0xAB81:
                    TotalCycles += 6; PushU16(0xAB83); PC = 0x456E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAB82:
                    { int a = 0x3945; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xAB85;
                    goto case 0xAB85;
                case 0xAB83:
                    A ^= _ram[0x39]; SetZN(A); TotalCycles += 3; PC = 0xAB85;
                    goto case 0xAB85;
                case 0xAB84:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x3391 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAB87;
                    return;
                case 0xAB85:
                    WriteMem(ReadU16Zp(0xB3) + Y, A); TotalCycles += 6; PC = 0xAB87;
                    return;
                case 0xAB89:
                    A &= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xAB8B;
                    goto case 0xAB8B;
                case 0xAB8A:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xAB8B;
                    goto case 0xAB8B;
                case 0xAB8B:
                    A |= ReadMem(ReadU16Zp(0xCA) + Y); SetZN(A); TotalCycles += 5; PC = 0xAB8D;
                    goto case 0xAB8D;
                case 0xAB8C:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xAB8D;
                    goto case 0xAB8D;
                case 0xAB8D:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xABD8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xABD8; }
                    PC = 0xAB8F; goto case 0xAB8F;
                case 0xAB8E:
                    A ^= 0x91; SetZN(A); TotalCycles += 2; PC = 0xAB90;
                    return;
                case 0xAB8F:
                    WriteMem(ReadU16Zp(0x7C) + Y, A); TotalCycles += 6; PC = 0xAB91;
                    return;
                case 0xAB92:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xAB93;
                    return;
                case 0xAB94:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xAB95;
                    goto case 0xAB95;
                case 0xAB95:
                    WriteMem(ReadU16Zp(0x8A) + Y, A); TotalCycles += 6; PC = 0xAB97;
                    goto case 0xAB97;
                case 0xAB96:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xAB97;
                    goto case 0xAB97;
                case 0xAB97:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xAB80; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xAB99; goto case 0xAB99;
                case 0xAB99:
                    A &= ReadMem(ReadU16Zp((byte)(0x05 + X))); SetZN(A); TotalCycles += 6; PC = 0xAB9B;
                    goto case 0xAB9B;
                case 0xAB9A: // === SUBROUTINE: Sub_AB9A ===
                    A |= _ram[0x91]; SetZN(A); TotalCycles += 3; PC = 0xAB9C;
                    return;
                case 0xAB9B:
                    WriteMem(ReadU16Zp(0x07) + Y, A); TotalCycles += 6; PC = 0xAB9D;
                    goto case 0xAB9D;
                case 0xAB9D:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xABB6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xABB6; }
                    PC = 0xAB9F; return;
                case 0xABA1:
                    TotalCycles += 6; PushU16(0xABA3); PC = 0x1149;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABA2:
                    A ^= 0x11; SetZN(A); TotalCycles += 2; PC = 0xABA4;
                    return;
                case 0xABA3:
                    A |= ReadMem(ReadU16Zp(0x9C) + Y); SetZN(A); TotalCycles += 5; PC = 0xABA5;
                    goto case 0xABA5;
                case 0xABA5:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xABA7;
                    return;
                case 0xABA6:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xABA7;
                    return;
                case 0xABA9:
                    X = _ram[0x27]; SetZN(X); TotalCycles += 3; PC = 0xABAB;
                    goto case 0xABAB;
                case 0xABAB:
                    _ram[0xD3] = Rol(_ram[0xD3]); TotalCycles += 5; PC = 0xABAD;
                    return;
                case 0xABAE:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xABAF;
                    return;
                case 0xABB1:
                    WriteMem(ReadU16Zp(0xD8) + Y, A); TotalCycles += 6; PC = 0xABB3;
                    return;
                case 0xABB2:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xABB3;
                    return;
                case 0xABB4:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x29F1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xABB7;
                    goto case 0xABB7;
                case 0xABB5:
                    Sbc(ReadMem(ReadU16Zp(0xA9) + Y)); TotalCycles += 5; PC = 0xABB7;
                    goto case 0xABB7;
                case 0xABB6:
                    A = 0x11; SetZN(A); TotalCycles += 2; PC = 0xABB8;
                    goto case 0xABB8;
                case 0xABB7:
                    A |= ReadMem(ReadU16Zp(0x09) + Y); SetZN(A); TotalCycles += 5; PC = 0xABB9;
                    goto case 0xABB9;
                case 0xABB8:
                    A |= 0xF1; SetZN(A); TotalCycles += 2; PC = 0xABBA;
                    return;
                case 0xABB9:
                    Sbc(ReadMem(ReadU16Zp(0x63) + Y)); TotalCycles += 5; PC = 0xABBB;
                    goto case 0xABBB;
                case 0xABBB:
                    Bit(_ram[0x67]); TotalCycles += 3; PC = 0xABBD;
                    goto case 0xABBD;
                case 0xABBD:
                    Bit(_ram[0xD8]); TotalCycles += 3; PC = 0xABBF;
                    return;
                case 0xABBE:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xABBF;
                    return;
                case 0xABC0:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xABC1;
                    goto case 0xABC1;
                case 0xABC1:
                    WriteMem(ReadU16Zp(0x2A) + Y, A); TotalCycles += 6; PC = 0xABC3;
                    goto case 0xABC3;
                case 0xABC2:
                    A = Rol(A); TotalCycles += 2; PC = 0xABC3;
                    goto case 0xABC3;
                case 0xABC3:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xAC1B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAC1B; }
                    PC = 0xABC5; goto case 0xABC5;
                case 0xABC4:
                    { byte z = (byte)(0x21 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xABC6;
                    goto case 0xABC6;
                case 0xABC5:
                    A &= ReadMem(ReadU16Zp((byte)(0x70 + X))); SetZN(A); TotalCycles += 6; PC = 0xABC7;
                    return;
                case 0xABC6:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xABCC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xABCC; }
                    PC = 0xABC8; goto case 0xABC8;
                case 0xABC8:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x0C0B + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xABCB;
                    goto case 0xABCB;
                case 0xABCA:
                    WriteIoReg(0x9400, Y); TotalCycles += 4; PC = 0xABCD;
                    goto case 0xABCD;
                case 0xABCB:
                    TotalCycles += 7; PushU16(0xABCD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xABCC:
                    _ram[(byte)(0x21 + X)] = Y; TotalCycles += 4; PC = 0xABCE;
                    return;
                case 0xABCD:
                    A &= ReadMem(ReadU16Zp((byte)(0x9F + X))); SetZN(A); TotalCycles += 6; PC = 0xABCF;
                    goto case 0xABCF;
                case 0xABCF:
                    A &= _ram[(byte)(0x2F + X)]; SetZN(A); TotalCycles += 4; PC = 0xABD1;
                    goto case 0xABD1;
                case 0xABD1:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xABD2;
                    goto case 0xABD2;
                case 0xABD2:
                    A &= ReadMem(0x7FC1 + X); SetZN(A); TotalCycles += 4; PC = 0xABD5;
                    goto case 0xABD5;
                case 0xABD3:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x7F + X)))); TotalCycles += 6; PC = 0xABD5;
                    goto case 0xABD5;
                case 0xABD5:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xABD7;
                    goto case 0xABD7;
                case 0xABD6:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x4106 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xABD9;
                    goto case 0xABD9;
                case 0xABD7:
                    _ram[0xC1] = Asl(_ram[0xC1]); TotalCycles += 5; PC = 0xABD9;
                    goto case 0xABD9;
                case 0xABD8:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x4C + X)))); TotalCycles += 6; PC = 0xABDA;
                    goto case 0xABDA;
                case 0xABD9:
                    TotalCycles += 3; PC = 0xF400;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABDA:
                    TotalCycles += 7; PushU16(0xABDC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xABDD:
                    A |= _ram[0x0602]; SetZN(A); TotalCycles += 4; PC = 0xABE0;
                    goto case 0xABE0;
                case 0xABDF:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xABE1;
                    goto case 0xABE1;
                case 0xABE0:
                    TotalCycles += 6; PushU16(0xABE2); PC = 0x4F24;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABE1:
                    Bit(_ram[0x4F]); TotalCycles += 3; PC = 0xABE3;
                    goto case 0xABE3;
                case 0xABE3:
                    A &= _ram[(byte)(0xA0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xABE5;
                    goto case 0xABE5;
                case 0xABE4:
                    Y = 0x36; SetZN(Y); TotalCycles += 2; PC = 0xABE6;
                    goto case 0xABE6;
                case 0xABE5:
                    { byte z = (byte)(0x20 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xABE7;
                    return;
                case 0xABE6:
                    TotalCycles += 6; PushU16(0xABE8); PC = 0x4653;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABE8:
                    _ram[0xD5] = Lsr(_ram[0xD5]); TotalCycles += 5; PC = 0xABEA;
                    goto case 0xABEA;
                case 0xABE9:
                    Cmp(A, _ram[(byte)(0x20 + X)]); TotalCycles += 4; PC = 0xABEB;
                    goto case 0xABEB;
                case 0xABEA:
                    TotalCycles += 6; PushU16(0xABEC); PC = 0x20D6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABEB:
                    { byte z = (byte)(0x20 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xABED;
                    return;
                case 0xABEC:
                    TotalCycles += 6; PushU16(0xABEE); PC = 0xA134;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xA134;
                case 0xABEE:
                    A = ReadMem(ReadU16Zp((byte)(0x73 + X))); SetZN(A); TotalCycles += 6; PC = 0xABF0;
                    goto case 0xABF0;
                case 0xABF0:
                    A ^= 0x74; SetZN(A); TotalCycles += 2; PC = 0xABF2;
                    goto case 0xABF2;
                case 0xABF2:
                    TotalCycles += 6; PushU16(0xABF4); PC = 0x2094;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABF3:
                    _ram[(byte)(0x20 + X)] = Y; TotalCycles += 4; PC = 0xABF5;
                    goto case 0xABF5;
                case 0xABF4:
                    TotalCycles += 6; PushU16(0xABF6); PC = 0x20B4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABF5:
                    Y = _ram[(byte)(0x20 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xABF7;
                    return;
                case 0xABF6:
                    TotalCycles += 6; PushU16(0xABF8); PC = 0x20D4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABF8:
                    TotalCycles += 6; PushU16(0xABFA); PC = 0x20F4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABFA:
                    TotalCycles += 6; PushU16(0xABFC); PC = 0x802E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xABFB:
                    { int a = 0x5980; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xABFE;
                    return;
                case 0xABFD:
                    A ^= ReadMem(0x4D42 + Y); SetZN(A); TotalCycles += 4; PC = 0xAC00;
                    return;
                case 0xABFF:
                    A ^= SmbEmbeddedAssets.StaticDataTables[0x7DC7]; SetZN(A); TotalCycles += 4; PC = 0xAC02;
                    goto case 0xAC02;
                case 0xAC01:
                    Sbc(ReadMem(0x3196 + X)); TotalCycles += 4; PC = 0xAC04;
                    return;
                case 0xAC02:
                    _ram[(byte)(0x31 + Y)] = X; TotalCycles += 4; PC = 0xAC04;
                    return;
                case 0xAC03:
                    A &= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0xAC05;
                    goto case 0xAC05;
                case 0xAC05:
                    _ram[0x0D] = Rol(_ram[0x0D]); TotalCycles += 5; PC = 0xAC07;
                    return;
                case 0xAC06:
                    A |= _ram[0x0203]; SetZN(A); TotalCycles += 4; PC = 0xAC09;
                    goto case 0xAC09;
                case 0xAC09:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xAC0C:
                    Cmp(Y, _ram[0x00]); TotalCycles += 3; PC = 0xAC0E;
                    goto case 0xAC0E;
                case 0xAC0D:
                    TotalCycles += 7; PushU16(0xAC0F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAC0E:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xAC0F;
                    return;
                case 0xAC10:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x53E1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAC13;
                    goto case 0xAC13;
                case 0xAC11:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xD3 + X)))); TotalCycles += 6; PC = 0xAC13;
                    goto case 0xAC13;
                case 0xAC13:
                    _ram[0xD7] = Asl(_ram[0xD7]); TotalCycles += 5; PC = 0xAC15;
                    return;
                case 0xAC16:
                    Sbc(ReadMem(0x0C61 + Y)); TotalCycles += 4; PC = 0xAC19;
                    goto case 0xAC19;
                case 0xAC17:
                    Adc(ReadMem(ReadU16Zp((byte)(0x0C + X)))); TotalCycles += 6; PC = 0xAC19;
                    goto case 0xAC19;
                case 0xAC19:
                    WriteMem(ReadU16Zp((byte)(0x4E + X)), A); TotalCycles += 6; PC = 0xAC1B;
                    goto case 0xAC1B;
                case 0xAC1A:
                    { int a = 0x8EB1; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xAC1D;
                    goto case 0xAC1D;
                case 0xAC1B:
                    A = ReadMem(ReadU16Zp(0x8E) + Y); SetZN(A); TotalCycles += 5; PC = 0xAC1D;
                    goto case 0xAC1D;
                case 0xAC1C:
                    WriteIoReg(0xBCB1, X); TotalCycles += 4; PC = 0xAC1F;
                    goto case 0xAC1F;
                case 0xAC1D:
                    A = ReadMem(ReadU16Zp(0xBC) + Y); SetZN(A); TotalCycles += 5; PC = 0xAC1F;
                    goto case 0xAC1F;
                case 0xAC1E:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x6401 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xAC21;
                    goto case 0xAC21;
                case 0xAC1F:
                    A |= ReadMem(ReadU16Zp((byte)(0xE4 + X))); SetZN(A); TotalCycles += 6; PC = 0xAC21;
                    goto case 0xAC21;
                case 0xAC20:
                    Cmp(X, _ram[0x50]); TotalCycles += 3; PC = 0xAC22;
                    goto case 0xAC22;
                case 0xAC21:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAC0C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAC0C; }
                    PC = 0xAC23; goto case 0xAC23;
                case 0xAC22:
                    Sbc(0x61); TotalCycles += 2; PC = 0xAC24;
                    return;
                case 0xAC23:
                    Adc(ReadMem(ReadU16Zp((byte)(0x0C + X)))); TotalCycles += 6; PC = 0xAC25;
                    goto case 0xAC25;
                case 0xAC25:
                    WriteMem(ReadU16Zp((byte)(0x0D + X)), A); TotalCycles += 6; PC = 0xAC27;
                    goto case 0xAC27;
                case 0xAC26:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x040A]; SetZN(A); TotalCycles += 4; PC = 0xAC29;
                    return;
                case 0xAC27:
                    A = Asl(A); TotalCycles += 2; PC = 0xAC28;
                    goto case 0xAC28;
                case 0xAC28:
                    _ram[0x43] = Y; TotalCycles += 3; PC = 0xAC2A;
                    goto case 0xAC2A;
                case 0xAC2A:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xAC2B;
                    return;
                case 0xAC2C:
                    A |= _ram[0x070C]; SetZN(A); TotalCycles += 4; PC = 0xAC2F;
                    goto case 0xAC2F;
                case 0xAC2F:
                    P |= FlagC; TotalCycles += 2; PC = 0xAC30;
                    goto case 0xAC30;
                case 0xAC30:
                    A |= ReadMem(0x5FC1 + X); SetZN(A); TotalCycles += 4; PC = 0xAC33;
                    goto case 0xAC33;
                case 0xAC31:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x5F + X)))); TotalCycles += 6; PC = 0xAC33;
                    goto case 0xAC33;
                case 0xAC33:
                    _ram[0xFD] = Rol(_ram[0xFD]); TotalCycles += 5; PC = 0xAC35;
                    goto case 0xAC35;
                case 0xAC34:
                    Sbc(ReadMem(0x0F48 + X)); TotalCycles += 4; PC = 0xAC37;
                    goto case 0xAC37;
                case 0xAC35:
                    PushU8(A); TotalCycles += 3; PC = 0xAC36;
                    return;
                case 0xAC37:
                    { int a = 0x5E01; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xAC3A;
                    return;
                case 0xAC38:
                    A |= ReadMem(ReadU16Zp((byte)(0x5E + X))); SetZN(A); TotalCycles += 6; PC = 0xAC3A;
                    return;
                case 0xAC39:
                    { int a = 0xA702 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xAC3C;
                    goto case 0xAC3C;
                case 0xAC3C:
                    TotalCycles += 7; PushU16(0xAC3E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAC3D:
                    Y = ReadMem(0x1A73 + X); SetZN(Y); TotalCycles += 4; PC = 0xAC40;
                    goto case 0xAC40;
                case 0xAC40:
                    Cmp(X, 0x39); TotalCycles += 2; PC = 0xAC42;
                    goto case 0xAC42;
                case 0xAC41:
                    A &= ReadMem(0x5861 + Y); SetZN(A); TotalCycles += 4; PC = 0xAC44;
                    return;
                case 0xAC42:
                    Adc(ReadMem(ReadU16Zp((byte)(0x58 + X)))); TotalCycles += 6; PC = 0xAC44;
                    return;
                case 0xAC43:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xAC44;
                    return;
                case 0xAC49:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xAC4A;
                    return;
                case 0xAC4B:
                    { byte z = (byte)(0x07 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xAC4D;
                    goto case 0xAC4D;
                case 0xAC4D:
                    P |= FlagD; TotalCycles += 2; PC = 0xAC4E;
                    return;
                case 0xAC4F:
                    A |= ReadMem(0x75E1 + Y); SetZN(A); TotalCycles += 4; PC = 0xAC52;
                    return;
                case 0xAC50:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x75 + X)))); TotalCycles += 6; PC = 0xAC52;
                    return;
                case 0xAC51:
                    Adc(_ram[(byte)(0x52 + X)]); TotalCycles += 4; PC = 0xAC53;
                    goto case 0xAC53;
                case 0xAC53:
                    _ram[0x40] = X; TotalCycles += 3; PC = 0xAC55;
                    return;
                case 0xAC54:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAC56:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xABED; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xAC58; return;
                case 0xAC57:
                    _ram[(byte)(0x52 + X)] = A; TotalCycles += 4; PC = 0xAC59;
                    return;
                case 0xAC5B:
                    A = _ram[0x21]; SetZN(A); TotalCycles += 3; PC = 0xAC5D;
                    goto case 0xAC5D;
                case 0xAC5C:
                    A &= ReadMem(ReadU16Zp((byte)(0xC5 + X))); SetZN(A); TotalCycles += 6; PC = 0xAC5E;
                    return;
                case 0xAC5D:
                    Cmp(A, _ram[0x52]); TotalCycles += 3; PC = 0xAC5F;
                    goto case 0xAC5F;
                case 0xAC5F:
                    { byte z = (byte)(0x40 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xAC61;
                    return;
                case 0xAC60:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAC62:
                    TotalCycles += 6; PushU16(0xAC64); PC = 0x06E5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAC63:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0xAC65;
                    goto case 0xAC65;
                case 0xAC64:
                    _ram[0xE6] = Asl(_ram[0xE6]); TotalCycles += 5; PC = 0xAC66;
                    goto case 0xAC66;
                case 0xAC65:
                    _ram[0x51] = IncVal(_ram[0x51]); TotalCycles += 5; PC = 0xAC67;
                    goto case 0xAC67;
                case 0xAC66:
                    A ^= ReadMem(ReadU16Zp(0x3E) + Y); SetZN(A); TotalCycles += 5; PC = 0xAC68;
                    goto case 0xAC68;
                case 0xAC67:
                    { int a = 0x5E8D + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xAC6A;
                    return;
                case 0xAC68:
                    _ram[0x035E] = A; TotalCycles += 4; PC = 0xAC6B;
                    return;
                case 0xAC69:
                    { int a = 0x6703 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xAC6C;
                    return;
                case 0xAC6F:
                    { int a = 0x9E02 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0xAC72;
                    return;
                case 0xAC73:
                    X = _ram[0x43]; SetZN(X); TotalCycles += 3; PC = 0xAC75;
                    return;
                case 0xAC77:
                    { int a = 0xFE05 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAC7A;
                    return;
                case 0xAC78:
                    A |= _ram[0xFE]; SetZN(A); TotalCycles += 3; PC = 0xAC7A;
                    return;
                case 0xAC79:
                    { int a = 0x1E02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAC7C;
                    return;
                case 0xAC7B:
                    { int a = 0x3383 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xAC7E;
                    return;
                case 0xAC7F:
                    _ram[0x40] = Lsr(_ram[0x40]); TotalCycles += 5; PC = 0xAC81;
                    return;
                case 0xAC80:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAC82:
                    A &= ReadMem(ReadU16Zp((byte)(0x56 + X))); SetZN(A); TotalCycles += 6; PC = 0xAC84;
                    return;
                case 0xAC83:
                    { byte z = (byte)(0x04 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xAC85;
                    goto case 0xAC85;
                case 0xAC85:
                    { int a = 0x8302 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xAC88;
                    return;
                case 0xAC8B:
                    _ram[(byte)(0x07 + Y)] = X; TotalCycles += 4; PC = 0xAC8D;
                    return;
                case 0xAC8E:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAC4E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xAC90; return;
                case 0xAC8F:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x4703 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xAC92;
                    return;
                case 0xAC93:
                    { int a = 0x0C02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAC96;
                    return;
                case 0xAC98:
                    A ^= _ram[0x45]; SetZN(A); TotalCycles += 3; PC = 0xAC9A;
                    goto case 0xAC9A;
                case 0xAC99:
                    A ^= _ram[0x24]; SetZN(A); TotalCycles += 3; PC = 0xAC9B;
                    goto case 0xAC9B;
                case 0xAC9A:
                    Bit(_ram[0x46]); TotalCycles += 3; PC = 0xAC9C;
                    goto case 0xAC9C;
                case 0xAC9B:
                    _ram[0x24] = Lsr(_ram[0x24]); TotalCycles += 5; PC = 0xAC9D;
                    goto case 0xAC9D;
                case 0xAC9C:
                    Bit(_ram[0x90]); TotalCycles += 3; PC = 0xAC9E;
                    goto case 0xAC9E;
                case 0xAC9D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xACA7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xACA7; }
                    PC = 0xAC9F; goto case 0xAC9F;
                case 0xAC9E:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAC9F;
                    goto case 0xAC9F;
                case 0xAC9F:
                    _ram[(byte)(0x51 + X)] = A; TotalCycles += 4; PC = 0xACA1;
                    goto case 0xACA1;
                case 0xACA0:
                    A ^= ReadMem(ReadU16Zp(0x78) + Y); SetZN(A); TotalCycles += 5; PC = 0xACA2;
                    return;
                case 0xACA1:
                    P |= FlagI; TotalCycles += 2; PC = 0xACA2;
                    return;
                case 0xACA5:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x0CF1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xACA8;
                    goto case 0xACA8;
                case 0xACA6:
                    Sbc(ReadMem(ReadU16Zp(0x8C) + Y)); TotalCycles += 5; PC = 0xACA8;
                    goto case 0xACA8;
                case 0xACA7:
                    WriteIoReg(0xA801, Y); TotalCycles += 4; PC = 0xACAA;
                    return;
                case 0xACA8:
                    A |= ReadMem(ReadU16Zp((byte)(0xA8 + X))); SetZN(A); TotalCycles += 6; PC = 0xACAA;
                    return;
                case 0xACA9:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xACAA;
                    return;
                case 0xACAB:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xACAC;
                    return;
                case 0xACAD:
                    Cmp(Y, ReadIoReg(0x5F01)); TotalCycles += 4; PC = 0xACB0;
                    return;
                case 0xACAE:
                    A |= ReadMem(ReadU16Zp((byte)(0x5F + X))); SetZN(A); TotalCycles += 6; PC = 0xACB0;
                    return;
                case 0xACB4:
                    TotalCycles += 7; PushU16(0xACB6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xACB5:
                    _ram[0x0681] = Asl(_ram[0x0681]); TotalCycles += 6; PC = 0xACB8;
                    goto case 0xACB8;
                case 0xACB6:
                    WriteMem(ReadU16Zp((byte)(0x16 + X)), A); TotalCycles += 6; PC = 0xACB8;
                    goto case 0xACB8;
                case 0xACB7:
                    { byte z = (byte)(0x24 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xACB9;
                    goto case 0xACB9;
                case 0xACB8:
                    Bit(_ram[0x66]); TotalCycles += 3; PC = 0xACBA;
                    return;
                case 0xACB9:
                    _ram[0x04] = Ror(_ram[0x04]); TotalCycles += 5; PC = 0xACBB;
                    goto case 0xACBB;
                case 0xACBB:
                    WriteIoReg(0xFE00, X); TotalCycles += 4; PC = 0xACBE;
                    goto case 0xACBE;
                case 0xACBC:
                    TotalCycles += 7; PushU16(0xACBE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xACBD:
                    { int a = 0x0801 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xACC0;
                    return;
                case 0xACBE:
                    A |= ReadMem(ReadU16Zp((byte)(0x08 + X))); SetZN(A); TotalCycles += 6; PC = 0xACC0;
                    return;
                case 0xACBF:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xACC0;
                    return;
                case 0xACC1:
                    { int a = 0x6F06; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xACC4;
                    return;
                case 0xACC2:
                    _ram[0x6F] = Asl(_ram[0x6F]); TotalCycles += 5; PC = 0xACC4;
                    return;
                case 0xACC7:
                    { int a = 0x2D82; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xACCA;
                    return;
                case 0xACC9:
                    A &= ReadIoReg(0x2847); SetZN(A); TotalCycles += 4; PC = 0xACCC;
                    return;
                case 0xACCB:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xACCC;
                    return;
                case 0xACCD:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xACCE;
                    return;
                case 0xACCF:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xACD0;
                    return;
                case 0xACD1:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5E01]; SetZN(X); TotalCycles += 4; PC = 0xACD4;
                    return;
                case 0xACD2:
                    A |= ReadMem(ReadU16Zp((byte)(0xDE + X))); SetZN(A); TotalCycles += 6; PC = 0xACD4;
                    return;
                case 0xACD3:
                    { int a = 0x6D0F + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xACD6;
                    goto case 0xACD6;
                case 0xACD5:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x7DC5]); TotalCycles += 4; PC = 0xACD8;
                    goto case 0xACD8;
                case 0xACD6:
                    Cmp(A, _ram[0xFD]); TotalCycles += 3; PC = 0xACD8;
                    goto case 0xACD8;
                case 0xACD7:
                    Sbc(ReadMem(0x0F48 + X)); TotalCycles += 4; PC = 0xACDA;
                    goto case 0xACDA;
                case 0xACD8:
                    PushU8(A); TotalCycles += 3; PC = 0xACD9;
                    return;
                case 0xACDA:
                    { int a = 0x5E01; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xACDD;
                    return;
                case 0xACDB:
                    A |= ReadMem(ReadU16Zp((byte)(0x5E + X))); SetZN(A); TotalCycles += 6; PC = 0xACDD;
                    return;
                case 0xACDC:
                    { int a = 0xBC02 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xACDF;
                    goto case 0xACDF;
                case 0xACDE:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x7C01 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xACE1;
                    goto case 0xACE1;
                case 0xACDF:
                    A |= ReadMem(ReadU16Zp((byte)(0xFC + X))); SetZN(A); TotalCycles += 6; PC = 0xACE1;
                    goto case 0xACE1;
                case 0xACE1:
                    A |= ReadMem(ReadU16Zp((byte)(0x2C + X))); SetZN(A); TotalCycles += 6; PC = 0xACE3;
                    return;
                case 0xACE2:
                    Bit(ReadIoReg(0x4182)); TotalCycles += 4; PC = 0xACE5;
                    return;
                case 0xACE4:
                    A ^= ReadMem(ReadU16Zp((byte)(0x52 + X))); SetZN(A); TotalCycles += 6; PC = 0xACE6;
                    goto case 0xACE6;
                case 0xACE6:
                    { int a = 0x6704; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xACE9;
                    goto case 0xACE9;
                case 0xACE9:
                    A &= _ram[0x68]; SetZN(A); TotalCycles += 3; PC = 0xACEB;
                    goto case 0xACEB;
                case 0xACEA:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xACEB;
                    goto case 0xACEB;
                case 0xACEB:
                    Bit(_ram[0x69]); TotalCycles += 3; PC = 0xACED;
                    goto case 0xACED;
                case 0xACEC:
                    Adc(0x24); TotalCycles += 2; PC = 0xACEE;
                    goto case 0xACEE;
                case 0xACED:
                    Bit(_ram[0xBA]); TotalCycles += 3; PC = 0xACEF;
                    return;
                case 0xACEE:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xACEF;
                    return;
                case 0xACF2:
                    { int a = 0xB20B + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xACF5;
                    return;
                case 0xACF6:
                    { int a = 0x2C02 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xACF9;
                    goto case 0xACF9;
                case 0xACF8:
                    Bit(ReadIoReg(0x2CE1)); TotalCycles += 4; PC = 0xACFB;
                    goto case 0xACFB;
                case 0xACF9:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x2C + X)))); TotalCycles += 6; PC = 0xACFB;
                    goto case 0xACFB;
                case 0xACFA:
                    Bit(ReadIoReg(0x6771)); TotalCycles += 4; PC = 0xACFD;
                    goto case 0xACFD;
                case 0xACFB:
                    Adc(ReadMem(ReadU16Zp(0x67) + Y)); TotalCycles += 5; PC = 0xACFD;
                    goto case 0xACFD;
                case 0xACFD:
                    A |= ReadMem(ReadU16Zp((byte)(0x77 + X))); SetZN(A); TotalCycles += 6; PC = 0xACFF;
                    goto case 0xACFF;
                case 0xACFF:
                    TotalCycles += 7; PushU16(0xAD01); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAD01:
                    A |= ReadMem(ReadU16Zp((byte)(0x8E + X))); SetZN(A); TotalCycles += 6; PC = 0xAD03;
                    goto case 0xAD03;
                case 0xAD02:
                    WriteIoReg(0xEE00, X); TotalCycles += 4; PC = 0xAD05;
                    goto case 0xAD05;
                case 0xAD03:
                    TotalCycles += 7; PushU16(0xAD05); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAD04:
                    { int a = 0xF601; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xAD07;
                    return;
                case 0xAD05:
                    A |= ReadMem(ReadU16Zp((byte)(0xF6 + X))); SetZN(A); TotalCycles += 6; PC = 0xAD07;
                    return;
                case 0xAD06:
                    { byte z = (byte)(0x02 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xAD08;
                    return;
                case 0xAD09:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0xAD0B;
                    return;
                case 0xAD0A:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xAD0C;
                    return;
                case 0xAD0D:
                    A &= ReadMem(ReadU16Zp((byte)(0x16 + X))); SetZN(A); TotalCycles += 6; PC = 0xAD0F;
                    return;
                case 0xAD0E:
                    { byte z = (byte)(0x02 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xAD10;
                    return;
                case 0xAD12:
                    { int a = 0x8802; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xAD15;
                    return;
                case 0xAD14:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xAD15;
                    return;
                case 0xAD17:
                    TotalCycles += 6; PushU16(0xAD19); PC = 0x07D7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAD1A:
                    Cmp(X, _ram[0x76]); TotalCycles += 3; PC = 0xAD1C;
                    return;
                case 0xAD1B:
                    { byte z = (byte)(0x07 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xAD1D;
                    goto case 0xAD1D;
                case 0xAD1D:
                    Y = 0x17; SetZN(Y); TotalCycles += 2; PC = 0xAD1F;
                    goto case 0xAD1F;
                case 0xAD1F:
                    _ram[0x48] = Asl(_ram[0x48]); TotalCycles += 5; PC = 0xAD21;
                    return;
                case 0xAD20:
                    PushU8(A); TotalCycles += 3; PC = 0xAD21;
                    return;
                case 0xAD22:
                    { byte z = (byte)(0x20 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xAD24;
                    goto case 0xAD24;
                case 0xAD23:
                    TotalCycles += 6; PushU16(0xAD25); PC = 0x7298;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAD24:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xAD25;
                    return;
                case 0xAD26:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x08E1 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xAD29;
                    return;
                case 0xAD27:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x88 + X)))); TotalCycles += 6; PC = 0xAD29;
                    return;
                case 0xAD28:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xAD29;
                    return;
                case 0xAD2B:
                    A |= ReadMem(ReadU16Zp((byte)(0xB7 + X))); SetZN(A); TotalCycles += 6; PC = 0xAD2D;
                    return;
                case 0xAD2F:
                    A |= ReadMem(ReadU16Zp((byte)(0xF8 + X))); SetZN(A); TotalCycles += 6; PC = 0xAD31;
                    return;
                case 0xAD30:
                    P |= FlagD; TotalCycles += 2; PC = 0xAD31;
                    return;
                case 0xAD32:
                    { int a = 0x0801 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAD35;
                    return;
                case 0xAD33:
                    A |= ReadMem(ReadU16Zp((byte)(0x08 + X))); SetZN(A); TotalCycles += 6; PC = 0xAD35;
                    return;
                case 0xAD34:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAD35;
                    return;
                case 0xAD36:
                    { int a = 0x6E00; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xAD39;
                    return;
                case 0xAD37:
                    TotalCycles += 7; PushU16(0xAD39); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAD38:
                    { int a = 0x7302; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xAD3B;
                    goto case 0xAD3B;
                case 0xAD3B:
                    TotalCycles += 6; PushU16(0xAD3D); PC = 0x2377;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAD41:
                    TotalCycles += 6; PushU16(0xAD43); PC = 0x00AE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAD42:
                    X = SmbEmbeddedAssets.StaticDataTables[0x7E00]; SetZN(X); TotalCycles += 4; PC = 0xAD45;
                    goto case 0xAD45;
                case 0xAD43:
                    TotalCycles += 7; PushU16(0xAD45); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAD44:
                    { int a = 0x0E0A + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAD47;
                    return;
                case 0xAD45:
                    A = Asl(A); TotalCycles += 2; PC = 0xAD46;
                    goto case 0xAD46;
                case 0xAD46:
                    { int a = 0x3982; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xAD49;
                    goto case 0xAD49;
                case 0xAD48:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x2871 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAD4B;
                    return;
                case 0xAD49:
                    Adc(ReadMem(ReadU16Zp(0xA8) + Y)); TotalCycles += 5; PC = 0xAD4B;
                    return;
                case 0xAD4A:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xAD4B;
                    return;
                case 0xAD4F:
                    WriteMem(ReadU16Zp((byte)(0x8F + X)), A); TotalCycles += 6; PC = 0xAD51;
                    return;
                case 0xAD52:
                    X = SmbEmbeddedAssets.StaticDataTables[0x7E00]; SetZN(X); TotalCycles += 4; PC = 0xAD55;
                    return;
                case 0xAD53:
                    TotalCycles += 7; PushU16(0xAD55); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAD54:
                    { int a = (0x0404 + X) & 0x07FF; _ram[a] = IncVal(_ram[a]); } TotalCycles += 7; PC = 0xAD57;
                    goto case 0xAD57;
                case 0xAD57:
                    Cmp(A, ReadMem(ReadU16Zp(0x17) + Y)); TotalCycles += 5; PC = 0xAD59;
                    return;
                case 0xAD5A:
                    _ram[0x49] = Rol(_ram[0x49]); TotalCycles += 5; PC = 0xAD5C;
                    return;
                case 0xAD5B:
                    A ^= 0x27; SetZN(A); TotalCycles += 2; PC = 0xAD5D;
                    goto case 0xAD5D;
                case 0xAD5D:
                    A &= 0xDF; SetZN(A); TotalCycles += 2; PC = 0xAD5F;
                    return;
                case 0xAD60:
                    { int a = 0x4402 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAD63;
                    goto case 0xAD63;
                case 0xAD63:
                    { byte z = (byte)(0x7C + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xAD65;
                    goto case 0xAD65;
                case 0xAD65:
                    A |= ReadMem(ReadU16Zp((byte)(0x8E + X))); SetZN(A); TotalCycles += 6; PC = 0xAD67;
                    goto case 0xAD67;
                case 0xAD66:
                    WriteIoReg(0xBF06, X); TotalCycles += 4; PC = 0xAD69;
                    return;
                case 0xAD67:
                    _ram[0xBF] = Asl(_ram[0xBF]); TotalCycles += 5; PC = 0xAD69;
                    return;
                case 0xAD6A:
                    { int a = 0x4D0F; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xAD6D;
                    return;
                case 0xAD6C:
                    A ^= _ram[0x06C7]; SetZN(A); TotalCycles += 4; PC = 0xAD6F;
                    return;
                case 0xAD6E:
                    { int a = 0x6882; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xAD71;
                    return;
                case 0xAD70:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xAD71;
                    return;
                case 0xAD72:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5E01]; SetZN(X); TotalCycles += 4; PC = 0xAD75;
                    return;
                case 0xAD73:
                    A |= ReadMem(ReadU16Zp((byte)(0xDE + X))); SetZN(A); TotalCycles += 6; PC = 0xAD75;
                    return;
                case 0xAD74:
                    { int a = 0x6D0F + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAD77;
                    goto case 0xAD77;
                case 0xAD76:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x7DC5]); TotalCycles += 4; PC = 0xAD79;
                    goto case 0xAD79;
                case 0xAD77:
                    Cmp(A, _ram[0xFD]); TotalCycles += 3; PC = 0xAD79;
                    goto case 0xAD79;
                case 0xAD78:
                    Sbc(_ram[(0x0148 + X) & 0x07FF]); TotalCycles += 4; PC = 0xAD7B;
                    goto case 0xAD7B;
                case 0xAD79:
                    PushU8(A); TotalCycles += 3; PC = 0xAD7A;
                    goto case 0xAD7A;
                case 0xAD7A:
                    A |= ReadMem(ReadU16Zp((byte)(0x0E + X))); SetZN(A); TotalCycles += 6; PC = 0xAD7C;
                    goto case 0xAD7C;
                case 0xAD7B:
                    _ram[0x0001] = Asl(_ram[0x0001]); TotalCycles += 6; PC = 0xAD7E;
                    return;
                case 0xAD7C:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0xAD7E;
                    return;
                case 0xAD7D:
                    TotalCycles += 7; PushU16(0xAD7F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAD7F:
                    { int a = 0x4506 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xAD82;
                    goto case 0xAD82;
                case 0xAD80:
                    _ram[0x45] = Asl(_ram[0x45]); TotalCycles += 5; PC = 0xAD82;
                    goto case 0xAD82;
                case 0xAD81:
                    A ^= _ram[0x46]; SetZN(A); TotalCycles += 3; PC = 0xAD83;
                    return;
                case 0xAD82:
                    _ram[0x47] = Lsr(_ram[0x47]); TotalCycles += 5; PC = 0xAD84;
                    goto case 0xAD84;
                case 0xAD84:
                    _ram[0x53] = Lsr(_ram[0x53]); TotalCycles += 5; PC = 0xAD86;
                    return;
                case 0xAD87:
                    X = SmbEmbeddedAssets.StaticDataTables[0x5F01]; SetZN(X); TotalCycles += 4; PC = 0xAD8A;
                    goto case 0xAD8A;
                case 0xAD88:
                    A |= ReadMem(ReadU16Zp((byte)(0xDF + X))); SetZN(A); TotalCycles += 6; PC = 0xAD8A;
                    goto case 0xAD8A;
                case 0xAD8A:
                    A = Lsr(A); TotalCycles += 2; PC = 0xAD8B;
                    goto case 0xAD8B;
                case 0xAD8B:
                    A ^= _ram[0x06C7]; SetZN(A); TotalCycles += 4; PC = 0xAD8E;
                    goto case 0xAD8E;
                case 0xAD8D:
                    _ram[0x0081] = Asl(_ram[0x0081]); TotalCycles += 6; PC = 0xAD90;
                    return;
                case 0xAD8E:
                    WriteMem(ReadU16Zp((byte)(0x00 + X)), A); TotalCycles += 6; PC = 0xAD90;
                    return;
                case 0xAD8F:
                    TotalCycles += 7; PushU16(0xAD91); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAD91:
                    { int a = 0x3704; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xAD94;
                    goto case 0xAD94;
                case 0xAD94:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xAD95;
                    return;
                case 0xAD96:
                    PushU8(A); TotalCycles += 3; PC = 0xAD97;
                    goto case 0xAD97;
                case 0xAD97:
                    _ram[0x47] = Lsr(_ram[0x47]); TotalCycles += 5; PC = 0xAD99;
                    return;
                case 0xAD9B:
                    { int a = 0xDF0F; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xAD9E;
                    goto case 0xAD9E;
                case 0xAD9E:
                    A = Lsr(A); TotalCycles += 2; PC = 0xAD9F;
                    goto case 0xAD9F;
                case 0xAD9F:
                    A ^= _ram[0x06C7]; SetZN(A); TotalCycles += 4; PC = 0xADA2;
                    goto case 0xADA2;
                case 0xADA1:
                    _ram[0x0081] = Asl(_ram[0x0081]); TotalCycles += 6; PC = 0xADA4;
                    return;
                case 0xADA2:
                    WriteMem(ReadU16Zp((byte)(0x00 + X)), A); TotalCycles += 6; PC = 0xADA4;
                    return;
                case 0xADA3:
                    TotalCycles += 7; PushU16(0xADA5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xADA8:
                    A ^= ReadMem(ReadU16Zp(0x46) + Y); SetZN(A); TotalCycles += 5; PC = 0xADAA;
                    goto case 0xADAA;
                case 0xADA9:
                    _ram[0x40] = Lsr(_ram[0x40]); TotalCycles += 5; PC = 0xADAB;
                    return;
                case 0xADAA:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xADAC:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAE01; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAE01; }
                    PC = 0xADAE; return;
                case 0xADAF:
                    A ^= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0xADB1;
                    goto case 0xADB1;
                case 0xADB0:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xADB1:
                    { byte z = (byte)(0x50 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xADB3;
                    return;
                case 0xADB2:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAE16; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAE16; }
                    PC = 0xADB4; return;
                case 0xADB6:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xADB7:
                    Adc(_ram[0x50]); TotalCycles += 3; PC = 0xADB9;
                    goto case 0xADB9;
                case 0xADB8:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAE2B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xADBA; goto case 0xADBA;
                case 0xADB9:
                    Adc(ReadMem(ReadU16Zp(0x41) + Y)); TotalCycles += 5; PC = 0xADBB;
                    return;
                case 0xADBA:
                    A ^= ReadMem(ReadU16Zp((byte)(0x73 + X))); SetZN(A); TotalCycles += 6; PC = 0xADBC;
                    goto case 0xADBC;
                case 0xADBC:
                    A ^= ReadMem(ReadU16Zp(0x83) + Y); SetZN(A); TotalCycles += 5; PC = 0xADBE;
                    goto case 0xADBE;
                case 0xADBE:
                    A ^= ReadMem(ReadU16Zp(0x94) + Y); SetZN(A); TotalCycles += 5; PC = 0xADC0;
                    goto case 0xADC0;
                case 0xADBF:
                    _ram[(byte)(0x40 + X)] = Y; TotalCycles += 4; PC = 0xADC1;
                    goto case 0xADC1;
                case 0xADC0:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xADC1:
                    _ram[(byte)(0x50 + X)] = A; TotalCycles += 4; PC = 0xADC3;
                    return;
                case 0xADC2:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAD67; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAD67; }
                    PC = 0xADC4; goto case 0xADC4;
                case 0xADC4:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAD6B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xADC6; goto case 0xADC6;
                case 0xADC5:
                    A = _ram[0x40]; SetZN(A); TotalCycles += 3; PC = 0xADC7;
                    goto case 0xADC7;
                case 0xADC6:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xADC7:
                    X = _ram[0x50]; SetZN(X); TotalCycles += 3; PC = 0xADC9;
                    return;
                case 0xADC8:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAD7D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAD7D; }
                    PC = 0xADCA; goto case 0xADCA;
                case 0xADCA:
                    A ^= ReadMem(ReadU16Zp(0xB6) + Y); SetZN(A); TotalCycles += 5; PC = 0xADCC;
                    goto case 0xADCC;
                case 0xADCB:
                    X = _ram[(byte)(0x40 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xADCD;
                    return;
                case 0xADCC:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xADCE:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAD93; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xADD0; return;
                case 0xADD2:
                    A = Lsr(A); TotalCycles += 2; PC = 0xADD3;
                    goto case 0xADD3;
                case 0xADD3:
                    A ^= _ram[0x06C7]; SetZN(A); TotalCycles += 4; PC = 0xADD6;
                    goto case 0xADD6;
                case 0xADD5:
                    _ram[0x0081] = Asl(_ram[0x0081]); TotalCycles += 6; PC = 0xADD8;
                    return;
                case 0xADD6:
                    WriteMem(ReadU16Zp((byte)(0x00 + X)), A); TotalCycles += 6; PC = 0xADD8;
                    return;
                case 0xADD7:
                    TotalCycles += 7; PushU16(0xADD9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xADD9:
                    { int a = 0x3602; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xADDC;
                    return;
                case 0xADDB:
                    { byte z = (byte)(0x47 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xADDD;
                    return;
                case 0xADE0:
                    A ^= 0x47; SetZN(A); TotalCycles += 2; PC = 0xADE2;
                    goto case 0xADE2;
                case 0xADE2:
                    A &= _ram[0xA7]; SetZN(A); TotalCycles += 3; PC = 0xADE4;
                    return;
                case 0xADE8:
                    A = Lsr(A); TotalCycles += 2; PC = 0xADE9;
                    goto case 0xADE9;
                case 0xADE9:
                    A ^= _ram[0x06C7]; SetZN(A); TotalCycles += 4; PC = 0xADEC;
                    goto case 0xADEC;
                case 0xADEB:
                    _ram[0x0081] = Asl(_ram[0x0081]); TotalCycles += 6; PC = 0xADEE;
                    return;
                case 0xADEC:
                    WriteMem(ReadU16Zp((byte)(0x00 + X)), A); TotalCycles += 6; PC = 0xADEE;
                    return;
                case 0xADED:
                    TotalCycles += 7; PushU16(0xADEF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xADEF:
                    { int a = 0x4402 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xADF2;
                    goto case 0xADF2;
                case 0xADF2:
                    A ^= ReadMem(ReadU16Zp(0x53) + Y); SetZN(A); TotalCycles += 5; PC = 0xADF4;
                    return;
                case 0xADF7:
                    A ^= _ram[(byte)(0x24 + X)]; SetZN(A); TotalCycles += 4; PC = 0xADF9;
                    goto case 0xADF9;
                case 0xADF8:
                    Bit(_ram[0xA1]); TotalCycles += 3; PC = 0xADFA;
                    return;
                case 0xADF9:
                    A = ReadMem(ReadU16Zp((byte)(0x54 + X))); SetZN(A); TotalCycles += 6; PC = 0xADFB;
                    goto case 0xADFB;
                case 0xADFB:
                    X = SmbEmbeddedAssets.StaticDataTables[0x3401]; SetZN(X); TotalCycles += 4; PC = 0xADFE;
                    goto case 0xADFE;
                case 0xADFC:
                    A |= ReadMem(ReadU16Zp((byte)(0xB4 + X))); SetZN(A); TotalCycles += 6; PC = 0xADFE;
                    goto case 0xADFE;
                case 0xADFD:
                    Y = _ram[(byte)(0x21 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xADFF;
                    return;
                case 0xADFE:
                    A &= ReadMem(ReadU16Zp((byte)(0xDF + X))); SetZN(A); TotalCycles += 6; PC = 0xAE00;
                    goto case 0xAE00;
                case 0xAE00:
                    A = Lsr(A); TotalCycles += 2; PC = 0xAE01;
                    goto case 0xAE01;
                case 0xAE01:
                    Sbc(_ram[0x07]); TotalCycles += 3; PC = 0xAE03;
                    goto case 0xAE03;
                case 0xAE03:
                    A ^= SmbEmbeddedAssets.StaticDataTables[0x7DC7]; SetZN(A); TotalCycles += 4; PC = 0xAE06;
                    goto case 0xAE06;
                case 0xAE05:
                    Sbc(_ram[(0x0141 + X) & 0x07FF]); TotalCycles += 4; PC = 0xAE08;
                    goto case 0xAE08;
                case 0xAE06:
                    A ^= ReadMem(ReadU16Zp((byte)(0x01 + X))); SetZN(A); TotalCycles += 6; PC = 0xAE08;
                    goto case 0xAE08;
                case 0xAE07:
                    A |= ReadMem(ReadU16Zp((byte)(0xB4 + X))); SetZN(A); TotalCycles += 6; PC = 0xAE09;
                    return;
                case 0xAE08:
                    Y = _ram[(byte)(0x34 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xAE0A;
                    goto case 0xAE0A;
                case 0xAE0A:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xAE0B;
                    return;
                case 0xAE0D:
                    A ^= ReadMem(ReadU16Zp(0x47) + Y); SetZN(A); TotalCycles += 5; PC = 0xAE0F;
                    return;
                case 0xAE10:
                    TotalCycles += 5; PC = ReadU16Zp(0x03); return;
                case 0xAE12:
                    Adc(_ram[0x49]); TotalCycles += 3; PC = 0xAE14;
                    return;
                case 0xAE13:
                    A ^= 0x9E; SetZN(A); TotalCycles += 2; PC = 0xAE15;
                    return;
                case 0xAE16:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x4C01 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xAE19;
                    return;
                case 0xAE17:
                    A |= ReadMem(ReadU16Zp((byte)(0xCC + X))); SetZN(A); TotalCycles += 6; PC = 0xAE19;
                    return;
                case 0xAE18:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x7E03]); TotalCycles += 4; PC = 0xAE1B;
                    return;
                case 0xAE1A:
                    { int a = 0x0D07 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAE1D;
                    goto case 0xAE1D;
                case 0xAE1C:
                    A |= _ram[0x06C9]; SetZN(A); TotalCycles += 4; PC = 0xAE1F;
                    goto case 0xAE1F;
                case 0xAE1D:
                    Cmp(A, 0x1E); TotalCycles += 2; PC = 0xAE1F;
                    goto case 0xAE1F;
                case 0xAE1E:
                    { int a = 0x6C01 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xAE21;
                    goto case 0xAE21;
                case 0xAE1F:
                    A |= ReadMem(ReadU16Zp((byte)(0x6C + X))); SetZN(A); TotalCycles += 6; PC = 0xAE21;
                    goto case 0xAE21;
                case 0xAE20:
                    TotalCycles += 5; PC = ReadU16Zp(0x01); return;
                case 0xAE21:
                    A |= ReadMem(ReadU16Zp((byte)(0x62 + X))); SetZN(A); TotalCycles += 6; PC = 0xAE23;
                    goto case 0xAE23;
                case 0xAE23:
                    A &= _ram[(byte)(0x63 + X)]; SetZN(A); TotalCycles += 4; PC = 0xAE25;
                    return;
                case 0xAE26:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xAE27;
                    goto case 0xAE27;
                case 0xAE27:
                    A ^= ReadMem(ReadU16Zp((byte)(0xAC + X))); SetZN(A); TotalCycles += 6; PC = 0xAE29;
                    goto case 0xAE29;
                case 0xAE28:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x3301]; SetZN(Y); TotalCycles += 4; PC = 0xAE2B;
                    return;
                case 0xAE29:
                    A |= ReadMem(ReadU16Zp((byte)(0xB3 + X))); SetZN(A); TotalCycles += 6; PC = 0xAE2B;
                    return;
                case 0xAE2C:
                    Sbc(0x51); TotalCycles += 2; PC = 0xAE2E;
                    goto case 0xAE2E;
                case 0xAE2D:
                    A ^= ReadMem(ReadU16Zp(0x26) + Y); SetZN(A); TotalCycles += 5; PC = 0xAE2F;
                    return;
                case 0xAE2E:
                    _ram[0xC3] = Rol(_ram[0xC3]); TotalCycles += 5; PC = 0xAE30;
                    return;
                case 0xAE36:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xAE37;
                    goto case 0xAE37;
                case 0xAE37:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xAE38:
                    Cmp(A, 0x61); TotalCycles += 2; PC = 0xAE3A;
                    goto case 0xAE3A;
                case 0xAE39:
                    Adc(ReadMem(ReadU16Zp((byte)(0xCE + X)))); TotalCycles += 6; PC = 0xAE3B;
                    return;
                case 0xAE3A:
                    { int a = 0xE50B; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xAE3D;
                    goto case 0xAE3D;
                case 0xAE3C:
                    Sbc(_ram[0x09]); TotalCycles += 3; PC = 0xAE3E;
                    goto case 0xAE3E;
                case 0xAE3D:
                    A |= 0xEE; SetZN(A); TotalCycles += 2; PC = 0xAE3F;
                    return;
                case 0xAE3E:
                    { int a = 0x7D0F; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xAE41;
                    goto case 0xAE41;
                case 0xAE40:
                    Adc(ReadMem(0x7DCA + X)); TotalCycles += 4; PC = 0xAE43;
                    return;
                case 0xAE41:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xAE42;
                    goto case 0xAE42;
                case 0xAE42:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x7D47 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xAE45;
                    goto case 0xAE45;
                case 0xAE44:
                    Sbc(_ram[(0x0141 + X) & 0x07FF]); TotalCycles += 4; PC = 0xAE47;
                    goto case 0xAE47;
                case 0xAE45:
                    A ^= ReadMem(ReadU16Zp((byte)(0x01 + X))); SetZN(A); TotalCycles += 6; PC = 0xAE47;
                    goto case 0xAE47;
                case 0xAE46:
                    A |= ReadMem(ReadU16Zp((byte)(0xB8 + X))); SetZN(A); TotalCycles += 6; PC = 0xAE48;
                    return;
                case 0xAE47:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xAE48;
                    return;
                case 0xAE49:
                     TotalCycles += 2; PC = 0xAE4A;
                    goto case 0xAE4A;
                case 0xAE4A:
                    A ^= ReadMem(ReadU16Zp((byte)(0x27 + X))); SetZN(A); TotalCycles += 6; PC = 0xAE4C;
                    return;
                case 0xAE4F:
                    { byte z = (byte)(0xD4 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xAE51;
                    goto case 0xAE51;
                case 0xAE51:
                    A = Lsr(A); TotalCycles += 2; PC = 0xAE52;
                    return;
                case 0xAE53:
                    A = _ram[0x51]; SetZN(A); TotalCycles += 3; PC = 0xAE55;
                    return;
                case 0xAE54:
                    A ^= ReadMem(ReadU16Zp(0xA7) + Y); SetZN(A); TotalCycles += 5; PC = 0xAE56;
                    goto case 0xAE56;
                case 0xAE56:
                    A &= ReadMem(ReadU16Zp(0x27) + Y); SetZN(A); TotalCycles += 5; PC = 0xAE58;
                    return;
                case 0xAE59:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAE5A;
                    return;
                case 0xAE5B:
                    { byte z = (byte)(0x64 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xAE5D;
                    goto case 0xAE5D;
                case 0xAE5D:
                    Bit(ReadIoReg(0x3804)); TotalCycles += 4; PC = 0xAE60;
                    return;
                case 0xAE5F:
                    P |= FlagC; TotalCycles += 2; PC = 0xAE60;
                    return;
                case 0xAE61:
                    { byte z = (byte)(0x64 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xAE63;
                    goto case 0xAE63;
                case 0xAE63:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xAE64;
                    return;
                case 0xAE65:
                    { int a = 0xFE07 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAE68;
                    goto case 0xAE68;
                case 0xAE67:
                    { int a = 0x0D01 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAE6A;
                    goto case 0xAE6A;
                case 0xAE68:
                    A |= ReadMem(ReadU16Zp((byte)(0x0D + X))); SetZN(A); TotalCycles += 6; PC = 0xAE6A;
                    goto case 0xAE6A;
                case 0xAE69:
                    A |= ReadIoReg(0x23C9); SetZN(A); TotalCycles += 4; PC = 0xAE6C;
                    return;
                case 0xAE6A:
                    Cmp(A, 0x23); TotalCycles += 2; PC = 0xAE6C;
                    return;
                case 0xAE6D:
                    A &= ReadMem(ReadU16Zp(0x51) + Y); SetZN(A); TotalCycles += 5; PC = 0xAE6F;
                    goto case 0xAE6F;
                case 0xAE6E:
                    A ^= ReadMem(ReadU16Zp(0x98) + Y); SetZN(A); TotalCycles += 5; PC = 0xAE70;
                    return;
                case 0xAE6F:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xAE70;
                    return;
                case 0xAE71:
                    A |= ReadIoReg(0x59C9); SetZN(A); TotalCycles += 4; PC = 0xAE74;
                    return;
                case 0xAE72:
                    Cmp(A, 0x59); TotalCycles += 2; PC = 0xAE74;
                    return;
                case 0xAE73:
                    A ^= ReadMem(0x6342 + Y); SetZN(A); TotalCycles += 4; PC = 0xAE76;
                    return;
                case 0xAE78:
                    A &= ReadMem(ReadU16Zp(0x14) + Y); SetZN(A); TotalCycles += 5; PC = 0xAE7A;
                    return;
                case 0xAE7B:
                    { byte z = (byte)(0x31 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xAE7D;
                    return;
                case 0xAE7C:
                    A &= ReadMem(ReadU16Zp(0x87) + Y); SetZN(A); TotalCycles += 5; PC = 0xAE7E;
                    return;
                case 0xAE81:
                    A &= 0x61; SetZN(A); TotalCycles += 2; PC = 0xAE83;
                    goto case 0xAE83;
                case 0xAE82:
                    Adc(ReadMem(ReadU16Zp((byte)(0x30 + X)))); TotalCycles += 6; PC = 0xAE84;
                    return;
                case 0xAE83:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xAEE7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAEE7; }
                    PC = 0xAE85; return;
                case 0xAE86:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAE87;
                    return;
                case 0xAE89:
                    A ^= ReadMem(0x6A40 + Y); SetZN(A); TotalCycles += 4; PC = 0xAE8C;
                    return;
                case 0xAE8A:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAE8B:
                    A = Ror(A); TotalCycles += 2; PC = 0xAE8C;
                    return;
                case 0xAE8D:
                    WriteMem(0xC940 + Y, A); TotalCycles += 5; PC = 0xAE90;
                    goto case 0xAE90;
                case 0xAE8E:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAE8F:
                    Cmp(A, 0x61); TotalCycles += 2; PC = 0xAE91;
                    return;
                case 0xAE90:
                    Adc(ReadMem(ReadU16Zp((byte)(0xD7 + X)))); TotalCycles += 6; PC = 0xAE92;
                    return;
                case 0xAE93:
                    A &= ReadMem(0x58D1 + Y); SetZN(A); TotalCycles += 4; PC = 0xAE96;
                    return;
                case 0xAE94:
                    Cmp(A, ReadMem(ReadU16Zp(0x58) + Y)); TotalCycles += 5; PC = 0xAE96;
                    return;
                case 0xAE95:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xAE96;
                    return;
                case 0xAE9A:
                    A &= ReadMem(ReadU16Zp(0xDC) + Y); SetZN(A); TotalCycles += 5; PC = 0xAE9C;
                    goto case 0xAE9C;
                case 0xAE9C:
                    _ram[0xF7] = Asl(_ram[0xF7]); TotalCycles += 5; PC = 0xAE9E;
                    return;
                case 0xAEA2:
                    A = ReadMem(ReadU16Zp(0x43) + Y); SetZN(A); TotalCycles += 5; PC = 0xAEA4;
                    return;
                case 0xAEA9:
                    Cmp(A, ReadMem(ReadU16Zp(0x51) + Y)); TotalCycles += 5; PC = 0xAEAB;
                    return;
                case 0xAEAA:
                    A ^= ReadMem(ReadU16Zp(0x43) + Y); SetZN(A); TotalCycles += 5; PC = 0xAEAC;
                    return;
                case 0xAEAF:
                    SP = X; TotalCycles += 2; PC = 0xAEB0;
                    goto case 0xAEB0;
                case 0xAEB0:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xAE5B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAE5B; }
                    PC = 0xAEB2; goto case 0xAEB2;
                case 0xAEB1:
                    A = 0x61; SetZN(A); TotalCycles += 2; PC = 0xAEB3;
                    goto case 0xAEB3;
                case 0xAEB2:
                    Adc(ReadMem(ReadU16Zp((byte)(0xB8 + X)))); TotalCycles += 6; PC = 0xAEB4;
                    return;
                case 0xAEB3:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xAEB4;
                    return;
                case 0xAEB5:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x550B + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xAEB8;
                    goto case 0xAEB8;
                case 0xAEB7:
                    Cmp(A, _ram[(byte)(0x09 + X)]); TotalCycles += 4; PC = 0xAEB9;
                    goto case 0xAEB9;
                case 0xAEB8:
                    A |= 0xDE; SetZN(A); TotalCycles += 2; PC = 0xAEBA;
                    return;
                case 0xAEB9:
                    { int a = 0x0D0F + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xAEBC;
                    goto case 0xAEBC;
                case 0xAEBB:
                    A |= ReadIoReg(0x7DCA); SetZN(A); TotalCycles += 4; PC = 0xAEBE;
                    return;
                case 0xAEBC:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xAEBD;
                    goto case 0xAEBD;
                case 0xAEBD:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x7D47 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xAEC0;
                    goto case 0xAEC0;
                case 0xAEBF:
                    Sbc(ReadMem(0x0F49 + X)); TotalCycles += 4; PC = 0xAEC2;
                    goto case 0xAEC2;
                case 0xAEC0:
                    A ^= 0x0F; SetZN(A); TotalCycles += 2; PC = 0xAEC2;
                    goto case 0xAEC2;
                case 0xAEC2:
                    { int a = 0x3901 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xAEC5;
                    return;
                case 0xAEC3:
                    A |= ReadMem(ReadU16Zp((byte)(0x39 + X))); SetZN(A); TotalCycles += 6; PC = 0xAEC5;
                    return;
                case 0xAEC4:
                    A &= ReadMem(0x5E73 + Y); SetZN(A); TotalCycles += 4; PC = 0xAEC7;
                    return;
                case 0xAEC6:
                    { int a = 0xAE07 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xAEC9;
                    return;
                case 0xAEC8:
                    X = _ram[0x060B]; SetZN(X); TotalCycles += 4; PC = 0xAECB;
                    return;
                case 0xAECA:
                    { int a = 0x6E82 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xAECD;
                    goto case 0xAECD;
                case 0xAECC:
                    { int a = 0x9E88; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xAECF;
                    return;
                case 0xAECD:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xAECE;
                    return;
                case 0xAED0: // === SUBROUTINE: GameMode ===
                    A |= ReadIoReg(0x2E04); SetZN(A); TotalCycles += 4; PC = 0xAED3;
                    return;
                case 0xAED2:
                    { int a = 0x450B; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xAED5;
                    goto case 0xAED5;
                case 0xAED4:
                    A ^= _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xAED6;
                    goto case 0xAED6;
                case 0xAED5:
                    A |= 0x4E; SetZN(A); TotalCycles += 2; PC = 0xAED7;
                    return;
                case 0xAED6:
                    { int a = 0xED0F; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xAED9;
                    return;
                case 0xAED8:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x7D47]); TotalCycles += 4; PC = 0xAEDB;
                    return;
                case 0xAEDA:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x2DFF + X) & 0x7FFF]); TotalCycles += 4; PC = 0xAEDD;
                    return;
                case 0xAEDC:
                    A = _ram[0x0772]; SetZN(A); TotalCycles += 4; PC = 0xAEDF;
                    goto case 0xAEDF;
                case 0xAEDF:
                    TotalCycles += 6; PushU16(0xAEE1); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAEE1:
                    WriteIoReg(0x8FE4, X); TotalCycles += 4; PC = 0xAEE4;
                    return;
                case 0xAEE2:
                    Cmp(X, _ram[0x8F]); TotalCycles += 3; PC = 0xAEE4;
                    return;
                case 0xAEE5:
                    _ram[0x71] = A; TotalCycles += 3; PC = 0xAEE7;
                    goto case 0xAEE7;
                case 0xAEE6:
                    Adc(ReadMem(ReadU16Zp(0x90) + Y)); TotalCycles += 5; PC = 0xAEE8;
                    goto case 0xAEE8;
                case 0xAEE7:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xAED3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xAEE9; goto case 0xAEE9;
                case 0xAEE8:
                     TotalCycles += 2; PC = 0xAEE9;
                    goto case 0xAEE9;
                case 0xAEE9:
                    X = ReadIoReg(0x53AE); SetZN(X); TotalCycles += 4; PC = 0xAEEC;
                    return;
                case 0xAEEA: // === SUBROUTINE: GameCoreRoutine ===
                    X = _ram[0x0753]; SetZN(X); TotalCycles += 4; PC = 0xAEED;
                    goto case 0xAEED;
                case 0xAEED:
                    A = _ram[(0x06FC + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xAEF0;
                    goto case 0xAEF0;
                case 0xAEEF:
                    _ram[0x8D] = Asl(_ram[0x8D]); TotalCycles += 5; PC = 0xAEF1;
                    return;
                case 0xAEF0:
                    _ram[0x06FC] = A; TotalCycles += 4; PC = 0xAEF3;
                    goto case 0xAEF3;
                case 0xAEF2:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xAEF4;
                    goto case 0xAEF4;
                case 0xAEF3:
                    TotalCycles += 6; PushU16(0xAEF5); PC = 0xB04A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB04A;
                case 0xAEF4:
                    A = Lsr(A); TotalCycles += 2; PC = 0xAEF5;
                    goto case 0xAEF5;
                case 0xAEF5:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xAEA4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xAEF7; return;
                case 0xAEF6:
                    A = _ram[0x0772]; SetZN(A); TotalCycles += 4; PC = 0xAEF9;
                    goto case 0xAEF9;
                case 0xAEF9:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xAEFB;
                    goto case 0xAEFB;
                case 0xAEFB:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xAEFE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAEFE; }
                    PC = 0xAEFD; goto case 0xAEFD;
                case 0xAEFC:
                    A |= ReadMem(ReadU16Zp((byte)(0x60 + X))); SetZN(A); TotalCycles += 6; PC = 0xAEFE;
                    goto case 0xAEFE;
                case 0xAEFD:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xAEFE:
                    TotalCycles += 6; PushU16(0xAF00); PC = 0xB624;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB624;
                case 0xAEFF:
                    Bit(_ram[0xB6]); TotalCycles += 3; PC = 0xAF01;
                    goto case 0xAF01;
                case 0xAF00:
                    X = _ram[(byte)(0xA2 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xAF02;
                    goto case 0xAF02;
                case 0xAF01:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xAF03;
                    goto case 0xAF03;
                case 0xAF02:
                    TotalCycles += 7; PushU16(0xAF04); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAF03:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xAF05;
                    goto case 0xAF05;
                case 0xAF04:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAF05;
                    goto case 0xAF05;
                case 0xAF05:
                    TotalCycles += 6; PushU16(0xAF07); PC = 0xC047;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF07:
                    Cmp(Y, 0x20); TotalCycles += 2; PC = 0xAF09;
                    return;
                case 0xAF08:
                    TotalCycles += 6; PushU16(0xAF0A); PC = 0x84C3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF0A:
                    _ram[0xE8] = Y; TotalCycles += 3; PC = 0xAF0C;
                    goto case 0xAF0C;
                case 0xAF0B:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xAF0C;
                    goto case 0xAF0C;
                case 0xAF0C:
                    Cmp(X, 0x06); TotalCycles += 2; PC = 0xAF0E;
                    goto case 0xAF0E;
                case 0xAF0D:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xAF0F;
                    return;
                case 0xAF0E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xAF03; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF03; }
                    PC = 0xAF10; goto case 0xAF10;
                case 0xAF10:
                    TotalCycles += 6; PushU16(0xAF12); PC = 0xF180;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF12:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xAF14;
                    goto case 0xAF14;
                case 0xAF13:
                    TotalCycles += 6; PushU16(0xAF15); PC = 0xF12A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF14:
                    A = Rol(A); TotalCycles += 2; PC = 0xAF15;
                    goto case 0xAF15;
                case 0xAF15:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xAF17;
                    goto case 0xAF17;
                case 0xAF16:
                    TotalCycles += 6; PushU16(0xAF18); PC = 0xEEE9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF17:
                    Sbc(0xEE); TotalCycles += 2; PC = 0xAF19;
                    goto case 0xAF19;
                case 0xAF18:
                    { int a = 0xD420; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xAF1B;
                    goto case 0xAF1B;
                case 0xAF19:
                    TotalCycles += 6; PushU16(0xAF1B); PC = 0xBED4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBED4;
                case 0xAF1B:
                    X = _ram[(0x01A2 + Y) & 0x07FF]; SetZN(X); TotalCycles += 4; PC = 0xAF1E;
                    goto case 0xAF1E;
                case 0xAF1C:
                    X = 0x01; SetZN(X); TotalCycles += 2; PC = 0xAF1E;
                    goto case 0xAF1E;
                case 0xAF1D:
                    A |= ReadMem(ReadU16Zp((byte)(0x86 + X))); SetZN(A); TotalCycles += 6; PC = 0xAF1F;
                    goto case 0xAF1F;
                case 0xAF1E:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xAF20;
                    goto case 0xAF20;
                case 0xAF1F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAF20;
                    goto case 0xAF20;
                case 0xAF20:
                    TotalCycles += 6; PushU16(0xAF22); PC = 0xBE70;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBE70;
                case 0xAF21:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xAEE1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAEE1; }
                    PC = 0xAF23; goto case 0xAF23;
                case 0xAF22:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x06CA + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xAF25;
                    goto case 0xAF25;
                case 0xAF23:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xAF24;
                    goto case 0xAF24;
                case 0xAF24:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xAF26;
                    goto case 0xAF26;
                case 0xAF25:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAF26;
                    goto case 0xAF26;
                case 0xAF26:
                    TotalCycles += 6; PushU16(0xAF28); PC = 0xBE70;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBE70;
                case 0xAF27:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xAEE7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAEE7; }
                    PC = 0xAF29; goto case 0xAF29;
                case 0xAF28:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x1620 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xAF2B;
                    return;
                case 0xAF29:
                    TotalCycles += 6; PushU16(0xAF2B); PC = 0xBB96;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBB96;
                case 0xAF2A:
                    _ram[(byte)(0xBB + Y)] = X; TotalCycles += 4; PC = 0xAF2C;
                    goto case 0xAF2C;
                case 0xAF2C:
                    TotalCycles += 6; PushU16(0xAF2E); PC = 0xB9BC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB9BC;
                case 0xAF2D:
                    Y = ReadMem(0x20B9 + X); SetZN(Y); TotalCycles += 4; PC = 0xAF30;
                    goto case 0xAF30;
                case 0xAF2E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3820 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAF31;
                    return;
                case 0xAF2F:
                    TotalCycles += 6; PushU16(0xAF31); PC = 0xB7B8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB7B8;
                case 0xAF30:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xAF31;
                    return;
                case 0xAF32:
                    TotalCycles += 6; PushU16(0xAF34); PC = 0xB855;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB855;
                case 0xAF33:
                    A ^= _ram[(byte)(0xB8 + X)]; SetZN(A); TotalCycles += 4; PC = 0xAF35;
                    goto case 0xAF35;
                case 0xAF34:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xAF35;
                    goto case 0xAF35;
                case 0xAF35:
                    TotalCycles += 6; PushU16(0xAF37); PC = 0xB74F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB74F;
                case 0xAF38:
                    TotalCycles += 6; PushU16(0xAF3A); PC = 0x89E1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF39:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x89 + X)))); TotalCycles += 6; PC = 0xAF3B;
                    goto case 0xAF3B;
                case 0xAF3B:
                    A = _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xAF3D;
                    goto case 0xAF3D;
                case 0xAF3C:
                    A = _ram[(byte)(0xC9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xAF3E;
                    return;
                case 0xAF3D:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xAF3F;
                    goto case 0xAF3F;
                case 0xAF3F:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xAF52; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF52; }
                    PC = 0xAF41; goto case 0xAF41;
                case 0xAF40:
                    A |= ReadMem(ReadU16Zp(0xAD) + Y); SetZN(A); TotalCycles += 5; PC = 0xAF42;
                    return;
                case 0xAF41:
                    A = _ram[0x079F]; SetZN(A); TotalCycles += 4; PC = 0xAF44;
                    goto case 0xAF44;
                case 0xAF44:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xAF64; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF64; }
                    PC = 0xAF46; goto case 0xAF46;
                case 0xAF45:
                    { int a = (0x04C9 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xAF48;
                    goto case 0xAF48;
                case 0xAF46:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0xAF48;
                    goto case 0xAF48;
                case 0xAF48:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xAF52; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF52; }
                    PC = 0xAF4A; goto case 0xAF4A;
                case 0xAF49:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAF4A;
                    goto case 0xAF4A;
                case 0xAF4A:
                    A = _ram[0x077F]; SetZN(A); TotalCycles += 4; PC = 0xAF4D;
                    goto case 0xAF4D;
                case 0xAF4D:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xAF52; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF52; }
                    PC = 0xAF4F; goto case 0xAF4F;
                case 0xAF4F:
                    TotalCycles += 6; PushU16(0xAF51); PC = 0x90ED;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF50:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x2C90]); TotalCycles += 4; PC = 0xAF53;
                    return;
                case 0xAF51:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xAEFF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAEFF; }
                    PC = 0xAF53; return;
                case 0xAF52:
                    Y = _ram[0x079F]; SetZN(Y); TotalCycles += 4; PC = 0xAF55;
                    goto case 0xAF55;
                case 0xAF55:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xAF57;
                    goto case 0xAF57;
                case 0xAF56:
                    A |= 0xC0; SetZN(A); TotalCycles += 2; PC = 0xAF58;
                    goto case 0xAF58;
                case 0xAF57:
                    Cmp(Y, 0x08); TotalCycles += 2; PC = 0xAF59;
                    goto case 0xAF59;
                case 0xAF58:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAF59;
                    goto case 0xAF59;
                case 0xAF59:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xAF5D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF5D; }
                    PC = 0xAF5B; goto case 0xAF5B;
                case 0xAF5B:
                    A = Lsr(A); TotalCycles += 2; PC = 0xAF5C;
                    goto case 0xAF5C;
                case 0xAF5C:
                    A = Lsr(A); TotalCycles += 2; PC = 0xAF5D;
                    goto case 0xAF5D;
                case 0xAF5D: // === SUBROUTINE: UpdScrollVar ===
                    A = Lsr(A); TotalCycles += 2; PC = 0xAF5E;
                    goto case 0xAF5E;
                case 0xAF5E:
                    TotalCycles += 6; PushU16(0xAF60); PC = 0xB288;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB288;
                case 0xAF5F:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xAF60;
                    return;
                case 0xAF61:
                    TotalCycles += 3; PC = 0xAF67;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xAF67;
                case 0xAF64:
                    TotalCycles += 6; PushU16(0xAF66); PC = 0xB29A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB29A;
                case 0xAF65:
                    SP = X; TotalCycles += 2; PC = 0xAF66;
                    return;
                case 0xAF67:
                    A = _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0xAF69;
                    goto case 0xAF69;
                case 0xAF68:
                    A = Asl(A); TotalCycles += 2; PC = 0xAF69;
                    goto case 0xAF69;
                case 0xAF69:
                    _ram[0x0D] = A; TotalCycles += 3; PC = 0xAF6B;
                    goto case 0xAF6B;
                case 0xAF6A:
                    A |= _ram[0x00A9]; SetZN(A); TotalCycles += 4; PC = 0xAF6D;
                    goto case 0xAF6D;
                case 0xAF6B:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xAF6D;
                    goto case 0xAF6D;
                case 0xAF6C:
                    TotalCycles += 7; PushU16(0xAF6E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAF6D:
                    _ram[0x0C] = A; TotalCycles += 3; PC = 0xAF6F;
                    goto case 0xAF6F;
                case 0xAF6F:
                    A = _ram[0x0773]; SetZN(A); TotalCycles += 4; PC = 0xAF72;
                    goto case 0xAF72;
                case 0xAF72:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0xAF74;
                    goto case 0xAF74;
                case 0xAF73:
                    _ram[0xF0] = Asl(_ram[0xF0]); TotalCycles += 5; PC = 0xAF75;
                    return;
                case 0xAF74:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xAF92; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF92; }
                    PC = 0xAF76; goto case 0xAF76;
                case 0xAF76:
                    A = _ram[0x071F]; SetZN(A); TotalCycles += 4; PC = 0xAF79;
                    goto case 0xAF79;
                case 0xAF79:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xAF8F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF8F; }
                    PC = 0xAF7B; goto case 0xAF7B;
                case 0xAF7B:
                    A = _ram[0x073D]; SetZN(A); TotalCycles += 4; PC = 0xAF7E;
                    goto case 0xAF7E;
                case 0xAF7C:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x4907 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAF7F;
                    goto case 0xAF7F;
                case 0xAF7E:
                    Cmp(A, 0x20); TotalCycles += 2; PC = 0xAF80;
                    goto case 0xAF80;
                case 0xAF7F:
                    TotalCycles += 6; PushU16(0xAF81); PC = 0x1030;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF80:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xAF92; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF92; }
                    PC = 0xAF82; goto case 0xAF82;
                case 0xAF81:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xAF30; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF30; }
                    PC = 0xAF83; goto case 0xAF83;
                case 0xAF82:
                    A = _ram[0x073D]; SetZN(A); TotalCycles += 4; PC = 0xAF85;
                    goto case 0xAF85;
                case 0xAF83:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x6907 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAF86;
                    goto case 0xAF86;
                case 0xAF85:
                    Sbc(0x20); TotalCycles += 2; PC = 0xAF87;
                    goto case 0xAF87;
                case 0xAF86:
                    TotalCycles += 6; PushU16(0xAF88); PC = 0x3D8D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF87:
                    _ram[0x073D] = A; TotalCycles += 4; PC = 0xAF8A;
                    goto case 0xAF8A;
                case 0xAF88:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x2907 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAF8B;
                    goto case 0xAF8B;
                case 0xAF8A:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xAF8C;
                    goto case 0xAF8C;
                case 0xAF8B:
                    TotalCycles += 7; PushU16(0xAF8D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAF8C:
                    _ram[0x0340] = A; TotalCycles += 4; PC = 0xAF8F;
                    goto case 0xAF8F;
                case 0xAF8D:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xAF8F:
                    TotalCycles += 6; PushU16(0xAF91); PC = 0x92B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xAF90:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xAF24; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF24; }
                    PC = 0xAF92; goto case 0xAF92;
                case 0xAF92:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xAF93: // === SUBROUTINE: Sub_AF93 ===
                    A = _ram[0x06FF]; SetZN(A); TotalCycles += 4; PC = 0xAF96;
                    goto case 0xAF96;
                case 0xAF95:
                    _ram[0x18] = Asl(_ram[0x18]); TotalCycles += 5; PC = 0xAF97;
                    goto case 0xAF97;
                case 0xAF96:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xAF97;
                    goto case 0xAF97;
                case 0xAF97:
                    Adc(_ram[0x03A1]); TotalCycles += 4; PC = 0xAF9A;
                    goto case 0xAF9A;
                case 0xAF98:
                    A = ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0xAF9A;
                    goto case 0xAF9A;
                case 0xAF9A:
                    _ram[0x06FF] = A; TotalCycles += 4; PC = 0xAF9D;
                    goto case 0xAF9D;
                case 0xAF9C:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xAF9E;
                    return;
                case 0xAF9D:
                    A = _ram[0x0723]; SetZN(A); TotalCycles += 4; PC = 0xAFA0;
                    goto case 0xAFA0;
                case 0xAFA0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xAFFB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAFFB; }
                    PC = 0xAFA2; goto case 0xAFA2;
                case 0xAFA1:
                    A ^= ReadMem(0x55AD + Y); SetZN(A); TotalCycles += 4; PC = 0xAFA4;
                    return;
                case 0xAFA2:
                    A = _ram[0x0755]; SetZN(A); TotalCycles += 4; PC = 0xAFA5;
                    goto case 0xAFA5;
                case 0xAFA3:
                    A ^= _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0xAFA5;
                    goto case 0xAFA5;
                case 0xAFA5:
                    Cmp(A, 0x50); TotalCycles += 2; PC = 0xAFA7;
                    goto case 0xAFA7;
                case 0xAFA6:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xAF38; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF38; }
                    PC = 0xAFA8; return;
                case 0xAFA7:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xAFFB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAFFB; }
                    PC = 0xAFA9; goto case 0xAFA9;
                case 0xAFA9:
                    A = _ram[0x0785]; SetZN(A); TotalCycles += 4; PC = 0xAFAC;
                    goto case 0xAFAC;
                case 0xAFAA:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0xAFAC;
                    goto case 0xAFAC;
                case 0xAFAC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xAFFB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAFFB; }
                    PC = 0xAFAE; goto case 0xAFAE;
                case 0xAFAD:
                    A ^= SmbEmbeddedAssets.StaticDataTables[0x7FAC]; SetZN(A); TotalCycles += 4; PC = 0xAFB0;
                    goto case 0xAFB0;
                case 0xAFAE:
                    Y = _ram[0x06FF]; SetZN(Y); TotalCycles += 4; PC = 0xAFB1;
                    goto case 0xAFB1;
                case 0xAFB0:
                    _ram[0x88] = Asl(_ram[0x88]); TotalCycles += 5; PC = 0xAFB2;
                    goto case 0xAFB2;
                case 0xAFB1:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xAFB2;
                    goto case 0xAFB2;
                case 0xAFB2:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xAFFB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAFFB; }
                    PC = 0xAFB4; goto case 0xAFB4;
                case 0xAFB4:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xAFB5;
                    goto case 0xAFB5;
                case 0xAFB5:
                    Cmp(Y, 0x02); TotalCycles += 2; PC = 0xAFB7;
                    goto case 0xAFB7;
                case 0xAFB7:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xAFBA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAFBA; }
                    PC = 0xAFB9; goto case 0xAFB9;
                case 0xAFB8:
                    A |= ReadMem(ReadU16Zp((byte)(0x88 + X))); SetZN(A); TotalCycles += 6; PC = 0xAFBA;
                    goto case 0xAFBA;
                case 0xAFB9:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xAFBA;
                    goto case 0xAFBA;
                case 0xAFBA:
                    A = _ram[0x0755]; SetZN(A); TotalCycles += 4; PC = 0xAFBD;
                    goto case 0xAFBD;
                case 0xAFBB:
                    A ^= _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0xAFBD;
                    goto case 0xAFBD;
                case 0xAFBD:
                    Cmp(A, 0x70); TotalCycles += 2; PC = 0xAFBF;
                    goto case 0xAFBF;
                case 0xAFBE:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xAF50; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF50; }
                    PC = 0xAFC0; return;
                case 0xAFBF:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xAFC4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAFC4; }
                    PC = 0xAFC1; goto case 0xAFC1;
                case 0xAFC1:
                    Y = _ram[0x06FF]; SetZN(Y); TotalCycles += 4; PC = 0xAFC4;
                    goto case 0xAFC4;
                case 0xAFC3:
                    _ram[0x98] = Asl(_ram[0x98]); TotalCycles += 5; PC = 0xAFC5;
                    goto case 0xAFC5;
                case 0xAFC4:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xAFC5;
                    goto case 0xAFC5;
                case 0xAFC5:
                    _ram[0x0775] = A; TotalCycles += 4; PC = 0xAFC8;
                    goto case 0xAFC8;
                case 0xAFC6:
                    Adc(_ram[(byte)(0x07 + X)]); TotalCycles += 4; PC = 0xAFC8;
                    goto case 0xAFC8;
                case 0xAFC8:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xAFC9;
                    goto case 0xAFC9;
                case 0xAFC9:
                    Adc(_ram[0x073D]); TotalCycles += 4; PC = 0xAFCC;
                    goto case 0xAFCC;
                case 0xAFCA:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x0D07 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAFCD;
                    goto case 0xAFCD;
                case 0xAFCC:
                    _ram[0x073D] = A; TotalCycles += 4; PC = 0xAFCF;
                    goto case 0xAFCF;
                case 0xAFCD:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x1807 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xAFD0;
                    goto case 0xAFD0;
                case 0xAFCF:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xAFD0;
                    goto case 0xAFD0;
                case 0xAFD0:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xAFD1;
                    goto case 0xAFD1;
                case 0xAFD1:
                    Adc(_ram[0x071C]); TotalCycles += 4; PC = 0xAFD4;
                    goto case 0xAFD4;
                case 0xAFD4:
                    _ram[0x071C] = A; TotalCycles += 4; PC = 0xAFD7;
                    goto case 0xAFD7;
                case 0xAFD7:
                    _ram[0x073F] = A; TotalCycles += 4; PC = 0xAFDA;
                    goto case 0xAFDA;
                case 0xAFDA:
                    A = _ram[0x071A]; SetZN(A); TotalCycles += 4; PC = 0xAFDD;
                    goto case 0xAFDD;
                case 0xAFDD:
                    Adc(0x00); TotalCycles += 2; PC = 0xAFDF;
                    goto case 0xAFDF;
                case 0xAFDE:
                    TotalCycles += 7; PushU16(0xAFE0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAFDF:
                    _ram[0x071A] = A; TotalCycles += 4; PC = 0xAFE2;
                    goto case 0xAFE2;
                case 0xAFE2:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0xAFE4;
                    goto case 0xAFE4;
                case 0xAFE3:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xAFE5;
                    goto case 0xAFE5;
                case 0xAFE4:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xAFE6;
                    goto case 0xAFE6;
                case 0xAFE5:
                    TotalCycles += 7; PushU16(0xAFE7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAFE6:
                    A = _ram[0x0778]; SetZN(A); TotalCycles += 4; PC = 0xAFE9;
                    goto case 0xAFE9;
                case 0xAFE7:
                    P |= FlagI; TotalCycles += 2; PC = 0xAFE8;
                    return;
                case 0xAFE9:
                    A &= 0xFE; SetZN(A); TotalCycles += 2; PC = 0xAFEB;
                    goto case 0xAFEB;
                case 0xAFEA:
                    { int a = (0x0005 + X) & 0x07FF; _ram[a] = IncVal(_ram[a]); } TotalCycles += 7; PC = 0xAFED;
                    goto case 0xAFED;
                case 0xAFEB:
                    A |= _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xAFED;
                    goto case 0xAFED;
                case 0xAFEC:
                    TotalCycles += 7; PushU16(0xAFEE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAFED:
                    _ram[0x0778] = A; TotalCycles += 4; PC = 0xAFF0;
                    goto case 0xAFF0;
                case 0xAFEE:
                    P |= FlagI; TotalCycles += 2; PC = 0xAFEF;
                    return;
                case 0xAFF0:
                    TotalCycles += 6; PushU16(0xAFF2); PC = 0xB038;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB038;
                case 0xAFF1:
                    P |= FlagC; TotalCycles += 2; PC = 0xAFF2;
                    goto case 0xAFF2;
                case 0xAFF2:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xAF9D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAF9D; }
                    PC = 0xAFF4; goto case 0xAFF4;
                case 0xAFF3:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xAFF5;
                    goto case 0xAFF5;
                case 0xAFF4:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xAFF5;
                    goto case 0xAFF5;
                case 0xAFF5:
                    _ram[0x0795] = A; TotalCycles += 4; PC = 0xAFF8;
                    goto case 0xAFF8;
                case 0xAFF6:
                    _ram[(byte)(0x07 + X)] = A; TotalCycles += 4; PC = 0xAFF8;
                    goto case 0xAFF8;
                case 0xAFF8:
                    TotalCycles += 3; PC = 0xB000;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB000;
                case 0xAFF9:
                    TotalCycles += 7; PushU16(0xAFFB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAFFA:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xAFA5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAFA5; }
                    PC = 0xAFFC; goto case 0xAFFC;
                case 0xAFFB:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xAFFD;
                    goto case 0xAFFD;
                case 0xAFFC:
                    TotalCycles += 7; PushU16(0xAFFE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xAFFD:
                    _ram[0x0775] = A; TotalCycles += 4; PC = 0xB000;
                    goto case 0xB000;
                case 0xAFFE:
                    Adc(_ram[(byte)(0x07 + X)]); TotalCycles += 4; PC = 0xB000;
                    goto case 0xB000;
                case 0xB000:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xB002;
                    goto case 0xB002;
                case 0xB001:
                    TotalCycles += 7; PushU16(0xB003); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB002:
                    TotalCycles += 6; PushU16(0xB004); PC = 0xF1F6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB003:
                    { byte z = (byte)(0xF1 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xB005;
                    goto case 0xB005;
                case 0xB004:
                    Sbc(ReadMem(ReadU16Zp(0x85) + Y)); TotalCycles += 5; PC = 0xB006;
                    goto case 0xB006;
                case 0xB005:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xB007;
                    goto case 0xB007;
                case 0xB006:
                    TotalCycles += 7; PushU16(0xB008); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB007:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB009;
                    goto case 0xB009;
                case 0xB008:
                    TotalCycles += 7; PushU16(0xB00A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB009:
                    A = Asl(A); TotalCycles += 2; PC = 0xB00A;
                    goto case 0xB00A;
                case 0xB00A:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB013; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB013; }
                    PC = 0xB00C; goto case 0xB00C;
                case 0xB00C:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB00D;
                    goto case 0xB00D;
                case 0xB00D:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xB00F;
                    goto case 0xB00F;
                case 0xB00E:
                    TotalCycles += 7; PushU16(0xB010); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB00F:
                    A &= 0x20; SetZN(A); TotalCycles += 2; PC = 0xB011;
                    goto case 0xB011;
                case 0xB010:
                    TotalCycles += 6; PushU16(0xB012); PC = 0x1BF0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB011:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB02E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB02E; }
                    PC = 0xB013; goto case 0xB013;
                case 0xB013:
                    A = _ram[(0x071C + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB016;
                    goto case 0xB016;
                case 0xB016:
                    P |= FlagC; TotalCycles += 2; PC = 0xB017;
                    goto case 0xB017;
                case 0xB017:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x3034 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xB01A;
                    goto case 0xB01A;
                case 0xB019:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xAFA0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xAFA0; }
                    PC = 0xB01B; goto case 0xB01B;
                case 0xB01A:
                    _ram[0x86] = A; TotalCycles += 3; PC = 0xB01C;
                    goto case 0xB01C;
                case 0xB01B:
                    _ram[0xB9] = X; TotalCycles += 3; PC = 0xB01D;
                    return;
                case 0xB01C:
                    A = _ram[(0x071A + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB01F;
                    goto case 0xB01F;
                case 0xB01F:
                    Sbc(0x00); TotalCycles += 2; PC = 0xB021;
                    goto case 0xB021;
                case 0xB020:
                    TotalCycles += 7; PushU16(0xB022); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB021:
                    _ram[0x6D] = A; TotalCycles += 3; PC = 0xB023;
                    goto case 0xB023;
                case 0xB022:
                    Adc(_ram[0x04A5]); TotalCycles += 4; PC = 0xB025;
                    goto case 0xB025;
                case 0xB023:
                    A = _ram[0x0C]; SetZN(A); TotalCycles += 3; PC = 0xB025;
                    goto case 0xB025;
                case 0xB025:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x3036 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xB028;
                    goto case 0xB028;
                case 0xB026:
                    { byte z = (byte)(0xB0 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xB028;
                    goto case 0xB028;
                case 0xB027:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB019; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB019; }
                    PC = 0xB029; return;
                case 0xB028:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB02E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB02E; }
                    PC = 0xB02A; goto case 0xB02A;
                case 0xB02A:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB02C;
                    goto case 0xB02C;
                case 0xB02B:
                    TotalCycles += 7; PushU16(0xB02D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB02C:
                    _ram[0x57] = A; TotalCycles += 3; PC = 0xB02E;
                    goto case 0xB02E;
                case 0xB02E:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB030;
                    goto case 0xB030;
                case 0xB02F:
                    TotalCycles += 7; PushU16(0xB031); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB030:
                    _ram[0x03A1] = A; TotalCycles += 4; PC = 0xB033;
                    goto case 0xB033;
                case 0xB031:
                    A = ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0xB033;
                    goto case 0xB033;
                case 0xB033:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB034:
                    TotalCycles += 7; PushU16(0xB036); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB035:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB038; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB038; }
                    PC = 0xB037; return;
                case 0xB036:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0xB038;
                    goto case 0xB038;
                case 0xB038: // === SUBROUTINE: Sub_B038 ===
                    A = _ram[0x071C]; SetZN(A); TotalCycles += 4; PC = 0xB03B;
                    goto case 0xB03B;
                case 0xB03B:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB03C;
                    goto case 0xB03C;
                case 0xB03C:
                    Adc(0xFF); TotalCycles += 2; PC = 0xB03E;
                    goto case 0xB03E;
                case 0xB03E:
                    _ram[0x071D] = A; TotalCycles += 4; PC = 0xB041;
                    goto case 0xB041;
                case 0xB03F: // === SUBROUTINE: ScrollHandler ===
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x2D07 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB042;
                    return;
                case 0xB041:
                    A = _ram[0x071A]; SetZN(A); TotalCycles += 4; PC = 0xB044;
                    goto case 0xB044;
                case 0xB044:
                    Adc(0x00); TotalCycles += 2; PC = 0xB046;
                    goto case 0xB046;
                case 0xB045:
                    TotalCycles += 7; PushU16(0xB047); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB046:
                    _ram[0x071B] = A; TotalCycles += 4; PC = 0xB049;
                    goto case 0xB049;
                case 0xB049: // === SUBROUTINE: GameRoutines ===
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB04A: // === SUBROUTINE: Sub_B04A ===
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0xB04C;
                    goto case 0xB04C;
                case 0xB04B:
                    _ram[0x0420] = Asl(_ram[0x0420]); TotalCycles += 6; PC = 0xB04E;
                    goto case 0xB04E;
                case 0xB04C:
                    TotalCycles += 6; PushU16(0xB04E); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB04E:
                    WriteIoReg(0x9131, X); TotalCycles += 4; PC = 0xB051;
                    return;
                case 0xB04F:
                    A &= ReadMem(ReadU16Zp(0x91) + Y); SetZN(A); TotalCycles += 5; PC = 0xB051;
                    return;
                case 0xB050:
                    WriteMem(ReadU16Zp(0xC7) + Y, A); TotalCycles += 6; PC = 0xB052;
                    goto case 0xB052;
                case 0xB052:
                    A = ReadMem(ReadU16Zp(0x06) + Y); SetZN(A); TotalCycles += 5; PC = 0xB054;
                    return;
                case 0xB053:
                    _ram[0xB2] = Asl(_ram[0xB2]); TotalCycles += 5; PC = 0xB055;
                    goto case 0xB055;
                case 0xB055:
                    Sbc(_ram[0xB1]); TotalCycles += 3; PC = 0xB057;
                    goto case 0xB057;
                case 0xB056:
                    A = ReadMem(ReadU16Zp(0xA4) + Y); SetZN(A); TotalCycles += 5; PC = 0xB058;
                    return;
                case 0xB057:
                    Y = _ram[0xB2]; SetZN(Y); TotalCycles += 3; PC = 0xB059;
                    goto case 0xB059;
                case 0xB059:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xB05A;
                    return;
                case 0xB05B:
                    Cmp(A, ReadIoReg(0x6991)); TotalCycles += 4; PC = 0xB05E;
                    goto case 0xB05E;
                case 0xB05C:
                    WriteMem(ReadU16Zp(0x69) + Y, A); TotalCycles += 6; PC = 0xB05E;
                    goto case 0xB05E;
                case 0xB05D:
                    Adc(0xB0); TotalCycles += 2; PC = 0xB05F;
                    goto case 0xB05F;
                case 0xB05E:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB049; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB049; }
                    PC = 0xB060; goto case 0xB060;
                case 0xB05F:
                    Sbc(0xB0); TotalCycles += 2; PC = 0xB061;
                    return;
                case 0xB060:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB095; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB095; }
                    PC = 0xB062; return;
                case 0xB063:
                    A ^= _ram[0xB2]; SetZN(A); TotalCycles += 3; PC = 0xB065;
                    goto case 0xB065;
                case 0xB065:
                    Adc(0xB2); TotalCycles += 2; PC = 0xB067;
                    goto case 0xB067;
                case 0xB067:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x2DB2 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xB06A;
                    return;
                case 0xB069:
                    A = _ram[0x0752]; SetZN(A); TotalCycles += 4; PC = 0xB06C;
                    goto case 0xB06C;
                case 0xB06C:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xB06E;
                    goto case 0xB06E;
                case 0xB06E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB09B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB09B; }
                    PC = 0xB070; goto case 0xB070;
                case 0xB070:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB072;
                    goto case 0xB072;
                case 0xB071:
                    TotalCycles += 7; PushU16(0xB073); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB072:
                    Y = _ram[0xCE]; SetZN(Y); TotalCycles += 3; PC = 0xB074;
                    goto case 0xB074;
                case 0xB073: // === SUBROUTINE: PlayerEntrance ===
                    { int a = 0x30C0; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB076;
                    goto case 0xB076;
                case 0xB074:
                    Cmp(Y, 0x30); TotalCycles += 2; PC = 0xB076;
                    goto case 0xB076;
                case 0xB075:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB007; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB007; }
                    PC = 0xB077; goto case 0xB077;
                case 0xB076:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB0E6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB0E6; }
                    PC = 0xB078; goto case 0xB078;
                case 0xB077:
                    _ram[0x00AD] = Ror(_ram[0x00AD]); TotalCycles += 6; PC = 0xB07A;
                    return;
                case 0xB078:
                    A = _ram[0x0710]; SetZN(A); TotalCycles += 4; PC = 0xB07B;
                    goto case 0xB07B;
                case 0xB079:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB082; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB082; }
                    PC = 0xB07B; goto case 0xB07B;
                case 0xB07B:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0xB07D;
                    goto case 0xB07D;
                case 0xB07C:
                    _ram[0xF0] = Asl(_ram[0xF0]); TotalCycles += 5; PC = 0xB07E;
                    return;
                case 0xB07D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB083; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB083; }
                    PC = 0xB07F; goto case 0xB07F;
                case 0xB07F:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0xB081;
                    goto case 0xB081;
                case 0xB081:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB0D3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB0D3; }
                    PC = 0xB083; goto case 0xB083;
                case 0xB082:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB031; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB031; }
                    PC = 0xB084; goto case 0xB084;
                case 0xB083:
                    A = _ram[0x03C4]; SetZN(A); TotalCycles += 4; PC = 0xB086;
                    goto case 0xB086;
                case 0xB084:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0xB086;
                    goto case 0xB086;
                case 0xB086:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB08D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB08D; }
                    PC = 0xB088; goto case 0xB088;
                case 0xB087:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xB089;
                    goto case 0xB089;
                case 0xB088:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB08A;
                    goto case 0xB08A;
                case 0xB089:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xB08B;
                    goto case 0xB08B;
                case 0xB08A:
                    TotalCycles += 3; PC = 0xB0E6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB0E6;
                case 0xB08B:
                    _ram[0xB0] = IncVal(_ram[0xB0]); TotalCycles += 5; PC = 0xB08D;
                    goto case 0xB08D;
                case 0xB08C:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB0AE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB08E; return;
                case 0xB08D:
                    TotalCycles += 6; PushU16(0xB08F); PC = 0xB21F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB21F;
                case 0xB090:
                    _ram[0x06DE] = DecVal(_ram[0x06DE]); TotalCycles += 6; PC = 0xB093;
                    goto case 0xB093;
                case 0xB091:
                    { int a = 0xD006 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xB094;
                    goto case 0xB094;
                case 0xB092:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xB094;
                    goto case 0xB094;
                case 0xB093:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB0E5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB0E5; }
                    PC = 0xB095; goto case 0xB095;
                case 0xB094:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB084; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB084; }
                    PC = 0xB096; goto case 0xB096;
                case 0xB095:
                    _ram[0x0769] = IncVal(_ram[0x0769]); TotalCycles += 6; PC = 0xB098;
                    goto case 0xB098;
                case 0xB096:
                    Adc(0x07); TotalCycles += 2; PC = 0xB098;
                    goto case 0xB098;
                case 0xB098:
                    TotalCycles += 3; PC = 0xB315;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB315;
                case 0xB099:
                    A |= _ram[(byte)(0xB3 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB09B;
                    goto case 0xB09B;
                case 0xB09B: // === SUBROUTINE: Sub_B09B ===
                    A = _ram[0x0758]; SetZN(A); TotalCycles += 4; PC = 0xB09E;
                    goto case 0xB09E;
                case 0xB09C:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xB09D;
                    return;
                case 0xB09E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB0AC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB0AC; }
                    PC = 0xB0A0; goto case 0xB0A0;
                case 0xB0A0:
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0xB0A2;
                    goto case 0xB0A2;
                case 0xB0A2:
                    TotalCycles += 6; PushU16(0xB0A4); PC = 0xB200;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB200;
                case 0xB0A3:
                    TotalCycles += 7; PushU16(0xB0A5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB0A5:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB0A7;
                    goto case 0xB0A7;
                case 0xB0A6:
                    { int a = 0x91C9; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB0A9;
                    goto case 0xB0A9;
                case 0xB0A7:
                    Cmp(A, 0x91); TotalCycles += 2; PC = 0xB0A9;
                    goto case 0xB0A9;
                case 0xB0A8:
                    WriteMem(ReadU16Zp(0x90) + Y, A); TotalCycles += 6; PC = 0xB0AA;
                    goto case 0xB0AA;
                case 0xB0A9:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB0D3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB0D3; }
                    PC = 0xB0AB; goto case 0xB0AB;
                case 0xB0AA:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xB0AB;
                    goto case 0xB0AB;
                case 0xB0AB:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB0AC:
                    A = _ram[0x0399]; SetZN(A); TotalCycles += 4; PC = 0xB0AF;
                    goto case 0xB0AF;
                case 0xB0AD:
                    WriteMem(0xC903 + Y, A); TotalCycles += 5; PC = 0xB0B0;
                    goto case 0xB0B0;
                case 0xB0AF:
                    Cmp(A, 0x60); TotalCycles += 2; PC = 0xB0B1;
                    goto case 0xB0B1;
                case 0xB0B0:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB0B1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB0E5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB0E5; }
                    PC = 0xB0B3; goto case 0xB0B3;
                case 0xB0B3:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB0B5;
                    goto case 0xB0B5;
                case 0xB0B4:
                    { int a = 0x99C9; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB0B7;
                    goto case 0xB0B7;
                case 0xB0B5:
                    Cmp(A, 0x99); TotalCycles += 2; PC = 0xB0B7;
                    goto case 0xB0B7;
                case 0xB0B6:
                    _ram[(0x00A0 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xB0B9;
                    goto case 0xB0B9;
                case 0xB0B7:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB0B9;
                    goto case 0xB0B9;
                case 0xB0B8:
                    TotalCycles += 7; PushU16(0xB0BA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB0B9:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB0BB;
                    goto case 0xB0BB;
                case 0xB0BA:
                    A |= ReadMem(ReadU16Zp((byte)(0x90 + X))); SetZN(A); TotalCycles += 6; PC = 0xB0BC;
                    goto case 0xB0BC;
                case 0xB0BB:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB0C7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB0C7; }
                    PC = 0xB0BD; goto case 0xB0BD;
                case 0xB0BC:
                    A = Asl(A); TotalCycles += 2; PC = 0xB0BD;
                    goto case 0xB0BD;
                case 0xB0BD:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xB0BF;
                    goto case 0xB0BF;
                case 0xB0BF:
                    _ram[0x1D] = A; TotalCycles += 3; PC = 0xB0C1;
                    goto case 0xB0C1;
                case 0xB0C0:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x29C8 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB0C3;
                    goto case 0xB0C3;
                case 0xB0C1:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB0C2;
                    goto case 0xB0C2;
                case 0xB0C2:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xB0C4;
                    goto case 0xB0C4;
                case 0xB0C3:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB0C4;
                    goto case 0xB0C4;
                case 0xB0C4:
                    _ram[0x05B4] = A; TotalCycles += 4; PC = 0xB0C7;
                    goto case 0xB0C7;
                case 0xB0C5:
                    Y = _ram[(byte)(0x05 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB0C7;
                    goto case 0xB0C7;
                case 0xB0C6:
                    A |= _ram[0x8C]; SetZN(A); TotalCycles += 3; PC = 0xB0C8;
                    goto case 0xB0C8;
                case 0xB0C7:
                    _ram[0x0716] = Y; TotalCycles += 4; PC = 0xB0CA;
                    goto case 0xB0CA;
                case 0xB0C8:
                    { byte z = (byte)(0x07 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB0CA;
                    goto case 0xB0CA;
                case 0xB0CA:
                    TotalCycles += 6; PushU16(0xB0CC); PC = 0xB0E6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB0E6;
                case 0xB0CB:
                    _ram[0xB0] = IncVal(_ram[0xB0]); TotalCycles += 5; PC = 0xB0CD;
                    goto case 0xB0CD;
                case 0xB0CC: // === SUBROUTINE: Sub_B0CC ===
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB073; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB073; }
                    PC = 0xB0CE; goto case 0xB0CE;
                case 0xB0CD:
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xB0CF;
                    goto case 0xB0CF;
                case 0xB0CE:
                    _ram[0xC9] = X; TotalCycles += 3; PC = 0xB0D0;
                    goto case 0xB0D0;
                case 0xB0CF: // === SUBROUTINE: Sub_B0CF ===
                    Cmp(A, 0x48); TotalCycles += 2; PC = 0xB0D1;
                    goto case 0xB0D1;
                case 0xB0D0:
                    PushU8(A); TotalCycles += 3; PC = 0xB0D1;
                    goto case 0xB0D1;
                case 0xB0D1:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB0E5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB0E5; }
                    PC = 0xB0D3; goto case 0xB0D3;
                case 0xB0D3:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xB0D5;
                    goto case 0xB0D5;
                case 0xB0D4:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB0D5;
                    goto case 0xB0D5;
                case 0xB0D5:
                    _ram[0x0E] = A; TotalCycles += 3; PC = 0xB0D7;
                    goto case 0xB0D7;
                case 0xB0D6:
                    _ram[0x01A9] = Asl(_ram[0x01A9]); TotalCycles += 6; PC = 0xB0D9;
                    goto case 0xB0D9;
                case 0xB0D7:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB0D9;
                    goto case 0xB0D9;
                case 0xB0D8:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xB0DA;
                    return;
                case 0xB0D9:
                    _ram[0x33] = A; TotalCycles += 3; PC = 0xB0DB;
                    goto case 0xB0DB;
                case 0xB0DB:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB0DC;
                    goto case 0xB0DC;
                case 0xB0DC:
                    _ram[0x0752] = A; TotalCycles += 4; PC = 0xB0DF;
                    goto case 0xB0DF;
                case 0xB0DF:
                    _ram[0x0716] = A; TotalCycles += 4; PC = 0xB0E2;
                    goto case 0xB0E2;
                case 0xB0E0:
                    { byte z = (byte)(0x07 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB0E2;
                    goto case 0xB0E2;
                case 0xB0E2:
                    _ram[0x0758] = A; TotalCycles += 4; PC = 0xB0E5;
                    goto case 0xB0E5;
                case 0xB0E3:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xB0E4;
                    return;
                case 0xB0E5:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB0E6: // === SUBROUTINE: Sub_B0E6 ===
                    _ram[0x06FC] = A; TotalCycles += 4; PC = 0xB0E9;
                    goto case 0xB0E9;
                case 0xB0E8:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xB0EA;
                    goto case 0xB0EA;
                case 0xB0E9: // === SUBROUTINE: PlayerCtrlRoutine ===
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0xB0EB;
                    goto case 0xB0EB;
                case 0xB0EA:
                    _ram[0x03C9] = Asl(_ram[0x03C9]); TotalCycles += 6; PC = 0xB0ED;
                    goto case 0xB0ED;
                case 0xB0EB:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0xB0ED;
                    goto case 0xB0ED;
                case 0xB0ED:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB12B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB12B; }
                    PC = 0xB0EF; goto case 0xB0EF;
                case 0xB0EF:
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0xB0F2;
                    goto case 0xB0F2;
                case 0xB0F0:
                    { int a = 0xD007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xB0F3;
                    goto case 0xB0F3;
                case 0xB0F2:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB104; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB104; }
                    PC = 0xB0F4; goto case 0xB0F4;
                case 0xB0F3:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB099; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB099; }
                    PC = 0xB0F5; goto case 0xB0F5;
                case 0xB0F4:
                    Y = _ram[0xB5]; SetZN(Y); TotalCycles += 3; PC = 0xB0F6;
                    goto case 0xB0F6;
                case 0xB0F5:
                    A = _ram[(byte)(0x88 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB0F7;
                    goto case 0xB0F7;
                case 0xB0F6:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB0F7;
                    goto case 0xB0F7;
                case 0xB0F7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB0FF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB0FF; }
                    PC = 0xB0F9; goto case 0xB0F9;
                case 0xB0F8:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xB0FA;
                    goto case 0xB0FA;
                case 0xB0F9:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB0FB;
                    goto case 0xB0FB;
                case 0xB0FA:
                    { int a = 0xD0C9; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB0FD;
                    goto case 0xB0FD;
                case 0xB0FB:
                    Cmp(A, 0xD0); TotalCycles += 2; PC = 0xB0FD;
                    goto case 0xB0FD;
                case 0xB0FC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB08E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB0FE; goto case 0xB0FE;
                case 0xB0FD:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB104; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB104; }
                    PC = 0xB0FF; goto case 0xB0FF;
                case 0xB0FE:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xB100;
                    goto case 0xB100;
                case 0xB0FF:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB101;
                    goto case 0xB101;
                case 0xB100:
                    TotalCycles += 7; PushU16(0xB102); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB101:
                    _ram[0x06FC] = A; TotalCycles += 4; PC = 0xB104;
                    goto case 0xB104;
                case 0xB103:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xB105;
                    return;
                case 0xB104:
                    A = _ram[0x06FC]; SetZN(A); TotalCycles += 4; PC = 0xB107;
                    goto case 0xB107;
                case 0xB106:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0xB108;
                    goto case 0xB108;
                case 0xB107:
                    A &= 0xC0; SetZN(A); TotalCycles += 2; PC = 0xB109;
                    goto case 0xB109;
                case 0xB108:
                    Cmp(Y, 0x85); TotalCycles += 2; PC = 0xB10A;
                    goto case 0xB10A;
                case 0xB109:
                    _ram[0x0A] = A; TotalCycles += 3; PC = 0xB10B;
                    goto case 0xB10B;
                case 0xB10A:
                    A = Asl(A); TotalCycles += 2; PC = 0xB10B;
                    goto case 0xB10B;
                case 0xB10B:
                    A = _ram[0x06FC]; SetZN(A); TotalCycles += 4; PC = 0xB10E;
                    goto case 0xB10E;
                case 0xB10D:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0xB10F;
                    return;
                case 0xB10E:
                    A &= 0x03; SetZN(A); TotalCycles += 2; PC = 0xB110;
                    goto case 0xB110;
                case 0xB110:
                    _ram[0x0C] = A; TotalCycles += 3; PC = 0xB112;
                    goto case 0xB112;
                case 0xB112:
                    A = _ram[0x06FC]; SetZN(A); TotalCycles += 4; PC = 0xB115;
                    goto case 0xB115;
                case 0xB114:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0xB116;
                    return;
                case 0xB115:
                    A &= 0x0C; SetZN(A); TotalCycles += 2; PC = 0xB117;
                    goto case 0xB117;
                case 0xB117:
                    _ram[0x0B] = A; TotalCycles += 3; PC = 0xB119;
                    goto case 0xB119;
                case 0xB119:
                    A &= 0x04; SetZN(A); TotalCycles += 2; PC = 0xB11B;
                    goto case 0xB11B;
                case 0xB11B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB12B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB12B; }
                    PC = 0xB11D; goto case 0xB11D;
                case 0xB11C:
                    _ram[0x05A5] = Asl(_ram[0x05A5]); TotalCycles += 6; PC = 0xB11F;
                    goto case 0xB11F;
                case 0xB11D:
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xB11F;
                    goto case 0xB11F;
                case 0xB11E:
                    A |= ReadMem(0x0AD0 + X); SetZN(A); TotalCycles += 4; PC = 0xB121;
                    goto case 0xB121;
                case 0xB11F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB12B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB12B; }
                    PC = 0xB121; goto case 0xB121;
                case 0xB120:
                    A = Asl(A); TotalCycles += 2; PC = 0xB121;
                    goto case 0xB121;
                case 0xB121:
                    Y = _ram[0x0C]; SetZN(Y); TotalCycles += 3; PC = 0xB123;
                    goto case 0xB123;
                case 0xB123:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB12B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB12B; }
                    PC = 0xB125; goto case 0xB125;
                case 0xB124:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xB126;
                    goto case 0xB126;
                case 0xB125:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB127;
                    goto case 0xB127;
                case 0xB126:
                    TotalCycles += 7; PushU16(0xB128); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB127:
                    _ram[0x0C] = A; TotalCycles += 3; PC = 0xB129;
                    goto case 0xB129;
                case 0xB129:
                    _ram[0x0B] = A; TotalCycles += 3; PC = 0xB12B;
                    goto case 0xB12B;
                case 0xB12B:
                    TotalCycles += 6; PushU16(0xB12D); PC = 0xB329;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB329;
                case 0xB12C:
                    A &= 0xB3; SetZN(A); TotalCycles += 2; PC = 0xB12E;
                    goto case 0xB12E;
                case 0xB12E:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xB130;
                    goto case 0xB130;
                case 0xB12F:
                    A |= ReadMem(ReadU16Zp((byte)(0xAD + X))); SetZN(A); TotalCycles += 6; PC = 0xB131;
                    return;
                case 0xB130:
                    A = _ram[0x0754]; SetZN(A); TotalCycles += 4; PC = 0xB133;
                    goto case 0xB133;
                case 0xB133:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB13E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB13E; }
                    PC = 0xB135; goto case 0xB135;
                case 0xB134:
                    A |= 0xA0; SetZN(A); TotalCycles += 2; PC = 0xB136;
                    goto case 0xB136;
                case 0xB135:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB137;
                    goto case 0xB137;
                case 0xB136:
                    TotalCycles += 7; PushU16(0xB138); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB137:
                    A = _ram[0x0714]; SetZN(A); TotalCycles += 4; PC = 0xB13A;
                    goto case 0xB13A;
                case 0xB13A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB13E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB13E; }
                    PC = 0xB13C; goto case 0xB13C;
                case 0xB13C:
                    Y = 0x02; SetZN(Y); TotalCycles += 2; PC = 0xB13E;
                    goto case 0xB13E;
                case 0xB13E: // === SUBROUTINE: AutoControlPlayer ===
                    _ram[0x0499] = Y; TotalCycles += 4; PC = 0xB141;
                    goto case 0xB141;
                case 0xB13F:
                    WriteMem(0xA904 + Y, A); TotalCycles += 5; PC = 0xB142;
                    goto case 0xB142;
                case 0xB141:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB143;
                    goto case 0xB143;
                case 0xB142:
                    A |= ReadMem(ReadU16Zp((byte)(0xA4 + X))); SetZN(A); TotalCycles += 6; PC = 0xB144;
                    return;
                case 0xB143:
                    Y = _ram[0x57]; SetZN(Y); TotalCycles += 3; PC = 0xB145;
                    goto case 0xB145;
                case 0xB145:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB14C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB14C; }
                    PC = 0xB147; goto case 0xB147;
                case 0xB146:
                    A |= _ram[0x10]; SetZN(A); TotalCycles += 3; PC = 0xB148;
                    goto case 0xB148;
                case 0xB147: // === SUBROUTINE: Vine_AutoClimb ===
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB14A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB14A; }
                    PC = 0xB149; goto case 0xB149;
                case 0xB148:
                    A |= ReadMem(ReadU16Zp((byte)(0x0A + X))); SetZN(A); TotalCycles += 6; PC = 0xB14A;
                    goto case 0xB14A;
                case 0xB149:
                    A = Asl(A); TotalCycles += 2; PC = 0xB14A;
                    goto case 0xB14A;
                case 0xB14A:
                    _ram[0x45] = A; TotalCycles += 3; PC = 0xB14C;
                    goto case 0xB14C;
                case 0xB14B:
                    A ^= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0xB14D;
                    return;
                case 0xB14C:
                    TotalCycles += 6; PushU16(0xB14E); PC = 0xAF93;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xAF93;
                case 0xB14F:
                    TotalCycles += 6; PushU16(0xB151); PC = 0xF180;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB151:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xB153;
                    goto case 0xB153;
                case 0xB152:
                    TotalCycles += 6; PushU16(0xB154); PC = 0xF12A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB153:
                    A = Rol(A); TotalCycles += 2; PC = 0xB154;
                    goto case 0xB154;
                case 0xB154:
                    Sbc(ReadMem(ReadU16Zp(0xA2) + Y)); TotalCycles += 5; PC = 0xB156;
                    goto case 0xB156;
                case 0xB155:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xB157;
                    goto case 0xB157;
                case 0xB156:
                    TotalCycles += 7; PushU16(0xB158); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB157:
                    TotalCycles += 6; PushU16(0xB159); PC = 0xE29C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB15A:
                    TotalCycles += 6; PushU16(0xB15C); PC = 0xDC64;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB15D:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB15F;
                    goto case 0xB15F;
                case 0xB15E:
                    { int a = 0x40C9; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB161;
                    goto case 0xB161;
                case 0xB15F:
                    Cmp(A, 0x40); TotalCycles += 2; PC = 0xB161;
                    goto case 0xB161;
                case 0xB160:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xB161:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB179; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB179; }
                    PC = 0xB163; goto case 0xB163;
                case 0xB162:
                    { byte z = (byte)(0xA5 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB164;
                    goto case 0xB164;
                case 0xB163:
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0xB165;
                    goto case 0xB165;
                case 0xB164:
                    _ram[0x05C9] = Asl(_ram[0x05C9]); TotalCycles += 6; PC = 0xB167;
                    goto case 0xB167;
                case 0xB165:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xB167;
                    goto case 0xB167;
                case 0xB166:
                    A |= _ram[0xF0]; SetZN(A); TotalCycles += 3; PC = 0xB168;
                    goto case 0xB168;
                case 0xB167:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB179; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB179; }
                    PC = 0xB169; goto case 0xB169;
                case 0xB168:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB133; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB133; }
                    PC = 0xB16A; return;
                case 0xB169:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0xB16B;
                    goto case 0xB16B;
                case 0xB16B: // === SUBROUTINE: SetEntr ===
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB179; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB179; }
                    PC = 0xB16D; goto case 0xB16D;
                case 0xB16D:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0xB16F;
                    goto case 0xB16F;
                case 0xB16F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB179; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB179; }
                    PC = 0xB171; goto case 0xB171;
                case 0xB170:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB171;
                    goto case 0xB171;
                case 0xB171:
                    A = _ram[0x03C4]; SetZN(A); TotalCycles += 4; PC = 0xB174;
                    goto case 0xB174;
                case 0xB172:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0xB174;
                    goto case 0xB174;
                case 0xB174:
                    A &= 0xDF; SetZN(A); TotalCycles += 2; PC = 0xB176;
                    goto case 0xB176;
                case 0xB176:
                    _ram[0x03C4] = A; TotalCycles += 4; PC = 0xB179;
                    goto case 0xB179;
                case 0xB177:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0xB179;
                    goto case 0xB179;
                case 0xB179:
                    A = _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xB17B;
                    goto case 0xB17B;
                case 0xB17A:
                    A = _ram[(byte)(0xC9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB17C;
                    return;
                case 0xB17B:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xB17D;
                    goto case 0xB17D;
                case 0xB17D:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB1BA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB1BA; }
                    PC = 0xB17F; goto case 0xB17F;
                case 0xB17F:
                    X = 0x01; SetZN(X); TotalCycles += 2; PC = 0xB181;
                    goto case 0xB181;
                case 0xB180:
                    A |= ReadMem(ReadU16Zp((byte)(0x8E + X))); SetZN(A); TotalCycles += 6; PC = 0xB182;
                    return;
                case 0xB181:
                    _ram[0x0723] = X; TotalCycles += 4; PC = 0xB184;
                    goto case 0xB184;
                case 0xB184:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xB186;
                    goto case 0xB186;
                case 0xB186:
                    _ram[0x07] = Y; TotalCycles += 3; PC = 0xB188;
                    goto case 0xB188;
                case 0xB188:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xB18A;
                    goto case 0xB18A;
                case 0xB189:
                    TotalCycles += 7; PushU16(0xB18B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB18A:
                    Y = _ram[0x0759]; SetZN(Y); TotalCycles += 4; PC = 0xB18D;
                    goto case 0xB18D;
                case 0xB18B:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x5007 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB18E;
                    goto case 0xB18E;
                case 0xB18D:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB194; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB194; }
                    PC = 0xB18F; goto case 0xB18F;
                case 0xB18E:
                    A |= _ram[0xAC]; SetZN(A); TotalCycles += 3; PC = 0xB190;
                    return;
                case 0xB18F:
                    Y = _ram[0x0743]; SetZN(Y); TotalCycles += 4; PC = 0xB192;
                    goto case 0xB192;
                case 0xB192:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB1AA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB1AA; }
                    PC = 0xB194; goto case 0xB194;
                case 0xB193:
                    { byte z = (byte)(0xE8 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB195;
                    goto case 0xB195;
                case 0xB194:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xB195;
                    goto case 0xB195;
                case 0xB195:
                    Y = _ram[0x0E]; SetZN(Y); TotalCycles += 3; PC = 0xB197;
                    goto case 0xB197;
                case 0xB196:
                    _ram[0x03C0] = Asl(_ram[0x03C0]); TotalCycles += 6; PC = 0xB199;
                    goto case 0xB199;
                case 0xB197:
                    Cmp(Y, 0x0B); TotalCycles += 2; PC = 0xB199;
                    goto case 0xB199;
                case 0xB199:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB1AA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB1AA; }
                    PC = 0xB19B; goto case 0xB19B;
                case 0xB19B:
                    Y = _ram[0x0712]; SetZN(Y); TotalCycles += 4; PC = 0xB19E;
                    goto case 0xB19E;
                case 0xB19E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB1A6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB1A6; }
                    PC = 0xB1A0; goto case 0xB1A0;
                case 0xB19F:
                    _ram[0xC8] = Asl(_ram[0xC8]); TotalCycles += 5; PC = 0xB1A1;
                    goto case 0xB1A1;
                case 0xB1A0:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB1A1;
                    goto case 0xB1A1;
                case 0xB1A1:
                    _ram[0xFC] = Y; TotalCycles += 3; PC = 0xB1A3;
                    goto case 0xB1A3;
                case 0xB1A3:
                    _ram[0x0712] = Y; TotalCycles += 4; PC = 0xB1A6;
                    goto case 0xB1A6;
                case 0xB1A6:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0xB1A8;
                    goto case 0xB1A8;
                case 0xB1A7:
                    _ram[0x84] = Asl(_ram[0x84]); TotalCycles += 5; PC = 0xB1A9;
                    return;
                case 0xB1A8:
                    _ram[0x07] = Y; TotalCycles += 3; PC = 0xB1AA;
                    goto case 0xB1AA;
                case 0xB1AA:
                    Cmp(A, _ram[0x07]); TotalCycles += 3; PC = 0xB1AC;
                    goto case 0xB1AC;
                case 0xB1AC:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB1BA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB1BA; }
                    PC = 0xB1AE; goto case 0xB1AE;
                case 0xB1AE:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xB1AF;
                    goto case 0xB1AF;
                case 0xB1AF:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB1BB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB1BB; }
                    PC = 0xB1B1; goto case 0xB1B1;
                case 0xB1B0:
                    A = Asl(A); TotalCycles += 2; PC = 0xB1B1;
                    goto case 0xB1B1;
                case 0xB1B1:
                    Y = _ram[0x07B1]; SetZN(Y); TotalCycles += 4; PC = 0xB1B4;
                    goto case 0xB1B4;
                case 0xB1B2:
                    A = ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xB1B4;
                    goto case 0xB1B4;
                case 0xB1B4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB1BA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB1BA; }
                    PC = 0xB1B6; goto case 0xB1B6;
                case 0xB1B6:
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0xB1B8;
                    goto case 0xB1B8;
                case 0xB1B7:
                    _ram[0x85] = Asl(_ram[0x85]); TotalCycles += 5; PC = 0xB1B9;
                    goto case 0xB1B9;
                case 0xB1B8:
                    _ram[0x0E] = A; TotalCycles += 3; PC = 0xB1BA;
                    goto case 0xB1BA;
                case 0xB1B9:
                    { int a = 0xA960; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB1BC;
                    goto case 0xB1BC;
                case 0xB1BA:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB1BB:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB1BD;
                    goto case 0xB1BD;
                case 0xB1BC:
                    TotalCycles += 7; PushU16(0xB1BE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB1BD:
                    _ram[0x0758] = A; TotalCycles += 4; PC = 0xB1C0;
                    goto case 0xB1C0;
                case 0xB1BE:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xB1BF;
                    return;
                case 0xB1C0:
                    TotalCycles += 6; PushU16(0xB1C2); PC = 0xB1DD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB1DD;
                case 0xB1C1:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x6EB1 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xB1C4;
                    return;
                case 0xB1C2:
                    A = ReadMem(ReadU16Zp(0xEE) + Y); SetZN(A); TotalCycles += 5; PC = 0xB1C4;
                    return;
                case 0xB1C3:
                    _ram[0x0752] = IncVal(_ram[0x0752]); TotalCycles += 6; PC = 0xB1C6;
                    goto case 0xB1C6;
                case 0xB1C6:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB1C7: // === SUBROUTINE: Sub_B1C7 ===
                    A = _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xB1C9;
                    goto case 0xB1C9;
                case 0xB1C8:
                    A = _ram[(byte)(0xD0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB1CA;
                    goto case 0xB1CA;
                case 0xB1C9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB1D1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB1D1; }
                    PC = 0xB1CB; goto case 0xB1CB;
                case 0xB1CA:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xB1CC;
                    goto case 0xB1CC;
                case 0xB1CB:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB1CD;
                    goto case 0xB1CD;
                case 0xB1CC:
                    { int a = 0xE4C9; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB1CF;
                    goto case 0xB1CF;
                case 0xB1CD:
                    Cmp(A, 0xE4); TotalCycles += 2; PC = 0xB1CF;
                    goto case 0xB1CF;
                case 0xB1CE:
                    Cmp(X, _ram[0x90]); TotalCycles += 3; PC = 0xB1D0;
                    return;
                case 0xB1CF:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB1DD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB1DD; }
                    PC = 0xB1D1; goto case 0xB1D1;
                case 0xB1D1:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xB1D3;
                    goto case 0xB1D3;
                case 0xB1D2:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB1D3;
                    goto case 0xB1D3;
                case 0xB1D3:
                    _ram[0x0758] = A; TotalCycles += 4; PC = 0xB1D6;
                    goto case 0xB1D6;
                case 0xB1D4:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xB1D5;
                    return;
                case 0xB1D6:
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0xB1D8;
                    goto case 0xB1D8;
                case 0xB1D8:
                    _ram[0x1D] = Y; TotalCycles += 3; PC = 0xB1DA;
                    goto case 0xB1DA;
                case 0xB1D9:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x664C + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB1DC;
                    goto case 0xB1DC;
                case 0xB1DA:
                    TotalCycles += 3; PC = 0xB0E6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB0E6;
                case 0xB1DB:
                    _ram[0xB0] = IncVal(_ram[0xB0]); TotalCycles += 5; PC = 0xB1DD;
                    goto case 0xB1DD;
                case 0xB1DC:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB187; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB1DE; return;
                case 0xB1DD: // === SUBROUTINE: Sub_B1DD ===
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xB1DF;
                    goto case 0xB1DF;
                case 0xB1DF:
                    _ram[0x0752] = A; TotalCycles += 4; PC = 0xB1E2;
                    goto case 0xB1E2;
                case 0xB1E2:
                    TotalCycles += 3; PC = 0xB213;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB213;
                case 0xB1E5: // === SUBROUTINE: Sub_B1E5 ===
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB1E7;
                    goto case 0xB1E7;
                case 0xB1E6:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xB1E8;
                    goto case 0xB1E8;
                case 0xB1E7:
                    TotalCycles += 6; PushU16(0xB1E9); PC = 0xB200;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB200;
                case 0xB1E8:
                    TotalCycles += 7; PushU16(0xB1EA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB1EA:
                    TotalCycles += 6; PushU16(0xB1EC); PC = 0xAF93;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xAF93;
                case 0xB1ED:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB1EF;
                    goto case 0xB1EF;
                case 0xB1EE:
                    TotalCycles += 7; PushU16(0xB1F0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB1EF:
                    A = _ram[0x06D6]; SetZN(A); TotalCycles += 4; PC = 0xB1F2;
                    goto case 0xB1F2;
                case 0xB1F0:
                    { byte z = (byte)(0x06 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xB1F2;
                    goto case 0xB1F2;
                case 0xB1F1:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xB1F3;
                    return;
                case 0xB1F2:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB20B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB20B; }
                    PC = 0xB1F4; goto case 0xB1F4;
                case 0xB1F4:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB1F5;
                    goto case 0xB1F5;
                case 0xB1F5:
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0xB1F8;
                    goto case 0xB1F8;
                case 0xB1F6:
                    { int a = 0xC907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xB1F9;
                    return;
                case 0xB1F8:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xB1FA;
                    goto case 0xB1FA;
                case 0xB1FA:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB20B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB20B; }
                    PC = 0xB1FC; goto case 0xB1FC;
                case 0xB1FC:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB1FD;
                    goto case 0xB1FD;
                case 0xB1FD:
                    TotalCycles += 3; PC = 0xB20B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB20B;
                case 0xB200: // === SUBROUTINE: Sub_B200 ===
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB201;
                    goto case 0xB201;
                case 0xB201:
                    Adc(_ram[0xCE]); TotalCycles += 3; PC = 0xB203;
                    goto case 0xB203;
                case 0xB202:
                    { int a = 0xCE85; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB205;
                    goto case 0xB205;
                case 0xB203:
                    _ram[0xCE] = A; TotalCycles += 3; PC = 0xB205;
                    goto case 0xB205;
                case 0xB204:
                    { int a = 0x2060; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB207;
                    return;
                case 0xB205:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB206: // === SUBROUTINE: Sub_B206 ===
                    TotalCycles += 6; PushU16(0xB208); PC = 0xB21F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB21F;
                case 0xB209:
                    Y = 0x02; SetZN(Y); TotalCycles += 2; PC = 0xB20B;
                    goto case 0xB20B;
                case 0xB20B: // === SUBROUTINE: MovePlayerYAxis ===
                    _ram[0x06DE] = DecVal(_ram[0x06DE]); TotalCycles += 6; PC = 0xB20E;
                    goto case 0xB20E;
                case 0xB20C:
                    { int a = 0xD006 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xB20F;
                    goto case 0xB20F;
                case 0xB20D:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xB20F;
                    goto case 0xB20F;
                case 0xB20E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB21E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB21E; }
                    PC = 0xB210; goto case 0xB210;
                case 0xB20F:
                    { int a = 0x528C; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB212;
                    return;
                case 0xB210:
                    _ram[0x0752] = Y; TotalCycles += 4; PC = 0xB213;
                    goto case 0xB213;
                case 0xB213: // === SUBROUTINE: Sub_B213 ===
                    _ram[0x0774] = IncVal(_ram[0x0774]); TotalCycles += 6; PC = 0xB216;
                    goto case 0xB216;
                case 0xB216:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB218;
                    goto case 0xB218;
                case 0xB217:
                    TotalCycles += 7; PushU16(0xB219); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB218:
                    _ram[0x0772] = A; TotalCycles += 4; PC = 0xB21B;
                    goto case 0xB21B;
                case 0xB21B:
                    _ram[0x0722] = A; TotalCycles += 4; PC = 0xB21E;
                    goto case 0xB21E;
                case 0xB21E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB21F: // === SUBROUTINE: Sub_B21F ===
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xB221;
                    goto case 0xB221;
                case 0xB220: // === SUBROUTINE: SideExitPipeEntry ===
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB221;
                    goto case 0xB221;
                case 0xB221:
                    _ram[0x57] = A; TotalCycles += 3; PC = 0xB223;
                    goto case 0xB223;
                case 0xB223:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xB225;
                    goto case 0xB225;
                case 0xB224:
                    A |= ReadMem(ReadU16Zp((byte)(0xA5 + X))); SetZN(A); TotalCycles += 6; PC = 0xB226;
                    goto case 0xB226;
                case 0xB225:
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xB227;
                    goto case 0xB227;
                case 0xB226:
                    _ram[0x29] = X; TotalCycles += 3; PC = 0xB228;
                    return;
                case 0xB227:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0xB229;
                    goto case 0xB229;
                case 0xB229:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB22E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB22E; }
                    PC = 0xB22B; goto case 0xB22B;
                case 0xB22B:
                    _ram[0x57] = A; TotalCycles += 3; PC = 0xB22D;
                    goto case 0xB22D;
                case 0xB22D:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xB22E;
                    goto case 0xB22E;
                case 0xB22E:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB22F;
                    goto case 0xB22F;
                case 0xB22F:
                    TotalCycles += 6; PushU16(0xB231); PC = 0xB0E6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB0E6;
                case 0xB230:
                    _ram[0xB0] = IncVal(_ram[0xB0]); TotalCycles += 5; PC = 0xB232;
                    goto case 0xB232;
                case 0xB231:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB293; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB293; }
                    PC = 0xB233; goto case 0xB233;
                case 0xB232:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB233: // === SUBROUTINE: Sub_B233 ===
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xB236;
                    goto case 0xB236;
                case 0xB236:
                    Cmp(A, 0xF8); TotalCycles += 2; PC = 0xB238;
                    goto case 0xB238;
                case 0xB237:
                    P |= FlagD; TotalCycles += 2; PC = 0xB238;
                    goto case 0xB238;
                case 0xB238:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB23D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB23D; }
                    PC = 0xB23A; goto case 0xB23A;
                case 0xB23A:
                    TotalCycles += 3; PC = 0xB255;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB255;
                case 0xB23B:
                    A ^= _ram[(byte)(0xB2 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB23D;
                    goto case 0xB23D;
                case 0xB23D:
                    Cmp(A, 0xC4); TotalCycles += 2; PC = 0xB23F;
                    goto case 0xB23F;
                case 0xB23E:
                    Cmp(Y, _ram[0xD0]); TotalCycles += 3; PC = 0xB240;
                    return;
                case 0xB23F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB244; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB244; }
                    PC = 0xB241; goto case 0xB241;
                case 0xB241:
                    TotalCycles += 6; PushU16(0xB243); PC = 0xB273;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB273;
                case 0xB244:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB245: // === SUBROUTINE: Sub_B245 ===
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xB248;
                    goto case 0xB248;
                case 0xB248:
                    Cmp(A, 0xF0); TotalCycles += 2; PC = 0xB24A;
                    goto case 0xB24A;
                case 0xB249:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB1FB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB24B; return;
                case 0xB24A:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB253; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB253; }
                    PC = 0xB24C; goto case 0xB24C;
                case 0xB24C:
                    Cmp(A, 0xC8); TotalCycles += 2; PC = 0xB24E;
                    goto case 0xB24E;
                case 0xB24D:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB24E;
                    goto case 0xB24E;
                case 0xB24E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB273; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB273; }
                    PC = 0xB250; goto case 0xB250;
                case 0xB250:
                    TotalCycles += 3; PC = 0xB0E9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB0E9;
                case 0xB251:
                    Sbc(0xB0); TotalCycles += 2; PC = 0xB253;
                    goto case 0xB253;
                case 0xB252:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB224; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB224; }
                    PC = 0xB254; return;
                case 0xB253:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB268; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB268; }
                    PC = 0xB255; goto case 0xB255;
                case 0xB255:
                    Y = _ram[0x070B]; SetZN(Y); TotalCycles += 4; PC = 0xB258;
                    goto case 0xB258;
                case 0xB258:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB268; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB268; }
                    PC = 0xB25A; goto case 0xB25A;
                case 0xB259:
                    _ram[0x058C] = Asl(_ram[0x058C]); TotalCycles += 6; PC = 0xB25C;
                    return;
                case 0xB25A:
                    _ram[0x070D] = Y; TotalCycles += 4; PC = 0xB25D;
                    goto case 0xB25D;
                case 0xB25B:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x6E07]; SetZN(A); TotalCycles += 4; PC = 0xB25E;
                    return;
                case 0xB25D:
                    _ram[0x070B] = IncVal(_ram[0x070B]); TotalCycles += 6; PC = 0xB260;
                    goto case 0xB260;
                case 0xB260:
                    A = _ram[0x0754]; SetZN(A); TotalCycles += 4; PC = 0xB263;
                    goto case 0xB263;
                case 0xB263: // === SUBROUTINE: ChgAreaMode ===
                    A ^= 0x01; SetZN(A); TotalCycles += 2; PC = 0xB265;
                    goto case 0xB265;
                case 0xB264:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0xB266;
                    return;
                case 0xB265:
                    _ram[0x0754] = A; TotalCycles += 4; PC = 0xB268;
                    goto case 0xB268;
                case 0xB268:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB269: // === SUBROUTINE: Sub_B269 ===
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xB26C;
                    goto case 0xB26C;
                case 0xB26C:
                    Cmp(A, 0xF0); TotalCycles += 2; PC = 0xB26E;
                    goto case 0xB26E;
                case 0xB26D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB21F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB21F; }
                    PC = 0xB26F; return;
                case 0xB26E:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB2A3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2A3; }
                    PC = 0xB270; goto case 0xB270;
                case 0xB270: // === SUBROUTINE: EnterSidePipe ===
                    TotalCycles += 3; PC = 0xB0E9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB0E9;
                case 0xB271:
                    Sbc(0xB0); TotalCycles += 2; PC = 0xB273;
                    goto case 0xB273;
                case 0xB272:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB21D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB274; goto case 0xB274;
                case 0xB273: // === SUBROUTINE: Sub_B273 ===
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB275;
                    goto case 0xB275;
                case 0xB274:
                    TotalCycles += 7; PushU16(0xB276); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB275:
                    _ram[0x0747] = A; TotalCycles += 4; PC = 0xB278;
                    goto case 0xB278;
                case 0xB278:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xB27A;
                    goto case 0xB27A;
                case 0xB279:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB27A;
                    goto case 0xB27A;
                case 0xB27A:
                    _ram[0x0E] = A; TotalCycles += 3; PC = 0xB27C;
                    goto case 0xB27C;
                case 0xB27B:
                    { int a = 0xAD60; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB27E;
                    return;
                case 0xB27C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB27D: // === SUBROUTINE: Sub_B27D ===
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xB280;
                    goto case 0xB280;
                case 0xB280:
                    Cmp(A, 0xC0); TotalCycles += 2; PC = 0xB282;
                    goto case 0xB282;
                case 0xB281:
                    Cmp(Y, 0xF0); TotalCycles += 2; PC = 0xB283;
                    return;
                case 0xB282:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB297; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB297; }
                    PC = 0xB284; goto case 0xB284;
                case 0xB284:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xB286;
                    goto case 0xB286;
                case 0xB285:
                    A |= 0x4A; SetZN(A); TotalCycles += 2; PC = 0xB287;
                    goto case 0xB287;
                case 0xB286:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB287;
                    goto case 0xB287;
                case 0xB287:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB288;
                    goto case 0xB288;
                case 0xB288: // === SUBROUTINE: Sub_B288 ===
                    A &= 0x03; SetZN(A); TotalCycles += 2; PC = 0xB28A;
                    goto case 0xB28A;
                case 0xB28A:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xB28C;
                    goto case 0xB28C;
                case 0xB28B:
                    TotalCycles += 7; PushU16(0xB28D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB28C:
                    A = _ram[0x03C4]; SetZN(A); TotalCycles += 4; PC = 0xB28F;
                    goto case 0xB28F;
                case 0xB28D:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0xB28F;
                    goto case 0xB28F;
                case 0xB28F:
                    A &= 0xFC; SetZN(A); TotalCycles += 2; PC = 0xB291;
                    goto case 0xB291;
                case 0xB291:
                    A |= _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xB293;
                    goto case 0xB293;
                case 0xB292:
                    TotalCycles += 7; PushU16(0xB294); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB293:
                    _ram[0x03C4] = A; TotalCycles += 4; PC = 0xB296;
                    goto case 0xB296;
                case 0xB294:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0xB296;
                    goto case 0xB296;
                case 0xB296:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB297:
                    TotalCycles += 6; PushU16(0xB299); PC = 0xB273;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB273;
                case 0xB29A: // === SUBROUTINE: Sub_B29A ===
                    A = _ram[0x03C4]; SetZN(A); TotalCycles += 4; PC = 0xB29D;
                    goto case 0xB29D;
                case 0xB29B:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0xB29D;
                    goto case 0xB29D;
                case 0xB29D:
                    A &= 0xFC; SetZN(A); TotalCycles += 2; PC = 0xB29F;
                    goto case 0xB29F;
                case 0xB29F:
                    _ram[0x03C4] = A; TotalCycles += 4; PC = 0xB2A2;
                    goto case 0xB2A2;
                case 0xB2A0:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0xB2A2;
                    goto case 0xB2A2;
                case 0xB2A2:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB2A3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB2A4: // === SUBROUTINE: PlayerChangeSize ===
                    A = _ram[0x1B]; SetZN(A); TotalCycles += 3; PC = 0xB2A6;
                    goto case 0xB2A6;
                case 0xB2A6:
                    Cmp(A, 0x30); TotalCycles += 2; PC = 0xB2A8;
                    goto case 0xB2A8;
                case 0xB2A7:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB279; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB279; }
                    PC = 0xB2A9; goto case 0xB2A9;
                case 0xB2A8:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB2BF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2BF; }
                    PC = 0xB2AA; goto case 0xB2AA;
                case 0xB2A9:
                    A |= _ram[(byte)(0xAD + X)]; SetZN(A); TotalCycles += 4; PC = 0xB2AB;
                    return;
                case 0xB2AA:
                    A = _ram[0x0713]; SetZN(A); TotalCycles += 4; PC = 0xB2AD;
                    goto case 0xB2AD;
                case 0xB2AD:
                    _ram[0xFF] = A; TotalCycles += 3; PC = 0xB2AF;
                    goto case 0xB2AF;
                case 0xB2AF:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB2B1;
                    goto case 0xB2B1;
                case 0xB2B0:
                    TotalCycles += 7; PushU16(0xB2B2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB2B1:
                    _ram[0x0713] = A; TotalCycles += 4; PC = 0xB2B4;
                    goto case 0xB2B4;
                case 0xB2B4:
                    Y = _ram[0xCE]; SetZN(Y); TotalCycles += 3; PC = 0xB2B6;
                    goto case 0xB2B6;
                case 0xB2B5:
                    { int a = 0x9EC0; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB2B8;
                    goto case 0xB2B8;
                case 0xB2B6:
                    Cmp(Y, 0x9E); TotalCycles += 2; PC = 0xB2B8;
                    goto case 0xB2B8;
                case 0xB2B8:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB2BC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2BC; }
                    PC = 0xB2BA; goto case 0xB2BA;
                case 0xB2BA:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xB2BC;
                    goto case 0xB2BC;
                case 0xB2BC:
                    TotalCycles += 3; PC = 0xB0E6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB0E6;
                case 0xB2BD:
                    _ram[0xB0] = IncVal(_ram[0xB0]); TotalCycles += 5; PC = 0xB2BF;
                    goto case 0xB2BF;
                case 0xB2BE:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB2A6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2A6; }
                    PC = 0xB2C0; goto case 0xB2C0;
                case 0xB2BF:
                    _ram[0x0E] = IncVal(_ram[0x0E]); TotalCycles += 5; PC = 0xB2C1;
                    goto case 0xB2C1;
                case 0xB2C0:
                    _ram[0x0560] = Asl(_ram[0x0560]); TotalCycles += 6; PC = 0xB2C3;
                    return;
                case 0xB2C1:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB2C2:
                    A |= _ram[(byte)(0x23 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB2C4;
                    goto case 0xB2C4;
                case 0xB2C4:
                    { byte z = (byte)(0x1B + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB2C6;
                    return;
                case 0xB2C7:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB2C8;
                    return;
                case 0xB2CA:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB2CC;
                    goto case 0xB2CC;
                case 0xB2CB:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xB2CD;
                    goto case 0xB2CD;
                case 0xB2CC:
                    TotalCycles += 6; PushU16(0xB2CE); PC = 0xB0E6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB0E6;
                case 0xB2CD:
                    _ram[0xB0] = IncVal(_ram[0xB0]); TotalCycles += 5; PC = 0xB2CF;
                    goto case 0xB2CF;
                case 0xB2CE:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB275; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB275; }
                    PC = 0xB2D0; goto case 0xB2D0;
                case 0xB2CF:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB2D1;
                    goto case 0xB2D1;
                case 0xB2D0:
                    { int a = 0xAEC9; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB2D3;
                    goto case 0xB2D3;
                case 0xB2D1:
                    Cmp(A, 0xAE); TotalCycles += 2; PC = 0xB2D3;
                    goto case 0xB2D3;
                case 0xB2D2:
                    X = _ram[0x0690]; SetZN(X); TotalCycles += 4; PC = 0xB2D5;
                    goto case 0xB2D5;
                case 0xB2D3:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB2E3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2E3; }
                    PC = 0xB2D5; goto case 0xB2D5;
                case 0xB2D4:
                    { int a = 0x23AD; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB2D7;
                    return;
                case 0xB2D5:
                    A = _ram[0x0723]; SetZN(A); TotalCycles += 4; PC = 0xB2D8;
                    goto case 0xB2D8;
                case 0xB2D8:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB2E3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2E3; }
                    PC = 0xB2DA; goto case 0xB2DA;
                case 0xB2D9:
                    A |= 0xA9; SetZN(A); TotalCycles += 2; PC = 0xB2DB;
                    goto case 0xB2DB;
                case 0xB2DA:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0xB2DC;
                    goto case 0xB2DC;
                case 0xB2DB:
                    TotalCycles += 6; PushU16(0xB2DD); PC = 0xFC85;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB2DC:
                    _ram[0xFC] = A; TotalCycles += 3; PC = 0xB2DE;
                    goto case 0xB2DE;
                case 0xB2DE:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB2E0;
                    goto case 0xB2E0;
                case 0xB2DF: // === SUBROUTINE: PlayerInjuryBlink ===
                    TotalCycles += 7; PushU16(0xB2E1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB2E0:
                    _ram[0x0723] = A; TotalCycles += 4; PC = 0xB2E3;
                    goto case 0xB2E3;
                case 0xB2E3:
                    A = _ram[0x0490]; SetZN(A); TotalCycles += 4; PC = 0xB2E6;
                    goto case 0xB2E6;
                case 0xB2E4:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB2EA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2EA; }
                    PC = 0xB2E6; goto case 0xB2E6;
                case 0xB2E6:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB2E7;
                    goto case 0xB2E7;
                case 0xB2E7:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB2F6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2F6; }
                    PC = 0xB2E9; goto case 0xB2E9;
                case 0xB2E8:
                    A |= ReadIoReg(0x46AD); SetZN(A); TotalCycles += 4; PC = 0xB2EB;
                    return;
                case 0xB2E9:
                    A = _ram[0x0746]; SetZN(A); TotalCycles += 4; PC = 0xB2EC;
                    goto case 0xB2EC;
                case 0xB2EA:
                    _ram[0x07] = Lsr(_ram[0x07]); TotalCycles += 5; PC = 0xB2EC;
                    goto case 0xB2EC;
                case 0xB2EC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB2F1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2F1; }
                    PC = 0xB2EE; goto case 0xB2EE;
                case 0xB2EE:
                    _ram[0x0746] = IncVal(_ram[0x0746]); TotalCycles += 6; PC = 0xB2F1;
                    goto case 0xB2F1;
                case 0xB2EF:
                    _ram[0x07] = Lsr(_ram[0x07]); TotalCycles += 5; PC = 0xB2F1;
                    goto case 0xB2F1;
                case 0xB2F1:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0xB2F3;
                    goto case 0xB2F3;
                case 0xB2F2:
                    TotalCycles += 6; PushU16(0xB2F4); PC = 0xC48D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB2F3:
                    _ram[0x03C4] = A; TotalCycles += 4; PC = 0xB2F6;
                    goto case 0xB2F6;
                case 0xB2F4:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0xB2F6;
                    goto case 0xB2F6;
                case 0xB2F6:
                    A = _ram[0x0746]; SetZN(A); TotalCycles += 4; PC = 0xB2F9;
                    goto case 0xB2F9;
                case 0xB2F7:
                    _ram[0x07] = Lsr(_ram[0x07]); TotalCycles += 5; PC = 0xB2F9;
                    goto case 0xB2F9;
                case 0xB2F9:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xB2FB;
                    goto case 0xB2FB;
                case 0xB2FA:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xB2FC;
                    return;
                case 0xB2FB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB328; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB328; }
                    PC = 0xB2FD; goto case 0xB2FD;
                case 0xB2FD:
                    _ram[0x075C] = IncVal(_ram[0x075C]); TotalCycles += 6; PC = 0xB300;
                    goto case 0xB300;
                case 0xB300:
                    A = _ram[0x075C]; SetZN(A); TotalCycles += 4; PC = 0xB303;
                    goto case 0xB303;
                case 0xB303:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xB305;
                    goto case 0xB305;
                case 0xB305:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB315; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB315; }
                    PC = 0xB307; goto case 0xB307;
                case 0xB306:
                    { int a = 0x5FAC; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB309;
                    return;
                case 0xB307:
                    Y = _ram[0x075F]; SetZN(Y); TotalCycles += 4; PC = 0xB30A;
                    goto case 0xB30A;
                case 0xB30A:
                    A = _ram[0x0748]; SetZN(A); TotalCycles += 4; PC = 0xB30D;
                    goto case 0xB30D;
                case 0xB30B:
                    PushU8(A); TotalCycles += 3; PC = 0xB30C;
                    return;
                case 0xB30D:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x32C2 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xB310;
                    goto case 0xB310;
                case 0xB310:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB315; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB315; }
                    PC = 0xB312; goto case 0xB312;
                case 0xB312:
                    _ram[0x075D] = IncVal(_ram[0x075D]); TotalCycles += 6; PC = 0xB315;
                    goto case 0xB315;
                case 0xB313:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x6E07 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB316;
                    goto case 0xB316;
                case 0xB315:
                    _ram[0x0760] = IncVal(_ram[0x0760]); TotalCycles += 6; PC = 0xB318;
                    goto case 0xB318;
                case 0xB316: // === SUBROUTINE: InitChangeSize ===
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB318:
                    TotalCycles += 6; PushU16(0xB31A); PC = 0x9C03;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB31B:
                    _ram[0x0757] = IncVal(_ram[0x0757]); TotalCycles += 6; PC = 0xB31E;
                    goto case 0xB31E;
                case 0xB31E:
                    TotalCycles += 6; PushU16(0xB320); PC = 0xB213;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB213;
                case 0xB321:
                    _ram[0x075B] = A; TotalCycles += 4; PC = 0xB324;
                    goto case 0xB324;
                case 0xB324:
                    A = 0x80; SetZN(A); TotalCycles += 2; PC = 0xB326;
                    goto case 0xB326;
                case 0xB326:
                    _ram[0xFC] = A; TotalCycles += 3; PC = 0xB328;
                    goto case 0xB328;
                case 0xB328:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB329: // === SUBROUTINE: Sub_B329 ===
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB32B;
                    goto case 0xB32B;
                case 0xB32A:
                    TotalCycles += 7; PushU16(0xB32C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB32B:
                    Y = _ram[0x0754]; SetZN(Y); TotalCycles += 4; PC = 0xB32E;
                    goto case 0xB32E;
                case 0xB32E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB338; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB338; }
                    PC = 0xB330; goto case 0xB330;
                case 0xB32F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB330;
                    goto case 0xB330;
                case 0xB330:
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xB332;
                    goto case 0xB332;
                case 0xB331:
                    A |= _ram[(0x07D0 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB334;
                    goto case 0xB334;
                case 0xB332:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB33B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB33B; }
                    PC = 0xB334; goto case 0xB334;
                case 0xB334:
                    A = _ram[0x0B]; SetZN(A); TotalCycles += 3; PC = 0xB336;
                    goto case 0xB336;
                case 0xB336:
                    A &= 0x04; SetZN(A); TotalCycles += 2; PC = 0xB338;
                    goto case 0xB338;
                case 0xB338:
                    _ram[0x0714] = A; TotalCycles += 4; PC = 0xB33B;
                    goto case 0xB33B;
                case 0xB33B:
                    TotalCycles += 6; PushU16(0xB33D); PC = 0xB450;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB450;
                case 0xB33C:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB2F2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB2F2; }
                    PC = 0xB33E; goto case 0xB33E;
                case 0xB33D:
                    Y = _ram[(byte)(0xAD + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB33F;
                    return;
                case 0xB33E: // === SUBROUTINE: PlayerFireFlower ===
                    A = _ram[0x070B]; SetZN(A); TotalCycles += 4; PC = 0xB341;
                    goto case 0xB341;
                case 0xB341:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB359; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB359; }
                    PC = 0xB343; goto case 0xB343;
                case 0xB342:
                    { byte z = (byte)(0xA5 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB344;
                    goto case 0xB344;
                case 0xB343:
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xB345;
                    goto case 0xB345;
                case 0xB344:
                    A |= _ram[(0x03C9 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB347;
                    goto case 0xB347;
                case 0xB345:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xB347;
                    goto case 0xB347;
                case 0xB347:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB34E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB34E; }
                    PC = 0xB349; goto case 0xB349;
                case 0xB348:
                    A |= _ram[0xA0]; SetZN(A); TotalCycles += 3; PC = 0xB34A;
                    goto case 0xB34A;
                case 0xB349:
                    Y = 0x18; SetZN(Y); TotalCycles += 2; PC = 0xB34B;
                    goto case 0xB34B;
                case 0xB34A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB34B;
                    goto case 0xB34B;
                case 0xB34B:
                    _ram[0x0789] = Y; TotalCycles += 4; PC = 0xB34E;
                    goto case 0xB34E;
                case 0xB34E:
                    TotalCycles += 6; PushU16(0xB350); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB350:
                    WriteIoReg(0xB35A, X); TotalCycles += 4; PC = 0xB353;
                    goto case 0xB353;
                case 0xB353:
                    { byte z = (byte)(0xB3 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xB355;
                    goto case 0xB355;
                case 0xB355:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x4FB3]); TotalCycles += 4; PC = 0xB358;
                    return;
                case 0xB359:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB35A: // === SUBROUTINE: Sub_B35A ===
                    TotalCycles += 6; PushU16(0xB35C); PC = 0xB58F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB58F;
                case 0xB35C:
                    A = _ram[(byte)(0xA5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB35E;
                    return;
                case 0xB35D:
                    A = _ram[0x0C]; SetZN(A); TotalCycles += 3; PC = 0xB35F;
                    goto case 0xB35F;
                case 0xB35F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB363; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB363; }
                    PC = 0xB361; goto case 0xB361;
                case 0xB361:
                    _ram[0x33] = A; TotalCycles += 3; PC = 0xB363;
                    goto case 0xB363;
                case 0xB363:
                    TotalCycles += 6; PushU16(0xB365); PC = 0xB5CC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB5CC;
                case 0xB364:
                    Cmp(Y, ReadIoReg(0x20B5)); TotalCycles += 4; PC = 0xB367;
                    goto case 0xB367;
                case 0xB365:
                    A = _ram[(byte)(0x20 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB367;
                    goto case 0xB367;
                case 0xB366:
                    TotalCycles += 6; PushU16(0xB368); PC = 0xBF09;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF09;
                case 0xB367:
                    A |= 0xBF; SetZN(A); TotalCycles += 2; PC = 0xB369;
                    goto case 0xB369;
                case 0xB369:
                    _ram[0x06FF] = A; TotalCycles += 4; PC = 0xB36C;
                    goto case 0xB36C;
                case 0xB36B:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0xB36D;
                    goto case 0xB36D;
                case 0xB36C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB36D: // === SUBROUTINE: Sub_B36D ===
                    A = _ram[0x070A]; SetZN(A); TotalCycles += 4; PC = 0xB370;
                    goto case 0xB370;
                case 0xB36E:
                    A = Asl(A); TotalCycles += 2; PC = 0xB36F;
                    return;
                case 0xB370:
                    _ram[0x0709] = A; TotalCycles += 4; PC = 0xB373;
                    goto case 0xB373;
                case 0xB371:
                    A |= 0x07; SetZN(A); TotalCycles += 2; PC = 0xB373;
                    goto case 0xB373;
                case 0xB373:
                    TotalCycles += 3; PC = 0xB3AC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB3AC;
                case 0xB374:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x24B3]; SetZN(Y); TotalCycles += 4; PC = 0xB377;
                    return;
                case 0xB376: // === SUBROUTINE: Sub_B376 ===
                    Y = _ram[0x9F]; SetZN(Y); TotalCycles += 3; PC = 0xB378;
                    goto case 0xB378;
                case 0xB378:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB38D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB38D; }
                    PC = 0xB37A; goto case 0xB37A;
                case 0xB37A:
                    A = _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0xB37C;
                    goto case 0xB37C;
                case 0xB37B:
                    A = Asl(A); TotalCycles += 2; PC = 0xB37C;
                    goto case 0xB37C;
                case 0xB37C:
                    A &= 0x80; SetZN(A); TotalCycles += 2; PC = 0xB37E;
                    goto case 0xB37E;
                case 0xB37E:
                    A &= _ram[0x0D]; SetZN(A); TotalCycles += 3; PC = 0xB380;
                    goto case 0xB380;
                case 0xB37F:
                    A |= _ram[0x01D0]; SetZN(A); TotalCycles += 4; PC = 0xB382;
                    goto case 0xB382;
                case 0xB380:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB393; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB393; }
                    PC = 0xB382; goto case 0xB382;
                case 0xB381:
                    A |= ReadMem(ReadU16Zp(0xAD) + Y); SetZN(A); TotalCycles += 5; PC = 0xB383;
                    goto case 0xB383;
                case 0xB382:
                    A = _ram[0x0708]; SetZN(A); TotalCycles += 4; PC = 0xB385;
                    goto case 0xB385;
                case 0xB383: // === SUBROUTINE: ResetPalStar ===
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB384;
                    return;
                case 0xB385:
                    P |= FlagC; TotalCycles += 2; PC = 0xB386;
                    goto case 0xB386;
                case 0xB386:
                    Sbc(_ram[0xCE]); TotalCycles += 3; PC = 0xB388;
                    goto case 0xB388;
                case 0xB387:
                    _ram[0x06CD] = DecVal(_ram[0x06CD]); TotalCycles += 6; PC = 0xB38A;
                    return;
                case 0xB388:
                    Cmp(A, _ram[0x0706]); TotalCycles += 4; PC = 0xB38B;
                    goto case 0xB38B;
                case 0xB389:
                    _ram[0x07] = Asl(_ram[0x07]); TotalCycles += 5; PC = 0xB38B;
                    goto case 0xB38B;
                case 0xB38B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB393; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB393; }
                    PC = 0xB38D; goto case 0xB38D;
                case 0xB38C:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xB38E;
                    goto case 0xB38E;
                case 0xB38D:
                    A = _ram[0x070A]; SetZN(A); TotalCycles += 4; PC = 0xB390;
                    goto case 0xB390;
                case 0xB38E:
                    A = Asl(A); TotalCycles += 2; PC = 0xB38F;
                    return;
                case 0xB390:
                    _ram[0x0709] = A; TotalCycles += 4; PC = 0xB393;
                    goto case 0xB393;
                case 0xB391:
                    A |= 0x07; SetZN(A); TotalCycles += 2; PC = 0xB393;
                    goto case 0xB393;
                case 0xB393:
                    A = _ram[0x0704]; SetZN(A); TotalCycles += 4; PC = 0xB396;
                    goto case 0xB396;
                case 0xB396: // === SUBROUTINE: FlagpoleSlide ===
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB3AC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB3AC; }
                    PC = 0xB398; goto case 0xB398;
                case 0xB398:
                    TotalCycles += 6; PushU16(0xB39A); PC = 0xB58F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB58F;
                case 0xB39A:
                    A = _ram[(byte)(0xA5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB39C;
                    goto case 0xB39C;
                case 0xB39B:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB39D;
                    goto case 0xB39D;
                case 0xB39C:
                    _ram[0x04C9] = DecVal(_ram[0x04C9]); TotalCycles += 6; PC = 0xB39F;
                    goto case 0xB39F;
                case 0xB39D:
                    Cmp(A, 0x14); TotalCycles += 2; PC = 0xB39F;
                    goto case 0xB39F;
                case 0xB39F:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB3A6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB3A6; }
                    PC = 0xB3A1; goto case 0xB3A1;
                case 0xB3A0:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xB3A2;
                    goto case 0xB3A2;
                case 0xB3A1:
                    A = 0x18; SetZN(A); TotalCycles += 2; PC = 0xB3A3;
                    goto case 0xB3A3;
                case 0xB3A2:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB3A3;
                    goto case 0xB3A3;
                case 0xB3A3:
                    _ram[0x0709] = A; TotalCycles += 4; PC = 0xB3A6;
                    goto case 0xB3A6;
                case 0xB3A4:
                    A |= 0x07; SetZN(A); TotalCycles += 2; PC = 0xB3A6;
                    goto case 0xB3A6;
                case 0xB3A6:
                    A = _ram[0x0C]; SetZN(A); TotalCycles += 3; PC = 0xB3A8;
                    goto case 0xB3A8;
                case 0xB3A8:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB3AC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB3AC; }
                    PC = 0xB3AA; goto case 0xB3AA;
                case 0xB3AA:
                    _ram[0x33] = A; TotalCycles += 3; PC = 0xB3AC;
                    goto case 0xB3AC;
                case 0xB3AC:
                    A = _ram[0x0C]; SetZN(A); TotalCycles += 3; PC = 0xB3AE;
                    goto case 0xB3AE;
                case 0xB3AE:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB3B3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB3B3; }
                    PC = 0xB3B0; goto case 0xB3B0;
                case 0xB3B0:
                    TotalCycles += 6; PushU16(0xB3B2); PC = 0xB5CC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB5CC;
                case 0xB3B1:
                    Cmp(Y, ReadIoReg(0x20B5)); TotalCycles += 4; PC = 0xB3B4;
                    goto case 0xB3B4;
                case 0xB3B2:
                    A = _ram[(byte)(0x20 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB3B4;
                    goto case 0xB3B4;
                case 0xB3B3:
                    TotalCycles += 6; PushU16(0xB3B5); PC = 0xBF09;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF09;
                case 0xB3B4:
                    A |= 0xBF; SetZN(A); TotalCycles += 2; PC = 0xB3B6;
                    goto case 0xB3B6;
                case 0xB3B6:
                    _ram[0x06FF] = A; TotalCycles += 4; PC = 0xB3B9;
                    goto case 0xB3B9;
                case 0xB3B8:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0xB3BA;
                    goto case 0xB3BA;
                case 0xB3B9:
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0xB3BB;
                    goto case 0xB3BB;
                case 0xB3BA:
                    _ram[0x03C9] = Asl(_ram[0x03C9]); TotalCycles += 6; PC = 0xB3BD;
                    goto case 0xB3BD;
                case 0xB3BB:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0xB3BD;
                    goto case 0xB3BD;
                case 0xB3BD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB3C4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB3C4; }
                    PC = 0xB3BF; goto case 0xB3BF;
                case 0xB3BE:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xB3C0;
                    goto case 0xB3C0;
                case 0xB3BF:
                    A = 0x28; SetZN(A); TotalCycles += 2; PC = 0xB3C1;
                    goto case 0xB3C1;
                case 0xB3C0:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xB3C1;
                    goto case 0xB3C1;
                case 0xB3C1:
                    _ram[0x0709] = A; TotalCycles += 4; PC = 0xB3C4;
                    goto case 0xB3C4;
                case 0xB3C2:
                    A |= 0x07; SetZN(A); TotalCycles += 2; PC = 0xB3C4;
                    goto case 0xB3C4;
                case 0xB3C4:
                    TotalCycles += 3; PC = 0xBF4D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF4D;
                case 0xB3C5:
                    A ^= _ram[0x06BF]; SetZN(A); TotalCycles += 4; PC = 0xB3C8;
                    return;
                case 0xB3C7:
                    { int a = 0xFC04; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB3CA;
                    return;
                case 0xB3CB:
                    TotalCycles += 7; PushU16(0xB3CD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB3CC:
                    TotalCycles += 7; PushU16(0xB3CE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB3CF:
                    A = _ram[0x0416]; SetZN(A); TotalCycles += 4; PC = 0xB3D2;
                    goto case 0xB3D2;
                case 0xB3D0:
                    { byte z = (byte)(0x04 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB3D2;
                    goto case 0xB3D2;
                case 0xB3D2:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB3D3;
                    goto case 0xB3D3;
                case 0xB3D3:
                    Adc(_ram[0x0433]); TotalCycles += 4; PC = 0xB3D6;
                    goto case 0xB3D6;
                case 0xB3D6:
                    _ram[0x0416] = A; TotalCycles += 4; PC = 0xB3D9;
                    goto case 0xB3D9;
                case 0xB3D7:
                    { byte z = (byte)(0x04 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB3D9;
                    goto case 0xB3D9;
                case 0xB3D9:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB3DB;
                    goto case 0xB3DB;
                case 0xB3DA:
                    TotalCycles += 7; PushU16(0xB3DC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB3DB:
                    A = _ram[0x9F]; SetZN(A); TotalCycles += 3; PC = 0xB3DD;
                    goto case 0xB3DD;
                case 0xB3DD:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB3E0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB3E0; }
                    PC = 0xB3DF; goto case 0xB3DF;
                case 0xB3DE:
                    A |= ReadMem(ReadU16Zp((byte)(0x88 + X))); SetZN(A); TotalCycles += 6; PC = 0xB3E0;
                    goto case 0xB3E0;
                case 0xB3DF:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB3E0;
                    goto case 0xB3E0;
                case 0xB3E0:
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0xB3E2;
                    goto case 0xB3E2;
                case 0xB3E1:
                    TotalCycles += 7; PushU16(0xB3E3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB3E2:
                    Adc(_ram[0xCE]); TotalCycles += 3; PC = 0xB3E4;
                    goto case 0xB3E4;
                case 0xB3E3:
                    { int a = 0xCE85; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB3E6;
                    goto case 0xB3E6;
                case 0xB3E4:
                    _ram[0xCE] = A; TotalCycles += 3; PC = 0xB3E6;
                    goto case 0xB3E6;
                case 0xB3E5:
                    { int a = 0xB5A5; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB3E8;
                    goto case 0xB3E8;
                case 0xB3E6:
                    A = _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xB3E8;
                    goto case 0xB3E8;
                case 0xB3E7:
                    A = _ram[(byte)(0x65 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB3E9;
                    goto case 0xB3E9;
                case 0xB3E8:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0xB3EA;
                    goto case 0xB3EA;
                case 0xB3E9:
                    TotalCycles += 7; PushU16(0xB3EB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB3EA:
                    _ram[0xB5] = A; TotalCycles += 3; PC = 0xB3EC;
                    goto case 0xB3EC;
                case 0xB3EB:
                    A = _ram[(byte)(0xA5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB3ED;
                    return;
                case 0xB3EC: // === SUBROUTINE: PlayerEndLevel ===
                    A = _ram[0x0C]; SetZN(A); TotalCycles += 3; PC = 0xB3EE;
                    goto case 0xB3EE;
                case 0xB3EE:
                    A &= _ram[0x0490]; SetZN(A); TotalCycles += 4; PC = 0xB3F1;
                    goto case 0xB3F1;
                case 0xB3EF:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB3F5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB3F1; goto case 0xB3F1;
                case 0xB3F1:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB420; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB420; }
                    PC = 0xB3F3; goto case 0xB3F3;
                case 0xB3F2:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x09AC]; SetZN(A); TotalCycles += 4; PC = 0xB3F5;
                    return;
                case 0xB3F3:
                    Y = _ram[0x0789]; SetZN(Y); TotalCycles += 4; PC = 0xB3F6;
                    goto case 0xB3F6;
                case 0xB3F6:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB41F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB41F; }
                    PC = 0xB3F8; goto case 0xB3F8;
                case 0xB3F8:
                    Y = 0x18; SetZN(Y); TotalCycles += 2; PC = 0xB3FA;
                    goto case 0xB3FA;
                case 0xB3F9:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB3FA;
                    goto case 0xB3FA;
                case 0xB3FA:
                    _ram[0x0789] = Y; TotalCycles += 4; PC = 0xB3FD;
                    goto case 0xB3FD;
                case 0xB3FD:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xB3FF;
                    goto case 0xB3FF;
                case 0xB3FE:
                    TotalCycles += 7; PushU16(0xB400); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB3FF:
                    Y = _ram[0x33]; SetZN(Y); TotalCycles += 3; PC = 0xB401;
                    goto case 0xB401;
                case 0xB401:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB402;
                    goto case 0xB402;
                case 0xB402:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB406; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB406; }
                    PC = 0xB404; goto case 0xB404;
                case 0xB404:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xB405;
                    goto case 0xB405;
                case 0xB405:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xB406;
                    goto case 0xB406;
                case 0xB406:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB407;
                    goto case 0xB407;
                case 0xB407:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB40A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB40A; }
                    PC = 0xB409; goto case 0xB409;
                case 0xB408:
                    A |= ReadMem(ReadU16Zp((byte)(0xE8 + X))); SetZN(A); TotalCycles += 6; PC = 0xB40A;
                    goto case 0xB40A;
                case 0xB409:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xB40A;
                    goto case 0xB40A;
                case 0xB40A:
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xB40C;
                    goto case 0xB40C;
                case 0xB40B:
                    _ram[0x18] = X; TotalCycles += 3; PC = 0xB40D;
                    goto case 0xB40D;
                case 0xB40C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB40D;
                    goto case 0xB40D;
                case 0xB40D:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x33C7 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xB410;
                    goto case 0xB410;
                case 0xB410:
                    _ram[0x86] = A; TotalCycles += 3; PC = 0xB412;
                    goto case 0xB412;
                case 0xB411:
                    _ram[0xA5] = X; TotalCycles += 3; PC = 0xB413;
                    goto case 0xB413;
                case 0xB412:
                    A = _ram[0x6D]; SetZN(A); TotalCycles += 3; PC = 0xB414;
                    goto case 0xB414;
                case 0xB413:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x4B7D]); TotalCycles += 4; PC = 0xB416;
                    return;
                case 0xB414:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x33CB + X) & 0x7FFF]); TotalCycles += 4; PC = 0xB417;
                    goto case 0xB417;
                case 0xB417:
                    _ram[0x6D] = A; TotalCycles += 3; PC = 0xB419;
                    goto case 0xB419;
                case 0xB418:
                    Adc(_ram[0x04A5]); TotalCycles += 4; PC = 0xB41B;
                    goto case 0xB41B;
                case 0xB419:
                    A = _ram[0x0C]; SetZN(A); TotalCycles += 3; PC = 0xB41B;
                    goto case 0xB41B;
                case 0xB41B:
                    A ^= 0x03; SetZN(A); TotalCycles += 2; PC = 0xB41D;
                    goto case 0xB41D;
                case 0xB41D:
                    _ram[0x33] = A; TotalCycles += 3; PC = 0xB41F;
                    goto case 0xB41F;
                case 0xB41F:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB420:
                    _ram[0x0789] = A; TotalCycles += 4; PC = 0xB423;
                    goto case 0xB423;
                case 0xB423:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB424:
                    TotalCycles += 6; PushU16(0xB426); PC = 0x1E20;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB425:
                    TotalCycles += 6; PushU16(0xB427); PC = 0x281E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB426:
                    { int a = 0x2828 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xB429;
                    goto case 0xB429;
                case 0xB427:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xB428;
                    goto case 0xB428;
                case 0xB428:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xB429;
                    goto case 0xB429;
                case 0xB429:
                    A |= ReadIoReg(0x7004); SetZN(A); TotalCycles += 4; PC = 0xB42C;
                    goto case 0xB42C;
                case 0xB42B:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xB49D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB49D; }
                    PC = 0xB42D; goto case 0xB42D;
                case 0xB42C:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xB48E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB48E; }
                    PC = 0xB42E; goto case 0xB42E;
                case 0xB42D:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB42E:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB3C0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB3C0; }
                    PC = 0xB430; goto case 0xB430;
                case 0xB42F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB43B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB43B; }
                    PC = 0xB431; goto case 0xB431;
                case 0xB430:
                    A = Asl(A); TotalCycles += 2; PC = 0xB431;
                    goto case 0xB431;
                case 0xB431:
                    A |= 0xFC; SetZN(A); TotalCycles += 2; PC = 0xB433;
                    return;
                case 0xB437:
                    { int a = (0x00FF + X) & 0x07FF; _ram[a] = IncVal(_ram[a]); } TotalCycles += 7; PC = 0xB43A;
                    goto case 0xB43A;
                case 0xB439:
                    TotalCycles += 7; PushU16(0xB43B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB43A:
                    TotalCycles += 7; PushU16(0xB43C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB43B:
                    TotalCycles += 7; PushU16(0xB43D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB43C:
                    TotalCycles += 7; PushU16(0xB43E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB43D:
                    TotalCycles += 7; PushU16(0xB43F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB43F:
                    TotalCycles += 7; PushU16(0xB441); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB440: // === SUBROUTINE: PlayerMovementSubs ===
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xB441;
                    goto case 0xB441;
                case 0xB441:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xB442;
                    goto case 0xB442;
                case 0xB442:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB46C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB46C; }
                    PC = 0xB444; goto case 0xB444;
                case 0xB443:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xB444;
                    goto case 0xB444;
                case 0xB444:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB445;
                    goto case 0xB445;
                case 0xB445:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB453; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB447; goto case 0xB447;
                case 0xB447:
                    Cmp(X, _ram[0x98]); TotalCycles += 3; PC = 0xB449;
                    goto case 0xB449;
                case 0xB448:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB449;
                    goto case 0xB449;
                case 0xB449:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB44B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB44B; return;
                case 0xB44A:
                    TotalCycles += 7; PushU16(0xB44C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB44C:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0xB44E;
                    goto case 0xB44E;
                case 0xB44D:
                    TotalCycles += 7; PushU16(0xB44F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB44E:
                    TotalCycles += 6; PushU16(0xB450); PC = 0xA5FF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xA5FF;
                case 0xB450: // === SUBROUTINE: Sub_B450 ===
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xB452;
                    goto case 0xB452;
                case 0xB451:
                    A |= _ram[(0x03C9 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB454;
                    goto case 0xB454;
                case 0xB452:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xB454;
                    goto case 0xB454;
                case 0xB454:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB479; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB479; }
                    PC = 0xB456; goto case 0xB456;
                case 0xB456:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB458;
                    goto case 0xB458;
                case 0xB457:
                    TotalCycles += 7; PushU16(0xB459); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB458:
                    A = _ram[0x0B]; SetZN(A); TotalCycles += 3; PC = 0xB45A;
                    goto case 0xB45A;
                case 0xB45A:
                    A &= _ram[0x0490]; SetZN(A); TotalCycles += 4; PC = 0xB45D;
                    goto case 0xB45D;
                case 0xB45B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB461; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB461; }
                    PC = 0xB45D; goto case 0xB45D;
                case 0xB45D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB465; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB465; }
                    PC = 0xB45F; goto case 0xB45F;
                case 0xB45E:
                    _ram[0xC8] = Asl(_ram[0xC8]); TotalCycles += 5; PC = 0xB460;
                    goto case 0xB460;
                case 0xB45F:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB460;
                    goto case 0xB460;
                case 0xB460:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xB462;
                    goto case 0xB462;
                case 0xB461:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB462;
                    goto case 0xB462;
                case 0xB462:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB465; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB465; }
                    PC = 0xB464; goto case 0xB464;
                case 0xB463:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xB465;
                    goto case 0xB465;
                case 0xB464:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB465;
                    goto case 0xB465;
                case 0xB465:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x344D + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xB468;
                    goto case 0xB468;
                case 0xB466:
                    A ^= SmbEmbeddedAssets.StaticDataTables[0x0EB4]; SetZN(A); TotalCycles += 4; PC = 0xB469;
                    return;
                case 0xB467:
                    Y = _ram[(byte)(0x8E + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB469;
                    return;
                case 0xB468:
                    _ram[0x0433] = X; TotalCycles += 4; PC = 0xB46B;
                    goto case 0xB46B;
                case 0xB46B:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xB46D;
                    goto case 0xB46D;
                case 0xB46C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB46D;
                    goto case 0xB46D;
                case 0xB46D:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x344A + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xB470;
                    goto case 0xB470;
                case 0xB46E:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB46F;
                    goto case 0xB46F;
                case 0xB46F:
                    Y = _ram[(byte)(0x86 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB471;
                    return;
                case 0xB470:
                    _ram[0x9F] = X; TotalCycles += 3; PC = 0xB472;
                    goto case 0xB472;
                case 0xB472:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB475; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB475; }
                    PC = 0xB474; goto case 0xB474;
                case 0xB473:
                    A |= ReadMem(ReadU16Zp((byte)(0x4A + X))); SetZN(A); TotalCycles += 6; PC = 0xB475;
                    goto case 0xB475;
                case 0xB474:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB475;
                    goto case 0xB475;
                case 0xB475:
                    _ram[0x070C] = A; TotalCycles += 4; PC = 0xB478;
                    goto case 0xB478;
                case 0xB478:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB479:
                    A = _ram[0x070E]; SetZN(A); TotalCycles += 4; PC = 0xB47C;
                    goto case 0xB47C;
                case 0xB47A:
                    { int a = 0xD007; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB47D;
                    goto case 0xB47D;
                case 0xB47C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB488; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB488; }
                    PC = 0xB47E; goto case 0xB47E;
                case 0xB47D:
                    A = Asl(A); TotalCycles += 2; PC = 0xB47E;
                    goto case 0xB47E;
                case 0xB47E:
                    A = _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0xB480;
                    goto case 0xB480;
                case 0xB47F:
                    A = Asl(A); TotalCycles += 2; PC = 0xB480;
                    goto case 0xB480;
                case 0xB480:
                    A &= 0x80; SetZN(A); TotalCycles += 2; PC = 0xB482;
                    goto case 0xB482;
                case 0xB482:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB488; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB488; }
                    PC = 0xB484; goto case 0xB484;
                case 0xB484:
                    A &= _ram[0x0D]; SetZN(A); TotalCycles += 3; PC = 0xB486;
                    goto case 0xB486;
                case 0xB485:
                    A |= _ram[0x03F0]; SetZN(A); TotalCycles += 4; PC = 0xB488;
                    goto case 0xB488;
                case 0xB486:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB48B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB48B; }
                    PC = 0xB488; goto case 0xB488;
                case 0xB488:
                    TotalCycles += 3; PC = 0xB51C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB51C;
                case 0xB48A:
                    A = _ram[(byte)(0xA5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB48C;
                    goto case 0xB48C;
                case 0xB48B:
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xB48D;
                    goto case 0xB48D;
                case 0xB48C:
                    A |= ReadMem(0x11F0 + X); SetZN(A); TotalCycles += 4; PC = 0xB48F;
                    goto case 0xB48F;
                case 0xB48D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB4A0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB4A0; }
                    PC = 0xB48F; goto case 0xB48F;
                case 0xB48E:
                    A |= ReadMem(ReadU16Zp(0xAD) + Y); SetZN(A); TotalCycles += 5; PC = 0xB490;
                    return;
                case 0xB48F:
                    A = _ram[0x0704]; SetZN(A); TotalCycles += 4; PC = 0xB492;
                    goto case 0xB492;
                case 0xB492:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB488; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB488; }
                    PC = 0xB494; goto case 0xB494;
                case 0xB494:
                    A = _ram[0x0782]; SetZN(A); TotalCycles += 4; PC = 0xB497;
                    goto case 0xB497;
                case 0xB497:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB4A0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB4A0; }
                    PC = 0xB499; goto case 0xB499;
                case 0xB499:
                    A = _ram[0x9F]; SetZN(A); TotalCycles += 3; PC = 0xB49B;
                    goto case 0xB49B;
                case 0xB49B:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB4A0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB4A0; }
                    PC = 0xB49D; goto case 0xB49D;
                case 0xB49D:
                    TotalCycles += 3; PC = 0xB51C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB51C;
                case 0xB49F:
                    A = _ram[(byte)(0xA9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB4A1;
                    goto case 0xB4A1;
                case 0xB4A0:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0xB4A2;
                    goto case 0xB4A2;
                case 0xB4A1:
                    TotalCycles += 6; PushU16(0xB4A3); PC = 0x828D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB4A2:
                    _ram[0x0782] = A; TotalCycles += 4; PC = 0xB4A5;
                    goto case 0xB4A5;
                case 0xB4A5:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB4A7;
                    goto case 0xB4A7;
                case 0xB4A6:
                    TotalCycles += 7; PushU16(0xB4A8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB4A7:
                    _ram[0x0416] = Y; TotalCycles += 4; PC = 0xB4AA;
                    goto case 0xB4AA;
                case 0xB4A8:
                    { byte z = (byte)(0x04 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB4AA;
                    goto case 0xB4AA;
                case 0xB4AA:
                    _ram[0x0433] = Y; TotalCycles += 4; PC = 0xB4AD;
                    goto case 0xB4AD;
                case 0xB4AD:
                    A = _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xB4AF;
                    goto case 0xB4AF;
                case 0xB4AE:
                    A = _ram[(byte)(0x8D + X)]; SetZN(A); TotalCycles += 4; PC = 0xB4B0;
                    return;
                case 0xB4AF:
                    _ram[0x0707] = A; TotalCycles += 4; PC = 0xB4B2;
                    goto case 0xB4B2;
                case 0xB4B2:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB4B4;
                    goto case 0xB4B4;
                case 0xB4B3:
                    _ram[0x008D] = DecVal(_ram[0x008D]); TotalCycles += 6; PC = 0xB4B6;
                    return;
                case 0xB4B4:
                    _ram[0x0708] = A; TotalCycles += 4; PC = 0xB4B7;
                    goto case 0xB4B7;
                case 0xB4B5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB4B6;
                    return;
                case 0xB4B7:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB4B9;
                    goto case 0xB4B9;
                case 0xB4B8:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xB4BA;
                    goto case 0xB4BA;
                case 0xB4B9:
                    _ram[0x1D] = A; TotalCycles += 3; PC = 0xB4BB;
                    goto case 0xB4BB;
                case 0xB4BA:
                    A |= _ram[(0x00AD + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB4BD;
                    return;
                case 0xB4BB:
                    A = _ram[0x0700]; SetZN(A); TotalCycles += 4; PC = 0xB4BE;
                    goto case 0xB4BE;
                case 0xB4BC:
                    TotalCycles += 7; PushU16(0xB4BE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB4BE:
                    Cmp(A, 0x09); TotalCycles += 2; PC = 0xB4C0;
                    goto case 0xB4C0;
                case 0xB4BF:
                    A |= 0x90; SetZN(A); TotalCycles += 2; PC = 0xB4C1;
                    goto case 0xB4C1;
                case 0xB4C0:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB4D2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB4D2; }
                    PC = 0xB4C2; goto case 0xB4C2;
                case 0xB4C1:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB48B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB48B; }
                    PC = 0xB4C3; goto case 0xB4C3;
                case 0xB4C2:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB4C3;
                    goto case 0xB4C3;
                case 0xB4C3:
                    Cmp(A, 0x10); TotalCycles += 2; PC = 0xB4C5;
                    goto case 0xB4C5;
                case 0xB4C4:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB456; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB456; }
                    PC = 0xB4C6; return;
                case 0xB4C5:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB4D2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB4D2; }
                    PC = 0xB4C7; goto case 0xB4C7;
                case 0xB4C7:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB4C8;
                    goto case 0xB4C8;
                case 0xB4C8:
                    Cmp(A, 0x19); TotalCycles += 2; PC = 0xB4CA;
                    goto case 0xB4CA;
                case 0xB4C9:
                    A |= _ram[(0x0690 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB4CC;
                    goto case 0xB4CC;
                case 0xB4CA:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB4D2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB4D2; }
                    PC = 0xB4CC; goto case 0xB4CC;
                case 0xB4CB:
                    _ram[0xC8] = Asl(_ram[0xC8]); TotalCycles += 5; PC = 0xB4CD;
                    goto case 0xB4CD;
                case 0xB4CC:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB4CD;
                    goto case 0xB4CD;
                case 0xB4CD:
                    Cmp(A, 0x1C); TotalCycles += 2; PC = 0xB4CF;
                    goto case 0xB4CF;
                case 0xB4CF:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB4D2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB4D2; }
                    PC = 0xB4D1; goto case 0xB4D1;
                case 0xB4D0:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xB4D2;
                    goto case 0xB4D2;
                case 0xB4D1:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB4D2;
                    goto case 0xB4D2;
                case 0xB4D2:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB4D4;
                    goto case 0xB4D4;
                case 0xB4D3:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0xB4D5;
                    goto case 0xB4D5;
                case 0xB4D4:
                    _ram[0x0706] = A; TotalCycles += 4; PC = 0xB4D7;
                    goto case 0xB4D7;
                case 0xB4D5:
                    _ram[0x07] = Asl(_ram[0x07]); TotalCycles += 5; PC = 0xB4D7;
                    goto case 0xB4D7;
                case 0xB4D7:
                    A = _ram[0x0704]; SetZN(A); TotalCycles += 4; PC = 0xB4DA;
                    goto case 0xB4DA;
                case 0xB4DA:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB4E4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB4E4; }
                    PC = 0xB4DC; goto case 0xB4DC;
                case 0xB4DB:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB4DC;
                    goto case 0xB4DC;
                case 0xB4DC:
                    Y = 0x05; SetZN(Y); TotalCycles += 2; PC = 0xB4DE;
                    goto case 0xB4DE;
                case 0xB4DD:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0xB4DF;
                    goto case 0xB4DF;
                case 0xB4DE:
                    A = _ram[0x047D]; SetZN(A); TotalCycles += 4; PC = 0xB4E1;
                    goto case 0xB4E1;
                case 0xB4DF:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x7004 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xB4E2;
                    goto case 0xB4E2;
                case 0xB4E1:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB4E4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB4E4; }
                    PC = 0xB4E3; goto case 0xB4E3;
                case 0xB4E2:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xB4E4;
                    goto case 0xB4E4;
                case 0xB4E3:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB4E4;
                    goto case 0xB4E4;
                case 0xB4E4:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3424 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB4E7;
                    goto case 0xB4E7;
                case 0xB4E5:
                    Bit(_ram[0xB4]); TotalCycles += 3; PC = 0xB4E7;
                    goto case 0xB4E7;
                case 0xB4E6:
                    Y = _ram[(byte)(0x8D + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB4E8;
                    goto case 0xB4E8;
                case 0xB4E7:
                    _ram[0x0709] = A; TotalCycles += 4; PC = 0xB4EA;
                    goto case 0xB4EA;
                case 0xB4E8:
                    A |= 0x07; SetZN(A); TotalCycles += 2; PC = 0xB4EA;
                    goto case 0xB4EA;
                case 0xB4EA:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x342B + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB4ED;
                    goto case 0xB4ED;
                case 0xB4EC:
                    Y = _ram[(byte)(0x8D + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB4EE;
                    goto case 0xB4EE;
                case 0xB4ED:
                    _ram[0x070A] = A; TotalCycles += 4; PC = 0xB4F0;
                    goto case 0xB4F0;
                case 0xB4EE:
                    A = Asl(A); TotalCycles += 2; PC = 0xB4EF;
                    return;
                case 0xB4F0:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3439 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB4F3;
                    goto case 0xB4F3;
                case 0xB4F1:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x0DB4 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB4F4;
                    return;
                case 0xB4F2:
                    Y = _ram[(byte)(0x8D + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB4F4;
                    return;
                case 0xB4F3:
                    _ram[0x0433] = A; TotalCycles += 4; PC = 0xB4F6;
                    goto case 0xB4F6;
                case 0xB4F6:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3432 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB4F9;
                    goto case 0xB4F9;
                case 0xB4F8:
                    Y = _ram[(byte)(0x85 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB4FA;
                    return;
                case 0xB4F9:
                    _ram[0x9F] = A; TotalCycles += 3; PC = 0xB4FB;
                    goto case 0xB4FB;
                case 0xB4FB:
                    A = _ram[0x0704]; SetZN(A); TotalCycles += 4; PC = 0xB4FE;
                    goto case 0xB4FE;
                case 0xB4FE:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB511; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB511; }
                    PC = 0xB500; goto case 0xB500;
                case 0xB4FF:
                    A |= ReadMem(ReadU16Zp(0xA9) + Y); SetZN(A); TotalCycles += 5; PC = 0xB501;
                    return;
                case 0xB500:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xB502;
                    goto case 0xB502;
                case 0xB502:
                    _ram[0xFF] = A; TotalCycles += 3; PC = 0xB504;
                    goto case 0xB504;
                case 0xB504:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB506;
                    goto case 0xB506;
                case 0xB505: // === SUBROUTINE: MovePlayerHorizontally ===
                    _ram[0x04C9] = DecVal(_ram[0x04C9]); TotalCycles += 6; PC = 0xB508;
                    goto case 0xB508;
                case 0xB506:
                    Cmp(A, 0x14); TotalCycles += 2; PC = 0xB508;
                    goto case 0xB508;
                case 0xB508:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB51C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB51C; }
                    PC = 0xB50A; goto case 0xB50A;
                case 0xB50A:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB50C;
                    goto case 0xB50C;
                case 0xB50B:
                    TotalCycles += 7; PushU16(0xB50D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB50C:
                    _ram[0x9F] = A; TotalCycles += 3; PC = 0xB50E;
                    goto case 0xB50E;
                case 0xB50E:
                    TotalCycles += 3; PC = 0xB51C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB51C;
                case 0xB510:
                    A = _ram[(byte)(0xA9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB512;
                    goto case 0xB512;
                case 0xB511:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB513;
                    goto case 0xB513;
                case 0xB512:
                    A |= ReadMem(ReadU16Zp((byte)(0xAC + X))); SetZN(A); TotalCycles += 6; PC = 0xB514;
                    return;
                case 0xB513:
                    Y = _ram[0x0754]; SetZN(Y); TotalCycles += 4; PC = 0xB516;
                    goto case 0xB516;
                case 0xB516:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB51A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB51A; }
                    PC = 0xB518; goto case 0xB518;
                case 0xB518:
                    A = 0x80; SetZN(A); TotalCycles += 2; PC = 0xB51A;
                    goto case 0xB51A;
                case 0xB51A:
                    _ram[0xFF] = A; TotalCycles += 3; PC = 0xB51C;
                    goto case 0xB51C;
                case 0xB51C:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB51E;
                    goto case 0xB51E;
                case 0xB51D:
                    TotalCycles += 7; PushU16(0xB51F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB51E:
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0xB520;
                    goto case 0xB520;
                case 0xB51F:
                    TotalCycles += 7; PushU16(0xB521); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB520:
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xB522;
                    goto case 0xB522;
                case 0xB521:
                    A |= ReadMem(0x09F0 + X); SetZN(A); TotalCycles += 4; PC = 0xB524;
                    goto case 0xB524;
                case 0xB522:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB52D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB52D; }
                    PC = 0xB524; goto case 0xB524;
                case 0xB523:
                    A |= 0xAD; SetZN(A); TotalCycles += 2; PC = 0xB525;
                    goto case 0xB525;
                case 0xB524:
                    A = _ram[0x0700]; SetZN(A); TotalCycles += 4; PC = 0xB527;
                    goto case 0xB527;
                case 0xB525: // === SUBROUTINE: MovePlayerVertically ===
                    TotalCycles += 7; PushU16(0xB527); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB527:
                    Cmp(A, 0x19); TotalCycles += 2; PC = 0xB529;
                    goto case 0xB529;
                case 0xB528:
                    A |= ReadMem(0x33B0 + Y); SetZN(A); TotalCycles += 4; PC = 0xB52B;
                    goto case 0xB52B;
                case 0xB529:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB55E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB55E; }
                    PC = 0xB52B; goto case 0xB52B;
                case 0xB52B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB545; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB545; }
                    PC = 0xB52D; goto case 0xB52D;
                case 0xB52C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB52D;
                    goto case 0xB52D;
                case 0xB52D:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB52E;
                    goto case 0xB52E;
                case 0xB52E:
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0xB531;
                    goto case 0xB531;
                case 0xB52F:
                    { int a = 0xF007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xB532;
                    return;
                case 0xB531:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB545; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB545; }
                    PC = 0xB533; goto case 0xB533;
                case 0xB533:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB534;
                    goto case 0xB534;
                case 0xB534:
                    A = _ram[0x0C]; SetZN(A); TotalCycles += 3; PC = 0xB536;
                    goto case 0xB536;
                case 0xB536:
                    Cmp(A, _ram[0x45]); TotalCycles += 3; PC = 0xB538;
                    goto case 0xB538;
                case 0xB537:
                    A ^= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xB539;
                    return;
                case 0xB538:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB545; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB545; }
                    PC = 0xB53A; goto case 0xB53A;
                case 0xB53A:
                    A = _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0xB53C;
                    goto case 0xB53C;
                case 0xB53B:
                    A = Asl(A); TotalCycles += 2; PC = 0xB53C;
                    goto case 0xB53C;
                case 0xB53C:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0xB53E;
                    goto case 0xB53E;
                case 0xB53D:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xB53E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB559; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB559; }
                    PC = 0xB540; goto case 0xB540;
                case 0xB53F:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x03AD + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB542;
                    return;
                case 0xB540:
                    A = _ram[0x0783]; SetZN(A); TotalCycles += 4; PC = 0xB543;
                    goto case 0xB543;
                case 0xB543:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB55E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB55E; }
                    PC = 0xB545; goto case 0xB545;
                case 0xB544:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x66C8 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB547;
                    goto case 0xB547;
                case 0xB545:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB546;
                    goto case 0xB546;
                case 0xB546:
                    _ram[0x00] = IncVal(_ram[0x00]); TotalCycles += 5; PC = 0xB548;
                    goto case 0xB548;
                case 0xB547:
                    TotalCycles += 7; PushU16(0xB549); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB548:
                    A = _ram[0x0703]; SetZN(A); TotalCycles += 4; PC = 0xB54B;
                    goto case 0xB54B;
                case 0xB54B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB554; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB554; }
                    PC = 0xB54D; goto case 0xB54D;
                case 0xB54D:
                    A = _ram[0x0700]; SetZN(A); TotalCycles += 4; PC = 0xB550;
                    goto case 0xB550;
                case 0xB54E:
                    TotalCycles += 7; PushU16(0xB550); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB550:
                    Cmp(A, 0x21); TotalCycles += 2; PC = 0xB552;
                    goto case 0xB552;
                case 0xB551:
                    A &= ReadMem(ReadU16Zp((byte)(0x90 + X))); SetZN(A); TotalCycles += 6; PC = 0xB553;
                    goto case 0xB553;
                case 0xB552:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB55E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB55E; }
                    PC = 0xB554; goto case 0xB554;
                case 0xB553:
                    A = Asl(A); TotalCycles += 2; PC = 0xB554;
                    goto case 0xB554;
                case 0xB554:
                    _ram[0x00] = IncVal(_ram[0x00]); TotalCycles += 5; PC = 0xB556;
                    goto case 0xB556;
                case 0xB555:
                    TotalCycles += 7; PushU16(0xB557); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB556:
                    TotalCycles += 3; PC = 0xB55E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB55E;
                case 0xB557:
                    { int a = 0xA9B5 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xB55A;
                    goto case 0xB55A;
                case 0xB558:
                    A = _ram[(byte)(0xA9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB55A;
                    goto case 0xB55A;
                case 0xB559:
                    A = 0x0A; SetZN(A); TotalCycles += 2; PC = 0xB55B;
                    goto case 0xB55B;
                case 0xB55A:
                    A = Asl(A); TotalCycles += 2; PC = 0xB55B;
                    goto case 0xB55B;
                case 0xB55B:
                    _ram[0x0783] = A; TotalCycles += 4; PC = 0xB55E;
                    goto case 0xB55E;
                case 0xB55E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3440 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB561;
                    goto case 0xB561;
                case 0xB55F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xB560:
                    Y = _ram[(byte)(0x8D + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB562;
                    goto case 0xB562;
                case 0xB561:
                    _ram[0x0450] = A; TotalCycles += 4; PC = 0xB564;
                    goto case 0xB564;
                case 0xB562:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB568; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB568; }
                    PC = 0xB564; goto case 0xB564;
                case 0xB564:
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0xB566;
                    goto case 0xB566;
                case 0xB565:
                    _ram[0x07C9] = Asl(_ram[0x07C9]); TotalCycles += 6; PC = 0xB568;
                    goto case 0xB568;
                case 0xB566:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0xB568;
                    goto case 0xB568;
                case 0xB568:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB56C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB56C; }
                    PC = 0xB56A; goto case 0xB56A;
                case 0xB56A:
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0xB56C;
                    goto case 0xB56C;
                case 0xB56C:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3443 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB56F;
                    goto case 0xB56F;
                case 0xB56E:
                    Y = _ram[(byte)(0x8D + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB570;
                    goto case 0xB570;
                case 0xB56F:
                    _ram[0x0456] = A; TotalCycles += 4; PC = 0xB572;
                    goto case 0xB572;
                case 0xB570:
                    { byte z = (byte)(0x04 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xB572;
                    goto case 0xB572;
                case 0xB572:
                    Y = _ram[0x00]; SetZN(Y); TotalCycles += 3; PC = 0xB574;
                    goto case 0xB574;
                case 0xB573:
                    TotalCycles += 7; PushU16(0xB575); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB574:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3447 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB577;
                    goto case 0xB577;
                case 0xB576:
                    Y = _ram[(byte)(0x8D + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB578;
                    return;
                case 0xB577:
                    _ram[0x0702] = A; TotalCycles += 4; PC = 0xB57A;
                    goto case 0xB57A;
                case 0xB57A:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB57C;
                    goto case 0xB57C;
                case 0xB57B:
                    TotalCycles += 7; PushU16(0xB57D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB57C:
                    _ram[0x0701] = A; TotalCycles += 4; PC = 0xB57F;
                    goto case 0xB57F;
                case 0xB57D:
                    A |= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0xB57F;
                    goto case 0xB57F;
                case 0xB57F:
                    A = _ram[0x33]; SetZN(A); TotalCycles += 3; PC = 0xB581;
                    goto case 0xB581;
                case 0xB581:
                    Cmp(A, _ram[0x45]); TotalCycles += 3; PC = 0xB583;
                    goto case 0xB583;
                case 0xB582:
                    A ^= _ram[0xF0]; SetZN(A); TotalCycles += 3; PC = 0xB584;
                    goto case 0xB584;
                case 0xB583:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB58B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB58B; }
                    PC = 0xB585; goto case 0xB585;
                case 0xB584:
                    _ram[0x0E] = Asl(_ram[0x0E]); TotalCycles += 5; PC = 0xB586;
                    return;
                case 0xB585:
                    _ram[0x0702] = Asl(_ram[0x0702]); TotalCycles += 6; PC = 0xB588;
                    goto case 0xB588;
                case 0xB588:
                    _ram[0x0701] = Rol(_ram[0x0701]); TotalCycles += 6; PC = 0xB58B;
                    goto case 0xB58B;
                case 0xB589:
                    A |= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0xB58B;
                    goto case 0xB58B;
                case 0xB58B:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB58F: // === SUBROUTINE: Sub_B58F ===
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB591;
                    goto case 0xB591;
                case 0xB590:
                    TotalCycles += 7; PushU16(0xB592); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB591:
                    A = _ram[0x0700]; SetZN(A); TotalCycles += 4; PC = 0xB594;
                    goto case 0xB594;
                case 0xB592:
                    TotalCycles += 7; PushU16(0xB594); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB594:
                    Cmp(A, 0x1C); TotalCycles += 2; PC = 0xB596;
                    goto case 0xB596;
                case 0xB596:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB5AD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB5AD; }
                    PC = 0xB598; goto case 0xB598;
                case 0xB597:
                    A |= _ram[(byte)(0xC8 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB599;
                    goto case 0xB599;
                case 0xB598:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB599;
                    goto case 0xB599;
                case 0xB599:
                    Cmp(A, 0x0E); TotalCycles += 2; PC = 0xB59B;
                    goto case 0xB59B;
                case 0xB59A:
                    _ram[0x01B0] = Asl(_ram[0x01B0]); TotalCycles += 6; PC = 0xB59D;
                    goto case 0xB59D;
                case 0xB59B:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB59E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB59E; }
                    PC = 0xB59D; goto case 0xB59D;
                case 0xB59C:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xB59E;
                    goto case 0xB59E;
                case 0xB59D:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB59E;
                    goto case 0xB59E;
                case 0xB59E:
                    A = _ram[0x06FC]; SetZN(A); TotalCycles += 4; PC = 0xB5A1;
                    goto case 0xB5A1;
                case 0xB5A0:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0xB5A2;
                    return;
                case 0xB5A1:
                    A &= 0x7F; SetZN(A); TotalCycles += 2; PC = 0xB5A3;
                    goto case 0xB5A3;
                case 0xB5A3:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB5C5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB5C5; }
                    PC = 0xB5A5; goto case 0xB5A5;
                case 0xB5A4:
                    TotalCycles += 6; PushU16(0xB5A6); PC = 0x0329;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB5A5:
                    A &= 0x03; SetZN(A); TotalCycles += 2; PC = 0xB5A7;
                    goto case 0xB5A7;
                case 0xB5A7:
                    Cmp(A, _ram[0x45]); TotalCycles += 3; PC = 0xB5A9;
                    goto case 0xB5A9;
                case 0xB5A8:
                    A ^= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xB5AA;
                    goto case 0xB5AA;
                case 0xB5A9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB5B3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB5B3; }
                    PC = 0xB5AB; goto case 0xB5AB;
                case 0xB5AA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB5AB;
                    goto case 0xB5AB;
                case 0xB5AB:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB5AD;
                    goto case 0xB5AD;
                case 0xB5AC:
                    TotalCycles += 7; PushU16(0xB5AE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB5AD:
                    _ram[0x0703] = A; TotalCycles += 4; PC = 0xB5B0;
                    goto case 0xB5B0;
                case 0xB5B0:
                    TotalCycles += 3; PC = 0xB5C5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB5C5;
                case 0xB5B1:
                    Cmp(A, _ram[0xB5]); TotalCycles += 3; PC = 0xB5B3;
                    goto case 0xB5B3;
                case 0xB5B2:
                    A = _ram[(byte)(0xAD + X)]; SetZN(A); TotalCycles += 4; PC = 0xB5B4;
                    goto case 0xB5B4;
                case 0xB5B3:
                    A = _ram[0x0700]; SetZN(A); TotalCycles += 4; PC = 0xB5B6;
                    goto case 0xB5B6;
                case 0xB5B4:
                    TotalCycles += 7; PushU16(0xB5B6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB5B6:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0xB5B8;
                    goto case 0xB5B8;
                case 0xB5B8:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB5C5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB5C5; }
                    PC = 0xB5BA; goto case 0xB5BA;
                case 0xB5BA:
                    A = _ram[0x33]; SetZN(A); TotalCycles += 3; PC = 0xB5BC;
                    goto case 0xB5BC;
                case 0xB5BC:
                    _ram[0x45] = A; TotalCycles += 3; PC = 0xB5BE;
                    goto case 0xB5BE;
                case 0xB5BD:
                    A ^= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xB5BF;
                    goto case 0xB5BF;
                case 0xB5BE:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB5C0;
                    goto case 0xB5C0;
                case 0xB5BF:
                    TotalCycles += 7; PushU16(0xB5C1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB5C0:
                    _ram[0x57] = A; TotalCycles += 3; PC = 0xB5C2;
                    goto case 0xB5C2;
                case 0xB5C2:
                    _ram[0x0705] = A; TotalCycles += 4; PC = 0xB5C5;
                    goto case 0xB5C5;
                case 0xB5C3:
                    A |= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0xB5C5;
                    goto case 0xB5C5;
                case 0xB5C5:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x358C + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB5C8;
                    goto case 0xB5C8;
                case 0xB5C6:
                    WriteIoReg(0x8DB5, Y); TotalCycles += 4; PC = 0xB5C9;
                    return;
                case 0xB5C7:
                    A = _ram[(byte)(0x8D + X)]; SetZN(A); TotalCycles += 4; PC = 0xB5C9;
                    return;
                case 0xB5C8:
                    _ram[0x070C] = A; TotalCycles += 4; PC = 0xB5CB;
                    goto case 0xB5CB;
                case 0xB5CB:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB5CC: // === SUBROUTINE: Sub_B5CC ===
                    A &= _ram[0x0490]; SetZN(A); TotalCycles += 4; PC = 0xB5CF;
                    goto case 0xB5CF;
                case 0xB5CD:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB5D3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB5D3; }
                    PC = 0xB5CF; goto case 0xB5CF;
                case 0xB5CF:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xB5D1;
                    goto case 0xB5D1;
                case 0xB5D0:
                    TotalCycles += 7; PushU16(0xB5D2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB5D1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB5DB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB5DB; }
                    PC = 0xB5D3; goto case 0xB5D3;
                case 0xB5D2:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB5D3;
                    goto case 0xB5D3;
                case 0xB5D3:
                    A = _ram[0x57]; SetZN(A); TotalCycles += 3; PC = 0xB5D5;
                    goto case 0xB5D5;
                case 0xB5D5:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB620; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB620; }
                    PC = 0xB5D7; goto case 0xB5D7;
                case 0xB5D6:
                    A ^= 0x10; SetZN(A); TotalCycles += 2; PC = 0xB5D8;
                    return;
                case 0xB5D7:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB5FC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB5FC; }
                    PC = 0xB5D9; goto case 0xB5D9;
                case 0xB5D9:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB5DE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB5DE; }
                    PC = 0xB5DB; goto case 0xB5DB;
                case 0xB5DB:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB5DC;
                    goto case 0xB5DC;
                case 0xB5DC:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB5FC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB5FC; }
                    PC = 0xB5DE; goto case 0xB5DE;
                case 0xB5DD:
                    { int a = (0x05AD + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xB5E0;
                    return;
                case 0xB5DE:
                    A = _ram[0x0705]; SetZN(A); TotalCycles += 4; PC = 0xB5E1;
                    goto case 0xB5E1;
                case 0xB5DF:
                    A |= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0xB5E1;
                    goto case 0xB5E1;
                case 0xB5E1:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB5E2;
                    goto case 0xB5E2;
                case 0xB5E2:
                    Adc(_ram[0x0702]); TotalCycles += 4; PC = 0xB5E5;
                    goto case 0xB5E5;
                case 0xB5E5:
                    _ram[0x0705] = A; TotalCycles += 4; PC = 0xB5E8;
                    goto case 0xB5E8;
                case 0xB5E6:
                    A |= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0xB5E8;
                    goto case 0xB5E8;
                case 0xB5E8:
                    A = _ram[0x57]; SetZN(A); TotalCycles += 3; PC = 0xB5EA;
                    goto case 0xB5EA;
                case 0xB5EA:
                    Adc(_ram[0x0701]); TotalCycles += 4; PC = 0xB5ED;
                    goto case 0xB5ED;
                case 0xB5EB:
                    A |= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0xB5ED;
                    goto case 0xB5ED;
                case 0xB5ED:
                    _ram[0x57] = A; TotalCycles += 3; PC = 0xB5EF;
                    goto case 0xB5EF;
                case 0xB5EF:
                    Cmp(A, _ram[0x0456]); TotalCycles += 4; PC = 0xB5F2;
                    goto case 0xB5F2;
                case 0xB5F0:
                    { byte z = (byte)(0x04 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xB5F2;
                    goto case 0xB5F2;
                case 0xB5F2:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB617; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB617; }
                    PC = 0xB5F4; goto case 0xB5F4;
                case 0xB5F4:
                    A = _ram[0x0456]; SetZN(A); TotalCycles += 4; PC = 0xB5F7;
                    goto case 0xB5F7;
                case 0xB5F5:
                    { byte z = (byte)(0x04 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xB5F7;
                    goto case 0xB5F7;
                case 0xB5F7:
                    _ram[0x57] = A; TotalCycles += 3; PC = 0xB5F9;
                    goto case 0xB5F9;
                case 0xB5F9:
                    TotalCycles += 3; PC = 0xB620;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB620;
                case 0xB5FA:
                    TotalCycles += 6; PushU16(0xB5FC); PC = 0xADB6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xADB6;
                case 0xB5FB:
                    X = _ram[(byte)(0xAD + Y)]; SetZN(X); TotalCycles += 4; PC = 0xB5FD;
                    goto case 0xB5FD;
                case 0xB5FC:
                    A = _ram[0x0705]; SetZN(A); TotalCycles += 4; PC = 0xB5FF;
                    goto case 0xB5FF;
                case 0xB5FD:
                    A |= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0xB5FF;
                    goto case 0xB5FF;
                case 0xB5FF:
                    P |= FlagC; TotalCycles += 2; PC = 0xB600;
                    goto case 0xB600;
                case 0xB600:
                    Sbc(_ram[0x0702]); TotalCycles += 4; PC = 0xB603;
                    goto case 0xB603;
                case 0xB603:
                    _ram[0x0705] = A; TotalCycles += 4; PC = 0xB606;
                    goto case 0xB606;
                case 0xB604:
                    A |= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0xB606;
                    goto case 0xB606;
                case 0xB606:
                    A = _ram[0x57]; SetZN(A); TotalCycles += 3; PC = 0xB608;
                    goto case 0xB608;
                case 0xB608:
                    Sbc(_ram[0x0701]); TotalCycles += 4; PC = 0xB60B;
                    goto case 0xB60B;
                case 0xB609:
                    A |= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0xB60B;
                    goto case 0xB60B;
                case 0xB60B:
                    _ram[0x57] = A; TotalCycles += 3; PC = 0xB60D;
                    goto case 0xB60D;
                case 0xB60D:
                    Cmp(A, _ram[0x0450]); TotalCycles += 4; PC = 0xB610;
                    goto case 0xB610;
                case 0xB60E:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB614; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB610; goto case 0xB610;
                case 0xB610:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB617; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB617; }
                    PC = 0xB612; goto case 0xB612;
                case 0xB611:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0xB613;
                    goto case 0xB613;
                case 0xB612:
                    A = _ram[0x0450]; SetZN(A); TotalCycles += 4; PC = 0xB615;
                    goto case 0xB615;
                case 0xB613:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB619; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB619; }
                    PC = 0xB615; goto case 0xB615;
                case 0xB615:
                    _ram[0x57] = A; TotalCycles += 3; PC = 0xB617;
                    goto case 0xB617;
                case 0xB617:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xB619;
                    goto case 0xB619;
                case 0xB618:
                    TotalCycles += 7; PushU16(0xB61A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB619:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB620; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB620; }
                    PC = 0xB61B; goto case 0xB61B;
                case 0xB61A:
                    A |= _ram[0x49]; SetZN(A); TotalCycles += 3; PC = 0xB61C;
                    return;
                case 0xB61B:
                    A ^= 0xFF; SetZN(A); TotalCycles += 2; PC = 0xB61D;
                    goto case 0xB61D;
                case 0xB61D:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB61E;
                    goto case 0xB61E;
                case 0xB61E:
                    Adc(0x01); TotalCycles += 2; PC = 0xB620;
                    goto case 0xB620;
                case 0xB61F:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0xB621;
                    goto case 0xB621;
                case 0xB620:
                    _ram[0x0700] = A; TotalCycles += 4; PC = 0xB623;
                    goto case 0xB623;
                case 0xB621:
                    TotalCycles += 7; PushU16(0xB623); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB623:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB624: // === SUBROUTINE: Sub_B624 ===
                    A = _ram[0x0756]; SetZN(A); TotalCycles += 4; PC = 0xB627;
                    goto case 0xB627;
                case 0xB625:
                    { byte z = (byte)(0x07 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xB627;
                    goto case 0xB627;
                case 0xB627:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xB629;
                    goto case 0xB629;
                case 0xB629:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB66E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB66E; }
                    PC = 0xB62B; goto case 0xB62B;
                case 0xB62B:
                    A = _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0xB62D;
                    goto case 0xB62D;
                case 0xB62C:
                    A = Asl(A); TotalCycles += 2; PC = 0xB62D;
                    goto case 0xB62D;
                case 0xB62D:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0xB62F;
                    goto case 0xB62F;
                case 0xB62E:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xB62F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB664; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB664; }
                    PC = 0xB631; goto case 0xB631;
                case 0xB631:
                    A &= _ram[0x0D]; SetZN(A); TotalCycles += 3; PC = 0xB633;
                    goto case 0xB633;
                case 0xB632:
                    A |= ReadIoReg(0x2FD0); SetZN(A); TotalCycles += 4; PC = 0xB635;
                    goto case 0xB635;
                case 0xB633:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB664; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB664; }
                    PC = 0xB635; goto case 0xB635;
                case 0xB635:
                    A = _ram[0x06CE]; SetZN(A); TotalCycles += 4; PC = 0xB638;
                    goto case 0xB638;
                case 0xB636:
                    { int a = 0x2906; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB639;
                    goto case 0xB639;
                case 0xB637:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0xB639;
                    goto case 0xB639;
                case 0xB638:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0xB63A;
                    goto case 0xB63A;
                case 0xB639:
                    A |= ReadMem(ReadU16Zp((byte)(0xAA + X))); SetZN(A); TotalCycles += 6; PC = 0xB63B;
                    goto case 0xB63B;
                case 0xB63A:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xB63B;
                    goto case 0xB63B;
                case 0xB63B:
                    A = _ram[(byte)(0x24 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB63D;
                    goto case 0xB63D;
                case 0xB63C:
                    Bit(_ram[0xD0]); TotalCycles += 3; PC = 0xB63E;
                    goto case 0xB63E;
                case 0xB63D:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB664; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB664; }
                    PC = 0xB63F; goto case 0xB63F;
                case 0xB63E:
                    A &= _ram[0xA4]; SetZN(A); TotalCycles += 3; PC = 0xB640;
                    goto case 0xB640;
                case 0xB63F:
                    Y = _ram[0xB5]; SetZN(Y); TotalCycles += 3; PC = 0xB641;
                    goto case 0xB641;
                case 0xB640:
                    A = _ram[(byte)(0x88 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB642;
                    goto case 0xB642;
                case 0xB641:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB642;
                    goto case 0xB642;
                case 0xB642:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB664; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB664; }
                    PC = 0xB644; goto case 0xB644;
                case 0xB643:
                    TotalCycles += 6; PushU16(0xB645); PC = 0x14AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB644:
                    A = _ram[0x0714]; SetZN(A); TotalCycles += 4; PC = 0xB647;
                    goto case 0xB647;
                case 0xB647:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB664; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB664; }
                    PC = 0xB649; goto case 0xB649;
                case 0xB649:
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xB64B;
                    goto case 0xB64B;
                case 0xB64A:
                    A |= _ram[(0x03C9 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB64D;
                    goto case 0xB64D;
                case 0xB64B:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xB64D;
                    goto case 0xB64D;
                case 0xB64D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB664; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB664; }
                    PC = 0xB64F; goto case 0xB64F;
                case 0xB64E:
                    A |= _ram[(byte)(0xA9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB650;
                    goto case 0xB650;
                case 0xB64F:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0xB651;
                    goto case 0xB651;
                case 0xB650:
                    TotalCycles += 6; PushU16(0xB652); PC = 0xFF85;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB651:
                    _ram[0xFF] = A; TotalCycles += 3; PC = 0xB653;
                    goto case 0xB653;
                case 0xB653:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xB655;
                    goto case 0xB655;
                case 0xB655:
                    _ram[(byte)(0x24 + X)] = A; TotalCycles += 4; PC = 0xB657;
                    goto case 0xB657;
                case 0xB656:
                    Bit(_ram[0xAC]); TotalCycles += 3; PC = 0xB658;
                    return;
                case 0xB657:
                    Y = _ram[0x070C]; SetZN(Y); TotalCycles += 4; PC = 0xB65A;
                    goto case 0xB65A;
                case 0xB65A:
                    _ram[0x0711] = Y; TotalCycles += 4; PC = 0xB65D;
                    goto case 0xB65D;
                case 0xB65B:
                    A |= ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0xB65D;
                    goto case 0xB65D;
                case 0xB65D:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB65E;
                    goto case 0xB65E;
                case 0xB65E:
                    _ram[0x0781] = Y; TotalCycles += 4; PC = 0xB661;
                    goto case 0xB661;
                case 0xB65F:
                    WriteMem(ReadU16Zp((byte)(0x07 + X)), A); TotalCycles += 6; PC = 0xB661;
                    goto case 0xB661;
                case 0xB661:
                    _ram[0x06CE] = IncVal(_ram[0x06CE]); TotalCycles += 6; PC = 0xB664;
                    goto case 0xB664;
                case 0xB662:
                    { int a = 0xA206; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB665;
                    goto case 0xB665;
                case 0xB663:
                    _ram[0xA2] = Asl(_ram[0xA2]); TotalCycles += 5; PC = 0xB665;
                    goto case 0xB665;
                case 0xB664:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xB666;
                    goto case 0xB666;
                case 0xB665:
                    TotalCycles += 7; PushU16(0xB667); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB666:
                    TotalCycles += 6; PushU16(0xB668); PC = 0xB689;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB689;
                case 0xB668:
                    X = _ram[(byte)(0xA2 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xB66A;
                    goto case 0xB66A;
                case 0xB669:
                    X = 0x01; SetZN(X); TotalCycles += 2; PC = 0xB66B;
                    goto case 0xB66B;
                case 0xB66A:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xB66C;
                    return;
                case 0xB66B:
                    TotalCycles += 6; PushU16(0xB66D); PC = 0xB689;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB689;
                case 0xB66D:
                    X = _ram[(byte)(0xAD + Y)]; SetZN(X); TotalCycles += 4; PC = 0xB66F;
                    goto case 0xB66F;
                case 0xB66E:
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0xB671;
                    goto case 0xB671;
                case 0xB66F:
                    { int a = 0xD007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xB672;
                    return;
                case 0xB671:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB686; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB686; }
                    PC = 0xB673; goto case 0xB673;
                case 0xB673:
                    X = 0x02; SetZN(X); TotalCycles += 2; PC = 0xB675;
                    goto case 0xB675;
                case 0xB675:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xB677;
                    goto case 0xB677;
                case 0xB676:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB677;
                    goto case 0xB677;
                case 0xB677:
                    TotalCycles += 6; PushU16(0xB679); PC = 0xB6F9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB6F9;
                case 0xB678:
                    Sbc(ReadMem(0x20B6 + Y)); TotalCycles += 4; PC = 0xB67B;
                    goto case 0xB67B;
                case 0xB679:
                    X = _ram[(byte)(0x20 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xB67B;
                    goto case 0xB67B;
                case 0xB67A:
                    TotalCycles += 6; PushU16(0xB67C); PC = 0xF131;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB67B:
                    A &= ReadMem(ReadU16Zp(0xF1) + Y); SetZN(A); TotalCycles += 5; PC = 0xB67D;
                    goto case 0xB67D;
                case 0xB67C:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xB67E;
                    goto case 0xB67E;
                case 0xB67D:
                    TotalCycles += 6; PushU16(0xB67F); PC = 0xF191;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB67E:
                    WriteMem(ReadU16Zp(0xF1) + Y, A); TotalCycles += 6; PC = 0xB680;
                    goto case 0xB680;
                case 0xB67F:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xB681;
                    goto case 0xB681;
                case 0xB680:
                    TotalCycles += 6; PushU16(0xB682); PC = 0xEDE1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB681:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xED + X)))); TotalCycles += 6; PC = 0xB683;
                    goto case 0xB683;
                case 0xB682:
                    Sbc(_ram[0x00CA]); TotalCycles += 4; PC = 0xB685;
                    return;
                case 0xB683:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xB684;
                    goto case 0xB684;
                case 0xB684:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB675; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB675; }
                    PC = 0xB686; goto case 0xB686;
                case 0xB686:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB687:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xB688:
                    Cmp(Y, 0x86); TotalCycles += 2; PC = 0xB68A;
                    goto case 0xB68A;
                case 0xB689: // === SUBROUTINE: Sub_B689 ===
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xB68B;
                    goto case 0xB68B;
                case 0xB68A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB68B;
                    goto case 0xB68B;
                case 0xB68B:
                    A = _ram[(byte)(0x24 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB68D;
                    goto case 0xB68D;
                case 0xB68C:
                    Bit(_ram[0x0A]); TotalCycles += 3; PC = 0xB68E;
                    goto case 0xB68E;
                case 0xB68D:
                    A = Asl(A); TotalCycles += 2; PC = 0xB68E;
                    goto case 0xB68E;
                case 0xB68E:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB6F3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB6F3; }
                    PC = 0xB690; goto case 0xB690;
                case 0xB690:
                    Y = _ram[(byte)(0x24 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xB692;
                    goto case 0xB692;
                case 0xB691:
                    Bit(_ram[0xF0]); TotalCycles += 3; PC = 0xB693;
                    goto case 0xB693;
                case 0xB692:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB6F2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB6F2; }
                    PC = 0xB694; goto case 0xB694;
                case 0xB693:
                    { int a = 0xF088 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xB696;
                    return;
                case 0xB694:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB695;
                    goto case 0xB695;
                case 0xB695:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB6BE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB6BE; }
                    PC = 0xB697; goto case 0xB697;
                case 0xB697:
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xB699;
                    goto case 0xB699;
                case 0xB698:
                    _ram[0x69] = X; TotalCycles += 3; PC = 0xB69A;
                    return;
                case 0xB699:
                    Adc(0x04); TotalCycles += 2; PC = 0xB69B;
                    goto case 0xB69B;
                case 0xB69B:
                    _ram[(byte)(0x8D + X)] = A; TotalCycles += 4; PC = 0xB69D;
                    goto case 0xB69D;
                case 0xB69C:
                    WriteIoReg(0x6DA5, A); TotalCycles += 4; PC = 0xB69F;
                    goto case 0xB69F;
                case 0xB69D:
                    A = _ram[0x6D]; SetZN(A); TotalCycles += 3; PC = 0xB69F;
                    goto case 0xB69F;
                case 0xB69E:
                    Adc(_ram[0x0069]); TotalCycles += 4; PC = 0xB6A1;
                    goto case 0xB6A1;
                case 0xB69F:
                    Adc(0x00); TotalCycles += 2; PC = 0xB6A1;
                    goto case 0xB6A1;
                case 0xB6A0:
                    TotalCycles += 7; PushU16(0xB6A2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB6A1:
                    _ram[(byte)(0x74 + X)] = A; TotalCycles += 4; PC = 0xB6A3;
                    goto case 0xB6A3;
                case 0xB6A3:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB6A5;
                    goto case 0xB6A5;
                case 0xB6A4:
                    { int a = 0xD595; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB6A7;
                    goto case 0xB6A7;
                case 0xB6A5:
                    _ram[(byte)(0xD5 + X)] = A; TotalCycles += 4; PC = 0xB6A7;
                    goto case 0xB6A7;
                case 0xB6A6:
                    Cmp(A, _ram[(byte)(0xA9 + X)]); TotalCycles += 4; PC = 0xB6A8;
                    goto case 0xB6A8;
                case 0xB6A7:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB6A9;
                    goto case 0xB6A9;
                case 0xB6A8:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xB6AA;
                    goto case 0xB6AA;
                case 0xB6A9:
                    _ram[(byte)(0xBC + X)] = A; TotalCycles += 4; PC = 0xB6AB;
                    goto case 0xB6AB;
                case 0xB6AA:
                    Y = ReadMem(0x33A4 + X); SetZN(Y); TotalCycles += 4; PC = 0xB6AD;
                    goto case 0xB6AD;
                case 0xB6AB:
                    Y = _ram[0x33]; SetZN(Y); TotalCycles += 3; PC = 0xB6AD;
                    goto case 0xB6AD;
                case 0xB6AD:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB6AE;
                    goto case 0xB6AE;
                case 0xB6AE:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3687 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB6B1;
                    goto case 0xB6B1;
                case 0xB6B0:
                    X = _ram[(byte)(0x95 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xB6B2;
                    goto case 0xB6B2;
                case 0xB6B1:
                    _ram[(byte)(0x5E + X)] = A; TotalCycles += 4; PC = 0xB6B3;
                    goto case 0xB6B3;
                case 0xB6B2:
                    { int a = (0x04A9 + X) & 0x07FF; _ram[a] = Lsr(_ram[a]); } TotalCycles += 7; PC = 0xB6B5;
                    goto case 0xB6B5;
                case 0xB6B3:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xB6B5;
                    goto case 0xB6B5;
                case 0xB6B5:
                    _ram[(byte)(0xA6 + X)] = A; TotalCycles += 4; PC = 0xB6B7;
                    goto case 0xB6B7;
                case 0xB6B6:
                    X = _ram[0xA9]; SetZN(X); TotalCycles += 3; PC = 0xB6B8;
                    return;
                case 0xB6B7:
                    A = 0x07; SetZN(A); TotalCycles += 2; PC = 0xB6B9;
                    goto case 0xB6B9;
                case 0xB6B9:
                    _ram[(0x04A0 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xB6BC;
                    goto case 0xB6BC;
                case 0xB6BA:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xB6BC;
                    goto case 0xB6BC;
                case 0xB6BC:
                    { byte z = (byte)(0x24 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xB6BE;
                    goto case 0xB6BE;
                case 0xB6BD:
                    Bit(_ram[0x8A]); TotalCycles += 3; PC = 0xB6BF;
                    goto case 0xB6BF;
                case 0xB6BE:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xB6BF;
                    goto case 0xB6BF;
                case 0xB6BF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB6C0;
                    goto case 0xB6C0;
                case 0xB6C0:
                    Adc(0x07); TotalCycles += 2; PC = 0xB6C2;
                    goto case 0xB6C2;
                case 0xB6C2:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xB6C3;
                    goto case 0xB6C3;
                case 0xB6C3:
                    A = 0x50; SetZN(A); TotalCycles += 2; PC = 0xB6C5;
                    goto case 0xB6C5;
                case 0xB6C4:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB64B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB64B; }
                    PC = 0xB6C6; goto case 0xB6C6;
                case 0xB6C5:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xB6C7;
                    goto case 0xB6C7;
                case 0xB6C6:
                    TotalCycles += 7; PushU16(0xB6C8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB6C7:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xB6C9;
                    goto case 0xB6C9;
                case 0xB6C9:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xB6CB;
                    goto case 0xB6CB;
                case 0xB6CB:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB6CD;
                    goto case 0xB6CD;
                case 0xB6CC:
                    TotalCycles += 7; PushU16(0xB6CE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB6CD:
                    TotalCycles += 6; PushU16(0xB6CF); PC = 0xBFD7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFD7;
                case 0xB6D0:
                    TotalCycles += 6; PushU16(0xB6D2); PC = 0xBF0F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF0F;
                case 0xB6D3:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xB6D5;
                    goto case 0xB6D5;
                case 0xB6D4:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB6D5;
                    goto case 0xB6D5;
                case 0xB6D5:
                    TotalCycles += 6; PushU16(0xB6D7); PC = 0xF13B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB6D7:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xB6D9;
                    return;
                case 0xB6D8:
                    TotalCycles += 6; PushU16(0xB6DA); PC = 0xF187;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB6DA:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xB6DC;
                    goto case 0xB6DC;
                case 0xB6DB:
                    TotalCycles += 6; PushU16(0xB6DD); PC = 0xE22D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB6DC:
                    A &= ReadIoReg(0x20E2); SetZN(A); TotalCycles += 4; PC = 0xB6DF;
                    goto case 0xB6DF;
                case 0xB6DE:
                    TotalCycles += 6; PushU16(0xB6E0); PC = 0xE1C8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB6DF:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB6E0;
                    goto case 0xB6E0;
                case 0xB6E0:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xAD + X)))); TotalCycles += 6; PC = 0xB6E2;
                    return;
                case 0xB6E1:
                    A = _ram[0x03D2]; SetZN(A); TotalCycles += 4; PC = 0xB6E4;
                    goto case 0xB6E4;
                case 0xB6E4:
                    A &= 0xCC; SetZN(A); TotalCycles += 2; PC = 0xB6E6;
                    goto case 0xB6E6;
                case 0xB6E5:
                    Cmp(Y, _ram[0x06D0]); TotalCycles += 4; PC = 0xB6E8;
                    goto case 0xB6E8;
                case 0xB6E6:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB6EE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB6EE; }
                    PC = 0xB6E8; goto case 0xB6E8;
                case 0xB6E7:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xB6E9;
                    goto case 0xB6E9;
                case 0xB6E8:
                    TotalCycles += 6; PushU16(0xB6EA); PC = 0xD6D9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB6E9:
                    Cmp(A, ReadMem(0x4CD6 + Y)); TotalCycles += 4; PC = 0xB6EC;
                    goto case 0xB6EC;
                case 0xB6EA:
                    { byte z = (byte)(0x4C + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xB6EC;
                    goto case 0xB6EC;
                case 0xB6EB:
                    TotalCycles += 3; PC = 0xECDE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB6EC:
                    { int a = 0xA9EC + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xB6EF;
                    goto case 0xB6EF;
                case 0xB6ED:
                    Cmp(X, _ram[0x00A9]); TotalCycles += 4; PC = 0xB6F0;
                    goto case 0xB6F0;
                case 0xB6EE:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB6F0;
                    goto case 0xB6F0;
                case 0xB6EF:
                    TotalCycles += 7; PushU16(0xB6F1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB6F0:
                    _ram[(byte)(0x24 + X)] = A; TotalCycles += 4; PC = 0xB6F2;
                    goto case 0xB6F2;
                case 0xB6F1:
                    Bit(_ram[0x60]); TotalCycles += 3; PC = 0xB6F3;
                    goto case 0xB6F3;
                case 0xB6F2:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB6F3:
                    TotalCycles += 6; PushU16(0xB6F5); PC = 0xF13B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB6F5:
                    Sbc(ReadMem(ReadU16Zp(0x4C) + Y)); TotalCycles += 5; PC = 0xB6F7;
                    goto case 0xB6F7;
                case 0xB6F6:
                    TotalCycles += 3; PC = 0xED09;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB6F7:
                    A |= 0xED; SetZN(A); TotalCycles += 2; PC = 0xB6F9;
                    goto case 0xB6F9;
                case 0xB6F8:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x28BD]); TotalCycles += 4; PC = 0xB6FB;
                    return;
                case 0xB6F9: // === SUBROUTINE: Sub_B6F9 ===
                    A = _ram[(0x07A8 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB6FC;
                    goto case 0xB6FC;
                case 0xB6FA:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xB6FB;
                    return;
                case 0xB6FC:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0xB6FE;
                    goto case 0xB6FE;
                case 0xB6FD:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xB6FF;
                    return;
                case 0xB6FE:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0xB700;
                    goto case 0xB700;
                case 0xB700:
                    A = _ram[(byte)(0xE4 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB702;
                    goto case 0xB702;
                case 0xB701:
                    Cmp(X, _ram[0xC9]); TotalCycles += 3; PC = 0xB703;
                    goto case 0xB703;
                case 0xB702:
                    Cmp(A, 0xF8); TotalCycles += 2; PC = 0xB704;
                    goto case 0xB704;
                case 0xB703:
                    P |= FlagD; TotalCycles += 2; PC = 0xB704;
                    goto case 0xB704;
                case 0xB704:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB732; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB732; }
                    PC = 0xB706; goto case 0xB706;
                case 0xB705:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x12AD]); TotalCycles += 4; PC = 0xB708;
                    return;
                case 0xB706:
                    A = _ram[0x0792]; SetZN(A); TotalCycles += 4; PC = 0xB709;
                    goto case 0xB709;
                case 0xB709:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB74A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB74A; }
                    PC = 0xB70B; goto case 0xB70B;
                case 0xB70B:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB70D;
                    goto case 0xB70D;
                case 0xB70C:
                    TotalCycles += 7; PushU16(0xB70E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB70D:
                    A = _ram[0x33]; SetZN(A); TotalCycles += 3; PC = 0xB70F;
                    goto case 0xB70F;
                case 0xB70F:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB710;
                    goto case 0xB710;
                case 0xB710:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB714; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB714; }
                    PC = 0xB712; goto case 0xB712;
                case 0xB712:
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0xB714;
                    goto case 0xB714;
                case 0xB713:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB714;
                    goto case 0xB714;
                case 0xB714:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB715;
                    goto case 0xB715;
                case 0xB715:
                    Adc(_ram[0x86]); TotalCycles += 3; PC = 0xB717;
                    goto case 0xB717;
                case 0xB716:
                    _ram[0x95] = X; TotalCycles += 3; PC = 0xB718;
                    return;
                case 0xB717:
                    _ram[(byte)(0x9C + X)] = A; TotalCycles += 4; PC = 0xB719;
                    goto case 0xB719;
                case 0xB719:
                    A = _ram[0x6D]; SetZN(A); TotalCycles += 3; PC = 0xB71B;
                    goto case 0xB71B;
                case 0xB71A:
                    Adc(_ram[0x0069]); TotalCycles += 4; PC = 0xB71D;
                    goto case 0xB71D;
                case 0xB71B:
                    Adc(0x00); TotalCycles += 2; PC = 0xB71D;
                    goto case 0xB71D;
                case 0xB71C:
                    TotalCycles += 7; PushU16(0xB71E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB71D:
                    _ram[(byte)(0x83 + X)] = A; TotalCycles += 4; PC = 0xB71F;
                    goto case 0xB71F;
                case 0xB71F:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB721;
                    goto case 0xB721;
                case 0xB720:
                    { int a = 0x6918; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB723;
                    goto case 0xB723;
                case 0xB721:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB722;
                    goto case 0xB722;
                case 0xB722:
                    Adc(0x08); TotalCycles += 2; PC = 0xB724;
                    goto case 0xB724;
                case 0xB723:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB724;
                    goto case 0xB724;
                case 0xB724:
                    _ram[(byte)(0xE4 + X)] = A; TotalCycles += 4; PC = 0xB726;
                    goto case 0xB726;
                case 0xB725:
                    Cmp(X, _ram[0xA9]); TotalCycles += 3; PC = 0xB727;
                    goto case 0xB727;
                case 0xB726:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB728;
                    goto case 0xB728;
                case 0xB727:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xB729;
                    return;
                case 0xB728:
                    _ram[(byte)(0xCB + X)] = A; TotalCycles += 4; PC = 0xB72A;
                    goto case 0xB72A;
                case 0xB72A:
                    Y = _ram[0x07]; SetZN(Y); TotalCycles += 3; PC = 0xB72C;
                    goto case 0xB72C;
                case 0xB72C:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x374D + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB72F;
                    goto case 0xB72F;
                case 0xB72D:
                    A ^= SmbEmbeddedAssets.StaticDataTables[0x0DB7]; SetZN(A); TotalCycles += 4; PC = 0xB730;
                    return;
                case 0xB72F:
                    _ram[0x0792] = A; TotalCycles += 4; PC = 0xB732;
                    goto case 0xB732;
                case 0xB732:
                    Y = _ram[0x07]; SetZN(Y); TotalCycles += 3; PC = 0xB734;
                    goto case 0xB734;
                case 0xB734:
                    A = _ram[(0x042C + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB737;
                    goto case 0xB737;
                case 0xB735:
                    Bit(ReadIoReg(0x3804)); TotalCycles += 4; PC = 0xB738;
                    goto case 0xB738;
                case 0xB737:
                    P |= FlagC; TotalCycles += 2; PC = 0xB738;
                    goto case 0xB738;
                case 0xB738:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x374B + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xB73B;
                    goto case 0xB73B;
                case 0xB73B:
                    _ram[(0x042C + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xB73E;
                    goto case 0xB73E;
                case 0xB73C:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x3504]); TotalCycles += 4; PC = 0xB73F;
                    goto case 0xB73F;
                case 0xB73E:
                    A = _ram[(byte)(0xE4 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB740;
                    goto case 0xB740;
                case 0xB73F:
                    Cmp(X, _ram[0xE9]); TotalCycles += 3; PC = 0xB741;
                    goto case 0xB741;
                case 0xB740:
                    Sbc(0x00); TotalCycles += 2; PC = 0xB742;
                    goto case 0xB742;
                case 0xB741:
                    TotalCycles += 7; PushU16(0xB743); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB742:
                    Cmp(A, 0x20); TotalCycles += 2; PC = 0xB744;
                    goto case 0xB744;
                case 0xB743:
                    TotalCycles += 6; PushU16(0xB745); PC = 0x02B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB744:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB748; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB748; }
                    PC = 0xB746; goto case 0xB746;
                case 0xB746:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0xB748;
                    goto case 0xB748;
                case 0xB747:
                    P |= FlagD; TotalCycles += 2; PC = 0xB748;
                    goto case 0xB748;
                case 0xB748:
                    _ram[(byte)(0xE4 + X)] = A; TotalCycles += 4; PC = 0xB74A;
                    goto case 0xB74A;
                case 0xB749:
                    Cmp(X, _ram[0x60]); TotalCycles += 3; PC = 0xB74B;
                    return;
                case 0xB74A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB74C:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB78E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB74E; goto case 0xB74E;
                case 0xB74D:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xB74E:
                    TotalCycles += 6; PushU16(0xB750); PC = 0x70AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB74F: // === SUBROUTINE: Sub_B74F ===
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0xB752;
                    goto case 0xB752;
                case 0xB750:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0xB759; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB759; }
                    PC = 0xB752; goto case 0xB752;
                case 0xB752:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB7A3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7A3; }
                    PC = 0xB754; goto case 0xB754;
                case 0xB754:
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0xB756;
                    goto case 0xB756;
                case 0xB755:
                    _ram[0x00C9] = Asl(_ram[0x00C9]); TotalCycles += 6; PC = 0xB758;
                    goto case 0xB758;
                case 0xB756:
                    Cmp(A, 0x08); TotalCycles += 2; PC = 0xB758;
                    goto case 0xB758;
                case 0xB757:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB758;
                    goto case 0xB758;
                case 0xB758:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB7A3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7A3; }
                    PC = 0xB75A; goto case 0xB75A;
                case 0xB759:
                    A ^= 0xC9; SetZN(A); TotalCycles += 2; PC = 0xB75B;
                    return;
                case 0xB75A:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0xB75C;
                    goto case 0xB75C;
                case 0xB75C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB7A3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7A3; }
                    PC = 0xB75E; goto case 0xB75E;
                case 0xB75D:
                    A ^= _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0xB75F;
                    goto case 0xB75F;
                case 0xB75E:
                    A = _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xB760;
                    goto case 0xB760;
                case 0xB75F:
                    A = _ram[(byte)(0xC9 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB761;
                    return;
                case 0xB760:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xB762;
                    goto case 0xB762;
                case 0xB762:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB7A3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7A3; }
                    PC = 0xB764; goto case 0xB764;
                case 0xB764:
                    A = _ram[0x0787]; SetZN(A); TotalCycles += 4; PC = 0xB767;
                    goto case 0xB767;
                case 0xB767:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB7A3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7A3; }
                    PC = 0xB769; goto case 0xB769;
                case 0xB769:
                    A = _ram[0x07F8]; SetZN(A); TotalCycles += 4; PC = 0xB76C;
                    goto case 0xB76C;
                case 0xB76A:
                    P |= FlagD; TotalCycles += 2; PC = 0xB76B;
                    return;
                case 0xB76C:
                    A |= _ram[0x07F9]; SetZN(A); TotalCycles += 4; PC = 0xB76F;
                    goto case 0xB76F;
                case 0xB76D:
                    Sbc(ReadMem(0x0D07 + Y)); TotalCycles += 4; PC = 0xB770;
                    return;
                case 0xB76F:
                    A |= _ram[0x07FA]; SetZN(A); TotalCycles += 4; PC = 0xB772;
                    goto case 0xB772;
                case 0xB772:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB79A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB79A; }
                    PC = 0xB774; goto case 0xB774;
                case 0xB773:
                    _ram[0xAC] = Rol(_ram[0xAC]); TotalCycles += 5; PC = 0xB775;
                    goto case 0xB775;
                case 0xB774:
                    Y = _ram[0x07F8]; SetZN(Y); TotalCycles += 4; PC = 0xB777;
                    goto case 0xB777;
                case 0xB775:
                    P |= FlagD; TotalCycles += 2; PC = 0xB776;
                    return;
                case 0xB777:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB778;
                    goto case 0xB778;
                case 0xB778:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB786; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB786; }
                    PC = 0xB77A; goto case 0xB77A;
                case 0xB77A:
                    A = _ram[0x07F9]; SetZN(A); TotalCycles += 4; PC = 0xB77D;
                    goto case 0xB77D;
                case 0xB77B:
                    Sbc(ReadMem(0x0D07 + Y)); TotalCycles += 4; PC = 0xB77E;
                    return;
                case 0xB77D:
                    A |= _ram[0x07FA]; SetZN(A); TotalCycles += 4; PC = 0xB780;
                    goto case 0xB780;
                case 0xB780:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB786; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB786; }
                    PC = 0xB782; goto case 0xB782;
                case 0xB782:
                    A = 0x40; SetZN(A); TotalCycles += 2; PC = 0xB784;
                    goto case 0xB784;
                case 0xB783:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xB784:
                    _ram[0xFC] = A; TotalCycles += 3; PC = 0xB786;
                    goto case 0xB786;
                case 0xB786:
                    A = 0x18; SetZN(A); TotalCycles += 2; PC = 0xB788;
                    goto case 0xB788;
                case 0xB787:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB788;
                    goto case 0xB788;
                case 0xB788:
                    _ram[0x0787] = A; TotalCycles += 4; PC = 0xB78B;
                    goto case 0xB78B;
                case 0xB78B:
                    Y = 0x23; SetZN(Y); TotalCycles += 2; PC = 0xB78D;
                    goto case 0xB78D;
                case 0xB78D:
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0xB78F;
                    goto case 0xB78F;
                case 0xB78F:
                    _ram[0x0139] = A; TotalCycles += 4; PC = 0xB792;
                    goto case 0xB792;
                case 0xB790:
                    A &= ReadMem(0x2001 + Y); SetZN(A); TotalCycles += 4; PC = 0xB793;
                    return;
                case 0xB791:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xB793;
                    return;
                case 0xB792:
                    TotalCycles += 6; PushU16(0xB794); PC = 0x8F5F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB795:
                    A = 0xA4; SetZN(A); TotalCycles += 2; PC = 0xB797;
                    goto case 0xB797;
                case 0xB796:
                    Y = _ram[0x4C]; SetZN(Y); TotalCycles += 3; PC = 0xB798;
                    goto case 0xB798;
                case 0xB797:
                    TotalCycles += 3; PC = 0x8F06;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB798: // === SUBROUTINE: Sub_B798 ===
                    _ram[0x8F] = Asl(_ram[0x8F]); TotalCycles += 5; PC = 0xB79A;
                    goto case 0xB79A;
                case 0xB79A:
                    _ram[0x0756] = A; TotalCycles += 4; PC = 0xB79D;
                    goto case 0xB79D;
                case 0xB79B:
                    { byte z = (byte)(0x07 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xB79D;
                    goto case 0xB79D;
                case 0xB79D:
                    TotalCycles += 6; PushU16(0xB79F); PC = 0xD931;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB79E:
                    A &= ReadMem(ReadU16Zp(0xD9) + Y); SetZN(A); TotalCycles += 5; PC = 0xB7A0;
                    goto case 0xB7A0;
                case 0xB79F:
                    Cmp(A, ReadMem(0x59EE + Y)); TotalCycles += 4; PC = 0xB7A2;
                    return;
                case 0xB7A0:
                    _ram[0x0759] = IncVal(_ram[0x0759]); TotalCycles += 6; PC = 0xB7A3;
                    goto case 0xB7A3;
                case 0xB7A1:
                    A ^= ReadMem(0x6007 + Y); SetZN(A); TotalCycles += 4; PC = 0xB7A4;
                    goto case 0xB7A4;
                case 0xB7A3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB7A4: // === SUBROUTINE: Sub_B7A4 ===
                    A = _ram[0x0723]; SetZN(A); TotalCycles += 4; PC = 0xB7A7;
                    goto case 0xB7A7;
                case 0xB7A7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB7A3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7A3; }
                    PC = 0xB7A9; goto case 0xB7A9;
                case 0xB7A9:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB7AB;
                    goto case 0xB7AB;
                case 0xB7AA:
                    { int a = 0xB525; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB7AD;
                    goto case 0xB7AD;
                case 0xB7AB:
                    A &= _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xB7AD;
                    goto case 0xB7AD;
                case 0xB7AC:
                    A = _ram[(byte)(0xD0 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB7AE;
                    return;
                case 0xB7AD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB7A3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7A3; }
                    PC = 0xB7AF; goto case 0xB7AF;
                case 0xB7AF:
                    _ram[0x0723] = A; TotalCycles += 4; PC = 0xB7B2;
                    goto case 0xB7B2;
                case 0xB7B2:
                    _ram[0x06D6] = IncVal(_ram[0x06D6]); TotalCycles += 6; PC = 0xB7B5;
                    goto case 0xB7B5;
                case 0xB7B3:
                    { byte z = (byte)(0x06 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xB7B5;
                    goto case 0xB7B5;
                case 0xB7B4:
                    _ram[0x4C] = Asl(_ram[0x4C]); TotalCycles += 5; PC = 0xB7B6;
                    goto case 0xB7B6;
                case 0xB7B5:
                    TotalCycles += 3; PC = 0xC998;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB7B6:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB7B7;
                    goto case 0xB7B7;
                case 0xB7B7:
                    Cmp(A, 0xAD); TotalCycles += 2; PC = 0xB7B9;
                    goto case 0xB7B9;
                case 0xB7B8: // === SUBROUTINE: Sub_B7B8 ===
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0xB7BB;
                    goto case 0xB7BB;
                case 0xB7B9:
                    { int a = 0xD007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xB7BC;
                    return;
                case 0xB7BB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB7F4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7F4; }
                    PC = 0xB7BD; goto case 0xB7BD;
                case 0xB7BD:
                    _ram[0x047D] = A; TotalCycles += 4; PC = 0xB7C0;
                    goto case 0xB7C0;
                case 0xB7BE:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x2D04 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xB7C1;
                    return;
                case 0xB7C0:
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xB7C3;
                    goto case 0xB7C3;
                case 0xB7C3: // === SUBROUTINE: Sub_B7C3 ===
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB7F4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7F4; }
                    PC = 0xB7C5; goto case 0xB7C5;
                case 0xB7C5:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0xB7C7;
                    goto case 0xB7C7;
                case 0xB7C7:
                    A = _ram[(0x0471 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB7CA;
                    goto case 0xB7CA;
                case 0xB7C8:
                    Adc(ReadMem(ReadU16Zp(0x04) + Y)); TotalCycles += 5; PC = 0xB7CA;
                    goto case 0xB7CA;
                case 0xB7CA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB7CB;
                    goto case 0xB7CB;
                case 0xB7CB:
                    Adc(_ram[(0x0477 + Y) & 0x07FF]); TotalCycles += 4; PC = 0xB7CE;
                    goto case 0xB7CE;
                case 0xB7CE:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xB7D0;
                    goto case 0xB7D0;
                case 0xB7D0:
                    A = _ram[(0x046B + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB7D3;
                    goto case 0xB7D3;
                case 0xB7D3:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB7F1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7F1; }
                    PC = 0xB7D5; goto case 0xB7D5;
                case 0xB7D5:
                    Adc(0x00); TotalCycles += 2; PC = 0xB7D7;
                    goto case 0xB7D7;
                case 0xB7D6:
                    TotalCycles += 7; PushU16(0xB7D8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB7D7:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xB7D9;
                    goto case 0xB7D9;
                case 0xB7D8:
                    A |= ReadMem(ReadU16Zp((byte)(0xA5 + X))); SetZN(A); TotalCycles += 6; PC = 0xB7DA;
                    goto case 0xB7DA;
                case 0xB7D9:
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xB7DB;
                    goto case 0xB7DB;
                case 0xB7DA:
                    _ram[0x38] = X; TotalCycles += 3; PC = 0xB7DC;
                    goto case 0xB7DC;
                case 0xB7DB:
                    P |= FlagC; TotalCycles += 2; PC = 0xB7DC;
                    goto case 0xB7DC;
                case 0xB7DC:
                    Sbc(_ram[(0x0471 + Y) & 0x07FF]); TotalCycles += 4; PC = 0xB7DF;
                    goto case 0xB7DF;
                case 0xB7DD:
                    Adc(ReadMem(ReadU16Zp(0x04) + Y)); TotalCycles += 5; PC = 0xB7DF;
                    goto case 0xB7DF;
                case 0xB7DF:
                    A = _ram[0x6D]; SetZN(A); TotalCycles += 3; PC = 0xB7E1;
                    goto case 0xB7E1;
                case 0xB7E0:
                    Adc(ReadIoReg(0x6BF9)); TotalCycles += 4; PC = 0xB7E3;
                    return;
                case 0xB7E1:
                    Sbc(_ram[(0x046B + Y) & 0x07FF]); TotalCycles += 4; PC = 0xB7E4;
                    goto case 0xB7E4;
                case 0xB7E4:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB7F1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7F1; }
                    PC = 0xB7E6; goto case 0xB7E6;
                case 0xB7E6:
                    A = _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xB7E8;
                    goto case 0xB7E8;
                case 0xB7E8:
                    P |= FlagC; TotalCycles += 2; PC = 0xB7E9;
                    goto case 0xB7E9;
                case 0xB7E9:
                    Sbc(_ram[0x86]); TotalCycles += 3; PC = 0xB7EB;
                    goto case 0xB7EB;
                case 0xB7EA:
                    _ram[0xA5] = X; TotalCycles += 3; PC = 0xB7EC;
                    goto case 0xB7EC;
                case 0xB7EB:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0xB7ED;
                    goto case 0xB7ED;
                case 0xB7EC:
                    A |= ReadMem(ReadU16Zp((byte)(0xE5 + X))); SetZN(A); TotalCycles += 6; PC = 0xB7EE;
                    goto case 0xB7EE;
                case 0xB7ED:
                    Sbc(_ram[0x6D]); TotalCycles += 3; PC = 0xB7EF;
                    goto case 0xB7EF;
                case 0xB7EE:
                    Adc(_ram[0x0410]); TotalCycles += 4; PC = 0xB7F1;
                    goto case 0xB7F1;
                case 0xB7EF:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB7F5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7F5; }
                    PC = 0xB7F1; goto case 0xB7F1;
                case 0xB7F1:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB7F2;
                    goto case 0xB7F2;
                case 0xB7F2:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB7C7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7C7; }
                    PC = 0xB7F4; goto case 0xB7F4;
                case 0xB7F4:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB7F5:
                    A = _ram[(0x0477 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB7F8;
                    goto case 0xB7F8;
                case 0xB7F8:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB7F9;
                    goto case 0xB7F9;
                case 0xB7F9:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xB7FB;
                    goto case 0xB7FB;
                case 0xB7FA:
                    TotalCycles += 7; PushU16(0xB7FC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB7FB:
                    A = _ram[(0x0471 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB7FE;
                    goto case 0xB7FE;
                case 0xB7FC:
                    Adc(ReadMem(ReadU16Zp(0x04) + Y)); TotalCycles += 5; PC = 0xB7FE;
                    goto case 0xB7FE;
                case 0xB7FE:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB7FF;
                    goto case 0xB7FF;
                case 0xB7FF:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0xB801;
                    goto case 0xB801;
                case 0xB800:
                    TotalCycles += 7; PushU16(0xB802); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB801:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xB803;
                    goto case 0xB803;
                case 0xB802:
                    A |= ReadMem(ReadU16Zp((byte)(0xB9 + X))); SetZN(A); TotalCycles += 6; PC = 0xB804;
                    return;
                case 0xB803:
                    A = _ram[(0x046B + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB806;
                    goto case 0xB806;
                case 0xB806:
                    Adc(0x00); TotalCycles += 2; PC = 0xB808;
                    goto case 0xB808;
                case 0xB807:
                    TotalCycles += 7; PushU16(0xB809); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB808:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xB80A;
                    goto case 0xB80A;
                case 0xB809:
                    TotalCycles += 7; PushU16(0xB80B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB80A:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xB80C;
                    goto case 0xB80C;
                case 0xB80B:
                    A |= 0x4A; SetZN(A); TotalCycles += 2; PC = 0xB80D;
                    goto case 0xB80D;
                case 0xB80C:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB80D;
                    goto case 0xB80D;
                case 0xB80D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB83B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB83B; }
                    PC = 0xB80F; goto case 0xB80F;
                case 0xB80E:
                    Bit(_ram[0x01A5]); TotalCycles += 4; PC = 0xB811;
                    goto case 0xB811;
                case 0xB80F:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0xB811;
                    goto case 0xB811;
                case 0xB810:
                    A |= ReadMem(ReadU16Zp((byte)(0x38 + X))); SetZN(A); TotalCycles += 6; PC = 0xB812;
                    goto case 0xB812;
                case 0xB811:
                    P |= FlagC; TotalCycles += 2; PC = 0xB812;
                    goto case 0xB812;
                case 0xB812:
                    Sbc(_ram[0x86]); TotalCycles += 3; PC = 0xB814;
                    goto case 0xB814;
                case 0xB813:
                    _ram[0xA5] = X; TotalCycles += 3; PC = 0xB815;
                    goto case 0xB815;
                case 0xB814:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xB816;
                    goto case 0xB816;
                case 0xB815:
                    TotalCycles += 7; PushU16(0xB817); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB816:
                    Sbc(_ram[0x6D]); TotalCycles += 3; PC = 0xB818;
                    goto case 0xB818;
                case 0xB817:
                    Adc(_ram[0x0610]); TotalCycles += 4; PC = 0xB81A;
                    goto case 0xB81A;
                case 0xB818:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB828; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB828; }
                    PC = 0xB81A; goto case 0xB81A;
                case 0xB819:
                    { int a = 0x86A5; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB81C;
                    goto case 0xB81C;
                case 0xB81A:
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xB81C;
                    goto case 0xB81C;
                case 0xB81B:
                    _ram[0x38] = X; TotalCycles += 3; PC = 0xB81D;
                    goto case 0xB81D;
                case 0xB81C:
                    P |= FlagC; TotalCycles += 2; PC = 0xB81D;
                    goto case 0xB81D;
                case 0xB81D:
                    Sbc(0x01); TotalCycles += 2; PC = 0xB81F;
                    goto case 0xB81F;
                case 0xB81E:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xB820;
                    goto case 0xB820;
                case 0xB81F:
                    _ram[0x86] = A; TotalCycles += 3; PC = 0xB821;
                    goto case 0xB821;
                case 0xB820:
                    _ram[0xA5] = X; TotalCycles += 3; PC = 0xB822;
                    goto case 0xB822;
                case 0xB821:
                    A = _ram[0x6D]; SetZN(A); TotalCycles += 3; PC = 0xB823;
                    goto case 0xB823;
                case 0xB822:
                    Adc(_ram[0x00E9]); TotalCycles += 4; PC = 0xB825;
                    goto case 0xB825;
                case 0xB823:
                    Sbc(0x00); TotalCycles += 2; PC = 0xB825;
                    goto case 0xB825;
                case 0xB824:
                    TotalCycles += 7; PushU16(0xB826); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB825:
                    TotalCycles += 3; PC = 0xB839;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB839;
                case 0xB826:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x2DB8 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB829;
                    goto case 0xB829;
                case 0xB827:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xB828;
                    goto case 0xB828;
                case 0xB828:
                    A = _ram[0x0490]; SetZN(A); TotalCycles += 4; PC = 0xB82B;
                    goto case 0xB82B;
                case 0xB829:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB82F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB82F; }
                    PC = 0xB82B; goto case 0xB82B;
                case 0xB82B:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB82C;
                    goto case 0xB82C;
                case 0xB82C:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB83B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB83B; }
                    PC = 0xB82E; goto case 0xB82E;
                case 0xB82D:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x06A5]; SetZN(A); TotalCycles += 4; PC = 0xB830;
                    goto case 0xB830;
                case 0xB82E:
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xB830;
                    goto case 0xB830;
                case 0xB82F:
                    _ram[0x18] = X; TotalCycles += 3; PC = 0xB831;
                    goto case 0xB831;
                case 0xB830:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB831;
                    goto case 0xB831;
                case 0xB831:
                    Adc(0x01); TotalCycles += 2; PC = 0xB833;
                    goto case 0xB833;
                case 0xB832:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xB834;
                    goto case 0xB834;
                case 0xB833:
                    _ram[0x86] = A; TotalCycles += 3; PC = 0xB835;
                    goto case 0xB835;
                case 0xB834:
                    _ram[0xA5] = X; TotalCycles += 3; PC = 0xB836;
                    goto case 0xB836;
                case 0xB835:
                    A = _ram[0x6D]; SetZN(A); TotalCycles += 3; PC = 0xB837;
                    goto case 0xB837;
                case 0xB836:
                    Adc(_ram[0x0069]); TotalCycles += 4; PC = 0xB839;
                    goto case 0xB839;
                case 0xB837:
                    Adc(0x00); TotalCycles += 2; PC = 0xB839;
                    goto case 0xB839;
                case 0xB838:
                    TotalCycles += 7; PushU16(0xB83A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB839:
                    _ram[0x6D] = A; TotalCycles += 3; PC = 0xB83B;
                    goto case 0xB83B;
                case 0xB83A:
                    Adc(_ram[0x00A9]); TotalCycles += 4; PC = 0xB83D;
                    goto case 0xB83D;
                case 0xB83B:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0xB83D;
                    goto case 0xB83D;
                case 0xB83C:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB7C3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB7C3; }
                    PC = 0xB83E; goto case 0xB83E;
                case 0xB83D:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xB83F;
                    goto case 0xB83F;
                case 0xB83E:
                    TotalCycles += 7; PushU16(0xB840); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB83F:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB841;
                    goto case 0xB841;
                case 0xB840:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0xB842;
                    goto case 0xB842;
                case 0xB841:
                    _ram[0x047D] = A; TotalCycles += 4; PC = 0xB844;
                    goto case 0xB844;
                case 0xB842:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x0504 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xB845;
                    return;
                case 0xB844:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xB846;
                    goto case 0xB846;
                case 0xB846:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB847;
                    goto case 0xB847;
                case 0xB847:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xB848;
                    goto case 0xB848;
                case 0xB848:
                    TotalCycles += 3; PC = 0xBFD7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFD7;
                case 0xB84B:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xB84D;
                    goto case 0xB84D;
                case 0xB84D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB84E;
                    return;
                case 0xB84F:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0xB851;
                    return;
                case 0xB855: // === SUBROUTINE: Sub_B855 ===
                    X = 0x05; SetZN(X); TotalCycles += 2; PC = 0xB857;
                    goto case 0xB857;
                case 0xB856:
                    A |= _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xB858;
                    goto case 0xB858;
                case 0xB857:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xB859;
                    goto case 0xB859;
                case 0xB858:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB859;
                    goto case 0xB859;
                case 0xB859:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB85B;
                    goto case 0xB85B;
                case 0xB85A:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB85C;
                    goto case 0xB85C;
                case 0xB85B:
                    Cmp(A, 0x30); TotalCycles += 2; PC = 0xB85D;
                    goto case 0xB85D;
                case 0xB85C:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB82E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB82E; }
                    PC = 0xB85E; goto case 0xB85E;
                case 0xB85D:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB8B5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB8B5; }
                    PC = 0xB85F; goto case 0xB85F;
                case 0xB85E:
                    { byte z = (byte)(0xA5 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xB860;
                    goto case 0xB860;
                case 0xB85F:
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0xB861;
                    goto case 0xB861;
                case 0xB860:
                    _ram[0x04C9] = Asl(_ram[0x04C9]); TotalCycles += 6; PC = 0xB863;
                    goto case 0xB863;
                case 0xB861:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0xB863;
                    goto case 0xB863;
                case 0xB863:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB896; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB896; }
                    PC = 0xB865; goto case 0xB865;
                case 0xB864:
                    A &= ReadMem(ReadU16Zp(0xA5) + Y); SetZN(A); TotalCycles += 5; PC = 0xB866;
                    goto case 0xB866;
                case 0xB865:
                    A = _ram[0x1D]; SetZN(A); TotalCycles += 3; PC = 0xB867;
                    goto case 0xB867;
                case 0xB866:
                    A |= _ram[(0x03C9 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB869;
                    goto case 0xB869;
                case 0xB867:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xB869;
                    goto case 0xB869;
                case 0xB869:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB896; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB896; }
                    PC = 0xB86B; goto case 0xB86B;
                case 0xB86B:
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xB86D;
                    goto case 0xB86D;
                case 0xB86D:
                    Cmp(A, 0xAA); TotalCycles += 2; PC = 0xB86F;
                    goto case 0xB86F;
                case 0xB86E:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xB86F;
                    goto case 0xB86F;
                case 0xB86F:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB899; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB899; }
                    PC = 0xB871; goto case 0xB871;
                case 0xB870:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xB871;
                    goto case 0xB871;
                case 0xB871:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xB873;
                    goto case 0xB873;
                case 0xB872:
                    { int a = 0xA2C9; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB875;
                    goto case 0xB875;
                case 0xB873:
                    Cmp(A, 0xA2); TotalCycles += 2; PC = 0xB875;
                    goto case 0xB875;
                case 0xB874:
                    X = 0xB0; SetZN(X); TotalCycles += 2; PC = 0xB876;
                    return;
                case 0xB875:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB899; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB899; }
                    PC = 0xB877; goto case 0xB877;
                case 0xB877:
                    A = _ram[(0x0417 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB87A;
                    goto case 0xB87A;
                case 0xB87A:
                    Adc(0xFF); TotalCycles += 2; PC = 0xB87C;
                    goto case 0xB87C;
                case 0xB87C:
                    _ram[(0x0417 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xB87F;
                    goto case 0xB87F;
                case 0xB87F:
                    A = _ram[(byte)(0xCF + X)]; SetZN(A); TotalCycles += 4; PC = 0xB881;
                    goto case 0xB881;
                case 0xB881:
                    Adc(0x01); TotalCycles += 2; PC = 0xB883;
                    goto case 0xB883;
                case 0xB882:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xB884;
                    return;
                case 0xB883:
                    _ram[(byte)(0xCF + X)] = A; TotalCycles += 4; PC = 0xB885;
                    goto case 0xB885;
                case 0xB885:
                    A = _ram[0x010E]; SetZN(A); TotalCycles += 4; PC = 0xB888;
                    goto case 0xB888;
                case 0xB886:
                    { int a = 0x3801; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB889;
                    goto case 0xB889;
                case 0xB887:
                    A |= ReadMem(ReadU16Zp((byte)(0x38 + X))); SetZN(A); TotalCycles += 6; PC = 0xB889;
                    goto case 0xB889;
                case 0xB888:
                    P |= FlagC; TotalCycles += 2; PC = 0xB889;
                    goto case 0xB889;
                case 0xB889:
                    Sbc(0xFF); TotalCycles += 2; PC = 0xB88B;
                    goto case 0xB88B;
                case 0xB88B:
                    _ram[0x010E] = A; TotalCycles += 4; PC = 0xB88E;
                    goto case 0xB88E;
                case 0xB88C:
                    { int a = 0xAD01; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB88F;
                    goto case 0xB88F;
                case 0xB88D:
                    A |= ReadMem(ReadU16Zp((byte)(0xAD + X))); SetZN(A); TotalCycles += 6; PC = 0xB88F;
                    goto case 0xB88F;
                case 0xB88E:
                    A = _ram[0x010D]; SetZN(A); TotalCycles += 4; PC = 0xB891;
                    goto case 0xB891;
                case 0xB88F:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x6901]; SetZN(A); TotalCycles += 4; PC = 0xB892;
                    goto case 0xB892;
                case 0xB890:
                    A |= ReadMem(ReadU16Zp((byte)(0xE9 + X))); SetZN(A); TotalCycles += 6; PC = 0xB892;
                    goto case 0xB892;
                case 0xB891:
                    Sbc(0x01); TotalCycles += 2; PC = 0xB893;
                    goto case 0xB893;
                case 0xB892:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0xB894;
                    goto case 0xB894;
                case 0xB893:
                    _ram[0x010D] = A; TotalCycles += 4; PC = 0xB896;
                    goto case 0xB896;
                case 0xB894:
                    A |= ReadIoReg(0x4C01); SetZN(A); TotalCycles += 4; PC = 0xB897;
                    goto case 0xB897;
                case 0xB895:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0xB897;
                    goto case 0xB897;
                case 0xB896:
                    TotalCycles += 3; PC = 0xB8AC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB8AC;
                case 0xB897:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x2CB8]; SetZN(Y); TotalCycles += 4; PC = 0xB89A;
                    return;
                case 0xB898:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xB899;
                    goto case 0xB899;
                case 0xB899:
                    Y = _ram[0x010F]; SetZN(Y); TotalCycles += 4; PC = 0xB89C;
                    goto case 0xB89C;
                case 0xB89B:
                    A |= ReadMem(ReadU16Zp((byte)(0xB9 + X))); SetZN(A); TotalCycles += 6; PC = 0xB89D;
                    return;
                case 0xB89C:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x384B + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB89F;
                    goto case 0xB89F;
                case 0xB89E:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xB89F;
                    goto case 0xB89F;
                case 0xB89F:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x3850 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xB8A2;
                    goto case 0xB8A2;
                case 0xB8A0:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB85A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB85A; }
                    PC = 0xB8A2; goto case 0xB8A2;
                case 0xB8A1:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xB8A2;
                    goto case 0xB8A2;
                case 0xB8A2:
                    _ram[(0x0134 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xB8A5;
                    goto case 0xB8A5;
                case 0xB8A4:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xB8A6;
                    return;
                case 0xB8A5:
                    TotalCycles += 6; PushU16(0xB8A7); PC = 0xBC27;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBC27;
                case 0xB8A7:
                    Y = _ram[(0x05A9 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xB8AA;
                    goto case 0xB8AA;
                case 0xB8A8:
                    A = 0x05; SetZN(A); TotalCycles += 2; PC = 0xB8AA;
                    goto case 0xB8AA;
                case 0xB8A9:
                    A |= _ram[0x85]; SetZN(A); TotalCycles += 3; PC = 0xB8AB;
                    goto case 0xB8AB;
                case 0xB8AA:
                    _ram[0x0E] = A; TotalCycles += 3; PC = 0xB8AC;
                    goto case 0xB8AC;
                case 0xB8AB:
                    { int a = 0xAF20; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB8AE;
                    goto case 0xB8AE;
                case 0xB8AC:
                    TotalCycles += 6; PushU16(0xB8AE); PC = 0xF1AF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB8AE:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xB8B0;
                    return;
                case 0xB8AF:
                    TotalCycles += 6; PushU16(0xB8B1); PC = 0xF152;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB8B1:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xB8B3;
                    return;
                case 0xB8B2:
                    TotalCycles += 6; PushU16(0xB8B4); PC = 0xE54B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB8B4:
                    Sbc(_ram[0x60]); TotalCycles += 3; PC = 0xB8B6;
                    goto case 0xB8B6;
                case 0xB8B5:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB8B6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB8B7;
                    goto case 0xB8B7;
                case 0xB8B7:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB8C1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB8C1; }
                    PC = 0xB8B9; goto case 0xB8B9;
                case 0xB8B8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB8B9;
                    goto case 0xB8B9;
                case 0xB8B9:
                    TotalCycles += 7; PushU16(0xB8BB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB8BA:
                    TotalCycles += 6; PushU16(0xB8BC); PC = 0xF1AF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB8BC:
                    Sbc(ReadMem(ReadU16Zp(0xAD) + Y)); TotalCycles += 5; PC = 0xB8BE;
                    return;
                case 0xB8BD:
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xB8C0;
                    goto case 0xB8C0;
                case 0xB8C0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB902; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB902; }
                    PC = 0xB8C2; goto case 0xB8C2;
                case 0xB8C1:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xB8C2:
                    A = _ram[0x070E]; SetZN(A); TotalCycles += 4; PC = 0xB8C5;
                    goto case 0xB8C5;
                case 0xB8C3:
                    { int a = 0xF007; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB8C6;
                    return;
                case 0xB8C5:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB902; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB902; }
                    PC = 0xB8C7; goto case 0xB8C7;
                case 0xB8C7: // === SUBROUTINE: Sub_B8C7 ===
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xB8C8;
                    goto case 0xB8C8;
                case 0xB8C8:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB8C9;
                    goto case 0xB8C9;
                case 0xB8C9:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB8CA;
                    goto case 0xB8CA;
                case 0xB8CA:
                    A &= 0x02; SetZN(A); TotalCycles += 2; PC = 0xB8CC;
                    goto case 0xB8CC;
                case 0xB8CC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB8D5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB8D5; }
                    PC = 0xB8CE; goto case 0xB8CE;
                case 0xB8CE:
                    _ram[0xCE] = IncVal(_ram[0xCE]); TotalCycles += 5; PC = 0xB8D0;
                    goto case 0xB8D0;
                case 0xB8CF:
                    { int a = 0xCEE6; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB8D2;
                    goto case 0xB8D2;
                case 0xB8D0:
                    _ram[0xCE] = IncVal(_ram[0xCE]); TotalCycles += 5; PC = 0xB8D2;
                    goto case 0xB8D2;
                case 0xB8D1:
                    { int a = 0xD94C; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB8D4;
                    goto case 0xB8D4;
                case 0xB8D2:
                    TotalCycles += 3; PC = 0xB8D9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB8D9;
                case 0xB8D3:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x46B8 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xB8D6;
                    goto case 0xB8D6;
                case 0xB8D4:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xB8D5;
                    goto case 0xB8D5;
                case 0xB8D5:
                    _ram[0xCE] = DecVal(_ram[0xCE]); TotalCycles += 5; PC = 0xB8D7;
                    goto case 0xB8D7;
                case 0xB8D6:
                    { int a = 0xCEC6; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB8D9;
                    goto case 0xB8D9;
                case 0xB8D7:
                    _ram[0xCE] = DecVal(_ram[0xCE]); TotalCycles += 5; PC = 0xB8D9;
                    goto case 0xB8D9;
                case 0xB8D8:
                    { int a = 0x58B5; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xB8DB;
                    goto case 0xB8DB;
                case 0xB8D9:
                    A = _ram[(byte)(0x58 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB8DB;
                    goto case 0xB8DB;
                case 0xB8DA:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xB8DB;
                    goto case 0xB8DB;
                case 0xB8DB:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xB8DC;
                    goto case 0xB8DC;
                case 0xB8DC:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x38B6 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xB8DF;
                    goto case 0xB8DF;
                case 0xB8DD:
                    X = _ram[(byte)(0xB8 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xB8DF;
                    goto case 0xB8DF;
                case 0xB8DE:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0xB8DF;
                    goto case 0xB8DF;
                case 0xB8DF:
                    _ram[(byte)(0xCF + X)] = A; TotalCycles += 4; PC = 0xB8E1;
                    goto case 0xB8E1;
                case 0xB8E1:
                    Cmp(Y, 0x01); TotalCycles += 2; PC = 0xB8E3;
                    goto case 0xB8E3;
                case 0xB8E2:
                    A |= ReadMem(ReadU16Zp((byte)(0x90 + X))); SetZN(A); TotalCycles += 6; PC = 0xB8E4;
                    return;
                case 0xB8E3:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB8F4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB8F4; }
                    PC = 0xB8E5; goto case 0xB8E5;
                case 0xB8E5:
                    A = _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0xB8E7;
                    goto case 0xB8E7;
                case 0xB8E6:
                    A = Asl(A); TotalCycles += 2; PC = 0xB8E7;
                    goto case 0xB8E7;
                case 0xB8E7:
                    A &= 0x80; SetZN(A); TotalCycles += 2; PC = 0xB8E9;
                    goto case 0xB8E9;
                case 0xB8E9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB8F4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB8F4; }
                    PC = 0xB8EB; goto case 0xB8EB;
                case 0xB8EA:
                    A |= 0x25; SetZN(A); TotalCycles += 2; PC = 0xB8EC;
                    goto case 0xB8EC;
                case 0xB8EB:
                    A &= _ram[0x0D]; SetZN(A); TotalCycles += 3; PC = 0xB8ED;
                    goto case 0xB8ED;
                case 0xB8EC:
                    A |= _ram[0x05D0]; SetZN(A); TotalCycles += 4; PC = 0xB8EF;
                    goto case 0xB8EF;
                case 0xB8ED:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB8F4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB8F4; }
                    PC = 0xB8EF; goto case 0xB8EF;
                case 0xB8EE:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xB8F0;
                    return;
                case 0xB8EF:
                    A = 0xF4; SetZN(A); TotalCycles += 2; PC = 0xB8F1;
                    goto case 0xB8F1;
                case 0xB8F1:
                    _ram[0x06DB] = A; TotalCycles += 4; PC = 0xB8F4;
                    goto case 0xB8F4;
                case 0xB8F3:
                    _ram[0xC0] = Asl(_ram[0xC0]); TotalCycles += 5; PC = 0xB8F5;
                    return;
                case 0xB8F4:
                    Cmp(Y, 0x03); TotalCycles += 2; PC = 0xB8F6;
                    goto case 0xB8F6;
                case 0xB8F6:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB902; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB902; }
                    PC = 0xB8F8; goto case 0xB8F8;
                case 0xB8F7:
                    A = Asl(A); TotalCycles += 2; PC = 0xB8F8;
                    goto case 0xB8F8;
                case 0xB8F8:
                    A = _ram[0x06DB]; SetZN(A); TotalCycles += 4; PC = 0xB8FB;
                    goto case 0xB8FB;
                case 0xB8FA:
                    _ram[0x85] = Asl(_ram[0x85]); TotalCycles += 5; PC = 0xB8FC;
                    return;
                case 0xB8FB:
                    _ram[0x9F] = A; TotalCycles += 3; PC = 0xB8FD;
                    goto case 0xB8FD;
                case 0xB8FD:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xB8FF;
                    goto case 0xB8FF;
                case 0xB8FE:
                    TotalCycles += 7; PushU16(0xB900); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB8FF:
                    _ram[0x070E] = A; TotalCycles += 4; PC = 0xB902;
                    goto case 0xB902;
                case 0xB900:
                    { int a = 0x2007; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB903;
                    return;
                case 0xB902:
                    TotalCycles += 6; PushU16(0xB904); PC = 0xF152;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB904:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xB906;
                    goto case 0xB906;
                case 0xB905:
                    TotalCycles += 6; PushU16(0xB907); PC = 0xE87D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB906:
                    Adc(ReadMem(0x20E8 + X)); TotalCycles += 4; PC = 0xB909;
                    return;
                case 0xB907:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xB908;
                    goto case 0xB908;
                case 0xB908:
                    TotalCycles += 6; PushU16(0xB90A); PC = 0xD67A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB90A:
                    { byte z = (byte)(0xAD + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xB90C;
                    goto case 0xB90C;
                case 0xB90B:
                    A = _ram[0x070E]; SetZN(A); TotalCycles += 4; PC = 0xB90E;
                    goto case 0xB90E;
                case 0xB90C:
                    { int a = 0xF007; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB90F;
                    goto case 0xB90F;
                case 0xB90E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB91D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB91D; }
                    PC = 0xB910; goto case 0xB910;
                case 0xB90F:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x06AD]; SetZN(A); TotalCycles += 4; PC = 0xB912;
                    return;
                case 0xB910:
                    A = _ram[0x0786]; SetZN(A); TotalCycles += 4; PC = 0xB913;
                    goto case 0xB913;
                case 0xB911:
                    _ram[0x07] = X; TotalCycles += 3; PC = 0xB913;
                    goto case 0xB913;
                case 0xB913:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB91D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB91D; }
                    PC = 0xB915; goto case 0xB915;
                case 0xB914:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB915;
                    goto case 0xB915;
                case 0xB915:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xB917;
                    goto case 0xB917;
                case 0xB917:
                    _ram[0x0786] = A; TotalCycles += 4; PC = 0xB91A;
                    goto case 0xB91A;
                case 0xB918:
                    _ram[0x07] = X; TotalCycles += 3; PC = 0xB91A;
                    goto case 0xB91A;
                case 0xB91A:
                    _ram[0x070E] = IncVal(_ram[0x070E]); TotalCycles += 6; PC = 0xB91D;
                    goto case 0xB91D;
                case 0xB91B:
                    { int a = 0x6007; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB91E;
                    goto case 0xB91E;
                case 0xB91D:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB91E: // === SUBROUTINE: Sub_B91E ===
                    A = 0x2F; SetZN(A); TotalCycles += 2; PC = 0xB920;
                    goto case 0xB920;
                case 0xB920:
                    _ram[(byte)(0x16 + X)] = A; TotalCycles += 4; PC = 0xB922;
                    goto case 0xB922;
                case 0xB921:
                    { byte z = (byte)(0xA9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xB923;
                    goto case 0xB923;
                case 0xB922:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB924;
                    goto case 0xB924;
                case 0xB923:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xB925;
                    return;
                case 0xB924:
                    _ram[(byte)(0x0F + X)] = A; TotalCycles += 4; PC = 0xB926;
                    goto case 0xB926;
                case 0xB926:
                    A = _ram[(0x0076 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB929;
                    goto case 0xB929;
                case 0xB927:
                    { byte z = (byte)(0x00 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xB929;
                    goto case 0xB929;
                case 0xB928:
                    TotalCycles += 7; PushU16(0xB92A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB929:
                    _ram[(byte)(0x6E + X)] = A; TotalCycles += 4; PC = 0xB92B;
                    goto case 0xB92B;
                case 0xB92A:
                    { int a = 0x8FB9; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xB92D;
                    goto case 0xB92D;
                case 0xB92B:
                    A = _ram[(0x008F + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB92E;
                    goto case 0xB92E;
                case 0xB92D:
                    TotalCycles += 7; PushU16(0xB92F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB92E:
                    _ram[(byte)(0x87 + X)] = A; TotalCycles += 4; PC = 0xB930;
                    goto case 0xB930;
                case 0xB930:
                    A = _ram[(0x00D7 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB933;
                    goto case 0xB933;
                case 0xB932:
                    TotalCycles += 7; PushU16(0xB934); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB933:
                    _ram[(byte)(0xCF + X)] = A; TotalCycles += 4; PC = 0xB935;
                    goto case 0xB935;
                case 0xB935:
                    Y = _ram[0x0398]; SetZN(Y); TotalCycles += 4; PC = 0xB938;
                    goto case 0xB938;
                case 0xB936:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB937;
                    return;
                case 0xB938:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB93D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB93D; }
                    PC = 0xB93A; goto case 0xB93A;
                case 0xB93A:
                    _ram[0x039D] = A; TotalCycles += 4; PC = 0xB93D;
                    goto case 0xB93D;
                case 0xB93B:
                    WriteMem(0x8A03 + X, A); TotalCycles += 5; PC = 0xB93E;
                    goto case 0xB93E;
                case 0xB93D:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xB93E;
                    goto case 0xB93E;
                case 0xB93E:
                    _ram[(0x039A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xB941;
                    goto case 0xB941;
                case 0xB93F:
                    SP = X; TotalCycles += 2; PC = 0xB940;
                    return;
                case 0xB941:
                    _ram[0x0398] = IncVal(_ram[0x0398]); TotalCycles += 6; PC = 0xB944;
                    goto case 0xB944;
                case 0xB942:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB943;
                    return;
                case 0xB944:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xB946;
                    goto case 0xB946;
                case 0xB946:
                    _ram[0xFE] = A; TotalCycles += 3; PC = 0xB948;
                    goto case 0xB948;
                case 0xB947:
                    { int a = 0x3060 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xB94A;
                    goto case 0xB94A;
                case 0xB948:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB949: // === SUBROUTINE: Sub_B949 ===
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xB9AB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB9AB; }
                    PC = 0xB94B; goto case 0xB94B;
                case 0xB94A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB94B:
                    Cmp(X, 0x05); TotalCycles += 2; PC = 0xB94D;
                    goto case 0xB94D;
                case 0xB94C:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xB94E;
                    goto case 0xB94E;
                case 0xB94D:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB9B7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB9B7; }
                    PC = 0xB94F; goto case 0xB94F;
                case 0xB94E:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xB94F;
                    goto case 0xB94F;
                case 0xB94F:
                    Y = _ram[0x0398]; SetZN(Y); TotalCycles += 4; PC = 0xB952;
                    goto case 0xB952;
                case 0xB950:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB951;
                    return;
                case 0xB952:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB953;
                    goto case 0xB953;
                case 0xB953:
                    A = _ram[0x0399]; SetZN(A); TotalCycles += 4; PC = 0xB956;
                    goto case 0xB956;
                case 0xB954:
                    WriteMem(0xD903 + Y, A); TotalCycles += 5; PC = 0xB957;
                    goto case 0xB957;
                case 0xB956:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x3949 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xB959;
                    goto case 0xB959;
                case 0xB957:
                    A ^= 0xB9; SetZN(A); TotalCycles += 2; PC = 0xB959;
                    goto case 0xB959;
                case 0xB958:
                    A = ReadMem(0x0FF0 + Y); SetZN(A); TotalCycles += 4; PC = 0xB95B;
                    goto case 0xB95B;
                case 0xB959:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB96A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB96A; }
                    PC = 0xB95B; goto case 0xB95B;
                case 0xB95B:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xB95D;
                    goto case 0xB95D;
                case 0xB95C:
                    A |= 0x4A; SetZN(A); TotalCycles += 2; PC = 0xB95E;
                    goto case 0xB95E;
                case 0xB95D:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB95E;
                    goto case 0xB95E;
                case 0xB95E:
                    A = Lsr(A); TotalCycles += 2; PC = 0xB95F;
                    goto case 0xB95F;
                case 0xB95F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB96A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB96A; }
                    PC = 0xB961; goto case 0xB961;
                case 0xB960:
                    A |= 0xA5; SetZN(A); TotalCycles += 2; PC = 0xB962;
                    return;
                case 0xB961:
                    A = _ram[0xD4]; SetZN(A); TotalCycles += 3; PC = 0xB963;
                    goto case 0xB963;
                case 0xB963:
                    Sbc(0x01); TotalCycles += 2; PC = 0xB965;
                    goto case 0xB965;
                case 0xB964:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xB966;
                    return;
                case 0xB965:
                    _ram[0xD4] = A; TotalCycles += 3; PC = 0xB967;
                    goto case 0xB967;
                case 0xB967:
                    _ram[0x0399] = IncVal(_ram[0x0399]); TotalCycles += 6; PC = 0xB96A;
                    goto case 0xB96A;
                case 0xB968:
                    WriteMem(0xAD03 + Y, A); TotalCycles += 5; PC = 0xB96B;
                    goto case 0xB96B;
                case 0xB96A:
                    A = _ram[0x0399]; SetZN(A); TotalCycles += 4; PC = 0xB96D;
                    goto case 0xB96D;
                case 0xB96B:
                    WriteMem(0xC903 + Y, A); TotalCycles += 5; PC = 0xB96E;
                    goto case 0xB96E;
                case 0xB96D:
                    Cmp(A, 0x08); TotalCycles += 2; PC = 0xB96F;
                    goto case 0xB96F;
                case 0xB96E:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB96F;
                    goto case 0xB96F;
                case 0xB96F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB9B7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB9B7; }
                    PC = 0xB971; goto case 0xB971;
                case 0xB970:
                    _ram[0x20] = Lsr(_ram[0x20]); TotalCycles += 5; PC = 0xB972;
                    return;
                case 0xB971:
                    TotalCycles += 6; PushU16(0xB973); PC = 0xF152;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB973:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xB975;
                    return;
                case 0xB974:
                    TotalCycles += 6; PushU16(0xB976); PC = 0xF1AF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB976:
                    Sbc(ReadMem(ReadU16Zp(0xA0) + Y)); TotalCycles += 5; PC = 0xB978;
                    goto case 0xB978;
                case 0xB977:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xB979;
                    goto case 0xB979;
                case 0xB978:
                    TotalCycles += 7; PushU16(0xB97A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB979:
                    TotalCycles += 6; PushU16(0xB97B); PC = 0xE435;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB97A:
                    A &= _ram[(byte)(0xE4 + X)]; SetZN(A); TotalCycles += 4; PC = 0xB97C;
                    goto case 0xB97C;
                case 0xB97B:
                    Cmp(X, _ram[0xC8]); TotalCycles += 3; PC = 0xB97D;
                    goto case 0xB97D;
                case 0xB97C:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xB97D;
                    goto case 0xB97D;
                case 0xB97D:
                    Cmp(Y, _ram[0x0398]); TotalCycles += 4; PC = 0xB980;
                    goto case 0xB980;
                case 0xB97E:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB97F;
                    return;
                case 0xB980:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB979; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB979; }
                    PC = 0xB982; goto case 0xB982;
                case 0xB982:
                    A = _ram[0x03D1]; SetZN(A); TotalCycles += 4; PC = 0xB985;
                    goto case 0xB985;
                case 0xB983:
                    Cmp(A, ReadMem(ReadU16Zp(0x03) + Y)); TotalCycles += 5; PC = 0xB985;
                    goto case 0xB985;
                case 0xB985:
                    A &= 0x0C; SetZN(A); TotalCycles += 2; PC = 0xB987;
                    goto case 0xB987;
                case 0xB987:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB999; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB999; }
                    PC = 0xB989; goto case 0xB989;
                case 0xB988:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB912; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB98A; goto case 0xB98A;
                case 0xB989:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB98A;
                    goto case 0xB98A;
                case 0xB98A:
                    X = _ram[(0x039A + Y) & 0x07FF]; SetZN(X); TotalCycles += 4; PC = 0xB98D;
                    goto case 0xB98D;
                case 0xB98B:
                    SP = X; TotalCycles += 2; PC = 0xB98C;
                    return;
                case 0xB98D:
                    TotalCycles += 6; PushU16(0xB98F); PC = 0xC998;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB98E:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB98F;
                    goto case 0xB98F;
                case 0xB98F:
                    Cmp(A, 0x88); TotalCycles += 2; PC = 0xB991;
                    goto case 0xB991;
                case 0xB990:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xB991;
                    goto case 0xB991;
                case 0xB991:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB98A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB98A; }
                    PC = 0xB993; goto case 0xB993;
                case 0xB993:
                    _ram[0x0398] = A; TotalCycles += 4; PC = 0xB996;
                    goto case 0xB996;
                case 0xB994:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xB995;
                    return;
                case 0xB996:
                    _ram[0x0399] = A; TotalCycles += 4; PC = 0xB999;
                    goto case 0xB999;
                case 0xB997:
                    WriteMem(0xAD03 + Y, A); TotalCycles += 5; PC = 0xB99A;
                    goto case 0xB99A;
                case 0xB999:
                    A = _ram[0x0399]; SetZN(A); TotalCycles += 4; PC = 0xB99C;
                    goto case 0xB99C;
                case 0xB99A:
                    WriteMem(0xC903 + Y, A); TotalCycles += 5; PC = 0xB99D;
                    goto case 0xB99D;
                case 0xB99C:
                    Cmp(A, 0x20); TotalCycles += 2; PC = 0xB99E;
                    goto case 0xB99E;
                case 0xB99D:
                    TotalCycles += 6; PushU16(0xB99F); PC = 0x1790;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB99E:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xB9B7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB9B7; }
                    PC = 0xB9A0; goto case 0xB9A0;
                case 0xB9A0:
                    X = 0x06; SetZN(X); TotalCycles += 2; PC = 0xB9A2;
                    goto case 0xB9A2;
                case 0xB9A1:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xB9A3;
                    goto case 0xB9A3;
                case 0xB9A2:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xB9A4;
                    goto case 0xB9A4;
                case 0xB9A3:
                    A |= ReadMem(ReadU16Zp((byte)(0xA0 + X))); SetZN(A); TotalCycles += 6; PC = 0xB9A5;
                    return;
                case 0xB9A4:
                    Y = 0x1B; SetZN(Y); TotalCycles += 2; PC = 0xB9A6;
                    goto case 0xB9A6;
                case 0xB9A6:
                    TotalCycles += 6; PushU16(0xB9A8); PC = 0xE3F0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xB9A7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB98C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xB9A9; goto case 0xB9A9;
                case 0xB9A9:
                    Y = _ram[0x02]; SetZN(Y); TotalCycles += 3; PC = 0xB9AB;
                    goto case 0xB9AB;
                case 0xB9AB:
                    Cmp(Y, 0xD0); TotalCycles += 2; PC = 0xB9AD;
                    goto case 0xB9AD;
                case 0xB9AC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB95E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB95E; }
                    PC = 0xB9AE; goto case 0xB9AE;
                case 0xB9AD:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xB9B7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB9B7; }
                    PC = 0xB9AF; goto case 0xB9AF;
                case 0xB9AE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB9AF;
                    goto case 0xB9AF;
                case 0xB9AF:
                    A = ReadMem(ReadU16Zp(0x06) + Y); SetZN(A); TotalCycles += 5; PC = 0xB9B1;
                    goto case 0xB9B1;
                case 0xB9B0:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xB9B2;
                    return;
                case 0xB9B1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xB9B7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB9B7; }
                    PC = 0xB9B3; goto case 0xB9B3;
                case 0xB9B3:
                    A = 0x26; SetZN(A); TotalCycles += 2; PC = 0xB9B5;
                    goto case 0xB9B5;
                case 0xB9B4:
                    _ram[0x91] = Rol(_ram[0x91]); TotalCycles += 5; PC = 0xB9B6;
                    goto case 0xB9B6;
                case 0xB9B5:
                    WriteMem(ReadU16Zp(0x06) + Y, A); TotalCycles += 6; PC = 0xB9B7;
                    goto case 0xB9B7;
                case 0xB9B6:
                    _ram[0xA6] = Asl(_ram[0xA6]); TotalCycles += 5; PC = 0xB9B8;
                    goto case 0xB9B8;
                case 0xB9B7:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xB9B9;
                    goto case 0xB9B9;
                case 0xB9B8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB9B9;
                    goto case 0xB9B9;
                case 0xB9B9:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xB9BC: // === SUBROUTINE: Sub_B9BC ===
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0xB9BF;
                    goto case 0xB9BF;
                case 0xB9BD:
                    { int a = 0xF007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0xB9C0;
                    return;
                case 0xB9BF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBA30; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA30; }
                    PC = 0xB9C1; goto case 0xB9C1;
                case 0xB9C1:
                    X = 0x02; SetZN(X); TotalCycles += 2; PC = 0xB9C3;
                    goto case 0xB9C3;
                case 0xB9C3:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xB9C5;
                    goto case 0xB9C5;
                case 0xB9C4:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB9C5;
                    goto case 0xB9C5;
                case 0xB9C5:
                    A = _ram[(byte)(0x0F + X)]; SetZN(A); TotalCycles += 4; PC = 0xB9C7;
                    goto case 0xB9C7;
                case 0xB9C7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBA1A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA1A; }
                    PC = 0xB9C9; goto case 0xB9C9;
                case 0xB9C8:
                    A ^= ReadMem(ReadU16Zp(0xBD) + Y); SetZN(A); TotalCycles += 5; PC = 0xB9CA;
                    goto case 0xB9CA;
                case 0xB9C9:
                    A = _ram[(0x07A8 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB9CC;
                    goto case 0xB9CC;
                case 0xB9CA:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xB9CB;
                    return;
                case 0xB9CC:
                    Y = _ram[0x06CC]; SetZN(Y); TotalCycles += 4; PC = 0xB9CF;
                    goto case 0xB9CF;
                case 0xB9CD:
                    Cmp(Y, ReadIoReg(0x3906)); TotalCycles += 4; PC = 0xB9D0;
                    goto case 0xB9D0;
                case 0xB9CE:
                    _ram[0x39] = Asl(_ram[0x39]); TotalCycles += 5; PC = 0xB9D0;
                    goto case 0xB9D0;
                case 0xB9CF:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x39BA + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xB9D2;
                    goto case 0xB9D2;
                case 0xB9D0:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xB9D1;
                    goto case 0xB9D1;
                case 0xB9D1:
                    A = _ram[(0x06C9 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB9D4;
                    goto case 0xB9D4;
                case 0xB9D2:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0xB9D4;
                    goto case 0xB9D4;
                case 0xB9D3:
                    _ram[0xB0] = Asl(_ram[0xB0]); TotalCycles += 5; PC = 0xB9D5;
                    return;
                case 0xB9D4:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xBA1A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA1A; }
                    PC = 0xB9D6; goto case 0xB9D6;
                case 0xB9D6:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xB9D7;
                    goto case 0xB9D7;
                case 0xB9D7:
                    A = _ram[(0x046B + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB9DA;
                    goto case 0xB9DA;
                case 0xB9DA:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBA1A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA1A; }
                    PC = 0xB9DC; goto case 0xB9DC;
                case 0xB9DB:
                    { int a = 0x7DB9 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xB9DE;
                    return;
                case 0xB9DC:
                    A = _ram[(0x047D + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB9DF;
                    goto case 0xB9DF;
                case 0xB9DD:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x7004 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xB9E0;
                    goto case 0xB9E0;
                case 0xB9DF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xB9E9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB9E9; }
                    PC = 0xB9E1; goto case 0xB9E1;
                case 0xB9E0:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xB9E1;
                    goto case 0xB9E1;
                case 0xB9E1:
                    Sbc(0x00); TotalCycles += 2; PC = 0xB9E3;
                    goto case 0xB9E3;
                case 0xB9E2:
                    TotalCycles += 7; PushU16(0xB9E4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xB9E3:
                    _ram[(0x047D + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xB9E6;
                    goto case 0xB9E6;
                case 0xB9E4:
                    Adc(ReadMem(0x4C04 + X)); TotalCycles += 4; PC = 0xB9E7;
                    return;
                case 0xB9E6:
                    TotalCycles += 3; PC = 0xBA1A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBA1A;
                case 0xB9E8:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xB9E9;
                    goto case 0xB9E9;
                case 0xB9E9:
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xB9EC;
                    goto case 0xB9EC;
                case 0xB9EC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBA1A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA1A; }
                    PC = 0xB9EE; goto case 0xB9EE;
                case 0xB9ED:
                    Bit(_ram[0x06A9]); TotalCycles += 4; PC = 0xB9F0;
                    goto case 0xB9F0;
                case 0xB9EE:
                    A = 0x0E; SetZN(A); TotalCycles += 2; PC = 0xB9F0;
                    goto case 0xB9F0;
                case 0xB9EF:
                    { int a = 0x7D99; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xB9F2;
                    return;
                case 0xB9F0:
                    _ram[(0x047D + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xB9F3;
                    goto case 0xB9F3;
                case 0xB9F1:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x3904 + X) & 0x7FFF]); TotalCycles += 4; PC = 0xB9F4;
                    return;
                case 0xB9F3:
                    A = _ram[(0x046B + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB9F6;
                    goto case 0xB9F6;
                case 0xB9F6:
                    _ram[(byte)(0x6E + X)] = A; TotalCycles += 4; PC = 0xB9F8;
                    goto case 0xB9F8;
                case 0xB9F7:
                    { int a = 0x71B9; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xB9FA;
                    return;
                case 0xB9F8:
                    A = _ram[(0x0471 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xB9FB;
                    goto case 0xB9FB;
                case 0xB9F9:
                    Adc(ReadMem(ReadU16Zp(0x04) + Y)); TotalCycles += 5; PC = 0xB9FB;
                    goto case 0xB9FB;
                case 0xB9FB:
                    _ram[(byte)(0x87 + X)] = A; TotalCycles += 4; PC = 0xB9FD;
                    goto case 0xB9FD;
                case 0xB9FD:
                    A = _ram[(0x0477 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBA00;
                    goto case 0xBA00;
                case 0xBA00:
                    P |= FlagC; TotalCycles += 2; PC = 0xBA01;
                    goto case 0xBA01;
                case 0xBA01:
                    Sbc(0x08); TotalCycles += 2; PC = 0xBA03;
                    goto case 0xBA03;
                case 0xBA02:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBA03;
                    goto case 0xBA03;
                case 0xBA03:
                    _ram[(byte)(0xCF + X)] = A; TotalCycles += 4; PC = 0xBA05;
                    goto case 0xBA05;
                case 0xBA05:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBA07;
                    goto case 0xBA07;
                case 0xBA06:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xBA08;
                    goto case 0xBA08;
                case 0xBA07:
                    _ram[(byte)(0xB6 + X)] = A; TotalCycles += 4; PC = 0xBA09;
                    goto case 0xBA09;
                case 0xBA08:
                    X = _ram[(byte)(0x95 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xBA0A;
                    return;
                case 0xBA09:
                    _ram[(byte)(0x0F + X)] = A; TotalCycles += 4; PC = 0xBA0B;
                    goto case 0xBA0B;
                case 0xBA0B:
                    A = Lsr(A); TotalCycles += 2; PC = 0xBA0C;
                    goto case 0xBA0C;
                case 0xBA0C:
                    _ram[(byte)(0x1E + X)] = A; TotalCycles += 4; PC = 0xBA0E;
                    goto case 0xBA0E;
                case 0xBA0D:
                    { int a = 0x09A9 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xBA10;
                    goto case 0xBA10;
                case 0xBA0E:
                    A = 0x09; SetZN(A); TotalCycles += 2; PC = 0xBA10;
                    goto case 0xBA10;
                case 0xBA0F:
                    A |= 0x9D; SetZN(A); TotalCycles += 2; PC = 0xBA11;
                    goto case 0xBA11;
                case 0xBA10:
                    _ram[(0x049A + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBA13;
                    goto case 0xBA13;
                case 0xBA11:
                    SP = X; TotalCycles += 2; PC = 0xBA12;
                    return;
                case 0xBA13:
                    A = 0x33; SetZN(A); TotalCycles += 2; PC = 0xBA15;
                    goto case 0xBA15;
                case 0xBA15:
                    _ram[(byte)(0x16 + X)] = A; TotalCycles += 4; PC = 0xBA17;
                    goto case 0xBA17;
                case 0xBA16:
                    { byte z = (byte)(0x4C + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xBA18;
                    goto case 0xBA18;
                case 0xBA17:
                    TotalCycles += 3; PC = 0xBA2D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBA2D;
                case 0xBA18:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x35BA]; SetZN(A); TotalCycles += 4; PC = 0xBA1B;
                    goto case 0xBA1B;
                case 0xBA19:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xBA1A;
                    goto case 0xBA1A;
                case 0xBA1A:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBA1C;
                    goto case 0xBA1C;
                case 0xBA1B:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xBA1D;
                    return;
                case 0xBA1C:
                    Cmp(A, 0x33); TotalCycles += 2; PC = 0xBA1E;
                    goto case 0xBA1E;
                case 0xBA1E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBA2D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA2D; }
                    PC = 0xBA20; goto case 0xBA20;
                case 0xBA1F:
                    A |= ReadIoReg(0x7A20); SetZN(A); TotalCycles += 4; PC = 0xBA22;
                    goto case 0xBA22;
                case 0xBA20:
                    TotalCycles += 6; PushU16(0xBA22); PC = 0xD67A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA22:
                    { byte z = (byte)(0xB5 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xBA24;
                    return;
                case 0xBA23:
                    A = _ram[(byte)(0x0F + X)]; SetZN(A); TotalCycles += 4; PC = 0xBA25;
                    goto case 0xBA25;
                case 0xBA25:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBA2D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA2D; }
                    PC = 0xBA27; goto case 0xBA27;
                case 0xBA26:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xBA28;
                    return;
                case 0xBA27:
                    TotalCycles += 6; PushU16(0xBA29); PC = 0xF1AF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA29:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBA2B;
                    return;
                case 0xBA2A:
                    TotalCycles += 6; PushU16(0xBA2C); PC = 0xBA33;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBA33;
                case 0xBA2C:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xBA2D;
                    goto case 0xBA2D;
                case 0xBA2D:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xBA2E;
                    goto case 0xBA2E;
                case 0xBA2E:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xB9C3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB9C3; }
                    PC = 0xBA30; goto case 0xBA30;
                case 0xBA30:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBA31: // === SUBROUTINE: Sub_BA31 ===
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBA32;
                    goto case 0xBA32;
                case 0xBA32:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xBA33;
                    goto case 0xBA33;
                case 0xBA33: // === SUBROUTINE: Sub_BA33 ===
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xBA36;
                    goto case 0xBA36;
                case 0xBA36:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBA76; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA76; }
                    PC = 0xBA38; goto case 0xBA38;
                case 0xBA37:
                    { int a = 0x1EB5 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xBA3A;
                    goto case 0xBA3A;
                case 0xBA38:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xBA3A;
                    goto case 0xBA3A;
                case 0xBA39:
                    { int a = 0x2ED0 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xBA3C;
                    goto case 0xBA3C;
                case 0xBA3A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBA6A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA6A; }
                    PC = 0xBA3C; goto case 0xBA3C;
                case 0xBA3B:
                    { int a = 0xD1AD; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0xBA3E;
                    return;
                case 0xBA3C:
                    A = _ram[0x03D1]; SetZN(A); TotalCycles += 4; PC = 0xBA3F;
                    goto case 0xBA3F;
                case 0xBA3D:
                    Cmp(A, ReadMem(ReadU16Zp(0x03) + Y)); TotalCycles += 5; PC = 0xBA3F;
                    goto case 0xBA3F;
                case 0xBA3F:
                    A &= 0x0C; SetZN(A); TotalCycles += 2; PC = 0xBA41;
                    goto case 0xBA41;
                case 0xBA41:
                    Cmp(A, 0x0C); TotalCycles += 2; PC = 0xBA43;
                    goto case 0xBA43;
                case 0xBA43:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBA85; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA85; }
                    PC = 0xBA45; goto case 0xBA45;
                case 0xBA44:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xBA45:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xBA47;
                    goto case 0xBA47;
                case 0xBA46:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xBA48;
                    return;
                case 0xBA47:
                    TotalCycles += 6; PushU16(0xBA49); PC = 0xE143;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA49:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x30 + X)))); TotalCycles += 6; PC = 0xBA4B;
                    goto case 0xBA4B;
                case 0xBA4A:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xBA4D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA4D; }
                    PC = 0xBA4C; goto case 0xBA4C;
                case 0xBA4B:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xBA4D;
                    goto case 0xBA4D;
                case 0xBA4C:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xBA4D;
                    goto case 0xBA4D;
                case 0xBA4D:
                    _ram[(byte)(0x46 + X)] = Y; TotalCycles += 4; PC = 0xBA4F;
                    goto case 0xBA4F;
                case 0xBA4E:
                    _ram[0x88] = Lsr(_ram[0x88]); TotalCycles += 5; PC = 0xBA50;
                    goto case 0xBA50;
                case 0xBA4F:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xBA50;
                    goto case 0xBA50;
                case 0xBA50:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3A31 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBA53;
                    goto case 0xBA53;
                case 0xBA51:
                    A &= ReadMem(ReadU16Zp(0xBA) + Y); SetZN(A); TotalCycles += 5; PC = 0xBA53;
                    goto case 0xBA53;
                case 0xBA52:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xBA53;
                    goto case 0xBA53;
                case 0xBA53:
                    _ram[(byte)(0x58 + X)] = A; TotalCycles += 4; PC = 0xBA55;
                    goto case 0xBA55;
                case 0xBA54:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xBA55;
                    goto case 0xBA55;
                case 0xBA55:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0xBA57;
                    goto case 0xBA57;
                case 0xBA56:
                    TotalCycles += 7; PushU16(0xBA58); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBA57:
                    Adc(0x28); TotalCycles += 2; PC = 0xBA59;
                    goto case 0xBA59;
                case 0xBA58:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xBA59;
                    goto case 0xBA59;
                case 0xBA59:
                    Cmp(A, 0x50); TotalCycles += 2; PC = 0xBA5B;
                    goto case 0xBA5B;
                case 0xBA5A:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xB9EC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xB9EC; }
                    PC = 0xBA5C; goto case 0xBA5C;
                case 0xBA5B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBA85; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA85; }
                    PC = 0xBA5D; goto case 0xBA5D;
                case 0xBA5C:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xBA5D;
                    goto case 0xBA5D;
                case 0xBA5D:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBA5F;
                    goto case 0xBA5F;
                case 0xBA5E:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xBA60;
                    goto case 0xBA60;
                case 0xBA5F:
                    _ram[(byte)(0x1E + X)] = A; TotalCycles += 4; PC = 0xBA61;
                    goto case 0xBA61;
                case 0xBA60:
                    { int a = 0x0AA9 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xBA63;
                    goto case 0xBA63;
                case 0xBA61:
                    A = 0x0A; SetZN(A); TotalCycles += 2; PC = 0xBA63;
                    goto case 0xBA63;
                case 0xBA62:
                    A = Asl(A); TotalCycles += 2; PC = 0xBA63;
                    goto case 0xBA63;
                case 0xBA63:
                    _ram[(0x078A + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBA66;
                    goto case 0xBA66;
                case 0xBA64:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xBA65;
                    return;
                case 0xBA66:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0xBA68;
                    goto case 0xBA68;
                case 0xBA67:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBA68;
                    goto case 0xBA68;
                case 0xBA68:
                    _ram[0xFE] = A; TotalCycles += 3; PC = 0xBA6A;
                    goto case 0xBA6A;
                case 0xBA69:
                    { int a = 0x1EB5 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xBA6C;
                    goto case 0xBA6C;
                case 0xBA6A:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xBA6C;
                    goto case 0xBA6C;
                case 0xBA6B:
                    { int a = 0x2029 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xBA6E;
                    goto case 0xBA6E;
                case 0xBA6C:
                    A &= 0x20; SetZN(A); TotalCycles += 2; PC = 0xBA6E;
                    goto case 0xBA6E;
                case 0xBA6D:
                    TotalCycles += 6; PushU16(0xBA6F); PC = 0x03F0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA6E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBA73; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA73; }
                    PC = 0xBA70; goto case 0xBA70;
                case 0xBA70:
                    TotalCycles += 6; PushU16(0xBA72); PC = 0xBF63;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF63;
                case 0xBA73:
                    TotalCycles += 6; PushU16(0xBA75); PC = 0xBF02;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF02;
                case 0xBA76:
                    TotalCycles += 6; PushU16(0xBA78); PC = 0xF1AF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA78:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBA7A;
                    return;
                case 0xBA79:
                    TotalCycles += 6; PushU16(0xBA7B); PC = 0xF152;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA7B:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBA7D;
                    return;
                case 0xBA7C:
                    TotalCycles += 6; PushU16(0xBA7E); PC = 0xE243;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA7F:
                    TotalCycles += 6; PushU16(0xBA81); PC = 0xD853;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA81:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xBA82;
                    goto case 0xBA82;
                case 0xBA82:
                    TotalCycles += 3; PC = 0xE87D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA83:
                    Adc(ReadMem(0x20E8 + X)); TotalCycles += 4; PC = 0xBA86;
                    goto case 0xBA86;
                case 0xBA84:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xBA85;
                    goto case 0xBA85;
                case 0xBA85:
                    TotalCycles += 6; PushU16(0xBA87); PC = 0xC998;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBA86:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xBA87;
                    goto case 0xBA87;
                case 0xBA87:
                    Cmp(A, 0x60); TotalCycles += 2; PC = 0xBA89;
                    return;
                case 0xBA88:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBA8C:
                    A |= _ram[0x05]; SetZN(A); TotalCycles += 3; PC = 0xBA8E;
                    goto case 0xBA8E;
                case 0xBA8D:
                    A |= _ram[0x05]; SetZN(A); TotalCycles += 3; PC = 0xBA8F;
                    goto case 0xBA8F;
                case 0xBA8E:
                    A |= _ram[0x06]; SetZN(A); TotalCycles += 3; PC = 0xBA90;
                    goto case 0xBA90;
                case 0xBA8F:
                    _ram[0x06] = Asl(_ram[0x06]); TotalCycles += 5; PC = 0xBA91;
                    goto case 0xBA91;
                case 0xBA90:
                    _ram[0x06] = Asl(_ram[0x06]); TotalCycles += 5; PC = 0xBA92;
                    goto case 0xBA92;
                case 0xBA91:
                    _ram[0x10] = Asl(_ram[0x10]); TotalCycles += 5; PC = 0xBA93;
                    goto case 0xBA93;
                case 0xBA92:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBA84; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA84; }
                    PC = 0xBA94; goto case 0xBA94;
                case 0xBA93:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBA42; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xBA95; goto case 0xBA95;
                case 0xBA94: // === SUBROUTINE: Sub_BA94 ===
                    A = _ram[0x07A8]; SetZN(A); TotalCycles += 4; PC = 0xBA97;
                    goto case 0xBA97;
                case 0xBA95:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBA96;
                    return;
                case 0xBA97:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0xBA99;
                    goto case 0xBA99;
                case 0xBA99:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBAA0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBAA0; }
                    PC = 0xBA9B; goto case 0xBA9B;
                case 0xBA9A:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0xBA9C;
                    goto case 0xBA9C;
                case 0xBA9B: // === SUBROUTINE: Sub_BA9B ===
                    A = _ram[0x07A8]; SetZN(A); TotalCycles += 4; PC = 0xBA9E;
                    goto case 0xBA9E;
                case 0xBA9C:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBA9D;
                    return;
                case 0xBA9E:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0xBAA0;
                    goto case 0xBAA0;
                case 0xBA9F:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBAA0;
                    goto case 0xBAA0;
                case 0xBAA0:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBAA1;
                    goto case 0xBAA1;
                case 0xBAA1:
                    A = _ram[(0x002A + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBAA4;
                    goto case 0xBAA4;
                case 0xBAA2:
                    A = Rol(A); TotalCycles += 2; PC = 0xBAA3;
                    goto case 0xBAA3;
                case 0xBAA3:
                    TotalCycles += 7; PushU16(0xBAA5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBAA4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBABF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBABF; }
                    PC = 0xBAA6; goto case 0xBAA6;
                case 0xBAA5:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x09BE + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBAA8;
                    goto case 0xBAA8;
                case 0xBAA6:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x3A89 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xBAA9;
                    goto case 0xBAA9;
                case 0xBAA8:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xBAA9;
                    goto case 0xBAA9;
                case 0xBAA9:
                    A = _ram[(byte)(0x0F + X)]; SetZN(A); TotalCycles += 4; PC = 0xBAAB;
                    goto case 0xBAAB;
                case 0xBAAB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBABF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBABF; }
                    PC = 0xBAAD; goto case 0xBAAD;
                case 0xBAAD:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBAAF;
                    goto case 0xBAAF;
                case 0xBAAE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBAAF;
                    goto case 0xBAAF;
                case 0xBAAF:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xBAB0;
                    goto case 0xBAB0;
                case 0xBAB0:
                    _ram[(0x06AE + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBAB3;
                    goto case 0xBAB3;
                case 0xBAB1:
                    X = SmbEmbeddedAssets.StaticDataTables[0x2906]; SetZN(X); TotalCycles += 4; PC = 0xBAB4;
                    goto case 0xBAB4;
                case 0xBAB2:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xBAB4;
                    goto case 0xBAB4;
                case 0xBAB3:
                    A = 0x90; SetZN(A); TotalCycles += 2; PC = 0xBAB5;
                    goto case 0xBAB5;
                case 0xBAB4:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBA4F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA4F; }
                    PC = 0xBAB6; goto case 0xBAB6;
                case 0xBAB5:
                    _ram[(0x002A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBAB8;
                    goto case 0xBAB8;
                case 0xBAB6:
                    A = Rol(A); TotalCycles += 2; PC = 0xBAB7;
                    goto case 0xBAB7;
                case 0xBAB7:
                    TotalCycles += 7; PushU16(0xBAB9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBAB8:
                    A = 0x07; SetZN(A); TotalCycles += 2; PC = 0xBABA;
                    goto case 0xBABA;
                case 0xBABA:
                    _ram[(0x04A2 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBABD;
                    goto case 0xBABD;
                case 0xBABB:
                    X = 0x04; SetZN(X); TotalCycles += 2; PC = 0xBABD;
                    goto case 0xBABD;
                case 0xBABD:
                    P |= FlagC; TotalCycles += 2; PC = 0xBABE;
                    goto case 0xBABE;
                case 0xBABE:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBABF:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBAC1;
                    goto case 0xBAC1;
                case 0xBAC0:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBAC1;
                    goto case 0xBAC1;
                case 0xBAC1:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBAC2;
                    goto case 0xBAC2;
                case 0xBAC2:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBAC3: // === SUBROUTINE: Sub_BAC3 ===
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xBAC6;
                    goto case 0xBAC6;
                case 0xBAC6:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBB2B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBB2B; }
                    PC = 0xBAC8; goto case 0xBAC8;
                case 0xBAC8:
                    A = _ram[(byte)(0x2A + X)]; SetZN(A); TotalCycles += 4; PC = 0xBACA;
                    goto case 0xBACA;
                case 0xBAC9:
                    A = Rol(A); TotalCycles += 2; PC = 0xBACA;
                    goto case 0xBACA;
                case 0xBACA:
                    A &= 0x7F; SetZN(A); TotalCycles += 2; PC = 0xBACC;
                    goto case 0xBACC;
                case 0xBACC:
                    Y = _ram[(0x06AE + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xBACF;
                    goto case 0xBACF;
                case 0xBACD:
                    X = SmbEmbeddedAssets.StaticDataTables[0x4906]; SetZN(X); TotalCycles += 4; PC = 0xBAD0;
                    return;
                case 0xBACE:
                    _ram[0xC9] = Asl(_ram[0xC9]); TotalCycles += 5; PC = 0xBAD0;
                    return;
                case 0xBACF:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xBAD1;
                    goto case 0xBAD1;
                case 0xBAD1:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBAF3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBAF3; }
                    PC = 0xBAD3; goto case 0xBAD3;
                case 0xBAD2: // === SUBROUTINE: Sub_BAD2 ===
                    TotalCycles += 6; PushU16(0xBAD4); PC = 0x34B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBAD3:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xBB09; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBB09; }
                    PC = 0xBAD5; goto case 0xBAD5;
                case 0xBAD5:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xBAD6;
                    goto case 0xBAD6;
                case 0xBAD6:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBAD7;
                    goto case 0xBAD7;
                case 0xBAD7:
                    Adc(0x0D); TotalCycles += 2; PC = 0xBAD9;
                    goto case 0xBAD9;
                case 0xBAD8:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x29AA]; SetZN(A); TotalCycles += 4; PC = 0xBADB;
                    goto case 0xBADB;
                case 0xBAD9:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xBADA;
                    goto case 0xBADA;
                case 0xBADA:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0xBADC;
                    goto case 0xBADC;
                case 0xBADB:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBA62; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBA62; }
                    PC = 0xBADD; goto case 0xBADD;
                case 0xBADC:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xBADE;
                    goto case 0xBADE;
                case 0xBADD:
                    TotalCycles += 7; PushU16(0xBADF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBADE:
                    A = 0x0F; SetZN(A); TotalCycles += 2; PC = 0xBAE0;
                    goto case 0xBAE0;
                case 0xBAE0:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xBAE2;
                    goto case 0xBAE2;
                case 0xBAE1:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0xBAE3;
                    return;
                case 0xBAE2:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xBAE4;
                    goto case 0xBAE4;
                case 0xBAE4:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xBAE6;
                    goto case 0xBAE6;
                case 0xBAE6:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBAE8;
                    goto case 0xBAE8;
                case 0xBAE7:
                    TotalCycles += 7; PushU16(0xBAE9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBAE8:
                    TotalCycles += 6; PushU16(0xBAEA); PC = 0xBFD7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFD7;
                case 0xBAEB:
                    TotalCycles += 6; PushU16(0xBAED); PC = 0xBF0F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF0F;
                case 0xBAEE:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBAF0;
                    goto case 0xBAF0;
                case 0xBAEF:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBAF0;
                    goto case 0xBAF0;
                case 0xBAF0:
                    TotalCycles += 3; PC = 0xBB28;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBB28;
                case 0xBAF1:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0xBAF2;
                    return;
                case 0xBAF3:
                    A = 0xFE; SetZN(A); TotalCycles += 2; PC = 0xBAF5;
                    goto case 0xBAF5;
                case 0xBAF4:
                    { int a = 0xAC95 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xBAF7;
                    goto case 0xBAF7;
                case 0xBAF5:
                    _ram[(byte)(0xAC + X)] = A; TotalCycles += 4; PC = 0xBAF7;
                    goto case 0xBAF7;
                case 0xBAF6:
                    Y = _ram[0x06B9]; SetZN(Y); TotalCycles += 4; PC = 0xBAF9;
                    goto case 0xBAF9;
                case 0xBAF7:
                    A = _ram[(0x001E + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBAFA;
                    goto case 0xBAFA;
                case 0xBAF8:
                    { int a = 0x2900 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xBAFB;
                    return;
                case 0xBAF9:
                    TotalCycles += 7; PushU16(0xBAFB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBAFA:
                    A &= 0xF7; SetZN(A); TotalCycles += 2; PC = 0xBAFC;
                    goto case 0xBAFC;
                case 0xBAFC:
                    _ram[(0x001E + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBAFF;
                    goto case 0xBAFF;
                case 0xBAFD:
                    { int a = 0xB600 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xBB00;
                    goto case 0xBB00;
                case 0xBAFE:
                    TotalCycles += 7; PushU16(0xBB00); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBAFF:
                    X = _ram[(byte)(0x46 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xBB01;
                    goto case 0xBB01;
                case 0xBB00:
                    _ram[0xCA] = Lsr(_ram[0xCA]); TotalCycles += 5; PC = 0xBB02;
                    goto case 0xBB02;
                case 0xBB01:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xBB02;
                    goto case 0xBB02;
                case 0xBB02:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3A92 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBB05;
                    goto case 0xBB05;
                case 0xBB04:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xBB05;
                    goto case 0xBB05;
                case 0xBB05:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBB07;
                    goto case 0xBB07;
                case 0xBB06:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBB07;
                    goto case 0xBB07;
                case 0xBB07:
                    _ram[(byte)(0x64 + X)] = A; TotalCycles += 4; PC = 0xBB09;
                    goto case 0xBB09;
                case 0xBB09:
                    { byte z = (byte)(0x2A + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xBB0B;
                    goto case 0xBB0B;
                case 0xBB0A:
                    A = Rol(A); TotalCycles += 2; PC = 0xBB0B;
                    goto case 0xBB0B;
                case 0xBB0B:
                    A = _ram[(0x0087 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBB0E;
                    goto case 0xBB0E;
                case 0xBB0D:
                    TotalCycles += 7; PushU16(0xBB0F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB0E:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBB0F;
                    goto case 0xBB0F;
                case 0xBB0F:
                    Adc(0x02); TotalCycles += 2; PC = 0xBB11;
                    goto case 0xBB11;
                case 0xBB11:
                    _ram[(byte)(0x93 + X)] = A; TotalCycles += 4; PC = 0xBB13;
                    goto case 0xBB13;
                case 0xBB13:
                    A = _ram[(0x006E + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBB16;
                    goto case 0xBB16;
                case 0xBB14:
                    { int a = 0x6900; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0xBB17;
                    goto case 0xBB17;
                case 0xBB15:
                    TotalCycles += 7; PushU16(0xBB17); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB16:
                    Adc(0x00); TotalCycles += 2; PC = 0xBB18;
                    goto case 0xBB18;
                case 0xBB17:
                    TotalCycles += 7; PushU16(0xBB19); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB18:
                    _ram[(byte)(0x7A + X)] = A; TotalCycles += 4; PC = 0xBB1A;
                    goto case 0xBB1A;
                case 0xBB1A:
                    A = _ram[(0x00CF + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBB1D;
                    goto case 0xBB1D;
                case 0xBB1C:
                    TotalCycles += 7; PushU16(0xBB1E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB1D:
                    P |= FlagC; TotalCycles += 2; PC = 0xBB1E;
                    goto case 0xBB1E;
                case 0xBB1E:
                    Sbc(0x0A); TotalCycles += 2; PC = 0xBB20;
                    goto case 0xBB20;
                case 0xBB1F:
                    A = Asl(A); TotalCycles += 2; PC = 0xBB20;
                    goto case 0xBB20;
                case 0xBB20:
                    _ram[(byte)(0xDB + X)] = A; TotalCycles += 4; PC = 0xBB22;
                    goto case 0xBB22;
                case 0xBB22:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBB24;
                    goto case 0xBB24;
                case 0xBB23:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0xBB25;
                    return;
                case 0xBB24:
                    _ram[(byte)(0xC2 + X)] = A; TotalCycles += 4; PC = 0xBB26;
                    goto case 0xBB26;
                case 0xBB26:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBB2B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBB2B; }
                    PC = 0xBB28; goto case 0xBB28;
                case 0xBB28:
                    TotalCycles += 6; PushU16(0xBB2A); PC = 0xD7C4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBB29:
                    Cmp(Y, _ram[0xD7]); TotalCycles += 3; PC = 0xBB2B;
                    goto case 0xBB2B;
                case 0xBB2B:
                    TotalCycles += 6; PushU16(0xBB2D); PC = 0xF19B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBB2D:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBB2F;
                    goto case 0xBB2F;
                case 0xBB2E:
                    TotalCycles += 6; PushU16(0xBB30); PC = 0xF148;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBB2F:
                    PushU8(A); TotalCycles += 3; PC = 0xBB30;
                    goto case 0xBB30;
                case 0xBB30:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBB32;
                    goto case 0xBB32;
                case 0xBB31:
                    TotalCycles += 6; PushU16(0xBB33); PC = 0xE236;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBB32:
                    { byte z = (byte)(0xE2 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xBB34;
                    goto case 0xBB34;
                case 0xBB34:
                    TotalCycles += 6; PushU16(0xBB36); PC = 0xE4DC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBB36:
                    Cmp(X, _ram[0x60]); TotalCycles += 3; PC = 0xBB38;
                    goto case 0xBB38;
                case 0xBB37:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBB38: // === SUBROUTINE: Sub_BB38 ===
                    TotalCycles += 6; PushU16(0xBB3A); PC = 0xBB84;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBB84;
                case 0xBB39:
                    _ram[0xBB] = Y; TotalCycles += 3; PC = 0xBB3B;
                    goto case 0xBB3B;
                case 0xBB3B:
                    A = _ram[(byte)(0x76 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBB3D;
                    goto case 0xBB3D;
                case 0xBB3C:
                    { byte z = (byte)(0x99 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xBB3E;
                    return;
                case 0xBB3D:
                    _ram[(0x007A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBB40;
                    goto case 0xBB40;
                case 0xBB3F:
                    TotalCycles += 7; PushU16(0xBB41); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB40:
                    A = _ram[(byte)(0x8F + X)]; SetZN(A); TotalCycles += 4; PC = 0xBB42;
                    goto case 0xBB42;
                case 0xBB42:
                    A |= 0x05; SetZN(A); TotalCycles += 2; PC = 0xBB44;
                    goto case 0xBB44;
                case 0xBB43:
                    A |= _ram[0x99]; SetZN(A); TotalCycles += 3; PC = 0xBB45;
                    return;
                case 0xBB44:
                    _ram[(0x0093 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBB47;
                    goto case 0xBB47;
                case 0xBB46:
                    TotalCycles += 7; PushU16(0xBB48); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB47:
                    A = _ram[(byte)(0xD7 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBB49;
                    goto case 0xBB49;
                case 0xBB49:
                    Sbc(0x10); TotalCycles += 2; PC = 0xBB4B;
                    goto case 0xBB4B;
                case 0xBB4A:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBAE5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xBB4C; return;
                case 0xBB4B:
                    _ram[(0x00DB + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBB4E;
                    goto case 0xBB4E;
                case 0xBB4D:
                    TotalCycles += 7; PushU16(0xBB4F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB4E:
                    TotalCycles += 3; PC = 0xBB6C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBB6C;
                case 0xBB4F:
                    TotalCycles += 5; PC = ReadU16Zp(0xBB); return;
                case 0xBB51: // === SUBROUTINE: Sub_BB51 ===
                    TotalCycles += 6; PushU16(0xBB53); PC = 0xBB84;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBB84;
                case 0xBB52:
                    _ram[0xBB] = Y; TotalCycles += 3; PC = 0xBB54;
                    goto case 0xBB54;
                case 0xBB54:
                    A = _ram[(0x03EA + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBB57;
                    goto case 0xBB57;
                case 0xBB55:
                     TotalCycles += 2; PC = 0xBB56;
                    return;
                case 0xBB57:
                    _ram[(0x007A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBB5A;
                    goto case 0xBB5A;
                case 0xBB59:
                    TotalCycles += 7; PushU16(0xBB5B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB5A:
                    A = _ram[0x06]; SetZN(A); TotalCycles += 3; PC = 0xBB5C;
                    goto case 0xBB5C;
                case 0xBB5B:
                    _ram[0x0A] = Asl(_ram[0x0A]); TotalCycles += 5; PC = 0xBB5D;
                    goto case 0xBB5D;
                case 0xBB5C:
                    A = Asl(A); TotalCycles += 2; PC = 0xBB5D;
                    goto case 0xBB5D;
                case 0xBB5D:
                    A = Asl(A); TotalCycles += 2; PC = 0xBB5E;
                    goto case 0xBB5E;
                case 0xBB5E:
                    A = Asl(A); TotalCycles += 2; PC = 0xBB5F;
                    goto case 0xBB5F;
                case 0xBB5F:
                    A = Asl(A); TotalCycles += 2; PC = 0xBB60;
                    goto case 0xBB60;
                case 0xBB60:
                    A |= 0x05; SetZN(A); TotalCycles += 2; PC = 0xBB62;
                    goto case 0xBB62;
                case 0xBB61:
                    A |= _ram[0x99]; SetZN(A); TotalCycles += 3; PC = 0xBB63;
                    return;
                case 0xBB62:
                    _ram[(0x0093 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBB65;
                    goto case 0xBB65;
                case 0xBB64:
                    TotalCycles += 7; PushU16(0xBB66); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB65:
                    A = _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xBB67;
                    goto case 0xBB67;
                case 0xBB67:
                    Adc(0x20); TotalCycles += 2; PC = 0xBB69;
                    goto case 0xBB69;
                case 0xBB68:
                    TotalCycles += 6; PushU16(0xBB6A); PC = 0xDB99;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBB69:
                    _ram[(0x00DB + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBB6C;
                    goto case 0xBB6C;
                case 0xBB6B:
                    TotalCycles += 7; PushU16(0xBB6D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB6C:
                    A = 0xFB; SetZN(A); TotalCycles += 2; PC = 0xBB6E;
                    goto case 0xBB6E;
                case 0xBB6E:
                    _ram[(0x00AC + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBB71;
                    goto case 0xBB71;
                case 0xBB6F:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x2900]; SetZN(Y); TotalCycles += 4; PC = 0xBB72;
                    goto case 0xBB72;
                case 0xBB70:
                    TotalCycles += 7; PushU16(0xBB72); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB71:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBB73;
                    goto case 0xBB73;
                case 0xBB72:
                    A |= ReadMem(ReadU16Zp((byte)(0x99 + X))); SetZN(A); TotalCycles += 6; PC = 0xBB74;
                    return;
                case 0xBB73:
                    _ram[(0x00C2 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBB76;
                    goto case 0xBB76;
                case 0xBB75:
                    TotalCycles += 7; PushU16(0xBB77); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB76:
                    _ram[(0x002A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBB79;
                    goto case 0xBB79;
                case 0xBB77:
                    A = Rol(A); TotalCycles += 2; PC = 0xBB78;
                    goto case 0xBB78;
                case 0xBB78:
                    TotalCycles += 7; PushU16(0xBB7A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB79:
                    _ram[0xFE] = A; TotalCycles += 3; PC = 0xBB7B;
                    goto case 0xBB7B;
                case 0xBB7A:
                    { int a = 0x0886 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xBB7D;
                    goto case 0xBB7D;
                case 0xBB7B:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xBB7D;
                    goto case 0xBB7D;
                case 0xBB7C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBB7D;
                    goto case 0xBB7D;
                case 0xBB7D:
                    TotalCycles += 6; PushU16(0xBB7F); PC = 0xBBFE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBBFE;
                case 0xBB7E:
                    { int a = 0xEEBB + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xBB81;
                    goto case 0xBB81;
                case 0xBB80:
                    _ram[0x0748] = IncVal(_ram[0x0748]); TotalCycles += 6; PC = 0xBB83;
                    goto case 0xBB83;
                case 0xBB81:
                    PushU8(A); TotalCycles += 3; PC = 0xBB82;
                    return;
                case 0xBB83:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBB84: // === SUBROUTINE: Sub_BB84 ===
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0xBB86;
                    goto case 0xBB86;
                case 0xBB85:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBB86;
                    goto case 0xBB86;
                case 0xBB86:
                    A = _ram[(0x002A + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBB89;
                    goto case 0xBB89;
                case 0xBB87:
                    A = Rol(A); TotalCycles += 2; PC = 0xBB88;
                    goto case 0xBB88;
                case 0xBB88:
                    TotalCycles += 7; PushU16(0xBB8A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBB89:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBB92; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBB92; }
                    PC = 0xBB8B; goto case 0xBB8B;
                case 0xBB8B:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xBB8C;
                    goto case 0xBB8C;
                case 0xBB8C:
                    Cmp(Y, 0x05); TotalCycles += 2; PC = 0xBB8E;
                    goto case 0xBB8E;
                case 0xBB8D:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xBB8F;
                    goto case 0xBB8F;
                case 0xBB8E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBB86; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBB86; }
                    PC = 0xBB90; goto case 0xBB90;
                case 0xBB8F:
                    { byte z = (byte)(0xA0 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xBB91;
                    goto case 0xBB91;
                case 0xBB90:
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0xBB92;
                    goto case 0xBB92;
                case 0xBB91:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBB92;
                    goto case 0xBB92;
                case 0xBB92:
                    _ram[0x06B7] = Y; TotalCycles += 4; PC = 0xBB95;
                    goto case 0xBB95;
                case 0xBB94:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0xBB96;
                    goto case 0xBB96;
                case 0xBB95:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBB96: // === SUBROUTINE: Sub_BB96 ===
                    X = 0x08; SetZN(X); TotalCycles += 2; PC = 0xBB98;
                    goto case 0xBB98;
                case 0xBB97:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBB98;
                    goto case 0xBB98;
                case 0xBB98:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xBB9A;
                    goto case 0xBB9A;
                case 0xBB99:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBB9A;
                    goto case 0xBB9A;
                case 0xBB9A:
                    A = _ram[(byte)(0x2A + X)]; SetZN(A); TotalCycles += 4; PC = 0xBB9C;
                    goto case 0xBB9C;
                case 0xBB9B:
                    A = Rol(A); TotalCycles += 2; PC = 0xBB9C;
                    goto case 0xBB9C;
                case 0xBB9C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBBF4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBBF4; }
                    PC = 0xBB9E; goto case 0xBB9E;
                case 0xBB9D:
                    { byte z = (byte)(0x0A + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xBB9F;
                    goto case 0xBB9F;
                case 0xBB9E:
                    A = Asl(A); TotalCycles += 2; PC = 0xBB9F;
                    goto case 0xBB9F;
                case 0xBB9F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBBA7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBBA7; }
                    PC = 0xBBA1; goto case 0xBBA1;
                case 0xBBA0:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xBBA2;
                    return;
                case 0xBBA1:
                    TotalCycles += 6; PushU16(0xBBA3); PC = 0xBAC3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBAC3;
                case 0xBBA3:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0xBBA4;
                    goto case 0xBBA4;
                case 0xBBA4:
                    TotalCycles += 3; PC = 0xBBF4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBBF4;
                case 0xBBA7:
                    Y = _ram[(byte)(0x2A + X)]; SetZN(Y); TotalCycles += 4; PC = 0xBBA9;
                    goto case 0xBBA9;
                case 0xBBA8:
                    A = Rol(A); TotalCycles += 2; PC = 0xBBA9;
                    goto case 0xBBA9;
                case 0xBBA9:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xBBAA;
                    goto case 0xBBAA;
                case 0xBBAA:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBBC9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBBC9; }
                    PC = 0xBBAC; goto case 0xBBAC;
                case 0xBBAB:
                    A |= ReadMem(0x2AF6 + X); SetZN(A); TotalCycles += 4; PC = 0xBBAE;
                    goto case 0xBBAE;
                case 0xBBAC:
                    { byte z = (byte)(0x2A + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xBBAE;
                    goto case 0xBBAE;
                case 0xBBAD:
                    A = Rol(A); TotalCycles += 2; PC = 0xBBAE;
                    goto case 0xBBAE;
                case 0xBBAE:
                    A = _ram[(byte)(0x93 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBBB0;
                    goto case 0xBBB0;
                case 0xBBB0:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBBB1;
                    goto case 0xBBB1;
                case 0xBBB1:
                    Adc(_ram[0x0775]); TotalCycles += 4; PC = 0xBBB4;
                    goto case 0xBBB4;
                case 0xBBB2:
                    Adc(_ram[(byte)(0x07 + X)]); TotalCycles += 4; PC = 0xBBB4;
                    goto case 0xBBB4;
                case 0xBBB4:
                    _ram[(byte)(0x93 + X)] = A; TotalCycles += 4; PC = 0xBBB6;
                    goto case 0xBBB6;
                case 0xBBB6:
                    A = _ram[(byte)(0x7A + X)]; SetZN(A); TotalCycles += 4; PC = 0xBBB8;
                    goto case 0xBBB8;
                case 0xBBB8:
                    Adc(0x00); TotalCycles += 2; PC = 0xBBBA;
                    goto case 0xBBBA;
                case 0xBBB9:
                    TotalCycles += 7; PushU16(0xBBBB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBBBA:
                    _ram[(byte)(0x7A + X)] = A; TotalCycles += 4; PC = 0xBBBC;
                    goto case 0xBBBC;
                case 0xBBBC:
                    A = _ram[(byte)(0x2A + X)]; SetZN(A); TotalCycles += 4; PC = 0xBBBE;
                    goto case 0xBBBE;
                case 0xBBBD:
                    A = Rol(A); TotalCycles += 2; PC = 0xBBBE;
                    goto case 0xBBBE;
                case 0xBBBE:
                    Cmp(A, 0x30); TotalCycles += 2; PC = 0xBBC0;
                    goto case 0xBBC0;
                case 0xBBBF:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xBB91; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBB91; }
                    PC = 0xBBC1; goto case 0xBBC1;
                case 0xBBC0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBBE8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBBE8; }
                    PC = 0xBBC2; goto case 0xBBC2;
                case 0xBBC1:
                    _ram[0xA9] = Rol(_ram[0xA9]); TotalCycles += 5; PC = 0xBBC3;
                    goto case 0xBBC3;
                case 0xBBC2:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBBC4;
                    goto case 0xBBC4;
                case 0xBBC3:
                    TotalCycles += 7; PushU16(0xBBC5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBBC4:
                    _ram[(byte)(0x2A + X)] = A; TotalCycles += 4; PC = 0xBBC6;
                    goto case 0xBBC6;
                case 0xBBC5:
                    A = Rol(A); TotalCycles += 2; PC = 0xBBC6;
                    goto case 0xBBC6;
                case 0xBBC6:
                    TotalCycles += 3; PC = 0xBBF4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBBF4;
                case 0xBBC9:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xBBCA;
                    goto case 0xBBCA;
                case 0xBBCA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBBCB;
                    goto case 0xBBCB;
                case 0xBBCB:
                    Adc(0x0D); TotalCycles += 2; PC = 0xBBCD;
                    goto case 0xBBCD;
                case 0xBBCC:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x29AA]; SetZN(A); TotalCycles += 4; PC = 0xBBCF;
                    goto case 0xBBCF;
                case 0xBBCD:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xBBCE;
                    goto case 0xBBCE;
                case 0xBBCE:
                    A = 0x50; SetZN(A); TotalCycles += 2; PC = 0xBBD0;
                    goto case 0xBBD0;
                case 0xBBCF:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xBB56; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xBBD1; goto case 0xBBD1;
                case 0xBBD0:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xBBD2;
                    goto case 0xBBD2;
                case 0xBBD1:
                    TotalCycles += 7; PushU16(0xBBD3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBBD2:
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0xBBD4;
                    goto case 0xBBD4;
                case 0xBBD3:
                    _ram[0x85] = Asl(_ram[0x85]); TotalCycles += 5; PC = 0xBBD5;
                    return;
                case 0xBBD4:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xBBD6;
                    goto case 0xBBD6;
                case 0xBBD6:
                    A = Lsr(A); TotalCycles += 2; PC = 0xBBD7;
                    goto case 0xBBD7;
                case 0xBBD7:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xBBD9;
                    goto case 0xBBD9;
                case 0xBBD8:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0xBBDA;
                    goto case 0xBBDA;
                case 0xBBD9:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBBDB;
                    goto case 0xBBDB;
                case 0xBBDA:
                    TotalCycles += 7; PushU16(0xBBDC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBBDB:
                    TotalCycles += 6; PushU16(0xBBDD); PC = 0xBFD7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFD7;
                case 0xBBDE:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBBE0;
                    goto case 0xBBE0;
                case 0xBBDF:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBBE0;
                    goto case 0xBBE0;
                case 0xBBE0:
                    A = _ram[(byte)(0xAC + X)]; SetZN(A); TotalCycles += 4; PC = 0xBBE2;
                    goto case 0xBBE2;
                case 0xBBE1:
                    Y = _ram[0x05C9]; SetZN(Y); TotalCycles += 4; PC = 0xBBE4;
                    goto case 0xBBE4;
                case 0xBBE2:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xBBE4;
                    goto case 0xBBE4;
                case 0xBBE3:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xBBE5;
                    return;
                case 0xBBE4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBBE8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBBE8; }
                    PC = 0xBBE6; goto case 0xBBE6;
                case 0xBBE6:
                    { byte z = (byte)(0x2A + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xBBE8;
                    goto case 0xBBE8;
                case 0xBBE7:
                    A = Rol(A); TotalCycles += 2; PC = 0xBBE8;
                    goto case 0xBBE8;
                case 0xBBE8:
                    TotalCycles += 6; PushU16(0xBBEA); PC = 0xF148;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBBE9:
                    PushU8(A); TotalCycles += 3; PC = 0xBBEA;
                    goto case 0xBBEA;
                case 0xBBEA:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBBEC;
                    return;
                case 0xBBEB:
                    TotalCycles += 6; PushU16(0xBBED); PC = 0xF19B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBBED:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBBEF;
                    goto case 0xBBEF;
                case 0xBBEE:
                    TotalCycles += 6; PushU16(0xBBF0); PC = 0xE236;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBBEF:
                    { byte z = (byte)(0xE2 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0xBBF1;
                    goto case 0xBBF1;
                case 0xBBF1:
                    TotalCycles += 6; PushU16(0xBBF3); PC = 0xE686;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBBF2:
                    _ram[0xE6] = X; TotalCycles += 3; PC = 0xBBF4;
                    goto case 0xBBF4;
                case 0xBBF3:
                    _ram[0xCA] = IncVal(_ram[0xCA]); TotalCycles += 5; PC = 0xBBF5;
                    goto case 0xBBF5;
                case 0xBBF4:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xBBF5;
                    goto case 0xBBF5;
                case 0xBBF5:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBB98; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBB98; }
                    PC = 0xBBF7; goto case 0xBBF7;
                case 0xBBF6:
                    A = ReadMem(ReadU16Zp((byte)(0x60 + X))); SetZN(A); TotalCycles += 6; PC = 0xBBF8;
                    return;
                case 0xBBF7:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBBF9:
                    A |= ReadMem(0x110B + X); SetZN(A); TotalCycles += 4; PC = 0xBBFC;
                    return;
                case 0xBBFB:
                    A |= ReadMem(ReadU16Zp(0x02) + Y); SetZN(A); TotalCycles += 5; PC = 0xBBFD;
                    return;
                case 0xBBFE: // === SUBROUTINE: Sub_BBFE ===
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBC00;
                    goto case 0xBC00;
                case 0xBBFF:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0xBC01;
                    goto case 0xBC01;
                case 0xBC00:
                    _ram[0x0139] = A; TotalCycles += 4; PC = 0xBC03;
                    goto case 0xBC03;
                case 0xBC01:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x2E01 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBC04;
                    return;
                case 0xBC02:
                    A |= ReadMem(ReadU16Zp((byte)(0xAE + X))); SetZN(A); TotalCycles += 6; PC = 0xBC04;
                    return;
                case 0xBC03:
                    X = _ram[0x0753]; SetZN(X); TotalCycles += 4; PC = 0xBC06;
                    goto case 0xBC06;
                case 0xBC06:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x3BF8 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xBC09;
                    goto case 0xBC09;
                case 0xBC07:
                    P |= FlagD; TotalCycles += 2; PC = 0xBC08;
                    return;
                case 0xBC09:
                    TotalCycles += 6; PushU16(0xBC0B); PC = 0x8F5F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBC0C:
                    _ram[0x075E] = IncVal(_ram[0x075E]); TotalCycles += 6; PC = 0xBC0F;
                    goto case 0xBC0F;
                case 0xBC0D:
                    { int a = 0xAD07 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xBC10;
                    goto case 0xBC10;
                case 0xBC0F:
                    A = _ram[0x075E]; SetZN(A); TotalCycles += 4; PC = 0xBC12;
                    goto case 0xBC12;
                case 0xBC10:
                    { int a = 0xC907 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xBC13;
                    return;
                case 0xBC12:
                    Cmp(A, 0x64); TotalCycles += 2; PC = 0xBC14;
                    goto case 0xBC14;
                case 0xBC14:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBC22; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBC22; }
                    PC = 0xBC16; goto case 0xBC16;
                case 0xBC16:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBC18;
                    goto case 0xBC18;
                case 0xBC17:
                    TotalCycles += 7; PushU16(0xBC19); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBC18:
                    _ram[0x075E] = A; TotalCycles += 4; PC = 0xBC1B;
                    goto case 0xBC1B;
                case 0xBC19:
                    { int a = 0xEE07 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xBC1C;
                    return;
                case 0xBC1B:
                    _ram[0x075A] = IncVal(_ram[0x075A]); TotalCycles += 6; PC = 0xBC1E;
                    goto case 0xBC1E;
                case 0xBC1E:
                    A = 0x40; SetZN(A); TotalCycles += 2; PC = 0xBC20;
                    goto case 0xBC20;
                case 0xBC1F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0xBC20:
                    _ram[0xFE] = A; TotalCycles += 3; PC = 0xBC22;
                    goto case 0xBC22;
                case 0xBC21:
                    { int a = (0x02A9 + X) & 0x07FF; _ram[a] = IncVal(_ram[a]); } TotalCycles += 7; PC = 0xBC24;
                    goto case 0xBC24;
                case 0xBC22:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xBC24;
                    goto case 0xBC24;
                case 0xBC24:
                    _ram[0x0138] = A; TotalCycles += 4; PC = 0xBC27;
                    goto case 0xBC27;
                case 0xBC25:
                    P |= FlagC; TotalCycles += 2; PC = 0xBC26;
                    goto case 0xBC26;
                case 0xBC26:
                    A |= ReadMem(ReadU16Zp((byte)(0xAE + X))); SetZN(A); TotalCycles += 6; PC = 0xBC28;
                    return;
                case 0xBC27: // === SUBROUTINE: Sub_BC27 ===
                    X = _ram[0x0753]; SetZN(X); TotalCycles += 4; PC = 0xBC2A;
                    goto case 0xBC2A;
                case 0xBC2A:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x3BFA + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xBC2D;
                    goto case 0xBC2D;
                case 0xBC2D:
                    TotalCycles += 6; PushU16(0xBC2F); PC = 0x8F5F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBC30: // === SUBROUTINE: Sub_BC30 ===
                    Y = _ram[0x0753]; SetZN(Y); TotalCycles += 4; PC = 0xBC33;
                    goto case 0xBC33;
                case 0xBC33:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3BFC + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBC36;
                    goto case 0xBC36;
                case 0xBC36: // === SUBROUTINE: Sub_BC36 ===
                    TotalCycles += 6; PushU16(0xBC38); PC = 0x8F06;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBC37:
                    _ram[0x8F] = Asl(_ram[0x8F]); TotalCycles += 5; PC = 0xBC39;
                    goto case 0xBC39;
                case 0xBC39:
                    Y = _ram[0x0300]; SetZN(Y); TotalCycles += 4; PC = 0xBC3C;
                    goto case 0xBC3C;
                case 0xBC3A:
                    TotalCycles += 7; PushU16(0xBC3C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBC3C:
                    A = _ram[(0x02FB + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBC3F;
                    goto case 0xBC3F;
                case 0xBC3F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBC46; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBC46; }
                    PC = 0xBC41; goto case 0xBC41;
                case 0xBC40:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0xBC42;
                    goto case 0xBC42;
                case 0xBC41:
                    A = 0x24; SetZN(A); TotalCycles += 2; PC = 0xBC43;
                    goto case 0xBC43;
                case 0xBC42:
                    Bit(_ram[0x99]); TotalCycles += 3; PC = 0xBC44;
                    return;
                case 0xBC43:
                    _ram[(0x02FB + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0xBC46;
                    goto case 0xBC46;
                case 0xBC46:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBC48;
                    goto case 0xBC48;
                case 0xBC47:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBC48;
                    goto case 0xBC48;
                case 0xBC48:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBC49:
                    A = 0x2E; SetZN(A); TotalCycles += 2; PC = 0xBC4B;
                    goto case 0xBC4B;
                case 0xBC4A:
                    _ram[0x0385] = Rol(_ram[0x0385]); TotalCycles += 6; PC = 0xBC4D;
                    goto case 0xBC4D;
                case 0xBC4B:
                    _ram[0x1B] = A; TotalCycles += 3; PC = 0xBC4D;
                    goto case 0xBC4D;
                case 0xBC4D:
                    A = _ram[(byte)(0x76 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBC4F;
                    goto case 0xBC4F;
                case 0xBC4E:
                    { byte z = (byte)(0x85 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xBC50;
                    return;
                case 0xBC4F:
                    _ram[0x73] = A; TotalCycles += 3; PC = 0xBC51;
                    goto case 0xBC51;
                case 0xBC51:
                    A = _ram[(byte)(0x8F + X)]; SetZN(A); TotalCycles += 4; PC = 0xBC53;
                    goto case 0xBC53;
                case 0xBC53:
                    _ram[0x8C] = A; TotalCycles += 3; PC = 0xBC55;
                    goto case 0xBC55;
                case 0xBC54:
                    _ram[0x01A9] = Y; TotalCycles += 4; PC = 0xBC57;
                    goto case 0xBC57;
                case 0xBC55:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBC57;
                    goto case 0xBC57;
                case 0xBC56:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xBC58;
                    return;
                case 0xBC57:
                    _ram[0xBB] = A; TotalCycles += 3; PC = 0xBC59;
                    goto case 0xBC59;
                case 0xBC59:
                    A = _ram[(byte)(0xD7 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBC5B;
                    goto case 0xBC5B;
                case 0xBC5B:
                    P |= FlagC; TotalCycles += 2; PC = 0xBC5C;
                    goto case 0xBC5C;
                case 0xBC5C:
                    Sbc(0x08); TotalCycles += 2; PC = 0xBC5E;
                    goto case 0xBC5E;
                case 0xBC5D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBC5E;
                    goto case 0xBC5E;
                case 0xBC5E:
                    _ram[0xD4] = A; TotalCycles += 3; PC = 0xBC60;
                    goto case 0xBC60;
                case 0xBC60:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBC62;
                    goto case 0xBC62;
                case 0xBC61:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0xBC63;
                    return;
                case 0xBC62:
                    _ram[0x23] = A; TotalCycles += 3; PC = 0xBC64;
                    goto case 0xBC64;
                case 0xBC64:
                    _ram[0x14] = A; TotalCycles += 3; PC = 0xBC66;
                    goto case 0xBC66;
                case 0xBC66:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xBC68;
                    goto case 0xBC68;
                case 0xBC68:
                    _ram[0x049F] = A; TotalCycles += 4; PC = 0xBC6B;
                    goto case 0xBC6B;
                case 0xBC6B:
                    A = _ram[0x39]; SetZN(A); TotalCycles += 3; PC = 0xBC6D;
                    goto case 0xBC6D;
                case 0xBC6C:
                    A &= _ram[(0x02C9 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBC6F;
                    goto case 0xBC6F;
                case 0xBC6D:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xBC6F;
                    goto case 0xBC6F;
                case 0xBC6F:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xBC7B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBC7B; }
                    PC = 0xBC71; goto case 0xBC71;
                case 0xBC70:
                    A = Asl(A); TotalCycles += 2; PC = 0xBC71;
                    goto case 0xBC71;
                case 0xBC71:
                    A = _ram[0x0756]; SetZN(A); TotalCycles += 4; PC = 0xBC74;
                    goto case 0xBC74;
                case 0xBC72:
                    { byte z = (byte)(0x07 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xBC74;
                    goto case 0xBC74;
                case 0xBC74:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xBC76;
                    goto case 0xBC76;
                case 0xBC76:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBC79; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBC79; }
                    PC = 0xBC78; goto case 0xBC78;
                case 0xBC77:
                    A |= ReadMem(ReadU16Zp((byte)(0x4A + X))); SetZN(A); TotalCycles += 6; PC = 0xBC79;
                    goto case 0xBC79;
                case 0xBC78:
                    A = Lsr(A); TotalCycles += 2; PC = 0xBC79;
                    goto case 0xBC79;
                case 0xBC79:
                    _ram[0x39] = A; TotalCycles += 3; PC = 0xBC7B;
                    goto case 0xBC7B;
                case 0xBC7A:
                    A &= ReadMem(0x20A9 + Y); SetZN(A); TotalCycles += 4; PC = 0xBC7D;
                    goto case 0xBC7D;
                case 0xBC7B:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0xBC7D;
                    goto case 0xBC7D;
                case 0xBC7C:
                    TotalCycles += 6; PushU16(0xBC7E); PC = 0xCA8D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBC7D:
                    _ram[0x03CA] = A; TotalCycles += 4; PC = 0xBC80;
                    goto case 0xBC80;
                case 0xBC7E:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xBC7F;
                    return;
                case 0xBC80:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xBC82;
                    goto case 0xBC82;
                case 0xBC82:
                    _ram[0xFE] = A; TotalCycles += 3; PC = 0xBC84;
                    goto case 0xBC84;
                case 0xBC83:
                    { int a = 0xA260 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xBC86;
                    goto case 0xBC86;
                case 0xBC84:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBC85:
                    X = 0x05; SetZN(X); TotalCycles += 2; PC = 0xBC87;
                    goto case 0xBC87;
                case 0xBC86:
                    A |= _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xBC88;
                    goto case 0xBC88;
                case 0xBC87:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xBC89;
                    goto case 0xBC89;
                case 0xBC88:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBC89;
                    goto case 0xBC89;
                case 0xBC89:
                    A = _ram[0x23]; SetZN(A); TotalCycles += 3; PC = 0xBC8B;
                    goto case 0xBC8B;
                case 0xBC8B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBCEA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCEA; }
                    PC = 0xBC8D; goto case 0xBC8D;
                case 0xBC8C:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x100A + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBC8F;
                    return;
                case 0xBC8D:
                    A = Asl(A); TotalCycles += 2; PC = 0xBC8E;
                    goto case 0xBC8E;
                case 0xBC8E:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBCB3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCB3; }
                    PC = 0xBC90; goto case 0xBC90;
                case 0xBC90:
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xBC93;
                    goto case 0xBC93;
                case 0xBC93:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBCD8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCD8; }
                    PC = 0xBC95; goto case 0xBC95;
                case 0xBC95:
                    A = _ram[0x39]; SetZN(A); TotalCycles += 3; PC = 0xBC97;
                    goto case 0xBC97;
                case 0xBC96:
                    A &= ReadMem(0x11F0 + Y); SetZN(A); TotalCycles += 4; PC = 0xBC99;
                    goto case 0xBC99;
                case 0xBC97:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBCAA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCAA; }
                    PC = 0xBC99; goto case 0xBC99;
                case 0xBC98:
                    A |= ReadMem(ReadU16Zp(0xC9) + Y); SetZN(A); TotalCycles += 5; PC = 0xBC9A;
                    return;
                case 0xBC99:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0xBC9B;
                    goto case 0xBC9B;
                case 0xBC9B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBCAA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCAA; }
                    PC = 0xBC9D; goto case 0xBC9D;
                case 0xBC9C:
                    A |= _ram[0x02C9]; SetZN(A); TotalCycles += 4; PC = 0xBC9F;
                    goto case 0xBC9F;
                case 0xBC9D:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0xBC9F;
                    goto case 0xBC9F;
                case 0xBC9F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBCD8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCD8; }
                    PC = 0xBCA1; goto case 0xBCA1;
                case 0xBCA1:
                    TotalCycles += 6; PushU16(0xBCA3); PC = 0xCAF9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCA2:
                    Sbc(ReadMem(0x20CA + Y)); TotalCycles += 4; PC = 0xBCA5;
                    return;
                case 0xBCA3:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xBCA4;
                    goto case 0xBCA4;
                case 0xBCA4:
                    TotalCycles += 6; PushU16(0xBCA6); PC = 0xE163;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCA6:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x4C + X)))); TotalCycles += 6; PC = 0xBCA8;
                    goto case 0xBCA8;
                case 0xBCA7:
                    TotalCycles += 3; PC = 0xBCD8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBCD8;
                case 0xBCA8:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xBCA9;
                    goto case 0xBCA9;
                case 0xBCA9:
                    Y = ReadMem(0x7720 + X); SetZN(Y); TotalCycles += 4; PC = 0xBCAC;
                    goto case 0xBCAC;
                case 0xBCAA:
                    TotalCycles += 6; PushU16(0xBCAC); PC = 0xCA77;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCAC:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xBCAD;
                    goto case 0xBCAD;
                case 0xBCAD:
                    TotalCycles += 6; PushU16(0xBCAF); PC = 0xDFC1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCAE:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xDF + X)))); TotalCycles += 6; PC = 0xBCB0;
                    goto case 0xBCB0;
                case 0xBCB0:
                    TotalCycles += 3; PC = 0xBCD8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBCD8;
                case 0xBCB1:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xBCB2;
                    goto case 0xBCB2;
                case 0xBCB2:
                    Y = ReadMem(0x09A5 + X); SetZN(Y); TotalCycles += 4; PC = 0xBCB5;
                    goto case 0xBCB5;
                case 0xBCB3:
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0xBCB5;
                    goto case 0xBCB5;
                case 0xBCB4:
                    A |= 0x29; SetZN(A); TotalCycles += 2; PC = 0xBCB6;
                    return;
                case 0xBCB5:
                    A &= 0x03; SetZN(A); TotalCycles += 2; PC = 0xBCB7;
                    goto case 0xBCB7;
                case 0xBCB7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBCD2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCD2; }
                    PC = 0xBCB9; goto case 0xBCB9;
                case 0xBCB8:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x54C6 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBCBB;
                    goto case 0xBCBB;
                case 0xBCB9:
                    _ram[0xD4] = DecVal(_ram[0xD4]); TotalCycles += 5; PC = 0xBCBB;
                    goto case 0xBCBB;
                case 0xBCBB:
                    A = _ram[0x23]; SetZN(A); TotalCycles += 3; PC = 0xBCBD;
                    goto case 0xBCBD;
                case 0xBCBD:
                    _ram[0x23] = IncVal(_ram[0x23]); TotalCycles += 5; PC = 0xBCBF;
                    goto case 0xBCBF;
                case 0xBCBF:
                    Cmp(A, 0x11); TotalCycles += 2; PC = 0xBCC1;
                    goto case 0xBCC1;
                case 0xBCC0:
                    A |= ReadMem(ReadU16Zp(0x90) + Y); SetZN(A); TotalCycles += 5; PC = 0xBCC2;
                    return;
                case 0xBCC1:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBCD2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCD2; }
                    PC = 0xBCC3; goto case 0xBCC3;
                case 0xBCC3:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0xBCC5;
                    goto case 0xBCC5;
                case 0xBCC4:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBC5B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBC5B; }
                    PC = 0xBCC6; goto case 0xBCC6;
                case 0xBCC5:
                    _ram[(byte)(0x58 + X)] = A; TotalCycles += 4; PC = 0xBCC7;
                    goto case 0xBCC7;
                case 0xBCC6:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xBCC7;
                    goto case 0xBCC7;
                case 0xBCC7:
                    A = 0x80; SetZN(A); TotalCycles += 2; PC = 0xBCC9;
                    goto case 0xBCC9;
                case 0xBCC9:
                    _ram[0x23] = A; TotalCycles += 3; PC = 0xBCCB;
                    goto case 0xBCCB;
                case 0xBCCB:
                    A = Asl(A); TotalCycles += 2; PC = 0xBCCC;
                    goto case 0xBCCC;
                case 0xBCCC:
                    _ram[0x03CA] = A; TotalCycles += 4; PC = 0xBCCF;
                    goto case 0xBCCF;
                case 0xBCCD:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xBCCE;
                    return;
                case 0xBCCF:
                    A = Rol(A); TotalCycles += 2; PC = 0xBCD0;
                    goto case 0xBCD0;
                case 0xBCD0:
                    _ram[(byte)(0x46 + X)] = A; TotalCycles += 4; PC = 0xBCD2;
                    goto case 0xBCD2;
                case 0xBCD1:
                    _ram[0xA5] = Lsr(_ram[0xA5]); TotalCycles += 5; PC = 0xBCD3;
                    return;
                case 0xBCD2:
                    A = _ram[0x23]; SetZN(A); TotalCycles += 3; PC = 0xBCD4;
                    goto case 0xBCD4;
                case 0xBCD4:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0xBCD6;
                    goto case 0xBCD6;
                case 0xBCD5:
                    _ram[0x90] = Asl(_ram[0x90]); TotalCycles += 5; PC = 0xBCD7;
                    return;
                case 0xBCD6:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBCEA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCEA; }
                    PC = 0xBCD8; goto case 0xBCD8;
                case 0xBCD8:
                    TotalCycles += 6; PushU16(0xBCDA); PC = 0xF152;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCDA:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBCDC;
                    return;
                case 0xBCDB:
                    TotalCycles += 6; PushU16(0xBCDD); PC = 0xF1AF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCDD:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBCDF;
                    return;
                case 0xBCDE:
                    TotalCycles += 6; PushU16(0xBCE0); PC = 0xE243;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCE1:
                    TotalCycles += 6; PushU16(0xBCE3); PC = 0xE6D2;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCE3:
                    _ram[0x20] = IncVal(_ram[0x20]); TotalCycles += 5; PC = 0xBCE5;
                    return;
                case 0xBCE4:
                    TotalCycles += 6; PushU16(0xBCE6); PC = 0xD853;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCE6:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xBCE7;
                    goto case 0xBCE7;
                case 0xBCE7:
                    TotalCycles += 6; PushU16(0xBCE9); PC = 0xD67A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCE9:
                    { byte z = (byte)(0x60 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0xBCEB;
                    return;
                case 0xBCEA:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBCED: // === SUBROUTINE: Sub_BCED ===
                    PushU8(A); TotalCycles += 3; PC = 0xBCEE;
                    goto case 0xBCEE;
                case 0xBCEE:
                    A = 0x11; SetZN(A); TotalCycles += 2; PC = 0xBCF0;
                    goto case 0xBCF0;
                case 0xBCEF:
                    A |= ReadMem(ReadU16Zp(0xAE) + Y); SetZN(A); TotalCycles += 5; PC = 0xBCF1;
                    goto case 0xBCF1;
                case 0xBCF0:
                    X = _ram[0x03EE]; SetZN(X); TotalCycles += 4; PC = 0xBCF3;
                    goto case 0xBCF3;
                case 0xBCF1:
                    { int a = 0xAC03; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBCF4;
                    return;
                case 0xBCF3:
                    Y = _ram[0x0754]; SetZN(Y); TotalCycles += 4; PC = 0xBCF6;
                    goto case 0xBCF6;
                case 0xBCF6:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBCFA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCFA; }
                    PC = 0xBCF8; goto case 0xBCF8;
                case 0xBCF8:
                    A = 0x12; SetZN(A); TotalCycles += 2; PC = 0xBCFA;
                    goto case 0xBCFA;
                case 0xBCFA:
                    _ram[(byte)(0x26 + X)] = A; TotalCycles += 4; PC = 0xBCFC;
                    goto case 0xBCFC;
                case 0xBCFB:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0xBCFD;
                    return;
                case 0xBCFC:
                    TotalCycles += 6; PushU16(0xBCFE); PC = 0x8A6B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBCFE:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xBCFF;
                    goto case 0xBCFF;
                case 0xBCFF:
                    X = _ram[0x03EE]; SetZN(X); TotalCycles += 4; PC = 0xBD02;
                    goto case 0xBD02;
                case 0xBD00:
                    { int a = 0xA503; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBD03;
                    return;
                case 0xBD02:
                    A = _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0xBD04;
                    goto case 0xBD04;
                case 0xBD04:
                    _ram[(0x03E4 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBD07;
                    goto case 0xBD07;
                case 0xBD05:
                    Cmp(X, _ram[0x03]); TotalCycles += 3; PC = 0xBD07;
                    goto case 0xBD07;
                case 0xBD07:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBD08;
                    goto case 0xBD08;
                case 0xBD08:
                    A = _ram[0x06]; SetZN(A); TotalCycles += 3; PC = 0xBD0A;
                    goto case 0xBD0A;
                case 0xBD09:
                    _ram[0x9D] = Asl(_ram[0x9D]); TotalCycles += 5; PC = 0xBD0B;
                    goto case 0xBD0B;
                case 0xBD0A:
                    _ram[(0x03E6 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBD0D;
                    goto case 0xBD0D;
                case 0xBD0B:
                    _ram[0x03] = IncVal(_ram[0x03]); TotalCycles += 5; PC = 0xBD0D;
                    goto case 0xBD0D;
                case 0xBD0D:
                    A = ReadMem(ReadU16Zp(0x06) + Y); SetZN(A); TotalCycles += 5; PC = 0xBD0F;
                    goto case 0xBD0F;
                case 0xBD0E:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xBD10;
                    goto case 0xBD10;
                case 0xBD0F:
                    TotalCycles += 6; PushU16(0xBD11); PC = 0xBDF6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBDF6;
                case 0xBD10:
                    { byte z = (byte)(0xBD + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xBD12;
                    goto case 0xBD12;
                case 0xBD11:
                    A = _ram[(0x0085 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBD14;
                    goto case 0xBD14;
                case 0xBD12:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xBD14;
                    goto case 0xBD14;
                case 0xBD13:
                    TotalCycles += 7; PushU16(0xBD15); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBD14:
                    Y = _ram[0x0754]; SetZN(Y); TotalCycles += 4; PC = 0xBD17;
                    goto case 0xBD17;
                case 0xBD17:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBD1A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD1A; }
                    PC = 0xBD19; goto case 0xBD19;
                case 0xBD18:
                    A |= ReadMem(ReadU16Zp((byte)(0x98 + X))); SetZN(A); TotalCycles += 6; PC = 0xBD1A;
                    goto case 0xBD1A;
                case 0xBD19:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xBD1A;
                    goto case 0xBD1A;
                case 0xBD1A:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBD41; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD41; }
                    PC = 0xBD1C; goto case 0xBD1C;
                case 0xBD1B:
                    A &= _ram[0xA0]; SetZN(A); TotalCycles += 3; PC = 0xBD1D;
                    goto case 0xBD1D;
                case 0xBD1C:
                    Y = 0x11; SetZN(Y); TotalCycles += 2; PC = 0xBD1E;
                    goto case 0xBD1E;
                case 0xBD1D:
                    A |= ReadMem(ReadU16Zp(0x94) + Y); SetZN(A); TotalCycles += 5; PC = 0xBD1F;
                    goto case 0xBD1F;
                case 0xBD1E:
                    _ram[(byte)(0x26 + X)] = Y; TotalCycles += 4; PC = 0xBD20;
                    goto case 0xBD20;
                case 0xBD1F:
                    _ram[0xA9] = Rol(_ram[0xA9]); TotalCycles += 5; PC = 0xBD21;
                    goto case 0xBD21;
                case 0xBD20:
                    A = 0xC4; SetZN(A); TotalCycles += 2; PC = 0xBD22;
                    goto case 0xBD22;
                case 0xBD21:
                    Cmp(Y, _ram[0xA4]); TotalCycles += 3; PC = 0xBD23;
                    goto case 0xBD23;
                case 0xBD22:
                    Y = _ram[0x00]; SetZN(Y); TotalCycles += 3; PC = 0xBD24;
                    goto case 0xBD24;
                case 0xBD23:
                    TotalCycles += 7; PushU16(0xBD25); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBD24:
                    Cmp(Y, 0x58); TotalCycles += 2; PC = 0xBD26;
                    goto case 0xBD26;
                case 0xBD25:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xBD26;
                    goto case 0xBD26;
                case 0xBD26:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBD2C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD2C; }
                    PC = 0xBD28; goto case 0xBD28;
                case 0xBD28:
                    Cmp(Y, 0x5D); TotalCycles += 2; PC = 0xBD2A;
                    goto case 0xBD2A;
                case 0xBD29:
                    A ^= ReadMem(0x15D0 + X); SetZN(A); TotalCycles += 4; PC = 0xBD2C;
                    goto case 0xBD2C;
                case 0xBD2A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBD41; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD41; }
                    PC = 0xBD2C; goto case 0xBD2C;
                case 0xBD2B:
                    A |= _ram[(byte)(0xAD + X)]; SetZN(A); TotalCycles += 4; PC = 0xBD2D;
                    goto case 0xBD2D;
                case 0xBD2C:
                    A = _ram[0x06BC]; SetZN(A); TotalCycles += 4; PC = 0xBD2F;
                    goto case 0xBD2F;
                case 0xBD2D:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x5006 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xBD30;
                    goto case 0xBD30;
                case 0xBD2E:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0xBD30;
                    goto case 0xBD30;
                case 0xBD2F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBD39; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD39; }
                    PC = 0xBD31; goto case 0xBD31;
                case 0xBD30:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBD31;
                    goto case 0xBD31;
                case 0xBD31:
                    A = 0x0B; SetZN(A); TotalCycles += 2; PC = 0xBD33;
                    goto case 0xBD33;
                case 0xBD33:
                    _ram[0x079D] = A; TotalCycles += 4; PC = 0xBD36;
                    goto case 0xBD36;
                case 0xBD34:
                    WriteMem(0xEE07 + X, A); TotalCycles += 5; PC = 0xBD37;
                    goto case 0xBD37;
                case 0xBD36:
                    _ram[0x06BC] = IncVal(_ram[0x06BC]); TotalCycles += 6; PC = 0xBD39;
                    goto case 0xBD39;
                case 0xBD37:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x2D06 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xBD3A;
                    goto case 0xBD3A;
                case 0xBD38:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0xBD3A;
                    goto case 0xBD3A;
                case 0xBD39:
                    A = _ram[0x079D]; SetZN(A); TotalCycles += 4; PC = 0xBD3C;
                    goto case 0xBD3C;
                case 0xBD3A:
                    WriteMem(0xD007 + X, A); TotalCycles += 5; PC = 0xBD3D;
                    return;
                case 0xBD3C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBD40; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD40; }
                    PC = 0xBD3E; goto case 0xBD3E;
                case 0xBD3E:
                    Y = 0xC4; SetZN(Y); TotalCycles += 2; PC = 0xBD40;
                    goto case 0xBD40;
                case 0xBD3F:
                    Cmp(Y, _ram[0x98]); TotalCycles += 3; PC = 0xBD41;
                    goto case 0xBD41;
                case 0xBD40:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xBD41;
                    goto case 0xBD41;
                case 0xBD41:
                    _ram[(0x03E8 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBD44;
                    goto case 0xBD44;
                case 0xBD42:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xBD43;
                    return;
                case 0xBD44:
                    TotalCycles += 6; PushU16(0xBD46); PC = 0xBD84;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBD84;
                case 0xBD45:
                    _ram[0xBD] = Y; TotalCycles += 3; PC = 0xBD47;
                    goto case 0xBD47;
                case 0xBD46:
                    A = _ram[(0x02A4 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBD49;
                    goto case 0xBD49;
                case 0xBD47:
                    Y = _ram[0x02]; SetZN(Y); TotalCycles += 3; PC = 0xBD49;
                    goto case 0xBD49;
                case 0xBD49:
                    A = 0x23; SetZN(A); TotalCycles += 2; PC = 0xBD4B;
                    goto case 0xBD4B;
                case 0xBD4B:
                    WriteMem(ReadU16Zp(0x06) + Y, A); TotalCycles += 6; PC = 0xBD4D;
                    goto case 0xBD4D;
                case 0xBD4C:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xBD4E;
                    goto case 0xBD4E;
                case 0xBD4D:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0xBD4F;
                    goto case 0xBD4F;
                case 0xBD4E:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBCDD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBCDD; }
                    PC = 0xBD50; goto case 0xBD50;
                case 0xBD4F:
                    _ram[0x0784] = A; TotalCycles += 4; PC = 0xBD52;
                    goto case 0xBD52;
                case 0xBD50:
                    _ram[0x07] = Y; TotalCycles += 3; PC = 0xBD52;
                    goto case 0xBD52;
                case 0xBD52:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xBD53;
                    goto case 0xBD53;
                case 0xBD53:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0xBD55;
                    goto case 0xBD55;
                case 0xBD54:
                    A |= _ram[0xA0]; SetZN(A); TotalCycles += 3; PC = 0xBD56;
                    goto case 0xBD56;
                case 0xBD55:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xBD57;
                    goto case 0xBD57;
                case 0xBD56:
                    TotalCycles += 7; PushU16(0xBD58); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBD57:
                    A = _ram[0x0714]; SetZN(A); TotalCycles += 4; PC = 0xBD5A;
                    goto case 0xBD5A;
                case 0xBD5A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBD61; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD61; }
                    PC = 0xBD5C; goto case 0xBD5C;
                case 0xBD5B:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0xBD5D;
                    return;
                case 0xBD5C:
                    A = _ram[0x0754]; SetZN(A); TotalCycles += 4; PC = 0xBD5F;
                    goto case 0xBD5F;
                case 0xBD5F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBD62; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD62; }
                    PC = 0xBD61; goto case 0xBD61;
                case 0xBD60:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0xBD62;
                    goto case 0xBD62;
                case 0xBD61:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0xBD62;
                    goto case 0xBD62;
                case 0xBD62:
                    A = _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0xBD64;
                    goto case 0xBD64;
                case 0xBD63:
                    { int a = 0x7918; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBD66;
                    return;
                case 0xBD64:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBD65;
                    goto case 0xBD65;
                case 0xBD65:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x3CEB + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xBD68;
                    goto case 0xBD68;
                case 0xBD67:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x7029 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xBD6A;
                    goto case 0xBD6A;
                case 0xBD68:
                    A &= 0xF0; SetZN(A); TotalCycles += 2; PC = 0xBD6A;
                    goto case 0xBD6A;
                case 0xBD69:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBD00; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD00; }
                    PC = 0xBD6B; return;
                case 0xBD6A:
                    _ram[(byte)(0xD7 + X)] = A; TotalCycles += 4; PC = 0xBD6C;
                    goto case 0xBD6C;
                case 0xBD6C:
                    Y = _ram[(byte)(0x26 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xBD6E;
                    goto case 0xBD6E;
                case 0xBD6D:
                    _ram[0xC0] = Rol(_ram[0xC0]); TotalCycles += 5; PC = 0xBD6F;
                    goto case 0xBD6F;
                case 0xBD6E:
                    Cmp(Y, 0x11); TotalCycles += 2; PC = 0xBD70;
                    goto case 0xBD70;
                case 0xBD6F:
                    A |= ReadMem(ReadU16Zp(0xF0) + Y); SetZN(A); TotalCycles += 5; PC = 0xBD71;
                    goto case 0xBD71;
                case 0xBD70:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBD78; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD78; }
                    PC = 0xBD72; goto case 0xBD72;
                case 0xBD71:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xBD73;
                    return;
                case 0xBD72:
                    TotalCycles += 6; PushU16(0xBD74); PC = 0xBE02;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBE02;
                case 0xBD74:
                    X = ReadMem(0x7B4C + Y); SetZN(X); TotalCycles += 4; PC = 0xBD77;
                    goto case 0xBD77;
                case 0xBD75:
                    TotalCycles += 3; PC = 0xBD7B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBD7B;
                case 0xBD77:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1B20 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBD7A;
                    goto case 0xBD7A;
                case 0xBD78:
                    TotalCycles += 6; PushU16(0xBD7A); PC = 0xBD9B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBD9B;
                case 0xBD7A:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x6EAD + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBD7D;
                    return;
                case 0xBD7B:
                    A = _ram[0x03EE]; SetZN(A); TotalCycles += 4; PC = 0xBD7E;
                    goto case 0xBD7E;
                case 0xBD7C:
                    { int a = 0x4903; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBD7F;
                    goto case 0xBD7F;
                case 0xBD7E:
                    A ^= 0x01; SetZN(A); TotalCycles += 2; PC = 0xBD80;
                    goto case 0xBD80;
                case 0xBD7F:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0xBD81;
                    goto case 0xBD81;
                case 0xBD80:
                    _ram[0x03EE] = A; TotalCycles += 4; PC = 0xBD83;
                    goto case 0xBD83;
                case 0xBD81:
                    { int a = 0x6003; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBD84;
                    goto case 0xBD84;
                case 0xBD83: // === SUBROUTINE: Sub_BD83 ===
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBD84: // === SUBROUTINE: Sub_BD84 ===
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0xBD86;
                    goto case 0xBD86;
                case 0xBD85: // === SUBROUTINE: FireballObjCore ===
                    _ram[0x18] = X; TotalCycles += 3; PC = 0xBD87;
                    goto case 0xBD87;
                case 0xBD86:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBD87;
                    goto case 0xBD87;
                case 0xBD87:
                    Adc(0x08); TotalCycles += 2; PC = 0xBD89;
                    goto case 0xBD89;
                case 0xBD88:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBD89;
                    goto case 0xBD89;
                case 0xBD89:
                    A &= 0xF0; SetZN(A); TotalCycles += 2; PC = 0xBD8B;
                    goto case 0xBD8B;
                case 0xBD8A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBD21; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBD21; }
                    PC = 0xBD8C; return;
                case 0xBD8B:
                    _ram[(byte)(0x8F + X)] = A; TotalCycles += 4; PC = 0xBD8D;
                    goto case 0xBD8D;
                case 0xBD8D:
                    A = _ram[0x6D]; SetZN(A); TotalCycles += 3; PC = 0xBD8F;
                    goto case 0xBD8F;
                case 0xBD8E:
                    Adc(_ram[0x0069]); TotalCycles += 4; PC = 0xBD91;
                    goto case 0xBD91;
                case 0xBD8F:
                    Adc(0x00); TotalCycles += 2; PC = 0xBD91;
                    goto case 0xBD91;
                case 0xBD90:
                    TotalCycles += 7; PushU16(0xBD92); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBD91:
                    _ram[(byte)(0x76 + X)] = A; TotalCycles += 4; PC = 0xBD93;
                    goto case 0xBD93;
                case 0xBD92:
                    { byte z = (byte)(0x9D + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xBD94;
                    goto case 0xBD94;
                case 0xBD93:
                    _ram[(0x03EA + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBD96;
                    goto case 0xBD96;
                case 0xBD94:
                     TotalCycles += 2; PC = 0xBD95;
                    return;
                case 0xBD96:
                    A = _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0xBD98;
                    goto case 0xBD98;
                case 0xBD97:
                    A = _ram[(byte)(0x95 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBD99;
                    goto case 0xBD99;
                case 0xBD98:
                    _ram[(byte)(0xBE + X)] = A; TotalCycles += 4; PC = 0xBD9A;
                    goto case 0xBD9A;
                case 0xBD99:
                    X = ReadMem(0x2060 + Y); SetZN(X); TotalCycles += 4; PC = 0xBD9C;
                    return;
                case 0xBD9A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBD9B: // === SUBROUTINE: Sub_BD9B ===
                    TotalCycles += 6; PushU16(0xBD9D); PC = 0xBE1F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBE1F;
                case 0xBD9D:
                    X = _ram[(0x02A9 + Y) & 0x07FF]; SetZN(X); TotalCycles += 4; PC = 0xBDA0;
                    goto case 0xBDA0;
                case 0xBD9E:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xBDA0;
                    goto case 0xBDA0;
                case 0xBDA0:
                    _ram[0xFF] = A; TotalCycles += 3; PC = 0xBDA2;
                    goto case 0xBDA2;
                case 0xBDA2:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBDA4;
                    goto case 0xBDA4;
                case 0xBDA3:
                    TotalCycles += 7; PushU16(0xBDA5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBDA4:
                    _ram[(byte)(0x60 + X)] = A; TotalCycles += 4; PC = 0xBDA6;
                    goto case 0xBDA6;
                case 0xBDA5:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBDA6:
                    _ram[(0x043C + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBDA9;
                    goto case 0xBDA9;
                case 0xBDA9:
                    _ram[0x9F] = A; TotalCycles += 3; PC = 0xBDAB;
                    goto case 0xBDAB;
                case 0xBDAB:
                    A = 0xFE; SetZN(A); TotalCycles += 2; PC = 0xBDAD;
                    goto case 0xBDAD;
                case 0xBDAC:
                    { int a = 0xA895 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xBDAF;
                    goto case 0xBDAF;
                case 0xBDAD:
                    _ram[(byte)(0xA8 + X)] = A; TotalCycles += 4; PC = 0xBDAF;
                    goto case 0xBDAF;
                case 0xBDAE:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBDAF;
                    goto case 0xBDAF;
                case 0xBDAF:
                    A = _ram[0x05]; SetZN(A); TotalCycles += 3; PC = 0xBDB1;
                    goto case 0xBDB1;
                case 0xBDB0:
                    A |= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0xBDB2;
                    goto case 0xBDB2;
                case 0xBDB1:
                    TotalCycles += 6; PushU16(0xBDB3); PC = 0xBDF6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBDF6;
                case 0xBDB2:
                    { byte z = (byte)(0xBD + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0xBDB4;
                    goto case 0xBDB4;
                case 0xBDB3:
                    A = ReadMem(0x3190 + X); SetZN(A); TotalCycles += 4; PC = 0xBDB6;
                    goto case 0xBDB6;
                case 0xBDB4:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBDE7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBDE7; }
                    PC = 0xBDB6; goto case 0xBDB6;
                case 0xBDB5:
                    A &= ReadMem(ReadU16Zp(0x98) + Y); SetZN(A); TotalCycles += 5; PC = 0xBDB7;
                    goto case 0xBDB7;
                case 0xBDB6: // === SUBROUTINE: MiscObjectsCore ===
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xBDB7;
                    goto case 0xBDB7;
                case 0xBDB7:
                    Cmp(A, 0x09); TotalCycles += 2; PC = 0xBDB9;
                    goto case 0xBDB9;
                case 0xBDB8:
                    A |= 0x90; SetZN(A); TotalCycles += 2; PC = 0xBDBA;
                    return;
                case 0xBDB9:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBDBD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBDBD; }
                    PC = 0xBDBB; goto case 0xBDBB;
                case 0xBDBB:
                    Sbc(0x05); TotalCycles += 2; PC = 0xBDBD;
                    goto case 0xBDBD;
                case 0xBDBC:
                    A |= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0xBDBE;
                    return;
                case 0xBDBD:
                    TotalCycles += 6; PushU16(0xBDBF); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBDBF:
                    WriteIoReg(0xBDD2, X); TotalCycles += 4; PC = 0xBDC2;
                    goto case 0xBDC2;
                case 0xBDC1:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3B38 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBDC4;
                    goto case 0xBDC4;
                case 0xBDC2:
                    P |= FlagC; TotalCycles += 2; PC = 0xBDC3;
                    return;
                case 0xBDC4:
                    P |= FlagC; TotalCycles += 2; PC = 0xBDC5;
                    return;
                case 0xBDC6:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xBDC7;
                    goto case 0xBDC7;
                case 0xBDC7:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3DD2 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBDCA;
                    return;
                case 0xBDC9:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3DDF + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBDCC;
                    goto case 0xBDCC;
                case 0xBDCB:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3DD5 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBDCE;
                    goto case 0xBDCE;
                case 0xBDCC:
                    Cmp(A, _ram[(byte)(0xBD + X)]); TotalCycles += 4; PC = 0xBDCE;
                    goto case 0xBDCE;
                case 0xBDCD:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3B38 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBDD0;
                    goto case 0xBDD0;
                case 0xBDCE:
                    P |= FlagC; TotalCycles += 2; PC = 0xBDCF;
                    return;
                case 0xBDD0:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0xBDD1;
                    goto case 0xBDD1;
                case 0xBDD1:
                    A = _ram[(0x00A9 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBDD4;
                    goto case 0xBDD4;
                case 0xBDD2:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBDD4;
                    goto case 0xBDD4;
                case 0xBDD3:
                    TotalCycles += 7; PushU16(0xBDD5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBDD4:
                    Bit(_ram[0x02A9]); TotalCycles += 4; PC = 0xBDD7;
                    goto case 0xBDD7;
                case 0xBDD5:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xBDD7;
                    goto case 0xBDD7;
                case 0xBDD7:
                    Bit(_ram[0x03A9]); TotalCycles += 4; PC = 0xBDDA;
                    goto case 0xBDDA;
                case 0xBDD8:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xBDDA;
                    goto case 0xBDDA;
                case 0xBDDA:
                    _ram[0x39] = A; TotalCycles += 3; PC = 0xBDDC;
                    goto case 0xBDDC;
                case 0xBDDB:
                    A &= ReadMem(0x494C + Y); SetZN(A); TotalCycles += 4; PC = 0xBDDE;
                    goto case 0xBDDE;
                case 0xBDDC:
                    TotalCycles += 3; PC = 0xBC49;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBC49;
                case 0xBDDD:
                    A ^= 0xBC; SetZN(A); TotalCycles += 2; PC = 0xBDDF;
                    goto case 0xBDDF;
                case 0xBDDE:
                    Y = _ram[(0x05A2 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0xBDE1;
                    goto case 0xBDE1;
                case 0xBDDF:
                    X = 0x05; SetZN(X); TotalCycles += 2; PC = 0xBDE1;
                    goto case 0xBDE1;
                case 0xBDE0:
                    A |= _ram[0xAC]; SetZN(A); TotalCycles += 3; PC = 0xBDE2;
                    goto case 0xBDE2;
                case 0xBDE1:
                    Y = _ram[0x03EE]; SetZN(Y); TotalCycles += 4; PC = 0xBDE4;
                    goto case 0xBDE4;
                case 0xBDE2:
                    { int a = 0x2003; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBDE5;
                    goto case 0xBDE5;
                case 0xBDE4:
                    TotalCycles += 6; PushU16(0xBDE6); PC = 0xB91E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xB91E;
                case 0xBDE5:
                    { int a = 0x60B9 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0xBDE8;
                    goto case 0xBDE8;
                case 0xBDE6:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x4160 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBDE9;
                    goto case 0xBDE9;
                case 0xBDE7:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBDE8:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xC0 + X)))); TotalCycles += 6; PC = 0xBDEA;
                    return;
                case 0xBDE9:
                    Cmp(Y, 0x5F); TotalCycles += 2; PC = 0xBDEB;
                    goto case 0xBDEB;
                case 0xBDEB:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBDEC:
                    A ^= _ram[(byte)(0x56 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBDEE;
                    return;
                case 0xBDED:
                    { byte z = (byte)(0x57 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0xBDEF;
                    goto case 0xBDEF;
                case 0xBDEF:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0xBDF0;
                    goto case 0xBDF0;
                case 0xBDF0:
                    A ^= ReadMem(0x5B5A + Y); SetZN(A); TotalCycles += 4; PC = 0xBDF3;
                    return;
                case 0xBDF4:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x205E + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBDF7;
                    goto case 0xBDF7;
                case 0xBDF5:
                    { int a = 0x0DA0 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0xBDF8;
                    goto case 0xBDF8;
                case 0xBDF6: // === SUBROUTINE: Sub_BDF6 ===
                    Y = 0x0D; SetZN(Y); TotalCycles += 2; PC = 0xBDF8;
                    goto case 0xBDF8;
                case 0xBDF7:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x68D9]; SetZN(A); TotalCycles += 4; PC = 0xBDFA;
                    goto case 0xBDFA;
                case 0xBDF8:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x3DE8 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xBDFB;
                    goto case 0xBDFB;
                case 0xBDF9:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xBDFA;
                    goto case 0xBDFA;
                case 0xBDFA:
                    A = _ram[(0x04F0 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBDFD;
                    goto case 0xBDFD;
                case 0xBDFB:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBE01; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBE01; }
                    PC = 0xBDFD; goto case 0xBDFD;
                case 0xBDFD:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xBDFE;
                    goto case 0xBDFE;
                case 0xBDFE:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBDF8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBDF8; }
                    PC = 0xBE00; goto case 0xBE00;
                case 0xBDFF:
                    P |= FlagD; TotalCycles += 2; PC = 0xBE00;
                    goto case 0xBE00;
                case 0xBE00:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBE01;
                    goto case 0xBE01;
                case 0xBE01:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBE02: // === SUBROUTINE: Sub_BE02 ===
                    TotalCycles += 6; PushU16(0xBE04); PC = 0xBE1F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBE1F;
                case 0xBE04:
                    X = _ram[(0x01A9 + Y) & 0x07FF]; SetZN(X); TotalCycles += 4; PC = 0xBE07;
                    goto case 0xBE07;
                case 0xBE05:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBE07;
                    goto case 0xBE07;
                case 0xBE06:
                    A |= ReadMem(ReadU16Zp((byte)(0x9D + X))); SetZN(A); TotalCycles += 6; PC = 0xBE08;
                    goto case 0xBE08;
                case 0xBE07:
                    _ram[(0x03EC + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBE0A;
                    goto case 0xBE0A;
                case 0xBE08:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x0503]); TotalCycles += 4; PC = 0xBE0B;
                    goto case 0xBE0B;
                case 0xBE0A:
                    _ram[0xFD] = A; TotalCycles += 3; PC = 0xBE0C;
                    goto case 0xBE0C;
                case 0xBE0B:
                    Sbc(ReadMem(0x4120 + X)); TotalCycles += 4; PC = 0xBE0E;
                    goto case 0xBE0E;
                case 0xBE0C:
                    TotalCycles += 6; PushU16(0xBE0E); PC = 0xBE41;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBE41;
                case 0xBE0D:
                    A ^= ReadMem(ReadU16Zp((byte)(0xBE + X))); SetZN(A); TotalCycles += 6; PC = 0xBE0F;
                    goto case 0xBE0F;
                case 0xBE0E:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x7EA9 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0xBE11;
                    goto case 0xBE11;
                case 0xBE0F:
                    A = 0xFE; SetZN(A); TotalCycles += 2; PC = 0xBE11;
                    goto case 0xBE11;
                case 0xBE10:
                    { int a = 0x9F85 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0xBE13;
                    goto case 0xBE13;
                case 0xBE11:
                    _ram[0x9F] = A; TotalCycles += 3; PC = 0xBE13;
                    goto case 0xBE13;
                case 0xBE13:
                    A = 0x05; SetZN(A); TotalCycles += 2; PC = 0xBE15;
                    goto case 0xBE15;
                case 0xBE14:
                    A |= _ram[0x8D]; SetZN(A); TotalCycles += 3; PC = 0xBE16;
                    goto case 0xBE16;
                case 0xBE15:
                    _ram[0x0139] = A; TotalCycles += 4; PC = 0xBE18;
                    goto case 0xBE18;
                case 0xBE16:
                    A &= ReadMem(0x2001 + Y); SetZN(A); TotalCycles += 4; PC = 0xBE19;
                    return;
                case 0xBE17:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0xBE19;
                    return;
                case 0xBE18:
                    TotalCycles += 6; PushU16(0xBE1A); PC = 0xBC27;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBC27;
                case 0xBE1A:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x6EAE + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0xBE1D;
                    return;
                case 0xBE1B:
                    X = _ram[0x03EE]; SetZN(X); TotalCycles += 4; PC = 0xBE1E;
                    goto case 0xBE1E;
                case 0xBE1C:
                    { int a = 0x6003; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBE1F;
                    goto case 0xBE1F;
                case 0xBE1E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBE1F: // === SUBROUTINE: Sub_BE1F ===
                    X = _ram[0x03EE]; SetZN(X); TotalCycles += 4; PC = 0xBE22;
                    goto case 0xBE22;
                case 0xBE20:
                    { int a = 0xA403; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBE23;
                    return;
                case 0xBE22:
                    Y = _ram[0x02]; SetZN(Y); TotalCycles += 3; PC = 0xBE24;
                    goto case 0xBE24;
                case 0xBE24:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBE40; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBE40; }
                    PC = 0xBE26; goto case 0xBE26;
                case 0xBE26:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xBE27;
                    goto case 0xBE27;
                case 0xBE27:
                    P |= FlagC; TotalCycles += 2; PC = 0xBE28;
                    goto case 0xBE28;
                case 0xBE28:
                    Sbc(0x10); TotalCycles += 2; PC = 0xBE2A;
                    goto case 0xBE2A;
                case 0xBE29:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBDB0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBDB0; }
                    PC = 0xBE2B; return;
                case 0xBE2A:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xBE2C;
                    goto case 0xBE2C;
                case 0xBE2C:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBE2D;
                    goto case 0xBE2D;
                case 0xBE2D:
                    A = ReadMem(ReadU16Zp(0x06) + Y); SetZN(A); TotalCycles += 5; PC = 0xBE2F;
                    goto case 0xBE2F;
                case 0xBE2E:
                    _ram[0xC9] = Asl(_ram[0xC9]); TotalCycles += 5; PC = 0xBE30;
                    return;
                case 0xBE2F:
                    Cmp(A, 0xC2); TotalCycles += 2; PC = 0xBE31;
                    goto case 0xBE31;
                case 0xBE31:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBE40; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBE40; }
                    PC = 0xBE33; goto case 0xBE33;
                case 0xBE32:
                    A |= _ram[0x00A9]; SetZN(A); TotalCycles += 4; PC = 0xBE35;
                    goto case 0xBE35;
                case 0xBE33:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBE35;
                    goto case 0xBE35;
                case 0xBE34:
                    TotalCycles += 7; PushU16(0xBE36); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBE35:
                    WriteMem(ReadU16Zp(0x06) + Y, A); TotalCycles += 6; PC = 0xBE37;
                    goto case 0xBE37;
                case 0xBE36:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xBE38;
                    goto case 0xBE38;
                case 0xBE37:
                    TotalCycles += 6; PushU16(0xBE39); PC = 0x8A4D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBE38:
                    A ^= SmbEmbeddedAssets.StaticDataTables[0x2E8A]; SetZN(A); TotalCycles += 4; PC = 0xBE3B;
                    goto case 0xBE3B;
                case 0xBE39:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xBE3A;
                    goto case 0xBE3A;
                case 0xBE3A:
                    X = _ram[0x03EE]; SetZN(X); TotalCycles += 4; PC = 0xBE3D;
                    goto case 0xBE3D;
                case 0xBE3B:
                    { int a = 0x2003; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBE3E;
                    goto case 0xBE3E;
                case 0xBE3D:
                    TotalCycles += 6; PushU16(0xBE3F); PC = 0xBB51;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBB51;
                case 0xBE3E:
                    A ^= ReadMem(ReadU16Zp(0xBB) + Y); SetZN(A); TotalCycles += 5; PC = 0xBE40;
                    goto case 0xBE40;
                case 0xBE40:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBE41: // === SUBROUTINE: Sub_BE41 ===
                    A = _ram[(byte)(0x8F + X)]; SetZN(A); TotalCycles += 4; PC = 0xBE43;
                    goto case 0xBE43;
                case 0xBE43:
                    _ram[(0x03F1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBE46;
                    goto case 0xBE46;
                case 0xBE44:
                    Sbc(ReadMem(ReadU16Zp(0x03) + Y)); TotalCycles += 5; PC = 0xBE46;
                    goto case 0xBE46;
                case 0xBE46:
                    A = 0xF0; SetZN(A); TotalCycles += 2; PC = 0xBE48;
                    goto case 0xBE48;
                case 0xBE47:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBDDE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBDDE; }
                    PC = 0xBE49; goto case 0xBE49;
                case 0xBE48:
                    _ram[(byte)(0x60 + X)] = A; TotalCycles += 4; PC = 0xBE4A;
                    goto case 0xBE4A;
                case 0xBE49:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBE4A:
                    _ram[(byte)(0x62 + X)] = A; TotalCycles += 4; PC = 0xBE4C;
                    goto case 0xBE4C;
                case 0xBE4C:
                    A = 0xFA; SetZN(A); TotalCycles += 2; PC = 0xBE4E;
                    goto case 0xBE4E;
                case 0xBE4E:
                    _ram[(byte)(0xA8 + X)] = A; TotalCycles += 4; PC = 0xBE50;
                    goto case 0xBE50;
                case 0xBE4F:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBE50;
                    goto case 0xBE50;
                case 0xBE50:
                    A = 0xFC; SetZN(A); TotalCycles += 2; PC = 0xBE52;
                    goto case 0xBE52;
                case 0xBE52:
                    _ram[(byte)(0xAA + X)] = A; TotalCycles += 4; PC = 0xBE54;
                    goto case 0xBE54;
                case 0xBE53:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xBE54;
                    goto case 0xBE54;
                case 0xBE54:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBE56;
                    goto case 0xBE56;
                case 0xBE55:
                    TotalCycles += 7; PushU16(0xBE57); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBE56:
                    _ram[(0x043C + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBE59;
                    goto case 0xBE59;
                case 0xBE59:
                    _ram[(0x043E + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBE5C;
                    goto case 0xBE5C;
                case 0xBE5A:
                    { int a = 0xB504 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xBE5D;
                    goto case 0xBE5D;
                case 0xBE5C:
                    A = _ram[(byte)(0x76 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBE5E;
                    goto case 0xBE5E;
                case 0xBE5D:
                    { byte z = (byte)(0x95 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0xBE5F;
                    goto case 0xBE5F;
                case 0xBE5E:
                    _ram[(byte)(0x78 + X)] = A; TotalCycles += 4; PC = 0xBE60;
                    goto case 0xBE60;
                case 0xBE5F:
                    P |= FlagI; TotalCycles += 2; PC = 0xBE60;
                    goto case 0xBE60;
                case 0xBE60:
                    A = _ram[(byte)(0x8F + X)]; SetZN(A); TotalCycles += 4; PC = 0xBE62;
                    goto case 0xBE62;
                case 0xBE62:
                    _ram[(byte)(0x91 + X)] = A; TotalCycles += 4; PC = 0xBE64;
                    goto case 0xBE64;
                case 0xBE63:
                    WriteMem(ReadU16Zp(0xB5) + Y, A); TotalCycles += 6; PC = 0xBE65;
                    return;
                case 0xBE64:
                    A = _ram[(byte)(0xD7 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBE66;
                    goto case 0xBE66;
                case 0xBE66:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBE67;
                    goto case 0xBE67;
                case 0xBE67:
                    Adc(0x08); TotalCycles += 2; PC = 0xBE69;
                    goto case 0xBE69;
                case 0xBE68:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBE69;
                    goto case 0xBE69;
                case 0xBE69:
                    _ram[(byte)(0xD9 + X)] = A; TotalCycles += 4; PC = 0xBE6B;
                    goto case 0xBE6B;
                case 0xBE6A:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7AA9 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xBE6D;
                    goto case 0xBE6D;
                case 0xBE6B:
                    A = 0xFA; SetZN(A); TotalCycles += 2; PC = 0xBE6D;
                    goto case 0xBE6D;
                case 0xBE6D:
                    _ram[(byte)(0xA8 + X)] = A; TotalCycles += 4; PC = 0xBE6F;
                    goto case 0xBE6F;
                case 0xBE6E:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBE6F;
                    goto case 0xBE6F;
                case 0xBE6F:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBE70: // === SUBROUTINE: Sub_BE70 ===
                    A = _ram[(byte)(0x26 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBE72;
                    goto case 0xBE72;
                case 0xBE71:
                    _ram[0xF0] = Rol(_ram[0xF0]); TotalCycles += 5; PC = 0xBE73;
                    goto case 0xBE73;
                case 0xBE72:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBED1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBED1; }
                    PC = 0xBE74; goto case 0xBE74;
                case 0xBE73:
                    A ^= ReadMem(0x0F29 + X); SetZN(A); TotalCycles += 4; PC = 0xBE76;
                    goto case 0xBE76;
                case 0xBE74:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0xBE76;
                    goto case 0xBE76;
                case 0xBE76:
                    PushU8(A); TotalCycles += 3; PC = 0xBE77;
                    goto case 0xBE77;
                case 0xBE77:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBE78;
                    goto case 0xBE78;
                case 0xBE78:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xBE79;
                    goto case 0xBE79;
                case 0xBE79:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBE7A;
                    goto case 0xBE7A;
                case 0xBE7A:
                    Adc(0x09); TotalCycles += 2; PC = 0xBE7C;
                    goto case 0xBE7C;
                case 0xBE7B:
                    A |= 0xAA; SetZN(A); TotalCycles += 2; PC = 0xBE7D;
                    goto case 0xBE7D;
                case 0xBE7C:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xBE7D;
                    goto case 0xBE7D;
                case 0xBE7D:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xBE7E;
                    goto case 0xBE7E;
                case 0xBE7E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBEB3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBEB3; }
                    PC = 0xBE80; goto case 0xBE80;
                case 0xBE80:
                    TotalCycles += 6; PushU16(0xBE82); PC = 0xBFA4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFA4;
                case 0xBE81:
                    Y = _ram[0xBF]; SetZN(Y); TotalCycles += 3; PC = 0xBE83;
                    goto case 0xBE83;
                case 0xBE83:
                    TotalCycles += 6; PushU16(0xBE85); PC = 0xBF0F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF0F;
                case 0xBE86:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xBE87;
                    goto case 0xBE87;
                case 0xBE87:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBE88;
                    goto case 0xBE88;
                case 0xBE88:
                    Adc(0x02); TotalCycles += 2; PC = 0xBE8A;
                    goto case 0xBE8A;
                case 0xBE8A:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xBE8B;
                    goto case 0xBE8B;
                case 0xBE8B:
                    TotalCycles += 6; PushU16(0xBE8D); PC = 0xBFA4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFA4;
                case 0xBE8C:
                    Y = _ram[0xBF]; SetZN(Y); TotalCycles += 3; PC = 0xBE8E;
                    goto case 0xBE8E;
                case 0xBE8E:
                    TotalCycles += 6; PushU16(0xBE90); PC = 0xBF0F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF0F;
                case 0xBE91:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBE93;
                    goto case 0xBE93;
                case 0xBE92:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBE93;
                    goto case 0xBE93;
                case 0xBE93:
                    TotalCycles += 6; PushU16(0xBE95); PC = 0xF159;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBE94:
                    A ^= ReadMem(0x20F1 + Y); SetZN(A); TotalCycles += 4; PC = 0xBE97;
                    goto case 0xBE97;
                case 0xBE95:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBE97;
                    goto case 0xBE97;
                case 0xBE96:
                    TotalCycles += 6; PushU16(0xBE98); PC = 0xF1B6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBE97:
                    X = _ram[(byte)(0xF1 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xBE99;
                    goto case 0xBE99;
                case 0xBE98:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBE9A;
                    return;
                case 0xBE99:
                    TotalCycles += 6; PushU16(0xBE9B); PC = 0xEC53;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBE9B:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x3468]); TotalCycles += 4; PC = 0xBE9E;
                    goto case 0xBE9E;
                case 0xBE9C:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xBE9D;
                    goto case 0xBE9D;
                case 0xBE9D:
                    Y = _ram[(byte)(0xBE + X)]; SetZN(Y); TotalCycles += 4; PC = 0xBE9F;
                    goto case 0xBE9F;
                case 0xBE9E:
                    X = ReadMem(0x30F0 + Y); SetZN(X); TotalCycles += 4; PC = 0xBEA1;
                    goto case 0xBEA1;
                case 0xBE9F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBED1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBED1; }
                    PC = 0xBEA1; goto case 0xBEA1;
                case 0xBEA0:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0xBEEA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0xBEA2; goto case 0xBEA2;
                case 0xBEA1:
                    PushU8(A); TotalCycles += 3; PC = 0xBEA2;
                    goto case 0xBEA2;
                case 0xBEA2:
                    A = 0xF0; SetZN(A); TotalCycles += 2; PC = 0xBEA4;
                    goto case 0xBEA4;
                case 0xBEA3:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBE7A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBE7A; }
                    PC = 0xBEA5; goto case 0xBEA5;
                case 0xBEA4:
                    Cmp(A, _ram[(byte)(0xD9 + X)]); TotalCycles += 4; PC = 0xBEA6;
                    goto case 0xBEA6;
                case 0xBEA5:
                    Cmp(A, _ram[(0x02B0 + Y) & 0x07FF]); TotalCycles += 4; PC = 0xBEA8;
                    goto case 0xBEA8;
                case 0xBEA6:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xBEAA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBEAA; }
                    PC = 0xBEA8; goto case 0xBEA8;
                case 0xBEA8:
                    _ram[(byte)(0xD9 + X)] = A; TotalCycles += 4; PC = 0xBEAA;
                    goto case 0xBEAA;
                case 0xBEA9:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x57B5 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0xBEAC;
                    goto case 0xBEAC;
                case 0xBEAA:
                    A = _ram[(byte)(0xD7 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBEAC;
                    goto case 0xBEAC;
                case 0xBEAC:
                    Cmp(A, 0xF0); TotalCycles += 2; PC = 0xBEAE;
                    goto case 0xBEAE;
                case 0xBEAD:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBF17; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF17; }
                    PC = 0xBEAF; goto case 0xBEAF;
                case 0xBEAE:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xBEAF;
                    goto case 0xBEAF;
                case 0xBEAF:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBED1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBED1; }
                    PC = 0xBEB1; goto case 0xBEB1;
                case 0xBEB0:
                    TotalCycles += 6; PushU16(0xBEB2); PC = 0x1CB0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBEB1:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xBECF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBECF; }
                    PC = 0xBEB3; goto case 0xBEB3;
                case 0xBEB3:
                    TotalCycles += 6; PushU16(0xBEB5); PC = 0xBFA4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFA4;
                case 0xBEB4:
                    Y = _ram[0xBF]; SetZN(Y); TotalCycles += 3; PC = 0xBEB6;
                    goto case 0xBEB6;
                case 0xBEB6:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBEB8;
                    goto case 0xBEB8;
                case 0xBEB7:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBEB8;
                    goto case 0xBEB8;
                case 0xBEB8:
                    TotalCycles += 6; PushU16(0xBEBA); PC = 0xF159;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBEB9:
                    A ^= ReadMem(0x20F1 + Y); SetZN(A); TotalCycles += 4; PC = 0xBEBC;
                    goto case 0xBEBC;
                case 0xBEBA:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBEBC;
                    goto case 0xBEBC;
                case 0xBEBB:
                    TotalCycles += 6; PushU16(0xBEBD); PC = 0xF1B6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBEBC:
                    X = _ram[(byte)(0xF1 + Y)]; SetZN(X); TotalCycles += 4; PC = 0xBEBE;
                    goto case 0xBEBE;
                case 0xBEBD:
                    Sbc(ReadMem(ReadU16Zp(0x20) + Y)); TotalCycles += 5; PC = 0xBEBF;
                    goto case 0xBEBF;
                case 0xBEBE:
                    TotalCycles += 6; PushU16(0xBEC0); PC = 0xEBD1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBEBF:
                    Cmp(A, ReadMem(ReadU16Zp(0xEB) + Y)); TotalCycles += 5; PC = 0xBEC1;
                    goto case 0xBEC1;
                case 0xBEC1:
                    A = _ram[(byte)(0xD7 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBEC3;
                    goto case 0xBEC3;
                case 0xBEC3:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0xBEC5;
                    goto case 0xBEC5;
                case 0xBEC5:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xBEC7;
                    goto case 0xBEC7;
                case 0xBEC6:
                    A |= _ram[0x68]; SetZN(A); TotalCycles += 3; PC = 0xBEC8;
                    goto case 0xBEC8;
                case 0xBEC7:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xBEC8;
                    goto case 0xBEC8;
                case 0xBEC8:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0xBED1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBED1; }
                    PC = 0xBECA; goto case 0xBECA;
                case 0xBECA:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBECC;
                    goto case 0xBECC;
                case 0xBECB:
                    A |= ReadMem(ReadU16Zp((byte)(0x9D + X))); SetZN(A); TotalCycles += 6; PC = 0xBECD;
                    goto case 0xBECD;
                case 0xBECC:
                    _ram[(0x03EC + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBECF;
                    goto case 0xBECF;
                case 0xBECD:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x2903]); TotalCycles += 4; PC = 0xBED0;
                    goto case 0xBED0;
                case 0xBECF:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBED1;
                    goto case 0xBED1;
                case 0xBED0:
                    TotalCycles += 7; PushU16(0xBED2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBED1:
                    _ram[(byte)(0x26 + X)] = A; TotalCycles += 4; PC = 0xBED3;
                    goto case 0xBED3;
                case 0xBED2:
                    _ram[0x60] = Rol(_ram[0x60]); TotalCycles += 5; PC = 0xBED4;
                    goto case 0xBED4;
                case 0xBED3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBED4: // === SUBROUTINE: Sub_BED4 ===
                    X = 0x01; SetZN(X); TotalCycles += 2; PC = 0xBED6;
                    goto case 0xBED6;
                case 0xBED5:
                    A |= ReadMem(ReadU16Zp((byte)(0x86 + X))); SetZN(A); TotalCycles += 6; PC = 0xBED7;
                    goto case 0xBED7;
                case 0xBED6:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0xBED8;
                    goto case 0xBED8;
                case 0xBED7:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBED8;
                    goto case 0xBED8;
                case 0xBED8:
                    A = _ram[0x0301]; SetZN(A); TotalCycles += 4; PC = 0xBEDB;
                    goto case 0xBEDB;
                case 0xBED9:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0xBEDB;
                    goto case 0xBEDB;
                case 0xBEDB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBEFE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBEFE; }
                    PC = 0xBEDD; goto case 0xBEDD;
                case 0xBEDC:
                    A &= ReadMem(ReadU16Zp((byte)(0xBD + X))); SetZN(A); TotalCycles += 6; PC = 0xBEDE;
                    goto case 0xBEDE;
                case 0xBEDD:
                    A = _ram[(0x03EC + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBEE0;
                    goto case 0xBEE0;
                case 0xBEDE:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x7003]); TotalCycles += 4; PC = 0xBEE1;
                    return;
                case 0xBEE0:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBEFE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBEFE; }
                    PC = 0xBEE2; goto case 0xBEE2;
                case 0xBEE2:
                    A = _ram[(0x03E6 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBEE5;
                    goto case 0xBEE5;
                case 0xBEE3:
                    _ram[0x03] = IncVal(_ram[0x03]); TotalCycles += 5; PC = 0xBEE5;
                    goto case 0xBEE5;
                case 0xBEE5:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0xBEE7;
                    goto case 0xBEE7;
                case 0xBEE6:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0xBEE8;
                    goto case 0xBEE8;
                case 0xBEE7:
                    A = 0x05; SetZN(A); TotalCycles += 2; PC = 0xBEE9;
                    goto case 0xBEE9;
                case 0xBEE8:
                    A |= _ram[0x85]; SetZN(A); TotalCycles += 3; PC = 0xBEEA;
                    return;
                case 0xBEE9:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0xBEEB;
                    goto case 0xBEEB;
                case 0xBEEB:
                    A = _ram[(0x03E4 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBEEE;
                    goto case 0xBEEE;
                case 0xBEEC:
                    Cmp(X, _ram[0x03]); TotalCycles += 3; PC = 0xBEEE;
                    goto case 0xBEEE;
                case 0xBEEE:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xBEF0;
                    goto case 0xBEF0;
                case 0xBEF0:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBEF1;
                    goto case 0xBEF1;
                case 0xBEF1:
                    A = _ram[(0x03E8 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBEF4;
                    goto case 0xBEF4;
                case 0xBEF2:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xBEF3;
                    return;
                case 0xBEF4:
                    WriteMem(ReadU16Zp(0x06) + Y, A); TotalCycles += 6; PC = 0xBEF6;
                    goto case 0xBEF6;
                case 0xBEF5:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0xBEF7;
                    goto case 0xBEF7;
                case 0xBEF6:
                    TotalCycles += 6; PushU16(0xBEF8); PC = 0x8A61;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBEF7:
                    Adc(ReadMem(ReadU16Zp((byte)(0x8A + X)))); TotalCycles += 6; PC = 0xBEF9;
                    goto case 0xBEF9;
                case 0xBEF8:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0xBEF9;
                    goto case 0xBEF9;
                case 0xBEF9:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBEFB;
                    goto case 0xBEFB;
                case 0xBEFA:
                    TotalCycles += 7; PushU16(0xBEFC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBEFB:
                    _ram[(0x03EC + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBEFE;
                    goto case 0xBEFE;
                case 0xBEFC:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x4A03]); TotalCycles += 4; PC = 0xBEFF;
                    goto case 0xBEFF;
                case 0xBEFE:
                    X--; SetZN(X); TotalCycles += 2; PC = 0xBEFF;
                    goto case 0xBEFF;
                case 0xBEFF:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBED6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBED6; }
                    PC = 0xBF01; goto case 0xBF01;
                case 0xBF00:
                    Cmp(A, _ram[(byte)(0x60 + X)]); TotalCycles += 4; PC = 0xBF02;
                    goto case 0xBF02;
                case 0xBF01:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBF02: // === SUBROUTINE: Sub_BF02 ===
                    X++; SetZN(X); TotalCycles += 2; PC = 0xBF03;
                    goto case 0xBF03;
                case 0xBF03:
                    TotalCycles += 6; PushU16(0xBF05); PC = 0xBF0F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF0F;
                case 0xBF06:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBF08;
                    goto case 0xBF08;
                case 0xBF07:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBF08;
                    goto case 0xBF08;
                case 0xBF08:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBF09: // === SUBROUTINE: Sub_BF09 ===
                    A = _ram[0x070E]; SetZN(A); TotalCycles += 4; PC = 0xBF0C;
                    goto case 0xBF0C;
                case 0xBF0A:
                    { int a = 0xD007; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xBF0D;
                    goto case 0xBF0D;
                case 0xBF0C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBF4C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF4C; }
                    PC = 0xBF0E; goto case 0xBF0E;
                case 0xBF0D:
                    { int a = 0xB5AA + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0xBF10;
                    return;
                case 0xBF0E:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0xBF0F;
                    goto case 0xBF0F;
                case 0xBF0F: // === SUBROUTINE: Sub_BF0F ===
                    A = _ram[(byte)(0x57 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBF11;
                    goto case 0xBF11;
                case 0xBF11:
                    A = Asl(A); TotalCycles += 2; PC = 0xBF12;
                    goto case 0xBF12;
                case 0xBF12:
                    A = Asl(A); TotalCycles += 2; PC = 0xBF13;
                    goto case 0xBF13;
                case 0xBF13:
                    A = Asl(A); TotalCycles += 2; PC = 0xBF14;
                    goto case 0xBF14;
                case 0xBF14:
                    A = Asl(A); TotalCycles += 2; PC = 0xBF15;
                    goto case 0xBF15;
                case 0xBF15:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xBF17;
                    goto case 0xBF17;
                case 0xBF16:
                    A |= ReadMem(ReadU16Zp((byte)(0xB5 + X))); SetZN(A); TotalCycles += 6; PC = 0xBF18;
                    return;
                case 0xBF17:
                    A = _ram[(byte)(0x57 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBF19;
                    goto case 0xBF19;
                case 0xBF19:
                    A = Lsr(A); TotalCycles += 2; PC = 0xBF1A;
                    goto case 0xBF1A;
                case 0xBF1A:
                    A = Lsr(A); TotalCycles += 2; PC = 0xBF1B;
                    goto case 0xBF1B;
                case 0xBF1B:
                    A = Lsr(A); TotalCycles += 2; PC = 0xBF1C;
                    goto case 0xBF1C;
                case 0xBF1C:
                    A = Lsr(A); TotalCycles += 2; PC = 0xBF1D;
                    goto case 0xBF1D;
                case 0xBF1D:
                    Cmp(A, 0x08); TotalCycles += 2; PC = 0xBF1F;
                    goto case 0xBF1F;
                case 0xBF1E:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBF1F;
                    goto case 0xBF1F;
                case 0xBF1F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0xBF23; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF23; }
                    PC = 0xBF21; goto case 0xBF21;
                case 0xBF21:
                    A |= 0xF0; SetZN(A); TotalCycles += 2; PC = 0xBF23;
                    goto case 0xBF23;
                case 0xBF22:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0xBEA9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBEA9; }
                    PC = 0xBF24; goto case 0xBF24;
                case 0xBF23:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xBF25;
                    goto case 0xBF25;
                case 0xBF24:
                    TotalCycles += 7; PushU16(0xBF26); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF25:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xBF27;
                    goto case 0xBF27;
                case 0xBF26:
                    TotalCycles += 7; PushU16(0xBF28); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF27:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0xBF29;
                    goto case 0xBF29;
                case 0xBF28:
                    TotalCycles += 7; PushU16(0xBF2A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF29:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBF2C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF2C; }
                    PC = 0xBF2B; goto case 0xBF2B;
                case 0xBF2A:
                    A |= ReadMem(ReadU16Zp((byte)(0x88 + X))); SetZN(A); TotalCycles += 6; PC = 0xBF2C;
                    goto case 0xBF2C;
                case 0xBF2B:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xBF2C;
                    goto case 0xBF2C;
                case 0xBF2C:
                    _ram[0x02] = Y; TotalCycles += 3; PC = 0xBF2E;
                    goto case 0xBF2E;
                case 0xBF2E:
                    A = _ram[(0x0400 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBF31;
                    goto case 0xBF31;
                case 0xBF2F:
                    TotalCycles += 7; PushU16(0xBF31); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF31:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBF32;
                    goto case 0xBF32;
                case 0xBF32:
                    Adc(_ram[0x01]); TotalCycles += 3; PC = 0xBF34;
                    goto case 0xBF34;
                case 0xBF33:
                    A |= ReadMem(ReadU16Zp((byte)(0x9D + X))); SetZN(A); TotalCycles += 6; PC = 0xBF35;
                    goto case 0xBF35;
                case 0xBF34:
                    _ram[(0x0400 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBF37;
                    goto case 0xBF37;
                case 0xBF35:
                    TotalCycles += 7; PushU16(0xBF37); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF37:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBF39;
                    goto case 0xBF39;
                case 0xBF38:
                    TotalCycles += 7; PushU16(0xBF3A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF39:
                    A = Rol(A); TotalCycles += 2; PC = 0xBF3A;
                    goto case 0xBF3A;
                case 0xBF3A:
                    PushU8(A); TotalCycles += 3; PC = 0xBF3B;
                    goto case 0xBF3B;
                case 0xBF3B:
                    A = Ror(A); TotalCycles += 2; PC = 0xBF3C;
                    goto case 0xBF3C;
                case 0xBF3C:
                    A = _ram[(byte)(0x86 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBF3E;
                    goto case 0xBF3E;
                case 0xBF3D:
                    _ram[0x65] = X; TotalCycles += 3; PC = 0xBF3F;
                    goto case 0xBF3F;
                case 0xBF3E:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0xBF40;
                    goto case 0xBF40;
                case 0xBF3F:
                    TotalCycles += 7; PushU16(0xBF41); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF40:
                    _ram[(byte)(0x86 + X)] = A; TotalCycles += 4; PC = 0xBF42;
                    goto case 0xBF42;
                case 0xBF41:
                    _ram[0xB5] = X; TotalCycles += 3; PC = 0xBF43;
                    goto case 0xBF43;
                case 0xBF42:
                    A = _ram[(byte)(0x6D + X)]; SetZN(A); TotalCycles += 4; PC = 0xBF44;
                    goto case 0xBF44;
                case 0xBF43:
                    Adc(_ram[0x0265]); TotalCycles += 4; PC = 0xBF46;
                    goto case 0xBF46;
                case 0xBF44:
                    Adc(_ram[0x02]); TotalCycles += 3; PC = 0xBF46;
                    goto case 0xBF46;
                case 0xBF46:
                    _ram[(byte)(0x6D + X)] = A; TotalCycles += 4; PC = 0xBF48;
                    goto case 0xBF48;
                case 0xBF47:
                    Adc(_ram[0x0068]); TotalCycles += 4; PC = 0xBF4A;
                    goto case 0xBF4A;
                case 0xBF48:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xBF49;
                    goto case 0xBF49;
                case 0xBF49:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBF4A;
                    goto case 0xBF4A;
                case 0xBF4A:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0xBF4C;
                    goto case 0xBF4C;
                case 0xBF4B:
                    TotalCycles += 7; PushU16(0xBF4D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF4C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBF4D:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0xBF4F;
                    goto case 0xBF4F;
                case 0xBF4E:
                    TotalCycles += 7; PushU16(0xBF50); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF4F:
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0xBF52;
                    goto case 0xBF52;
                case 0xBF52:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBF59; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF59; }
                    PC = 0xBF54; goto case 0xBF54;
                case 0xBF53:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0xBF55;
                    goto case 0xBF55;
                case 0xBF54:
                    A = _ram[0x070E]; SetZN(A); TotalCycles += 4; PC = 0xBF57;
                    goto case 0xBF57;
                case 0xBF55:
                    { int a = 0xD007; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0xBF58;
                    return;
                case 0xBF57:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBF4C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF4C; }
                    PC = 0xBF59; goto case 0xBF59;
                case 0xBF59:
                    A = _ram[0x0709]; SetZN(A); TotalCycles += 4; PC = 0xBF5C;
                    goto case 0xBF5C;
                case 0xBF5A:
                    A |= 0x07; SetZN(A); TotalCycles += 2; PC = 0xBF5C;
                    goto case 0xBF5C;
                case 0xBF5C:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xBF5E;
                    goto case 0xBF5E;
                case 0xBF5D:
                    TotalCycles += 7; PushU16(0xBF5F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF5E:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0xBF60;
                    goto case 0xBF60;
                case 0xBF60:
                    TotalCycles += 3; PC = 0xBFAD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFAD;
                case 0xBF61:
                    A = SmbEmbeddedAssets.StaticDataTables[0x20BF]; SetZN(A); TotalCycles += 4; PC = 0xBF64;
                    goto case 0xBF64;
                case 0xBF63: // === SUBROUTINE: Sub_BF63 ===
                    Y = 0x3D; SetZN(Y); TotalCycles += 2; PC = 0xBF65;
                    goto case 0xBF65;
                case 0xBF64:
                    A &= ReadMem(0x1EB5 + X); SetZN(A); TotalCycles += 4; PC = 0xBF67;
                    goto case 0xBF67;
                case 0xBF65:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0xBF67;
                    goto case 0xBF67;
                case 0xBF66:
                    { int a = (0x05C9 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0xBF69;
                    goto case 0xBF69;
                case 0xBF67:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0xBF69;
                    goto case 0xBF69;
                case 0xBF68:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0xBF6A;
                    return;
                case 0xBF69:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBF6D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF6D; }
                    PC = 0xBF6B; goto case 0xBF6B;
                case 0xBF6B: // === SUBROUTINE: Sub_BF6B ===
                    Y = 0x20; SetZN(Y); TotalCycles += 2; PC = 0xBF6D;
                    goto case 0xBF6D;
                case 0xBF6C:
                    TotalCycles += 6; PushU16(0xBF6E); PC = 0x944C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0xBF6D:
                    TotalCycles += 3; PC = 0xBF94;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF94;
                case 0xBF6E:
                    _ram[(byte)(0xBF + X)] = Y; TotalCycles += 4; PC = 0xBF70;
                    goto case 0xBF70;
                case 0xBF70: // === SUBROUTINE: Sub_BF70 ===
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xBF72;
                    goto case 0xBF72;
                case 0xBF71:
                    TotalCycles += 7; PushU16(0xBF73); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF72:
                    TotalCycles += 3; PC = 0xBF77;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBF77;
                case 0xBF75: // === SUBROUTINE: Sub_BF75 ===
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xBF77;
                    goto case 0xBF77;
                case 0xBF76:
                    A |= ReadMem(ReadU16Zp((byte)(0xE8 + X))); SetZN(A); TotalCycles += 6; PC = 0xBF78;
                    goto case 0xBF78;
                case 0xBF77:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xBF78;
                    goto case 0xBF78;
                case 0xBF78:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xBF7A;
                    goto case 0xBF7A;
                case 0xBF7A:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xBF7C;
                    goto case 0xBF7C;
                case 0xBF7B:
                    TotalCycles += 7; PushU16(0xBF7D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF7C:
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0xBF7E;
                    goto case 0xBF7E;
                case 0xBF7D:
                    _ram[0x85] = Asl(_ram[0x85]); TotalCycles += 5; PC = 0xBF7F;
                    goto case 0xBF7F;
                case 0xBF7E:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xBF80;
                    goto case 0xBF80;
                case 0xBF7F:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0xBF81;
                    return;
                case 0xBF80:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xBF82;
                    goto case 0xBF82;
                case 0xBF82:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xBF84;
                    goto case 0xBF84;
                case 0xBF84:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0xBF85;
                    goto case 0xBF85;
                case 0xBF85:
                    TotalCycles += 3; PC = 0xBFD1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFD1;
                case 0xBF86: // === SUBROUTINE: Sub_BF86 ===
                    Cmp(A, ReadMem(ReadU16Zp(0xBF) + Y)); TotalCycles += 5; PC = 0xBF88;
                    goto case 0xBF88;
                case 0xBF88: // === SUBROUTINE: Sub_BF88 ===
                    Y = 0x7F; SetZN(Y); TotalCycles += 2; PC = 0xBF8A;
                    goto case 0xBF8A;
                case 0xBF8A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBF8E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF8E; }
                    PC = 0xBF8C; goto case 0xBF8C;
                case 0xBF8C: // === SUBROUTINE: Sub_BF8C ===
                    Y = 0x0F; SetZN(Y); TotalCycles += 2; PC = 0xBF8E;
                    goto case 0xBF8E;
                case 0xBF8E:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0xBF90;
                    goto case 0xBF90;
                case 0xBF90:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBF96; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF96; }
                    PC = 0xBF92; goto case 0xBF92;
                case 0xBF92: // === SUBROUTINE: Sub_BF92 ===
                    Y = 0x1C; SetZN(Y); TotalCycles += 2; PC = 0xBF94;
                    goto case 0xBF94;
                case 0xBF94:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xBF96;
                    goto case 0xBF96;
                case 0xBF96:
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0xBF98;
                    goto case 0xBF98;
                case 0xBF97:
                    TotalCycles += 7; PushU16(0xBF99); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBF98:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xBF99;
                    goto case 0xBF99;
                case 0xBF99:
                    TotalCycles += 6; PushU16(0xBF9B); PC = 0xBFAD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFAD;
                case 0xBF9A:
                    A = SmbEmbeddedAssets.StaticDataTables[0x26BF]; SetZN(A); TotalCycles += 4; PC = 0xBF9D;
                    goto case 0xBF9D;
                case 0xBF9C:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBF9E;
                    goto case 0xBF9E;
                case 0xBF9D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBF9E;
                    goto case 0xBF9E;
                case 0xBF9E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBF9F: // === SUBROUTINE: Sub_BF9F ===
                    _ram[0x08] = Asl(_ram[0x08]); TotalCycles += 5; PC = 0xBFA1;
                    goto case 0xBFA1;
                case 0xBFA0:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBFA1;
                    goto case 0xBFA1;
                case 0xBFA1:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xBFA3;
                    goto case 0xBFA3;
                case 0xBFA2:
                    TotalCycles += 7; PushU16(0xBFA4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBFA3:
                    Bit(_ram[0x01A0]); TotalCycles += 4; PC = 0xBFA6;
                    goto case 0xBFA6;
                case 0xBFA4: // === SUBROUTINE: Sub_BFA4 ===
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0xBFA6;
                    goto case 0xBFA6;
                case 0xBFA5:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0xBFA7;
                    goto case 0xBFA7;
                case 0xBFA6:
                    A = 0x50; SetZN(A); TotalCycles += 2; PC = 0xBFA8;
                    goto case 0xBFA8;
                case 0xBFA7:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0xBF2E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBF2E; }
                    PC = 0xBFA9; goto case 0xBFA9;
                case 0xBFA8:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xBFAA;
                    goto case 0xBFAA;
                case 0xBFA9:
                    TotalCycles += 7; PushU16(0xBFAB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBFAA:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3F9F + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0xBFAD;
                    goto case 0xBFAD;
                case 0xBFAD: // === SUBROUTINE: Sub_BFAD ===
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xBFAF;
                    goto case 0xBFAF;
                case 0xBFAF:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBFB1;
                    goto case 0xBFB1;
                case 0xBFB0:
                    TotalCycles += 7; PushU16(0xBFB2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBFB1:
                    TotalCycles += 3; PC = 0xBFD7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFD7;
                case 0xBFB4: // === SUBROUTINE: Sub_BFB4 ===
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0xBFB6;
                    goto case 0xBFB6;
                case 0xBFB5:
                    TotalCycles += 7; PushU16(0xBFB7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBFB6:
                    Bit(_ram[0x01A9]); TotalCycles += 4; PC = 0xBFB9;
                    goto case 0xBFB9;
                case 0xBFB7: // === SUBROUTINE: Sub_BFB7 ===
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0xBFB9;
                    goto case 0xBFB9;
                case 0xBFB8:
                    A |= ReadMem(ReadU16Zp((byte)(0x48 + X))); SetZN(A); TotalCycles += 6; PC = 0xBFBA;
                    goto case 0xBFBA;
                case 0xBFB9:
                    PushU8(A); TotalCycles += 3; PC = 0xBFBA;
                    goto case 0xBFBA;
                case 0xBFBA:
                    Y = _ram[(byte)(0x16 + X)]; SetZN(Y); TotalCycles += 4; PC = 0xBFBC;
                    goto case 0xBFBC;
                case 0xBFBB:
                    { byte z = (byte)(0xE8 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xBFBD;
                    goto case 0xBFBD;
                case 0xBFBC:
                    X++; SetZN(X); TotalCycles += 2; PC = 0xBFBD;
                    goto case 0xBFBD;
                case 0xBFBD:
                    A = 0x05; SetZN(A); TotalCycles += 2; PC = 0xBFBF;
                    goto case 0xBFBF;
                case 0xBFBE:
                    A |= _ram[0xC0]; SetZN(A); TotalCycles += 3; PC = 0xBFC0;
                    goto case 0xBFC0;
                case 0xBFBF:
                    Cmp(Y, 0x29); TotalCycles += 2; PC = 0xBFC1;
                    goto case 0xBFC1;
                case 0xBFC0:
                    A &= 0xD0; SetZN(A); TotalCycles += 2; PC = 0xBFC2;
                    return;
                case 0xBFC1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0xBFC5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBFC5; }
                    PC = 0xBFC3; goto case 0xBFC3;
                case 0xBFC3:
                    A = 0x09; SetZN(A); TotalCycles += 2; PC = 0xBFC5;
                    goto case 0xBFC5;
                case 0xBFC4:
                    A |= 0x85; SetZN(A); TotalCycles += 2; PC = 0xBFC6;
                    goto case 0xBFC6;
                case 0xBFC5:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0xBFC7;
                    goto case 0xBFC7;
                case 0xBFC6:
                    TotalCycles += 7; PushU16(0xBFC8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBFC7:
                    A = 0x0A; SetZN(A); TotalCycles += 2; PC = 0xBFC9;
                    goto case 0xBFC9;
                case 0xBFC8:
                    A = Asl(A); TotalCycles += 2; PC = 0xBFC9;
                    goto case 0xBFC9;
                case 0xBFC9:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0xBFCB;
                    goto case 0xBFCB;
                case 0xBFCA:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0xBFCC;
                    return;
                case 0xBFCB:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0xBFCD;
                    goto case 0xBFCD;
                case 0xBFCD:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0xBFCF;
                    goto case 0xBFCF;
                case 0xBFCF:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0xBFD0;
                    goto case 0xBFD0;
                case 0xBFD0:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0xBFD1;
                    goto case 0xBFD1;
                case 0xBFD1:
                    TotalCycles += 6; PushU16(0xBFD3); PC = 0xBFD7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0xBFD7;
                case 0xBFD4:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0xBFD6;
                    goto case 0xBFD6;
                case 0xBFD5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0xBFD6;
                    goto case 0xBFD6;
                case 0xBFD6:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0xBFD7: // === SUBROUTINE: Sub_BFD7 ===
                    PushU8(A); TotalCycles += 3; PC = 0xBFD8;
                    goto case 0xBFD8;
                case 0xBFD8:
                    A = _ram[(0x0416 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBFDB;
                    goto case 0xBFDB;
                case 0xBFD9:
                    { byte z = (byte)(0x04 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xBFDB;
                    goto case 0xBFDB;
                case 0xBFDB:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBFDC;
                    goto case 0xBFDC;
                case 0xBFDC:
                    Adc(_ram[(0x0433 + X) & 0x07FF]); TotalCycles += 4; PC = 0xBFDF;
                    goto case 0xBFDF;
                case 0xBFDF:
                    _ram[(0x0416 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBFE2;
                    goto case 0xBFE2;
                case 0xBFE0:
                    { byte z = (byte)(0x04 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0xBFE2;
                    goto case 0xBFE2;
                case 0xBFE2:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0xBFE4;
                    goto case 0xBFE4;
                case 0xBFE3:
                    TotalCycles += 7; PushU16(0xBFE5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBFE4:
                    A = _ram[(byte)(0x9F + X)]; SetZN(A); TotalCycles += 4; PC = 0xBFE6;
                    goto case 0xBFE6;
                case 0xBFE6:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0xBFE9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0xBFE9; }
                    PC = 0xBFE8; goto case 0xBFE8;
                case 0xBFE7:
                    A |= ReadMem(ReadU16Zp((byte)(0x88 + X))); SetZN(A); TotalCycles += 6; PC = 0xBFE9;
                    goto case 0xBFE9;
                case 0xBFE8:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0xBFE9;
                    goto case 0xBFE9;
                case 0xBFE9:
                    _ram[0x07] = Y; TotalCycles += 3; PC = 0xBFEB;
                    goto case 0xBFEB;
                case 0xBFEB:
                    Adc(_ram[(byte)(0xCE + X)]); TotalCycles += 4; PC = 0xBFED;
                    goto case 0xBFED;
                case 0xBFEC:
                    { int a = 0xCE95; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBFEF;
                    goto case 0xBFEF;
                case 0xBFED:
                    _ram[(byte)(0xCE + X)] = A; TotalCycles += 4; PC = 0xBFEF;
                    goto case 0xBFEF;
                case 0xBFEE:
                    { int a = 0xB5B5; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0xBFF1;
                    goto case 0xBFF1;
                case 0xBFEF:
                    A = _ram[(byte)(0xB5 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBFF1;
                    goto case 0xBFF1;
                case 0xBFF0:
                    A = _ram[(byte)(0x65 + X)]; SetZN(A); TotalCycles += 4; PC = 0xBFF2;
                    return;
                case 0xBFF1:
                    Adc(_ram[0x07]); TotalCycles += 3; PC = 0xBFF3;
                    goto case 0xBFF3;
                case 0xBFF3:
                    _ram[(byte)(0xB5 + X)] = A; TotalCycles += 4; PC = 0xBFF5;
                    goto case 0xBFF5;
                case 0xBFF4:
                    A = _ram[(byte)(0xBD + X)]; SetZN(A); TotalCycles += 4; PC = 0xBFF6;
                    return;
                case 0xBFF5:
                    A = _ram[(0x0433 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0xBFF8;
                    goto case 0xBFF8;
                case 0xBFF8:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0xBFF9;
                    goto case 0xBFF9;
                case 0xBFF9:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0xBFFB;
                    goto case 0xBFFB;
                case 0xBFFA:
                    TotalCycles += 7; PushU16(0xBFFC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0xBFFB:
                    _ram[(0x0433 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0xBFFE;
                    goto case 0xBFFE;
                case 0xBFFE:
                    A = _ram[(byte)(0x9F + X)]; SetZN(A); TotalCycles += 4; PC = 0xC000;
                    return;
                default:
                    throw new InvalidOperationException($"Address not statically recompiled: 0x{PC:X4}");
            }
        }
    }
}
