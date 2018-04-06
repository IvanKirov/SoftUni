using System;
using System.Linq;

namespace _06.Reverse_Array_of_Strings
{
    public class ReverseArrayOfStrings
    {
        public static void Main()
        {
            string[] numberArray = Console.ReadLine().Split(' ').Reverse().ToArray();

            for (int i = 0; i < numberArray.Length; i++)
            {
                Console.Write(numberArray[i] + " ");
            }
        }
    }
}
