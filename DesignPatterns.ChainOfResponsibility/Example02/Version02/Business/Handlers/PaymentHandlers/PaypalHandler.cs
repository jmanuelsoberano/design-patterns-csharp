using DesignPatterns.ChainOfResponsibility.Example02.Version02.Business.Models;
using DesignPatterns.ChainOfResponsibility.Example02.Version02.Business.PaymentProcessors;

namespace DesignPatterns.ChainOfResponsibility.Example02.Version02.Business.Handlers.PaymentHandlers;

public class PaypalHandler : IReceiver<Order>
{
    private PaypalPaymentProcessor PaypalPaymentProcessor { get; } = new();

    public void Handle(Order order)
    {
        if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Paypal))
            PaypalPaymentProcessor.Finalize(order);
    }
}