using System;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    public class FactorialTrailingZeroes
    {
        public static BigInteger Factoriel(int number)
        {
            BigInteger factoriel = 1;
            while (number > 1)
            {
                factoriel *= number;
                number--;
            }

            var zeroCounter = 0;
            while (true)
            {
                var zeroCheck = factoriel % 10;
                if (zeroCheck > 0)
                {
                    break;
                }
                zeroCounter++;
                factoriel = factoriel / 10;
            }

            return zeroCounter;
        }
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            

            Console.WriteLine(Factoriel(number));
        }
    }
}
