using System;

namespace DivisionWithoutRemainder
{
    class DivisionWithoutRemainder
    {
        static void Main(string[] args)
        {
            var broi = int.Parse(Console.ReadLine());
            decimal p1 = 0M;
            decimal p2 = 0M;
            decimal p3 = 0M;           
            for (int i = 1; i <= broi; i++)
            {
                int vhodChislo = int.Parse(Console.ReadLine());
                if (vhodChislo % 2 == 0) { p1++; }
                if (vhodChislo % 3 == 0) { p2++; }
                if (vhodChislo % 4 == 0) { p3++; }
            }
            Console.WriteLine("{0:f2}%", p1 / broi * 100);
            Console.WriteLine("{0:f2}%", p2 / broi * 100);
            Console.WriteLine("{0:f2}%", p3 / broi * 100);           
        }
    }
}
