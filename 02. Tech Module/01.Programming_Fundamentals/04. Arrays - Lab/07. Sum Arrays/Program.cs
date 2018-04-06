using System;
using System.Linq;

namespace _07.Sum_Arrays
{
    public class SumArrays
    {
        public static void Main()
        {
            long[] firstArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[] secondArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            var lenghtArray = Math.Max(firstArray.Length, secondArray.Length);
            long[] sumArray = new long[lenghtArray];

            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstArray[i % firstArray.Length] + secondArray[i % secondArray.Length];
                Console.Write(sumArray[i] + " ");
            }
        }
    }
}
