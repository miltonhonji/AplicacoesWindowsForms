﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAccount> AccountList = new List<IAccount>();

            CheckingAccount oCheckingAccount = new CheckingAccount();
            SavingsAccount oSavingsAccount = new SavingsAccount();

            oCheckingAccount.AccountNumber = 100;
            oSavingsAccount.AccountNumber = 200;

            AccountList.Add(oCheckingAccount);
            AccountList.Add(oSavingsAccount);

            foreach (IAccount a in AccountList)
            {
                Console.WriteLine(a.GetAccountInfo());
            }
            Console.ReadLine();
            /*List<Account> AccountList = new List<Account>();
            CheckingAccount oCheckingAccount = new CheckingAccount();
            SavingsAccount oSavingsAccount = new SavingsAccount();

            oCheckingAccount.AccountNumber = 100;
            oSavingsAccount.AccountNumber = 200;

            AccountList.Add(oCheckingAccount);
            AccountList.Add(oSavingsAccount);

            foreach(Account a in AccountList)
            {
                Console.WriteLine(a.GetAccountInfo());
            }
            Console.ReadLine();*/
        }
    }
}
