using System;
using System.Collections.Generic;

namespace BankAccount
{
    class StartUp
    {
        static void Main(string[] args)
        {
            BankAccount fibank = new BankAccount();
            fibank.Id = 02452354;
            fibank.Balance = 1000000;
            BankAccount unicredit = new BankAccount();
            unicredit.Id = 2000123;
            unicredit.Balance = 2000000;
            List<BankAccount> accounts = new List<BankAccount> { fibank, unicredit };

            Person person = new Person("Svetloslav", 16, accounts);

            Console.WriteLine(person.GetBalance());
        }
    }
}
