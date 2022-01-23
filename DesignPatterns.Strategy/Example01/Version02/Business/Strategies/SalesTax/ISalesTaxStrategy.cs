using DesignPatterns.Strategy.Example01.Version02.Business.Models;

namespace DesignPatterns.Strategy.Example01.Version02.Business.Strategies.SalesTax;

public interface ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order);
}