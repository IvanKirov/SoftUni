using System;
using System.Linq;

namespace _09.Extract_Middle_Elements
{
    public class ExtractMiddleElements
    {
        public static void Main()
        {
            int[] numbersArray = Console.ReadLine().
                Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            var lenghtOfArray = numbersArray.Length;
            if (lenghtOfArray == 1)
            {
                Console.WriteLine("{ " + numbersArray[0] + " }");
            }
            else if (lenghtOfArray % 2 == 0)
            {
                Console.WriteLine("{ " + numbersArray[lenghtOfArray / 2 - 1] 
                    + ", " + numbersArray[lenghtOfArray / 2] + " }");
            }
            else if (lenghtOfArray % 2 != 0)
            {
                Console.WriteLine("{ " + numbersArray[lenghtOfArray / 2 - 1] 
                    + ", " + numbersArray[lenghtOfArray / 2] 
                    + ", " + numbersArray[lenghtOfArray / 2 + 1] + " }");
            }
        }
    }
}
 