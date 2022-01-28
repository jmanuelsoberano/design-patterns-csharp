namespace DesignPatterns.Bridge.Example01.Version03.Business;

public class NoneSpecialOffer : SpecialOffer
{
    public override TimeSpan GetExpirationDate()
    {
        return TimeSpan.Zero;
    }
}