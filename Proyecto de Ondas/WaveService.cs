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
                ["types_radio"] = () => (WaveData.Responses.Types_RadioWaves, WaveData.GetTypesSubMenu(), "https://www.google.com/imgres?q=Ondas%20de%20radio&imgurl=https%3A%2F%2Fdefinicion.de%2Fwp-content%2Fuploads%2F2024%2F04%2Fondas-de-radio.jpg&imgrefurl=https%3A%2F%2Fdefinicion.de%2Fondas-de-radio%2F&docid=x737c82ESFK4GM&tbnid=gO2vMJZhUH_owM&vet=12ahUKEwjp4aDtl9mNAxVPn4QIHb1_G7kQM3oECG8QAA..i&w=1280&h=824&hcb=2&ved=2ahUKEwjp4aDtl9mNAxVPn4QIHb1_G7kQM3oECG8QAA"),
                ["types_microwaves"] = () => (WaveData.Responses.Types_Microwaves, WaveData.GetTypesSubMenu(), "https://example.com/images/microwaves.jpg"),
                ["types_infrared"] = () => (WaveData.Responses.Types_Infrared, WaveData.GetTypesSubMenu(), "https://www.google.com/imgres?q=radiacion%20infrarroja&imgurl=https%3A%2F%2Fwww.redalyc.org%2Fjournal%2F920%2F92046968008%2F92046968008_gf2.png&imgrefurl=https%3A%2F%2Fwww.redalyc.org%2Fjournal%2F920%2F92046968008%2Fhtml%2F&docid=Md-bCMyso5jE4M&tbnid=6ya4AnzWcvZcBM&vet=12ahUKEwiG1PWFmdmNAxV1TTABHcSeKCAQM3oECCAQAA..i&w=506&h=262&hcb=2&ved=2ahUKEwiG1PWFmdmNAxV1TTABHcSeKCAQM3oECCAQAA"),
                ["types_visible"] = () => (WaveData.Responses.Types_VisibleLight, WaveData.GetTypesSubMenu(), "https://example.com/images/visible_light.jpg"),
                ["types_ultraviolet"] = () => (WaveData.Responses.Types_Ultraviolet, WaveData.GetTypesSubMenu(), "https://example.com/images/ultraviolet.jpg"),
                ["types_xrays"] = () => (WaveData.Responses.Types_XRays, WaveData.GetTypesSubMenu(), "https://example.com/images/xrays.jpg"),
                ["types_gamma"] = () => (WaveData.Responses.Types_GammaRays, WaveData.GetTypesSubMenu(), "https://example.com/images/gamma_rays.jpg"),

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
                ["applications_radio"] = () => (WaveData.Responses.Applications_RadioWaves, WaveData.GetApplicationsSubMenu(), "https://example.com/images/radio_applications.jpg"),
                ["applications_microwaves"] = () => (WaveData.Responses.Applications_Microwaves, WaveData.GetApplicationsSubMenu(), "https://example.com/images/microwave_applications.jpg"),
                ["applications_infrared"] = () => (WaveData.Responses.Applications_Infrared, WaveData.GetApplicationsSubMenu(), "https://example.com/images/infrared_applications.jpg"),
                ["applications_visible"] = () => (WaveData.Responses.Applications_VisibleLight, WaveData.GetApplicationsSubMenu(), "https://example.com/images/visible_applications.jpg"),
                ["applications_ultraviolet"] = () => (WaveData.Responses.Applications_Ultraviolet, WaveData.GetApplicationsSubMenu(), "https://example.com/images/ultraviolet_applications.jpg"),
                ["applications_xrays"] = () => (WaveData.Responses.Applications_XRays, WaveData.GetApplicationsSubMenu(), "https://example.com/images/xray_applications.jpg"),
                ["applications_gamma"] = () => (WaveData.Responses.Applications_GammaRays, WaveData.GetApplicationsSubMenu(), "https://example.com/images/gamma_applications.jpg"),

                // Polarización  
                ["polarization_overview"] = () => (WaveData.Responses.Polarization_Overview, WaveData.GetPolarizationSubMenu(), null),
                ["polarization_linear"] = () => (WaveData.Responses.Polarization_Linear, WaveData.GetPolarizationSubMenu(), "https://example.com/images/polarization_linear.jpg"),
                ["polarization_circular"] = () => (WaveData.Responses.Polarization_Circular, WaveData.GetPolarizationSubMenu(), "https://example.com/images/polarization_circular.jpg"),
                ["polarization_elliptical"] = () => (WaveData.Responses.Polarization_Elliptical, WaveData.GetPolarizationSubMenu(), "https://example.com/images/polarization_elliptical.jpg"),

                // Propagación  
                ["propagation_overview"] = () => (WaveData.Responses.Propagation_Overview, WaveData.GetPropagationSubMenu(), null),
                ["propagation_vacuum"] = () => (WaveData.Responses.Propagation_Vacuum, WaveData.GetPropagationSubMenu(), "https://example.com/images/propagation_vacuum.jpg"),
                ["propagation_air"] = () => (WaveData.Responses.Propagation_Air, WaveData.GetPropagationSubMenu(), "https://example.com/images/propagation_air.jpg"),
                ["propagation_materials"] = () => (WaveData.Responses.Propagation_Materials, WaveData.GetPropagationSubMenu(), "https://example.com/images/propagation_materials.jpg"),
                ["propagation_phenomena"] = () => (WaveData.Responses.Propagation_Phenomena, WaveData.GetPropagationSubMenu(), "https://example.com/images/propagation_phenomena.jpg"),

                // Espectro  
                ["spectrum_overview"] = () => (WaveData.Responses.Spectrum_Overview, WaveData.GetSpectrumSubMenu(), null),
                ["spectrum_radio"] = () => (WaveData.Responses.Spectrum_RadioWaves, WaveData.GetSpectrumSubMenu(), "https://example.com/images/spectrum_radio.jpg"),
                ["spectrum_microwaves"] = () => (WaveData.Responses.Spectrum_Microwaves, WaveData.GetSpectrumSubMenu(), "https://example.com/images/spectrum_microwaves.jpg"),
                ["spectrum_infrared"] = () => (WaveData.Responses.Spectrum_Infrared, WaveData.GetSpectrumSubMenu(), "https://example.com/images/spectrum_infrared.jpg"),
                ["spectrum_visible"] = () => (WaveData.Responses.Spectrum_VisibleLight, WaveData.GetSpectrumSubMenu(), "https://example.com/images/spectrum_visible.jpg"),
                ["spectrum_ultraviolet"] = () => (WaveData.Responses.Spectrum_Ultraviolet, WaveData.GetSpectrumSubMenu(), "https://example.com/images/spectrum_ultraviolet.jpg"),
                ["spectrum_xrays"] = () => (WaveData.Responses.Spectrum_XRays, WaveData.GetSpectrumSubMenu(), "https://example.com/images/spectrum_xrays.jpg"),
                ["spectrum_gamma"] = () => (WaveData.Responses.Spectrum_GammaRays, WaveData.GetSpectrumSubMenu(), "https://example.com/images/spectrum_gamma.jpg")
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