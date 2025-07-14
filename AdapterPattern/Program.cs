using AdapterPattern;
using AdapterPattern.Adapter;
using AdapterPattern.NewService;

var whatsAppService = new WhatsAppService();
INotification notification = new WhatsAppAdapter(whatsAppService);

notification.Send("Adapter Pattern izahı hazırdır!");