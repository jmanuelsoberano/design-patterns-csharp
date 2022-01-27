using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Exceptions;
using DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Models;

namespace DesignPatterns.ChainOfResponsibility.Example02.Version01.Business.Handlers;

public abstract class PaymentHandler : IHandler<Order>
{
    private IHandler<Order> Next { get; set; }

    public virtual void Handle(Order order)
    {
        Console.WriteLine($"Running: {GetType().Name}");

        if (Next == null && order.AmountDue > 0) throw new InsufficientPaymentException();

        if (order.AmountDue > 0)
            Next.Handle(order);
        else
            order.ShippingStatus = ShippingStatus.ReadyForShippment;
    }

    public IHandler<Order> SetNext(IHandler<Order> next)
    {
        Next = next;

        return Next;
    }
}