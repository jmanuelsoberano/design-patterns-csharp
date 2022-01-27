namespace DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Models;

public class Payment
{
    public decimal Amount { get; set; }
    public PaymentProvider PaymentProvider { get; set; }
}