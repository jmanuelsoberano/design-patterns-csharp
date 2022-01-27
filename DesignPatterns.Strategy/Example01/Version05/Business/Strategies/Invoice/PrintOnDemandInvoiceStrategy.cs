using DesignPatterns.Strategy.Example01.Version05.Business.Models;
using Newtonsoft.Json;

namespace DesignPatterns.Strategy.Example01.Version05.Business.Strategies.Invoice;

public class PrintOnDemandInvoiceStrategy : IInvoiceStrategy
{
    public void Generate(Order order)
    {
        using (var client = new HttpClient())
        {
            var content = JsonConvert.SerializeObject(order);

            client.BaseAddress = new Uri("https://pluralsight.com");

            client.PostAsync("/print-on-demand", new StringContent(content));
        }
    }
}