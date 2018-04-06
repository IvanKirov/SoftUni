using System;
using System.Linq;

namespace _01.Largest_Common_End
{
    public class LargestCommonEnd
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            var counterLeftToRight = 0;
            var counterRightToLeft = 0;
            var firsLenght = firstArray.Length;
            var secondLenght = secondArray.Length;
            var minLenght = Math.Min(firsLenght, secondLenght);
            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counterLeftToRight++;
                }

                if (firstArray[firsLenght - i - 1] == secondArray[secondLenght - i - 1])
                {
                    counterRightToLeft++;
                }
            }

            var answer = Math.Max(counterLeftToRight, counterRightToLeft);
            Console.WriteLine(answer);
        }
    }
}
