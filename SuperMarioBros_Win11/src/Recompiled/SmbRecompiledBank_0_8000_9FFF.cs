using System;
using System.Runtime.CompilerServices;
using SuperMarioBros_Win11.Recompiled;

namespace SuperMarioBros_Win11.Core
{
    public sealed partial class SmbEngineCore
    {
        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        private void ExecuteNativeBlock_8000_9FFF(long targetCycles)
        {
            switch (PC)
            {
                case 0x8000: // === SUBROUTINE: Start_RESET ===
                    P |= FlagI; TotalCycles += 2; PC = 0x8001;
                    goto case 0x8001;
                case 0x8001:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0x8002;
                    goto case 0x8002;
                case 0x8002:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0x8004;
                    goto case 0x8004;
                case 0x8003:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x7F92; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8005; goto case 0x8005;
                case 0x8004:
                    WriteIoReg(0x2000, A); TotalCycles += 4; PC = 0x8007;
                    goto case 0x8007;
                case 0x8005:
                    TotalCycles += 7; PushU16(0x8007); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8006:
                    TotalCycles += 6; PushU16(0x8008); PC = 0xFFA2;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8007:
                    X = 0xFF; SetZN(X); TotalCycles += 2; PC = 0x8009;
                    goto case 0x8009;
                case 0x8009:
                    SP = X; TotalCycles += 2; PC = 0x800A;
                    goto case 0x800A;
                case 0x800A:
                    A = ReadIoReg(0x2002); SetZN(A); TotalCycles += 4; PC = 0x800D;
                    goto case 0x800D;
                case 0x800C:
                    TotalCycles += 6; PushU16(0x800E); PC = 0xFB10;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x800D:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x800A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x800A; }
                    PC = 0x800F; goto case 0x800F;
                case 0x800F:
                    A = ReadIoReg(0x2002); SetZN(A); TotalCycles += 4; PC = 0x8012;
                    goto case 0x8012;
                case 0x8011:
                    TotalCycles += 6; PushU16(0x8013); PC = 0xFB10;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8012:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x800F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x800F; }
                    PC = 0x8014; goto case 0x8014;
                case 0x8014:
                    Y = 0xFE; SetZN(Y); TotalCycles += 2; PC = 0x8016;
                    goto case 0x8016;
                case 0x8015:
                    { int a = (0x05A2 + X) & 0x07FF; _ram[a] = IncVal(_ram[a]); } TotalCycles += 7; PC = 0x8018;
                    goto case 0x8018;
                case 0x8016:
                    X = 0x05; SetZN(X); TotalCycles += 2; PC = 0x8018;
                    goto case 0x8018;
                case 0x8017:
                    A |= _ram[0xBD]; SetZN(A); TotalCycles += 3; PC = 0x8019;
                    return;
                case 0x8018:
                    A = _ram[(0x07D7 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x801B;
                    goto case 0x801B;
                case 0x801B:
                    Cmp(A, 0x0A); TotalCycles += 2; PC = 0x801D;
                    goto case 0x801D;
                case 0x801C:
                    A = Asl(A); TotalCycles += 2; PC = 0x801D;
                    goto case 0x801D;
                case 0x801D:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x802B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x802B; }
                    PC = 0x801F; goto case 0x801F;
                case 0x801F:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8020;
                    goto case 0x8020;
                case 0x8020:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8018; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8018; }
                    PC = 0x8022; goto case 0x8022;
                case 0x8021:
                    { byte z = (byte)(0xAD + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0x8023;
                    return;
                case 0x8022:
                    A = _ram[0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8025;
                    goto case 0x8025;
                case 0x8025:
                    Cmp(A, 0xA5); TotalCycles += 2; PC = 0x8027;
                    goto case 0x8027;
                case 0x8026:
                    A = _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0x8028;
                    return;
                case 0x8027:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x802B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x802B; }
                    PC = 0x8029; goto case 0x8029;
                case 0x8029:
                    Y = 0xD6; SetZN(Y); TotalCycles += 2; PC = 0x802B;
                    goto case 0x802B;
                case 0x802A:
                    { byte z = (byte)(0x20 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0x802C;
                    goto case 0x802C;
                case 0x802B:
                    TotalCycles += 6; PushU16(0x802D); PC = 0x90CC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x90CC;
                case 0x802C:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x0D90]); TotalCycles += 4; PC = 0x802F;
                    goto case 0x802F;
                case 0x802D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x7FBC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x802F; goto case 0x802F;
                case 0x802E:
                    WriteIoReg(0x4011, A); TotalCycles += 4; PC = 0x8031;
                    goto case 0x8031;
                case 0x802F:
                    A |= ReadMem(ReadU16Zp(0x40) + Y); SetZN(A); TotalCycles += 5; PC = 0x8031;
                    goto case 0x8031;
                case 0x8030:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8031:
                    _ram[0x0770] = A; TotalCycles += 4; PC = 0x8034;
                    goto case 0x8034;
                case 0x8032:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x803B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8034; goto case 0x8034;
                case 0x8034:
                    A = 0xA5; SetZN(A); TotalCycles += 2; PC = 0x8036;
                    goto case 0x8036;
                case 0x8035:
                    A = _ram[0x8D]; SetZN(A); TotalCycles += 3; PC = 0x8037;
                    return;
                case 0x8036:
                    _ram[0x07FF] = A; TotalCycles += 4; PC = 0x8039;
                    goto case 0x8039;
                case 0x8039:
                    _ram[0x07A7] = A; TotalCycles += 4; PC = 0x803C;
                    goto case 0x803C;
                case 0x803C:
                    A = 0x0F; SetZN(A); TotalCycles += 2; PC = 0x803E;
                    goto case 0x803E;
                case 0x803E:
                    WriteIoReg(0x4015, A); TotalCycles += 4; PC = 0x8041;
                    goto case 0x8041;
                case 0x803F:
                    A |= _ram[(byte)(0x40 + X)]; SetZN(A); TotalCycles += 4; PC = 0x8041;
                    goto case 0x8041;
                case 0x8040:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8041:
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0x8043;
                    goto case 0x8043;
                case 0x8042:
                    _ram[0x8D] = Asl(_ram[0x8D]); TotalCycles += 5; PC = 0x8044;
                    goto case 0x8044;
                case 0x8043:
                    WriteIoReg(0x2001, A); TotalCycles += 4; PC = 0x8046;
                    goto case 0x8046;
                case 0x8044:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0x8046;
                    goto case 0x8046;
                case 0x8045:
                    TotalCycles += 6; PushU16(0x8047); PC = 0x2020;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8046:
                    TotalCycles += 6; PushU16(0x8048); PC = 0x8220;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8220;
                case 0x8047:
                    TotalCycles += 6; PushU16(0x8049); PC = 0x2082;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8049:
                    TotalCycles += 6; PushU16(0x804B); PC = 0x8E19;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E19;
                case 0x804A:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x6E8E + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x804D;
                    return;
                case 0x804B:
                    WriteIoReg(0x74EE, X); TotalCycles += 4; PC = 0x804E;
                    return;
                case 0x804C:
                    _ram[0x0774] = IncVal(_ram[0x0774]); TotalCycles += 6; PC = 0x804F;
                    goto case 0x804F;
                case 0x804F:
                    A = _ram[0x0778]; SetZN(A); TotalCycles += 4; PC = 0x8052;
                    goto case 0x8052;
                case 0x8050:
                    P |= FlagI; TotalCycles += 2; PC = 0x8051;
                    return;
                case 0x8052:
                    A |= 0x80; SetZN(A); TotalCycles += 2; PC = 0x8054;
                    goto case 0x8054;
                case 0x8054:
                    TotalCycles += 6; PushU16(0x8056); PC = 0x8EED;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8EED;
                case 0x8055:
                    Sbc(ReadIoReg(0x4C8E)); TotalCycles += 4; PC = 0x8058;
                    return;
                case 0x8056:
                    WriteIoReg(0x574C, X); TotalCycles += 4; PC = 0x8059;
                    return;
                case 0x8057: // === SUBROUTINE: InitMemory ===
                    TotalCycles += 3; PC = 0x8057;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8057;
                case 0x805A:
                    A |= ReadMem(ReadU16Zp((byte)(0xA4 + X))); SetZN(A); TotalCycles += 6; PC = 0x805C;
                    goto case 0x805C;
                case 0x805B:
                    Y = _ram[0xC8]; SetZN(Y); TotalCycles += 3; PC = 0x805D;
                    goto case 0x805D;
                case 0x805C:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x805D;
                    goto case 0x805D;
                case 0x805D:
                    Cmp(X, _ram[0x0010]); TotalCycles += 4; PC = 0x8060;
                    goto case 0x8060;
                case 0x805E:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8060; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8060; }
                    PC = 0x8060; goto case 0x8060;
                case 0x805F:
                    TotalCycles += 7; PushU16(0x8061); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8060:
                    A ^= ReadMem(ReadU16Zp((byte)(0x41 + X))); SetZN(A); TotalCycles += 6; PC = 0x8062;
                    goto case 0x8062;
                case 0x8061:
                    A ^= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0x8063;
                    return;
                case 0x8062:
                    TotalCycles += 3; PC = 0x3C34;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8067:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8068;
                    return;
                case 0x8069:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x806A;
                    return;
                case 0x806B:
                    { int a = (0x03EF + X) & 0x07FF; _ram[a] = DecVal(_ram[a]); } TotalCycles += 7; PC = 0x806E;
                    goto case 0x806E;
                case 0x806E:
                    WriteIoReg(0x8C8C, Y); TotalCycles += 4; PC = 0x8071;
                    goto case 0x8071;
                case 0x806F:
                    WriteIoReg(0x8D8C, Y); TotalCycles += 4; PC = 0x8072;
                    return;
                case 0x8070:
                    _ram[0x038D] = Y; TotalCycles += 4; PC = 0x8073;
                    return;
                case 0x8071:
                    _ram[0x0303] = A; TotalCycles += 4; PC = 0x8074;
                    return;
                case 0x8075:
                    WriteIoReg(0x8D8D, A); TotalCycles += 4; PC = 0x8078;
                    goto case 0x8078;
                case 0x8076:
                    WriteIoReg(0x8D8D, A); TotalCycles += 4; PC = 0x8079;
                    goto case 0x8079;
                case 0x8077:
                    WriteIoReg(0x8D8D, A); TotalCycles += 4; PC = 0x807A;
                    goto case 0x807A;
                case 0x8078:
                    WriteIoReg(0x8D8D, A); TotalCycles += 4; PC = 0x807B;
                    goto case 0x807B;
                case 0x8079:
                    WriteIoReg(0x8D8D, A); TotalCycles += 4; PC = 0x807C;
                    goto case 0x807C;
                case 0x807A:
                    WriteIoReg(0x8D8D, A); TotalCycles += 4; PC = 0x807D;
                    goto case 0x807D;
                case 0x807B:
                    WriteIoReg(0x8D8D, A); TotalCycles += 4; PC = 0x807E;
                    goto case 0x807E;
                case 0x807C:
                    WriteIoReg(0x8D8D, A); TotalCycles += 4; PC = 0x807F;
                    goto case 0x807F;
                case 0x807D:
                    WriteIoReg(0x8D8D, A); TotalCycles += 4; PC = 0x8080;
                    goto case 0x8080;
                case 0x807E:
                    _ram[0x008D] = A; TotalCycles += 4; PC = 0x8081;
                    goto case 0x8081;
                case 0x807F:
                    TotalCycles = targetCycles; return;
                case 0x8080:
                    TotalCycles += 7; PushU16(0x8082); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8081:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8082: // === SUBROUTINE: NonMaskableInterrupt_NMI ===
                    A = _ram[0x0778]; SetZN(A); TotalCycles += 4; PC = 0x8085;
                    goto case 0x8085;
                case 0x8083:
                    P |= FlagI; TotalCycles += 2; PC = 0x8084;
                    return;
                case 0x8085:
                    A &= 0x7F; SetZN(A); TotalCycles += 2; PC = 0x8087;
                    goto case 0x8087;
                case 0x8087:
                    _ram[0x0778] = A; TotalCycles += 4; PC = 0x808A;
                    goto case 0x808A;
                case 0x8088:
                    P |= FlagI; TotalCycles += 2; PC = 0x8089;
                    return;
                case 0x808A:
                    A &= 0x7E; SetZN(A); TotalCycles += 2; PC = 0x808C;
                    goto case 0x808C;
                case 0x808B:
                    { int a = (0x008D + X) & 0x07FF; _ram[a] = Ror(_ram[a]); } TotalCycles += 7; PC = 0x808E;
                    goto case 0x808E;
                case 0x808C:
                    WriteIoReg(0x2000, A); TotalCycles += 4; PC = 0x808F;
                    goto case 0x808F;
                case 0x808D:
                    TotalCycles += 7; PushU16(0x808F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x808E:
                    TotalCycles += 6; PushU16(0x8090); PC = 0x79AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x808F:
                    A = _ram[0x0779]; SetZN(A); TotalCycles += 4; PC = 0x8092;
                    goto case 0x8092;
                case 0x8090:
                    Adc(ReadMem(0x2907 + Y)); TotalCycles += 4; PC = 0x8093;
                    goto case 0x8093;
                case 0x8092:
                    A &= 0xE6; SetZN(A); TotalCycles += 2; PC = 0x8094;
                    goto case 0x8094;
                case 0x8093:
                    _ram[0xAC] = IncVal(_ram[0xAC]); TotalCycles += 5; PC = 0x8095;
                    return;
                case 0x8094:
                    Y = _ram[0x0774]; SetZN(Y); TotalCycles += 4; PC = 0x8097;
                    goto case 0x8097;
                case 0x8097:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x809E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x809E; }
                    PC = 0x8099; goto case 0x8099;
                case 0x8098:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0x809A;
                    goto case 0x809A;
                case 0x8099:
                    A = _ram[0x0779]; SetZN(A); TotalCycles += 4; PC = 0x809C;
                    goto case 0x809C;
                case 0x809A:
                    Adc(ReadMem(0x0907 + Y)); TotalCycles += 4; PC = 0x809D;
                    goto case 0x809D;
                case 0x809C:
                    A |= 0x1E; SetZN(A); TotalCycles += 2; PC = 0x809E;
                    goto case 0x809E;
                case 0x809D:
                    { int a = 0x798D + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x80A0;
                    return;
                case 0x809E:
                    _ram[0x0779] = A; TotalCycles += 4; PC = 0x80A1;
                    goto case 0x80A1;
                case 0x809F:
                    Adc(ReadMem(0x2907 + Y)); TotalCycles += 4; PC = 0x80A2;
                    return;
                case 0x80A1:
                    A &= 0xE7; SetZN(A); TotalCycles += 2; PC = 0x80A3;
                    goto case 0x80A3;
                case 0x80A3:
                    WriteIoReg(0x2001, A); TotalCycles += 4; PC = 0x80A6;
                    goto case 0x80A6;
                case 0x80A4:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0x80A6;
                    goto case 0x80A6;
                case 0x80A5:
                    TotalCycles += 6; PushU16(0x80A7); PC = 0x02AE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x80A6:
                    X = ReadIoReg(0x2002); SetZN(X); TotalCycles += 4; PC = 0x80A9;
                    goto case 0x80A9;
                case 0x80A8:
                    TotalCycles += 6; PushU16(0x80AA); PC = 0x00A9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x80A9:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x80AB;
                    goto case 0x80AB;
                case 0x80AA:
                    TotalCycles += 7; PushU16(0x80AC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x80AB:
                    TotalCycles += 6; PushU16(0x80AD); PC = 0x8EE6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8EE6;
                case 0x80AC:
                    _ram[0x8E] = IncVal(_ram[0x8E]); TotalCycles += 5; PC = 0x80AE;
                    goto case 0x80AE;
                case 0x80AD:
                    _ram[0x038D] = X; TotalCycles += 4; PC = 0x80B0;
                    goto case 0x80B0;
                case 0x80AE:
                    WriteIoReg(0x2003, A); TotalCycles += 4; PC = 0x80B1;
                    goto case 0x80B1;
                case 0x80B0:
                    TotalCycles += 6; PushU16(0x80B2); PC = 0x02A9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x80B1:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0x80B3;
                    goto case 0x80B3;
                case 0x80B3:
                    WriteIoReg(0x4014, A); TotalCycles += 4; PC = 0x80B6;
                    goto case 0x80B6;
                case 0x80B5:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x80B6:
                    X = _ram[0x0773]; SetZN(X); TotalCycles += 4; PC = 0x80B9;
                    goto case 0x80B9;
                case 0x80B9:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x005A + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x80BC;
                    goto case 0x80BC;
                case 0x80BC:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x80BE;
                    goto case 0x80BE;
                case 0x80BD:
                    TotalCycles += 7; PushU16(0x80BF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x80BE:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x006D + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x80C1;
                    goto case 0x80C1;
                case 0x80BF:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x0580]); TotalCycles += 4; PC = 0x80C2;
                    goto case 0x80C2;
                case 0x80C1:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0x80C3;
                    goto case 0x80C3;
                case 0x80C2:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0x80C4;
                    goto case 0x80C4;
                case 0x80C3:
                    TotalCycles += 6; PushU16(0x80C5); PC = 0x8EDD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8EDD;
                case 0x80C4:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x208E + X) & 0x7FFF]); TotalCycles += 4; PC = 0x80C7;
                    goto case 0x80C7;
                case 0x80C5:
                    _ram[0x00A0] = X; TotalCycles += 4; PC = 0x80C8;
                    goto case 0x80C8;
                case 0x80C6:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x80C8;
                    goto case 0x80C8;
                case 0x80C7:
                    TotalCycles += 7; PushU16(0x80C9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x80C8:
                    X = _ram[0x0773]; SetZN(X); TotalCycles += 4; PC = 0x80CB;
                    goto case 0x80CB;
                case 0x80CB:
                    Cmp(X, 0x06); TotalCycles += 2; PC = 0x80CD;
                    goto case 0x80CD;
                case 0x80CC:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0x80CE;
                    goto case 0x80CE;
                case 0x80CD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x80D0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x80D0; }
                    PC = 0x80CF; goto case 0x80CF;
                case 0x80CE:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0x80D0;
                    goto case 0x80D0;
                case 0x80CF:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x80D0;
                    goto case 0x80D0;
                case 0x80D0:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x0080 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0x80D3;
                    goto case 0x80D3;
                case 0x80D3:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x80D5;
                    goto case 0x80D5;
                case 0x80D4:
                    TotalCycles += 7; PushU16(0x80D6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x80D5:
                    _ram[(0x0300 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x80D8;
                    goto case 0x80D8;
                case 0x80D6:
                    TotalCycles += 7; PushU16(0x80D8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x80D8:
                    _ram[(0x0301 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x80DB;
                    goto case 0x80DB;
                case 0x80D9:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x80DB;
                    goto case 0x80DB;
                case 0x80DB:
                    _ram[0x0773] = A; TotalCycles += 4; PC = 0x80DE;
                    goto case 0x80DE;
                case 0x80DE:
                    A = _ram[0x0779]; SetZN(A); TotalCycles += 4; PC = 0x80E1;
                    goto case 0x80E1;
                case 0x80DF:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x0D07 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x80E2;
                    goto case 0x80E2;
                case 0x80E1:
                    WriteIoReg(0x2001, A); TotalCycles += 4; PC = 0x80E4;
                    goto case 0x80E4;
                case 0x80E2:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0x80E4;
                    goto case 0x80E4;
                case 0x80E3:
                    TotalCycles += 6; PushU16(0x80E5); PC = 0xD020;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x80E4:
                    TotalCycles += 6; PushU16(0x80E6); PC = 0xF2D0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x80E5:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x80D9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x80D9; }
                    PC = 0x80E7; goto case 0x80E7;
                case 0x80E7:
                    TotalCycles += 6; PushU16(0x80E9); PC = 0x8E5C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E5C;
                case 0x80E9:
                    WriteIoReg(0x8220, X); TotalCycles += 4; PC = 0x80EC;
                    goto case 0x80EC;
                case 0x80EA:
                    TotalCycles += 6; PushU16(0x80EC); PC = 0x8182;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8182;
                case 0x80EC:
                    WriteMem(ReadU16Zp((byte)(0x20 + X)), A); TotalCycles += 6; PC = 0x80EE;
                    return;
                case 0x80ED:
                    TotalCycles += 6; PushU16(0x80EF); PC = 0x8F97;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8F97;
                case 0x80F0:
                    A = _ram[0x0776]; SetZN(A); TotalCycles += 4; PC = 0x80F3;
                    goto case 0x80F3;
                case 0x80F1:
                    { byte z = (byte)(0x07 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x80F3;
                    goto case 0x80F3;
                case 0x80F3:
                    A = Lsr(A); TotalCycles += 2; PC = 0x80F4;
                    goto case 0x80F4;
                case 0x80F4:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x811B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x811B; }
                    PC = 0x80F6; goto case 0x80F6;
                case 0x80F5:
                    A &= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0x80F7;
                    return;
                case 0x80F6:
                    A = _ram[0x0747]; SetZN(A); TotalCycles += 4; PC = 0x80F9;
                    goto case 0x80F9;
                case 0x80F9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8100; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8100; }
                    PC = 0x80FB; goto case 0x80FB;
                case 0x80FA:
                    A |= _ram[0xCE]; SetZN(A); TotalCycles += 3; PC = 0x80FC;
                    return;
                case 0x80FB:
                    _ram[0x0747] = DecVal(_ram[0x0747]); TotalCycles += 6; PC = 0x80FE;
                    goto case 0x80FE;
                case 0x80FE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8119; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8119; }
                    PC = 0x8100; goto case 0x8100;
                case 0x80FF:
                    A |= ReadMem(0x14A2 + Y); SetZN(A); TotalCycles += 4; PC = 0x8102;
                    goto case 0x8102;
                case 0x8100:
                    X = 0x14; SetZN(X); TotalCycles += 2; PC = 0x8102;
                    goto case 0x8102;
                case 0x8102:
                    _ram[0x077F] = DecVal(_ram[0x077F]); TotalCycles += 6; PC = 0x8105;
                    goto case 0x8105;
                case 0x8105:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x810E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x810E; }
                    PC = 0x8107; goto case 0x8107;
                case 0x8107:
                    A = 0x14; SetZN(A); TotalCycles += 2; PC = 0x8109;
                    goto case 0x8109;
                case 0x8109:
                    _ram[0x077F] = A; TotalCycles += 4; PC = 0x810C;
                    goto case 0x810C;
                case 0x810C:
                    X = 0x23; SetZN(X); TotalCycles += 2; PC = 0x810E;
                    goto case 0x810E;
                case 0x810E:
                    A = _ram[(0x0780 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8111;
                    goto case 0x8111;
                case 0x8111:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8116; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8116; }
                    PC = 0x8113; goto case 0x8113;
                case 0x8113:
                    { int a = (0x0780 + X) & 0x07FF; _ram[a] = DecVal(_ram[a]); } TotalCycles += 7; PC = 0x8116;
                    goto case 0x8116;
                case 0x8116:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8117;
                    goto case 0x8117;
                case 0x8117:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x810E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x810E; }
                    PC = 0x8119; goto case 0x8119;
                case 0x8118:
                    Sbc(_ram[(byte)(0xE6 + X)]); TotalCycles += 4; PC = 0x811A;
                    goto case 0x811A;
                case 0x8119:
                    _ram[0x09] = IncVal(_ram[0x09]); TotalCycles += 5; PC = 0x811B;
                    goto case 0x811B;
                case 0x811A:
                    A |= 0xA2; SetZN(A); TotalCycles += 2; PC = 0x811C;
                    goto case 0x811C;
                case 0x811B:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x811D;
                    goto case 0x811D;
                case 0x811C:
                    TotalCycles += 7; PushU16(0x811E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x811D:
                    Y = 0x07; SetZN(Y); TotalCycles += 2; PC = 0x811F;
                    goto case 0x811F;
                case 0x811F:
                    A = _ram[0x07A7]; SetZN(A); TotalCycles += 4; PC = 0x8122;
                    goto case 0x8122;
                case 0x8122:
                    A &= 0x02; SetZN(A); TotalCycles += 2; PC = 0x8124;
                    goto case 0x8124;
                case 0x8124:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x8126;
                    goto case 0x8126;
                case 0x8125:
                    TotalCycles += 7; PushU16(0x8127); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8126:
                    A = _ram[0x07A8]; SetZN(A); TotalCycles += 4; PC = 0x8129;
                    goto case 0x8129;
                case 0x8127:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x8128;
                    return;
                case 0x8129:
                    A &= 0x02; SetZN(A); TotalCycles += 2; PC = 0x812B;
                    goto case 0x812B;
                case 0x812B:
                    A ^= _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x812D;
                    goto case 0x812D;
                case 0x812C:
                    TotalCycles += 7; PushU16(0x812E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x812D:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x812E;
                    goto case 0x812E;
                case 0x812E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8131; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8131; }
                    PC = 0x8130; goto case 0x8130;
                case 0x812F:
                    A |= ReadMem(ReadU16Zp((byte)(0x38 + X))); SetZN(A); TotalCycles += 6; PC = 0x8131;
                    goto case 0x8131;
                case 0x8130:
                    P |= FlagC; TotalCycles += 2; PC = 0x8131;
                    goto case 0x8131;
                case 0x8131:
                    { int a = (0x07A7 + X) & 0x07FF; _ram[a] = Ror(_ram[a]); } TotalCycles += 7; PC = 0x8134;
                    goto case 0x8134;
                case 0x8134:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8135;
                    goto case 0x8135;
                case 0x8135:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8136;
                    goto case 0x8136;
                case 0x8136:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8131; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8131; }
                    PC = 0x8138; goto case 0x8138;
                case 0x8137:
                    Sbc(ReadMem(0x22AD + Y)); TotalCycles += 4; PC = 0x813A;
                    return;
                case 0x8138:
                    A = _ram[0x0722]; SetZN(A); TotalCycles += 4; PC = 0x813B;
                    goto case 0x813B;
                case 0x813B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x815C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x815C; }
                    PC = 0x813D; goto case 0x813D;
                case 0x813D:
                    A = ReadIoReg(0x2002); SetZN(A); TotalCycles += 4; PC = 0x8140;
                    goto case 0x8140;
                case 0x813F:
                    TotalCycles += 6; PushU16(0x8141); PC = 0x4029;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8140:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0x8142;
                    goto case 0x8142;
                case 0x8141:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8142:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x813D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x813D; }
                    PC = 0x8144; goto case 0x8144;
                case 0x8143:
                    Sbc(ReadMem(0x76AD + Y)); TotalCycles += 4; PC = 0x8146;
                    return;
                case 0x8144:
                    A = _ram[0x0776]; SetZN(A); TotalCycles += 4; PC = 0x8147;
                    goto case 0x8147;
                case 0x8145:
                    { byte z = (byte)(0x07 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x8147;
                    goto case 0x8147;
                case 0x8147:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8148;
                    goto case 0x8148;
                case 0x8148:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8150; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8150; }
                    PC = 0x814A; goto case 0x814A;
                case 0x8149:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x814B;
                    return;
                case 0x814A:
                    TotalCycles += 6; PushU16(0x814C); PC = 0x8223;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8223;
                case 0x814D:
                    TotalCycles += 6; PushU16(0x814F); PC = 0x81C6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x81C6;
                case 0x814E:
                    _ram[0x81] = DecVal(_ram[0x81]); TotalCycles += 5; PC = 0x8150;
                    goto case 0x8150;
                case 0x814F:
                    WriteMem(ReadU16Zp((byte)(0xAD + X)), A); TotalCycles += 6; PC = 0x8151;
                    return;
                case 0x8150:
                    A = ReadIoReg(0x2002); SetZN(A); TotalCycles += 4; PC = 0x8153;
                    goto case 0x8153;
                case 0x8152:
                    TotalCycles += 6; PushU16(0x8154); PC = 0x4029;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8153:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0x8155;
                    goto case 0x8155;
                case 0x8154:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8155:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8150; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8150; }
                    PC = 0x8157; goto case 0x8157;
                case 0x8156:
                    Sbc(ReadMem(0x14A0 + Y)); TotalCycles += 4; PC = 0x8159;
                    goto case 0x8159;
                case 0x8157:
                    Y = 0x14; SetZN(Y); TotalCycles += 2; PC = 0x8159;
                    goto case 0x8159;
                case 0x8159:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x815A;
                    goto case 0x815A;
                case 0x815A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8159; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8159; }
                    PC = 0x815C; goto case 0x815C;
                case 0x815B:
                    Sbc(ReadMem(0x3FAD + X)); TotalCycles += 4; PC = 0x815E;
                    return;
                case 0x815C:
                    A = _ram[0x073F]; SetZN(A); TotalCycles += 4; PC = 0x815F;
                    goto case 0x815F;
                case 0x815F:
                    WriteIoReg(0x2005, A); TotalCycles += 4; PC = 0x8162;
                    goto case 0x8162;
                case 0x8160:
                    A |= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0x8162;
                    goto case 0x8162;
                case 0x8161:
                    TotalCycles += 6; PushU16(0x8163); PC = 0x40AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8162:
                    A = _ram[0x0740]; SetZN(A); TotalCycles += 4; PC = 0x8165;
                    goto case 0x8165;
                case 0x8163:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8165:
                    WriteIoReg(0x2005, A); TotalCycles += 4; PC = 0x8168;
                    goto case 0x8168;
                case 0x8166:
                    A |= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0x8168;
                    goto case 0x8168;
                case 0x8167:
                    TotalCycles += 6; PushU16(0x8169); PC = 0x78AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8168:
                    A = _ram[0x0778]; SetZN(A); TotalCycles += 4; PC = 0x816B;
                    goto case 0x816B;
                case 0x8169:
                    P |= FlagI; TotalCycles += 2; PC = 0x816A;
                    return;
                case 0x816B:
                    PushU8(A); TotalCycles += 3; PC = 0x816C;
                    goto case 0x816C;
                case 0x816C:
                    WriteIoReg(0x2000, A); TotalCycles += 4; PC = 0x816F;
                    goto case 0x816F;
                case 0x816D:
                    TotalCycles += 7; PushU16(0x816F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x816E:
                    TotalCycles += 6; PushU16(0x8170); PC = 0x76AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x816F:
                    A = _ram[0x0776]; SetZN(A); TotalCycles += 4; PC = 0x8172;
                    goto case 0x8172;
                case 0x8170:
                    { byte z = (byte)(0x07 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x8172;
                    goto case 0x8172;
                case 0x8172:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8173;
                    goto case 0x8173;
                case 0x8173:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8178; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8178; }
                    PC = 0x8175; goto case 0x8175;
                case 0x8175:
                    TotalCycles += 6; PushU16(0x8177); PC = 0x8212;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8212;
                case 0x8178:
                    A = ReadIoReg(0x2002); SetZN(A); TotalCycles += 4; PC = 0x817B;
                    goto case 0x817B;
                case 0x817A:
                    TotalCycles += 6; PushU16(0x817C); PC = 0x0968;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x817B:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x817C;
                    goto case 0x817C;
                case 0x817C:
                    A |= 0x80; SetZN(A); TotalCycles += 2; PC = 0x817E;
                    goto case 0x817E;
                case 0x817E:
                    WriteIoReg(0x2000, A); TotalCycles += 4; PC = 0x8181;
                    goto case 0x8181;
                case 0x817F:
                    TotalCycles += 7; PushU16(0x8181); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8180:
                    TotalCycles += 6; PushU16(0x8182); PC = 0xAD40;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8181:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8182: // === SUBROUTINE: PauseRoutine ===
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0x8185;
                    goto case 0x8185;
                case 0x8183:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x818C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x818C; }
                    PC = 0x8185; goto case 0x8185;
                case 0x8185:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0x8187;
                    goto case 0x8187;
                case 0x8187:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8194; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8194; }
                    PC = 0x8189; goto case 0x8189;
                case 0x8189:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0x818B;
                    goto case 0x818B;
                case 0x818A:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0x818C;
                    goto case 0x818C;
                case 0x818B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x81C5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81C5; }
                    PC = 0x818D; goto case 0x818D;
                case 0x818C:
                    P |= FlagC; TotalCycles += 2; PC = 0x818D;
                    goto case 0x818D;
                case 0x818D:
                    A = _ram[0x0772]; SetZN(A); TotalCycles += 4; PC = 0x8190;
                    goto case 0x8190;
                case 0x8190:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0x8192;
                    goto case 0x8192;
                case 0x8192:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x81C5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81C5; }
                    PC = 0x8194; goto case 0x8194;
                case 0x8193:
                    A &= ReadMem(ReadU16Zp(0xAD) + Y); SetZN(A); TotalCycles += 5; PC = 0x8195;
                    return;
                case 0x8194:
                    A = _ram[0x0777]; SetZN(A); TotalCycles += 4; PC = 0x8197;
                    goto case 0x8197;
                case 0x8197:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x819D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x819D; }
                    PC = 0x8199; goto case 0x8199;
                case 0x8199:
                    _ram[0x0777] = DecVal(_ram[0x0777]); TotalCycles += 6; PC = 0x819C;
                    goto case 0x819C;
                case 0x819C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x819D:
                    A = _ram[0x06FC]; SetZN(A); TotalCycles += 4; PC = 0x81A0;
                    goto case 0x81A0;
                case 0x819F:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0x81A1;
                    goto case 0x81A1;
                case 0x81A0:
                    A &= 0x10; SetZN(A); TotalCycles += 2; PC = 0x81A2;
                    goto case 0x81A2;
                case 0x81A1:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8193; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8193; }
                    PC = 0x81A3; goto case 0x81A3;
                case 0x81A2:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x81BD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81BD; }
                    PC = 0x81A4; goto case 0x81A4;
                case 0x81A3:
                    A |= ReadMem(0x76AD + Y); SetZN(A); TotalCycles += 4; PC = 0x81A6;
                    return;
                case 0x81A4:
                    A = _ram[0x0776]; SetZN(A); TotalCycles += 4; PC = 0x81A7;
                    goto case 0x81A7;
                case 0x81A5:
                    { byte z = (byte)(0x07 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x81A7;
                    goto case 0x81A7;
                case 0x81A7:
                    A &= 0x80; SetZN(A); TotalCycles += 2; PC = 0x81A9;
                    goto case 0x81A9;
                case 0x81A9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x81C5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81C5; }
                    PC = 0x81AB; goto case 0x81AB;
                case 0x81AB:
                    A = 0x2B; SetZN(A); TotalCycles += 2; PC = 0x81AD;
                    goto case 0x81AD;
                case 0x81AD:
                    _ram[0x0777] = A; TotalCycles += 4; PC = 0x81B0;
                    goto case 0x81B0;
                case 0x81B0:
                    A = _ram[0x0776]; SetZN(A); TotalCycles += 4; PC = 0x81B3;
                    goto case 0x81B3;
                case 0x81B1:
                    { byte z = (byte)(0x07 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x81B3;
                    goto case 0x81B3;
                case 0x81B3:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x81B4;
                    goto case 0x81B4;
                case 0x81B4:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x81B5;
                    goto case 0x81B5;
                case 0x81B5:
                    _ram[0xFA] = Y; TotalCycles += 3; PC = 0x81B7;
                    goto case 0x81B7;
                case 0x81B7:
                    A ^= 0x01; SetZN(A); TotalCycles += 2; PC = 0x81B9;
                    goto case 0x81B9;
                case 0x81B8:
                    A |= ReadMem(ReadU16Zp((byte)(0x09 + X))); SetZN(A); TotalCycles += 6; PC = 0x81BA;
                    return;
                case 0x81B9:
                    A |= 0x80; SetZN(A); TotalCycles += 2; PC = 0x81BB;
                    goto case 0x81BB;
                case 0x81BB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x81C2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81C2; }
                    PC = 0x81BD; goto case 0x81BD;
                case 0x81BC:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0x81BE;
                    goto case 0x81BE;
                case 0x81BD:
                    A = _ram[0x0776]; SetZN(A); TotalCycles += 4; PC = 0x81C0;
                    goto case 0x81C0;
                case 0x81BE:
                    { byte z = (byte)(0x07 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x81C0;
                    goto case 0x81C0;
                case 0x81C0:
                    A &= 0x7F; SetZN(A); TotalCycles += 2; PC = 0x81C2;
                    goto case 0x81C2;
                case 0x81C2:
                    _ram[0x0776] = A; TotalCycles += 4; PC = 0x81C5;
                    goto case 0x81C5;
                case 0x81C3:
                    { byte z = (byte)(0x07 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x81C5;
                    goto case 0x81C5;
                case 0x81C5:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x81C6: // === SUBROUTINE: SpriteShuffler ===
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x81C9;
                    goto case 0x81C9;
                case 0x81C7:
                    { int a = 0xA907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x81CA;
                    goto case 0x81CA;
                case 0x81C9:
                    A = 0x28; SetZN(A); TotalCycles += 2; PC = 0x81CB;
                    goto case 0x81CB;
                case 0x81CA:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x81CB;
                    goto case 0x81CB;
                case 0x81CB:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x81CD;
                    goto case 0x81CD;
                case 0x81CC:
                    TotalCycles += 7; PushU16(0x81CE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x81CD:
                    X = 0x0E; SetZN(X); TotalCycles += 2; PC = 0x81CF;
                    goto case 0x81CF;
                case 0x81CE:
                    { int a = 0xE4BD; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x81D1;
                    goto case 0x81D1;
                case 0x81CF:
                    A = _ram[(0x06E4 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x81D2;
                    goto case 0x81D2;
                case 0x81D0:
                    Cmp(X, _ram[0x06]); TotalCycles += 3; PC = 0x81D2;
                    goto case 0x81D2;
                case 0x81D1:
                    _ram[0xC5] = Asl(_ram[0xC5]); TotalCycles += 5; PC = 0x81D3;
                    goto case 0x81D3;
                case 0x81D2:
                    Cmp(A, _ram[0x00]); TotalCycles += 3; PC = 0x81D4;
                    goto case 0x81D4;
                case 0x81D3:
                    TotalCycles += 7; PushU16(0x81D5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x81D4:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x81E5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81E5; }
                    PC = 0x81D6; goto case 0x81D6;
                case 0x81D6:
                    Y = _ram[0x06E0]; SetZN(Y); TotalCycles += 4; PC = 0x81D9;
                    goto case 0x81D9;
                case 0x81D7:
                    Cmp(X, 0x06); TotalCycles += 2; PC = 0x81D9;
                    goto case 0x81D9;
                case 0x81D8:
                    _ram[0x18] = Asl(_ram[0x18]); TotalCycles += 5; PC = 0x81DA;
                    goto case 0x81DA;
                case 0x81D9:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x81DA;
                    goto case 0x81DA;
                case 0x81DA:
                    Adc(_ram[(0x06E1 + Y) & 0x07FF]); TotalCycles += 4; PC = 0x81DD;
                    goto case 0x81DD;
                case 0x81DB:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x06 + X)))); TotalCycles += 6; PC = 0x81DD;
                    goto case 0x81DD;
                case 0x81DC:
                    _ram[0x90] = Asl(_ram[0x90]); TotalCycles += 5; PC = 0x81DE;
                    return;
                case 0x81DD:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x81E2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81E2; }
                    PC = 0x81DF; goto case 0x81DF;
                case 0x81DF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x81E0;
                    goto case 0x81E0;
                case 0x81E0:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0x81E2;
                    goto case 0x81E2;
                case 0x81E1:
                    TotalCycles += 7; PushU16(0x81E3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x81E2:
                    _ram[(0x06E4 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x81E5;
                    goto case 0x81E5;
                case 0x81E3:
                    Cmp(X, _ram[0x06]); TotalCycles += 3; PC = 0x81E5;
                    goto case 0x81E5;
                case 0x81E4:
                    _ram[0xCA] = Asl(_ram[0xCA]); TotalCycles += 5; PC = 0x81E6;
                    goto case 0x81E6;
                case 0x81E5:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x81E6;
                    goto case 0x81E6;
                case 0x81E6:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x81CF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81CF; }
                    PC = 0x81E8; goto case 0x81E8;
                case 0x81E8:
                    X = _ram[0x06E0]; SetZN(X); TotalCycles += 4; PC = 0x81EB;
                    goto case 0x81EB;
                case 0x81E9:
                    Cmp(X, 0x06); TotalCycles += 2; PC = 0x81EB;
                    goto case 0x81EB;
                case 0x81EA:
                    _ram[0xE8] = Asl(_ram[0xE8]); TotalCycles += 5; PC = 0x81EC;
                    goto case 0x81EC;
                case 0x81EB:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x81EC;
                    goto case 0x81EC;
                case 0x81EC:
                    Cmp(X, 0x03); TotalCycles += 2; PC = 0x81EE;
                    goto case 0x81EE;
                case 0x81EE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x81F2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81F2; }
                    PC = 0x81F0; goto case 0x81F0;
                case 0x81F0:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x81F2;
                    goto case 0x81F2;
                case 0x81F1:
                    TotalCycles += 7; PushU16(0x81F3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x81F2:
                    _ram[0x06E0] = X; TotalCycles += 4; PC = 0x81F5;
                    goto case 0x81F5;
                case 0x81F3:
                    Cmp(X, 0x06); TotalCycles += 2; PC = 0x81F5;
                    goto case 0x81F5;
                case 0x81F4:
                    _ram[0xA2] = Asl(_ram[0xA2]); TotalCycles += 5; PC = 0x81F6;
                    goto case 0x81F6;
                case 0x81F5:
                    X = 0x08; SetZN(X); TotalCycles += 2; PC = 0x81F7;
                    goto case 0x81F7;
                case 0x81F6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x81F7;
                    goto case 0x81F7;
                case 0x81F7:
                    Y = 0x02; SetZN(Y); TotalCycles += 2; PC = 0x81F9;
                    goto case 0x81F9;
                case 0x81F9:
                    A = _ram[(0x06E9 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x81FC;
                    goto case 0x81FC;
                case 0x81FA:
                    Sbc(0x06); TotalCycles += 2; PC = 0x81FC;
                    goto case 0x81FC;
                case 0x81FB:
                    _ram[0x9D] = Asl(_ram[0x9D]); TotalCycles += 5; PC = 0x81FD;
                    goto case 0x81FD;
                case 0x81FC:
                    _ram[(0x06F1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x81FF;
                    goto case 0x81FF;
                case 0x81FD:
                    Sbc(ReadMem(ReadU16Zp(0x06) + Y)); TotalCycles += 5; PC = 0x81FF;
                    goto case 0x81FF;
                case 0x81FE:
                    _ram[0x18] = Asl(_ram[0x18]); TotalCycles += 5; PC = 0x8200;
                    goto case 0x8200;
                case 0x81FF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8200;
                    goto case 0x8200;
                case 0x8200:
                    Adc(0x08); TotalCycles += 2; PC = 0x8202;
                    goto case 0x8202;
                case 0x8201:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8202;
                    goto case 0x8202;
                case 0x8202:
                    _ram[(0x06F2 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8205;
                    goto case 0x8205;
                case 0x8204:
                    _ram[0x18] = Asl(_ram[0x18]); TotalCycles += 5; PC = 0x8206;
                    goto case 0x8206;
                case 0x8205:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8206;
                    goto case 0x8206;
                case 0x8206:
                    Adc(0x08); TotalCycles += 2; PC = 0x8208;
                    goto case 0x8208;
                case 0x8207:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8208;
                    goto case 0x8208;
                case 0x8208:
                    _ram[(0x06F3 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x820B;
                    goto case 0x820B;
                case 0x820A:
                    _ram[0xCA] = Asl(_ram[0xCA]); TotalCycles += 5; PC = 0x820C;
                    goto case 0x820C;
                case 0x820B:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x820C;
                    goto case 0x820C;
                case 0x820C:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x820D;
                    goto case 0x820D;
                case 0x820D:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x820E;
                    goto case 0x820E;
                case 0x820E:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x820F;
                    goto case 0x820F;
                case 0x820F:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x81F9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x81F9; }
                    PC = 0x8211; goto case 0x8211;
                case 0x8210:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8211;
                    goto case 0x8211;
                case 0x8211:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8212: // === SUBROUTINE: OperModeExecutionTree ===
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0x8215;
                    goto case 0x8215;
                case 0x8213:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x821C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8215; goto case 0x8215;
                case 0x8215:
                    TotalCycles += 6; PushU16(0x8217); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E04;
                case 0x8217:
                    WriteIoReg(0x8231, X); TotalCycles += 4; PC = 0x821A;
                    return;
                case 0x8218:
                    A &= ReadMem(ReadU16Zp(0x82) + Y); SetZN(A); TotalCycles += 5; PC = 0x821A;
                    return;
                case 0x821B:
                    X = SmbEmbeddedAssets.StaticDataTables[0x038B]; SetZN(X); TotalCycles += 4; PC = 0x821E;
                    goto case 0x821E;
                case 0x821E:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x821F;
                    return;
                case 0x8220: // === SUBROUTINE: MoveAllSpritesOffscreen ===
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x8222;
                    goto case 0x8222;
                case 0x8221:
                    TotalCycles += 7; PushU16(0x8223); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8222: // === SUBROUTINE: MoveSpritesOffscreen ===
                    Bit(_ram[0x04A0]); TotalCycles += 4; PC = 0x8225;
                    goto case 0x8225;
                case 0x8223: // === SUBROUTINE: Sub_8223 ===
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0x8225;
                    goto case 0x8225;
                case 0x8225:
                    A = 0xF8; SetZN(A); TotalCycles += 2; PC = 0x8227;
                    goto case 0x8227;
                case 0x8226:
                    P |= FlagD; TotalCycles += 2; PC = 0x8227;
                    goto case 0x8227;
                case 0x8227:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x822A;
                    goto case 0x822A;
                case 0x8228:
                    TotalCycles += 7; PushU16(0x822A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x822A:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x822B;
                    goto case 0x822B;
                case 0x822B:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x822C;
                    goto case 0x822C;
                case 0x822C:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x822D;
                    goto case 0x822D;
                case 0x822D:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x822E;
                    goto case 0x822E;
                case 0x822E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8227; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8227; }
                    PC = 0x8230; goto case 0x8230;
                case 0x8230:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8231: // === SUBROUTINE: TitleScreenMode ===
                    A = _ram[0x0772]; SetZN(A); TotalCycles += 4; PC = 0x8234;
                    goto case 0x8234;
                case 0x8234:
                    TotalCycles += 6; PushU16(0x8236); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E04;
                case 0x8236:
                    WriteIoReg(0x8FCF, X); TotalCycles += 4; PC = 0x8239;
                    return;
                case 0x823A:
                    _ram[0x61] = A; TotalCycles += 3; PC = 0x823C;
                    goto case 0x823C;
                case 0x823B:
                    Adc(ReadMem(ReadU16Zp((byte)(0x90 + X)))); TotalCycles += 6; PC = 0x823D;
                    goto case 0x823D;
                case 0x823C: // === SUBROUTINE: InitializeGame ===
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8283; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8283; }
                    PC = 0x823E; return;
                case 0x823D:
                    A ^= _ram[0x82]; SetZN(A); TotalCycles += 3; PC = 0x823F;
                    return;
                case 0x8240:
                    TotalCycles += 6; PushU16(0x8242); PC = 0x0173;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8242:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0x8244;
                    goto case 0x8244;
                case 0x8243:
                    TotalCycles += 7; PushU16(0x8245); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8244:
                    TotalCycles += 7; PushU16(0x8246); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8245: // === SUBROUTINE: PrimaryGameSetup ===
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x8247;
                    goto case 0x8247;
                case 0x8246:
                    TotalCycles += 7; PushU16(0x8248); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8247:
                    A = _ram[0x06FC]; SetZN(A); TotalCycles += 4; PC = 0x824A;
                    goto case 0x824A;
                case 0x8249:
                    _ram[0x0D] = Asl(_ram[0x0D]); TotalCycles += 5; PC = 0x824B;
                    goto case 0x824B;
                case 0x824A:
                    A |= _ram[0x06FD]; SetZN(A); TotalCycles += 4; PC = 0x824D;
                    goto case 0x824D;
                case 0x824B:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x4906 + X) & 0x7FFF]); TotalCycles += 4; PC = 0x824E;
                    goto case 0x824E;
                case 0x824C:
                    _ram[0xC9] = Asl(_ram[0xC9]); TotalCycles += 5; PC = 0x824E;
                    goto case 0x824E;
                case 0x824D:
                    Cmp(A, 0x10); TotalCycles += 2; PC = 0x824F;
                    goto case 0x824F;
                case 0x824E:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8240; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8240; }
                    PC = 0x8250; return;
                case 0x824F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8255; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8255; }
                    PC = 0x8251; goto case 0x8251;
                case 0x8251:
                    Cmp(A, 0x90); TotalCycles += 2; PC = 0x8253;
                    goto case 0x8253;
                case 0x8252:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8224; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8254; return;
                case 0x8253:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8258; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8258; }
                    PC = 0x8255; goto case 0x8255;
                case 0x8255:
                    TotalCycles += 3; PC = 0x82D8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x82D8;
                case 0x8256:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0x8257;
                    return;
                case 0x8258:
                    Cmp(A, 0x20); TotalCycles += 2; PC = 0x825A;
                    goto case 0x825A;
                case 0x8259:
                    TotalCycles += 6; PushU16(0x825B); PC = 0x1AF0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x825A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8276; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8276; }
                    PC = 0x825C; goto case 0x825C;
                case 0x825C:
                    X = _ram[0x07A2]; SetZN(X); TotalCycles += 4; PC = 0x825F;
                    goto case 0x825F;
                case 0x825D:
                    X = 0x07; SetZN(X); TotalCycles += 2; PC = 0x825F;
                    goto case 0x825F;
                case 0x825F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x826C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x826C; }
                    PC = 0x8261; goto case 0x8261;
                case 0x8261:
                    _ram[0x0780] = A; TotalCycles += 4; PC = 0x8264;
                    goto case 0x8264;
                case 0x8264:
                    TotalCycles += 6; PushU16(0x8266); PC = 0x836B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x836B;
                case 0x8267:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x82C9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x82C9; }
                    PC = 0x8269; goto case 0x8269;
                case 0x8268:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8269:
                    TotalCycles += 3; PC = 0x82C0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x82C0;
                case 0x826A:
                    Cmp(Y, 0x82); TotalCycles += 2; PC = 0x826C;
                    goto case 0x826C;
                case 0x826C:
                    X = _ram[0x07FC]; SetZN(X); TotalCycles += 4; PC = 0x826F;
                    goto case 0x826F;
                case 0x826F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x82BB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x82BB; }
                    PC = 0x8271; goto case 0x8271;
                case 0x8270:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8271;
                    goto case 0x8271;
                case 0x8271:
                    Cmp(A, 0x40); TotalCycles += 2; PC = 0x8273;
                    goto case 0x8273;
                case 0x8272:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8273:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x82BB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x82BB; }
                    PC = 0x8275; goto case 0x8275;
                case 0x8274:
                    _ram[0xC8] = Lsr(_ram[0xC8]); TotalCycles += 5; PC = 0x8276;
                    goto case 0x8276;
                case 0x8275:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8276;
                    goto case 0x8276;
                case 0x8276:
                    A = _ram[0x07A2]; SetZN(A); TotalCycles += 4; PC = 0x8279;
                    goto case 0x8279;
                case 0x8277:
                    X = 0x07; SetZN(X); TotalCycles += 2; PC = 0x8279;
                    goto case 0x8279;
                case 0x8279:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x82C9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x82C9; }
                    PC = 0x827B; goto case 0x827B;
                case 0x827A:
                    _ram[0x00A9] = Lsr(_ram[0x00A9]); TotalCycles += 6; PC = 0x827D;
                    goto case 0x827D;
                case 0x827B:
                    A = 0x18; SetZN(A); TotalCycles += 2; PC = 0x827D;
                    goto case 0x827D;
                case 0x827C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x827D;
                    goto case 0x827D;
                case 0x827D:
                    _ram[0x07A2] = A; TotalCycles += 4; PC = 0x8280;
                    goto case 0x8280;
                case 0x827E:
                    X = 0x07; SetZN(X); TotalCycles += 2; PC = 0x8280;
                    goto case 0x8280;
                case 0x8280:
                    A = _ram[0x0780]; SetZN(A); TotalCycles += 4; PC = 0x8283;
                    goto case 0x8283;
                case 0x8283:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x82BB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x82BB; }
                    PC = 0x8285; goto case 0x8285;
                case 0x8284:
                    { byte z = (byte)(0xA9 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x8286;
                    goto case 0x8286;
                case 0x8285:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0x8287;
                    goto case 0x8287;
                case 0x8286:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8215; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8215; }
                    PC = 0x8288; return;
                case 0x8287:
                    _ram[0x0780] = A; TotalCycles += 4; PC = 0x828A;
                    goto case 0x828A;
                case 0x828A:
                    Cmp(Y, 0x01); TotalCycles += 2; PC = 0x828C;
                    goto case 0x828C;
                case 0x828B:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0x828D;
                    goto case 0x828D;
                case 0x828C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x829C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x829C; }
                    PC = 0x828E; goto case 0x828E;
                case 0x828D:
                    { int a = 0x7AAD; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x8290;
                    return;
                case 0x828E:
                    A = _ram[0x077A]; SetZN(A); TotalCycles += 4; PC = 0x8291;
                    goto case 0x8291;
                case 0x8291:
                    A ^= 0x01; SetZN(A); TotalCycles += 2; PC = 0x8293;
                    goto case 0x8293;
                case 0x8292:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x8294;
                    return;
                case 0x8293:
                    _ram[0x077A] = A; TotalCycles += 4; PC = 0x8296;
                    goto case 0x8296;
                case 0x8296:
                    TotalCycles += 6; PushU16(0x8298); PC = 0x8325;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8325;
                case 0x8297:
                    A &= _ram[0x83]; SetZN(A); TotalCycles += 3; PC = 0x8299;
                    goto case 0x8299;
                case 0x8299:
                    TotalCycles += 3; PC = 0x82BB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x82BB;
                case 0x829C:
                    X = _ram[0x076B]; SetZN(X); TotalCycles += 4; PC = 0x829F;
                    goto case 0x829F;
                case 0x829F:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x82A0;
                    goto case 0x82A0;
                case 0x82A0:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x82A1;
                    goto case 0x82A1;
                case 0x82A1:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0x82A3;
                    goto case 0x82A3;
                case 0x82A3:
                    _ram[0x076B] = A; TotalCycles += 4; PC = 0x82A6;
                    goto case 0x82A6;
                case 0x82A6:
                    TotalCycles += 6; PushU16(0x82A8); PC = 0x830E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x830E;
                case 0x82A7:
                    { int a = 0xBD83; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x82AA;
                    return;
                case 0x82A9:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x023F + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x82AC;
                    goto case 0x82AC;
                case 0x82AC:
                    _ram[(0x0300 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x82AF;
                    goto case 0x82AF;
                case 0x82AD:
                    TotalCycles += 7; PushU16(0x82AF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x82AF:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x82B0;
                    goto case 0x82B0;
                case 0x82B0:
                    Cmp(X, 0x06); TotalCycles += 2; PC = 0x82B2;
                    goto case 0x82B2;
                case 0x82B1:
                    _ram[0x30] = Asl(_ram[0x30]); TotalCycles += 5; PC = 0x82B3;
                    goto case 0x82B3;
                case 0x82B2:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x82A9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x82A9; }
                    PC = 0x82B4; goto case 0x82B4;
                case 0x82B3:
                    Sbc(_ram[(byte)(0xAC + X)]); TotalCycles += 4; PC = 0x82B5;
                    return;
                case 0x82B4:
                    Y = _ram[0x075F]; SetZN(Y); TotalCycles += 4; PC = 0x82B7;
                    goto case 0x82B7;
                case 0x82B7:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x82B8;
                    goto case 0x82B8;
                case 0x82B8:
                    _ram[0x0304] = Y; TotalCycles += 4; PC = 0x82BB;
                    goto case 0x82BB;
                case 0x82BB:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x82BD;
                    goto case 0x82BD;
                case 0x82BC:
                    TotalCycles += 7; PushU16(0x82BE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x82BD:
                    _ram[0x06FC] = A; TotalCycles += 4; PC = 0x82C0;
                    goto case 0x82C0;
                case 0x82BF:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x82C1;
                    goto case 0x82C1;
                case 0x82C0:
                    TotalCycles += 6; PushU16(0x82C2); PC = 0xAEEA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x82C1:
                     TotalCycles += 2; PC = 0x82C2;
                    goto case 0x82C2;
                case 0x82C2:
                    X = _ram[0x06A5]; SetZN(X); TotalCycles += 4; PC = 0x82C5;
                    goto case 0x82C5;
                case 0x82C3:
                    A = _ram[0x0E]; SetZN(A); TotalCycles += 3; PC = 0x82C5;
                    goto case 0x82C5;
                case 0x82C4:
                    _ram[0x06C9] = Asl(_ram[0x06C9]); TotalCycles += 6; PC = 0x82C7;
                    goto case 0x82C7;
                case 0x82C5:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0x82C7;
                    goto case 0x82C7;
                case 0x82C6:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0x82C8;
                    return;
                case 0x82C7:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x830D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x830D; }
                    PC = 0x82C9; goto case 0x82C9;
                case 0x82C9:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x82CB;
                    goto case 0x82CB;
                case 0x82CA:
                    TotalCycles += 7; PushU16(0x82CC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x82CB:
                    _ram[0x0770] = A; TotalCycles += 4; PC = 0x82CE;
                    goto case 0x82CE;
                case 0x82CC:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x82D5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x82CE; goto case 0x82CE;
                case 0x82CE:
                    _ram[0x0772] = A; TotalCycles += 4; PC = 0x82D1;
                    goto case 0x82D1;
                case 0x82D1:
                    _ram[0x0722] = A; TotalCycles += 4; PC = 0x82D4;
                    goto case 0x82D4;
                case 0x82D4:
                    _ram[0x0774] = IncVal(_ram[0x0774]); TotalCycles += 6; PC = 0x82D7;
                    goto case 0x82D7;
                case 0x82D7:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x82D8:
                    Y = _ram[0x07A2]; SetZN(Y); TotalCycles += 4; PC = 0x82DB;
                    goto case 0x82DB;
                case 0x82D9:
                    X = 0x07; SetZN(X); TotalCycles += 2; PC = 0x82DB;
                    goto case 0x82DB;
                case 0x82DB:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x82C9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x82C9; }
                    PC = 0x82DD; goto case 0x82DD;
                case 0x82DC:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x100A]); TotalCycles += 4; PC = 0x82DF;
                    goto case 0x82DF;
                case 0x82DD:
                    A = Asl(A); TotalCycles += 2; PC = 0x82DE;
                    goto case 0x82DE;
                case 0x82DE:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x82E6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x82E6; }
                    PC = 0x82E0; goto case 0x82E0;
                case 0x82DF:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0x82E1;
                    goto case 0x82E1;
                case 0x82E0:
                    A = _ram[0x07FD]; SetZN(A); TotalCycles += 4; PC = 0x82E3;
                    goto case 0x82E3;
                case 0x82E1:
                    Sbc(ReadMem(0x2007 + X)); TotalCycles += 4; PC = 0x82E4;
                    goto case 0x82E4;
                case 0x82E3:
                    TotalCycles += 6; PushU16(0x82E5); PC = 0x830E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x830E;
                case 0x82E4:
                    { int a = 0x2083; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x82E7;
                    return;
                case 0x82E6:
                    TotalCycles += 6; PushU16(0x82E8); PC = 0x9C03;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9C03;
                case 0x82E9:
                    _ram[0x075D] = IncVal(_ram[0x075D]); TotalCycles += 6; PC = 0x82EC;
                    goto case 0x82EC;
                case 0x82EA:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x6E07 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x82ED;
                    return;
                case 0x82EC:
                    _ram[0x0764] = IncVal(_ram[0x0764]); TotalCycles += 6; PC = 0x82EF;
                    goto case 0x82EF;
                case 0x82EF:
                    _ram[0x0757] = IncVal(_ram[0x0757]); TotalCycles += 6; PC = 0x82F2;
                    goto case 0x82F2;
                case 0x82F2:
                    _ram[0x0770] = IncVal(_ram[0x0770]); TotalCycles += 6; PC = 0x82F5;
                    goto case 0x82F5;
                case 0x82F3:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x82FC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x82FC; }
                    PC = 0x82F5; goto case 0x82F5;
                case 0x82F5:
                    A = _ram[0x07FC]; SetZN(A); TotalCycles += 4; PC = 0x82F8;
                    goto case 0x82F8;
                case 0x82F8:
                    _ram[0x076A] = A; TotalCycles += 4; PC = 0x82FB;
                    goto case 0x82FB;
                case 0x82F9:
                    A = Ror(A); TotalCycles += 2; PC = 0x82FA;
                    return;
                case 0x82FB:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x82FD;
                    goto case 0x82FD;
                case 0x82FC:
                    TotalCycles += 7; PushU16(0x82FE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x82FD:
                    _ram[0x0772] = A; TotalCycles += 4; PC = 0x8300;
                    goto case 0x8300;
                case 0x8300:
                    _ram[0x07A2] = A; TotalCycles += 4; PC = 0x8303;
                    goto case 0x8303;
                case 0x8301:
                    X = 0x07; SetZN(X); TotalCycles += 2; PC = 0x8303;
                    goto case 0x8303;
                case 0x8303:
                    X = 0x17; SetZN(X); TotalCycles += 2; PC = 0x8305;
                    goto case 0x8305;
                case 0x8305:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8307;
                    goto case 0x8307;
                case 0x8306:
                    TotalCycles += 7; PushU16(0x8308); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8307:
                    _ram[(0x07DD + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x830A;
                    goto case 0x830A;
                case 0x8308:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x4A07 + X) & 0x7FFF]); TotalCycles += 4; PC = 0x830B;
                    goto case 0x830B;
                case 0x830A:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x830B;
                    goto case 0x830B;
                case 0x830B:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8307; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8307; }
                    PC = 0x830D; goto case 0x830D;
                case 0x830D:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x830E: // === SUBROUTINE: Sub_830E ===
                    _ram[0x075F] = A; TotalCycles += 4; PC = 0x8311;
                    goto case 0x8311;
                case 0x8311:
                    _ram[0x0766] = A; TotalCycles += 4; PC = 0x8314;
                    goto case 0x8314;
                case 0x8312:
                    _ram[0x07] = Ror(_ram[0x07]); TotalCycles += 5; PC = 0x8314;
                    goto case 0x8314;
                case 0x8314:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x8316;
                    goto case 0x8316;
                case 0x8315:
                    TotalCycles += 7; PushU16(0x8317); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8316:
                    _ram[0x0760] = X; TotalCycles += 4; PC = 0x8319;
                    goto case 0x8319;
                case 0x8317:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8319:
                    _ram[0x0767] = X; TotalCycles += 4; PC = 0x831C;
                    goto case 0x831C;
                case 0x831C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x831F:
                    A ^= 0x83; SetZN(A); TotalCycles += 2; PC = 0x8321;
                    goto case 0x8321;
                case 0x8321:
                    { int a = 0x2424; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0x8324;
                    goto case 0x8324;
                case 0x8322:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8324;
                    goto case 0x8324;
                case 0x8323:
                    Bit(_ram[0x00]); TotalCycles += 3; PC = 0x8325;
                    goto case 0x8325;
                case 0x8324:
                    TotalCycles += 7; PushU16(0x8326); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8325: // === SUBROUTINE: Sub_8325 ===
                    Y = 0x07; SetZN(Y); TotalCycles += 2; PC = 0x8327;
                    goto case 0x8327;
                case 0x8327:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x031D + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x832A;
                    goto case 0x832A;
                case 0x8328:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x1983 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x832B;
                    goto case 0x832B;
                case 0x832A:
                    _ram[(0x0300 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x832D;
                    goto case 0x832D;
                case 0x832B:
                    TotalCycles += 7; PushU16(0x832D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x832D:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x832E;
                    goto case 0x832E;
                case 0x832E:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8327; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8327; }
                    PC = 0x8330; goto case 0x8330;
                case 0x8330:
                    A = _ram[0x077A]; SetZN(A); TotalCycles += 4; PC = 0x8333;
                    goto case 0x8333;
                case 0x8333:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x833F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x833F; }
                    PC = 0x8335; goto case 0x8335;
                case 0x8334:
                    A = Asl(A); TotalCycles += 2; PC = 0x8335;
                    goto case 0x8335;
                case 0x8335:
                    A = 0x24; SetZN(A); TotalCycles += 2; PC = 0x8337;
                    goto case 0x8337;
                case 0x8336:
                    Bit(_ram[0x8D]); TotalCycles += 3; PC = 0x8338;
                    return;
                case 0x8337:
                    _ram[0x0304] = A; TotalCycles += 4; PC = 0x833A;
                    goto case 0x833A;
                case 0x833A:
                    A = 0xCE; SetZN(A); TotalCycles += 2; PC = 0x833C;
                    goto case 0x833C;
                case 0x833B:
                    _ram[0x068D] = DecVal(_ram[0x068D]); TotalCycles += 6; PC = 0x833E;
                    return;
                case 0x833C:
                    _ram[0x0306] = A; TotalCycles += 4; PC = 0x833F;
                    goto case 0x833F;
                case 0x833D:
                    _ram[0x03] = Asl(_ram[0x03]); TotalCycles += 5; PC = 0x833F;
                    goto case 0x833F;
                case 0x833F:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8340:
                    A |= ReadMem(ReadU16Zp((byte)(0x80 + X))); SetZN(A); TotalCycles += 6; PC = 0x8342;
                    return;
                case 0x8343:
                    WriteMem(ReadU16Zp((byte)(0x41 + X)), A); TotalCycles += 6; PC = 0x8345;
                    return;
                case 0x8344:
                    A ^= ReadMem(ReadU16Zp((byte)(0x80 + X))); SetZN(A); TotalCycles += 6; PC = 0x8346;
                    goto case 0x8346;
                case 0x8346:
                    A |= ReadMem(ReadU16Zp((byte)(0x42 + X))); SetZN(A); TotalCycles += 6; PC = 0x8348;
                    return;
                case 0x834B:
                    A ^= ReadMem(ReadU16Zp((byte)(0xC1 + X))); SetZN(A); TotalCycles += 6; PC = 0x834D;
                    goto case 0x834D;
                case 0x834C:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x41 + X)))); TotalCycles += 6; PC = 0x834E;
                    goto case 0x834E;
                case 0x834D:
                    A ^= ReadMem(ReadU16Zp((byte)(0xC1 + X))); SetZN(A); TotalCycles += 6; PC = 0x834F;
                    goto case 0x834F;
                case 0x834E:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x01 + X)))); TotalCycles += 6; PC = 0x8350;
                    goto case 0x8350;
                case 0x834F:
                    A |= ReadMem(ReadU16Zp((byte)(0xC1 + X))); SetZN(A); TotalCycles += 6; PC = 0x8351;
                    goto case 0x8351;
                case 0x8350:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x01 + X)))); TotalCycles += 6; PC = 0x8352;
                    return;
                case 0x8351:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0x8353;
                    return;
                case 0x8354:
                    TotalCycles += 7; PushU16(0x8356); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8356:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8370; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8358; goto case 0x8358;
                case 0x8357:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8358;
                    goto case 0x8358;
                case 0x8358:
                    A |= _ram[0x2C]; SetZN(A); TotalCycles += 3; PC = 0x835A;
                    goto case 0x835A;
                case 0x8359:
                    Bit(ReadIoReg(0x2420)); TotalCycles += 4; PC = 0x835C;
                    goto case 0x835C;
                case 0x835A:
                    TotalCycles += 6; PushU16(0x835C); PC = 0x1524;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x835B: // === SUBROUTINE: DrawMushroomIcon ===
                    Bit(_ram[0x15]); TotalCycles += 3; PC = 0x835D;
                    return;
                case 0x835C:
                    A |= _ram[(byte)(0x5A + X)]; SetZN(A); TotalCycles += 4; PC = 0x835E;
                    goto case 0x835E;
                case 0x835E:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8380; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8380; }
                    PC = 0x8360; goto case 0x8360;
                case 0x835F:
                    TotalCycles += 6; PushU16(0x8361); PC = 0x3028;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8360:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x8361;
                    goto case 0x8361;
                case 0x8361:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8383; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8383; }
                    PC = 0x8363; goto case 0x8363;
                case 0x8362:
                    TotalCycles += 6; PushU16(0x8364); PC = 0x8010;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8363:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x82E5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8365; goto case 0x8365;
                case 0x8365:
                    TotalCycles += 6; PushU16(0x8367); PC = 0x3030;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8366:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8398; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8368; goto case 0x8368;
                case 0x8367:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x836A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x836A; }
                    PC = 0x8369; return;
                case 0x8368:
                    A |= ReadMem(ReadU16Zp((byte)(0xFF + X))); SetZN(A); TotalCycles += 6; PC = 0x836A;
                    goto case 0x836A;
                case 0x836A:
                    TotalCycles += 7; PushU16(0x836C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x836B: // === SUBROUTINE: Sub_836B ===
                    X = _ram[0x0717]; SetZN(X); TotalCycles += 4; PC = 0x836E;
                    goto case 0x836E;
                case 0x836E:
                    A = _ram[0x0718]; SetZN(A); TotalCycles += 4; PC = 0x8371;
                    goto case 0x8371;
                case 0x836F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8370;
                    return;
                case 0x8371:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8380; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8380; }
                    PC = 0x8373; goto case 0x8373;
                case 0x8372:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x6EE8]; SetZN(A); TotalCycles += 4; PC = 0x8375;
                    return;
                case 0x8373:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8374;
                    goto case 0x8374;
                case 0x8374:
                    _ram[0x0717] = IncVal(_ram[0x0717]); TotalCycles += 6; PC = 0x8377;
                    goto case 0x8377;
                case 0x8377:
                    P |= FlagC; TotalCycles += 2; PC = 0x8378;
                    goto case 0x8378;
                case 0x8378:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0354 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x837B;
                    goto case 0x837B;
                case 0x837B:
                    _ram[0x0718] = A; TotalCycles += 4; PC = 0x837E;
                    goto case 0x837E;
                case 0x837C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x837D;
                    return;
                case 0x837E: // === SUBROUTINE: DemoEngine ===
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x838A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x838A; }
                    PC = 0x8380; goto case 0x8380;
                case 0x837F:
                    A = Asl(A); TotalCycles += 2; PC = 0x8380;
                    goto case 0x8380;
                case 0x8380:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x033F + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8383;
                    goto case 0x8383;
                case 0x8383:
                    _ram[0x06FC] = A; TotalCycles += 4; PC = 0x8386;
                    goto case 0x8386;
                case 0x8385:
                    _ram[0xCE] = Asl(_ram[0xCE]); TotalCycles += 5; PC = 0x8387;
                    goto case 0x8387;
                case 0x8386:
                    _ram[0x0718] = DecVal(_ram[0x0718]); TotalCycles += 6; PC = 0x8389;
                    goto case 0x8389;
                case 0x8387:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8388;
                    return;
                case 0x8389:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x838A;
                    goto case 0x838A;
                case 0x838A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x838B: // === SUBROUTINE: Sub_838B ===
                    TotalCycles += 6; PushU16(0x838D); PC = 0x83A0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x83A0;
                case 0x838C:
                    Y = 0x83; SetZN(Y); TotalCycles += 2; PC = 0x838E;
                    goto case 0x838E;
                case 0x838E:
                    A = _ram[0x0772]; SetZN(A); TotalCycles += 4; PC = 0x8391;
                    goto case 0x8391;
                case 0x8391:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x839A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x839A; }
                    PC = 0x8393; goto case 0x8393;
                case 0x8393:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x8395;
                    goto case 0x8395;
                case 0x8394:
                    TotalCycles += 7; PushU16(0x8396); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8395:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0x8397;
                    goto case 0x8397;
                case 0x8396:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8397;
                    goto case 0x8397;
                case 0x8397:
                    TotalCycles += 6; PushU16(0x8399); PC = 0xC047;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8399:
                    Cmp(Y, 0x20); TotalCycles += 2; PC = 0x839B;
                    goto case 0x839B;
                case 0x839A:
                    TotalCycles += 6; PushU16(0x839C); PC = 0xF12A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x839B:
                    A = Rol(A); TotalCycles += 2; PC = 0x839C;
                    goto case 0x839C;
                case 0x839C:
                    Sbc(ReadMem(ReadU16Zp(0x4C) + Y)); TotalCycles += 5; PC = 0x839E;
                    goto case 0x839E;
                case 0x839D:
                    TotalCycles += 3; PC = 0xEEE9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x839E:
                    Sbc(0xEE); TotalCycles += 2; PC = 0x83A0;
                    goto case 0x83A0;
                case 0x839F:
                    { int a = 0x72AD; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0x83A2;
                    return;
                case 0x83A0: // === SUBROUTINE: VictoryMode ===
                    A = _ram[0x0772]; SetZN(A); TotalCycles += 4; PC = 0x83A3;
                    goto case 0x83A3;
                case 0x83A3:
                    TotalCycles += 6; PushU16(0x83A5); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E04;
                case 0x83A5:
                    WriteIoReg(0xCFEC, X); TotalCycles += 4; PC = 0x83A8;
                    goto case 0x83A8;
                case 0x83A6:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x30CF]); TotalCycles += 4; PC = 0x83A9;
                    return;
                case 0x83A8:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x832D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x832D; }
                    PC = 0x83AA; goto case 0x83AA;
                case 0x83AA:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x7683 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x83AD;
                    return;
                case 0x83AC:
                    { byte z = (byte)(0x83 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0x83AE;
                    goto case 0x83AE;
                case 0x83AE:
                    Adc(ReadMem(ReadU16Zp((byte)(0x84 + X)))); TotalCycles += 6; PC = 0x83B0;
                    goto case 0x83B0;
                case 0x83AF: // === SUBROUTINE: BridgeCollapse ===
                    _ram[0xAE] = Y; TotalCycles += 3; PC = 0x83B1;
                    return;
                case 0x83B0:
                    X = _ram[0x071B]; SetZN(X); TotalCycles += 4; PC = 0x83B3;
                    goto case 0x83B3;
                case 0x83B3:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x83B4;
                    goto case 0x83B4;
                case 0x83B4:
                    _ram[0x34] = X; TotalCycles += 3; PC = 0x83B6;
                    goto case 0x83B6;
                case 0x83B6:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0x83B8;
                    goto case 0x83B8;
                case 0x83B7:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x83B8;
                    goto case 0x83B8;
                case 0x83B8:
                    _ram[0xFC] = A; TotalCycles += 3; PC = 0x83BA;
                    goto case 0x83BA;
                case 0x83BA:
                    TotalCycles += 3; PC = 0x874E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x874E;
                case 0x83BB:
                    { int a = 0xA087; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x83BE;
                    goto case 0x83BE;
                case 0x83BD:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x83BF;
                    goto case 0x83BF;
                case 0x83BE:
                    TotalCycles += 7; PushU16(0x83C0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x83BF:
                    _ram[0x35] = Y; TotalCycles += 3; PC = 0x83C1;
                    goto case 0x83C1;
                case 0x83C0:
                    A &= _ram[(byte)(0xA5 + X)]; SetZN(A); TotalCycles += 4; PC = 0x83C2;
                    goto case 0x83C2;
                case 0x83C1:
                    A = _ram[0x6D]; SetZN(A); TotalCycles += 3; PC = 0x83C3;
                    goto case 0x83C3;
                case 0x83C2:
                    Adc(ReadIoReg(0x34C5)); TotalCycles += 4; PC = 0x83C5;
                    goto case 0x83C5;
                case 0x83C3:
                    Cmp(A, _ram[0x34]); TotalCycles += 3; PC = 0x83C5;
                    goto case 0x83C5;
                case 0x83C5:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x83CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x83CD; }
                    PC = 0x83C7; goto case 0x83C7;
                case 0x83C6:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0x83C8;
                    goto case 0x83C8;
                case 0x83C7:
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0x83C9;
                    goto case 0x83C9;
                case 0x83C8:
                    _ram[0xC9] = X; TotalCycles += 3; PC = 0x83CA;
                    goto case 0x83CA;
                case 0x83C9:
                    Cmp(A, 0x60); TotalCycles += 2; PC = 0x83CB;
                    goto case 0x83CB;
                case 0x83CA:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x83CB:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x83D0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x83D0; }
                    PC = 0x83CD; goto case 0x83CD;
                case 0x83CD:
                    _ram[0x35] = IncVal(_ram[0x35]); TotalCycles += 5; PC = 0x83CF;
                    goto case 0x83CF;
                case 0x83CE:
                    A &= _ram[(byte)(0xC8 + X)]; SetZN(A); TotalCycles += 4; PC = 0x83D0;
                    goto case 0x83D0;
                case 0x83CF:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x83D0;
                    goto case 0x83D0;
                case 0x83D0:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x83D1;
                    goto case 0x83D1;
                case 0x83D1:
                    TotalCycles += 6; PushU16(0x83D3); PC = 0xB0E6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x83D2:
                    _ram[0xB0] = IncVal(_ram[0xB0]); TotalCycles += 5; PC = 0x83D4;
                    goto case 0x83D4;
                case 0x83D3:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8382; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x83D5; return;
                case 0x83D4:
                    A = _ram[0x071A]; SetZN(A); TotalCycles += 4; PC = 0x83D7;
                    goto case 0x83D7;
                case 0x83D7:
                    Cmp(A, _ram[0x34]); TotalCycles += 3; PC = 0x83D9;
                    goto case 0x83D9;
                case 0x83D9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x83F1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x83F1; }
                    PC = 0x83DB; goto case 0x83DB;
                case 0x83DA:
                    { byte z = (byte)(0xAD + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x83DC;
                    goto case 0x83DC;
                case 0x83DB:
                    A = _ram[0x0768]; SetZN(A); TotalCycles += 4; PC = 0x83DE;
                    goto case 0x83DE;
                case 0x83DC:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x83DD;
                    return;
                case 0x83DE:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x83DF;
                    goto case 0x83DF;
                case 0x83DF:
                    Adc(0x80); TotalCycles += 2; PC = 0x83E1;
                    goto case 0x83E1;
                case 0x83E1:
                    _ram[0x0768] = A; TotalCycles += 4; PC = 0x83E4;
                    goto case 0x83E4;
                case 0x83E2:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x83E3;
                    return;
                case 0x83E4:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x83E6;
                    goto case 0x83E6;
                case 0x83E5:
                    A |= ReadMem(ReadU16Zp((byte)(0x69 + X))); SetZN(A); TotalCycles += 6; PC = 0x83E7;
                    goto case 0x83E7;
                case 0x83E6:
                    Adc(0x00); TotalCycles += 2; PC = 0x83E8;
                    goto case 0x83E8;
                case 0x83E7:
                    TotalCycles += 7; PushU16(0x83E9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x83E8:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x83E9;
                    goto case 0x83E9;
                case 0x83E9:
                    TotalCycles += 6; PushU16(0x83EB); PC = 0xAFC4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x83EA:
                    Cmp(Y, _ram[0xAF]); TotalCycles += 3; PC = 0x83EC;
                    goto case 0x83EC;
                case 0x83EC:
                    TotalCycles += 6; PushU16(0x83EE); PC = 0xAF6F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x83EF:
                    _ram[0x35] = IncVal(_ram[0x35]); TotalCycles += 5; PC = 0x83F1;
                    goto case 0x83F1;
                case 0x83F0:
                    A &= _ram[(byte)(0xA5 + X)]; SetZN(A); TotalCycles += 4; PC = 0x83F2;
                    goto case 0x83F2;
                case 0x83F1:
                    A = _ram[0x35]; SetZN(A); TotalCycles += 3; PC = 0x83F3;
                    goto case 0x83F3;
                case 0x83F2:
                    A &= _ram[(byte)(0xF0 + X)]; SetZN(A); TotalCycles += 4; PC = 0x83F4;
                    goto case 0x83F4;
                case 0x83F3:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x845D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x845D; }
                    PC = 0x83F5; goto case 0x83F5;
                case 0x83F4:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x83F5;
                    goto case 0x83F5;
                case 0x83F5:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x83F6:
                    A = _ram[0x0749]; SetZN(A); TotalCycles += 4; PC = 0x83F9;
                    goto case 0x83F9;
                case 0x83F7:
                    A ^= 0x07; SetZN(A); TotalCycles += 2; PC = 0x83F9;
                    goto case 0x83F9;
                case 0x83F9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8443; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8443; }
                    PC = 0x83FB; goto case 0x83FB;
                case 0x83FA:
                    PushU8(A); TotalCycles += 3; PC = 0x83FB;
                    goto case 0x83FB;
                case 0x83FB:
                    A = _ram[0x0719]; SetZN(A); TotalCycles += 4; PC = 0x83FE;
                    goto case 0x83FE;
                case 0x83FC:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x7007 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x83FF;
                    goto case 0x83FF;
                case 0x83FE:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8418; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8418; }
                    PC = 0x8400; goto case 0x8400;
                case 0x83FF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8400;
                    goto case 0x8400;
                case 0x8400:
                    Cmp(A, 0x09); TotalCycles += 2; PC = 0x8402;
                    goto case 0x8402;
                case 0x8401:
                    A |= 0xB0; SetZN(A); TotalCycles += 2; PC = 0x8403;
                    return;
                case 0x8402:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8443; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8443; }
                    PC = 0x8404; goto case 0x8404;
                case 0x8404:
                    Y = _ram[0x075F]; SetZN(Y); TotalCycles += 4; PC = 0x8407;
                    goto case 0x8407;
                case 0x8407:
                    Cmp(Y, 0x07); TotalCycles += 2; PC = 0x8409;
                    goto case 0x8409;
                case 0x8409:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8414; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8414; }
                    PC = 0x840B; goto case 0x840B;
                case 0x840A:
                    A |= 0xC9; SetZN(A); TotalCycles += 2; PC = 0x840C;
                    return;
                case 0x840B:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0x840D;
                    goto case 0x840D;
                case 0x840D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8443; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8443; }
                    PC = 0x840F; goto case 0x840F;
                case 0x840F:
                    Sbc(0x01); TotalCycles += 2; PC = 0x8411;
                    goto case 0x8411;
                case 0x8410:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0x8412;
                    goto case 0x8412;
                case 0x8411:
                    TotalCycles += 3; PC = 0x8418;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8418;
                case 0x8412:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8413;
                    goto case 0x8413;
                case 0x8413:
                    _ram[0xC9] = Y; TotalCycles += 3; PC = 0x8415;
                    return;
                case 0x8414:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0x8416;
                    goto case 0x8416;
                case 0x8416:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8443; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8443; }
                    PC = 0x8418; goto case 0x8418;
                case 0x8418:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x8419;
                    goto case 0x8419;
                case 0x8419:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8423; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8423; }
                    PC = 0x841B; goto case 0x841B;
                case 0x841A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x841B;
                    goto case 0x841B;
                case 0x841B:
                    A = _ram[0x0753]; SetZN(A); TotalCycles += 4; PC = 0x841E;
                    goto case 0x841E;
                case 0x841E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8434; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8434; }
                    PC = 0x8420; goto case 0x8420;
                case 0x8420:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8421;
                    goto case 0x8421;
                case 0x8421:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8434; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8434; }
                    PC = 0x8423; goto case 0x8423;
                case 0x8422:
                    A |= ReadMem(ReadU16Zp(0xC8) + Y); SetZN(A); TotalCycles += 5; PC = 0x8424;
                    goto case 0x8424;
                case 0x8423:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8424;
                    goto case 0x8424;
                case 0x8424:
                    A = _ram[0x075F]; SetZN(A); TotalCycles += 4; PC = 0x8427;
                    goto case 0x8427;
                case 0x8427:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0x8429;
                    goto case 0x8429;
                case 0x8429:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8434; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8434; }
                    PC = 0x842B; goto case 0x842B;
                case 0x842A:
                    A |= 0x88; SetZN(A); TotalCycles += 2; PC = 0x842C;
                    goto case 0x842C;
                case 0x842B:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x842C;
                    goto case 0x842C;
                case 0x842C:
                    Cmp(Y, 0x04); TotalCycles += 2; PC = 0x842E;
                    goto case 0x842E;
                case 0x842E:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8456; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8456; }
                    PC = 0x8430; goto case 0x8430;
                case 0x842F:
                    _ram[0xC0] = Rol(_ram[0xC0]); TotalCycles += 5; PC = 0x8431;
                    return;
                case 0x8430:
                    Cmp(Y, 0x03); TotalCycles += 2; PC = 0x8432;
                    goto case 0x8432;
                case 0x8432:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8443; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8443; }
                    PC = 0x8434; goto case 0x8434;
                case 0x8434:
                    Cmp(Y, 0x03); TotalCycles += 2; PC = 0x8436;
                    goto case 0x8436;
                case 0x8436:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x843C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x843C; }
                    PC = 0x8438; goto case 0x8438;
                case 0x8438:
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0x843A;
                    goto case 0x843A;
                case 0x843A:
                    _ram[0xFC] = A; TotalCycles += 3; PC = 0x843C;
                    goto case 0x843C;
                case 0x843C: // === SUBROUTINE: SetupVictoryMode ===
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x843D;
                    goto case 0x843D;
                case 0x843D:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x843E;
                    goto case 0x843E;
                case 0x843E:
                    Adc(0x0C); TotalCycles += 2; PC = 0x8440;
                    goto case 0x8440;
                case 0x8440:
                    _ram[0x0773] = A; TotalCycles += 4; PC = 0x8443;
                    goto case 0x8443;
                case 0x8443:
                    A = _ram[0x0749]; SetZN(A); TotalCycles += 4; PC = 0x8446;
                    goto case 0x8446;
                case 0x8444:
                    A ^= 0x07; SetZN(A); TotalCycles += 2; PC = 0x8446;
                    goto case 0x8446;
                case 0x8446:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8447;
                    goto case 0x8447;
                case 0x8447:
                    Adc(0x04); TotalCycles += 2; PC = 0x8449;
                    goto case 0x8449;
                case 0x8449:
                    _ram[0x0749] = A; TotalCycles += 4; PC = 0x844C;
                    goto case 0x844C;
                case 0x844A:
                    A ^= 0x07; SetZN(A); TotalCycles += 2; PC = 0x844C;
                    goto case 0x844C;
                case 0x844C:
                    A = _ram[0x0719]; SetZN(A); TotalCycles += 4; PC = 0x844F;
                    goto case 0x844F;
                case 0x844D:
                    A |= ReadMem(0x6907 + Y); SetZN(A); TotalCycles += 4; PC = 0x8450;
                    goto case 0x8450;
                case 0x844F:
                    Adc(0x00); TotalCycles += 2; PC = 0x8451;
                    goto case 0x8451;
                case 0x8450:
                    TotalCycles += 7; PushU16(0x8452); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8451:
                    _ram[0x0719] = A; TotalCycles += 4; PC = 0x8454;
                    goto case 0x8454;
                case 0x8452:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x4907 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8455;
                    return;
                case 0x8454:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0x8456;
                    goto case 0x8456;
                case 0x8456:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8460; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8460; }
                    PC = 0x8458; goto case 0x8458;
                case 0x8457:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8458;
                    goto case 0x8458;
                case 0x8458:
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0x845A;
                    goto case 0x845A;
                case 0x8459:
                    _ram[0x8D] = Asl(_ram[0x8D]); TotalCycles += 5; PC = 0x845B;
                    goto case 0x845B;
                case 0x845A:
                    _ram[0x07A1] = A; TotalCycles += 4; PC = 0x845D;
                    goto case 0x845D;
                case 0x845B: // === SUBROUTINE: PlayerEndWorld ===
                    A = ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x845D;
                    goto case 0x845D;
                case 0x845D:
                    _ram[0x0772] = IncVal(_ram[0x0772]); TotalCycles += 6; PC = 0x8460;
                    goto case 0x8460;
                case 0x8460:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8461: // === SUBROUTINE: Sub_8461 ===
                    A = _ram[0x07A1]; SetZN(A); TotalCycles += 4; PC = 0x8464;
                    goto case 0x8464;
                case 0x8462:
                    A = ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x8464;
                    goto case 0x8464;
                case 0x8464:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8486; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8486; }
                    PC = 0x8466; goto case 0x8466;
                case 0x8465:
                    TotalCycles += 6; PushU16(0x8467); PC = 0x5FAC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8466:
                    Y = _ram[0x075F]; SetZN(Y); TotalCycles += 4; PC = 0x8469;
                    goto case 0x8469;
                case 0x8469:
                    Cmp(Y, 0x07); TotalCycles += 2; PC = 0x846B;
                    goto case 0x846B;
                case 0x846B:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8487; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8487; }
                    PC = 0x846D; goto case 0x846D;
                case 0x846D:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x846F;
                    goto case 0x846F;
                case 0x846E:
                    TotalCycles += 7; PushU16(0x8470); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x846F:
                    _ram[0x0760] = A; TotalCycles += 4; PC = 0x8472;
                    goto case 0x8472;
                case 0x8470:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8472:
                    _ram[0x075C] = A; TotalCycles += 4; PC = 0x8475;
                    goto case 0x8475;
                case 0x8475:
                    _ram[0x0772] = A; TotalCycles += 4; PC = 0x8478;
                    goto case 0x8478;
                case 0x8478:
                    _ram[0x075F] = IncVal(_ram[0x075F]); TotalCycles += 6; PC = 0x847B;
                    goto case 0x847B;
                case 0x847B:
                    TotalCycles += 6; PushU16(0x847D); PC = 0x9C03;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9C03;
                case 0x847E:
                    _ram[0x0757] = IncVal(_ram[0x0757]); TotalCycles += 6; PC = 0x8481;
                    goto case 0x8481;
                case 0x8481:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x8483;
                    goto case 0x8483;
                case 0x8482:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x8484;
                    goto case 0x8484;
                case 0x8483:
                    _ram[0x0770] = A; TotalCycles += 4; PC = 0x8486;
                    goto case 0x8486;
                case 0x8484:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x848D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x848D; }
                    PC = 0x8486; goto case 0x8486;
                case 0x8486:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8487:
                    A = _ram[0x06FC]; SetZN(A); TotalCycles += 4; PC = 0x848A;
                    goto case 0x848A;
                case 0x8489:
                    _ram[0x0D] = Asl(_ram[0x0D]); TotalCycles += 5; PC = 0x848B;
                    goto case 0x848B;
                case 0x848A:
                    A |= _ram[0x06FD]; SetZN(A); TotalCycles += 4; PC = 0x848D;
                    goto case 0x848D;
                case 0x848B:
                    Sbc(ReadMem(0x2906 + X)); TotalCycles += 4; PC = 0x848E;
                    goto case 0x848E;
                case 0x848C:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0x848E;
                    goto case 0x848E;
                case 0x848D:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0x848F;
                    goto case 0x848F;
                case 0x848E:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x848F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x849E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x849E; }
                    PC = 0x8491; goto case 0x8491;
                case 0x8490:
                    A |= _ram[0x01A9]; SetZN(A); TotalCycles += 4; PC = 0x8493;
                    goto case 0x8493;
                case 0x8491:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x8493;
                    goto case 0x8493;
                case 0x8492:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x8494;
                    return;
                case 0x8493:
                    _ram[0x07FC] = A; TotalCycles += 4; PC = 0x8496;
                    goto case 0x8496;
                case 0x8496:
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0x8498;
                    goto case 0x8498;
                case 0x8498:
                    _ram[0x075A] = A; TotalCycles += 4; PC = 0x849B;
                    goto case 0x849B;
                case 0x849B:
                    TotalCycles += 6; PushU16(0x849D); PC = 0x9248;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9248;
                case 0x849C:
                    PushU8(A); TotalCycles += 3; PC = 0x849D;
                    return;
                case 0x849E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x84A1:
                    { byte z = (byte)(0xFB + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0x84A3;
                    return;
                case 0x84A5:
                    P |= FlagD; TotalCycles += 2; PC = 0x84A6;
                    return;
                case 0x84A7:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7AFB + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x84AA;
                    return;
                case 0x84AB:
                    { byte z = (byte)(0x50 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0x84AD;
                    return;
                case 0x84AC:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x84A5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x84A5; }
                    PC = 0x84AE; goto case 0x84AE;
                case 0x84AE:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x84A8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x84B0; goto case 0x84B0;
                case 0x84AF:
                    P |= FlagD; TotalCycles += 2; PC = 0x84B0;
                    goto case 0x84B0;
                case 0x84B0:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x84AB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x84AB; }
                    PC = 0x84B2; goto case 0x84B2;
                case 0x84B1:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7A50 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x84B4;
                    goto case 0x84B4;
                case 0x84B2:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x84AE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x84AE; }
                    PC = 0x84B4; goto case 0x84B4;
                case 0x84B4:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x84B3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x84B6; goto case 0x84B6;
                case 0x84B5:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7FFE + X) & 0x7FFF]); TotalCycles += 4; PC = 0x84B8;
                    goto case 0x84B8;
                case 0x84B6:
                    { int a = 0x41FF + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0x84B9;
                    return;
                case 0x84B8:
                    A ^= ReadMem(ReadU16Zp((byte)(0x42 + X))); SetZN(A); TotalCycles += 6; PC = 0x84BA;
                    return;
                case 0x84BB:
                    A ^= _ram[0x48]; SetZN(A); TotalCycles += 3; PC = 0x84BD;
                    goto case 0x84BD;
                case 0x84BC:
                    PushU8(A); TotalCycles += 3; PC = 0x84BD;
                    goto case 0x84BD;
                case 0x84BD:
                    A &= ReadMem(ReadU16Zp(0x32) + Y); SetZN(A); TotalCycles += 5; PC = 0x84BF;
                    return;
                case 0x84C0:
                    A &= _ram[(byte)(0x38 + X)]; SetZN(A); TotalCycles += 4; PC = 0x84C2;
                    goto case 0x84C2;
                case 0x84C1:
                    P |= FlagC; TotalCycles += 2; PC = 0x84C2;
                    goto case 0x84C2;
                case 0x84C2:
                    TotalCycles += 7; PushU16(0x84C4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x84C3: // === SUBROUTINE: Sub_84C3 ===
                    A = _ram[(0x0110 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x84C6;
                    goto case 0x84C6;
                case 0x84C4:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x84C7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x84C7; }
                    PC = 0x84C6; goto case 0x84C6;
                case 0x84C5:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0x84C7;
                    goto case 0x84C7;
                case 0x84C6:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8486; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8486; }
                    PC = 0x84C8; goto case 0x84C8;
                case 0x84C7:
                    X = ReadMem(0x0BC9 + Y); SetZN(X); TotalCycles += 4; PC = 0x84CA;
                    goto case 0x84CA;
                case 0x84C8:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0x84CA;
                    goto case 0x84CA;
                case 0x84CA:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x84D1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x84D1; }
                    PC = 0x84CC; goto case 0x84CC;
                case 0x84CB:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0x84CD;
                    return;
                case 0x84CC:
                    A = 0x0B; SetZN(A); TotalCycles += 2; PC = 0x84CE;
                    goto case 0x84CE;
                case 0x84CE:
                    _ram[(0x0110 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x84D1;
                    goto case 0x84D1;
                case 0x84CF:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x84D2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x84D2; }
                    PC = 0x84D1; goto case 0x84D1;
                case 0x84D0:
                    A |= ReadMem(ReadU16Zp((byte)(0xA8 + X))); SetZN(A); TotalCycles += 6; PC = 0x84D2;
                    goto case 0x84D2;
                case 0x84D1:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x84D2;
                    goto case 0x84D2;
                case 0x84D2:
                    A = _ram[(0x012C + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x84D5;
                    goto case 0x84D5;
                case 0x84D3:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x5001]); TotalCycles += 4; PC = 0x84D6;
                    return;
                case 0x84D4:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0x84D6;
                    return;
                case 0x84D5:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x84DB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x84DB; }
                    PC = 0x84D7; goto case 0x84D7;
                case 0x84D7:
                    _ram[(0x0110 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x84DA;
                    goto case 0x84DA;
                case 0x84D8:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x84DB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x84DB; }
                    PC = 0x84DA; goto case 0x84DA;
                case 0x84D9:
                    A |= ReadMem(ReadU16Zp((byte)(0x60 + X))); SetZN(A); TotalCycles += 6; PC = 0x84DB;
                    goto case 0x84DB;
                case 0x84DA:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x84DB:
                    { int a = (0x012C + X) & 0x07FF; _ram[a] = DecVal(_ram[a]); } TotalCycles += 7; PC = 0x84DE;
                    goto case 0x84DE;
                case 0x84DC:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x4901]); TotalCycles += 4; PC = 0x84DF;
                    return;
                case 0x84DD:
                    A |= ReadMem(ReadU16Zp((byte)(0xC9 + X))); SetZN(A); TotalCycles += 6; PC = 0x84DF;
                    return;
                case 0x84DE:
                    Cmp(A, 0x2B); TotalCycles += 2; PC = 0x84E0;
                    goto case 0x84E0;
                case 0x84E0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8500; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8500; }
                    PC = 0x84E2; goto case 0x84E2;
                case 0x84E1:
                    { int a = 0x0BC0 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x84E4;
                    goto case 0x84E4;
                case 0x84E2:
                    Cmp(Y, 0x0B); TotalCycles += 2; PC = 0x84E4;
                    goto case 0x84E4;
                case 0x84E4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x84ED; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x84ED; }
                    PC = 0x84E6; goto case 0x84E6;
                case 0x84E6:
                    _ram[0x075A] = IncVal(_ram[0x075A]); TotalCycles += 6; PC = 0x84E9;
                    goto case 0x84E9;
                case 0x84E9:
                    A = 0x40; SetZN(A); TotalCycles += 2; PC = 0x84EB;
                    goto case 0x84EB;
                case 0x84EA:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x84EB:
                    _ram[0xFE] = A; TotalCycles += 3; PC = 0x84ED;
                    goto case 0x84ED;
                case 0x84EC:
                    { int a = 0xB7B9 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0x84EF;
                    goto case 0x84EF;
                case 0x84ED:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x04B7 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x84F0;
                    goto case 0x84F0;
                case 0x84EF:
                    _ram[0x4A] = Y; TotalCycles += 3; PC = 0x84F1;
                    goto case 0x84F1;
                case 0x84F0:
                    A = Lsr(A); TotalCycles += 2; PC = 0x84F1;
                    goto case 0x84F1;
                case 0x84F1:
                    A = Lsr(A); TotalCycles += 2; PC = 0x84F2;
                    goto case 0x84F2;
                case 0x84F2:
                    A = Lsr(A); TotalCycles += 2; PC = 0x84F3;
                    goto case 0x84F3;
                case 0x84F3:
                    A = Lsr(A); TotalCycles += 2; PC = 0x84F4;
                    goto case 0x84F4;
                case 0x84F4:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x84F5;
                    goto case 0x84F5;
                case 0x84F5:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x04B7 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x84F8;
                    goto case 0x84F8;
                case 0x84F7:
                    _ram[0x29] = Y; TotalCycles += 3; PC = 0x84F9;
                    return;
                case 0x84F8:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x84FA;
                    goto case 0x84FA;
                case 0x84FA:
                    _ram[(0x0134 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x84FD;
                    goto case 0x84FD;
                case 0x84FC:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0x84FE;
                    return;
                case 0x84FD:
                    TotalCycles += 6; PushU16(0x84FF); PC = 0xBC27;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x84FF:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x65BC + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0x8502;
                    goto case 0x8502;
                case 0x8500:
                    Y = _ram[(0x06E5 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x8503;
                    goto case 0x8503;
                case 0x8501:
                    Sbc(_ram[0x06]); TotalCycles += 3; PC = 0x8503;
                    goto case 0x8503;
                case 0x8502:
                    _ram[0xB5] = Asl(_ram[0xB5]); TotalCycles += 5; PC = 0x8504;
                    goto case 0x8504;
                case 0x8503:
                    A = _ram[(byte)(0x16 + X)]; SetZN(A); TotalCycles += 4; PC = 0x8505;
                    goto case 0x8505;
                case 0x8504:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8506;
                    return;
                case 0x8505:
                    Cmp(A, 0x12); TotalCycles += 2; PC = 0x8507;
                    goto case 0x8507;
                case 0x8507:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x852B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x852B; }
                    PC = 0x8509; goto case 0x8509;
                case 0x8509:
                    Cmp(A, 0x0D); TotalCycles += 2; PC = 0x850B;
                    goto case 0x850B;
                case 0x850A:
                    A |= _ram[0x06F0]; SetZN(A); TotalCycles += 4; PC = 0x850D;
                    goto case 0x850D;
                case 0x850B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x852B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x852B; }
                    PC = 0x850D; goto case 0x850D;
                case 0x850C:
                    { int a = (0x05C9 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0x850F;
                    goto case 0x850F;
                case 0x850D:
                    Cmp(A, 0x05); TotalCycles += 2; PC = 0x850F;
                    goto case 0x850F;
                case 0x850E:
                    A |= _ram[0xF0]; SetZN(A); TotalCycles += 3; PC = 0x8510;
                    return;
                case 0x850F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8523; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8523; }
                    PC = 0x8511; goto case 0x8511;
                case 0x8511:
                    Cmp(A, 0x0A); TotalCycles += 2; PC = 0x8513;
                    goto case 0x8513;
                case 0x8512:
                    A = Asl(A); TotalCycles += 2; PC = 0x8513;
                    goto case 0x8513;
                case 0x8513:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x852B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x852B; }
                    PC = 0x8515; goto case 0x8515;
                case 0x8514:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8516;
                    return;
                case 0x8515:
                    Cmp(A, 0x0B); TotalCycles += 2; PC = 0x8517;
                    goto case 0x8517;
                case 0x8517:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x852B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x852B; }
                    PC = 0x8519; goto case 0x8519;
                case 0x8519:
                    Cmp(A, 0x09); TotalCycles += 2; PC = 0x851B;
                    goto case 0x851B;
                case 0x851A:
                    A |= 0xB0; SetZN(A); TotalCycles += 2; PC = 0x851C;
                    goto case 0x851C;
                case 0x851B:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8523; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8523; }
                    PC = 0x851D; goto case 0x851D;
                case 0x851C:
                    _ram[0xB5] = Asl(_ram[0xB5]); TotalCycles += 5; PC = 0x851E;
                    goto case 0x851E;
                case 0x851D:
                    A = _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0x851F;
                    goto case 0x851F;
                case 0x851E:
                    { int a = (0x02C9 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0x8521;
                    goto case 0x8521;
                case 0x851F:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0x8521;
                    goto case 0x8521;
                case 0x8521:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x852B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x852B; }
                    PC = 0x8523; goto case 0x8523;
                case 0x8522:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8523;
                    goto case 0x8523;
                case 0x8523:
                    X = _ram[0x03EE]; SetZN(X); TotalCycles += 4; PC = 0x8526;
                    goto case 0x8526;
                case 0x8524:
                    { int a = 0xBC03; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0x8527;
                    goto case 0x8527;
                case 0x8526:
                    Y = _ram[(0x06EC + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x8529;
                    goto case 0x8529;
                case 0x8527:
                    Cmp(X, SmbEmbeddedAssets.StaticDataTables[0x2606]); TotalCycles += 4; PC = 0x852A;
                    goto case 0x852A;
                case 0x8528:
                    _ram[0xA6] = Asl(_ram[0xA6]); TotalCycles += 5; PC = 0x852A;
                    goto case 0x852A;
                case 0x8529:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0x852B;
                    goto case 0x852B;
                case 0x852A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x852B;
                    goto case 0x852B;
                case 0x852B:
                    A = _ram[(0x011E + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x852E;
                    goto case 0x852E;
                case 0x852C:
                    { int a = 0xC901 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x852F;
                    goto case 0x852F;
                case 0x852D:
                    A |= ReadMem(ReadU16Zp((byte)(0xC9 + X))); SetZN(A); TotalCycles += 6; PC = 0x852F;
                    goto case 0x852F;
                case 0x852E:
                    Cmp(A, 0x18); TotalCycles += 2; PC = 0x8530;
                    goto case 0x8530;
                case 0x852F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8530;
                    goto case 0x8530;
                case 0x8530:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8537; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8537; }
                    PC = 0x8532; goto case 0x8532;
                case 0x8531:
                    A |= _ram[0xE9]; SetZN(A); TotalCycles += 3; PC = 0x8533;
                    goto case 0x8533;
                case 0x8532:
                    Sbc(0x01); TotalCycles += 2; PC = 0x8534;
                    goto case 0x8534;
                case 0x8533:
                    A |= ReadMem(ReadU16Zp((byte)(0x9D + X))); SetZN(A); TotalCycles += 6; PC = 0x8535;
                    goto case 0x8535;
                case 0x8534:
                    _ram[(0x011E + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8537;
                    goto case 0x8537;
                case 0x8535:
                    { int a = 0xBD01 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8538;
                    goto case 0x8538;
                case 0x8536:
                    A |= ReadMem(ReadU16Zp((byte)(0xBD + X))); SetZN(A); TotalCycles += 6; PC = 0x8538;
                    goto case 0x8538;
                case 0x8537:
                    A = _ram[(0x011E + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x853A;
                    goto case 0x853A;
                case 0x8538:
                    { int a = 0xE901 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x853B;
                    goto case 0x853B;
                case 0x8539:
                    A |= ReadMem(ReadU16Zp((byte)(0xE9 + X))); SetZN(A); TotalCycles += 6; PC = 0x853B;
                    goto case 0x853B;
                case 0x853A:
                    Sbc(0x08); TotalCycles += 2; PC = 0x853C;
                    goto case 0x853C;
                case 0x853B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x853C;
                    goto case 0x853C;
                case 0x853C:
                    TotalCycles += 6; PushU16(0x853E); PC = 0xE5C1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x853D:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0xE5 + X)))); TotalCycles += 6; PC = 0x853F;
                    goto case 0x853F;
                case 0x853E:
                    Sbc(_ram[0xBD]); TotalCycles += 3; PC = 0x8540;
                    return;
                case 0x853F:
                    A = _ram[(0x0117 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8542;
                    goto case 0x8542;
                case 0x8541:
                    A |= ReadMem(ReadU16Zp((byte)(0x99 + X))); SetZN(A); TotalCycles += 6; PC = 0x8543;
                    return;
                case 0x8542:
                    _ram[(0x0203 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8545;
                    goto case 0x8545;
                case 0x8545:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8546;
                    goto case 0x8546;
                case 0x8546:
                    Adc(0x08); TotalCycles += 2; PC = 0x8548;
                    goto case 0x8548;
                case 0x8547:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8548;
                    goto case 0x8548;
                case 0x8548:
                    _ram[(0x0207 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x854B;
                    goto case 0x854B;
                case 0x854B:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0x854D;
                    goto case 0x854D;
                case 0x854D:
                    _ram[(0x0202 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8550;
                    goto case 0x8550;
                case 0x8550:
                    _ram[(0x0206 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8553;
                    goto case 0x8553;
                case 0x8551:
                    _ram[0x02] = Asl(_ram[0x02]); TotalCycles += 5; PC = 0x8553;
                    goto case 0x8553;
                case 0x8553: // === SUBROUTINE: PlayerLoseLife ===
                    A = _ram[(0x0110 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8556;
                    goto case 0x8556;
                case 0x8554:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8557; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8557; }
                    PC = 0x8556; goto case 0x8556;
                case 0x8555:
                    A |= ReadMem(ReadU16Zp((byte)(0x0A + X))); SetZN(A); TotalCycles += 6; PC = 0x8557;
                    goto case 0x8557;
                case 0x8556:
                    A = Asl(A); TotalCycles += 2; PC = 0x8557;
                    goto case 0x8557;
                case 0x8557:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x8558;
                    goto case 0x8558;
                case 0x8558:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x049F + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x855B;
                    goto case 0x855B;
                case 0x855A:
                    _ram[0x99] = Y; TotalCycles += 3; PC = 0x855C;
                    goto case 0x855C;
                case 0x855B:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x855E;
                    goto case 0x855E;
                case 0x855C:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0x855E;
                    goto case 0x855E;
                case 0x855E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x04A0 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8561;
                    goto case 0x8561;
                case 0x855F:
                    Y = 0x84; SetZN(Y); TotalCycles += 2; PC = 0x8561;
                    goto case 0x8561;
                case 0x8560:
                    _ram[0x99] = Y; TotalCycles += 3; PC = 0x8562;
                    goto case 0x8562;
                case 0x8561:
                    _ram[(0x0205 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8564;
                    goto case 0x8564;
                case 0x8562:
                    A |= _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0x8564;
                    goto case 0x8564;
                case 0x8564:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0x8566;
                    goto case 0x8566;
                case 0x8565:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8566;
                    goto case 0x8566;
                case 0x8566:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8567: // === SUBROUTINE: ScreenRoutines ===
                    A = _ram[0x073C]; SetZN(A); TotalCycles += 4; PC = 0x856A;
                    goto case 0x856A;
                case 0x856A:
                    TotalCycles += 6; PushU16(0x856C); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E04;
                case 0x856C:
                    WriteIoReg(0x858B, X); TotalCycles += 4; PC = 0x856F;
                    return;
                case 0x856E:
                    _ram[0x9B] = A; TotalCycles += 3; PC = 0x8570;
                    goto case 0x8570;
                case 0x8570:
                    _ram[0x52] = A; TotalCycles += 3; PC = 0x8572;
                    goto case 0x8572;
                case 0x8572:
                    _ram[0x5A] = X; TotalCycles += 3; PC = 0x8574;
                    goto case 0x8574;
                case 0x8574:
                    _ram[0x93] = X; TotalCycles += 3; PC = 0x8576;
                    goto case 0x8576;
                case 0x8576:
                    _ram[0x9D] = X; TotalCycles += 3; PC = 0x8578;
                    goto case 0x8578;
                case 0x8577:
                    WriteMem(0xA888 + X, A); TotalCycles += 5; PC = 0x857A;
                    goto case 0x857A;
                case 0x8578:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8579;
                    goto case 0x8579;
                case 0x8579:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x857A;
                    goto case 0x857A;
                case 0x857A:
                    _ram[0x9D] = X; TotalCycles += 3; PC = 0x857C;
                    goto case 0x857C;
                case 0x857B:
                    WriteMem(0xE688 + X, A); TotalCycles += 5; PC = 0x857E;
                    goto case 0x857E;
                case 0x857C:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x857D;
                    goto case 0x857D;
                case 0x857D:
                    _ram[0x86] = IncVal(_ram[0x86]); TotalCycles += 5; PC = 0x857F;
                    return;
                case 0x857E:
                    _ram[0xBF] = X; TotalCycles += 3; PC = 0x8580;
                    goto case 0x8580;
                case 0x8580:
                    _ram[0xE3] = A; TotalCycles += 3; PC = 0x8582;
                    goto case 0x8582;
                case 0x8582:
                    _ram[0x43] = A; TotalCycles += 3; PC = 0x8584;
                    goto case 0x8584;
                case 0x8584:
                    _ram[0xFF] = X; TotalCycles += 3; PC = 0x8586;
                    goto case 0x8586;
                case 0x8586:
                    _ram[0x32] = X; TotalCycles += 3; PC = 0x8588;
                    return;
                case 0x8589: // === SUBROUTINE: InitScreen ===
                    A ^= 0x87; SetZN(A); TotalCycles += 2; PC = 0x858B;
                    goto case 0x858B;
                case 0x858B:
                    TotalCycles += 6; PushU16(0x858D); PC = 0x8220;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8220;
                case 0x858C:
                    TotalCycles += 6; PushU16(0x858E); PC = 0x2082;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x858E:
                    TotalCycles += 6; PushU16(0x8590); PC = 0x8E19;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E19;
                case 0x858F:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x2D8E + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8592;
                    goto case 0x8592;
                case 0x8590:
                    WriteIoReg(0x70AD, X); TotalCycles += 4; PC = 0x8593;
                    return;
                case 0x8591:
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0x8594;
                    goto case 0x8594;
                case 0x8592:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x859B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x859B; }
                    PC = 0x8594; goto case 0x8594;
                case 0x8594:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x85C8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x85C8; }
                    PC = 0x8596; goto case 0x8596;
                case 0x8596:
                    X = 0x03; SetZN(X); TotalCycles += 2; PC = 0x8598;
                    goto case 0x8598;
                case 0x8598:
                    TotalCycles += 3; PC = 0x85C5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x85C5;
                case 0x8599:
                    Cmp(A, _ram[0x85]); TotalCycles += 3; PC = 0x859B;
                    goto case 0x859B;
                case 0x859A:
                    _ram[0xAD] = A; TotalCycles += 3; PC = 0x859C;
                    return;
                case 0x859B: // === SUBROUTINE: Sub_859B ===
                    A = _ram[0x0744]; SetZN(A); TotalCycles += 4; PC = 0x859E;
                    goto case 0x859E;
                case 0x859E:
                    PushU8(A); TotalCycles += 3; PC = 0x859F;
                    goto case 0x859F;
                case 0x859F:
                    A = _ram[0x0756]; SetZN(A); TotalCycles += 4; PC = 0x85A2;
                    goto case 0x85A2;
                case 0x85A0:
                    { byte z = (byte)(0x07 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x85A2;
                    goto case 0x85A2;
                case 0x85A2:
                    PushU8(A); TotalCycles += 3; PC = 0x85A3;
                    goto case 0x85A3;
                case 0x85A3:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x85A5;
                    goto case 0x85A5;
                case 0x85A4:
                    TotalCycles += 7; PushU16(0x85A6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x85A5:
                    _ram[0x0756] = A; TotalCycles += 4; PC = 0x85A8;
                    goto case 0x85A8;
                case 0x85A6:
                    { byte z = (byte)(0x07 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x85A8;
                    goto case 0x85A8;
                case 0x85A8:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0x85AA;
                    goto case 0x85AA;
                case 0x85AA:
                    _ram[0x0744] = A; TotalCycles += 4; PC = 0x85AD;
                    goto case 0x85AD;
                case 0x85AD:
                    TotalCycles += 6; PushU16(0x85AF); PC = 0x85F1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x85F1;
                case 0x85AE:
                    Sbc(ReadMem(ReadU16Zp(0x85) + Y)); TotalCycles += 5; PC = 0x85B0;
                    goto case 0x85B0;
                case 0x85AF:
                    _ram[0x68] = A; TotalCycles += 3; PC = 0x85B1;
                    goto case 0x85B1;
                case 0x85B0:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x85B1;
                    goto case 0x85B1;
                case 0x85B1:
                    _ram[0x0756] = A; TotalCycles += 4; PC = 0x85B4;
                    goto case 0x85B4;
                case 0x85B2:
                    { byte z = (byte)(0x07 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x85B4;
                    goto case 0x85B4;
                case 0x85B4:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x85B5;
                    goto case 0x85B5;
                case 0x85B5:
                    _ram[0x0744] = A; TotalCycles += 4; PC = 0x85B8;
                    goto case 0x85B8;
                case 0x85B8:
                    TotalCycles += 3; PC = 0x8745;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8745;
                case 0x85B9:
                    A ^= _ram[0x87]; SetZN(A); TotalCycles += 3; PC = 0x85BB;
                    goto case 0x85BB;
                case 0x85BB:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0x85BD;
                    return;
                case 0x85BF:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x85C2;
                    goto case 0x85C2;
                case 0x85C0:
                    { int a = 0xBE07; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x85C3;
                    return;
                case 0x85C2:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x05BB + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0x85C5;
                    goto case 0x85C5;
                case 0x85C4:
                    _ram[0x8E] = A; TotalCycles += 3; PC = 0x85C6;
                    return;
                case 0x85C5:
                    _ram[0x0773] = X; TotalCycles += 4; PC = 0x85C8;
                    goto case 0x85C8;
                case 0x85C8:
                    TotalCycles += 3; PC = 0x8745;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8745;
                case 0x85C9:
                    A ^= _ram[0x87]; SetZN(A); TotalCycles += 3; PC = 0x85CB;
                    goto case 0x85CB;
                case 0x85CB:
                    TotalCycles += 7; PushU16(0x85CD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x85CC:
                    A |= 0x0A; SetZN(A); TotalCycles += 2; PC = 0x85CE;
                    return;
                case 0x85CD:
                    A = Asl(A); TotalCycles += 2; PC = 0x85CE;
                    return;
                case 0x85D8:
                    { byte z = (byte)(0x27 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x85DA;
                    goto case 0x85DA;
                case 0x85DA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x85DB;
                    return;
                case 0x85DC:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8605; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8605; }
                    PC = 0x85DE; goto case 0x85DE;
                case 0x85DE:
                    A |= ReadMem(0x3722 + Y); SetZN(A); TotalCycles += 4; PC = 0x85E1;
                    return;
                case 0x85E2:
                    { byte z = (byte)(0xAC + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x85E4;
                    return;
                case 0x85E3:
                    Y = _ram[0x0744]; SetZN(Y); TotalCycles += 4; PC = 0x85E6;
                    goto case 0x85E6;
                case 0x85E6:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x85EE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x85EE; }
                    PC = 0x85E8; goto case 0x85E8;
                case 0x85E7:
                    _ram[0xB9] = Asl(_ram[0xB9]); TotalCycles += 5; PC = 0x85E9;
                    return;
                case 0x85E8:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x05C7 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x85EB;
                    goto case 0x85EB;
                case 0x85EA:
                    _ram[0x8D] = A; TotalCycles += 3; PC = 0x85EC;
                    return;
                case 0x85EB:
                    _ram[0x0773] = A; TotalCycles += 4; PC = 0x85EE;
                    goto case 0x85EE;
                case 0x85EE:
                    _ram[0x073C] = IncVal(_ram[0x073C]); TotalCycles += 6; PC = 0x85F1;
                    goto case 0x85F1;
                case 0x85F1: // === SUBROUTINE: Sub_85F1 ===
                    X = _ram[0x0300]; SetZN(X); TotalCycles += 4; PC = 0x85F4;
                    goto case 0x85F4;
                case 0x85F2:
                    TotalCycles += 7; PushU16(0x85F4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x85F4:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x85F6;
                    goto case 0x85F6;
                case 0x85F5:
                    TotalCycles += 7; PushU16(0x85F7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x85F6:
                    A = _ram[0x0753]; SetZN(A); TotalCycles += 4; PC = 0x85F9;
                    goto case 0x85F9;
                case 0x85F9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x85FD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x85FD; }
                    PC = 0x85FB; goto case 0x85FB;
                case 0x85FB:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0x85FD;
                    goto case 0x85FD;
                case 0x85FD:
                    A = _ram[0x0756]; SetZN(A); TotalCycles += 4; PC = 0x8600;
                    goto case 0x8600;
                case 0x85FE:
                    { byte z = (byte)(0x07 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x8600;
                    goto case 0x8600;
                case 0x8600:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0x8602;
                    goto case 0x8602;
                case 0x8602:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8606; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8606; }
                    PC = 0x8604; goto case 0x8604;
                case 0x8604:
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0x8606;
                    goto case 0x8606;
                case 0x8605:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8606;
                    goto case 0x8606;
                case 0x8606:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x8608;
                    goto case 0x8608;
                case 0x8608:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x860A;
                    goto case 0x860A;
                case 0x8609:
                    TotalCycles += 7; PushU16(0x860B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x860A:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x05D7 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x860D;
                    goto case 0x860D;
                case 0x860C:
                    _ram[0x9D] = A; TotalCycles += 3; PC = 0x860E;
                    return;
                case 0x860D:
                    _ram[(0x0304 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8610;
                    goto case 0x8610;
                case 0x8610:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8611;
                    goto case 0x8611;
                case 0x8611:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8612;
                    goto case 0x8612;
                case 0x8612:
                    _ram[0x00] = DecVal(_ram[0x00]); TotalCycles += 5; PC = 0x8614;
                    goto case 0x8614;
                case 0x8613:
                    TotalCycles += 7; PushU16(0x8615); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8614:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x860A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x860A; }
                    PC = 0x8616; goto case 0x8616;
                case 0x8616:
                    X = _ram[0x0300]; SetZN(X); TotalCycles += 4; PC = 0x8619;
                    goto case 0x8619;
                case 0x8617:
                    TotalCycles += 7; PushU16(0x8619); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8619:
                    Y = _ram[0x0744]; SetZN(Y); TotalCycles += 4; PC = 0x861C;
                    goto case 0x861C;
                case 0x861C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8621; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8621; }
                    PC = 0x861E; goto case 0x861E;
                case 0x861E:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x8621;
                    goto case 0x8621;
                case 0x861F:
                    { int a = 0xB907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x8622;
                    return;
                case 0x8621:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x05CF + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8624;
                    goto case 0x8624;
                case 0x8623:
                    _ram[0x9D] = A; TotalCycles += 3; PC = 0x8625;
                    return;
                case 0x8624:
                    _ram[(0x0304 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8627;
                    goto case 0x8627;
                case 0x8627:
                    A = 0x3F; SetZN(A); TotalCycles += 2; PC = 0x8629;
                    goto case 0x8629;
                case 0x8629:
                    _ram[(0x0301 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x862C;
                    goto case 0x862C;
                case 0x862A:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x862C;
                    goto case 0x862C;
                case 0x862C:
                    A = 0x10; SetZN(A); TotalCycles += 2; PC = 0x862E;
                    goto case 0x862E;
                case 0x862D:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x85CC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x85CC; }
                    PC = 0x862F; return;
                case 0x862E:
                    _ram[(0x0302 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8631;
                    goto case 0x8631;
                case 0x8631: // === SUBROUTINE: GetBackgroundColor ===
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0x8633;
                    goto case 0x8633;
                case 0x8633:
                    _ram[(0x0303 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8636;
                    goto case 0x8636;
                case 0x8636:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8638;
                    goto case 0x8638;
                case 0x8637:
                    TotalCycles += 7; PushU16(0x8639); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8638:
                    _ram[(0x0308 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x863B;
                    goto case 0x863B;
                case 0x8639:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x863A;
                    return;
                case 0x863B:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x863C;
                    goto case 0x863C;
                case 0x863C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x863D;
                    goto case 0x863D;
                case 0x863D:
                    Adc(0x07); TotalCycles += 2; PC = 0x863F;
                    goto case 0x863F;
                case 0x863F:
                    _ram[0x0300] = A; TotalCycles += 4; PC = 0x8642;
                    goto case 0x8642;
                case 0x8640:
                    TotalCycles += 7; PushU16(0x8642); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8642:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8643: // === SUBROUTINE: Sub_8643 ===
                    A = _ram[0x0733]; SetZN(A); TotalCycles += 4; PC = 0x8646;
                    goto case 0x8646;
                case 0x8646:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0x8648;
                    goto case 0x8648;
                case 0x8647:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0x8649;
                    goto case 0x8649;
                case 0x8648:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x864F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x864F; }
                    PC = 0x864A; goto case 0x864A;
                case 0x8649:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0x864B;
                    return;
                case 0x864A:
                    A = 0x0B; SetZN(A); TotalCycles += 2; PC = 0x864C;
                    goto case 0x864C;
                case 0x864C:
                    _ram[0x0773] = A; TotalCycles += 4; PC = 0x864F;
                    goto case 0x864F;
                case 0x864F:
                    TotalCycles += 3; PC = 0x8745;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8745;
                case 0x8650:
                    A ^= _ram[0x87]; SetZN(A); TotalCycles += 3; PC = 0x8652;
                    goto case 0x8652;
                case 0x8652: // === SUBROUTINE: Sub_8652 ===
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8654;
                    goto case 0x8654;
                case 0x8653:
                    TotalCycles += 7; PushU16(0x8655); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8654:
                    TotalCycles += 6; PushU16(0x8656); PC = 0x8808;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8808;
                case 0x8655:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8656;
                    goto case 0x8656;
                case 0x8656:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8657;
                    goto case 0x8657;
                case 0x8657:
                    TotalCycles += 3; PC = 0x8745;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8745;
                case 0x8658:
                    A ^= _ram[0x87]; SetZN(A); TotalCycles += 3; PC = 0x865A;
                    goto case 0x865A;
                case 0x865A: // === SUBROUTINE: Sub_865A ===
                    TotalCycles += 6; PushU16(0x865C); PC = 0xBC30;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x865B:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8619; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8619; }
                    PC = 0x865D; goto case 0x865D;
                case 0x865C:
                    Y = _ram[(0x00AE + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x865F;
                    return;
                case 0x865D:
                    X = _ram[0x0300]; SetZN(X); TotalCycles += 4; PC = 0x8660;
                    goto case 0x8660;
                case 0x865E:
                    TotalCycles += 7; PushU16(0x8660); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8660:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0x8662;
                    goto case 0x8662;
                case 0x8661:
                    TotalCycles += 6; PushU16(0x8663); PC = 0x019D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8662:
                    _ram[(0x0301 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8665;
                    goto case 0x8665;
                case 0x8663:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x8665;
                    goto case 0x8665;
                case 0x8665:
                    A = 0x73; SetZN(A); TotalCycles += 2; PC = 0x8667;
                    goto case 0x8667;
                case 0x8667:
                    _ram[(0x0302 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x866A;
                    goto case 0x866A;
                case 0x866A:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x866C;
                    goto case 0x866C;
                case 0x866C:
                    _ram[(0x0303 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x866F;
                    goto case 0x866F;
                case 0x866F:
                    Y = _ram[0x075F]; SetZN(Y); TotalCycles += 4; PC = 0x8672;
                    goto case 0x8672;
                case 0x8672:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8673;
                    goto case 0x8673;
                case 0x8673:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x8674;
                    goto case 0x8674;
                case 0x8674:
                    _ram[(0x0304 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8677;
                    goto case 0x8677;
                case 0x8677:
                    A = 0x28; SetZN(A); TotalCycles += 2; PC = 0x8679;
                    goto case 0x8679;
                case 0x8678:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x8679;
                    goto case 0x8679;
                case 0x8679:
                    _ram[(0x0305 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x867C;
                    goto case 0x867C;
                case 0x867A:
                    A |= _ram[0x03]; SetZN(A); TotalCycles += 3; PC = 0x867C;
                    goto case 0x867C;
                case 0x867C:
                    Y = _ram[0x075C]; SetZN(Y); TotalCycles += 4; PC = 0x867F;
                    goto case 0x867F;
                case 0x867F:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8680;
                    goto case 0x8680;
                case 0x8680:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x8681;
                    goto case 0x8681;
                case 0x8681:
                    _ram[(0x0306 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8684;
                    goto case 0x8684;
                case 0x8682:
                    _ram[0x03] = Asl(_ram[0x03]); TotalCycles += 5; PC = 0x8684;
                    goto case 0x8684;
                case 0x8684:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8686;
                    goto case 0x8686;
                case 0x8685:
                    TotalCycles += 7; PushU16(0x8687); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8686:
                    _ram[(0x0307 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8689;
                    goto case 0x8689;
                case 0x8689:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x868A;
                    goto case 0x868A;
                case 0x868A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x868B;
                    goto case 0x868B;
                case 0x868B:
                    Adc(0x06); TotalCycles += 2; PC = 0x868D;
                    goto case 0x868D;
                case 0x868C:
                    _ram[0x8D] = Asl(_ram[0x8D]); TotalCycles += 5; PC = 0x868E;
                    goto case 0x868E;
                case 0x868D:
                    _ram[0x0300] = A; TotalCycles += 4; PC = 0x8690;
                    goto case 0x8690;
                case 0x868E:
                    TotalCycles += 7; PushU16(0x8690); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8690:
                    TotalCycles += 3; PC = 0x8745;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8745;
                case 0x8691:
                    A ^= _ram[0x87]; SetZN(A); TotalCycles += 3; PC = 0x8693;
                    goto case 0x8693;
                case 0x8693: // === SUBROUTINE: WriteTopStatusLine ===
                    A = _ram[0x0759]; SetZN(A); TotalCycles += 4; PC = 0x8696;
                    goto case 0x8696;
                case 0x8694:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x7007 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8697;
                    goto case 0x8697;
                case 0x8696:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x86A2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x86A2; }
                    PC = 0x8698; goto case 0x8698;
                case 0x8697:
                    A = Asl(A); TotalCycles += 2; PC = 0x8698;
                    goto case 0x8698;
                case 0x8698:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x869A;
                    goto case 0x869A;
                case 0x8699:
                    TotalCycles += 7; PushU16(0x869B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x869A:
                    _ram[0x0759] = A; TotalCycles += 4; PC = 0x869D;
                    goto case 0x869D;
                case 0x869B:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x2907 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x869E;
                    return;
                case 0x869D:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0x869F;
                    goto case 0x869F;
                case 0x869F:
                    TotalCycles += 3; PC = 0x86C7;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x86C7;
                case 0x86A1:
                    _ram[0xEE] = X; TotalCycles += 3; PC = 0x86A3;
                    return;
                case 0x86A2:
                    _ram[0x073C] = IncVal(_ram[0x073C]); TotalCycles += 6; PC = 0x86A5;
                    goto case 0x86A5;
                case 0x86A5:
                    TotalCycles += 3; PC = 0x8745;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8745;
                case 0x86A6:
                    A ^= _ram[0x87]; SetZN(A); TotalCycles += 3; PC = 0x86A8;
                    goto case 0x86A8;
                case 0x86A8: // === SUBROUTINE: Sub_86A8 ===
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0x86AB;
                    goto case 0x86AB;
                case 0x86A9:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x86B2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x86AB; goto case 0x86AB;
                case 0x86AB:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x86E0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x86E0; }
                    PC = 0x86AD; goto case 0x86AD;
                case 0x86AD:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0x86AF;
                    goto case 0x86AF;
                case 0x86AF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x86D3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x86D3; }
                    PC = 0x86B1; goto case 0x86B1;
                case 0x86B1:
                    A = _ram[0x0752]; SetZN(A); TotalCycles += 4; PC = 0x86B4;
                    goto case 0x86B4;
                case 0x86B4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x86E0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x86E0; }
                    PC = 0x86B6; goto case 0x86B6;
                case 0x86B5:
                    A = Rol(A); TotalCycles += 2; PC = 0x86B6;
                    goto case 0x86B6;
                case 0x86B6:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x86B9;
                    goto case 0x86B9;
                case 0x86B7:
                    { int a = 0xC007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x86BA;
                    return;
                case 0x86B9:
                    Cmp(Y, 0x03); TotalCycles += 2; PC = 0x86BB;
                    goto case 0x86BB;
                case 0x86BB:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x86C2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x86C2; }
                    PC = 0x86BD; goto case 0x86BD;
                case 0x86BC:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0x86BE;
                    goto case 0x86BE;
                case 0x86BD:
                    A = _ram[0x0769]; SetZN(A); TotalCycles += 4; PC = 0x86C0;
                    goto case 0x86C0;
                case 0x86BE:
                    Adc(0x07); TotalCycles += 2; PC = 0x86C0;
                    goto case 0x86C0;
                case 0x86C0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x86E0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x86E0; }
                    PC = 0x86C2; goto case 0x86C2;
                case 0x86C1:
                    { int a = 0xA420 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x86C4;
                    return;
                case 0x86C2:
                    TotalCycles += 6; PushU16(0x86C4); PC = 0xEFA4;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x86C3:
                    Y = _ram[0xEF]; SetZN(Y); TotalCycles += 3; PC = 0x86C5;
                    goto case 0x86C5;
                case 0x86C5:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x86C7;
                    goto case 0x86C7;
                case 0x86C6:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0x86C8;
                    goto case 0x86C8;
                case 0x86C7:
                    TotalCycles += 6; PushU16(0x86C9); PC = 0x8808;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8808;
                case 0x86C8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x86C9;
                    goto case 0x86C9;
                case 0x86C9:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x86CA;
                    goto case 0x86CA;
                case 0x86CA:
                    TotalCycles += 6; PushU16(0x86CC); PC = 0x88A5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x88A5;
                case 0x86CB:
                    A = _ram[0x88]; SetZN(A); TotalCycles += 3; PC = 0x86CD;
                    goto case 0x86CD;
                case 0x86CC:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x86CD;
                    goto case 0x86CD;
                case 0x86CD:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x86CF;
                    goto case 0x86CF;
                case 0x86CE: // === SUBROUTINE: DisplayIntermediate ===
                    TotalCycles += 7; PushU16(0x86D0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x86CF:
                    _ram[0x0774] = A; TotalCycles += 4; PC = 0x86D2;
                    goto case 0x86D2;
                case 0x86D2:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x86D3:
                    A = 0x12; SetZN(A); TotalCycles += 2; PC = 0x86D5;
                    goto case 0x86D5;
                case 0x86D5:
                    _ram[0x07A0] = A; TotalCycles += 4; PC = 0x86D8;
                    goto case 0x86D8;
                case 0x86D6:
                    Y = 0x07; SetZN(Y); TotalCycles += 2; PC = 0x86D8;
                    goto case 0x86D8;
                case 0x86D8:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x86DA;
                    goto case 0x86DA;
                case 0x86DA:
                    TotalCycles += 6; PushU16(0x86DC); PC = 0x8808;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8808;
                case 0x86DB:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x86DC;
                    goto case 0x86DC;
                case 0x86DC:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x86DD;
                    goto case 0x86DD;
                case 0x86DD:
                    TotalCycles += 3; PC = 0x874E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x874E;
                case 0x86DE:
                    { int a = 0xA987; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x86E1;
                    goto case 0x86E1;
                case 0x86E0:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0x86E2;
                    goto case 0x86E2;
                case 0x86E1:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x86E2;
                    goto case 0x86E2;
                case 0x86E2:
                    _ram[0x073C] = A; TotalCycles += 4; PC = 0x86E5;
                    goto case 0x86E5;
                case 0x86E5:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x86E6: // === SUBROUTINE: Sub_86E6 ===
                    _ram[0x0774] = IncVal(_ram[0x0774]); TotalCycles += 6; PC = 0x86E9;
                    goto case 0x86E9;
                case 0x86E9:
                    TotalCycles += 6; PushU16(0x86EB); PC = 0x92B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x92B0;
                case 0x86EA:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x867E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x86EC; goto case 0x86EC;
                case 0x86EC:
                    A = _ram[0x071F]; SetZN(A); TotalCycles += 4; PC = 0x86EF;
                    goto case 0x86EF;
                case 0x86EF:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x86E9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x86E9; }
                    PC = 0x86F1; goto case 0x86F1;
                case 0x86F0:
                    P |= FlagD; TotalCycles += 2; PC = 0x86F1;
                    goto case 0x86F1;
                case 0x86F1:
                    _ram[0x071E] = DecVal(_ram[0x071E]); TotalCycles += 6; PC = 0x86F4;
                    goto case 0x86F4;
                case 0x86F2:
                    { int a = 0x1007 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x86F5;
                    return;
                case 0x86F4:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x86F9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x86F9; }
                    PC = 0x86F6; goto case 0x86F6;
                case 0x86F6:
                    _ram[0x073C] = IncVal(_ram[0x073C]); TotalCycles += 6; PC = 0x86F9;
                    goto case 0x86F9;
                case 0x86F9:
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0x86FB;
                    goto case 0x86FB;
                case 0x86FA:
                    _ram[0x8D] = Asl(_ram[0x8D]); TotalCycles += 5; PC = 0x86FC;
                    return;
                case 0x86FB:
                    _ram[0x0773] = A; TotalCycles += 4; PC = 0x86FE;
                    goto case 0x86FE;
                case 0x86FE:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x86FF: // === SUBROUTINE: Sub_86FF ===
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0x8702;
                    goto case 0x8702;
                case 0x8700:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x8709; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8709; }
                    PC = 0x8702; goto case 0x8702;
                case 0x8702:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x874E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x874E; }
                    PC = 0x8704; goto case 0x8704;
                case 0x8703:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8704;
                    goto case 0x8704;
                case 0x8704:
                    A = 0x1E; SetZN(A); TotalCycles += 2; PC = 0x8706;
                    goto case 0x8706;
                case 0x8705:
                    { int a = (0x068D + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0x8708;
                    goto case 0x8708;
                case 0x8706:
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x8709;
                    goto case 0x8709;
                case 0x8707:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x8709;
                    goto case 0x8709;
                case 0x8708:
                    TotalCycles += 6; PushU16(0x870A); PC = 0xC0A9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8709:
                    A = 0xC0; SetZN(A); TotalCycles += 2; PC = 0x870B;
                    goto case 0x870B;
                case 0x870A:
                    Cmp(Y, 0x8D); TotalCycles += 2; PC = 0x870C;
                    goto case 0x870C;
                case 0x870B:
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x870E;
                    goto case 0x870E;
                case 0x870C:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x870E;
                    goto case 0x870E;
                case 0x870D:
                    TotalCycles += 6; PushU16(0x870F); PC = 0x03A9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x870E:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x8710;
                    goto case 0x8710;
                case 0x8710:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0x8712;
                    goto case 0x8712;
                case 0x8711:
                    A |= ReadMem(ReadU16Zp((byte)(0xA0 + X))); SetZN(A); TotalCycles += 6; PC = 0x8713;
                    goto case 0x8713;
                case 0x8712:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x8714;
                    goto case 0x8714;
                case 0x8713:
                    TotalCycles += 7; PushU16(0x8715); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8714:
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0x8716;
                    goto case 0x8716;
                case 0x8715:
                    TotalCycles += 7; PushU16(0x8717); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8716:
                    A = ReadIoReg(0x2007); SetZN(A); TotalCycles += 4; PC = 0x8719;
                    goto case 0x8719;
                case 0x8718:
                    TotalCycles += 6; PushU16(0x871A); PC = 0x07AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8719:
                    A = ReadIoReg(0x2007); SetZN(A); TotalCycles += 4; PC = 0x871C;
                    goto case 0x871C;
                case 0x871B:
                    TotalCycles += 6; PushU16(0x871D); PC = 0x0091;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x871C:
                    WriteMem(ReadU16Zp(0x00) + Y, A); TotalCycles += 6; PC = 0x871E;
                    goto case 0x871E;
                case 0x871D:
                    TotalCycles += 7; PushU16(0x871F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x871E: // === SUBROUTINE: AreaParserTaskControl ===
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x871F;
                    goto case 0x871F;
                case 0x871F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8723; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8723; }
                    PC = 0x8721; goto case 0x8721;
                case 0x8721:
                    _ram[0x01] = IncVal(_ram[0x01]); TotalCycles += 5; PC = 0x8723;
                    goto case 0x8723;
                case 0x8722:
                    A |= ReadMem(ReadU16Zp((byte)(0xA5 + X))); SetZN(A); TotalCycles += 6; PC = 0x8724;
                    goto case 0x8724;
                case 0x8723:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0x8725;
                    goto case 0x8725;
                case 0x8724:
                    A |= ReadMem(ReadU16Zp((byte)(0xC9 + X))); SetZN(A); TotalCycles += 6; PC = 0x8726;
                    return;
                case 0x8725:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0x8727;
                    goto case 0x8727;
                case 0x8727:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8719; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8719; }
                    PC = 0x8729; goto case 0x8729;
                case 0x8728:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x86EA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x86EA; }
                    PC = 0x872A; return;
                case 0x8729:
                    Cmp(Y, 0x3A); TotalCycles += 2; PC = 0x872B;
                    goto case 0x872B;
                case 0x872B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8719; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8719; }
                    PC = 0x872D; goto case 0x872D;
                case 0x872C:
                    Cmp(X, _ram[0x05A9]); TotalCycles += 4; PC = 0x872F;
                    goto case 0x872F;
                case 0x872D:
                    A = 0x05; SetZN(A); TotalCycles += 2; PC = 0x872F;
                    goto case 0x872F;
                case 0x872E:
                    A |= _ram[0x4C]; SetZN(A); TotalCycles += 3; PC = 0x8730;
                    goto case 0x8730;
                case 0x872F:
                    TotalCycles += 3; PC = 0x864C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x864C;
                case 0x8730:
                    TotalCycles += 3; PC = 0xAD86;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8731:
                    _ram[0xAD] = X; TotalCycles += 3; PC = 0x8733;
                    goto case 0x8733;
                case 0x8732: // === SUBROUTINE: Sub_8732 ===
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0x8735;
                    goto case 0x8735;
                case 0x8733:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x873C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x873C; }
                    PC = 0x8735; goto case 0x8735;
                case 0x8735:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x874E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x874E; }
                    PC = 0x8737; goto case 0x8737;
                case 0x8737:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x8739;
                    goto case 0x8739;
                case 0x8738:
                    TotalCycles += 7; PushU16(0x873A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8739:
                    _ram[(0x0300 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x873C;
                    goto case 0x873C;
                case 0x873A:
                    TotalCycles += 7; PushU16(0x873C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x873C:
                    _ram[(0x0400 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x873F;
                    goto case 0x873F;
                case 0x873D:
                    TotalCycles += 7; PushU16(0x873F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x873F:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8740;
                    goto case 0x8740;
                case 0x8740:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8739; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8739; }
                    PC = 0x8742; goto case 0x8742;
                case 0x8742:
                    TotalCycles += 6; PushU16(0x8744); PC = 0x8325;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8325;
                case 0x8743:
                    A &= _ram[0x83]; SetZN(A); TotalCycles += 3; PC = 0x8745;
                    goto case 0x8745;
                case 0x8745:
                    _ram[0x073C] = IncVal(_ram[0x073C]); TotalCycles += 6; PC = 0x8748;
                    goto case 0x8748;
                case 0x8748:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8749: // === SUBROUTINE: Sub_8749 ===
                    A = 0xFA; SetZN(A); TotalCycles += 2; PC = 0x874B;
                    goto case 0x874B;
                case 0x874B:
                    TotalCycles += 6; PushU16(0x874D); PC = 0xBC36;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x874C: // === SUBROUTINE: ClearBuffersDrawIcon ===
                    { byte z = (byte)(0xBC + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x874E;
                    goto case 0x874E;
                case 0x874D:
                    Y = ReadMem(0x72EE + X); SetZN(Y); TotalCycles += 4; PC = 0x8750;
                    return;
                case 0x874E:
                    _ram[0x0772] = IncVal(_ram[0x0772]); TotalCycles += 6; PC = 0x8751;
                    goto case 0x8751;
                case 0x8751:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8752:
                    TotalCycles += 6; PushU16(0x8754); PC = 0x0543;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8754:
                    A |= _ram[0x16]; SetZN(A); TotalCycles += 3; PC = 0x8756;
                    goto case 0x8756;
                case 0x8755:
                    { byte z = (byte)(0x0A + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8757;
                    return;
                case 0x8756:
                    A = Asl(A); TotalCycles += 2; PC = 0x8757;
                    return;
                case 0x8759:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x875A;
                    goto case 0x875A;
                case 0x875A:
                    TotalCycles += 6; PushU16(0x875C); PC = 0x0B52;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x875D:
                    TotalCycles += 6; PushU16(0x875F); PC = 0x1B18;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x875E:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x875F;
                    return;
                case 0x8760:
                    A |= _ram[(byte)(0x0D + X)]; SetZN(A); TotalCycles += 4; PC = 0x8762;
                    goto case 0x8762;
                case 0x8761:
                    A |= ReadIoReg(0x2424); SetZN(A); TotalCycles += 4; PC = 0x8764;
                    goto case 0x8764;
                case 0x8762:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8764;
                    goto case 0x8764;
                case 0x8763:
                    Bit(_ram[0x1D]); TotalCycles += 3; PC = 0x8765;
                    return;
                case 0x8764:
                    A |= ReadMem(0x1612 + X); SetZN(A); TotalCycles += 4; PC = 0x8767;
                    goto case 0x8767;
                case 0x8766:
                    { byte z = (byte)(0x0E + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8768;
                    goto case 0x8768;
                case 0x8767:
                    { int a = 0x6820; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x876A;
                    goto case 0x876A;
                case 0x8768:
                    TotalCycles += 6; PushU16(0x876A); PC = 0x0568;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8769:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x876A;
                    goto case 0x876A;
                case 0x876A:
                    A |= _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x876C;
                    goto case 0x876C;
                case 0x876B:
                    TotalCycles += 7; PushU16(0x876D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x876C:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x876E;
                    goto case 0x876E;
                case 0x876D:
                    Bit(_ram[0x2E]); TotalCycles += 3; PC = 0x876F;
                    goto case 0x876F;
                case 0x876E:
                    { int a = 0x2329; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0x8771;
                    goto case 0x8771;
                case 0x876F:
                    A &= 0x23; SetZN(A); TotalCycles += 2; PC = 0x8771;
                    goto case 0x8771;
                case 0x8771:
                    Cmp(Y, 0x7F); TotalCycles += 2; PC = 0x8773;
                    goto case 0x8773;
                case 0x8773:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x8774;
                    return;
                case 0x8776:
                    A |= ReadMem(ReadU16Zp((byte)(0xEA + X))); SetZN(A); TotalCycles += 6; PC = 0x8778;
                    return;
                case 0x8777: // === SUBROUTINE: WriteTopScore ===
                     TotalCycles += 2; PC = 0x8778;
                    return;
                case 0x8779:
                    A &= ReadMem(ReadU16Zp((byte)(0xCD + X))); SetZN(A); TotalCycles += 6; PC = 0x877B;
                    return;
                case 0x877A:
                    Cmp(A, ReadIoReg(0x2407)); TotalCycles += 4; PC = 0x877D;
                    goto case 0x877D;
                case 0x877C:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x877E;
                    goto case 0x877E;
                case 0x877D:
                    Bit(_ram[0x29]); TotalCycles += 3; PC = 0x877F;
                    goto case 0x877F;
                case 0x877E:
                    A &= 0x24; SetZN(A); TotalCycles += 2; PC = 0x8780;
                    goto case 0x8780;
                case 0x877F:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8781;
                    goto case 0x8781;
                case 0x8780:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8782;
                    goto case 0x8782;
                case 0x8781:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8783;
                    goto case 0x8783;
                case 0x8782:
                    Bit(_ram[0x21]); TotalCycles += 3; PC = 0x8784;
                    return;
                case 0x8783:
                    A &= ReadMem(ReadU16Zp((byte)(0x4B + X))); SetZN(A); TotalCycles += 6; PC = 0x8785;
                    goto case 0x8785;
                case 0x8785:
                    A |= 0x20; SetZN(A); TotalCycles += 2; PC = 0x8787;
                    goto case 0x8787;
                case 0x8786:
                    TotalCycles += 6; PushU16(0x8788); PC = 0x1B18;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8787:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8788;
                    return;
                case 0x8789:
                    A |= _ram[(byte)(0x0D + X)]; SetZN(A); TotalCycles += 4; PC = 0x878B;
                    goto case 0x878B;
                case 0x878A:
                    A |= ReadIoReg(0x2424); SetZN(A); TotalCycles += 4; PC = 0x878D;
                    goto case 0x878D;
                case 0x878B:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x878D;
                    goto case 0x878D;
                case 0x878C:
                    Bit(_ram[0x28]); TotalCycles += 3; PC = 0x878E;
                    goto case 0x878E;
                case 0x878D:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x878E;
                    goto case 0x878E;
                case 0x878E:
                    Bit(_ram[0x22]); TotalCycles += 3; PC = 0x8790;
                    return;
                case 0x8792:
                    Bit(_ram[0x23]); TotalCycles += 3; PC = 0x8794;
                    return;
                case 0x8795:
                    A |= ReadMem(ReadU16Zp((byte)(0xBA + X))); SetZN(A); TotalCycles += 6; PC = 0x8797;
                    return;
                case 0x8796:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0x8797;
                    return;
                case 0x8798:
                    A &= ReadMem(ReadU16Zp((byte)(0xCD + X))); SetZN(A); TotalCycles += 6; PC = 0x879A;
                    goto case 0x879A;
                case 0x8799:
                    Cmp(A, _ram[0x0605]); TotalCycles += 4; PC = 0x879C;
                    goto case 0x879C;
                case 0x879A:
                    A |= _ram[0x16]; SetZN(A); TotalCycles += 3; PC = 0x879C;
                    goto case 0x879C;
                case 0x879B:
                    { byte z = (byte)(0x0A + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x879D;
                    return;
                case 0x879C:
                    A = Asl(A); TotalCycles += 2; PC = 0x879D;
                    return;
                case 0x879F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x87A0;
                    return;
                case 0x87A3:
                    A |= ReadMem(0x1612 + X); SetZN(A); TotalCycles += 4; PC = 0x87A6;
                    goto case 0x87A6;
                case 0x87A5:
                    { byte z = (byte)(0x0E + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x87A7;
                    goto case 0x87A7;
                case 0x87A6:
                    _ram[0x0624] = Asl(_ram[0x0624]); TotalCycles += 6; PC = 0x87A9;
                    goto case 0x87A9;
                case 0x87A7:
                    Bit(_ram[0x1E]); TotalCycles += 3; PC = 0x87A9;
                    goto case 0x87A9;
                case 0x87A8:
                    { int a = 0xFF19 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x87AB;
                    goto case 0x87AB;
                case 0x87A9:
                    A |= ReadMem(0x21FF + Y); SetZN(A); TotalCycles += 4; PC = 0x87AC;
                    goto case 0x87AC;
                case 0x87AB:
                    A &= ReadMem(ReadU16Zp((byte)(0xCD + X))); SetZN(A); TotalCycles += 6; PC = 0x87AD;
                    goto case 0x87AD;
                case 0x87AC:
                    Cmp(A, _ram[0x0605]); TotalCycles += 4; PC = 0x87AF;
                    goto case 0x87AF;
                case 0x87AD:
                    A |= _ram[0x16]; SetZN(A); TotalCycles += 3; PC = 0x87AF;
                    goto case 0x87AF;
                case 0x87AE:
                    { byte z = (byte)(0x0A + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x87B0;
                    return;
                case 0x87AF: // === SUBROUTINE: PrintStatusBarNumbers ===
                    A = Asl(A); TotalCycles += 2; PC = 0x87B0;
                    return;
                case 0x87B2:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x87B3;
                    return;
                case 0x87B5:
                    A |= 0x10; SetZN(A); TotalCycles += 2; PC = 0x87B7;
                    goto case 0x87B7;
                case 0x87B6:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x87C2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x87C2; }
                    PC = 0x87B8; goto case 0x87B8;
                case 0x87B7:
                    A = Asl(A); TotalCycles += 2; PC = 0x87B8;
                    goto case 0x87B8;
                case 0x87B8:
                    { byte z = (byte)(0x0E + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x87BA;
                    goto case 0x87BA;
                case 0x87B9:
                    _ram[0x0024] = Asl(_ram[0x0024]); TotalCycles += 6; PC = 0x87BC;
                    return;
                case 0x87BA:
                    Bit(_ram[0x18]); TotalCycles += 3; PC = 0x87BC;
                    return;
                case 0x87BB:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x87BC;
                    return;
                case 0x87BD:
                    { int a = 0xFF1B; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x87C0;
                    goto case 0x87C0;
                case 0x87C0:
                    A &= _ram[0x84]; SetZN(A); TotalCycles += 3; PC = 0x87C2;
                    goto case 0x87C2;
                case 0x87C1:
                    _ram[0x15] = Y; TotalCycles += 3; PC = 0x87C3;
                    goto case 0x87C3;
                case 0x87C2: // === SUBROUTINE: Sub_87C2 ===
                    A |= _ram[(byte)(0x20 + X)]; SetZN(A); TotalCycles += 4; PC = 0x87C4;
                    goto case 0x87C4;
                case 0x87C3:
                    TotalCycles += 6; PushU16(0x87C5); PC = 0x150E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x87C4:
                    _ram[0x0415] = Asl(_ram[0x0415]); TotalCycles += 6; PC = 0x87C7;
                    goto case 0x87C7;
                case 0x87C5:
                    A |= _ram[(byte)(0x0C + X)]; SetZN(A); TotalCycles += 4; PC = 0x87C7;
                    goto case 0x87C7;
                case 0x87C7:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x87C8;
                    goto case 0x87C8;
                case 0x87C8:
                    { byte z = (byte)(0x0E + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x87CA;
                    goto case 0x87CA;
                case 0x87C9:
                    _ram[0x0524] = Asl(_ram[0x0524]); TotalCycles += 6; PC = 0x87CC;
                    goto case 0x87CC;
                case 0x87CA:
                    Bit(_ram[0x1D]); TotalCycles += 3; PC = 0x87CC;
                    goto case 0x87CC;
                case 0x87CB:
                    A |= ReadMem(0x2418 + X); SetZN(A); TotalCycles += 4; PC = 0x87CE;
                    goto case 0x87CE;
                case 0x87CC:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x87CD;
                    goto case 0x87CD;
                case 0x87CD:
                    Bit(_ram[0x20]); TotalCycles += 3; PC = 0x87CF;
                    goto case 0x87CF;
                case 0x87CE:
                    TotalCycles += 6; PushU16(0x87D0); PC = 0x1B0A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x87CF:
                    A = Asl(A); TotalCycles += 2; PC = 0x87D0;
                    return;
                case 0x87D1:
                    A |= ReadMem(0x2324 + Y); SetZN(A); TotalCycles += 4; PC = 0x87D4;
                    goto case 0x87D4;
                case 0x87D2:
                    Bit(_ram[0x23]); TotalCycles += 3; PC = 0x87D4;
                    goto case 0x87D4;
                case 0x87D4:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x87D5;
                    return;
                case 0x87D6:
                    { int a = 0x262B; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x87D9;
                    goto case 0x87D9;
                case 0x87D8:
                    _ram[0x25] = Rol(_ram[0x25]); TotalCycles += 5; PC = 0x87DA;
                    goto case 0x87DA;
                case 0x87D9:
                    A &= _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0x87DB;
                    goto case 0x87DB;
                case 0x87DA:
                    A |= ReadMem(ReadU16Zp((byte)(0x24 + X))); SetZN(A); TotalCycles += 6; PC = 0x87DC;
                    goto case 0x87DC;
                case 0x87DB:
                    Bit(_ram[0x26]); TotalCycles += 3; PC = 0x87DD;
                    goto case 0x87DD;
                case 0x87DC:
                    _ram[0x2D] = Rol(_ram[0x2D]); TotalCycles += 5; PC = 0x87DE;
                    goto case 0x87DE;
                case 0x87DD:
                    A &= ReadIoReg(0x2401); SetZN(A); TotalCycles += 4; PC = 0x87E0;
                    goto case 0x87E0;
                case 0x87DE:
                    A |= ReadMem(ReadU16Zp((byte)(0x24 + X))); SetZN(A); TotalCycles += 6; PC = 0x87E0;
                    goto case 0x87E0;
                case 0x87DF:
                    Bit(_ram[0x26]); TotalCycles += 3; PC = 0x87E1;
                    goto case 0x87E1;
                case 0x87E0:
                    _ram[0x35] = Rol(_ram[0x35]); TotalCycles += 5; PC = 0x87E2;
                    goto case 0x87E2;
                case 0x87E1:
                    A &= _ram[(byte)(0x01 + X)]; SetZN(A); TotalCycles += 4; PC = 0x87E3;
                    goto case 0x87E3;
                case 0x87E2:
                    A |= ReadMem(ReadU16Zp((byte)(0x24 + X))); SetZN(A); TotalCycles += 6; PC = 0x87E4;
                    return;
                case 0x87E3:
                    Bit(_ram[0x27]); TotalCycles += 3; PC = 0x87E5;
                    goto case 0x87E5;
                case 0x87E5:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x2A46 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x87E8;
                    return;
                case 0x87E6:
                    _ram[0xAA] = Lsr(_ram[0xAA]); TotalCycles += 5; PC = 0x87E8;
                    return;
                case 0x87E7:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x87E8;
                    return;
                case 0x87E9:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x45 + X)))); TotalCycles += 6; PC = 0x87EB;
                    goto case 0x87EB;
                case 0x87EA:
                    A ^= _ram[0xAA]; SetZN(A); TotalCycles += 3; PC = 0x87EC;
                    return;
                case 0x87EB:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x87EC;
                    return;
                case 0x87ED:
                    A |= _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0x87EF;
                    return;
                case 0x87EE:
                    { int a = 0x1012 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x87F1;
                    return;
                case 0x87F0:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8804; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8804; }
                    PC = 0x87F2; return;
                case 0x87F5:
                    TotalCycles += 7; PushU16(0x87F7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x87F6:
                    Bit(_ram[0x05]); TotalCycles += 3; PC = 0x87F8;
                    goto case 0x87F8;
                case 0x87F7:
                    A |= _ram[0x24]; SetZN(A); TotalCycles += 3; PC = 0x87F9;
                    goto case 0x87F9;
                case 0x87F8:
                    Bit(_ram[0x00]); TotalCycles += 3; PC = 0x87FA;
                    goto case 0x87FA;
                case 0x87F9:
                    TotalCycles += 7; PushU16(0x87FB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x87FA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x87FB;
                    return;
                case 0x87FC:
                    _ram[0x00] = Asl(_ram[0x00]); TotalCycles += 5; PC = 0x87FE;
                    goto case 0x87FE;
                case 0x87FD:
                    TotalCycles += 7; PushU16(0x87FF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x87FE:
                    TotalCycles += 7; PushU16(0x8800); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x87FF:
                    TotalCycles += 7; PushU16(0x8801); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8802:
                    _ram[0x4E] = Lsr(_ram[0x4E]); TotalCycles += 5; PC = 0x8804;
                    goto case 0x8804;
                case 0x8803:
                    { int a = 0x6159; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x8806;
                    goto case 0x8806;
                case 0x8804:
                    A ^= ReadMem(0x6E61 + Y); SetZN(A); TotalCycles += 4; PC = 0x8807;
                    goto case 0x8807;
                case 0x8805:
                    Adc(ReadMem(ReadU16Zp((byte)(0x6E + X)))); TotalCycles += 6; PC = 0x8807;
                    goto case 0x8807;
                case 0x8806:
                    { int a = 0x486E; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0x8809;
                    goto case 0x8809;
                case 0x8807:
                    _ram[0x0248] = Ror(_ram[0x0248]); TotalCycles += 6; PC = 0x880A;
                    goto case 0x880A;
                case 0x8808: // === SUBROUTINE: Sub_8808 ===
                    PushU8(A); TotalCycles += 3; PC = 0x8809;
                    goto case 0x8809;
                case 0x8809:
                    A = Asl(A); TotalCycles += 2; PC = 0x880A;
                    goto case 0x880A;
                case 0x880A:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x880B;
                    goto case 0x880B;
                case 0x880B:
                    Cmp(Y, 0x04); TotalCycles += 2; PC = 0x880D;
                    goto case 0x880D;
                case 0x880D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x881B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x881B; }
                    PC = 0x880F; goto case 0x880F;
                case 0x880F:
                    Cmp(Y, 0x08); TotalCycles += 2; PC = 0x8811;
                    goto case 0x8811;
                case 0x8810:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8811;
                    goto case 0x8811;
                case 0x8811:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8815; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8815; }
                    PC = 0x8813; goto case 0x8813;
                case 0x8813:
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0x8815;
                    goto case 0x8815;
                case 0x8814:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8815;
                    goto case 0x8815;
                case 0x8815:
                    A = _ram[0x077A]; SetZN(A); TotalCycles += 4; PC = 0x8818;
                    goto case 0x8818;
                case 0x8818:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x881B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x881B; }
                    PC = 0x881A; goto case 0x881A;
                case 0x8819:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0x881B;
                    goto case 0x881B;
                case 0x881A:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x881B;
                    goto case 0x881B;
                case 0x881B:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x07FE + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0x881E;
                    goto case 0x881E;
                case 0x881C:
                    { int a = 0xA087 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0x881F;
                    goto case 0x881F;
                case 0x881E:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x8820;
                    goto case 0x8820;
                case 0x881F:
                    TotalCycles += 7; PushU16(0x8821); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8820:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0752 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8823;
                    goto case 0x8823;
                case 0x8823:
                    Cmp(A, 0xFF); TotalCycles += 2; PC = 0x8825;
                    goto case 0x8825;
                case 0x8825:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x882E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x882E; }
                    PC = 0x8827; goto case 0x8827;
                case 0x8827:
                    _ram[(0x0301 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x882A;
                    goto case 0x882A;
                case 0x8828:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x882A;
                    goto case 0x882A;
                case 0x882A:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x882B;
                    goto case 0x882B;
                case 0x882B:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x882C;
                    goto case 0x882C;
                case 0x882C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8820; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8820; }
                    PC = 0x882E; goto case 0x882E;
                case 0x882E:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8830;
                    goto case 0x8830;
                case 0x882F:
                    TotalCycles += 7; PushU16(0x8831); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8830:
                    _ram[(0x0301 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8833;
                    goto case 0x8833;
                case 0x8831:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x8833;
                    goto case 0x8833;
                case 0x8833:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8834;
                    goto case 0x8834;
                case 0x8834:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x8835;
                    goto case 0x8835;
                case 0x8835:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0x8837;
                    goto case 0x8837;
                case 0x8837:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8882; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8882; }
                    PC = 0x8839; goto case 0x8839;
                case 0x8838:
                    A ^= 0xCA; SetZN(A); TotalCycles += 2; PC = 0x883A;
                    goto case 0x883A;
                case 0x8839:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x883A;
                    goto case 0x883A;
                case 0x883A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x885F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x885F; }
                    PC = 0x883C; goto case 0x883C;
                case 0x883C:
                    A = _ram[0x075A]; SetZN(A); TotalCycles += 4; PC = 0x883F;
                    goto case 0x883F;
                case 0x883F:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8840;
                    goto case 0x8840;
                case 0x8840:
                    Adc(0x01); TotalCycles += 2; PC = 0x8842;
                    goto case 0x8842;
                case 0x8841:
                    A |= ReadMem(ReadU16Zp((byte)(0xC9 + X))); SetZN(A); TotalCycles += 6; PC = 0x8843;
                    goto case 0x8843;
                case 0x8842:
                    Cmp(A, 0x0A); TotalCycles += 2; PC = 0x8844;
                    goto case 0x8844;
                case 0x8843:
                    A = Asl(A); TotalCycles += 2; PC = 0x8844;
                    goto case 0x8844;
                case 0x8844:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x884D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x884D; }
                    PC = 0x8846; goto case 0x8846;
                case 0x8846:
                    Sbc(0x0A); TotalCycles += 2; PC = 0x8848;
                    goto case 0x8848;
                case 0x8847:
                    A = Asl(A); TotalCycles += 2; PC = 0x8848;
                    goto case 0x8848;
                case 0x8848:
                    Y = 0x9F; SetZN(Y); TotalCycles += 2; PC = 0x884A;
                    goto case 0x884A;
                case 0x884A:
                    _ram[0x0308] = Y; TotalCycles += 4; PC = 0x884D;
                    goto case 0x884D;
                case 0x884B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x884C;
                    return;
                case 0x884D:
                    _ram[0x0309] = A; TotalCycles += 4; PC = 0x8850;
                    goto case 0x8850;
                case 0x884E:
                    A |= 0x03; SetZN(A); TotalCycles += 2; PC = 0x8850;
                    goto case 0x8850;
                case 0x8850:
                    Y = _ram[0x075F]; SetZN(Y); TotalCycles += 4; PC = 0x8853;
                    goto case 0x8853;
                case 0x8853:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8854;
                    goto case 0x8854;
                case 0x8854:
                    _ram[0x0314] = Y; TotalCycles += 4; PC = 0x8857;
                    goto case 0x8857;
                case 0x8857:
                    Y = _ram[0x075C]; SetZN(Y); TotalCycles += 4; PC = 0x885A;
                    goto case 0x885A;
                case 0x885A:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x885B;
                    goto case 0x885B;
                case 0x885B:
                    _ram[0x0316] = Y; TotalCycles += 4; PC = 0x885E;
                    goto case 0x885E;
                case 0x885C:
                    { byte z = (byte)(0x03 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x885E;
                    goto case 0x885E;
                case 0x885E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x885F:
                    A = _ram[0x077A]; SetZN(A); TotalCycles += 4; PC = 0x8862;
                    goto case 0x8862;
                case 0x8862:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8881; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8881; }
                    PC = 0x8864; goto case 0x8864;
                case 0x8863:
                    A |= ReadMem(0x53AD + X); SetZN(A); TotalCycles += 4; PC = 0x8866;
                    return;
                case 0x8864:
                    A = _ram[0x0753]; SetZN(A); TotalCycles += 4; PC = 0x8867;
                    goto case 0x8867;
                case 0x8867:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8868;
                    goto case 0x8868;
                case 0x8868:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8873; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8873; }
                    PC = 0x886A; goto case 0x886A;
                case 0x8869:
                    A |= 0xAC; SetZN(A); TotalCycles += 2; PC = 0x886B;
                    goto case 0x886B;
                case 0x886A:
                    Y = _ram[0x0770]; SetZN(Y); TotalCycles += 4; PC = 0x886D;
                    goto case 0x886D;
                case 0x886B:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x8874; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8874; }
                    PC = 0x886D; goto case 0x886D;
                case 0x886D:
                    Cmp(Y, 0x03); TotalCycles += 2; PC = 0x886F;
                    goto case 0x886F;
                case 0x886F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8873; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8873; }
                    PC = 0x8871; goto case 0x8871;
                case 0x8871:
                    A ^= 0x01; SetZN(A); TotalCycles += 2; PC = 0x8873;
                    goto case 0x8873;
                case 0x8872:
                    A |= ReadMem(ReadU16Zp((byte)(0x4A + X))); SetZN(A); TotalCycles += 6; PC = 0x8874;
                    goto case 0x8874;
                case 0x8873:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8874;
                    goto case 0x8874;
                case 0x8874:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8881; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8881; }
                    PC = 0x8876; goto case 0x8876;
                case 0x8876:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0x8878;
                    goto case 0x8878;
                case 0x8878:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x07ED + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x887B;
                    goto case 0x887B;
                case 0x8879:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x1987]); TotalCycles += 4; PC = 0x887C;
                    return;
                case 0x887B: // === SUBROUTINE: DigitsMathRoutine ===
                    _ram[(0x0304 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x887E;
                    goto case 0x887E;
                case 0x887E:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x887F;
                    goto case 0x887F;
                case 0x887F:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8878; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8878; }
                    PC = 0x8881; goto case 0x8881;
                case 0x8881:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8882:
                    Sbc(0x04); TotalCycles += 2; PC = 0x8884;
                    goto case 0x8884;
                case 0x8884:
                    A = Asl(A); TotalCycles += 2; PC = 0x8885;
                    goto case 0x8885;
                case 0x8885:
                    A = Asl(A); TotalCycles += 2; PC = 0x8886;
                    goto case 0x8886;
                case 0x8886:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x8887;
                    goto case 0x8887;
                case 0x8887:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x8889;
                    goto case 0x8889;
                case 0x8888:
                    TotalCycles += 7; PushU16(0x888A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8889:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x07F2 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x888C;
                    goto case 0x888C;
                case 0x888C:
                    _ram[(0x031C + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x888F;
                    goto case 0x888F;
                case 0x888F:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8890;
                    goto case 0x8890;
                case 0x8890:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8891;
                    goto case 0x8891;
                case 0x8891:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8892;
                    goto case 0x8892;
                case 0x8892:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8893;
                    goto case 0x8893;
                case 0x8893:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8894;
                    goto case 0x8894;
                case 0x8894:
                    Cmp(Y, 0x0C); TotalCycles += 2; PC = 0x8896;
                    goto case 0x8896;
                case 0x8896:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8889; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8889; }
                    PC = 0x8898; goto case 0x8898;
                case 0x8897:
                    Sbc(ReadMem(ReadU16Zp(0xA9) + Y)); TotalCycles += 5; PC = 0x8899;
                    goto case 0x8899;
                case 0x8898:
                    A = 0x2C; SetZN(A); TotalCycles += 2; PC = 0x889A;
                    goto case 0x889A;
                case 0x8899:
                    Bit(ReadIoReg(0x3F4C)); TotalCycles += 4; PC = 0x889C;
                    goto case 0x889C;
                case 0x889A:
                    TotalCycles += 3; PC = 0x863F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x863F;
                case 0x889C:
                    _ram[0xAD] = X; TotalCycles += 3; PC = 0x889E;
                    goto case 0x889E;
                case 0x889D: // === SUBROUTINE: Sub_889D ===
                    A = _ram[0x07A0]; SetZN(A); TotalCycles += 4; PC = 0x88A0;
                    goto case 0x88A0;
                case 0x889E:
                    Y = 0x07; SetZN(Y); TotalCycles += 2; PC = 0x88A0;
                    goto case 0x88A0;
                case 0x88A0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x88AD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x88AD; }
                    PC = 0x88A2; goto case 0x88A2;
                case 0x88A2:
                    TotalCycles += 6; PushU16(0x88A4); PC = 0x8220;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8220;
                case 0x88A3:
                    TotalCycles += 6; PushU16(0x88A5); PC = 0xA982;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x88A5: // === SUBROUTINE: Sub_88A5 ===
                    A = 0x07; SetZN(A); TotalCycles += 2; PC = 0x88A7;
                    goto case 0x88A7;
                case 0x88A7:
                    _ram[0x07A0] = A; TotalCycles += 4; PC = 0x88AA;
                    goto case 0x88AA;
                case 0x88A8:
                    Y = 0x07; SetZN(Y); TotalCycles += 2; PC = 0x88AA;
                    goto case 0x88AA;
                case 0x88AA:
                    _ram[0x073C] = IncVal(_ram[0x073C]); TotalCycles += 6; PC = 0x88AD;
                    goto case 0x88AD;
                case 0x88AD:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x88AE: // === SUBROUTINE: UpdateTopScore ===
                    A = _ram[0x0726]; SetZN(A); TotalCycles += 4; PC = 0x88B1;
                    goto case 0x88B1;
                case 0x88AF:
                    _ram[0x07] = Rol(_ram[0x07]); TotalCycles += 5; PC = 0x88B1;
                    goto case 0x88B1;
                case 0x88B1:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0x88B3;
                    goto case 0x88B3;
                case 0x88B2:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0x88B4;
                    goto case 0x88B4;
                case 0x88B3:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0x88B5;
                    goto case 0x88B5;
                case 0x88B4:
                    A |= _ram[0xAC]; SetZN(A); TotalCycles += 3; PC = 0x88B6;
                    goto case 0x88B6;
                case 0x88B5:
                    Y = _ram[0x0340]; SetZN(Y); TotalCycles += 4; PC = 0x88B8;
                    goto case 0x88B8;
                case 0x88B6:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x88B8:
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0x88BA;
                    goto case 0x88BA;
                case 0x88B9:
                    TotalCycles += 7; PushU16(0x88BB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x88BA:
                    A = _ram[0x0721]; SetZN(A); TotalCycles += 4; PC = 0x88BD;
                    goto case 0x88BD;
                case 0x88BB:
                    A &= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x88BD;
                    goto case 0x88BD;
                case 0x88BD:
                    _ram[(0x0342 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x88C0;
                    goto case 0x88C0;
                case 0x88C0:
                    A = _ram[0x0720]; SetZN(A); TotalCycles += 4; PC = 0x88C3;
                    goto case 0x88C3;
                case 0x88C1:
                    TotalCycles += 6; PushU16(0x88C3); PC = 0x9907;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9907;
                case 0x88C3:
                    _ram[(0x0341 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x88C6;
                    goto case 0x88C6;
                case 0x88C4:
                    A ^= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x88C6;
                    goto case 0x88C6;
                case 0x88C6:
                    A = 0x9A; SetZN(A); TotalCycles += 2; PC = 0x88C8;
                    goto case 0x88C8;
                case 0x88C7:
                    SP = X; TotalCycles += 2; PC = 0x88C8;
                    goto case 0x88C8;
                case 0x88C8:
                    _ram[(0x0343 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x88CB;
                    goto case 0x88CB;
                case 0x88CB:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x88CD;
                    goto case 0x88CD;
                case 0x88CC:
                    TotalCycles += 7; PushU16(0x88CE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x88CD:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0x88CF;
                    goto case 0x88CF;
                case 0x88CF:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x88D0;
                    goto case 0x88D0;
                case 0x88D0:
                    _ram[0x01] = X; TotalCycles += 3; PC = 0x88D2;
                    goto case 0x88D2;
                case 0x88D1:
                    A |= ReadMem(ReadU16Zp((byte)(0xBD + X))); SetZN(A); TotalCycles += 6; PC = 0x88D3;
                    goto case 0x88D3;
                case 0x88D2:
                    A = _ram[(0x06A1 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x88D5;
                    goto case 0x88D5;
                case 0x88D3:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x88D5;
                    goto case 0x88D5;
                case 0x88D4:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0x88D6;
                    goto case 0x88D6;
                case 0x88D5:
                    A &= 0xC0; SetZN(A); TotalCycles += 2; PC = 0x88D7;
                    goto case 0x88D7;
                case 0x88D6:
                    Cmp(Y, 0x85); TotalCycles += 2; PC = 0x88D8;
                    return;
                case 0x88D7:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0x88D9;
                    goto case 0x88D9;
                case 0x88D9:
                    A = Asl(A); TotalCycles += 2; PC = 0x88DA;
                    goto case 0x88DA;
                case 0x88DA:
                    A = Rol(A); TotalCycles += 2; PC = 0x88DB;
                    goto case 0x88DB;
                case 0x88DB:
                    A = Rol(A); TotalCycles += 2; PC = 0x88DC;
                    goto case 0x88DC;
                case 0x88DC:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x88DD;
                    goto case 0x88DD;
                case 0x88DD:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0B08 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x88E0;
                    goto case 0x88E0;
                case 0x88DE:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x88DF;
                    return;
                case 0x88E0:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0x88E2;
                    goto case 0x88E2;
                case 0x88E1:
                    _ram[0xB9] = Asl(_ram[0xB9]); TotalCycles += 5; PC = 0x88E3;
                    return;
                case 0x88E2:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0B0C + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x88E5;
                    goto case 0x88E5;
                case 0x88E5:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0x88E7;
                    goto case 0x88E7;
                case 0x88E7:
                    A = _ram[(0x06A1 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x88EA;
                    goto case 0x88EA;
                case 0x88E8:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x88EA;
                    goto case 0x88EA;
                case 0x88E9:
                    _ram[0x0A] = Asl(_ram[0x0A]); TotalCycles += 5; PC = 0x88EB;
                    goto case 0x88EB;
                case 0x88EA:
                    A = Asl(A); TotalCycles += 2; PC = 0x88EB;
                    goto case 0x88EB;
                case 0x88EB:
                    A = Asl(A); TotalCycles += 2; PC = 0x88EC;
                    goto case 0x88EC;
                case 0x88EC:
                    _ram[0x02] = A; TotalCycles += 3; PC = 0x88EE;
                    goto case 0x88EE;
                case 0x88EE:
                    A = _ram[0x071F]; SetZN(A); TotalCycles += 4; PC = 0x88F1;
                    goto case 0x88F1;
                case 0x88F1:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0x88F3;
                    goto case 0x88F3;
                case 0x88F2:
                    A |= ReadMem(ReadU16Zp((byte)(0x49 + X))); SetZN(A); TotalCycles += 6; PC = 0x88F4;
                    goto case 0x88F4;
                case 0x88F3:
                    A ^= 0x01; SetZN(A); TotalCycles += 2; PC = 0x88F5;
                    goto case 0x88F5;
                case 0x88F4:
                    A |= ReadMem(ReadU16Zp((byte)(0x0A + X))); SetZN(A); TotalCycles += 6; PC = 0x88F6;
                    goto case 0x88F6;
                case 0x88F5:
                    A = Asl(A); TotalCycles += 2; PC = 0x88F6;
                    goto case 0x88F6;
                case 0x88F6:
                    Adc(_ram[0x02]); TotalCycles += 3; PC = 0x88F8;
                    goto case 0x88F8;
                case 0x88F8:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x88F9;
                    goto case 0x88F9;
                case 0x88F9:
                    X = _ram[0x00]; SetZN(X); TotalCycles += 3; PC = 0x88FB;
                    goto case 0x88FB;
                case 0x88FA:
                    TotalCycles += 7; PushU16(0x88FC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x88FB:
                    A = ReadMem(ReadU16Zp(0x06) + Y); SetZN(A); TotalCycles += 5; PC = 0x88FD;
                    goto case 0x88FD;
                case 0x88FC:
                    _ram[0x9D] = Asl(_ram[0x9D]); TotalCycles += 5; PC = 0x88FE;
                    return;
                case 0x88FD:
                    _ram[(0x0344 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8900;
                    goto case 0x8900;
                case 0x8900:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8901;
                    goto case 0x8901;
                case 0x8901:
                    A = ReadMem(ReadU16Zp(0x06) + Y); SetZN(A); TotalCycles += 5; PC = 0x8903;
                    goto case 0x8903;
                case 0x8902:
                    _ram[0x9D] = Asl(_ram[0x9D]); TotalCycles += 5; PC = 0x8904;
                    goto case 0x8904;
                case 0x8903:
                    _ram[(0x0345 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8906;
                    goto case 0x8906;
                case 0x8904:
                    A ^= _ram[0x03]; SetZN(A); TotalCycles += 3; PC = 0x8906;
                    goto case 0x8906;
                case 0x8906:
                    Y = _ram[0x04]; SetZN(Y); TotalCycles += 3; PC = 0x8908;
                    goto case 0x8908;
                case 0x8908:
                    A = _ram[0x05]; SetZN(A); TotalCycles += 3; PC = 0x890A;
                    goto case 0x890A;
                case 0x8909:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0x890B;
                    goto case 0x890B;
                case 0x890A:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x891A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x891A; }
                    PC = 0x890C; goto case 0x890C;
                case 0x890B:
                    _ram[0x01A5] = Asl(_ram[0x01A5]); TotalCycles += 6; PC = 0x890E;
                    goto case 0x890E;
                case 0x890C:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0x890E;
                    goto case 0x890E;
                case 0x890D:
                    A |= ReadMem(ReadU16Zp((byte)(0x4A + X))); SetZN(A); TotalCycles += 6; PC = 0x890F;
                    goto case 0x890F;
                case 0x890E:
                    A = Lsr(A); TotalCycles += 2; PC = 0x890F;
                    goto case 0x890F;
                case 0x890F:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x892A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x892A; }
                    PC = 0x8911; goto case 0x8911;
                case 0x8910:
                    A |= _ram[(0x0326 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8913;
                    goto case 0x8913;
                case 0x8911:
                    _ram[0x03] = Rol(_ram[0x03]); TotalCycles += 5; PC = 0x8913;
                    goto case 0x8913;
                case 0x8913:
                    _ram[0x03] = Rol(_ram[0x03]); TotalCycles += 5; PC = 0x8915;
                    goto case 0x8915;
                case 0x8915:
                    _ram[0x03] = Rol(_ram[0x03]); TotalCycles += 5; PC = 0x8917;
                    goto case 0x8917;
                case 0x8917:
                    TotalCycles += 3; PC = 0x8930;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8930;
                case 0x8918:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x88A3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x88A3; }
                    PC = 0x891A; goto case 0x891A;
                case 0x891A:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0x891C;
                    goto case 0x891C;
                case 0x891B:
                    A |= ReadMem(ReadU16Zp((byte)(0x4A + X))); SetZN(A); TotalCycles += 6; PC = 0x891D;
                    goto case 0x891D;
                case 0x891C:
                    A = Lsr(A); TotalCycles += 2; PC = 0x891D;
                    goto case 0x891D;
                case 0x891D:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x892E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x892E; }
                    PC = 0x891F; goto case 0x891F;
                case 0x891F:
                    _ram[0x03] = Lsr(_ram[0x03]); TotalCycles += 5; PC = 0x8921;
                    goto case 0x8921;
                case 0x8921:
                    _ram[0x03] = Lsr(_ram[0x03]); TotalCycles += 5; PC = 0x8923;
                    goto case 0x8923;
                case 0x8923:
                    _ram[0x03] = Lsr(_ram[0x03]); TotalCycles += 5; PC = 0x8925;
                    goto case 0x8925;
                case 0x8925:
                    _ram[0x03] = Lsr(_ram[0x03]); TotalCycles += 5; PC = 0x8927;
                    goto case 0x8927;
                case 0x8927:
                    TotalCycles += 3; PC = 0x8930;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8930;
                case 0x8928:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x88B3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x88B3; }
                    PC = 0x892A; goto case 0x892A;
                case 0x892A:
                    _ram[0x03] = Lsr(_ram[0x03]); TotalCycles += 5; PC = 0x892C;
                    goto case 0x892C;
                case 0x892C:
                    _ram[0x03] = Lsr(_ram[0x03]); TotalCycles += 5; PC = 0x892E;
                    goto case 0x892E;
                case 0x892E:
                    _ram[0x04] = IncVal(_ram[0x04]); TotalCycles += 5; PC = 0x8930;
                    goto case 0x8930;
                case 0x8930:
                    A = _ram[(0x03F9 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8933;
                    goto case 0x8933;
                case 0x8931:
                    Sbc(_ram[(0x0503 + Y) & 0x07FF]); TotalCycles += 4; PC = 0x8934;
                    return;
                case 0x8933:
                    A |= _ram[0x03]; SetZN(A); TotalCycles += 3; PC = 0x8935;
                    goto case 0x8935;
                case 0x8935:
                    _ram[(0x03F9 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8938;
                    goto case 0x8938;
                case 0x8936:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x6603 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x8939;
                    goto case 0x8939;
                case 0x8938:
                    _ram[0x00] = IncVal(_ram[0x00]); TotalCycles += 5; PC = 0x893A;
                    goto case 0x893A;
                case 0x8939:
                    TotalCycles += 7; PushU16(0x893B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x893A:
                    _ram[0x00] = IncVal(_ram[0x00]); TotalCycles += 5; PC = 0x893C;
                    goto case 0x893C;
                case 0x893B:
                    TotalCycles += 7; PushU16(0x893D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x893C:
                    X = _ram[0x01]; SetZN(X); TotalCycles += 3; PC = 0x893E;
                    goto case 0x893E;
                case 0x893D:
                    A |= ReadMem(ReadU16Zp((byte)(0xE8 + X))); SetZN(A); TotalCycles += 6; PC = 0x893F;
                    goto case 0x893F;
                case 0x893E:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x893F;
                    goto case 0x893F;
                case 0x893F:
                    Cmp(X, 0x0D); TotalCycles += 2; PC = 0x8941;
                    goto case 0x8941;
                case 0x8940:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x0D90]; SetZN(A); TotalCycles += 4; PC = 0x8943;
                    goto case 0x8943;
                case 0x8941:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x88D0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x88D0; }
                    PC = 0x8943; goto case 0x8943;
                case 0x8942:
                    _ram[0x00A4] = A; TotalCycles += 4; PC = 0x8945;
                    goto case 0x8945;
                case 0x8943:
                    Y = _ram[0x00]; SetZN(Y); TotalCycles += 3; PC = 0x8945;
                    goto case 0x8945;
                case 0x8944:
                    TotalCycles += 7; PushU16(0x8946); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8945:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8946;
                    goto case 0x8946;
                case 0x8946:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8947;
                    goto case 0x8947;
                case 0x8947:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8948;
                    goto case 0x8948;
                case 0x8948:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x894A;
                    goto case 0x894A;
                case 0x8949:
                    TotalCycles += 7; PushU16(0x894B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x894A:
                    _ram[(0x0341 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x894D;
                    goto case 0x894D;
                case 0x894B:
                    A ^= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x894D;
                    goto case 0x894D;
                case 0x894D:
                    _ram[0x0340] = Y; TotalCycles += 4; PC = 0x8950;
                    goto case 0x8950;
                case 0x894E:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8950:
                    _ram[0x0721] = IncVal(_ram[0x0721]); TotalCycles += 6; PC = 0x8953;
                    goto case 0x8953;
                case 0x8951:
                    A &= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x8953;
                    goto case 0x8953;
                case 0x8953:
                    A = _ram[0x0721]; SetZN(A); TotalCycles += 4; PC = 0x8956;
                    goto case 0x8956;
                case 0x8954:
                    A &= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x8956;
                    goto case 0x8956;
                case 0x8956:
                    A &= 0x1F; SetZN(A); TotalCycles += 2; PC = 0x8958;
                    goto case 0x8958;
                case 0x8958:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8967; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8967; }
                    PC = 0x895A; goto case 0x895A;
                case 0x8959:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x00A9]; SetZN(A); TotalCycles += 4; PC = 0x895C;
                    goto case 0x895C;
                case 0x895A:
                    A = 0x80; SetZN(A); TotalCycles += 2; PC = 0x895C;
                    goto case 0x895C;
                case 0x895C:
                    _ram[0x0721] = A; TotalCycles += 4; PC = 0x895F;
                    goto case 0x895F;
                case 0x895D:
                    A &= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x895F;
                    goto case 0x895F;
                case 0x895F:
                    A = _ram[0x0720]; SetZN(A); TotalCycles += 4; PC = 0x8962;
                    goto case 0x8962;
                case 0x8960:
                    TotalCycles += 6; PushU16(0x8962); PC = 0x4907;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8962:
                    A ^= 0x04; SetZN(A); TotalCycles += 2; PC = 0x8964;
                    goto case 0x8964;
                case 0x8964:
                    _ram[0x0720] = A; TotalCycles += 4; PC = 0x8967;
                    goto case 0x8967;
                case 0x8965:
                    TotalCycles += 6; PushU16(0x8967); PC = 0x4C07;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8967:
                    TotalCycles += 3; PC = 0x89BD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x89BD;
                case 0x8968:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2D89 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x896B;
                    goto case 0x896B;
                case 0x896A: // === SUBROUTINE: Sub_896A ===
                    A = _ram[0x0721]; SetZN(A); TotalCycles += 4; PC = 0x896D;
                    goto case 0x896D;
                case 0x896B: // === SUBROUTINE: GetAreaMusic ===
                    A &= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x896D;
                    goto case 0x896D;
                case 0x896D:
                    A &= 0x1F; SetZN(A); TotalCycles += 2; PC = 0x896F;
                    goto case 0x896F;
                case 0x896F:
                    P |= FlagC; TotalCycles += 2; PC = 0x8970;
                    goto case 0x8970;
                case 0x8970:
                    Sbc(0x04); TotalCycles += 2; PC = 0x8972;
                    goto case 0x8972;
                case 0x8972:
                    A &= 0x1F; SetZN(A); TotalCycles += 2; PC = 0x8974;
                    goto case 0x8974;
                case 0x8974:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0x8976;
                    goto case 0x8976;
                case 0x8975:
                    A |= ReadMem(ReadU16Zp((byte)(0xAD + X))); SetZN(A); TotalCycles += 6; PC = 0x8977;
                    goto case 0x8977;
                case 0x8976:
                    A = _ram[0x0720]; SetZN(A); TotalCycles += 4; PC = 0x8979;
                    goto case 0x8979;
                case 0x8977:
                    TotalCycles += 6; PushU16(0x8979); PC = 0xB007;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8979:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x897D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x897D; }
                    PC = 0x897B; goto case 0x897B;
                case 0x897B:
                    A ^= 0x04; SetZN(A); TotalCycles += 2; PC = 0x897D;
                    goto case 0x897D;
                case 0x897D:
                    A &= 0x04; SetZN(A); TotalCycles += 2; PC = 0x897F;
                    goto case 0x897F;
                case 0x897F:
                    A |= 0x23; SetZN(A); TotalCycles += 2; PC = 0x8981;
                    goto case 0x8981;
                case 0x8981:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x8983;
                    goto case 0x8983;
                case 0x8982:
                    TotalCycles += 7; PushU16(0x8984); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8983:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0x8985;
                    goto case 0x8985;
                case 0x8984:
                    A |= ReadMem(ReadU16Zp((byte)(0x4A + X))); SetZN(A); TotalCycles += 6; PC = 0x8986;
                    goto case 0x8986;
                case 0x8985:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8986;
                    goto case 0x8986;
                case 0x8986:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8987;
                    goto case 0x8987;
                case 0x8987:
                    Adc(0xC0); TotalCycles += 2; PC = 0x8989;
                    goto case 0x8989;
                case 0x8988:
                    Cmp(Y, 0x85); TotalCycles += 2; PC = 0x898A;
                    goto case 0x898A;
                case 0x8989:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0x898B;
                    goto case 0x898B;
                case 0x898A:
                    A |= ReadMem(ReadU16Zp((byte)(0xA2 + X))); SetZN(A); TotalCycles += 6; PC = 0x898C;
                    goto case 0x898C;
                case 0x898B:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x898D;
                    goto case 0x898D;
                case 0x898C:
                    TotalCycles += 7; PushU16(0x898E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x898D:
                    Y = _ram[0x0340]; SetZN(Y); TotalCycles += 4; PC = 0x8990;
                    goto case 0x8990;
                case 0x898E:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8990:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x8992;
                    goto case 0x8992;
                case 0x8991:
                    TotalCycles += 7; PushU16(0x8993); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8992:
                    _ram[(0x0341 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8995;
                    goto case 0x8995;
                case 0x8993:
                    A ^= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x8995;
                    goto case 0x8995;
                case 0x8995:
                    A = _ram[0x01]; SetZN(A); TotalCycles += 3; PC = 0x8997;
                    goto case 0x8997;
                case 0x8996:
                    A |= ReadMem(ReadU16Zp((byte)(0x18 + X))); SetZN(A); TotalCycles += 6; PC = 0x8998;
                    goto case 0x8998;
                case 0x8997:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8998;
                    goto case 0x8998;
                case 0x8998:
                    Adc(0x08); TotalCycles += 2; PC = 0x899A;
                    goto case 0x899A;
                case 0x8999:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x899A;
                    goto case 0x899A;
                case 0x899A:
                    _ram[(0x0342 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x899D;
                    goto case 0x899D;
                case 0x899D:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0x899F;
                    goto case 0x899F;
                case 0x899E:
                    A |= ReadMem(ReadU16Zp((byte)(0xBD + X))); SetZN(A); TotalCycles += 6; PC = 0x89A0;
                    goto case 0x89A0;
                case 0x899F:
                    A = _ram[(0x03F9 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x89A2;
                    goto case 0x89A2;
                case 0x89A0:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x1903 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x89A3;
                    return;
                case 0x89A2:
                    _ram[(0x0344 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x89A5;
                    goto case 0x89A5;
                case 0x89A5:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x89A7;
                    goto case 0x89A7;
                case 0x89A6:
                    A |= ReadMem(ReadU16Zp((byte)(0x99 + X))); SetZN(A); TotalCycles += 6; PC = 0x89A8;
                    return;
                case 0x89A7:
                    _ram[(0x0343 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x89AA;
                    goto case 0x89AA;
                case 0x89AA:
                    A = Lsr(A); TotalCycles += 2; PC = 0x89AB;
                    goto case 0x89AB;
                case 0x89AB:
                    _ram[(0x03F9 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x89AE;
                    goto case 0x89AE;
                case 0x89AC:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x4803 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x89AF;
                    goto case 0x89AF;
                case 0x89AE:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x89AF;
                    goto case 0x89AF;
                case 0x89AF:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x89B0;
                    goto case 0x89B0;
                case 0x89B0:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x89B1;
                    goto case 0x89B1;
                case 0x89B1:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x89B2;
                    goto case 0x89B2;
                case 0x89B2:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x89B3;
                    goto case 0x89B3;
                case 0x89B3:
                    Cmp(X, 0x07); TotalCycles += 2; PC = 0x89B5;
                    goto case 0x89B5;
                case 0x89B5:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8990; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8990; }
                    PC = 0x89B7; goto case 0x89B7;
                case 0x89B6:
                    Cmp(A, ReadMem(0x4199 + Y)); TotalCycles += 4; PC = 0x89B9;
                    return;
                case 0x89B7:
                    _ram[(0x0341 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x89BA;
                    goto case 0x89BA;
                case 0x89B8:
                    A ^= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x89BA;
                    goto case 0x89BA;
                case 0x89BA:
                    _ram[0x0340] = Y; TotalCycles += 4; PC = 0x89BD;
                    goto case 0x89BD;
                case 0x89BB:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x89BD: // === SUBROUTINE: Entrance_GameTimerSetup ===
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0x89BF;
                    goto case 0x89BF;
                case 0x89BE:
                    _ram[0x8D] = Asl(_ram[0x8D]); TotalCycles += 5; PC = 0x89C0;
                    return;
                case 0x89BF:
                    _ram[0x0773] = A; TotalCycles += 4; PC = 0x89C2;
                    goto case 0x89C2;
                case 0x89C2:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x89D0:
                    TotalCycles += 7; PushU16(0x89D2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x89E0:
                    TotalCycles += 7; PushU16(0x89E2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x89E1: // === SUBROUTINE: Sub_89E1 ===
                    A = _ram[0x09]; SetZN(A); TotalCycles += 3; PC = 0x89E3;
                    goto case 0x89E3;
                case 0x89E2:
                    A |= 0x29; SetZN(A); TotalCycles += 2; PC = 0x89E4;
                    return;
                case 0x89E3:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0x89E5;
                    goto case 0x89E5;
                case 0x89E5:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8A38; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A38; }
                    PC = 0x89E7; goto case 0x89E7;
                case 0x89E6:
                    A ^= ReadMem(ReadU16Zp(0xAE) + Y); SetZN(A); TotalCycles += 5; PC = 0x89E8;
                    goto case 0x89E8;
                case 0x89E7:
                    X = _ram[0x0300]; SetZN(X); TotalCycles += 4; PC = 0x89EA;
                    goto case 0x89EA;
                case 0x89E8:
                    TotalCycles += 7; PushU16(0x89EA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x89EA:
                    Cmp(X, 0x31); TotalCycles += 2; PC = 0x89EC;
                    goto case 0x89EC;
                case 0x89EB:
                    A &= ReadMem(ReadU16Zp(0xB0) + Y); SetZN(A); TotalCycles += 5; PC = 0x89ED;
                    goto case 0x89ED;
                case 0x89EC:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8A38; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A38; }
                    PC = 0x89EE; goto case 0x89EE;
                case 0x89ED:
                    A = Lsr(A); TotalCycles += 2; PC = 0x89EE;
                    goto case 0x89EE;
                case 0x89EE:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x89EF;
                    goto case 0x89EF;
                case 0x89EF:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x09C9 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x89F2;
                    goto case 0x89F2;
                case 0x89F0:
                    Cmp(A, 0x89); TotalCycles += 2; PC = 0x89F2;
                    goto case 0x89F2;
                case 0x89F2:
                    _ram[(0x0301 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x89F5;
                    goto case 0x89F5;
                case 0x89F3:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x89F5;
                    goto case 0x89F5;
                case 0x89F5:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x89F6;
                    goto case 0x89F6;
                case 0x89F6:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x89F7;
                    goto case 0x89F7;
                case 0x89F7:
                    Cmp(Y, 0x08); TotalCycles += 2; PC = 0x89F9;
                    goto case 0x89F9;
                case 0x89F8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x89F9;
                    goto case 0x89F9;
                case 0x89F9:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x89EF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x89EF; }
                    PC = 0x89FB; goto case 0x89FB;
                case 0x89FB:
                    X = _ram[0x0300]; SetZN(X); TotalCycles += 4; PC = 0x89FE;
                    goto case 0x89FE;
                case 0x89FC:
                    TotalCycles += 7; PushU16(0x89FE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x89FE:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x8A00;
                    goto case 0x8A00;
                case 0x8A00:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x8A02;
                    goto case 0x8A02;
                case 0x8A01:
                    TotalCycles += 7; PushU16(0x8A03); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A02:
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0x8A05;
                    goto case 0x8A05;
                case 0x8A03:
                    _ram[0x0207] = Lsr(_ram[0x0207]); TotalCycles += 6; PC = 0x8A06;
                    goto case 0x8A06;
                case 0x8A05:
                    A = Asl(A); TotalCycles += 2; PC = 0x8A06;
                    goto case 0x8A06;
                case 0x8A06:
                    A = Asl(A); TotalCycles += 2; PC = 0x8A07;
                    goto case 0x8A07;
                case 0x8A07:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x8A08;
                    goto case 0x8A08;
                case 0x8A08:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x09D1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8A0B;
                    goto case 0x8A0B;
                case 0x8A09:
                    Cmp(A, ReadMem(ReadU16Zp(0x89) + Y)); TotalCycles += 5; PC = 0x8A0B;
                    goto case 0x8A0B;
                case 0x8A0B:
                    _ram[(0x0304 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8A0E;
                    goto case 0x8A0E;
                case 0x8A0E:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8A0F;
                    goto case 0x8A0F;
                case 0x8A0F:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8A10;
                    goto case 0x8A10;
                case 0x8A10:
                    _ram[0x00] = DecVal(_ram[0x00]); TotalCycles += 5; PC = 0x8A12;
                    goto case 0x8A12;
                case 0x8A11:
                    TotalCycles += 7; PushU16(0x8A13); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A12:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8A08; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A08; }
                    PC = 0x8A14; goto case 0x8A14;
                case 0x8A14:
                    X = _ram[0x0300]; SetZN(X); TotalCycles += 4; PC = 0x8A17;
                    goto case 0x8A17;
                case 0x8A15:
                    TotalCycles += 7; PushU16(0x8A17); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A17:
                    Y = _ram[0x06D4]; SetZN(Y); TotalCycles += 4; PC = 0x8A1A;
                    goto case 0x8A1A;
                case 0x8A19:
                    _ram[0xB9] = Asl(_ram[0xB9]); TotalCycles += 5; PC = 0x8A1B;
                    return;
                case 0x8A1A:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x09C3 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8A1D;
                    goto case 0x8A1D;
                case 0x8A1D:
                    _ram[(0x0305 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8A20;
                    goto case 0x8A20;
                case 0x8A1E:
                    A |= _ram[0x03]; SetZN(A); TotalCycles += 3; PC = 0x8A20;
                    goto case 0x8A20;
                case 0x8A20:
                    A = _ram[0x0300]; SetZN(A); TotalCycles += 4; PC = 0x8A23;
                    goto case 0x8A23;
                case 0x8A21:
                    TotalCycles += 7; PushU16(0x8A23); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A23:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8A24;
                    goto case 0x8A24;
                case 0x8A24:
                    Adc(0x07); TotalCycles += 2; PC = 0x8A26;
                    goto case 0x8A26;
                case 0x8A26:
                    _ram[0x0300] = A; TotalCycles += 4; PC = 0x8A29;
                    goto case 0x8A29;
                case 0x8A27:
                    TotalCycles += 7; PushU16(0x8A29); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A29:
                    _ram[0x06D4] = IncVal(_ram[0x06D4]); TotalCycles += 6; PC = 0x8A2C;
                    goto case 0x8A2C;
                case 0x8A2B:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0x8A2D;
                    return;
                case 0x8A2C:
                    A = _ram[0x06D4]; SetZN(A); TotalCycles += 4; PC = 0x8A2F;
                    goto case 0x8A2F;
                case 0x8A2E:
                    _ram[0xC9] = Asl(_ram[0xC9]); TotalCycles += 5; PC = 0x8A30;
                    goto case 0x8A30;
                case 0x8A2F:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0x8A31;
                    goto case 0x8A31;
                case 0x8A30:
                    _ram[0x90] = Asl(_ram[0x90]); TotalCycles += 5; PC = 0x8A32;
                    goto case 0x8A32;
                case 0x8A31:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8A38; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A38; }
                    PC = 0x8A33; goto case 0x8A33;
                case 0x8A32:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0x8A34;
                    goto case 0x8A34;
                case 0x8A33:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8A35;
                    goto case 0x8A35;
                case 0x8A34: // === SUBROUTINE: PlayerLoseGame ===
                    TotalCycles += 7; PushU16(0x8A36); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A35:
                    _ram[0x06D4] = A; TotalCycles += 4; PC = 0x8A38;
                    goto case 0x8A38;
                case 0x8A37:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x8A39;
                    goto case 0x8A39;
                case 0x8A38:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8A39:
                    A ^= _ram[0x45]; SetZN(A); TotalCycles += 3; PC = 0x8A3B;
                    return;
                case 0x8A3A:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8A3C;
                    return;
                case 0x8A42:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0x8A43;
                    goto case 0x8A43;
                case 0x8A43:
                    A ^= ReadMem(0x245A + Y); SetZN(A); TotalCycles += 4; PC = 0x8A46;
                    goto case 0x8A46;
                case 0x8A45:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8A47;
                    goto case 0x8A47;
                case 0x8A46:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8A48;
                    goto case 0x8A48;
                case 0x8A47:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8A49;
                    goto case 0x8A49;
                case 0x8A48:
                    Bit(_ram[0x26]); TotalCycles += 3; PC = 0x8A4A;
                    goto case 0x8A4A;
                case 0x8A49:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8A4B;
                    goto case 0x8A4B;
                case 0x8A4A:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8A4C;
                    goto case 0x8A4C;
                case 0x8A4B:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8A4D;
                    goto case 0x8A4D;
                case 0x8A4C:
                    _ram[0xA0] = Rol(_ram[0xA0]); TotalCycles += 5; PC = 0x8A4E;
                    goto case 0x8A4E;
                case 0x8A4D: // === SUBROUTINE: Sub_8A4D ===
                    Y = 0x41; SetZN(Y); TotalCycles += 2; PC = 0x8A4F;
                    goto case 0x8A4F;
                case 0x8A4E:
                    A ^= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0x8A50;
                    return;
                case 0x8A4F:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x8A51;
                    goto case 0x8A51;
                case 0x8A51:
                    X = _ram[0x074E]; SetZN(X); TotalCycles += 4; PC = 0x8A54;
                    goto case 0x8A54;
                case 0x8A52:
                    { int a = 0xD007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x8A55;
                    return;
                case 0x8A54:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8A58; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A58; }
                    PC = 0x8A56; goto case 0x8A56;
                case 0x8A56: // === SUBROUTINE: DoNothing1 ===
                    A = 0x04; SetZN(A); TotalCycles += 2; PC = 0x8A58;
                    goto case 0x8A58;
                case 0x8A58: // === SUBROUTINE: AreaParserTasks ===
                    TotalCycles += 6; PushU16(0x8A5A); PC = 0x8A97;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8A97;
                case 0x8A5A:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8A5B;
                    goto case 0x8A5B;
                case 0x8A5B:
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0x8A5D;
                    goto case 0x8A5D;
                case 0x8A5C:
                    _ram[0x8D] = Asl(_ram[0x8D]); TotalCycles += 5; PC = 0x8A5E;
                    return;
                case 0x8A5D:
                    _ram[0x0773] = A; TotalCycles += 4; PC = 0x8A60;
                    goto case 0x8A60;
                case 0x8A60:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8A61: // === SUBROUTINE: Sub_8A61 ===
                    TotalCycles += 6; PushU16(0x8A63); PC = 0x8A6D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8A6D;
                case 0x8A62:
                    Adc(SmbEmbeddedAssets.StaticDataTables[0x6E8A]); TotalCycles += 4; PC = 0x8A65;
                    goto case 0x8A65;
                case 0x8A63:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8A64;
                    goto case 0x8A64;
                case 0x8A64:
                    _ram[0x03F0] = IncVal(_ram[0x03F0]); TotalCycles += 6; PC = 0x8A67;
                    goto case 0x8A67;
                case 0x8A65:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8A6A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A6A; }
                    PC = 0x8A67; goto case 0x8A67;
                case 0x8A67:
                    { int a = (0x03EC + X) & 0x07FF; _ram[a] = DecVal(_ram[a]); } TotalCycles += 7; PC = 0x8A6A;
                    goto case 0x8A6A;
                case 0x8A68:
                    Cmp(X, ReadIoReg(0x6003)); TotalCycles += 4; PC = 0x8A6B;
                    goto case 0x8A6B;
                case 0x8A6A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8A6B: // === SUBROUTINE: Sub_8A6B ===
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8A6D;
                    goto case 0x8A6D;
                case 0x8A6C:
                    TotalCycles += 7; PushU16(0x8A6E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A6D: // === SUBROUTINE: Sub_8A6D ===
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0x8A6F;
                    goto case 0x8A6F;
                case 0x8A6F:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0x8A71;
                    goto case 0x8A71;
                case 0x8A70:
                    TotalCycles += 7; PushU16(0x8A72); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A71:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8A87; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A87; }
                    PC = 0x8A73; goto case 0x8A73;
                case 0x8A73:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x8A75;
                    goto case 0x8A75;
                case 0x8A74:
                    TotalCycles += 7; PushU16(0x8A76); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A75:
                    Cmp(A, 0x58); TotalCycles += 2; PC = 0x8A77;
                    goto case 0x8A77;
                case 0x8A76:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0x8A77;
                    goto case 0x8A77;
                case 0x8A77:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8A87; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A87; }
                    PC = 0x8A79; goto case 0x8A79;
                case 0x8A78:
                    { int a = 0x51C9; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x8A7B;
                    goto case 0x8A7B;
                case 0x8A79:
                    Cmp(A, 0x51); TotalCycles += 2; PC = 0x8A7B;
                    goto case 0x8A7B;
                case 0x8A7A:
                    A ^= ReadMem(ReadU16Zp(0xF0) + Y); SetZN(A); TotalCycles += 5; PC = 0x8A7C;
                    goto case 0x8A7C;
                case 0x8A7B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8A87; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A87; }
                    PC = 0x8A7D; goto case 0x8A7D;
                case 0x8A7C:
                    A = Asl(A); TotalCycles += 2; PC = 0x8A7D;
                    goto case 0x8A7D;
                case 0x8A7D:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8A7E;
                    goto case 0x8A7E;
                case 0x8A7E:
                    Cmp(A, 0x5D); TotalCycles += 2; PC = 0x8A80;
                    goto case 0x8A80;
                case 0x8A7F:
                    A ^= _ram[(0x05F0 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8A82;
                    goto case 0x8A82;
                case 0x8A80:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8A87; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A87; }
                    PC = 0x8A82; goto case 0x8A82;
                case 0x8A81:
                    A |= _ram[0xC9]; SetZN(A); TotalCycles += 3; PC = 0x8A83;
                    return;
                case 0x8A82:
                    Cmp(A, 0x52); TotalCycles += 2; PC = 0x8A84;
                    goto case 0x8A84;
                case 0x8A84:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8A87; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A87; }
                    PC = 0x8A86; goto case 0x8A86;
                case 0x8A85:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0x8A87;
                    goto case 0x8A87;
                case 0x8A86:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8A87;
                    goto case 0x8A87;
                case 0x8A87:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x8A88;
                    goto case 0x8A88;
                case 0x8A88:
                    Y = _ram[0x0300]; SetZN(Y); TotalCycles += 4; PC = 0x8A8B;
                    goto case 0x8A8B;
                case 0x8A89:
                    TotalCycles += 7; PushU16(0x8A8B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A8B:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8A8C;
                    goto case 0x8A8C;
                case 0x8A8C:
                    TotalCycles += 6; PushU16(0x8A8E); PC = 0x8A97;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8A97;
                case 0x8A8E:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8A8F;
                    goto case 0x8A8F;
                case 0x8A8F:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8A90;
                    goto case 0x8A90;
                case 0x8A90:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x8A91;
                    goto case 0x8A91;
                case 0x8A91:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8A92;
                    goto case 0x8A92;
                case 0x8A92:
                    Adc(0x0A); TotalCycles += 2; PC = 0x8A94;
                    goto case 0x8A94;
                case 0x8A93:
                    A = Asl(A); TotalCycles += 2; PC = 0x8A94;
                    goto case 0x8A94;
                case 0x8A94:
                    TotalCycles += 3; PC = 0x863F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x863F;
                case 0x8A96:
                    _ram[0x86] = X; TotalCycles += 3; PC = 0x8A98;
                    goto case 0x8A98;
                case 0x8A97: // === SUBROUTINE: Sub_8A97 ===
                    _ram[0x00] = X; TotalCycles += 3; PC = 0x8A99;
                    goto case 0x8A99;
                case 0x8A98:
                    TotalCycles += 7; PushU16(0x8A9A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8A99:
                    _ram[0x01] = Y; TotalCycles += 3; PC = 0x8A9B;
                    goto case 0x8A9B;
                case 0x8A9A:
                    A |= ReadMem(ReadU16Zp((byte)(0x0A + X))); SetZN(A); TotalCycles += 6; PC = 0x8A9C;
                    goto case 0x8A9C;
                case 0x8A9B:
                    A = Asl(A); TotalCycles += 2; PC = 0x8A9C;
                    goto case 0x8A9C;
                case 0x8A9C:
                    A = Asl(A); TotalCycles += 2; PC = 0x8A9D;
                    goto case 0x8A9D;
                case 0x8A9D:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x8A9E;
                    goto case 0x8A9E;
                case 0x8A9E:
                    Y = 0x20; SetZN(Y); TotalCycles += 2; PC = 0x8AA0;
                    goto case 0x8AA0;
                case 0x8A9F:
                    TotalCycles += 6; PushU16(0x8AA1); PC = 0x06A5;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8AA0:
                    A = _ram[0x06]; SetZN(A); TotalCycles += 3; PC = 0x8AA2;
                    goto case 0x8AA2;
                case 0x8AA1:
                    _ram[0xC9] = Asl(_ram[0xC9]); TotalCycles += 5; PC = 0x8AA3;
                    goto case 0x8AA3;
                case 0x8AA2:
                    Cmp(A, 0xD0); TotalCycles += 2; PC = 0x8AA4;
                    goto case 0x8AA4;
                case 0x8AA3:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8A35; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8A35; }
                    PC = 0x8AA5; return;
                case 0x8AA4:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8AA8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8AA8; }
                    PC = 0x8AA6; goto case 0x8AA6;
                case 0x8AA6:
                    Y = 0x24; SetZN(Y); TotalCycles += 2; PC = 0x8AA8;
                    goto case 0x8AA8;
                case 0x8AA7:
                    Bit(_ram[0x84]); TotalCycles += 3; PC = 0x8AA9;
                    return;
                case 0x8AA8:
                    _ram[0x03] = Y; TotalCycles += 3; PC = 0x8AAA;
                    goto case 0x8AAA;
                case 0x8AAA:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x8AAC;
                    goto case 0x8AAC;
                case 0x8AAC:
                    A = Asl(A); TotalCycles += 2; PC = 0x8AAD;
                    goto case 0x8AAD;
                case 0x8AAD:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0x8AAF;
                    goto case 0x8AAF;
                case 0x8AAF:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8AB1;
                    goto case 0x8AB1;
                case 0x8AB0:
                    TotalCycles += 7; PushU16(0x8AB2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8AB1:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0x8AB3;
                    goto case 0x8AB3;
                case 0x8AB2:
                    A |= _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0x8AB4;
                    return;
                case 0x8AB3:
                    A = _ram[0x02]; SetZN(A); TotalCycles += 3; PC = 0x8AB5;
                    goto case 0x8AB5;
                case 0x8AB5:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8AB6;
                    goto case 0x8AB6;
                case 0x8AB6:
                    Adc(0x20); TotalCycles += 2; PC = 0x8AB8;
                    goto case 0x8AB8;
                case 0x8AB7:
                    TotalCycles += 6; PushU16(0x8AB9); PC = 0x260A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8AB8:
                    A = Asl(A); TotalCycles += 2; PC = 0x8AB9;
                    goto case 0x8AB9;
                case 0x8AB9:
                    _ram[0x05] = Rol(_ram[0x05]); TotalCycles += 5; PC = 0x8ABB;
                    goto case 0x8ABB;
                case 0x8ABA:
                    A |= _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0x8ABC;
                    goto case 0x8ABC;
                case 0x8ABB:
                    A = Asl(A); TotalCycles += 2; PC = 0x8ABC;
                    goto case 0x8ABC;
                case 0x8ABC:
                    _ram[0x05] = Rol(_ram[0x05]); TotalCycles += 5; PC = 0x8ABE;
                    goto case 0x8ABE;
                case 0x8ABD:
                    A |= _ram[0x65]; SetZN(A); TotalCycles += 3; PC = 0x8ABF;
                    return;
                case 0x8ABE:
                    Adc(_ram[0x04]); TotalCycles += 3; PC = 0x8AC0;
                    goto case 0x8AC0;
                case 0x8AC0:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0x8AC2;
                    goto case 0x8AC2;
                case 0x8AC2:
                    A = _ram[0x05]; SetZN(A); TotalCycles += 3; PC = 0x8AC4;
                    goto case 0x8AC4;
                case 0x8AC3:
                    A |= _ram[0x69]; SetZN(A); TotalCycles += 3; PC = 0x8AC5;
                    goto case 0x8AC5;
                case 0x8AC4:
                    Adc(0x00); TotalCycles += 2; PC = 0x8AC6;
                    goto case 0x8AC6;
                case 0x8AC5:
                    TotalCycles += 7; PushU16(0x8AC7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8AC6:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8AC7;
                    goto case 0x8AC7;
                case 0x8AC7:
                    Adc(_ram[0x03]); TotalCycles += 3; PC = 0x8AC9;
                    goto case 0x8AC9;
                case 0x8AC9:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0x8ACB;
                    goto case 0x8ACB;
                case 0x8ACA:
                    A |= _ram[0xA4]; SetZN(A); TotalCycles += 3; PC = 0x8ACC;
                    goto case 0x8ACC;
                case 0x8ACB:
                    Y = _ram[0x01]; SetZN(Y); TotalCycles += 3; PC = 0x8ACD;
                    goto case 0x8ACD;
                case 0x8ACC:
                    A |= ReadMem(ReadU16Zp((byte)(0xBD + X))); SetZN(A); TotalCycles += 6; PC = 0x8ACE;
                    goto case 0x8ACE;
                case 0x8ACD:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0A39 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8AD0;
                    goto case 0x8AD0;
                case 0x8ACE:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x198A + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8AD1;
                    return;
                case 0x8ACF:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8AD0;
                    goto case 0x8AD0;
                case 0x8AD0:
                    _ram[(0x0303 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8AD3;
                    goto case 0x8AD3;
                case 0x8AD3:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0A3A + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8AD6;
                    goto case 0x8AD6;
                case 0x8AD5: // === SUBROUTINE: AreaParserCore ===
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8AD6;
                    goto case 0x8AD6;
                case 0x8AD6:
                    _ram[(0x0304 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8AD9;
                    goto case 0x8AD9;
                case 0x8AD9:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0A3B + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8ADC;
                    goto case 0x8ADC;
                case 0x8ADB:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8ADC;
                    goto case 0x8ADC;
                case 0x8ADC:
                    _ram[(0x0308 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8ADF;
                    goto case 0x8ADF;
                case 0x8ADD:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8ADE;
                    return;
                case 0x8ADF:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0A3C + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8AE2;
                    goto case 0x8AE2;
                case 0x8AE1:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8AE2;
                    goto case 0x8AE2;
                case 0x8AE2:
                    _ram[(0x0309 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8AE5;
                    goto case 0x8AE5;
                case 0x8AE3:
                    A |= 0x03; SetZN(A); TotalCycles += 2; PC = 0x8AE5;
                    goto case 0x8AE5;
                case 0x8AE5:
                    A = _ram[0x04]; SetZN(A); TotalCycles += 3; PC = 0x8AE7;
                    goto case 0x8AE7;
                case 0x8AE7:
                    _ram[(0x0301 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8AEA;
                    goto case 0x8AEA;
                case 0x8AE8:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x8AEA;
                    goto case 0x8AEA;
                case 0x8AEA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8AEB;
                    goto case 0x8AEB;
                case 0x8AEB:
                    Adc(0x20); TotalCycles += 2; PC = 0x8AED;
                    goto case 0x8AED;
                case 0x8AEC:
                    TotalCycles += 6; PushU16(0x8AEE); PC = 0x0699;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8AED:
                    _ram[(0x0306 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8AF0;
                    goto case 0x8AF0;
                case 0x8AEE:
                    _ram[0x03] = Asl(_ram[0x03]); TotalCycles += 5; PC = 0x8AF0;
                    goto case 0x8AF0;
                case 0x8AF0:
                    A = _ram[0x05]; SetZN(A); TotalCycles += 3; PC = 0x8AF2;
                    goto case 0x8AF2;
                case 0x8AF1:
                    A |= _ram[0x99]; SetZN(A); TotalCycles += 3; PC = 0x8AF3;
                    goto case 0x8AF3;
                case 0x8AF2:
                    _ram[(0x0300 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8AF5;
                    goto case 0x8AF5;
                case 0x8AF3:
                    TotalCycles += 7; PushU16(0x8AF5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8AF5:
                    _ram[(0x0305 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8AF8;
                    goto case 0x8AF8;
                case 0x8AF6:
                    A |= _ram[0x03]; SetZN(A); TotalCycles += 3; PC = 0x8AF8;
                    goto case 0x8AF8;
                case 0x8AF8:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0x8AFA;
                    goto case 0x8AFA;
                case 0x8AFA:
                    _ram[(0x0302 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8AFD;
                    goto case 0x8AFD;
                case 0x8AFD:
                    _ram[(0x0307 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8B00;
                    goto case 0x8B00;
                case 0x8B00:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8B02;
                    goto case 0x8B02;
                case 0x8B01:
                    TotalCycles += 7; PushU16(0x8B03); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8B02:
                    _ram[(0x030A + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8B05;
                    goto case 0x8B05;
                case 0x8B03:
                    A = Asl(A); TotalCycles += 2; PC = 0x8B04;
                    return;
                case 0x8B05:
                    X = _ram[0x00]; SetZN(X); TotalCycles += 3; PC = 0x8B07;
                    goto case 0x8B07;
                case 0x8B06:
                    TotalCycles += 7; PushU16(0x8B08); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8B07:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8B08:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8AB6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8AB6; }
                    PC = 0x8B0A; return;
                case 0x8B09:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x0C64]; SetZN(Y); TotalCycles += 4; PC = 0x8B0C;
                    return;
                case 0x8B0B:
                    WriteIoReg(0x8B8B, Y); TotalCycles += 4; PC = 0x8B0E;
                    goto case 0x8B0E;
                case 0x8B0E:
                    WriteIoReg(0x248C, Y); TotalCycles += 4; PC = 0x8B11;
                    goto case 0x8B11;
                case 0x8B0F:
                    WriteIoReg(0x2424, Y); TotalCycles += 4; PC = 0x8B12;
                    goto case 0x8B12;
                case 0x8B10:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8B12;
                    goto case 0x8B12;
                case 0x8B11:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8B13;
                    goto case 0x8B13;
                case 0x8B12:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8B14;
                    return;
                case 0x8B13:
                    Bit(_ram[0x27]); TotalCycles += 3; PC = 0x8B15;
                    return;
                case 0x8B18:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8B1A;
                    goto case 0x8B1A;
                case 0x8B19:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8B1B;
                    goto case 0x8B1B;
                case 0x8B1A:
                    Bit(_ram[0x35]); TotalCycles += 3; PC = 0x8B1C;
                    goto case 0x8B1C;
                case 0x8B1B:
                    A &= _ram[(byte)(0x36 + X)]; SetZN(A); TotalCycles += 4; PC = 0x8B1D;
                    goto case 0x8B1D;
                case 0x8B1C:
                    { byte z = (byte)(0x25 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x8B1E;
                    return;
                case 0x8B1D:
                    A &= _ram[0x37]; SetZN(A); TotalCycles += 3; PC = 0x8B1F;
                    goto case 0x8B1F;
                case 0x8B1F:
                    A &= _ram[0x24]; SetZN(A); TotalCycles += 3; PC = 0x8B21;
                    goto case 0x8B21;
                case 0x8B20:
                    Bit(_ram[0x38]); TotalCycles += 3; PC = 0x8B22;
                    goto case 0x8B22;
                case 0x8B21:
                    P |= FlagC; TotalCycles += 2; PC = 0x8B22;
                    goto case 0x8B22;
                case 0x8B22:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8B24;
                    goto case 0x8B24;
                case 0x8B23:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8B25;
                    goto case 0x8B25;
                case 0x8B24:
                    Bit(_ram[0x30]); TotalCycles += 3; PC = 0x8B26;
                    goto case 0x8B26;
                case 0x8B25:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8B57; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8B27; goto case 0x8B27;
                case 0x8B26:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8B4E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8B28; goto case 0x8B28;
                case 0x8B27:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8B29;
                    goto case 0x8B29;
                case 0x8B28:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8B2A;
                    return;
                case 0x8B29:
                    _ram[0x34] = Rol(_ram[0x34]); TotalCycles += 5; PC = 0x8B2B;
                    goto case 0x8B2B;
                case 0x8B2B: // === SUBROUTINE: ProcessAreaData ===
                    _ram[0x24] = Rol(_ram[0x24]); TotalCycles += 5; PC = 0x8B2D;
                    goto case 0x8B2D;
                case 0x8B2C:
                    Bit(_ram[0x31]); TotalCycles += 3; PC = 0x8B2E;
                    goto case 0x8B2E;
                case 0x8B2D:
                    A &= ReadMem(ReadU16Zp(0x24) + Y); SetZN(A); TotalCycles += 5; PC = 0x8B2F;
                    return;
                case 0x8B2E:
                    Bit(_ram[0x32]); TotalCycles += 3; PC = 0x8B30;
                    return;
                case 0x8B31:
                    _ram[0x24] = Rol(_ram[0x24]); TotalCycles += 5; PC = 0x8B33;
                    return;
                case 0x8B32:
                    Bit(_ram[0x33]); TotalCycles += 3; PC = 0x8B34;
                    return;
                case 0x8B35:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8B37;
                    goto case 0x8B37;
                case 0x8B36:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8B38;
                    goto case 0x8B38;
                case 0x8B37:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8B39;
                    goto case 0x8B39;
                case 0x8B38:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8B3A;
                    goto case 0x8B3A;
                case 0x8B39:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8B3B;
                    goto case 0x8B3B;
                case 0x8B3A:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8B3C;
                    goto case 0x8B3C;
                case 0x8B3B:
                    _ram[0x24] = Rol(_ram[0x24]); TotalCycles += 5; PC = 0x8B3D;
                    goto case 0x8B3D;
                case 0x8B3C:
                    Bit(_ram[0xC0]); TotalCycles += 3; PC = 0x8B3E;
                    goto case 0x8B3E;
                case 0x8B3D:
                    Cmp(Y, 0x24); TotalCycles += 2; PC = 0x8B3F;
                    goto case 0x8B3F;
                case 0x8B3E:
                    Bit(_ram[0xC0]); TotalCycles += 3; PC = 0x8B40;
                    goto case 0x8B40;
                case 0x8B3F:
                    Cmp(Y, 0x24); TotalCycles += 2; PC = 0x8B41;
                    return;
                case 0x8B40:
                    Bit(_ram[0x7F]); TotalCycles += 3; PC = 0x8B42;
                    return;
                case 0x8B43:
                    Bit(_ram[0xB8]); TotalCycles += 3; PC = 0x8B45;
                    goto case 0x8B45;
                case 0x8B44:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0x8B45;
                    goto case 0x8B45;
                case 0x8B45:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0x8B46;
                    goto case 0x8B46;
                case 0x8B46:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x38BB + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8B49;
                    goto case 0x8B49;
                case 0x8B48:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0x8B49;
                    goto case 0x8B49;
                case 0x8B49:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x3DB9 + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0x8B4C;
                    goto case 0x8B4C;
                case 0x8B4A:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3ABD + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8B4D;
                    goto case 0x8B4D;
                case 0x8B4B:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3CBA + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8B4E;
                    return;
                case 0x8B4C:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0x8B4D;
                    goto case 0x8B4D;
                case 0x8B4D:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x3DBB + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0x8B50;
                    goto case 0x8B50;
                case 0x8B4F:
                    A = ReadMem(0x6460 + X); SetZN(A); TotalCycles += 4; PC = 0x8B52;
                    goto case 0x8B52;
                case 0x8B50:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8B52:
                    Adc(ReadMem(ReadU16Zp((byte)(0x65 + X)))); TotalCycles += 6; PC = 0x8B54;
                    return;
                case 0x8B53:
                    Adc(_ram[0x62]); TotalCycles += 3; PC = 0x8B55;
                    goto case 0x8B55;
                case 0x8B55:
                    _ram[0x63] = Ror(_ram[0x63]); TotalCycles += 5; PC = 0x8B57;
                    return;
                case 0x8B58:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8B5A:
                    Adc(ReadMem(ReadU16Zp((byte)(0x65 + X)))); TotalCycles += 6; PC = 0x8B5C;
                    return;
                case 0x8B5B:
                    Adc(_ram[0x62]); TotalCycles += 3; PC = 0x8B5D;
                    goto case 0x8B5D;
                case 0x8B5D:
                    _ram[0x63] = Ror(_ram[0x63]); TotalCycles += 5; PC = 0x8B5F;
                    return;
                case 0x8B60:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8B61;
                    goto case 0x8B61;
                case 0x8B61:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8B62;
                    goto case 0x8B62;
                case 0x8B62:
                    Adc(0x69); TotalCycles += 2; PC = 0x8B64;
                    goto case 0x8B64;
                case 0x8B63:
                    Adc(0x26); TotalCycles += 2; PC = 0x8B65;
                    goto case 0x8B65;
                case 0x8B64:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8B66;
                    goto case 0x8B66;
                case 0x8B65:
                    _ram[0x6A] = Rol(_ram[0x6A]); TotalCycles += 5; PC = 0x8B67;
                    goto case 0x8B67;
                case 0x8B66:
                    A = Ror(A); TotalCycles += 2; PC = 0x8B67;
                    goto case 0x8B67;
                case 0x8B67:
                    A = Ror(A); TotalCycles += 2; PC = 0x8B68;
                    return;
                case 0x8B69:
                    TotalCycles += 3; PC = 0x4E4D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8B6A:
                    A ^= ReadIoReg(0x4D4E); SetZN(A); TotalCycles += 4; PC = 0x8B6D;
                    return;
                case 0x8B6B:
                    { int a = 0x4F4D; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x8B6E;
                    goto case 0x8B6E;
                case 0x8B6C:
                    A ^= ReadIoReg(0x4D4F); SetZN(A); TotalCycles += 4; PC = 0x8B6F;
                    return;
                case 0x8B6E:
                    A ^= ReadIoReg(0x4D4F); SetZN(A); TotalCycles += 4; PC = 0x8B71;
                    goto case 0x8B71;
                case 0x8B70:
                    A ^= ReadIoReg(0x504E); SetZN(A); TotalCycles += 4; PC = 0x8B73;
                    goto case 0x8B73;
                case 0x8B71:
                    { int a = 0x5150; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x8B74;
                    return;
                case 0x8B72:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x8BC5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8B74; return;
                case 0x8B73:
                    A ^= ReadMem(ReadU16Zp(0x6B) + Y); SetZN(A); TotalCycles += 5; PC = 0x8B75;
                    goto case 0x8B75;
                case 0x8B75:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x8BA3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8BA3; }
                    PC = 0x8B77; goto case 0x8B77;
                case 0x8B76:
                    Bit(ReadIoReg(0x6C2D)); TotalCycles += 4; PC = 0x8B79;
                    goto case 0x8B79;
                case 0x8B77:
                    A &= ReadIoReg(0x716C); SetZN(A); TotalCycles += 4; PC = 0x8B7A;
                    goto case 0x8B7A;
                case 0x8B78:
                    TotalCycles += 5; PC = ReadU16Zp(0x71); return;
                case 0x8B79:
                    Adc(ReadMem(ReadU16Zp(0x6D) + Y)); TotalCycles += 5; PC = 0x8B7B;
                    return;
                case 0x8B7A:
                    Adc(ReadIoReg(0x6E72)); TotalCycles += 4; PC = 0x8B7D;
                    return;
                case 0x8B7C:
                    { int a = 0x6F73; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0x8B7F;
                    return;
                case 0x8B80:
                    _ram[0x8A] = X; TotalCycles += 3; PC = 0x8B82;
                    return;
                case 0x8B81:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8B82;
                    return;
                case 0x8B84:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8B85;
                    goto case 0x8B85;
                case 0x8B85:
                    WriteIoReg(0x8C88, Y); TotalCycles += 4; PC = 0x8B88;
                    return;
                case 0x8B86:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8B87;
                    goto case 0x8B87;
                case 0x8B87:
                    WriteIoReg(0x8D89, Y); TotalCycles += 4; PC = 0x8B8A;
                    goto case 0x8B8A;
                case 0x8B89:
                    WriteIoReg(0x6969, A); TotalCycles += 4; PC = 0x8B8C;
                    goto case 0x8B8C;
                case 0x8B8A:
                    Adc(0x69); TotalCycles += 2; PC = 0x8B8C;
                    goto case 0x8B8C;
                case 0x8B8B:
                    Adc(0x8E); TotalCycles += 2; PC = 0x8B8D;
                    goto case 0x8B8D;
                case 0x8B8C:
                    WriteIoReg(0x8F91, X); TotalCycles += 4; PC = 0x8B8F;
                    return;
                case 0x8B8D:
                    WriteMem(ReadU16Zp(0x8F) + Y, A); TotalCycles += 6; PC = 0x8B8F;
                    return;
                case 0x8B90:
                    _ram[0x93] = Rol(_ram[0x93]); TotalCycles += 5; PC = 0x8B92;
                    goto case 0x8B92;
                case 0x8B92:
                    _ram[0x93] = Rol(_ram[0x93]); TotalCycles += 5; PC = 0x8B94;
                    goto case 0x8B94;
                case 0x8B94:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8B2A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8B96; goto case 0x8B96;
                case 0x8B95:
                    _ram[(byte)(0x69 + X)] = Y; TotalCycles += 4; PC = 0x8B97;
                    goto case 0x8B97;
                case 0x8B96:
                    Adc(0x69); TotalCycles += 2; PC = 0x8B98;
                    goto case 0x8B98;
                case 0x8B97:
                    Adc(0xA4); TotalCycles += 2; PC = 0x8B99;
                    goto case 0x8B99;
                case 0x8B98:
                    Y = _ram[0xE9]; SetZN(Y); TotalCycles += 3; PC = 0x8B9A;
                    goto case 0x8B9A;
                case 0x8B99:
                    Sbc(0xEA); TotalCycles += 2; PC = 0x8B9B;
                    return;
                case 0x8B9A:
                     TotalCycles += 2; PC = 0x8B9B;
                    return;
                case 0x8B9C:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8B9E;
                    goto case 0x8B9E;
                case 0x8B9D:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8B9F;
                    goto case 0x8B9F;
                case 0x8B9E:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8BA0;
                    goto case 0x8BA0;
                case 0x8B9F:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8BA1;
                    return;
                case 0x8BA0:
                    Bit(_ram[0x2F]); TotalCycles += 3; PC = 0x8BA2;
                    goto case 0x8BA2;
                case 0x8BA2:
                    Bit(_ram[0x3D]); TotalCycles += 3; PC = 0x8BA4;
                    goto case 0x8BA4;
                case 0x8BA3:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x22A2 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8BA6;
                    return;
                case 0x8BA4:
                    X = 0xA2; SetZN(X); TotalCycles += 2; PC = 0x8BA6;
                    return;
                case 0x8BA5:
                    X = 0xA3; SetZN(X); TotalCycles += 2; PC = 0x8BA7;
                    return;
                case 0x8BA8:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8BAA;
                    goto case 0x8BAA;
                case 0x8BA9:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8BAB;
                    goto case 0x8BAB;
                case 0x8BAA:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8BAC;
                    goto case 0x8BAC;
                case 0x8BAB:
                    Bit(_ram[0xA2]); TotalCycles += 3; PC = 0x8BAD;
                    goto case 0x8BAD;
                case 0x8BAC:
                    X = 0xA2; SetZN(X); TotalCycles += 2; PC = 0x8BAE;
                    return;
                case 0x8BAD:
                    X = 0xA3; SetZN(X); TotalCycles += 2; PC = 0x8BAF;
                    return;
                case 0x8BB0:
                    WriteMem(0x9924 + Y, A); TotalCycles += 5; PC = 0x8BB3;
                    goto case 0x8BB3;
                case 0x8BB1:
                    Bit(_ram[0x99]); TotalCycles += 3; PC = 0x8BB3;
                    goto case 0x8BB3;
                case 0x8BB2:
                    WriteMem(0x2424 + Y, A); TotalCycles += 5; PC = 0x8BB5;
                    goto case 0x8BB5;
                case 0x8BB3:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8BB5;
                    goto case 0x8BB5;
                case 0x8BB4:
                    Bit(_ram[0xA2]); TotalCycles += 3; PC = 0x8BB6;
                    goto case 0x8BB6;
                case 0x8BB5:
                    X = 0x3E; SetZN(X); TotalCycles += 2; PC = 0x8BB7;
                    return;
                case 0x8BB6:
                    { int a = 0x5B3F + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0x8BB9;
                    return;
                case 0x8BBA:
                    Bit(_ram[0xA3]); TotalCycles += 3; PC = 0x8BBC;
                    goto case 0x8BBC;
                case 0x8BBC:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8BBE;
                    goto case 0x8BBE;
                case 0x8BBD:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8BBF;
                    goto case 0x8BBF;
                case 0x8BBE:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8BC0;
                    goto case 0x8BC0;
                case 0x8BBF:
                    Bit(_ram[0x9D]); TotalCycles += 3; PC = 0x8BC1;
                    return;
                case 0x8BC0:
                    WriteMem(0x9E47 + X, A); TotalCycles += 5; PC = 0x8BC3;
                    return;
                case 0x8BD0:
                    A = 0x47; SetZN(A); TotalCycles += 2; PC = 0x8BD2;
                    goto case 0x8BD2;
                case 0x8BD2:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x8BD3;
                    return;
                case 0x8BE1:
                    Y = 0x81; SetZN(Y); TotalCycles += 2; PC = 0x8BE3;
                    goto case 0x8BE3;
                case 0x8BE2:
                    WriteMem(ReadU16Zp((byte)(0xA1 + X)), A); TotalCycles += 6; PC = 0x8BE4;
                    goto case 0x8BE4;
                case 0x8BE3:
                    A = ReadMem(ReadU16Zp((byte)(0xBE + X))); SetZN(A); TotalCycles += 6; PC = 0x8BE5;
                    goto case 0x8BE5;
                case 0x8BE4:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x3FBE + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0x8BE7;
                    return;
                case 0x8BE5:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x3FBF + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0x8BE8;
                    goto case 0x8BE8;
                case 0x8BE8:
                    Adc(_ram[(byte)(0xBA + X)]); TotalCycles += 4; PC = 0x8BEA;
                    goto case 0x8BEA;
                case 0x8BE9:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0x8BEA;
                    goto case 0x8BEA;
                case 0x8BEA:
                    { byte z = (byte)(0xBB + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x8BEC;
                    goto case 0x8BEC;
                case 0x8BEC:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0x8BED;
                    goto case 0x8BED;
                case 0x8BED:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0x8BEE;
                    return;
                case 0x8BF0:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8BF2;
                    goto case 0x8BF2;
                case 0x8BF2:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8BF4;
                    return;
                case 0x8BF8:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8BFA;
                    goto case 0x8BFA;
                case 0x8BFA:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8BFC;
                    goto case 0x8BFC;
                case 0x8BFC:
                    Y = _ram[(byte)(0xB6 + X)]; SetZN(Y); TotalCycles += 4; PC = 0x8BFE;
                    goto case 0x8BFE;
                case 0x8BFD:
                    X = _ram[(byte)(0xB5 + Y)]; SetZN(X); TotalCycles += 4; PC = 0x8BFF;
                    return;
                case 0x8BFE:
                    A = _ram[(byte)(0xB7 + X)]; SetZN(A); TotalCycles += 4; PC = 0x8C00;
                    goto case 0x8C00;
                case 0x8C00:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C02;
                    goto case 0x8C02;
                case 0x8C02:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C04;
                    goto case 0x8C04;
                case 0x8C04:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C06;
                    goto case 0x8C06;
                case 0x8C06:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C08;
                    goto case 0x8C08;
                case 0x8C08:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C0A;
                    goto case 0x8C0A;
                case 0x8C0A:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C0C;
                    goto case 0x8C0C;
                case 0x8C0C:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C0E;
                    goto case 0x8C0E;
                case 0x8C0E:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C10;
                    goto case 0x8C10;
                case 0x8C10:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C12;
                    goto case 0x8C12;
                case 0x8C12:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x8C14;
                    return;
                case 0x8C28:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C2A;
                    goto case 0x8C2A;
                case 0x8C29:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C2B;
                    goto case 0x8C2B;
                case 0x8C2A:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C2C;
                    goto case 0x8C2C;
                case 0x8C2B:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C2D;
                    goto case 0x8C2D;
                case 0x8C2C:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C2E;
                    goto case 0x8C2E;
                case 0x8C2D:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C2F;
                    goto case 0x8C2F;
                case 0x8C2E:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C30;
                    return;
                case 0x8C2F:
                    Bit(_ram[0xAB]); TotalCycles += 3; PC = 0x8C31;
                    goto case 0x8C31;
                case 0x8C31:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x2EAD]; SetZN(Y); TotalCycles += 4; PC = 0x8C34;
                    goto case 0x8C34;
                case 0x8C32:
                    A = ReadIoReg(0x5DAE); SetZN(A); TotalCycles += 4; PC = 0x8C35;
                    goto case 0x8C35;
                case 0x8C33:
                    X = ReadIoReg(0x5E5D); SetZN(X); TotalCycles += 4; PC = 0x8C36;
                    goto case 0x8C36;
                case 0x8C34:
                    A ^= ReadMem(0x5D5E + X); SetZN(A); TotalCycles += 4; PC = 0x8C37;
                    goto case 0x8C37;
                case 0x8C35:
                    { int a = 0x5E5D + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0x8C38;
                    goto case 0x8C38;
                case 0x8C36:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x415E + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8C39;
                    goto case 0x8C39;
                case 0x8C37:
                    { int a = 0x24C1 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0x8C3A;
                    goto case 0x8C3A;
                case 0x8C38:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x24 + X)))); TotalCycles += 6; PC = 0x8C3A;
                    goto case 0x8C3A;
                case 0x8C39:
                    Bit(_ram[0xC1]); TotalCycles += 3; PC = 0x8C3B;
                    goto case 0x8C3B;
                case 0x8C3A:
                    Cmp(A, ReadMem(ReadU16Zp((byte)(0x24 + X)))); TotalCycles += 6; PC = 0x8C3C;
                    goto case 0x8C3C;
                case 0x8C3B:
                    Bit(_ram[0xC6]); TotalCycles += 3; PC = 0x8C3D;
                    goto case 0x8C3D;
                case 0x8C3C:
                    _ram[0xC8] = DecVal(_ram[0xC8]); TotalCycles += 5; PC = 0x8C3E;
                    return;
                case 0x8C3D:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8C3E;
                    return;
                case 0x8C3F:
                    Cmp(A, 0xCA); TotalCycles += 2; PC = 0x8C41;
                    goto case 0x8C41;
                case 0x8C40:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8C41;
                    goto case 0x8C41;
                case 0x8C41:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x4DCB]); TotalCycles += 4; PC = 0x8C44;
                    goto case 0x8C44;
                case 0x8C43:
                    Cmp(A, ReadIoReg(0x2A2A)); TotalCycles += 4; PC = 0x8C46;
                    goto case 0x8C46;
                case 0x8C44:
                    A = Rol(A); TotalCycles += 2; PC = 0x8C45;
                    goto case 0x8C45;
                case 0x8C45:
                    A = Rol(A); TotalCycles += 2; PC = 0x8C46;
                    goto case 0x8C46;
                case 0x8C46:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8C47:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8C48:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C4A;
                    goto case 0x8C4A;
                case 0x8C49:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C4B;
                    goto case 0x8C4B;
                case 0x8C4A:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C4C;
                    goto case 0x8C4C;
                case 0x8C4B:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C4D;
                    return;
                case 0x8C4C:
                    Bit(_ram[0x47]); TotalCycles += 3; PC = 0x8C4E;
                    goto case 0x8C4E;
                case 0x8C4E:
                    Bit(_ram[0x47]); TotalCycles += 3; PC = 0x8C50;
                    return;
                case 0x8C52:
                    _ram[0x85] = Y; TotalCycles += 3; PC = 0x8C54;
                    goto case 0x8C54;
                case 0x8C53:
                    _ram[0x24] = A; TotalCycles += 3; PC = 0x8C55;
                    return;
                case 0x8C54:
                    Bit(_ram[0x47]); TotalCycles += 3; PC = 0x8C56;
                    goto case 0x8C56;
                case 0x8C56:
                    Bit(_ram[0x47]); TotalCycles += 3; PC = 0x8C58;
                    goto case 0x8C58;
                case 0x8C58:
                    _ram[0x8A] = X; TotalCycles += 3; PC = 0x8C5A;
                    return;
                case 0x8C59:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8C5A;
                    return;
                case 0x8C5C:
                    WriteIoReg(0x8F91, X); TotalCycles += 4; PC = 0x8C5F;
                    return;
                case 0x8C5D:
                    WriteMem(ReadU16Zp(0x8F) + Y, A); TotalCycles += 6; PC = 0x8C5F;
                    return;
                case 0x8C60:
                    Bit(_ram[0x2F]); TotalCycles += 3; PC = 0x8C62;
                    goto case 0x8C62;
                case 0x8C62:
                    Bit(_ram[0x3D]); TotalCycles += 3; PC = 0x8C64;
                    goto case 0x8C64;
                case 0x8C63:
                    A &= ReadMem(0x2424 + X); SetZN(A); TotalCycles += 4; PC = 0x8C66;
                    goto case 0x8C66;
                case 0x8C64:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C66;
                    goto case 0x8C66;
                case 0x8C65:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C67;
                    goto case 0x8C67;
                case 0x8C66:
                    Bit(_ram[0x35]); TotalCycles += 3; PC = 0x8C68;
                    goto case 0x8C68;
                case 0x8C67: // === SUBROUTINE: DecodeAreaData ===
                    A &= _ram[(byte)(0x36 + X)]; SetZN(A); TotalCycles += 4; PC = 0x8C69;
                    goto case 0x8C69;
                case 0x8C68:
                    { byte z = (byte)(0x25 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x8C6A;
                    return;
                case 0x8C69:
                    A &= _ram[0x37]; SetZN(A); TotalCycles += 3; PC = 0x8C6B;
                    goto case 0x8C6B;
                case 0x8C6B:
                    A &= _ram[0x24]; SetZN(A); TotalCycles += 3; PC = 0x8C6D;
                    goto case 0x8C6D;
                case 0x8C6C:
                    Bit(_ram[0x38]); TotalCycles += 3; PC = 0x8C6E;
                    goto case 0x8C6E;
                case 0x8C6D:
                    P |= FlagC; TotalCycles += 2; PC = 0x8C6E;
                    goto case 0x8C6E;
                case 0x8C6E:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C70;
                    goto case 0x8C70;
                case 0x8C6F:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C71;
                    goto case 0x8C71;
                case 0x8C70:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C72;
                    goto case 0x8C72;
                case 0x8C71:
                    Bit(_ram[0x39]); TotalCycles += 3; PC = 0x8C73;
                    goto case 0x8C73;
                case 0x8C72:
                    A &= ReadMem(0x3A24 + Y); SetZN(A); TotalCycles += 4; PC = 0x8C75;
                    goto case 0x8C75;
                case 0x8C73:
                    Bit(_ram[0x3A]); TotalCycles += 3; PC = 0x8C75;
                    goto case 0x8C75;
                case 0x8C75:
                    Bit(_ram[0x3B]); TotalCycles += 3; PC = 0x8C77;
                    goto case 0x8C77;
                case 0x8C77:
                    Bit(_ram[0x3C]); TotalCycles += 3; PC = 0x8C79;
                    goto case 0x8C79;
                case 0x8C79:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C7B;
                    goto case 0x8C7B;
                case 0x8C7A:
                    Bit(_ram[0x24]); TotalCycles += 3; PC = 0x8C7C;
                    goto case 0x8C7C;
                case 0x8C7B:
                    Bit(_ram[0x41]); TotalCycles += 3; PC = 0x8C7D;
                    goto case 0x8C7D;
                case 0x8C7C:
                    A ^= ReadMem(ReadU16Zp((byte)(0x26 + X))); SetZN(A); TotalCycles += 6; PC = 0x8C7E;
                    goto case 0x8C7E;
                case 0x8C7D:
                    _ram[0x41] = Rol(_ram[0x41]); TotalCycles += 5; PC = 0x8C7F;
                    goto case 0x8C7F;
                case 0x8C7E:
                    A ^= ReadMem(ReadU16Zp((byte)(0x26 + X))); SetZN(A); TotalCycles += 6; PC = 0x8C80;
                    goto case 0x8C80;
                case 0x8C7F:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8C81;
                    goto case 0x8C81;
                case 0x8C80:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8C82;
                    goto case 0x8C82;
                case 0x8C81:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8C83;
                    goto case 0x8C83;
                case 0x8C82:
                    _ram[0x26] = Rol(_ram[0x26]); TotalCycles += 5; PC = 0x8C84;
                    goto case 0x8C84;
                case 0x8C83:
                    _ram[0xB0] = Rol(_ram[0xB0]); TotalCycles += 5; PC = 0x8C85;
                    goto case 0x8C85;
                case 0x8C84:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8C37; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8C37; }
                    PC = 0x8C86; return;
                case 0x8C85:
                    A = ReadMem(ReadU16Zp(0xB2) + Y); SetZN(A); TotalCycles += 5; PC = 0x8C87;
                    return;
                case 0x8C89:
                    Adc(ReadMem(0x7977 + Y)); TotalCycles += 4; PC = 0x8C8C;
                    return;
                case 0x8C8B:
                    Adc(ReadMem(0x5553 + Y)); TotalCycles += 4; PC = 0x8C8E;
                    return;
                case 0x8C8D:
                    A ^= _ram[(byte)(0x54 + X)]; SetZN(A); TotalCycles += 4; PC = 0x8C8F;
                    goto case 0x8C8F;
                case 0x8C8F:
                    { byte z = (byte)(0x53 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x8C91;
                    goto case 0x8C91;
                case 0x8C91:
                    A ^= _ram[(byte)(0x54 + X)]; SetZN(A); TotalCycles += 4; PC = 0x8C93;
                    goto case 0x8C93;
                case 0x8C93:
                    { byte z = (byte)(0xA5 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x8C95;
                    return;
                case 0x8C94:
                    A = _ram[0xA7]; SetZN(A); TotalCycles += 3; PC = 0x8C96;
                    goto case 0x8C96;
                case 0x8C96:
                    X = _ram[0xA8]; SetZN(X); TotalCycles += 3; PC = 0x8C98;
                    return;
                case 0x8C97:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x8C98;
                    return;
                case 0x8C99:
                    Cmp(Y, _ram[0xC3]); TotalCycles += 3; PC = 0x8C9B;
                    goto case 0x8C9B;
                case 0x8C9B:
                    Cmp(A, _ram[0x57]); TotalCycles += 3; PC = 0x8C9D;
                    goto case 0x8C9D;
                case 0x8C9D:
                    A ^= ReadMem(0x5A58 + Y); SetZN(A); TotalCycles += 4; PC = 0x8CA0;
                    return;
                case 0x8C9E:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0x8C9F;
                    return;
                case 0x8CA1:
                    Adc(ReadMem(0x7E7C + X)); TotalCycles += 4; PC = 0x8CA4;
                    return;
                case 0x8CA3:
                    { int a = (0x003F + X) & 0x07FF; _ram[a] = Ror(_ram[a]); } TotalCycles += 7; PC = 0x8CA6;
                    goto case 0x8CA6;
                case 0x8CA5:
                    TotalCycles += 7; PushU16(0x8CA7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8CA6:
                    TotalCycles += 6; PushU16(0x8CA8); PC = 0x150F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8CA8:
                    A |= _ram[(byte)(0x12 + X)]; SetZN(A); TotalCycles += 4; PC = 0x8CAA;
                    goto case 0x8CAA;
                case 0x8CAA:
                    A &= _ram[0x0F]; SetZN(A); TotalCycles += 3; PC = 0x8CAC;
                    return;
                case 0x8CB0:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8CC4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8CB2; return;
                case 0x8CB8:
                    { byte z = (byte)(0x27 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8CBA;
                    goto case 0x8CBA;
                case 0x8CBA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8CBB;
                    return;
                case 0x8CBC:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8CEE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8CEE; }
                    PC = 0x8CBE; return;
                case 0x8CBD:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8CE6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8CBF; return;
                case 0x8CC0:
                    { byte z = (byte)(0x30 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8CC2;
                    return;
                case 0x8CC1:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8CEA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8CC3; return;
                case 0x8CC5:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8CD7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8CC7; goto case 0x8CC7;
                case 0x8CC6:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8CC8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8CC8; return;
                case 0x8CC7:
                    TotalCycles += 7; PushU16(0x8CC9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8CC9:
                    TotalCycles += 7; PushU16(0x8CCB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8CCA:
                    TotalCycles += 6; PushU16(0x8CCC); PC = 0x290F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8CCC:
                    A &= 0x1A; SetZN(A); TotalCycles += 2; PC = 0x8CCE;
                    return;
                case 0x8CD0:
                    { byte z = (byte)(0x17 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x8CD2;
                    return;
                case 0x8CD4:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8CF7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8CD6; return;
                case 0x8CD5:
                    A &= ReadMem(ReadU16Zp((byte)(0x0F + X))); SetZN(A); TotalCycles += 6; PC = 0x8CD7;
                    return;
                case 0x8CDC:
                    { byte z = (byte)(0x27 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8CDE;
                    goto case 0x8CDE;
                case 0x8CDE:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8CDF;
                    return;
                case 0x8CE1:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D0A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8CE3; return;
                case 0x8CE4:
                    { byte z = (byte)(0x30 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8CE6;
                    return;
                case 0x8CE5:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D0E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8CE7; return;
                case 0x8CE9:
                    { byte z = (byte)(0x17 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x8CEB;
                    goto case 0x8CEB;
                case 0x8CEB:
                    TotalCycles += 7; PushU16(0x8CED); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8CED:
                    TotalCycles += 7; PushU16(0x8CEF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8CEE:
                    TotalCycles += 6; PushU16(0x8CF0); PC = 0x290F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8CF0:
                    A &= 0x1A; SetZN(A); TotalCycles += 2; PC = 0x8CF2;
                    goto case 0x8CF2;
                case 0x8CF2:
                    A |= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x8CF4;
                    return;
                case 0x8CF8:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D1B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8CFA; return;
                case 0x8CF9:
                    A &= ReadMem(ReadU16Zp((byte)(0x1C + X))); SetZN(A); TotalCycles += 6; PC = 0x8CFB;
                    return;
                case 0x8D00:
                    { byte z = (byte)(0x27 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8D02;
                    goto case 0x8D02;
                case 0x8D02:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8D03;
                    return;
                case 0x8D05:
                    { byte z = (byte)(0x17 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x8D07;
                    return;
                case 0x8D08:
                    { byte z = (byte)(0x30 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8D0A;
                    return;
                case 0x8D09:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D32; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8D32; }
                    PC = 0x8D0B; return;
                case 0x8D0F:
                    TotalCycles += 7; PushU16(0x8D11); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D11:
                    TotalCycles += 7; PushU16(0x8D13); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D12:
                    TotalCycles += 6; PushU16(0x8D14); PC = 0x300F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8D14:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D26; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8D26; }
                    PC = 0x8D16; goto case 0x8D16;
                case 0x8D15:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8D17; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8D17; return;
                case 0x8D16:
                    TotalCycles += 7; PushU16(0x8D18); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D18:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D2A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8D1A; goto case 0x8D1A;
                case 0x8D19:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8D1B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8D1B; return;
                case 0x8D1A:
                    TotalCycles += 7; PushU16(0x8D1C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D1C:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D34; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8D1E; goto case 0x8D1E;
                case 0x8D1D:
                    { byte z = (byte)(0x00 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8D1F;
                    return;
                case 0x8D1E:
                    TotalCycles += 7; PushU16(0x8D20); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D22:
                    TotalCycles += 7; PushU16(0x8D24); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D24:
                    { byte z = (byte)(0x27 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8D26;
                    goto case 0x8D26;
                case 0x8D26:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8D27;
                    return;
                case 0x8D29:
                    { byte z = (byte)(0x17 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x8D2B;
                    return;
                case 0x8D2C:
                    { byte z = (byte)(0x30 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8D2E;
                    return;
                case 0x8D2D:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D56; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8D56; }
                    PC = 0x8D2F; return;
                case 0x8D30:
                    TotalCycles += 7; PushU16(0x8D32); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D31:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D43; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8D43; }
                    PC = 0x8D33; goto case 0x8D33;
                case 0x8D32:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8D34; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8D34; return;
                case 0x8D33:
                    TotalCycles += 7; PushU16(0x8D35); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D35:
                    TotalCycles += 7; PushU16(0x8D37); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D38:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D3A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8D3A; }
                    PC = 0x8D3A; goto case 0x8D3A;
                case 0x8D39:
                    TotalCycles += 7; PushU16(0x8D3B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D3A:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8D3C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8D3C; return;
                case 0x8D3B:
                    TotalCycles += 7; PushU16(0x8D3D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D3D:
                    TotalCycles += 7; PushU16(0x8D3F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D40:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D42; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8D42; }
                    PC = 0x8D42; goto case 0x8D42;
                case 0x8D41:
                    TotalCycles += 7; PushU16(0x8D43); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D42:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8D44; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8D44; return;
                case 0x8D43:
                    TotalCycles += 7; PushU16(0x8D45); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D45:
                    TotalCycles += 7; PushU16(0x8D47); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D49:
                    { byte z = (byte)(0x0F + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8D4B;
                    goto case 0x8D4B;
                case 0x8D4B:
                    TotalCycles += 7; PushU16(0x8D4D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D51:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8D7A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8D53; goto case 0x8D53;
                case 0x8D53:
                    TotalCycles += 7; PushU16(0x8D55); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D54:
                    A &= _ram[0x48]; SetZN(A); TotalCycles += 3; PC = 0x8D56;
                    goto case 0x8D56;
                case 0x8D55:
                    PushU8(A); TotalCycles += 3; PC = 0x8D56;
                    goto case 0x8D56;
                case 0x8D56:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8D75; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8D75; }
                    PC = 0x8D58; goto case 0x8D58;
                case 0x8D57:
                    A |= ReadMem(0x0A11 + X); SetZN(A); TotalCycles += 4; PC = 0x8D5A;
                    return;
                case 0x8D58:
                    A |= ReadMem(ReadU16Zp(0x0A) + Y); SetZN(A); TotalCycles += 5; PC = 0x8D5A;
                    return;
                case 0x8D59:
                    A = Asl(A); TotalCycles += 2; PC = 0x8D5A;
                    return;
                case 0x8D5C:
                    Bit(_ram[0x22]); TotalCycles += 3; PC = 0x8D5E;
                    goto case 0x8D5E;
                case 0x8D5E:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8D5F;
                    goto case 0x8D5F;
                case 0x8D5F:
                    { int a = 0x1624 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8D62;
                    goto case 0x8D62;
                case 0x8D60:
                    Bit(_ram[0x16]); TotalCycles += 3; PC = 0x8D62;
                    goto case 0x8D62;
                case 0x8D61:
                    { byte z = (byte)(0x0A + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8D63;
                    return;
                case 0x8D62:
                    A = Asl(A); TotalCycles += 2; PC = 0x8D63;
                    return;
                case 0x8D65:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8D66;
                    return;
                case 0x8D67:
                    TotalCycles += 7; PushU16(0x8D69); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D68:
                    A &= _ram[0x48]; SetZN(A); TotalCycles += 3; PC = 0x8D6A;
                    goto case 0x8D6A;
                case 0x8D69:
                    PushU8(A); TotalCycles += 3; PC = 0x8D6A;
                    goto case 0x8D6A;
                case 0x8D6A:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8D89; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8D6C; goto case 0x8D6C;
                case 0x8D6B:
                    A |= ReadMem(0x0A11 + X); SetZN(A); TotalCycles += 4; PC = 0x8D6E;
                    return;
                case 0x8D6C:
                    A |= ReadMem(ReadU16Zp(0x0A) + Y); SetZN(A); TotalCycles += 5; PC = 0x8D6E;
                    return;
                case 0x8D6D:
                    A = Asl(A); TotalCycles += 2; PC = 0x8D6E;
                    return;
                case 0x8D70:
                    Bit(_ram[0x22]); TotalCycles += 3; PC = 0x8D72;
                    goto case 0x8D72;
                case 0x8D72:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8D73;
                    goto case 0x8D73;
                case 0x8D73:
                    { int a = 0x1524 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8D76;
                    goto case 0x8D76;
                case 0x8D74:
                    Bit(_ram[0x15]); TotalCycles += 3; PC = 0x8D76;
                    goto case 0x8D76;
                case 0x8D75:
                    A |= _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0x8D77;
                    return;
                case 0x8D76:
                    { int a = 0x1012 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8D79;
                    return;
                case 0x8D78:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8D8C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8D8C; }
                    PC = 0x8D7A; return;
                case 0x8D7B:
                    TotalCycles += 7; PushU16(0x8D7D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8D7C:
                    A &= _ram[0xC5]; SetZN(A); TotalCycles += 3; PC = 0x8D7E;
                    goto case 0x8D7E;
                case 0x8D7D:
                    Cmp(A, _ram[0x16]); TotalCycles += 3; PC = 0x8D7F;
                    return;
                case 0x8D7E:
                    { byte z = (byte)(0x0B + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8D80;
                    goto case 0x8D80;
                case 0x8D80:
                    { int a = 0x241D + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8D83;
                    goto case 0x8D83;
                case 0x8D81:
                    A |= ReadMem(0x1824 + X); SetZN(A); TotalCycles += 4; PC = 0x8D84;
                    goto case 0x8D84;
                case 0x8D82:
                    Bit(_ram[0x18]); TotalCycles += 3; PC = 0x8D84;
                    goto case 0x8D84;
                case 0x8D83:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8D84;
                    goto case 0x8D84;
                case 0x8D84:
                    { int a = 0x241B + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8D87;
                    goto case 0x8D87;
                case 0x8D86:
                    Bit(_ram[0x19]); TotalCycles += 3; PC = 0x8D88;
                    return;
                case 0x8D87:
                    A |= ReadMem(0x121B + Y); SetZN(A); TotalCycles += 4; PC = 0x8D8A;
                    return;
                case 0x8D8C:
                    _ram[0x041C] = Asl(_ram[0x041C]); TotalCycles += 6; PC = 0x8D8F;
                    goto case 0x8D8F;
                case 0x8D8F:
                    Bit(_ram[0x12]); TotalCycles += 3; PC = 0x8D91;
                    return;
                case 0x8D92:
                    Bit(_ram[0x12]); TotalCycles += 3; PC = 0x8D94;
                    return;
                case 0x8D95:
                    _ram[0x05] = Rol(_ram[0x05]); TotalCycles += 5; PC = 0x8D97;
                    return;
                case 0x8D96:
                    A |= _ram[0x0F]; SetZN(A); TotalCycles += 3; PC = 0x8D98;
                    goto case 0x8D98;
                case 0x8D98:
                    A = Asl(A); TotalCycles += 2; PC = 0x8D99;
                    return;
                case 0x8D9A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8D9B;
                    goto case 0x8D9B;
                case 0x8D9B:
                    A |= ReadMem(0x0E11 + X); SetZN(A); TotalCycles += 4; PC = 0x8D9E;
                    return;
                case 0x8D9C:
                    A |= ReadMem(ReadU16Zp(0x0E) + Y); SetZN(A); TotalCycles += 5; PC = 0x8D9E;
                    return;
                case 0x8D9D:
                    { int a = 0x241B; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x8DA0;
                    return;
                case 0x8D9F:
                    Bit(_ram[0x0C]); TotalCycles += 3; PC = 0x8DA1;
                    goto case 0x8DA1;
                case 0x8DA1:
                    A = Asl(A); TotalCycles += 2; PC = 0x8DA2;
                    return;
                case 0x8DA3:
                    A |= ReadMem(0x0E15 + X); SetZN(A); TotalCycles += 4; PC = 0x8DA6;
                    return;
                case 0x8DA4:
                    A |= _ram[(byte)(0x0E + X)]; SetZN(A); TotalCycles += 4; PC = 0x8DA6;
                    return;
                case 0x8DA5:
                    _ram[0x002B] = Asl(_ram[0x002B]); TotalCycles += 6; PC = 0x8DA8;
                    goto case 0x8DA8;
                case 0x8DA7:
                    TotalCycles += 7; PushU16(0x8DA9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8DA8:
                    A &= _ram[0xA7]; SetZN(A); TotalCycles += 3; PC = 0x8DAA;
                    return;
                case 0x8DAC:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8DAD;
                    goto case 0x8DAD;
                case 0x8DAD:
                    { int a = 0x241B + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8DB0;
                    return;
                case 0x8DAF:
                    Bit(_ram[0x1A]); TotalCycles += 3; PC = 0x8DB1;
                    goto case 0x8DB1;
                case 0x8DB1:
                    { int a = 0x1C0E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8DB4;
                    goto case 0x8DB4;
                case 0x8DB2:
                    _ram[0x051C] = Asl(_ram[0x051C]); TotalCycles += 6; PC = 0x8DB5;
                    goto case 0x8DB5;
                case 0x8DB4:
                    A |= ReadMem(0x1224 + X); SetZN(A); TotalCycles += 4; PC = 0x8DB7;
                    return;
                case 0x8DB5:
                    Bit(_ram[0x12]); TotalCycles += 3; PC = 0x8DB7;
                    return;
                case 0x8DB8:
                    Bit(_ram[0x18]); TotalCycles += 3; PC = 0x8DBA;
                    return;
                case 0x8DB9:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8DBA;
                    return;
                case 0x8DBB:
                    { int a = 0xAF1B; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x8DBE;
                    goto case 0x8DBE;
                case 0x8DBE:
                    TotalCycles += 7; PushU16(0x8DC0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8DBF:
                    A &= _ram[0xE3]; SetZN(A); TotalCycles += 3; PC = 0x8DC1;
                    return;
                case 0x8DC2:
                    TotalCycles += 6; PushU16(0x8DC4); PC = 0x240E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8DC3:
                    _ram[0x0124] = Asl(_ram[0x0124]); TotalCycles += 6; PC = 0x8DC6;
                    return;
                case 0x8DC4:
                    Bit(_ram[0x19]); TotalCycles += 3; PC = 0x8DC6;
                    return;
                case 0x8DC5:
                    A |= ReadMem(0x0E1B + Y); SetZN(A); TotalCycles += 4; PC = 0x8DC8;
                    return;
                case 0x8DC7:
                    _ram[0x061C] = Asl(_ram[0x061C]); TotalCycles += 6; PC = 0x8DCA;
                    return;
                case 0x8DC9:
                    _ram[0x0517] = Asl(_ram[0x0517]); TotalCycles += 6; PC = 0x8DCC;
                    goto case 0x8DCC;
                case 0x8DCB:
                    A |= ReadMem(0x2224 + X); SetZN(A); TotalCycles += 4; PC = 0x8DCE;
                    goto case 0x8DCE;
                case 0x8DCC:
                    Bit(_ram[0x22]); TotalCycles += 3; PC = 0x8DCE;
                    goto case 0x8DCE;
                case 0x8DCE:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8DCF;
                    goto case 0x8DCF;
                case 0x8DCF:
                    { int a = 0x0A24 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8DD2;
                    goto case 0x8DD2;
                case 0x8DD0:
                    Bit(_ram[0x0A]); TotalCycles += 3; PC = 0x8DD2;
                    goto case 0x8DD2;
                case 0x8DD1:
                    A = Asl(A); TotalCycles += 2; PC = 0x8DD2;
                    goto case 0x8DD2;
                case 0x8DD2:
                    Bit(_ram[0x17]); TotalCycles += 3; PC = 0x8DD4;
                    goto case 0x8DD4;
                case 0x8DD4:
                    { int a = 0x2420; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x8DD7;
                    return;
                case 0x8DD5:
                    TotalCycles += 6; PushU16(0x8DD7); PC = 0x1A24;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8DD6:
                    Bit(_ram[0x1A]); TotalCycles += 3; PC = 0x8DD8;
                    goto case 0x8DD8;
                case 0x8DD8:
                    { int a = 0x1C0E + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8DDB;
                    goto case 0x8DDB;
                case 0x8DD9:
                    _ram[0x051C] = Asl(_ram[0x051C]); TotalCycles += 6; PC = 0x8DDC;
                    return;
                case 0x8DDB:
                    A |= _ram[(0x00AF + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8DDE;
                    goto case 0x8DDE;
                case 0x8DDD:
                    TotalCycles += 7; PushU16(0x8DDF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8DDE:
                    _ram[0x4A] = Rol(_ram[0x4A]); TotalCycles += 5; PC = 0x8DE0;
                    goto case 0x8DE0;
                case 0x8DDF:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8DE0;
                    goto case 0x8DE0;
                case 0x8DE0:
                    A |= _ram[0x0619]; SetZN(A); TotalCycles += 4; PC = 0x8DE3;
                    return;
                case 0x8DE1:
                    A |= ReadMem(0x1C1E + Y); SetZN(A); TotalCycles += 4; PC = 0x8DE4;
                    goto case 0x8DE4;
                case 0x8DE2:
                    { int a = 0x111C + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8DE5;
                    goto case 0x8DE5;
                case 0x8DE4:
                    A |= ReadMem(ReadU16Zp(0x24) + Y); SetZN(A); TotalCycles += 5; PC = 0x8DE6;
                    return;
                case 0x8DE5:
                    Bit(_ram[0x0B]); TotalCycles += 3; PC = 0x8DE7;
                    goto case 0x8DE7;
                case 0x8DE7:
                    { int a = 0x1D1D + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8DEA;
                    goto case 0x8DEA;
                case 0x8DE8:
                    A |= ReadMem(0x181D + X); SetZN(A); TotalCycles += 4; PC = 0x8DEB;
                    return;
                case 0x8DE9:
                    A |= ReadMem(0x1718 + X); SetZN(A); TotalCycles += 4; PC = 0x8DEC;
                    goto case 0x8DEC;
                case 0x8DEA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8DEB;
                    return;
                case 0x8DEC:
                    Bit(_ram[0x0B]); TotalCycles += 3; PC = 0x8DEE;
                    goto case 0x8DEE;
                case 0x8DEE:
                    TotalCycles += 7; PushU16(0x8DF0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8DEF:
                    _ram[0x88] = Rol(_ram[0x88]); TotalCycles += 5; PC = 0x8DF1;
                    goto case 0x8DF1;
                case 0x8DF0:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8DF1;
                    goto case 0x8DF1;
                case 0x8DF1:
                    A |= ReadMem(ReadU16Zp(0x1D) + Y); SetZN(A); TotalCycles += 5; PC = 0x8DF3;
                    goto case 0x8DF3;
                case 0x8DF2:
                    A |= ReadMem(0x2418 + X); SetZN(A); TotalCycles += 4; PC = 0x8DF5;
                    return;
                case 0x8DF3:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8DF4;
                    goto case 0x8DF4;
                case 0x8DF4:
                    Bit(_ram[0x1C]); TotalCycles += 3; PC = 0x8DF6;
                    goto case 0x8DF6;
                case 0x8DF6:
                    _ram[0x0615] = Asl(_ram[0x0615]); TotalCycles += 6; PC = 0x8DF9;
                    return;
                case 0x8DF7:
                    A |= _ram[(byte)(0x0E + X)]; SetZN(A); TotalCycles += 4; PC = 0x8DF9;
                    return;
                case 0x8DF8:
                    _ram[0x050C] = Asl(_ram[0x050C]); TotalCycles += 6; PC = 0x8DFB;
                    goto case 0x8DFB;
                case 0x8DFA:
                    A |= ReadMem(0x0A24 + X); SetZN(A); TotalCycles += 4; PC = 0x8DFD;
                    goto case 0x8DFD;
                case 0x8DFB:
                    Bit(_ram[0x0A]); TotalCycles += 3; PC = 0x8DFD;
                    goto case 0x8DFD;
                case 0x8DFC:
                    A = Asl(A); TotalCycles += 2; PC = 0x8DFD;
                    goto case 0x8DFD;
                case 0x8DFD:
                    Bit(_ram[0x20]); TotalCycles += 3; PC = 0x8DFF;
                    goto case 0x8DFF;
                case 0x8DFE:
                    TotalCycles += 6; PushU16(0x8E00); PC = 0x1B18;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8DFF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8E00;
                    return;
                case 0x8E01:
                    A |= _ram[(byte)(0x0D + X)]; SetZN(A); TotalCycles += 4; PC = 0x8E03;
                    goto case 0x8E03;
                case 0x8E02:
                    A |= _ram[0x0200]; SetZN(A); TotalCycles += 4; PC = 0x8E05;
                    goto case 0x8E05;
                case 0x8E03:
                    TotalCycles += 7; PushU16(0x8E05); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8E04: // === SUBROUTINE: JumpEngine ===
                    A = Asl(A); TotalCycles += 2; PC = 0x8E05;
                    goto case 0x8E05;
                case 0x8E05:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x8E06;
                    goto case 0x8E06;
                case 0x8E06:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8E07;
                    goto case 0x8E07;
                case 0x8E07:
                    _ram[0x04] = A; TotalCycles += 3; PC = 0x8E09;
                    goto case 0x8E09;
                case 0x8E09:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8E0A;
                    goto case 0x8E0A;
                case 0x8E0A:
                    _ram[0x05] = A; TotalCycles += 3; PC = 0x8E0C;
                    goto case 0x8E0C;
                case 0x8E0B:
                    A |= _ram[0xC8]; SetZN(A); TotalCycles += 3; PC = 0x8E0D;
                    goto case 0x8E0D;
                case 0x8E0C:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8E0D;
                    goto case 0x8E0D;
                case 0x8E0D:
                    A = ReadMem(ReadU16Zp(0x04) + Y); SetZN(A); TotalCycles += 5; PC = 0x8E0F;
                    goto case 0x8E0F;
                case 0x8E0F:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0x8E11;
                    goto case 0x8E11;
                case 0x8E10:
                    _ram[0xC8] = Asl(_ram[0xC8]); TotalCycles += 5; PC = 0x8E12;
                    goto case 0x8E12;
                case 0x8E11:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8E12;
                    goto case 0x8E12;
                case 0x8E12:
                    A = ReadMem(ReadU16Zp(0x04) + Y); SetZN(A); TotalCycles += 5; PC = 0x8E14;
                    goto case 0x8E14;
                case 0x8E14:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0x8E16;
                    goto case 0x8E16;
                case 0x8E16:
                    TotalCycles += 5; PC = ReadU16Zp(0x06); return;
                case 0x8E17:
                    _ram[0x00] = Asl(_ram[0x00]); TotalCycles += 5; PC = 0x8E19;
                    goto case 0x8E19;
                case 0x8E18:
                    TotalCycles += 7; PushU16(0x8E1A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8E19: // === SUBROUTINE: InitializeNameTables ===
                    A = ReadIoReg(0x2002); SetZN(A); TotalCycles += 4; PC = 0x8E1C;
                    goto case 0x8E1C;
                case 0x8E1B:
                    TotalCycles += 6; PushU16(0x8E1D); PC = 0x78AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8E1C:
                    A = _ram[0x0778]; SetZN(A); TotalCycles += 4; PC = 0x8E1F;
                    goto case 0x8E1F;
                case 0x8E1D:
                    P |= FlagI; TotalCycles += 2; PC = 0x8E1E;
                    return;
                case 0x8E1F:
                    A |= 0x10; SetZN(A); TotalCycles += 2; PC = 0x8E21;
                    goto case 0x8E21;
                case 0x8E20:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8E4B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8E4B; }
                    PC = 0x8E22; goto case 0x8E22;
                case 0x8E21:
                    A &= 0xF0; SetZN(A); TotalCycles += 2; PC = 0x8E23;
                    goto case 0x8E23;
                case 0x8E22:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8E44; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8E44; }
                    PC = 0x8E24; goto case 0x8E24;
                case 0x8E23:
                    TotalCycles += 6; PushU16(0x8E25); PC = 0x8EED;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8EED;
                case 0x8E24:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x298E]); TotalCycles += 4; PC = 0x8E27;
                    goto case 0x8E27;
                case 0x8E25:
                    WriteIoReg(0x24A9, X); TotalCycles += 4; PC = 0x8E28;
                    goto case 0x8E28;
                case 0x8E26:
                    A = 0x24; SetZN(A); TotalCycles += 2; PC = 0x8E28;
                    goto case 0x8E28;
                case 0x8E27:
                    Bit(_ram[0x20]); TotalCycles += 3; PC = 0x8E29;
                    goto case 0x8E29;
                case 0x8E28:
                    TotalCycles += 6; PushU16(0x8E2A); PC = 0x8E2D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E2D;
                case 0x8E29:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x298E]; SetZN(A); TotalCycles += 4; PC = 0x8E2C;
                    goto case 0x8E2C;
                case 0x8E2A:
                    WriteIoReg(0x20A9, X); TotalCycles += 4; PC = 0x8E2D;
                    goto case 0x8E2D;
                case 0x8E2B:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0x8E2D;
                    goto case 0x8E2D;
                case 0x8E2C:
                    TotalCycles += 6; PushU16(0x8E2E); PC = 0x068D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8E2D: // === SUBROUTINE: ClearNameTable ===
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x8E30;
                    goto case 0x8E30;
                case 0x8E2E:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x8E30;
                    goto case 0x8E30;
                case 0x8E2F:
                    TotalCycles += 6; PushU16(0x8E31); PC = 0x00A9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8E30:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8E32;
                    goto case 0x8E32;
                case 0x8E31:
                    TotalCycles += 7; PushU16(0x8E33); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8E32:
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x8E35;
                    goto case 0x8E35;
                case 0x8E33:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x8E35;
                    goto case 0x8E35;
                case 0x8E34:
                    TotalCycles += 6; PushU16(0x8E36); PC = 0x04A2;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8E35:
                    X = 0x04; SetZN(X); TotalCycles += 2; PC = 0x8E37;
                    goto case 0x8E37;
                case 0x8E37:
                    Y = 0xC0; SetZN(Y); TotalCycles += 2; PC = 0x8E39;
                    goto case 0x8E39;
                case 0x8E38:
                    Cmp(Y, 0xA9); TotalCycles += 2; PC = 0x8E3A;
                    goto case 0x8E3A;
                case 0x8E39:
                    A = 0x24; SetZN(A); TotalCycles += 2; PC = 0x8E3B;
                    goto case 0x8E3B;
                case 0x8E3A:
                    Bit(_ram[0x8D]); TotalCycles += 3; PC = 0x8E3C;
                    return;
                case 0x8E3B:
                    WriteIoReg(0x2007, A); TotalCycles += 4; PC = 0x8E3E;
                    goto case 0x8E3E;
                case 0x8E3D:
                    TotalCycles += 6; PushU16(0x8E3F); PC = 0xD088;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8E3E:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8E3F;
                    goto case 0x8E3F;
                case 0x8E3F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8E3B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8E3B; }
                    PC = 0x8E41; goto case 0x8E41;
                case 0x8E41:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8E42;
                    goto case 0x8E42;
                case 0x8E42:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8E3B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8E3B; }
                    PC = 0x8E44; goto case 0x8E44;
                case 0x8E44:
                    Y = 0x40; SetZN(Y); TotalCycles += 2; PC = 0x8E46;
                    goto case 0x8E46;
                case 0x8E45:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8E46:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x8E47;
                    goto case 0x8E47;
                case 0x8E47:
                    _ram[0x0300] = A; TotalCycles += 4; PC = 0x8E4A;
                    goto case 0x8E4A;
                case 0x8E48:
                    TotalCycles += 7; PushU16(0x8E4A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8E4A:
                    _ram[0x0301] = A; TotalCycles += 4; PC = 0x8E4D;
                    goto case 0x8E4D;
                case 0x8E4B:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x8E4D;
                    goto case 0x8E4D;
                case 0x8E4D:
                    WriteIoReg(0x2007, A); TotalCycles += 4; PC = 0x8E50;
                    goto case 0x8E50;
                case 0x8E4F:
                    TotalCycles += 6; PushU16(0x8E51); PC = 0xD088;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8E50:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8E51;
                    goto case 0x8E51;
                case 0x8E51:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8E4D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8E4D; }
                    PC = 0x8E53; goto case 0x8E53;
                case 0x8E53:
                    _ram[0x073F] = A; TotalCycles += 4; PC = 0x8E56;
                    goto case 0x8E56;
                case 0x8E56:
                    _ram[0x0740] = A; TotalCycles += 4; PC = 0x8E59;
                    goto case 0x8E59;
                case 0x8E57:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8E59:
                    TotalCycles += 3; PC = 0x8EE6;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8EE6;
                case 0x8E5A:
                    _ram[0x8E] = IncVal(_ram[0x8E]); TotalCycles += 5; PC = 0x8E5C;
                    goto case 0x8E5C;
                case 0x8E5B:
                    _ram[0x01A9] = X; TotalCycles += 4; PC = 0x8E5E;
                    goto case 0x8E5E;
                case 0x8E5C: // === SUBROUTINE: WritePPUReg1 ===
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x8E5E;
                    goto case 0x8E5E;
                case 0x8E5D:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x8E5F;
                    goto case 0x8E5F;
                case 0x8E5E:
                    WriteIoReg(0x4016, A); TotalCycles += 4; PC = 0x8E61;
                    goto case 0x8E61;
                case 0x8E5F:
                    { byte z = (byte)(0x40 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8E61;
                    goto case 0x8E61;
                case 0x8E60:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8E61:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8E62;
                    goto case 0x8E62;
                case 0x8E62:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x8E63;
                    goto case 0x8E63;
                case 0x8E63:
                    WriteIoReg(0x4016, A); TotalCycles += 4; PC = 0x8E66;
                    goto case 0x8E66;
                case 0x8E64:
                    { byte z = (byte)(0x40 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8E66;
                    goto case 0x8E66;
                case 0x8E65:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8E66:
                    TotalCycles += 6; PushU16(0x8E68); PC = 0x8E6A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E6A;
                case 0x8E67:
                    A = Ror(A); TotalCycles += 2; PC = 0x8E68;
                    goto case 0x8E68;
                case 0x8E68:
                    WriteIoReg(0xA0E8, X); TotalCycles += 4; PC = 0x8E6B;
                    goto case 0x8E6B;
                case 0x8E69:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8E6A;
                    goto case 0x8E6A;
                case 0x8E6A: // === SUBROUTINE: PrintStatusBar ===
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0x8E6C;
                    goto case 0x8E6C;
                case 0x8E6B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x8E6C;
                    goto case 0x8E6C;
                case 0x8E6C:
                    PushU8(A); TotalCycles += 3; PC = 0x8E6D;
                    goto case 0x8E6D;
                case 0x8E6D:
                    A = ReadMem(0x4016 + X); SetZN(A); TotalCycles += 4; PC = 0x8E70;
                    goto case 0x8E70;
                case 0x8E6E:
                    { byte z = (byte)(0x40 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8E70;
                    goto case 0x8E70;
                case 0x8E6F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x8E70:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x8E72;
                    goto case 0x8E72;
                case 0x8E71:
                    TotalCycles += 7; PushU16(0x8E73); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8E72:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8E73;
                    goto case 0x8E73;
                case 0x8E73:
                    A |= _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x8E75;
                    goto case 0x8E75;
                case 0x8E74:
                    TotalCycles += 7; PushU16(0x8E76); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8E75:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8E76;
                    goto case 0x8E76;
                case 0x8E76:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8E77;
                    goto case 0x8E77;
                case 0x8E77:
                    A = Rol(A); TotalCycles += 2; PC = 0x8E78;
                    goto case 0x8E78;
                case 0x8E78:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8E79;
                    goto case 0x8E79;
                case 0x8E79:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8E6C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8E6C; }
                    PC = 0x8E7B; goto case 0x8E7B;
                case 0x8E7A:
                    Sbc(ReadMem(ReadU16Zp(0x9D) + Y)); TotalCycles += 5; PC = 0x8E7C;
                    return;
                case 0x8E7B:
                    _ram[(0x06FC + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8E7E;
                    goto case 0x8E7E;
                case 0x8E7D:
                    _ram[0x48] = Asl(_ram[0x48]); TotalCycles += 5; PC = 0x8E7F;
                    goto case 0x8E7F;
                case 0x8E7E:
                    PushU8(A); TotalCycles += 3; PC = 0x8E7F;
                    goto case 0x8E7F;
                case 0x8E7F:
                    A &= 0x30; SetZN(A); TotalCycles += 2; PC = 0x8E81;
                    goto case 0x8E81;
                case 0x8E80:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8EBF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8EBF; }
                    PC = 0x8E82; goto case 0x8E82;
                case 0x8E81:
                    A &= _ram[(0x074A + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8E84;
                    goto case 0x8E84;
                case 0x8E82:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8E83;
                    return;
                case 0x8E84:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8E8D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8E8D; }
                    PC = 0x8E86; goto case 0x8E86;
                case 0x8E86:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8E87;
                    goto case 0x8E87;
                case 0x8E87:
                    A &= 0xCF; SetZN(A); TotalCycles += 2; PC = 0x8E89;
                    goto case 0x8E89;
                case 0x8E89:
                    _ram[(0x06FC + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8E8C;
                    goto case 0x8E8C;
                case 0x8E8B:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x8E8D;
                    goto case 0x8E8D;
                case 0x8E8C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8E8D:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8E8E;
                    goto case 0x8E8E;
                case 0x8E8E:
                    _ram[(0x074A + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8E91;
                    goto case 0x8E91;
                case 0x8E8F:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8E90;
                    return;
                case 0x8E91:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8E92:
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x8E95;
                    goto case 0x8E95;
                case 0x8E93:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x8E95;
                    goto case 0x8E95;
                case 0x8E94:
                    TotalCycles += 6; PushU16(0x8E96); PC = 0xB1C8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8E95:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8E96;
                    goto case 0x8E96;
                case 0x8E96:
                    A = ReadMem(ReadU16Zp(0x00) + Y); SetZN(A); TotalCycles += 5; PC = 0x8E98;
                    goto case 0x8E98;
                case 0x8E97:
                    TotalCycles += 7; PushU16(0x8E99); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8E98:
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x8E9B;
                    goto case 0x8E9B;
                case 0x8E99:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x8E9B;
                    goto case 0x8E9B;
                case 0x8E9A:
                    TotalCycles += 6; PushU16(0x8E9C); PC = 0xB1C8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8E9B:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8E9C;
                    goto case 0x8E9C;
                case 0x8E9C:
                    A = ReadMem(ReadU16Zp(0x00) + Y); SetZN(A); TotalCycles += 5; PC = 0x8E9E;
                    goto case 0x8E9E;
                case 0x8E9D:
                    TotalCycles += 7; PushU16(0x8E9F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8E9E:
                    A = Asl(A); TotalCycles += 2; PC = 0x8E9F;
                    goto case 0x8E9F;
                case 0x8E9F:
                    PushU8(A); TotalCycles += 3; PC = 0x8EA0;
                    goto case 0x8EA0;
                case 0x8EA0:
                    A = _ram[0x0778]; SetZN(A); TotalCycles += 4; PC = 0x8EA3;
                    goto case 0x8EA3;
                case 0x8EA1:
                    P |= FlagI; TotalCycles += 2; PC = 0x8EA2;
                    return;
                case 0x8EA3:
                    A |= 0x04; SetZN(A); TotalCycles += 2; PC = 0x8EA5;
                    goto case 0x8EA5;
                case 0x8EA5:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8EA9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8EA9; }
                    PC = 0x8EA7; goto case 0x8EA7;
                case 0x8EA7:
                    A &= 0xFB; SetZN(A); TotalCycles += 2; PC = 0x8EA9;
                    goto case 0x8EA9;
                case 0x8EA9:
                    TotalCycles += 6; PushU16(0x8EAB); PC = 0x8EED;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8EED;
                case 0x8EAA:
                    Sbc(ReadIoReg(0x688E)); TotalCycles += 4; PC = 0x8EAD;
                    goto case 0x8EAD;
                case 0x8EAB:
                    _ram[0x0268] = X; TotalCycles += 4; PC = 0x8EAE;
                    goto case 0x8EAE;
                case 0x8EAC:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8EAD;
                    goto case 0x8EAD;
                case 0x8EAD:
                    A = Asl(A); TotalCycles += 2; PC = 0x8EAE;
                    goto case 0x8EAE;
                case 0x8EAE:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8EB3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8EB3; }
                    PC = 0x8EB0; goto case 0x8EB0;
                case 0x8EB0:
                    A |= 0x02; SetZN(A); TotalCycles += 2; PC = 0x8EB2;
                    goto case 0x8EB2;
                case 0x8EB2:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8EB3;
                    goto case 0x8EB3;
                case 0x8EB3:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8EB4;
                    goto case 0x8EB4;
                case 0x8EB4:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8EB5;
                    goto case 0x8EB5;
                case 0x8EB5:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x8EB6;
                    goto case 0x8EB6;
                case 0x8EB6:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8EB9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8EB9; }
                    PC = 0x8EB8; goto case 0x8EB8;
                case 0x8EB7:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0x8EB9;
                    goto case 0x8EB9;
                case 0x8EB8:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8EB9;
                    goto case 0x8EB9;
                case 0x8EB9:
                    A = ReadMem(ReadU16Zp(0x00) + Y); SetZN(A); TotalCycles += 5; PC = 0x8EBB;
                    goto case 0x8EBB;
                case 0x8EBA:
                    TotalCycles += 7; PushU16(0x8EBC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8EBB:
                    WriteIoReg(0x2007, A); TotalCycles += 4; PC = 0x8EBE;
                    goto case 0x8EBE;
                case 0x8EBD:
                    TotalCycles += 6; PushU16(0x8EBF); PC = 0xD0CA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8EBE:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8EBF;
                    goto case 0x8EBF;
                case 0x8EBF:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8EB6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8EB6; }
                    PC = 0x8EC1; goto case 0x8EC1;
                case 0x8EC0:
                    Sbc(_ram[(byte)(0x38 + X)]); TotalCycles += 4; PC = 0x8EC2;
                    goto case 0x8EC2;
                case 0x8EC1:
                    P |= FlagC; TotalCycles += 2; PC = 0x8EC2;
                    goto case 0x8EC2;
                case 0x8EC2:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x8EC3;
                    goto case 0x8EC3;
                case 0x8EC3:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0x8EC5;
                    goto case 0x8EC5;
                case 0x8EC4:
                    TotalCycles += 7; PushU16(0x8EC6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8EC5:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x8EC7;
                    goto case 0x8EC7;
                case 0x8EC6:
                    TotalCycles += 7; PushU16(0x8EC8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8EC7:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8EC9;
                    goto case 0x8EC9;
                case 0x8EC8:
                    TotalCycles += 7; PushU16(0x8ECA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8EC9:
                    Adc(_ram[0x01]); TotalCycles += 3; PC = 0x8ECB;
                    goto case 0x8ECB;
                case 0x8ECA:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0x8ECC;
                    goto case 0x8ECC;
                case 0x8ECB:
                    _ram[0x01] = A; TotalCycles += 3; PC = 0x8ECD;
                    goto case 0x8ECD;
                case 0x8ECC:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0x8ECE;
                    return;
                case 0x8ECD:
                    A = 0x3F; SetZN(A); TotalCycles += 2; PC = 0x8ECF;
                    goto case 0x8ECF;
                case 0x8ECF:
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x8ED2;
                    goto case 0x8ED2;
                case 0x8ED0:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x8ED2;
                    goto case 0x8ED2;
                case 0x8ED1:
                    TotalCycles += 6; PushU16(0x8ED3); PC = 0x00A9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8ED2:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8ED4;
                    goto case 0x8ED4;
                case 0x8ED3:
                    TotalCycles += 7; PushU16(0x8ED5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8ED4:
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x8ED7;
                    goto case 0x8ED7;
                case 0x8ED5:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x8ED7;
                    goto case 0x8ED7;
                case 0x8ED6:
                    TotalCycles += 6; PushU16(0x8ED8); PC = 0x068D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8ED7:
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x8EDA;
                    goto case 0x8EDA;
                case 0x8ED8:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x8EDA;
                    goto case 0x8EDA;
                case 0x8ED9:
                    TotalCycles += 6; PushU16(0x8EDB); PC = 0x068D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8EDA:
                    WriteIoReg(0x2006, A); TotalCycles += 4; PC = 0x8EDD;
                    goto case 0x8EDD;
                case 0x8EDB:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x8EDD;
                    goto case 0x8EDD;
                case 0x8EDC:
                    TotalCycles += 6; PushU16(0x8EDE); PC = 0x02AE;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8EDD: // === SUBROUTINE: UpdateScreen ===
                    X = ReadIoReg(0x2002); SetZN(X); TotalCycles += 4; PC = 0x8EE0;
                    goto case 0x8EE0;
                case 0x8EDF:
                    TotalCycles += 6; PushU16(0x8EE1); PC = 0x00A0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8EE0:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x8EE2;
                    goto case 0x8EE2;
                case 0x8EE1:
                    TotalCycles += 7; PushU16(0x8EE3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8EE2:
                    A = ReadMem(ReadU16Zp(0x00) + Y); SetZN(A); TotalCycles += 5; PC = 0x8EE4;
                    goto case 0x8EE4;
                case 0x8EE3:
                    TotalCycles += 7; PushU16(0x8EE5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8EE4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8E92; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8E92; }
                    PC = 0x8EE6; goto case 0x8EE6;
                case 0x8EE5:
                    Y = _ram[0x058D]; SetZN(Y); TotalCycles += 4; PC = 0x8EE8;
                    goto case 0x8EE8;
                case 0x8EE6: // === SUBROUTINE: WriteBufferToScreen ===
                    WriteIoReg(0x2005, A); TotalCycles += 4; PC = 0x8EE9;
                    goto case 0x8EE9;
                case 0x8EE7:
                    A |= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0x8EE9;
                    goto case 0x8EE9;
                case 0x8EE8:
                    TotalCycles += 6; PushU16(0x8EEA); PC = 0x058D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8EE9:
                    WriteIoReg(0x2005, A); TotalCycles += 4; PC = 0x8EEC;
                    goto case 0x8EEC;
                case 0x8EEA:
                    A |= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0x8EEC;
                    goto case 0x8EEC;
                case 0x8EEB:
                    TotalCycles += 6; PushU16(0x8EED); PC = 0x8D60;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8D60;
                case 0x8EEC:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8EED: // === SUBROUTINE: FUN_8eed ===
                    WriteIoReg(0x2000, A); TotalCycles += 4; PC = 0x8EF0;
                    goto case 0x8EF0;
                case 0x8EEE:
                    TotalCycles += 7; PushU16(0x8EF0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8EEF:
                    TotalCycles += 6; PushU16(0x8EF1); PC = 0x788D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8EF0:
                    _ram[0x0778] = A; TotalCycles += 4; PC = 0x8EF3;
                    goto case 0x8EF3;
                case 0x8EF1:
                    P |= FlagI; TotalCycles += 2; PC = 0x8EF2;
                    return;
                case 0x8EF3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8EF4:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8EFC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8EFC; }
                    PC = 0x8EF6; return;
                case 0x8EF5:
                    _ram[0x62] = Asl(_ram[0x62]); TotalCycles += 5; PC = 0x8EF7;
                    goto case 0x8EF7;
                case 0x8EF7:
                    _ram[0x62] = Asl(_ram[0x62]); TotalCycles += 5; PC = 0x8EF9;
                    goto case 0x8EF9;
                case 0x8EF9:
                    _ram[0x6D] = Asl(_ram[0x6D]); TotalCycles += 5; PC = 0x8EFB;
                    return;
                case 0x8EFA:
                    Adc(ReadIoReg(0x6D02)); TotalCycles += 4; PC = 0x8EFD;
                    return;
                case 0x8EFC:
                    Adc(ReadIoReg(0x7A02)); TotalCycles += 4; PC = 0x8EFF;
                    return;
                case 0x8F00:
                    _ram[0x0C] = Asl(_ram[0x0C]); TotalCycles += 5; PC = 0x8F02;
                    return;
                case 0x8F03:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8F04;
                    goto case 0x8F04;
                case 0x8F04:
                    { int a = 0x8524 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x8F07;
                    goto case 0x8F07;
                case 0x8F05:
                    Bit(_ram[0x85]); TotalCycles += 3; PC = 0x8F07;
                    goto case 0x8F07;
                case 0x8F06: // === SUBROUTINE: Sub_8F06 ===
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x8F08;
                    goto case 0x8F08;
                case 0x8F07:
                    TotalCycles += 7; PushU16(0x8F09); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8F08:
                    TotalCycles += 6; PushU16(0x8F0A); PC = 0x8F11;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8F11;
                case 0x8F09:
                    A |= ReadMem(ReadU16Zp(0x8F) + Y); SetZN(A); TotalCycles += 5; PC = 0x8F0B;
                    goto case 0x8F0B;
                case 0x8F0B:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x8F0D;
                    goto case 0x8F0D;
                case 0x8F0C:
                    TotalCycles += 7; PushU16(0x8F0E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8F0D:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8F0E;
                    goto case 0x8F0E;
                case 0x8F0E:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8F0F;
                    goto case 0x8F0F;
                case 0x8F0F:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8F10;
                    goto case 0x8F10;
                case 0x8F10:
                    A = Lsr(A); TotalCycles += 2; PC = 0x8F11;
                    goto case 0x8F11;
                case 0x8F11: // === SUBROUTINE: Sub_8F11 ===
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8F12;
                    goto case 0x8F12;
                case 0x8F12:
                    Adc(0x01); TotalCycles += 2; PC = 0x8F14;
                    goto case 0x8F14;
                case 0x8F13:
                    A |= ReadMem(ReadU16Zp((byte)(0x29 + X))); SetZN(A); TotalCycles += 6; PC = 0x8F15;
                    return;
                case 0x8F14:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x8F16;
                    goto case 0x8F16;
                case 0x8F16:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0x8F18;
                    goto case 0x8F18;
                case 0x8F17:
                    _ram[0xB0] = Asl(_ram[0xB0]); TotalCycles += 5; PC = 0x8F19;
                    return;
                case 0x8F18:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8F5E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F5E; }
                    PC = 0x8F1A; goto case 0x8F1A;
                case 0x8F1A:
                    PushU8(A); TotalCycles += 3; PC = 0x8F1B;
                    goto case 0x8F1B;
                case 0x8F1B:
                    A = Asl(A); TotalCycles += 2; PC = 0x8F1C;
                    goto case 0x8F1C;
                case 0x8F1C:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x8F1D;
                    goto case 0x8F1D;
                case 0x8F1D:
                    X = _ram[0x0300]; SetZN(X); TotalCycles += 4; PC = 0x8F20;
                    goto case 0x8F20;
                case 0x8F1E:
                    TotalCycles += 7; PushU16(0x8F20); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8F20:
                    A = 0x20; SetZN(A); TotalCycles += 2; PC = 0x8F22;
                    goto case 0x8F22;
                case 0x8F21:
                    TotalCycles += 6; PushU16(0x8F23); PC = 0x00C0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x8F22:
                    Cmp(Y, 0x00); TotalCycles += 2; PC = 0x8F24;
                    goto case 0x8F24;
                case 0x8F23:
                    TotalCycles += 7; PushU16(0x8F25); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8F24:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8F28; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F28; }
                    PC = 0x8F26; goto case 0x8F26;
                case 0x8F26:
                    A = 0x22; SetZN(A); TotalCycles += 2; PC = 0x8F28;
                    goto case 0x8F28;
                case 0x8F28:
                    _ram[(0x0301 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8F2B;
                    goto case 0x8F2B;
                case 0x8F29:
                    A |= ReadMem(ReadU16Zp((byte)(0x03 + X))); SetZN(A); TotalCycles += 6; PC = 0x8F2B;
                    goto case 0x8F2B;
                case 0x8F2B:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0EF4 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8F2E;
                    goto case 0x8F2E;
                case 0x8F2D:
                    _ram[0x029D] = X; TotalCycles += 4; PC = 0x8F30;
                    return;
                case 0x8F2E:
                    _ram[(0x0302 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8F31;
                    goto case 0x8F31;
                case 0x8F31:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0EF5 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8F34;
                    goto case 0x8F34;
                case 0x8F32:
                    Sbc(_ram[(byte)(0x8E + X)]); TotalCycles += 4; PC = 0x8F34;
                    goto case 0x8F34;
                case 0x8F33:
                    _ram[0x039D] = X; TotalCycles += 4; PC = 0x8F36;
                    return;
                case 0x8F34:
                    _ram[(0x0303 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8F37;
                    goto case 0x8F37;
                case 0x8F37:
                    _ram[0x03] = A; TotalCycles += 3; PC = 0x8F39;
                    goto case 0x8F39;
                case 0x8F39:
                    _ram[0x02] = X; TotalCycles += 3; PC = 0x8F3B;
                    goto case 0x8F3B;
                case 0x8F3B:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x8F3C;
                    goto case 0x8F3C;
                case 0x8F3C:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x8F3D;
                    goto case 0x8F3D;
                case 0x8F3D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0F00 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8F40;
                    goto case 0x8F40;
                case 0x8F3E:
                    TotalCycles += 7; PushU16(0x8F40); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8F40:
                    P |= FlagC; TotalCycles += 2; PC = 0x8F41;
                    goto case 0x8F41;
                case 0x8F41:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x0EF5 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x8F44;
                    goto case 0x8F44;
                case 0x8F42:
                    Sbc(_ram[(byte)(0x8E + X)]); TotalCycles += 4; PC = 0x8F44;
                    goto case 0x8F44;
                case 0x8F43:
                    WriteIoReg(0xA6A8, X); TotalCycles += 4; PC = 0x8F46;
                    return;
                case 0x8F44:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x8F45;
                    goto case 0x8F45;
                case 0x8F45:
                    X = _ram[0x02]; SetZN(X); TotalCycles += 3; PC = 0x8F47;
                    goto case 0x8F47;
                case 0x8F47: // === SUBROUTINE: DrawTitleScreen ===
                    A = _ram[(0x07D7 + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8F4A;
                    goto case 0x8F4A;
                case 0x8F4A:
                    _ram[(0x0304 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8F4D;
                    goto case 0x8F4D;
                case 0x8F4D:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8F4E;
                    goto case 0x8F4E;
                case 0x8F4E:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8F4F;
                    goto case 0x8F4F;
                case 0x8F4F:
                    _ram[0x03] = DecVal(_ram[0x03]); TotalCycles += 5; PC = 0x8F51;
                    goto case 0x8F51;
                case 0x8F51:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8F47; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F47; }
                    PC = 0x8F53; goto case 0x8F53;
                case 0x8F53:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8F55;
                    goto case 0x8F55;
                case 0x8F54:
                    TotalCycles += 7; PushU16(0x8F56); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8F55:
                    _ram[(0x0304 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8F58;
                    goto case 0x8F58;
                case 0x8F58:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8F59;
                    goto case 0x8F59;
                case 0x8F59:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8F5A;
                    goto case 0x8F5A;
                case 0x8F5A:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8F5B;
                    goto case 0x8F5B;
                case 0x8F5B:
                    _ram[0x0300] = X; TotalCycles += 4; PC = 0x8F5E;
                    goto case 0x8F5E;
                case 0x8F5C:
                    TotalCycles += 7; PushU16(0x8F5E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8F5E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8F5F: // === SUBROUTINE: Sub_8F5F ===
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0x8F62;
                    goto case 0x8F62;
                case 0x8F60:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x8F69; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8F62; goto case 0x8F62;
                case 0x8F62:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0x8F64;
                    goto case 0x8F64;
                case 0x8F63:
                    TotalCycles += 7; PushU16(0x8F65); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8F64:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8F7C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F7C; }
                    PC = 0x8F66; goto case 0x8F66;
                case 0x8F65:
                    { byte z = (byte)(0xA2 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8F67;
                    goto case 0x8F67;
                case 0x8F66:
                    X = 0x05; SetZN(X); TotalCycles += 2; PC = 0x8F68;
                    goto case 0x8F68;
                case 0x8F67:
                    A |= _ram[0xBD]; SetZN(A); TotalCycles += 3; PC = 0x8F69;
                    return;
                case 0x8F68:
                    A = _ram[(0x0134 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8F6B;
                    goto case 0x8F6B;
                case 0x8F6A:
                    A |= ReadMem(ReadU16Zp((byte)(0x18 + X))); SetZN(A); TotalCycles += 6; PC = 0x8F6C;
                    goto case 0x8F6C;
                case 0x8F6B:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8F6C;
                    goto case 0x8F6C;
                case 0x8F6C:
                    Adc(_ram[(0x07D7 + Y) & 0x07FF]); TotalCycles += 4; PC = 0x8F6F;
                    goto case 0x8F6F;
                case 0x8F6F:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x8F87; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F87; }
                    PC = 0x8F71; goto case 0x8F71;
                case 0x8F70:
                    { byte z = (byte)(0xC9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x8F72;
                    goto case 0x8F72;
                case 0x8F71:
                    Cmp(A, 0x0A); TotalCycles += 2; PC = 0x8F73;
                    goto case 0x8F73;
                case 0x8F72:
                    A = Asl(A); TotalCycles += 2; PC = 0x8F73;
                    goto case 0x8F73;
                case 0x8F73:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8F8E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F8E; }
                    PC = 0x8F75; goto case 0x8F75;
                case 0x8F74:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x5799 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x8F77;
                    return;
                case 0x8F75:
                    _ram[(0x07D7 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8F78;
                    goto case 0x8F78;
                case 0x8F78:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8F79;
                    goto case 0x8F79;
                case 0x8F79:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8F7A;
                    goto case 0x8F7A;
                case 0x8F7A:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8F68; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F68; }
                    PC = 0x8F7C; goto case 0x8F7C;
                case 0x8F7B:
                    Cmp(X, _ram[0x00A9]); TotalCycles += 4; PC = 0x8F7E;
                    goto case 0x8F7E;
                case 0x8F7C:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8F7E;
                    goto case 0x8F7E;
                case 0x8F7D:
                    TotalCycles += 7; PushU16(0x8F7F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8F7E:
                    X = 0x06; SetZN(X); TotalCycles += 2; PC = 0x8F80;
                    goto case 0x8F80;
                case 0x8F7F:
                    _ram[0x9D] = Asl(_ram[0x9D]); TotalCycles += 5; PC = 0x8F81;
                    return;
                case 0x8F80:
                    _ram[(0x0133 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8F83;
                    goto case 0x8F83;
                case 0x8F82:
                    A |= ReadMem(ReadU16Zp((byte)(0xCA + X))); SetZN(A); TotalCycles += 6; PC = 0x8F84;
                    goto case 0x8F84;
                case 0x8F83:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8F84;
                    goto case 0x8F84;
                case 0x8F84:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8F80; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F80; }
                    PC = 0x8F86; goto case 0x8F86;
                case 0x8F86:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8F87:
                    { int a = (0x0133 + X) & 0x07FF; _ram[a] = DecVal(_ram[a]); } TotalCycles += 7; PC = 0x8F8A;
                    goto case 0x8F8A;
                case 0x8F89:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0x8F8B;
                    goto case 0x8F8B;
                case 0x8F8A:
                    A = 0x09; SetZN(A); TotalCycles += 2; PC = 0x8F8C;
                    goto case 0x8F8C;
                case 0x8F8B:
                    A |= 0xD0; SetZN(A); TotalCycles += 2; PC = 0x8F8D;
                    return;
                case 0x8F8C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x8F75; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F75; }
                    PC = 0x8F8E; goto case 0x8F8E;
                case 0x8F8E:
                    P |= FlagC; TotalCycles += 2; PC = 0x8F8F;
                    goto case 0x8F8F;
                case 0x8F8F:
                    Sbc(0x0A); TotalCycles += 2; PC = 0x8F91;
                    goto case 0x8F91;
                case 0x8F90:
                    A = Asl(A); TotalCycles += 2; PC = 0x8F91;
                    goto case 0x8F91;
                case 0x8F91:
                    { int a = (0x0133 + X) & 0x07FF; _ram[a] = IncVal(_ram[a]); } TotalCycles += 7; PC = 0x8F94;
                    goto case 0x8F94;
                case 0x8F93:
                    A |= ReadMem(ReadU16Zp((byte)(0x4C + X))); SetZN(A); TotalCycles += 6; PC = 0x8F95;
                    goto case 0x8F95;
                case 0x8F94:
                    TotalCycles += 3; PC = 0x8F75;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8F75;
                case 0x8F95:
                    Adc(_ram[(byte)(0x8F + X)]); TotalCycles += 4; PC = 0x8F97;
                    goto case 0x8F97;
                case 0x8F97: // === SUBROUTINE: ClearMemory ===
                    X = 0x05; SetZN(X); TotalCycles += 2; PC = 0x8F99;
                    goto case 0x8F99;
                case 0x8F98:
                    A |= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0x8F9A;
                    return;
                case 0x8F99:
                    TotalCycles += 6; PushU16(0x8F9B); PC = 0x8F9E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8F9E;
                case 0x8F9C:
                    X = 0x0B; SetZN(X); TotalCycles += 2; PC = 0x8F9E;
                    goto case 0x8F9E;
                case 0x8F9E: // === SUBROUTINE: ClearMemLoop ===
                    Y = 0x05; SetZN(Y); TotalCycles += 2; PC = 0x8FA0;
                    goto case 0x8FA0;
                case 0x8F9F:
                    A |= _ram[0x38]; SetZN(A); TotalCycles += 3; PC = 0x8FA1;
                    goto case 0x8FA1;
                case 0x8FA0:
                    P |= FlagC; TotalCycles += 2; PC = 0x8FA1;
                    goto case 0x8FA1;
                case 0x8FA1:
                    A = _ram[(0x07DD + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8FA4;
                    goto case 0x8FA4;
                case 0x8FA2:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x7907 + X) & 0x7FFF]); TotalCycles += 4; PC = 0x8FA5;
                    return;
                case 0x8FA4:
                    Sbc(_ram[(0x07D7 + Y) & 0x07FF]); TotalCycles += 4; PC = 0x8FA7;
                    goto case 0x8FA7;
                case 0x8FA7:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8FA8;
                    goto case 0x8FA8;
                case 0x8FA8:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8FA9;
                    goto case 0x8FA9;
                case 0x8FA9:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8FA1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8FA1; }
                    PC = 0x8FAB; goto case 0x8FAB;
                case 0x8FAA:
                    { byte z = (byte)(0x90 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0x8FAC;
                    goto case 0x8FAC;
                case 0x8FAB:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8FBB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8FBB; }
                    PC = 0x8FAD; goto case 0x8FAD;
                case 0x8FAC:
                    { int a = 0xC8E8; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x8FAF;
                    goto case 0x8FAF;
                case 0x8FAD:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8FAE;
                    goto case 0x8FAE;
                case 0x8FAE:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8FAF;
                    goto case 0x8FAF;
                case 0x8FAF:
                    A = _ram[(0x07DD + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x8FB2;
                    goto case 0x8FB2;
                case 0x8FB0:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x1907 + X) & 0x7FFF]); TotalCycles += 4; PC = 0x8FB3;
                    return;
                case 0x8FB2:
                    _ram[(0x07D7 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8FB5;
                    goto case 0x8FB5;
                case 0x8FB5:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8FB6;
                    goto case 0x8FB6;
                case 0x8FB6:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x8FB7;
                    goto case 0x8FB7;
                case 0x8FB7:
                    Cmp(Y, 0x06); TotalCycles += 2; PC = 0x8FB9;
                    goto case 0x8FB9;
                case 0x8FB8:
                    _ram[0x90] = Asl(_ram[0x90]); TotalCycles += 5; PC = 0x8FBA;
                    return;
                case 0x8FB9:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8FAF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8FAF; }
                    PC = 0x8FBB; goto case 0x8FBB;
                case 0x8FBB:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8FBD:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9007; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9007; }
                    PC = 0x8FBF; goto case 0x8FBF;
                case 0x8FBE:
                    PushU8(A); TotalCycles += 3; PC = 0x8FBF;
                    goto case 0x8FBF;
                case 0x8FBF:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x8FC0:
                    P |= FlagI; TotalCycles += 2; PC = 0x8FC1;
                    goto case 0x8FC1;
                case 0x8FC1:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8F6B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F6B; }
                    PC = 0x8FC3; goto case 0x8FC3;
                case 0x8FC2:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x8FC3;
                    goto case 0x8FC3;
                case 0x8FC3:
                    Cmp(Y, 0xD8); TotalCycles += 2; PC = 0x8FC5;
                    goto case 0x8FC5;
                case 0x8FC4:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0x8FC5;
                    goto case 0x8FC5;
                case 0x8FC5:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x8FC6;
                    goto case 0x8FC6;
                case 0x8FC6:
                    Bit(_ram[0xF8]); TotalCycles += 3; PC = 0x8FC8;
                    return;
                case 0x8FC7:
                    P |= FlagD; TotalCycles += 2; PC = 0x8FC8;
                    return;
                case 0x8FC9:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x8FCA;
                    goto case 0x8FCA;
                case 0x8FCA:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x7F18]); TotalCycles += 4; PC = 0x8FCD;
                    return;
                case 0x8FCB:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8FCC;
                    return;
                case 0x8FCE:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0x8FCF;
                    goto case 0x8FCF;
                case 0x8FCF:
                    Y = 0x6F; SetZN(Y); TotalCycles += 2; PC = 0x8FD1;
                    goto case 0x8FD1;
                case 0x8FD1:
                    TotalCycles += 6; PushU16(0x8FD3); PC = 0x90CC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x90CC;
                case 0x8FD2:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x2090]); TotalCycles += 4; PC = 0x8FD5;
                    return;
                case 0x8FD3:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8F75; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F75; }
                    PC = 0x8FD5; return;
                case 0x8FD4:
                    Y = 0x1F; SetZN(Y); TotalCycles += 2; PC = 0x8FD6;
                    goto case 0x8FD6;
                case 0x8FD6:
                    _ram[(0x07B0 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x8FD9;
                    goto case 0x8FD9;
                case 0x8FD7:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8FE0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x8FD9; goto case 0x8FD9;
                case 0x8FD9:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x8FDA;
                    goto case 0x8FDA;
                case 0x8FDA:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8FD6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8FD6; }
                    PC = 0x8FDC; goto case 0x8FDC;
                case 0x8FDC:
                    A = 0x18; SetZN(A); TotalCycles += 2; PC = 0x8FDE;
                    goto case 0x8FDE;
                case 0x8FDD:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x8FDE;
                    goto case 0x8FDE;
                case 0x8FDE:
                    _ram[0x07A2] = A; TotalCycles += 4; PC = 0x8FE1;
                    goto case 0x8FE1;
                case 0x8FDF:
                    X = 0x07; SetZN(X); TotalCycles += 2; PC = 0x8FE1;
                    goto case 0x8FE1;
                case 0x8FE1:
                    TotalCycles += 6; PushU16(0x8FE3); PC = 0x9C03;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9C03;
                case 0x8FE4:
                    Y = 0x4B; SetZN(Y); TotalCycles += 2; PC = 0x8FE6;
                    goto case 0x8FE6;
                case 0x8FE6:
                    TotalCycles += 6; PushU16(0x8FE8); PC = 0x90CC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x90CC;
                case 0x8FE7:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x2290]); TotalCycles += 4; PC = 0x8FEA;
                    goto case 0x8FEA;
                case 0x8FE8:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x8F8C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8F8C; }
                    PC = 0x8FEA; goto case 0x8FEA;
                case 0x8FE9:
                    X = 0x21; SetZN(X); TotalCycles += 2; PC = 0x8FEB;
                    goto case 0x8FEB;
                case 0x8FEA:
                    A &= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0x8FEC;
                    goto case 0x8FEC;
                case 0x8FEB:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x8FED;
                    goto case 0x8FED;
                case 0x8FEC:
                    TotalCycles += 7; PushU16(0x8FEE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x8FED:
                    _ram[(0x0780 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x8FF0;
                    goto case 0x8FF0;
                case 0x8FF0:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x8FF1;
                    goto case 0x8FF1;
                case 0x8FF1:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8FED; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8FED; }
                    PC = 0x8FF3; goto case 0x8FF3;
                case 0x8FF3:
                    A = _ram[0x075B]; SetZN(A); TotalCycles += 4; PC = 0x8FF6;
                    goto case 0x8FF6;
                case 0x8FF6:
                    Y = _ram[0x0752]; SetZN(Y); TotalCycles += 4; PC = 0x8FF9;
                    goto case 0x8FF9;
                case 0x8FF9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x8FFE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8FFE; }
                    PC = 0x8FFB; goto case 0x8FFB;
                case 0x8FFB:
                    A = _ram[0x0751]; SetZN(A); TotalCycles += 4; PC = 0x8FFE;
                    goto case 0x8FFE;
                case 0x8FFC:
                    A ^= ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0x8FFE;
                    goto case 0x8FFE;
                case 0x8FFE:
                    _ram[0x071A] = A; TotalCycles += 4; PC = 0x9001;
                    goto case 0x9001;
                case 0x9001:
                    _ram[0x0725] = A; TotalCycles += 4; PC = 0x9004;
                    goto case 0x9004;
                case 0x9002:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9004;
                    goto case 0x9004;
                case 0x9004:
                    _ram[0x0728] = A; TotalCycles += 4; PC = 0x9007;
                    goto case 0x9007;
                case 0x9005:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9006;
                    return;
                case 0x9007:
                    TotalCycles += 6; PushU16(0x9009); PC = 0xB038;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9008:
                    P |= FlagC; TotalCycles += 2; PC = 0x9009;
                    goto case 0x9009;
                case 0x9009:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x8FAB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x8FAB; }
                    PC = 0x900B; goto case 0x900B;
                case 0x900A:
                    Y = 0x20; SetZN(Y); TotalCycles += 2; PC = 0x900C;
                    goto case 0x900C;
                case 0x900B:
                    TotalCycles += 6; PushU16(0x900D); PC = 0x0129;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x900C:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0x900E;
                    goto case 0x900E;
                case 0x900D:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0x900F;
                    return;
                case 0x900E:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9012; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9012; }
                    PC = 0x9010; goto case 0x9010;
                case 0x9010:
                    Y = 0x24; SetZN(Y); TotalCycles += 2; PC = 0x9012;
                    goto case 0x9012;
                case 0x9011:
                    Bit(_ram[0x8C]); TotalCycles += 3; PC = 0x9013;
                    goto case 0x9013;
                case 0x9012:
                    _ram[0x0720] = Y; TotalCycles += 4; PC = 0x9015;
                    goto case 0x9015;
                case 0x9013:
                    TotalCycles += 6; PushU16(0x9015); PC = 0xA007;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9015:
                    Y = 0x80; SetZN(Y); TotalCycles += 2; PC = 0x9017;
                    goto case 0x9017;
                case 0x9017:
                    _ram[0x0721] = Y; TotalCycles += 4; PC = 0x901A;
                    goto case 0x901A;
                case 0x9018:
                    A &= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x901A;
                    goto case 0x901A;
                case 0x901A:
                    A = Asl(A); TotalCycles += 2; PC = 0x901B;
                    goto case 0x901B;
                case 0x901B:
                    A = Asl(A); TotalCycles += 2; PC = 0x901C;
                    goto case 0x901C;
                case 0x901C:
                    A = Asl(A); TotalCycles += 2; PC = 0x901D;
                    goto case 0x901D;
                case 0x901D:
                    A = Asl(A); TotalCycles += 2; PC = 0x901E;
                    goto case 0x901E;
                case 0x901E:
                    _ram[0x06A0] = A; TotalCycles += 4; PC = 0x9021;
                    goto case 0x9021;
                case 0x901F:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0x9021;
                    goto case 0x9021;
                case 0x9020:
                    _ram[0xCE] = Asl(_ram[0xCE]); TotalCycles += 5; PC = 0x9022;
                    goto case 0x9022;
                case 0x9021:
                    _ram[0x0730] = DecVal(_ram[0x0730]); TotalCycles += 6; PC = 0x9024;
                    goto case 0x9024;
                case 0x9022:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x902B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9024; goto case 0x9024;
                case 0x9024:
                    _ram[0x0731] = DecVal(_ram[0x0731]); TotalCycles += 6; PC = 0x9027;
                    goto case 0x9027;
                case 0x9025:
                    A &= ReadMem(ReadU16Zp(0x07) + Y); SetZN(A); TotalCycles += 5; PC = 0x9027;
                    goto case 0x9027;
                case 0x9027:
                    _ram[0x0732] = DecVal(_ram[0x0732]); TotalCycles += 6; PC = 0x902A;
                    goto case 0x902A;
                case 0x902A:
                    A = 0x0B; SetZN(A); TotalCycles += 2; PC = 0x902C;
                    goto case 0x902C;
                case 0x902C:
                    _ram[0x071E] = A; TotalCycles += 4; PC = 0x902F;
                    goto case 0x902F;
                case 0x902D:
                    { int a = 0x2007 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x9030;
                    return;
                case 0x902F:
                    TotalCycles += 6; PushU16(0x9031); PC = 0x9C22;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9C22;
                case 0x9032:
                    A = _ram[0x076A]; SetZN(A); TotalCycles += 4; PC = 0x9035;
                    goto case 0x9035;
                case 0x9033:
                    A = Ror(A); TotalCycles += 2; PC = 0x9034;
                    return;
                case 0x9035:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9047; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9047; }
                    PC = 0x9037; goto case 0x9037;
                case 0x9036:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x8FE5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9038; return;
                case 0x9037:
                    A = _ram[0x075F]; SetZN(A); TotalCycles += 4; PC = 0x903A;
                    goto case 0x903A;
                case 0x903A:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0x903C;
                    goto case 0x903C;
                case 0x903C:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x904A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x904A; }
                    PC = 0x903E; goto case 0x903E;
                case 0x903E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9047; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9047; }
                    PC = 0x9040; goto case 0x9040;
                case 0x9040:
                    A = _ram[0x075C]; SetZN(A); TotalCycles += 4; PC = 0x9043;
                    goto case 0x9043;
                case 0x9043:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0x9045;
                    goto case 0x9045;
                case 0x9045:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x904A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x904A; }
                    PC = 0x9047; goto case 0x9047;
                case 0x9047:
                    _ram[0x06CC] = IncVal(_ram[0x06CC]); TotalCycles += 6; PC = 0x904A;
                    goto case 0x904A;
                case 0x9048:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x2D06]); TotalCycles += 4; PC = 0x904B;
                    return;
                case 0x9049:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0x904B;
                    return;
                case 0x904A:
                    A = _ram[0x075B]; SetZN(A); TotalCycles += 4; PC = 0x904D;
                    goto case 0x904D;
                case 0x904D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9054; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9054; }
                    PC = 0x904F; goto case 0x904F;
                case 0x904E:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0x9050;
                    return;
                case 0x904F:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0x9051;
                    goto case 0x9051;
                case 0x9051:
                    _ram[0x0710] = A; TotalCycles += 4; PC = 0x9054;
                    goto case 0x9054;
                case 0x9052:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x905B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9054; goto case 0x9054;
                case 0x9054:
                    A = 0x80; SetZN(A); TotalCycles += 2; PC = 0x9056;
                    goto case 0x9056;
                case 0x9056:
                    _ram[0xFB] = A; TotalCycles += 3; PC = 0x9058;
                    goto case 0x9058;
                case 0x9058:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x905A;
                    goto case 0x905A;
                case 0x9059:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x905B;
                    return;
                case 0x905A:
                    _ram[0x0774] = A; TotalCycles += 4; PC = 0x905D;
                    goto case 0x905D;
                case 0x905D:
                    _ram[0x0772] = IncVal(_ram[0x0772]); TotalCycles += 6; PC = 0x9060;
                    goto case 0x9060;
                case 0x9060:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9061: // === SUBROUTINE: TranscribeAttributes ===
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x9063;
                    goto case 0x9063;
                case 0x9062:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x9064;
                    return;
                case 0x9063:
                    _ram[0x0757] = A; TotalCycles += 4; PC = 0x9066;
                    goto case 0x9066;
                case 0x9066:
                    _ram[0x0754] = A; TotalCycles += 4; PC = 0x9069;
                    goto case 0x9069;
                case 0x9069:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0x906B;
                    goto case 0x906B;
                case 0x906B:
                    _ram[0x075A] = A; TotalCycles += 4; PC = 0x906E;
                    goto case 0x906E;
                case 0x906E:
                    _ram[0x0761] = A; TotalCycles += 4; PC = 0x9071;
                    goto case 0x9071;
                case 0x906F:
                    Adc(ReadMem(ReadU16Zp((byte)(0x07 + X)))); TotalCycles += 6; PC = 0x9071;
                    goto case 0x9071;
                case 0x9071:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9073;
                    goto case 0x9073;
                case 0x9072:
                    TotalCycles += 7; PushU16(0x9074); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9073:
                    _ram[0x0774] = A; TotalCycles += 4; PC = 0x9076;
                    goto case 0x9076;
                case 0x9076:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9077;
                    goto case 0x9077;
                case 0x9077:
                    _ram[(0x0300 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x907A;
                    goto case 0x907A;
                case 0x9078:
                    TotalCycles += 7; PushU16(0x907A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x907A:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x907B;
                    goto case 0x907B;
                case 0x907B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9077; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9077; }
                    PC = 0x907D; goto case 0x907D;
                case 0x907D:
                    _ram[0x0759] = A; TotalCycles += 4; PC = 0x9080;
                    goto case 0x9080;
                case 0x907E:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x0D07 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9081;
                    goto case 0x9081;
                case 0x9080:
                    _ram[0x0769] = A; TotalCycles += 4; PC = 0x9083;
                    goto case 0x9083;
                case 0x9081:
                    Adc(0x07); TotalCycles += 2; PC = 0x9083;
                    goto case 0x9083;
                case 0x9083:
                    _ram[0x0728] = A; TotalCycles += 4; PC = 0x9086;
                    goto case 0x9086;
                case 0x9084:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9085;
                    return;
                case 0x9086:
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0x9088;
                    goto case 0x9088;
                case 0x9088:
                    _ram[0x03A0] = A; TotalCycles += 4; PC = 0x908B;
                    goto case 0x908B;
                case 0x9089:
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0x908B;
                    goto case 0x908B;
                case 0x908B:
                    A = _ram[0x071A]; SetZN(A); TotalCycles += 4; PC = 0x908E;
                    goto case 0x908E;
                case 0x908E:
                    _ram[0x0778] = Lsr(_ram[0x0778]); TotalCycles += 6; PC = 0x9091;
                    goto case 0x9091;
                case 0x908F:
                    P |= FlagI; TotalCycles += 2; PC = 0x9090;
                    return;
                case 0x9091:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0x9093;
                    goto case 0x9093;
                case 0x9092:
                    A |= ReadMem(ReadU16Zp((byte)(0x6A + X))); SetZN(A); TotalCycles += 6; PC = 0x9094;
                    goto case 0x9094;
                case 0x9093:
                    A = Ror(A); TotalCycles += 2; PC = 0x9094;
                    goto case 0x9094;
                case 0x9094:
                    _ram[0x0778] = Rol(_ram[0x0778]); TotalCycles += 6; PC = 0x9097;
                    goto case 0x9097;
                case 0x9095:
                    P |= FlagI; TotalCycles += 2; PC = 0x9096;
                    return;
                case 0x9097:
                    TotalCycles += 6; PushU16(0x9099); PC = 0x90ED;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x90ED;
                case 0x9098:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[0x2990]); TotalCycles += 4; PC = 0x909B;
                    goto case 0x909B;
                case 0x9099:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9044; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x909B; goto case 0x909B;
                case 0x909A:
                    A = 0x38; SetZN(A); TotalCycles += 2; PC = 0x909C;
                    goto case 0x909C;
                case 0x909B:
                    P |= FlagC; TotalCycles += 2; PC = 0x909C;
                    goto case 0x909C;
                case 0x909C:
                    _ram[0x06E3] = A; TotalCycles += 4; PC = 0x909F;
                    goto case 0x909F;
                case 0x909E:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0x90A0;
                    goto case 0x90A0;
                case 0x909F:
                    A = 0x48; SetZN(A); TotalCycles += 2; PC = 0x90A1;
                    goto case 0x90A1;
                case 0x90A0:
                    PushU8(A); TotalCycles += 3; PC = 0x90A1;
                    goto case 0x90A1;
                case 0x90A1:
                    _ram[0x06E2] = A; TotalCycles += 4; PC = 0x90A4;
                    goto case 0x90A4;
                case 0x90A3:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0x90A5;
                    goto case 0x90A5;
                case 0x90A4:
                    A = 0x58; SetZN(A); TotalCycles += 2; PC = 0x90A6;
                    goto case 0x90A6;
                case 0x90A5:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0x90A6;
                    goto case 0x90A6;
                case 0x90A6:
                    _ram[0x06E1] = A; TotalCycles += 4; PC = 0x90A9;
                    goto case 0x90A9;
                case 0x90A7:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x06 + X)))); TotalCycles += 6; PC = 0x90A9;
                    goto case 0x90A9;
                case 0x90A8:
                    _ram[0xA2] = Asl(_ram[0xA2]); TotalCycles += 5; PC = 0x90AA;
                    goto case 0x90AA;
                case 0x90A9:
                    X = 0x0E; SetZN(X); TotalCycles += 2; PC = 0x90AB;
                    goto case 0x90AB;
                case 0x90AA:
                    { int a = 0xBCBD; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x90AD;
                    return;
                case 0x90AB:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0FBC + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x90AE;
                    goto case 0x90AE;
                case 0x90AC:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x1D8F + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0x90AF;
                    goto case 0x90AF;
                case 0x90AE:
                    _ram[(0x06E4 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x90B1;
                    goto case 0x90B1;
                case 0x90AF:
                    Cmp(X, _ram[0x06]); TotalCycles += 3; PC = 0x90B1;
                    goto case 0x90B1;
                case 0x90B0:
                    _ram[0xCA] = Asl(_ram[0xCA]); TotalCycles += 5; PC = 0x90B2;
                    goto case 0x90B2;
                case 0x90B1:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x90B2;
                    goto case 0x90B2;
                case 0x90B2:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x90AB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x90AB; }
                    PC = 0x90B4; goto case 0x90B4;
                case 0x90B4:
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0x90B6;
                    goto case 0x90B6;
                case 0x90B6:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x0FCB + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x90B9;
                    goto case 0x90B9;
                case 0x90B9:
                    _ram[(0x0200 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x90BC;
                    goto case 0x90BC;
                case 0x90BA:
                    TotalCycles += 7; PushU16(0x90BC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x90BC:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x90BD;
                    goto case 0x90BD;
                case 0x90BD:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x90B6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x90B6; }
                    PC = 0x90BF; goto case 0x90BF;
                case 0x90BF:
                    TotalCycles += 6; PushU16(0x90C1); PC = 0x92AF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x92AF;
                case 0x90C2:
                    TotalCycles += 6; PushU16(0x90C4); PC = 0x92AA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x92AA;
                case 0x90C3:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x90C4;
                    return;
                case 0x90C5:
                    _ram[0x0722] = IncVal(_ram[0x0722]); TotalCycles += 6; PC = 0x90C8;
                    goto case 0x90C8;
                case 0x90C8:
                    _ram[0x0772] = IncVal(_ram[0x0772]); TotalCycles += 6; PC = 0x90CB;
                    goto case 0x90CB;
                case 0x90CB:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x90CC: // === SUBROUTINE: ReadJoypads ===
                    X = 0x07; SetZN(X); TotalCycles += 2; PC = 0x90CE;
                    goto case 0x90CE;
                case 0x90CE:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x90D0;
                    goto case 0x90D0;
                case 0x90CF:
                    TotalCycles += 7; PushU16(0x90D1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x90D0:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0x90D2;
                    goto case 0x90D2;
                case 0x90D1:
                    _ram[0x86] = Asl(_ram[0x86]); TotalCycles += 5; PC = 0x90D3;
                    return;
                case 0x90D2:
                    _ram[0x07] = X; TotalCycles += 3; PC = 0x90D4;
                    goto case 0x90D4;
                case 0x90D4:
                    Cmp(X, 0x01); TotalCycles += 2; PC = 0x90D6;
                    goto case 0x90D6;
                case 0x90D5:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0x90D7;
                    return;
                case 0x90D6:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x90DC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x90DC; }
                    PC = 0x90D8; goto case 0x90D8;
                case 0x90D8:
                    Cmp(Y, 0x60); TotalCycles += 2; PC = 0x90DA;
                    goto case 0x90DA;
                case 0x90D9:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x90DA:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x90DE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x90DE; }
                    PC = 0x90DC; goto case 0x90DC;
                case 0x90DC: // === SUBROUTINE: ReadPortBits ===
                    WriteMem(ReadU16Zp(0x06) + Y, A); TotalCycles += 6; PC = 0x90DE;
                    goto case 0x90DE;
                case 0x90DD:
                    _ram[0x88] = Asl(_ram[0x88]); TotalCycles += 5; PC = 0x90DF;
                    goto case 0x90DF;
                case 0x90DE:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x90DF;
                    goto case 0x90DF;
                case 0x90DF:
                    Cmp(Y, 0xFF); TotalCycles += 2; PC = 0x90E1;
                    goto case 0x90E1;
                case 0x90E1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x90D4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x90D4; }
                    PC = 0x90E3; goto case 0x90E3;
                case 0x90E2:
                    Sbc(ReadMem(ReadU16Zp(0xCA) + Y)); TotalCycles += 5; PC = 0x90E4;
                    goto case 0x90E4;
                case 0x90E3:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x90E4;
                    goto case 0x90E4;
                case 0x90E4:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x90D2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x90D2; }
                    PC = 0x90E6; goto case 0x90E6;
                case 0x90E5:
                    Cmp(X, _ram[0x0260]); TotalCycles += 4; PC = 0x90E8;
                    goto case 0x90E8;
                case 0x90E6:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x90E8:
                    A |= ReadMem(ReadU16Zp((byte)(0x04 + X))); SetZN(A); TotalCycles += 6; PC = 0x90EA;
                    goto case 0x90EA;
                case 0x90EA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x90EB;
                    goto case 0x90EB;
                case 0x90EB:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x910D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x90ED; goto case 0x90ED;
                case 0x90EC:
                    TotalCycles += 6; PushU16(0x90EE); PC = 0x70AD;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x90ED: // === SUBROUTINE: Sub_90ED ===
                    A = _ram[0x0770]; SetZN(A); TotalCycles += 4; PC = 0x90F0;
                    goto case 0x90F0;
                case 0x90EE:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x90F7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x90F7; }
                    PC = 0x90F0; goto case 0x90F0;
                case 0x90F0:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9115; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9115; }
                    PC = 0x90F2; goto case 0x90F2;
                case 0x90F2:
                    A = _ram[0x0752]; SetZN(A); TotalCycles += 4; PC = 0x90F5;
                    goto case 0x90F5;
                case 0x90F5:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0x90F7;
                    goto case 0x90F7;
                case 0x90F7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9106; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9106; }
                    PC = 0x90F9; goto case 0x90F9;
                case 0x90F8:
                    A |= _ram[0x05A0]; SetZN(A); TotalCycles += 4; PC = 0x90FB;
                    goto case 0x90FB;
                case 0x90F9:
                    Y = 0x05; SetZN(Y); TotalCycles += 2; PC = 0x90FB;
                    goto case 0x90FB;
                case 0x90FA:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0x90FC;
                    goto case 0x90FC;
                case 0x90FB:
                    A = _ram[0x0710]; SetZN(A); TotalCycles += 4; PC = 0x90FE;
                    goto case 0x90FE;
                case 0x90FC:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9105; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9105; }
                    PC = 0x90FE; goto case 0x90FE;
                case 0x90FE:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0x9100;
                    goto case 0x9100;
                case 0x90FF:
                    _ram[0xF0] = Asl(_ram[0xF0]); TotalCycles += 5; PC = 0x9101;
                    goto case 0x9101;
                case 0x9100:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9110; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9110; }
                    PC = 0x9102; goto case 0x9102;
                case 0x9101:
                    _ram[0x07C9] = Asl(_ram[0x07C9]); TotalCycles += 6; PC = 0x9104;
                    goto case 0x9104;
                case 0x9102:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0x9104;
                    goto case 0x9104;
                case 0x9104:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9110; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9110; }
                    PC = 0x9106; goto case 0x9106;
                case 0x9105:
                    A = Asl(A); TotalCycles += 2; PC = 0x9106;
                    goto case 0x9106;
                case 0x9106:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x9109;
                    goto case 0x9109;
                case 0x9107:
                    { int a = 0xAD07; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x910A;
                    return;
                case 0x9109:
                    A = _ram[0x0743]; SetZN(A); TotalCycles += 4; PC = 0x910C;
                    goto case 0x910C;
                case 0x910C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9110; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9110; }
                    PC = 0x910E; goto case 0x910E;
                case 0x910E:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0x9110;
                    goto case 0x9110;
                case 0x9110:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x10E7 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9113;
                    goto case 0x9113;
                case 0x9112:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9099; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9099; }
                    PC = 0x9114; return;
                case 0x9113:
                    _ram[0xFB] = A; TotalCycles += 3; PC = 0x9115;
                    goto case 0x9115;
                case 0x9115:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9116:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9117;
                    goto case 0x9117;
                case 0x9117:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9118;
                    goto case 0x9118;
                case 0x9118:
                    P |= FlagC; TotalCycles += 2; PC = 0x9119;
                    goto case 0x9119;
                case 0x9119:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x911A;
                    goto case 0x911A;
                case 0x911A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x911B;
                    goto case 0x911B;
                case 0x911B:
                    TotalCycles += 7; PushU16(0x911D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x911C:
                    TotalCycles += 7; PushU16(0x911E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x911D:
                    TotalCycles += 6; PushU16(0x911F); PC = 0x50B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x911E:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x9170; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9170; }
                    PC = 0x9120; goto case 0x9120;
                case 0x911F:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x9121; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9121; }
                    PC = 0x9121; goto case 0x9121;
                case 0x9120:
                    TotalCycles += 7; PushU16(0x9122); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9121:
                    TotalCycles += 7; PushU16(0x9123); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9122:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x90D4; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x90D4; }
                    PC = 0x9124; goto case 0x9124;
                case 0x9123:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x9115; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9115; }
                    PC = 0x9125; goto case 0x9125;
                case 0x9124:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9126; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9126; }
                    PC = 0x9126; goto case 0x9126;
                case 0x9125:
                    TotalCycles += 7; PushU16(0x9127); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9126:
                    TotalCycles += 6; PushU16(0x9128); PC = 0x0000;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9127:
                    TotalCycles += 7; PushU16(0x9129); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9128:
                    TotalCycles += 7; PushU16(0x912A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9129:
                    TotalCycles += 7; PushU16(0x912B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x912A:
                    TotalCycles += 7; PushU16(0x912C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x912B:
                    TotalCycles += 7; PushU16(0x912D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x912C:
                    TotalCycles += 7; PushU16(0x912E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x912D:
                    TotalCycles += 6; PushU16(0x912F); PC = 0x0304;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9131:
                    A = _ram[0x071A]; SetZN(A); TotalCycles += 4; PC = 0x9134;
                    goto case 0x9134;
                case 0x9134:
                    _ram[0x6D] = A; TotalCycles += 3; PC = 0x9136;
                    goto case 0x9136;
                case 0x9135:
                    Adc(ReadIoReg(0x28A9)); TotalCycles += 4; PC = 0x9138;
                    goto case 0x9138;
                case 0x9136:
                    A = 0x28; SetZN(A); TotalCycles += 2; PC = 0x9138;
                    goto case 0x9138;
                case 0x9137:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9138;
                    goto case 0x9138;
                case 0x9138:
                    _ram[0x070A] = A; TotalCycles += 4; PC = 0x913B;
                    goto case 0x913B;
                case 0x9139:
                    A = Asl(A); TotalCycles += 2; PC = 0x913A;
                    return;
                case 0x913B:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x913D;
                    goto case 0x913D;
                case 0x913C:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0x913E;
                    return;
                case 0x913D:
                    _ram[0x33] = A; TotalCycles += 3; PC = 0x913F;
                    goto case 0x913F;
                case 0x913F:
                    _ram[0xB5] = A; TotalCycles += 3; PC = 0x9141;
                    goto case 0x9141;
                case 0x9140:
                    A = _ram[(byte)(0xA9 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9142;
                    goto case 0x9142;
                case 0x9141:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9143;
                    goto case 0x9143;
                case 0x9142:
                    TotalCycles += 7; PushU16(0x9144); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9143:
                    _ram[0x1D] = A; TotalCycles += 3; PC = 0x9145;
                    goto case 0x9145;
                case 0x9144:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x10CE + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9147;
                    return;
                case 0x9145:
                    _ram[0x0490] = DecVal(_ram[0x0490]); TotalCycles += 6; PC = 0x9148;
                    goto case 0x9148;
                case 0x9146:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x914C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9148; goto case 0x9148;
                case 0x9148:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x914A;
                    goto case 0x914A;
                case 0x9149:
                    TotalCycles += 7; PushU16(0x914B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x914A:
                    _ram[0x075B] = Y; TotalCycles += 4; PC = 0x914D;
                    goto case 0x914D;
                case 0x914D:
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0x9150;
                    goto case 0x9150;
                case 0x914E:
                    { int a = 0xD007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9151;
                    goto case 0x9151;
                case 0x9150:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9153; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9153; }
                    PC = 0x9152; goto case 0x9152;
                case 0x9151:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0x9153;
                    goto case 0x9153;
                case 0x9152:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9153;
                    goto case 0x9153;
                case 0x9153:
                    _ram[0x0704] = Y; TotalCycles += 4; PC = 0x9156;
                    goto case 0x9156;
                case 0x9156:
                    X = _ram[0x0710]; SetZN(X); TotalCycles += 4; PC = 0x9159;
                    goto case 0x9159;
                case 0x9157:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9160; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9160; }
                    PC = 0x9159; goto case 0x9159;
                case 0x9159:
                    Y = _ram[0x0752]; SetZN(Y); TotalCycles += 4; PC = 0x915C;
                    goto case 0x915C;
                case 0x915C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9165; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9165; }
                    PC = 0x915E; goto case 0x915E;
                case 0x915E:
                    Cmp(Y, 0x01); TotalCycles += 2; PC = 0x9160;
                    goto case 0x9160;
                case 0x915F:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0x9161;
                    return;
                case 0x9160:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9165; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9165; }
                    PC = 0x9162; goto case 0x9162;
                case 0x9162:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x1118 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0x9165;
                    goto case 0x9165;
                case 0x9163:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9164;
                    goto case 0x9164;
                case 0x9164:
                    WriteMem(ReadU16Zp(0xB9) + Y, A); TotalCycles += 6; PC = 0x9166;
                    goto case 0x9166;
                case 0x9165:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1116 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9168;
                    goto case 0x9168;
                case 0x9166:
                    { byte z = (byte)(0x91 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x9168;
                    goto case 0x9168;
                case 0x9167:
                    WriteMem(ReadU16Zp(0x85) + Y, A); TotalCycles += 6; PC = 0x9169;
                    goto case 0x9169;
                case 0x9168:
                    _ram[0x86] = A; TotalCycles += 3; PC = 0x916A;
                    goto case 0x916A;
                case 0x9169:
                    _ram[0xBD] = X; TotalCycles += 3; PC = 0x916B;
                    return;
                case 0x916A:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x111C + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x916D;
                    goto case 0x916D;
                case 0x916C:
                    WriteMem(ReadU16Zp(0x85) + Y, A); TotalCycles += 6; PC = 0x916E;
                    goto case 0x916E;
                case 0x916D:
                    _ram[0xCE] = A; TotalCycles += 3; PC = 0x916F;
                    goto case 0x916F;
                case 0x916E:
                    { int a = 0x25BD; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0x9171;
                    goto case 0x9171;
                case 0x916F:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1125 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9172;
                    goto case 0x9172;
                case 0x9170:
                    A &= _ram[0x91]; SetZN(A); TotalCycles += 3; PC = 0x9172;
                    goto case 0x9172;
                case 0x9171:
                    WriteMem(ReadU16Zp(0x8D) + Y, A); TotalCycles += 6; PC = 0x9173;
                    goto case 0x9173;
                case 0x9172:
                    _ram[0x03C4] = A; TotalCycles += 4; PC = 0x9175;
                    goto case 0x9175;
                case 0x9173:
                    Cmp(Y, _ram[0x03]); TotalCycles += 3; PC = 0x9175;
                    goto case 0x9175;
                case 0x9175:
                    TotalCycles += 6; PushU16(0x9177); PC = 0x85F1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x85F1;
                case 0x9176:
                    Sbc(ReadMem(ReadU16Zp(0x85) + Y)); TotalCycles += 5; PC = 0x9178;
                    goto case 0x9178;
                case 0x9177:
                    _ram[0xAC] = A; TotalCycles += 3; PC = 0x9179;
                    goto case 0x9179;
                case 0x9178:
                    Y = _ram[0x0715]; SetZN(Y); TotalCycles += 4; PC = 0x917B;
                    goto case 0x917B;
                case 0x9179:
                    A |= _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0x917B;
                    goto case 0x917B;
                case 0x917B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9197; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9197; }
                    PC = 0x917D; goto case 0x917D;
                case 0x917D:
                    A = _ram[0x0757]; SetZN(A); TotalCycles += 4; PC = 0x9180;
                    goto case 0x9180;
                case 0x9180:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9197; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9197; }
                    PC = 0x9182; goto case 0x9182;
                case 0x9181:
                    A |= _ram[(byte)(0xB9 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9183;
                    goto case 0x9183;
                case 0x9182:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x112D + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9185;
                    goto case 0x9185;
                case 0x9183:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x0D91]; SetZN(A); TotalCycles += 4; PC = 0x9186;
                    goto case 0x9186;
                case 0x9184:
                    WriteMem(ReadU16Zp(0x8D) + Y, A); TotalCycles += 6; PC = 0x9186;
                    goto case 0x9186;
                case 0x9185:
                    _ram[0x07F8] = A; TotalCycles += 4; PC = 0x9188;
                    goto case 0x9188;
                case 0x9186:
                    P |= FlagD; TotalCycles += 2; PC = 0x9187;
                    return;
                case 0x9188:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x918A;
                    goto case 0x918A;
                case 0x9189:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x918B;
                    return;
                case 0x918A:
                    _ram[0x07FA] = A; TotalCycles += 4; PC = 0x918D;
                    goto case 0x918D;
                case 0x918D:
                    A = Lsr(A); TotalCycles += 2; PC = 0x918E;
                    goto case 0x918E;
                case 0x918E:
                    _ram[0x07F9] = A; TotalCycles += 4; PC = 0x9191;
                    goto case 0x9191;
                case 0x918F:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x0D07 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x9192;
                    return;
                case 0x9191:
                    _ram[0x0757] = A; TotalCycles += 4; PC = 0x9194;
                    goto case 0x9194;
                case 0x9194:
                    _ram[0x079F] = A; TotalCycles += 4; PC = 0x9197;
                    goto case 0x9197;
                case 0x9197:
                    Y = _ram[0x0758]; SetZN(Y); TotalCycles += 4; PC = 0x919A;
                    goto case 0x919A;
                case 0x9198:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0x9199;
                    return;
                case 0x919A:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x91B0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x91B0; }
                    PC = 0x919C; goto case 0x919C;
                case 0x919C:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x919E;
                    goto case 0x919E;
                case 0x919E:
                    _ram[0x1D] = A; TotalCycles += 3; PC = 0x91A0;
                    goto case 0x91A0;
                case 0x919F:
                    A |= _ram[(0x00A2 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x91A2;
                    goto case 0x91A2;
                case 0x91A0:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x91A2;
                    goto case 0x91A2;
                case 0x91A1:
                    TotalCycles += 7; PushU16(0x91A3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x91A2:
                    TotalCycles += 6; PushU16(0x91A4); PC = 0xBD84;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x91A3:
                    _ram[0xBD] = Y; TotalCycles += 3; PC = 0x91A5;
                    goto case 0x91A5;
                case 0x91A4:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x70A9 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x91A7;
                    goto case 0x91A7;
                case 0x91A5:
                    A = 0xF0; SetZN(A); TotalCycles += 2; PC = 0x91A7;
                    goto case 0x91A7;
                case 0x91A6:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x912D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x912D; }
                    PC = 0x91A8; return;
                case 0x91A7:
                    _ram[0xD7] = A; TotalCycles += 3; PC = 0x91A9;
                    goto case 0x91A9;
                case 0x91A9:
                    X = 0x05; SetZN(X); TotalCycles += 2; PC = 0x91AB;
                    goto case 0x91AB;
                case 0x91AA:
                    A |= _ram[0xA0]; SetZN(A); TotalCycles += 3; PC = 0x91AC;
                    goto case 0x91AC;
                case 0x91AB:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x91AD;
                    goto case 0x91AD;
                case 0x91AC:
                    TotalCycles += 7; PushU16(0x91AE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x91AD:
                    TotalCycles += 6; PushU16(0x91AF); PC = 0xB91E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x91AE:
                    { int a = 0xACB9 + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x91B1;
                    goto case 0x91B1;
                case 0x91AF:
                    A = ReadMem(0x4EAC + Y); SetZN(A); TotalCycles += 4; PC = 0x91B2;
                    return;
                case 0x91B0:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x91B3;
                    goto case 0x91B3;
                case 0x91B1:
                    { int a = 0xD007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x91B4;
                    return;
                case 0x91B3:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x91B8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x91B8; }
                    PC = 0x91B5; goto case 0x91B5;
                case 0x91B5:
                    TotalCycles += 6; PushU16(0x91B7); PC = 0xB70B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x91B8:
                    A = 0x07; SetZN(A); TotalCycles += 2; PC = 0x91BA;
                    goto case 0x91BA;
                case 0x91BA:
                    _ram[0x0E] = A; TotalCycles += 3; PC = 0x91BC;
                    goto case 0x91BC;
                case 0x91BB:
                    { int a = 0x5660; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x91BE;
                    goto case 0x91BE;
                case 0x91BC:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x91BD:
                    { byte z = (byte)(0x40 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x91BF;
                    goto case 0x91BF;
                case 0x91BE:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x91BF:
                    Adc(_ram[0x70]); TotalCycles += 3; PC = 0x91C1;
                    goto case 0x91C1;
                case 0x91C0:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x9228; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x91C2; goto case 0x91C2;
                case 0x91C1:
                    _ram[0x40] = Ror(_ram[0x40]); TotalCycles += 5; PC = 0x91C3;
                    goto case 0x91C3;
                case 0x91C2:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x91C3:
                    _ram[0x40] = Ror(_ram[0x40]); TotalCycles += 5; PC = 0x91C5;
                    goto case 0x91C5;
                case 0x91C4:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x91C5:
                    _ram[0x40] = Ror(_ram[0x40]); TotalCycles += 5; PC = 0x91C7;
                    goto case 0x91C7;
                case 0x91C6:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x91C7:
                    _ram[0x60] = Ror(_ram[0x60]); TotalCycles += 5; PC = 0x91C9;
                    goto case 0x91C9;
                case 0x91C8:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x91C9:
                    Adc(_ram[0x70]); TotalCycles += 3; PC = 0x91CB;
                    goto case 0x91CB;
                case 0x91CA:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x91CC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x91CC; }
                    PC = 0x91CC; goto case 0x91CC;
                case 0x91CB:
                    TotalCycles += 7; PushU16(0x91CD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x91CC:
                    TotalCycles += 7; PushU16(0x91CE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x91CD:
                    _ram[0x0774] = IncVal(_ram[0x0774]); TotalCycles += 6; PC = 0x91D0;
                    goto case 0x91D0;
                case 0x91D0:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x91D2;
                    goto case 0x91D2;
                case 0x91D1:
                    TotalCycles += 7; PushU16(0x91D3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x91D2:
                    _ram[0x0722] = A; TotalCycles += 4; PC = 0x91D5;
                    goto case 0x91D5;
                case 0x91D5:
                    A = 0x80; SetZN(A); TotalCycles += 2; PC = 0x91D7;
                    goto case 0x91D7;
                case 0x91D7:
                    _ram[0xFC] = A; TotalCycles += 3; PC = 0x91D9;
                    goto case 0x91D9;
                case 0x91D9:
                    _ram[0x075A] = DecVal(_ram[0x075A]); TotalCycles += 6; PC = 0x91DC;
                    goto case 0x91DC;
                case 0x91DC:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x91E9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x91E9; }
                    PC = 0x91DE; goto case 0x91DE;
                case 0x91DE:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x91E0;
                    goto case 0x91E0;
                case 0x91DF:
                    TotalCycles += 7; PushU16(0x91E1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x91E0:
                    _ram[0x0772] = A; TotalCycles += 4; PC = 0x91E3;
                    goto case 0x91E3;
                case 0x91E3:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x91E5;
                    goto case 0x91E5;
                case 0x91E5:
                    _ram[0x0770] = A; TotalCycles += 4; PC = 0x91E8;
                    goto case 0x91E8;
                case 0x91E6:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x91EF; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x91E8; goto case 0x91E8;
                case 0x91E8:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x91E9:
                    A = _ram[0x075F]; SetZN(A); TotalCycles += 4; PC = 0x91EC;
                    goto case 0x91EC;
                case 0x91EC:
                    A = Asl(A); TotalCycles += 2; PC = 0x91ED;
                    goto case 0x91ED;
                case 0x91ED:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x91EE;
                    goto case 0x91EE;
                case 0x91EE:
                    A = _ram[0x075C]; SetZN(A); TotalCycles += 4; PC = 0x91F1;
                    goto case 0x91F1;
                case 0x91F1:
                    A &= 0x02; SetZN(A); TotalCycles += 2; PC = 0x91F3;
                    goto case 0x91F3;
                case 0x91F3:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x91F6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x91F6; }
                    PC = 0x91F5; goto case 0x91F5;
                case 0x91F4:
                    A |= ReadMem(ReadU16Zp((byte)(0xE8 + X))); SetZN(A); TotalCycles += 6; PC = 0x91F6;
                    goto case 0x91F6;
                case 0x91F5:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x91F6;
                    goto case 0x91F6;
                case 0x91F6:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x11BD + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0x91F9;
                    goto case 0x91F9;
                case 0x91F7:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x2D91 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x91FA;
                    return;
                case 0x91F8:
                    WriteMem(ReadU16Zp(0xAD) + Y, A); TotalCycles += 6; PC = 0x91FA;
                    return;
                case 0x91F9:
                    A = _ram[0x075C]; SetZN(A); TotalCycles += 4; PC = 0x91FC;
                    goto case 0x91FC;
                case 0x91FC:
                    A = Lsr(A); TotalCycles += 2; PC = 0x91FD;
                    goto case 0x91FD;
                case 0x91FD:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x91FE;
                    goto case 0x91FE;
                case 0x91FE:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x9204; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9204; }
                    PC = 0x9200; goto case 0x9200;
                case 0x9200:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9201;
                    goto case 0x9201;
                case 0x9201:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9202;
                    goto case 0x9202;
                case 0x9202:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9203;
                    goto case 0x9203;
                case 0x9203:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9204;
                    goto case 0x9204;
                case 0x9204:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x9206;
                    goto case 0x9206;
                case 0x9206:
                    Cmp(A, _ram[0x071A]); TotalCycles += 4; PC = 0x9209;
                    goto case 0x9209;
                case 0x9209:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x920F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x920F; }
                    PC = 0x920B; goto case 0x920B;
                case 0x920B:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x920F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x920F; }
                    PC = 0x920D; goto case 0x920D;
                case 0x920D:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x920F;
                    goto case 0x920F;
                case 0x920E:
                    TotalCycles += 7; PushU16(0x9210); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x920F:
                    _ram[0x075B] = A; TotalCycles += 4; PC = 0x9212;
                    goto case 0x9212;
                case 0x9212:
                    TotalCycles += 6; PushU16(0x9214); PC = 0x9282;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9282;
                case 0x9215:
                    TotalCycles += 3; PC = 0x9264;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9264;
                case 0x9218: // === SUBROUTINE: GameOverMode ===
                    A = _ram[0x0772]; SetZN(A); TotalCycles += 4; PC = 0x921B;
                    goto case 0x921B;
                case 0x921B:
                    TotalCycles += 6; PushU16(0x921D); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E04;
                case 0x921D:
                    WriteIoReg(0x9224, X); TotalCycles += 4; PC = 0x9220;
                    return;
                case 0x921E:
                    Bit(_ram[0x92]); TotalCycles += 3; PC = 0x9220;
                    return;
                case 0x9221:
                    _ram[0x37] = A; TotalCycles += 3; PC = 0x9223;
                    return;
                case 0x9224:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9226;
                    goto case 0x9226;
                case 0x9225:
                    TotalCycles += 7; PushU16(0x9227); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9226:
                    _ram[0x073C] = A; TotalCycles += 4; PC = 0x9229;
                    goto case 0x9229;
                case 0x9229:
                    _ram[0x0722] = A; TotalCycles += 4; PC = 0x922C;
                    goto case 0x922C;
                case 0x922C:
                    A = 0x02; SetZN(A); TotalCycles += 2; PC = 0x922E;
                    goto case 0x922E;
                case 0x922E:
                    _ram[0xFC] = A; TotalCycles += 3; PC = 0x9230;
                    goto case 0x9230;
                case 0x9230:
                    _ram[0x0774] = IncVal(_ram[0x0774]); TotalCycles += 6; PC = 0x9233;
                    goto case 0x9233;
                case 0x9233:
                    _ram[0x0772] = IncVal(_ram[0x0772]); TotalCycles += 6; PC = 0x9236;
                    goto case 0x9236;
                case 0x9236:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9237:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9239;
                    goto case 0x9239;
                case 0x9238:
                    TotalCycles += 7; PushU16(0x923A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9239:
                    _ram[0x0774] = A; TotalCycles += 4; PC = 0x923C;
                    goto case 0x923C;
                case 0x923C:
                    A = _ram[0x06FC]; SetZN(A); TotalCycles += 4; PC = 0x923F;
                    goto case 0x923F;
                case 0x923E:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0x9240;
                    goto case 0x9240;
                case 0x923F: // === SUBROUTINE: GameOverMenu ===
                    A &= 0x10; SetZN(A); TotalCycles += 2; PC = 0x9241;
                    goto case 0x9241;
                case 0x9240:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9212; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9212; }
                    PC = 0x9242; goto case 0x9242;
                case 0x9241:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9248; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9248; }
                    PC = 0x9243; goto case 0x9243;
                case 0x9242:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0x9244;
                    goto case 0x9244;
                case 0x9243:
                    A = _ram[0x07A0]; SetZN(A); TotalCycles += 4; PC = 0x9246;
                    goto case 0x9246;
                case 0x9244:
                    Y = 0x07; SetZN(Y); TotalCycles += 2; PC = 0x9246;
                    goto case 0x9246;
                case 0x9246:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9281; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9281; }
                    PC = 0x9248; goto case 0x9248;
                case 0x9247:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x00A9 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x924A;
                    goto case 0x924A;
                case 0x9248: // === SUBROUTINE: Sub_9248 ===
                    A = 0x80; SetZN(A); TotalCycles += 2; PC = 0x924A;
                    goto case 0x924A;
                case 0x924A:
                    _ram[0xFC] = A; TotalCycles += 3; PC = 0x924C;
                    goto case 0x924C;
                case 0x924C:
                    TotalCycles += 6; PushU16(0x924E); PC = 0x9282;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9282;
                case 0x924F:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9264; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9264; }
                    PC = 0x9251; goto case 0x9251;
                case 0x9251:
                    A = _ram[0x075F]; SetZN(A); TotalCycles += 4; PC = 0x9254;
                    goto case 0x9254;
                case 0x9254:
                    _ram[0x07FD] = A; TotalCycles += 4; PC = 0x9257;
                    goto case 0x9257;
                case 0x9255:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x2907 + X) & 0x7FFF]); TotalCycles += 4; PC = 0x9258;
                    goto case 0x9258;
                case 0x9257:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9259;
                    goto case 0x9259;
                case 0x9258:
                    TotalCycles += 7; PushU16(0x925A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9259:
                    A = Asl(A); TotalCycles += 2; PC = 0x925A;
                    goto case 0x925A;
                case 0x925A:
                    _ram[0x0772] = A; TotalCycles += 4; PC = 0x925D;
                    goto case 0x925D;
                case 0x925D:
                    _ram[0x07A0] = A; TotalCycles += 4; PC = 0x9260;
                    goto case 0x9260;
                case 0x925E:
                    Y = 0x07; SetZN(Y); TotalCycles += 2; PC = 0x9260;
                    goto case 0x9260;
                case 0x9260:
                    _ram[0x0770] = A; TotalCycles += 4; PC = 0x9263;
                    goto case 0x9263;
                case 0x9261:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x926A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9263; goto case 0x9263;
                case 0x9263:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9264:
                    TotalCycles += 6; PushU16(0x9266); PC = 0x9C03;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9C03;
                case 0x9267:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x9269;
                    goto case 0x9269;
                case 0x9268:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x926A;
                    return;
                case 0x9269:
                    _ram[0x0754] = A; TotalCycles += 4; PC = 0x926C;
                    goto case 0x926C;
                case 0x926C:
                    _ram[0x0757] = IncVal(_ram[0x0757]); TotalCycles += 6; PC = 0x926F;
                    goto case 0x926F;
                case 0x926F:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9271;
                    goto case 0x9271;
                case 0x9270:
                    TotalCycles += 7; PushU16(0x9272); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9271:
                    _ram[0x0747] = A; TotalCycles += 4; PC = 0x9274;
                    goto case 0x9274;
                case 0x9274:
                    _ram[0x0756] = A; TotalCycles += 4; PC = 0x9277;
                    goto case 0x9277;
                case 0x9275:
                    { byte z = (byte)(0x07 + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x9277;
                    goto case 0x9277;
                case 0x9277:
                    _ram[0x0E] = A; TotalCycles += 3; PC = 0x9279;
                    goto case 0x9279;
                case 0x9278:
                    { int a = 0x728D; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x927B;
                    return;
                case 0x9279:
                    _ram[0x0772] = A; TotalCycles += 4; PC = 0x927C;
                    goto case 0x927C;
                case 0x927C: // === SUBROUTINE: RunGameOver ===
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x927E;
                    goto case 0x927E;
                case 0x927D:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x927F;
                    goto case 0x927F;
                case 0x927E:
                    _ram[0x0770] = A; TotalCycles += 4; PC = 0x9281;
                    goto case 0x9281;
                case 0x927F:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x9288; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9288; }
                    PC = 0x9281; goto case 0x9281;
                case 0x9281:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9282: // === SUBROUTINE: Sub_9282 ===
                    P |= FlagC; TotalCycles += 2; PC = 0x9283;
                    goto case 0x9283;
                case 0x9283:
                    A = _ram[0x077A]; SetZN(A); TotalCycles += 4; PC = 0x9286;
                    goto case 0x9286;
                case 0x9286:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x92A9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x92A9; }
                    PC = 0x9288; goto case 0x9288;
                case 0x9287:
                    A &= ReadMem(ReadU16Zp((byte)(0xAD + X))); SetZN(A); TotalCycles += 6; PC = 0x9289;
                    goto case 0x9289;
                case 0x9288:
                    A = _ram[0x0761]; SetZN(A); TotalCycles += 4; PC = 0x928B;
                    goto case 0x928B;
                case 0x9289:
                    Adc(ReadMem(ReadU16Zp((byte)(0x07 + X)))); TotalCycles += 6; PC = 0x928B;
                    goto case 0x928B;
                case 0x928B:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x92A9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x92A9; }
                    PC = 0x928D; goto case 0x928D;
                case 0x928D:
                    A = _ram[0x0753]; SetZN(A); TotalCycles += 4; PC = 0x9290;
                    goto case 0x9290;
                case 0x9290:
                    A ^= 0x01; SetZN(A); TotalCycles += 2; PC = 0x9292;
                    goto case 0x9292;
                case 0x9291:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x9293;
                    return;
                case 0x9292:
                    _ram[0x0753] = A; TotalCycles += 4; PC = 0x9295;
                    goto case 0x9295;
                case 0x9295:
                    X = 0x06; SetZN(X); TotalCycles += 2; PC = 0x9297;
                    goto case 0x9297;
                case 0x9296:
                    _ram[0xBD] = Asl(_ram[0xBD]); TotalCycles += 5; PC = 0x9298;
                    return;
                case 0x9297:
                    A = _ram[(0x075A + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x929A;
                    goto case 0x929A;
                case 0x929A:
                    PushU8(A); TotalCycles += 3; PC = 0x929B;
                    goto case 0x929B;
                case 0x929B:
                    A = _ram[(0x0761 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x929E;
                    goto case 0x929E;
                case 0x929C:
                    Adc(ReadMem(ReadU16Zp((byte)(0x07 + X)))); TotalCycles += 6; PC = 0x929E;
                    goto case 0x929E;
                case 0x929E:
                    _ram[(0x075A + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x92A1;
                    goto case 0x92A1;
                case 0x92A1:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x92A2;
                    goto case 0x92A2;
                case 0x92A2:
                    _ram[(0x0761 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x92A5;
                    goto case 0x92A5;
                case 0x92A3:
                    Adc(ReadMem(ReadU16Zp((byte)(0x07 + X)))); TotalCycles += 6; PC = 0x92A5;
                    goto case 0x92A5;
                case 0x92A5:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x92A6;
                    goto case 0x92A6;
                case 0x92A6:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9297; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9297; }
                    PC = 0x92A8; goto case 0x92A8;
                case 0x92A8:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x92A9;
                    goto case 0x92A9;
                case 0x92A9:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x92AA: // === SUBROUTINE: Sub_92AA ===
                    A = 0xFF; SetZN(A); TotalCycles += 2; PC = 0x92AC;
                    goto case 0x92AC;
                case 0x92AC:
                    _ram[0x06C9] = A; TotalCycles += 4; PC = 0x92AF;
                    goto case 0x92AF;
                case 0x92AD:
                    Cmp(A, 0x06); TotalCycles += 2; PC = 0x92AF;
                    goto case 0x92AF;
                case 0x92AE:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x92B0;
                    goto case 0x92B0;
                case 0x92AF: // === SUBROUTINE: Sub_92AF ===
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x92B0: // === SUBROUTINE: AreaParserCore_ObjDispatcher ===
                    Y = _ram[0x071F]; SetZN(Y); TotalCycles += 4; PC = 0x92B3;
                    goto case 0x92B3;
                case 0x92B3:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x92BA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x92BA; }
                    PC = 0x92B5; goto case 0x92B5;
                case 0x92B4:
                    A |= _ram[0xA0]; SetZN(A); TotalCycles += 3; PC = 0x92B6;
                    goto case 0x92B6;
                case 0x92B5:
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0x92B7;
                    goto case 0x92B7;
                case 0x92B6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x92B7;
                    goto case 0x92B7;
                case 0x92B7:
                    _ram[0x071F] = Y; TotalCycles += 4; PC = 0x92BA;
                    goto case 0x92BA;
                case 0x92BA:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x92BB;
                    goto case 0x92BB;
                case 0x92BB:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x92BC;
                    goto case 0x92BC;
                case 0x92BC:
                    TotalCycles += 6; PushU16(0x92BE); PC = 0x92C8;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x92C8;
                case 0x92BD:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x92BE;
                    return;
                case 0x92BF:
                    _ram[0x071F] = DecVal(_ram[0x071F]); TotalCycles += 6; PC = 0x92C2;
                    goto case 0x92C2;
                case 0x92C2:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x92C7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x92C7; }
                    PC = 0x92C4; goto case 0x92C4;
                case 0x92C4:
                    TotalCycles += 6; PushU16(0x92C6); PC = 0x896A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x896A;
                case 0x92C5:
                    A = Ror(A); TotalCycles += 2; PC = 0x92C6;
                    return;
                case 0x92C7:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x92C8: // === SUBROUTINE: Sub_92C8 ===
                    TotalCycles += 6; PushU16(0x92CA); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E04;
                case 0x92CA:
                    WriteIoReg(0x92DB, X); TotalCycles += 4; PC = 0x92CD;
                    goto case 0x92CD;
                case 0x92CD:
                    X = SmbEmbeddedAssets.StaticDataTables[0x2E88]; SetZN(X); TotalCycles += 4; PC = 0x92D0;
                    goto case 0x92D0;
                case 0x92CE:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x92CF;
                    goto case 0x92CF;
                case 0x92CF:
                    X = SmbEmbeddedAssets.StaticDataTables[0x7C88]; SetZN(X); TotalCycles += 4; PC = 0x92D2;
                    return;
                case 0x92D0:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x92D1;
                    return;
                case 0x92D5:
                    X = SmbEmbeddedAssets.StaticDataTables[0x2E88]; SetZN(X); TotalCycles += 4; PC = 0x92D8;
                    goto case 0x92D8;
                case 0x92D6:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x92D7;
                    goto case 0x92D7;
                case 0x92D7:
                    X = SmbEmbeddedAssets.StaticDataTables[0x7C88]; SetZN(X); TotalCycles += 4; PC = 0x92DA;
                    return;
                case 0x92D8:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x92D9;
                    return;
                case 0x92DB:
                    _ram[0x0726] = IncVal(_ram[0x0726]); TotalCycles += 6; PC = 0x92DE;
                    goto case 0x92DE;
                case 0x92DC:
                    _ram[0x07] = Rol(_ram[0x07]); TotalCycles += 5; PC = 0x92DE;
                    goto case 0x92DE;
                case 0x92DE:
                    A = _ram[0x0726]; SetZN(A); TotalCycles += 4; PC = 0x92E1;
                    goto case 0x92E1;
                case 0x92DF:
                    _ram[0x07] = Rol(_ram[0x07]); TotalCycles += 5; PC = 0x92E1;
                    goto case 0x92E1;
                case 0x92E1:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x92E3;
                    goto case 0x92E3;
                case 0x92E3:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x92EB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x92EB; }
                    PC = 0x92E5; goto case 0x92E5;
                case 0x92E4:
                    _ram[0x8D] = Asl(_ram[0x8D]); TotalCycles += 5; PC = 0x92E6;
                    goto case 0x92E6;
                case 0x92E5:
                    _ram[0x0726] = A; TotalCycles += 4; PC = 0x92E8;
                    goto case 0x92E8;
                case 0x92E6:
                    _ram[0x07] = Rol(_ram[0x07]); TotalCycles += 5; PC = 0x92E8;
                    goto case 0x92E8;
                case 0x92E8:
                    _ram[0x0725] = IncVal(_ram[0x0725]); TotalCycles += 6; PC = 0x92EB;
                    goto case 0x92EB;
                case 0x92E9:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x92EB;
                    goto case 0x92EB;
                case 0x92EB:
                    _ram[0x06A0] = IncVal(_ram[0x06A0]); TotalCycles += 6; PC = 0x92EE;
                    goto case 0x92EE;
                case 0x92EC:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0x92EE;
                    goto case 0x92EE;
                case 0x92ED:
                    _ram[0xAD] = Asl(_ram[0xAD]); TotalCycles += 5; PC = 0x92EF;
                    goto case 0x92EF;
                case 0x92EE:
                    A = _ram[0x06A0]; SetZN(A); TotalCycles += 4; PC = 0x92F1;
                    goto case 0x92F1;
                case 0x92EF:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0x92F1;
                    goto case 0x92F1;
                case 0x92F0:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0x92F2;
                    return;
                case 0x92F1:
                    A &= 0x1F; SetZN(A); TotalCycles += 2; PC = 0x92F3;
                    goto case 0x92F3;
                case 0x92F3:
                    _ram[0x06A0] = A; TotalCycles += 4; PC = 0x92F6;
                    goto case 0x92F6;
                case 0x92F4:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0x92F6;
                    goto case 0x92F6;
                case 0x92F5:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x92F7;
                    goto case 0x92F7;
                case 0x92F6:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x92F7:
                    TotalCycles += 7; PushU16(0x92F9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x92F8:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x935A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x935A; }
                    PC = 0x92FA; return;
                case 0x92F9:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x92FB:
                    TotalCycles += 7; PushU16(0x92FD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x92FC:
                    TotalCycles += 7; PushU16(0x92FE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x92FD:
                    A |= ReadMem(ReadU16Zp(0x12) + Y); SetZN(A); TotalCycles += 5; PC = 0x92FF;
                    return;
                case 0x9301:
                    TotalCycles += 7; PushU16(0x9303); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9302:
                    TotalCycles += 7; PushU16(0x9304); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9303:
                    A ^= ReadMem(ReadU16Zp(0x52) + Y); SetZN(A); TotalCycles += 5; PC = 0x9305;
                    return;
                case 0x9306:
                    TotalCycles += 7; PushU16(0x9308); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9307:
                    TotalCycles += 7; PushU16(0x9309); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9308:
                    TotalCycles += 7; PushU16(0x930A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9309:
                    TotalCycles += 7; PushU16(0x930B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x930A:
                    TotalCycles += 7; PushU16(0x930C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x930B:
                    TotalCycles += 7; PushU16(0x930D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x930C:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0x930E;
                    return;
                case 0x9310:
                    TotalCycles += 7; PushU16(0x9312); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9311:
                    TotalCycles += 7; PushU16(0x9313); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9312:
                    TotalCycles += 7; PushU16(0x9314); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9313:
                    TotalCycles += 7; PushU16(0x9315); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9314:
                    TotalCycles += 7; PushU16(0x9316); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9315:
                    TotalCycles += 7; PushU16(0x9317); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9316:
                    WriteMem(ReadU16Zp(0x92) + Y, A); TotalCycles += 6; PC = 0x9318;
                    return;
                case 0x9319:
                    TotalCycles += 7; PushU16(0x931B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x931A:
                    TotalCycles += 7; PushU16(0x931C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x931B:
                    TotalCycles += 7; PushU16(0x931D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x931C:
                    TotalCycles += 7; PushU16(0x931E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x931D:
                    A ^= ReadMem(ReadU16Zp(0x52) + Y); SetZN(A); TotalCycles += 5; PC = 0x931F;
                    return;
                case 0x9320:
                    A ^= ReadMem(ReadU16Zp((byte)(0x42 + X))); SetZN(A); TotalCycles += 6; PC = 0x9322;
                    return;
                case 0x9323:
                    TotalCycles += 7; PushU16(0x9325); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9324:
                    TotalCycles += 7; PushU16(0x9326); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9325:
                    TotalCycles += 7; PushU16(0x9327); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9326:
                    TotalCycles += 7; PushU16(0x9328); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9327:
                    TotalCycles += 7; PushU16(0x9329); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9328:
                    WriteMem(ReadU16Zp(0x92) + Y, A); TotalCycles += 6; PC = 0x932A;
                    return;
                case 0x932C:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x932D;
                    return;
                case 0x932E:
                    _ram[(0x0000 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x9331;
                    goto case 0x9331;
                case 0x932F:
                    TotalCycles += 7; PushU16(0x9331); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9330:
                    TotalCycles += 7; PushU16(0x9332); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9331:
                    TotalCycles += 7; PushU16(0x9333); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9332:
                    A |= ReadMem(ReadU16Zp(0x12) + Y); SetZN(A); TotalCycles += 5; PC = 0x9334;
                    return;
                case 0x9335:
                    Y = _ram[0xA5]; SetZN(Y); TotalCycles += 3; PC = 0x9337;
                    goto case 0x9337;
                case 0x9336:
                    A = _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0x9338;
                    goto case 0x9338;
                case 0x9337:
                    A = _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0x9339;
                    goto case 0x9339;
                case 0x9338:
                    A = _ram[0xA6]; SetZN(A); TotalCycles += 3; PC = 0x933A;
                    return;
                case 0x9339:
                    X = _ram[0x97]; SetZN(X); TotalCycles += 3; PC = 0x933B;
                    goto case 0x933B;
                case 0x933B:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x933C;
                    goto case 0x933C;
                case 0x933C:
                    _ram[(0x0201 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x933F;
                    return;
                case 0x933D:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0x933F;
                    return;
                case 0x9340:
                    TotalCycles += 7; PushU16(0x9342); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9341:
                    Y = _ram[0xA5]; SetZN(Y); TotalCycles += 3; PC = 0x9343;
                    goto case 0x9343;
                case 0x9342:
                    A = _ram[0xA6]; SetZN(A); TotalCycles += 3; PC = 0x9344;
                    goto case 0x9344;
                case 0x9343:
                    X = _ram[0x00]; SetZN(X); TotalCycles += 3; PC = 0x9345;
                    goto case 0x9345;
                case 0x9344:
                    TotalCycles += 7; PushU16(0x9346); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9345:
                    A |= ReadMem(ReadU16Zp(0x12) + Y); SetZN(A); TotalCycles += 5; PC = 0x9347;
                    return;
                case 0x934A:
                    TotalCycles += 7; PushU16(0x934C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x934B:
                    TotalCycles += 7; PushU16(0x934D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x934C:
                    TotalCycles += 7; PushU16(0x934E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x934D:
                    TotalCycles += 7; PushU16(0x934F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x934E:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0x9350;
                    return;
                case 0x9352:
                    TotalCycles += 7; PushU16(0x9354); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9353:
                    Y = _ram[0xA5]; SetZN(Y); TotalCycles += 3; PC = 0x9355;
                    goto case 0x9355;
                case 0x9354:
                    A = _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0x9356;
                    goto case 0x9356;
                case 0x9355:
                    A = _ram[0xA6]; SetZN(A); TotalCycles += 3; PC = 0x9357;
                    goto case 0x9357;
                case 0x9356:
                    X = _ram[0x00]; SetZN(X); TotalCycles += 3; PC = 0x9358;
                    goto case 0x9358;
                case 0x9357:
                    TotalCycles += 7; PushU16(0x9359); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9358:
                    TotalCycles += 7; PushU16(0x935A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9359:
                    TotalCycles += 7; PushU16(0x935B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x935A:
                    A |= ReadMem(ReadU16Zp(0x12) + Y); SetZN(A); TotalCycles += 5; PC = 0x935C;
                    return;
                case 0x935E:
                    TotalCycles += 7; PushU16(0x9360); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x935F:
                    TotalCycles += 7; PushU16(0x9361); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9360:
                    TotalCycles += 7; PushU16(0x9362); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9361:
                    TotalCycles += 7; PushU16(0x9363); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9362:
                    TotalCycles += 7; PushU16(0x9364); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9363:
                    TotalCycles += 7; PushU16(0x9365); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9364:
                    TotalCycles += 7; PushU16(0x9366); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9366:
                    TotalCycles += 7; PushU16(0x9368); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9368:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9369;
                    goto case 0x9369;
                case 0x9369:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x936A;
                    goto case 0x936A;
                case 0x936A:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x936B;
                    goto case 0x936B;
                case 0x936B:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x936C;
                    goto case 0x936C;
                case 0x936C:
                    A |= ReadMem(ReadU16Zp(0x12) + Y); SetZN(A); TotalCycles += 5; PC = 0x936E;
                    return;
                case 0x9370:
                    TotalCycles += 7; PushU16(0x9372); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9373:
                    TotalCycles += 7; PushU16(0x9375); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9374:
                    TotalCycles += 7; PushU16(0x9376); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9375:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0x9377;
                    return;
                case 0x9378:
                    A |= ReadMem(ReadU16Zp(0x12) + Y); SetZN(A); TotalCycles += 5; PC = 0x937A;
                    return;
                case 0x937C:
                    TotalCycles += 7; PushU16(0x937E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x937D:
                    TotalCycles += 7; PushU16(0x937F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x937E:
                    TotalCycles += 7; PushU16(0x9380); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x937F:
                    TotalCycles += 7; PushU16(0x9381); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9380:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9381;
                    goto case 0x9381;
                case 0x9381:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9382;
                    return;
                case 0x9383:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9384;
                    goto case 0x9384;
                case 0x9384:
                    TotalCycles += 7; PushU16(0x9386); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9386: // === SUBROUTINE: Sub_9386 ===
                    TotalCycles += 7; PushU16(0x9388); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9387:
                    A |= ReadMem(ReadU16Zp((byte)(0x02 + X))); SetZN(A); TotalCycles += 6; PC = 0x9389;
                    return;
                case 0x938C:
                    TotalCycles += 7; PushU16(0x938E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x938D:
                    WriteMem(ReadU16Zp((byte)(0x84 + X)), A); TotalCycles += 6; PC = 0x938F;
                    goto case 0x938F;
                case 0x938E:
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0x9390;
                    return;
                case 0x938F:
                    TotalCycles += 7; PushU16(0x9391); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9391:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x9393;
                    return;
                case 0x9392:
                    TotalCycles += 7; PushU16(0x9394); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9394:
                    TotalCycles += 7; PushU16(0x9396); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9395:
                    TotalCycles += 7; PushU16(0x9397); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9397:
                    TotalCycles += 7; PushU16(0x9399); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9398:
                    TotalCycles += 7; PushU16(0x939A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x939A:
                    TotalCycles += 7; PushU16(0x939C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x939B:
                    TotalCycles += 7; PushU16(0x939D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x939C:
                    TotalCycles += 7; PushU16(0x939E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x939D:
                    A |= _ram[0x06]; SetZN(A); TotalCycles += 3; PC = 0x939F;
                    return;
                case 0x939E:
                    _ram[0x07] = Asl(_ram[0x07]); TotalCycles += 5; PC = 0x93A0;
                    goto case 0x93A0;
                case 0x93A0:
                    _ram[0x0A] = Asl(_ram[0x0A]); TotalCycles += 5; PC = 0x93A2;
                    goto case 0x93A2;
                case 0x93A1:
                    A = Asl(A); TotalCycles += 2; PC = 0x93A2;
                    goto case 0x93A2;
                case 0x93A2:
                    TotalCycles += 7; PushU16(0x93A4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93A3:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x93A4;
                    goto case 0x93A4;
                case 0x93A4:
                    A |= 0x4D; SetZN(A); TotalCycles += 2; PC = 0x93A6;
                    goto case 0x93A6;
                case 0x93A5:
                    A ^= _ram[0x0000]; SetZN(A); TotalCycles += 4; PC = 0x93A8;
                    goto case 0x93A8;
                case 0x93A6:
                    TotalCycles += 7; PushU16(0x93A8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93A7:
                    TotalCycles += 7; PushU16(0x93A9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93A8:
                    A |= ReadIoReg(0x4E0F); SetZN(A); TotalCycles += 4; PC = 0x93AB;
                    goto case 0x93AB;
                case 0x93AA:
                    { int a = 0x4E0E; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x93AD;
                    goto case 0x93AD;
                case 0x93AB:
                    { int a = 0x4E4E; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x93AE;
                    goto case 0x93AE;
                case 0x93AC:
                    _ram[0x004E] = Lsr(_ram[0x004E]); TotalCycles += 6; PC = 0x93AF;
                    goto case 0x93AF;
                case 0x93AD:
                    _ram[0x0500] = Lsr(_ram[0x0500]); TotalCycles += 6; PC = 0x93B0;
                    return;
                case 0x93AE:
                    TotalCycles += 7; PushU16(0x93B0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93AF:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x061A]; SetZN(A); TotalCycles += 4; PC = 0x93B2;
                    return;
                case 0x93B1:
                    _ram[0x87] = X; TotalCycles += 3; PC = 0x93B3;
                    return;
                case 0x93BC:
                    Adc(0x69); TotalCycles += 2; PC = 0x93BE;
                    goto case 0x93BE;
                case 0x93BD:
                    Adc(0x00); TotalCycles += 2; PC = 0x93BF;
                    goto case 0x93BF;
                case 0x93BE:
                    TotalCycles += 7; PushU16(0x93C0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93BF:
                    TotalCycles += 7; PushU16(0x93C1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93C0:
                    TotalCycles += 7; PushU16(0x93C2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93C1:
                    TotalCycles += 7; PushU16(0x93C3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93C2:
                    TotalCycles += 7; PushU16(0x93C4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93C3:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x93C5;
                    return;
                case 0x93C9:
                    TotalCycles += 7; PushU16(0x93CB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93CA:
                    TotalCycles += 7; PushU16(0x93CC); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93CB:
                    TotalCycles += 7; PushU16(0x93CD); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93CC:
                    TotalCycles += 7; PushU16(0x93CE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93CD:
                    TotalCycles += 7; PushU16(0x93CF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93CE:
                    TotalCycles += 7; PushU16(0x93D0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93CF:
                    TotalCycles += 7; PushU16(0x93D1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93D0:
                    TotalCycles += 7; PushU16(0x93D2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93D1:
                    TotalCycles += 7; PushU16(0x93D3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93D2:
                    TotalCycles += 7; PushU16(0x93D4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93D3:
                    TotalCycles += 7; PushU16(0x93D5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93D4:
                    TotalCycles += 7; PushU16(0x93D6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93D5:
                    TotalCycles += 7; PushU16(0x93D7); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93D6:
                    _ram[0x87] = X; TotalCycles += 3; PC = 0x93D8;
                    goto case 0x93D8;
                case 0x93D8:
                    Adc(0x54); TotalCycles += 2; PC = 0x93DA;
                    return;
                case 0x93DC:
                    TotalCycles += 7; PushU16(0x93DE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93DD:
                    TotalCycles += 7; PushU16(0x93DF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93DE:
                    TotalCycles += 7; PushU16(0x93E0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93DF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x93E0;
                    goto case 0x93E0;
                case 0x93E0:
                    A |= ReadMem(ReadU16Zp((byte)(0x18 + X))); SetZN(A); TotalCycles += 6; PC = 0x93E2;
                    return;
                case 0x93E1:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x93E2;
                    return;
                case 0x93E3:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x93E4;
                    return;
                case 0x93E5:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x93E6;
                    return;
                case 0x93E7:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x93E8;
                    goto case 0x93E8;
                case 0x93E8:
                    A |= ReadMem(ReadU16Zp((byte)(0x1F + X))); SetZN(A); TotalCycles += 6; PC = 0x93EA;
                    return;
                case 0x93EE:
                    WriteMem(ReadU16Zp((byte)(0x1F + X)), A); TotalCycles += 6; PC = 0x93F0;
                    goto case 0x93F0;
                case 0x93F0:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0x93F2;
                    return;
                case 0x93F1:
                    TotalCycles += 7; PushU16(0x93F3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x93F4:
                    Sbc(ReadMem(ReadU16Zp(0x1F) + Y)); TotalCycles += 5; PC = 0x93F6;
                    goto case 0x93F6;
                case 0x93F6:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x7118 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x93F9;
                    goto case 0x93F9;
                case 0x93F7:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x93F8;
                    goto case 0x93F8;
                case 0x93F8:
                    Sbc(ReadMem(ReadU16Zp(0x18) + Y)); TotalCycles += 5; PC = 0x93FA;
                    return;
                case 0x93F9:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x93FA;
                    return;
                case 0x93FC:
                    A = _ram[0x0728]; SetZN(A); TotalCycles += 4; PC = 0x93FF;
                    goto case 0x93FF;
                case 0x93FD:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x93FE;
                    return;
                case 0x93FF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9404; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9404; }
                    PC = 0x9401; goto case 0x9401;
                case 0x9401:
                    TotalCycles += 6; PushU16(0x9403); PC = 0x9508;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9508;
                case 0x9402:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9403;
                    goto case 0x9403;
                case 0x9403:
                    _ram[(byte)(0xA2 + X)] = A; TotalCycles += 4; PC = 0x9405;
                    return;
                case 0x9404:
                    X = 0x0C; SetZN(X); TotalCycles += 2; PC = 0x9406;
                    goto case 0x9406;
                case 0x9406:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9408;
                    goto case 0x9408;
                case 0x9407:
                    TotalCycles += 7; PushU16(0x9409); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9408:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x940B;
                    goto case 0x940B;
                case 0x9409:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x940B;
                    goto case 0x940B;
                case 0x940A:
                    _ram[0xCA] = Asl(_ram[0xCA]); TotalCycles += 5; PC = 0x940C;
                    goto case 0x940C;
                case 0x940B:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x940C;
                    goto case 0x940C;
                case 0x940C:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9408; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9408; }
                    PC = 0x940E; goto case 0x940E;
                case 0x940E:
                    Y = _ram[0x0742]; SetZN(Y); TotalCycles += 4; PC = 0x9411;
                    goto case 0x9411;
                case 0x9411:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9455; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9455; }
                    PC = 0x9413; goto case 0x9413;
                case 0x9413:
                    A = _ram[0x0725]; SetZN(A); TotalCycles += 4; PC = 0x9416;
                    goto case 0x9416;
                case 0x9414:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9416;
                    goto case 0x9416;
                case 0x9416:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0x9418;
                    goto case 0x9418;
                case 0x9418:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x941F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x941F; }
                    PC = 0x941A; goto case 0x941A;
                case 0x9419:
                    A |= _ram[0x38]; SetZN(A); TotalCycles += 3; PC = 0x941B;
                    goto case 0x941B;
                case 0x941A:
                    P |= FlagC; TotalCycles += 2; PC = 0x941B;
                    goto case 0x941B;
                case 0x941B:
                    Sbc(0x03); TotalCycles += 2; PC = 0x941D;
                    goto case 0x941D;
                case 0x941D:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9416; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9416; }
                    PC = 0x941F; goto case 0x941F;
                case 0x941F:
                    A = Asl(A); TotalCycles += 2; PC = 0x9420;
                    goto case 0x9420;
                case 0x9420:
                    A = Asl(A); TotalCycles += 2; PC = 0x9421;
                    goto case 0x9421;
                case 0x9421:
                    A = Asl(A); TotalCycles += 2; PC = 0x9422;
                    goto case 0x9422;
                case 0x9422:
                    A = Asl(A); TotalCycles += 2; PC = 0x9423;
                    goto case 0x9423;
                case 0x9423:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x12F6 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x9426;
                    goto case 0x9426;
                case 0x9424:
                    { byte z = (byte)(0x92 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0x9426;
                    goto case 0x9426;
                case 0x9426:
                    Adc(_ram[0x0726]); TotalCycles += 4; PC = 0x9429;
                    goto case 0x9429;
                case 0x9427:
                    _ram[0x07] = Rol(_ram[0x07]); TotalCycles += 5; PC = 0x9429;
                    goto case 0x9429;
                case 0x9429:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x942A;
                    goto case 0x942A;
                case 0x942A:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x12FA + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x942D;
                    goto case 0x942D;
                case 0x942D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9455; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9455; }
                    PC = 0x942F; goto case 0x942F;
                case 0x942E:
                    _ram[0x48] = Rol(_ram[0x48]); TotalCycles += 5; PC = 0x9430;
                    goto case 0x9430;
                case 0x942F:
                    PushU8(A); TotalCycles += 3; PC = 0x9430;
                    goto case 0x9430;
                case 0x9430:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x9432;
                    goto case 0x9432;
                case 0x9432:
                    P |= FlagC; TotalCycles += 2; PC = 0x9433;
                    goto case 0x9433;
                case 0x9433:
                    Sbc(0x01); TotalCycles += 2; PC = 0x9435;
                    goto case 0x9435;
                case 0x9434:
                    A |= ReadMem(ReadU16Zp((byte)(0x85 + X))); SetZN(A); TotalCycles += 6; PC = 0x9436;
                    goto case 0x9436;
                case 0x9435:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x9437;
                    goto case 0x9437;
                case 0x9436:
                    TotalCycles += 7; PushU16(0x9438); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9437:
                    A = Asl(A); TotalCycles += 2; PC = 0x9438;
                    goto case 0x9438;
                case 0x9438:
                    Adc(_ram[0x00]); TotalCycles += 3; PC = 0x943A;
                    goto case 0x943A;
                case 0x9439:
                    TotalCycles += 7; PushU16(0x943B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x943A:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x943B;
                    goto case 0x943B;
                case 0x943B:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x943C;
                    goto case 0x943C;
                case 0x943C:
                    A = Lsr(A); TotalCycles += 2; PC = 0x943D;
                    goto case 0x943D;
                case 0x943D:
                    A = Lsr(A); TotalCycles += 2; PC = 0x943E;
                    goto case 0x943E;
                case 0x943E:
                    A = Lsr(A); TotalCycles += 2; PC = 0x943F;
                    goto case 0x943F;
                case 0x943F:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9440;
                    goto case 0x9440;
                case 0x9440:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9441;
                    goto case 0x9441;
                case 0x9441:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x9443;
                    goto case 0x9443;
                case 0x9443:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x9445;
                    goto case 0x9445;
                case 0x9444:
                    TotalCycles += 7; PushU16(0x9446); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9445:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x138A + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9448;
                    goto case 0x9448;
                case 0x9446:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x9447;
                    return;
                case 0x9448:
                    _ram[(0x06A1 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x944B;
                    goto case 0x944B;
                case 0x9449:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x944B;
                    goto case 0x944B;
                case 0x944A:
                    _ram[0xE8] = Asl(_ram[0xE8]); TotalCycles += 5; PC = 0x944C;
                    goto case 0x944C;
                case 0x944B:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x944C;
                    goto case 0x944C;
                case 0x944C:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x944D;
                    goto case 0x944D;
                case 0x944D:
                    Cmp(Y, 0x0B); TotalCycles += 2; PC = 0x944F;
                    goto case 0x944F;
                case 0x944F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9455; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9455; }
                    PC = 0x9451; goto case 0x9451;
                case 0x9451:
                    _ram[0x00] = DecVal(_ram[0x00]); TotalCycles += 5; PC = 0x9453;
                    goto case 0x9453;
                case 0x9452:
                    TotalCycles += 7; PushU16(0x9454); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9453:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9445; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9445; }
                    PC = 0x9455; goto case 0x9455;
                case 0x9454:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9404; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9404; }
                    PC = 0x9456; goto case 0x9456;
                case 0x9455:
                    X = _ram[0x0741]; SetZN(X); TotalCycles += 4; PC = 0x9458;
                    goto case 0x9458;
                case 0x9456:
                    A ^= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x9458;
                    goto case 0x9458;
                case 0x9458:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x946D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x946D; }
                    PC = 0x945A; goto case 0x945A;
                case 0x945A:
                    Y = SmbEmbeddedAssets.StaticDataTables[(0x13AD + X) & 0x7FFF]; SetZN(Y); TotalCycles += 4; PC = 0x945D;
                    goto case 0x945D;
                case 0x945B:
                    A = SmbEmbeddedAssets.StaticDataTables[0x2293]; SetZN(A); TotalCycles += 4; PC = 0x945E;
                    goto case 0x945E;
                case 0x945D:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x945F;
                    goto case 0x945F;
                case 0x945E:
                    TotalCycles += 7; PushU16(0x9460); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x945F:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x13B1 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9462;
                    goto case 0x9462;
                case 0x9460:
                    A = ReadMem(ReadU16Zp(0x93) + Y); SetZN(A); TotalCycles += 5; PC = 0x9462;
                    goto case 0x9462;
                case 0x9462:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9467; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9467; }
                    PC = 0x9464; goto case 0x9464;
                case 0x9464:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9467;
                    goto case 0x9467;
                case 0x9465:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x9467;
                    goto case 0x9467;
                case 0x9466:
                    _ram[0xC8] = Asl(_ram[0xC8]); TotalCycles += 5; PC = 0x9468;
                    goto case 0x9468;
                case 0x9467:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9468;
                    goto case 0x9468;
                case 0x9468:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9469;
                    goto case 0x9469;
                case 0x9469:
                    Cmp(X, 0x0D); TotalCycles += 2; PC = 0x946B;
                    goto case 0x946B;
                case 0x946A:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x72D0]; SetZN(A); TotalCycles += 4; PC = 0x946D;
                    goto case 0x946D;
                case 0x946B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x945F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x945F; }
                    PC = 0x946D; goto case 0x946D;
                case 0x946D:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x9470;
                    goto case 0x9470;
                case 0x946E:
                    { int a = 0xD007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9471;
                    return;
                case 0x9470:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x947E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x947E; }
                    PC = 0x9472; goto case 0x9472;
                case 0x9472:
                    A = _ram[0x075F]; SetZN(A); TotalCycles += 4; PC = 0x9475;
                    goto case 0x9475;
                case 0x9475:
                    Cmp(A, 0x07); TotalCycles += 2; PC = 0x9477;
                    goto case 0x9477;
                case 0x9477:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x947E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x947E; }
                    PC = 0x9479; goto case 0x9479;
                case 0x9478:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0x947A;
                    return;
                case 0x9479:
                    A = 0x62; SetZN(A); TotalCycles += 2; PC = 0x947B;
                    goto case 0x947B;
                case 0x947B:
                    TotalCycles += 3; PC = 0x9488;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9488;
                case 0x947C:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x947D;
                    goto case 0x947D;
                case 0x947D:
                    _ram[(byte)(0xB9 + X)] = Y; TotalCycles += 4; PC = 0x947F;
                    goto case 0x947F;
                case 0x947E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x13D8 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9481;
                    goto case 0x9481;
                case 0x947F:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0x9480;
                    return;
                case 0x9481:
                    Y = _ram[0x0743]; SetZN(Y); TotalCycles += 4; PC = 0x9484;
                    goto case 0x9484;
                case 0x9484:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9488; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9488; }
                    PC = 0x9486; goto case 0x9486;
                case 0x9486:
                    A = 0x88; SetZN(A); TotalCycles += 2; PC = 0x9488;
                    goto case 0x9488;
                case 0x9487:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9488;
                    goto case 0x9488;
                case 0x9488:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0x948A;
                    goto case 0x948A;
                case 0x948A:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x948C;
                    goto case 0x948C;
                case 0x948B:
                    TotalCycles += 7; PushU16(0x948D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x948C:
                    A = _ram[0x0727]; SetZN(A); TotalCycles += 4; PC = 0x948F;
                    goto case 0x948F;
                case 0x948F:
                    A = Asl(A); TotalCycles += 2; PC = 0x9490;
                    goto case 0x9490;
                case 0x9490:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9491;
                    goto case 0x9491;
                case 0x9491:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x13DC + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9494;
                    goto case 0x9494;
                case 0x9494:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x9496;
                    goto case 0x9496;
                case 0x9495:
                    TotalCycles += 7; PushU16(0x9497); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9496:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9497;
                    goto case 0x9497;
                case 0x9497:
                    _ram[0x01] = Y; TotalCycles += 3; PC = 0x9499;
                    goto case 0x9499;
                case 0x9498: // === SUBROUTINE: Sub_9498 ===
                    A |= ReadMem(ReadU16Zp((byte)(0xAD + X))); SetZN(A); TotalCycles += 6; PC = 0x949A;
                    return;
                case 0x9499:
                    A = _ram[0x0743]; SetZN(A); TotalCycles += 4; PC = 0x949C;
                    goto case 0x949C;
                case 0x949C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x94A8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94A8; }
                    PC = 0x949E; goto case 0x949E;
                case 0x949D:
                    A = Asl(A); TotalCycles += 2; PC = 0x949E;
                    goto case 0x949E;
                case 0x949E:
                    Cmp(X, 0x00); TotalCycles += 2; PC = 0x94A0;
                    goto case 0x94A0;
                case 0x949F:
                    TotalCycles += 7; PushU16(0x94A1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94A0:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x94A8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94A8; }
                    PC = 0x94A2; goto case 0x94A2;
                case 0x94A1:
                    _ram[0xA5] = Asl(_ram[0xA5]); TotalCycles += 5; PC = 0x94A3;
                    goto case 0x94A3;
                case 0x94A2:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x94A4;
                    goto case 0x94A4;
                case 0x94A3:
                    TotalCycles += 7; PushU16(0x94A5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94A4:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0x94A6;
                    goto case 0x94A6;
                case 0x94A5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x94A6;
                    goto case 0x94A6;
                case 0x94A6:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x94A8;
                    goto case 0x94A8;
                case 0x94A7:
                    TotalCycles += 7; PushU16(0x94A9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94A8:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x94AA;
                    goto case 0x94AA;
                case 0x94A9:
                    TotalCycles += 7; PushU16(0x94AB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94AA:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x468A + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x94AD;
                    goto case 0x94AD;
                case 0x94AB:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x94AC;
                    goto case 0x94AC;
                case 0x94AC:
                    _ram[0x24] = DecVal(_ram[0x24]); TotalCycles += 5; PC = 0x94AE;
                    goto case 0x94AE;
                case 0x94AD:
                    Bit(_ram[0x00]); TotalCycles += 3; PC = 0x94AF;
                    goto case 0x94AF;
                case 0x94AE:
                    TotalCycles += 7; PushU16(0x94B0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94AF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x94B6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94B6; }
                    PC = 0x94B1; goto case 0x94B1;
                case 0x94B0:
                    A |= _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0x94B2;
                    return;
                case 0x94B1:
                    A = _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x94B3;
                    goto case 0x94B3;
                case 0x94B3:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x94B6;
                    goto case 0x94B6;
                case 0x94B4:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x94B6;
                    goto case 0x94B6;
                case 0x94B5:
                    _ram[0xE8] = Asl(_ram[0xE8]); TotalCycles += 5; PC = 0x94B7;
                    goto case 0x94B7;
                case 0x94B6:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x94B7;
                    goto case 0x94B7;
                case 0x94B7:
                    Cmp(X, 0x0D); TotalCycles += 2; PC = 0x94B9;
                    goto case 0x94B9;
                case 0x94B8:
                    A |= _ram[0x00F0]; SetZN(A); TotalCycles += 4; PC = 0x94BB;
                    goto case 0x94BB;
                case 0x94B9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x94D3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94D3; }
                    PC = 0x94BB; goto case 0x94BB;
                case 0x94BA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x94BB;
                    goto case 0x94BB;
                case 0x94BB:
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0x94BE;
                    goto case 0x94BE;
                case 0x94BC:
                    { int a = 0xC907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x94BF;
                    return;
                case 0x94BE:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0x94C0;
                    goto case 0x94C0;
                case 0x94C0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x94CA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94CA; }
                    PC = 0x94C2; goto case 0x94C2;
                case 0x94C1:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x94C2;
                    goto case 0x94C2;
                case 0x94C2:
                    Cmp(X, 0x0B); TotalCycles += 2; PC = 0x94C4;
                    goto case 0x94C4;
                case 0x94C4:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x94CA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94CA; }
                    PC = 0x94C6; goto case 0x94C6;
                case 0x94C6:
                    A = 0x54; SetZN(A); TotalCycles += 2; PC = 0x94C8;
                    goto case 0x94C8;
                case 0x94C8:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0x94CA;
                    goto case 0x94CA;
                case 0x94CA:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x94CB;
                    goto case 0x94CB;
                case 0x94CB:
                    Cmp(Y, 0x08); TotalCycles += 2; PC = 0x94CD;
                    goto case 0x94CD;
                case 0x94CC:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x94CD;
                    goto case 0x94CD;
                case 0x94CD:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x94AA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94AA; }
                    PC = 0x94CF; goto case 0x94CF;
                case 0x94CF:
                    Y = _ram[0x01]; SetZN(Y); TotalCycles += 3; PC = 0x94D1;
                    goto case 0x94D1;
                case 0x94D0:
                    A |= ReadMem(ReadU16Zp((byte)(0xD0 + X))); SetZN(A); TotalCycles += 6; PC = 0x94D2;
                    goto case 0x94D2;
                case 0x94D1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9491; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9491; }
                    PC = 0x94D3; goto case 0x94D3;
                case 0x94D2:
                    X = ReadMem(0x0820 + Y); SetZN(X); TotalCycles += 4; PC = 0x94D5;
                    goto case 0x94D5;
                case 0x94D3:
                    TotalCycles += 6; PushU16(0x94D5); PC = 0x9508;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9508;
                case 0x94D4:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x94D5;
                    goto case 0x94D5;
                case 0x94D5:
                    _ram[(byte)(0xAD + X)] = A; TotalCycles += 4; PC = 0x94D7;
                    goto case 0x94D7;
                case 0x94D6:
                    A = _ram[0x06A0]; SetZN(A); TotalCycles += 4; PC = 0x94D9;
                    goto case 0x94D9;
                case 0x94D7:
                    Y = 0x06; SetZN(Y); TotalCycles += 2; PC = 0x94D9;
                    goto case 0x94D9;
                case 0x94D8:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x94DA;
                    goto case 0x94DA;
                case 0x94D9:
                    TotalCycles += 6; PushU16(0x94DB); PC = 0x9BE1;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BE1;
                case 0x94DA:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x9B + X)))); TotalCycles += 6; PC = 0x94DC;
                    goto case 0x94DC;
                case 0x94DC:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x94DE;
                    goto case 0x94DE;
                case 0x94DD:
                    TotalCycles += 7; PushU16(0x94DF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94DE:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x94E0;
                    goto case 0x94E0;
                case 0x94DF:
                    TotalCycles += 7; PushU16(0x94E1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94E0:
                    _ram[0x00] = Y; TotalCycles += 3; PC = 0x94E2;
                    goto case 0x94E2;
                case 0x94E1:
                    TotalCycles += 7; PushU16(0x94E3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94E2:
                    A = _ram[(0x06A1 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x94E5;
                    goto case 0x94E5;
                case 0x94E3:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x94E5;
                    goto case 0x94E5;
                case 0x94E4:
                    _ram[0x29] = Asl(_ram[0x29]); TotalCycles += 5; PC = 0x94E6;
                    goto case 0x94E6;
                case 0x94E5:
                    A &= 0xC0; SetZN(A); TotalCycles += 2; PC = 0x94E7;
                    goto case 0x94E7;
                case 0x94E6:
                    Cmp(Y, 0x0A); TotalCycles += 2; PC = 0x94E8;
                    goto case 0x94E8;
                case 0x94E7:
                    A = Asl(A); TotalCycles += 2; PC = 0x94E8;
                    goto case 0x94E8;
                case 0x94E8:
                    A = Rol(A); TotalCycles += 2; PC = 0x94E9;
                    goto case 0x94E9;
                case 0x94E9:
                    A = Rol(A); TotalCycles += 2; PC = 0x94EA;
                    goto case 0x94EA;
                case 0x94EA:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x94EB;
                    goto case 0x94EB;
                case 0x94EB:
                    A = _ram[(0x06A1 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x94EE;
                    goto case 0x94EE;
                case 0x94EC:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x94EE;
                    goto case 0x94EE;
                case 0x94ED:
                    _ram[0xD9] = Asl(_ram[0xD9]); TotalCycles += 5; PC = 0x94EF;
                    return;
                case 0x94EE:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x1504 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x94F1;
                    goto case 0x94F1;
                case 0x94F0:
                    _ram[(byte)(0xB0 + X)] = A; TotalCycles += 4; PC = 0x94F2;
                    return;
                case 0x94F1:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x94F5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94F5; }
                    PC = 0x94F3; goto case 0x94F3;
                case 0x94F3:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x94F5;
                    goto case 0x94F5;
                case 0x94F4:
                    TotalCycles += 7; PushU16(0x94F6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94F5:
                    Y = _ram[0x00]; SetZN(Y); TotalCycles += 3; PC = 0x94F7;
                    goto case 0x94F7;
                case 0x94F6:
                    TotalCycles += 7; PushU16(0x94F8); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x94F7:
                    WriteMem(ReadU16Zp(0x06) + Y, A); TotalCycles += 6; PC = 0x94F9;
                    goto case 0x94F9;
                case 0x94F8:
                    _ram[0x98] = Asl(_ram[0x98]); TotalCycles += 5; PC = 0x94FA;
                    goto case 0x94FA;
                case 0x94F9:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x94FA;
                    goto case 0x94FA;
                case 0x94FA:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x94FB;
                    goto case 0x94FB;
                case 0x94FB:
                    Adc(0x10); TotalCycles += 2; PC = 0x94FD;
                    goto case 0x94FD;
                case 0x94FC:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x94A6; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94A6; }
                    PC = 0x94FE; goto case 0x94FE;
                case 0x94FD:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x94FE;
                    goto case 0x94FE;
                case 0x94FE:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x94FF;
                    goto case 0x94FF;
                case 0x94FF:
                    Cmp(X, 0x0D); TotalCycles += 2; PC = 0x9501;
                    goto case 0x9501;
                case 0x9500:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x5D90]; SetZN(A); TotalCycles += 4; PC = 0x9503;
                    goto case 0x9503;
                case 0x9501:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x94E0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x94E0; }
                    PC = 0x9503; goto case 0x9503;
                case 0x9502:
                    Cmp(A, ReadMem(0x1060 + X)); TotalCycles += 4; PC = 0x9505;
                    goto case 0x9505;
                case 0x9503:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9504:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9557; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9557; }
                    PC = 0x9506; goto case 0x9506;
                case 0x9505:
                    A ^= ReadMem(ReadU16Zp(0x88) + Y); SetZN(A); TotalCycles += 5; PC = 0x9507;
                    goto case 0x9507;
                case 0x9506:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9507;
                    goto case 0x9507;
                case 0x9507:
                    Cmp(Y, 0xA2); TotalCycles += 2; PC = 0x9509;
                    return;
                case 0x9508:
                    X = 0x02; SetZN(X); TotalCycles += 2; PC = 0x950A;
                    goto case 0x950A;
                case 0x950A:
                    _ram[0x08] = X; TotalCycles += 3; PC = 0x950C;
                    goto case 0x950C;
                case 0x950B:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x950C;
                    goto case 0x950C;
                case 0x950C:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x950E;
                    goto case 0x950E;
                case 0x950D:
                    TotalCycles += 7; PushU16(0x950F); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x950E:
                    _ram[0x0729] = A; TotalCycles += 4; PC = 0x9511;
                    goto case 0x9511;
                case 0x950F:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0x9511;
                    goto case 0x9511;
                case 0x9511:
                    Y = _ram[0x072C]; SetZN(Y); TotalCycles += 4; PC = 0x9514;
                    goto case 0x9514;
                case 0x9512:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x3107]); TotalCycles += 4; PC = 0x9515;
                    return;
                case 0x9514:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9516;
                    goto case 0x9516;
                case 0x9516:
                    Cmp(A, 0xFD); TotalCycles += 2; PC = 0x9518;
                    goto case 0x9518;
                case 0x9517:
                    Sbc(ReadMem(0x4BF0 + X)); TotalCycles += 4; PC = 0x951A;
                    goto case 0x951A;
                case 0x9518:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9565; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9565; }
                    PC = 0x951A; goto case 0x951A;
                case 0x951A:
                    A = _ram[(0x0730 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x951D;
                    goto case 0x951D;
                case 0x951B:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9524; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x951D; goto case 0x951D;
                case 0x951D:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9565; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9565; }
                    PC = 0x951F; goto case 0x951F;
                case 0x951E:
                    _ram[0xC8] = Lsr(_ram[0xC8]); TotalCycles += 5; PC = 0x9520;
                    goto case 0x9520;
                case 0x951F:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9520;
                    goto case 0x9520;
                case 0x9520:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9522;
                    goto case 0x9522;
                case 0x9522:
                    A = Asl(A); TotalCycles += 2; PC = 0x9523;
                    goto case 0x9523;
                case 0x9523:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9530; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9530; }
                    PC = 0x9525; goto case 0x9525;
                case 0x9525:
                    A = _ram[0x072B]; SetZN(A); TotalCycles += 4; PC = 0x9528;
                    goto case 0x9528;
                case 0x9528:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9530; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9530; }
                    PC = 0x952A; goto case 0x952A;
                case 0x9529:
                    _ram[0xEE] = Asl(_ram[0xEE]); TotalCycles += 5; PC = 0x952B;
                    return;
                case 0x952A:
                    _ram[0x072B] = IncVal(_ram[0x072B]); TotalCycles += 6; PC = 0x952D;
                    goto case 0x952D;
                case 0x952D:
                    _ram[0x072A] = IncVal(_ram[0x072A]); TotalCycles += 6; PC = 0x9530;
                    goto case 0x9530;
                case 0x952E:
                    A = Rol(A); TotalCycles += 2; PC = 0x952F;
                    return;
                case 0x9530:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9531;
                    goto case 0x9531;
                case 0x9531:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9533;
                    goto case 0x9533;
                case 0x9533:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x9535;
                    goto case 0x9535;
                case 0x9535:
                    Cmp(A, 0x0D); TotalCycles += 2; PC = 0x9537;
                    goto case 0x9537;
                case 0x9536:
                    A |= _ram[0x03D0]; SetZN(A); TotalCycles += 4; PC = 0x9539;
                    goto case 0x9539;
                case 0x9537:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9554; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9554; }
                    PC = 0x9539; goto case 0x9539;
                case 0x9539:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x953A;
                    goto case 0x953A;
                case 0x953A:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x953C;
                    goto case 0x953C;
                case 0x953C:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x953D;
                    goto case 0x953D;
                case 0x953D:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0x953F;
                    goto case 0x953F;
                case 0x953E:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x953F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x955D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x955D; }
                    PC = 0x9541; goto case 0x9541;
                case 0x9541:
                    A = _ram[0x072B]; SetZN(A); TotalCycles += 4; PC = 0x9544;
                    goto case 0x9544;
                case 0x9544:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x955D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x955D; }
                    PC = 0x9546; goto case 0x9546;
                case 0x9546:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9547;
                    goto case 0x9547;
                case 0x9547:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9549;
                    goto case 0x9549;
                case 0x9549:
                    A &= 0x1F; SetZN(A); TotalCycles += 2; PC = 0x954B;
                    goto case 0x954B;
                case 0x954B:
                    _ram[0x072A] = A; TotalCycles += 4; PC = 0x954E;
                    goto case 0x954E;
                case 0x954C:
                    A = Rol(A); TotalCycles += 2; PC = 0x954D;
                    return;
                case 0x954E:
                    _ram[0x072B] = IncVal(_ram[0x072B]); TotalCycles += 6; PC = 0x9551;
                    goto case 0x9551;
                case 0x9551:
                    TotalCycles += 3; PC = 0x956E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x956E;
                case 0x9552:
                    { int a = 0xC995; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0x9555;
                    goto case 0x9555;
                case 0x9553:
                    _ram[(byte)(0xC9 + X)] = A; TotalCycles += 4; PC = 0x9555;
                    goto case 0x9555;
                case 0x9554:
                    Cmp(A, 0x0E); TotalCycles += 2; PC = 0x9556;
                    goto case 0x9556;
                case 0x9555:
                    _ram[0x05D0] = Asl(_ram[0x05D0]); TotalCycles += 6; PC = 0x9558;
                    goto case 0x9558;
                case 0x9556:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x955D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x955D; }
                    PC = 0x9558; goto case 0x9558;
                case 0x9557:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0x9559;
                    goto case 0x9559;
                case 0x9558:
                    A = _ram[0x0728]; SetZN(A); TotalCycles += 4; PC = 0x955B;
                    goto case 0x955B;
                case 0x9559:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x955A;
                    return;
                case 0x955B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9565; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9565; }
                    PC = 0x955D; goto case 0x955D;
                case 0x955C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x955D;
                    goto case 0x955D;
                case 0x955D:
                    A = _ram[0x072A]; SetZN(A); TotalCycles += 4; PC = 0x9560;
                    goto case 0x9560;
                case 0x955E:
                    A = Rol(A); TotalCycles += 2; PC = 0x955F;
                    return;
                case 0x9560:
                    Cmp(A, _ram[0x0725]); TotalCycles += 4; PC = 0x9563;
                    goto case 0x9563;
                case 0x9561:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9563;
                    goto case 0x9563;
                case 0x9563:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x956B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x956B; }
                    PC = 0x9565; goto case 0x9565;
                case 0x9564:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x9566;
                    goto case 0x9566;
                case 0x9565:
                    TotalCycles += 6; PushU16(0x9567); PC = 0x9595;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9595;
                case 0x9566:
                    _ram[(byte)(0x95 + X)] = A; TotalCycles += 4; PC = 0x9568;
                    goto case 0x9568;
                case 0x9567:
                    _ram[(byte)(0x4C + X)] = A; TotalCycles += 4; PC = 0x9569;
                    goto case 0x9569;
                case 0x9568:
                    TotalCycles += 3; PC = 0x9571;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9571;
                case 0x9569:
                    Adc(ReadMem(ReadU16Zp(0x95) + Y)); TotalCycles += 5; PC = 0x956B;
                    goto case 0x956B;
                case 0x956A:
                    _ram[(byte)(0xEE + X)] = A; TotalCycles += 4; PC = 0x956C;
                    goto case 0x956C;
                case 0x956B:
                    _ram[0x0729] = IncVal(_ram[0x0729]); TotalCycles += 6; PC = 0x956E;
                    goto case 0x956E;
                case 0x956C:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0x956E;
                    goto case 0x956E;
                case 0x956E:
                    TotalCycles += 6; PushU16(0x9570); PC = 0x9589;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9589;
                case 0x9570:
                    _ram[(byte)(0xA6 + X)] = A; TotalCycles += 4; PC = 0x9572;
                    goto case 0x9572;
                case 0x9571:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0x9573;
                    goto case 0x9573;
                case 0x9572:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9573;
                    goto case 0x9573;
                case 0x9573:
                    A = _ram[(0x0730 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x9576;
                    goto case 0x9576;
                case 0x9574:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x957D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x957D; }
                    PC = 0x9576; goto case 0x9576;
                case 0x9576:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x957B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x957B; }
                    PC = 0x9578; goto case 0x9578;
                case 0x9578:
                    { int a = (0x0730 + X) & 0x07FF; _ram[a] = DecVal(_ram[a]); } TotalCycles += 7; PC = 0x957B;
                    goto case 0x957B;
                case 0x9579:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9582; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9582; }
                    PC = 0x957B; goto case 0x957B;
                case 0x957B:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x957C;
                    goto case 0x957C;
                case 0x957C:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x950A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x950A; }
                    PC = 0x957E; goto case 0x957E;
                case 0x957D:
                    WriteIoReg(0x29AD, Y); TotalCycles += 4; PC = 0x9580;
                    return;
                case 0x957E:
                    A = _ram[0x0729]; SetZN(A); TotalCycles += 4; PC = 0x9581;
                    goto case 0x9581;
                case 0x957F:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0x9581;
                    goto case 0x9581;
                case 0x9581:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9508; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9508; }
                    PC = 0x9583; goto case 0x9583;
                case 0x9582:
                    _ram[0xAD] = A; TotalCycles += 3; PC = 0x9584;
                    goto case 0x9584;
                case 0x9583:
                    A = _ram[0x0728]; SetZN(A); TotalCycles += 4; PC = 0x9586;
                    goto case 0x9586;
                case 0x9584:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9585;
                    return;
                case 0x9586:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9508; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9508; }
                    PC = 0x9588; goto case 0x9588;
                case 0x9588:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9589: // === SUBROUTINE: Sub_9589 ===
                    _ram[0x072C] = IncVal(_ram[0x072C]); TotalCycles += 6; PC = 0x958C;
                    goto case 0x958C;
                case 0x958A:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x6E07]); TotalCycles += 4; PC = 0x958D;
                    goto case 0x958D;
                case 0x958C:
                    _ram[0x072C] = IncVal(_ram[0x072C]); TotalCycles += 6; PC = 0x958F;
                    goto case 0x958F;
                case 0x958D:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x2907]); TotalCycles += 4; PC = 0x9590;
                    goto case 0x9590;
                case 0x958F:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9591;
                    goto case 0x9591;
                case 0x9590:
                    TotalCycles += 7; PushU16(0x9592); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9591:
                    _ram[0x072B] = A; TotalCycles += 4; PC = 0x9594;
                    goto case 0x9594;
                case 0x9594:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9595:
                    A = _ram[(0x0730 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x9598;
                    goto case 0x9598;
                case 0x9596:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x959F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x959F; }
                    PC = 0x9598; goto case 0x9598;
                case 0x9598:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x959D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x959D; }
                    PC = 0x959A; goto case 0x959A;
                case 0x959A:
                    Y = _ram[(0x072D + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x959D;
                    goto case 0x959D;
                case 0x959B:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x2207]; SetZN(A); TotalCycles += 4; PC = 0x959E;
                    goto case 0x959E;
                case 0x959D:
                    X = 0x10; SetZN(X); TotalCycles += 2; PC = 0x959F;
                    goto case 0x959F;
                case 0x959E:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9551; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9551; }
                    PC = 0x95A0; return;
                case 0x959F:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x95A1;
                    goto case 0x95A1;
                case 0x95A1:
                    Cmp(A, 0xFD); TotalCycles += 2; PC = 0x95A3;
                    goto case 0x95A3;
                case 0x95A2:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x63F0 + X) & 0x7FFF]); TotalCycles += 4; PC = 0x95A5;
                    goto case 0x95A5;
                case 0x95A3:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9588; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9588; }
                    PC = 0x95A5; goto case 0x95A5;
                case 0x95A5:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x95A7;
                    goto case 0x95A7;
                case 0x95A7:
                    Cmp(A, 0x0F); TotalCycles += 2; PC = 0x95A9;
                    goto case 0x95A9;
                case 0x95A9:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x95B3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x95B3; }
                    PC = 0x95AB; goto case 0x95AB;
                case 0x95AA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x95AB;
                    goto case 0x95AB;
                case 0x95AB:
                    X = 0x08; SetZN(X); TotalCycles += 2; PC = 0x95AD;
                    goto case 0x95AD;
                case 0x95AC:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x95AD;
                    goto case 0x95AD;
                case 0x95AD:
                    Cmp(A, 0x0C); TotalCycles += 2; PC = 0x95AF;
                    goto case 0x95AF;
                case 0x95AF:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x95B3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x95B3; }
                    PC = 0x95B1; goto case 0x95B1;
                case 0x95B1:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x95B3;
                    goto case 0x95B3;
                case 0x95B2:
                    TotalCycles += 7; PushU16(0x95B4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x95B3:
                    _ram[0x07] = X; TotalCycles += 3; PC = 0x95B5;
                    goto case 0x95B5;
                case 0x95B5:
                    X = _ram[0x08]; SetZN(X); TotalCycles += 3; PC = 0x95B7;
                    goto case 0x95B7;
                case 0x95B6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x95B7;
                    goto case 0x95B7;
                case 0x95B7:
                    Cmp(A, 0x0E); TotalCycles += 2; PC = 0x95B9;
                    goto case 0x95B9;
                case 0x95B8:
                    _ram[0x00D0] = Asl(_ram[0x00D0]); TotalCycles += 6; PC = 0x95BB;
                    goto case 0x95BB;
                case 0x95B9:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x95C3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x95C3; }
                    PC = 0x95BB; goto case 0x95BB;
                case 0x95BA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x95BB;
                    goto case 0x95BB;
                case 0x95BB:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x95BD;
                    goto case 0x95BD;
                case 0x95BC:
                    TotalCycles += 7; PushU16(0x95BE); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x95BD:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0x95BF;
                    goto case 0x95BF;
                case 0x95BF:
                    A = 0x2E; SetZN(A); TotalCycles += 2; PC = 0x95C1;
                    goto case 0x95C1;
                case 0x95C0:
                    { int a = 0x53D0; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0x95C3;
                    goto case 0x95C3;
                case 0x95C1:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9616; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9616; }
                    PC = 0x95C3; goto case 0x95C3;
                case 0x95C3:
                    Cmp(A, 0x0D); TotalCycles += 2; PC = 0x95C5;
                    goto case 0x95C5;
                case 0x95C4:
                    A |= _ram[0x03D0]; SetZN(A); TotalCycles += 4; PC = 0x95C7;
                    goto case 0x95C7;
                case 0x95C5:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x95E2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x95E2; }
                    PC = 0x95C7; goto case 0x95C7;
                case 0x95C7:
                    A = 0x22; SetZN(A); TotalCycles += 2; PC = 0x95C9;
                    goto case 0x95C9;
                case 0x95C9: // === SUBROUTINE: Sub_95C9 ===
                    _ram[0x07] = A; TotalCycles += 3; PC = 0x95CB;
                    goto case 0x95CB;
                case 0x95CB:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x95CC;
                    goto case 0x95CC;
                case 0x95CC:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x95CE;
                    goto case 0x95CE;
                case 0x95CE:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0x95D0;
                    goto case 0x95D0;
                case 0x95CF:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x95D0:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9635; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9635; }
                    PC = 0x95D2; goto case 0x95D2;
                case 0x95D2:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x95D4;
                    goto case 0x95D4;
                case 0x95D4:
                    A &= 0x7F; SetZN(A); TotalCycles += 2; PC = 0x95D6;
                    goto case 0x95D6;
                case 0x95D6:
                    Cmp(A, 0x4B); TotalCycles += 2; PC = 0x95D8;
                    goto case 0x95D8;
                case 0x95D8:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x95DD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x95DD; }
                    PC = 0x95DA; goto case 0x95DA;
                case 0x95DA:
                    _ram[0x0745] = IncVal(_ram[0x0745]); TotalCycles += 6; PC = 0x95DD;
                    goto case 0x95DD;
                case 0x95DB:
                    A ^= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x95DD;
                    goto case 0x95DD;
                case 0x95DD:
                    A &= 0x3F; SetZN(A); TotalCycles += 2; PC = 0x95DF;
                    goto case 0x95DF;
                case 0x95DF:
                    TotalCycles += 3; PC = 0x9616;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9616;
                case 0x95E0:
                    { byte z = (byte)(0x96 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x95E2;
                    goto case 0x95E2;
                case 0x95E1:
                    _ram[(byte)(0xC9 + Y)] = X; TotalCycles += 4; PC = 0x95E3;
                    return;
                case 0x95E2: // === SUBROUTINE: Sub_95E2 ===
                    Cmp(A, 0x0C); TotalCycles += 2; PC = 0x95E4;
                    goto case 0x95E4;
                case 0x95E4:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x960D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x960D; }
                    PC = 0x95E6; goto case 0x95E6;
                case 0x95E6:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x95E7;
                    goto case 0x95E7;
                case 0x95E7:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x95E9;
                    goto case 0x95E9;
                case 0x95E9:
                    A &= 0x70; SetZN(A); TotalCycles += 2; PC = 0x95EB;
                    goto case 0x95EB;
                case 0x95EA:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x95BC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x95BC; }
                    PC = 0x95EC; return;
                case 0x95EB:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x95F8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x95F8; }
                    PC = 0x95ED; goto case 0x95ED;
                case 0x95ED:
                    A = 0x16; SetZN(A); TotalCycles += 2; PC = 0x95EF;
                    goto case 0x95EF;
                case 0x95EE:
                    { byte z = (byte)(0x85 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x95F0;
                    return;
                case 0x95EF:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0x95F1;
                    goto case 0x95F1;
                case 0x95F1:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x95F3;
                    goto case 0x95F3;
                case 0x95F3:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x95F5;
                    goto case 0x95F5;
                case 0x95F5:
                    TotalCycles += 3; PC = 0x9616;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9616;
                case 0x95F6:
                    { byte z = (byte)(0x96 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x95F8;
                    goto case 0x95F8;
                case 0x95F7:
                    _ram[(byte)(0x85 + Y)] = X; TotalCycles += 4; PC = 0x95F9;
                    goto case 0x95F9;
                case 0x95F8:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x95FA;
                    goto case 0x95FA;
                case 0x95F9:
                    TotalCycles += 7; PushU16(0x95FB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x95FA:
                    Cmp(A, 0x70); TotalCycles += 2; PC = 0x95FC;
                    goto case 0x95FC;
                case 0x95FB:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x95CD; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x95FD; goto case 0x95FD;
                case 0x95FC:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9608; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9608; }
                    PC = 0x95FE; goto case 0x95FE;
                case 0x95FD:
                    A = Asl(A); TotalCycles += 2; PC = 0x95FE;
                    goto case 0x95FE;
                case 0x95FE:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9600;
                    goto case 0x9600;
                case 0x9600:
                    A &= 0x08; SetZN(A); TotalCycles += 2; PC = 0x9602;
                    goto case 0x9602;
                case 0x9601:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9602;
                    goto case 0x9602;
                case 0x9602:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9608; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9608; }
                    PC = 0x9604; goto case 0x9604;
                case 0x9604:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9606;
                    goto case 0x9606;
                case 0x9605:
                    TotalCycles += 7; PushU16(0x9607); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9606:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x9608;
                    goto case 0x9608;
                case 0x9607:
                    TotalCycles += 7; PushU16(0x9609); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9608:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x960A;
                    goto case 0x960A;
                case 0x9609:
                    TotalCycles += 7; PushU16(0x960B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x960A:
                    TotalCycles += 3; PC = 0x9612;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9612;
                case 0x960C:
                    _ram[(byte)(0xC8 + Y)] = X; TotalCycles += 4; PC = 0x960E;
                    goto case 0x960E;
                case 0x960D:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x960E;
                    goto case 0x960E;
                case 0x960E:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9610;
                    goto case 0x9610;
                case 0x9610:
                    A &= 0x70; SetZN(A); TotalCycles += 2; PC = 0x9612;
                    goto case 0x9612;
                case 0x9611:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x965D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9613; goto case 0x9613;
                case 0x9612:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9613;
                    goto case 0x9613;
                case 0x9613:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9614;
                    goto case 0x9614;
                case 0x9614:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9615;
                    goto case 0x9615;
                case 0x9615:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9616;
                    goto case 0x9616;
                case 0x9616:
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x9618;
                    goto case 0x9618;
                case 0x9617:
                    TotalCycles += 7; PushU16(0x9619); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9618:
                    A = _ram[(0x0730 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x961B;
                    goto case 0x961B;
                case 0x9619:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9622; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x961B; goto case 0x961B;
                case 0x961B:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x965F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x965F; }
                    PC = 0x961D; goto case 0x961D;
                case 0x961D:
                    A = _ram[0x072A]; SetZN(A); TotalCycles += 4; PC = 0x9620;
                    goto case 0x9620;
                case 0x961E:
                    A = Rol(A); TotalCycles += 2; PC = 0x961F;
                    return;
                case 0x9620:
                    Cmp(A, _ram[0x0725]); TotalCycles += 4; PC = 0x9623;
                    goto case 0x9623;
                case 0x9621:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9623;
                    goto case 0x9623;
                case 0x9623:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9636; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9636; }
                    PC = 0x9625; goto case 0x9625;
                case 0x9624:
                    A |= ReadMem(ReadU16Zp(0xAC) + Y); SetZN(A); TotalCycles += 5; PC = 0x9626;
                    goto case 0x9626;
                case 0x9625:
                    Y = _ram[0x072C]; SetZN(Y); TotalCycles += 4; PC = 0x9628;
                    goto case 0x9628;
                case 0x9626:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x3107]); TotalCycles += 4; PC = 0x9629;
                    return;
                case 0x9628:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x962A;
                    goto case 0x962A;
                case 0x962A:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x962C;
                    goto case 0x962C;
                case 0x962C:
                    Cmp(A, 0x0E); TotalCycles += 2; PC = 0x962E;
                    goto case 0x962E;
                case 0x962D:
                    _ram[0x05D0] = Asl(_ram[0x05D0]); TotalCycles += 6; PC = 0x9630;
                    goto case 0x9630;
                case 0x962E:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9635; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9635; }
                    PC = 0x9630; goto case 0x9630;
                case 0x962F:
                    A |= _ram[0xAD]; SetZN(A); TotalCycles += 3; PC = 0x9631;
                    goto case 0x9631;
                case 0x9630:
                    A = _ram[0x0728]; SetZN(A); TotalCycles += 4; PC = 0x9633;
                    goto case 0x9633;
                case 0x9631:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9632;
                    return;
                case 0x9633:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9656; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9656; }
                    PC = 0x9635; goto case 0x9635;
                case 0x9634:
                    A &= ReadMem(ReadU16Zp((byte)(0x60 + X))); SetZN(A); TotalCycles += 6; PC = 0x9636;
                    goto case 0x9636;
                case 0x9635:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9636:
                    A = _ram[0x0728]; SetZN(A); TotalCycles += 4; PC = 0x9639;
                    goto case 0x9639;
                case 0x9637:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9638;
                    return;
                case 0x9639:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9646; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9646; }
                    PC = 0x963B; goto case 0x963B;
                case 0x963B:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x963D;
                    goto case 0x963D;
                case 0x963C:
                    TotalCycles += 7; PushU16(0x963E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x963D:
                    _ram[0x0728] = A; TotalCycles += 4; PC = 0x9640;
                    goto case 0x9640;
                case 0x963E:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x963F;
                    return;
                case 0x9640:
                    _ram[0x0729] = A; TotalCycles += 4; PC = 0x9643;
                    goto case 0x9643;
                case 0x9641:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0x9643;
                    goto case 0x9643;
                case 0x9643:
                    _ram[0x08] = A; TotalCycles += 3; PC = 0x9645;
                    goto case 0x9645;
                case 0x9644:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9645;
                    goto case 0x9645;
                case 0x9645:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9646:
                    Y = _ram[0x072C]; SetZN(Y); TotalCycles += 4; PC = 0x9649;
                    goto case 0x9649;
                case 0x9647:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x3107]); TotalCycles += 4; PC = 0x964A;
                    return;
                case 0x9649:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x964B;
                    goto case 0x964B;
                case 0x964B:
                    A &= 0xF0; SetZN(A); TotalCycles += 2; PC = 0x964D;
                    goto case 0x964D;
                case 0x964C:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9698; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x964E; goto case 0x964E;
                case 0x964D:
                    A = Lsr(A); TotalCycles += 2; PC = 0x964E;
                    goto case 0x964E;
                case 0x964E:
                    A = Lsr(A); TotalCycles += 2; PC = 0x964F;
                    goto case 0x964F;
                case 0x964F:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9650;
                    goto case 0x9650;
                case 0x9650:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9651;
                    goto case 0x9651;
                case 0x9651:
                    Cmp(A, _ram[0x0726]); TotalCycles += 4; PC = 0x9654;
                    goto case 0x9654;
                case 0x9652:
                    _ram[0x07] = Rol(_ram[0x07]); TotalCycles += 5; PC = 0x9654;
                    goto case 0x9654;
                case 0x9654:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9635; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9635; }
                    PC = 0x9656; goto case 0x9656;
                case 0x9656:
                    A = _ram[0x072C]; SetZN(A); TotalCycles += 4; PC = 0x9659;
                    goto case 0x9659;
                case 0x9657:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x1D07]); TotalCycles += 4; PC = 0x965A;
                    goto case 0x965A;
                case 0x9659:
                    _ram[(0x072D + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x965C;
                    goto case 0x965C;
                case 0x965A:
                    A &= ReadIoReg(0x2007); SetZN(A); TotalCycles += 4; PC = 0x965D;
                    return;
                case 0x965C:
                    TotalCycles += 6; PushU16(0x965E); PC = 0x9589;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9589;
                case 0x965E:
                    _ram[(byte)(0xA5 + X)] = A; TotalCycles += 4; PC = 0x9660;
                    goto case 0x9660;
                case 0x965F:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x9661;
                    goto case 0x9661;
                case 0x9660:
                    TotalCycles += 7; PushU16(0x9662); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9661: // === SUBROUTINE: DecodeAreaData_ObjectJumpTable ===
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9662;
                    goto case 0x9662;
                case 0x9662:
                    Adc(_ram[0x07]); TotalCycles += 3; PC = 0x9664;
                    goto case 0x9664;
                case 0x9664:
                    TotalCycles += 6; PushU16(0x9666); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E04;
                case 0x9666:
                    WriteIoReg(0x98E5, X); TotalCycles += 4; PC = 0x9669;
                    goto case 0x9669;
                case 0x9667:
                    Sbc(_ram[0x98]); TotalCycles += 3; PC = 0x9669;
                    goto case 0x9669;
                case 0x9668:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x9669;
                    goto case 0x9669;
                case 0x9669:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x966B:
                    { int a = 0x3E9A; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0x966E;
                    goto case 0x966E;
                case 0x966C:
                    SP = X; TotalCycles += 2; PC = 0x966D;
                    goto case 0x966D;
                case 0x966D:
                    { int a = 0xF29A + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0x9670;
                    goto case 0x9670;
                case 0x966E:
                    SP = X; TotalCycles += 2; PC = 0x966F;
                    return;
                case 0x9670:
                    WriteMem(0x9A50 + Y, A); TotalCycles += 5; PC = 0x9673;
                    goto case 0x9673;
                case 0x9671:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x960D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x960D; }
                    PC = 0x9673; goto case 0x9673;
                case 0x9672:
                    SP = X; TotalCycles += 2; PC = 0x9673;
                    goto case 0x9673;
                case 0x9673:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x659A + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9676;
                    goto case 0x9676;
                case 0x9674:
                    SP = X; TotalCycles += 2; PC = 0x9675;
                    goto case 0x9675;
                case 0x9675:
                    Sbc(_ram[0x98]); TotalCycles += 3; PC = 0x9677;
                    goto case 0x9677;
                case 0x9676:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x9677;
                    goto case 0x9677;
                case 0x9677:
                    A ^= ReadMem(ReadU16Zp((byte)(0x9B + X))); SetZN(A); TotalCycles += 6; PC = 0x9679;
                    goto case 0x9679;
                case 0x9679:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0x967A;
                    return;
                case 0x967B:
                    Adc(ReadMem(0x7C99 + Y)); TotalCycles += 4; PC = 0x967E;
                    goto case 0x967E;
                case 0x967C:
                    WriteMem(0x997C + Y, A); TotalCycles += 5; PC = 0x967F;
                    return;
                case 0x967E:
                    WriteMem(0x997F + Y, A); TotalCycles += 5; PC = 0x9681;
                    return;
                case 0x9680:
                    WriteMem(0x9957 + Y, A); TotalCycles += 5; PC = 0x9683;
                    goto case 0x9683;
                case 0x9682:
                    WriteMem(0x9968 + Y, A); TotalCycles += 5; PC = 0x9685;
                    return;
                case 0x9683:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9684;
                    goto case 0x9684;
                case 0x9684:
                    WriteMem(0x996B + Y, A); TotalCycles += 5; PC = 0x9687;
                    goto case 0x9687;
                case 0x9686:
                    WriteMem(0x99D0 + Y, A); TotalCycles += 5; PC = 0x9689;
                    return;
                case 0x9687:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9622; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9689; return;
                case 0x9688:
                    WriteMem(0x99D7 + Y, A); TotalCycles += 5; PC = 0x968B;
                    goto case 0x968B;
                case 0x968A:
                    WriteMem(0x9806 + Y, A); TotalCycles += 5; PC = 0x968D;
                    return;
                case 0x968B:
                    _ram[0x98] = Asl(_ram[0x98]); TotalCycles += 5; PC = 0x968D;
                    return;
                case 0x968C:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x968D;
                    return;
                case 0x968E:
                    SP = X; TotalCycles += 2; PC = 0x968F;
                    return;
                case 0x9690:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x9691;
                    goto case 0x9691;
                case 0x9691:
                    _ram[(byte)(0x99 + X)] = Y; TotalCycles += 4; PC = 0x9693;
                    goto case 0x9693;
                case 0x9692:
                    WriteMem(0x9B0E + Y, A); TotalCycles += 5; PC = 0x9695;
                    goto case 0x9695;
                case 0x9693:
                    _ram[0x069B] = Asl(_ram[0x069B]); TotalCycles += 6; PC = 0x9696;
                    return;
                case 0x9695:
                    _ram[0x069B] = Asl(_ram[0x069B]); TotalCycles += 6; PC = 0x9698;
                    return;
                case 0x9697:
                    _ram[0x019B] = Asl(_ram[0x019B]); TotalCycles += 6; PC = 0x969A;
                    return;
                case 0x9699:
                    A |= ReadMem(ReadU16Zp((byte)(0x9B + X))); SetZN(A); TotalCycles += 6; PC = 0x969B;
                    goto case 0x969B;
                case 0x969B:
                    A |= ReadMem(0x199B + Y); SetZN(A); TotalCycles += 4; PC = 0x969E;
                    return;
                case 0x969D:
                    A |= ReadMem(0x199B + Y); SetZN(A); TotalCycles += 4; PC = 0x96A0;
                    return;
                case 0x969F:
                    A |= ReadMem(0x149B + Y); SetZN(A); TotalCycles += 4; PC = 0x96A2;
                    return;
                case 0x96A3:
                    A |= ReadMem(0x6F9B + Y); SetZN(A); TotalCycles += 4; PC = 0x96A6;
                    goto case 0x96A6;
                case 0x96A6:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x96A7;
                    goto case 0x96A7;
                case 0x96A7:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x539A + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x96AA;
                    goto case 0x96AA;
                case 0x96A8:
                    SP = X; TotalCycles += 2; PC = 0x96A9;
                    return;
                case 0x96AA:
                    SP = X; TotalCycles += 2; PC = 0x96AB;
                    return;
                case 0x96AC:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x96AD;
                    return;
                case 0x96AE:
                    WriteMem(0x9A09 + Y, A); TotalCycles += 5; PC = 0x96B1;
                    goto case 0x96B1;
                case 0x96AF:
                    A |= 0x9A; SetZN(A); TotalCycles += 2; PC = 0x96B1;
                    goto case 0x96B1;
                case 0x96B0:
                    SP = X; TotalCycles += 2; PC = 0x96B1;
                    goto case 0x96B1;
                case 0x96B1:
                    _ram[0x019A] = Asl(_ram[0x019A]); TotalCycles += 6; PC = 0x96B4;
                    goto case 0x96B4;
                case 0x96B2:
                    SP = X; TotalCycles += 2; PC = 0x96B3;
                    goto case 0x96B3;
                case 0x96B3:
                    A |= ReadMem(ReadU16Zp((byte)(0x9A + X))); SetZN(A); TotalCycles += 6; PC = 0x96B5;
                    return;
                case 0x96B4:
                    SP = X; TotalCycles += 2; PC = 0x96B5;
                    return;
                case 0x96B6:
                    _ram[(byte)(0x0D + Y)] = X; TotalCycles += 4; PC = 0x96B8;
                    return;
                case 0x96B7:
                    A |= _ram[0x0597]; SetZN(A); TotalCycles += 4; PC = 0x96BA;
                    return;
                case 0x96B9:
                    A |= ReadIoReg(0x2B97); SetZN(A); TotalCycles += 4; PC = 0x96BC;
                    return;
                case 0x96C1:
                    A ^= _ram[0x96]; SetZN(A); TotalCycles += 3; PC = 0x96C3;
                    goto case 0x96C3;
                case 0x96C2:
                    _ram[(byte)(0xC5 + Y)] = X; TotalCycles += 4; PC = 0x96C4;
                    goto case 0x96C4;
                case 0x96C3:
                    Cmp(A, _ram[0x96]); TotalCycles += 3; PC = 0x96C5;
                    goto case 0x96C5;
                case 0x96C4:
                    _ram[(byte)(0xBC + Y)] = X; TotalCycles += 4; PC = 0x96C6;
                    goto case 0x96C6;
                case 0x96C5:
                    Y = _ram[(0x072D + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x96C8;
                    goto case 0x96C8;
                case 0x96C6:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x4807]; SetZN(A); TotalCycles += 4; PC = 0x96C9;
                    goto case 0x96C9;
                case 0x96C8:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x96C9;
                    goto case 0x96C9;
                case 0x96C9:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x96CB;
                    goto case 0x96CB;
                case 0x96CB:
                    PushU8(A); TotalCycles += 3; PC = 0x96CC;
                    goto case 0x96CC;
                case 0x96CC:
                    A &= 0x40; SetZN(A); TotalCycles += 2; PC = 0x96CE;
                    goto case 0x96CE;
                case 0x96CD:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x96CE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x96E2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x96E2; }
                    PC = 0x96D0; goto case 0x96D0;
                case 0x96D0:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x96D1;
                    goto case 0x96D1;
                case 0x96D1:
                    PushU8(A); TotalCycles += 3; PC = 0x96D2;
                    goto case 0x96D2;
                case 0x96D2:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x96D4;
                    goto case 0x96D4;
                case 0x96D4:
                    _ram[0x0727] = A; TotalCycles += 4; PC = 0x96D7;
                    goto case 0x96D7;
                case 0x96D7:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x96D8;
                    goto case 0x96D8;
                case 0x96D8:
                    A &= 0x30; SetZN(A); TotalCycles += 2; PC = 0x96DA;
                    goto case 0x96DA;
                case 0x96D9:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9725; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9725; }
                    PC = 0x96DB; goto case 0x96DB;
                case 0x96DA:
                    A = Lsr(A); TotalCycles += 2; PC = 0x96DB;
                    goto case 0x96DB;
                case 0x96DB:
                    A = Lsr(A); TotalCycles += 2; PC = 0x96DC;
                    goto case 0x96DC;
                case 0x96DC:
                    A = Lsr(A); TotalCycles += 2; PC = 0x96DD;
                    goto case 0x96DD;
                case 0x96DD:
                    A = Lsr(A); TotalCycles += 2; PC = 0x96DE;
                    goto case 0x96DE;
                case 0x96DE:
                    _ram[0x0742] = A; TotalCycles += 4; PC = 0x96E1;
                    goto case 0x96E1;
                case 0x96E1:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x96E2:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x96E3;
                    goto case 0x96E3;
                case 0x96E3:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0x96E5;
                    goto case 0x96E5;
                case 0x96E5:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0x96E7;
                    goto case 0x96E7;
                case 0x96E7:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x96EE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x96EE; }
                    PC = 0x96E9; goto case 0x96E9;
                case 0x96E8:
                    A |= _ram[0x8D]; SetZN(A); TotalCycles += 3; PC = 0x96EA;
                    return;
                case 0x96E9:
                    _ram[0x0744] = A; TotalCycles += 4; PC = 0x96EC;
                    goto case 0x96EC;
                case 0x96EC:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x96EE;
                    goto case 0x96EE;
                case 0x96ED:
                    TotalCycles += 7; PushU16(0x96EF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x96EE:
                    _ram[0x0741] = A; TotalCycles += 4; PC = 0x96F1;
                    goto case 0x96F1;
                case 0x96EF:
                    A ^= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x96F1;
                    goto case 0x96F1;
                case 0x96F1:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x96F2:
                    X = 0x04; SetZN(X); TotalCycles += 2; PC = 0x96F4;
                    goto case 0x96F4;
                case 0x96F4:
                    A = _ram[0x075F]; SetZN(A); TotalCycles += 4; PC = 0x96F7;
                    goto case 0x96F7;
                case 0x96F7:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9701; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9701; }
                    PC = 0x96F9; goto case 0x96F9;
                case 0x96F8:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x96F9;
                    goto case 0x96F9;
                case 0x96F9:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x96FA;
                    goto case 0x96FA;
                case 0x96FA:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x96FD;
                    goto case 0x96FD;
                case 0x96FB:
                    { int a = 0x8807; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x96FE;
                    goto case 0x96FE;
                case 0x96FD:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x96FE;
                    goto case 0x96FE;
                case 0x96FE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9701; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9701; }
                    PC = 0x9700; goto case 0x9700;
                case 0x96FF:
                    A |= ReadMem(ReadU16Zp((byte)(0xE8 + X))); SetZN(A); TotalCycles += 6; PC = 0x9701;
                    goto case 0x9701;
                case 0x9700:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9701;
                    goto case 0x9701;
                case 0x9701:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x9702;
                    goto case 0x9702;
                case 0x9702:
                    _ram[0x06D6] = A; TotalCycles += 4; PC = 0x9705;
                    goto case 0x9705;
                case 0x9703:
                    { byte z = (byte)(0x06 + X); _ram[z] = DecVal(_ram[z]); } TotalCycles += 6; PC = 0x9705;
                    goto case 0x9705;
                case 0x9704:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x9706;
                    goto case 0x9706;
                case 0x9705:
                    TotalCycles += 6; PushU16(0x9707); PC = 0x8808;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8808;
                case 0x9706:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9707;
                    goto case 0x9707;
                case 0x9707:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9708;
                    goto case 0x9708;
                case 0x9708:
                    A = 0x0D; SetZN(A); TotalCycles += 2; PC = 0x970A;
                    goto case 0x970A;
                case 0x9709:
                    A |= _ram[0x0620]; SetZN(A); TotalCycles += 4; PC = 0x970C;
                    return;
                case 0x970A:
                    TotalCycles += 6; PushU16(0x970C); PC = 0x9716;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9716;
                case 0x970B:
                    { byte z = (byte)(0x97 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x970D;
                    goto case 0x970D;
                case 0x970D:
                    A = _ram[0x0723]; SetZN(A); TotalCycles += 4; PC = 0x9710;
                    goto case 0x9710;
                case 0x9710:
                    A ^= 0x01; SetZN(A); TotalCycles += 2; PC = 0x9712;
                    goto case 0x9712;
                case 0x9711:
                    A |= ReadMem(ReadU16Zp((byte)(0x8D + X))); SetZN(A); TotalCycles += 6; PC = 0x9713;
                    return;
                case 0x9712:
                    _ram[0x0723] = A; TotalCycles += 4; PC = 0x9715;
                    goto case 0x9715;
                case 0x9715:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9716: // === SUBROUTINE: Sub_9716 ===
                    _ram[0x00] = A; TotalCycles += 3; PC = 0x9718;
                    goto case 0x9718;
                case 0x9717:
                    TotalCycles += 7; PushU16(0x9719); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9718:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x971A;
                    goto case 0x971A;
                case 0x9719:
                    TotalCycles += 7; PushU16(0x971B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x971A:
                    X = 0x04; SetZN(X); TotalCycles += 2; PC = 0x971C;
                    goto case 0x971C;
                case 0x971C:
                    Y = _ram[(byte)(0x16 + X)]; SetZN(Y); TotalCycles += 4; PC = 0x971E;
                    goto case 0x971E;
                case 0x971D:
                    { byte z = (byte)(0xC4 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x971F;
                    goto case 0x971F;
                case 0x971E:
                    Cmp(Y, _ram[0x00]); TotalCycles += 3; PC = 0x9720;
                    goto case 0x9720;
                case 0x971F:
                    TotalCycles += 7; PushU16(0x9721); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9720:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9724; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9724; }
                    PC = 0x9722; goto case 0x9722;
                case 0x9722:
                    _ram[(byte)(0x0F + X)] = A; TotalCycles += 4; PC = 0x9724;
                    goto case 0x9724;
                case 0x9724:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x9725;
                    goto case 0x9725;
                case 0x9725:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x971C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x971C; }
                    PC = 0x9727; goto case 0x9727;
                case 0x9726:
                    Sbc(_ram[(byte)(0x60 + X)]); TotalCycles += 4; PC = 0x9728;
                    return;
                case 0x9727:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x972A:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x972B;
                    goto case 0x972B;
                case 0x972B:
                    X = _ram[0x00]; SetZN(X); TotalCycles += 3; PC = 0x972D;
                    goto case 0x972D;
                case 0x972C:
                    TotalCycles += 7; PushU16(0x972E); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x972D:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1720 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9730;
                    goto case 0x9730;
                case 0x972E:
                    TotalCycles += 6; PushU16(0x9730); PC = 0xA097;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9730:
                    Y = 0x05; SetZN(Y); TotalCycles += 2; PC = 0x9732;
                    goto case 0x9732;
                case 0x9731:
                    A |= _ram[0x88]; SetZN(A); TotalCycles += 3; PC = 0x9733;
                    goto case 0x9733;
                case 0x9732:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9733;
                    goto case 0x9733;
                case 0x9733:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x973C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x973C; }
                    PC = 0x9735; goto case 0x9735;
                case 0x9735:
                    Cmp(A, _ram[(0x0016 + Y) & 0x07FF]); TotalCycles += 4; PC = 0x9738;
                    goto case 0x9738;
                case 0x9736:
                    { byte z = (byte)(0x00 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x9738;
                    goto case 0x9738;
                case 0x9737:
                    TotalCycles += 7; PushU16(0x9739); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9738:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9732; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9732; }
                    PC = 0x973A; goto case 0x973A;
                case 0x9739:
                    P |= FlagD; TotalCycles += 2; PC = 0x973A;
                    goto case 0x973A;
                case 0x973A:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x973C;
                    goto case 0x973C;
                case 0x973B:
                    TotalCycles += 7; PushU16(0x973D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x973C:
                    _ram[0x06CD] = A; TotalCycles += 4; PC = 0x973F;
                    goto case 0x973F;
                case 0x973D:
                    Cmp(A, ReadIoReg(0x6006)); TotalCycles += 4; PC = 0x9740;
                    goto case 0x9740;
                case 0x973E:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x9740;
                    goto case 0x9740;
                case 0x973F:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9740: // === SUBROUTINE: LargeObjectSubroutines ===
                    A = _ram[0x0733]; SetZN(A); TotalCycles += 4; PC = 0x9743;
                    goto case 0x9743;
                case 0x9743:
                    TotalCycles += 6; PushU16(0x9745); PC = 0x8E04;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8E04;
                case 0x9745:
                    WriteIoReg(0x974C, X); TotalCycles += 4; PC = 0x9748;
                    goto case 0x9748;
                case 0x9746:
                    TotalCycles += 3; PC = 0x7897;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9748:
                    P |= FlagI; TotalCycles += 2; PC = 0x9749;
                    return;
                case 0x974A:
                    Adc(0x9A); TotalCycles += 2; PC = 0x974C;
                    goto case 0x974C;
                case 0x974B:
                    SP = X; TotalCycles += 2; PC = 0x974C;
                    goto case 0x974C;
                case 0x974C:
                    TotalCycles += 6; PushU16(0x974E); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x974F:
                    A = _ram[(0x0730 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x9752;
                    goto case 0x9752;
                case 0x9750:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9759; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9752; goto case 0x9752;
                case 0x9752:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9773; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9773; }
                    PC = 0x9754; goto case 0x9754;
                case 0x9754:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9767; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9767; }
                    PC = 0x9756; goto case 0x9756;
                case 0x9755:
                    A |= ReadMem(ReadU16Zp(0x98) + Y); SetZN(A); TotalCycles += 5; PC = 0x9757;
                    goto case 0x9757;
                case 0x9756:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x9757;
                    goto case 0x9757;
                case 0x9757:
                    _ram[(0x0730 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x975A;
                    goto case 0x975A;
                case 0x9758:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9761; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9761; }
                    PC = 0x975A; goto case 0x975A;
                case 0x975A:
                    A = _ram[0x0725]; SetZN(A); TotalCycles += 4; PC = 0x975D;
                    goto case 0x975D;
                case 0x975B:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x975D;
                    goto case 0x975D;
                case 0x975D:
                    A |= _ram[0x0726]; SetZN(A); TotalCycles += 4; PC = 0x9760;
                    goto case 0x9760;
                case 0x975E:
                    _ram[0x07] = Rol(_ram[0x07]); TotalCycles += 5; PC = 0x9760;
                    goto case 0x9760;
                case 0x9760:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9767; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9767; }
                    PC = 0x9762; goto case 0x9762;
                case 0x9761:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0x9763;
                    goto case 0x9763;
                case 0x9762:
                    A = 0x16; SetZN(A); TotalCycles += 2; PC = 0x9764;
                    goto case 0x9764;
                case 0x9763:
                    { byte z = (byte)(0x4C + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x9765;
                    goto case 0x9765;
                case 0x9764:
                    TotalCycles += 3; PC = 0x97B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x97B0;
                case 0x9765:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x96FE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x96FE; }
                    PC = 0x9767; goto case 0x9767;
                case 0x9767:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9769;
                    goto case 0x9769;
                case 0x9769:
                    A = 0x17; SetZN(A); TotalCycles += 2; PC = 0x976B;
                    goto case 0x976B;
                case 0x976B:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x976E;
                    goto case 0x976E;
                case 0x976C:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x976E;
                    goto case 0x976E;
                case 0x976D:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0x976F;
                    goto case 0x976F;
                case 0x976E:
                    A = 0x4C; SetZN(A); TotalCycles += 2; PC = 0x9770;
                    goto case 0x9770;
                case 0x976F:
                    TotalCycles += 3; PC = 0xAA4C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9770:
                    TotalCycles += 3; PC = 0x97AA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x97AA;
                case 0x9771:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9772;
                    return;
                case 0x9773:
                    A = 0x18; SetZN(A); TotalCycles += 2; PC = 0x9775;
                    goto case 0x9775;
                case 0x9774:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9775;
                    goto case 0x9775;
                case 0x9775:
                    TotalCycles += 3; PC = 0x97B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x97B0;
                case 0x9776:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x970F; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9778; goto case 0x9778;
                case 0x9778:
                    TotalCycles += 6; PushU16(0x977A); PC = 0x9BAC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAC;
                case 0x9779:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x049B]; SetZN(Y); TotalCycles += 4; PC = 0x977C;
                    goto case 0x977C;
                case 0x977B:
                    _ram[0x06] = Y; TotalCycles += 3; PC = 0x977D;
                    goto case 0x977D;
                case 0x977C:
                    _ram[0x90] = Asl(_ram[0x90]); TotalCycles += 5; PC = 0x977E;
                    return;
                case 0x977D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x978B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x978B; }
                    PC = 0x977F; goto case 0x977F;
                case 0x977F:
                    A = _ram[(0x0730 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x9782;
                    goto case 0x9782;
                case 0x9780:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9789; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9789; }
                    PC = 0x9782; goto case 0x9782;
                case 0x9782:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9783;
                    goto case 0x9783;
                case 0x9783:
                    _ram[(0x0736 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9786;
                    goto case 0x9786;
                case 0x9784:
                    { byte z = (byte)(0x07 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9786;
                    goto case 0x9786;
                case 0x9786:
                    A = 0x19; SetZN(A); TotalCycles += 2; PC = 0x9788;
                    goto case 0x9788;
                case 0x9787:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x304C + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x978A;
                    return;
                case 0x9788:
                    TotalCycles += 3; PC = 0x97B0;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x97B0;
                case 0x9789:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x9722; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9722; }
                    PC = 0x978B; goto case 0x978B;
                case 0x978B:
                    A = 0x1B; SetZN(A); TotalCycles += 2; PC = 0x978D;
                    goto case 0x978D;
                case 0x978D:
                    Y = _ram[(0x0730 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x9790;
                    goto case 0x9790;
                case 0x978E:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9797; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9797; }
                    PC = 0x9790; goto case 0x9790;
                case 0x9790:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x97B0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x97B0; }
                    PC = 0x9792; goto case 0x9792;
                case 0x9791:
                    { int a = 0x36BD + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x9794;
                    return;
                case 0x9792:
                    A = _ram[(0x0736 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x9795;
                    goto case 0x9795;
                case 0x9793:
                    { byte z = (byte)(0x07 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9795;
                    goto case 0x9795;
                case 0x9795:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0x9797;
                    goto case 0x9797;
                case 0x9796:
                    _ram[0xA6] = Asl(_ram[0xA6]); TotalCycles += 5; PC = 0x9798;
                    return;
                case 0x9797:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9799;
                    goto case 0x9799;
                case 0x9799:
                    A = 0x1A; SetZN(A); TotalCycles += 2; PC = 0x979B;
                    goto case 0x979B;
                case 0x979B:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x979E;
                    goto case 0x979E;
                case 0x979C:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x979E;
                    goto case 0x979E;
                case 0x979D:
                    _ram[0xC4] = Asl(_ram[0xC4]); TotalCycles += 5; PC = 0x979F;
                    goto case 0x979F;
                case 0x979E:
                    Cmp(Y, _ram[0x06]); TotalCycles += 3; PC = 0x97A0;
                    goto case 0x97A0;
                case 0x979F:
                    _ram[0xD0] = Asl(_ram[0xD0]); TotalCycles += 5; PC = 0x97A1;
                    goto case 0x97A1;
                case 0x97A0:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x97CE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x97CE; }
                    PC = 0x97A2; goto case 0x97A2;
                case 0x97A1:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x29E8]); TotalCycles += 4; PC = 0x97A4;
                    return;
                case 0x97A2:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x97A3;
                    goto case 0x97A3;
                case 0x97A3:
                    A = 0x4F; SetZN(A); TotalCycles += 2; PC = 0x97A5;
                    goto case 0x97A5;
                case 0x97A5:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x97A8;
                    goto case 0x97A8;
                case 0x97A6:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x97A8;
                    goto case 0x97A8;
                case 0x97A7:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0x97A9;
                    goto case 0x97A9;
                case 0x97A8:
                    A = 0x50; SetZN(A); TotalCycles += 2; PC = 0x97AA;
                    goto case 0x97AA;
                case 0x97A9:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x9793; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9793; }
                    PC = 0x97AB; goto case 0x97AB;
                case 0x97AA:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x97AB;
                    goto case 0x97AB;
                case 0x97AB:
                    Y = 0x0F; SetZN(Y); TotalCycles += 2; PC = 0x97AD;
                    goto case 0x97AD;
                case 0x97AD:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x97AE:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x269B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x97B1;
                    return;
                case 0x97B0:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x97B2;
                    goto case 0x97B2;
                case 0x97B2:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x97B4;
                    goto case 0x97B4;
                case 0x97B3:
                    TotalCycles += 7; PushU16(0x97B5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x97B4:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x97B5:
                    Adc(ReadMem(0x429B + X)); TotalCycles += 4; PC = 0x97B8;
                    goto case 0x97B8;
                case 0x97B8:
                    A ^= ReadMem(ReadU16Zp((byte)(0x43 + X))); SetZN(A); TotalCycles += 6; PC = 0x97BA;
                    goto case 0x97BA;
                case 0x97BA:
                    TotalCycles += 6; PushU16(0x97BC); PC = 0x9BAC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAC;
                case 0x97BB:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x209B]; SetZN(Y); TotalCycles += 4; PC = 0x97BE;
                    goto case 0x97BE;
                case 0x97BD:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x97BF;
                    goto case 0x97BF;
                case 0x97BE:
                    TotalCycles += 7; PushU16(0x97C0); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x97BF:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x97C8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x97C8; }
                    PC = 0x97C1; goto case 0x97C1;
                case 0x97C1:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x97C2;
                    goto case 0x97C2;
                case 0x97C2:
                    A = _ram[(0x0730 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x97C5;
                    goto case 0x97C5;
                case 0x97C3:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x97CC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x97CC; }
                    PC = 0x97C5; goto case 0x97C5;
                case 0x97C5:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x97C8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x97C8; }
                    PC = 0x97C7; goto case 0x97C7;
                case 0x97C6:
                    A |= ReadMem(ReadU16Zp((byte)(0xC8 + X))); SetZN(A); TotalCycles += 6; PC = 0x97C8;
                    goto case 0x97C8;
                case 0x97C7:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x97C8;
                    goto case 0x97C8;
                case 0x97C8:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x17B7 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x97CB;
                    goto case 0x97CB;
                case 0x97CB:
                    _ram[0x06A1] = A; TotalCycles += 4; PC = 0x97CE;
                    goto case 0x97CE;
                case 0x97CC:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x97CE;
                    goto case 0x97CE;
                case 0x97CD:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x97CF;
                    goto case 0x97CF;
                case 0x97CE:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x97CF:
                    TotalCycles += 7; PushU16(0x97D1); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x97D0:
                    A ^= _ram[0x45]; SetZN(A); TotalCycles += 3; PC = 0x97D2;
                    goto case 0x97D2;
                case 0x97D1:
                    A ^= _ram[0x45]; SetZN(A); TotalCycles += 3; PC = 0x97D3;
                    goto case 0x97D3;
                case 0x97D2:
                    A ^= _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x97D4;
                    goto case 0x97D4;
                case 0x97D3:
                    TotalCycles += 7; PushU16(0x97D5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x97D4:
                    TotalCycles += 7; PushU16(0x97D6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x97D5:
                    PushU8(A); TotalCycles += 3; PC = 0x97D6;
                    return;
                case 0x97D7:
                    _ram[0x00] = Lsr(_ram[0x00]); TotalCycles += 5; PC = 0x97D9;
                    goto case 0x97D9;
                case 0x97D8:
                    TotalCycles += 7; PushU16(0x97DA); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x97D9:
                    A ^= _ram[0x49]; SetZN(A); TotalCycles += 3; PC = 0x97DB;
                    goto case 0x97DB;
                case 0x97DA:
                    A ^= 0x49; SetZN(A); TotalCycles += 2; PC = 0x97DC;
                    goto case 0x97DC;
                case 0x97DB:
                    A ^= 0x49; SetZN(A); TotalCycles += 2; PC = 0x97DD;
                    goto case 0x97DD;
                case 0x97DC:
                    A ^= 0x45; SetZN(A); TotalCycles += 2; PC = 0x97DE;
                    return;
                case 0x97DD:
                    A ^= _ram[0x47]; SetZN(A); TotalCycles += 3; PC = 0x97DF;
                    return;
                case 0x97E0:
                    A = Lsr(A); TotalCycles += 2; PC = 0x97E1;
                    return;
                case 0x97E8:
                    A ^= 0x49; SetZN(A); TotalCycles += 2; PC = 0x97EA;
                    goto case 0x97EA;
                case 0x97E9:
                    A ^= 0x49; SetZN(A); TotalCycles += 2; PC = 0x97EB;
                    goto case 0x97EB;
                case 0x97EA:
                    A ^= 0x49; SetZN(A); TotalCycles += 2; PC = 0x97EC;
                    goto case 0x97EC;
                case 0x97EB:
                    A ^= 0x49; SetZN(A); TotalCycles += 2; PC = 0x97ED;
                    return;
                case 0x97EC:
                    A ^= 0x47; SetZN(A); TotalCycles += 2; PC = 0x97EE;
                    goto case 0x97EE;
                case 0x97EE:
                    A = Lsr(A); TotalCycles += 2; PC = 0x97EF;
                    return;
                case 0x97F0:
                    A = Lsr(A); TotalCycles += 2; PC = 0x97F1;
                    return;
                case 0x97FC:
                    A = Lsr(A); TotalCycles += 2; PC = 0x97FD;
                    return;
                case 0x97FE:
                    A = Lsr(A); TotalCycles += 2; PC = 0x97FF;
                    return;
                case 0x9800:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9801;
                    return;
                case 0x9806:
                    TotalCycles += 6; PushU16(0x9808); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9809:
                    _ram[0x07] = Y; TotalCycles += 3; PC = 0x980B;
                    goto case 0x980B;
                case 0x980B:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0x980D;
                    goto case 0x980D;
                case 0x980D:
                    TotalCycles += 6; PushU16(0x980F); PC = 0x9BAF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAF;
                case 0x9810:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x9811;
                    goto case 0x9811;
                case 0x9811:
                    PushU8(A); TotalCycles += 3; PC = 0x9812;
                    goto case 0x9812;
                case 0x9812:
                    Y = _ram[(0x0730 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x9815;
                    goto case 0x9815;
                case 0x9813:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x981C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9815; goto case 0x9815;
                case 0x9815:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9817;
                    goto case 0x9817;
                case 0x9817:
                    A = 0x0B; SetZN(A); TotalCycles += 2; PC = 0x9819;
                    goto case 0x9819;
                case 0x9819:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0x981B;
                    goto case 0x981B;
                case 0x981A:
                    _ram[0xB9] = Asl(_ram[0xB9]); TotalCycles += 5; PC = 0x981C;
                    return;
                case 0x981B:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x17CF + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x981E;
                    goto case 0x981E;
                case 0x981E:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9821;
                    goto case 0x9821;
                case 0x981F:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x9821;
                    goto case 0x9821;
                case 0x9820:
                    _ram[0xE8] = Asl(_ram[0xE8]); TotalCycles += 5; PC = 0x9822;
                    goto case 0x9822;
                case 0x9821:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9822;
                    goto case 0x9822;
                case 0x9822:
                    A = _ram[0x06]; SetZN(A); TotalCycles += 3; PC = 0x9824;
                    goto case 0x9824;
                case 0x9823:
                    _ram[0xF0] = Asl(_ram[0xF0]); TotalCycles += 5; PC = 0x9825;
                    return;
                case 0x9824:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x982D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x982D; }
                    PC = 0x9826; goto case 0x9826;
                case 0x9826:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9827;
                    goto case 0x9827;
                case 0x9827:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9828;
                    goto case 0x9828;
                case 0x9828:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9829;
                    goto case 0x9829;
                case 0x9829:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x982A;
                    goto case 0x982A;
                case 0x982A:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x982B;
                    goto case 0x982B;
                case 0x982B:
                    _ram[0x06] = DecVal(_ram[0x06]); TotalCycles += 5; PC = 0x982D;
                    goto case 0x982D;
                case 0x982C:
                    _ram[0xE0] = Asl(_ram[0xE0]); TotalCycles += 5; PC = 0x982E;
                    return;
                case 0x982D:
                    Cmp(X, 0x0B); TotalCycles += 2; PC = 0x982F;
                    goto case 0x982F;
                case 0x982F:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x981B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x981B; }
                    PC = 0x9831; goto case 0x9831;
                case 0x9830:
                     TotalCycles += 2; PC = 0x9831;
                    goto case 0x9831;
                case 0x9831:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9832;
                    goto case 0x9832;
                case 0x9832:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9833;
                    goto case 0x9833;
                case 0x9833:
                    A = _ram[0x0725]; SetZN(A); TotalCycles += 4; PC = 0x9836;
                    goto case 0x9836;
                case 0x9834:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9836;
                    goto case 0x9836;
                case 0x9836:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x986E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x986E; }
                    PC = 0x9838; goto case 0x9838;
                case 0x9837:
                    { byte z = (byte)(0xBD + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9839;
                    goto case 0x9839;
                case 0x9838:
                    A = _ram[(0x0730 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x983B;
                    goto case 0x983B;
                case 0x9839:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9842; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x983B; goto case 0x983B;
                case 0x983B:
                    Cmp(A, 0x01); TotalCycles += 2; PC = 0x983D;
                    goto case 0x983D;
                case 0x983C:
                    A |= ReadMem(ReadU16Zp((byte)(0xF0 + X))); SetZN(A); TotalCycles += 6; PC = 0x983E;
                    goto case 0x983E;
                case 0x983D:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9869; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9869; }
                    PC = 0x983F; goto case 0x983F;
                case 0x983E:
                    A = Rol(A); TotalCycles += 2; PC = 0x983F;
                    goto case 0x983F;
                case 0x983F:
                    Y = _ram[0x07]; SetZN(Y); TotalCycles += 3; PC = 0x9841;
                    goto case 0x9841;
                case 0x9841:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9847; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9847; }
                    PC = 0x9843; goto case 0x9843;
                case 0x9843:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0x9845;
                    goto case 0x9845;
                case 0x9845:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9869; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9869; }
                    PC = 0x9847; goto case 0x9847;
                case 0x9847:
                    Cmp(A, 0x02); TotalCycles += 2; PC = 0x9849;
                    goto case 0x9849;
                case 0x9849:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x986E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x986E; }
                    PC = 0x984B; goto case 0x984B;
                case 0x984B:
                    TotalCycles += 6; PushU16(0x984D); PC = 0x9BCB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BCB;
                case 0x984E:
                    PushU8(A); TotalCycles += 3; PC = 0x984F;
                    goto case 0x984F;
                case 0x984F:
                    TotalCycles += 6; PushU16(0x9851); PC = 0x994A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x994A;
                case 0x9850:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9851;
                    goto case 0x9851;
                case 0x9851:
                    WriteMem(0x9568 + Y, A); TotalCycles += 5; PC = 0x9854;
                    return;
                case 0x9852:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9853;
                    goto case 0x9853;
                case 0x9853:
                    _ram[(byte)(0x87 + X)] = A; TotalCycles += 4; PC = 0x9855;
                    goto case 0x9855;
                case 0x9855:
                    A = _ram[0x0725]; SetZN(A); TotalCycles += 4; PC = 0x9858;
                    goto case 0x9858;
                case 0x9856:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9858;
                    goto case 0x9858;
                case 0x9858:
                    _ram[(byte)(0x6E + X)] = A; TotalCycles += 4; PC = 0x985A;
                    goto case 0x985A;
                case 0x9859:
                    _ram[0x01A9] = Ror(_ram[0x01A9]); TotalCycles += 6; PC = 0x985C;
                    goto case 0x985C;
                case 0x985A:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x985C;
                    goto case 0x985C;
                case 0x985B:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0x985D;
                    goto case 0x985D;
                case 0x985C:
                    _ram[(byte)(0xB6 + X)] = A; TotalCycles += 4; PC = 0x985E;
                    goto case 0x985E;
                case 0x985D:
                    X = _ram[(byte)(0x95 + Y)]; SetZN(X); TotalCycles += 4; PC = 0x985F;
                    return;
                case 0x985E:
                    _ram[(byte)(0x0F + X)] = A; TotalCycles += 4; PC = 0x9860;
                    goto case 0x9860;
                case 0x9860:
                    A = 0x90; SetZN(A); TotalCycles += 2; PC = 0x9862;
                    goto case 0x9862;
                case 0x9861:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x97F8; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9863; return;
                case 0x9862:
                    _ram[(byte)(0xCF + X)] = A; TotalCycles += 4; PC = 0x9864;
                    goto case 0x9864;
                case 0x9864:
                    A = 0x31; SetZN(A); TotalCycles += 2; PC = 0x9866;
                    goto case 0x9866;
                case 0x9865:
                    A &= ReadMem(ReadU16Zp(0x95) + Y); SetZN(A); TotalCycles += 5; PC = 0x9867;
                    goto case 0x9867;
                case 0x9866:
                    _ram[(byte)(0x16 + X)] = A; TotalCycles += 4; PC = 0x9868;
                    goto case 0x9868;
                case 0x9867:
                    { byte z = (byte)(0x60 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x9869;
                    goto case 0x9869;
                case 0x9868:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9869:
                    Y = 0x52; SetZN(Y); TotalCycles += 2; PC = 0x986B;
                    goto case 0x986B;
                case 0x986B:
                    _ram[0x06AB] = Y; TotalCycles += 4; PC = 0x986E;
                    goto case 0x986E;
                case 0x986D:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x986F;
                    goto case 0x986F;
                case 0x986E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x986F:
                    TotalCycles += 6; PushU16(0x9871); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9872:
                    Y = _ram[(0x0730 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x9875;
                    goto case 0x9875;
                case 0x9873:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x987C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x987C; }
                    PC = 0x9875; goto case 0x9875;
                case 0x9875:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9877;
                    goto case 0x9877;
                case 0x9877:
                    A = 0x6B; SetZN(A); TotalCycles += 2; PC = 0x9879;
                    goto case 0x9879;
                case 0x9879:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x987C;
                    goto case 0x987C;
                case 0x987A:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x987C;
                    goto case 0x987C;
                case 0x987B:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0x987D;
                    goto case 0x987D;
                case 0x987C:
                    A = 0x6C; SetZN(A); TotalCycles += 2; PC = 0x987E;
                    goto case 0x987E;
                case 0x987D:
                    TotalCycles += 5; PC = ReadU16Zp(0x9D); return;
                case 0x987E:
                    _ram[(0x06A2 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9881;
                    goto case 0x9881;
                case 0x987F:
                    X = 0x06; SetZN(X); TotalCycles += 2; PC = 0x9881;
                    goto case 0x9881;
                case 0x9880:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x9882;
                    goto case 0x9882;
                case 0x9881:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9882:
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0x9884;
                    goto case 0x9884;
                case 0x9884:
                    TotalCycles += 6; PushU16(0x9886); PC = 0x9BAF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAF;
                case 0x9887:
                    Y = 0x0A; SetZN(Y); TotalCycles += 2; PC = 0x9889;
                    goto case 0x9889;
                case 0x9888:
                    A = Asl(A); TotalCycles += 2; PC = 0x9889;
                    goto case 0x9889;
                case 0x9889:
                    TotalCycles += 6; PushU16(0x988B); PC = 0x98B3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x98B3;
                case 0x988B:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x988C;
                    goto case 0x988C;
                case 0x988C:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x989E; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x989E; }
                    PC = 0x988E; goto case 0x988E;
                case 0x988D:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9831; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9831; }
                    PC = 0x988F; goto case 0x988F;
                case 0x988E:
                    X = 0x06; SetZN(X); TotalCycles += 2; PC = 0x9890;
                    goto case 0x9890;
                case 0x988F:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0x9891;
                    goto case 0x9891;
                case 0x9890:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9892;
                    goto case 0x9892;
                case 0x9891:
                    TotalCycles += 7; PushU16(0x9893); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9892:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9895;
                    goto case 0x9895;
                case 0x9893:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x9895;
                    goto case 0x9895;
                case 0x9894:
                    _ram[0xCA] = Asl(_ram[0xCA]); TotalCycles += 5; PC = 0x9896;
                    goto case 0x9896;
                case 0x9895:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x9896;
                    goto case 0x9896;
                case 0x9896:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9890; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9890; }
                    PC = 0x9898; goto case 0x9898;
                case 0x9897:
                    P |= FlagD; TotalCycles += 2; PC = 0x9898;
                    goto case 0x9898;
                case 0x9898:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x18DD + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x989B;
                    goto case 0x989B;
                case 0x9899:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x0D98 + X) & 0x7FFF]); TotalCycles += 4; PC = 0x989C;
                    goto case 0x989C;
                case 0x989A:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x989B;
                    goto case 0x989B;
                case 0x989B:
                    _ram[0x06A8] = A; TotalCycles += 4; PC = 0x989E;
                    goto case 0x989E;
                case 0x989C:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x989D;
                    goto case 0x989D;
                case 0x989D:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x989F;
                    goto case 0x989F;
                case 0x989E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x989F:
                    A |= _ram[(byte)(0x14 + X)]; SetZN(A); TotalCycles += 4; PC = 0x98A1;
                    goto case 0x98A1;
                case 0x98A1:
                    TotalCycles += 7; PushU16(0x98A3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x98A2:
                    TotalCycles += 7; PushU16(0x98A4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x98A3:
                    A |= _ram[(byte)(0x1E + X)]; SetZN(A); TotalCycles += 4; PC = 0x98A5;
                    goto case 0x98A5;
                case 0x98A4:
                    { int a = 0x1C1D + X; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 7; PC = 0x98A7;
                    goto case 0x98A7;
                case 0x98A5:
                    A |= ReadMem(0x151C + X); SetZN(A); TotalCycles += 4; PC = 0x98A8;
                    goto case 0x98A8;
                case 0x98A7:
                    A |= _ram[(byte)(0x21 + X)]; SetZN(A); TotalCycles += 4; PC = 0x98A9;
                    goto case 0x98A9;
                case 0x98A8:
                    A &= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0x98AA;
                    return;
                case 0x98A9:
                    TotalCycles += 6; PushU16(0x98AB); PC = 0xA01F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x98AB:
                    Y = 0x03; SetZN(Y); TotalCycles += 2; PC = 0x98AD;
                    goto case 0x98AD;
                case 0x98AD:
                    TotalCycles += 6; PushU16(0x98AF); PC = 0x9BAF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAF;
                case 0x98B0:
                    TotalCycles += 6; PushU16(0x98B2); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x98B3:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x98B4;
                    goto case 0x98B4;
                case 0x98B4:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x98B5;
                    goto case 0x98B5;
                case 0x98B5:
                    _ram[0x05] = Y; TotalCycles += 3; PC = 0x98B7;
                    goto case 0x98B7;
                case 0x98B6:
                    A |= _ram[0xBC]; SetZN(A); TotalCycles += 3; PC = 0x98B8;
                    goto case 0x98B8;
                case 0x98B7:
                    Y = _ram[(0x0730 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x98BA;
                    goto case 0x98BA;
                case 0x98B8:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x98C1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x98C1; }
                    PC = 0x98BA; goto case 0x98BA;
                case 0x98BA:
                    _ram[0x06] = Y; TotalCycles += 3; PC = 0x98BC;
                    goto case 0x98BC;
                case 0x98BB:
                    _ram[0xA6] = Asl(_ram[0xA6]); TotalCycles += 5; PC = 0x98BD;
                    goto case 0x98BD;
                case 0x98BC:
                    X = _ram[0x05]; SetZN(X); TotalCycles += 3; PC = 0x98BE;
                    goto case 0x98BE;
                case 0x98BD:
                    A |= _ram[0xE8]; SetZN(A); TotalCycles += 3; PC = 0x98BF;
                    goto case 0x98BF;
                case 0x98BE:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x98BF;
                    goto case 0x98BF;
                case 0x98BF:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x189F + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x98C2;
                    goto case 0x98C2;
                case 0x98C1:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x98C2;
                    goto case 0x98C2;
                case 0x98C2:
                    Cmp(A, 0x00); TotalCycles += 2; PC = 0x98C4;
                    goto case 0x98C4;
                case 0x98C3:
                    TotalCycles += 7; PushU16(0x98C5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x98C4:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x98CE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x98CE; }
                    PC = 0x98C6; goto case 0x98C6;
                case 0x98C5:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x98C6;
                    goto case 0x98C6;
                case 0x98C6:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x98C8;
                    goto case 0x98C8;
                case 0x98C7:
                    TotalCycles += 7; PushU16(0x98C9); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x98C8:
                    Y = _ram[0x05]; SetZN(Y); TotalCycles += 3; PC = 0x98CA;
                    goto case 0x98CA;
                case 0x98C9:
                    A |= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0x98CB;
                    goto case 0x98CB;
                case 0x98CA:
                    TotalCycles += 6; PushU16(0x98CC); PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x98CB:
                    Adc(ReadMem(0x189B + X)); TotalCycles += 4; PC = 0x98CE;
                    goto case 0x98CE;
                case 0x98CD:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x98CE;
                    goto case 0x98CE;
                case 0x98CE:
                    Y = _ram[0x06]; SetZN(Y); TotalCycles += 3; PC = 0x98D0;
                    goto case 0x98D0;
                case 0x98CF:
                    _ram[0xB9] = Asl(_ram[0xB9]); TotalCycles += 5; PC = 0x98D1;
                    return;
                case 0x98D0:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x18A3 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x98D3;
                    goto case 0x98D3;
                case 0x98D2:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x98D3;
                    goto case 0x98D3;
                case 0x98D3:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x98D6;
                    goto case 0x98D6;
                case 0x98D4:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x98D6;
                    goto case 0x98D6;
                case 0x98D5:
                    _ram[0xB9] = Asl(_ram[0xB9]); TotalCycles += 5; PC = 0x98D7;
                    return;
                case 0x98D6:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x18A7 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x98D9;
                    goto case 0x98D9;
                case 0x98D8:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x98D9;
                    goto case 0x98D9;
                case 0x98D9:
                    _ram[(0x06A2 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x98DC;
                    goto case 0x98DC;
                case 0x98DA:
                    X = 0x06; SetZN(X); TotalCycles += 2; PC = 0x98DC;
                    goto case 0x98DC;
                case 0x98DB:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x98DD;
                    goto case 0x98DD;
                case 0x98DC:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x98DD:
                    A |= ReadMem(ReadU16Zp(0x10) + Y); SetZN(A); TotalCycles += 5; PC = 0x98DF;
                    goto case 0x98DF;
                case 0x98DE:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x98F5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x98F5; }
                    PC = 0x98E0; return;
                case 0x98DF:
                    A |= _ram[(byte)(0x14 + X)]; SetZN(A); TotalCycles += 4; PC = 0x98E1;
                    return;
                case 0x98E3:
                    A |= _ram[(byte)(0x14 + X)]; SetZN(A); TotalCycles += 4; PC = 0x98E5;
                    goto case 0x98E5;
                case 0x98E5:
                    TotalCycles += 6; PushU16(0x98E7); PC = 0x9939;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9939;
                case 0x98E6:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x2599 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x98E9;
                    goto case 0x98E9;
                case 0x98E7:
                    _ram[(0x00A5 + Y) & 0x07FF] = A; TotalCycles += 5; PC = 0x98EA;
                    goto case 0x98EA;
                case 0x98E8:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x98EA;
                    goto case 0x98EA;
                case 0x98E9:
                    TotalCycles += 7; PushU16(0x98EB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x98EA:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x98F0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x98F0; }
                    PC = 0x98EC; goto case 0x98EC;
                case 0x98EC:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x98ED;
                    goto case 0x98ED;
                case 0x98ED:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x98EE;
                    goto case 0x98EE;
                case 0x98EE:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x98EF;
                    goto case 0x98EF;
                case 0x98EF:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x98F0;
                    goto case 0x98F0;
                case 0x98F0:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x98F1;
                    goto case 0x98F1;
                case 0x98F1:
                    PushU8(A); TotalCycles += 3; PC = 0x98F2;
                    goto case 0x98F2;
                case 0x98F2:
                    A = _ram[0x0760]; SetZN(A); TotalCycles += 4; PC = 0x98F5;
                    goto case 0x98F5;
                case 0x98F3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x98F5:
                    A |= _ram[0x075F]; SetZN(A); TotalCycles += 4; PC = 0x98F8;
                    goto case 0x98F8;
                case 0x98F8:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9925; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9925; }
                    PC = 0x98FA; goto case 0x98FA;
                case 0x98FA:
                    Y = _ram[(0x0730 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x98FD;
                    goto case 0x98FD;
                case 0x98FB:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9904; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9904; }
                    PC = 0x98FD; goto case 0x98FD;
                case 0x98FD:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9925; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9925; }
                    PC = 0x98FF; goto case 0x98FF;
                case 0x98FE:
                    _ram[0x20] = Rol(_ram[0x20]); TotalCycles += 5; PC = 0x9900;
                    goto case 0x9900;
                case 0x98FF:
                    TotalCycles += 6; PushU16(0x9901); PC = 0x994A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x994A;
                case 0x9900:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9901;
                    goto case 0x9901;
                case 0x9901:
                    WriteMem(0x21B0 + Y, A); TotalCycles += 5; PC = 0x9904;
                    goto case 0x9904;
                case 0x9902:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x9925; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9925; }
                    PC = 0x9904; goto case 0x9904;
                case 0x9903:
                    A &= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0x9905;
                    return;
                case 0x9904:
                    TotalCycles += 6; PushU16(0x9906); PC = 0x9BCB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BCB;
                case 0x9907:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9908;
                    goto case 0x9908;
                case 0x9908:
                    Adc(0x08); TotalCycles += 2; PC = 0x990A;
                    goto case 0x990A;
                case 0x9909:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x990A;
                    goto case 0x990A;
                case 0x990A:
                    _ram[(byte)(0x87 + X)] = A; TotalCycles += 4; PC = 0x990C;
                    goto case 0x990C;
                case 0x990C:
                    A = _ram[0x0725]; SetZN(A); TotalCycles += 4; PC = 0x990F;
                    goto case 0x990F;
                case 0x990D:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x990F;
                    goto case 0x990F;
                case 0x990F:
                    Adc(0x00); TotalCycles += 2; PC = 0x9911;
                    goto case 0x9911;
                case 0x9910:
                    TotalCycles += 7; PushU16(0x9912); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9911:
                    _ram[(byte)(0x6E + X)] = A; TotalCycles += 4; PC = 0x9913;
                    goto case 0x9913;
                case 0x9912:
                    _ram[0x01A9] = Ror(_ram[0x01A9]); TotalCycles += 6; PC = 0x9915;
                    goto case 0x9915;
                case 0x9913:
                    A = 0x01; SetZN(A); TotalCycles += 2; PC = 0x9915;
                    goto case 0x9915;
                case 0x9914:
                    A |= ReadMem(ReadU16Zp((byte)(0x95 + X))); SetZN(A); TotalCycles += 6; PC = 0x9916;
                    goto case 0x9916;
                case 0x9915:
                    _ram[(byte)(0xB6 + X)] = A; TotalCycles += 4; PC = 0x9917;
                    goto case 0x9917;
                case 0x9916:
                    X = _ram[(byte)(0x95 + Y)]; SetZN(X); TotalCycles += 4; PC = 0x9918;
                    return;
                case 0x9917:
                    _ram[(byte)(0x0F + X)] = A; TotalCycles += 4; PC = 0x9919;
                    goto case 0x9919;
                case 0x9919:
                    TotalCycles += 6; PushU16(0x991B); PC = 0x9BD3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BD3;
                case 0x991C:
                    _ram[(byte)(0xCF + X)] = A; TotalCycles += 4; PC = 0x991E;
                    goto case 0x991E;
                case 0x991E:
                    A = 0x0D; SetZN(A); TotalCycles += 2; PC = 0x9920;
                    goto case 0x9920;
                case 0x991F:
                    A |= _ram[0x0695]; SetZN(A); TotalCycles += 4; PC = 0x9922;
                    goto case 0x9922;
                case 0x9920:
                    _ram[(byte)(0x16 + X)] = A; TotalCycles += 4; PC = 0x9922;
                    goto case 0x9922;
                case 0x9921:
                    { byte z = (byte)(0x20 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x9923;
                    return;
                case 0x9922:
                    TotalCycles += 6; PushU16(0x9924); PC = 0xC787;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9925:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9926;
                    goto case 0x9926;
                case 0x9926:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9927;
                    goto case 0x9927;
                case 0x9927:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9929;
                    goto case 0x9929;
                case 0x9929:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x18DD + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x992C;
                    goto case 0x992C;
                case 0x992A:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x1D98 + X) & 0x7FFF]); TotalCycles += 4; PC = 0x992D;
                    goto case 0x992D;
                case 0x992B:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x992C;
                    goto case 0x992C;
                case 0x992C:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x992F;
                    goto case 0x992F;
                case 0x992D:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x992F;
                    goto case 0x992F;
                case 0x992E:
                    _ram[0xE8] = Asl(_ram[0xE8]); TotalCycles += 5; PC = 0x9930;
                    goto case 0x9930;
                case 0x992F:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9930;
                    goto case 0x9930;
                case 0x9930:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x18DF + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9933;
                    goto case 0x9933;
                case 0x9932:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x9933;
                    goto case 0x9933;
                case 0x9933:
                    Y = _ram[0x06]; SetZN(Y); TotalCycles += 3; PC = 0x9935;
                    goto case 0x9935;
                case 0x9934:
                    _ram[0x88] = Asl(_ram[0x88]); TotalCycles += 5; PC = 0x9936;
                    goto case 0x9936;
                case 0x9935:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9936;
                    goto case 0x9936;
                case 0x9936:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x9937:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x209B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x993A;
                    goto case 0x993A;
                case 0x9939:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0x993B;
                    goto case 0x993B;
                case 0x993A:
                    A |= ReadMem(ReadU16Zp((byte)(0x20 + X))); SetZN(A); TotalCycles += 6; PC = 0x993C;
                    return;
                case 0x993B:
                    TotalCycles += 6; PushU16(0x993D); PC = 0x9BAF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAF;
                case 0x993E:
                    TotalCycles += 6; PushU16(0x9940); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9941:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x9942;
                    goto case 0x9942;
                case 0x9942:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0x9944;
                    goto case 0x9944;
                case 0x9944:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0x9946;
                    goto case 0x9946;
                case 0x9945:
                    _ram[0xBC] = Asl(_ram[0xBC]); TotalCycles += 5; PC = 0x9947;
                    goto case 0x9947;
                case 0x9946:
                    Y = _ram[(0x0730 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x9949;
                    goto case 0x9949;
                case 0x9947:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9950; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9950; }
                    PC = 0x9949; goto case 0x9949;
                case 0x9949:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x994A:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x994C;
                    goto case 0x994C;
                case 0x994B:
                    TotalCycles += 7; PushU16(0x994D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x994C:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x994D;
                    goto case 0x994D;
                case 0x994D:
                    A = _ram[(byte)(0x0F + X)]; SetZN(A); TotalCycles += 4; PC = 0x994F;
                    goto case 0x994F;
                case 0x994F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9956; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9956; }
                    PC = 0x9951; goto case 0x9951;
                case 0x9950:
                    A |= _ram[0xE8]; SetZN(A); TotalCycles += 3; PC = 0x9952;
                    goto case 0x9952;
                case 0x9951:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9952;
                    goto case 0x9952;
                case 0x9952:
                    Cmp(X, 0x05); TotalCycles += 2; PC = 0x9954;
                    goto case 0x9954;
                case 0x9953:
                    A |= _ram[0xD0]; SetZN(A); TotalCycles += 3; PC = 0x9955;
                    goto case 0x9955;
                case 0x9954:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x994C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x994C; }
                    PC = 0x9956; goto case 0x9956;
                case 0x9955:
                    { byte z = (byte)(0x60 + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0x9957;
                    goto case 0x9957;
                case 0x9956:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9957:
                    TotalCycles += 6; PushU16(0x9959); PC = 0x9BAC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAC;
                case 0x9958:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x299B]; SetZN(Y); TotalCycles += 4; PC = 0x995B;
                    goto case 0x995B;
                case 0x995A:
                    A = 0x86; SetZN(A); TotalCycles += 2; PC = 0x995C;
                    goto case 0x995C;
                case 0x995B:
                    _ram[0x8D] = X; TotalCycles += 3; PC = 0x995D;
                    return;
                case 0x995C:
                    _ram[0x06AB] = A; TotalCycles += 4; PC = 0x995F;
                    goto case 0x995F;
                case 0x995E:
                    _ram[0xA2] = Asl(_ram[0xA2]); TotalCycles += 5; PC = 0x9960;
                    return;
                case 0x995F:
                    X = 0x0B; SetZN(X); TotalCycles += 2; PC = 0x9961;
                    goto case 0x9961;
                case 0x9961:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0x9963;
                    goto case 0x9963;
                case 0x9962:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0x9964;
                    return;
                case 0x9963:
                    A = 0x87; SetZN(A); TotalCycles += 2; PC = 0x9965;
                    goto case 0x9965;
                case 0x9965:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x9966:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x299B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x9969;
                    return;
                case 0x9968:
                    A = 0x03; SetZN(A); TotalCycles += 2; PC = 0x996A;
                    goto case 0x996A;
                case 0x996A:
                    Bit(_ram[0x07A9]); TotalCycles += 4; PC = 0x996D;
                    goto case 0x996D;
                case 0x996B:
                    A = 0x07; SetZN(A); TotalCycles += 2; PC = 0x996D;
                    goto case 0x996D;
                case 0x996D:
                    PushU8(A); TotalCycles += 3; PC = 0x996E;
                    goto case 0x996E;
                case 0x996E:
                    TotalCycles += 6; PushU16(0x9970); PC = 0x9BAC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAC;
                case 0x996F:
                    Y = ReadIoReg(0x689B); SetZN(Y); TotalCycles += 4; PC = 0x9972;
                    goto case 0x9972;
                case 0x9971:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9972;
                    goto case 0x9972;
                case 0x9972:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9973;
                    goto case 0x9973;
                case 0x9973:
                    A = 0xC0; SetZN(A); TotalCycles += 2; PC = 0x9975;
                    goto case 0x9975;
                case 0x9974:
                    Cmp(Y, 0x9D); TotalCycles += 2; PC = 0x9976;
                    goto case 0x9976;
                case 0x9975:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9978;
                    goto case 0x9978;
                case 0x9976:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x9978;
                    goto case 0x9978;
                case 0x9977:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x9979;
                    goto case 0x9979;
                case 0x9978:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9979:
                    A = 0x06; SetZN(A); TotalCycles += 2; PC = 0x997B;
                    goto case 0x997B;
                case 0x997A:
                    _ram[0x2C] = Asl(_ram[0x2C]); TotalCycles += 5; PC = 0x997C;
                    goto case 0x997C;
                case 0x997B:
                    Bit(_ram[0x07A9]); TotalCycles += 4; PC = 0x997E;
                    goto case 0x997E;
                case 0x997C:
                    A = 0x07; SetZN(A); TotalCycles += 2; PC = 0x997E;
                    goto case 0x997E;
                case 0x997E:
                    Bit(_ram[0x01A9]); TotalCycles += 4; PC = 0x9981;
                    goto case 0x9981;
                case 0x997F:
                    A = 0x09; SetZN(A); TotalCycles += 2; PC = 0x9981;
                    goto case 0x9981;
                case 0x9980:
                    A |= 0x48; SetZN(A); TotalCycles += 2; PC = 0x9982;
                    goto case 0x9982;
                case 0x9981:
                    PushU8(A); TotalCycles += 3; PC = 0x9982;
                    goto case 0x9982;
                case 0x9982:
                    TotalCycles += 6; PushU16(0x9984); PC = 0x9BAC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAC;
                case 0x9983:
                    Y = ReadIoReg(0x689B); SetZN(Y); TotalCycles += 4; PC = 0x9986;
                    goto case 0x9986;
                case 0x9985:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9986;
                    goto case 0x9986;
                case 0x9986:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9987;
                    goto case 0x9987;
                case 0x9987:
                    A = 0x0B; SetZN(A); TotalCycles += 2; PC = 0x9989;
                    goto case 0x9989;
                case 0x9989:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x998C;
                    goto case 0x998C;
                case 0x998A:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x998C;
                    goto case 0x998C;
                case 0x998B:
                    _ram[0xE8] = Asl(_ram[0xE8]); TotalCycles += 5; PC = 0x998D;
                    goto case 0x998D;
                case 0x998C:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x998D;
                    goto case 0x998D;
                case 0x998D:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x998F;
                    goto case 0x998F;
                case 0x998E:
                    TotalCycles += 7; PushU16(0x9990); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x998F:
                    A = 0x63; SetZN(A); TotalCycles += 2; PC = 0x9991;
                    goto case 0x9991;
                case 0x9991:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x9992:
                    Adc(ReadMem(0x209B + X)); TotalCycles += 4; PC = 0x9995;
                    return;
                case 0x9994:
                    TotalCycles += 6; PushU16(0x9996); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9997:
                    X = 0x02; SetZN(X); TotalCycles += 2; PC = 0x9999;
                    goto case 0x9999;
                case 0x9999:
                    A = 0x6D; SetZN(A); TotalCycles += 2; PC = 0x999B;
                    goto case 0x999B;
                case 0x999A:
                    Adc(ReadIoReg(0x7D4C)); TotalCycles += 4; PC = 0x999D;
                    return;
                case 0x999B:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x999C:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x299B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x999F;
                    goto case 0x999F;
                case 0x999E:
                    A = 0x24; SetZN(A); TotalCycles += 2; PC = 0x99A0;
                    goto case 0x99A0;
                case 0x999F:
                    Bit(_ram[0x8D]); TotalCycles += 3; PC = 0x99A1;
                    goto case 0x99A1;
                case 0x99A0:
                    _ram[0x06A1] = A; TotalCycles += 4; PC = 0x99A3;
                    goto case 0x99A3;
                case 0x99A1:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x99A3;
                    goto case 0x99A3;
                case 0x99A2:
                    _ram[0xA2] = Asl(_ram[0xA2]); TotalCycles += 5; PC = 0x99A4;
                    goto case 0x99A4;
                case 0x99A3:
                    X = 0x01; SetZN(X); TotalCycles += 2; PC = 0x99A5;
                    goto case 0x99A5;
                case 0x99A4:
                    A |= ReadMem(ReadU16Zp((byte)(0xA0 + X))); SetZN(A); TotalCycles += 6; PC = 0x99A6;
                    goto case 0x99A6;
                case 0x99A5:
                    Y = 0x08; SetZN(Y); TotalCycles += 2; PC = 0x99A7;
                    goto case 0x99A7;
                case 0x99A6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x99A7;
                    goto case 0x99A7;
                case 0x99A7:
                    A = 0x25; SetZN(A); TotalCycles += 2; PC = 0x99A9;
                    goto case 0x99A9;
                case 0x99A8:
                    A &= _ram[0x20]; SetZN(A); TotalCycles += 3; PC = 0x99AA;
                    goto case 0x99AA;
                case 0x99A9:
                    TotalCycles += 6; PushU16(0x99AB); PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x99AA:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x299B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x99AD;
                    goto case 0x99AD;
                case 0x99AC:
                    A = 0x61; SetZN(A); TotalCycles += 2; PC = 0x99AE;
                    goto case 0x99AE;
                case 0x99AD:
                    Adc(ReadMem(ReadU16Zp((byte)(0x8D + X)))); TotalCycles += 6; PC = 0x99AF;
                    return;
                case 0x99AE:
                    _ram[0x06AB] = A; TotalCycles += 4; PC = 0x99B1;
                    goto case 0x99B1;
                case 0x99B0:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x99B2;
                    return;
                case 0x99B1:
                    TotalCycles += 6; PushU16(0x99B3); PC = 0x9BCB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BCB;
                case 0x99B4:
                    P |= FlagC; TotalCycles += 2; PC = 0x99B5;
                    goto case 0x99B5;
                case 0x99B5:
                    Sbc(0x08); TotalCycles += 2; PC = 0x99B7;
                    goto case 0x99B7;
                case 0x99B6:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x99B7;
                    goto case 0x99B7;
                case 0x99B7:
                    _ram[0x8C] = A; TotalCycles += 3; PC = 0x99B9;
                    goto case 0x99B9;
                case 0x99B8:
                    WriteIoReg(0x25AD, Y); TotalCycles += 4; PC = 0x99BB;
                    return;
                case 0x99B9:
                    A = _ram[0x0725]; SetZN(A); TotalCycles += 4; PC = 0x99BC;
                    goto case 0x99BC;
                case 0x99BA:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x99BC;
                    goto case 0x99BC;
                case 0x99BC:
                    Sbc(0x00); TotalCycles += 2; PC = 0x99BE;
                    goto case 0x99BE;
                case 0x99BD:
                    TotalCycles += 7; PushU16(0x99BF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x99BE:
                    _ram[0x73] = A; TotalCycles += 3; PC = 0x99C0;
                    goto case 0x99C0;
                case 0x99C0:
                    A = 0x30; SetZN(A); TotalCycles += 2; PC = 0x99C2;
                    goto case 0x99C2;
                case 0x99C1:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9948; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x99C3; return;
                case 0x99C2:
                    _ram[0xD4] = A; TotalCycles += 3; PC = 0x99C4;
                    goto case 0x99C4;
                case 0x99C4:
                    A = 0xB0; SetZN(A); TotalCycles += 2; PC = 0x99C6;
                    goto case 0x99C6;
                case 0x99C5:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x9954; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9954; }
                    PC = 0x99C7; goto case 0x99C7;
                case 0x99C6:
                    _ram[0x010D] = A; TotalCycles += 4; PC = 0x99C9;
                    goto case 0x99C9;
                case 0x99C7:
                    A |= SmbEmbeddedAssets.StaticDataTables[0x2901]; SetZN(A); TotalCycles += 4; PC = 0x99CA;
                    goto case 0x99CA;
                case 0x99C8:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0x99CA;
                    goto case 0x99CA;
                case 0x99C9:
                    A = 0x30; SetZN(A); TotalCycles += 2; PC = 0x99CB;
                    goto case 0x99CB;
                case 0x99CA:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9951; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9951; }
                    PC = 0x99CC; return;
                case 0x99CB:
                    _ram[0x1B] = A; TotalCycles += 3; PC = 0x99CD;
                    goto case 0x99CD;
                case 0x99CD:
                    _ram[0x14] = IncVal(_ram[0x14]); TotalCycles += 5; PC = 0x99CF;
                    goto case 0x99CF;
                case 0x99CF:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x99D0:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x99D2;
                    goto case 0x99D2;
                case 0x99D1:
                    TotalCycles += 7; PushU16(0x99D3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x99D2:
                    Y = 0x0F; SetZN(Y); TotalCycles += 2; PC = 0x99D4;
                    goto case 0x99D4;
                case 0x99D4:
                    TotalCycles += 3; PC = 0x99E9;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x99E9;
                case 0x99D5:
                    Sbc(0x99); TotalCycles += 2; PC = 0x99D7;
                    goto case 0x99D7;
                case 0x99D6:
                    WriteMem(0x488A + Y, A); TotalCycles += 5; PC = 0x99D9;
                    goto case 0x99D9;
                case 0x99D7:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x99D8;
                    goto case 0x99D8;
                case 0x99D8:
                    PushU8(A); TotalCycles += 3; PC = 0x99D9;
                    goto case 0x99D9;
                case 0x99D9:
                    X = 0x01; SetZN(X); TotalCycles += 2; PC = 0x99DB;
                    goto case 0x99DB;
                case 0x99DA:
                    A |= ReadMem(ReadU16Zp((byte)(0xA0 + X))); SetZN(A); TotalCycles += 6; PC = 0x99DC;
                    return;
                case 0x99DB:
                    Y = 0x0F; SetZN(Y); TotalCycles += 2; PC = 0x99DD;
                    goto case 0x99DD;
                case 0x99DD:
                    A = 0x44; SetZN(A); TotalCycles += 2; PC = 0x99DF;
                    goto case 0x99DF;
                case 0x99DF:
                    TotalCycles += 6; PushU16(0x99E1); PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x99E0:
                    Adc(ReadMem(0x689B + X)); TotalCycles += 4; PC = 0x99E3;
                    goto case 0x99E3;
                case 0x99E2:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x99E3;
                    goto case 0x99E3;
                case 0x99E3:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x99E4;
                    goto case 0x99E4;
                case 0x99E4:
                    TotalCycles += 6; PushU16(0x99E6); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x99E7:
                    X = 0x01; SetZN(X); TotalCycles += 2; PC = 0x99E9;
                    goto case 0x99E9;
                case 0x99E8:
                    A |= ReadMem(ReadU16Zp((byte)(0xA9 + X))); SetZN(A); TotalCycles += 6; PC = 0x99EA;
                    goto case 0x99EA;
                case 0x99E9:
                    A = 0x40; SetZN(A); TotalCycles += 2; PC = 0x99EB;
                    goto case 0x99EB;
                case 0x99EA:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x99EB:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x99EC:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x439B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x99EF;
                    return;
                case 0x99F2:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x99F5;
                    goto case 0x99F5;
                case 0x99F3:
                    { int a = 0xB907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x99F6;
                    goto case 0x99F6;
                case 0x99F5:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x19EE + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x99F8;
                    goto case 0x99F8;
                case 0x99F6:
                    { int a = 0x4C99; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0x99F9;
                    return;
                case 0x99F7:
                    WriteMem(0x444C + Y, A); TotalCycles += 5; PC = 0x99FA;
                    goto case 0x99FA;
                case 0x99F8:
                    TotalCycles += 3; PC = 0x9A44;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9A44;
                case 0x99FA:
                    SP = X; TotalCycles += 2; PC = 0x99FB;
                    goto case 0x99FB;
                case 0x99FB:
                    _ram[0x07] = Asl(_ram[0x07]); TotalCycles += 5; PC = 0x99FD;
                    goto case 0x99FD;
                case 0x99FD:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x99FE;
                    goto case 0x99FE;
                case 0x99FE:
                    Cmp(A, _ram[0x0C]); TotalCycles += 3; PC = 0x9A00;
                    return;
                case 0x9A01:
                    Y = 0x0C; SetZN(Y); TotalCycles += 2; PC = 0x9A03;
                    goto case 0x9A03;
                case 0x9A03:
                    TotalCycles += 6; PushU16(0x9A05); PC = 0x9BAF;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAF;
                case 0x9A06:
                    TotalCycles += 3; PC = 0x9A0E;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9A0E;
                case 0x9A07:
                    { int a = 0xA99A; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9A0A;
                    goto case 0x9A0A;
                case 0x9A08:
                    SP = X; TotalCycles += 2; PC = 0x9A09;
                    goto case 0x9A09;
                case 0x9A09:
                    A = 0x08; SetZN(A); TotalCycles += 2; PC = 0x9A0B;
                    goto case 0x9A0B;
                case 0x9A0A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9A0B;
                    goto case 0x9A0B;
                case 0x9A0B:
                    _ram[0x0773] = A; TotalCycles += 4; PC = 0x9A0E;
                    goto case 0x9A0E;
                case 0x9A0E:
                    Y = _ram[0x00]; SetZN(Y); TotalCycles += 3; PC = 0x9A10;
                    goto case 0x9A10;
                case 0x9A0F:
                    TotalCycles += 7; PushU16(0x9A11); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9A10:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x19F9 + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0x9A13;
                    goto case 0x9A13;
                case 0x9A11:
                    Sbc(SmbEmbeddedAssets.StaticDataTables[(0x3999 + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x9A14;
                    return;
                case 0x9A12:
                    WriteMem(0xFCB9 + Y, A); TotalCycles += 5; PC = 0x9A15;
                    goto case 0x9A15;
                case 0x9A13:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x19FC + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9A16;
                    goto case 0x9A16;
                case 0x9A15:
                    WriteMem(0x204C + Y, A); TotalCycles += 5; PC = 0x9A18;
                    goto case 0x9A18;
                case 0x9A16:
                    TotalCycles += 3; PC = 0x9A20;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9A20;
                case 0x9A17:
                    TotalCycles += 6; PushU16(0x9A19); PC = 0x209A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9A18:
                    SP = X; TotalCycles += 2; PC = 0x9A19;
                    goto case 0x9A19;
                case 0x9A19:
                    TotalCycles += 6; PushU16(0x9A1B); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9A1C:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9A1E;
                    goto case 0x9A1E;
                case 0x9A1E:
                    A = 0xC4; SetZN(A); TotalCycles += 2; PC = 0x9A20;
                    goto case 0x9A20;
                case 0x9A1F:
                    Cmp(Y, _ram[0xA0]); TotalCycles += 3; PC = 0x9A21;
                    goto case 0x9A21;
                case 0x9A20:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x9A22;
                    goto case 0x9A22;
                case 0x9A21:
                    TotalCycles += 7; PushU16(0x9A23); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9A22:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x9A23:
                    Adc(ReadMem(0x699B + X)); TotalCycles += 4; PC = 0x9A26;
                    goto case 0x9A26;
                case 0x9A25:
                    Adc(0x61); TotalCycles += 2; PC = 0x9A27;
                    goto case 0x9A27;
                case 0x9A26:
                    Adc(ReadMem(ReadU16Zp((byte)(0x61 + X)))); TotalCycles += 6; PC = 0x9A28;
                    return;
                case 0x9A27:
                    Adc(ReadMem(ReadU16Zp((byte)(0x62 + X)))); TotalCycles += 6; PC = 0x9A29;
                    return;
                case 0x9A2A:
                    A ^= ReadMem(ReadU16Zp(0x52) + Y); SetZN(A); TotalCycles += 5; PC = 0x9A2C;
                    return;
                case 0x9A2D:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9A2E;
                    goto case 0x9A2E;
                case 0x9A2E:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x9A31;
                    goto case 0x9A31;
                case 0x9A2F:
                    { int a = 0xAD07; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9A32;
                    return;
                case 0x9A31:
                    A = _ram[0x0743]; SetZN(A); TotalCycles += 4; PC = 0x9A34;
                    goto case 0x9A34;
                case 0x9A34:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9A38; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9A38; }
                    PC = 0x9A36; goto case 0x9A36;
                case 0x9A36:
                    Y = 0x04; SetZN(Y); TotalCycles += 2; PC = 0x9A38;
                    goto case 0x9A38;
                case 0x9A38:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1A29 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9A3B;
                    goto case 0x9A3B;
                case 0x9A39:
                    A &= 0x9A; SetZN(A); TotalCycles += 2; PC = 0x9A3B;
                    goto case 0x9A3B;
                case 0x9A3A:
                    SP = X; TotalCycles += 2; PC = 0x9A3B;
                    goto case 0x9A3B;
                case 0x9A3B:
                    TotalCycles += 3; PC = 0x9A44;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9A44;
                case 0x9A3D:
                    SP = X; TotalCycles += 2; PC = 0x9A3E;
                    goto case 0x9A3E;
                case 0x9A3E:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x9A41;
                    goto case 0x9A41;
                case 0x9A3F:
                    { int a = 0xB907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9A42;
                    goto case 0x9A42;
                case 0x9A41:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1A25 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9A44;
                    goto case 0x9A44;
                case 0x9A42:
                    A &= _ram[0x9A]; SetZN(A); TotalCycles += 3; PC = 0x9A44;
                    goto case 0x9A44;
                case 0x9A43:
                    SP = X; TotalCycles += 2; PC = 0x9A44;
                    goto case 0x9A44;
                case 0x9A44:
                    PushU8(A); TotalCycles += 3; PC = 0x9A45;
                    goto case 0x9A45;
                case 0x9A45:
                    TotalCycles += 6; PushU16(0x9A47); PC = 0x9BAC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAC;
                case 0x9A46:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x269B]; SetZN(Y); TotalCycles += 4; PC = 0x9A49;
                    return;
                case 0x9A48:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9A4A;
                    goto case 0x9A4A;
                case 0x9A4A:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x9A4C;
                    goto case 0x9A4C;
                case 0x9A4B:
                    TotalCycles += 7; PushU16(0x9A4D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9A4C:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9A4D;
                    goto case 0x9A4D;
                case 0x9A4D:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x9A4E:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x2C9B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x9A51;
                    goto case 0x9A51;
                case 0x9A50:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x9A53;
                    goto case 0x9A53;
                case 0x9A51:
                    { int a = 0xB907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9A54;
                    goto case 0x9A54;
                case 0x9A53:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1A29 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9A56;
                    goto case 0x9A56;
                case 0x9A54:
                    A &= 0x9A; SetZN(A); TotalCycles += 2; PC = 0x9A56;
                    goto case 0x9A56;
                case 0x9A55:
                    SP = X; TotalCycles += 2; PC = 0x9A56;
                    goto case 0x9A56;
                case 0x9A56:
                    TotalCycles += 3; PC = 0x9A5F;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9A5F;
                case 0x9A58:
                    SP = X; TotalCycles += 2; PC = 0x9A59;
                    goto case 0x9A59;
                case 0x9A59:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x9A5C;
                    goto case 0x9A5C;
                case 0x9A5A:
                    { int a = 0xB907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9A5D;
                    goto case 0x9A5D;
                case 0x9A5C:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1A25 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9A5F;
                    goto case 0x9A5F;
                case 0x9A5D:
                    A &= _ram[0x9A]; SetZN(A); TotalCycles += 3; PC = 0x9A5F;
                    goto case 0x9A5F;
                case 0x9A5E:
                    SP = X; TotalCycles += 2; PC = 0x9A5F;
                    goto case 0x9A5F;
                case 0x9A5F:
                    PushU8(A); TotalCycles += 3; PC = 0x9A60;
                    goto case 0x9A60;
                case 0x9A60:
                    TotalCycles += 6; PushU16(0x9A62); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9A63:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9A64;
                    goto case 0x9A64;
                case 0x9A64:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9A66;
                    goto case 0x9A66;
                case 0x9A66:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x9A67:
                    Adc(ReadMem(0x209B + X)); TotalCycles += 4; PC = 0x9A6A;
                    return;
                case 0x9A69:
                    TotalCycles += 6; PushU16(0x9A6B); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9A6C:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9A6E;
                    goto case 0x9A6E;
                case 0x9A6E:
                    A = 0x64; SetZN(A); TotalCycles += 2; PC = 0x9A70;
                    goto case 0x9A70;
                case 0x9A70:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9A73;
                    goto case 0x9A73;
                case 0x9A71:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x9A73;
                    goto case 0x9A73;
                case 0x9A72:
                    _ram[0xE8] = Asl(_ram[0xE8]); TotalCycles += 5; PC = 0x9A74;
                    goto case 0x9A74;
                case 0x9A73:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9A74;
                    goto case 0x9A74;
                case 0x9A74:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9A75;
                    goto case 0x9A75;
                case 0x9A75:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9A85; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9A85; }
                    PC = 0x9A77; goto case 0x9A77;
                case 0x9A76:
                    { int a = 0x65A9; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9A79;
                    goto case 0x9A79;
                case 0x9A77:
                    A = 0x65; SetZN(A); TotalCycles += 2; PC = 0x9A79;
                    goto case 0x9A79;
                case 0x9A78:
                    Adc(_ram[0x9D]); TotalCycles += 3; PC = 0x9A7A;
                    goto case 0x9A7A;
                case 0x9A79:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9A7C;
                    goto case 0x9A7C;
                case 0x9A7A:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x9A7C;
                    goto case 0x9A7C;
                case 0x9A7B:
                    _ram[0xE8] = Asl(_ram[0xE8]); TotalCycles += 5; PC = 0x9A7D;
                    goto case 0x9A7D;
                case 0x9A7C:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9A7D;
                    goto case 0x9A7D;
                case 0x9A7D:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9A7E;
                    goto case 0x9A7E;
                case 0x9A7E:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9A85; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9A85; }
                    PC = 0x9A80; goto case 0x9A80;
                case 0x9A7F:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0x9A81;
                    goto case 0x9A81;
                case 0x9A80:
                    A = 0x66; SetZN(A); TotalCycles += 2; PC = 0x9A82;
                    goto case 0x9A82;
                case 0x9A81:
                    _ram[0x20] = Ror(_ram[0x20]); TotalCycles += 5; PC = 0x9A83;
                    goto case 0x9A83;
                case 0x9A82:
                    TotalCycles += 6; PushU16(0x9A84); PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x9A83:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x2E9B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x9A86;
                    goto case 0x9A86;
                case 0x9A85:
                    X = _ram[0x046A]; SetZN(X); TotalCycles += 4; PC = 0x9A88;
                    goto case 0x9A88;
                case 0x9A86:
                    A = Ror(A); TotalCycles += 2; PC = 0x9A87;
                    return;
                case 0x9A88:
                    TotalCycles += 6; PushU16(0x9A8A); PC = 0x9BD3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BD3;
                case 0x9A8B:
                    _ram[(0x0477 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9A8E;
                    goto case 0x9A8E;
                case 0x9A8E:
                    A = _ram[0x0725]; SetZN(A); TotalCycles += 4; PC = 0x9A91;
                    goto case 0x9A91;
                case 0x9A8F:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9A91;
                    goto case 0x9A91;
                case 0x9A91:
                    _ram[(0x046B + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9A94;
                    goto case 0x9A94;
                case 0x9A94:
                    TotalCycles += 6; PushU16(0x9A96); PC = 0x9BCB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BCB;
                case 0x9A97:
                    _ram[(0x0471 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9A9A;
                    goto case 0x9A9A;
                case 0x9A98:
                    Adc(ReadMem(ReadU16Zp(0x04) + Y)); TotalCycles += 5; PC = 0x9A9A;
                    goto case 0x9A9A;
                case 0x9A9A:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9A9B;
                    goto case 0x9A9B;
                case 0x9A9B:
                    Cmp(X, 0x06); TotalCycles += 2; PC = 0x9A9D;
                    goto case 0x9A9D;
                case 0x9A9C:
                    _ram[0x90] = Asl(_ram[0x90]); TotalCycles += 5; PC = 0x9A9E;
                    return;
                case 0x9A9D:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9AA1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9AA1; }
                    PC = 0x9A9F; goto case 0x9A9F;
                case 0x9A9F:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x9AA1;
                    goto case 0x9AA1;
                case 0x9AA0:
                    TotalCycles += 7; PushU16(0x9AA2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9AA1:
                    _ram[0x046A] = X; TotalCycles += 4; PC = 0x9AA4;
                    goto case 0x9AA4;
                case 0x9AA2:
                    A = Ror(A); TotalCycles += 2; PC = 0x9AA3;
                    return;
                case 0x9AA4:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9AA7:
                    _ram[0x05] = Asl(_ram[0x05]); TotalCycles += 5; PC = 0x9AA9;
                    return;
                case 0x9AA8:
                    A |= _ram[0x04]; SetZN(A); TotalCycles += 3; PC = 0x9AAA;
                    return;
                case 0x9AAC:
                    A |= ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0x9AAE;
                    return;
                case 0x9AAD:
                    TotalCycles += 7; PushU16(0x9AAF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9AB1:
                    A |= _ram[0x06]; SetZN(A); TotalCycles += 3; PC = 0x9AB3;
                    return;
                case 0x9AB2:
                    _ram[0x07] = Asl(_ram[0x07]); TotalCycles += 5; PC = 0x9AB4;
                    goto case 0x9AB4;
                case 0x9AB4:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9AB5;
                    goto case 0x9AB5;
                case 0x9AB5:
                    A |= 0x0A; SetZN(A); TotalCycles += 2; PC = 0x9AB7;
                    goto case 0x9AB7;
                case 0x9AB6:
                    A = Asl(A); TotalCycles += 2; PC = 0x9AB7;
                    goto case 0x9AB7;
                case 0x9AB7:
                    TotalCycles += 6; PushU16(0x9AB9); PC = 0x9BAC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAC;
                case 0x9AB8:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x109B]; SetZN(Y); TotalCycles += 4; PC = 0x9ABB;
                    goto case 0x9ABB;
                case 0x9ABA:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9AC1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9AC1; }
                    PC = 0x9ABC; goto case 0x9ABC;
                case 0x9ABB:
                    A |= _ram[0xA9]; SetZN(A); TotalCycles += 3; PC = 0x9ABD;
                    goto case 0x9ABD;
                case 0x9ABC:
                    A = 0x09; SetZN(A); TotalCycles += 2; PC = 0x9ABE;
                    goto case 0x9ABE;
                case 0x9ABD:
                    A |= 0x8D; SetZN(A); TotalCycles += 2; PC = 0x9ABF;
                    return;
                case 0x9ABE:
                    _ram[0x0734] = A; TotalCycles += 4; PC = 0x9AC1;
                    goto case 0x9AC1;
                case 0x9AC1:
                    _ram[0x0734] = DecVal(_ram[0x0734]); TotalCycles += 6; PC = 0x9AC4;
                    goto case 0x9AC4;
                case 0x9AC4:
                    Y = _ram[0x0734]; SetZN(Y); TotalCycles += 4; PC = 0x9AC7;
                    goto case 0x9AC7;
                case 0x9AC7:
                    X = SmbEmbeddedAssets.StaticDataTables[(0x1AAE + Y) & 0x7FFF]; SetZN(X); TotalCycles += 4; PC = 0x9ACA;
                    goto case 0x9ACA;
                case 0x9AC8:
                    X = SmbEmbeddedAssets.StaticDataTables[0x399A]; SetZN(X); TotalCycles += 4; PC = 0x9ACB;
                    goto case 0x9ACB;
                case 0x9AC9:
                    SP = X; TotalCycles += 2; PC = 0x9ACA;
                    goto case 0x9ACA;
                case 0x9ACA:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1AA5 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9ACD;
                    goto case 0x9ACD;
                case 0x9ACB:
                    A = _ram[0x9A]; SetZN(A); TotalCycles += 3; PC = 0x9ACD;
                    goto case 0x9ACD;
                case 0x9ACC:
                    SP = X; TotalCycles += 2; PC = 0x9ACD;
                    goto case 0x9ACD;
                case 0x9ACD:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9ACE;
                    goto case 0x9ACE;
                case 0x9ACE:
                    A = 0x61; SetZN(A); TotalCycles += 2; PC = 0x9AD0;
                    goto case 0x9AD0;
                case 0x9ACF:
                    Adc(ReadMem(ReadU16Zp((byte)(0x4C + X)))); TotalCycles += 6; PC = 0x9AD1;
                    goto case 0x9AD1;
                case 0x9AD0:
                    TotalCycles += 3; PC = 0x9B7D;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B7D;
                case 0x9AD1:
                    Adc(ReadMem(0x209B + X)); TotalCycles += 4; PC = 0x9AD4;
                    return;
                case 0x9AD3:
                    TotalCycles += 6; PushU16(0x9AD5); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9AD6:
                    TotalCycles += 6; PushU16(0x9AD8); PC = 0x994A;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x994A;
                case 0x9AD7:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9AD8;
                    goto case 0x9AD8;
                case 0x9AD8:
                    WriteMem(0xCB20 + Y, A); TotalCycles += 5; PC = 0x9ADB;
                    return;
                case 0x9AD9:
                    TotalCycles += 6; PushU16(0x9ADB); PC = 0x9BCB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BCB;
                case 0x9ADC:
                    _ram[(byte)(0x87 + X)] = A; TotalCycles += 4; PC = 0x9ADE;
                    goto case 0x9ADE;
                case 0x9ADE:
                    A = _ram[0x0725]; SetZN(A); TotalCycles += 4; PC = 0x9AE1;
                    goto case 0x9AE1;
                case 0x9ADF:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9AE1;
                    goto case 0x9AE1;
                case 0x9AE1:
                    _ram[(byte)(0x6E + X)] = A; TotalCycles += 4; PC = 0x9AE3;
                    goto case 0x9AE3;
                case 0x9AE2:
                    { int a = 0xD320; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 6; PC = 0x9AE5;
                    return;
                case 0x9AE3:
                    TotalCycles += 6; PushU16(0x9AE5); PC = 0x9BD3;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BD3;
                case 0x9AE6:
                    _ram[(byte)(0xCF + X)] = A; TotalCycles += 4; PC = 0x9AE8;
                    goto case 0x9AE8;
                case 0x9AE8:
                    _ram[(byte)(0x58 + X)] = A; TotalCycles += 4; PC = 0x9AEA;
                    goto case 0x9AEA;
                case 0x9AE9:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0x9AEA;
                    goto case 0x9AEA;
                case 0x9AEA:
                    A = 0x32; SetZN(A); TotalCycles += 2; PC = 0x9AEC;
                    goto case 0x9AEC;
                case 0x9AEC:
                    _ram[(byte)(0x16 + X)] = A; TotalCycles += 4; PC = 0x9AEE;
                    goto case 0x9AEE;
                case 0x9AED:
                    { byte z = (byte)(0xA0 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x9AEF;
                    goto case 0x9AEF;
                case 0x9AEE:
                    Y = 0x01; SetZN(Y); TotalCycles += 2; PC = 0x9AF0;
                    goto case 0x9AF0;
                case 0x9AEF:
                    A |= ReadMem(ReadU16Zp((byte)(0x94 + X))); SetZN(A); TotalCycles += 6; PC = 0x9AF1;
                    goto case 0x9AF1;
                case 0x9AF0:
                    _ram[(byte)(0xB6 + X)] = Y; TotalCycles += 4; PC = 0x9AF2;
                    goto case 0x9AF2;
                case 0x9AF1:
                    X = _ram[(byte)(0xF6 + Y)]; SetZN(X); TotalCycles += 4; PC = 0x9AF3;
                    return;
                case 0x9AF2:
                    { byte z = (byte)(0x0F + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0x9AF4;
                    goto case 0x9AF4;
                case 0x9AF4:
                    X = _ram[0x07]; SetZN(X); TotalCycles += 3; PC = 0x9AF6;
                    goto case 0x9AF6;
                case 0x9AF6:
                    A = 0x67; SetZN(A); TotalCycles += 2; PC = 0x9AF8;
                    goto case 0x9AF8;
                case 0x9AF8:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9AFB;
                    goto case 0x9AFB;
                case 0x9AF9:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x9AFB;
                    goto case 0x9AFB;
                case 0x9AFA:
                    _ram[0xA9] = Asl(_ram[0xA9]); TotalCycles += 5; PC = 0x9AFC;
                    goto case 0x9AFC;
                case 0x9AFB:
                    A = 0x68; SetZN(A); TotalCycles += 2; PC = 0x9AFD;
                    goto case 0x9AFD;
                case 0x9AFC:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9AFD;
                    goto case 0x9AFD;
                case 0x9AFD:
                    _ram[(0x06A2 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9B00;
                    goto case 0x9B00;
                case 0x9AFE:
                    X = 0x06; SetZN(X); TotalCycles += 2; PC = 0x9B00;
                    goto case 0x9B00;
                case 0x9AFF:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x9B01;
                    goto case 0x9B01;
                case 0x9B00:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9B01:
                    A = _ram[0x075D]; SetZN(A); TotalCycles += 4; PC = 0x9B04;
                    goto case 0x9B04;
                case 0x9B02:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x7007 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9B05;
                    goto case 0x9B05;
                case 0x9B04:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9B3C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9B3C; }
                    PC = 0x9B06; goto case 0x9B06;
                case 0x9B05:
                    { byte z = (byte)(0xA9 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9B07;
                    goto case 0x9B07;
                case 0x9B06:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9B08;
                    goto case 0x9B08;
                case 0x9B07:
                    TotalCycles += 7; PushU16(0x9B09); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B08:
                    _ram[0x075D] = A; TotalCycles += 4; PC = 0x9B0B;
                    goto case 0x9B0B;
                case 0x9B09:
                    A ^= ReadMem(0x4C07 + X); SetZN(A); TotalCycles += 4; PC = 0x9B0C;
                    goto case 0x9B0C;
                case 0x9B0B:
                    TotalCycles += 3; PC = 0x9B19;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B19;
                case 0x9B0C:
                    A |= ReadMem(0x209B + Y); SetZN(A); TotalCycles += 4; PC = 0x9B0F;
                    goto case 0x9B0F;
                case 0x9B0E:
                    TotalCycles += 6; PushU16(0x9B10); PC = 0x9B36;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B36;
                case 0x9B0F:
                    { byte z = (byte)(0x9B + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9B11;
                    goto case 0x9B11;
                case 0x9B11:
                    TotalCycles += 3; PC = 0x9B2C;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B2C;
                case 0x9B12:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x299B]); TotalCycles += 4; PC = 0x9B15;
                    goto case 0x9B15;
                case 0x9B14:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9B16;
                    goto case 0x9B16;
                case 0x9B15:
                    TotalCycles += 7; PushU16(0x9B17); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B16:
                    _ram[0x06BC] = A; TotalCycles += 4; PC = 0x9B19;
                    goto case 0x9B19;
                case 0x9B17:
                    Y = ReadMem(0x2006 + X); SetZN(Y); TotalCycles += 4; PC = 0x9B1A;
                    goto case 0x9B1A;
                case 0x9B18:
                    _ram[0x20] = Asl(_ram[0x20]); TotalCycles += 5; PC = 0x9B1A;
                    goto case 0x9B1A;
                case 0x9B19:
                    TotalCycles += 6; PushU16(0x9B1B); PC = 0x9B36;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9B36;
                case 0x9B1A:
                    { byte z = (byte)(0x9B + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9B1C;
                    goto case 0x9B1C;
                case 0x9B1C:
                    _ram[0x07] = Y; TotalCycles += 3; PC = 0x9B1E;
                    goto case 0x9B1E;
                case 0x9B1E:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9B20;
                    goto case 0x9B20;
                case 0x9B1F:
                    TotalCycles += 7; PushU16(0x9B21); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B20:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x9B23;
                    goto case 0x9B23;
                case 0x9B21:
                    { int a = 0x8807; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9B24;
                    goto case 0x9B24;
                case 0x9B23:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9B24;
                    goto case 0x9B24;
                case 0x9B24:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9B28; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9B28; }
                    PC = 0x9B26; goto case 0x9B26;
                case 0x9B26:
                    A = 0x05; SetZN(A); TotalCycles += 2; PC = 0x9B28;
                    goto case 0x9B28;
                case 0x9B27:
                    A |= _ram[0x18]; SetZN(A); TotalCycles += 3; PC = 0x9B29;
                    goto case 0x9B29;
                case 0x9B28:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9B29;
                    goto case 0x9B29;
                case 0x9B29:
                    Adc(_ram[0x07]); TotalCycles += 3; PC = 0x9B2B;
                    goto case 0x9B2B;
                case 0x9B2B:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9B2C;
                    goto case 0x9B2C;
                case 0x9B2C:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x3DE8 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9B2F;
                    goto case 0x9B2F;
                case 0x9B2D:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9B2E;
                    goto case 0x9B2E;
                case 0x9B2E:
                    A = ReadMem(0x2048 + X); SetZN(A); TotalCycles += 4; PC = 0x9B31;
                    return;
                case 0x9B2F:
                    PushU8(A); TotalCycles += 3; PC = 0x9B30;
                    goto case 0x9B30;
                case 0x9B30:
                    TotalCycles += 6; PushU16(0x9B32); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9B33:
                    TotalCycles += 3; PC = 0x9A48;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9A48;
                case 0x9B34:
                    PushU8(A); TotalCycles += 3; PC = 0x9B35;
                    goto case 0x9B35;
                case 0x9B35:
                    SP = X; TotalCycles += 2; PC = 0x9B36;
                    goto case 0x9B36;
                case 0x9B36:
                    A = _ram[0x00]; SetZN(A); TotalCycles += 3; PC = 0x9B38;
                    goto case 0x9B38;
                case 0x9B37:
                    TotalCycles += 7; PushU16(0x9B39); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B38:
                    P |= FlagC; TotalCycles += 2; PC = 0x9B39;
                    goto case 0x9B39;
                case 0x9B39:
                    Sbc(0x00); TotalCycles += 2; PC = 0x9B3B;
                    goto case 0x9B3B;
                case 0x9B3A:
                    TotalCycles += 7; PushU16(0x9B3C); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B3B:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9B3C;
                    goto case 0x9B3C;
                case 0x9B3C:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9B3E:
                    TotalCycles += 7; PushU16(0x9B40); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B3F:
                    TotalCycles += 7; PushU16(0x9B41); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B40:
                    TotalCycles += 7; PushU16(0x9B42); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B41:
                    TotalCycles += 6; PushU16(0x9B43); PC = 0x9BAC;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BAC;
                case 0x9B42:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x109B]; SetZN(Y); TotalCycles += 4; PC = 0x9B45;
                    goto case 0x9B45;
                case 0x9B44:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9B73; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9B73; }
                    PC = 0x9B46; goto case 0x9B46;
                case 0x9B45:
                    A &= ReadIoReg(0x4EAD); SetZN(A); TotalCycles += 4; PC = 0x9B48;
                    return;
                case 0x9B46:
                    A = _ram[0x074E]; SetZN(A); TotalCycles += 4; PC = 0x9B49;
                    goto case 0x9B49;
                case 0x9B47:
                    { int a = 0xD007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9B4A;
                    goto case 0x9B4A;
                case 0x9B49:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9B73; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9B73; }
                    PC = 0x9B4B; goto case 0x9B4B;
                case 0x9B4A:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9B4B;
                    goto case 0x9B4B;
                case 0x9B4B:
                    X = _ram[0x046A]; SetZN(X); TotalCycles += 4; PC = 0x9B4E;
                    goto case 0x9B4E;
                case 0x9B4C:
                    A = Ror(A); TotalCycles += 2; PC = 0x9B4D;
                    return;
                case 0x9B4E:
                    TotalCycles += 6; PushU16(0x9B50); PC = 0x9BCB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BCB;
                case 0x9B51:
                    P |= FlagC; TotalCycles += 2; PC = 0x9B52;
                    goto case 0x9B52;
                case 0x9B52:
                    Sbc(0x10); TotalCycles += 2; PC = 0x9B54;
                    goto case 0x9B54;
                case 0x9B53:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9AF2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9AF2; }
                    PC = 0x9B55; goto case 0x9B55;
                case 0x9B54:
                    _ram[(0x0471 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9B57;
                    goto case 0x9B57;
                case 0x9B55:
                    Adc(ReadMem(ReadU16Zp(0x04) + Y)); TotalCycles += 5; PC = 0x9B57;
                    goto case 0x9B57;
                case 0x9B57:
                    A = _ram[0x0725]; SetZN(A); TotalCycles += 4; PC = 0x9B5A;
                    goto case 0x9B5A;
                case 0x9B58:
                    A &= _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9B5A;
                    goto case 0x9B5A;
                case 0x9B5A:
                    Sbc(0x00); TotalCycles += 2; PC = 0x9B5C;
                    goto case 0x9B5C;
                case 0x9B5B:
                    TotalCycles += 7; PushU16(0x9B5D); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B5C:
                    _ram[(0x046B + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9B5F;
                    goto case 0x9B5F;
                case 0x9B5F:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9B60;
                    goto case 0x9B60;
                case 0x9B60:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9B61;
                    goto case 0x9B61;
                case 0x9B61:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x9B62;
                    goto case 0x9B62;
                case 0x9B62:
                    A = Asl(A); TotalCycles += 2; PC = 0x9B63;
                    goto case 0x9B63;
                case 0x9B63:
                    A = Asl(A); TotalCycles += 2; PC = 0x9B64;
                    goto case 0x9B64;
                case 0x9B64:
                    A = Asl(A); TotalCycles += 2; PC = 0x9B65;
                    goto case 0x9B65;
                case 0x9B65:
                    A = Asl(A); TotalCycles += 2; PC = 0x9B66;
                    goto case 0x9B66;
                case 0x9B66:
                    _ram[(0x0477 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9B69;
                    goto case 0x9B69;
                case 0x9B69:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9B6A;
                    goto case 0x9B6A;
                case 0x9B6A:
                    Cmp(X, 0x05); TotalCycles += 2; PC = 0x9B6C;
                    goto case 0x9B6C;
                case 0x9B6B:
                    A |= _ram[0x90]; SetZN(A); TotalCycles += 3; PC = 0x9B6D;
                    return;
                case 0x9B6C:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9B70; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9B70; }
                    PC = 0x9B6E; goto case 0x9B6E;
                case 0x9B6E:
                    X = 0x00; SetZN(X); TotalCycles += 2; PC = 0x9B70;
                    goto case 0x9B70;
                case 0x9B6F:
                    TotalCycles += 7; PushU16(0x9B71); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9B70:
                    _ram[0x046A] = X; TotalCycles += 4; PC = 0x9B73;
                    goto case 0x9B73;
                case 0x9B71:
                    A = Ror(A); TotalCycles += 2; PC = 0x9B72;
                    return;
                case 0x9B73:
                    X = _ram[0x074E]; SetZN(X); TotalCycles += 4; PC = 0x9B76;
                    goto case 0x9B76;
                case 0x9B74:
                    { int a = 0xBD07; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9B77;
                    goto case 0x9B77;
                case 0x9B76:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1B3D + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9B79;
                    goto case 0x9B79;
                case 0x9B77:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x229B + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9B7A;
                    goto case 0x9B7A;
                case 0x9B79:
                    X = 0x08; SetZN(X); TotalCycles += 2; PC = 0x9B7B;
                    goto case 0x9B7B;
                case 0x9B7A:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9B7B;
                    goto case 0x9B7B;
                case 0x9B7B:
                    Y = 0x0F; SetZN(Y); TotalCycles += 2; PC = 0x9B7D;
                    goto case 0x9B7D;
                case 0x9B7D:
                    _ram[0x0735] = Y; TotalCycles += 4; PC = 0x9B80;
                    goto case 0x9B80;
                case 0x9B7E:
                    A &= _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9B80;
                    goto case 0x9B80;
                case 0x9B80:
                    Y = _ram[(0x06A1 + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x9B83;
                    goto case 0x9B83;
                case 0x9B81:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x9B83;
                    goto case 0x9B83;
                case 0x9B82:
                    _ram[0xF0] = Asl(_ram[0xF0]); TotalCycles += 5; PC = 0x9B84;
                    goto case 0x9B84;
                case 0x9B83:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9B9D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9B9D; }
                    PC = 0x9B85; goto case 0x9B85;
                case 0x9B84:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9B85;
                    goto case 0x9B85;
                case 0x9B85: // === SUBROUTINE: Sub_9B85 ===
                    Cmp(Y, 0x17); TotalCycles += 2; PC = 0x9B87;
                    goto case 0x9B87;
                case 0x9B87:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9BA0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9BA0; }
                    PC = 0x9B89; goto case 0x9B89;
                case 0x9B89:
                    Cmp(Y, 0x1A); TotalCycles += 2; PC = 0x9B8B;
                    goto case 0x9B8B;
                case 0x9B8B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9BA0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9BA0; }
                    PC = 0x9B8D; goto case 0x9B8D;
                case 0x9B8D:
                    Cmp(Y, 0xC0); TotalCycles += 2; PC = 0x9B8F;
                    goto case 0x9B8F;
                case 0x9B8E:
                    Cmp(Y, 0xF0); TotalCycles += 2; PC = 0x9B90;
                    return;
                case 0x9B8F:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9B9D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9B9D; }
                    PC = 0x9B91; goto case 0x9B91;
                case 0x9B91:
                    Cmp(Y, 0xC0); TotalCycles += 2; PC = 0x9B93;
                    goto case 0x9B93;
                case 0x9B92:
                    Cmp(Y, 0xB0); TotalCycles += 2; PC = 0x9B94;
                    return;
                case 0x9B93:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x9BA0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9BA0; }
                    PC = 0x9B95; goto case 0x9B95;
                case 0x9B95:
                    Cmp(Y, 0x54); TotalCycles += 2; PC = 0x9B97;
                    goto case 0x9B97;
                case 0x9B97:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9B9D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9B9D; }
                    PC = 0x9B99; goto case 0x9B99;
                case 0x9B99:
                    Cmp(A, 0x50); TotalCycles += 2; PC = 0x9B9B;
                    goto case 0x9B9B;
                case 0x9B9A:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x9B8C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9B9C; return;
                case 0x9B9B:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9BA0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9BA0; }
                    PC = 0x9B9D; goto case 0x9B9D;
                case 0x9B9D:
                    _ram[(0x06A1 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9BA0;
                    goto case 0x9BA0;
                case 0x9B9E:
                    A = ReadMem(ReadU16Zp((byte)(0x06 + X))); SetZN(A); TotalCycles += 6; PC = 0x9BA0;
                    goto case 0x9BA0;
                case 0x9B9F:
                    _ram[0xE8] = Asl(_ram[0xE8]); TotalCycles += 5; PC = 0x9BA1;
                    goto case 0x9BA1;
                case 0x9BA0:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9BA1;
                    goto case 0x9BA1;
                case 0x9BA1:
                    Cmp(X, 0x0D); TotalCycles += 2; PC = 0x9BA3;
                    goto case 0x9BA3;
                case 0x9BA2:
                    A |= _ram[0x06B0]; SetZN(A); TotalCycles += 4; PC = 0x9BA5;
                    goto case 0x9BA5;
                case 0x9BA3:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x9BAB; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9BAB; }
                    PC = 0x9BA5; goto case 0x9BA5;
                case 0x9BA4:
                    _ram[0xAC] = Asl(_ram[0xAC]); TotalCycles += 5; PC = 0x9BA6;
                    goto case 0x9BA6;
                case 0x9BA5:
                    Y = _ram[0x0735]; SetZN(Y); TotalCycles += 4; PC = 0x9BA8;
                    goto case 0x9BA8;
                case 0x9BA6:
                    A &= _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9BA8;
                    goto case 0x9BA8;
                case 0x9BA8:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9BA9;
                    goto case 0x9BA9;
                case 0x9BA9:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9B7D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9B7D; }
                    PC = 0x9BAB; goto case 0x9BAB;
                case 0x9BAB:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9BAC: // === SUBROUTINE: Sub_9BAC ===
                    TotalCycles += 6; PushU16(0x9BAE); PC = 0x9BBB;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9BBB;
                case 0x9BAF:
                    A = _ram[(0x0730 + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x9BB2;
                    goto case 0x9BB2;
                case 0x9BB0:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9BB9; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9BB9; }
                    PC = 0x9BB2; goto case 0x9BB2;
                case 0x9BB2:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9BB3;
                    goto case 0x9BB3;
                case 0x9BB3:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9BBA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9BBA; }
                    PC = 0x9BB5; goto case 0x9BB5;
                case 0x9BB4:
                    A |= _ram[0x98]; SetZN(A); TotalCycles += 3; PC = 0x9BB6;
                    goto case 0x9BB6;
                case 0x9BB5:
                    A = Y; SetZN(A); TotalCycles += 2; PC = 0x9BB6;
                    goto case 0x9BB6;
                case 0x9BB6:
                    _ram[(0x0730 + X) & 0x07FF] = A; TotalCycles += 5; PC = 0x9BB9;
                    goto case 0x9BB9;
                case 0x9BB7:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9BC0; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9BC0; }
                    PC = 0x9BB9; goto case 0x9BB9;
                case 0x9BB9:
                    P |= FlagC; TotalCycles += 2; PC = 0x9BBA;
                    goto case 0x9BBA;
                case 0x9BBA:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9BBB: // === SUBROUTINE: Sub_9BBB ===
                    Y = _ram[(0x072D + X) & 0x07FF]; SetZN(Y); TotalCycles += 4; PC = 0x9BBE;
                    goto case 0x9BBE;
                case 0x9BBC:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x3107]; SetZN(A); TotalCycles += 4; PC = 0x9BBF;
                    return;
                case 0x9BBE:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9BC0;
                    goto case 0x9BC0;
                case 0x9BC0:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x9BC2;
                    goto case 0x9BC2;
                case 0x9BC2:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0x9BC4;
                    goto case 0x9BC4;
                case 0x9BC4:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9BC5;
                    goto case 0x9BC5;
                case 0x9BC5:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9BC7;
                    goto case 0x9BC7;
                case 0x9BC7:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x9BC9;
                    goto case 0x9BC9;
                case 0x9BC9:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9BCA;
                    goto case 0x9BCA;
                case 0x9BCA:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9BCB: // === SUBROUTINE: Sub_9BCB ===
                    A = _ram[0x0726]; SetZN(A); TotalCycles += 4; PC = 0x9BCE;
                    goto case 0x9BCE;
                case 0x9BCC:
                    _ram[0x07] = Rol(_ram[0x07]); TotalCycles += 5; PC = 0x9BCE;
                    goto case 0x9BCE;
                case 0x9BCE:
                    A = Asl(A); TotalCycles += 2; PC = 0x9BCF;
                    goto case 0x9BCF;
                case 0x9BCF:
                    A = Asl(A); TotalCycles += 2; PC = 0x9BD0;
                    goto case 0x9BD0;
                case 0x9BD0:
                    A = Asl(A); TotalCycles += 2; PC = 0x9BD1;
                    goto case 0x9BD1;
                case 0x9BD1:
                    A = Asl(A); TotalCycles += 2; PC = 0x9BD2;
                    goto case 0x9BD2;
                case 0x9BD2:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9BD3: // === SUBROUTINE: Sub_9BD3 ===
                    A = _ram[0x07]; SetZN(A); TotalCycles += 3; PC = 0x9BD5;
                    goto case 0x9BD5;
                case 0x9BD5:
                    A = Asl(A); TotalCycles += 2; PC = 0x9BD6;
                    goto case 0x9BD6;
                case 0x9BD6:
                    A = Asl(A); TotalCycles += 2; PC = 0x9BD7;
                    goto case 0x9BD7;
                case 0x9BD7:
                    A = Asl(A); TotalCycles += 2; PC = 0x9BD8;
                    goto case 0x9BD8;
                case 0x9BD8:
                    A = Asl(A); TotalCycles += 2; PC = 0x9BD9;
                    goto case 0x9BD9;
                case 0x9BD9:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9BDA;
                    goto case 0x9BDA;
                case 0x9BDA:
                    Adc(0x20); TotalCycles += 2; PC = 0x9BDC;
                    goto case 0x9BDC;
                case 0x9BDB:
                    TotalCycles += 6; PushU16(0x9BDD); PC = 0x0060;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9BDC:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9BDD:
                    TotalCycles += 7; PushU16(0x9BDF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9BDE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9BE5; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9BE5; }
                    PC = 0x9BE0; goto case 0x9BE0;
                case 0x9BDF:
                    A |= _ram[0x05]; SetZN(A); TotalCycles += 3; PC = 0x9BE1;
                    goto case 0x9BE1;
                case 0x9BE0:
                    A |= _ram[0x48]; SetZN(A); TotalCycles += 3; PC = 0x9BE2;
                    goto case 0x9BE2;
                case 0x9BE1: // === SUBROUTINE: Sub_9BE1 ===
                    PushU8(A); TotalCycles += 3; PC = 0x9BE2;
                    goto case 0x9BE2;
                case 0x9BE2:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9BE3;
                    goto case 0x9BE3;
                case 0x9BE3:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9BE4;
                    goto case 0x9BE4;
                case 0x9BE4:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9BE5;
                    goto case 0x9BE5;
                case 0x9BE5:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9BE6;
                    goto case 0x9BE6;
                case 0x9BE6:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9BE7;
                    goto case 0x9BE7;
                case 0x9BE7:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1BDF + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9BEA;
                    goto case 0x9BEA;
                case 0x9BEA:
                    _ram[0x07] = A; TotalCycles += 3; PC = 0x9BEC;
                    goto case 0x9BEC;
                case 0x9BEC:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9BED;
                    goto case 0x9BED;
                case 0x9BED:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x9BEF;
                    goto case 0x9BEF;
                case 0x9BEF:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9BF0;
                    goto case 0x9BF0;
                case 0x9BF0:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x1BDD + Y) & 0x7FFF]); TotalCycles += 4; PC = 0x9BF3;
                    goto case 0x9BF3;
                case 0x9BF1:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[(0x059B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x9BF4;
                    goto case 0x9BF4;
                case 0x9BF3:
                    _ram[0x06] = A; TotalCycles += 3; PC = 0x9BF5;
                    goto case 0x9BF5;
                case 0x9BF4:
                    _ram[0x60] = Asl(_ram[0x60]); TotalCycles += 5; PC = 0x9BF6;
                    return;
                case 0x9BF5:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9BF9:
                    { byte z = (byte)(0x0E + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9BFB;
                    goto case 0x9BFB;
                case 0x9BFA:
                    _ram[0x060E] = Asl(_ram[0x060E]); TotalCycles += 6; PC = 0x9BFD;
                    return;
                case 0x9BFB:
                    { int a = 0x320E; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9BFE;
                    return;
                case 0x9BFC:
                    { int a = 0x3232; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9BFF;
                    return;
                case 0x9C00:
                    A = Asl(A); TotalCycles += 2; PC = 0x9C01;
                    goto case 0x9C01;
                case 0x9C01:
                    _ram[0x40] = Rol(_ram[0x40]); TotalCycles += 5; PC = 0x9C03;
                    goto case 0x9C03;
                case 0x9C02:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x9C03: // === SUBROUTINE: Sub_9C03 ===
                    TotalCycles += 6; PushU16(0x9C05); PC = 0x9C13;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9C13;
                case 0x9C06:
                    _ram[0x0750] = A; TotalCycles += 4; PC = 0x9C09;
                    goto case 0x9C09;
                case 0x9C07:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x9C10; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9C10; }
                    PC = 0x9C09; goto case 0x9C09;
                case 0x9C09: // === SUBROUTINE: Sub_9C09 ===
                    A &= 0x60; SetZN(A); TotalCycles += 2; PC = 0x9C0B;
                    goto case 0x9C0B;
                case 0x9C0A:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9C0B:
                    A = Asl(A); TotalCycles += 2; PC = 0x9C0C;
                    goto case 0x9C0C;
                case 0x9C0C:
                    A = Rol(A); TotalCycles += 2; PC = 0x9C0D;
                    goto case 0x9C0D;
                case 0x9C0D:
                    A = Rol(A); TotalCycles += 2; PC = 0x9C0E;
                    goto case 0x9C0E;
                case 0x9C0E:
                    A = Rol(A); TotalCycles += 2; PC = 0x9C0F;
                    goto case 0x9C0F;
                case 0x9C0F:
                    _ram[0x074E] = A; TotalCycles += 4; PC = 0x9C12;
                    goto case 0x9C12;
                case 0x9C10:
                    { int a = 0x6007; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9C13;
                    goto case 0x9C13;
                case 0x9C12:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9C13: // === SUBROUTINE: Sub_9C13 ===
                    Y = _ram[0x075F]; SetZN(Y); TotalCycles += 4; PC = 0x9C16;
                    goto case 0x9C16;
                case 0x9C16:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1CB4 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9C19;
                    goto case 0x9C19;
                case 0x9C17:
                    Y = _ram[(byte)(0x9C + X)]; SetZN(Y); TotalCycles += 4; PC = 0x9C19;
                    goto case 0x9C19;
                case 0x9C19:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9C1A;
                    goto case 0x9C1A;
                case 0x9C1A:
                    Adc(_ram[0x0760]); TotalCycles += 4; PC = 0x9C1D;
                    goto case 0x9C1D;
                case 0x9C1B:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9C1D:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9C1E;
                    goto case 0x9C1E;
                case 0x9C1E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1CBC + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9C21;
                    goto case 0x9C21;
                case 0x9C1F:
                    Y = ReadMem(0x609C + X); SetZN(Y); TotalCycles += 4; PC = 0x9C22;
                    goto case 0x9C22;
                case 0x9C21:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9C22: // === SUBROUTINE: Sub_9C22 ===
                    A = _ram[0x0750]; SetZN(A); TotalCycles += 4; PC = 0x9C25;
                    goto case 0x9C25;
                case 0x9C23:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x9C2C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9C2C; }
                    PC = 0x9C25; goto case 0x9C25;
                case 0x9C25:
                    TotalCycles += 6; PushU16(0x9C27); PC = 0x9C09;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x9C09;
                case 0x9C26:
                    A |= 0x9C; SetZN(A); TotalCycles += 2; PC = 0x9C28;
                    goto case 0x9C28;
                case 0x9C28:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9C29;
                    goto case 0x9C29;
                case 0x9C29:
                    A = _ram[0x0750]; SetZN(A); TotalCycles += 4; PC = 0x9C2C;
                    goto case 0x9C2C;
                case 0x9C2A:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x9C33; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9C2C; goto case 0x9C2C;
                case 0x9C2C:
                    A &= 0x1F; SetZN(A); TotalCycles += 2; PC = 0x9C2E;
                    goto case 0x9C2E;
                case 0x9C2E:
                    _ram[0x074F] = A; TotalCycles += 4; PC = 0x9C31;
                    goto case 0x9C31;
                case 0x9C31:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1CE0 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9C34;
                    goto case 0x9C34;
                case 0x9C32:
                    Cmp(X, 0x9C); TotalCycles += 2; PC = 0x9C34;
                    goto case 0x9C34;
                case 0x9C34:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9C35;
                    goto case 0x9C35;
                case 0x9C35:
                    Adc(_ram[0x074F]); TotalCycles += 4; PC = 0x9C38;
                    goto case 0x9C38;
                case 0x9C38:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9C39;
                    goto case 0x9C39;
                case 0x9C39:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1CE4 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9C3C;
                    goto case 0x9C3C;
                case 0x9C3A:
                    Cmp(X, _ram[0x9C]); TotalCycles += 3; PC = 0x9C3C;
                    goto case 0x9C3C;
                case 0x9C3C:
                    _ram[0xE9] = A; TotalCycles += 3; PC = 0x9C3E;
                    goto case 0x9C3E;
                case 0x9C3D:
                    Sbc(0xB9); TotalCycles += 2; PC = 0x9C3F;
                    goto case 0x9C3F;
                case 0x9C3E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1D06 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9C41;
                    goto case 0x9C41;
                case 0x9C3F:
                    _ram[0x9D] = Asl(_ram[0x9D]); TotalCycles += 5; PC = 0x9C41;
                    goto case 0x9C41;
                case 0x9C40:
                    WriteMem(0xEA85 + X, A); TotalCycles += 5; PC = 0x9C43;
                    goto case 0x9C43;
                case 0x9C41:
                    _ram[0xEA] = A; TotalCycles += 3; PC = 0x9C43;
                    goto case 0x9C43;
                case 0x9C42:
                     TotalCycles += 2; PC = 0x9C43;
                    goto case 0x9C43;
                case 0x9C43:
                    Y = _ram[0x074E]; SetZN(Y); TotalCycles += 4; PC = 0x9C46;
                    goto case 0x9C46;
                case 0x9C44:
                    { int a = 0xB907; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9C47;
                    goto case 0x9C47;
                case 0x9C46:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1D28 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9C49;
                    goto case 0x9C49;
                case 0x9C47:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9C48;
                    goto case 0x9C48;
                case 0x9C48:
                    WriteMem(0x6D18 + X, A); TotalCycles += 5; PC = 0x9C4B;
                    return;
                case 0x9C49:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9C4A;
                    goto case 0x9C4A;
                case 0x9C4A:
                    Adc(_ram[0x074F]); TotalCycles += 4; PC = 0x9C4D;
                    goto case 0x9C4D;
                case 0x9C4D:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9C4E;
                    goto case 0x9C4E;
                case 0x9C4E:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1D2C + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9C51;
                    goto case 0x9C51;
                case 0x9C4F:
                    Bit(SmbEmbeddedAssets.StaticDataTables[0x059D]); TotalCycles += 4; PC = 0x9C52;
                    return;
                case 0x9C50:
                    WriteMem(0xE785 + X, A); TotalCycles += 5; PC = 0x9C53;
                    goto case 0x9C53;
                case 0x9C51:
                    _ram[0xE7] = A; TotalCycles += 3; PC = 0x9C53;
                    goto case 0x9C53;
                case 0x9C53:
                    A = SmbEmbeddedAssets.StaticDataTables[(0x1D4E + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9C56;
                    goto case 0x9C56;
                case 0x9C54:
                    { int a = 0x859D; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9C57;
                    goto case 0x9C57;
                case 0x9C55:
                    WriteMem(0xE885 + X, A); TotalCycles += 5; PC = 0x9C58;
                    goto case 0x9C58;
                case 0x9C56:
                    _ram[0xE8] = A; TotalCycles += 3; PC = 0x9C58;
                    goto case 0x9C58;
                case 0x9C57:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9C58;
                    goto case 0x9C58;
                case 0x9C58:
                    Y = 0x00; SetZN(Y); TotalCycles += 2; PC = 0x9C5A;
                    goto case 0x9C5A;
                case 0x9C59:
                    TotalCycles += 7; PushU16(0x9C5B); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9C5A:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9C5C;
                    goto case 0x9C5C;
                case 0x9C5C:
                    PushU8(A); TotalCycles += 3; PC = 0x9C5D;
                    goto case 0x9C5D;
                case 0x9C5D:
                    A &= 0x07; SetZN(A); TotalCycles += 2; PC = 0x9C5F;
                    goto case 0x9C5F;
                case 0x9C5F:
                    Cmp(A, 0x04); TotalCycles += 2; PC = 0x9C61;
                    goto case 0x9C61;
                case 0x9C61:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9C68; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9C68; }
                    PC = 0x9C63; goto case 0x9C63;
                case 0x9C62:
                    A |= _ram[0x8D]; SetZN(A); TotalCycles += 3; PC = 0x9C64;
                    return;
                case 0x9C63:
                    _ram[0x0744] = A; TotalCycles += 4; PC = 0x9C66;
                    goto case 0x9C66;
                case 0x9C66:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9C68;
                    goto case 0x9C68;
                case 0x9C67:
                    TotalCycles += 7; PushU16(0x9C69); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9C68:
                    _ram[0x0741] = A; TotalCycles += 4; PC = 0x9C6B;
                    goto case 0x9C6B;
                case 0x9C69:
                    A ^= ReadMem(ReadU16Zp((byte)(0x07 + X))); SetZN(A); TotalCycles += 6; PC = 0x9C6B;
                    goto case 0x9C6B;
                case 0x9C6B:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9C6C;
                    goto case 0x9C6C;
                case 0x9C6C:
                    PushU8(A); TotalCycles += 3; PC = 0x9C6D;
                    goto case 0x9C6D;
                case 0x9C6D:
                    A &= 0x38; SetZN(A); TotalCycles += 2; PC = 0x9C6F;
                    goto case 0x9C6F;
                case 0x9C6E:
                    P |= FlagC; TotalCycles += 2; PC = 0x9C6F;
                    goto case 0x9C6F;
                case 0x9C6F:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9C70;
                    goto case 0x9C70;
                case 0x9C70:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9C71;
                    goto case 0x9C71;
                case 0x9C71:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9C72;
                    goto case 0x9C72;
                case 0x9C72:
                    _ram[0x0710] = A; TotalCycles += 4; PC = 0x9C75;
                    goto case 0x9C75;
                case 0x9C73:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9C7C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9C7C; }
                    PC = 0x9C75; goto case 0x9C75;
                case 0x9C75:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9C76;
                    goto case 0x9C76;
                case 0x9C76:
                    A &= 0xC0; SetZN(A); TotalCycles += 2; PC = 0x9C78;
                    goto case 0x9C78;
                case 0x9C77:
                    Cmp(Y, 0x18); TotalCycles += 2; PC = 0x9C79;
                    goto case 0x9C79;
                case 0x9C78:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9C79;
                    goto case 0x9C79;
                case 0x9C79:
                    A = Rol(A); TotalCycles += 2; PC = 0x9C7A;
                    goto case 0x9C7A;
                case 0x9C7A:
                    A = Rol(A); TotalCycles += 2; PC = 0x9C7B;
                    goto case 0x9C7B;
                case 0x9C7B:
                    A = Rol(A); TotalCycles += 2; PC = 0x9C7C;
                    goto case 0x9C7C;
                case 0x9C7C:
                    _ram[0x0715] = A; TotalCycles += 4; PC = 0x9C7F;
                    goto case 0x9C7F;
                case 0x9C7D:
                    A |= _ram[(byte)(0x07 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9C7F;
                    goto case 0x9C7F;
                case 0x9C7F:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9C80;
                    goto case 0x9C80;
                case 0x9C80:
                    A = ReadMem(ReadU16Zp(0xE7) + Y); SetZN(A); TotalCycles += 5; PC = 0x9C82;
                    goto case 0x9C82;
                case 0x9C82:
                    PushU8(A); TotalCycles += 3; PC = 0x9C83;
                    goto case 0x9C83;
                case 0x9C83:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x9C85;
                    goto case 0x9C85;
                case 0x9C85:
                    _ram[0x0727] = A; TotalCycles += 4; PC = 0x9C88;
                    goto case 0x9C88;
                case 0x9C88:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9C89;
                    goto case 0x9C89;
                case 0x9C89:
                    PushU8(A); TotalCycles += 3; PC = 0x9C8A;
                    goto case 0x9C8A;
                case 0x9C8A:
                    A &= 0x30; SetZN(A); TotalCycles += 2; PC = 0x9C8C;
                    goto case 0x9C8C;
                case 0x9C8B:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9CD7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9C8D; goto case 0x9C8D;
                case 0x9C8C:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9C8D;
                    goto case 0x9C8D;
                case 0x9C8D:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9C8E;
                    goto case 0x9C8E;
                case 0x9C8E:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9C8F;
                    goto case 0x9C8F;
                case 0x9C8F:
                    A = Lsr(A); TotalCycles += 2; PC = 0x9C90;
                    goto case 0x9C90;
                case 0x9C90:
                    _ram[0x0742] = A; TotalCycles += 4; PC = 0x9C93;
                    goto case 0x9C93;
                case 0x9C93:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9C94;
                    goto case 0x9C94;
                case 0x9C94:
                    A &= 0xC0; SetZN(A); TotalCycles += 2; PC = 0x9C96;
                    goto case 0x9C96;
                case 0x9C95:
                    Cmp(Y, 0x18); TotalCycles += 2; PC = 0x9C97;
                    goto case 0x9C97;
                case 0x9C96:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9C97;
                    goto case 0x9C97;
                case 0x9C97:
                    A = Rol(A); TotalCycles += 2; PC = 0x9C98;
                    goto case 0x9C98;
                case 0x9C98:
                    A = Rol(A); TotalCycles += 2; PC = 0x9C99;
                    goto case 0x9C99;
                case 0x9C99:
                    A = Rol(A); TotalCycles += 2; PC = 0x9C9A;
                    goto case 0x9C9A;
                case 0x9C9A:
                    Cmp(A, 0x03); TotalCycles += 2; PC = 0x9C9C;
                    goto case 0x9C9C;
                case 0x9C9C:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9CA3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9CA3; }
                    PC = 0x9C9E; goto case 0x9C9E;
                case 0x9C9D:
                    A |= _ram[0x8D]; SetZN(A); TotalCycles += 3; PC = 0x9C9F;
                    return;
                case 0x9C9E:
                    _ram[0x0743] = A; TotalCycles += 4; PC = 0x9CA1;
                    goto case 0x9CA1;
                case 0x9CA1:
                    A = 0x00; SetZN(A); TotalCycles += 2; PC = 0x9CA3;
                    goto case 0x9CA3;
                case 0x9CA2:
                    TotalCycles += 7; PushU16(0x9CA4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9CA3:
                    _ram[0x0733] = A; TotalCycles += 4; PC = 0x9CA6;
                    goto case 0x9CA6;
                case 0x9CA6:
                    A = _ram[0xE7]; SetZN(A); TotalCycles += 3; PC = 0x9CA8;
                    goto case 0x9CA8;
                case 0x9CA8:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9CA9;
                    goto case 0x9CA9;
                case 0x9CA9:
                    Adc(0x02); TotalCycles += 2; PC = 0x9CAB;
                    goto case 0x9CAB;
                case 0x9CAB:
                    _ram[0xE7] = A; TotalCycles += 3; PC = 0x9CAD;
                    goto case 0x9CAD;
                case 0x9CAD:
                    A = _ram[0xE8]; SetZN(A); TotalCycles += 3; PC = 0x9CAF;
                    goto case 0x9CAF;
                case 0x9CAE:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9CAF;
                    goto case 0x9CAF;
                case 0x9CAF:
                    Adc(0x00); TotalCycles += 2; PC = 0x9CB1;
                    goto case 0x9CB1;
                case 0x9CB0:
                    TotalCycles += 7; PushU16(0x9CB2); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9CB1:
                    _ram[0xE8] = A; TotalCycles += 3; PC = 0x9CB3;
                    goto case 0x9CB3;
                case 0x9CB2:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9CB3;
                    goto case 0x9CB3;
                case 0x9CB3:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9CB4:
                    TotalCycles += 7; PushU16(0x9CB6); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9CB5:
                    A |= _ram[0x0A]; SetZN(A); TotalCycles += 3; PC = 0x9CB7;
                    goto case 0x9CB7;
                case 0x9CB6:
                    A = Asl(A); TotalCycles += 2; PC = 0x9CB7;
                    goto case 0x9CB7;
                case 0x9CB7:
                    _ram[0x0713] = Asl(_ram[0x0713]); TotalCycles += 6; PC = 0x9CBA;
                    return;
                case 0x9CBB:
                    TotalCycles += 6; PushU16(0x9CBD); PC = 0x2925;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9CBC:
                    A &= _ram[0x29]; SetZN(A); TotalCycles += 3; PC = 0x9CBE;
                    goto case 0x9CBE;
                case 0x9CBD:
                    A &= 0xC0; SetZN(A); TotalCycles += 2; PC = 0x9CBF;
                    goto case 0x9CBF;
                case 0x9CBE:
                    Cmp(Y, 0x26); TotalCycles += 2; PC = 0x9CC0;
                    goto case 0x9CC0;
                case 0x9CBF:
                    _ram[0x60] = Rol(_ram[0x60]); TotalCycles += 5; PC = 0x9CC1;
                    goto case 0x9CC1;
                case 0x9CC0:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9CC1:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9CC2;
                    goto case 0x9CC2;
                case 0x9CC2:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0x9CC4;
                    return;
                case 0x9CC3:
                    A |= ReadMem(ReadU16Zp((byte)(0x27 + X))); SetZN(A); TotalCycles += 6; PC = 0x9CC5;
                    return;
                case 0x9CC6:
                    Bit(_ram[0x35]); TotalCycles += 3; PC = 0x9CC8;
                    goto case 0x9CC8;
                case 0x9CC7:
                    A &= _ram[(byte)(0x20 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9CC9;
                    return;
                case 0x9CC8:
                    TotalCycles += 6; PushU16(0x9CCA); PC = 0x2263;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9CCB:
                    A &= 0x41; SetZN(A); TotalCycles += 2; PC = 0x9CCD;
                    goto case 0x9CCD;
                case 0x9CCC:
                    A ^= ReadMem(ReadU16Zp((byte)(0x2C + X))); SetZN(A); TotalCycles += 6; PC = 0x9CCE;
                    goto case 0x9CCE;
                case 0x9CCD:
                    Bit(ReadIoReg(0x2A61)); TotalCycles += 4; PC = 0x9CD0;
                    goto case 0x9CD0;
                case 0x9CCE:
                    Adc(ReadMem(ReadU16Zp((byte)(0x2A + X)))); TotalCycles += 6; PC = 0x9CD0;
                    goto case 0x9CD0;
                case 0x9CCF:
                    A = Rol(A); TotalCycles += 2; PC = 0x9CD0;
                    goto case 0x9CD0;
                case 0x9CD0:
                    A &= ReadMem(ReadU16Zp(0x26) + Y); SetZN(A); TotalCycles += 5; PC = 0x9CD2;
                    return;
                case 0x9CD1:
                    _ram[0x62] = Rol(_ram[0x62]); TotalCycles += 5; PC = 0x9CD3;
                    goto case 0x9CD3;
                case 0x9CD3:
                    { int a = 0x2D23; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0x9CD6;
                    goto case 0x9CD6;
                case 0x9CD5:
                    A &= ReadIoReg(0x3360); SetZN(A); TotalCycles += 4; PC = 0x9CD8;
                    goto case 0x9CD8;
                case 0x9CD6:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9CD8:
                    A &= 0x01; SetZN(A); TotalCycles += 2; PC = 0x9CDA;
                    return;
                case 0x9CD9:
                    A |= ReadMem(ReadU16Zp((byte)(0x27 + X))); SetZN(A); TotalCycles += 6; PC = 0x9CDB;
                    return;
                case 0x9CDC:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9D10; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9CDE; goto case 0x9CDE;
                case 0x9CDE:
                    A &= ReadMem(ReadU16Zp((byte)(0x65 + X))); SetZN(A); TotalCycles += 6; PC = 0x9CE0;
                    return;
                case 0x9CDF:
                    Adc(_ram[0x1F]); TotalCycles += 3; PC = 0x9CE1;
                    goto case 0x9CE1;
                case 0x9CE1:
                    _ram[0x1C] = Asl(_ram[0x1C]); TotalCycles += 5; PC = 0x9CE3;
                    goto case 0x9CE3;
                case 0x9CE3:
                    TotalCycles += 7; PushU16(0x9CE5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9CE4:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x9C7D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9C7D; }
                    PC = 0x9CE6; goto case 0x9CE6;
                case 0x9CE6:
                    TotalCycles += 2;
                    if ((P & FlagC) != 0) { TotalCycles += 1; PC = 0x9CC7; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9CC7; }
                    PC = 0x9CE8; goto case 0x9CE8;
                case 0x9CE8:
                    A = Asl(A); TotalCycles += 2; PC = 0x9CE9;
                    return;
                case 0x9CEA:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x1B7E + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9CED;
                    goto case 0x9CED;
                case 0x9CEB:
                    { int a = 0xA99B + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0x9CEE;
                    goto case 0x9CEE;
                case 0x9CED:
                    A = 0xD0; SetZN(A); TotalCycles += 2; PC = 0x9CEF;
                    goto case 0x9CEF;
                case 0x9CEE:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9CF1; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9CF0; return;
                case 0x9CEF:
                    A |= ReadMem(ReadU16Zp((byte)(0x1F + X))); SetZN(A); TotalCycles += 6; PC = 0x9CF1;
                    return;
                case 0x9CF2:
                    A ^= ReadMem(ReadU16Zp(0x7B) + Y); SetZN(A); TotalCycles += 5; PC = 0x9CF4;
                    return;
                case 0x9CF5:
                    Y = 0xA9; SetZN(Y); TotalCycles += 2; PC = 0x9CF7;
                    goto case 0x9CF7;
                case 0x9CF6:
                    A = 0xCE; SetZN(A); TotalCycles += 2; PC = 0x9CF8;
                    goto case 0x9CF8;
                case 0x9CF7:
                    { int a = 0xFAF1; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0x9CFA;
                    return;
                case 0x9CF8:
                    Sbc(ReadMem(ReadU16Zp(0xFA) + Y)); TotalCycles += 5; PC = 0x9CFA;
                    return;
                case 0x9CFB:
                    A &= _ram[(byte)(0x60 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9CFD;
                    goto case 0x9CFD;
                case 0x9CFC:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9CFD:
                    WriteIoReg(0xB3AA, X); TotalCycles += 4; PC = 0x9D00;
                    goto case 0x9D00;
                case 0x9CFE:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9CFF;
                    return;
                case 0x9D00:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0x9D01;
                    goto case 0x9D01;
                case 0x9D01:
                    A |= _ram[0x33]; SetZN(A); TotalCycles += 3; PC = 0x9D03;
                    goto case 0x9D03;
                case 0x9D03:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9D04:
                    Adc(ReadMem(ReadU16Zp(0x9B) + Y)); TotalCycles += 5; PC = 0x9D06;
                    goto case 0x9D06;
                case 0x9D06:
                    WriteMem(0x9D9D + X, A); TotalCycles += 5; PC = 0x9D09;
                    goto case 0x9D09;
                case 0x9D07:
                    WriteMem(0x9D9D + X, A); TotalCycles += 5; PC = 0x9D0A;
                    return;
                case 0x9D08:
                    WriteMem(0x9E9D + X, A); TotalCycles += 5; PC = 0x9D0B;
                    return;
                case 0x9D09:
                    WriteMem(0x9E9E + X, A); TotalCycles += 5; PC = 0x9D0C;
                    return;
                case 0x9D1D:
                    Y = 0xA0; SetZN(Y); TotalCycles += 2; PC = 0x9D1F;
                    goto case 0x9D1F;
                case 0x9D1E:
                    Y = 0xA0; SetZN(Y); TotalCycles += 2; PC = 0x9D20;
                    goto case 0x9D20;
                case 0x9D1F:
                    Y = 0xA0; SetZN(Y); TotalCycles += 2; PC = 0x9D21;
                    goto case 0x9D21;
                case 0x9D20:
                    Y = 0xA0; SetZN(Y); TotalCycles += 2; PC = 0x9D22;
                    goto case 0x9D22;
                case 0x9D21:
                    Y = 0xA0; SetZN(Y); TotalCycles += 2; PC = 0x9D23;
                    goto case 0x9D23;
                case 0x9D22:
                    Y = 0xA1; SetZN(Y); TotalCycles += 2; PC = 0x9D24;
                    goto case 0x9D24;
                case 0x9D23:
                    A = ReadMem(ReadU16Zp((byte)(0xA1 + X))); SetZN(A); TotalCycles += 6; PC = 0x9D25;
                    goto case 0x9D25;
                case 0x9D24:
                    A = ReadMem(ReadU16Zp((byte)(0xA1 + X))); SetZN(A); TotalCycles += 6; PC = 0x9D26;
                    goto case 0x9D26;
                case 0x9D25:
                    A = ReadMem(ReadU16Zp((byte)(0xA1 + X))); SetZN(A); TotalCycles += 6; PC = 0x9D27;
                    goto case 0x9D27;
                case 0x9D26:
                    A = ReadMem(ReadU16Zp((byte)(0xA1 + X))); SetZN(A); TotalCycles += 6; PC = 0x9D28;
                    goto case 0x9D28;
                case 0x9D27:
                    A = ReadMem(ReadU16Zp((byte)(0x00 + X))); SetZN(A); TotalCycles += 6; PC = 0x9D29;
                    return;
                case 0x9D28:
                    TotalCycles += 7; PushU16(0x9D2A); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9D2A:
                    A |= _ram[(0x061C + Y) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x9D2D;
                    goto case 0x9D2D;
                case 0x9D2C:
                    _ram[0x45] = Asl(_ram[0x45]); TotalCycles += 5; PC = 0x9D2E;
                    goto case 0x9D2E;
                case 0x9D2D:
                    A ^= _ram[0xC0]; SetZN(A); TotalCycles += 3; PC = 0x9D2F;
                    return;
                case 0x9D2E:
                    Cmp(Y, 0x6B); TotalCycles += 2; PC = 0x9D30;
                    goto case 0x9D30;
                case 0x9D30:
                    { int a = 0x8A37; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0x9D33;
                    goto case 0x9D33;
                case 0x9D32:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x9D33;
                    goto case 0x9D33;
                case 0x9D33:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x738E + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9D36;
                    goto case 0x9D36;
                case 0x9D34:
                    WriteIoReg(0x48F3, X); TotalCycles += 4; PC = 0x9D37;
                    goto case 0x9D37;
                case 0x9D36:
                    PushU8(A); TotalCycles += 3; PC = 0x9D37;
                    goto case 0x9D37;
                case 0x9D37:
                    Cmp(A, ReadIoReg(0x3B32)); TotalCycles += 4; PC = 0x9D3A;
                    return;
                case 0x9D3C:
                    { byte z = (byte)(0x5B + X); _ram[z] = IncVal(_ram[z]); } TotalCycles += 6; PC = 0x9D3E;
                    goto case 0x9D3E;
                case 0x9D3E:
                    { int a = 0x92FF; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0x9D41;
                    goto case 0x9D41;
                case 0x9D41:
                    A |= _ram[0x7E]; SetZN(A); TotalCycles += 3; PC = 0x9D43;
                    return;
                case 0x9D42:
                    { int a = (0x02D7 + X) & 0x07FF; _ram[a] = Ror(_ram[a]); } TotalCycles += 7; PC = 0x9D45;
                    goto case 0x9D45;
                case 0x9D45:
                    A &= _ram[(byte)(0xD8 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9D47;
                    goto case 0x9D47;
                case 0x9D46:
                    P &= unchecked((byte)~FlagD); TotalCycles += 2; PC = 0x9D47;
                    goto case 0x9D47;
                case 0x9D47:
                    Adc(ReadMem(0x10AF + Y)); TotalCycles += 4; PC = 0x9D4A;
                    return;
                case 0x9D49:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9CDA; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9D4B; return;
                case 0x9D4E:
                    X = SmbEmbeddedAssets.StaticDataTables[0x2EAE]; SetZN(X); TotalCycles += 4; PC = 0x9D51;
                    goto case 0x9D51;
                case 0x9D4F:
                    X = SmbEmbeddedAssets.StaticDataTables[0x24AE]; SetZN(X); TotalCycles += 4; PC = 0x9D52;
                    goto case 0x9D52;
                case 0x9D50:
                    X = SmbEmbeddedAssets.StaticDataTables[0x24A4]; SetZN(X); TotalCycles += 4; PC = 0x9D53;
                    goto case 0x9D53;
                case 0x9D51:
                    Y = _ram[0xA4]; SetZN(Y); TotalCycles += 3; PC = 0x9D53;
                    goto case 0x9D53;
                case 0x9D52:
                    Y = _ram[0xA5]; SetZN(Y); TotalCycles += 3; PC = 0x9D54;
                    goto case 0x9D54;
                case 0x9D53:
                    A = _ram[0xA5]; SetZN(A); TotalCycles += 3; PC = 0x9D55;
                    goto case 0x9D55;
                case 0x9D54:
                    A = _ram[0xA6]; SetZN(A); TotalCycles += 3; PC = 0x9D56;
                    goto case 0x9D56;
                case 0x9D55:
                    X = _ram[0xA6]; SetZN(X); TotalCycles += 3; PC = 0x9D57;
                    goto case 0x9D57;
                case 0x9D56:
                    X = _ram[0xA6]; SetZN(X); TotalCycles += 3; PC = 0x9D58;
                    return;
                case 0x9D57:
                    X = _ram[0xA7]; SetZN(X); TotalCycles += 3; PC = 0x9D59;
                    return;
                case 0x9D5A:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9D5B;
                    goto case 0x9D5B;
                case 0x9D5B:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9D5C;
                    goto case 0x9D5C;
                case 0x9D5C:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9D5D;
                    goto case 0x9D5D;
                case 0x9D5D:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9D5E;
                    goto case 0x9D5E;
                case 0x9D5E:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9D5F;
                    goto case 0x9D5F;
                case 0x9D5F:
                    A = 0xA9; SetZN(A); TotalCycles += 2; PC = 0x9D61;
                    goto case 0x9D61;
                case 0x9D60:
                    A = 0xA9; SetZN(A); TotalCycles += 2; PC = 0x9D62;
                    goto case 0x9D62;
                case 0x9D61:
                    A = 0xAA; SetZN(A); TotalCycles += 2; PC = 0x9D63;
                    return;
                case 0x9D62:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9D63;
                    return;
                case 0x9D66:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x2CAC]; SetZN(Y); TotalCycles += 4; PC = 0x9D69;
                    goto case 0x9D69;
                case 0x9D67:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x2DAC]; SetZN(Y); TotalCycles += 4; PC = 0x9D6A;
                    goto case 0x9D6A;
                case 0x9D68:
                    Y = SmbEmbeddedAssets.StaticDataTables[0x21AD]; SetZN(Y); TotalCycles += 4; PC = 0x9D6B;
                    goto case 0x9D6B;
                case 0x9D69:
                    A = SmbEmbeddedAssets.StaticDataTables[0x22A1]; SetZN(A); TotalCycles += 4; PC = 0x9D6C;
                    goto case 0x9D6C;
                case 0x9D6A:
                    A = ReadMem(ReadU16Zp((byte)(0xA2 + X))); SetZN(A); TotalCycles += 6; PC = 0x9D6C;
                    goto case 0x9D6C;
                case 0x9D6B:
                    X = 0xA2; SetZN(X); TotalCycles += 2; PC = 0x9D6D;
                    return;
                case 0x9D6C:
                    X = 0xA3; SetZN(X); TotalCycles += 2; PC = 0x9D6E;
                    return;
                case 0x9D70:
                    { byte z = (byte)(0xDD + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x9D72;
                    return;
                case 0x9D71:
                    Cmp(A, ReadMem(0x4CBB + X)); TotalCycles += 4; PC = 0x9D74;
                    goto case 0x9D74;
                case 0x9D73:
                    TotalCycles += 3; PC = 0x1DEA;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9D74:
                     TotalCycles += 2; PC = 0x9D75;
                    goto case 0x9D75;
                case 0x9D75:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x4C1B + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9D78;
                    goto case 0x9D78;
                case 0x9D77:
                    Cmp(Y, ReadIoReg(0x5D56)); TotalCycles += 4; PC = 0x9D7A;
                    goto case 0x9D7A;
                case 0x9D78:
                    { byte z = (byte)(0x5D + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x9D7A;
                    goto case 0x9D7A;
                case 0x9D79:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x1D16 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9D7C;
                    goto case 0x9D7C;
                case 0x9D7A:
                    { byte z = (byte)(0x9D + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x9D7C;
                    goto case 0x9D7C;
                case 0x9D7B:
                    WriteMem(0x1DC6 + X, A); TotalCycles += 5; PC = 0x9D7E;
                    goto case 0x9D7E;
                case 0x9D7C:
                    _ram[0x1D] = DecVal(_ram[0x1D]); TotalCycles += 5; PC = 0x9D7E;
                    goto case 0x9D7E;
                case 0x9D7D:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x1D36 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9D80;
                    goto case 0x9D80;
                case 0x9D7E:
                    { byte z = (byte)(0x9D + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9D80;
                    goto case 0x9D80;
                case 0x9D7F:
                    WriteMem(0x1DC9 + X, A); TotalCycles += 5; PC = 0x9D82;
                    return;
                case 0x9D80:
                    Cmp(A, 0x1D); TotalCycles += 2; PC = 0x9D82;
                    return;
                case 0x9D81:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x5B04 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9D84;
                    goto case 0x9D84;
                case 0x9D84:
                    A ^= 0x1D; SetZN(A); TotalCycles += 2; PC = 0x9D86;
                    goto case 0x9D86;
                case 0x9D85:
                    A |= ReadMem(0x1B84 + X); SetZN(A); TotalCycles += 4; PC = 0x9D88;
                    goto case 0x9D88;
                case 0x9D86: // === SUBROUTINE: Sub_9D86 ===
                    _ram[0x1B] = Y; TotalCycles += 3; PC = 0x9D88;
                    goto case 0x9D88;
                case 0x9D88:
                    Cmp(A, 0x5D); TotalCycles += 2; PC = 0x9D8A;
                    goto case 0x9D8A;
                case 0x9D89:
                    A ^= SmbEmbeddedAssets.StaticDataTables[(0x1588 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9D8C;
                    return;
                case 0x9D8A:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9D8B;
                    goto case 0x9D8B;
                case 0x9D8B:
                    _ram[(byte)(0x0F + X)] = A; TotalCycles += 4; PC = 0x9D8D;
                    goto case 0x9D8D;
                case 0x9D8D:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9D8E;
                    goto case 0x9D8E;
                case 0x9D8E:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9DDC; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9DDC; }
                    PC = 0x9D90; goto case 0x9D90;
                case 0x9D8F:
                    TotalCycles += 3; PC = 0x2D78;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9D90:
                    P |= FlagI; TotalCycles += 2; PC = 0x9D91;
                    goto case 0x9D91;
                case 0x9D91:
                    A &= ReadIoReg(0x28A6); SetZN(A); TotalCycles += 4; PC = 0x9D94;
                    goto case 0x9D94;
                case 0x9D92:
                    X = _ram[0x28]; SetZN(X); TotalCycles += 3; PC = 0x9D94;
                    goto case 0x9D94;
                case 0x9D93:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9D94;
                    goto case 0x9D94;
                case 0x9D94:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9D4B; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9D96; return;
                case 0x9D95:
                    A = _ram[(byte)(0xFF + X)]; SetZN(A); TotalCycles += 4; PC = 0x9D97;
                    return;
                case 0x9D99:
                    { byte z = (byte)(0x1B + X); _ram[z] = Lsr(_ram[z]); } TotalCycles += 6; PC = 0x9D9B;
                    goto case 0x9D9B;
                case 0x9D9B:
                    Cmp(A, 0x1B); TotalCycles += 2; PC = 0x9D9D;
                    return;
                case 0x9D9F:
                    { byte z = (byte)(0x1B + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9DA1;
                    goto case 0x9DA1;
                case 0x9DA1:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9DA2;
                    return;
                case 0x9DA3:
                    PushU8(A); TotalCycles += 3; PC = 0x9DA4;
                    goto case 0x9DA4;
                case 0x9DA4:
                    _ram[(byte)(0x0F + X)] = A; TotalCycles += 4; PC = 0x9DA6;
                    goto case 0x9DA6;
                case 0x9DA6:
                    A = Asl(A); TotalCycles += 2; PC = 0x9DA7;
                    goto case 0x9DA7;
                case 0x9DA7:
                    A = Rol(A); TotalCycles += 2; PC = 0x9DA8;
                    return;
                case 0x9DAB:
                    P |= FlagI; TotalCycles += 2; PC = 0x9DAC;
                    goto case 0x9DAC;
                case 0x9DAC:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x3590]; SetZN(A); TotalCycles += 4; PC = 0x9DAF;
                    return;
                case 0x9DAD:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9D64; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9DAF; return;
                case 0x9DAE:
                    A = _ram[(byte)(0xFF + X)]; SetZN(A); TotalCycles += 4; PC = 0x9DB0;
                    return;
                case 0x9DB1:
                    WriteIoReg(0x4C4B, Y); TotalCycles += 4; PC = 0x9DB4;
                    return;
                case 0x9DB3:
                    TotalCycles += 3; PC = 0x5F77;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9DB8:
                    A = ReadMem(0x19DB + X); SetZN(A); TotalCycles += 4; PC = 0x9DBB;
                    goto case 0x9DBB;
                case 0x9DBA:
                    A |= ReadMem(0x759D + Y); SetZN(A); TotalCycles += 4; PC = 0x9DBD;
                    goto case 0x9DBD;
                case 0x9DBB:
                    WriteMem(0x1D75 + X, A); TotalCycles += 5; PC = 0x9DBE;
                    goto case 0x9DBE;
                case 0x9DBC:
                    Adc(_ram[(byte)(0x1D + X)]); TotalCycles += 4; PC = 0x9DBE;
                    goto case 0x9DBE;
                case 0x9DBD:
                    A |= ReadMem(0x5B7D + X); SetZN(A); TotalCycles += 4; PC = 0x9DC0;
                    goto case 0x9DC0;
                case 0x9DBE:
                    Adc(SmbEmbeddedAssets.StaticDataTables[(0x595B + X) & 0x7FFF]); TotalCycles += 4; PC = 0x9DC1;
                    goto case 0x9DC1;
                case 0x9DC0:
                    Cmp(A, ReadMem(0x3D1D + Y)); TotalCycles += 4; PC = 0x9DC3;
                    goto case 0x9DC3;
                case 0x9DC1:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x5D3D + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9DC4;
                    goto case 0x9DC4;
                case 0x9DC2:
                    A &= SmbEmbeddedAssets.StaticDataTables[(0x19DD + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9DC5;
                    goto case 0x9DC5;
                case 0x9DC3:
                    Cmp(A, ReadMem(0x1D99 + X)); TotalCycles += 4; PC = 0x9DC6;
                    goto case 0x9DC6;
                case 0x9DC4:
                    WriteMem(0x261D + Y, A); TotalCycles += 5; PC = 0x9DC7;
                    goto case 0x9DC7;
                case 0x9DC5:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x1D26 + X) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9DC8;
                    return;
                case 0x9DC6:
                    _ram[0x9D] = Rol(_ram[0x9D]); TotalCycles += 5; PC = 0x9DC8;
                    return;
                case 0x9DC7:
                    WriteMem(0x2B5A + X, A); TotalCycles += 5; PC = 0x9DCA;
                    goto case 0x9DCA;
                case 0x9DCA:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x9DCB;
                    goto case 0x9DCB;
                case 0x9DCB:
                    Bit(_ram[0x03CA]); TotalCycles += 4; PC = 0x9DCE;
                    goto case 0x9DCE;
                case 0x9DCC:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x9DCD;
                    return;
                case 0x9DCE:
                    TotalCycles += 6; PushU16(0x9DD0); PC = 0x7B95;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9DCF:
                    _ram[(byte)(0x7B + X)] = A; TotalCycles += 4; PC = 0x9DD1;
                    return;
                case 0x9DD3:
                    TotalCycles += 3; PC = 0xCC1B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    return;
                case 0x9DD5:
                    Cmp(Y, SmbEmbeddedAssets.StaticDataTables[0x4C3B]); TotalCycles += 4; PC = 0x9DD8;
                    goto case 0x9DD8;
                case 0x9DD7:
                    Cmp(Y, ReadIoReg(0x2D78)); TotalCycles += 4; PC = 0x9DDA;
                    goto case 0x9DDA;
                case 0x9DD8:
                    P |= FlagI; TotalCycles += 2; PC = 0x9DD9;
                    goto case 0x9DD9;
                case 0x9DD9:
                    A &= ReadIoReg(0x28A6); SetZN(A); TotalCycles += 4; PC = 0x9DDC;
                    goto case 0x9DDC;
                case 0x9DDA:
                    X = _ram[0x28]; SetZN(X); TotalCycles += 3; PC = 0x9DDC;
                    goto case 0x9DDC;
                case 0x9DDB:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9DDC;
                    goto case 0x9DDC;
                case 0x9DDC:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9D93; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9D93; }
                    PC = 0x9DDE; return;
                case 0x9DDD:
                    A = _ram[(byte)(0xFF + X)]; SetZN(A); TotalCycles += 4; PC = 0x9DDF;
                    return;
                case 0x9DE0:
                    _ram[0x053B] = Y; TotalCycles += 4; PC = 0x9DE3;
                    return;
                case 0x9DE2:
                    A |= ReadMem(0x1D8B + X); SetZN(A); TotalCycles += 4; PC = 0x9DE5;
                    return;
                case 0x9DE4:
                    A |= ReadMem(0x0CAB + X); SetZN(A); TotalCycles += 4; PC = 0x9DE7;
                    return;
                case 0x9DE8:
                    A |= _ram[(0x030F + X) & 0x07FF]; SetZN(A); TotalCycles += 4; PC = 0x9DEB;
                    goto case 0x9DEB;
                case 0x9DEB:
                    Adc(_ram[0x1D]); TotalCycles += 3; PC = 0x9DED;
                    return;
                case 0x9DEC:
                    A |= ReadMem(0x1B6B + X); SetZN(A); TotalCycles += 4; PC = 0x9DEF;
                    goto case 0x9DEF;
                case 0x9DEF:
                    A |= _ram[0x9D]; SetZN(A); TotalCycles += 3; PC = 0x9DF1;
                    return;
                case 0x9DF0:
                    WriteMem(0x1B0B + X, A); TotalCycles += 5; PC = 0x9DF3;
                    goto case 0x9DF3;
                case 0x9DF3:
                    A |= _ram[0x9B]; SetZN(A); TotalCycles += 3; PC = 0x9DF5;
                    return;
                case 0x9DF6:
                    A |= ReadMem(0x0C8B + X); SetZN(A); TotalCycles += 4; PC = 0x9DF9;
                    return;
                case 0x9DFA:
                    _ram[0x0570] = Y; TotalCycles += 4; PC = 0x9DFD;
                    return;
                case 0x9DFB:
                    TotalCycles += 2;
                    if ((P & FlagV) != 0) { TotalCycles += 1; PC = 0x9E12; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9DFD; return;
                case 0x9DFC:
                    A |= _ram[(byte)(0x7B + X)]; SetZN(A); TotalCycles += 4; PC = 0x9DFE;
                    return;
                case 0x9E02:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9E03;
                    goto case 0x9E03;
                case 0x9E03:
                    P |= FlagI; TotalCycles += 2; PC = 0x9E04;
                    goto case 0x9E04;
                case 0x9E04:
                    A &= ReadIoReg(0x28A6); SetZN(A); TotalCycles += 4; PC = 0x9E07;
                    goto case 0x9E07;
                case 0x9E05:
                    X = _ram[0x28]; SetZN(X); TotalCycles += 3; PC = 0x9E07;
                    goto case 0x9E07;
                case 0x9E06:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9E07;
                    goto case 0x9E07;
                case 0x9E07:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9DBE; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9DBE; }
                    PC = 0x9E09; return;
                case 0x9E08:
                    A = _ram[(byte)(0xFF + X)]; SetZN(A); TotalCycles += 4; PC = 0x9E0A;
                    return;
                case 0x9E0B:
                    A = 0x4B; SetZN(A); TotalCycles += 2; PC = 0x9E0D;
                    return;
                case 0x9E0E:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9E0F;
                    goto case 0x9E0F;
                case 0x9E0F:
                    A &= 0x0F; SetZN(A); TotalCycles += 2; PC = 0x9E11;
                    goto case 0x9E11;
                case 0x9E11:
                    _ram[0x77] = Asl(_ram[0x77]); TotalCycles += 5; PC = 0x9E13;
                    return;
                case 0x9E16:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9E17:
                    A |= _ram[(byte)(0x4B + X)]; SetZN(A); TotalCycles += 4; PC = 0x9E19;
                    goto case 0x9E19;
                case 0x9E19:
                    WriteIoReg(0x2D78, Y); TotalCycles += 4; PC = 0x9E1C;
                    goto case 0x9E1C;
                case 0x9E1A:
                    P |= FlagI; TotalCycles += 2; PC = 0x9E1B;
                    goto case 0x9E1B;
                case 0x9E1B:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x3590]; SetZN(A); TotalCycles += 4; PC = 0x9E1E;
                    return;
                case 0x9E1C:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9DD3; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9DD3; }
                    PC = 0x9E1E; return;
                case 0x9E1D:
                    A = _ram[(byte)(0xFF + X)]; SetZN(A); TotalCycles += 4; PC = 0x9E1F;
                    return;
                case 0x9E21:
                    WriteIoReg(0xE165, X); TotalCycles += 4; PC = 0x9E24;
                    return;
                case 0x9E22:
                    Adc(_ram[0xE1]); TotalCycles += 3; PC = 0x9E24;
                    return;
                case 0x9E23:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xBB + X)))); TotalCycles += 6; PC = 0x9E25;
                    goto case 0x9E25;
                case 0x9E25:
                    P |= FlagC; TotalCycles += 2; PC = 0x9E26;
                    goto case 0x9E26;
                case 0x9E26:
                    Adc(ReadIoReg(0x3EA8)); TotalCycles += 4; PC = 0x9E29;
                    goto case 0x9E29;
                case 0x9E27:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9E28;
                    goto case 0x9E28;
                case 0x9E28:
                    { int a = 0xE7E5 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0x9E2B;
                    return;
                case 0x9E29:
                    Sbc(_ram[0xE7]); TotalCycles += 3; PC = 0x9E2B;
                    return;
                case 0x9E2C:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9E2D;
                    return;
                case 0x9E31:
                    { int a = 0xE165 + X; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 7; PC = 0x9E34;
                    return;
                case 0x9E32:
                    Adc(_ram[0xE1]); TotalCycles += 3; PC = 0x9E34;
                    return;
                case 0x9E33:
                    Sbc(ReadMem(ReadU16Zp((byte)(0xBB + X)))); TotalCycles += 6; PC = 0x9E35;
                    goto case 0x9E35;
                case 0x9E35:
                    _ram[0x06DB] = Asl(_ram[0x06DB]); TotalCycles += 6; PC = 0x9E38;
                    return;
                case 0x9E37:
                    { int a = 0x8EBB; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9E3A;
                    return;
                case 0x9E39:
                    _ram[0x06DB] = X; TotalCycles += 4; PC = 0x9E3C;
                    goto case 0x9E3C;
                case 0x9E3B:
                    { int a = 0x65FE; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9E3E;
                    goto case 0x9E3E;
                case 0x9E3C:
                    { int a = 0xEC65 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0x9E3F;
                    return;
                case 0x9E3D:
                    Adc(_ram[0xEC]); TotalCycles += 3; PC = 0x9E3F;
                    return;
                case 0x9E3E:
                    Cmp(X, _ram[0x050F]); TotalCycles += 4; PC = 0x9E41;
                    goto case 0x9E41;
                case 0x9E40:
                    A |= ReadIoReg(0x654E); SetZN(A); TotalCycles += 4; PC = 0x9E43;
                    goto case 0x9E43;
                case 0x9E41:
                    { int a = 0xE165; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9E44;
                    return;
                case 0x9E42:
                    Adc(_ram[0xE1]); TotalCycles += 3; PC = 0x9E44;
                    return;
                case 0x9E43:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x0F + X)))); TotalCycles += 6; PC = 0x9E45;
                    goto case 0x9E45;
                case 0x9E45:
                    _ram[0x024E] = Asl(_ram[0x024E]); TotalCycles += 6; PC = 0x9E48;
                    goto case 0x9E48;
                case 0x9E46:
                    { int a = 0xE002; WriteMem(a, Lsr(ReadMem(a))); } TotalCycles += 6; PC = 0x9E49;
                    return;
                case 0x9E48:
                    Cmp(X, 0x0F); TotalCycles += 2; PC = 0x9E4A;
                    goto case 0x9E4A;
                case 0x9E4A:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9E4A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9E4A; }
                    PC = 0x9E4C; goto case 0x9E4C;
                case 0x9E4B:
                    { int a = 0xE1E5 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0x9E4E;
                    return;
                case 0x9E4C:
                    Sbc(_ram[0xE1]); TotalCycles += 3; PC = 0x9E4E;
                    return;
                case 0x9E4D:
                    Sbc(ReadMem(ReadU16Zp((byte)(0x1B + X)))); TotalCycles += 6; PC = 0x9E4F;
                    goto case 0x9E4F;
                case 0x9E4F:
                    _ram[0x7B] = A; TotalCycles += 3; PC = 0x9E51;
                    return;
                case 0x9E53:
                    _ram[(byte)(0x78 + X)] = A; TotalCycles += 4; PC = 0x9E55;
                    goto case 0x9E55;
                case 0x9E54:
                    P |= FlagI; TotalCycles += 2; PC = 0x9E55;
                    goto case 0x9E55;
                case 0x9E55:
                    A &= SmbEmbeddedAssets.StaticDataTables[0x3590]; SetZN(A); TotalCycles += 4; PC = 0x9E58;
                    return;
                case 0x9E56:
                    TotalCycles += 2;
                    if ((P & FlagC) == 0) { TotalCycles += 1; PC = 0x9E0D; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9E58; return;
                case 0x9E57:
                    A = _ram[(byte)(0xFF + X)]; SetZN(A); TotalCycles += 4; PC = 0x9E59;
                    goto case 0x9E59;
                case 0x9E59:
                    A = _ram[0x86]; SetZN(A); TotalCycles += 3; PC = 0x9E5B;
                    goto case 0x9E5B;
                case 0x9E5A:
                    _ram[0xE4] = X; TotalCycles += 3; PC = 0x9E5C;
                    goto case 0x9E5C;
                case 0x9E5B:
                    Cmp(X, _ram[0x28]); TotalCycles += 3; PC = 0x9E5D;
                    goto case 0x9E5D;
                case 0x9E5C:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9E5D;
                    goto case 0x9E5D;
                case 0x9E5D:
                    P &= unchecked((byte)~FlagC); TotalCycles += 2; PC = 0x9E5E;
                    goto case 0x9E5E;
                case 0x9E5E:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9E5F;
                    goto case 0x9E5F;
                case 0x9E5F:
                    A ^= _ram[0x83]; SetZN(A); TotalCycles += 3; PC = 0x9E61;
                    goto case 0x9E61;
                case 0x9E61:
                    Adc(0x03); TotalCycles += 2; PC = 0x9E63;
                    goto case 0x9E63;
                case 0x9E63:
                    _ram[0x29] = DecVal(_ram[0x29]); TotalCycles += 5; PC = 0x9E65;
                    return;
                case 0x9E64:
                    A &= 0x9B; SetZN(A); TotalCycles += 2; PC = 0x9E66;
                    return;
                case 0x9E67:
                    { byte z = (byte)(0xA4 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x9E69;
                    goto case 0x9E69;
                case 0x9E68:
                    Y = _ram[0x88]; SetZN(Y); TotalCycles += 3; PC = 0x9E6A;
                    goto case 0x9E6A;
                case 0x9E69:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9E6A;
                    goto case 0x9E6A;
                case 0x9E6A:
                    Bit(_ram[0xE9]); TotalCycles += 3; PC = 0x9E6C;
                    goto case 0x9E6C;
                case 0x9E6B:
                    Sbc(0x28); TotalCycles += 2; PC = 0x9E6D;
                    goto case 0x9E6D;
                case 0x9E6C:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9E6D;
                    goto case 0x9E6D;
                case 0x9E6D:
                    A |= _ram[0xA8]; SetZN(A); TotalCycles += 3; PC = 0x9E6F;
                    return;
                case 0x9E6E:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9E6F;
                    return;
                case 0x9E70:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9E71;
                    goto case 0x9E71;
                case 0x9E71:
                    Bit(_ram[0x8F]); TotalCycles += 3; PC = 0x9E73;
                    goto case 0x9E73;
                case 0x9E73:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9E74;
                    return;
                case 0x9E75:
                    X++; SetZN(X); TotalCycles += 2; PC = 0x9E76;
                    return;
                case 0x9E77:
                    _ram[0xA8] = Lsr(_ram[0xA8]); TotalCycles += 5; PC = 0x9E79;
                    goto case 0x9E79;
                case 0x9E78:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9E79;
                    goto case 0x9E79;
                case 0x9E79:
                    _ram[0x24] = A; TotalCycles += 3; PC = 0x9E7B;
                    goto case 0x9E7B;
                case 0x9E7A:
                    Bit(_ram[0xC8]); TotalCycles += 3; PC = 0x9E7C;
                    goto case 0x9E7C;
                case 0x9E7B:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9E7C;
                    goto case 0x9E7C;
                case 0x9E7C:
                    Bit(_ram[0xFF]); TotalCycles += 3; PC = 0x9E7E;
                    return;
                case 0x9E7F:
                    _ram[0x030F] = X; TotalCycles += 4; PC = 0x9E82;
                    return;
                case 0x9E83:
                    A |= _ram[0x17]; SetZN(A); TotalCycles += 3; PC = 0x9E85;
                    goto case 0x9E85;
                case 0x9E85:
                    _ram[0xDB] = A; TotalCycles += 3; PC = 0x9E87;
                    goto case 0x9E87;
                case 0x9E87:
                    _ram[0x070F] = X; TotalCycles += 4; PC = 0x9E8A;
                    return;
                case 0x9E8B:
                    A |= _ram[0x7B]; SetZN(A); TotalCycles += 3; PC = 0x9E8D;
                    goto case 0x9E8D;
                case 0x9E8D:
                    A |= _ram[0x9B]; SetZN(A); TotalCycles += 3; PC = 0x9E8F;
                    return;
                case 0x9E91:
                    _ram[0xFB] = A; TotalCycles += 3; PC = 0x9E93;
                    goto case 0x9E93;
                case 0x9E93:
                    A |= _ram[0x0F]; SetZN(A); TotalCycles += 3; PC = 0x9E95;
                    return;
                case 0x9E97:
                    A |= _ram[0x9B]; SetZN(A); TotalCycles += 3; PC = 0x9E99;
                    goto case 0x9E99;
                case 0x9E99:
                    A |= _ram[0xFF]; SetZN(A); TotalCycles += 3; PC = 0x9E9B;
                    goto case 0x9E9B;
                case 0x9E9B:
                    { int a = 0x66C2; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 6; PC = 0x9E9E;
                    return;
                case 0x9E9D:
                    _ram[0xE2] = Ror(_ram[0xE2]); TotalCycles += 5; PC = 0x9E9F;
                    goto case 0x9E9F;
                case 0x9E9F:
                    A |= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0x9EA1;
                    return;
                case 0x9EA3:
                    A |= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0x9EA5;
                    return;
                case 0x9EA7:
                    A |= ReadMem(ReadU16Zp(0xFF) + Y); SetZN(A); TotalCycles += 5; PC = 0x9EA9;
                    goto case 0x9EA9;
                case 0x9EA9:
                    { int a = 0xA8C2; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9EAC;
                    return;
                case 0x9EAB:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9EAC;
                    return;
                case 0x9EAD:
                    TotalCycles += 7; PushU16(0x9EAF); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9EAF:
                    WriteIoReg(0x826B, X); TotalCycles += 4; PC = 0x9EB2;
                    goto case 0x9EB2;
                case 0x9EB2:
                    { int a = 0xA000 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0x9EB5;
                    return;
                case 0x9EB3:
                    TotalCycles += 7; PushU16(0x9EB5); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9EB4:
                    Y = 0x33; SetZN(Y); TotalCycles += 2; PC = 0x9EB6;
                    goto case 0x9EB6;
                case 0x9EB6:
                    _ram[0x43] = X; TotalCycles += 3; PC = 0x9EB8;
                    goto case 0x9EB8;
                case 0x9EB8:
                    _ram[0x3E] = Asl(_ram[0x3E]); TotalCycles += 5; PC = 0x9EBA;
                    goto case 0x9EBA;
                case 0x9EB9:
                    { int a = 0xA0B4 + X; WriteMem(a, Rol(ReadMem(a))); } TotalCycles += 7; PC = 0x9EBC;
                    return;
                case 0x9EBA:
                    Y = _ram[(byte)(0xA0 + X)]; SetZN(Y); TotalCycles += 4; PC = 0x9EBC;
                    return;
                case 0x9EBB:
                    Y = 0xCB; SetZN(Y); TotalCycles += 2; PC = 0x9EBD;
                    return;
                case 0x9EC0:
                    { int a = 0xA642 + X; WriteMem(a, Ror(ReadMem(a))); } TotalCycles += 7; PC = 0x9EC3;
                    return;
                case 0x9EC2:
                    X = _ram[0x83]; SetZN(X); TotalCycles += 3; PC = 0x9EC4;
                    return;
                case 0x9EC6:
                    A = Asl(A); TotalCycles += 2; PC = 0x9EC7;
                    return;
                case 0x9ECE:
                    { int a = 0x9BFF; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9ED1;
                    goto case 0x9ED1;
                case 0x9ED1:
                    _ram[0x06CA] = X; TotalCycles += 4; PC = 0x9ED4;
                    goto case 0x9ED4;
                case 0x9ED2:
                    X--; SetZN(X); TotalCycles += 2; PC = 0x9ED3;
                    goto case 0x9ED3;
                case 0x9ED3:
                    { int a = 0x42EE; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9ED6;
                    return;
                case 0x9ED4:
                    { int a = 0x4442; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0x9ED7;
                    return;
                case 0x9ED8:
                    _ram[0x80] = X; TotalCycles += 3; PC = 0x9EDA;
                    goto case 0x9EDA;
                case 0x9EDA:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0x9EDB;
                    return;
                case 0x9EDD:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x9E99; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9E99; }
                    PC = 0x9EDF; goto case 0x9EDF;
                case 0x9EDE:
                    X = SP; SetZN(X); TotalCycles += 2; PC = 0x9EDF;
                    goto case 0x9EDF;
                case 0x9EDF:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9E98; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9EE1; return;
                case 0x9EE2:
                    TotalCycles += 7; PushU16(0x9EE4); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9EE4:
                    _ram[0x4B] = A; TotalCycles += 3; PC = 0x9EE6;
                    goto case 0x9EE6;
                case 0x9EE6:
                    A |= _ram[0xFE]; SetZN(A); TotalCycles += 3; PC = 0x9EE8;
                    return;
                case 0x9EE7:
                    { int a = 0x4034 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0x9EEA;
                    return;
                case 0x9EE9:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x9EEB:
                    _ram[0xC6] = X; TotalCycles += 3; PC = 0x9EED;
                    goto case 0x9EED;
                case 0x9EEC:
                    _ram[0x06] = DecVal(_ram[0x06]); TotalCycles += 5; PC = 0x9EEE;
                    return;
                case 0x9EED:
                    _ram[0x5B] = Asl(_ram[0x5B]); TotalCycles += 5; PC = 0x9EEF;
                    return;
                case 0x9EF1:
                    TotalCycles += 7; PushU16(0x9EF3); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9EF2:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9F2C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9F2C; }
                    PC = 0x9EF4; return;
                case 0x9EF3:
                    P |= FlagC; TotalCycles += 2; PC = 0x9EF4;
                    return;
                case 0x9EF5:
                    _ram[0x068A] = X; TotalCycles += 4; PC = 0x9EF8;
                    goto case 0x9EF8;
                case 0x9EF6:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x9EF7;
                    goto case 0x9EF7;
                case 0x9EF7:
                    _ram[0x00A6] = Asl(_ram[0x00A6]); TotalCycles += 6; PC = 0x9EFA;
                    return;
                case 0x9EF8:
                    X = _ram[0x00]; SetZN(X); TotalCycles += 3; PC = 0x9EFA;
                    return;
                case 0x9EF9:
                    TotalCycles += 7; PushU16(0x9EFB); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9EFB:
                    { int a = 0x80C5; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9EFE;
                    return;
                case 0x9EFC:
                    Cmp(A, _ram[0x80]); TotalCycles += 3; PC = 0x9EFE;
                    return;
                case 0x9EFF:
                    TotalCycles += 7; PushU16(0x9F01); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9F01:
                    { int a = (0x00C2 + X) & 0x07FF; _ram[a] = Asl(_ram[a]); } TotalCycles += 7; PC = 0x9F04;
                    return;
                case 0x9F03:
                    TotalCycles += 7; PushU16(0x9F05); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9F05:
                    _ram[0x8B] = Asl(_ram[0x8B]); TotalCycles += 5; PC = 0x9F07;
                    goto case 0x9F07;
                case 0x9F07:
                    _ram[0x63] = X; TotalCycles += 3; PC = 0x9F09;
                    return;
                case 0x9F0B:
                    A |= _ram[0x03]; SetZN(A); TotalCycles += 3; PC = 0x9F0D;
                    goto case 0x9F0D;
                case 0x9F0D:
                    _ram[0x23] = Asl(_ram[0x23]); TotalCycles += 5; PC = 0x9F0F;
                    goto case 0x9F0F;
                case 0x9F0F:
                    _ram[0x4B] = Asl(_ram[0x4B]); TotalCycles += 5; PC = 0x9F11;
                    return;
                case 0x9F13:
                    TotalCycles += 7; PushU16(0x9F15); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9F24:
                    _ram[0xE2] = X; TotalCycles += 3; PC = 0x9F26;
                    goto case 0x9F26;
                case 0x9F26:
                    _ram[0x76] = Asl(_ram[0x76]); TotalCycles += 5; PC = 0x9F28;
                    goto case 0x9F28;
                case 0x9F27:
                    { byte z = (byte)(0xA5 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x9F29;
                    return;
                case 0x9F28:
                    A = _ram[0xA3]; SetZN(A); TotalCycles += 3; PC = 0x9F2A;
                    return;
                case 0x9F2C:
                    _ram[0x2B] = X; TotalCycles += 3; PC = 0x9F2E;
                    return;
                case 0x9F2F:
                    A = PopU8(); SetZN(A); TotalCycles += 4; PC = 0x9F30;
                    goto case 0x9F30;
                case 0x9F30:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9F31;
                    goto case 0x9F31;
                case 0x9F31:
                    Sbc(0x28); TotalCycles += 2; PC = 0x9F33;
                    goto case 0x9F33;
                case 0x9F32:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9F33;
                    goto case 0x9F33;
                case 0x9F33:
                    Sbc(_ram[0x83]); TotalCycles += 3; PC = 0x9F35;
                    goto case 0x9F35;
                case 0x9F35:
                    Bit(_ram[0x8F]); TotalCycles += 3; PC = 0x9F37;
                    goto case 0x9F37;
                case 0x9F37:
                    { byte z = (byte)(0xA8 + X); _ram[z] = Rol(_ram[z]); } TotalCycles += 6; PC = 0x9F39;
                    return;
                case 0x9F38:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9F39;
                    return;
                case 0x9F3E:
                    P |= FlagI; TotalCycles += 2; PC = 0x9F3F;
                    goto case 0x9F3F;
                case 0x9F3F:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x9F40:
                    PushU8(A); TotalCycles += 3; PC = 0x9F41;
                    goto case 0x9F41;
                case 0x9F41:
                    { int a = 0xC3F8; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 6; PC = 0x9F44;
                    goto case 0x9F44;
                case 0x9F42:
                    P |= FlagD; TotalCycles += 2; PC = 0x9F43;
                    return;
                case 0x9F44:
                    P |= FlagD; TotalCycles += 2; PC = 0x9F45;
                    return;
                case 0x9F4A:
                    _ram[0xD0] = DecVal(_ram[0xD0]); TotalCycles += 5; PC = 0x9F4C;
                    return;
                case 0x9F4B:
                    TotalCycles += 2;
                    if ((P & FlagZ) == 0) { TotalCycles += 1; PC = 0x9F5C; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9F4D; goto case 0x9F4D;
                case 0x9F4D:
                    A = X; SetZN(A); TotalCycles += 2; PC = 0x9F4E;
                    goto case 0x9F4E;
                case 0x9F4E:
                    Y++; SetZN(Y); TotalCycles += 2; PC = 0x9F4F;
                    goto case 0x9F4F;
                case 0x9F4F:
                    TotalCycles += 2;
                    if ((P & FlagV) == 0) { TotalCycles += 1; PC = 0x9F50; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9F51; goto case 0x9F51;
                case 0x9F51:
                    _ram[0x86] = A; TotalCycles += 3; PC = 0x9F53;
                    return;
                case 0x9F52:
                    _ram[0x0B] = X; TotalCycles += 3; PC = 0x9F54;
                    return;
                case 0x9F56:
                    TotalCycles += 7; PushU16(0x9F58); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9F5D:
                    { int a = 0x202B + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0x9F60;
                    return;
                case 0x9F5F:
                    TotalCycles += 6; PushU16(0x9F61); PC = 0x802B;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x802B;
                case 0x9F63:
                    P |= FlagC; TotalCycles += 2; PC = 0x9F64;
                    return;
                case 0x9F65:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0x9F66;
                    return;
                case 0x9F67:
                    _ram[0xFE] = X; TotalCycles += 3; PC = 0x9F69;
                    return;
                case 0x9F68:
                    { int a = 0x2042 + X; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 7; PC = 0x9F6B;
                    goto case 0x9F6B;
                case 0x9F6A:
                    TotalCycles += 6; PushU16(0x9F6C); PC = 0x8649;
                    if (TotalCycles >= targetCycles || Ppu.NmiPending) return;
                    goto case 0x8649;
                case 0x9F6B:
                    A ^= 0x86; SetZN(A); TotalCycles += 2; PC = 0x9F6D;
                    return;
                case 0x9F6C:
                    _ram[0x8B] = X; TotalCycles += 3; PC = 0x9F6E;
                    goto case 0x9F6E;
                case 0x9F6E:
                    _ram[0x9B] = Asl(_ram[0x9B]); TotalCycles += 5; PC = 0x9F70;
                    return;
                case 0x9F72:
                    WriteIoReg(0xB75B, X); TotalCycles += 4; PC = 0x9F75;
                    return;
                case 0x9F76:
                    _ram[0x06BB] = Asl(_ram[0x06BB]); TotalCycles += 6; PC = 0x9F79;
                    return;
                case 0x9F78:
                    { int a = 0x809B; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9F7B;
                    return;
                case 0x9F7E:
                    TotalCycles += 6; PC = (ushort)(PopU16() + 1); return;
                case 0x9F7F:
                    P |= FlagC; TotalCycles += 2; PC = 0x9F80;
                    goto case 0x9F80;
                case 0x9F80:
                    TotalCycles += 2;
                    if ((P & FlagN) == 0) { TotalCycles += 1; PC = 0x9F3A; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; return; }
                    PC = 0x9F82; goto case 0x9F82;
                case 0x9F81:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0x9F82;
                    goto case 0x9F82;
                case 0x9F82:
                    Cmp(Y, 0x3B); TotalCycles += 2; PC = 0x9F84;
                    return;
                case 0x9F85:
                    WriteIoReg(0xB840, X); TotalCycles += 4; PC = 0x9F88;
                    goto case 0x9F88;
                case 0x9F86:
                    TotalCycles += 6; P = (byte)((PopU8() & ~FlagB) | FlagU); PC = PopU16(); return;
                case 0x9F87:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0x9F88;
                    goto case 0x9F88;
                case 0x9F88:
                    TotalCycles += 2;
                    if ((P & FlagZ) != 0) { TotalCycles += 1; PC = 0x9FC2; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9FC2; }
                    PC = 0x9F8A; return;
                case 0x9F89:
                    P |= FlagC; TotalCycles += 2; PC = 0x9F8A;
                    return;
                case 0x9F8B:
                    WriteIoReg(0xB8A0, X); TotalCycles += 4; PC = 0x9F8E;
                    goto case 0x9F8E;
                case 0x9F8C:
                    Y = 0xB8; SetZN(Y); TotalCycles += 2; PC = 0x9F8E;
                    goto case 0x9F8E;
                case 0x9F8D:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0x9F8E;
                    goto case 0x9F8E;
                case 0x9F8E:
                    Cmp(Y, 0xB8); TotalCycles += 2; PC = 0x9F90;
                    return;
                case 0x9F8F:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0x9F90;
                    return;
                case 0x9F91:
                    TotalCycles += 7; PushU16(0x9F93); PushU8((byte)(P | FlagB | FlagU)); P |= FlagI; PC = 0xFFF0; return;
                case 0x9F92:
                    Y = 0xB8; SetZN(Y); TotalCycles += 2; PC = 0x9F94;
                    goto case 0x9F94;
                case 0x9F93:
                    P &= unchecked((byte)~FlagV); TotalCycles += 2; PC = 0x9F94;
                    goto case 0x9F94;
                case 0x9F94:
                    TotalCycles += 2;
                    if ((P & FlagN) != 0) { TotalCycles += 1; PC = 0x9F51; if (TotalCycles >= targetCycles || Ppu.NmiPending) return; goto case 0x9F51; }
                    PC = 0x9F96; goto case 0x9F96;
                case 0x9F96:
                    { int a = 0x8842; WriteMem(a, IncVal(ReadMem(a))); } TotalCycles += 6; PC = 0x9F99;
                    return;
                case 0x9F98:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9F99;
                    return;
                case 0x9F9C:
                    _ram[0x0667] = Asl(_ram[0x0667]); TotalCycles += 6; PC = 0x9F9F;
                    return;
                case 0x9F9E:
                    _ram[0x02FF] = Asl(_ram[0x02FF]); TotalCycles += 6; PC = 0x9FA1;
                    goto case 0x9FA1;
                case 0x9FA0:
                    A = Asl(A); TotalCycles += 2; PC = 0x9FA1;
                    goto case 0x9FA1;
                case 0x9FA1:
                    X = A; SetZN(X); TotalCycles += 2; PC = 0x9FA2;
                    goto case 0x9FA2;
                case 0x9FA2:
                    { int a = 0x2A28; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9FA5;
                    goto case 0x9FA5;
                case 0x9FA3:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9FA4;
                    goto case 0x9FA4;
                case 0x9FA4:
                    A = Rol(A); TotalCycles += 2; PC = 0x9FA5;
                    goto case 0x9FA5;
                case 0x9FA5:
                    { int a = 0x8831; WriteMem(a, Asl(ReadMem(a))); } TotalCycles += 6; PC = 0x9FA8;
                    return;
                case 0x9FA6:
                    A &= ReadMem(ReadU16Zp(0x88) + Y); SetZN(A); TotalCycles += 5; PC = 0x9FA8;
                    return;
                case 0x9FA7:
                    Y--; SetZN(Y); TotalCycles += 2; PC = 0x9FA8;
                    return;
                case 0x9FB1:
                    A |= _ram[0xA4]; SetZN(A); TotalCycles += 3; PC = 0x9FB3;
                    goto case 0x9FB3;
                case 0x9FB2:
                    Y = _ram[0x78]; SetZN(Y); TotalCycles += 3; PC = 0x9FB4;
                    goto case 0x9FB4;
                case 0x9FB3:
                    P |= FlagI; TotalCycles += 2; PC = 0x9FB4;
                    goto case 0x9FB4;
                case 0x9FB4:
                    Bit(_ram[0xA6]); TotalCycles += 3; PC = 0x9FB6;
                    goto case 0x9FB6;
                case 0x9FB5:
                    X = _ram[0x25]; SetZN(X); TotalCycles += 3; PC = 0x9FB7;
                    goto case 0x9FB7;
                case 0x9FB6:
                    A &= _ram[0xE4]; SetZN(A); TotalCycles += 3; PC = 0x9FB8;
                    goto case 0x9FB8;
                case 0x9FB7:
                    Cmp(X, _ram[0x25]); TotalCycles += 3; PC = 0x9FB9;
                    return;
                case 0x9FB8:
                    A &= _ram[0x4B]; SetZN(A); TotalCycles += 3; PC = 0x9FBA;
                    return;
                case 0x9FBD:
                    A |= _ram[0xA4]; SetZN(A); TotalCycles += 3; PC = 0x9FBF;
                    return;
                case 0x9FBE:
                    Y = _ram[0x89]; SetZN(Y); TotalCycles += 3; PC = 0x9FC0;
                    goto case 0x9FC0;
                case 0x9FC0:
                    Bit(_ram[0xB5]); TotalCycles += 3; PC = 0x9FC2;
                    goto case 0x9FC2;
                case 0x9FC1:
                    A = _ram[(byte)(0x24 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9FC3;
                    goto case 0x9FC3;
                case 0x9FC2:
                    Bit(_ram[0x09]); TotalCycles += 3; PC = 0x9FC4;
                    goto case 0x9FC4;
                case 0x9FC3:
                    A |= 0xA4; SetZN(A); TotalCycles += 2; PC = 0x9FC5;
                    goto case 0x9FC5;
                case 0x9FC4:
                    Y = _ram[0x65]; SetZN(Y); TotalCycles += 3; PC = 0x9FC6;
                    goto case 0x9FC6;
                case 0x9FC5:
                    Adc(_ram[0x24]); TotalCycles += 3; PC = 0x9FC7;
                    goto case 0x9FC7;
                case 0x9FC6:
                    Bit(_ram[0xC9]); TotalCycles += 3; PC = 0x9FC8;
                    goto case 0x9FC8;
                case 0x9FC7:
                    Cmp(A, 0x24); TotalCycles += 2; PC = 0x9FC9;
                    return;
                case 0x9FC8:
                    Bit(_ram[0x0F]); TotalCycles += 3; PC = 0x9FCA;
                    goto case 0x9FCA;
                case 0x9FCA:
                    PushU8((byte)(P | FlagB | FlagU)); TotalCycles += 3; PC = 0x9FCB;
                    goto case 0x9FCB;
                case 0x9FCB:
                    _ram[0x25] = A; TotalCycles += 3; PC = 0x9FCD;
                    return;
                case 0x9FCC:
                    A &= _ram[0xFF]; SetZN(A); TotalCycles += 3; PC = 0x9FCE;
                    goto case 0x9FCE;
                case 0x9FCE:
                    Cmp(A, SmbEmbeddedAssets.StaticDataTables[0x35A5]); TotalCycles += 4; PC = 0x9FD1;
                    goto case 0x9FD1;
                case 0x9FCF:
                    A = _ram[0xB5]; SetZN(A); TotalCycles += 3; PC = 0x9FD1;
                    goto case 0x9FD1;
                case 0x9FD0:
                    A = _ram[(byte)(0xA8 + X)]; SetZN(A); TotalCycles += 4; PC = 0x9FD2;
                    return;
                case 0x9FD1:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9FD2;
                    return;
                case 0x9FD3:
                    Y = A; SetZN(Y); TotalCycles += 2; PC = 0x9FD4;
                    goto case 0x9FD4;
                case 0x9FD4:
                    { byte z = (byte)(0x28 + X); _ram[z] = Ror(_ram[z]); } TotalCycles += 6; PC = 0x9FD6;
                    goto case 0x9FD6;
                case 0x9FD5:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9FD6;
                    goto case 0x9FD6;
                case 0x9FD6:
                    Cmp(Y, ReadIoReg(0x6525)); TotalCycles += 4; PC = 0x9FD9;
                    goto case 0x9FD9;
                case 0x9FD7:
                    A &= _ram[0x65]; SetZN(A); TotalCycles += 3; PC = 0x9FD9;
                    goto case 0x9FD9;
                case 0x9FD8:
                    Adc(_ram[0xA4]); TotalCycles += 3; PC = 0x9FDA;
                    goto case 0x9FDA;
                case 0x9FD9:
                    Y = _ram[0xA9]; SetZN(Y); TotalCycles += 3; PC = 0x9FDB;
                    goto case 0x9FDB;
                case 0x9FDA:
                    A = 0x24; SetZN(A); TotalCycles += 2; PC = 0x9FDC;
                    goto case 0x9FDC;
                case 0x9FDB:
                    Bit(_ram[0xE5]); TotalCycles += 3; PC = 0x9FDD;
                    goto case 0x9FDD;
                case 0x9FDC:
                    Sbc(_ram[0x24]); TotalCycles += 3; PC = 0x9FDE;
                    goto case 0x9FDE;
                case 0x9FDD:
                    Bit(_ram[0x19]); TotalCycles += 3; PC = 0x9FDF;
                    goto case 0x9FDF;
                case 0x9FDE:
                    A |= ReadMem(0x0FA4 + Y); SetZN(A); TotalCycles += 4; PC = 0x9FE1;
                    return;
                case 0x9FDF:
                    Y = _ram[0x0F]; SetZN(Y); TotalCycles += 3; PC = 0x9FE1;
                    return;
                case 0x9FE2:
                    _ram[(byte)(0x28 + X)] = A; TotalCycles += 4; PC = 0x9FE4;
                    goto case 0x9FE4;
                case 0x9FE3:
                    P = (byte)((PopU8() & ~FlagB) | FlagU); TotalCycles += 4; PC = 0x9FE4;
                    goto case 0x9FE4;
                case 0x9FE4:
                    _ram[0x24] = IncVal(_ram[0x24]); TotalCycles += 5; PC = 0x9FE6;
                    goto case 0x9FE6;
                case 0x9FE5:
                    Bit(_ram[0x19]); TotalCycles += 3; PC = 0x9FE7;
                    goto case 0x9FE7;
                case 0x9FE6:
                    A |= SmbEmbeddedAssets.StaticDataTables[(0x57A4 + Y) & 0x7FFF]; SetZN(A); TotalCycles += 4; PC = 0x9FE9;
                    goto case 0x9FE9;
                case 0x9FE7:
                    Y = _ram[0xD7]; SetZN(Y); TotalCycles += 3; PC = 0x9FE9;
                    goto case 0x9FE9;
                case 0x9FE9:
                    A &= 0x16; SetZN(A); TotalCycles += 2; PC = 0x9FEB;
                    goto case 0x9FEB;
                case 0x9FEA:
                    { byte z = (byte)(0xA9 + X); _ram[z] = Asl(_ram[z]); } TotalCycles += 6; PC = 0x9FEC;
                    goto case 0x9FEC;
                case 0x9FEB:
                    A = 0x58; SetZN(A); TotalCycles += 2; PC = 0x9FED;
                    goto case 0x9FED;
                case 0x9FEC:
                    P &= unchecked((byte)~FlagI); TotalCycles += 2; PC = 0x9FED;
                    goto case 0x9FED;
                case 0x9FED:
                    A &= 0x97; SetZN(A); TotalCycles += 2; PC = 0x9FEF;
                    goto case 0x9FEF;
                case 0x9FEF:
                    A &= 0xFF; SetZN(A); TotalCycles += 2; PC = 0x9FF1;
                    return;
                case 0x9FF4:
                    A |= ReadMem(ReadU16Zp(0x0F) + Y); SetZN(A); TotalCycles += 5; PC = 0x9FF6;
                    return;
                case 0x9FF8:
                    A |= ReadMem(ReadU16Zp(0xFF) + Y); SetZN(A); TotalCycles += 5; PC = 0x9FFA;
                    return;
                case 0x9FFE:
                    P |= FlagC; TotalCycles += 2; PC = 0x9FFF;
                    goto case 0x9FFF;
                case 0x9FFF:
                    { int a = 0xE242 + X; WriteMem(a, DecVal(ReadMem(a))); } TotalCycles += 7; PC = 0xA002;
                    return;
                default:
                    throw new InvalidOperationException($"Address not statically recompiled: 0x{PC:X4}");
            }
        }
    }
}
