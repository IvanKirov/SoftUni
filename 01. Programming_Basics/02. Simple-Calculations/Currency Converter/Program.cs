using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = double.Parse(Console.ReadLine());
            var cur1 = Console.ReadLine();
            var cur2 = Console.ReadLine();
            var bgn = 1;
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;
            switch (cur1)
            {
                case "BGN":
                    break;
                case "USD":
                    sum = sum * usd;
                    break;
                case "EUR":
                    sum = sum * eur;
                    break;
                case "GBP":
                    sum = sum * gbp;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select BGN, USD, EUR or GBP");
                    break;
            }
            switch (cur2)
            {
                case "BGN":
                    sum = sum / bgn;
                    break;
                case "USD":
                    sum = sum / usd;
                    break;
                case "EUR":
                    sum = sum / eur;
                    break;
                case "GBP":
                    sum = sum / gbp;
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please select BGN, USD, EUR or GBP");
                    break;
            }
            Console.WriteLine(Math.Round(sum, 2) + " " + cur2);
        }
    }
}
