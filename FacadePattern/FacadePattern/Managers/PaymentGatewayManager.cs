using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Managers
{
    public class PaymentGatewayManager : IPaymentGateway
    {
        public bool ProcessPayment(string cardNo, double price)
        {
            Console.WriteLine($"${price} payment has been made by card {cardNo}.");
            return true;
        }

        public bool VerifyCardDetails(string cardNo)
        {
            Console.WriteLine($"Card {cardNo} is valid and ready to make payment.");
            return true;
        }
    }
}
