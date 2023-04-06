using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_2
{
    public class CheckingAccount : Account
    {
        double _balance;

        /*public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }*/

        public double GetMinimumBalance()
        {
            return 200;
        }

        public override double Withdraw(double amount)
        {
            if (Balance >= amount + GetMinimumBalance())
            {
                return base.Withdraw(amount);
            }
            else
            {
                return -1; //Not enough funds
            }
        }
    }
}
