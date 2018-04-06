using System;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int blanks = n - 1;
            for (int red = 0; red <= n-1; red++)
            {
                Console.Write(new string(' ', blanks));
                for (int stars = 0; stars <= red; stars++)
                {
                    Console.Write("* ");
                }                
                Console.WriteLine();
                blanks--;
            }
            blanks = 1;
            for (int red = n-1; red >= 1; red--)
            {
                Console.Write(new string(' ', blanks));
                for (int stars = red; stars > 0; stars--)
                { 
                    Console.Write("* ");
                }
                Console.WriteLine();
                blanks++;
            }

        }
    }
}
