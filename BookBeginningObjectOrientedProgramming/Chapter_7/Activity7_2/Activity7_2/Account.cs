using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_2
{
    public class Account
    {
        public double Balance { get; set; }
        public int AccountNumber { get; set; }

        public double GetBalance(int accountNumber)
        {
            AccountNumber = accountNumber;

            if (AccountNumber == 1)
                return 1000;
            else if (AccountNumber == 2)
                return 2000;
            else
                return -1;
        }

        public virtual double Withdraw(double amount)
        {
            Balance -= amount;
            return Balance;
        }
    }
}
