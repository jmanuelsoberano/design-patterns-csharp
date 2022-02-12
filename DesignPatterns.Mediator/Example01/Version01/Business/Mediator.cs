namespace DesignPatterns.Mediator.Example01.Version01.Business.Structural;

public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}