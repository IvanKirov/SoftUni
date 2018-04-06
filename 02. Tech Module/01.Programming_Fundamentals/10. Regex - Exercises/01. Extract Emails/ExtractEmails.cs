using System;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{

    public class ExtractEmails
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            // @"\b(?<!\S)(([a-z0-9\-\.]+@[a-z0-9\-]+\.[a-z0-9]+([\.a-z0-9]+)?))\b"
            var regex = new Regex(@"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+");

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                string matchString = match.ToString();
                if (!(matchString.StartsWith(".") ||
                    matchString.StartsWith("-") ||
                    matchString.StartsWith("_") ||
                    matchString.EndsWith(".") ||
                    matchString.EndsWith("-") ||
                    matchString.EndsWith("_")))
                {
                    Console.WriteLine(match.Value);
                }
                // Console.WriteLine(match.Value);
            }
        }
    }
}
