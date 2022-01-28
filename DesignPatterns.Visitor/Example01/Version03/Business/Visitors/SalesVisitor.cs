namespace DesignPatterns.Visitor.Example01.Version03.Business.Visitors;

public class SalesVisitor : IVisitor
{
    private int BookCount;
    private int VinylCount;

    public void Visit(Book book)
    {
        BookCount++;
    }

    public void Visit(Vinyl vinyl)
    {
        VinylCount++;
    }

    public void Print()
    {
        Console.WriteLine($"Books sold: {BookCount} \nVinyl sold: {VinylCount}");
        Console.WriteLine($"The store sold {BookCount + VinylCount} units today!");
    }
}