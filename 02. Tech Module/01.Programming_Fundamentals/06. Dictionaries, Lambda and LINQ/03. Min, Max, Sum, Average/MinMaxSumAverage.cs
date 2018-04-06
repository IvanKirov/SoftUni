using System;
using System.Linq;

namespace _03.Min__Max__Sum__Average
{
    public class MinMaxSumAverage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                var newNumber = int.Parse(Console.ReadLine());
                numbers[i] = newNumber;
            }

            Console.WriteLine("Sum = " + numbers.Sum());
            Console.WriteLine("Min = " + numbers.Min());
            Console.WriteLine("Max = " + numbers.Max());
            Console.WriteLine("Average = " + numbers.Average());
        }
    }
}
