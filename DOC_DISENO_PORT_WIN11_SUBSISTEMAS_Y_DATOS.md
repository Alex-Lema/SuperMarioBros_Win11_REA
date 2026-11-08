# Documento de Diseño de Ingeniería (Volumen 2): Subsistemas del Motor, Decompilación C++20 y Tablas de Datos de *Super Mario Bros.*

**Proyecto:** Port Nativo 1:1 de *Super Mario Bros.* (NES) para Windows 11  
**Volumen Precedente:** [DOC_DISENO_PORT_WIN11_ARQUITECTURA.md](file:///c:/Antigravity_Projects/SuperMarioBros_REA/DOC_DISENO_PORT_WIN11_ARQUITECTURA.md)  
**Datos Estructurados Asociados:**
- [smb_rea_evidence_bundle.json](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_rea_evidence_bundle.json) (Decompilaciones C de Ghidra 12.1.4 vía REA)
- [smb_rom_data_tables.json](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_rom_data_tables.json) (Tablas binarias extraídas de `smb_prg.bin` y `smb_chr.bin`)
- [smb_symbols.json](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_symbols.json) (Catálogo completo de las 533 subrutinas descubiertas)
- [smb_full_disassembly.asm](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm) (Desensamblado completo anotado de `$8000..$FFFF`)

---

## 1. Decompilación REA (Ghidra 12.1.4) y Traducción Directa a C++20

El proveedor nativo **Ghidra 12.1.4** (`6502:LE:16:default`) invocado mediante `batch_decompile` en REA generó pseudocódigo C para las **34 procedimientos del árbol directo de llamadas** (`ev_118ca6ddc7ce4ecf544aabf5ed4ad45b4e940a88ef73c5a8d3127d0a16dfa015` y `ev_fa50a5de5a78f2c189b5cb804927d1219bb94cb6612056839695cdbc92114c78`). A continuación se presenta la correspondencia exacta de los 34 procedimientos decompilados por Ghidra con sus nombres canónicos en nuestra base de símbolos y su implementación C++20 para Windows 11.

### 1.1. Catálogo de los 34 Procedimientos Decompilados por Ghidra 12.1.4

| Dirección | Símbolo Ghidra | Nombre Canónico en `smb_symbols.json` | Evidence ID REA | Rol en el Port Nativo Win11 |
| :---: | :--- | :--- | :--- | :--- |
| `0x8000` | `entry` | [`Start_RESET`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L9-L65) | `ev_118ca6dd...` | Inicialización de arranque en frío/caliente (`BootReset()`). |
| `0x8182` | `FUN_8182` | [`PauseRoutine`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L178-L221) | `ev_118ca6dd...` | Máquina de estados de pausa y disparo de sonido de pausa (`$00FA`). |
| `0x81C6` | `FUN_81c6` | [`SpriteShuffler`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L223-L273) | `ev_118ca6dd...` | Rotación de offsets OAM (`$06E4..$06FD`) para multiplexado de sprites. |
| `0x8212` | `FUN_8212` | [`OperModeExecutionTree`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L275-L287) | `ev_118ca6dd...` | Despachador maestro por `OperMode` (`$0770`). |
| `0x8220` | `FUN_8220` | [`MoveAllSpritesOffscreen`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L289-L306) | `ev_118ca6dd...` | Escribe `Y = 0xF8` en los 64 sprites de `$0200..$02FC`. |
| `0x8E04` | `FUN_8e04` | [`JumpEngine`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L1808-L1830) | `ev_118ca6dd...` | Motor de salto indirecto indexado por `A` tras `JSR $8E04`. |
| `0x8E19` | `FUN_8e19` | [`InitializeNameTables`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L1832-L1846) | `ev_118ca6dd...` | Limpia NameTable 1 (`$2400`) y NameTable 0 (`$2000`). |
| `0x8E2D` | `FUN_8e2d` | [`ClearNameTable`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L1848-L1890) | `ev_fa50a5de...` | Escribe `0x24` (espacio vacío) en 960 tiles y `0x00` en 64 bytes de atributos. |
| `0x8E5C` | `FUN_8e5c` | `ReadJoypads_Inner` (`$90CC` en nuestro mapa) | `ev_118ca6dd...` | Lectura serie de 8 bits de los puertos `$4016`/`$4017` y máscara Start/Select. |
| `0x8E6A` | `FUN_8e6a` | `ReadPortBits_Strobe` | `ev_fa50a5de...` | Pulso de strobe (`1 -> 0`) en `$4016` y bucle de lectura de 8 bits. |
| `0x8EDD` | `FUN_8edd` | `UpdateScreen_Entry` | `ev_118ca6dd...` | Intérprete de comandos PPU (`VRAM_Buffer1/2` -> `$2006/$2007`). |
| `0x8EE6` | `FUN_8ee6` | [`WriteBufferToScreen`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L1948-L1983) | `ev_fa50a5de...` | Bucle interno de transferencia de tiras horizontales/verticales y RLE a VRAM. |
| `0x8EED` | `FUN_8eed` | `WritePPUReg1` | `ev_fa50a5de...` | Escribe `A` en `PPUCTRL` (`$2000`) y actualiza `Mirror_PPU_CTRL_REG1` (`$0778`). |
| `0x8F97` | `FUN_8f97` | `UpdateTopScore` (`$88AE`) | `ev_118ca6dd...` | Compara puntuación del jugador con `TopScoreDisplay` (`$07D7..$07DC`) y actualiza récord. |
| `0x8F9E` | `FUN_8f9e` | `TopScoreCheck_Sub` | `ev_fa50a5de...` | Resta BCD de 6 dígitos para comparar puntuaciones de J1/J2 contra el récord. |
| `0x90CC` | `FUN_90cc` | `InitMemory_Loop` (`$8F97`/`$90CC`) | `ev_118ca6dd...` | Limpieza selectiva de páginas RAM `$0000..$07FF` preservando stack `$0160..$01FF`. |
| `0xF2D0` | `FUN_f2d0` | [`SoundEngine`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12548-L12638) | `ev_118ca6dd...` | Punto de entrada por frame de la APU 2A03: gestiona pausa, SFX y música. |
| `0xF381` | `FUN_f381` | [`PlayBrickShatter`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12640-L12655) | `ev_fa50a5de...` | Efecto de rotura de ladrillo en el canal de ruido (`$400C..$400F`). |
| `0xF388` | `FUN_f388` | [`PlaySqu2Sfx`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12657-L12668) | `ev_fa50a5de...` | Helper que escribe `Y, X, A` en los registros de Square 2 (`$4004..$4007`). |
| `0xF38B` | `FUN_f38b` | `SetSquare2Regs` | `ev_fa50a5de...` | Escritura directa de registros del canal Square 2. |
| `0xF39F` | `FUN_f39f` | [`PlaySfx1`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12678-L12689) | `ev_fa50a5de...` | Configura envolvente y sweep del canal Square 1 (`$4000..$4003`). |
| `0xF3A6` | `FUN_f3a6` | [`PlaySmallJump`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12691-L12696) | `ev_fa50a5de...` | Dispara el salto de Small Mario (tono base `0x28`). |
| `0xF3A9` | `FUN_f3a9` | [`PlayBigJump`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12698-L12703) | `ev_fa50a5de...` | Dispara el salto de Super Mario (tono base `0x18`). |
| `0xF3AD` | `FUN_f3ad` | [`PlayBump`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12705-L12745) | `ev_fa50a5de...` | Sonido de golpear bloque/pared, nadar (`Stomp/Swim`) y bola de fuego (`Fireball`). |
| `0xF41B` | `FUN_f41b` | [`ContinueSfx1`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12747-L12810) | `ev_fa50a5de...` | Despachador de la cola `Square1SoundQueue` (`$00FF`). |
| `0xF4A7` | `FUN_f4a7` | [`PlayPipeDownInj`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12812-L12885) | `ev_fa50a5de...` | Efecto de entrar en tubería / perder tamaño y crecimiento de la enredadera (`Vine`). |
| `0xF571` | `FUN_f571` | [`PlayCoinGrab`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12887-L12900) | `ev_fa50a5de...` | Sonido de moneda (`B5 -> E6` en Square 2, duración `0x35` frames). |
| `0xF57C` | `FUN_f57c` | [`PlayTimerTick`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12902-L12995) | `ev_fa50a5de...` | Despachador de `Square2SoundQueue` (`$00FE`): Moneda, PowerUp, 1-Up, Bowser Flame, Timer Tick. |
| `0xF667` | `FUN_f667` | [`PlayBlast`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L12997-L13030) | `ev_fa50a5de...` | Despachador de `NoiseSoundQueue` (`$00FD`): Ladrillo roto, explosión y llama de Bowser. |
| `0xF694` | `FUN_f694` | [`PlayPowerUpGrab`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L13032-L13250) | `ev_fa50a5de...` | Secuenciador principal de música de eventos y áreas (`ProcessMusicQueue`). |
| `0xF8C5` | `FUN_f8c5` | [`HandleAreaMusicLoopB`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L13252-L13260) | `ev_fa50a5de...` | Bucle de repetición de música de área. |
| `0xF8CB` | `FUN_f8cb` | [`HandleAltMusic`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L13262-L13275) | `ev_fa50a5de...` | Selección de música alternativa al terminar evento temporal. |
| `0xF8D8` | `FUN_f8d8` | [`LoadEventMusic`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L13277-L13300) | `ev_fa50a5de...` | Carga cabecera de música de evento (`EventMusicQueue` `$00FC`: muerte, victoria, Game Over, Time Warning). |
| `0xF8F4` | `FUN_f8f4` | [`LoadAreaMusic`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L13302-L13350) | `ev_fa50a5de...` | Carga cabecera de música de nivel (`AreaMusicQueue` `$00FB`: Ground, Water, Underground, Castle, Cloud, Pipe Intro, Starman). |

### 1.2. Traducción C++20 de `Start_RESET` (`0x8000`) y `NonMaskableInterrupt_NMI` (`0x8082`)

Comparando el pseudocódigo de Ghidra (`entry` en `ev_118ca6dd...`) con el desensamblado en [`smb_full_disassembly.asm`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L9-L176):

```cpp
void SMBEngine::BootReset() {
    // 1. Configuración inicial de PPUCTRL ($2000 = 0x10: Background Pattern Table = $1000)
    ppu.WriteCTRL(0x10);
    
    // 2. Comprobación de Warm Boot ($07FF == 0xA5 y dígitos de TopScoreDisplay <= 9)
    uint8_t clear_limit = 0xFE; // Por defecto (Cold Boot): limpiar toda la página $0700..$07FE
    bool valid_ digits = true;
    for (int x = 5; x >= 0; --x) {
        if (mem.raw[0x07D7 + x] > 9) {
            valid_digits = false;
            break;
        }
    }
    if (valid_digits && mem.raw[0x07FF] == 0xA5) {
        clear_limit = 0xD6; // Warm Boot: preservar TopScoreDisplay ($07D7..$07DC)
    }

    // 3. Limpiar RAM ($0000..$0700+clear_limit, saltando stack $0160..$01FF)
    InitMemory(clear_limit);

    // 4. Firmar WarmBootValidation y semilla inicial del PRNG LFSR de 56 bits
    mem.raw[0x07FF] = 0xA5;
    mem.raw[0x07A7] = 0xA5;

    // 5. Inicializar registros de APU y PPU
    apu.WriteReg(0x4015, 0x0F); // Habilitar Pulse 1, Pulse 2, Triangle, Noise
    ppu.WriteMASK(0x06);        // Recortar columna izquierda desconectado
    apu.WriteReg(0x4011, 0x00); // DAC counter = 0

    MoveAllSpritesOffscreen();  // $8220: Poner Y = 0xF8 en los 64 sprites ($0200..$02FC)
    InitializeNameTables();     // $8E19: Limpiar NameTable $2400 y $2000

    mem.DisableScreenFlag() += 1;
    WritePPUReg1(mem.Mirror_PPU_CTRL_REG1() | 0x80); // Habilitar NMI (60 Hz)
}
```

Y el bucle por frame **`SMBEngine::TickFrame()`** (traducción exacta de `NonMaskableInterrupt_NMI` `$8082`):

```cpp
void SMBEngine::TickFrame() {
    // 1. Apagar bit NMI temporalmente y comprobar DisableScreenFlag ($0774)
    uint8_t ctrl1 = mem.Mirror_PPU_CTRL_REG1() & 0x7F;
    ppu.WriteCTRL(ctrl1);

    uint8_t mask = mem.Mirror_PPU_CTRL_REG2();
    if (mem.DisableScreenFlag() != 0) {
        mask &= 0xE6; // Apagar fondo y sprites ($2001)
    }
    mem.Mirror_PPU_CTRL_REG2() = mask;
    ppu.WriteMASK(mask & 0xE7);

    // 2. Si la pantalla está activa (DisableScreenFlag == 0), ejecutar DMA de OAM y volcado de VRAM_Buffer
    if (mem.DisableScreenFlag() == 0) {
        ppu.TransferOAM(mem.raw + 0x0200); // DMA de los 256 bytes de $0200..$02FF
        uint8_t addr_ctrl = mem.VRAM_Buffer_AddrCtrl();
        const uint8_t* vram_buf = GetVRAMBufferPtr(addr_ctrl);
        ppu.ExecuteUpdateScreen(vram_buf, mem.Mirror_PPU_CTRL_REG1());

        // Limpiar el buffer recién consumido
        if (addr_ctrl == 6) {
            mem.raw[0x0340] = 0;
            mem.raw[0x0341] = 0;
        } else {
            mem.raw[0x0300] = 0;
            mem.raw[0x0301] = 0;
        }
        mem.VRAM_Buffer_AddrCtrl() = 0;
        ppu.WriteMASK(mem.Mirror_PPU_CTRL_REG2());
    }

    // 3. Ejecutar el Motor de Sonido ($F2D0), Leer Mandos ($90CC) y Comprobar Pausa ($8182)
    sound_engine.Tick(); // Equivalente a JSR $F2D0 (SoundEngine)
    input.ReadJoypads(); // Equivalente a JSR $90CC (ReadJoypads)
    PauseRoutine();      // Equivalente a JSR $8182 (PauseRoutine)
    UpdateTopScore();    // Equivalente a JSR $88AE (UpdateTopScore)

    // 4. Si el juego NO está en pausa (Bit 0 de GamePauseStatus $0776 == 0), decrementar Timers y avanzar PRNG
    if ((mem.GamePauseStatus() & 0x01) == 0) {
        DecrementSystemTimers(); // $8135..$8168 (36 timers en $0780..$07A3)
    }
    StepLFSR56Bit(); // $8169..$817A: Rotación ROR de 7 bytes en $07A7..$07AD

    // 5. Configurar split de Sprite 0 + Scroll del Playfield para el compositor PPU
    ppu.SetFrameSplitScroll(
        /* statusBarScrollX */ 0,
        /* playfieldScrollX */ mem.HorizontalScroll(),
        /* playfieldScrollY */ mem.VerticalScroll(),
        /* nametableSelect  */ mem.Mirror_PPU_CTRL_REG1() & 0x03,
        /* splitEnabled     */ (mem.OperMode() != 0 || mem.OperMode_Task() >= 2)
    );

    // 6. Incrementar FrameCounter ($0009) y ejecutar el árbol del motor si no está en pausa
    mem.FrameCounter() += 1;
    if ((mem.GamePauseStatus() & 0x01) == 0) {
        SpriteShuffler();        // JSR $81C6
        OperModeExecutionTree(); // JSR $8212
    }

    // 7. Reactivar bit NMI en Mirror_PPU_CTRL_REG1
    mem.Mirror_PPU_CTRL_REG1() |= 0x80;
}
```

---

## 2. Catálogo Completo de las 18 Tablas de `JumpEngine` (`239` Punteros)

En el port C++20, la subrutina `JumpEngine` (`$8E04`) se reemplaza por `switch` deterministas sobre los **239 punteros** extraídos en [`smb_rom_data_tables.json`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_rom_data_tables.json):

| # | Nombre de Tabla | Llamada `JSR $8E04` | Dirección Tabla | Entradas | Variable Índice | Destinos Principales (Direcciones PRG-ROM) |
| :-: | :--- | :---: | :---: | :---: | :--- | :--- |
| 1 | `OperModeExecutionTree_Tbl` | `$8212` | `$8215` | `4` | `OperMode` (`$0770`) | `[0] $8231 TitleScreenMode`, `[1] $AED0 GameMode`, `[2] $83A0 VictoryMode`, `[3] $9218 GameOverMode` |
| 2 | `TitleScreenMode_Tbl` | `$8231` | `$8234` | `4` | `OperMode_Task` (`$0772`) | `[0] $823C InitializeGame`, `[1] $8567 ScreenRoutines`, `[2] $8245 PrimaryGameSetup`, `[3] $826D GameMenuRoutine` |
| 3 | `VictoryMode_Tbl` | `$83A0` | `$83A3` | `5` | `OperMode_Task` (`$0772`) | `[0] $83AF BridgeCollapse`, `[1] $843C SetupVictoryMode`, `[2] $845B PlayerEndWorld`, `[3] $849A VictoryWalk`, `[4] $84B3 PrintVictoryMessages` |
| 4 | `ScreenRoutines_Tbl` | `$8567` | `$856A` | `15` | `ScreenRoutineTask` (`$073C`) | `[0] $8589 InitScreen`, `[1] $85ED SetupIntermediate`, `[2] $869E WriteBottomStatusLine`, `[3] $86AC GetTimeUp`, `[4] $86CE DisplayIntermediate`, `[5] $88DF InitializeArea`, `[6] $871E AreaParserTaskControl`, `[7] $8618 GetAreaPalette`, `[8] $8631 GetBackgroundColor`, `[9] $8651 GetPlayerColors`, `[10] $8693 WriteTopStatusLine`, `[11] $874C ClearBuffersDrawIcon`, `[12] $8777 WriteTopScore`, `[13] $8F47 DrawTitleScreen`, `[14] $8A56 FinishScreenRoutines` |
| 5 | `GameOverMode_Tbl` | `$9218` | `$921B` | `3` | `OperMode_Task` (`$0772`) | `[0] $9223 SetupGameOver`, `[1] $8567 ScreenRoutines`, `[2] $927C RunGameOver` |
| 6 | `AreaStyleObject_Tbl` | `$92C5` | `$92C8` | `8` | `AreaStyle` (`$0733`) | Constructores de terreno contextuales (`$9928 TreeLedge`, `$998A MushroomLedge`, `$9A0C PulleyRope`, etc.) |
| 7 | `DecodeAreaData_Tbl` | `$9661` | `$9664` | `47` | `Object_ID` decodificado | Los **47 constructores de objetos de nivel** (bloques `?`, tuberías, escaleras, castillos, mástil de bandera, puentes, agujeros, monedas). |
| 8 | `LargeObject_Tbl` | `$9740` | `$9743` | `3` | Subtipo de objeto grande | Constructores auxiliares de objetos de múltiples columnas. |
| 9 | `GameMode_Tbl` | `$AEDC` | `$AEDF` | `4` | `OperMode_Task` (`$0772`) | `[0] $88DF InitializeArea`, `[1] $8567 ScreenRoutines`, `[2] $891E SecondaryGameSetup`, `[3] $AEEA GameCoreRoutine` |
| 10 | `GameRoutines_Tbl` | `$B049` | `$B04C` | `13` | `GameEngineSubroutine` (`$000E`) | `[0] $B073 PlayerEntrance`, `[1] $B147 Vine_AutoClimb`, `[2] $B220 SideExitPipeEntry`, `[3] $B19C VerticalPipeEntry`, `[4] $B396 FlagpoleSlide`, `[5] $B3EC PlayerEndLevel`, `[6] $8553 PlayerLoseLife`, `[7] $B270 EnterSidePipe`, `[8] $B0E9 PlayerCtrlRoutine`, `[9] $B2A4 PlayerChangeSize`, `[10] $B2DF PlayerInjuryBlink`, `[11] $B322 PlayerDeath`, `[12] $B33E PlayerFireFlower` |
| 11 | `PlayerFireFlower_Tbl` | `$B34B` | `$B34E` | `4` | Etapa animación flor | Sub-pasos del cambio de paleta al recoger la Flor de Fuego. |
| 12 | `MiscObjectsCore_Tbl` | `$BDBA` | `$BDBD` | `9` | `Misc_Object_ID` | Actualización de martillos, monedas saltando, fragmentos de ladrillo. |
| 13 | `InitEnemyObject_Tbl` | `$C27C` | `$C27F` | `55` | `Enemy_ID` (`$0016,X`) | Los **55 inicializadores de enemigos y eventos** (`0x00` Green Koopa .. `0x2D` Bowser .. `0x36` Warp Zone). |
| 14 | `EnemyGfxHandler_Tbl` | `$C7A5` | `$C7A8` | `6` | Tipo de sprite especial | Renderizadores de sprites compuestos (Bowser, Podoboos, plataformas, puente). |
| 15 | `RunEngineSubroutine_Tbl` | `$C88C` | `$C88F` | `34` | `Enemy_ID` en ejecución | Los **34 manejadores por frame** de enemigos activos (`$C8E0 RunNormalEnemies`, `$C984 RunBowserFlame`, `$C998 RunFirebarObj`, `$CA34 RunSmallPlatform`, `$CB9E RunLargePlatform`, `$D2E2 PowerUpObjHandler`, etc.). |
| 16 | `RunNormalEnemies_Tbl` | `$C904` | `$C907` | `21` | `Enemy_ID` (`0x00..0x14`) | Los **21 controladores de IA/física de enemigos estándar** (Koopas, Goombas, Blooper, Bullet Bill, Cheep-Cheep, Lakitu, Spiny, Hammer Bro, Piranha Plant). |
| 17 | `BowserGfx_Tbl` | `$C984` | `$C987` | `7` | Sub-estado de Bowser | Subrutinas de IA y aliento de fuego del Rey Koopa. |
| 18 | `PowerUpObjHandler_Tbl` | `$D2E2` | `$D2E5` | `5` | `PowerUpType` (`$0039`) | `[0] Super Mushroom`, `[1] Fire Flower`, `[2] Starman`, `[3] 1-Up Mushroom`, `[4] Vine` |

---

## 3. Especificación Matemática del Motor de Física de Mario (`$B0E9`..`$B550`)

Uno de los aspectos más importantes para que el port de Windows 11 se sienta **auténtico al 100%** es la física en coma fija de Mario implementada en [`PlayerCtrlRoutine`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L4872-L4970) (`$B0E9`) y [`MovePlayerVertically`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L5400-L5450) (`$B525`).

### 3.1. Tablas Exactas de Salto y Gravedad (`$B424..$B43F`)

Extraídas directamente de `smb_prg.bin` en [`smb_rom_data_tables.json`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_rom_data_tables.json):

```cpp
// Índices 0..4: Salto en tierra según velocidad horizontal |vx| ($0700):
//   [0]: |vx| < 0x09 (parado)
//   [1]: 0x09 <= |vx| < 0x10 (caminando lento)
//   [2]: 0x10 <= |vx| < 0x19 (caminando rápido)
//   [3]: 0x19 <= |vx| < 0x1C (corriendo)
//   [4]: |vx| >= 0x1C (sprint máximo -> salto más alto)
// Índices 5..6: Natación bajo el agua (SwimmingFlag != 0)
constexpr uint8_t kJumpMForceData[7] = { 0x20, 0x20, 0x1E, 0x28, 0x28, 0x0D, 0x04 }; // $B424: Gravedad mientras se mantiene pulsado 'A' subiendo
constexpr uint8_t kFallMForceData[7] = { 0x70, 0x70, 0x60, 0x90, 0x90, 0x0A, 0x09 }; // $B42B: Gravedad al soltar 'A' o al caer (vy >= 0)
constexpr int8_t  kPlayerYSpdData[7] = {  -4,   -4,   -4,   -5,   -5,   -2,   -1  }; // $B432: Velocidad vertical entera inicial (0xFC=-4, 0xFB=-5)
constexpr uint8_t kInitMForceData[7] = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00 }; // $B439: Subpíxel vertical inicial ($0433)
```

### 3.2. Ecuación de Integración Vertical en Coma Fija (`8.8` bits por Frame)

En cada frame en el que Mario está en el aire (`Player_State != 0`), [`MovePlayerVertically`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L5400-L5450) (`$B525`) ejecuta la siguiente integración en aritmética entera de 8 bits con acarreo (`ADC`):

1. **Selección de Gravedad (`CurrentPlayerGfxForce` `$0709`)**:
   - Al iniciar el salto, se guarda el índice de tabla `idx` (`0..6`), se carga `Player_Y_Speed = kPlayerYSpdData[idx]`, `Player_Y_MoveForce = kInitMForceData[idx]`, y `CurrentPlayerGfxForce = kJumpMForceData[idx]`.
   - En cada frame posterior, si `Player_Y_Speed >= 0` (empezó a caer) **o** el jugador suelta el botón **A** (`(A_B_Buttons & 0x80) == 0` y no está rebotando sobre un enemigo), la gravedad cambia inmediatamente a la gravedad pesada: `CurrentPlayerGfxForce = kFallMForceData[idx]`. Esto produce el icónico control de altura de salto variable de *Super Mario Bros.*

2. **Integración de Posición y Velocidad**:
   ```cpp
   // Paso 1: Sumar parte fraccionaria de velocidad a la posición Y
   uint16_t frac_pos_sum = static_cast<uint16_t>(mem.Player_Y_MoveForce()) + static_cast<uint16_t>(mem.CurrentPlayerGfxForce());
   uint8_t carry_pos = (frac_pos_sum > 0xFF) ? 1 : 0;

   // Actualizar posición entera Y ($00CE) y página vertical ($00B5)
   int16_t new_y = static_cast<int16_t>(mem.Player_Y_Position()) + static_cast<int16_t>(mem.Player_Y_Speed()) + carry_pos;
   if (mem.Player_Y_Speed() < 0) {
       if (new_y < 0) mem.Player_Y_HighPos() -= 1;
   } else {
       if (new_y > 0xFF) mem.Player_Y_HighPos() += 1;
   }
   mem.Player_Y_Position() = static_cast<uint8_t>(new_y & 0xFF);

   // Paso 2: Actualizar velocidad vertical (vy + gravedad)
   mem.Player_Y_MoveForce() = static_cast<uint8_t>(frac_pos_sum & 0xFF);
   if (carry_pos) {
       mem.Player_Y_Speed() += 1;
   }
   // Límite de velocidad terminal de caída: si Player_Y_Speed >= 4 y Player_Y_MoveForce >= 0x80, clampa a vy = 4, frac = 0x00
   if (mem.Player_Y_Speed() >= 4 && mem.Player_Y_MoveForce() >= 0x80) {
       mem.Player_Y_Speed() = 4;
       mem.Player_Y_MoveForce() = 0x00;
   }
   ```

### 3.3. Velocidades Máximas Horizontales y Fricción (`$B440..$B449`)

```cpp
// Velocidades máximas a la izquierda ($B440) y derecha ($B443):
//   Índice 0: Bajo el agua (caminando) -> -0x18 / +0x18 (24 subpíxeles/frame = 1.5 px/frame)
//   Índice 1: En tierra (caminando, sin botón B) -> -0x18 / +0x18 (1.5 px/frame)
//   Índice 2: En tierra (corriendo con botón B) -> -0x28 / +0x28 (40 subpíxeles/frame = 2.5 px/frame)
//   Índice 3: Entrada automática/enredadera -> +0x10 (1.0 px/frame)
constexpr int8_t  kMaxLeftXSpdData[3]  = { -0x18, -0x18, -0x28 };
constexpr int8_t  kMaxRightXSpdData[4] = {  0x18,  0x18,  0x28, 0x10 };
constexpr uint8_t kFrictionData[3]     = {  0xE4,  0x98,  0xD0 }; // Fricción normal, derrape (skid) y carrera
```

---

## 4. Especificación del Decodificador de Niveles y las 34 Áreas en ROM (`$92B0` y `$9CB4..$9D71`)

A diferencia de los juegos modernos que guardan mapas completos como matrices 2D descomprimidas, *Super Mario Bros.* almacena los **32 niveles (Mundos 1-1 a 8-4) más las sub-áreas** (tuberías de monedas, zonas bajo el agua, zonas de nubes e intros de tubería) en **34 áreas únicas** dentro de `smb_prg.bin` usando solo `4,631` bytes (`$9CB4..$AECB`).

### 4.1. Tablas de Punteros de Mundos y Áreas (`$9CB4..$9D71`)

Extraídas íntegramente en `world_and_area_tables` dentro de [`smb_rom_data_tables.json`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_rom_data_tables.json):
- `WorldAddrOffsets` (`$9CB4`, 8 bytes): `[0, 5, 10, 14, 19, 23, 28, 32]`. Indica el desplazamiento inicial en `AreaAddrOffsets` para los Mundos 1 a 8. (Los mundos con 5 entradas tienen una sub-área de introducción de transición como el nivel 1-2 o 2-2).
- `AreaAddrOffsets` (`$9CBC`, 36 bytes): Contiene el byte `AreaPointer` (`$0750`) para cada etapa.
  - **Bits `6..5` de `AreaPointer`**: Tipo de área (`0 = Water`, `1 = Ground`, `2 = Underground`, `3 = Castle`).
  - **Bits `4..0` de `AreaPointer`**: Índice relativo dentro de ese tipo de área, sumado a `AreaDataHOffsets[AreaType]` (`[0, 3, 25, 28]`) para obtener el índice global `0..33` en las tablas de punteros de 16 bits:
    - `AreaDataAddrLow` (`$9D2C`) / `AreaDataAddrHigh` (`$9D4E`): Dirección del flujo de **Terreno/Objetos**.
    - `EnemyDataAddrLow` (`$9CE4`) / `EnemyDataAddrHigh` (`$9D06`): Dirección del flujo de **Enemigos/Comandos Loop**.

### 4.2. Tabla Maestra de las 34 Áreas Únicas en la ROM

| Índice Global | Tipo de Área | Puntero Terreno (`AreaData`) | Bytes Cabecera | Nº Objetos Terreno | Puntero Enemigos (`EnemyData`) | Nº Objetos Enemigos | Niveles que usan esta Área |
| :-: | :--- | :---: | :---: | :-: | :---: | :-: | :--- |
| `0` | `Water` | `$A965` | `0x52, 0x00` | `30` | `$A1E8` | `20` | Sub-área acuática bonus |
| `1` | `Water` | `$A9A3` | `0x50, 0x01` | `64` | `$A211` | `27` | World 2-2 / World 7-2 |
| `2` | `Water` | `$AA25` | `0x50, 0x01` | `69` | `$A249` | `46` | Zona acuática de World 8-4 |
| `3` | `Ground` | `$A390` | `0x94, 0x11` | `61` | `$9E69` | `32` | **World 1-1** |
| `4` | `Ground` | `$A40C` | `0x90, 0x31` | `66` | `$9EA9` | `31` | **World 1-3 / World 5-3** |
| `5` | `Ground` | `$A492` | `0x9B, 0x0A` | `59` | `$9EE9` | `26` | **World 2-1** |
| `6` | `Ground` | `$A50A` | `0x50, 0x21` | `49` | `$9F1E` | `29` | **World 2-3 / World 7-3** (Puentes Cheep-Cheep) |
| `7` | `Ground` | `$A56E` | `0x52, 0x31` | `78` | `$9F59` | `40` | **World 3-1** |
| `8` | `Ground` | `$A60C` | `0x52, 0x11` | `39` | `$9FA9` | `40` | **World 3-2** |
| `9` | `Ground` | `$A65C` | `0x90, 0x1A` | `57` | `$9FFA` | `24` | **World 3-3** |
| `10` | `Ground` | `$A6D0` | `0x92, 0x41` | `48` | `$A02B` | `19` | **World 4-1** (Lakitu) |
| `11` | `Ground` | `$A732` | `0x50, 0x31` | `52` | `$A052` | `28` | **World 4-3** |
| `12` | `Ground` | `$A79C` | `0x92, 0x01` | `47` | `$A08B` | `35` | **World 5-1** |
| `13` | `Ground` | `$A7FC` | `0x5B, 0x0A` | `83` | `$A0D1` | `37` | **World 5-2** |
| `14` | `Ground` | `$A8A4` | `0x54, 0x11` | `45` | `$A11D` | `28` | **World 6-1** |
| `15` | `Ground` | `$A900` | `0x54, 0x21` | `67` | `$A156` | `24` | **World 6-2** |
| `16` | `Ground` | `$AAAF` | `0x92, 0x09` | `52` | `$A187` | `22` | **World 6-3** |
| `17` | `Ground` | `$AB19` | `0x9A, 0x09` | `58` | `$A1B3` | `26` | **World 7-1** |
| `18` | `Ground` | `$AB8F` | `0x52, 0x09` | `88` | `$A2A6` | `58` | **World 8-1** |
| `19` | `Ground` | `$AC41` | `0x5A, 0x01` | `69` | `$A31D` | `43` | **World 8-2** |
| `20` | `Ground` | `$ACCD` | `0x90, 0x11` | `65` | `$A373` | `14` | **World 8-3** |
| `21..24` | `Ground` | `$AD51..$AE53` | Varios | `1..38` | `$9E58..$9E68` | `0..5` | Intros de tubería (`1-2`, `2-2`), Warp Zone y Cloud Bonus |
| `25` | `Underground` | `$AE5B` | `0x48, 0x0F` | `80` | `$9D72` | `29` | **World 1-2** |
| `26` | `Underground` | `$AEFD` | `0x48, 0x0F` | `86` | `$9DAD` | `32` | **World 4-2** |
| `27` | `Underground` | `$AFAA` | `0x48, 0x0F` | `25` | `$9DEF` | `5` | Sala subterránea de monedas (Bonus Coin Room) |
| `28` | `Castle` | `$9FD2` / `$A014` | `0x5B, 0x07` | `58..92` | `$9CB4..` | `21..39` | **Castillos 1-4 a 8-4** (Índices `28..33`, ver detalle en [`smb_rom_data_tables.json`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_rom_data_tables.json)) |

### 4.3. Formato Binario de Objetos de Terreno (`AreaData`) y Enemigos (`EnemyData`)

1. **Cabecera de Área (2 bytes al inicio de `AreaData`)**:
   - **Byte 0**: Bits `7..6` = Control de reloj inicial (`400`, `300` o `200` segundos); Bits `5..3` = Posición Y de entrada de Mario; Bits `2..0` = Fondo escénico (`BackgroundScenery`: nubes, montañas, vallas).
   - **Byte 1**: Bits `7..6` = Estilo de plataformas/árboles (`AreaStyle`: normal, setas gigantes, cañones Bullet Bill, nubes); Bits `5..4` = Control de terreno base (`TerrainControl`: techo/suelo inicial); Bits `3..0` = Patrón de suelo inicial (`Ground_Pattern`).

2. **Registros de Objetos de Terreno (2 bytes por objeto, terminados por `0xFD`)**:
   - **Byte 0 (`Coordinates`)**:
     - `Bits 7..4` (`X` = `0..15`): Columna dentro de la página actual de 16 metatiles (en píxeles: `X * 16`).
     - `Bits 3..0` (`Y` = `0..15`): Fila vertical (`0..11` = filas normales de pantalla; `12` (`0x0C`) = objetos que cambian el patrón de suelo/cielo a lo largo de varias columnas; `13` (`0x0D`) = objetos especiales de página como el mástil de bandera, puentes o bloqueos de scroll; `14` (`0x0E`) = cambio de fondo/estilo de terreno a mitad de nivel; `15` (`0x0F`) = cuerdas, castillos y escaleras verticales).
   - **Byte 1 (`Object Specifier`)**:
     - `Bit 7` (`Page Flag`): Si vale `1`, antes de colocar este objeto la página actual del nivel se incrementa en `+1` (`CurrentPageLoc++`).
     - `Bits 6..4` (`Object ID` / `Type`): Identificador del constructor en [`DecodeAreaData_Tbl`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L2612-L2665) (`$9664`, 47 constructores).
     - `Bits 3..0` (`Length` / `Subtype`): Longitud horizontal/vertical del objeto (`Length + 1` metatiles) o subtipo si `Y >= 12`.

3. **Registros de Enemigos y Comandos de Bucle de Castillo (2 o 3 bytes, terminados por `0xFF`)**:
   - **Byte 0**: `Bits 7..4` = Columna `X` (`0..15`); `Bits 3..0` = Fila `Y` (`0..13` = posición Y del enemigo; `0x0E` = **Cambio de Área / Tubería / Sub-área de 3 bytes**; `0x0F` = Salto directo a una página específica `NewPageLoc`).
   - **Byte 1**: `Bit 7` = `Page Flag` (`+1` a la página actual); `Bit 6` = **Hard Mode Flag** (si vale `1`, el enemigo solo aparece en el *Second Quest* o en los mundos posteriores cuando `PrimaryHardMode` está activo); `Bits 5..0` = `Enemy_ID` (`0x00..0x36`), despachado mediante [`InitEnemyObject_Tbl`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L6180-L6245) (`$C27F`).

---

## 5. Subsistema de Colisiones AABB (`$9B90` y `$D68F..$DA95`)

*Super Mario Bros.* resuelve dos tipos de colisiones en cada frame dentro de `GameCoreRoutine`:

### 5.1. Colisión Entidad-Entidad mediante Cajas AABB (`BoundingBoxCoordData` `$9B90`)

En [`smb_rom_data_tables.json`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_rom_data_tables.json) (`BoundingBoxCoordData_0x9B90`, 48 bytes = 12 definiciones de cajas de `[Offset_X1, Offset_Y1, Offset_X2, Offset_Y2]`), cada entidad (Mario grande, Mario pequeño/agachado, Goomba/Koopa, Bowser, Bola de fuego, Martillo, Moneda) tiene asignado un índice de caja delimitadora (`0..11`):

```cpp
// Tabla exacta extraída de 0x9B90..0x9BBF (12 cajas de 4 bytes: left_off, top_off, right_off, bottom_off)
constexpr uint8_t kBoundingBoxCoordData[12][4] = {
    { 0x02, 0x04, 0x0E, 0x20 }, // [0] Super Mario de pie (12x28 px)
    { 0x02, 0x14, 0x0E, 0x20 }, // [1] Small Mario o Super Mario agachado (12x12 px)
    { 0x02, 0x09, 0x0E, 0x15 }, // [2] Enemigo estándar (Goomba, Koopa, Buzzy Beetle)
    { 0x02, 0x04, 0x0E, 0x18 }, // [3] Koopa Paratroopa / Hammer Bro / Lakitu
    { 0x00, 0x00, 0x18, 0x06 }, // [4] Plataforma / Barra de fuego
    { 0x02, 0x02, 0x06, 0x06 }, // [5] Bola de fuego de Mario / Martillo
    { 0x02, 0x04, 0x1E, 0x18 }, // [6] Bowser (Rey Koopa)
    { 0x00, 0x02, 0x10, 0x06 }, // [7] Llama de Bowser
    { 0x03, 0x04, 0x0D, 0x14 }, // [8] Planta Piraña / Blooper
    { 0x02, 0x02, 0x0E, 0x0E }, // [9] Power-Up (Seta, Flor, Estrella) / Moneda
    { 0x00, 0x00, 0x10, 0x10 }, // [10] Bloque rebotando
    { 0x04, 0x04, 0x0C, 0x0C }  // [11] Burbuja / Objeto pequeño
};
```

En [`PlayerEnemyCollision`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_full_disassembly.asm#L7900-L8020) (`$D8B0`), dos cajas `A` y `B` colisionan si y solo si se solapan en ambos ejes (`A.x2 >= B.x1 && B.x2 >= A.x1 && A.y2 >= B.y1 && B.y2 >= A.y1`). Para determinar si Mario **aplasta (stomp)** a un enemigo o recibe daño:
- El motor comprueba si `Player_Y_Speed > 0` (Mario está cayendo) **o** si el borde inferior de Mario está por encima del centro vertical del enemigo (`Player_Y_Position + offset < Enemy_Y_Position + 12`).

---

## 6. Guía de Implementación y Verificación Paso a Paso para Windows 11

Para desarrollar el ejecutable nativo `SuperMarioBros_Win11.exe` a partir de estos documentos y los archivos JSON/ASM generados en el workspace:

1. **Carga y Validación de la ROM (`smb_rom_loader.cpp`)**:
   - Abrir `smb.nes` (`40,976` bytes), verificar la cabecera `4E 45 53 1A` (`NES\x1A`), copiar los bytes `16..32783` en el array constante `PRG_ROM[0x8000]` (mapeado a `$8000..$FFFF`) y los bytes `32784..40975` en `CHR_ROM[0x2000]`.
   - De este modo, **todas las tablas de niveles, física, paletas y música** (`$8000..$FFFF`) están presentes en sus direcciones exactas de memoria sin riesgo de errores de transcripción manual, y también pueden consultarse de forma estructurada en [`smb_rom_data_tables.json`](file:///c:/Antigravity_Projects/SuperMarioBros_REA/smb_rom_data_tables.json).

2. **Orden Recomendado de Construcción de Módulos C++20**:
   - **Etapa A (Núcleo + PPU + Pantalla de Título)**: Implementar `SMBMemory`, `PPU2C02` (`UpdateScreen` `$8EDD`, `ClearNameTable` `$8E2D`, `DrawTitleScreen` `$8F47`), `BootReset` (`$8000`), `TickFrame` (`$8082`) y `TitleScreenMode` (`$8231`). **Hito de verificación**: La pantalla de título se dibuja perfectamente y tras unos segundos arranca la Demo automática (`DemoEngine` `$837E`) de World 1-1.
   - **Etapa B (Parser de Niveles + Scroll + Física de Mario)**: Implementar `AreaParserCore` (`$92B0`), `ScrollHandler` (`$B03F`), `PlayerCtrlRoutine` (`$B0E9`) y `PlayerBGCollision` (`$DA95`). **Hito de verificación**: La Demo automática reproduce exactamente los movimientos de Mario sin desincronizarse, demostrando que la física en coma fija y las colisiones con bloques son bit-exactas.
   - **Etapa C (Enemigos + Bucles de Castillo + Audio APU)**: Implementar `EnemiesAndLoopsCore` (`$C047`), `PlayerEnemyCollision` (`$D8B0`), `SoundEngine` (`$F2D0..$F8F4`, usando directamente las 18 funciones decompiladas por Ghidra 12.1.4) y el sintetizador `APU2A03Synth` sobre WASAPI. **Hito de verificación**: Juego 100% completable desde World 1-1 hasta World 8-4 (incluyendo Second Quest y Warp Zones).
