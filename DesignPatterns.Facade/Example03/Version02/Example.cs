using DesignPatterns.Facade.Example03.Version02.Business;

namespace DesignPatterns.Facade.Example03.Version02;

public class Example
{
    public void Execute()
    {
        IServiceFacade facade = new ServiceFacade();

        var result = facade.CallFacade();

        Console.WriteLine(result.Item1 + " - " + result.Item2 + " - " + result.Item3);
    }
}