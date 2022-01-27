namespace DesignPatterns.Bridge.Example01.Version02.Business;

public class TwoDaysLicense : MovieLicense
{
    public TwoDaysLicense(string movie, DateTime purchaseTime)
        : base(movie, purchaseTime)
    {
    }

    public override decimal GetPrice()
    {
        return 4;
    }

    public override DateTime? GetExpirationDate()
    {
        return PurchaseTime.AddDays(2);
    }
}