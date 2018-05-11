using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Regeh
{
    public class Regeh
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"[^\s]\[.+?<([0-9]+?)REGEH([0-9]+?)>.+?\]";
            var matches = Regex.Matches(input, pattern);

            var indexes = new Queue<int>();

            foreach (Match match in matches)
            {
                indexes.Enqueue(int.Parse(match.Groups[1].Value));
                indexes.Enqueue(int.Parse(match.Groups[2].Value));
            }

            var answer = "";
            var oldIndex = 0;

            while (indexes.Count > 0)
            {
                var currentIndex = indexes.Dequeue() + oldIndex;
                if (currentIndex >= input.Length)
                {
                    currentIndex -= input.Length;
                }
                answer += input[currentIndex];

                oldIndex = currentIndex;
            }

            Console.WriteLine(answer);        
        }
    }
}
