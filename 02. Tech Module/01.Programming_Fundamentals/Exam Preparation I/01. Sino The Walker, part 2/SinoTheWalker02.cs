using System;
using System.Globalization;

namespace _01.Sino_The_Walker__part_2
{
    public class SinoTheWalker02
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

            long initialSeconds = startingTime.Hour * 60 * 60 * 24
                + startingTime.Minute * 60 + startingTime.Second;

            ulong secondsToAdd = (ulong)numberOfSteps * (ulong)secondsPerStep;

            ulong totelSeconds = (ulong)initialSeconds + secondsToAdd;

            var seconds = totelSeconds % 60;
            var totalMinutes = totelSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHours = totalMinutes / 60;
            var hours = totalMinutes % 24;
            
            Console.WriteLine($"Time Arrival: {hours:00}:{minutes:00}:{seconds:00}");
        }
    }
}
