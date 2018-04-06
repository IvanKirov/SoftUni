using System;
using System.Linq;

namespace _07.Max_Sequence_of_Increasing_Elements
{
    public class MaxSequenceOfIncreasingElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var counterIncreasingElements = 0;
            var longetsCounter = 0;
            var startMaxSequence = 0;
            var startCurrentSequence = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    counterIncreasingElements++;
                    startCurrentSequence = i - counterIncreasingElements;
                    if (longetsCounter < counterIncreasingElements)
                    {
                        longetsCounter = counterIncreasingElements;
                        startMaxSequence = startCurrentSequence;
                    }
                }
                else
                {
                    counterIncreasingElements = 0;
                }
            }

            for (int i = startMaxSequence; i <= (startMaxSequence + longetsCounter); i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
