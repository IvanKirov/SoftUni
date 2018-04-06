using System.Collections.Generic;
using System.IO;

namespace _02.Line_Numbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            var file = "../../input.txt";

            var lines = File.ReadAllLines(file);

            var linesWithNumbers = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                linesWithNumbers.Add($"{i + 1}. {lines[i]}");
            }

            File.WriteAllLines("../../Output.txt", linesWithNumbers);
        }
    }
}
