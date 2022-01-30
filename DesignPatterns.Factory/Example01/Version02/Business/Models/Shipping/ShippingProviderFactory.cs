namespace DesignPatterns.Factory.Example01.Version02.Business.Models.Shipping;

public class ShippingProviderFactory
{
    public static ShippingProvider
        CreateShippingProvider(string country)
    {
        ShippingProvider shippingProvider;

        #region Create Shipping Provider

        if (country == "Australia")
        {
            #region Australia Post Shipping Provider

            var shippingCostCalculator = new ShippingCostCalculator(
                250,
                500
            )
            {
                ShippingType = ShippingType.Standard
            };

            var customsHandlingOptions = new CustomsHandlingOptions
            {
                TaxOptions = TaxOptions.PrePaid
            };

            var insuranceOptions = new InsuranceOptions
            {
                ProviderHasInsurance = false,
                ProviderHasExtendedInsurance = false,
                ProviderRequiresReturnOnDamange = false
            };

            shippingProvider = new AustraliaPostShippingProvider("CLIENT_ID",
                "SECRET",
                shippingCostCalculator,
                customsHandlingOptions,
                insuranceOptions);

            #endregion
        }
        else if (country == "Sweden")
        {
            #region Swedish Postal Service Shipping Provider

            var shippingCostCalculator = new ShippingCostCalculator(
                50,
                100
            )
            {
                ShippingType = ShippingType.Express
            };

            var customsHandlingOptions = new CustomsHandlingOptions
            {
                TaxOptions = TaxOptions.PayOnArrival
            };

            var insuranceOptions = new InsuranceOptions
            {
                ProviderHasInsurance = true,
                ProviderHasExtendedInsurance = false,
                ProviderRequiresReturnOnDamange = false
            };

            shippingProvider = new SwedishPostalServiceShippingProvider("API_KEY",
                shippingCostCalculator,
                customsHandlingOptions,
                insuranceOptions);

            #endregion
        }
        else
        {
            throw new NotSupportedException("No shipping provider found for origin country");
        }

        #endregion

        return shippingProvider;
    }
}
