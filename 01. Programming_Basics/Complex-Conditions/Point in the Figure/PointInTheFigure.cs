using System;

namespace Point_in_the_Figure
{
    public class PointInTheFigure
    {
        public static void Main()
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var inBottom = ((x <= 3 * h && y <= h)) && (x >=0 && y >= 0);
            var inTop = ((x >= h && x <= 2 * h) && (y >= h && y <= 4 * h));
            var onLeftSide = ((x == 0) && (y >= 0 && y <= h)) || ((x == h) && (y >= h && y <= 4* h));
            var onRightSie = ((x == 3 * h) && (y >= 0 && y <= h)) || ((x == 2 * h) && (y >= h && y <= 4 * h));
            var onTopSide = ((y == h) && (x >= 0 && x <= h)) || ((y == 4 * h) && (x >= h && x <= 2 * h)) || 
                ((y == h) && (x >= 2* h && x <= 3 * h));
            var onBottomSide = ((y == 0) && (x >= 0 && x <= h * 3));

            if (onLeftSide || onRightSie || onTopSide || onBottomSide)
            {
                Console.WriteLine("Border");
            }
            else if (inBottom || inTop)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Outside");
            }
        }
    }
}
