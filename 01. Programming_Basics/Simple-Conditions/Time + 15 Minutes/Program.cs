using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var chas = int.Parse(Console.ReadLine());
            var minuti = int.Parse(Console.ReadLine());
            minuti += 15;
            if (minuti >= 60)
            {
                chas += 1;
                minuti -= 60;
                if (chas == 24)
                {
                    chas = 0;
                }
            }                        
            Console.WriteLine("{0}:{01:00}", chas,  minuti);            
        }
    }
}
