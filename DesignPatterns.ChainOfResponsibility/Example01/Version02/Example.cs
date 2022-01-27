using System.Globalization;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business;
using DesignPatterns.ChainOfResponsibility.Example01.Version02.Business.Models;

namespace DesignPatterns.ChainOfResponsibility.Example01.Version02;

public class Example
{
    public void Execute()
    {
        var user = new User("Filip Ekberg",
            "870101XXXX",
            new RegionInfo("SE"),
            new DateTimeOffset(1987, 01, 29, 00, 00, 00, TimeSpan.FromHours(2)));


        Console.WriteLine(user.Age);
        var processor = new UserProcessor();

        var ressult = processor.Register(user);

        Console.WriteLine(ressult);
    }
}