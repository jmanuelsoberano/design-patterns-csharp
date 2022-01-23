using DesignPatterns.Strategy.Example01.Version02.Business.Models;
using DesignPatterns.Strategy.Example01.Version02.Business.Strategies.SalesTax;

namespace DesignPatterns.Strategy.Example01.Version02;

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

        var destination = order.ShippingDetails.DestinationCountry.ToLowerInvariant();

        if (destination == "sweden") order.SalesTaxStrategy = new SwedenSalesTaxStrategy();
        else if (destination == "us") order.SalesTaxStrategy = new USAStateSalesTaxStrategy();

        order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m, ItemType.Literature), 1);
        order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m, ItemType.Service), 1);

        Console.WriteLine(order.GetTax());
    }
}