using System;
using System.Collections.Generic;

namespace _07.Sales_Report_part_2
{
    public class SalesReport
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var currentSaleParts = Console.ReadLine()
                    .Split(' ');
                var town = currentSaleParts[0];
                var price = decimal.Parse(currentSaleParts[2]);
                var quantity = decimal.Parse(currentSaleParts[3]);

                if (!result.ContainsKey(town))
                {
                    result[town] = 0;
                }

                result[town] += price * quantity;
            }

            
            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value:F2}");
            }
        }
    }
}