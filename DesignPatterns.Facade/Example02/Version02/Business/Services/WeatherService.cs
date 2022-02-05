using DesignPatterns.Facade.Example02.Version02.Business.Entities;

namespace DesignPatterns.Facade.Example02.Version02.Business.Services;

public class WeatherService
{
    public int GetTempFahrenheit(City city, State state)
    {
        // call to service or db would go here

        return 53;
    }
}