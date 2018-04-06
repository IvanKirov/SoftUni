using System;

namespace Draw_Fort
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int x = (n <= 4) ? 0 : (2*n-2*(n/2)-4); //proverka za n = 3 ili 4 i zadavane na ostataka na sredata
            for (int row = 1; row <= n - 1 ; row++)
            {
                if (row == 1)   // first row
                {
                    Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', x));
                }
                else if (row == n - 1)  // last row
                {
                    Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 + 1), new string('_', x));
                    Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', x));
                }
                else
                {   // drugite redove
                    Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
                }
            }
        }
    }
}
