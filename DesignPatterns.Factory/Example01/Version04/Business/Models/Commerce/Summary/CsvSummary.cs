namespace DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Summary;

public class CsvSummary : ISummary
{
    public string CreateOrderSummary(Order order)
    {
        return "This is a CSV summary";
    }

    public void Send()
    {
    }
}