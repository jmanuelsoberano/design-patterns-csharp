using DesignPatterns.Decorator.Example01.Version02.Business.Util;

namespace DesignPatterns.Decorator.Example01.Version02.Business;

internal class FrenchCuisineSkilledPastryChef : SkilledPastryChef
{
    public FrenchCuisineSkilledPastryChef(PastryChef pastryChef) : base(pastryChef)
    {
        Console.WriteLine("Creating frenchCuisineSkilledPastryChef \n");
    }

    public override void Beat()
    {
        base.Beat();
        AddBehaviourToBeatSouffle();
    }

    public override void Bake()
    {
        base.Bake();
        AddStateToBakeSouffle();
    }

    private void AddBehaviourToBeatSouffle()
    {
        Console.WriteLine("   Adding behabiour when beating eggs (frenchCuisineSkilledPastryChef)");
        Console.WriteLine("      Beating eggs with vanilla extract for souffle");
    }

    private void AddStateToBakeSouffle()
    {
        Console.WriteLine("   Adding state when baking (frenchCuisineSkilledPastryChef)");
        var clock = new Clock();

        if (!Oven.GetInstance().IsReady())
        {
            Console.WriteLine("      Waiting for the oven to be ready for baking (frenchCuisineSkilledPastryChef)");
            clock.SetAlarmDelay(OVEN_DELAY);
        }

        Console.WriteLine("      Baking souffle");

        Console.WriteLine("      Setting state in oven");
        Oven.GetInstance().SetLastTimeUsage(clock.GetCurrentDate());
    }
}