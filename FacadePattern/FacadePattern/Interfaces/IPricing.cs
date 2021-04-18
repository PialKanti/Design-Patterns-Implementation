using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Interfaces
{
     public interface IPricing
    {
        double ApplyDiscount(double price, double discountParcent);
    }
}
