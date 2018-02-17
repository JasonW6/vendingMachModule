using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    public class VendingMachineFileReader
    {
        private string FilePath;
        private const int DefaultQuantity = 5;
        private const int Col_SlotId = 0;
        private const int Col_Name = 1;
        private const int Col_Cost = 2;

        public VendingMachineFileReader(string filePath)
        {
            FilePath = filePath;
        }

        public Dictionary<string, List<VendingMachineItem>> GetInventory()
        {
            Dictionary<string, List<VendingMachineItem>> inventory = new Dictionary<string, List<VendingMachineItem>>();

            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] splitLine = line.Split('|');

                        List<VendingMachineItem> inventList = GetVendingMachineItemFromLine(splitLine);

                        inventory.Add(splitLine[Col_SlotId], inventList);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file.");
                Console.WriteLine(ex.Message);
            }

            return inventory;
        }

        private List<VendingMachineItem> GetVendingMachineItemFromLine(string[] splitLine)
        {
            List<VendingMachineItem> inventList = new List<VendingMachineItem>();
            VendingMachineItem item;
            if (splitLine[Col_SlotId].Contains('A'))
            {
                item = new ChipItem(splitLine[Col_Name], decimal.Parse(splitLine[Col_Cost]));
            }
            else if (splitLine[Col_SlotId].Contains('B'))
            {
                item = new CandyItem(splitLine[Col_Name], decimal.Parse(splitLine[Col_Cost]));
            }
            else if (splitLine[Col_SlotId].Contains('C'))
            {
                item = new BeverageItem(splitLine[Col_Name], decimal.Parse(splitLine[Col_Cost]));
            }
            else
            {
                item = new GumItem(splitLine[Col_Name], decimal.Parse(splitLine[Col_Cost]));
            }

            item.ItemStock = DefaultQuantity;
            inventList.Add(item);

            return inventList;
        }
    }
}
