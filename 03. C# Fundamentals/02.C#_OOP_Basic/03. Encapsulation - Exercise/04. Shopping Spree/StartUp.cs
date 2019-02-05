using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> people;
            List<Product> products;

            try
            {
                people = new List<Person>(Console.ReadLine()
                .Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Split('='))
                .Select(p => new Person(p[0], decimal.Parse(p[1]))));

                products = new List<Product>(Console.ReadLine()
                    .Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Split('='))
                    .Select(p => new Product(p[0], decimal.Parse(p[1]))));
            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
                return;
            }
            

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(' ');
                var personName = tokens[0];
                var productName = tokens[1];

                var personIndex = people.FindIndex(p => p.Name == personName);
                var product = products[products.FindIndex(p => p.Name == productName)];
                people[personIndex].Purchase(product);
            }

            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");
                if (person.Bag.Count < 1)
                {
                    Console.WriteLine("Nothing bought");
                }
                else
                {
                    Console.WriteLine(string.Join(", ", person.Bag.Select(p => p.Name)));
                }
            }
        }
    }
}
