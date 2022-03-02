namespace DesignPatterns.Decorator.Example01.Version02.Business;

public class SkilledPastryChef : PastryChef
{
    protected static int OVEN_DELAY = 1;
    private PastryChef _next;

    public SkilledPastryChef(PastryChef pastryChef)
    {
        _next = pastryChef;
    }

    public override void Beat()
    {
        Console.WriteLine("Showing how to beat eggs to the apprentice (skilledPastryChef)");
        _next.Beat();
    }

    public override void Bake()
    {
        Console.WriteLine("Showing how to bake to the apprentice (skilledPastryChef)");
        _next.Bake();
    }
}