using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Shipping;

namespace DesignPatterns.Factory.Example01.Version04.Business;

public class ShoppingCart
{
    private readonly Order _order;
    private readonly IPurchaseProviderFactory _purchaseProviderFactory;

    public ShoppingCart(Order order, IPurchaseProviderFactory purchaseProviderFactory)
    {
        _order = order;
        _purchaseProviderFactory = purchaseProviderFactory;
    }

    public string Finalize()    
    {
        var shippingProvider = _purchaseProviderFactory.CreateShippingProvider(_order);

        var invoice = _purchaseProviderFactory.CreateInvoice(_order);

        // Send invoice

        invoice.GenerateInvoice();

        var summary = _purchaseProviderFactory.CreateSummary(_order);

        summary.Send();

        // Send summary

        _order.ShippingStatus = ShippingStatus.ReadyForShippment;

        return shippingProvider.GenerateShippingLabelFor(_order);
    }
}