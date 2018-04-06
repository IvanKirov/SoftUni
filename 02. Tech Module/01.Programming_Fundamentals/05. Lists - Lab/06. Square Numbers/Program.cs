using System;
using System.Linq;

namespace _06.Square_Numbers
{
    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.Sort();
            numbers.Reverse();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) % 1 == 0)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
