using System;
using System.Linq;

namespace _05.Rounding_Numbers
{
    public class RoundingNumbers
    {
        public static void Main()
        {
            double[] numberArray = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            for (int number = 0; number < numberArray.Length; number++)
            {
                var roundedNumber = Math.Round(numberArray[number], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numberArray[number]} => {roundedNumber}");
            }
        }
    }
}
