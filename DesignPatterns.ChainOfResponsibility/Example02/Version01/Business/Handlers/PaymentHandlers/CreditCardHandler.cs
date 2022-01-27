using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Models;
using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.PaymentProcessors;

namespace DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Handlers.PaymentHandlers;

public class CreditCardHandler : PaymentHandler
{
    public CreditCardPaymentProcessor CreditCardPaymentProcessor { get; } = new();

    public override void Handle(Order order)
    {
        if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.CreditCard))
            CreditCardPaymentProcessor.Finalize(order);

        base.Handle(order);
    }
}