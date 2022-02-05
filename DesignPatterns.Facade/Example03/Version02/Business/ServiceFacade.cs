namespace DesignPatterns.Facade.Example03.Version02.Business;

public class ServiceFacade : IServiceFacade
{
    private readonly ServiceA _serviceA = new();
    private readonly ServiceB _serviceB = new();
    private readonly ServiceC _serviceC = new();

    public Tuple<int, double, string> CallFacade()
    {
        var SAResult = _serviceA.Method2();
        var SBResult = _serviceB.Method2();
        var SCResult = _serviceC.Method1();

        return new Tuple<int, double, string>(SAResult, SCResult, SBResult);
    }
}
