using DesignPatterns.Visitor.Example01.Version03.Business;
using DesignPatterns.Visitor.Example01.Version03.Business.Visitors;

namespace DesignPatterns.Visitor.Example01.Version03;

public class Example
{
    public void Execute()
    {
        var items = new List<IVisitableElement>
        {
            new Book(12345, 11.99),
            new Book(78910, 22.79),
            new Vinyl(11198, 17.99),
            new Book(63254, 9.79)
        };

        var discountVisitor = new DiscountVisitor();
        foreach (var item in items) item.Accept(discountVisitor);
        discountVisitor.Print();

        var salesVisitor = new SalesVisitor();
        foreach (var item in items) item.Accept(salesVisitor);
        salesVisitor.Print();
    }
}
