using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string TipProjekcia = Console.ReadLine();
            var BroiRed = double.Parse(Console.ReadLine());
            var BroiColoni = double.Parse(Console.ReadLine());            
            switch (TipProjekcia)
            {
                case "Premiere":
                    Console.WriteLine("{0:f2}", (BroiRed * BroiColoni * 12));
                    break;
                case "Normal":
                    Console.WriteLine("{0:f2}", (BroiRed * BroiColoni * 7.5));
                    break;
                case "Discount":
                    Console.WriteLine("{0:f2}", (BroiRed * BroiColoni * 5));
                    break;
                default:
                    break;                    
            }
        }
    }
}
