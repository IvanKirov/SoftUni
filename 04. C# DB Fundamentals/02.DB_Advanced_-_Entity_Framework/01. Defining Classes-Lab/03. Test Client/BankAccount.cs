using System;

namespace _03.Test_Client
{
    class BankAccount
    {
        public int ID { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < this.Balance)
            {
                this.Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }
            
        }
    }
}
