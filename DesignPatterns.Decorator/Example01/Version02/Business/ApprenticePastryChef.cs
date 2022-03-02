namespace DesignPatterns.Decorator.Example01.Version02.Business;

public class ApprenticePastryChef : PastryChef
{
    public ApprenticePastryChef()
    {
        Console.WriteLine("Creating apprenticePastryChef");
    }

    public override void Beat()
    {
        Console.WriteLine("Beating eggs (apprenticePastryChef)");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking (apprenticePastryChef)");
    }
}