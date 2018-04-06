using System;

namespace _12.Rectangle_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangleWidth = double.Parse(Console.ReadLine());
            var rectangleHeight = double.Parse(Console.ReadLine());
            Console.WriteLine(rectangleHeight * 2 + rectangleWidth * 2);
            Console.WriteLine(rectangleWidth * rectangleHeight);
            Console.WriteLine(Math.Sqrt(rectangleWidth * rectangleWidth + rectangleHeight * rectangleHeight));
        }
    }
}
