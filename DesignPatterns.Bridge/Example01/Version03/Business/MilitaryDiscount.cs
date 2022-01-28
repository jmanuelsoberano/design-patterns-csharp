namespace DesignPatterns.Bridge.Example01.Version03.Business;

internal class MilitaryDiscount : Discount
{
    public override int GetDiscount()
    {
        return 10;
    }
}