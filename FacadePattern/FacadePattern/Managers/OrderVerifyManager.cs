using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Managers
{
    public class OrderVerifyManager : IOrderVerify
    {
        public bool VerifyShippingAddress(int pincode)
        {
            Console.WriteLine($"Pin code {pincode} valid. Product can be ship to that address.");
            return true;
        }
    }
}
