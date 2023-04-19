using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

namespace SimpleTelegramSender;

    public class Sender
    {
    private TelegramBotClient _botClient;
    private long _chatId;
    private CancellationTokenSource _ct = new();

    public Sender(string token, long chatId)
    {
        _botClient = new TelegramBotClient(token);
        _chatId = chatId;
    }

    public async Task SendMessageAsync(string message)
    {
        await _botClient.SendTextMessageAsync(
            chatId: _chatId,
            text: message,
            cancellationToken: _ct.Token);
    }
}
