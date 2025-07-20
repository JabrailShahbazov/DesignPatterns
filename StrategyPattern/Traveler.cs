namespace StrategyPattern;

public class Traveler
{
    private ITravelStrategy _travelStrategy;

    public Traveler(ITravelStrategy travelStrategy)
    {
        _travelStrategy = travelStrategy;
    }

    public void SetStrategy(ITravelStrategy travelStrategy)
    {
        _travelStrategy = travelStrategy;
    }

    public void Go()
    {
        _travelStrategy.GoToWork();
    }
}