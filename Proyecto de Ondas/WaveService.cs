using System;
using System.Collections.Generic;
using Telegram.Bot.Types.ReplyMarkups;

namespace Proyecto_de_Ondas
{
    public class WaveService
    {
        private readonly Dictionary<string, Func<(string response, InlineKeyboardMarkup keyboard)>> _commandHandlers;
        private readonly Dictionary<string, Func<(string response, InlineKeyboardMarkup keyboard)>> _callbackHandlers;

        public WaveService()
        {
            _commandHandlers = new Dictionary<string, Func<(string response, InlineKeyboardMarkup keyboard)>>
            {
                ["/start"] = () => (WaveData.Responses.WelcomeMessage, WaveData.GetMainMenu()),
                ["/help"] = () => (WaveData.Responses.HelpMessage, WaveData.GetMainMenu()),
                ["/info"] = () => (WaveData.Responses.InfoMessage, WaveData.GetMainMenu())
            };

            _callbackHandlers = new Dictionary<string, Func<(string response, InlineKeyboardMarkup keyboard)>>
            {
                // Menús principales  
                ["main_menu"] = () => (WaveData.Responses.WelcomeMessage, WaveData.GetMainMenu()),
                ["definition_menu"] = () => ("📚 *Definición*\nSelecciona una opción:", WaveData.GetDefinitionSubMenu()),
                ["types_menu"] = () => ("📡 *Tipos*\nSelecciona una opción:", WaveData.GetTypesSubMenu()),
                ["properties_menu"] = () => ("⚙️ *Propiedades*\nSelecciona una opción:", WaveData.GetPropertiesSubMenu()),
                ["equations_menu"] = () => ("📝 *Ecuaciones*\nSelecciona una opción:", WaveData.GetEquationsSubMenu()),
                ["applications_menu"] = () => ("🚀 *Aplicaciones*\nSelecciona una opción:", WaveData.GetApplicationsSubMenu()),
                ["polarization_menu"] = () => ("🔄 *Polarización*\nSelecciona una opción:", WaveData.GetPolarizationSubMenu()),
                ["propagation_menu"] = () => ("🌐 *Propagación*\nSelecciona una opción:", WaveData.GetPropagationSubMenu()),
                ["spectrum_menu"] = () => ("📊 *Espectro*\nSelecciona una opción:", WaveData.GetSpectrumSubMenu()),

                // Definición  
                ["definition_overview"] = () => (WaveData.Responses.Definition_Overview, WaveData.GetDefinitionSubMenu()),
                ["definition_history"] = () => (WaveData.Responses.Definition_History, WaveData.GetDefinitionSubMenu()),
                ["definition_characteristics"] = () => (WaveData.Responses.Definition_Characteristics, WaveData.GetDefinitionSubMenu()),

                // Tipos  
                ["types_overview"] = () => (WaveData.Responses.Types_Overview, WaveData.GetTypesSubMenu()),
                ["types_radio"] = () => (WaveData.Responses.Types_RadioWaves, WaveData.GetTypesSubMenu()),
                ["types_microwaves"] = () => (WaveData.Responses.Types_Microwaves, WaveData.GetTypesSubMenu()),
                ["types_infrared"] = () => (WaveData.Responses.Types_Infrared, WaveData.GetTypesSubMenu()),
                ["types_visible"] = () => (WaveData.Responses.Types_VisibleLight, WaveData.GetTypesSubMenu()),
                ["types_ultraviolet"] = () => (WaveData.Responses.Types_Ultraviolet, WaveData.GetTypesSubMenu()),
                ["types_xrays"] = () => (WaveData.Responses.Types_XRays, WaveData.GetTypesSubMenu()),
                ["types_gamma"] = () => (WaveData.Responses.Types_GammaRays, WaveData.GetTypesSubMenu()),

                // Propiedades  
                ["properties_overview"] = () => (WaveData.Responses.Properties_Overview, WaveData.GetPropertiesSubMenu()),
                ["properties_frequency"] = () => (WaveData.Responses.Properties_Frequency, WaveData.GetPropertiesSubMenu()),
                ["properties_wavelength"] = () => (WaveData.Responses.Properties_Wavelength, WaveData.GetPropertiesSubMenu()),
                ["properties_speed"] = () => (WaveData.Responses.Properties_Speed, WaveData.GetPropertiesSubMenu()),
                ["properties_energy"] = () => (WaveData.Responses.Properties_Energy, WaveData.GetPropertiesSubMenu()),
                ["properties_amplitude"] = () => (WaveData.Responses.Properties_Amplitude, WaveData.GetPropertiesSubMenu()),
                ["properties_transversal"] = () => (WaveData.Responses.Properties_Transversal, WaveData.GetPropertiesSubMenu()),
                ["properties_vacuum"] = () => (WaveData.Responses.Properties_Vacuum, WaveData.GetPropertiesSubMenu()),

                // Ecuaciones  
                ["equations_overview"] = () => (WaveData.Responses.Equations_Overview, WaveData.GetEquationsSubMenu()),
                ["equations_speed"] = () => (WaveData.Responses.Equations_Speed, WaveData.GetEquationsSubMenu()),
                ["equations_energy"] = () => (WaveData.Responses.Equations_Energy, WaveData.GetEquationsSubMenu()),
                ["equations_maxwell"] = () => (WaveData.Responses.Equations_Maxwell, WaveData.GetEquationsSubMenu()),

                // Aplicaciones  
                ["applications_overview"] = () => (WaveData.Responses.Applications_Overview, WaveData.GetApplicationsSubMenu()),
                ["applications_radio"] = () => (WaveData.Responses.Applications_RadioWaves, WaveData.GetApplicationsSubMenu()),
                ["applications_microwaves"] = () => (WaveData.Responses.Applications_Microwaves, WaveData.GetApplicationsSubMenu()),
                ["applications_infrared"] = () => (WaveData.Responses.Applications_Infrared, WaveData.GetApplicationsSubMenu()),
                ["applications_visible"] = () => (WaveData.Responses.Applications_VisibleLight, WaveData.GetApplicationsSubMenu()),
                ["applications_ultraviolet"] = () => (WaveData.Responses.Applications_Ultraviolet, WaveData.GetApplicationsSubMenu()),
                ["applications_xrays"] = () => (WaveData.Responses.Applications_XRays, WaveData.GetApplicationsSubMenu()),
                ["applications_gamma"] = () => (WaveData.Responses.Applications_GammaRays, WaveData.GetApplicationsSubMenu()),

                // Polarización  
                ["polarization_overview"] = () => (WaveData.Responses.Polarization_Overview, WaveData.GetPolarizationSubMenu()),
                ["polarization_linear"] = () => (WaveData.Responses.Polarization_Linear, WaveData.GetPolarizationSubMenu()),
                ["polarization_circular"] = () => (WaveData.Responses.Polarization_Circular, WaveData.GetPolarizationSubMenu()),
                ["polarization_elliptical"] = () => (WaveData.Responses.Polarization_Elliptical, WaveData.GetPolarizationSubMenu()),

                // Propagación  
                ["propagation_overview"] = () => (WaveData.Responses.Propagation_Overview, WaveData.GetPropagationSubMenu()),
                ["propagation_vacuum"] = () => (WaveData.Responses.Propagation_Vacuum, WaveData.GetPropagationSubMenu()),
                ["propagation_air"] = () => (WaveData.Responses.Propagation_Air, WaveData.GetPropagationSubMenu()),
                ["propagation_materials"] = () => (WaveData.Responses.Propagation_Materials, WaveData.GetPropagationSubMenu()),
                ["propagation_phenomena"] = () => (WaveData.Responses.Propagation_Phenomena, WaveData.GetPropagationSubMenu()),

                // Espectro  
                ["spectrum_overview"] = () => (WaveData.Responses.Spectrum_Overview, WaveData.GetSpectrumSubMenu()),
                ["spectrum_radio"] = () => (WaveData.Responses.Spectrum_RadioWaves, WaveData.GetSpectrumSubMenu()),
                ["spectrum_microwaves"] = () => (WaveData.Responses.Spectrum_Microwaves, WaveData.GetSpectrumSubMenu()),
                ["spectrum_infrared"] = () => (WaveData.Responses.Spectrum_Infrared, WaveData.GetSpectrumSubMenu()),
                ["spectrum_visible"] = () => (WaveData.Responses.Spectrum_VisibleLight, WaveData.GetSpectrumSubMenu()),
                ["spectrum_ultraviolet"] = () => (WaveData.Responses.Spectrum_Ultraviolet, WaveData.GetSpectrumSubMenu()),
                ["spectrum_xrays"] = () => (WaveData.Responses.Spectrum_XRays, WaveData.GetSpectrumSubMenu()),
                ["spectrum_gamma"] = () => (WaveData.Responses.Spectrum_GammaRays, WaveData.GetSpectrumSubMenu())
            };
        }

        public (string response, InlineKeyboardMarkup keyboard) ProcessCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
                return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu());

            var normalizedCommand = command.ToLower().Trim();

            if (_commandHandlers.TryGetValue(normalizedCommand, out var handler))
                return handler();

            return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu());
        }

        public (string response, InlineKeyboardMarkup keyboard) ProcessCallbackQuery(string callbackData)
        {
            if (string.IsNullOrWhiteSpace(callbackData))
                return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu());

            if (_callbackHandlers.TryGetValue(callbackData, out var handler))
                return handler();

            return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu());
        }
    }
}