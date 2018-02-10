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

        public void RecordCompleteTransaction(decimal remainingBalance)
        {
            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine($"{DateTime.Now} GIVE CHANGE: {remainingBalance}");
            }
        }
        public void RecordDeposit(decimal amount, decimal finalBalance)
        {
            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine($"{DateTime.Now} FEED MONEY: {amount} {finalBalance}");
            }
        }
        public void RecordPurchase(string slot, string product, decimal intialBal, decimal finalBal)
        {
            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                sw.WriteLine($"{DateTime.Now} {product} {slot} {intialBal} {finalBal}");
            }
        }

    }

}
