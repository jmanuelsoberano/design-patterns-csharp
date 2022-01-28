namespace DesignPatterns.Visitor.Example01.Version04.Business.Visitors;

public class ObjectStructure
{
    private readonly List<IVisitableElement> _cart;

    public ObjectStructure(List<IVisitableElement> items)
    {
        _cart = items;
    }

    public void RemoveItem(IVisitableElement item)
    {
        _cart.Remove(item);
    }

    public void ApplyVisitor(IVisitor visitor)
    {
        Console.WriteLine("\n------- Visitor Breakdown -------");
        foreach (var item in _cart)
            item.Accept(visitor);

        visitor.Print();
    }
}