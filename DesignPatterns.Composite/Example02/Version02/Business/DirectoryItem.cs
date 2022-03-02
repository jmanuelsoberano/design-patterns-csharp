using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite.Example02.Version02.Business;

public class DirectoryItem : FileSystemItem
{
    public DirectoryItem(string name) : base(name)
    {
    }

    public List<FileSystemItem> Items { get; } = new();

    public void Add(FileSystemItem component)
    {
        Items.Add(component);
    }

    public void Remove(FileSystemItem component)
    {
        Items.Remove(component);
    }

    public override decimal GetSizeInKB()
    {
        return Items.Sum(x => x.GetSizeInKB());
    }
}