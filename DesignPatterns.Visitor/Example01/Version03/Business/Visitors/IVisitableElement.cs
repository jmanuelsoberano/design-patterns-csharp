namespace DesignPatterns.Visitor.Example01.Version03.Business.Visitors;

public interface IVisitableElement
{
    void Accept(IVisitor visitor);
}