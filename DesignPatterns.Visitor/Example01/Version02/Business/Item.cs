namespace DesignPatterns.Visitor.Example01.Version02.Business;

public class Item
{
    public int ID;
    public double Price;

    public Item(int id, double price)
    {
        this.ID = id;
        this.Price = price;
    }

    public double GetDiscount(double percentage)
    {
        return Math.Round(Price * percentage, 2);
    }
}