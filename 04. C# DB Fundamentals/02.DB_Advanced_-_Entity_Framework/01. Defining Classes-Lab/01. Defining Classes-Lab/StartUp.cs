using System;
using System.Linq;

namespace _01._Define_Bank_Account_Class
{
    public class StartUp
    {
        public static void Main()
        {
            BankAccount acc = new BankAccount();
            
            acc.ID = 1;
            acc.Deposit(15);
            acc.Withdraw(5);

            Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");
        }
    }
}
