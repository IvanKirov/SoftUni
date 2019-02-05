namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private decimal balance;

        //public int Id { get; set; }
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                id = value;
            }
        }

        // public decimal Balance { get; set; }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                balance = value;
            }
        }
    }
}
