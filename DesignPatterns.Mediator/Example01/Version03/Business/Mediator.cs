namespace DesignPatterns.Mediator.Example01.Version03.Business;

public abstract class Mediator
{
    public abstract void Send(string message, Colleague colleague);
}