using System;

namespace _08.Center_Point
{
    public class DistanceFromCenterPoint
    {
        public static double DistanceToCenterPoint(double pointX, double pointY)
        {
            double distanceToCenterPoint = Math.Sqrt((pointX * pointX) + (pointY * pointY));
            return distanceToCenterPoint;
        }

        public static void Main()
        {
            double pointOneX = double.Parse(Console.ReadLine());
            double pointOneY = double.Parse(Console.ReadLine());
            double pointTwoX = double.Parse(Console.ReadLine());
            double pointTwoY = double.Parse(Console.ReadLine());

            var distanceForPointOne = DistanceToCenterPoint(pointOneX, pointOneY);
            var distanceForPointTwo = DistanceToCenterPoint(pointTwoX, pointTwoY);

            if (distanceForPointOne <= distanceForPointTwo)
            {
                Console.WriteLine($"({pointOneX}, {pointOneY})");
            }
            else
            {
                Console.WriteLine($"({pointTwoX}, {pointTwoY})");
            }
        }        
    }
}
