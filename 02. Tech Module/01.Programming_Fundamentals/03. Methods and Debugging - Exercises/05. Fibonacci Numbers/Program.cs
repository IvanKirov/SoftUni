using System;

namespace _05.Fibonacci_Numbers
{
    public class FibonacciNumbers
    {
        public static int FibonacciNumber(int number)
        {
            int fibonachiNumber = 1;
            int newNumber = 0;
            for (int i = 0; i < number; i++)
            {
                var oldNumber = fibonachiNumber;
                fibonachiNumber += newNumber;
                newNumber = oldNumber;
            }

            return fibonachiNumber;
        }

        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var answer = FibonacciNumber(number);

            Console.WriteLine(answer);
        }
    }
}
