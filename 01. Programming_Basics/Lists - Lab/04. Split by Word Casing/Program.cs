using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Split_by_Word_Casing
{
    public class SplitByWordCasing
    {
        public static void Main()
        {
            List<string> inputList = Console.ReadLine().Split('|', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ').ToList();

            var lowerCaseList = new List<string>();
            var upperCaseList = new List<string>();
            var mixCaseList = new List<string>();

            foreach (var word in inputList)
            {
                List<string> mixWords = word.Split(' ').ToList();
                foreach (var character in mixWords)
                {
                    if (number != "")
                    {
                        outputList.Add(number);
                    }
                }
            }
        }
    }
}
