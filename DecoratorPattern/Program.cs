using DecoratorPattern;
using DecoratorPattern.Decorators;

ICoffee coffee = new SimpleCoffee();
coffee = new MilkDecorator(coffee);
coffee = new ChocolateDecorator(coffee);

Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost());