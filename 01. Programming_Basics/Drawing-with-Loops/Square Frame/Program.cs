using System;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            for (int red = 1; red <= N; red++)
            {
                if (red == 1 || red == N)
                {
                    Console.Write("+ ");
                    for (int i = 1; i <= N - 2; i++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("+");
                }
                else
                {
                    Console.Write("| ");
                    for (int i = 1; i <= N - 2; i++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine("|");
                }
            }
            
        }
    }
}
