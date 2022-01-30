using DesignPatterns.Factory.Example01.Version03.Business;
using DesignPatterns.Factory.Example01.Version03.Business.Models.Commerce;
using DesignPatterns.Factory.Example01.Version03.Business.Models.Shipping.Factories;

namespace DesignPatterns.Factory.Example01.Version03;

public class Example
{
    public void Execute()
    {
        #region Create Order

        Console.Write("Recipient Country: ");
        var recipientCountry = Console.ReadLine().Trim();

        Console.Write("Sender Country: ");
        var senderCountry = Console.ReadLine().Trim();

        Console.Write("Total Order Weight: ");
        var totalWeight = Convert.ToInt32(Console.ReadLine().Trim());

        var order = new Order
        {
            Recipient = new Address
            {
                To = "Filip Ekberg",
                Country = recipientCountry
            },

            Sender = new Address
            {
                To = "Someone else",
                Country = senderCountry
            },

            TotalWeight = totalWeight
        };

        order.LineItems.Add(new Item("CSHARP_SMORGASBORD", "C# Smorgasbord", 100m), 1);
        order.LineItems.Add(new Item("CONSULTING", "Building a website", 100m), 1);

        #endregion

        var cart = new ShoppingCart(order, new StandardShippingProviderFactory());

        var shippingLabel = cart.Finalize();

        Console.WriteLine(shippingLabel);
    }
}