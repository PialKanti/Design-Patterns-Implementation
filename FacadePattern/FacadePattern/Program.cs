using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            OrderDetails order = new OrderDetails(random.Next(1, 20), random.Next(10, 100),"Dhaka",random.Next(100,1000), random.Next(0,50), "122324343545666");

            OnlineShoppingFacade shoppingFacade = new OnlineShoppingFacade();
            shoppingFacade.FinalizeOrder(order);
        }
    }
}
