using DesignPatterns.Facade.Example01.Version01.Business;

namespace DesignPatterns.Facade.Example01.Version01;

public class Example
{
    public void Execute()
    {
        var bigClass = new BigClass();

        bigClass.SetValueI(3);

        bigClass.IncrementI();
        bigClass.IncrementI();
        bigClass.IncrementI();

        bigClass.DecrememntI();

        Console.WriteLine($"Final Number : {bigClass.GetValueB()}");
    }
}