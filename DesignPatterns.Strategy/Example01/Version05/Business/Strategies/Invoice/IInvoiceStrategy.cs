using DesignPatterns.Strategy.Example01.Version05.Business.Models;

namespace DesignPatterns.Strategy.Example01.Version05.Business.Strategies.Invoice;

public interface IInvoiceStrategy
{
    public void Generate(Order order);
}