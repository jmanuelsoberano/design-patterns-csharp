using DesignPatterns.Factory.Example01.Version02.Business.Models.Commerce;
using DesignPatterns.Factory.Example01.Version02.Business.Models.Shipping;

namespace DesignPatterns.Factory.Example01.Version02.Business;

public class ShoppingCart
{
    private readonly Order order;

    public ShoppingCart(Order order)
    {
        this.order = order;
    }

    public string Finalize()    
    {
        var shippingProvider = ShippingProviderFactory.CreateShippingProvider(order.Sender.Country);

        order.ShippingStatus = ShippingStatus.ReadyForShippment;

        return shippingProvider.GenerateShippingLabelFor(order);
    }
}