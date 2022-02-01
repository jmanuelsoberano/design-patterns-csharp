using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Invoice;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Summary;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Shipping;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Shipping.Factories;

namespace DesignPatterns.Factory.Example01.Version04.Business;

public class AustraliaPurchaseProviderFactory : IPurchaseProviderFactory
{
    public IInvoice CreateInvoice(Order order)
    {
        return new GSTInvoice();
    }

    public ShippingProvider CreateShippingProvider(Order order)
    {
        var shippingProviderFactory = new StandardShippingProviderFactory();

        return shippingProviderFactory.GetShippingProvider(order.Sender.Country);
    }

    public ISummary CreateSummary(Order order)
    {
        return new CsvSummary();
    }
}