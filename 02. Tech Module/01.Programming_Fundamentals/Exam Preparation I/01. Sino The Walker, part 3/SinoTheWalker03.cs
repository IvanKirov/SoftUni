using System;
using System.Globalization;

namespace _01.Sino_The_Walker__part_3
{
    public class SinoTheWalker03
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

            long initialSeconds = startingTime.Hour * 60 * 60
                + startingTime.Minute * 60 + startingTime.Second;

            ulong secondsToAdd = (ulong)numberOfSteps * (ulong)secondsPerStep;

            var secondsToAddPerDay = secondsToAdd % (24 * 60 * 60);

            var finalDate = startingTime.AddSeconds(secondsToAddPerDay);

            Console.WriteLine($"Time Arrival: {finalDate.ToString(timeFormat)}");
        }
    }
}
