using System;
using System.Linq;


namespace _01.Remove_Negatives_and_Reverse
{
    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var listNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            listNumbers.RemoveAll(x => x < 0);

            if (listNumbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                listNumbers.Reverse();

                listNumbers.ForEach(Console.WriteLine);
            }
        }
    }
}
