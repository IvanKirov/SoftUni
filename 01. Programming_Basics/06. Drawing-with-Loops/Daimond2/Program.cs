using System;

namespace Daimond2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star = 1;
            star = (n % 2 == 0) ? 2 : star; // proverka za chetno nechetno bez if
            var blanks = (n - star) / 2 - 1;
            int mid = star;
            for (int red = 1; red <= (n - star / 2); red++)  // (n-star/2) vadi 1 ot chetnite
            {
                if (red == 1 || red == (n - star / 2))
                {    //parvi i posleden red
                    Console.Write(new string('-', (n - star) / 2));
                    Console.Write(new string('*', star));
                    Console.WriteLine(new string('-', (n - star) / 2));
                }
                else if (red > 1 && red <= (n - star / 2) / 2 + 1)
                {   //srednite redove do sredata
                    Console.Write(new string('-', blanks));
                    Console.Write("*");
                    Console.Write(new string('-', (n - 2 - 2 * blanks)));
                    Console.Write("*");
                    Console.WriteLine(new string('-', blanks));
                    blanks--;
                    blanks = (blanks < 0) ? 0 : blanks;
                }
                else
                {   // srednite redove sled sredata                    
                    blanks++;
                    Console.Write(new string('-', blanks));
                    Console.Write("*");
                    Console.Write(new string('-', (n - 2 - 2 * blanks)));
                    Console.Write("*");
                    Console.WriteLine(new string('-', blanks));
                }
            }
        }
    }
}
