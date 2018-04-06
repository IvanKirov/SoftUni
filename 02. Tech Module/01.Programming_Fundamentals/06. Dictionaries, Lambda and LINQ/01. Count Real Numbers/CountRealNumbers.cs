using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Count_Real_Numbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            numbers.Sort();
            var sortedDictionary = new Dictionary<double, int>();

            foreach (var number in numbers)
            {
                if (!sortedDictionary.ContainsKey(number))
                {
                    sortedDictionary[number] = 0;
                }

                sortedDictionary[number]++;
            }

            foreach (var number in sortedDictionary)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
