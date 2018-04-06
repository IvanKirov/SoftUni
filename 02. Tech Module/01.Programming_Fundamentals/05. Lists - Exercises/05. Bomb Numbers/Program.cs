using System;
using System.Linq;

namespace _05.Bomb_Numbers
{
    public class BombNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var specialNumbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var lenght = numbers.Count;
            var power = specialNumbers[1];
            var bombNumber = specialNumbers[0];

            for (int i = 0; i < lenght; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber == bombNumber)
                {
                    var start = Math.Max(i - power, 0);
                    var end = Math.Min(power + i, lenght - 1);
                    var range = (end - start + 1);
                    numbers.RemoveRange(start, range);
                    i = 0;
                    lenght -= range;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
