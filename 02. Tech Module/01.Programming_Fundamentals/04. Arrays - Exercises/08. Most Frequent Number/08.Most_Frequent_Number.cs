using System;
using System.Linq;

namespace _08.Most_Frequent_Number
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            
            var mostFrequentNumber = 0;
            var maxCounter = 1;

            for (int i = 0; i < array.Length; i++)
            {
                var currentNumber = array[i];
                var currentCounter = 0;
                for (int j = i; j < array.Length; j++)
                {
                    if (currentNumber == array[j])
                    {
                        currentCounter++;
                    }
                }
                if (currentCounter > maxCounter)
                {
                    mostFrequentNumber = currentNumber;
                    maxCounter = currentCounter;
                }
            }

            Console.WriteLine(mostFrequentNumber);
        }
    }
}
