namespace DesignPatterns.Bridge.Example01.Version03.Business;

public abstract class Discount
{
    public abstract int GetDiscount();
}

public class SeniorDiscount : Discount
{
    public override int GetDiscount()
    {
        return 20;
    }
}

internal class MilitaryDiscount : Discount
{
    public override int GetDiscount()
    {
        return 10;
    }
}

public class NoDiscount : Discount
{
    public override int GetDiscount()
    {
        return 0;
    }
}