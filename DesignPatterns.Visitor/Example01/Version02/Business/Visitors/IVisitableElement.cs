namespace DesignPatterns.Visitor.Example01.Version02.Business.Visitors;

public interface IVisitableElement
{
    void Accept(IVisitor visitor);
}