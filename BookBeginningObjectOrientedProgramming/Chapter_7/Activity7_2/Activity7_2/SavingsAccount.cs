using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_2
{
    public class SavingsAccount : Account
    {

        public override double Withdraw(double amount)
        {
            if(Balance >= amount)
            { 
                return base.Withdraw(amount);
            }
            else
            {
                return -1;
            }
        }

    }
}
