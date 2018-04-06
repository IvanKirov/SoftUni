using System;

namespace _08.Multiply_Evens_by_Odds
{
    public class Program
    {
        public static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumEvens = GetSumOfEvenDigits(number);
            int sumOdds = GetSumOfOddDigits(number);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfOddDigits(int number)
        {
            var result = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 1)
                {
                    result += digit;
                }
            }

            return result;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            var result = 0;
            foreach (var symbol in number.ToString())
            {
                var digit = symbol - '0';
                if (digit % 2 == 0)
                {
                    result += digit;
                }
            }

            return result;
        }

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int answer = GetMultipleOfEvensAndOdds(number);
            Console.WriteLine(answer);
        }
    }
}
