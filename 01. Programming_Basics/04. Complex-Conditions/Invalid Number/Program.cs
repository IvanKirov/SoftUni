using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // logichesko otricanie
            var chislo = int.Parse(Console.ReadLine());
            var InRange = (chislo == 0 || chislo >= 100 && chislo <= 200);
            if (!InRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
