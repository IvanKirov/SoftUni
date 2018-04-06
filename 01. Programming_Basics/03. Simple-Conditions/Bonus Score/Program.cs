using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var score = double.Parse(Console.ReadLine());
            var bscore = 0.00;
            if (score <= 100)
                {
                bscore = 5;
                }
            else if (score > 100 && score <= 999)
                {
                bscore = score * 0.2;
                }
            else if (score > 1000)
                {
                bscore = score * 0.1;
                }
           if (score % 2 == 0)
                {
                bscore += 1;
                }
            else if (score % 10 == 5)
                {
                bscore += 2;
                }
            Console.WriteLine("Bonus score: {0}", bscore);
            Console.WriteLine("Total score: {0}", score+bscore);
        }
    }
}
