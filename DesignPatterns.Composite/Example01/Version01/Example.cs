using DesignPatterns.Composite.Example01.Version01.Business;

namespace DesignPatterns.Composite.Example01.Version01;

public class Example
{
    public void Execute()
    {
        // Create a tree structure
        var root = new Business.Composite("root");
        root.Add(new Leaf("Leaf A"));
        root.Add(new Leaf("Leaf B"));

        var comp1 = new Business.Composite("Composite C1");
        comp1.Add(new Leaf("Leaf C1-A"));
        comp1.Add(new Leaf("Leaf C1-B"));
        var comp2 = new Business.Composite("Composite C2");
        comp2.Add(new Leaf("Leaf C2-A"));
        comp1.Add(comp2);

        root.Add(comp1);
        root.Add(new Leaf("Leaf C"));

        // Add and remove a leaf
        var leaf = new Leaf("Leaf D");
        root.Add(leaf);
        root.Remove(leaf);

        // Recursively display tree
        root.PrimaryOperation(1);
    }
}
