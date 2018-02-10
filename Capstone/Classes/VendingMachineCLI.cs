using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    /// <summary>
    /// The job of the CLI class is to display the contents of the vending machine
    /// and be the interface the user interacts with.
    /// </summary>
    public class VendingMachineCLI
    {
        private VendingMachine vendingMachine;

        public VendingMachineCLI()
        {
            VendingMachineFileReader vfr = new VendingMachineFileReader("vendingmachine.csv");
            var inventory = vfr.GetInventory();

            vendingMachine = new VendingMachine(inventory);
        }
        
        public void Run()
        {
            bool quit = true;
            while (quit)
            {

            
            Console.WriteLine("(1) Display Vending Machine Items");

            Console.WriteLine("(2) Purchase");

            int choice = int.Parse(Console.ReadLine());

                //Dictionary<string, List<VendingMachineItem>> inventory = vendingMachine.Inventory;
                List<string> pickedItems = new List<string>();
                if (choice == 1)
                {
                    foreach (var slot in vendingMachine.Slots)
                    {
                        
                        VendingMachineItem item = vendingMachine.GetItemAtSlot(slot);
                        if (item.ItemStock > 0)
                        {
                            Console.WriteLine($"{slot} | {item.ItemName} | {item.Price} | {item.ItemStock}");
                        }
                        else
                        {
                            Console.WriteLine($"{slot} | {item.ItemName} | {item.Price} | Out of Stock");
                        }
                    }
                    Console.WriteLine();
                    
                }
                else if (choice == 2)
                 
                {
                    bool quitPurchase = true;
                    while (quitPurchase)
                    {

                        Console.WriteLine("(1) Feed Money");
                        Console.WriteLine("(2) Select Product");
                        Console.WriteLine("(3) Finish Transaction \n");
                        Console.WriteLine($" Current balance is ${vendingMachine.Balance}");
                        Console.WriteLine();
                        int choice2 = int.Parse(Console.ReadLine());
                        if (choice2 == 1)
                        {
                            Console.WriteLine("Enter Amount: ");
                            int dollars = int.Parse(Console.ReadLine());
                            vendingMachine.FeedMoney(dollars);
                        }
                        else if (choice2 == 2)
                        {
                            Console.WriteLine("Please select a product:");
                            string slot = Console.ReadLine();

                            vendingMachine.Purchase(slot);
                            pickedItems.Add(slot);

                        }
                        else if (choice2 == 3)
                        {
                            Change output = vendingMachine.ReturnChange();
                            Console.WriteLine($"Your change is {output.Total}\n ");

                            foreach (var item in pickedItems)
                            {
                                Console.WriteLine($"{vendingMachine.GetItemAtSlot(item).Consume()}\n");
                            }
                            break;
                        }
                        
                    }
                    
                    
                }
            }
        }
    }
}
