using DesignPatterns.Visitor.Example01.Version04.Business.Visitors;

namespace DesignPatterns.Visitor.Example01.Version04.Business;

public class Book : Item, IVisitableElement
{
    public Book(int id, double price) : base(id, price)
    {
    }

    public void Accept(IVisitor visitor)
    {
        visitor.Visit(this);
    }
}