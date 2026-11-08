# Super Mario Bros. (NES) — Reporte de Fase 4: Subsistemas Nucleares y Mapa Consolidado de Símbolos / RAM

## 1. Física y Control del Jugador (Mario) — `PlayerCtrlRoutine` (`0xB0E9`)

Invocada desde la entrada `[8]` de `GameRoutines` (`0xB04A` -> tabla `0xB04F`), `PlayerCtrlRoutine` (`0xB0E9..0xB183`) procesa la entrada del mando, la física de salto/gravedad, la inercia horizontal y la colisión con el escenario en cada fotograma:

### 1.1. Secuencia de Ejecución de `PlayerCtrlRoutine` (`0xB0E9..0xB162`)

```assembly
; =============================================================================
; PlayerCtrlRoutine (0xB0E9) — Control y física en tiempo real de Mario
; =============================================================================
0xB0E9  A5 0E     LDA $0E         ; GameEngineSubroutine
0xB0EB  C9 0B     CMP #$0B        ; ¿Mario está en estado de muerte (#$0B)?
0xB0ED  F0 3C     BEQ $B12B       ; Si está muriendo, ignorar botones y saltar a física

; Bloqueo de controles si Mario cae por debajo del borde inferior en nivel no-acuático
0xB0EF  AD 4E 07  LDA $074E       ; AreaType ($074E: 0=Agua, 1=Tierra, 2=Subterráneo, 3=Castillo)
0xB0F2  D0 10     BNE $B104
0xB0F4  A4 B5     LDY $B5         ; Player_Y_HighPos ($B5)
0xB0F6  88        DEY
0xB0F7  D0 06     BNE $B0FF
0xB0F9  A5 CE     LDA $CE         ; Player_Y_Position ($CE)
0xB0FB  C9 D0     CMP #$D0
0xB0FD  90 05     BCC $B104
0xB0FF  A9 00     LDA #$00        ; Anular controles bajo el agua debajo de Y=$D0
0xB101  8D FC 06  STA $06FC

; Descomposición de SavedJoypadBits ($06FC) en sub-registros de Zero-Page
0xB104  AD FC 06  LDA $06FC
0xB107  29 C0     AND #$C0        ; Aislar botones A (bit 7) y B (bit 6)
0xB109  85 0A     STA $0A         ; A_B_Buttons ($0A)
0xB10B  AD FC 06  LDA $06FC
0xB10E  29 03     AND #$03        ; Aislar Derecha (bit 0) e Izquierda (bit 1)
0xB110  85 0C     STA $0C         ; Left_Right_Buttons ($0C)
0xB112  AD FC 06  LDA $06FC
0xB115  29 0C     AND #$0C        ; Aislar Arriba (bit 3) y Abajo (bit 2)
0xB117  85 0B     STA $0B         ; Up_Down_Buttons ($0B)

; Agacharse (Crouch): si pulsa ABAJO en el suelo ($1D == 0), anular movimiento lateral
0xB119  29 04     AND #$04        ; ¿Abajo presionado?
0xB11B  F0 0E     BEQ $B12B
0xB11D  A5 1D     LDA $1D         ; Player_State ($1D: 0 = en suelo)
0xB11F  D0 0A     BNE $B12B
0xB121  A4 0C     LDY $0C         ; Si además pulsa Izquierda/Derecha, limpiar $0C y $0B
0xB123  F0 06     BEQ $B12B
0xB125  A9 00     LDA #$00
0xB127  85 0C     STA $0C
0xB129  85 0B     STA $0B

; Subrutinas de disparo, física, bounding box y colisión con escenario
0xB12B  20 29 B3  JSR $B329       ; GameTimerFireball: gestiona reloj y disparo de bola de fuego con B
0xB12E  A0 01     LDY #$01        ; Calcular índice de Bounding Box de Mario (0=Grande, 1=Pequeño, 2=Agachado)
0xB130  AD 54 07  LDA $0754       ; PlayerSize ($0754: 0=Grande, 1=Pequeño)
0xB133  D0 09     BNE $B13E
0xB135  A0 00     LDY #$00
0xB137  AD 14 07  LDA $0714       ; CrouchingFlag ($0714)
0xB13A  F0 02     BEQ $B13E
0xB13C  A0 02     LDY #$02
0xB13E  8C 99 04  STY $0499       ; Player_BoundBoxCtrl ($0499)
0xB14C  20 93 AF  JSR $AF93       ; PlayerMovementSubs: física X/Y, salto, gravedad y desplazamiento
0xB14F  20 80 F1  JSR $F180       ; GetPlayerOffscreenBits
0xB152  20 2A F1  JSR $F12A       ; RelativePlayerPosition
0xB155  A2 00     LDX #$00        ; X = 0 (slot del jugador)
0xB157  20 9C E2  JSR $E29C       ; BoundingBoxCore: calcula coordenadas del hitbox en $04AC..$04AF
0xB15A  20 64 DC  JSR $DC64       ; PlayerBGCollision: colisión de Mario con tiles del nivel
```

### 1.2. Tablas de Física de Salto y Gravedad (`0xB424..0xB500`)
En `0xB479..0xB500` (`ProcJumpingSwim`), cuando Mario inicia un salto (`A_B_Buttons & #$80`), el juego selecciona uno de **5 perfiles de salto** (`Y = 0..4`) según la velocidad horizontal absoluta de Mario (`$0700` — `Player_X_MoveForce`, umbrales `#$09`, `#$10`, `#$19`, `#$1C`), o los perfiles de nado (`Y = 5..6` si `SwimmingFlag` en `$0704 != 0`):
- `0xB424` (`JumpMForceData`): Parte fraccionaria de gravedad inicial (`$0709`).
- `0xB42B` (`FallMForceData`): Incremento de gravedad en caída libre (`$070A` — mayor gravedad al soltar el botón `A`, lo que permite saltos de altura variable).
- `0xB432` (`PlayerYSpdData`): Velocidad vertical inicial de salto (`$9F`,p. ej. `#$FC` o `#$FB`).
- `0xB439` (`InitMForceData`): Fuerza fraccionaria vertical inicial (`$0433`).

---

## 2. Motor de Entidades / Enemigos y Sistema de Colisiones

### 2.1. `EnemiesAndLoopsCore` (`0xC047`) y `RunEnemyObjectsCore` (`0xC882`)
Llamado en bucle para los 6 slots de entidades (`X = 0..5`, guardado en `ObjectOffset` `$08`):
1. **`0xC047`**: Lee `Enemy_Flag,X` (`$0F,X`).
   - Si el slot está vacío (`$0F,X == 0`), comprueba periódicamente el comando de bucle de castillos tipo `4-4`/`7-4` (`ProcessLoopCommand` en `0xC0CC`).
   - Si el slot está activo (`$0F,X != 0`), salta a **`0xC882` (`RunEnemyObjectsCore`)**.
2. **`0xC882` (`RunEnemyObjectsCore`)**:
   - Toma el identificador de entidad `Enemy_ID,X` (`$16,X`):
     - Si `Enemy_ID < #$15` (Goomba `#$06`, Koopa `#$00..#$03`, Lakitu `#$11`, Piranha Plant `#$0D`, Podoboo `#$0C`, etc.), pasa `A = 0` a `JSR $8E04` (`0xC88F`), ejecutando la entrada `[0]` **`0xC8E0` (`RunNormalEnemies`)**.
     - Si `Enemy_ID >= #$15` (Bowser `#$2D`, llama de Bowser `#$15`, puente, plataformas móviles, etc.), resta `#$14` (`SBC #$14`) e indexa las entradas `[1..33]` de la tabla `0xC892`.

### 2.2. Pipeline de un Enemigo Estándar: `RunNormalEnemies` (`0xC8E0..0xC904`)
```assembly
0xC8E0  A9 00     LDA #$00
0xC8E2  9D C5 03  STA $03C5,X     ; Limpiar flag de estado de sprite
0xC8E5  20 AF F1  JSR $F1AF       ; GetEnemyOffscreenBits: ¿qué partes están fuera de cámara?
0xC8E8  20 52 F1  JSR $F152       ; RelativeEnemyPosition: posición relativa a pantalla
0xC8EB  20 7D E8  JSR $E87D       ; EnemyGfxHandler: dibuja el metasprite del enemigo en OAM ($0200)
0xC8EE  20 43 E2  JSR $E243       ; GetEnemyBoundBox: calcula hitbox del enemigo en $04B0+4*X
0xC8F1  20 C1 DF  JSR $DFC1       ; EnemyToBGCollisionDet: colisión enemigo vs. paredes y suelo
0xC8F4  20 33 DA  JSR $DA33       ; EnemiesCollision: colisión enemigo vs. otros enemigos / caparazones
0xC8F7  20 53 D8  JSR $D853       ; PlayerEnemyCollision: colisión Mario vs. este enemigo/power-up
0xC8FA  AC 47 07  LDY $0747       ; TimerControl: si el juego no está congelado por animación...
0xC8FD  D0 03     BNE $C902
0xC8FF  20 05 C9  JSR $C905       ; EnemyMovementSubs (JSR $8E04 en 0xC907: IA de movimiento)
0xC902  4C 7A D6  JMP $D67A       ; OffscreenBoundsCheck: elimina enemigo si queda atrás de la cámara
```

---

## 3. Decodificador de Niveles (`AreaParserCore` en `0x92B0`) y Motor de Audio (`SoundEngine` en `0xF2D0`)

### 3.1. Streaming y Decodificación de Niveles (`0x92B0..0x96C5`)
Super Mario Bros. almacena los 32 niveles comprimidos como listas de objetos geométricos de 2 bytes (coordenada/página + tipo/longitud) ordenados de izquierda a derecha:
1. **`0x92B0` (`AreaParserCore`)**:
   - Se ejecuta a medida que avanza el scroll horizontal.
   - Llama a **`0x92C8` (`ProcessAreaData` / `JSR $8E04`)**, que alterna entre decodificar las columnas del búfer de bloques (`0x92DB` / `0x93FC` `DecodeAreaData`) y renderizar los atributos/tiles en VRAM (`0x88AE`).
2. **`0x9664` (`DecodeAreaData` — Tabla de 47 Constructores en `0x9667..0x96C4`)**:
   - Despacha la construcción de cada elemento del escenario sobre el buffer de metatiles en RAM (`Block_Buffer_1` en `$0500..$05CF` y `Block_Buffer_2` en `$05D0..$069F`):
     - Bloques con interrogación (moneda o power-up), filas de ladrillos, tuberías verticales y de entrada, cañones Bullet Bill, puentes, plataformas, escaleras de bloques, fosos sin fondo y el castillo final con mástil de bandera.

### 3.2. Motor de Audio APU (`SoundEngine` en `0xF2D0`)
Invocado desde `NMI` (`0x80E4: JSR $F2D0`) en cada fotograma:
- **`0xF2D0..0xF2D8`**: Si el juego está en `TitleScreenMode` (`OperMode == 0`), escribe `0` en `$4015` (silenciando todos los canales de la APU) y retorna inmediatamente (`RTS`).
- **`0xF2D9..0xF2E2`**: Configura el contador de tramas de la APU (`$4017 = #$FF`) y habilita los 4 canales (`$4015 = #$0F`).
- **Colas de Audio en Zero-Page (`$FA..$FF`)**:
  - `$FA` (`PauseSoundQueue`): Sonido de pausa (prioridad máxima: silencia la música mientras suena).
  - `$FB` (`Square1SoundQueue`): Efectos en canal Pulse 1 (salto pequeño/grande, nadar, pisar enemigo, golpear bloque).
  - `$FC` (`MusicQueue`): Pistas musicales principales (Overworld, Underground, Underwater, Castle, Starman, Victory, Game Over, Muerte).
  - `$FD` (`NoiseSoundQueue`): Efectos en canal de ruido (romper ladrillo, explosión/fuego de Bowser).
  - `$FE` (`AreaMusicQueue`) / `$FF` (`Square2SoundQueue`): Efectos en canal Pulse 2 (moneda, aparición de power-up / 1-UP, fuegos artificiales, caída de Bowser).

---

## 4. Catálogo Consolidado de Funciones Principales (`0x8000..0xFFFF`)

| Dirección | Offset PRG | Símbolo Recuperado | Subsistema | Descripción |
| :--- | :--- | :--- | :--- | :--- |
| `0x8000` | `+0x0000` | `Start` (`RESET`) | Boot / Core | Punto de entrada de hardware; detecta Cold/Warm boot, limpia RAM y activa NMI. |
| `0x8057` | `+0x0057` | `InfiniteLoop` | Boot / Core | Bucle infinito `JMP $8057`; cede todo el control a `NMI`. |
| `0x8082` | `+0x0082` | `NonMaskableInterrupt` (`NMI`) | Core / VBlank | Manejador de fotograma a 60 Hz (OAM DMA, VRAM, APU, mandos, RNG, Sprite #0, scroll y `OperMode`). |
| `0x8182` | `+0x0182` | `PauseRoutine` | Core / Input | Detecta botón `START` y alterna `GamePauseStatus` (`$0776`). |
| `0x81C6` | `+0x01C6` | `SpriteShuffler` | Render / OAM | Cicla posiciones OAM para multiplexar >8 sprites por línea mediante parpadeo. |
| `0x8212` | `+0x0212` | `OperModeExecutionTree` | Dispatcher | Despachador raíz de los 4 modos según `OperMode` (`$0770`). |
| `0x8220` | `+0x0220` | `MoveAllSpritesOffscreen` | Render / OAM | Oculta los 64 sprites escribiendo `Y = #$F8` en `$0200..$02FC`. |
| `0x8231` | `+0x0231` | `TitleScreenMode` | Mode 0 | Despachador de tareas de pantalla de título y modo demo. |
| `0x8245` | `+0x0245` | `GameMenuRoutine` | Mode 0 | Selección de 1/2 jugadores, selección de mundo con `B` y ejecución de demo. |
| `0x836B` | `+0x036B` | `DemoEngine` | Mode 0 | Reproduce la tabla de botones grabados para la demo de la pantalla de título. |
| `0x838B` | `+0x038B` | `VictoryMode` | Mode 2 | Secuencia de victoria tras tocar el hacha en castillos `X-4`. |
| `0x83A0` | `+0x03A0` | `VictoryModeSubroutines` | Mode 2 | Despacha las 5 fases de victoria (colapso de puente, paseo, mensajes de Toad/Peach). |
| `0x84C3` | `+0x04C3` | `FloateyNumbersRoutine` | UI / HUD | Actualiza y dibuja puntuaciones flotantes (`100`..`8000`, `1UP`). |
| `0x8567` | `+0x0567` | `ScreenRoutines` | Render / Setup | Despachador de 15 subtareas para construir pantallas y HUD en VRAM. |
| `0x86FF` | `+0x06FF` | `DrawTitleScreen` | Mode 0 / VRAM | Carga el mapa de tiles de la pantalla de título desde la CHR-ROM (`$1EC0`). |
| `0x8E04` | `+0x0E04` | `JumpEngine` | Core / Dispatcher | Despachador dinámico de tablas de punteros de 16 bits in-line (18 sitios en ROM). |
| `0x8E19` | `+0x0E19` | `InitializeNameTables` | Render / VRAM | Borra las nametables `$2000` y `$2400` con el tile vacío `#$24`. |
| `0x8E5C` | `+0x0E5C` | `ReadJoypads` | Core / Input | Lee los desplazamientos serie de los mandos 1 y 2 (`$4016`/`$4017`). |
| `0x8EDD` | `+0x0EDD` | `UpdateScreen` | Render / VRAM | Intérprete de tiras de comandos VRAM en `$0300` hacia `$2006`/`$2007`. |
| `0x8F97` | `+0x0F97` | `UpdateTopScore` | UI / Score | Sincroniza la puntuación máxima si algún jugador la supera. |
| `0x8FCF` | `+0x0FCF` | `InitializeGame` | Setup | Inicializa partida desde pantalla de título. |
| `0x8FE4` | `+0x0FE4` | `InitializeArea` | Setup | Inicializa punteros y variables al cargar un área o nivel. |
| `0x90CC` | `+0x10CC` | `InitializeMemory` | Boot / Core | Limpia la RAM `$0000..$07FE` (o `$07D6` en Warm Boot) respetando la pila `$0160..$01FF`. |
| `0x9218` | `+0x1218` | `GameOverMode` | Mode 3 | Despachador de las 3 tareas de la pantalla de Game Over. |
| `0x92B0` | `+0x12B0` | `AreaParserCore` | Level Engine | Decodificador en streaming de columnas de nivel a medida que avanza el scroll. |
| `0x9664` | `+0x1664` | `DecodeAreaData` | Level Engine | Despachador de los 47 constructores de objetos de escenario. |
| `0xAEDC` | `+0x2EDC` | `GameMode` | Mode 1 | Despachador principal del modo de partida activa. |
| `0xAEEA` | `+0x2EEA` | `GameCoreRoutine` | Mode 1 | Bucle maestro por fotograma de jugador, scroll, 6 enemigos, bloques y sprites. |
| `0xAF93` | `+0x2F93` | `PlayerMovementSubs` | Player Physics | Integra aceleración, fricción, gravedad y desplazamiento X/Y de Mario. |
| `0xB04A` | `+0x304A` | `GameRoutines` | Player State | Máquina de 13 estados de Mario (`GameEngineSubroutine` en `$0E`). |
| `0xB0E9` | `+0x30E9` | `PlayerCtrlRoutine` | Player Control | Procesa botones de Mario, disparo de fuego, salto y colisiones con escenario. |
| `0xB329` | `+0x3329` | `GameTimerFireball` | Player / Weapon | Decrementa el reloj del nivel (`400..0`) e instancia bolas de fuego al pulsar `B`. |
| `0xB624` | `+0x3624` | `ScrollHandler` | Camera / Scroll | Calcula desplazamiento de cámara horizontal y solicita nuevas columnas al parser. |
| `0xB7B8` | `+0x37B8` | `FlagpoleRoutine` | Level Objects | Gestiona la bandera del final del nivel y su puntuación. |
| `0xB855` | `+0x3855` | `ColorRotation` | Render / Palette | Anima la paleta de monedas, bloques `?` y el destello de Mario Estrella. |
| `0xBB96` | `+0x3B96` | `MiscObjectsCore` | Entities | Actualiza proyectiles auxiliares (martillos de Hammer Bros, monedas saltarinas). |
| `0xBE70` | `+0x3E70` | `BlockObjectsCore` | Level Objects | Física de rebote de bloques golpeados por Mario. |
| `0xC047` | `+0x4047` | `EnemiesAndLoopsCore` | Enemy Engine | Gestiona cada uno de los 6 slots de entidades y los bucles de castillos laberínticos. |
| `0xC27F` | `+0x427F` | `InitEnemyObject` | Enemy Engine | Despachador de 55 constructores de inicialización por `Enemy_ID`. |
| `0xC882` | `+0x4882` | `RunEnemyObjectsCore` | Enemy Engine | Despachador de ejecución por fotograma de todos los tipos de enemigos y jefes. |
| `0xC8E0` | `+0x48E0` | `RunNormalEnemies` | Enemy Engine | Pipeline completo de enemigos estándar (OAM, Hitbox, BG/Enemy/Player Collision, IA). |
| `0xCFEC` | `+0x4FEC` | `BridgeCollapse` | Mode 2 / Boss | Secuencia de destrucción del puente de Bowser y caída a la lava. |
| `0xD853` | `+0x5853` | `PlayerEnemyCollision` | Collisions | Detecta y resuelve colisiones entre Mario y enemigos/power-ups (pisotón, daño, estrella). |
| `0xDA33` | `+0x5A33` | `EnemiesCollision` | Collisions | Detecta colisiones entre enemigos y caparazones pateados. |
| `0xDC64` | `+0x5C64` | `PlayerBGCollision` | Collisions | Detecta y resuelve colisiones de Mario contra bloques, tuberías, suelo, monedas y agua. |
| `0xDFC1` | `+0x5FC1` | `EnemyToBGCollisionDet` | Collisions | Detecta colisiones de enemigos contra el escenario y cambios de dirección. |
| `0xE29C` | `+0x629C` | `BoundingBoxCore` | Collisions | Calcula las 4 esquinas (`X1, Y1, X2, Y2`) del rectángulo de colisión en `$04AC+4*X`. |
| `0xE87D` | `+0x687D` | `EnemyGfxHandler` | Render / OAM | Construye los sprites de enemigos, plataformas y Bowser en `$0200`. |
| `0xEEE9` | `+0x6EE9` | `PlayerGfxHandler` | Render / OAM | Construye los metasprites de Mario (pequeño, grande, nadando, trepando) en `$0200`. |
| `0xF2D0` | `+0x72D0` | `SoundEngine` | Audio / APU | Motor de efectos de sonido y secuenciador musical de 4 canales. |
| `0xFFF0` | `+0x7FF0` | `IRQStub` (`IRQ/BRK`) | Hardware Vector | Vector de interrupción `IRQ/BRK` (bucle inactivo / no utilizado en NROM). |

---

## 5. Mapa de Variables Clave en Memoria RAM (`$0000..$07FF`)

| Dirección RAM | Símbolo | Tamaño | Función en el Motor |
| :--- | :--- | :-: | :--- |
| `$0000..$0007` | `TempPointers` | 8 B | Punteros indirectos temporales; `$04..$07` usados por `JumpEngine` (`0x8E04`). |
| `$0008` | `ObjectOffset` | 1 B | Índice `X` (`0..5`) de la entidad/enemigo que se está procesando actualmente. |
| `$0009` | `FrameCounter` | 1 B | Contador global de fotogramas incrementado en cada `NMI`. |
| `$000A..$000C` | `JoypadBitMasks` | 3 B | Botones desglosados de Mario: `$0A` (`A/B`), `$0B` (`Up/Down`), `$0C` (`Left/Right`). |
| `$000E` | `GameEngineSubroutine` | 1 B | Estado actual de Mario (`0..12`, despachado por `GameRoutines` en `0xB04A`). |
| `$000F..$0014` | `Enemy_Flag` | 6 B | Estado de activación de los 6 slots de enemigos (`0` = inactivo, `>=1` = activo). |
| `$0016..$001B` | `Enemy_ID` | 6 B | Identificador de tipo de entidad para cada uno de los 6 slots (`0x00` Koopa, `0x06` Goomba, `0x2D` Bowser, `0x2E` Power-Up). |
| `$001D` | `Player_State` | 1 B | Estado físico de Mario (`0` = en suelo, `1` = en el aire/saltando, `2` = cayendo de borde, `3` = trepando). |
| `$0057` | `Player_X_Speed` | 1 B | Velocidad horizontal con signo de Mario (en píxeles/subpíxeles). |
| `$006D` | `Player_PageLoc` | 1 B | Página horizontal (`256 px`) de la posición de Mario en el nivel. |
| `$0086` | `Player_X_Position` | 1 B | Coordenada X de Mario dentro de la página actual (`0..255`). |
| `$009F` | `Player_Y_Speed` | 1 B | Velocidad vertical con signo de Mario (`<0` subiendo, `>0` cayendo). |
| `$00B5` | `Player_Y_HighPos` | 1 B | Página vertical de Mario (`1` = pantalla visible, `>1` = caído en foso). |
| `$00CE` | `Player_Y_Position` | 1 B | Coordenada Y en píxeles de Mario (`0..255`). |
| `$00FA..$00FF` | `SoundQueues` | 6 B | Colas de disparo de sonido y música leídas por `SoundEngine` (`0xF2D0`). |
| `$0100..$015F` | `VertScrollBuffer` | 96 B | Buffer auxiliar y datos de texto/bandera. |
| `$0160..$01FF` | `HardwareStack` | 160 B | Pila hardware del 6502 (protegida durante `InitializeMemory` en `0x90CC`). |
| `$0200..$02FF` | `SpriteOAMBuffer` | 256 B | Buffer de 64 sprites (4 bytes c/u: `Y, Tile, Attr, X`) transferido por DMA a `$4014`. |
| `$0300..$0362` | `VRAM_Buffer1_2` | 99 B | Colas de comandos de escritura diferida a la PPU consumidas por `UpdateScreen` (`0x8EDD`). |
| `$04AC..$04CF` | `BoundingBoxCoords` | 36 B | Coordenadas `(X1, Y1, X2, Y2)` del hitbox de Mario (`$04AC..$04AF`) y de cada entidad. |
| `$0500..$069F` | `Block_Buffers_1_2` | 416 B | Mapa circular en RAM de dos pantallas de metatiles (`16x16 px`) para colisiones con el nivel. |
| `$06FC..$06FD` | `SavedJoypadBits` | 2 B | Estado leído de los 8 botones del Mando 1 (`$06FC`) y Mando 2 (`$06FD`). |
| `$0700` | `Player_X_MoveForce` | 1 B | Magnitud de velocidad horizontal usada para elegir entre los 5 perfiles de salto. |
| `$0704` | `SwimmingFlag` | 1 B | `0` = física terrestre, `!=0` = física de nado (permite saltar repetidamente en el aire). |
| `$073C` | `ScreenRoutineTask` | 1 B | Índice (`0..14`) de subtarea en `ScreenRoutines` (`0x8567`). |
| `$073F..$0740` | `Scroll_X_Y` | 2 B | Registros sombra de `PPUSCROLL` horizontal (`$073F`) y vertical (`$0740`). |
| `$074E` | `AreaType` | 1 B | Tipo de escenario (`0` = Agua, `1` = Tierra/Overworld, `2` = Subterráneo, `3` = Castillo). |
| `$0754` | `PlayerSize` | 1 B | Tamaño de Mario (`0` = Super/Fire Grande, `1` = Pequeño). |
| `$0756` | `PlayerStatus` | 1 B | Estado de power-up (`0` = Pequeño, `1` = Super Mario, `2` = Fire Mario). |
| `$075A` | `NumberofLives` | 1 B | Contador de vidas restantes de Mario (mostrado como `Lives + 1`). |
| `$075F..$0760` | `World_LevelNumber` | 2 B | Mundo actual (`$075F`, `0..7` = Mundos 1..8) y Nivel/Etapa (`$0760`, `0..3` = Etapas 1..4). |
| `$0770` | `OperMode` | 1 B | Modo maestro del juego (`0` = Title, `1` = Game, `2` = Victory, `3` = GameOver). |
| `$0772` | `OperMode_Task` | 1 B | Subtarea actual dentro del modo `OperMode` activo. |
| `$0773` | `VRAM_Buffer_AddrCtrl` | 1 B | Selector de tabla de comandos VRAM para el próximo `NMI`. |
| `$0774` | `DisableScreenFlag` | 1 B | Si `!= 0`, apaga fondo y sprites en `PPUMASK` durante cargas de nivel. |
| `$0776` | `GamePauseStatus` | 1 B | Bit 0 = juego en pausa; Bit 7 = bloqueo de antirrebote de transición. |
| `$0778..$0779` | `Mirror_PPUCTRL_MASK` | 2 B | Copias en RAM de los registros de escritura `$2000` (`PPUCTRL`) y `$2001` (`PPUMASK`). |
| `$0780..$07A3` | `GameTimers` | 36 B | Temporizadores rápidos (`$0780..$0794`, 60 Hz) y lentos (`$0795..$07A3`, ~2.85 Hz). |
| `$07A7..$07AD` | `PseudoRandomBitReg` | 7 B | Registro LFSR de 56 bits desplazado en cada `NMI` (semilla inicial `#$A5`). |
| `$07D7..$07DC` | `TopScoreDisplay` | 6 B | Los 6 dígitos BCD desempacados de la puntuación récord (preservados en Warm Boot). |
| `$07FF` | `WarmBootValidation` | 1 B | Firma mágica `#$A5` que indica que la RAM ya fue inicializada previamente. |
