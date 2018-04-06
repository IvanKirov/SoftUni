using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int k = numbers.Length / 4;

            var firstRowLeft = numbers
                .Take(k)
                .Reverse()
                .ToArray();

            var firstRowRight = numbers
                .Reverse()
                .Take(k)
                .ToArray();

            var firstRow = firstRowLeft
                .Concat(firstRowRight)
                .ToArray();

            var secondRow = numbers
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            var result = firstRow
                .Zip(secondRow, (x, y) => x + y);

            // kato gornia red, drug variant
            // var result = firstRow.Select((n, index) => n + secondRow[index]);

            foreach (var number in result)
            {
                Console.Write(number + " ");
            }
        }
    }
}
