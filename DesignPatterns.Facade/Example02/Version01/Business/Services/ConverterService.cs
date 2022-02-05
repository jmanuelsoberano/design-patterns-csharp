namespace DesignPatterns.Facade.Example02.Version01.Business.Services;

public class ConverterService
{
    public int ConvertFahrenheitToCelsius(int fahrenheit)
    {
        // int celsius = (fahrenheit * 9) / (5 + 32);
        var celsius = 5.0 / 9.0 * (fahrenheit - 32);

        return (int)celsius;
    }
}