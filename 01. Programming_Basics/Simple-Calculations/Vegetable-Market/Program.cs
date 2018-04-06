using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            var PriceKgZelen = double.Parse(Console.ReadLine()) / 1.94;
            var PriceKgPlod = double.Parse(Console.ReadLine()) / 1.94;
            var KgZelen = double.Parse(Console.ReadLine());
            var KgPlod = double.Parse(Console.ReadLine());            
            Console.WriteLine(PriceKgZelen * KgZelen + PriceKgPlod * KgPlod);
        }
    }
}
