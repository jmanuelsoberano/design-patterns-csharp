namespace DesignPatterns.Bridge.Example01.Version02.Business;

public class SeniorTwoDaysLicense : TwoDaysLicense
{
    public SeniorTwoDaysLicense(string movie, DateTime purchaseTime)
        : base(movie, purchaseTime)
    {
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() * 0.8m;
    }
}