using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class OrderDetails
    {
        public int ProductId { get; set; }
        public int AreaPincode { get; set; }
        public string ShippingAddress { get; set; }
        public double Price { get; set; }
        public double DiscountPercentage { get; set; }
        public string CardNumber { get; set; }

        public OrderDetails(int productId, int pincode, string shippingAddress, double price, double discountPercentage, string cardNumber)
        {
            ProductId = productId;
            AreaPincode = pincode;
            ShippingAddress = shippingAddress;
            Price = price;
            DiscountPercentage = discountPercentage;
            CardNumber = cardNumber;
        }
    }
}
