using System;
using System.Linq;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var listNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            var lenght = listNumbers.Count;
            for (int i = 0; i < lenght; i++)
            {
                var currentNumber = listNumbers[i];
                if ((i + 1) >= lenght)
                {
                    break;
                }
                else
                {
                    var nextNumber = listNumbers[i + 1];
                    if (currentNumber == nextNumber)
                    {
                        listNumbers[i] = currentNumber + nextNumber;
                        listNumbers.Remove(nextNumber);
                        i = -1;
                        lenght--;
                    }
                }                
            }

            listNumbers.ForEach(Console.WriteLine);
        }
    }
}
