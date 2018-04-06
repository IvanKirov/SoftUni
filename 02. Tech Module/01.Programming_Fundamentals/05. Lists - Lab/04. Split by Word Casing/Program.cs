using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Split_by_Word_Casing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            List<string> inputList = Console.ReadLine()
                .Split(
                new[] { '|', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixCaseList = new List<string>();

            foreach (var word in inputList)
            {
                bool isAllLowerCase = true;
                bool isAllUpperrCase = true;
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        isAllUpperrCase = false;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        isAllLowerCase = false;
                    }
                    else
                    {
                        isAllLowerCase = false;
                        isAllUpperrCase = false;
                    }

                }
                if (isAllLowerCase)
                {
                    lowerCaseList.Add(word);
                }
                else if (isAllUpperrCase)
                {
                    upperCaseList.Add(word);
                }
                else
                {
                    mixCaseList.Add(word);
                }
            }
            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCaseList));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixCaseList));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCaseList));
        }
    }
}
