using System;

namespace _02.Reverse_Array_of_Integers
{
    public class ReverseIntegerArray
    {
        public static void Main()
        {
            int numberElements = int.Parse(Console.ReadLine());
            int[] elements = new int [numberElements];

            for (int i = 0; i < elements.Length; i++)
            {
                var currentElements = int.Parse(Console.ReadLine());
                elements[elements.Length - i - 1] = currentElements;
            }

            for (int i = 0; i < elements.Length; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
