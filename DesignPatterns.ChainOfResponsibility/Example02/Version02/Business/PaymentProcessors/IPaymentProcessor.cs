using DesignPatterns.ChainOfResponsibility.Example02.Version02.Business.Models;

namespace DesignPatterns.ChainOfResponsibility.Example02.Version02.Business.PaymentProcessors;

public interface IPaymentProcessor
{
    void Finalize(Order order);
}