namespace StrategyPattern;

public class WalkStrategy : ITravelStrategy
{
    public void GoToWork() => Console.WriteLine("Piyada işə gedirəm. 🚶‍♂️");
}

public class CarStrategy : ITravelStrategy
{
    public void GoToWork() => Console.WriteLine("Maşınla işə gedirəm. 🚗");
}

public class BikeStrategy : ITravelStrategy
{
    public void GoToWork() => Console.WriteLine("Velosipedlə işə gedirəm. 🚲");
}