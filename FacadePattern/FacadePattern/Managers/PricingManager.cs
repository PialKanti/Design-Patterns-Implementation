using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Managers
{
    public class PricingManager : IPricing
    {
        public double ApplyDiscount(double price, double discountParcent)
        {
            double finalPrice = price - (discountParcent / 100) * price;
            Console.WriteLine($"Discounted price is {finalPrice} after applying {discountParcent}% discount.");
            return finalPrice;
        }
    }
}
