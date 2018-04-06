using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Palindromes
{
    public class Palindromes
    {
        public static bool IsPalindrom(string word)
        {
            var reversedWord = word.Reverse();
            var answer = word.SequenceEqual(reversedWord);
            
            return answer;
        }

        public static void Main()
        {
            var words = Console.ReadLine()
                .Split(new char[] { ',', ' ', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var palindroms = new List<string>();

            foreach (var word in words)
            {
                if (IsPalindrom(word))
                {
                    palindroms.Add(word);
                }
            }
            
            Console.WriteLine(string.Join(", ", palindroms.OrderBy(x => x).Distinct()));
        }
    }
}
