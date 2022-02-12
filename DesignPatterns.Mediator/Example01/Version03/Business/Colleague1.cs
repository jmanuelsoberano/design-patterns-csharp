﻿namespace DesignPatterns.Mediator.Example01.Version03.Business;

public class Colleague1 : Colleague
{
    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague1 receives notification message: {message}");
    }
}