using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());            
            double z, x = 1, y = 1;

            for (int i = 0; i < n-1; i++)
            {                
                z = x;
                x += y;
                y = z;
            }
            Console.WriteLine(x);
        }
    }
}
