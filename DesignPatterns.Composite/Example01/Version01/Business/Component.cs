namespace DesignPatterns.Composite.Example01.Version01.Business;

public abstract class Component
{
    public Component(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract void PrimaryOperation(int depth);
}