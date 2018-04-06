using System;

namespace _01.Sweet_Dessert
{
    public class SweetDessert
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var numberGuests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriePrice = decimal.Parse(Console.ReadLine());

            var numberOfDesserts = Math.Ceiling(numberGuests / 6m);
            var priceOfSweetDessert = 2 * bananaPrice + 4 * eggPrice + 0.2m * berriePrice;
            var sum = numberOfDesserts * priceOfSweetDessert;

            if (sum <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {sum:F2}lv.");
            }
            else
            {
                var difference = sum - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {difference:F2}lv more.");
            }
            
        }
    }
}
