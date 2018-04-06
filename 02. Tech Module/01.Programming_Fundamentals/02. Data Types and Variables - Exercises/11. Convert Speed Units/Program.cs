using System;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distanceMeters = float.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());

            float kilometersPerHour = (distanceMeters / 1000.0f) / (hours + minutes / 60.0f + seconds / 3600.0f);
            float metersPerSecond = kilometersPerHour / 3.6f;
            float milesPerHour = metersPerSecond * 3600 / 1609f;

            Console.WriteLine(metersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
        }
    }
}
