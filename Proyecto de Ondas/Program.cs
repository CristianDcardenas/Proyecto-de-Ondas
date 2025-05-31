using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Proyecto_de_Ondas
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient(BotConfig.BotToken);
        private static readonly WaveService WaveService = new WaveService();

        static void Main(string[] args)
        {
            try
            {
                var cts = new CancellationTokenSource();
                Bot.StartReceiving(
                    updateHandler: HandleUpdateAsync,
                    pollingErrorHandler: HandleErrorAsync,
                    receiverOptions: new Telegram.Bot.Polling.ReceiverOptions(),
                    cancellationToken: cts.Token
                );

                Console.WriteLine("Bot iniciado. Presiona Enter para detenerlo...");
                Console.ReadLine();

                cts.Cancel();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al iniciar el bot: {ex.Message}");
                Console.ReadLine();
            }
        }

        private static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            try
            {
                if (update.Type == UpdateType.Message && update.Message.Type == MessageType.Text)
                {
                    var messageText = update.Message.Text;
                    var chatId = update.Message.Chat.Id;
                    var (response, keyboard) = WaveService.ProcessCommand(messageText);
                    await botClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: response,
                        parseMode: ParseMode.Markdown,
                        replyMarkup: keyboard,
                        cancellationToken: cancellationToken
                    );
                }
                else if (update.Type == UpdateType.CallbackQuery)
                {
                    var callbackQuery = update.CallbackQuery;
                    var chatId = callbackQuery.Message.Chat.Id;
                    var (response, keyboard) = WaveService.ProcessCallbackQuery(callbackQuery.Data);
                    await botClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: response,
                        parseMode: ParseMode.Markdown,
                        replyMarkup: keyboard,
                        cancellationToken: cancellationToken
                    );
                    await botClient.DeleteMessageAsync(chatId, callbackQuery.Message.MessageId, cancellationToken);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar la actualización: {ex.Message}");
            }
        }

        private static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Error: {exception.Message}");
            return Task.CompletedTask;
        }
    }
}