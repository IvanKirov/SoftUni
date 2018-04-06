using System;

namespace _02.Sign_of_Integer_Number
{
    public class Program
    {
        public static void PrintAnswer(int number)
        {
            if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else
            {
                Console.WriteLine($"The number 0 is zero.");
            }
        }

        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            PrintAnswer(number);
        }
    }
}
