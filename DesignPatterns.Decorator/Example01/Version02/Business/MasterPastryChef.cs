namespace DesignPatterns.Decorator.Example01.Version02.Business;

public class MasterPastryChef
{
    public MasterPastryChef()
    {
        Console.WriteLine("Creating masterPastryChef");
    }

    public void preparePastries(PastryChef pastryChef)
    {
        Console.WriteLine("MasterPastryChef requesting to prepare pastries \n");
        pastryChef.Beat();
        pastryChef.Bake();
    }
}