using System;

namespace _05.Cup
{
    public class Cup
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n + 1; i++)
            {
                if (i < n / 2)  // first part of the cup
                {
                    Console.WriteLine("{0}{1}{0}", new String('.', n + i), new String('#', 3 * n - i * 2));
                }
                else //hollow part
                {
                    Console.WriteLine("{0}#{1}#{0}", new String('.', n + i), new String('.', 3 * n - i * 2 - 2));
                }
            }

            // last line of the bowl
            Console.WriteLine("{0}{1}{0}", new String('.', 2 * n), new String('#', n));

            for (int i = 0; i < n + 2; i++)
            {
                if (i == n / 2 )
                {               //the line D^A^N^C^E^
                    Console.WriteLine("{0}{1}{0}", new String('.', (5 * n - 10) / 2), "D^A^N^C^E^");
                }
                else
                {
                    //Console.WriteLine("{0}{1}{0}", new String('.', (5 * n - (n + 4)) / 2), new String('#', n + 4));
                    Console.WriteLine("{0}{1}{0}", new String('.', 2 * (n - 1) ), new String('#', n + 4));
                }
            }
        }
    }
}
