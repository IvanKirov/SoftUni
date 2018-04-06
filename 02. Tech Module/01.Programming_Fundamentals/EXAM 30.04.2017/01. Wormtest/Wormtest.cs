using System;

namespace _01.Wormtest
{
    class Wormtest
    {
        static void Main()
        {
            var wormLength = int.Parse(Console.ReadLine()) * 100;
            var wormWidth = decimal.Parse(Console.ReadLine());           

            if (wormWidth != 0)
            {
                var division = wormLength / wormWidth;
                var answer = 0M;

                if (division % 10 != 0)
                {
                    answer = division * 100;
                    Console.WriteLine($"{answer:f2}%");
                }
                else
                {
                    answer = wormWidth * wormLength;
                    Console.WriteLine($"{answer:f2}");
                }
            }
            else
            {
                Console.WriteLine("0.00");
            }          
        }
    }
}
