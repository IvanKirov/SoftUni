using System;

namespace Histogram
{
    public class Histogram
    {
        public static void Main()
        {
            var broi = int.Parse(Console.ReadLine());
            decimal p1 = 0M;
            decimal p2 = 0M;
            decimal p3 = 0M;
            decimal p4 = 0M;
            decimal p5 = 0M;

            for (int i = 1; i <= broi; i++)
            {
                int vhodChislo = int.Parse(Console.ReadLine());
                if (vhodChislo < 200) { p1++; }
                else if (vhodChislo >= 200 && vhodChislo < 400) { p2++; }
                else if (vhodChislo >= 400 && vhodChislo < 600) { p3++; }
                else if (vhodChislo >= 600 && vhodChislo < 800) { p4++; }
                else if (vhodChislo >= 800) { p5++; }
            }
            
            Console.WriteLine("{0:f2}%", p1 / broi * 100);
            Console.WriteLine("{0:f2}%", p2 / broi * 100);
            Console.WriteLine("{0:f2}%", p3 / broi * 100);
            Console.WriteLine("{0:f2}%", p4 / broi * 100);
            Console.WriteLine("{0:f2}%", p5 / broi * 100);
        }
    }
}
