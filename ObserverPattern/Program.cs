using ObserverPattern;

var notifier = new CryptoPriceNotifier();

var user1 = new Trader("Murad");
var user2 = new Trader("Fuad");

notifier.Subscribe(user1);
notifier.Subscribe(user2);

notifier.PriceChanged("Bitcoin", 60000);