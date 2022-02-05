using DesignPatterns.Facade.Example03.Version01.Business;

namespace DesignPatterns.Facade.Example03.Version01;

public class Example
{
    public void Execute()
    {
        var serviceA = new ServiceA();
        var sAResult = serviceA.Method2();

        var serviceB = new ServiceB();
        var sBResult = serviceB.Method2();

        var serviceC = new ServiceC();
        var sCResult = serviceC.Method1();

        Console.WriteLine(sAResult + " - " + sCResult + " - " + sBResult);
    }
}