using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Interfaces
{
    public interface IPaymentGateway
    {
        bool VerifyCardDetails(string cardNo);
        bool ProcessPayment(string cardNo, double price);
    }
}
