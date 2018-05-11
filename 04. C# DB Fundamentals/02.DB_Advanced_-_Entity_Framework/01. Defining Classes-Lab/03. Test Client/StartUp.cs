using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Test_Client
{
    public class StartUp
    {
        public static void Main()
        {
            var bankAccounts = new Dictionary<int, BankAccount>();
            BankAccount acc;
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split().ToArray();
                var command = tokens[0];

                switch (command)
                {
                    case "Create":
                        var newId = int.Parse(tokens[1]);
                        if (!bankAccounts.Contains(newId))
                        {
                            bankAccounts.Add(newId);
                            acc = new BankAccount();

                        }
                        break;
                    case "Deposit":
                        break;
                    case "Withdraw":
                        break;
                    case "Print":
                        Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");
                        break;
                }
            }
            acc.ID = 1;
            acc.Deposit(15);
            acc.Withdraw(5);

            Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");
        }
    }
}
