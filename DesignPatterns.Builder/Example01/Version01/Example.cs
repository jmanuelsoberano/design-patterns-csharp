using DesignPatterns.Builder.Example01.Version01.Business;

namespace DesignPatterns.Builder.Example01.Version01
{
    public class Example
    {
        public void Execute()
        {
            var items = new List<FurnitureItem>
            {
                new("Sectional Couch", 55.5, 22.4, 78.6, 35.0),
                new("Nightstand", 25.0, 12.4, 20.0, 10.0),
                new("Dining Table", 105.0, 35.4, 100.6, 55.5)
            };
        }
    }
}
