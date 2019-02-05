using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                var newPerson = Console.ReadLine().Split();                
                var newPersonAge = int.Parse(newPerson[1]);

                if (newPersonAge > 30)
                {
                    var newPersonName = newPerson[0];
                    people.Add(new Person(newPersonName, newPersonAge));
                }                
            }

            foreach (Person person in people.OrderBy(p => p.Name))
            {
                Console.WriteLine(person.Name + " - " + person.Age);
            }
        }
    }
}
