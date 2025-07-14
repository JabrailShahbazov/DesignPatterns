namespace DecoratorPattern.Decorators;

public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription() => _coffee.GetDescription() + ", Şokolad";
    
    public override double GetCost() => _coffee.GetCost() + 0.7;
}
