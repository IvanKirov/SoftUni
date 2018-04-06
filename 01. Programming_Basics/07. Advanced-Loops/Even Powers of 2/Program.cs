using System;

namespace Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int sum = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(sum);
                sum = sum * 4;
            }
        }
    }
}
