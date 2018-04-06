using System;
using System.Globalization;

namespace _01.Sino_The_Walker
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            var timeFormat = "HH:mm:ss";
            var startingTime = DateTime.ParseExact(
                Console.ReadLine(),
                timeFormat,
                CultureInfo.InvariantCulture);      // da e veren datetime na vseki comp

            var numberOfSteps = int.Parse(Console.ReadLine());

            var secondsPerStep = int.Parse(Console.ReadLine());

            // var secondsToAdd = numberOfSteps * secondsPerStep;

            for (int i = 0; i < numberOfSteps; i++)
            {
                startingTime = startingTime.AddSeconds(secondsPerStep);
            }
            var result = startingTime.ToString(timeFormat);

            Console.WriteLine($"Time Arrival: {result}");
        }
    }
}
