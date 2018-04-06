using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 1;

            do
            {
                sum = sum * n;
                n--;
            } while (n > 1);
            Console.WriteLine(sum);
            for (int i = 1; i <= n; i++)
            {
                sum = sum * i;
            }
            Console.WriteLine(sum);
        }
    }
}
