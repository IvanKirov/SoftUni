using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!Console.IsInputRedirected)
            {
                Console.WriteLine("This example requires that input be redirected from a file.");
                return;
            }

            Console.WriteLine("About to call Console.ReadLine in a loop.");
            Console.WriteLine("----");
            String s;
            int ctr = 0;
            do
            {
                ctr++;
                s = Console.ReadLine();
                Console.WriteLine("Line {0}: {1}", ctr, s);
            } while (s != null);
            Console.WriteLine("---");
        }
    }
}
