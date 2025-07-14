namespace DecoratorPattern;

public class SimpleCoffee : ICoffee
{
    public string GetDescription() => "Sadə qəhvə";
    
    public double GetCost() => 2.0;
}