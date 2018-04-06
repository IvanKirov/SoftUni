using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            begin:
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            if (w < 3 || w > h || h > 100)
            {
                Console.WriteLine("Greshni stoinosti");
                goto begin;
            }
            var BroiRed = Math.Truncate(h * 100 / 120);
            var BuraRed = Math.Truncate((w * 100 - 100) / 70);            
            Console.WriteLine(BroiRed * BuraRed - 3);
        }
    }
}
