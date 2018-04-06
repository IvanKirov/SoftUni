using System;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 1;

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(sum);
                sum = sum * 2;
            }
        }
    }
}
