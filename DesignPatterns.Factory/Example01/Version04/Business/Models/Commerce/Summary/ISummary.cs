namespace DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Summary;

public interface ISummary
{
    string CreateOrderSummary(Order order);

    void Send();
}