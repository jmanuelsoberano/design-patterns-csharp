namespace DesignPatterns.Bridge.Example01.Version03.Business;

public class NoDiscount : Discount
{
    public override int GetDiscount()
    {
        return 0;
    }
}