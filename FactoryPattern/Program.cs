using FactoryPattern;

var notification = NotificationFactory.Create("email");
notification.Send("Factory Pattern öyrənmək rahatdır!");

var smsNotification = NotificationFactory.Create("sms");
smsNotification.Send("Bu SMS Factory Pattern ilə göndərildi!");