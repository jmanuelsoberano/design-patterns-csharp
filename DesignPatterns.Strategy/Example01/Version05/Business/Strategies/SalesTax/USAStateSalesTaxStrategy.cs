﻿using DesignPatterns.Strategy.Example01.Version05.Business.Models;

namespace DesignPatterns.Strategy.Example01.Version05.Business.Strategies.SalesTax;

public class USAStateSalesTaxStrategy : ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order)
    {
        var totalPrice = order.TotalPrice;

        switch (order.ShippingDetails.DestinationState.ToLowerInvariant())
        {
            case "la": return totalPrice * 0.095m;
            case "ny": return totalPrice * 0.04m;
            case "nyc": return totalPrice * 0.045m;
            default: return 0m;
        }
    }
}