using DesignPatterns.Visitor.Example01.Version04.Business;
using DesignPatterns.Visitor.Example01.Version04.Business.Visitors;

namespace DesignPatterns.Visitor.Example01.Version04;

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

        var cart = new ObjectStructure(items);

        var discountVisitor = new DiscountVisitor();
        var salesVisitor = new SalesVisitor();

        cart.ApplyVisitor(discountVisitor);
        cart.ApplyVisitor(salesVisitor);

        discountVisitor.Reset();

        cart.RemoveItem(items[2]);
        cart.ApplyVisitor(discountVisitor);
    }
}
