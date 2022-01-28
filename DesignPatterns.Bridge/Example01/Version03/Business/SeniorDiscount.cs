namespace DesignPatterns.Bridge.Example01.Version03.Business;

public class SeniorDiscount : Discount
{
    public override int GetDiscount()
    {
        return 20;
    }
}