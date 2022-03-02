using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite.Example02.Version02.Business;

public class FileSystemBuilder
{
    private DirectoryItem currentDirectory;

    public FileSystemBuilder(string rootDirectory)
    {
        Root = new DirectoryItem(rootDirectory);
        currentDirectory = Root;
    }

    public DirectoryItem Root { get; }

    public DirectoryItem AddDirectory(string name)
    {
        var dir = new DirectoryItem(name);
        currentDirectory.Add(dir);
        currentDirectory = dir;
        return dir;
    }

    public FileItem AddFile(string name, long fileByes)
    {
        var file = new FileItem(name, fileByes);
        currentDirectory.Add(new FileItem(name, fileByes));
        return file;
    }

    public DirectoryItem SetCurrentDirectory(string directoryName)
    {
        var dirStack = new Stack<DirectoryItem>();
        dirStack.Push(Root);
        while (dirStack.Any())
        {
            var current = dirStack.Pop();
            if (current.Name == directoryName)
            {
                currentDirectory = current;
                return current;
            }

            foreach (var item in current.Items.OfType<DirectoryItem>()) dirStack.Push(item);
        }

        throw new InvalidOperationException($"Directory name '{directoryName}' not found!");
    }
}