using System;

namespace Proyecto_de_Ondas
{
    public static class BotConfig
    {
        public static readonly string BotToken = GetBotToken();

        private static string GetBotToken()
        {
            // Intentar obtener del entorno primero (más seguro)
            var token = Environment.GetEnvironmentVariable("TELEGRAM_BOT_TOKEN");

            if (!string.IsNullOrEmpty(token))
                return token;

            // Token por defecto (cambiar por el tuyo)
            return "7772298308:AAFCmedWSYxQsasr4F1xXGmOYVem_W_EqSU";
        }
    }
}