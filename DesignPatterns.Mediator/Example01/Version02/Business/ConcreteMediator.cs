namespace DesignPatterns.Mediator.Example01.Version02.Business;

public class ConcreteMediator : Mediator
{
    private readonly List<Colleague> colleagues = new();

    public void Register(Colleague colleague)
    {
        colleague.SetMediator(this);
        colleagues.Add(colleague);
    }

    public override void Send(string message, Colleague colleague)
    {
        colleagues.Where(c => c != colleague).ToList().ForEach(c => c.HandleNotification(message));
    }
}
