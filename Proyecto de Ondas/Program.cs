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
                var me = await Bot.GetMeAsync();
                Console.WriteLine($"Bot iniciado: @{me.Username}");

                var cts = new CancellationTokenSource();

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

            var (response, keyboard, imageUrl) = WaveService.ProcessCommand(messageText);

            if (imageUrl != null)
            {
                await botClient.SendPhotoAsync(
                    chatId: chatId,
                    photo: imageUrl, // URL directamente
                    caption: response,
                    parseMode: ParseMode.Markdown,
                    replyMarkup: keyboard,
                    cancellationToken: cancellationToken
                );
            }
            else
            {
                await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: response,
                    parseMode: ParseMode.Markdown,
                    replyMarkup: keyboard,
                    cancellationToken: cancellationToken
                );
            }
        }

        private static async Task HandleCallbackQuery(ITelegramBotClient botClient, CallbackQuery callbackQuery, CancellationToken cancellationToken)
        {
            var chatId = callbackQuery.Message?.Chat.Id;
            var messageId = callbackQuery.Message?.MessageId;
            var callbackData = callbackQuery.Data;

            if (chatId == null || messageId == null) return;

            Console.WriteLine($"Callback recibido: {callbackData}");

            try
            {
                await botClient.AnswerCallbackQueryAsync(callbackQuery.Id, cancellationToken: cancellationToken);

                var (response, keyboard, imageUrl) = WaveService.ProcessCallbackQuery(callbackData);

                // Eliminar el mensaje anterior para evitar que la imagen anterior persista
                try
                {
                    await botClient.DeleteMessageAsync(
                        chatId: chatId,
                        messageId: (int)messageId,
                        cancellationToken: cancellationToken
                    );
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al eliminar mensaje anterior: {ex.Message}");
                }

                if (imageUrl != null)
                {
                    try
                    {
                        Console.WriteLine($"Intentando enviar imagen desde URL: {imageUrl}");
                        await botClient.SendPhotoAsync(
                            chatId: chatId,
                            photo: imageUrl,
                            caption: response,
                            parseMode: ParseMode.Markdown,
                            replyMarkup: keyboard,
                            cancellationToken: cancellationToken
                        );
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error al enviar imagen desde URL: {ex.Message}");
                        await botClient.SendTextMessageAsync(
                            chatId: chatId,
                            text: response + "\n\n⚠️ *No se pudo cargar la imagen. Verifica que la URL sea válida y accesible.*",
                            parseMode: ParseMode.Markdown,
                            replyMarkup: keyboard,
                            cancellationToken: cancellationToken
                        );
                    }
                }
                else
                {
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