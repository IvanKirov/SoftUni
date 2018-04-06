using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var broi = int.Parse(Console.ReadLine());
            var sumEven = 0;
            var sumOdd = 0;
            for (int i = 1; i <= broi; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven = sumEven + number;
                }
                else
                {
                    sumOdd = sumOdd + number;
                }
            }
            var sumRazlika = Math.Abs(sumEven - sumOdd);
            if (sumRazlika == 0)
            {
                Console.WriteLine("Yes sum " + sumEven);
            }
            else
            {
                Console.WriteLine("No diff " + sumRazlika);
            }
        }
    }
}
