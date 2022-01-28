using DesignPatterns.Visitor.Example01.Version02.Business.Visitors;

namespace DesignPatterns.Visitor.Example01.Version02.Business;

public class Vinyl : Item, IVisitableElement
{
    public Vinyl(int id, double price) : base(id, price)
    {
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}