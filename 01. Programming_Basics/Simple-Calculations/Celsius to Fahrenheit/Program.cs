using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = Double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(c * 9 / 5 + 32, 2));
        }
    }
}
