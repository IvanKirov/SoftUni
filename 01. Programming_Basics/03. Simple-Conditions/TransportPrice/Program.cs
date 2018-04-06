using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var patKm = int.Parse(Console.ReadLine());
            var den = Console.ReadLine();
            if (patKm >= 100)
            {
                Console.WriteLine(patKm * 0.06);
            }
            else if (patKm >= 20)
            {
                Console.WriteLine(patKm * 0.09);
            }
            else
            {
                if (den=="day")
                {
                    Console.WriteLine(patKm * 0.79+0.70);
                }
                else
                {
                    Console.WriteLine(patKm * 0.9+0.70);
                }
            }
        }
    }
}
