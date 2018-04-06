using System;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                for (int m = 0; m < N; m++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
