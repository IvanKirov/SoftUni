using System;

namespace _09.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());            
            for (int number = 1; number <= maxNumber; number++)
            {
                int digits = number;
                int specialNumber = 0;
                while (digits > 0)
                {
                    specialNumber += digits % 10;
                    digits = digits / 10;
                }
                bool answer = (specialNumber == 5) || (specialNumber == 7) || (specialNumber == 11);
                Console.WriteLine($"{number} -> {answer}");
                specialNumber = 0;
            }

        }
    }
}
