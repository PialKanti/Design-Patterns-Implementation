using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Interfaces
{
    public interface ILogistics
    {
        void ShipProduct(int productId, int pincode);
    }
}
