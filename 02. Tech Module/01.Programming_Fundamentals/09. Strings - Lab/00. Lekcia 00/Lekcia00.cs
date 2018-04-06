using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace _00.Lekcia_00
{
    public class Program
    {
        public static void Main()
        {
            var result = string.Empty;
            int testNumber = 50000;

            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < testNumber; i++)
            {
                result += i.ToString();
            }



            stopwatch.Stop();
            Console.WriteLine($"'???' - {stopwatch.Elapsed}");

            var sb = new StringBuilder();
            stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < testNumber; i++)
            {
                sb.Append(i);
            }

            stopwatch.Stop();
            result = sb.ToString();

            Console.WriteLine($"'StringBuilder' - {stopwatch.Elapsed}");
        }
    }
}
