namespace DesignPatterns.Bridge.Example01.Version01.Business;

public abstract class MovieLicense
{
    protected MovieLicense(string movie, DateTime purchaseTime)
    {
        Movie = movie;
        PurchaseTime = purchaseTime;
    }

    public string Movie { get; }
    public DateTime PurchaseTime { get; }

    public abstract decimal GetPrice();
    public abstract DateTime? GetExpirationDate();
}