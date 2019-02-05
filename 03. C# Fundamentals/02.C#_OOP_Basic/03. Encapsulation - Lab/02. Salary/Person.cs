namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.salary = salary;
        }

        public decimal Salary { get => this.salary; }

        public string FirstName { get => this.firstName; }

        public string LastName { get => this.lastName; }

        public int Age { get => this.age; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} receives {Salary:F2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (age < 30)
            {
                percentage /= 2;
            }

            this.salary += this.salary / 100 * percentage;
        }
    }
}
