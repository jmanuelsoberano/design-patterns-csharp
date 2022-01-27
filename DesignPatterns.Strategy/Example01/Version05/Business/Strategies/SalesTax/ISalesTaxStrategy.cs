using DesignPatterns.Strategy.Example01.Version05.Business.Models;

namespace DesignPatterns.Strategy.Example01.Version05.Business.Strategies.SalesTax;

public interface ISalesTaxStrategy
{
    public decimal GetTaxFor(Order order);
}