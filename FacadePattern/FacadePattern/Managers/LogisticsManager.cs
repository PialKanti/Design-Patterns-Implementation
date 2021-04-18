using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Managers
{
    public class LogisticsManager : ILogistics
    {
        public void ShipProduct(int productId, int pincode)
        {
            Console.WriteLine($"Product Id {productId} has been shipped to pin code {pincode}.);
        }
    }
}
