using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Exceptions;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace Proyecto_de_Ondas
{
    class Program
    {
        private static readonly TelegramBotClient Bot = new TelegramBotClient(BotConfig.BotToken);
        private static readonly WaveService WaveService = new WaveService();

        static async Task Main(string[] args)
        {
            try
            {
                // Verificar que el bot funciona
                var me = await Bot.GetMeAsync();
                Console.WriteLine($"Bot iniciado: @{me.Username}");

                var cts = new CancellationTokenSource();

                // Manejar Ctrl+C
                Console.CancelKeyPress += (_, e) =>
                {
                    e.Cancel = true;
                    cts.Cancel();
                };

                Bot.StartReceiving(
                    updateHandler: HandleUpdateAsync,
                    pollingErrorHandler: HandleErrorAsync,
                    receiverOptions: new Telegram.Bot.Polling.ReceiverOptions
                    {
                        AllowedUpdates = new[] { UpdateType.Message, UpdateType.CallbackQuery }
                    },
                    cancellationToken: cts.Token
                );

                Console.WriteLine("Bot iniciado. Presiona Ctrl+C para detenerlo...");

                try
                {
                    await Task.Delay(-1, cts.Token);
                }
                catch (OperationCanceledException)
                {
                    Console.WriteLine("Bot detenido.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al iniciar el bot: {ex.Message}");
                Console.WriteLine("Presiona Enter para salir...");
                Console.ReadLine();
            }
        }

        private static async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
            try
            {
                if (update.Type == UpdateType.Message && update.Message?.Type == MessageType.Text)
                {
                    await HandleTextMessage(botClient, update.Message, cancellationToken);
                }
                else if (update.Type == UpdateType.CallbackQuery)
                {
                    await HandleCallbackQuery(botClient, update.CallbackQuery, cancellationToken);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al procesar actualización: {ex.Message}");
            }
        }

        private static async Task HandleTextMessage(ITelegramBotClient botClient, Message message, CancellationToken cancellationToken)
        {
            var messageText = message.Text;
            var chatId = message.Chat.Id;

            Console.WriteLine($"Mensaje recibido: {messageText}");

            var (response, keyboard) = WaveService.ProcessCommand(messageText);

            await botClient.SendTextMessageAsync(
                chatId: chatId,
                text: response,
                parseMode: ParseMode.Markdown,
                replyMarkup: keyboard,
                cancellationToken: cancellationToken
            );
        }

        private static async Task HandleCallbackQuery(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken)
        {
            var chatId = callbackQuery.Message?.Chat.Id;
            var callbackData = callbackQuery.Data;

            if (chatId == null) return;

            Console.WriteLine($"Callback recibido: {callbackData}");

            try
            {
                // Responder al callback query
                await botClient.AnswerCallbackQueryAsync(callbackQuery.Id, cancellationToken: cancellationToken);

                var (response, keyboard) = WaveService.ProcessCallbackQuery(callbackData);

                // Intentar editar el mensaje
                try
                {
                    await botClient.EditMessageTextAsync(
                        chatId: chatId,
                        messageId: callbackQuery.Message.MessageId,
                        text: response,
                        parseMode: ParseMode.Markdown,
                        replyMarkup: keyboard,
                        cancellationToken: cancellationToken
                    );
                }
                catch (ApiRequestException ex) when (ex.Message.Contains("message is not modified"))
                {
                    // El mensaje es igual, no hacer nada
                }
                catch
                {
                    // Si no se puede editar, enviar nuevo mensaje
                    await botClient.SendTextMessageAsync(
                        chatId: chatId,
                        text: response,
                        parseMode: ParseMode.Markdown,
                        replyMarkup: keyboard,
                        cancellationToken: cancellationToken
                    );
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en callback query: {ex.Message}");
            }
        }

        private static Task HandleErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
            string errorMessage;
            if (exception is ApiRequestException apiRequestException)
            {
                errorMessage = $"Error de API: {apiRequestException.Message}";
            }
            else
            {
                errorMessage = exception.ToString();
            }

            Console.WriteLine($"Error: {errorMessage}");
            return Task.CompletedTask;
        }
    }
}