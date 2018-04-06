using System;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            var greater = Math.Max(a, b);
            var lesser = Math.Min(a, b);

            while (lesser != 0)
            {
                var ostatak = greater % lesser;
                greater = lesser;
                lesser = ostatak;
            }
            Console.WriteLine(greater);
        }
    }
}
