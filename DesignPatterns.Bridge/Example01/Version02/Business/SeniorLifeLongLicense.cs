namespace DesignPatterns.Bridge.Example01.Version02.Business;

internal class SeniorLifeLongLicense : LifeLongLicense
{
    public SeniorLifeLongLicense(string movie, DateTime purchaseTime) : base(movie, purchaseTime)
    {
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() * 0.8m;
    }
}