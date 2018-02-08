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
        public decimal Total
        {
            get { return Nickels + Dimes + Quarters; }
        }

        public Change(decimal total)
        {
            while (total > .25M)
            {
                Quarters++;
                total -= .25M;
            }
            while (total > .10M)
            {
                Dimes++;
                total -= .10M;
            }
            while (total > .05M)
            {
                Nickels++;
                total -= .05M;
            }
        }
    }
}
