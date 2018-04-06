using System;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ', n));
            Console.WriteLine(" |");
            int blanks = n - 1;
            int stars = 1;
            for (int i = 1; i <=n; i++)
            {
                Console.Write(new string(' ', blanks));
                Console.Write(new string('*', stars));
                Console.Write(" | ");
                Console.WriteLine(new string('*', stars));
                blanks--;
                stars++;
            }
        }
    }
}
