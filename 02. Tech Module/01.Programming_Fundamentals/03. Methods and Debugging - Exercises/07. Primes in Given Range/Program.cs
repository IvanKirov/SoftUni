using System;

namespace _07.Primes_in_Given_Range
{
    public class PrimesInGivenRange
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
            long firstNumber = long.Parse(Console.ReadLine());
            long lastNumber = long.Parse(Console.ReadLine());
            string emptyString = string.Empty;

            for (long number = firstNumber; number <= lastNumber; number++)
            {
                var answer = IsPrime(number);
                emptyString += answer ? $"{number}, " : string.Empty;
            }

            var answerString = emptyString.TrimEnd(' ', ',');
            Console.Write(answerString);
        }
    }
}
