using System;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int red = 1; red <= n; red++)
            {                
                if (red == 1 || red == n)
                {
                        Console.WriteLine(new string('*', n * 2) + new string(' ', n) + new string('*', n * 2));
                }
                else if (red == (n - 1) / 2 + 1)
                {
                    Console.WriteLine("*" + new string('/', n * 2 - 2) + "*" + new string('|', n) + "*" + new string('/', n * 2 - 2) + "*");
                }
                else
                {
                    Console.WriteLine("*" + new string('/', n * 2 - 2) + "*" + new string(' ', n) + "*" + new string('/', n * 2 - 2) + "*");
                }                
            }
        }
    }
}
