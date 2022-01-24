namespace DesignPatterns.Strategy.Example01.Version04.Business.Models;

public class Payment
{
    public decimal Amount { get; set; }
    public PaymentProvider PaymentProvider { get; set; }
}