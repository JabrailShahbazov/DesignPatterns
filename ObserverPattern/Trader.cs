namespace ObserverPattern;

public class Trader: IObserver
{
    private readonly string _name;
    public Trader(string name) => _name = name;

    public void Update(string message)
    {
        Console.WriteLine($"{_name} xəbər aldı: {message}");
    }
}