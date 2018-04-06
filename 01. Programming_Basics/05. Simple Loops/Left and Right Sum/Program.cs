using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var broi = int.Parse(Console.ReadLine());
            var sumLeft = 0;
            var sumRight = 0;
            for (int i = 1; i <= broi; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sumLeft = sumLeft + number;
            }
            for (int i = 1; i <= broi; i++)
            {
                var number = int.Parse(Console.ReadLine());
                sumRight = sumRight + number;
            }
            var sumRazlika = Math.Abs(sumLeft - sumRight);
            if (sumRazlika == 0)
            {
                Console.WriteLine("Yes sum " + sumLeft);
            }
            else
            {
                Console.WriteLine("No diff "+sumRazlika);
            }            
        }
    }
}
