using DesignPatterns.Strategy.Example01.Version03.Business.Strategies.SalesTax;

namespace DesignPatterns.Strategy.Example01.Version03.Business.Models;

public class Order
{
    public Dictionary<Item, int> LineItems { get; } = new();

    public IList<Payment> SelectedPayments { get; } = new List<Payment>();

    public IList<Payment> FinalizedPayments { get; } = new List<Payment>();

    public decimal AmountDue => TotalPrice - FinalizedPayments.Sum(payment => payment.Amount);

    public decimal TotalPrice => LineItems.Sum(item => item.Key.Price * item.Value);

    public ShippingStatus ShippingStatus { get; set; } = ShippingStatus.WaitingForPayment;

    public ShippingDetails ShippingDetails { get; set; }

    public ISalesTaxStrategy SalesTaxStrategy { get; set; }

    public decimal GetTax()
    {
        if (SalesTaxStrategy == null) return 0m;

        return SalesTaxStrategy.GetTaxFor(this);
    }
}