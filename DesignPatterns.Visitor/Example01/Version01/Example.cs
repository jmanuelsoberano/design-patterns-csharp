using DesignPatterns.Visitor.Example01.Version01.Business;

namespace DesignPatterns.Visitor.Example01.Version01;

public class Example
{
    public void Execute()
    {
        var items = new List<object>
        {
            new Book(12345, 11.99),
            new Book(78910, 22.79),
            new Vinyl(11198, 17.99),
            new Book(63254, 9.79)
        };
    }
}
