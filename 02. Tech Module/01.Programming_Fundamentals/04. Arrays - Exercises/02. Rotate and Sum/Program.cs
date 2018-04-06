using System;
using System.Linq;

namespace _02.Rotate_and_Sum
{
    public class RotateAndSum
    {
        public static int [] rotatedArrayRight(int[] array)
        {
            var lastNuimber = array[array.Length - 1];
            for (int i = array.Length - 1; i >0 ; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = lastNuimber;

            return array;
        }
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rotateKtimes = int.Parse(Console.ReadLine());
            int[] sumArray = new int[array.Length];

            for (int i = 0; i < rotateKtimes; i++)
            {
                array = rotatedArrayRight(array);
                for (int k = 0; k < array.Length; k++)
                {
                    sumArray[k] += array[k];
                }
            }

            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.Write($"{sumArray[i]} ");
            }
        }
    }
}
