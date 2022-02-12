namespace DesignPatterns.Mediator.Example01.Version01.Business.Structural;

public abstract class Colleague
{
    protected Mediator mediator;

    public Colleague(Mediator mediator)
    {
        this.mediator = mediator;
    }

    public virtual void Send(string message)
    {
        mediator.Send(message, this);
    }

    public abstract void HandleNotification(string message);
}
