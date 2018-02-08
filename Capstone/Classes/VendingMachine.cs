using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachine
    {

        public decimal Balance { get; private set; }
        public string[] Slots { get; }
        private Dictionary<string, List<VendingMachineItem>> Inventory { get; }

        public void FeedMoney (int dollars)
        {
            Balance += (decimal)dollars;
        }
        public VendingMachineItem GetItemAtSlot(string slot)
        {
           
        }
        public int GetQuantityRemaining(string slot)
        {
            // Subtract one quantity
            // return whats left
        }
        public VendingMachineItem Purchase(string slot)
        {
            // Subtract from the balance and quanity
        }
        public Change ReturnChange()
        {
            Change change = new Change(Balance);
            return change;
        }
        public VendingMachine(Dictionary<string, List<VendingMachineItem>> startingInventory)
        {

        }

    }
}
