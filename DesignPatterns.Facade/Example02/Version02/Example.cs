using DesignPatterns.Facade.Example02.Version02.Business;

namespace DesignPatterns.Facade.Example02.Version02;

public class Example
{
    public void Execute()
    {
        const string zipCode = "98074";

        IWeatherFacade weatherFacade = new WeatherFacade();
        var results = weatherFacade.GetTempInCity(zipCode);

        Console.WriteLine("The current temperature is {0}F/{1}C in {2}, {3}",
            results.Fahrenheit,
            results.Celsius,
            results.City.Name,
            results.State.Name);
    }
}