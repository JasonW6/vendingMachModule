using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class TransactionLogger
    {
        private string FilePath;

        public TransactionLogger(string filePath)
        {
            FilePath = filePath;
        }
        public void RecordDeposit(decimal amount, decimal finalBalance)
        {

        }
        public void RecordPurchase(string slot, string product, decimal intialBal, decimal finalBal)
        {

        }
        public void RecordCompleteTransaction(decimal remainingBalance)
        {

        }

    }
}
