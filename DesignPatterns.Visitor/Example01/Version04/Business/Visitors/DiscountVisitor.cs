namespace DesignPatterns.Visitor.Example01.Version04.Business.Visitors;

public class DiscountVisitor : IVisitor
{
    private double _savings;

    public void Visit(Book book)
    {
        var discount = 0.0;

        if (book.Price < 20.00)
        {
            discount = book.GetDiscount(0.10);
            Console.WriteLine($"DISCOUNTED: Book #{book.ID} is now ${Math.Round(book.Price - discount, 2)}");
        }
        else
        {
            Console.WriteLine($"FULL PRICE: Book #{book.ID} is ${book.Price}");
        }

        _savings += discount;
    }

    public void Visit(Vinyl vinyl)
    {
        var discount = vinyl.GetDiscount(0.15);
        Console.WriteLine($"SUPER SAVINGS: Vinyl #{vinyl.ID} is now ${Math.Round(vinyl.Price - discount, 2)}");

        _savings += discount;
    }

    public void Print()
    {
        Console.WriteLine($"\nYou saved a total of ${Math.Round(_savings, 2)} on today's order!");
    }

    public void Reset()
    {
        _savings = 0.0;
    }
}