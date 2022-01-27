namespace DesignPatterns.Bridge.Example01.Version02.Business;

internal class MilitaryLifeLongLicense : LifeLongLicense
{
    public MilitaryLifeLongLicense(string movie, DateTime purchaseTime) : base(movie, purchaseTime)
    {
    }

    public override decimal GetPrice()
    {
        return base.GetPrice() * 0.9m;
    }
}