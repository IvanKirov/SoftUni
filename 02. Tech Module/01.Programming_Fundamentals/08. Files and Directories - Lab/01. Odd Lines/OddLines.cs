using System.Collections.Generic;
using System.IO;

namespace _01.Odd_Lines
{
    public class OddLines
    {
        public static void Main()
        {
            var file = "../../input.txt";

            var lines = File.ReadAllLines(file);

            if (!File.Exists("input.txt"))
            {
                File.Create("input.txt");
            }

            var oddLines = new List<string>();

            for (int i = 0; i < lines.Length; i++)
            {
                if (i % 2 != 0)
                {
                    oddLines.Add(lines[i]);
                }
            }

            File.WriteAllLines("../../Output.txt", oddLines);
        }
    }
}
