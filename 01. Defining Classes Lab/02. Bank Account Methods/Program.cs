using System;

namespace _02._Bank_Account_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount();
            account.Id = 1;
            account.Deposit(15);
            account.WithDraw(10);
            Console.WriteLine(account);
        }
    }
}
