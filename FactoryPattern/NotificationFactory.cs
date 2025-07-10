namespace FactoryPattern;

public class NotificationFactory
{
    public static INotification Create(string type)
    {
        return type switch
               {
                   "email" => new EmailNotification(),
                   "sms" => new SmsNotification(),
                   _ => throw new ArgumentException("❌ Notification növü düzgün deyil")
               };
    }
}