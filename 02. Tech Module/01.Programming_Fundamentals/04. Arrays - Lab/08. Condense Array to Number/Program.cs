using System;
using System.Linq;

namespace _08.Condense_Array_to_Number
{
    public class CondenseArrayToNumber
    {
        public static void Main()
        {
            int[] numbersArray = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            
            var counter = numbersArray.Length;

            while (counter > 1)
            {
                for (int i = 0; i < counter - 1; i++)
                {
                    numbersArray[i] = numbersArray[i] + numbersArray[i + 1];
                }
                counter--;
            }
            Console.WriteLine(numbersArray[0]);
        }
    }
}
