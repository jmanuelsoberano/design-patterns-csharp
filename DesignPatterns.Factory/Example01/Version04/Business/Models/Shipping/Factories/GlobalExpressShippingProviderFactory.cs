namespace DesignPatterns.Factory.Example01.Version04.Business.Models.Shipping.Factories;

public class GlobalExpressShippingProviderFactory : ShippingProviderFactory
{
    public override ShippingProvider CreateShippingProvider(string country)
    {
        return new GlobalExpressShippingProvider();
    }
}