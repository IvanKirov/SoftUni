namespace _12._Google
{
    public class Company
    {
        private string name;
        private string department;
        private decimal salary;

        public Company(string name, string department, decimal salary)
        {
            this.name = name;
            this.salary = salary;
            this.department = department;
        }

        public override string ToString()
        {
            return $"{this.name} {this.department} {this.salary:F2}";
        }
    }
}
