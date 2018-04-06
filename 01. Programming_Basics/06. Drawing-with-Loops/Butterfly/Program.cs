using System;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var maxRow = 2 * n - 3;             //maximalen broi redove
            var midRow = (1 + maxRow) / 2;      //sreden red

            for (int row = 1; row <= maxRow; row++)
            {
                if (row < midRow)
                {
                    Console.WriteLine("{0}\\ /{0}", new string((row % 2 == 0) ? '-':'*', n - 2));
                }
                else if (row == midRow)
                {
                    Console.WriteLine("{0}@", new string(' ', n - 1));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}", new string((row % 2 == 0) ? '-' : '*', n - 2));
                }                
            }
        }
    }
}
