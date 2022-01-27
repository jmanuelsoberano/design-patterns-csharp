namespace DesignPatterns.Strategy.Example01.Version05.Business.Models;

public class Payment
{
    public decimal Amount { get; set; }
    public PaymentProvider PaymentProvider { get; set; }
}