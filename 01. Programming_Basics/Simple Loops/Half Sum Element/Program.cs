using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var broi = int.Parse(Console.ReadLine());
            int sum = 0;
            int maxNumber = -2147483648;
            for (int i = 1; i <= broi; i++) 
            {
                var number = int.Parse(Console.ReadLine());
                sum = sum + number;
                if (number > maxNumber) { maxNumber = number; }
            }
            var ostatak = (sum - maxNumber);
            if (ostatak == maxNumber)
            {
                Console.WriteLine("Yes sum " + maxNumber);
            }
            else
            {
                Console.WriteLine("No diff " + Math.Abs(maxNumber - ostatak));
            }
        }
    }
}
