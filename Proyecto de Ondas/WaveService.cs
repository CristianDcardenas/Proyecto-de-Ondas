using Telegram.Bot.Types.ReplyMarkups;

namespace Proyecto_de_Ondas
{
    public class WaveService
    {
        public (string response, InlineKeyboardMarkup keyboard) ProcessCommand(string command)
        {
            switch (command.ToLower())
            {
                case "/start":
                    return (WaveData.Responses.WelcomeMessage, WaveData.GetMainMenu());
                case "/help":
                    return (WaveData.Responses.HelpMessage, WaveData.GetMainMenu());
                case "/info":
                    return (WaveData.Responses.InfoMessage, WaveData.GetMainMenu());
                default:
                    return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu());
            }
        }

        public (string response, InlineKeyboardMarkup keyboard) ProcessCallbackQuery(string callbackData)
        {
            switch (callbackData)
            {
                // Menús
                case "main_menu":
                    return (WaveData.Responses.WelcomeMessage, WaveData.GetMainMenu());
                case "definition_menu":
                    return ("📚 *Definición*\nSelecciona una opción:", WaveData.GetDefinitionSubMenu());
                case "types_menu":
                    return ("📡 *Tipos*\nSelecciona una opción:", WaveData.GetTypesSubMenu());
                case "properties_menu":
                    return ("⚙️ *Propiedades*\nSelecciona una opción:", WaveData.GetPropertiesSubMenu());
                case "equations_menu":
                    return ("📝 *Ecuaciones*\nSelecciona una opción:", WaveData.GetEquationsSubMenu());
                case "applications_menu":
                    return ("🚀 *Aplicaciones*\nSelecciona una opción:", WaveData.GetApplicationsSubMenu());
                case "polarization_menu":
                    return ("🔄 *Polarización*\nSelecciona una opción:", WaveData.GetPolarizationSubMenu());
                case "propagation_menu":
                    return ("🌐 *Propagación*\nSelecciona una opción:", WaveData.GetPropagationSubMenu());
                case "spectrum_menu":
                    return ("📊 *Espectro*\nSelecciona una opción:", WaveData.GetSpectrumSubMenu());

                // Definición
                case "definition_overview":
                    return (WaveData.Responses.Definition_Overview, WaveData.GetDefinitionSubMenu());
                case "definition_history":
                    return (WaveData.Responses.Definition_History, WaveData.GetDefinitionSubMenu());
                case "definition_characteristics":
                    return (WaveData.Responses.Definition_Characteristics, WaveData.GetDefinitionSubMenu());

                // Tipos
                case "types_overview":
                    return (WaveData.Responses.Types_Overview, WaveData.GetTypesSubMenu());
                case "types_radio":
                    return (WaveData.Responses.Types_RadioWaves, WaveData.GetTypesSubMenu());
                case "types_microwaves":
                    return (WaveData.Responses.Types_Microwaves, WaveData.GetTypesSubMenu());
                case "types_infrared":
                    return (WaveData.Responses.Types_Infrared, WaveData.GetTypesSubMenu());
                case "types_visible":
                    return (WaveData.Responses.Types_VisibleLight, WaveData.GetTypesSubMenu());
                case "types_ultraviolet":
                    return (WaveData.Responses.Types_Ultraviolet, WaveData.GetTypesSubMenu());
                case "types_xrays":
                    return (WaveData.Responses.Types_XRays, WaveData.GetTypesSubMenu());
                case "types_gamma":
                    return (WaveData.Responses.Types_GammaRays, WaveData.GetTypesSubMenu());

                // Propiedades
                case "properties_overview":
                    return (WaveData.Responses.Properties_Overview, WaveData.GetPropertiesSubMenu());
                case "properties_frequency":
                    return (WaveData.Responses.Properties_Frequency, WaveData.GetPropertiesSubMenu());
                case "properties_wavelength":
                    return (WaveData.Responses.Properties_Wavelength, WaveData.GetPropertiesSubMenu());
                case "properties_speed":
                    return (WaveData.Responses.Properties_Speed, WaveData.GetPropertiesSubMenu());
                case "properties_energy":
                    return (WaveData.Responses.Properties_Energy, WaveData.GetPropertiesSubMenu());
                case "properties_amplitude":
                    return (WaveData.Responses.Properties_Amplitude, WaveData.GetPropertiesSubMenu());
                case "properties_transversal":
                    return (WaveData.Responses.Properties_Transversal, WaveData.GetPropertiesSubMenu());
                case "properties_vacuum":
                    return (WaveData.Responses.Properties_Vacuum, WaveData.GetPropertiesSubMenu());

                // Ecuaciones
                case "equations_overview":
                    return (WaveData.Responses.Equations_Overview, WaveData.GetEquationsSubMenu());
                case "equations_speed":
                    return (WaveData.Responses.Equations_Speed, WaveData.GetEquationsSubMenu());
                case "equations_energy":
                    return (WaveData.Responses.Equations_Energy, WaveData.GetEquationsSubMenu());
                case "equations_maxwell":
                    return (WaveData.Responses.Equations_Maxwell, WaveData.GetEquationsSubMenu());

                // Aplicaciones
                case "applications_overview":
                    return (WaveData.Responses.Applications_Overview, WaveData.GetApplicationsSubMenu());
                case "applications_radio":
                    return (WaveData.Responses.Applications_RadioWaves, WaveData.GetApplicationsSubMenu());
                case "applications_microwaves":
                    return (WaveData.Responses.Applications_Microwaves, WaveData.GetApplicationsSubMenu());
                case "applications_infrared":
                    return (WaveData.Responses.Applications_Infrared, WaveData.GetApplicationsSubMenu());
                case "applications_visible":
                    return (WaveData.Responses.Applications_VisibleLight, WaveData.GetApplicationsSubMenu());
                case "applications_ultraviolet":
                    return (WaveData.Responses.Applications_Ultraviolet, WaveData.GetApplicationsSubMenu());
                case "applications_xrays":
                    return (WaveData.Responses.Applications_XRays, WaveData.GetApplicationsSubMenu());
                case "applications_gamma":
                    return (WaveData.Responses.Applications_GammaRays, WaveData.GetApplicationsSubMenu());

                // Polarización
                case "polarization_overview":
                    return (WaveData.Responses.Polarization_Overview, WaveData.GetPolarizationSubMenu());
                case "polarization_linear":
                    return (WaveData.Responses.Polarization_Linear, WaveData.GetPolarizationSubMenu());
                case "polarization_circular":
                    return (WaveData.Responses.Polarization_Circular, WaveData.GetPolarizationSubMenu());
                case "polarization_elliptical":
                    return (WaveData.Responses.Polarization_Elliptical, WaveData.GetPolarizationSubMenu());

                // Propagación
                case "propagation_overview":
                    return (WaveData.Responses.Propagation_Overview, WaveData.GetPropagationSubMenu());
                case "propagation_vacuum":
                    return (WaveData.Responses.Propagation_Vacuum, WaveData.GetPropagationSubMenu());
                case "propagation_air":
                    return (WaveData.Responses.Propagation_Air, WaveData.GetPropagationSubMenu());
                case "propagation_materials":
                    return (WaveData.Responses.Propagation_Materials, WaveData.GetPropagationSubMenu());
                case "propagation_phenomena":
                    return (WaveData.Responses.Propagation_Phenomena, WaveData.GetPropagationSubMenu());

                // Espectro
                case "spectrum_overview":
                    return (WaveData.Responses.Spectrum_Overview, WaveData.GetSpectrumSubMenu());
                case "spectrum_radio":
                    return (WaveData.Responses.Spectrum_RadioWaves, WaveData.GetSpectrumSubMenu());
                case "spectrum_microwaves":
                    return (WaveData.Responses.Spectrum_Microwaves, WaveData.GetSpectrumSubMenu());
                case "spectrum_infrared":
                    return (WaveData.Responses.Spectrum_Infrared, WaveData.GetSpectrumSubMenu());
                case "spectrum_visible":
                    return (WaveData.Responses.Spectrum_VisibleLight, WaveData.GetSpectrumSubMenu());
                case "spectrum_ultraviolet":
                    return (WaveData.Responses.Spectrum_Ultraviolet, WaveData.GetSpectrumSubMenu());
                case "spectrum_xrays":
                    return (WaveData.Responses.Spectrum_XRays, WaveData.GetSpectrumSubMenu());
                case "spectrum_gamma":
                    return (WaveData.Responses.Spectrum_GammaRays, WaveData.GetSpectrumSubMenu());

                default:
                    return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu());
            }
        }
    }
}