using System;

namespace _03.Final_Competition
{
    public class FinalCompetition
    {
        public static void Main()
        {
            var numberOfDancers = byte.Parse(Console.ReadLine());
            var numberOfPoints = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var place = Console.ReadLine();

            decimal price = numberOfDancers * (decimal)numberOfPoints;
            if (place == "Abroad")
            {
                price *= 1.5m;  //50% add
            }

            // Expenses deduction
            if (season == "summer")
            {
                if (place == "Abroad")
                {
                    price *= 0.9m;  //10% deduction
                }
                else
                {
                    price *= 0.95m;  //5% deduction
                }
            }
            else
            {
                if (place == "Abroad")
                {
                    price *= 0.85m;  //15% deduction
                }
                else
                {
                    price *= 0.92m;  //8% deduction
                }
            }

            var charity = price * 0.75m;
            Console.WriteLine($"Charity - {charity:F2}"); 

            var moneyPerDancer = (price - charity) / numberOfDancers;
            Console.WriteLine($"Money per dancer - {moneyPerDancer:F2}");
        }
    }
}
