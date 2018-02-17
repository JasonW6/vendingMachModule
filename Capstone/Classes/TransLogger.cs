using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Capstone.Classes
{
    public class TransLogger
    {
        private string FilePath { get; }

        public TransLogger(string filepath)
        {
            FilePath = filepath;            
        }

        private void WriteMessageToFile(string message)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(FilePath, true))
                {
                    sw.WriteLine(message);
                }
            }
            catch(IOException ex)
            {
                Console.WriteLine("Error writing to file.");
                Console.WriteLine(ex.Message);
            }
        }

        public void RecordCompleteTransaction(decimal remainingBalance)
        {
            WriteMessageToFile($"{DateTime.Now} GIVE CHANGE: {remainingBalance}");           
        }

        public void RecordDeposit(decimal amount, decimal finalBalance)
        {
            WriteMessageToFile($"{DateTime.Now} FEED MONEY: {amount} {finalBalance}");            
        }

        public void RecordPurchase(string slot, string product, decimal intialBal, decimal finalBal)
        {
            WriteMessageToFile($"{DateTime.Now} {product} {slot} {intialBal} {finalBal}");            
        }

    }

}
