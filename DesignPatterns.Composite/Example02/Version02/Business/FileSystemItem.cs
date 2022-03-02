namespace DesignPatterns.Composite.Example02.Version02.Business;

public abstract class FileSystemItem
{
    public FileSystemItem(string name)
    {
        Name = name;
    }

    public string Name { get; }

    public abstract decimal GetSizeInKB();
}