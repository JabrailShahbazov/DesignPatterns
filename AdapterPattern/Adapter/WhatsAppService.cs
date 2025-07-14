namespace AdapterPattern.Adapter;

public class WhatsAppService
{
    public void SendMessage(string text)
    {
        Console.WriteLine($"💬 WhatsApp: {text}");
    }
}