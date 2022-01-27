namespace DesignPatterns.Bridge.Example01.Version03.Business;

public abstract class MovieLicense
{
    private readonly Discount _discount;
    private readonly SpecialOffer _specialOffer;

    protected MovieLicense(string movie, DateTime purchaseTime, Discount discount, SpecialOffer? specialOffer)
    {
        _discount = discount;
        _specialOffer = specialOffer ?? new NoneSpecialOffer();
        Movie = movie;
        PurchaseTime = purchaseTime;
    }

    public decimal GetPrice()
    {
        var discount = _discount.GetDiscount();
        var multiplier = 1 - discount / 100m;
        return GetPriceCore() * multiplier;
    }

    public string Movie { get; }
    public DateTime PurchaseTime { get; }

    protected abstract decimal GetPriceCore();

    public DateTime? GetExpirationDate()
    {
        var expirationDateCore = GetExpirationDateCore();
        return expirationDateCore?.Add(_specialOffer.GetExpirationDate());
    }

    public abstract DateTime? GetExpirationDateCore();

    protected TimeSpan GetSpecialOfferExtension()
    {
        return _specialOffer.GetExpirationDate();
    }
}