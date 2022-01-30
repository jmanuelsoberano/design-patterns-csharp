using DesignPatterns.Factory.Example01.Version03.Business.Models.Commerce;
using DesignPatterns.Factory.Example01.Version03.Business.Models.Shipping;
using DesignPatterns.Factory.Example01.Version03.Business.Models.Shipping.Factories;

namespace DesignPatterns.Factory.Example01.Version03.Business;

public class ShoppingCart
{
    private readonly Order _order;
    private readonly ShippingProviderFactory _shippingProviderFactory;

    public ShoppingCart(Order order, ShippingProviderFactory shippingProviderFactory)
    {
        _order = order;
        _shippingProviderFactory = shippingProviderFactory;
    }

    public string Finalize()    
    {
        var shippingProvider = _shippingProviderFactory.CreateShippingProvider(_order.Sender.Country);

        _order.ShippingStatus = ShippingStatus.ReadyForShippment;

        return shippingProvider.GenerateShippingLabelFor(_order);
    }
}