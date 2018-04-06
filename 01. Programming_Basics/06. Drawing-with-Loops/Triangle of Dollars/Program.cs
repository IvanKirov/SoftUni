using System;

namespace Triangle_of_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                for (int m = 0; m < i; m++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
