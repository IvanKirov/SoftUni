using System;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id { get; set; }

        public decimal Balance { get; set; }

        public void Deposit(decimal ammount)
        {
            this.Balance += ammount;
        }

        public void Withdraw(decimal ammount)
        {
            if (Balance >= ammount)
            {
                this.Balance -= ammount;
            }
            else
            {
                throw new ArgumentException("Insufficient ammount!");
            }            
        }

        public override string ToString()
        {
            return $"Account {this.Id}, balance {this.Balance}";
        }
    }
}
