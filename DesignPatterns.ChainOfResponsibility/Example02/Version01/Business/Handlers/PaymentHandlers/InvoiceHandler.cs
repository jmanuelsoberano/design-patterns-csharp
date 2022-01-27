using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Models;
using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.PaymentProcessors;

namespace DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Handlers.PaymentHandlers;

public class InvoiceHandler : PaymentHandler
{
    public InvoicePaymentProcessor InvoicePaymentProcessor { get; } = new();

    public override void Handle(Order order)
    {
        if (order.SelectedPayments.Any(x => x.PaymentProvider == PaymentProvider.Invoice))
            InvoicePaymentProcessor.Finalize(order);
        base.Handle(order);
    }
}