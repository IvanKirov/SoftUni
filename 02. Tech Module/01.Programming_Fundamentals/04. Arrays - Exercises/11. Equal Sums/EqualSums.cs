using System;
using System.Linq;

namespace _11.Equal_Sums
{
    public class EqualSums
    {
        public static void Main()
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            bool hasEqualSums = false;

            for (int i = 0; i < array.Length; i++)
            {
                int sumLeft = array.Take(i).Sum();
                var sumRight = array.Skip(i + 1).Sum();
                
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    hasEqualSums = true;
                    break;
                }
            }
            if (!hasEqualSums)
            {
                Console.WriteLine("no");
            }
        }
    }
}
