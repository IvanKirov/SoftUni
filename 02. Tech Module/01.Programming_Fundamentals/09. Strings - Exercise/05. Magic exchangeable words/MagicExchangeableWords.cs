using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Magic_exchangeable_words
{
    public class MagicExchangeableWords
    {
        public static void Main()
        {
            var text = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var firstWord = text
                .OrderByDescending(s => s.Length)
                .First()
                .ToCharArray();

            var secondWord = text
                .OrderByDescending(s => s.Length)
                .Last()
                .ToCharArray();

            var length = Math.Min(firstWord.Length, secondWord.Length);

            var pairs = new Dictionary<char, char>();
            var answer = "true";

            for (int i = 0; i < length; i++)
            {
                var charFirstWord = firstWord[i];
                var charSecondWord = secondWord[i];

                if (pairs.ContainsKey(charFirstWord))
                {
                    if (!pairs[charFirstWord].Equals(charSecondWord))
                    {
                        answer = "false";
                        break;
                    }
                }
                else if (pairs.ContainsValue(charSecondWord))
                {
                    answer = "false";
                    break;
                }
                else
                {
                    pairs[charFirstWord] = charSecondWord;
                }
            }

            for (int i = length; i < firstWord.Length; i++)
            {
                var charFirstWord = firstWord[i];

                if (!pairs.ContainsKey(charFirstWord))
                {
                    answer = "false";
                    break;
                }
            }

            Console.WriteLine(answer);
        }
    }
}
