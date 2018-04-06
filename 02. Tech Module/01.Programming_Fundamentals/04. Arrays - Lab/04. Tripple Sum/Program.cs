using System;
using System.Linq;

namespace _04.Tripple_Sum
{
    public class TripleSum
    {
        public static void Main()
        {
            long[] numberArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

            int resultsCounter = 0;
            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int secondNumber = i + 1; secondNumber < numberArray.Length; secondNumber++)
                {
                    for (int lastNumber = 0; lastNumber < numberArray.Length; lastNumber++)
                    {
                        if (numberArray[i] + numberArray[secondNumber] == numberArray[lastNumber])
                        {
                            Console.WriteLine($"{numberArray[i]} + {numberArray[secondNumber]} == {numberArray[lastNumber]}");
                            resultsCounter++;
                            break;
                        }
                    }
                }                
            }

            if (resultsCounter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
