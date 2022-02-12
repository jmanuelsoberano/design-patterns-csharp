using DesignPatterns.Mediator.Example01.Version01.Business.Structural;

namespace DesignPatterns.Mediator.Example01.Version01;

public class Example
{
    public void Execute()
    {
        var mediator = new ConcreteMediator();
        var c1 = new Colleague1(mediator);
        var c2 = new Colleague2(mediator);
        mediator.Colleague1 = c1;
        mediator.Colleague2 = c2;

        c1.Send("Hello, World! (from c1)");
        c2.Send("hi, there! (from c2)");
    }
}