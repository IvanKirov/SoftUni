using System;
using System.Numerics;

namespace _13.Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;

            while (number > 1)
            {
                factoriel *= number;
                number--;
            }

            Console.WriteLine(factoriel);
        }
    }
}
