using DesignPatterns.Strategy.Example01.Version05.Business.Models;
using DesignPatterns.Strategy.Example01.Version05.Business.Strategies.Invoice;
using DesignPatterns.Strategy.Example01.Version05.Business.Strategies.SalesTax;

namespace DesignPatterns.Strategy.Example01.Version05;

public class Example
{
    public void Execute()
    {
        var order = new Order
        {
            ShippingDetails = new ShippingDetails
            {
                OriginCountry = "Sweden",
                DestinationCountry = "Sweden"
            },
            SalesTaxStrategy = new SwedenSalesTaxStrategy(),
            InvoiceStrategy = new FileInvoiceStrategy()
        };
        order.SelectedPayments.Add(new Payment { PaymentProvider = PaymentProvider.Invoice });
        order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);

        Console.WriteLine(order.GetTax());

        order.FinalizeOrder();
    }
}