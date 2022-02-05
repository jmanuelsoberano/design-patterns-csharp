using DesignPatterns.Facade.Example02.Version01.Business.Services;

namespace DesignPatterns.Facade.Example02.Version01;

public class Example
{
    public void Execute()
    {
        const string zipCode = "98074";

        // call to service 1
        var geoLookupService = new GeoLookupService();
        var city = geoLookupService.GetCityForZipCode(zipCode);
        var state = geoLookupService.GetStateForZipCode(zipCode);

        // call to service 2
        var weatherService = new WeatherService();
        var fahrenheit = weatherService.GetTempFahrenheit(city, state);

        // call to service 3
        var metricConverter = new ConverterService();
        var celcius = metricConverter.ConvertFahrenheitToCelsius(fahrenheit);

        // bring the result of all service calls together
        Console.WriteLine("The current temperature is {0} F / {1} C in {2}, {3}",
            fahrenheit,
            celcius,
            city.Name,
            state.Name);
    }
}