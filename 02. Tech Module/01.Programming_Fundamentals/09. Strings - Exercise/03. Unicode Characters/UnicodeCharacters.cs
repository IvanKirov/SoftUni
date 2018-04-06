using System;

namespace _03.Unicode_Characters
{
    public class UnicodeCharacters
    {
        public static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }

        public static void Main()
        {
            var text = Console.ReadLine()
                .ToCharArray();

            var answer = string.Empty;

            foreach (var symbol in text)
            {
                answer += GetEscapeSequence(symbol).ToLower();
            }

            Console.WriteLine(answer);
        }        
    }
}
