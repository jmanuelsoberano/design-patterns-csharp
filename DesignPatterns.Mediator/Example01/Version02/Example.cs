using DesignPatterns.Mediator.Example01.Version02.Business;

namespace DesignPatterns.Mediator.Example01.Version02;

public class Example
{
    public void Execute()
    {
        var mediator = new ConcreteMediator();
        var c1 = new Colleague1();
        var c2 = new Colleague2();
        mediator.Register(c1);
        mediator.Register(c2);

        c1.Send("Hello, World! (from c1)");
        c2.Send("hi, there! (from c2)");
    }
}