namespace PersonsInfo
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName { get => this.firstName; }

        public string LastName { get => this.lastName; }

        public int Age { get => this.age; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age} years old.";
        }

    }
}
