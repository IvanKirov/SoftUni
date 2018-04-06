using System;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            
            var longestSequence = 0;
            var compareNumber = numbers[0];
            var lastNumber = numbers[0];
            var currentSequence = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber == lastNumber)
                {
                    currentSequence++;
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        compareNumber = currentNumber;
                    }
                }
                else
                {
                    if (currentSequence > longestSequence)
                    {
                        longestSequence = currentSequence;
                        compareNumber = currentNumber;
                    }
                    currentSequence = 0;
                    lastNumber = currentNumber;
                }                
            }
            
            for (int i = 0; i <= longestSequence; i++)
            {                
                Console.Write($"{compareNumber} ");
            }
        }
    }
}
