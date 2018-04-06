using System;

namespace _06.Prime_Checker
{
    public class PrimeChecker
    {
        public static bool IsPrime(long number)
        {
            var isPrime = true;
            if (number < 2)
            {
                isPrime = false;
            }

            for (long divider = 2; divider <= Math.Sqrt(number); divider++)  
            {
                if (number % divider == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }

        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());

            var answer = IsPrime(number);

            Console.WriteLine(answer);
        }
    }
}
