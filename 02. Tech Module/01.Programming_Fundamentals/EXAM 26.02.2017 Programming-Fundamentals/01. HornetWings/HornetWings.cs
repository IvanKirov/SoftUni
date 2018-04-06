using System;

namespace Hornet_Wings
{
    public class HornetWings
    {
        public static void Main()
        {
            var numberWingFlaps = int.Parse(Console.ReadLine());
            var distance = decimal.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            var maxDistance = (numberWingFlaps / 1000m) * distance;
            var flpasTime = numberWingFlaps / 100m;
            var restsTime = (numberWingFlaps / endurance) * 5;
            var totalTime = restsTime + flpasTime;

            Console.WriteLine($"{maxDistance:F2} m.");
            Console.WriteLine($"{totalTime:F0} s.");
        }
    }
}
