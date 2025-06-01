using Telegram.Bot.Types.ReplyMarkups;

namespace Proyecto_de_Ondas
{
    public static class WaveData
    {
        public static class Responses
        {
            public static readonly string WelcomeMessage =
                "🌊 *¡Explora las Ondas Electromagnéticas!* 🌊\n\n" +
                "Descubre temas como definición, tipos, propiedades y más con un menú interactivo.\n\n" +
                "Usa /help para ver los comandos disponibles.";

            public static readonly string HelpMessage =
                "ℹ️ *Comandos Disponibles*\n\n" +
                "• `/start` - Menú principal interactivo\n" +
                "• `/help` - Muestra esta ayuda\n" +
                "• `/info` - Información sobre el bot\n\n" +
                "Selecciona los botones para explorar los diferentes temas.";

            public static readonly string InfoMessage =
                "📖 *Sobre el Bot*\n\n" +
                "Bot educativo sobre ondas electromagnéticas, desarrollado en C# con .NET.\n\n" +
                "Ofrece información detallada sobre:\n" +
                "• Definiciones y conceptos básicos\n" +
                "• Tipos de ondas electromagnéticas\n" +
                "• Propiedades físicas\n" +
                "• Ecuaciones fundamentales\n" +
                "• Aplicaciones prácticas\n" +
                "• Y mucho más...\n\n" +
                "_Versión 2.0 - Mejorada_";

            public static readonly string UnknownCommand =
                "❓ *Comando no reconocido*\n\n" +
                "Usa `/start` para acceder al menú principal o `/help` para ver la ayuda.";

            // Definición
            public static readonly string Definition_Overview =
                "📚 *Definición: Conceptos Generales*\n\n" +
                "Las ondas electromagnéticas son perturbaciones que se propagan a través del espacio " +
                "transportando energía mediante la oscilación de campos eléctricos y magnéticos perpendiculares entre sí.\n\n" +
                "*Características principales:*\n" +
                "• No requieren medio material para propagarse\n" +
                "• Viajan a la velocidad de la luz en el vacío\n" +
                "• Transportan energía e información";

            public static readonly string Definition_History =
                "📚 *Definición: Historia y Desarrollo*\n\n" +
                "*Cronología histórica:*\n\n" +
                "🔬 *1864* - James Clerk Maxwell predice teóricamente las ondas electromagnéticas\n\n" +
                "⚡ *1887* - Heinrich Hertz confirma experimentalmente su existencia\n\n" +
                "📡 *1895* - Guglielmo Marconi desarrolla la primera transmisión inalámbrica\n\n" +
                "Estos descubrimientos revolucionaron las telecomunicaciones y nuestra comprensión de la luz.";

            public static readonly string Definition_Characteristics =
                "📚 *Definición: Características Fundamentales*\n\n" +
                "*Propiedades esenciales:*\n\n" +
                "🌊 *Naturaleza ondulatoria* - Exhiben interferencia y difracción\n\n" +
                "⚡ *Campos perpendiculares* - E ⊥ B ⊥ dirección de propagación\n\n" +
                "🚀 *Velocidad constante* - c = 299,792,458 m/s en el vacío\n\n" +
                "🌌 *Propagación en vacío* - No requieren medio material\n\n" +
                "📊 *Espectro continuo* - Desde ondas de radio hasta rayos gamma";

            // Tipos
            public static readonly string Types_Overview =
                "📡 *Tipos: Clasificación del Espectro*\n\n" +
                "El espectro electromagnético se clasifica según la frecuencia (f) y longitud de onda (λ):\n\n" +
                "*Relación fundamental:*\n" +
                "`c = f × λ`\n\n" +
                "Donde c = 299,792,458 m/s\n\n" +
                "*Orden por frecuencia creciente:*\n" +
                "📻 Radio → 🍽️ Microondas → 🔥 Infrarrojo → 🌈 Visible → ☀️ UV → 🩻 Rayos X → ☢️ Gamma";

            public static readonly string Types_RadioWaves =
                "📡 *Tipos: Ondas de Radio*\n\n" +
                "*Rango de frecuencias:* 3 Hz - 3 GHz\n" +
                "*Longitud de onda:* 100 km - 10 cm\n\n" +
                "*Aplicaciones principales:*\n" +
                "• Radio AM/FM\n" +
                "• Televisión\n" +
                "• Wi-Fi (2.4/5 GHz)\n" +
                "• Bluetooth\n" +
                "• Comunicaciones móviles";

            public static readonly string Types_Microwaves =
                "📡 *Tipos: Microondas*\n\n" +
                "*Rango de frecuencias:* 3 GHz - 300 GHz\n" +
                "*Longitud de onda:* 10 cm - 1 mm\n\n" +
                "*Aplicaciones:*\n" +
                "• Hornos microondas (2.45 GHz)\n" +
                "• Radares\n" +
                "• Comunicaciones satelitales\n" +
                "• Redes 5G";

            public static readonly string Types_Infrared =
                "📡 *Tipos: Radiación Infrarroja*\n\n" +
                "*Rango de frecuencias:* 300 GHz - 430 THz\n" +
                "*Longitud de onda:* 1 mm - 700 nm\n\n" +
                "*Aplicaciones:*\n" +
                "• Controles remotos\n" +
                "• Sensores de movimiento\n" +
                "• Termografía\n" +
                "• Calefacción";

            public static readonly string Types_VisibleLight =
                "📡 *Tipos: Luz Visible*\n\n" +
                "*Rango de frecuencias:* 430 THz - 770 THz\n" +
                "*Longitud de onda:* 700 nm - 400 nm\n\n" +
                "*Colores del espectro:*\n" +
                "🔴 Rojo (700 nm) → 🟠 Naranja → 🟡 Amarillo → 🟢 Verde → 🔵 Azul → 🟣 Violeta (400 nm)";

            public static readonly string Types_Ultraviolet =
                "📡 *Tipos: Radiación Ultravioleta*\n\n" +
                "*Rango de frecuencias:* 770 THz - 30 PHz\n" +
                "*Longitud de onda:* 400 nm - 10 nm\n\n" +
                "*Aplicaciones:*\n" +
                "• Esterilización\n" +
                "• Bronceado\n" +
                "• Análisis forense\n" +
                "• Purificación de agua";

            public static readonly string Types_XRays =
                "📡 *Tipos: Rayos X*\n\n" +
                "*Rango de frecuencias:* 30 PHz - 30 EHz\n" +
                "*Longitud de onda:* 10 nm - 0.01 nm\n\n" +
                "*Aplicaciones médicas:*\n" +
                "• Radiografías\n" +
                "• Tomografías\n" +
                "• Mamografías\n" +
                "• Inspección de equipaje";

            public static readonly string Types_GammaRays =
                "📡 *Tipos: Rayos Gamma*\n\n" +
                "*Rango de frecuencias:* > 30 EHz\n" +
                "*Longitud de onda:* < 0.01 nm\n\n" +
                "*Aplicaciones:*\n" +
                "• Radioterapia\n" +
                "• Esterilización médica\n" +
                "• Imágenes PET\n" +
                "• Investigación nuclear";

            // Propiedades
            public static readonly string Properties_Overview =
                "⚙️ *Propiedades: Características Generales*\n\n" +
                "Las ondas electromagnéticas tienen propiedades fundamentales que determinan su comportamiento:\n\n" +
                "• *Frecuencia* - Determina la energía\n" +
                "• *Longitud de onda* - Inversamente proporcional a la frecuencia\n" +
                "• *Velocidad* - Constante en el vacío\n" +
                "• *Amplitud* - Determina la intensidad";

            public static readonly string Properties_Frequency =
                "⚙️ *Propiedades: Frecuencia*\n\n" +
                "*Definición:* Número de oscilaciones por segundo (Hz)\n\n" +
                "*Relación con energía:*\n" +
                "`E = h × f`\n\n" +
                "Donde:\n" +
                "• h = Constante de Planck (6.626 × 10⁻³⁴ J·s)\n" +
                "• f = Frecuencia (Hz)\n\n" +
                "*Implicación:* Mayor frecuencia = Mayor energía";

            public static readonly string Properties_Wavelength =
                "⚙️ *Propiedades: Longitud de Onda*\n\n" +
                "*Definición:* Distancia entre dos picos consecutivos (metros)\n\n" +
                "*Relación fundamental:*\n" +
                "`c = f × λ`\n\n" +
                "Donde:\n" +
                "• c = Velocidad de la luz\n" +
                "• f = Frecuencia\n" +
                "• λ = Longitud de onda\n\n" +
                "*Característica:* Inversamente proporcional a la frecuencia";

            public static readonly string Properties_Speed =
                "⚙️ *Propiedades: Velocidad*\n\n" +
                "*En el vacío:*\n" +
                "c = 299,792,458 m/s (exacto)\n\n" +
                "*En medios materiales:*\n" +
                "v = c/n\n\n" +
                "Donde n es el índice de refracción:\n" +
                "• Aire: n ≈ 1.0003\n" +
                "• Agua: n ≈ 1.33\n" +
                "• Vidrio: n ≈ 1.5";

            public static readonly string Properties_Energy =
                "⚙️ *Propiedades: Energía*\n\n" +
                "*Ecuación de Planck:*\n" +
                "`E = h × f`\n\n" +
                "*Energía por unidad de área:*\n" +
                "`I = (1/2) × ε₀ × c × E₀²`\n\n" +
                "Donde:\n" +
                "• E₀ = Amplitud del campo eléctrico\n" +
                "• ε₀ = Permitividad del vacío\n\n" +
                "*Resultado:* La energía es proporcional al cuadrado de la amplitud";

            public static readonly string Properties_Amplitude =
                "⚙️ *Propiedades: Amplitud*\n\n" +
                "*Definición:* Valor máximo del campo eléctrico o magnético\n\n" +
                "*Relación con intensidad:*\n" +
                "`I ∝ E₀²`\n\n" +
                "*Características:*\n" +
                "• Determina la intensidad de la onda\n" +
                "• No afecta la frecuencia\n" +
                "• Se puede modular para transmitir información";

            public static readonly string Properties_Transversal =
                "⚙️ *Propiedades: Naturaleza Transversal*\n\n" +
                "*Configuración de campos:*\n" +
                "• Campo eléctrico (E) ⊥ Campo magnético (B)\n" +
                "• Ambos ⊥ dirección de propagación\n\n" +
                "*Implicaciones:*\n" +
                "• Permite la polarización\n" +
                "• Propagación en línea recta\n" +
                "• Reflexión y refracción posibles";

            public static readonly string Properties_Vacuum =
                "⚙️ *Propiedades: Propagación en el Vacío*\n\n" +
                "*Característica única:*\n" +
                "Las ondas electromagnéticas NO requieren medio material\n\n" +
                "*Diferencia con ondas mecánicas:*\n" +
                "• Sonido: Necesita aire, agua, sólidos\n" +
                "• EM: Viaja perfectamente en el vacío\n\n" +
                "*Aplicaciones:*\n" +
                "• Comunicaciones espaciales\n" +
                "• Astronomía\n" +
                "• Satélites";

            // Ecuaciones
            public static readonly string Equations_Overview =
                "📝 *Ecuaciones: Fundamentos Matemáticos*\n\n" +
                "Las ondas electromagnéticas se describen mediante ecuaciones fundamentales:\n\n" +
                "• *Velocidad:* c = f × λ\n" +
                "• *Energía:* E = h × f\n" +
                "• *Maxwell:* Describen la propagación\n" +
                "• *Intensidad:* I ∝ E₀²";

            public static readonly string Equations_Speed =
                "📝 *Ecuaciones: Velocidad de Propagación*\n\n" +
                "*Ecuación fundamental:*\n" +
                "`c = f × λ`\n\n" +
                "*En medios materiales:*\n" +
                "`v = c/n = f × λₘ`\n\n" +
                "*Constantes importantes:*\n" +
                "• c = 299,792,458 m/s\n" +
                "• c = 1/√(μ₀ε₀)\n" +
                "• μ₀ = 4π × 10⁻⁷ H/m\n" +
                "• ε₀ = 8.854 × 10⁻¹² F/m";

            public static readonly string Equations_Energy =
                "📝 *Ecuaciones: Energía y Potencia*\n\n" +
                "*Energía del fotón:*\n" +
                "`E = h × f = h × c/λ`\n\n" +
                "*Intensidad de la onda:*\n" +
                "`I = (1/2) × ε₀ × c × E₀²`\n\n" +
                "*Densidad de energía:*\n" +
                "`u = (1/2) × ε₀ × E² + (1/2μ₀) × B²`\n\n" +
                "*Constante de Planck:*\n" +
                "h = 6.626 × 10⁻³⁴ J·s";

            public static readonly string Equations_Maxwell =
                "📝 *Ecuaciones: Ecuaciones de Maxwell*\n\n" +
                "*Las cuatro ecuaciones fundamentales:*\n\n" +
                "1. `∇ · E = 0` (Ley de Gauss)\n" +
                "2. `∇ · B = 0` (No monopolos magnéticos)\n" +
                "3. `∇ × E = -∂B/∂t` (Ley de Faraday)\n" +
                "4. `∇ × B = μ₀ε₀ ∂E/∂t` (Ley de Ampère-Maxwell)\n\n" +
                "*Resultado:* Predicen la existencia y propagación de ondas electromagnéticas";

            // Aplicaciones
            public static readonly string Applications_Overview =
                "🚀 *Aplicaciones: Usos Tecnológicos*\n\n" +
                "Las ondas electromagnéticas tienen aplicaciones en múltiples campos:\n\n" +
                "• *Comunicaciones* - Radio, TV, móviles\n" +
                "• *Medicina* - Rayos X, resonancia magnética\n" +
                "• *Industria* - Hornos microondas, soldadura\n" +
                "• *Investigación* - Astronomía, espectroscopía";

            public static readonly string Applications_RadioWaves =
                "🚀 *Aplicaciones: Ondas de Radio*\n\n" +
                "*Comunicaciones:*\n" +
                "• Radio AM (535-1605 kHz)\n" +
                "• Radio FM (88-108 MHz)\n" +
                "• Televisión (54-890 MHz)\n\n" +
                "*Tecnologías inalámbricas:*\n" +
                "• Wi-Fi (2.4/5 GHz)\n" +
                "• Bluetooth (2.4 GHz)\n" +
                "• Telefonía móvil (800-2100 MHz)\n" +
                "• GPS (1.2/1.5 GHz)";

            public static readonly string Applications_Microwaves =
                "🚀 *Aplicaciones: Microondas*\n\n" +
                "*Uso doméstico:*\n" +
                "• Hornos microondas (2.45 GHz)\n\n" +
                "*Tecnología:*\n" +
                "• Radares meteorológicos\n" +
                "• Radares de tráfico\n" +
                "• Comunicaciones satelitales\n" +
                "• Redes 5G (24-40 GHz)\n" +
                "• Radioastronomía";

            public static readonly string Applications_Infrared =
                "🚀 *Aplicaciones: Radiación Infrarroja*\n\n" +
                "*Uso cotidiano:*\n" +
                "• Controles remotos\n" +
                "• Sensores de movimiento\n" +
                "• Calefactores infrarrojos\n\n" +
                "*Aplicaciones técnicas:*\n" +
                "• Termografía médica\n" +
                "• Visión nocturna\n" +
                "• Espectroscopía IR\n" +
                "• Comunicaciones de fibra óptica";

            public static readonly string Applications_VisibleLight =
                "🚀 *Aplicaciones: Luz Visible*\n\n" +
                "*Iluminación:*\n" +
                "• LEDs de alta eficiencia\n" +
                "• Lámparas fluorescentes\n" +
                "• Iluminación solar\n\n" +
                "*Tecnología:*\n" +
                "• Pantallas LCD/OLED\n" +
                "• Láseres quirúrgicos\n" +
                "• Comunicaciones ópticas\n" +
                "• Fotovoltaica";

            public static readonly string Applications_Ultraviolet =
                "🚀 *Aplicaciones: Radiación Ultravioleta*\n\n" +
                "*Esterilización:*\n" +
                "• Purificación de agua\n" +
                "• Esterilización médica\n" +
                "• Desinfección de superficies\n\n" +
                "*Otras aplicaciones:*\n" +
                "• Análisis forense\n" +
                "• Detección de falsificaciones\n" +
                "• Fotolitografía\n" +
                "• Tratamientos dermatológicos";

            public static readonly string Applications_XRays =
                "🚀 *Aplicaciones: Rayos X*\n\n" +
                "*Medicina:*\n" +
                "• Radiografías diagnósticas\n" +
                "• Tomografías computarizadas (CT)\n" +
                "• Mamografías\n" +
                "• Radioterapia\n\n" +
                "*Seguridad:*\n" +
                "• Inspección de equipaje\n" +
                "• Control de calidad industrial\n" +
                "• Análisis de materiales";

            public static readonly string Applications_GammaRays =
                "🚀 *Aplicaciones: Rayos Gamma*\n\n" +
                "*Medicina nuclear:*\n" +
                "• Radioterapia contra el cáncer\n" +
                "• Imágenes PET\n" +
                "• Esterilización de equipos médicos\n\n" +
                "*Industria:*\n" +
                "• Esterilización de alimentos\n" +
                "• Radiografía industrial\n" +
                "• Investigación nuclear\n" +
                "• Astronomía de rayos gamma";

            // Polarización
            public static readonly string Polarization_Overview =
                "🔄 *Polarización: Orientación del Campo*\n\n" +
                "*Definición:* Describe la orientación del campo eléctrico de una onda electromagnética\n\n" +
                "*Tipos principales:*\n" +
                "• *Lineal* - Campo oscila en un plano\n" +
                "• *Circular* - Campo rota en círculo\n" +
                "• *Elíptica* - Combinación de ambas\n\n" +
                "*Importancia:* Crucial en comunicaciones y óptica";

            public static readonly string Polarization_Linear =
                "🔄 *Polarización: Lineal*\n\n" +
                "*Características:*\n" +
                "• Campo eléctrico oscila en un solo plano\n" +
                "• Dirección fija en el espacio\n" +
                "• Más simple de generar y detectar\n\n" +
                "*Aplicaciones:*\n" +
                "• Antenas de radio y TV\n" +
                "• Gafas de sol polarizadas\n" +
                "• Pantallas LCD\n" +
                "• Comunicaciones terrestres";

            public static readonly string Polarization_Circular =
                "🔄 *Polarización: Circular*\n\n" +
                "*Características:*\n" +
                "• Campo eléctrico rota en un círculo\n" +
                "• Puede ser dextrógira o levógira\n" +
                "• Mantiene intensidad constante\n\n" +
                "*Ventajas:*\n" +
                "• Menos sensible a la orientación\n" +
                "• Mejor para comunicaciones móviles\n\n" +
                "*Aplicaciones:*\n" +
                "• Comunicaciones satelitales\n" +
                "• GPS\n" +
                "• Radares";

            public static readonly string Polarization_Elliptical =
                "🔄 *Polarización: Elíptica*\n\n" +
                "*Características:*\n" +
                "• Campo eléctrico traza una elipse\n" +
                "• Caso general (lineal y circular son casos especiales)\n" +
                "• Varía en amplitud y fase\n\n" +
                "*Parámetros:*\n" +
                "• Razón axial de la elipse\n" +
                "• Ángulo de orientación\n" +
                "• Sentido de rotación\n\n" +
                "*Aplicaciones:* Óptica avanzada, investigación";

            // Propagación
            public static readonly string Propagation_Overview =
                "🌐 *Propagación: Comportamiento en Medios*\n\n" +
                "Las ondas electromagnéticas se comportan diferente según el medio:\n\n" +
                "• *Vacío* - Propagación ideal\n" +
                "• *Aire* - Mínima atenuación\n" +
                "• *Materiales* - Velocidad reducida\n" +
                "• *Fenómenos* - Reflexión, refracción, dispersión";

            public static readonly string Propagation_Vacuum =
                "🌐 *Propagación: En el Vacío*\n\n" +
                "*Características ideales:*\n" +
                "• Velocidad máxima: c = 299,792,458 m/s\n" +
                "• Sin atenuación\n" +
                "• Sin dispersión\n" +
                "• Propagación rectilínea\n\n" +
                "*Aplicaciones:*\n" +
                "• Comunicaciones espaciales\n" +
                "• Astronomía\n" +
                "• Satélites geoestacionarios";

            public static readonly string Propagation_Air =
                "🌐 *Propagación: En el Aire*\n\n" +
                "*Características:*\n" +
                "• Velocidad ≈ 99.97% de c\n" +
                "• Atenuación mínima\n" +
                "• Índice de refracción n ≈ 1.0003\n\n" +
                "*Factores que afectan:*\n" +
                "• Humedad atmosférica\n" +
                "• Temperatura\n" +
                "• Presión barométrica\n" +
                "• Partículas en suspensión";

            public static readonly string Propagation_Materials =
                "🌐 *Propagación: En Materiales*\n\n" +
                "*Velocidad reducida:*\n" +
                "`v = c/n`\n\n" +
                "*Índices de refracción típicos:*\n" +
                "• Agua: n ≈ 1.33\n" +
                "• Vidrio: n ≈ 1.5\n" +
                "• Diamante: n ≈ 2.4\n\n" +
                "*Efectos:*\n" +
                "• Cambio de dirección (refracción)\n" +
                "• Cambio de longitud de onda\n" +
                "• Posible absorción";

            public static readonly string Propagation_Phenomena =
                "🌐 *Propagación: Fenómenos Ópticos*\n\n" +
                "*Reflexión:*\n" +
                "• Rebote en superficies (espejos)\n" +
                "• Ángulo de incidencia = Ángulo de reflexión\n\n" +
                "*Refracción:*\n" +
                "• Cambio de dirección al cambiar de medio\n" +
                "• Ley de Snell: n₁sin(θ₁) = n₂sin(θ₂)\n\n" +
                "*Dispersión:*\n" +
                "• Separación de colores (prismas, arcoíris)\n" +
                "• Dependiente de la frecuencia";

            // Espectro
            public static readonly string Spectrum_Overview =
                "📊 *Espectro: Clasificación Completa*\n\n" +
                "El espectro electromagnético abarca todas las ondas electromagnéticas, " +
                "ordenadas por frecuencia creciente:\n\n" +
                "*Secuencia completa:*\n" +
                "📻 Radio → 🍽️ Microondas → 🔥 IR → 🌈 Visible → ☀️ UV → 🩻 X → ☢️ Gamma\n\n" +
                "*Característica:* Espectro continuo sin límites definidos";

            public static readonly string Spectrum_RadioWaves =
                "📊 *Espectro: Ondas de Radio*\n\n" +
                "*Rango espectral:*\n" +
                "• Frecuencia: < 3 GHz\n" +
                "• Longitud de onda: > 10 cm\n\n" +
                "*Subdivisiones:*\n" +
                "• VLF (3-30 kHz) - Navegación\n" +
                "• LF (30-300 kHz) - Radio AM\n" +
                "• MF (300 kHz-3 MHz) - Radio AM\n" +
                "• HF (3-30 MHz) - Radio onda corta\n" +
                "• VHF (30-300 MHz) - FM, TV\n" +
                "• UHF (300 MHz-3 GHz) - TV, móviles";

            public static readonly string Spectrum_Microwaves =
                "📊 *Espectro: Microondas*\n\n" +
                "*Rango espectral:*\n" +
                "• Frecuencia: 3 GHz - 300 GHz\n" +
                "• Longitud de onda: 10 cm - 1 mm\n\n" +
                "*Bandas importantes:*\n" +
                "• Banda S (2-4 GHz) - Wi-Fi, Bluetooth\n" +
                "• Banda C (4-8 GHz) - Satélites\n" +
                "• Banda X (8-12 GHz) - Radares\n" +
                "• Banda K (18-27 GHz) - Radares policiales\n" +
                "• Banda Ka (27-40 GHz) - 5G";

            public static readonly string Spectrum_Infrared =
                "📊 *Espectro: Infrarrojo*\n\n" +
                "*Rango espectral:*\n" +
                "• Frecuencia: 300 GHz - 430 THz\n" +
                "• Longitud de onda: 1 mm - 700 nm\n\n" +
                "*Subdivisiones:*\n" +
                "• IR lejano (1 mm - 15 μm) - Calor\n" +
                "• IR medio (15 - 2.5 μm) - Sensores\n" +
                "• IR cercano (2.5 μm - 700 nm) - Fibra óptica\n\n" +
                "*Característica:* Asociado con radiación térmica";

            public static readonly string Spectrum_VisibleLight =
                "📊 *Espectro: Luz Visible*\n\n" +
                "*Rango espectral:*\n" +
                "• Frecuencia: 430 THz - 770 THz\n" +
                "• Longitud de onda: 700 nm - 400 nm\n\n" +
                "*Colores y longitudes de onda:*\n" +
                "🔴 Rojo: 620-700 nm\n" +
                "🟠 Naranja: 590-620 nm\n" +
                "🟡 Amarillo: 570-590 nm\n" +
                "🟢 Verde: 495-570 nm\n" +
                "🔵 Azul: 450-495 nm\n" +
                "🟣 Violeta: 400-450 nm";

            public static readonly string Spectrum_Ultraviolet =
                "📊 *Espectro: Ultravioleta*\n\n" +
                "*Rango espectral:*\n" +
                "• Frecuencia: 770 THz - 30 PHz\n" +
                "• Longitud de onda: 400 nm - 10 nm\n\n" +
                "*Subdivisiones:*\n" +
                "• UV-A (315-400 nm) - Bronceado\n" +
                "• UV-B (280-315 nm) - Quemaduras\n" +
                "• UV-C (100-280 nm) - Esterilización\n" +
                "• UV extremo (10-100 nm) - Investigación\n\n" +
                "*Peligro:* Puede dañar tejidos biológicos";

            public static readonly string Spectrum_XRays =
                "📊 *Espectro: Rayos X*\n\n" +
                "*Rango espectral:*\n" +
                "• Frecuencia: 30 PHz - 30 EHz\n" +
                "• Longitud de onda: 10 nm - 0.01 nm\n\n" +
                "*Clasificación médica:*\n" +
                "• Rayos X blandos (0.1-10 keV)\n" +
                "• Rayos X duros (10-100 keV)\n" +
                "• Rayos X muy duros (>100 keV)\n\n" +
                "*Característica:* Alta penetración en tejidos";

            public static readonly string Spectrum_GammaRays =
                "📊 *Espectro: Rayos Gamma*\n\n" +
                "*Rango espectral:*\n" +
                "• Frecuencia: > 30 EHz\n" +
                "• Longitud de onda: < 0.01 nm\n" +
                "• Energía: > 100 keV\n\n" +
                "*Origen:*\n" +
                "• Desintegración nuclear\n" +
                "• Procesos cósmicos\n" +
                "• Aceleradores de partículas\n\n" +
                "*Característica:* Máxima energía del espectro electromagnético";
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