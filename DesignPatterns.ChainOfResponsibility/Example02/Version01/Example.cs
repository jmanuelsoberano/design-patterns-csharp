using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Handlers.PaymentHandlers;
using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Models;

namespace DesignPatterns.ChainOfResponsibility.Example02.Version01
{
    public class Example
    {
        public void Execute()
        {
            var order = new Order();
            order.LineItems.Add(new Item("ATOMOSV", "Atomos Ninja V", 499), 2);
            order.LineItems.Add(new Item("EOSR", "Canon EOS R", 1799), 1);

            order.SelectedPayments.Add(new Payment
            {
                PaymentProvider = PaymentProvider.Paypal,
                Amount = 1000
            });

            order.SelectedPayments.Add(new Payment
            {
                PaymentProvider = PaymentProvider.Invoice,
                Amount = 1797
            });

            Console.WriteLine(order.AmountDue);
            Console.WriteLine(order.ShippingStatus);

            var handler = new PaypalHandler();
            handler.SetNext(new CreditCardHandler())
                .SetNext(new InvoiceHandler());

            handler.Handle(order);

            Console.WriteLine(order.AmountDue);
            Console.WriteLine(order.ShippingStatus);
        }
    }
}
