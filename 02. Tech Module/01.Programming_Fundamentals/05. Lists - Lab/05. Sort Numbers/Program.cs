using System;
using System.Linq;

namespace _05.Sort_Numbers
{
    public class SortNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToList();

            numbers.Sort();

            Console.Write(numbers[0]);
            for (int i = 1; i < numbers.Count; i++)
            {
                Console.Write($" <= {numbers[i]}");
            }
        }
    }
}
