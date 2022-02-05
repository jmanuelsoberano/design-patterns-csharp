using DesignPatterns.Facade.Example02.Version01.Business.Entities;

namespace DesignPatterns.Facade.Example02.Version01.Business.Services;

public class WeatherService
{
    public int GetTempFahrenheit(City city, State state)
    {
        // call to service or db would go here

        return 53;
    }
}