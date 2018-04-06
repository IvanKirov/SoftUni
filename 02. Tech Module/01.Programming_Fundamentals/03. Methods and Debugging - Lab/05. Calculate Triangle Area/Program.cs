using System;

namespace _05.Calculate_Triangle_Area
{
    public class Program
    {
        public static double GetTriangleArea(double width, double height)
        {
            return width * height / 2;
        }

        public static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var answer = GetTriangleArea(width, height);
            Console.WriteLine(answer);
        }
    }
}
