using DesignPatterns.ChainOfResponsibility.Example02.Version02.Business.Models;

namespace DesignPatterns.ChainOfResponsibility.Example02.Version02.Business.PaymentProcessors;

public class CreditCardPaymentProcessor : IPaymentProcessor
{
    public void Finalize(Order order)
    {
        // Invoke the Stripe API
        var payment = order.SelectedPayments
            .FirstOrDefault(x => x.PaymentProvider == PaymentProvider.CreditCard);

        if (payment == null) return;

        order.FinalizedPayments.Add(payment);
    }
}