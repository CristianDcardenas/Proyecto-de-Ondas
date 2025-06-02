using System;

namespace Proyecto_de_Ondas
{
    public static class BotConfig
    {
        public static readonly string BotToken = GetBotToken();

        private static string GetBotToken()
        {
           
            var token = Environment.GetEnvironmentVariable("TELEGRAM_BOT_TOKEN");

            if (!string.IsNullOrEmpty(token))
                return token;

           
            return "7772298308:AAFCmedWSYxQsasr4F1xXGmOYVem_W_EqSU";
        }
    }
}