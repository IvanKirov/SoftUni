using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int i;
            int k;
            int j = n - 2;
            for (i = 1; i <= n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
            for (k = 1; k <= j; k++)
            {
                Console.Write("*");
                for (i = 1; i <= j; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                Console.WriteLine();
            }
            for (i = 1; i <= n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine(" ");
        }
    }
}
