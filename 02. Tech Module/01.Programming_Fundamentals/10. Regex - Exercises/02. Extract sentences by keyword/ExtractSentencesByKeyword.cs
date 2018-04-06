using System;
using System.Text.RegularExpressions;

namespace _02.Extract_sentences_by_keyword
{
    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            var searchText = Console.ReadLine();

            var sentences = Console.ReadLine()
                .Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var pattern = "\\b" + searchText + "\\b";
            
            var regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }                
            }
        }
    }
}
