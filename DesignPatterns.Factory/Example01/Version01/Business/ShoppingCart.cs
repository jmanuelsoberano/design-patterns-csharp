﻿using DesignPatterns.Factory.Example01.Version01.Business.Models.Commerce;
using DesignPatterns.Factory.Example01.Version01.Business.Models.Shipping;

namespace DesignPatterns.Factory.Example01.Version01.Business;

public class ShoppingCart
{
    private readonly Order order;

    public ShoppingCart(Order order)
    {
        this.order = order;
    }

    public string Finalize()    
    {
        #region Create Shipping Provider
        ShippingProvider shippingProvider;

        if (order.Sender.Country == "Australia")
        {
            #region Australia Post Shipping Provider
            var shippingCostCalculator = new ShippingCostCalculator(
                internationalShippingFee: 250,
                extraWeightFee: 500
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
        else if (order.Sender.Country == "Sweden")
        {
            #region Swedish Postal Service Shipping Provider
            var shippingCostCalculator = new ShippingCostCalculator(
                internationalShippingFee: 50,
                extraWeightFee: 100
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

        order.ShippingStatus = ShippingStatus.ReadyForShippment;

        return shippingProvider.GenerateShippingLabelFor(order);
    }
}