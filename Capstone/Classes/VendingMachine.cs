using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{

    public class VendingMachine
    {
        TransLogger logger = new TransLogger("log.txt");

        public decimal Balance { get; private set; }

        public string[] Slots
        {
            get
            {
                return Inventory.Keys.ToArray();
            }
        }

        private Dictionary<string, List<VendingMachineItem>> Inventory;


        public void FeedMoney(int dollars)
        {
            Balance += dollars;

            logger.RecordDeposit(dollars, Balance);
        }

        public VendingMachineItem GetItemAtSlot(string slot)
        {
            VendingMachineItem itemSlot = Inventory[slot][0];
            return itemSlot;
        }

        public int GetQuantityRemaining(string slot)
        {
            return Inventory[slot][0].ItemStock;
        }

        public VendingMachineItem Purchase(string slot)
        {
            try
            {
                if (Balance < Inventory[slot][0].Price)
                {
                    Console.WriteLine("insufficient balance");
                }

                if (Inventory[slot][0].ItemStock < 1)
                {
                    Console.WriteLine("Out of stock");
                }

                Balance -= Inventory[slot][0].Price;
                Inventory[slot][0].ItemStock -= 1;

                logger.RecordPurchase(slot, Inventory[slot][0].ItemName, Inventory[slot][0].Price, Balance);

                return Inventory[slot][0];
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid Entry");
                Console.WriteLine(ex.Message + "\n");
            }

            
            return null;
        }

        public Change ReturnChange()
        {
            Change change = new Change(Balance);

            Balance = 0;
            logger.RecordCompleteTransaction(Balance);

            return change;
        }

        public VendingMachine(Dictionary<string, List<VendingMachineItem>> startingInventory)
        {
            Inventory = startingInventory;
        }
    }
}
