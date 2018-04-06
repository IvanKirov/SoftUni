using System;
using System.Linq;

namespace _10.Pairs_by_Difference
{
    public class PairsByDifference
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var difference = int.Parse(Console.ReadLine());
            var counterOfPairs = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] + difference)
                    {
                        counterOfPairs++;
                    }
                }
            }

            Console.WriteLine(counterOfPairs);
        }
    }
}
