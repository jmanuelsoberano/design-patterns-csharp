namespace DesignPatterns.Facade.Example03.Version02.Business;

public interface IServiceFacade
{
    Tuple<int, double, string> CallFacade();
}