using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            string mer1 = Console.ReadLine();
            string mer2 = Console.ReadLine();    
            var currencies = new Dictionary<string, double>()
            {
                {"m", 1 },
                {"mm", 1000 },
                {"cm", 100 },
                {"mi", 0.000621371192},
                {"in", 39.3700787},
                {"km", 0.001},
                {"ft", 3.2808399},
                {"yd", 1.0936133}
            };
            double result = sum / currencies[mer1] * currencies[mer2];

            Console.WriteLine("{0} {1}", result, mer2);
        }
    }
}
