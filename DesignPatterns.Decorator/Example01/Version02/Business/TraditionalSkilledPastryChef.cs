using DesignPatterns.Decorator.Example01.Version02.Business.Util;

namespace DesignPatterns.Decorator.Example01.Version02.Business;

public class TraditionalSkilledPastryChef : SkilledPastryChef
{
    public TraditionalSkilledPastryChef(PastryChef pastryChef) : base(pastryChef)
    {
        Console.WriteLine("Creating traditionalSkilledPastryChef \n");
    }

    public override void Beat()
    {
        base.Beat();
        AddBehaviourToBeatTraditionalCookies();
    }

    public override void Bake()
    {
        base.Bake();
        AddStateToBakeTraditionalCookies();
    }

    private void AddBehaviourToBeatTraditionalCookies()
    {
        Console.WriteLine("   Adding behabiour when beating eggs (traditionalSkilledPastryChef)");
        Console.WriteLine("      Beating eggs with chocolate chips for traditional cookies");
    }

    private void AddStateToBakeTraditionalCookies()
    {
        Console.WriteLine("   Adding state when baking (traditionalSkilledPastryChef)");
        var clock = new Clock();

        if (!Oven.GetInstance().IsReady())
        {
            Console.WriteLine("      Waiting for the oven to be ready for baking (traditionalSkilledPastryChef)");
            clock.SetAlarmDelay(OVEN_DELAY);
        }

        Console.WriteLine("      Baking traditional cookies");

        Console.WriteLine("      Setting state in oven");
        Oven.GetInstance().SetLastTimeUsage(clock.GetCurrentDate());
    }
}