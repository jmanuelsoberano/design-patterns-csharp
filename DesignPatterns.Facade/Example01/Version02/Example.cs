using DesignPatterns.Facade.Example01.Version02.Business;

namespace DesignPatterns.Facade.Example01.Version02;

public class Example
{
    public void Execute()
    {
        var bigClass = new BigClassFacade();

        bigClass.IncreaseBy(50);
        bigClass.DecreaseBy(20);

        Console.WriteLine($"Final Number : {bigClass.GetCurrentValue()}");
    }
}