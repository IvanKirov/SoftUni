using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var vrem1 = int.Parse(Console.ReadLine());
            var vrem2 = int.Parse(Console.ReadLine());
            var vrem3 = int.Parse(Console.ReadLine());
            int tvrem = (vrem1 + vrem2 + vrem3);
            if ( tvrem <= 59 )
            {
                Console.WriteLine("0:{0:00}", tvrem);
            }
            else if ( tvrem > 59 && tvrem <= 119)
            {
                Console.WriteLine("1:{0:00}", tvrem - 60);
            }
            else if ( tvrem > 119)
            {
                Console.WriteLine("2:{0:00}", tvrem - 120);
            }            
        }
    }
}
