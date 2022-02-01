using DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce;

namespace DesignPatterns.Factory.Example01.Version04.Business.Models.Shipping;

public class GlobalExpressShippingProvider : ShippingProvider
{
    public override string GenerateShippingLabelFor(Order order)
    {
        return "GLOBAL-EXPRESS";
    }
}