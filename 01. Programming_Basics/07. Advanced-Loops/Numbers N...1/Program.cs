using System;

namespace Numbers_N._._._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());            
            while ( n>0 )
            {
                Console.WriteLine(n);
                n--;
            }
            for (int i = n; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}
