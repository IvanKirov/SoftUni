using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var Oborot = decimal.Parse(Console.ReadLine());
            if (Oborot < 0 ) { Console.WriteLine("error"); } // proverka za otricatelen oborot
            switch (town)
            {
                case "Sofia":                    
                    if (Oborot > 10000) { Console.WriteLine(Math.Round((Oborot * 0.12m), 2)); }
                    else if (Oborot > 1000 && Oborot <= 10000) { Console.WriteLine(Math.Round((Oborot * 0.08m), 2)); }
                    else if (Oborot > 500 && Oborot <= 1000) { Console.WriteLine(Math.Round((Oborot * 0.07m), 2)); }
                    else if (Oborot >= 0 && Oborot <= 500) { Console.WriteLine(Math.Round((Oborot * 0.05m), 2)); }
                    break;
                case "Varna":
                    if (Oborot > 10000) { Console.WriteLine(Math.Round((Oborot * 0.13m), 2)); }
                    else if (Oborot > 1000 && Oborot <= 10000) { Console.WriteLine(Math.Round((Oborot * 0.10m), 2)); }
                    else if (Oborot > 500 && Oborot <= 1000) { Console.WriteLine(Math.Round((Oborot * 0.075m), 2)); }
                    else if (Oborot >= 0 && Oborot <= 500) { Console.WriteLine(Math.Round((Oborot * 0.045m), 2)); }
                    break;
                case "Plovdiv":
                    if (Oborot > 10000) { Console.WriteLine(Math.Round((Oborot * 0.145m), 2)); }
                    else if (Oborot > 1000 && Oborot <= 10000) { Console.WriteLine(Math.Round((Oborot * 0.12m), 2)); }
                    else if (Oborot > 500 && Oborot <= 1000) { Console.WriteLine(Math.Round((Oborot * 0.08m), 2)); }
                    else if (Oborot >= 0 && Oborot <= 500) { Console.WriteLine(Math.Round((Oborot * 0.055m), 2)); }
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }
        }
    }
}
