# 🌊 Proyecto de Ondas

[![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-blue)](https://dotnet.microsoft.com/)
[![Telegram Bot](https://img.shields.io/badge/Telegram-Bot-blue?logo=telegram)](https://core.telegram.org/bots/api)

**Proyecto de Ondas** es un bot educativo de Telegram (`@EspectroBot`) diseñado para enseñar sobre **ondas electromagnéticas** de forma interactiva. Desarrollado en **C#** con **.NET Framework 4.7.2**, ofrece menús y submenús con información segmentada sobre definición, tipos, propiedades, ecuaciones, aplicaciones, polarización, propagación y espectro electromagnético. ¡Explora el fascinante mundo de las ondas con una experiencia de usuario intuitiva y botones con iconos personalizados! 📚📡⚙️

## 📖 Descripción

Este proyecto implementa un bot de Telegram que permite a los usuarios aprender sobre ondas electromagnéticas a través de un **menú interactivo**. Cada categoría (como Tipos o Propiedades) tiene submenús con secciones específicas (por ejemplo, Ondas de Radio, Frecuencia), accesibles mediante botones con emojis temáticos (📻, 🌈, ⚡). La información está organizada en fragmentos cortos para facilitar la comprensión, y la navegación incluye un botón **"🔙 Volver al Menú"** para regresar al menú principal.

El bot se ejecuta como una **aplicación de consola** y utiliza la biblioteca `Telegram.Bot` v19.0.0 para interactuar con la API de Telegram. Es ideal para estudiantes, educadores o cualquier persona interesada en física y telecomunicaciones.

## ✨ Características

- **Menú Interactivo**: Explora 8 categorías principales con submenús detallados.
- **Iconos Personalizados**: Botones con emojis que reflejan el contenido (📝 para Ecuaciones, 🚀 para Aplicaciones).
- **Información Segmentada**: Contenido dividido en secciones cortas y específicas.
- **Navegación Intuitiva**: Botón "🔙 Volver al Menú" en cada submenú.
- **Comandos**: Soporta `/start`, `/help`, y `/info` para una experiencia completa.
- **Limpieza de Chat**: Elimina mensajes anteriores al responder callbacks.
- **Consola**: Ejecuta el bot desde una aplicación de consola sin interfaces gráficas.

## 🚀 Instalación

Sigue estos pasos para configurar y ejecutar el proyecto localmente.

### Prerrequisitos

- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- Visual Studio 2019/2022 o Visual Studio Code
- Una cuenta de Telegram y un token de bot (obtén uno con [@BotFather](https://t.me/BotFather))
- Dependencias:
  - `Telegram.Bot` v19.0.0
  - `Newtonsoft.Json` v13.0.3

### Pasos

1. **Clona el Repositorio**

   ```bash
   git clone https://github.com/tu-usuario/proyecto-de-ondas.git
   cd proyecto-de-ondas
Configura el Token del Bot

Abre BotConfig.cs y reemplaza el token con el tuyo, obtenido de @BotFather:

csharp

Copiar
public static readonly string BotToken = "TU_TOKEN_AQUÍ";
Instala las Dependencias

Usa NuGet Package Manager en Visual Studio o ejecuta en la terminal:

juerga

Copiar
dotnet add package Telegram.Bot --version 19.0.0
dotnet add package Newtonsoft.Json --version 13.0.3
Compila y Ejecuta

Abre el proyecto en Visual Studio.
Compila la solución (Ctrl+Shift+B).
Ejecuta el programa (F5); la consola mostrará: Bot iniciado. Presiona Enter para detenerlo....
Configura el Texto "About" en Telegram

Ve a @BotFather en Telegram.

Usa /mybots, selecciona tu bot, luego Edit Bot > Edit About.

Pega:

text

Copiar
🌊 Aprende sobre ondas electromagnéticas. ¡Menú interactivo! /start @EspectroBot
Reemplaza @EspectroBot con el nombre de tu bot si es diferente.

Prueba el Bot

Abre Telegram, busca tu bot (por ejemplo, @EspectroBot), y envía /start.
Explora los menús y submenús con los botones.
📚 Uso
Inicia el bot con /start para ver el menú principal:

📚 Definición
📡 Tipos
⚙️ Propiedades
📝 Ecuaciones
🚖 Aplicaciones
🔄 Polarización
🌐 Propagación
📊 Espectro
Selecciona una categoría para acceder a su submenú. Por ejemplo, "Tipos" muestra:

i️ General
📻 Ondas de Radio
🍽️ Microondas
🔥 Infrarrojo
🌈 Luz Visible
☀️ Ultravioleta
🩻 Rayos X
☢️ Rayos Gamma
🔙 Volver al Menú
Usa /help para ver los comandos disponibles o /info para información sobre el bot.

Navega con los botones y regresa al menú principal con " 🔙 Volver al Menú".

🗂️ Estructura del Proyecto
Plaintext

Copiar
Proyecto_de_Ondas/
├── BotConfig.cs         # Configuración del token del bot
├── Program.cs           # Punto de entrada de la aplicación de consola
├── WaveData.cs          # Respuestas y menús del bot
├── WaveService.cs       # Lógica para procesar comandos y callbacks
├── Proyecto_de_Ondas.csproj  # Archivo de proyecto
└── README.md            # Documentación del proyecto
🛠️ Dependencias
Telegram.Bot: v19.0.0 (NuGet)
Newtonsoft.Json: v13.0.3 (NuGet)
.NET Framework: 4.7.2
🤝 Contribuir
¡Las contribuciones son bienvenidas! Sigue estos pasos:

Haz un fork del repositorio.

Crea una rama para tu cambio:

juerga

Copiar
git checkout -b mi-nueva-funcionalidad
Realiza tus cambios y haz commit:

juerga

Copiar
git commit -m "Agrega nueva funcionalidad X"
Sube los cambios a tu fork:

juerga

Copiar
git push origin mi-nueva-funcionalidad
Abre un Pull Request en GitHub con una descripción clara de tus cambios.

Ideas para Contribuir
Agregar nuevas secciones al bot (por ejemplo, ejemplos prácticos).
Mejorar los textos de las respuestas o traducir a otros idiomas.
Optimizar la navegación o agregar más iconos.
Implementar pruebas unitarias.
🐛 Reportar errores
Si encuentras un problema, abre un issue en GitHub con:

Descripción del error.
Pasos para reproducirlo.
Capturas de pantalla (si aplica).
Mensajes de error de la consola.
📜 Licencia
Este proyecto está bajo la Licencia MIT. Siéntete libre de usarlo, modificarlo y distribuirlo.

📬 Contacto
Creador: [Tu Nombre o Alias] (coloca tu contacto, por ejemplo, correo o Telegram)
Bot: @EspectroBot (prueba el bot en Telegram)
