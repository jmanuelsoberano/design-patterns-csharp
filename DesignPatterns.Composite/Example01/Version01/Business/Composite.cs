using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite.Example01.Version01.Business;

public class Composite : Component
{
    private readonly List<Component> children = new();

    public Composite(string name) : base(name)
    {
    }

    public void Add(Component c)
    {
        children.Add(c);
    }

    public override void PrimaryOperation(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
        foreach (var component in children) component.PrimaryOperation(depth + 2);
    }

    public void Remove(Component c)
    {
        children.Remove(c);
    }
}