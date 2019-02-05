using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Google
{
    public class StartUp
    {
        public static void Main()
        {
            var persons = new Dictionary<string, Person>();
            AddindPerseonsAndInfo(persons);

            var person = Console.ReadLine();

            Console.WriteLine(persons[person].ToString());
        }

        private static void AddindPerseonsAndInfo(Dictionary<string, Person> persons)
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var name = tokens[0];
                if (!persons.ContainsKey(name))
                {
                    persons[name] = new Person(name);
                }

                switch (tokens[1])
                {
                    case "company":
                        var companyName = tokens[2];
                        var department = tokens[3];
                        var salary = decimal.Parse(tokens[4]);
                        var newCompany = new Company(companyName, department, salary);
                        persons[name].Company = newCompany;
                        break;
                    case "pokemon":
                        var pokemonName = tokens[2];
                        var type = tokens[3];
                        var newPokemon = new Pokemon(pokemonName, type);
                        persons[name].AddPokemon(newPokemon);
                        break;
                    case "parents":
                        var parentName = tokens[2];
                        var parentBirthday = tokens[3];
                        var newParent = new Parent(parentName, parentBirthday);
                        persons[name].AddParent(newParent);
                        break;
                    case "children":
                        var childName = tokens[2];
                        var childBirthday = tokens[3];
                        var newChild = new Child(childName, childBirthday);
                        persons[name].AddChild(newChild);
                        break;
                    case "car":
                        var carName = tokens[2];
                        var speed = int.Parse(tokens[3]);
                        var newCar = new Car(carName, speed);
                        persons[name].Car = newCar;
                        break;
                }
            }
        }
    }
}
