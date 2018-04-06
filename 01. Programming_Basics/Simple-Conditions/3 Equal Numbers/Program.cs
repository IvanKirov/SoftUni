using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var chislo1 = double.Parse(Console.ReadLine());
            var chislo2 = double.Parse(Console.ReadLine());
            var chislo3 = double.Parse(Console.ReadLine());
            if (chislo1 == chislo2 && chislo2 == chislo3)
            {
                Console.WriteLine("yes");
            }            
            else
            { Console.WriteLine("no"); }            
        }
    }
}
