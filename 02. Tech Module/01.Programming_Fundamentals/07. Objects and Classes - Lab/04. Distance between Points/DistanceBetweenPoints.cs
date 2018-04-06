using System;
using System.Linq;

namespace _04.Distance_between_Points
{
    public class DistanceBetweenPoints
    {
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }

        public static void Main()
        {
            var firstPointCoordinates = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var firstPoint = new Point
            {
                X = firstPointCoordinates[0],
                Y = firstPointCoordinates[1]
            };

            var secondPointCoordinates = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var secondPoint = new Point
            {
                X = secondPointCoordinates[0],
                Y = secondPointCoordinates[1]
            };

            var result = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine($"{result:F3}");
        }
    }
}
