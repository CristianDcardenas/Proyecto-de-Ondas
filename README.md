# 🌊 Proyecto de Ondas

**Proyecto de Ondas** es un bot educativo de Telegram [@EspectroBot](https://t.me/EspectroBot) diseñado para enseñar de forma interactiva sobre **ondas electromagnéticas**. Desarrollado en **C# con .NET Framework 4.7.2**, ofrece un menú organizado con botones intuitivos y emojis personalizados para facilitar el aprendizaje de conceptos como definición, tipos, propiedades, ecuaciones, aplicaciones, polarización, propagación y el espectro electromagnético.

> 📚 ¡Explora el fascinante mundo de las ondas con una experiencia visual atractiva y navegación intuitiva!

---

## 📖 Descripción

Este bot de Telegram guía a los usuarios a través de un menú interactivo, donde cada categoría (como `Tipos` o `Propiedades`) tiene submenús específicos (por ejemplo, `Ondas de Radio`, `Frecuencia`). El contenido está dividido en fragmentos breves para facilitar su comprensión, y cada sección incluye un botón **🔙 Volver al Menú** para regresar fácilmente al inicio.

- 🧠 Ideal para estudiantes, docentes o cualquier persona interesada en física y telecomunicaciones.
- 🧩 Ejecutado como una aplicación de consola.
- 🤖 Basado en la biblioteca `Telegram.Bot v19.0.0`.

---

## ✨ Características

- 📂 **Menú interactivo** con 8 categorías temáticas.
- 🎨 **Botones con iconos personalizados** (ej: 📝 Ecuaciones, 🚀 Aplicaciones).
- 🧾 **Información segmentada** para facilitar la lectura.
- 🔁 **Navegación fluida** con opción de volver al menú en cada submenú.
- 🧵 **Soporte para comandos**: `/start`, `/help`, `/info`.
- 🧹 **Limpieza automática del chat** al manejar respuestas de botones.
- 🖥️ **Ejecución desde consola**, sin interfaz gráfica.

---

## 🚀 Instalación

### 🔧 Prerrequisitos

- .NET Framework 4.7.2
- Visual Studio 2019/2022 o Visual Studio Code
- Cuenta de Telegram y token de bot (obtenido desde [@BotFather](https://t.me/BotFather))
- Dependencias:
  - `Telegram.Bot v19.0.0`
  - `Newtonsoft.Json v13.0.3`

### 📦 Pasos

1. **Clona el repositorio:**

```bash
git clone https://github.com/tu-usuario/proyecto-de-ondas.git
cd Proyecto-de-Ondas
```

2. **Configura el token del bot:**

Edita `BotConfig.cs` y reemplaza el valor del token:

```csharp
public static readonly string BotToken = "TU_TOKEN_AQUÍ";
```

3. **Instala las dependencias (si usas terminal):**

```bash
dotnet add package Telegram.Bot --version 19.0.0
dotnet add package Newtonsoft.Json --version 13.0.3
```

4. **Compila y ejecuta:**

- Abre el proyecto en Visual Studio.
- Presiona `Ctrl + Shift + B` para compilar.
- Presiona `F5` para ejecutar.

La consola mostrará: `Bot iniciado. Presiona Enter para detenerlo...`

5. **Configura el texto “About” del bot (en Telegram):**

- Ve a [@BotFather](https://t.me/BotFather)
- Comando `/mybots` > selecciona tu bot > `Edit Bot` > `Edit About`
- Texto sugerido:

```text
🌊 Aprende sobre ondas electromagnéticas. ¡Menú interactivo! /start @EspectroBot
```

(Reemplaza `@EspectroBot` si tu bot tiene otro nombre)

---

## 📚 Uso

1. Abre Telegram y busca tu bot (ej: `@EspectroBot`)
2. Envía `/start` para iniciar el menú principal:

```
📚 Definición
📡 Tipos
⚙️ Propiedades
📝 Ecuaciones
🚀 Aplicaciones
🔄 Polarización
🌐 Propagación
📊 Espectro
```

3. Al seleccionar una categoría, se abre un submenú. Ejemplo de “Tipos”:

```
📻 Ondas de Radio
🍽️ Microondas
🔥 Infrarrojo
🌈 Luz Visible
☀️ Ultravioleta
🩻 Rayos X
☢️ Rayos Gamma
🔙 Volver al Menú
```

4. Usa `/help` para ver los comandos disponibles y `/info` para más información.

---

## 🗂️ Estructura del Proyecto

```
Proyecto_de_Ondas/
├── BotConfig.cs         # Token del bot
├── Program.cs           # Punto de entrada
├── WaveData.cs          # Datos y menús del bot
├── WaveService.cs       # Lógica del bot
├── Proyecto_de_Ondas.csproj
└── README.md            # Este archivo
```

---

## 🛠️ Dependencias

- `Telegram.Bot` v19.0.0  
- `Newtonsoft.Json` v13.0.3  
- `.NET Framework` 4.7.2  

---

## 🤝 Contribuir

¡Las contribuciones son bienvenidas! ✨

### Cómo hacerlo:

1. Haz un **fork** del repositorio.
2. Crea una nueva rama:

```bash
git checkout -b mi-nueva-funcionalidad
```

3. Realiza tus cambios y haz commit:

```bash
git commit -m "Agrega nueva funcionalidad X"
```

4. Sube tus cambios:

```bash
git push origin mi-nueva-funcionalidad
```

5. Abre un **Pull Request** con la descripción de tus cambios.

### Ideas para contribuir:

- Agregar nuevas secciones al bot (ej. ejemplos prácticos).
- Mejorar o traducir los textos.
- Agregar más emojis o reorganizar el menú.
- Implementar pruebas unitarias.

---

## 🐛 Reportar errores

Si encuentras un error:

- Abre un **issue** en GitHub con:
  - Descripción del problema
  - Pasos para reproducirlo
  - Capturas de pantalla (si aplica)
  - Mensajes de error

---

## 📜 Licencia

Este proyecto está bajo la **Licencia MIT**.  
Puedes usarlo, modificarlo y distribuirlo libremente.

---

## 📬 Contacto

- **Creador**: [Tu Nombre o Alias]  
- **Telegram**: [@EspectroBot](https://t.me/EspectroBot)

---

> 🌊 Aprende sobre ondas electromagnéticas con [@EspectroBot](https://t.me/EspectroBot)
