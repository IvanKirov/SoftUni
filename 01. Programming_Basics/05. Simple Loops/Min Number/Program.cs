using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var broi = int.Parse(Console.ReadLine());            
            var minNumber = int.Parse(Console.ReadLine()); 
            for (int i = 1; i < broi; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (minNumber > number)
                {
                    minNumber = number;
                }
            }
            Console.WriteLine(minNumber);
        }
    }
}
