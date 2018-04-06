using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Array_Manipulator
{
    public class ArrayManipulator
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] inputCommands = Console.ReadLine()
                .Split(' ')
                .ToArray();

                if (inputCommands[0].Equals("add"))
                {
                    int index = int.Parse(inputCommands[1]);
                    int item = int.Parse(inputCommands[2]);
                    numbers.Insert(index, item);
                }

                else if (inputCommands[0].Equals("addMany"))
                {
                    int index = int.Parse(inputCommands[1]);
                    List<int> elements = inputCommands.Skip(2).
                        Take(inputCommands.Length - 2).
                        Select(int.Parse).
                        ToList();

                    numbers.InsertRange(index, elements);
                }

                else if (inputCommands[0].Equals("contains"))
                {
                    int element = int.Parse(inputCommands[1]);
                    bool hasElement = numbers.Contains(element);
                    if (hasElement)
                    {
                        Console.WriteLine(numbers.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }

                else if (inputCommands[0].Equals("remove"))
                {
                    int index = int.Parse(inputCommands[1]);
                    numbers.RemoveAt(index);
                }

                else if (inputCommands[0].Equals("shift"))
                {
                    int count = int.Parse(inputCommands[1]);
                    for (int i = 0; i < count; i++)
                    {
                        int firstNum = numbers[0];
                        numbers.RemoveAt(0);
                        numbers.Add(firstNum);
                    }
                }

                else if (inputCommands[0].Equals("sumPairs"))
                {
                    for (int i = 0; i < numbers.Count - 1; i++)
                    {
                        int sum = numbers[i] + numbers[i + 1];
                        numbers.RemoveAt(i);
                        numbers[i] = sum;
                    }
                }

                else
                {
                    Console.WriteLine($"[{string.Join(", ", numbers)}]");
                    return;
                }
            }
        }
    }
}
