using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Worm_Ipsum
{
    public class Worm_Ipsum
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();

            while (inputString != "Worm Ipsum")
            {
                var numberOfSentences = inputString
                    .Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                var firstCharacter = inputString[0];
                var corectSentence = new StringBuilder();

                if (numberOfSentences.Count == 1 && (firstCharacter > 64 && firstCharacter < 91))
                {
                    var words = numberOfSentences[0]
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();

                    for (int i = 0; i < words.Capacity; i++)
                    {
                        if (words[i].Length > 2)
                        {
                            words[i] = checkLetters(words[i]);
                        }
                    }
                    Console.WriteLine($"{string.Join(" ", words)}.");
                } 
                
                inputString = Console.ReadLine();
            }
        }

        private static string checkLetters(string word)
        {
            var charsDictionary = new Dictionary<Char, int>();
            string newWord = "";

            foreach (var symbol in word)
            {
                if (!charsDictionary.ContainsKey(symbol))
                {
                    charsDictionary[symbol] = 1;
                }
                else
                {
                    charsDictionary[symbol] += 1;
                }
            }

            // Take the most frequent letter from the word
            var maxRepeatingLetter = charsDictionary
                .First(l => l.Value == charsDictionary.Values.Max())
                .Key;

            var maxCount = charsDictionary[maxRepeatingLetter];

            if (maxCount > 1)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] != ',')
                    {
                        newWord += maxRepeatingLetter;
                    }
                    else
                    {
                        newWord += ',';
                    }
                }
            }
            else
            {
                newWord = word;
            }

            return newWord;
        }
    }
}
