namespace DesignPatterns.ChainOfResponsibility.Example02.Version02.Business.Models;

public class Order
{
    public Dictionary<Item, int> LineItems { get; } = new Dictionary<Item, int>();

    public IList<Payment> SelectedPayments { get; } = new List<Payment>();

    public IList<Payment> FinalizedPayments { get; } = new List<Payment>();

    public decimal AmountDue => LineItems.Sum(item => item.Key.Price * item.Value) - FinalizedPayments.Sum(payment => payment.Amount);

    public ShippingStatus ShippingStatus { get; set; } = ShippingStatus.WaitingForPayment;
}