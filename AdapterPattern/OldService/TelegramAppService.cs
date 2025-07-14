namespace AdapterPattern.OldService;

public class TelegramAppService : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"📧 Email: {message}");
    }
}
