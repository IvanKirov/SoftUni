using System;
using System.Linq;

namespace _02.Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var inputArray = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var commands = Console.ReadLine();

            while (commands != "end")
            {
                var inputCommands = commands
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var command = inputCommands[0];

                switch (command)
                {
                    case "exchange":
                        inputArray = SplitArray(inputArray, int.Parse(inputCommands[1]));
                        break;
                    case "max":
                    case "min":
                        MaxAndMin(inputArray, command, inputCommands[1]);
                        break;
                    case "first":
                    case "last":
                        FirstAndLast(inputArray, command, int.Parse(inputCommands[1]), inputCommands[2]);
                        break;
                    default:
                        break;
                }

                commands = Console.ReadLine();
            }

            PrintArray(inputArray);
        }

        private static void FirstAndLast(int[] inputArray, string command, int count, string evenOrOdd)
        {
            if (count > inputArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var filter = FilterEvenOrOdd(inputArray, evenOrOdd);

            int[] result;

            if (command == "first")
            {
                result = filter
                    .Take(count)
                    .ToArray();
            }
            else
            {
                result = filter
                    .Reverse()
                    .Take(count)
                    .Reverse()
                    .ToArray();
            }

            PrintArray(result);
        }

        public static void MaxAndMin(int[] inputArray, string command, string evenOrOdd)
        {
            var filter = FilterEvenOrOdd(inputArray, evenOrOdd);

            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var result = command == "max"
                        ? filter.Max()
                        : filter.Min();

            Console.WriteLine(Array.LastIndexOf(inputArray, result));
        }

        public static int[] SplitArray(int[] inputArray, int index)
        {
            if (index < 0 || index >= inputArray.Length)
            {
                Console.WriteLine("Invalid index");
                return inputArray;
            }

            var left = inputArray.Take(index + 1);
            var right = inputArray.Skip(index + 1);

            return right.Concat(left).ToArray();
        }

        public static int[] FilterEvenOrOdd(int[] inputArray, string evenOrOdd)
        {
            return inputArray
                .Where(n => evenOrOdd == "even"
                        ? n % 2 == 0
                        : n % 2 == 1)
                        .ToArray();
        }

        public static void PrintArray(int[] inputArray)
        {
            var outputArray = string.Join(", ", inputArray);
            Console.WriteLine($"[{outputArray}]");
        }
    }
}
