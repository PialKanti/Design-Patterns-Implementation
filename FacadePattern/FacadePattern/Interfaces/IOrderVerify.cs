using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Interfaces
{
    public interface IOrderVerify
    {
        bool VerifyShippingAddress(int pincode);
    }
}
