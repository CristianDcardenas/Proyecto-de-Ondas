using System;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace Proyecto_de_Ondas
{
    public class WaveService
    {
        private readonly Dictionary<string, Func<(string response, InlineKeyboardMarkup keyboard, string imageUrl)>> _commandHandlers;
        private readonly Dictionary<string, Func<(string response, InlineKeyboardMarkup keyboard, string imageUrl)>> _callbackHandlers;

        public WaveService()
        {
            _commandHandlers = new Dictionary<string, Func<(string response, InlineKeyboardMarkup keyboard, string imageUrl)>>
            {
                ["/start"] = () => (WaveData.Responses.WelcomeMessage, WaveData.GetMainMenu(), null),
                ["/help"] = () => (WaveData.Responses.HelpMessage, WaveData.GetMainMenu(), null),
                ["/info"] = () => (WaveData.Responses.InfoMessage, WaveData.GetMainMenu(), null)
            };

            _callbackHandlers = new Dictionary<string, Func<(string response, InlineKeyboardMarkup keyboard, string imageUrl)>>
            {
                // Menús principales  
                ["main_menu"] = () => (WaveData.Responses.WelcomeMessage, WaveData.GetMainMenu(), null),
                ["definition_menu"] = () => ("📚 *Definición*\nSelecciona una opción:", WaveData.GetDefinitionSubMenu(), null),
                ["types_menu"] = () => ("📡 *Tipos*\nSelecciona una opción:", WaveData.GetTypesSubMenu(), null),
                ["properties_menu"] = () => ("⚙️ *Propiedades*\nSelecciona una opción:", WaveData.GetPropertiesSubMenu(), null),
                ["equations_menu"] = () => ("📝 *Ecuaciones*\nSelecciona una opción:", WaveData.GetEquationsSubMenu(), null),
                ["applications_menu"] = () => ("🚀 *Aplicaciones*\nSelecciona una opción:", WaveData.GetApplicationsSubMenu(), null),
                ["polarization_menu"] = () => ("🔄 *Polarización*\nSelecciona una opción:", WaveData.GetPolarizationSubMenu(), null),
                ["propagation_menu"] = () => ("🌐 *Propagación*\nSelecciona una opción:", WaveData.GetPropagationSubMenu(), null),
                ["spectrum_menu"] = () => ("📊 *Espectro*\nSelecciona una opción:", WaveData.GetSpectrumSubMenu(), null),

                // Definición  
                ["definition_overview"] = () => (WaveData.Responses.Definition_Overview, WaveData.GetDefinitionSubMenu(), null),
                ["definition_history"] = () => (WaveData.Responses.Definition_History, WaveData.GetDefinitionSubMenu(), null),
                ["definition_characteristics"] = () => (WaveData.Responses.Definition_Characteristics, WaveData.GetDefinitionSubMenu(), null),

                // Tipos  
                ["types_overview"] = () => (WaveData.Responses.Types_Overview, WaveData.GetTypesSubMenu(), null),
                ["types_radio"] = () => (WaveData.Responses.Types_RadioWaves, WaveData.GetTypesSubMenu(), "https://definicion.de/wp-content/uploads/2024/04/ondas-de-radio.jpg"),
                ["types_microwaves"] = () => (WaveData.Responses.Types_Microwaves, WaveData.GetTypesSubMenu(), "https://www.revista.unam.mx/wp-content/uploads/3_interaccion_entre_microondas_y_moleculas.png"),
                ["types_infrared"] = () => (WaveData.Responses.Types_Infrared, WaveData.GetTypesSubMenu(), "https://www.redalyc.org/journal/920/92046968008/92046968008_gf2.png"),
                ["types_visible"] = () => (WaveData.Responses.Types_VisibleLight, WaveData.GetTypesSubMenu(), "https://educacionplasticayvisual.com/wp-content/uploads/espectro-luz-visible-prisma-plastica.jpg"),
                ["types_ultraviolet"] = () => (WaveData.Responses.Types_Ultraviolet, WaveData.GetTypesSubMenu(), "http://www.elisaribau.com/wp-content/uploads/2018/05/rayos-ultravioleta.jpg"),
                ["types_xrays"] = () => (WaveData.Responses.Types_XRays, WaveData.GetTypesSubMenu(), "https://medlineplus.gov/images/Xray_share.jpg"),
                ["types_gamma"] = () => (WaveData.Responses.Types_GammaRays, WaveData.GetTypesSubMenu(), "https://images.theconversation.com/files/559347/original/file-20231114-23-6sofq7.jpg"),

                // Propiedades  
                ["properties_overview"] = () => (WaveData.Responses.Properties_Overview, WaveData.GetPropertiesSubMenu(), null),
                ["properties_frequency"] = () => (WaveData.Responses.Properties_Frequency, WaveData.GetPropertiesSubMenu(), null),
                ["properties_wavelength"] = () => (WaveData.Responses.Properties_Wavelength, WaveData.GetPropertiesSubMenu(), null),
                ["properties_speed"] = () => (WaveData.Responses.Properties_Speed, WaveData.GetPropertiesSubMenu(), null),
                ["properties_energy"] = () => (WaveData.Responses.Properties_Energy, WaveData.GetPropertiesSubMenu(), null),
                ["properties_amplitude"] = () => (WaveData.Responses.Properties_Amplitude, WaveData.GetPropertiesSubMenu(), null),
                ["properties_transversal"] = () => (WaveData.Responses.Properties_Transversal, WaveData.GetPropertiesSubMenu(), null),
                ["properties_vacuum"] = () => (WaveData.Responses.Properties_Vacuum, WaveData.GetPropertiesSubMenu(), null),

                // Ecuaciones  
                ["equations_overview"] = () => (WaveData.Responses.Equations_Overview, WaveData.GetEquationsSubMenu(), null),
                ["equations_speed"] = () => (WaveData.Responses.Equations_Speed, WaveData.GetEquationsSubMenu(), null),
                ["equations_energy"] = () => (WaveData.Responses.Equations_Energy, WaveData.GetEquationsSubMenu(), null),
                ["equations_maxwell"] = () => (WaveData.Responses.Equations_Maxwell, WaveData.GetEquationsSubMenu(), null),

                // Aplicaciones  
                ["applications_overview"] = () => (WaveData.Responses.Applications_Overview, WaveData.GetApplicationsSubMenu(), null),
                ["applications_radio"] = () => (WaveData.Responses.Applications_RadioWaves, WaveData.GetApplicationsSubMenu(), "https://www.google.com/imgres?q=tecnologias%20inalambricas&imgurl=https%3A%2F%2Fwww.quonty.com%2Fblog%2Fwp-content%2Fuploads%2F2018%2F02%2Fmoviles-ordenadores-baratos-130.jpg&imgrefurl=https%3A%2F%2Fwww.quonty.com%2Fblog%2Ftecnologia-inalambrica%2F&docid=tr1zodSNyzbbpM&tbnid=DzXfAwfv8RwnxM&vet=12ahUKEwiY35aIrdmNAxWsmYQIHYhMMukQM3oECGYQAA..i&w=600&h=400&hcb=2&ved=2ahUKEwiY35aIrdmNAxWsmYQIHYhMMukQM3oECGYQAA"),
                ["applications_microwaves"] = () => (WaveData.Responses.Applications_Microwaves, WaveData.GetApplicationsSubMenu(), "https://www.google.com/imgres?q=microondas&imgurl=https%3A%2F%2Fhttp2.mlstatic.com%2FD_NQ_736824-MLA69192115939_052023-OO.jpg&imgrefurl=https%3A%2F%2Fwww.mercadolibre.com.co%2Fblog%2Ftr%2Fcuales-son-las-medidas-de-un-microondas-y-como-elegir-el-tuyo&docid=L86SbiWZ7XJ0SM&tbnid=4mVv-rhCJ34ToM&vet=12ahUKEwigpoC1rdmNAxUQSTABHZdmDR0QM3oECB4QAA..i&w=1920&h=1280&hcb=2&ved=2ahUKEwigpoC1rdmNAxUQSTABHZdmDR0QM3oECB4QAA"),
                ["applications_infrared"] = () => (WaveData.Responses.Applications_Infrared, WaveData.GetApplicationsSubMenu(), "https://www.google.com/imgres?q=termograf%C3%ADa%20mediaca&imgurl=https%3A%2F%2Fstatic.wixstatic.com%2Fmedia%2Fbc8fb4_77bc9f5867134aa1b5f7e156c6781a9d~mv2.jpg%2Fv1%2Ffill%2Fw_640%2Ch_298%2Cal_c%2Cq_80%2Cusm_0.66_1.00_0.01%2Cenc_avif%2Cquality_auto%2Fbc8fb4_77bc9f5867134aa1b5f7e156c6781a9d~mv2.jpg&imgrefurl=https%3A%2F%2Fwww.draleilagonzaga.com%2Fcopia-polissonografia&docid=o597ANFk_Rz15M&tbnid=8g5MLHHTIDbuxM&vet=12ahUKEwiI_9HzrdmNAxU0STABHWsWO-MQM3oFCIABEAA..i&w=640&h=298&hcb=2&ved=2ahUKEwiI_9HzrdmNAxU0STABHWsWO-MQM3oFCIABEAA"),
                ["applications_visible"] = () => (WaveData.Responses.Applications_VisibleLight, WaveData.GetApplicationsSubMenu(), "https://www.google.com/imgres?q=Pantallas&imgurl=https%3A%2F%2Fi0.wp.com%2Ffolou.co%2Fwp-content%2Fuploads%2F2022%2F04%2FPANTALLA-LCD-DICCIONARIO-FOLOU.jpg%3Ffit%3D1200%252C675%26ssl%3D1&imgrefurl=https%3A%2F%2Ffolou.co%2Fdispositivos%2Fpantalla-lcd%2F&docid=V4i8cKHQPRh2MM&tbnid=bhlQzQIYfuJDLM&vet=12ahUKEwjLi86vrtmNAxVzFlkFHQOjHysQM3oECEgQAA..i&w=1200&h=675&hcb=2&ved=2ahUKEwjLi86vrtmNAxVzFlkFHQOjHysQM3oECEgQAA"),
                ["applications_ultraviolet"] = () => (WaveData.Responses.Applications_Ultraviolet, WaveData.GetApplicationsSubMenu(), "https://www.google.com/imgres?q=analisis%20forense%20luz%20ultravioleta&imgurl=https%3A%2F%2Fwww.iluminet.com%2Fnewpress%2Fwp-content%2Fuploads%2F2018%2F01%2Flucesforenses.jpg&imgrefurl=https%3A%2F%2Filuminet.com%2Fluz-ciencias-forenses%2F&docid=G9DqCrLo25eZpM&tbnid=v8BnQw7gK1z8PM&vet=12ahUKEwiUqIXUrtmNAxWTRzABHRM6DIwQM3oECGYQAA..i&w=805&h=456&hcb=2&ved=2ahUKEwiUqIXUrtmNAxWTRzABHRM6DIwQM3oECGYQAA"),
                ["applications_xrays"] = () => (WaveData.Responses.Applications_XRays, WaveData.GetApplicationsSubMenu(), "https://www.google.com/imgres?q=Radio%20terapia&imgurl=https%3A%2F%2Fassets.neurosurgicalatlas.com%2Faaroncohen-gadol-com%2Fmeningioma-blog-8-fig-1.jpg&imgrefurl=https%3A%2F%2Fwww.aaroncohen-gadol.com%2Fes%2Fpacientes%2Fmeningioma-es%2Ftratamiento%2Fradioterapia&docid=0sDd4qvr32t6oM&tbnid=egrslVD1tCRzTM&vet=12ahUKEwiU4ej4rtmNAxV8VTABHW6qIOIQM3oECGEQAA..i&w=518&h=292&hcb=2&ved=2ahUKEwiU4ej4rtmNAxV8VTABHW6qIOIQM3oECGEQAA"),
                ["applications_gamma"] = () => (WaveData.Responses.Applications_GammaRays, WaveData.GetApplicationsSubMenu(), "https://www.google.com/imgres?q=investigaci%C3%B3n%20nuclear&imgurl=https%3A%2F%2Frinconeducativo.org%2Fwp-content%2Fuploads%2F2023%2F07%2FReactores_Investigacion.jpeg&imgrefurl=https%3A%2F%2Frinconeducativo.org%2Fes%2Frecursos-educativos%2Fque-son-los-reactores-de-investigacion%2F&docid=c15qCTe0g0isqM&tbnid=av9TLIXsuIsFtM&vet=12ahUKEwiXzqjjr9mNAxWYK1kFHQBgN64QM3oECGUQAA..i&w=295&h=171&hcb=2&ved=2ahUKEwiXzqjjr9mNAxWYK1kFHQBgN64QM3oECGUQAA"),

                // Polarización  
                ["polarization_overview"] = () => (WaveData.Responses.Polarization_Overview, WaveData.GetPolarizationSubMenu(), null),
                ["polarization_linear"] = () => (WaveData.Responses.Polarization_Linear, WaveData.GetPolarizationSubMenu(), "https://www.iar.unlp.edu.ar/wp-content/uploads/2021/06/fig1b.png"),
                ["polarization_circular"] = () => (WaveData.Responses.Polarization_Circular, WaveData.GetPolarizationSubMenu(), "http://hyperphysics.phy-astr.gsu.edu/hbasees/phyopt/imgpho/polcir.png"),
                ["polarization_elliptical"] = () => (WaveData.Responses.Polarization_Elliptical, WaveData.GetPolarizationSubMenu(), "http://hyperphysics.phy-astr.gsu.edu/hbasees/phyopt/imgpho/polell.png"),

                // Propagación  
                ["propagation_overview"] = () => (WaveData.Responses.Propagation_Overview, WaveData.GetPropagationSubMenu(), null),
                ["propagation_vacuum"] = () => (WaveData.Responses.Propagation_Vacuum, WaveData.GetPropagationSubMenu(), null),
                ["propagation_air"] = () => (WaveData.Responses.Propagation_Air, WaveData.GetPropagationSubMenu(), null),
                ["propagation_materials"] = () => (WaveData.Responses.Propagation_Materials, WaveData.GetPropagationSubMenu(), null),
                ["propagation_phenomena"] = () => (WaveData.Responses.Propagation_Phenomena, WaveData.GetPropagationSubMenu(), "https://thumbs.dreamstime.com/z/propiedades-de-dispersi%C3%B3n-y-refracci%C3%B3n-la-luz-diferencia-comparada-para-temas-educativos-actividad-onda-absorci%C3%B3n-espectro-191935745.jpg"),

                // Espectro  
                ["spectrum_overview"] = () => (WaveData.Responses.Spectrum_Overview, WaveData.GetSpectrumSubMenu(), null),
                ["spectrum_radio"] = () => (WaveData.Responses.Spectrum_RadioWaves, WaveData.GetSpectrumSubMenu(), null),
                ["spectrum_microwaves"] = () => (WaveData.Responses.Spectrum_Microwaves, WaveData.GetSpectrumSubMenu(), null),
                ["spectrum_infrared"] = () => (WaveData.Responses.Spectrum_Infrared, WaveData.GetSpectrumSubMenu(), null),
                ["spectrum_visible"] = () => (WaveData.Responses.Spectrum_VisibleLight, WaveData.GetSpectrumSubMenu(), null),
                ["spectrum_ultraviolet"] = () => (WaveData.Responses.Spectrum_Ultraviolet, WaveData.GetSpectrumSubMenu(), null),
                ["spectrum_xrays"] = () => (WaveData.Responses.Spectrum_XRays, WaveData.GetSpectrumSubMenu(), null),
                ["spectrum_gamma"] = () => (WaveData.Responses.Spectrum_GammaRays, WaveData.GetSpectrumSubMenu(), null)
            };
        }

        public (string response, InlineKeyboardMarkup keyboard, string imageUrl) ProcessCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
                return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu(), null);

            var normalizedCommand = command.ToLower().Trim();

            if (_commandHandlers.TryGetValue(normalizedCommand, out var handler))
                return handler();

            return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu(), null);
        }

        public (string response, InlineKeyboardMarkup keyboard, string imageUrl) ProcessCallbackQuery(string callbackData)
        {
            if (string.IsNullOrWhiteSpace(callbackData))
                return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu(), null);

            if (_callbackHandlers.TryGetValue(callbackData, out var handler))
                return handler();

            return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu(), null);
        }
    }
}