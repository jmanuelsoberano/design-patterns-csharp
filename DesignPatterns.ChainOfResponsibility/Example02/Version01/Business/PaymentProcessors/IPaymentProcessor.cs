using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Models;

namespace DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.PaymentProcessors;

public interface IPaymentProcessor
{
    void Finalize(Order order);
}