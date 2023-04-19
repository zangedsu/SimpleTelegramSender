using Telegram.Bot;

namespace SimpleTelegramSender;

    public class Sender
    {
    private TelegramBotClient _botClient;
    private long _chatId;
    private CancellationTokenSource _ct = new();

    public Sender(string token, long chatId)
    {
        if (!string.IsNullOrEmpty(token) && chatId != 0)
        {
            _botClient = new TelegramBotClient(token);
            _chatId = chatId;
        }
        else { throw new ArgumentException("Chat ID and telegram bot token cannot be empty"); }
    }

    public async Task SendMessageAsync(string message)
    {
        await _botClient.SendTextMessageAsync(
            chatId: _chatId,
            text: message,
            cancellationToken: _ct.Token);
    }
}
