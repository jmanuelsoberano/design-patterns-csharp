using DesignPatterns.Strategy.Example01.Version04.Business.Models;
using DesignPatterns.Strategy.Example01.Version04.Business.Strategies.SalesTax;

namespace DesignPatterns.Strategy.Example01.Version04;

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
            }
        };

        order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);

        Console.WriteLine(order.GetTax(new SwedenSalesTaxStrategy()));
    }
}