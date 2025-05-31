using Proyecto_de_Ondas;
using Telegram.Bot.Types.ReplyMarkups;

namespace Proyecto_de_Ondas
{
    public class WaveService
    {
        public (string, InlineKeyboardMarkup) ProcessCommand(string command)
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

        public (string, InlineKeyboardMarkup) ProcessCallbackQuery(string callbackData)
        {
            switch (callbackData)
            {
                case "definition":
                    return (WaveData.Responses.Definition, WaveData.GetMainMenu());
                case "types":
                    return (WaveData.Responses.Types, WaveData.GetMainMenu());
                case "properties":
                    return (WaveData.Responses.Properties, WaveData.GetMainMenu());
                case "equations":
                    return (WaveData.Responses.Equations, WaveData.GetMainMenu());
                case "applications":
                    return (WaveData.Responses.Applications, WaveData.GetMainMenu());
                case "polarization":
                    return (WaveData.Responses.Polarization, WaveData.GetMainMenu());
                case "propagation":
                    return (WaveData.Responses.Propagation, WaveData.GetMainMenu());
                case "spectrum":
                    return (WaveData.Responses.Spectrum, WaveData.GetMainMenu());
                default:
                    return (WaveData.Responses.UnknownCommand, WaveData.GetMainMenu());
            }
        }
    }
}