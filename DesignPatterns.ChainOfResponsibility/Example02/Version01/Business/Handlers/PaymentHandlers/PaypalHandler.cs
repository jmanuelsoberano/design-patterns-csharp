using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Models;
using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.PaymentProcessors;

namespace DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Handlers.PaymentHandlers;

public class PaypalHandler : PaymentHandler
{
    private PaypalPaymentProcessor PaypalPaymentProcessor { get; } = new();

    public override void Handle(Order order)
    {
        if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Paypal))
            PaypalPaymentProcessor.Finalize(order);

        base.Handle(order);
    }
}