using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Longest_Increasing_Subsequence
{
    public class LongestIncreasingSubsequence
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var longestSeq = FindLongestIncreasingSubsequence(numbers);
            
            Console.WriteLine(string.Join(" ", longestSeq));


        }

        public static int[] FindLongestIncreasingSubsequence(int[] numbers)
        {
            int[] sequencesLenght = new int[numbers.Length];
            int[] previuosIndex = new int[numbers.Length];
            int maxLenght = 0;
            int lastIndex = -1;

            for (int inputIndex = 0; inputIndex < numbers.Length; inputIndex++)
            {
                sequencesLenght[inputIndex] = 1;
                previuosIndex[inputIndex] = -1;

                for (int i = 0; i < inputIndex; i++)
                {
                    if (numbers[i] < numbers[inputIndex] && sequencesLenght[i] + 1 > sequencesLenght[inputIndex])
                    {
                        sequencesLenght[inputIndex] = 1 + sequencesLenght[i];
                        previuosIndex[inputIndex] = i;
                    }
                }

                if (sequencesLenght[inputIndex] > maxLenght)
                {
                    maxLenght = sequencesLenght[inputIndex];
                    lastIndex = inputIndex;
                }

                Console.WriteLine(string.Join(" ", sequencesLenght));
                //Console.WriteLine(string.Join(" ", previuosIndex));
            }

            var longestSequence = new List<int>();
            while (lastIndex != -1)
            {
                longestSequence.Add(numbers[lastIndex]);
                lastIndex = previuosIndex[lastIndex];
            }

            longestSequence.Reverse();

            return longestSequence.ToArray();
        }
    }
}
