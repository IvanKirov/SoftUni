using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var W = double.Parse(Console.ReadLine());
            var L = double.Parse(Console.ReadLine());
            var M = int.Parse(Console.ReadLine());
            var O = int.Parse(Console.ReadLine());
            var broiPlochki = ((N * N) - (M * O)) / (W * L);
            Console.WriteLine(broiPlochki);
            Console.WriteLine(broiPlochki * 0.2);
        }
    }
}
