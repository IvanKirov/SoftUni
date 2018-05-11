namespace _01._Define_Bank_Account_Class
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
            this.Balance -= amount;
        }
    }
}
