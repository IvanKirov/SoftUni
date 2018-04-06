using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {            
            var plod = Console.ReadLine().ToLower();
            var WeekDay = Console.ReadLine().ToLower();
            var Quantity = decimal.Parse(Console.ReadLine());

            if (Quantity < 0) { Console.WriteLine("error"); }   // proverka za otricateleno klichestvo
            if (!(WeekDay == "monday" || WeekDay == "tuesday" || WeekDay == "wednesday" || WeekDay == "thursday" || WeekDay == "friday" || WeekDay == "saturday" || WeekDay == "sunday")) { Console.WriteLine("error"); }

            switch (plod)
            {
                case "banana":
                    if (WeekDay == "monday" || WeekDay == "tuesday" || WeekDay == "wednesday" || WeekDay == "thursday" || WeekDay == "friday")
                    {
                        Console.WriteLine(Math.Round(Quantity * 2.50m, 2));
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(Quantity * 2.70m, 2));
                    }
                    break;
                case "apple":
                    if (WeekDay == "monday" || WeekDay == "tuesday" || WeekDay == "wednesday" || WeekDay == "thursday" || WeekDay == "friday")
                    {
                        Console.WriteLine(Math.Round(Quantity * 1.20m, 2));
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(Quantity * 1.25m, 2));
                    }
                    break;
                case "orange":
                    if (WeekDay == "monday" || WeekDay == "tuesday" || WeekDay == "wednesday" || WeekDay == "thursday" || WeekDay == "friday")
                    {
                        Console.WriteLine(Math.Round(Quantity * 0.85m, 2));
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(Quantity * 0.90m, 2));
                    }
                    break;
                case "grapefruit":
                    if (WeekDay == "monday" || WeekDay == "tuesday" || WeekDay == "wednesday" || WeekDay == "thursday" || WeekDay == "friday")
                    {
                        Console.WriteLine(Math.Round(Quantity * 1.45m, 2));
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(Quantity * 1.60m, 2));
                    }
                    break;
                case "kiwi":
                    if (WeekDay == "monday" || WeekDay == "tuesday" || WeekDay == "wednesday" || WeekDay == "thursday" || WeekDay == "friday")
                    {
                        Console.WriteLine(Math.Round(Quantity * 2.70m, 2));
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(Quantity * 3.00m, 2));
                    }
                    break;
                case "pineapple":
                    if (WeekDay == "monday" || WeekDay == "tuesday" || WeekDay == "wednesday" || WeekDay == "thursday" || WeekDay == "friday")
                    {
                        Console.WriteLine(Math.Round(Quantity * 5.50m, 2));
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(Quantity * 5.60m, 2));
                    }
                    break;
                case "grapes":
                    if (WeekDay == "monday" || WeekDay == "tuesday" || WeekDay == "wednesday" || WeekDay == "thursday" || WeekDay == "friday")
                    {
                        Console.WriteLine(Math.Round(Quantity * 3.85m, 2));
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(Quantity * 4.20m, 2));
                    }
                    break;
                default:
                    Console.WriteLine("error");     //greshka za nyama takav plod
                    break;
            }
        }
    }
}
