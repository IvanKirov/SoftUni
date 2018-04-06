using System;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var isPrime = true;

            if (n < 2)
            {
                isPrime = false;
            }

            for (int delitel = 2; delitel <= Math.Sqrt(n); delitel++)  //proverka do korenkvadraten ot n
            {
                if (n % delitel == 0) ;
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime == true)
            { Console.WriteLine("Prime"); }
            else
            { Console.WriteLine("Not Prime"); }
        }
    }
}
