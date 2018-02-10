using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Classes
{
    public class Change
    {
        public int Nickels { get; }
        public int Dimes { get; }
        public int Quarters { get; }
        public string Total
        {
            get { return $"{Nickels} nickels {Dimes} Dimes {Quarters} Quarters"; }
        }

        public Change(decimal balance)
        {
            while (balance >= .25M)
            {
                Quarters++;
                balance -= .25M;
            }
            while (balance >= .10M)
            {
                Dimes++;
                balance -= .10M;
            }
            while (balance >= .05M)
            {
                Nickels++;
                balance -= .05M;
            }
        }
    }
}
