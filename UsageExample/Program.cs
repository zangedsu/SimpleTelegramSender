using SimpleTelegramSender;
using System.Threading;
try
{
    var sender = new Sender("6246641246:AAGPQolVse2Ps_2jGFDOvTLwW6zEC0Dp6dU", 494650613);
    Thread.Sleep(1000);
    sender.SendMessageAsync("Hello World!!");
    

}
catch(Exception ex) { Console.WriteLine(ex.Message); }
Console.ReadLine();