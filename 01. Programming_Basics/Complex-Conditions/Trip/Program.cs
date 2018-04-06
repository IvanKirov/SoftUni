using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            string sezon = Console.ReadLine();
            sezon = sezon.ToLower();
            string destination, place;
            decimal spentM = 0m;
            if (money <= 100)
            {
                destination = "Bulgaria";
                if (sezon == "summer")
                {
                    spentM = money * 0.3m;
                    place = "Camp";
                }
                else
                { 
                    spentM = money * 0.7m;
                    place = "Hotel";
                }
            }
            else if (money > 100 && money <= 1000)
            {
                destination = "Balkans";
                if (sezon == "summer")
                {
                    spentM = money * 0.4m;
                    place = "Camp";
                }
                else
                { 
                    spentM = money * 0.8m;
                    place = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                spentM = money * 0.9m;
                place = "Hotel";
            }
            Console.WriteLine("Somewhere in " + destination);
            Console.WriteLine("{0} - {1:f2}", place, spentM);
        }
    }
}
