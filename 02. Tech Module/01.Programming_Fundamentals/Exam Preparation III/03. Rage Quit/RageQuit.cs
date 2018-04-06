using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03.Rage_Quit
{
    public class RageQuit
    {
        public static void Main()
        {
            var patern = @"(\D+)(\d+)";
            var regex = new Regex(patern);

            var inputString = Console.ReadLine().ToUpper();

            MatchCollection matches = regex.Matches(inputString);

            StringBuilder outputString = new StringBuilder();

            foreach (Match match in matches)
            {
                var message = match.Groups[1].Value;
                var repeates = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < repeates; i++)
                {
                    outputString.Append(message);
                }
            }

            Console.WriteLine($"Unique symbols used: {outputString.ToString().Distinct().Count()}");
            Console.WriteLine(outputString);
        }
    }
}
