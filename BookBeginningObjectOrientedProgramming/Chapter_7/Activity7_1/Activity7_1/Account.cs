using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_1
{
    //class Account
    abstract class Account
    {
        private int _accountNumber;

        //public double GetBalance(int accountNumber)
        protected double GetBalance(int accountNumber)
        {
            _accountNumber = accountNumber;

            //Data normally retrieved from database
            if (_accountNumber == 1)
                return 1000;
            else if (_accountNumber == 2)
                return 2000;
            else
                //Account number is incorrect
                return -1;
        }
    }
}
