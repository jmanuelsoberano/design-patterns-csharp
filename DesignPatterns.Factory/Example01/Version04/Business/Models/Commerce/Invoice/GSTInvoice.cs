using System.Text;

namespace DesignPatterns.Factory.Example01.Version04.Business.Models.Commerce.Invoice;

public class GSTInvoice : IInvoice
{
    public byte[] GenerateInvoice()
    {
        return
            Encoding
                .Default
                .GetBytes("Hello world from a GST Invoice");
    }
}