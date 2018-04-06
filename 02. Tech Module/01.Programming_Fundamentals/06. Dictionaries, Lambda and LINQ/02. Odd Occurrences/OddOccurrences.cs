using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Odd_Occurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            List<string> inputList = Console.ReadLine()
                .ToLower()
                .Split(' ')
                .ToList();
            
            var countDictionary = new Dictionary<string, int>();

            foreach (var word in inputList)
            {
                if (!countDictionary.ContainsKey(word))
                {
                    countDictionary[word] = 0;
                }

                countDictionary[word]++;
            }

            var result = new List<string>();
            foreach (var item in countDictionary)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                    
                }
            }

            Console.Write(string.Join(", ", result));
        }
    }
}
