using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            int chislo = int.Parse(Console.ReadLine());
            if (chislo > 200)
            {
                Console.WriteLine("Greater than 200");
            }
            else if (chislo > 99 && chislo <=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Less than 100");
            }
        }
    }
}
