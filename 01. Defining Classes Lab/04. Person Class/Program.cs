using System;
using System.Collections.Generic;

namespace BankAccount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BankAccount fibank = new BankAccount();
            fibank.Id = 1230001;
            fibank.Balance = 550.02m;
            BankAccount ktb = new BankAccount();
            ktb.Id = 2000123;
            ktb.Balance = 10m;
            List<BankAccount> accounts = new List<BankAccount> { fibank, ktb };

            Person pael = new Person("Pavel", 23, accounts);

            Console.WriteLine(pael.GetBalance());
        }
    }
}
