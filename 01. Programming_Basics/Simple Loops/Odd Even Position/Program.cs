using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var broi = int.Parse(Console.ReadLine());

            double oddSum = 0D;
            double evenSum = 0D;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            
            for (int i = 1; i <= broi; i++)
            {
                var vhodChislo = double.Parse(Console.ReadLine());                
                if (i % 2 == 0)
                {
                    evenSum += vhodChislo;
                    if (vhodChislo > evenMax)
                    {
                        evenMax = vhodChislo;
                    }
                    if (vhodChislo < evenMin)
                    {
                        evenMin = vhodChislo;
                    }
                }
                else
                {
                    oddSum += vhodChislo;
                    if (vhodChislo > oddMax)
                    {
                        oddMax = vhodChislo;
                    }
                    if (vhodChislo < oddMin)
                    {
                        oddMin = vhodChislo;
                    }
                }
            }
            if (broi == 0)
            {
                Console.WriteLine("OddSum=0");
                Console.WriteLine("OddMin=No");
                Console.WriteLine("OddMax=No");
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else if (broi == 1)            
            {
                Console.WriteLine("OddSum=" + oddSum);
                Console.WriteLine("OddMin=" + oddMin);
                Console.WriteLine("OddMax=" + oddMax);
                Console.WriteLine("EvenSum=0");
                Console.WriteLine("EvenMin=No");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine("OddSum=" + oddSum);
                Console.WriteLine("OddMin=" + oddMin);
                Console.WriteLine("OddMax=" + oddMax);
                Console.WriteLine("EvenSum=" + evenSum);
                Console.WriteLine("EvenMin=" + evenMin);
                Console.WriteLine("EvenMax=" + evenMax);
            }                        
        }
    }
}
