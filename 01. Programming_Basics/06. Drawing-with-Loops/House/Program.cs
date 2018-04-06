using System;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int star = 1;           
            if (n % 2 == 0)
            {
                star = 2;
            }
            int roof = (n-star) / 2;
            if (n == 2)
            {
                roof = 0;
            }
            for (int pokriv = 0; pokriv < (n+1)/2; pokriv++)
                {
                Console.Write(new string('-',roof) + new string('*', star) + new string('-', roof));                
                Console.WriteLine();
                star = star + 2;
                roof--;
            }            
            for (int walls = 0; walls < (n/2); walls++)
                {
                    Console.WriteLine("|" + new string('*', n - 2) + "|");
                }
        }
    }
}
