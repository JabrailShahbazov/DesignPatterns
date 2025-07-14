using AdapterPattern.Adapter;

namespace AdapterPattern.NewService;

public class WhatsAppAdapter : INotification
{
    
    private readonly WhatsAppService _whatsAppService;

    public WhatsAppAdapter(WhatsAppService whatsAppService)
    {
        _whatsAppService = whatsAppService;
    }
    
    public void Send(string message)
    {
        _whatsAppService.SendMessage(message);
    }
}