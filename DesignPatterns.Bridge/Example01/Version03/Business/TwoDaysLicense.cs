namespace DesignPatterns.Bridge.Example01.Version03.Business;

public class TwoDaysLicense : MovieLicense
{
    public TwoDaysLicense(string movie, DateTime purchaseTime, Discount discount, SpecialOffer? specialOffer = null)
        : base(movie, purchaseTime, discount, specialOffer)
    {
    }

    protected override decimal GetPriceCore()
    {
        return 4;
    }

    public override DateTime? GetExpirationDateCore()
    {
        return PurchaseTime.AddDays(2);
    }
}