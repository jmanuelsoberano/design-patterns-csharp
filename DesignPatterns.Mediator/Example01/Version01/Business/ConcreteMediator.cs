namespace DesignPatterns.Mediator.Example01.Version01.Business.Structural;

public class ConcreteMediator : Mediator
{
    public Colleague1 Colleague1 { get; set; }
    public Colleague2 Colleague2 { get; set; }

    public override void Send(string message, Colleague colleague)
    {
        if (colleague == Colleague1)
            Colleague2.HandleNotification(message);
        else
            Colleague1.HandleNotification(message);
    }
}
