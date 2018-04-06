using System;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            for (int mainNumber = 2; mainNumber <= inputNumber; mainNumber++)
            {
                bool isPrime = true;
                for (int divisorNumber = 2; divisorNumber <= Math.Sqrt(mainNumber); divisorNumber++)
                {
                    if (mainNumber % divisorNumber == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{mainNumber} -> {isPrime}");
            }

        }
    }
}
