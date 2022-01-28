namespace DesignPatterns.Visitor.Example01.Version04.Business.Visitors;

public interface IVisitor
{
    void Visit(Book book);
    void Visit(Vinyl vinyl);
    void Print();
}