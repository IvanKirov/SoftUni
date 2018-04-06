using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            var obemV = int.Parse(Console.ReadLine());
            var pipe1 = int.Parse(Console.ReadLine());
            var pipe2 = int.Parse(Console.ReadLine());
            var chasH = decimal.Parse(Console.ReadLine());
            var water = (pipe1 + pipe2) * chasH;            
            if (water > obemV)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", chasH, water - obemV);
            }
            else
            {
                var fullPull = Math.Truncate(water / obemV * 100);
                var p1 = Math.Truncate((pipe1 * chasH) / water * 100);
                var p2 = Math.Truncate((pipe2 * chasH) / water * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", fullPull, p1, p2);
            }
        }
    }
}
