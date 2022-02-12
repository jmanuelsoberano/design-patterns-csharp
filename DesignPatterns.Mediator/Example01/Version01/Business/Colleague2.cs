namespace DesignPatterns.Mediator.Example01.Version01.Business.Structural;

public class Colleague2 : Colleague
{
    public Colleague2(Mediator mediator) : base(mediator)
    {
    }

    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague2 receives notification message: {message}");
    }
}