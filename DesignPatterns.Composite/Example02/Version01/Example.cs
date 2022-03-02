using System;
using DesignPatterns.Composite.Example02.Version01.Business;

namespace DesignPatterns.Composite.Example02.Version01;

public class Example
{
    public void Execute()
    {
        var root = new DirectoryItem("development");
        var proj1 = new DirectoryItem("project1");
        var proj2 = new DirectoryItem("project2");
        root.Add(proj1);
        root.Add(proj2);

        proj1.Add(new FileItem("p1f1.txt", 2100));
        proj1.Add(new FileItem("p1f2.txt", 3100));
        var subDir1 = new DirectoryItem("sub-dir1");
        subDir1.Add(new FileItem("p1f3.txt", 4100));
        subDir1.Add(new FileItem("p1f4.txt", 5100));
        proj1.Add(subDir1);

        proj2.Add(new FileItem("p2f1.txt", 6100));
        proj2.Add(new FileItem("p2f2.txt", 7100));

        Console.WriteLine($"Total size (proj2): {proj2.GetSizeInKB()}");
        Console.WriteLine($"Total size (proj1): {proj1.GetSizeInKB()}");
        Console.WriteLine($"Total size (root) : {root.GetSizeInKB()}");
    }
}
