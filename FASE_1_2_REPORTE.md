# Super Mario Bros. (NES) — Reporte de Fases 1 y 2

## 1. Estado del Proveedor Ghidra en REA (`binary_session` / `open_binary`)

Al consultar `binary_session` tras configurar `GHIDRA_INSTALL_DIR = C:\ghidra_12.2_PUBLIC` y el JDK de Microsoft, **7 de las 8 comprobaciones de REA pasan con éxito**:

| Check | Estado | Detalle reportado por REA |
| :--- | :---: | :--- |
| `configuration` | ✅ `ok` | `C:\ghidra_12.2_PUBLIC` |
| `platform` | ✅ `ok` | `win32` |
| `architecture` | ✅ `ok` | `x64` |
| `installation` | ✅ `ok` | `C:\ghidra_12.2_PUBLIC\Ghidra\application.properties` |
| `headless` | ✅ `ok` | `C:\ghidra_12.2_PUBLIC\support\analyzeHeadless.bat` |
| `native_decompiler` | ✅ `ok` | `C:\ghidra_12.2_PUBLIC\Ghidra\Features\Decompiler\os\win_x86_64\decompile.exe` (`pe x86_64`) |
| `java` | ✅ `ok` | `25.0.5.0.2; 64-bit; JDK; C:\Program Files\Microsoft\jdk-25.0.5.21-hotspot` |
| `version` | ❌ `unsupported_version` | `12.2; accepted releases are 12.1.x (verified build 12.1.4)` |

> **Nota sobre versión de Ghidra en REA 6.8.0**: El adaptador de REA `6.8.0` valida estrictamente que la instalación pertenezca a la línea **Ghidra `12.1.x`** (verificada con `12.1.4`) y rechaza `12.2` con el código `unsupported_version`. Para habilitar las herramientas de puente profundo de Ghidra (`inspect_native_load_image`, `analyze_function`, `procedure_pseudo_code`), basta con extraer **Ghidra 12.1.4** (por ejemplo en `C:\ghidra_12.1.4_PUBLIC`) y apuntar `GHIDRA_INSTALL_DIR` a esa carpeta.

---

## 2. Fase 1: Imagen de Carga y Mapeo de Memoria (`0x8000..0xFFFF`)

### Evidencias REA (Autoridad: `shipped-artifact`)
- **ROM completa (`smb.nes`)**:
  - **SHA-256**: `f61548fdf1670cffefcc4f0b7bdcdd9eaba0c226e3b74f8666071496988248de` (`40,976` bytes).
  - **Evidencia REA (`inspect_byte_entropy`)**: `ev_84c09a8e7715c781954d4c763fedeeca6b13e99b70ebeae34167f2baeaab81b2` (padre: `ev_34483f57b838fefce3fc2c596a4e08167800bcdf706253b153799d05e25116f8`).
- **Imagen de código CPU extraída (`smb_prg.bin`)**:
  - **SHA-256**: `5374abb64cfb9b5d961856c60166cedc55859164cf2b8867730e144fa2bdd594` (`32,768` bytes / `0x8000` bytes).
  - **Evidencia REA (`inspect_byte_entropy`)**: `ev_c9ead377adfe31fbc1a5c8ce1ca793e4f70b8988be9a8a9ea3fa759290fe4d29` (padre: `ev_71576264dd7061aca6572c4511819b673107ce777b4809ac7ce773c6be047e61`).
  - **Admisión `open_binary` en REA**: `format: "raw-binary"`, `kind: "executable"`, `architecture: "6502"`, `entry_point: "0x8000"`.

### Mapa de Segmentos de Memoria (NROM-256 / Mapper 0)

| Rango CPU | Offset en `smb_prg.bin` | Offset en `smb.nes` | Descripción |
| :--- | :--- | :--- | :--- |
| `0x0000..0x00FF` | *(RAM no mapeada en ROM)* | — | **Zero-Page RAM**: punteros indirectos (`$00..$07`), variables rápidas y estado por frame. |
| `0x0100..0x01FF` | *(RAM no mapeada en ROM)* | — | **Hardware Stack** (`$0160..$01FF`) + **Vertical Scroll / Flag Buffer** (`$0100..$015F`). |
| `0x0200..0x02FF` | *(RAM no mapeada en ROM)* | — | **Shadow OAM Buffer**: 64 sprites de 4 bytes enviados por DMA (`$4014`) en cada NMI. |
| `0x0300..0x03FF` | *(RAM no mapeada en ROM)* | — | **VRAM Buffer 1** (`$0300..$0362`) y datos de bloques/relación. |
| `0x0400..0x07FF` | *(RAM no mapeada en ROM)* | — | **Game State RAM**: física, objetos, temporizadores (`$0780..$07A3`), modo de juego (`$0770`). |
| `0x2000..0x2007` | *(MMIO PPU)* | — | Registros del Picture Processing Unit (`PPUCTRL`, `PPUMASK`, `PPUSTATUS`, `OAMADDR`, `PPUSCROLL`, `PPUADDR`, `PPUDATA`). |
| `0x4000..0x4017` | *(MMIO APU / I/O)* | — | Registros de audio APU, DMA de OAM (`$4014`) y lectura de mandos (`$4016`/`$4017`). |
| `0x8000..0xFFFF` | `0x0000..0x7FFF` | `0x0010..0x800F` | **PRG-ROM (32 KB)**: Código 6502, tablas de datos y vectores hardware (`0xFFFA..0xFFFF`). |

---

## 3. Fase 2: Recuperación de Puntos de Entrada Hardware (`RESET` y `NMI`)

*(Desensamblado estático directo sobre `smb_prg.bin`, verificando byte a byte las instrucciones NMOS 6502).*

### 3.1. Rutina `RESET` (`0x8000..0x8059`, file offset `+0x0000..+0x0059`)

```assembly
; =============================================================================
; RESET (0x8000) — Arranque en frío / caliente de Super Mario Bros.
; =============================================================================
0x8000  78        SEI             ; Deshabilitar interrupciones IRQ
0x8001  D8        CLD             ; Deshabilitar modo decimal BCD
0x8002  A9 10     LDA #$10        ; Bit 4 = tabla de patrones de fondo en PPU $1000, NMI desactivado
0x8004  8D 00 20  STA $2000       ; PPUCTRL ($2000)
0x8007  A2 FF     LDX #$FF
0x8009  9A        TXS             ; Inicializar puntero de pila SP = $01FF

; Esperar 2 VBlanks para estabilizar la PPU tras encendido
0x800A  AD 02 20  LDA $2002       ; Leer PPUSTATUS ($2002)
0x800D  10 FB     BPL $800A       ; Esperar VBlank #1 (bit 7 = 1)
0x800F  AD 02 20  LDA $2002       ; Leer PPUSTATUS ($2002)
0x8012  10 FB     BPL $800F       ; Esperar VBlank #2 (bit 7 = 1)

; Comprobación de arranque en frío vs. arranque en caliente (Warm Boot)
0x8014  A0 FE     LDY #$FE        ; Por defecto: limpiar RAM hasta $07FE (Cold Boot)
0x8016  A2 05     LDX #$05        ; Verificar los 6 dígitos del Top Score en $07D7..$07DC
0x8018  BD D7 07  LDA $07D7,X
0x801B  C9 0A     CMP #$0A        ; ¿Algún dígito >= 10 (no decimal válido)?
0x801D  B0 0C     BCS $802B       ; Si es inválido -> Cold Boot (Y = $FE)
0x801F  CA        DEX
0x8020  10 F6     BPL $8018
0x8022  AD FF 07  LDA $07FF       ; Comprobar firma de Warm Boot en $07FF
0x8025  C9 A5     CMP #$A5        ; ¿$07FF == $A5?
0x8027  D0 02     BNE $802B       ; Si no coincide -> Cold Boot (Y = $FE)
0x8029  A0 D6     LDY #$D6        ; Warm Boot: limpiar solo hasta $07D6 (preserva Top Score)

0x802B  20 CC 90  JSR $90CC       ; InitializeMemory: pone a $00 desde ($0700+Y) hacia abajo hasta $0000 (excepto pila $0160..$01FF)
0x802E  8D 11 40  STA $4011       ; A=0 tras InitializeMemory -> silenciar canal DMC ($4011)
0x8031  8D 70 07  STA $0770       ; OperMode ($0770) = 0 (TitleScreenMode)
0x8034  A9 A5     LDA #$A5
0x8036  8D FF 07  STA $07FF       ; Escribir firma de Warm Boot ($A5) en $07FF
0x8039  8D A7 07  STA $07A7       ; Semilla inicial del generador pseudoaleatorio LFSR ($07A7 = $A5)
0x803C  A9 0F     LDA #$0F
0x803E  8D 15 40  STA $4015       ; Habilitar canales de audio APU (Pulse 1/2, Triangle, Noise)
0x8041  A9 06     LDA #$06
0x8043  8D 01 20  STA $2001       ; PPUMASK ($2001): mostrar borde izquierdo, ocultar fondo/sprites
0x8046  20 20 82  JSR $8220       ; MoveAllSpritesOffscreen: escribe Y=$F8 en todos los sprites ($0200..$02FC)
0x8049  20 19 8E  JSR $8E19       ; InitializeNameTables: limpia ambos nametables VRAM ($2000 y $2400)
0x804C  EE 74 07  INC $0774       ; DisableScreenFlag ($0774) = 1
0x804F  AD 78 07  LDA $0778       ; Leer Mirror_PPUCTRL ($0778)
0x8052  09 80     ORA #$80        ; Activar bit 7 (habilitar interrupción NMI en VBlank)
0x8054  20 ED 8E  JSR $8EED       ; WritePPUReg1: escribe en $2000 y guarda copia en $0778
0x8057  4C 57 80  JMP $8057       ; Bucle infinito: todo el juego corre dentro de la interrupción NMI
```

---

### 3.2. Rutina `NMI` (`0x8082..0x8181`, file offset `+0x0082..+0x0181`)

La interrupción no enmascarable (`NMI`) se dispara a **60 Hz** durante el intervalo de borrado vertical (VBlank) y contiene la totalidad del bucle principal de **Super Mario Bros.**:

```assembly
; =============================================================================
; NMI (0x8082) — Manejador de VBlank y Bucle Principal de Fotograma (60 Hz)
; =============================================================================
; 1. Desactivar NMI temporalmente y configurar PPUMASK según DisableScreenFlag ($0774)
0x8082  AD 78 07  LDA $0778       ; Mirror_PPUCTRL
0x8085  29 7F     AND #$7F        ; Limpiar bit 7 (NMI enable)
0x8087  8D 78 07  STA $0778
0x808A  29 7E     AND #$7E        ; Limpiar bit 0 (nametable base X)
0x808C  8D 00 20  STA $2000       ; PPUCTRL ($2000)
0x808F  AD 79 07  LDA $0779       ; Mirror_PPUMASK
0x8092  29 E6     AND #$E6
0x8094  AC 74 07  LDY $0774       ; DisableScreenFlag
0x8097  D0 05     BNE $809E       ; Si pantalla deshabilitada, mantener fondo/sprites apagados
0x8099  AD 79 07  LDA $0779
0x809C  09 1E     ORA #$1E        ; Habilitar renderizado de fondo y sprites
0x809E  8D 79 07  STA $0779
0x80A1  29 E7     AND #$E7        ; Desactivar renderizado durante las transferencias VRAM/OAM
0x80A3  8D 01 20  STA $2001       ; PPUMASK ($2001)
0x80A6  AE 02 20  LDX $2002       ; Leer PPUSTATUS para reiniciar el latch de direcciones PPU
0x80A9  A9 00     LDA #$00
0x80AB  20 E6 8E  JSR $8EE6       ; Resetear PPUSCROLL ($2005) y PPUADDR ($2006) a 0

; 2. Transferencia DMA de OAM (Sprites) y volcado del Buffer VRAM activo
0x80AE  8D 03 20  STA $2003       ; OAMADDR = $00
0x80B1  A9 02     LDA #$02
0x80B3  8D 14 40  STA $4014       ; OAMDMA: copiar $0200..$02FF a la OAM de la PPU
0x80B6  AE 73 07  LDX $0773       ; VRAM_Buffer_AddrCtrl ($0773): índice de tabla de punteros VRAM
0x80B9  BD 5A 80  LDA $805A,X     ; Byte bajo del puntero en tabla $805A
0x80BC  85 00     STA $00
0x80BE  BD 6D 80  LDA $806D,X     ; Byte alto del puntero en tabla $806D
0x80C1  85 01     STA $01
0x80C3  20 DD 8E  JSR $8EDD       ; UpdateScreen: vuelca los comandos del buffer ($00) a PPUDATA ($2007)
0x80C6  A0 00     LDY #$00
0x80C8  AE 73 07  LDX $0773
0x80CB  E0 06     CPX #$06        ; ¿Se usó el buffer secundario ($0341, índice 6)?
0x80CD  D0 01     BNE $80D0
0x80CF  C8        INY             ; Y = 1 (seleccionar offset $40 en tabla $8080)
0x80D0  BE 80 80  LDX $8080,Y     ; Offset de inicio del buffer ($00 o $40)
0x80D3  A9 00     LDA #$00
0x80D5  9D 00 03  STA $0300,X     ; Limpiar cabecera del buffer VRAM tras volcarlo
0x80D8  9D 01 03  STA $0301,X
0x80DB  8D 73 07  STA $0773       ; Resetear VRAM_Buffer_AddrCtrl = 0
0x80DE  AD 79 07  LDA $0779
0x80E1  8D 01 20  STA $2001       ; Restaurar PPUMASK (reactivar renderizado si procede)

; 3. Sonido, lectura de mandos y gestión de pausa
0x80E4  20 D0 F2  JSR $F2D0       ; SoundEngine: procesa efectos de sonido y música APU
0x80E7  20 5C 8E  JSR $8E5C       ; ReadJoypads: lee mandos ($4016/$4017) y guarda en $06FC/$06FD
0x80EA  20 82 81  JSR $8182       ; PauseRoutine: detecta botón START y alterna GamePauseStatus ($0776)
0x80ED  20 97 8F  JSR $8F97       ; UpdateTopScore: actualiza el récord si la puntuación de Mario lo supera

; 4. Decremento de temporizadores del juego (si no está en pausa)
0x80F0  AD 76 07  LDA $0776       ; GamePauseStatus
0x80F3  4A        LSR A           ; Bit 0 -> Carry (¿juego pausado?)
0x80F4  B0 25     BCS $811B       ; Si está en pausa, saltar actualización de temporizadores
0x80F6  AD 47 07  LDA $0747       ; TimerControl ($0747)
0x80F9  F0 05     BEQ $8100
0x80FB  CE 47 07  DEC $0747
0x80FE  D0 19     BNE $8119
0x8100  A2 14     LDX #$14        ; Por defecto: actualizar solo temporizadores rápidos ($0780..$0794)
0x8102  CE 7F 07  DEC $077F       ; IntervalTimerControl ($077F): divisor de 21 frames (~3 Hz)
0x8105  10 07     BPL $810E
0x8107  A9 14     LDA #$14
0x8109  8D 7F 07  STA $077F       ; Recargar divisor con $14 (20 -> 21 frames)
0x810C  A2 23     LDX #$23        ; Incluir también temporizadores lentos ($0795..$07A3)
0x810E  BD 80 07  LDA $0780,X
0x8111  F0 03     BEQ $8116
0x8113  DE 80 07  DEC $0780,X     ; Decrementar temporizador activo si > 0
0x8116  CA        DEX
0x8117  10 F5     BPL $810E
0x8119  E6 09     INC $09         ; FrameCounter ($09)++

; 5. Generador de números pseudoaleatorios (LFSR de 56 bits en $07A7..$07AD)
0x811B  A2 00     LDX #$00
0x811D  A0 07     LDY #$07
0x811F  AD A7 07  LDA $07A7       ; Bit 1 de $07A7 XOR Bit 1 de $07A8
0x8122  29 02     AND #$02
0x8124  85 00     STA $00
0x8126  AD A8 07  LDA $07A8
0x8129  29 02     AND #$02
0x812B  45 00     EOR $00
0x812D  18        CLC
0x812E  F0 01     BEQ $8131
0x8130  38        SEC
0x8131  7E A7 07  ROR $07A7,X     ; Desplazar registro LFSR de 7 bytes a la derecha
0x8134  E8        INX
0x8135  88        DEY
0x8136  D0 F9     BNE $8131

; 6. Sincronización de Sprite #0 Hit (barra de estado fija vs. scroll horizontal del nivel)
0x8138  AD 22 07  LDA $0722       ; Sprite0HitDetectFlag ($0722)
0x813B  F0 1F     BEQ $815C       ; Si no se requiere detección de Sprite #0, saltar
0x813D  AD 02 20  LDA $2002
0x8140  29 40     AND #$40        ; Esperar a que se limpie el flag de Sprite #0 Hit del frame anterior
0x8142  D0 F9     BNE $813D
0x8144  AD 76 07  LDA $0776       ; Si no está en pausa, limpiar sprites (salvo Sprite #0) y barajar OAM
0x8147  4A        LSR A
0x8148  B0 06     BCS $8150
0x814A  20 23 82  JSR $8223       ; MoveSpritesOffscreen (sprites 1..63 -> Y=$F8)
0x814D  20 C6 81  JSR $81C6       ; SpriteShuffler (alterna prioridades OAM para parpadeo en vez de ocultación)
0x8150  AD 02 20  LDA $2002
0x8153  29 40     AND #$40        ; Esperar a que la PPU alcance la línea del Sprite #0 (moneda del HUD)
0x8155  F0 F9     BEQ $8150
0x8157  A0 14     LDY #$14        ; Retardo corto (~100 ciclos) hasta fin de scanline del HUD
0x8159  88        DEY
0x815A  D0 FD     BNE $8159

; 7. Aplicar Scroll del Nivel y Ejecutar Árbol de Modos de Juego (OperModeExecutionTree)
0x815C  AD 3F 07  LDA $073F       ; HorizontalScroll ($073F)
0x815F  8D 05 20  STA $2005       ; PPUSCROLL X
0x8162  AD 40 07  LDA $0740       ; VerticalScroll ($0740)
0x8165  8D 05 20  STA $2005       ; PPUSCROLL Y
0x8168  AD 78 07  LDA $0778       ; Mirror_PPUCTRL (contiene el bit de nametable horizontal)
0x816B  48        PHA
0x816C  8D 00 20  STA $2000
0x816F  AD 76 07  LDA $0776       ; GamePauseStatus
0x8172  4A        LSR A
0x8173  B0 03     BCS $8178       ; Si está en pausa, NO ejecutar la lógica del modo de juego
0x8175  20 12 82  JSR $8212       ; ---> OperModeExecutionTree ($8212) <---
0x8178  AD 02 20  LDA $2002       ; Limpiar flag de VBlank pendiente en PPUSTATUS
0x817B  68        PLA
0x817C  09 80     ORA #$80        ; Reactivar generación de NMI (bit 7 = 1) para el siguiente frame
0x817E  8D 00 20  STA $2000
0x8181  40        RTI             ; Fin del manejador de fotograma NMI
```

---

### 3.3. Subrutinas Auxiliares Descubiertas en Fase 2

| Dirección | Nombre Recuperado | Llamada desde | Función |
| :--- | :--- | :--- | :--- |
| `0x8182` | `PauseRoutine` | `NMI` (`0x80EA`) | Lee `SavedJoypad1Bits` (`$06FC`), detecta botón `START` (`#$10`), aplica antirrebote (`$0777 = #$2B`), dispara sonido de pausa (`$FA`) y conmuta el bit 0 de `GamePauseStatus` (`$0776`). |
| `0x81C6` | `SpriteShuffler` | `NMI` (`0x814D`) | Rota los offsets de OAM (`$06E4..$06FD`) para que cuando haya más de 8 sprites en una scanline parpadeen en vez de volverse invisibles. |
| `0x8212` | `OperModeExecutionTree` | `NMI` (`0x8175`) | Carga `OperMode` (`$0770`) y llama a `JumpEngine` (`0x8E04`) para despachar a `0x8231` (`TitleScreenMode`), `0xAEDC` (`GameMode`), `0x838B` (`VictoryMode`) o `0x9218` (`GameOverMode`). |
| `0x8220` | `MoveAllSpritesOffscreen` | `RESET` (`0x8046`) | Escribe `#$F8` en la coordenada Y (`$0200,Y`) de los 64 sprites (con entrada secundaria en `0x8223` que preserva el Sprite #0 desde `Y=#$04`). |
| `0x8E04` | `JumpEngine` | `0x8215` (y 30+ sitios) | Multiplica `A` por 2 (`ASL A`), extrae la dirección de retorno de la pila (`PLA` -> `$04/$05`), lee el puntero de 16 bits en `($04),Y` hacia `$06/$07` y ejecuta `JMP ($0006)`. |
| `0x8E19` | `InitializeNameTables` | `RESET` (`0x8049`) | Limpia las nametables `$2000` y `$2400` con el tile vacío `#$24` e inicializa sus tablas de atributos. |
| `0x8E5C` | `ReadJoypads` | `NMI` (`0x80E7`) | Envía el pulso de strobe (`$01`/`$00`) a `$4016` y lee los 8 botones serie de los mandos 1 y 2. |
| `0x8EDD` | `UpdateScreen` | `NMI` (`0x80C3`) | Interpreta las cadenas de comandos de dibujo en el buffer apuntado por `($00)` y las escribe en `PPUADDR`/`PPUDATA`. |
| `0x8F97` | `UpdateTopScore` | `NMI` (`0x80ED`) | Compara la puntuación del jugador con `TopScoreDisplay` (`$07D7..$07DC`) y actualiza el récord si es mayor. |
| `0x90CC` | `InitializeMemory` | `RESET` (`0x802B`) | Rellena con `$00` desde la página `$07` (offset inicial en `Y`) hasta `$0000`, saltando la pila activa (`$0160..$01FF`). |
| `0xF2D0` | `SoundEngine` | `NMI` (`0x80E4`) | Motor de audio principal: despacha efectos de sonido (salto, moneda, fuego) y el secuenciador musical de las 4 pistas de la APU. |
