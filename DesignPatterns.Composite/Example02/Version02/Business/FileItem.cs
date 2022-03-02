namespace DesignPatterns.Composite.Example02.Version02.Business;

public class FileItem : FileSystemItem
{
    public FileItem(string name, long fileBytes) : base(name)
    {
        FileBytes = fileBytes;
    }

    public long FileBytes { get; }

    public override decimal GetSizeInKB()
    {
        return decimal.Divide(FileBytes, 1000);
    }
}