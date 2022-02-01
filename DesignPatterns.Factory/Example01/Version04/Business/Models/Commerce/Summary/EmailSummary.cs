namespace DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Summary;

public class EmailSummary : ISummary
{
    public string CreateOrderSummary(Order order)
    {
        return "This is an email summary";
    }

    public void Send()
    {
    }
}