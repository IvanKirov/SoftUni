using System;

namespace _09.Longer_Line
{
    public class Program
    {   
        public static double DistanceBetweenPoints(double deltaX, double deltaY)
        {
            double LenghtOfLine = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));
            return LenghtOfLine;
        }

        public static void Main()
        {
            double lineOneFirstX = double.Parse(Console.ReadLine());
            double lineOneFirstY = double.Parse(Console.ReadLine());
            double lineOneSecondX = double.Parse(Console.ReadLine());
            double lineOneSecondY = double.Parse(Console.ReadLine());

            var deltaX = (lineOneFirstX - lineOneSecondX);
            var deltaY = (lineOneFirstY - lineOneSecondY);
            var lengtOfLineOne = DistanceBetweenPoints(deltaX, deltaY);

            double lineTwoFirstX = double.Parse(Console.ReadLine());
            double lineTwoFirstY = double.Parse(Console.ReadLine());
            double lineTwoSecondX = double.Parse(Console.ReadLine());
            double lineTwoSecondY = double.Parse(Console.ReadLine());

            deltaX = (lineTwoFirstX - lineTwoSecondX);
            deltaY = (lineTwoFirstY - lineTwoSecondY);
            var lengtOfLinetTwo = DistanceBetweenPoints(deltaX, deltaY);

            if (lengtOfLineOne >= lengtOfLinetTwo)
            {
                var leftPoint = DistanceBetweenPoints(lineOneFirstX, lineOneFirstY);
                var rightPoint = DistanceBetweenPoints(lineOneSecondX, lineOneSecondY);
                if (leftPoint < rightPoint)
                {
                    Console.WriteLine($"({lineOneFirstX}, {lineOneFirstY})({lineOneSecondX}, {lineOneSecondY})");
                }
                else
                {
                    Console.WriteLine($"({lineOneSecondX}, {lineOneSecondY})({lineOneFirstX}, {lineOneFirstY})");
                }
                
            }
            else
            {
                var leftPoint = DistanceBetweenPoints(lineTwoFirstX, lineTwoFirstY);
                var rightPoint = DistanceBetweenPoints(lineTwoSecondX, lineTwoSecondY);
                if (leftPoint < rightPoint)
                {
                    Console.WriteLine($"({lineTwoFirstX}, {lineTwoFirstY})({lineTwoSecondX}, {lineTwoSecondY})");
                }
                else
                {
                    Console.WriteLine($"({lineTwoSecondX}, {lineTwoSecondY})({lineTwoFirstX}, {lineTwoFirstY})");
                }
        }
    }
}
