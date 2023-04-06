using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_3
{
    //public class SavingsAccount : Account
    public class SavingsAccount : IAccount
    {
        public int AccountNumber { get; set; }

        public string GetAccountInfo()
        {
            return $"Printing savings account info for account number { AccountNumber.ToString() }";
        }

        /*public override string GetAccountInfo()
        {
            return $"Printing savings account info for account number { AccountNumber.ToString() }";
        }*/
    }
}
