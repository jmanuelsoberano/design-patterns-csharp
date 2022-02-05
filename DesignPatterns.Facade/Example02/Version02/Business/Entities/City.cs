namespace DesignPatterns.Facade.Example02.Version02.Business.Entities;

public class City
{
    public City GetCityForZipCode(string zipCode)
    {
        // service or db lookup would go here
        return new City();
    }

    public string Name => "Redmond";
}