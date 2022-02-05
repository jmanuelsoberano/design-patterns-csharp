using DesignPatterns.Facade.Example02.Version01.Business.Entities;

namespace DesignPatterns.Facade.Example02.Version01.Business.Services;

public class GeoLookupService
{
    public City GetCityForZipCode(string zipCode)
    {
        return new City();
    }

    public State GetStateForZipCode(string zipCode)
    {
        return new State();
    }
}