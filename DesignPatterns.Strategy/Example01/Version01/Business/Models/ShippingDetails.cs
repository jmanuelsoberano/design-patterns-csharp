namespace DesignPatterns.Strategy.Example01.Version01.Business.Models;

public class ShippingDetails
{
    public string Receiver { get; set; }

    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }

    public string PostalCode { get; set; }

    public string DestinationCountry { get; set; }
    public string DestinationState { get; set; }

    public string OriginCountry { get; set; }
    public string OriginState { get; set; }
}