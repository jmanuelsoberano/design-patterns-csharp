using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Invoice;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Summary;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Shipping;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Shipping.Factories;

namespace DesignPatterns.Factory.Example01.Version04.Business;

public class SwedenPurchaseProviderFactory : IPurchaseProviderFactory
{
    public IInvoice CreateInvoice(Order order)
    {
        if (order.Recipient.Country != order.Sender.Country) return new NoVATInvoice();

        return new VATInvoice();
    }

    public ShippingProvider CreateShippingProvider(Order order)
    {
        ShippingProviderFactory shippingProviderFactory;

        if (order.Sender.Country != order.Recipient.Country)
            shippingProviderFactory = new GlobalExpressShippingProviderFactory();
        else
            shippingProviderFactory = new StandardShippingProviderFactory();

        return shippingProviderFactory.GetShippingProvider(order.Sender.Country);
    }

    public ISummary CreateSummary(Order order)
    {
        // Translate email to Swedish
        return new EmailSummary();
    }
}