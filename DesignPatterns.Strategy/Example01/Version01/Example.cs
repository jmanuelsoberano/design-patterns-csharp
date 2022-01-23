using DesignPatterns.Strategy.Example01.Version01.Business.Models;

namespace DesignPatterns.Strategy.Example01.Version01;

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
        order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m, ItemType.Service), 1);

        Console.WriteLine(order.GetTax());
    }
}