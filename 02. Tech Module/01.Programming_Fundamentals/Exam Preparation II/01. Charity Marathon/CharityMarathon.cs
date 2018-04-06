using System;

namespace _01.Charity_Marathon
{
    public class CharityMarathon
    {
        public static void Main()
        {
            var marathonDays = decimal.Parse(Console.ReadLine());
            var numberOfRuners = decimal.Parse(Console.ReadLine());
            var numberOfLaps = decimal.Parse(Console.ReadLine());
            var trackLength = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            var maxRuners = Math.Min((trackCapacity * marathonDays), numberOfRuners);
            var trackLengthKm = trackLength / 1000;
            decimal totalKm = maxRuners * numberOfLaps * trackLengthKm;

            decimal answer = totalKm * moneyPerKm;
            
            Console.WriteLine($"Money raised: {answer:F2}");
        }
    }
}
