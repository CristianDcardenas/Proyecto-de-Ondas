using Telegram.Bot.Types.ReplyMarkups;

namespace Proyecto_de_Ondas
{
    public static class WaveData
    {
        public static class Responses
        {
            public static readonly string WelcomeMessage =
                "🌊 *¡Explora las Ondas Electromagnéticas!* 🌊\n" +
                "Descubre temas como definición, tipos, propiedades y más con un menú interactivo.\n" +
                "Usa /help para ver los comandos disponibles.";

            public static readonly string HelpMessage =
                "ℹ️ *Comandos Disponibles*\n" +
                "- /start: Menú principal interactivo.\n" +
                "- /help: Muestra esta ayuda.\n" +
                "- /info: Información sobre el bot.\n" +
                "Selecciona los botones para explorar.";

            public static readonly string InfoMessage =
                "📖 *Sobre el Bot*\n" +
                "Bot educativo sobre ondas electromagnéticas, creado en C# (.NET Framework 4.7.2). " +
                "Ofrece información detallada con menús interactivos.";

            public static readonly string UnknownCommand =
                "❓ *Comando no reconocido.*\nUsa /start para el menú principal o /help para ayuda.";

            // Definición
            public static readonly string Definition_Overview =
                "📚 *Definición: General*\n" +
                "Las ondas electromagnéticas son perturbaciones que propagan energía mediante campos eléctricos y magnéticos oscilantes.";
            public static readonly string Definition_History =
                "📚 *Definición: Historia*\n" +
                "Predichas por Maxwell en 1864 y confirmadas por Hertz en 1887, son clave para la luz y telecomunicaciones.";
            public static readonly string Definition_Characteristics =
                "📚 *Definición: Características*\n" +
                "Ondas transversales, velocidad de la luz (c = 299,792,458 m/s) en el vacío, no necesitan medio.";

            // Tipos
            public static readonly string Types_Overview =
                "📡 *Tipos: General*\n" +
                "El espectro electromagnético clasifica ondas por frecuencia (f) y longitud de onda (λ), con c = f·λ.";
            public static readonly string Types_RadioWaves =
                "📡 *Tipos: Ondas de Radio*\n" +
                "Frecuencia: 3 Hz - 3 GHz, λ: 100 km - 10 cm. Usadas en radio AM/FM, TV, Wi-Fi.";
            public static readonly string Types_Microwaves =
                "📡 *Tipos: Microondas*\n" +
                "Frecuencia: 3 GHz - 300 GHz, λ: 10 cm - 1 mm. Hornos, radares, satélites.";
            public static readonly string Types_Infrared =
                "📡 *Tipos: Infrarrojo*\n" +
                "Frecuencia: 300 GHz - 430 THz, λ: 1 mm - 700 nm. Controles remotos, sensores térmicos.";
            public static readonly string Types_VisibleLight =
                "📡 *Tipos: Luz Visible*\n" +
                "Frecuencia: 430 THz - 770 THz, λ: 700 nm - 400 nm. Colores del rojo al violeta.";
            public static readonly string Types_Ultraviolet =
                "📡 *Tipos: Ultravioleta*\n" +
                "Frecuencia: 770 THz - 30 PHz, λ: 400 nm - 10 nm. Bronceado, esterilización.";
            public static readonly string Types_XRays =
                "📡 *Tipos: Rayos X*\n" +
                "Frecuencia: 30 PHz - 30 EHz, λ: 10 nm - 0.01 nm. Radiografías, tomografías.";
            public static readonly string Types_GammaRays =
                "📡 *Tipos: Rayos Gamma*\n" +
                "Frecuencia: > 30 EHz, λ: < 0.01 nm. Radioterapia, esterilización médica.";

            // Propiedades
            public static readonly string Properties_Overview =
                "⚙️ *Propiedades: General*\n" +
                "Las ondas electromagnéticas tienen características que determinan su comportamiento.";
            public static readonly string Properties_Frequency =
                "⚙️ *Propiedades: Frecuencia*\n" +
                "Número de oscilaciones por segundo (Hz). Determina la energía: E = h·f.";
            public static readonly string Properties_Wavelength =
                "⚙️ *Propiedades: Longitud de Onda*\n" +
                "Distancia entre picos consecutivos (m). Relacionada con frecuencia: c = f·λ.";
            public static readonly string Properties_Speed =
                "⚙️ *Propiedades: Velocidad*\n" +
                "En el vacío: c = 299,792,458 m/s. En medios, se reduce por el índice de refracción.";
            public static readonly string Properties_Energy =
                "⚙️ *Propiedades: Energía*\n" +
                "Proporcional a la frecuencia: E = h·f, con h = 6.626x10^-34 J·s.";
            public static readonly string Properties_Amplitude =
                "⚙️ *Propiedades: Amplitud*\n" +
                "Determina la intensidad, proporcional al cuadrado del campo eléctrico.";
            public static readonly string Properties_Transversal =
                "⚙️ *Propiedades: Naturaleza Transversal*\n" +
                "Campos E y B oscilan perpendicularmente a la dirección de propagación.";
            public static readonly string Properties_Vacuum =
                "⚙️ *Propiedades: Propagación en el Vacío*\n" +
                "No requieren medio material, a diferencia de ondas mecánicas.";

            // Ecuaciones
            public static readonly string Equations_Overview =
                "📝 *Ecuaciones: General*\n" +
                "Las ondas electromagnéticas se describen con ecuaciones que relacionan sus propiedades.";
            public static readonly string Equations_Speed =
                "📝 *Ecuaciones: Velocidad*\n" +
                "c = f·λ, donde c es la velocidad de la luz, f la frecuencia y λ la longitud de onda.";
            public static readonly string Equations_Energy =
                "📝 *Ecuaciones: Energía*\n" +
                "E = h·f, donde h = 6.626x10^-34 J·s y f es la frecuencia.";
            public static readonly string Equations_Maxwell =
                "📝 *Ecuaciones: Maxwell*\n" +
                "∇·E = 0, ∇·B = 0, ∇×E = -∂B/∂t, ∇×B = μ₀ε₀∂E/∂t. Describen la propagación.";

            // Aplicaciones
            public static readonly string Applications_Overview =
                "🚀 *Aplicaciones: General*\n" +
                "Las ondas electromagnéticas tienen usos en tecnología y medicina.";
            public static readonly string Applications_RadioWaves =
                "🚀 *Aplicaciones: Ondas de Radio*\n" +
                "Transmisiones AM/FM, Wi-Fi (2.4/5 GHz), Bluetooth, radar meteorológico.";
            public static readonly string Applications_Microwaves =
                "🚀 *Aplicaciones: Microondas*\n" +
                "Hornos (2.45 GHz), satélites, radar de tráfico, redes 5G.";
            public static readonly string Applications_Infrared =
                "🚀 *Aplicaciones: Infrarrojo*\n" +
                "Sensores de movimiento, termografía, controles remotos.";
            public static readonly string Applications_VisibleLight =
                "🚀 *Aplicaciones: Luz Visible*\n" +
                "Iluminación LED, láseres quirúrgicos, pantallas OLED.";
            public static readonly string Applications_Ultraviolet =
                "🚀 *Aplicaciones: Ultravioleta*\n" +
                "Esterilización médica, purificación de agua, análisis forense.";
            public static readonly string Applications_XRays =
                "🚀 *Aplicaciones: Rayos X*\n" +
                "Radiografías, tomografías, inspección de equipaje.";
            public static readonly string Applications_GammaRays =
                "🚀 *Aplicaciones: Rayos Gamma*\n" +
                "Radioterapia, esterilización, imágenes PET.";

            // Polarización
            public static readonly string Polarization_Overview =
                "🔄 *Polarización: General*\n" +
                "Describe la orientación del campo eléctrico de una onda electromagnética.";
            public static readonly string Polarization_Linear =
                "🔄 *Polarización: Lineal*\n" +
                "Campo eléctrico oscila en un solo plano. Usado en antenas de radio/TV.";
            public static readonly string Polarization_Circular =
                "🔄 *Polarización: Circular*\n" +
                "Campo eléctrico rota en un círculo. Común en comunicaciones satelitales.";
            public static readonly string Polarization_Elliptical =
                "🔄 *Polarización: Elíptica*\n" +
                "Combinación de lineal y circular. Usada en óptica avanzada.";

            // Propagación
            public static readonly string Propagation_Overview =
                "🌐 *Propagación: General*\n" +
                "Las ondas electromagnéticas se propagan distinto según el medio.";
            public static readonly string Propagation_Vacuum =
                "🌐 *Propagación: Vacío*\n" +
                "Viajan a c = 299,792,458 m/s sin pérdidas.";
            public static readonly string Propagation_Air =
                "🌐 *Propagación: Aire*\n" +
                "Velocidad cercana a c, con mínima atenuación.";
            public static readonly string Propagation_Materials =
                "🌐 *Propagación: Materiales*\n" +
                "Velocidad reducida por el índice de refracción (n). Ej.: agua n ≈ 1.33.";
            public static readonly string Propagation_Phenomena =
                "🌐 *Propagación: Fenómenos*\n" +
                "Reflexión (espejos), refracción (lentes), dispersión (arcoíris), absorción.";

            // Espectro
            public static readonly string Spectrum_Overview =
                "📊 *Espectro: General*\n" +
                "El espectro electromagnético abarca todas las ondas, ordenadas por frecuencia.";
            public static readonly string Spectrum_RadioWaves =
                "📊 *Espectro: Ondas de Radio*\n" +
                "< 3 GHz, λ > 10 cm. Usadas en telecomunicaciones.";
            public static readonly string Spectrum_Microwaves =
                "📊 *Espectro: Microondas*\n" +
                "3 GHz - 300 GHz, λ 10 cm - 1 mm. Radares, hornos.";
            public static readonly string Spectrum_Infrared =
                "📊 *Espectro: Infrarrojo*\n" +
                "300 GHz - 430 THz, λ 1 mm - 700 nm. Sensores térmicos.";
            public static readonly string Spectrum_VisibleLight =
                "📊 *Espectro: Luz Visible*\n" +
                "430 THz - 770 THz, λ 700 nm - 400 nm. Colores rojo a violeta.";
            public static readonly string Spectrum_Ultraviolet =
                "📊 *Espectro: Ultravioleta*\n" +
                "770 THz - 30 PHz, λ 400 nm - 10 nm. Esterilización.";
            public static readonly string Spectrum_XRays =
                "📊 *Espectro: Rayos X*\n" +
                "30 PHz - 30 EHz, λ 10 nm - 0.01 nm. Imágenes médicas.";
            public static readonly string Spectrum_GammaRays =
                "📊 *Espectro: Rayos Gamma*\n" +
                "> 30 EHz, λ < 0.01 nm. Aplicaciones nucleares.";
        }

        public static InlineKeyboardMarkup GetMainMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("📚 Definición", "definition_menu") },
                new[] { InlineKeyboardButton.WithCallbackData("📡 Tipos", "types_menu") },
                new[] { InlineKeyboardButton.WithCallbackData("⚙️ Propiedades", "properties_menu") },
                new[] { InlineKeyboardButton.WithCallbackData("📝 Ecuaciones", "equations_menu") },
                new[] { InlineKeyboardButton.WithCallbackData("🚀 Aplicaciones", "applications_menu") },
                new[] { InlineKeyboardButton.WithCallbackData("🔄 Polarización", "polarization_menu") },
                new[] { InlineKeyboardButton.WithCallbackData("🌐 Propagación", "propagation_menu") },
                new[] { InlineKeyboardButton.WithCallbackData("📊 Espectro", "spectrum_menu") }
            });
        }

        public static InlineKeyboardMarkup GetDefinitionSubMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("ℹ️ General", "definition_overview") },
                new[] { InlineKeyboardButton.WithCallbackData("📜 Historia", "definition_history") },
                new[] { InlineKeyboardButton.WithCallbackData("🔍 Características", "definition_characteristics") },
                new[] { InlineKeyboardButton.WithCallbackData("🔙 Volver al Menú", "main_menu") }
            });
        }

        public static InlineKeyboardMarkup GetTypesSubMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("ℹ️ General", "types_overview") },
                new[] { InlineKeyboardButton.WithCallbackData("📻 Ondas de Radio", "types_radio") },
                new[] { InlineKeyboardButton.WithCallbackData("🍽️ Microondas", "types_microwaves") },
                new[] { InlineKeyboardButton.WithCallbackData("🔥 Infrarrojo", "types_infrared") },
                new[] { InlineKeyboardButton.WithCallbackData("🌈 Luz Visible", "types_visible") },
                new[] { InlineKeyboardButton.WithCallbackData("☀️ Ultravioleta", "types_ultraviolet") },
                new[] { InlineKeyboardButton.WithCallbackData("🩻 Rayos X", "types_xrays") },
                new[] { InlineKeyboardButton.WithCallbackData("☢️ Rayos Gamma", "types_gamma") },
                new[] { InlineKeyboardButton.WithCallbackData("🔙 Volver al Menú", "main_menu") }
            });
        }

        public static InlineKeyboardMarkup GetPropertiesSubMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("ℹ️ General", "properties_overview") },
                new[] { InlineKeyboardButton.WithCallbackData("📈 Frecuencia", "properties_frequency") },
                new[] { InlineKeyboardButton.WithCallbackData("📏 Longitud de Onda", "properties_wavelength") },
                new[] { InlineKeyboardButton.WithCallbackData("💨 Velocidad", "properties_speed") },
                new[] { InlineKeyboardButton.WithCallbackData("⚡ Energía", "properties_energy") },
                new[] { InlineKeyboardButton.WithCallbackData("📐 Amplitud", "properties_amplitude") },
                new[] { InlineKeyboardButton.WithCallbackData("↔️ Naturaleza Transversal", "properties_transversal") },
                new[] { InlineKeyboardButton.WithCallbackData("🌌 Propagación en el Vacío", "properties_vacuum") },
                new[] { InlineKeyboardButton.WithCallbackData("🔙 Volver al Menú", "main_menu") }
            });
        }

        public static InlineKeyboardMarkup GetEquationsSubMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("ℹ️ General", "equations_overview") },
                new[] { InlineKeyboardButton.WithCallbackData("💨 Velocidad", "equations_speed") },
                new[] { InlineKeyboardButton.WithCallbackData("⚡ Energía", "equations_energy") },
                new[] { InlineKeyboardButton.WithCallbackData("🧮 Maxwell", "equations_maxwell") },
                new[] { InlineKeyboardButton.WithCallbackData("🔙 Volver al Menú", "main_menu") }
            });
        }

        public static InlineKeyboardMarkup GetApplicationsSubMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("ℹ️ General", "applications_overview") },
                new[] { InlineKeyboardButton.WithCallbackData("📻 Ondas de Radio", "applications_radio") },
                new[] { InlineKeyboardButton.WithCallbackData("🍽️ Microondas", "applications_microwaves") },
                new[] { InlineKeyboardButton.WithCallbackData("🔥 Infrarrojo", "applications_infrared") },
                new[] { InlineKeyboardButton.WithCallbackData("🌈 Luz Visible", "applications_visible") },
                new[] { InlineKeyboardButton.WithCallbackData("☀️ Ultravioleta", "applications_ultraviolet") },
                new[] { InlineKeyboardButton.WithCallbackData("🩻 Rayos X", "applications_xrays") },
                new[] { InlineKeyboardButton.WithCallbackData("☢️ Rayos Gamma", "applications_gamma") },
                new[] { InlineKeyboardButton.WithCallbackData("🔙 Volver al Menú", "main_menu") }
            });
        }

        public static InlineKeyboardMarkup GetPolarizationSubMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("ℹ️ General", "polarization_overview") },
                new[] { InlineKeyboardButton.WithCallbackData("➡️ Lineal", "polarization_linear") },
                new[] { InlineKeyboardButton.WithCallbackData("🔄 Circular", "polarization_circular") },
                new[] { InlineKeyboardButton.WithCallbackData("🌀 Elíptica", "polarization_elliptical") },
                new[] { InlineKeyboardButton.WithCallbackData("🔙 Volver al Menú", "main_menu") }
            });
        }

        public static InlineKeyboardMarkup GetPropagationSubMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("ℹ️ General", "propagation_overview") },
                new[] { InlineKeyboardButton.WithCallbackData("🌌 Vacío", "propagation_vacuum") },
                new[] { InlineKeyboardButton.WithCallbackData("💨 Aire", "propagation_air") },
                new[] { InlineKeyboardButton.WithCallbackData("🪨 Materiales", "propagation_materials") },
                new[] { InlineKeyboardButton.WithCallbackData("🌈 Fenómenos", "propagation_phenomena") },
                new[] { InlineKeyboardButton.WithCallbackData("🔙 Volver al Menú", "main_menu") }
            });
        }

        public static InlineKeyboardMarkup GetSpectrumSubMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[] { InlineKeyboardButton.WithCallbackData("ℹ️ General", "spectrum_overview") },
                new[] { InlineKeyboardButton.WithCallbackData("📻 Ondas de Radio", "spectrum_radio") },
                new[] { InlineKeyboardButton.WithCallbackData("🍽️ Microondas", "spectrum_microwaves") },
                new[] { InlineKeyboardButton.WithCallbackData("🔥 Infrarrojo", "spectrum_infrared") },
                new[] { InlineKeyboardButton.WithCallbackData("🌈 Luz Visible", "spectrum_visible") },
                new[] { InlineKeyboardButton.WithCallbackData("☀️ Ultravioleta", "spectrum_ultraviolet") },
                new[] { InlineKeyboardButton.WithCallbackData("🩻 Rayos X", "spectrum_xrays") },
                new[] { InlineKeyboardButton.WithCallbackData("☢️ Rayos Gamma", "spectrum_gamma") },
                new[] { InlineKeyboardButton.WithCallbackData("🔙 Volver al Menú", "main_menu") }
            });
        }
    }
}