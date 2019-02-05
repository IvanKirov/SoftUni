namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age) :this()
        {            
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
