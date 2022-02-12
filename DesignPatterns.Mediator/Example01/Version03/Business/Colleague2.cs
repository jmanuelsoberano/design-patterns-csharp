﻿namespace DesignPatterns.Mediator.Example01.Version03.Business;

public class Colleague2 : Colleague
{
    public override void HandleNotification(string message)
    {
        Console.WriteLine($"Colleague2 receives notification message: {message}");
    }
}