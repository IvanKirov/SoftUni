using System;
using System.Linq;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    public class ConvertFromBase10ToBaseN
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var nBase = int.Parse(numbers[0]);
            var number = BigInteger.Parse(numbers[1]);
            var answer = string.Empty;
            
            
            while (number >0)
            {
                BigInteger remainder = number % nBase;
                number /= nBase;
                answer = remainder + answer;                
            }

            Console.WriteLine(answer);
        }
    }
}
