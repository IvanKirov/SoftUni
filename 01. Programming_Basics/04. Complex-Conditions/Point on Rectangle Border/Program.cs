using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            // var onBorder = (((x == x1 || x == x2) && (y >= y1 && y <= y2)) || ((y == y1 || y == y2) && (x >= x1 && x <= x2)));
            // if (onBorder) tova moje da vmesto izpolzvaniat if red

            //var onLeftSide = ((x == x1) && (y >= y1 && y <= y2));
            //var onRightSie = ((x == x2) && (y >= y1 && y <= y2));
            //var onTopSide = ((y == y1) && (x >= x1 && x <= x2));
            //var onBottomSide = ((y == y1) && (x >= x1 && x <= x2));
            //if (onLeftSide || onRightSie || onTopSide || onBottomSide)

            if (((x == x1 || x== x2) && (y >= y1 && y <= y2)) ||    //proveryavame dali tochkata X,Y leji na nyakoya strana
               ((y == y1 || y == y2) && (x >= x1 && x <= x2)))
                {
                    Console.WriteLine("Border");
                }            
            else 
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
