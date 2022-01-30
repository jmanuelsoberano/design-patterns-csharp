﻿namespace DesignPatterns.Factory.Example01.Version02.Business.Models.Commerce;

public class Payment
{
    public decimal Amount { get; set; }
    public PaymentProvider PaymentProvider { get; set; }
}