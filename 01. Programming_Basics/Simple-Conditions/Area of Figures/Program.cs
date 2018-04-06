using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figura = Console.ReadLine();
            double figuralice, strana1, strana2;
            switch (figura)
            {
                case "square":
                    figuralice = double.Parse(Console.ReadLine());                   
                    Console.WriteLine(Math.Round(figuralice * figuralice, 3));
                    break;
                case "rectangle":
                    strana1 = double.Parse(Console.ReadLine());
                    strana2 = double.Parse(Console.ReadLine());                    
                    Console.WriteLine(Math.Round(strana1 * strana2, 3));
                    break;
                case "circle":
                    figuralice = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(figuralice * figuralice * Math.PI, 3));
                    break;
                case "triangle":
                    strana1 = double.Parse(Console.ReadLine());
                    strana2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Round(strana1 * strana2 / 2, 3));
                    break;
                default:
                    break;
            }            
        }
    }
}
