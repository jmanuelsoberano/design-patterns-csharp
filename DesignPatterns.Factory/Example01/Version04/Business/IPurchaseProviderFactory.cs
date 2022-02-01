using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Invoice;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Summary;
using DesignPatterns.Factory.Example01.Version04.Business.Models.Shipping;

namespace DesignPatterns.Factory.Example01.Version04.Business;

public interface IPurchaseProviderFactory
{
    ShippingProvider CreateShippingProvider(Order order);
    IInvoice CreateInvoice(Order order);
    ISummary CreateSummary(Order order);
}