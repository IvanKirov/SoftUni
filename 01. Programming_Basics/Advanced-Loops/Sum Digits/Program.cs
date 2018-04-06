using System;

namespace Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;

            do
            {
                sum = sum + (n % 10);   // (n%10) vrashta poslednata cifra na chisloto n
                n = n /10;              //triem poslednoto chilo
            } while (n>0);
            Console.WriteLine(sum);
        }
    }
}
