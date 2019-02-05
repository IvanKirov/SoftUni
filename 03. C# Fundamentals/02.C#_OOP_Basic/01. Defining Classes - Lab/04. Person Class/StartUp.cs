using System;
using System.Collections.Generic;
using System.Linq;

namespace BankAccount
{
    public class StartUp
    {
        public static void Main()
        {
            var accounts = new Dictionary<int, BankAccount>();
            string input;
           

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(' ').ToArray();

                var command = tokens[0];
                var id = int.Parse(tokens[1]);

                if (command == "Create" || accounts.ContainsKey(id))
                {
                    switch (command)
                    {
                        case "Create":
                            CreatAccount(accounts, id);
                            break;
                        case "Deposit":
                            accounts[id].Deposit(int.Parse(tokens[2]));
                            break;
                        case "Withdraw":
                            accounts[id].Withdraw(int.Parse(tokens[2]));
                            break;
                        case "Print":
                            Console.WriteLine(accounts[id]);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Account does not exist");
                }
            }
        }

        public static void CreatAccount(Dictionary<int, BankAccount> accounts, int id)
        {
            if (!accounts.ContainsKey(id))
            {
                accounts[id] = new BankAccount();
                accounts[id].Id = id;
            }
            else
            {
                Console.WriteLine("Account already exists");
            };
        }
    }
}
