using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class VendingMachineCLI
    {
        private VendingMachine VendingMachine;

        public VendingMachineCLI(VendingMachine)
        {

        }

        public void Run()
        {
            Console.WriteLine("(1) Display Vending Machine Items");
            Console.WriteLine("(2) Purchase");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {

            }
            else if (choice == 2)
            {
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
            }
        }
    }
}
