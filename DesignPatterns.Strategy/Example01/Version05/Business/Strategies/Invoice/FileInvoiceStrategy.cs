using DesignPatterns.Strategy.Example01.Version05.Business.Models;

namespace DesignPatterns.Strategy.Example01.Version05.Business.Strategies.Invoice;

public class FileInvoiceStrategy : InvoiceStrategy
{
    public override void Generate(Order order)
    {
        using (var stream = new StreamWriter($"invoice_{Guid.NewGuid()}.txt"))
        {
            stream.Write(GenerateTextInvoice(order));

            stream.Flush();
        }
    }
}