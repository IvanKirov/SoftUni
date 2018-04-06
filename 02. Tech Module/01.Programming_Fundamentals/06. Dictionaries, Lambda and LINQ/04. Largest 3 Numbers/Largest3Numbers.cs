using System;
using System.Linq;

namespace _04.Largest_3_Numbers
{
    public class Largest3Numbers
    {
        public static void Main()
        {
            var inputList = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            
            inputList
                .OrderByDescending(x => x)
                .Take(3)
                .ToList()
                .ForEach(Console.WriteLine);

            // ako iskah da e na 1 red
            Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .OrderByDescending(x => x)
                .Take(3)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
