using System;
using System.Linq;

namespace _03.Fold_and_Sum
{
    public class FoldAndSum
    {
        public static int[] partOfArray(int[] array, int start)
        {
            var partOfArray = new int[array.Length / 4];
            for (int i = 0; i < partOfArray.Length; i++)
            {
                partOfArray[i] = array[i + start];
            }
            return partOfArray;
        }

        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var lenght = array.Length;
            var k = lenght / 4;

            var leftPartArray = new int[k];
            leftPartArray = partOfArray(array, 0);
            Array.Reverse(leftPartArray);

            var rightPartArray = new int[k];
            rightPartArray = partOfArray(array, k * 3);
            Array.Reverse(rightPartArray);

            var firstRow = new int[2 * k];
            for (int i = 0; i < k; i++)
            {
                firstRow[i] = leftPartArray[i];
                firstRow[k + i] = rightPartArray[i];
            }

            var secondRow = new int[2 * k];
            for (int i = 0; i < 2 * k; i++)
            {
                secondRow[i] = array[i + k];
            }

            for (int i = 0; i < 2 * k; i++)
            {
                Console.Write($"{firstRow[i] + secondRow[i]} ");
            }
        }
    }
}
