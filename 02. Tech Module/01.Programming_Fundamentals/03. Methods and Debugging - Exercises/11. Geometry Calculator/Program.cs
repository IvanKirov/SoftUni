using System;

namespace _11.Geometry_Calculator
{
    public class GeometryCalculator
    {
        public static void Main()
        {
            string figureType = Console.ReadLine().ToLower();

            double answer = 0;
            switch (figureType)
            {
                case "triangle":
                    answer = Trianglearea();
                    break;
                case "square":
                    answer = SquareArea();
                    break;
                case "rectangle":
                    answer = RectangleArea();
                    break;
                case "circle":
                    answer = CircleArea();
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0:F2}", answer);
        }

        private static double CircleArea()
        {
            var radius = double.Parse(Console.ReadLine());
            var answer = Math.PI * Math.Pow(radius, 2);
            return answer; 
        }

        private static double RectangleArea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var answer = side * height;
            return answer; 
        }

        private static double SquareArea()
        {
            var side = double.Parse(Console.ReadLine());            
            var answer = Math.Pow(side , 2);
            return answer;
        }

        private static double Trianglearea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var answer = (side * height) / 2;
            return answer;
        }
    }
}
