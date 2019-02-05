namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Person firstPerson = new Person("Pesho", 12);
            Person secondPerson = new Person();
            secondPerson.Age = 15;
            secondPerson.Name = "Ivan";
        }
    }
}
