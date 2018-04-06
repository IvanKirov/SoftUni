using System;
using System.Linq;

namespace _05.Short_Words_Sorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var splitCharacters = new[] { '.', ',', ';', ':', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', '?', ' ' };

            var inputList = Console.ReadLine()
                .ToLower()
                .Split(splitCharacters, StringSplitOptions.RemoveEmptyEntries)                
                .OrderBy(x => x)
                .ToList();

            var answer = inputList
                .Distinct()
                .Where(x => x.Length < 5)
                .ToList();

            Console.WriteLine(string.Join(", ", answer));
        }
    }
}
