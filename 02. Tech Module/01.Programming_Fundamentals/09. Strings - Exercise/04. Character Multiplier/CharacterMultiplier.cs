using System;
using System.Linq;

namespace _04.Character_Multiplier
{
    public class CharacterMultiplier
    {
        public static void Main()
        {
            var inputString = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var firstString = inputString[0].ToCharArray();
            var lenghtStringOne = firstString.Length;

            var secondString = inputString[1].ToCharArray();
            var lenghtStringTwo = secondString.Length;

            var sum = 0;

            var length = Math.Min(lenghtStringOne, lenghtStringTwo);
            for (int i = 0; i < length; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            if (lenghtStringOne != lenghtStringTwo)
            {
                var longrString = inputString.OrderByDescending(s => s.Length).First();

                for (int i = length; i < longrString.Length; i++)
                {
                    sum += longrString[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
