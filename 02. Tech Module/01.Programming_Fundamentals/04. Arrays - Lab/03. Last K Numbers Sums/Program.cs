using System;

namespace _03.Last_K_Numbers_Sums
{
    public class LastKNumbersSums
    {
        public static void Main()
        {
            var nElements = long.Parse(Console.ReadLine());
            var kElements = long.Parse(Console.ReadLine());

            long[] arrayOfElements = new long[nElements];
            arrayOfElements[0] = 1;

            for (int i = 1; i < nElements; i++)
            {
                long sumKElements = 0;
                for (int k = i - 1; k >= 0 && k >= i - kElements; k--)
                {
                    sumKElements = sumKElements + arrayOfElements[k];
                }
                arrayOfElements[i] = sumKElements;
            }

            Console.WriteLine(string.Join(" ", arrayOfElements));
        }
    }
}
