using System;
using System.Linq;
using System.Numerics;

namespace _02.Convert_from_base_N_to_base_10
{
    public class ConvertFromBase_N_ToBase10
    {
        public static BigInteger IntPow(BigInteger number, int power)
        {
            BigInteger result = 1;
            for (int i = 0; i < power; i++)
            {
                result *= number;
            }
            return result;
        }

        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var nBase = int.Parse(numbers[0]);
            var number = numbers[1]
                .ToCharArray()
                .Select(char.GetNumericValue)
                .ToList();

            number.Reverse();

            BigInteger answer = 0;

            for (int i = 0; i < number.Count; i++)
            {
                var digit = new BigInteger(number[i]);
                if (digit != 0)
                {
                    answer += digit * IntPow(nBase, i);
                }                
            }

            Console.WriteLine(answer);
        }
    }
}
