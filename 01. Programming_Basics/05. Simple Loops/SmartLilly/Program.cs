using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageLili = int.Parse(Console.ReadLine());
            var priceWashM = double.Parse(Console.ReadLine());
            var priceToy = int.Parse(Console.ReadLine());
            int sumToys = 0;
            var broi = ageLili / 2;
            var sumMoney = (18 + (broi-1)*10) / 2 * broi;
            if (ageLili % 2 == 0)
            {
                sumToys = priceToy * broi;
            }
            else
            {
                sumToys = priceToy * (broi + 1);
            }
            double totalSum = sumMoney + sumToys;
            if (totalSum >= priceWashM)
            {
                Console.WriteLine("Yes! {0:f2}", totalSum - priceWashM);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceWashM - totalSum);
            }            
        }
    }
}
