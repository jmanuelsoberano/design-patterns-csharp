namespace DesignPatterns.Mediator.Example01.Version03.Business;

public class ConcreteMediator : Mediator
{
    private readonly List<Colleague> colleagues = new();

    public T CreateColleague<T>() where T : Colleague, new()
    {
        var c = new T();
        c.SetMediator(this);
        colleagues.Add(c);
        return c;
    }

    public override void Send(string message, Colleague colleague)
    {
        colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
    }
}
