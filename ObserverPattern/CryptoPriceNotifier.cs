namespace ObserverPattern;

public class CryptoPriceNotifier
{
    private readonly List<IObserver> _observers = new();

    public void Subscribe(IObserver observer) => _observers.Add(observer);
    public void Unsubscribe(IObserver observer) => _observers.Remove(observer);

    public void Notify(string message)
    {
        foreach (var observer in _observers)
            observer.Update(message);
    }

    public void PriceChanged(string crypto, double price)
    {
        string msg = $"{crypto} qiyməti {price}$ oldu.";
        Console.WriteLine($"📢 {msg}");
        Notify(msg);
    }
}