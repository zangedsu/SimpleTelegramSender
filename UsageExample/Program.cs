using SimpleTelegramSender;
try
{
    var sender = new Sender("TG_BOT_HERE", 111);
    sender.SendMessageAsync("Hello World!!");
}
catch(Exception ex) { Console.WriteLine(ex.Message); }
Console.ReadLine();