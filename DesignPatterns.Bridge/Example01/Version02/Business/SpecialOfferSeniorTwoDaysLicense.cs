namespace DesignPatterns.Bridge.Example01.Version02.Business;

public class SpecialOfferSeniorTwoDaysLicense : SeniorTwoDaysLicense
{
    public SpecialOfferSeniorTwoDaysLicense(string movie, DateTime purchaseTime) : base(movie, purchaseTime)
    {
    }

    public override DateTime? GetExpirationDate()
    {
        var expiraDate = base.GetExpirationDate();
        return expiraDate?.AddDays(2);
    }
}