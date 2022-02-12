using DesignPatterns.Mediator.Example01.Version03.Business;

namespace DesignPatterns.Mediator.Example01.Version03;

public class Example
{
    public void Execute()
    {
        var mediator = new ConcreteMediator();
        var c1 = mediator.CreateColleague<Colleague1>();
        var c2 = mediator.CreateColleague<Colleague2>();

        c1.Send("Hello, World! (from c1)");
        c2.Send("hi, there! (from c2)");
    }
}