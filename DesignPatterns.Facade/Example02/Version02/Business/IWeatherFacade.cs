using DesignPatterns.Facade.Example02.Version02.Business.Entities;

namespace DesignPatterns.Facade.Example02.Version02.Business;

public interface IWeatherFacade
{
    WeatherFacadeResults GetTempInCity(string zipCode);
}