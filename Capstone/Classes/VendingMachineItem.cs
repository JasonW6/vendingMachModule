using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public abstract class VendingMachineItem
    {
        public decimal Price { get; }
        public string ItemName { get; }
        public int ItemStock { get; set; }



        public VendingMachineItem(string item, decimal price)
        {
            Price = price;
            ItemName = item;
            
        }

        public abstract string Consume();
        
    }
}
