using System;
using System.Text.RegularExpressions;

namespace _00.Lekcia00
{
    public class Lekcia00
    {
        public static void Main()
        {
            var text = "Text 123 text 456";

            var regex = new Regex(@"\w+\s\d+");

            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }

            var text1 = "test_test@som.co";

            var regex1 = new Regex(@"\w{2,}@[A-Za-z0-9]{3,}\.[A-Za-z]{2,4}");

        }
    }
}
