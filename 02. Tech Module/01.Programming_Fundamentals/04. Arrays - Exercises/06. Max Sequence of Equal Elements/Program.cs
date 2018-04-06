using System;
using System.Linq;

namespace _06.Max_Sequence_of_Equal_Elements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var counterEqualElements = 0;
            var longetsCounter = 0;
            var compareElement = array[0];
            var elementLongestSequece = compareElement;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == compareElement)
                {
                    counterEqualElements++;
                    if (longetsCounter < counterEqualElements)
                    {
                        longetsCounter = counterEqualElements;
                        elementLongestSequece = compareElement; 
                    }
                }
                else
                {
                    if (longetsCounter < counterEqualElements)
                    {
                        longetsCounter = counterEqualElements;
                        elementLongestSequece = compareElement;
                    }
                    counterEqualElements = 0;
                    compareElement = array[i];
                }
            }

            for (int i = 0; i <= longetsCounter; i++)
            {
                Console.Write(elementLongestSequece + " ");
            }
            Console.WriteLine();

        }
    }
}
