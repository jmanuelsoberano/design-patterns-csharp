namespace DesignPatterns.Bridge.Example01.Version02.Business;

public class LifeLongLicense : MovieLicense
{
    public LifeLongLicense(string movie, DateTime purchaseTime)
        : base(movie, purchaseTime)
    {
    }

    public override decimal GetPrice()
    {
        return 8;
    }

    public override DateTime? GetExpirationDate()
    {
        return null;
    }
}