using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_3
{
    //public class CheckingAccount : Account
    public class CheckingAccount : IAccount
    {
        public int AccountNumber { get; set; }

        public string GetAccountInfo()
        {
            return $"Printing checking account info for account number {AccountNumber.ToString()} ";
        }
        /*public override string GetAccountInfo()
        {
            return $"Printing checking account info for account number {AccountNumber.ToString()} ";
        }*/
    }
}
