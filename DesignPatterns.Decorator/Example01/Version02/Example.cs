using DesignPatterns.Decorator.Example01.Version02.Business;

namespace DesignPatterns.Decorator.Example01.Version02;

public class Example
{
    public void Execute()
    {
        Console.WriteLine("========DECORATOR FINE");

        PastryChef apprenticePastryChef = new ApprenticePastryChef();
        var masterPastryChef = new MasterPastryChef();

        Console.WriteLine("====MASTER PASTRY CHEF ORDERING THE APPRENTICE TO PREPARE TRADICIONAL COOKIES");

        PastryChef apprenticeTraditionalPastryChef = new TraditionalSkilledPastryChef(apprenticePastryChef);
        masterPastryChef.preparePastries(apprenticeTraditionalPastryChef);

        Console.WriteLine("====MASTER PASTRY CHEF ORDERING THE APPRENTICE TO PREPARE A SOUFFLE");

        PastryChef apprenticeFrenchCuisinelPastryChef = new FrenchCuisineSkilledPastryChef(apprenticePastryChef);
        masterPastryChef.preparePastries(apprenticeFrenchCuisinelPastryChef);

        Rest();

        Console.WriteLine(
            "====MASTER PASTRY CHEF ORDERING THE APPRENTICE TO PREPARE BOTH TRADITIONAL COOKIES AND A SOUFFLE");

        PastryChef apprenticeMultiPurposePastryChef = new FrenchCuisineSkilledPastryChef(
            new TraditionalSkilledPastryChef(apprenticePastryChef));
        masterPastryChef.preparePastries(apprenticeMultiPurposePastryChef);
    }

    private static void Rest()
    {
        Thread.Sleep(4000);
    }
}