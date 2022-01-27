namespace DesignPatterns.ChainOfResponsibility.Example02.Version02.Business.Handlers
{
    public interface IReceiver<T> where T : class
    {
        void Handle(T request);
    }
}
