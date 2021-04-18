using FacadePattern.Interfaces;
using FacadePattern.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class OnlineShoppingFacade
    {
        IInventory inventory;
        ILogistics logistics;
        IOrderVerify orderVerify;
        IPaymentGateway paymentGateway;
        IPricing pricingManager;

        public OnlineShoppingFacade()
        {
            inventory = new InventoryManager();
            logistics = new LogisticsManager();
            orderVerify = new OrderVerifyManager();
            paymentGateway = new PaymentGatewayManager();
            pricingManager = new PricingManager();
        }

        public void FinalizeOrder(OrderDetails order)
        {
            inventory.Update(order.ProductId);
            orderVerify.VerifyShippingAddress(order.AreaPincode);

            order.Price = pricingManager.ApplyDiscount(order.Price, order.DiscountPercentage);

            paymentGateway.VerifyCardDetails(order.CardNumber);
            paymentGateway.ProcessPayment(order.CardNumber, order.Price);

            logistics.ShipProduct(order.ProductId, order.AreaPincode);
        }
    }
}
