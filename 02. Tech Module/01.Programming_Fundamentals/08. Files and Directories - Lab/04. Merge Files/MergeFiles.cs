using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04.Merge_Files
{
    public class MergeFiles
    {
        public static void Main()
        {
            var inputFileOne = File.ReadAllText("../../input1.txt")
                .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var inputFileTwo = File.ReadAllText("../../input2.txt")
                .Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var result = new List<string>();
            var lenght = Math.Min(inputFileOne.Length, inputFileOne.Length);

            for (int i = 0; i < lenght; i++)
            {
                var currentWordFileOne = inputFileOne[i];
                var currentWordFileTwo = inputFileTwo[i];
                result.Add(currentWordFileOne);
                result.Add(currentWordFileTwo);
            }

            File.WriteAllLines("../../Output.txt", result);
        }
    }
}
