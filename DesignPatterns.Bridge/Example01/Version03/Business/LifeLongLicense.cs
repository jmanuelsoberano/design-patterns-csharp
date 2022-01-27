namespace DesignPatterns.Bridge.Example01.Version03.Business;

public class LifeLongLicense : MovieLicense
{
    public LifeLongLicense(string movie, DateTime purchaseTime, Discount discount, SpecialOffer? specialOffer = null)
        : base(movie, purchaseTime, discount, specialOffer)
    {
    }

    protected override decimal GetPriceCore()
    {
        return 8;
    }

    public override DateTime? GetExpirationDateCore()
    {
        return null;
    }
}