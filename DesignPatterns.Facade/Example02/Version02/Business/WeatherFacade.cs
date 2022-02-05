using DesignPatterns.Facade.Example02.Version02.Business.Entities;
using DesignPatterns.Facade.Example02.Version02.Business.Services;

namespace DesignPatterns.Facade.Example02.Version02.Business;

public class WeatherFacade : IWeatherFacade
{
    private readonly ConverterService _converterService;
    private readonly GeoLookupService _geoLookUpService;
    private readonly WeatherService _weatherService;

    public WeatherFacade() :
        this(new ConverterService(), new GeoLookupService(), new WeatherService())
    {
    }

    public WeatherFacade(ConverterService converterService,
        GeoLookupService geoLookUpService,
        WeatherService weatherService)
    {
        _converterService = converterService;
        _geoLookUpService = geoLookUpService;
        _weatherService = weatherService;
    }

    public WeatherFacadeResults GetTempInCity(string zipCode)
    {
        var city = _geoLookUpService.GetCityForZipCode(zipCode);
        var state = _geoLookUpService.GetStateForZipCode(zipCode);
        var tempF = _weatherService.GetTempFahrenheit(city, state);
        var tempC = _converterService.ConvertFahrenheitToCelsius(tempF);

        var results = new WeatherFacadeResults
        {
            City = city,
            State = state,
            Fahrenheit = tempF,
            Celsius = tempC
        };

        return results;
    }
}