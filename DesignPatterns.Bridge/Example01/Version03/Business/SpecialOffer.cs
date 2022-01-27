namespace DesignPatterns.Bridge.Example01.Version03.Business;

public abstract class SpecialOffer
{
    public abstract TimeSpan GetExpirationDate();
}

public class TwoDaysExtensionSpecialOffer : SpecialOffer
{
    public override TimeSpan GetExpirationDate()
    {
        return TimeSpan.FromDays(2);
    }
}

public class NoneSpecialOffer : SpecialOffer
{
    public override TimeSpan GetExpirationDate()
    {
        return TimeSpan.Zero;
    }
}