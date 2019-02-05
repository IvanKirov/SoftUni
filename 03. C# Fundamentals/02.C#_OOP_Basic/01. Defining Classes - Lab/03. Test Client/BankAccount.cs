using System;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

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
                Console.WriteLine("Insufficient balance");
            }            
        }

        public override string ToString()
        {
            return $"Account ID{this.Id}, balance {this.Balance:f2}";
        }
    }
}
