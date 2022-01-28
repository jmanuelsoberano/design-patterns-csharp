namespace DesignPatterns.Bridge.Example01.Version03.Business;

public class TwoDaysExtensionSpecialOffer : SpecialOffer
{
    public override TimeSpan GetExpirationDate()
    {
        return TimeSpan.FromDays(2);
    }
}