using System;

namespace STOP_sign
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = n;
            var y = 2 * n - 1;

            Console.WriteLine("{0}{1}{0}", new string('.', n + 1), new string('_', 2 * n + 1));
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}", new string('.', x), new string('_', y));
                x--;
                y += 2;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', 2 * n - 3));
            for (int row = 0; row < n; row++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', x), new string('_', y));
                x++;
                y -= 2;
            }
        }
    }
}
