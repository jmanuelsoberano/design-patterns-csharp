using System;

namespace DesignPatterns.Composite.Example01.Version01.Business;

public class Leaf : Component
{
    public Leaf(string name) : base(name)
    {
    }

    public override void PrimaryOperation(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }
}