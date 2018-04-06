using System;
using System.Text.RegularExpressions;

namespace _01.Replace_a_tag
{
    public class ReplaceATag
    {
        public static void Main()
        {
            var inputText = string.Empty;
            var text = Console.ReadLine();

            while (text != "end")
            {                       
                var regex = new Regex(@"<a.*href.*=(.*)>(.*)<\/a>");

                var result = regex.Replace(text, @"[URL href=$1]$2[/URL]");

                Console.WriteLine(result);
                text = Console.ReadLine();
            }             

        }
    }
}
