namespace DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Handlers;

public interface IHandler<T> where T : class
{
    IHandler<T> SetNext(IHandler<T> next);
    void Handle(T request);
}