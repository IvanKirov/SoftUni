using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AndreyAndBilliard
{
    public class AndreyAndBilliard
    {
        public static void Main()
        {
            var numbers = int.Parse(Console.ReadLine());

            var priceList = new Dictionary<string, decimal>();

            for (int i = 0; i < numbers; i++)
            {
                var productAndPrices = Console.ReadLine()
                    .Split('-')
                    .ToArray();

                var productName = productAndPrices[0];
                var productPrice = decimal.Parse(productAndPrices[1]);                
                priceList[productName] = productPrice;
            }

            string inputString = string.Empty;

            var clientsList = new List<Customer>();

            while ((inputString = Console.ReadLine()) != "end of clients")
            {
                var inputText = inputString
                    .Split('-', ',')
                    .ToArray();
                
                var client = inputText[0];                
                var product = inputText[1];
                var quantity = int.Parse(inputText[2]);

                if (priceList.ContainsKey(product))
                {
                    if (!clientsList.Any(c => c.Name == client))
                    {
                        var newCustomer = new Customer();
                        newCustomer.Name = client;

                        newCustomer.OrderList = new Dictionary<string, int>();
                        newCustomer.OrderList.Add(product, quantity);

                        newCustomer.Bill += priceList[product] * quantity;
                        clientsList.Add(newCustomer);
                    }
                    else
                    {
                        var clientIndex = clientsList.FindIndex(c => c.Name == client);
                        clientsList[clientIndex].OrderList[product] += quantity;
                        clientsList[clientIndex].Bill += priceList[product] * quantity;
                    }
                }                
            }

            var totalBill = 0m;

            foreach (var student in clientsList.OrderBy(n => n.Name))
            {
                Console.WriteLine(student.Name);

                foreach (KeyValuePair<string, int> item in student.OrderList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                Console.WriteLine($"Bill: {student.Bill:F2}");
                totalBill += student.Bill;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}
