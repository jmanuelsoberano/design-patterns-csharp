namespace DesignPatterns.Factory.Example01.Version03.Business.Models.Commerce;

public class Payment
{
    public decimal Amount { get; set; }
    public PaymentProvider PaymentProvider { get; set; }
}