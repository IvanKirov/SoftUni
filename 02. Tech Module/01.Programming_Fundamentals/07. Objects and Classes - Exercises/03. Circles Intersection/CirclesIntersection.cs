using System;
using System.Linq;

namespace _03.Circles_Intersection
{
    public class CirclesIntersection
    {
        public static void Intersect(Circle c1, Circle c2)
        {
            var diffX = c1.X - c2.X;
            var diffY = c1.Y - c2.Y;

            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);
            
            var distanceCenters = Math.Sqrt(powX + powY);

            if ((c1.Radius + c2.Radius) >= distanceCenters)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        
        public static void Main()
        {
            var firstCircleData = Console.ReadLine()
                   .Split(' ')
                   .Select(double.Parse)
                   .ToArray();

            var firstCircle = new Circle
            {
                X = firstCircleData[0],
                Y = firstCircleData[1],
                Radius = firstCircleData[2]
            };

            var secondCircleData = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var secondCircle = new Circle
            {
                X = secondCircleData[0],
                Y = secondCircleData[1],
                Radius = secondCircleData[2]
            };

            Intersect(firstCircle, secondCircle);
        }
    }
}
