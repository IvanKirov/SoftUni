using System;
using System.Globalization;

namespace _01.Softuni_Coffee_Orders
{
    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            var numberOfOrders = int.Parse(Console.ReadLine());

            decimal totalPrice = 0M;

            for (int i = 0; i < numberOfOrders; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCaunt = long.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var coffeePrice = (daysInMonth * capsulesCaunt) * pricePerCapsule;
                totalPrice += coffeePrice;
                Console.WriteLine($"The price for the coffee is: ${coffeePrice:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
