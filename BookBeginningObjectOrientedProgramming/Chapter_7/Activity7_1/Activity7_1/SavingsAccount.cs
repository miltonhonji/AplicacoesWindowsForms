using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_1
{
    class SavingsAccount : Account
    {
        private double _dblBalance;

        public double Withdraw(int accountNumber, double amount)
        {
            _dblBalance = GetBalance(accountNumber);

            if(_dblBalance >= amount)
            {
                _dblBalance -= amount;
                return _dblBalance;
            }
            else
            {
                //Not enough funds
                return -1;
            }
        }
    }
}
