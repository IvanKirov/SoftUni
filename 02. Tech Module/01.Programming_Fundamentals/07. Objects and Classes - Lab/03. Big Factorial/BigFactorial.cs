using System;
using System.Numerics;

namespace _03.Big_Factorial
{
    public class BigFactorial
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            BigInteger result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            Console.WriteLine(result);
        }
    }
}
