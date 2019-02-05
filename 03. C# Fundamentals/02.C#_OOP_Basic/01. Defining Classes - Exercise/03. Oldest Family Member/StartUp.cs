using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            Family family = new Family();
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var newPerson = Console.ReadLine().Split();
                var newPersonName = newPerson[0];
                var newPersonAge = int.Parse(newPerson[1]);

                family.AddMember(new Person(newPersonName, newPersonAge));
            }

            var oldetsMember = family.GetOldestMember();
            Console.WriteLine(oldetsMember.Name + " " + oldetsMember.Age);

        }
    }
}
