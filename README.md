# Super Mario Bros. — Port Nativo para Windows 11 (Ingeniería Inversa con REA + Ghidra 12.1.4)

Este repositorio contiene el análisis completo de ingeniería inversa de **Super Mario Bros.** (NES, 1985) realizado mediante **REA + Ghidra 12.1.4 (`6502:LE:16:default`)** y un extractor estático recursivo de cobertura total, junto con la **implementación nativa para Windows 11 (`SuperMarioBros_Win11`)**.

---

## Características Principales de la Versión 100% Nativa para Windows 11 (`SuperMarioBros_Win11`)

- **Recompilación Estática 100% Nativa en C# (Sin Emulador ni Carga de Archivos ROM `.nes`)**:
  - Todas las **533 subrutinas y 18 tablas `JumpEngine`** identificadas durante la ingeniería inversa han sido traducidas estáticamente (Ahead-of-Time Static Binary Translation) a código C# nativo en `SuperMarioBros_Win11/src/Recompiled/` (`SmbRecompiledBank_0_8000_9FFF.cs`, `SmbRecompiledBank_1_A000_BFFF.cs`, `SmbRecompiledBank_2_C000_DFFF.cs`, `SmbRecompiledBank_3_E000_FFFF.cs`), compilado directamente a código máquina x64 por RyuJIT sin ningún intérprete de opcodes ni carga de archivos `.nes` externos.
  - Todos los gráficos (512 tiles pre-decodificados) y tablas de datos (34 niveles, enemigos, física en coma fija, cajas de colisión, paletas y secuencias musicales) están integrados estáticamente en `SmbEmbeddedAssets.cs`.
- **Controlador de Juegos Nativo con `Windows.Gaming.Input` y Latencia Mínima**:
  - Integración directa mediante invocación nativa COM/WinRT (`RoGetActivationFactory` + punteros de función `delegate* unmanaged[Stdcall]`) con **`Windows.Gaming.Input.Gamepad`** (`IGamepadStatics` / `IGamepad`) y **`Windows.Gaming.Input.RawGameController`** (`IRawGameControllerStatics` / `IRawGameController`), sin asignaciones en el heap (Zero-GC) y combinada con muestreo instantáneo de teclado (`GetAsyncKeyState`).
- **Resoluciones Altas de Windows 11**:
  - Renderizado escalado en paralelo (`Parallel.For` con punteros no administrados) a resoluciones altas desde la barra de menú estándar de Windows:
    - `1280 × 720 (HD 720p)`
    - `1600 × 900 (HD+ 900p)`
    - `1920 × 1080 (Full HD 1080p)` *(Por defecto)*
    - `1920 × 1200 (WUXGA 1200p - 16:10)`
    - `2560 × 1440 (QHD 1440p)`
    - `3840 × 2160 (4K UHD 2160p)`
    - `Pantalla Completa Sin Bordes (F11)`
- **Detección Inteligente de 120 FPS**:
  - Consulta los modos de refresco soportados por el monitor (`EnumDisplaySettingsW` / `GetDeviceCaps`) y mide el rendimiento de CPU/escalado en el arranque.
  - Si el ordenador permite ejecutar a **120 FPS**, habilita la opción **`120 FPS (120.20 Hz Ultra-Baja Latencia + Interpolado)`** en el menú desplegable `Tasa de Fotogramas (FPS)`. Si el hardware está limitado a 60 Hz, oculta automáticamente dicha opción.
- **Menú Desplegable Estándar de Windows**:
  - Todas las opciones de resolución, relación de aspecto (`4:3`, `Pixel-Perfect`, `16:9`), filtro `Scanlines CRT`, tasa de fotogramas y configuración de `Windows.Gaming.Input` se encuentran en un `MenuStrip` nativo de Windows, preservando intacto el menú original del juego.

---

## Estructura del Repositorio

- `SuperMarioBros_Win11/`: Código fuente y ejecutable compilado (`bin/Release/net6.0-windows/SuperMarioBros_Win11.exe`) de la versión nativa para Windows 11.
- `DOC_DISENO_PORT_WIN11_ARQUITECTURA.md`: Documento de Diseño (Volumen 1) — Arquitectura del sistema, mapa de RAM (`$0000..$07FF`), PPU 2C02 y sintetizador APU 2A03.
- `DOC_DISENO_PORT_WIN11_SUBSISTEMAS_Y_DATOS.md`: Documento de Diseño (Volumen 2) — Decompilaciones de Ghidra 12.1.4, las 18 tablas `JumpEngine` (`239` punteros), física en coma fija, decodificador de las 34 áreas y colisiones AABB.
- `smb_full_disassembly.asm`: Desensamblado completo y anotado de los 32 KB de PRG-ROM (`$8000..$FFFF`, `14,663` líneas).
- `smb_symbols.json`: Catálogo estructurado de las 533 subrutinas descubiertas y las 34 funciones decompiladas con Ghidra 12.1.4.
- `smb_rom_data_tables.json`: Tablas de datos binarios extraídas de la ROM (punteros de niveles, física, cajas de colisión, paletas y pantalla de título).
- `smb_rea_evidence_bundle.json`: Bundle determinista de evidencia exportado desde REA + Ghidra 12.1.4.
- `FASE_1_2_REPORTE.md`, `FASE_3_REPORTE.md`, `FASE_4_REPORTE.md`: Reportes de investigación incremental.

---

## Compilación y Ejecución

```powershell
dotnet build SuperMarioBros_Win11/SuperMarioBros_Win11.csproj -c Release
.\SuperMarioBros_Win11\bin\Release\net6.0-windows\SuperMarioBros_Win11.exe
```
