using Telegram.Bot.Types.ReplyMarkups;

namespace Proyecto_de_Ondas
{
    public static class WaveData
    {
        public static class Responses
        {
            public static readonly string WelcomeMessage =
                "🌊 *¡Explora el Fascinante Mundo de las Ondas Electromagnéticas!* 🌊\n" +
                "Este bot te ofrece información detallada y precisa sobre las ondas electromagnéticas.\n" +
                "Usa el menú interactivo para explorar temas como definición, tipos, propiedades, ecuaciones, aplicaciones, y más.\n" +
                "Escribe /help para ver los comandos disponibles.";

            public static readonly string HelpMessage =
                "ℹ️ *Comandos Disponibles*\n" +
                "- /start: Muestra el menú principal con temas interactivos.\n" +
                "- /help: Muestra esta ayuda.\n" +
                "- /info: Información técnica sobre el bot.\n" +
                "Usa los botones del menú para explorar temas específicos.";

            public static readonly string InfoMessage =
                "📖 *Sobre el Bot*\n" +
                "Desarrollado para el proyecto de ondas electromagnéticas, este bot proporciona información educativa precisa sobre " +
                "la física de las ondas electromagnéticas, incluyendo su definición, tipos, propiedades, ecuaciones, aplicaciones, polarización, " +
                "propagación y el espectro electromagnético.\n" +
                "Creado en C# con .NET Framework 4.7.2.";

            public static readonly string Definition =
                "📚 *Definición de Ondas Electromagnéticas*\n" +
                "Las ondas electromagnéticas son perturbaciones que propagan energía a través de campos eléctricos (E) y magnéticos (B) oscilantes, " +
                "perpendiculares entre sí y a la dirección de propagación, formando una onda transversal. Viajan a la velocidad de la luz en el vacío " +
                "(c = 299,792,458 m/s) y no requieren un medio material para propagarse. Fueron predichas por James Clerk Maxwell y confirmadas experimentalmente " +
                "por Heinrich Hertz en 1887. Estas ondas son fundamentales para fenómenos como la luz, las señales de radio y los rayos X.";

            public static readonly string Types =
                "📡 *Tipos de Ondas Electromagnéticas*\n" +
                "El espectro electromagnético se clasifica según la frecuencia (f) o longitud de onda (λ), relacionadas por c = f·λ:\n" +
                "1. *Ondas de radio* (f: 3 Hz - 3 GHz, λ: 100 km - 10 cm): Usadas en radio AM/FM, televisión, Wi-Fi (2.4 GHz o 5 GHz).\n" +
                "2. *Microondas* (f: 3 GHz - 300 GHz, λ: 10 cm - 1 mm): Hornos microondas, radares, comunicaciones satelitales.\n" +
                "3. *Infrarrojo* (f: 300 GHz - 430 THz, λ: 1 mm - 700 nm): Controles remotos, sensores térmicos, espectroscopia.\n" +
                "4. *Luz visible* (f: 430 THz - 770 THz, λ: 700 nm - 400 nm): Colores del rojo al violeta, esencial para la visión y la fotografía.\n" +
                "5. *Ultravioleta (UV)* (f: 770 THz - 30 PHz, λ: 400 nm - 10 nm): Bronceado, esterilización, fluorescencia.\n" +
                "6. *Rayos X* (f: 30 PHz - 30 EHz, λ: 10 nm - 0.01 nm): Radiografías, tomografías computadas, análisis de materiales.\n" +
                "7. *Rayos gamma* (f: > 30 EHz, λ: < 0.01 nm): Radioterapia, esterilización médica, estudios astrofísicos.";

            public static readonly string Properties =
                "⚙️ *Propiedades de las Ondas Electromagnéticas*\n" +
                "- *Frecuencia (f)*: Número de oscilaciones por segundo, en hercios (Hz). Determina la energía de la onda.\n" +
                "- *Longitud de onda (λ)*: Distancia entre dos picos consecutivos, en metros (m). Relacionada con la frecuencia por c = f·λ.\n" +
                "- *Velocidad (c)*: En el vacío, siempre es 299,792,458 m/s. En otros medios, se reduce según el índice de refracción (n).\n" +
                "- *Energía*: Proporcional a la frecuencia, dada por E = h·f, donde h = 6.626x10^-34 J·s (constante de Planck).\n" +
                "- *Amplitud*: Determina la intensidad de la onda, proporcional al cuadrado de la amplitud del campo eléctrico.\n" +
                "- *Naturaleza transversal*: Los campos E y B oscilan perpendicularmente a la dirección de propagación.\n" +
                "- *Propagación en el vacío*: No requieren medio material, a diferencia de las ondas mecánicas.";

            public static readonly string Equations =
                "📝 *Ecuaciones Fundamentales*\n" +
                "Las ondas electromagnéticas se describen mediante las ecuaciones de Maxwell y otras relaciones:\n" +
                "1. *Velocidad de la onda*: c = f·λ, donde c es la velocidad de la luz, f es la frecuencia y λ es la longitud de onda.\n" +
                "2. *Energía de un fotón*: E = h·f, donde h = 6.626x10^-34 J·s (constante de Planck).\n" +
                "3. *Ecuaciones de Maxwell* (en el vacío):\n" +
                "   - ∇·E = 0 (Divergencia del campo eléctrico es cero).\n" +
                "   - ∇·B = 0 (Divergencia del campo magnético es cero).\n" +
                "   - ∇×E = -∂B/∂t (Ley de Faraday: variación de B induce E).\n" +
                "   - ∇×B = μ₀ε₀∂E/∂t (Ley de Ampère-Maxwell: variación de E induce B).\n" +
                "Estas ecuaciones describen cómo los campos eléctricos y magnéticos se generan mutuamente, permitiendo la propagación de ondas electromagnéticas.";

            public static readonly string Applications =
                "🚀 *Aplicaciones Prácticas*\n" +
                "- *Ondas de radio*: Transmisiones AM (540-1600 kHz), FM (88-108 MHz), Wi-Fi (2.4 GHz/5 GHz), Bluetooth, radar meteorológico.\n" +
                "- *Microondas*: Hornos (2.45 GHz), satélites de comunicación, radar de tráfico, redes 5G.\n" +
                "- *Infrarrojo*: Sensores de movimiento, termografía, controles remotos, espectroscopia infrarroja.\n" +
                "- *Luz visible*: Iluminación LED, láseres quirúrgicos, fotografía, pantallas OLED.\n" +
                "- *Ultravioleta*: Esterilización de equipos médicos, lámparas UV para purificación de agua, análisis forense.\n" +
                "- *Rayos X*: Radiografías, tomografías computadas (CT), inspección de equipaje en aeropuertos.\n" +
                "- *Rayos gamma*: Radioterapia para tratar el cáncer, esterilización de instrumentos quirúrgicos, imágenes PET.";

            public static readonly string Polarization =
                "🔄 *Polarización de las Ondas Electromagnéticas*\n" +
                "La polarización describe la orientación del campo eléctrico de una onda electromagnética. Tipos principales:\n" +
                "- *Lineal*: El campo eléctrico oscila en un solo plano (por ejemplo, horizontal o vertical). Usado en antenas de radio y TV.\n" +
                "- *Circular*: El campo eléctrico rota en un círculo, con sentido horario o antihorario. Común en comunicaciones satelitales.\n" +
                "- *Elíptica*: Combinación de lineal y circular, usada en aplicaciones avanzadas como óptica.\n" +
                "La polarización es crucial en tecnologías como gafas 3D, filtros fotográficos y comunicaciones inalámbricas, ya que afecta la recepción de señales.";

            public static readonly string Propagation =
                "🌐 *Propagación de las Ondas Electromagnéticas*\n" +
                "Las ondas electromagnéticas se propagan de manera diferente según el medio:\n" +
                "- *Vacío*: Viajan a c = 299,792,458 m/s sin pérdidas.\n" +
                "- *Aire*: Velocidad cercana a c, con mínima atenuación.\n" +
                "- *Medios materiales*: La velocidad se reduce según el índice de refracción (n = c/v). Por ejemplo, en el agua n ≈ 1.33, en el vidrio n ≈ 1.5.\n" +
                "Fenómenos asociados:\n" +
                "- *Reflexión*: Rebote de la onda en una superficie (ejemplo: espejos).\n" +
                "- *Refracción*: Cambio de dirección al pasar entre medios (ejemplo: lentes ópticos).\n" +
                "- *Dispersión*: Separación de la luz en colores (ejemplo: arcoíris).\n" +
                "- *Absorción*: Pérdida de energía en el medio (ejemplo: bloqueo de UV por la atmósfera).";

            public static readonly string Spectrum =
                "📊 *Espectro Electromagnético*\n" +
                "El espectro electromagnético abarca todas las ondas electromagnéticas, ordenadas por frecuencia o longitud de onda:\n" +
                "- *Ondas de radio*: < 3 GHz, λ > 10 cm, usadas en telecomunicaciones.\n" +
                "- *Microondas*: 3 GHz - 300 GHz, λ 10 cm - 1 mm, para radares y hornos.\n" +
                "- *Infrarrojo*: 300 GHz - 430 THz, λ 1 mm - 700 nm, para sensores térmicos.\n" +
                "- *Luz visible*: 430 THz - 770 THz, λ 700 nm - 400 nm, dividido en colores (rojo ~650 nm, azul ~450 nm).\n" +
                "- *Ultravioleta*: 770 THz - 30 PHz, λ 400 nm - 10 nm, para esterilización.\n" +
                "- *Rayos X*: 30 PHz - 30 EHz, λ 10 nm - 0.01 nm, para imágenes médicas.\n" +
                "- *Rayos gamma*: > 30 EHz, λ < 0.01 nm, para aplicaciones nucleares.\n" +
                "La frecuencia determina la energía y el uso práctico de cada tipo de onda.";

            public static readonly string UnknownCommand =
                "❓ Comando no reconocido. Usa /start para el menú principal o /help para ver los comandos disponibles.";
        }

        public static InlineKeyboardMarkup GetMainMenu()
        {
            return new InlineKeyboardMarkup(new[]
            {
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("📚 Definición", "definition"),
                    InlineKeyboardButton.WithCallbackData("📡 Tipos", "types")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("⚙️ Propiedades", "properties"),
                    InlineKeyboardButton.WithCallbackData("📝 Ecuaciones", "equations")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("🚀 Aplicaciones", "applications"),
                    InlineKeyboardButton.WithCallbackData("🔄 Polarización", "polarization")
                },
                new[]
                {
                    InlineKeyboardButton.WithCallbackData("🌐 Propagación", "propagation"),
                    InlineKeyboardButton.WithCallbackData("📊 Espectro", "spectrum")
                }
            });
        }
    }
}
