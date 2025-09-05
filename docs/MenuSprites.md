# Sombras Gran Colombia – Sprites del Menú

## 📂 Carpeta
`SombrasGranColombia/Assets/Sprites/Menu/`

---

## 🖼️ Sprites actuales

| Sprite        | Resolución | Uso previsto       | Notas                      |
|---------------|------------|-------------------|---------------------------|
| **bg_menu.png**   | 1920×1080  | Fondo del menú principal | Pixel-art, paleta 16 colores |
| **btn_start.png** | 256×64    | Botón **Iniciar Juego**  | Estado base (idle)         |
| **btn_options.png** | 256×64  | Botón **Opciones**       | Mismo estilo que start     |
| **btn_exit.png**   | 256×64  | Botón **Salir**          | Ícono puerta opcional      |
| **cursor.png**     | 32×32   | Cursor personalizado     | Se puede animar en 2-3 frames |

---

## 🎯 Pendientes de arte
- Crear frames de animación para botones (hover / click).
- Ajustar paleta para accesibilidad visual.
- Exportar en **PNG** sin fondo (transparencia).

---

## 🔎 Notas de integración
- Todos los PNG deben importarse en Unity con:
  - **Pixels Per Unit:** 16 (o la unidad que uses en el proyecto).
  - **Filter Mode:** Point (sin suavizado).
  - **Compression:** None (para evitar pérdida de detalle).

---

> Documento de referencia para mantener consistencia visual del menú.
