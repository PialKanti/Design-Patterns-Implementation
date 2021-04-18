using FacadePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Managers
{
    public class InventoryManager : IInventory
    {
        public void Update(int productId)
        {
            Console.WriteLine($"Product Id = {productId} has been removed from inventory.");
        }
    }
}
