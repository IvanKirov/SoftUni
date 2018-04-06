using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Sort();

            var dictionary = new Dictionary<int, int>();
            foreach (var number in numbers)
            {
                if (!dictionary.ContainsKey(number))
                {
                    dictionary[number] = 0;
                }

                dictionary[number]++;
            }

            foreach (var number in dictionary)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
