using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Command_Interpreter
{
    public class CommandInterpreter
    {
        public static void Main()
        {
            var stringInput = Console.ReadLine()
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var inputCommands = Console.ReadLine();

            while (inputCommands != "end")
            {
                var commandParams = inputCommands
                .Trim()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                var command = commandParams[0];

                switch (command)
                {
                    case "reverse":
                        var reverseStart = int.Parse(commandParams[2]);
                        var reverseCount = int.Parse(commandParams[4]);

                        if (isValid(stringInput, reverseStart, reverseCount))
                        {
                            //stringInput.Reverse(reverseStart, reverseCount);
                            Reverse(stringInput, reverseStart, reverseCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "sort":
                        var sortStart = int.Parse(commandParams[2]);
                        var sortCount = int.Parse(commandParams[4]);

                        if (isValid(stringInput, sortStart, sortCount))
                        {
                            //stringInput.Sort(sortStart, sortCount, StringComparer.InvariantCulture);
                            Sort(stringInput, sortStart, sortCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    case "rollLeft":
                        var rollLeftCount = int.Parse(commandParams[1]);


                        if (rollLeftCount >= 0)
                        {
                            RollLeft(stringInput, rollLeftCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }                        

                        break;
                    case "rollRight":
                        var rollRightCount = int.Parse(commandParams[1]);
                                                
                        if (rollRightCount >= 0)
                        {
                            RollRight(stringInput, rollRightCount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }

                        break;
                    default:
                        break;
                }


                inputCommands = Console.ReadLine();
            }

            Console.WriteLine("[{0}]", string.Join(", ", stringInput));
        }

        public static void RollRight(List<string> stringInput, int count)
        {            
            count = count % stringInput.Count;

            for (int i = 0; i < count; i++)
            {
                var lastElement = stringInput[stringInput.Count - 1];
                stringInput.RemoveAt(stringInput.Count - 1);
                stringInput.Insert(0, lastElement);
                
                //    for (int j = stringInput.Count - 1; j < 0; j--)
                //    {
                //        stringInput[j] = stringInput[j - 1];
                //    }

                //    stringInput[0] = lastElement;
            }
        }

        public static void RollLeft(List<string> stringInput, int count)
        {
            count = count % stringInput.Count;          // проверява за ненужни превъртания, след пълно превъртане

            for (int i = 0; i < count; i++)
            {
                var firstElement = stringInput[0];

                for (int j = 0; j < stringInput.Count - 1; j++)
                {
                    stringInput[j] = stringInput[j + 1];
                }

                stringInput[stringInput.Count - 1] = firstElement;
            }
        }

        public static void Sort(List<string> stringInput, int sortStart, int sortCount)
        {
            var sortArray = stringInput
                .Skip(sortStart)
                .Take(sortCount)
                .OrderBy(a => a)
                .ToList();

            stringInput.RemoveRange(sortStart, sortCount);
            stringInput.InsertRange(sortStart, sortArray);
        }

        public static void Reverse(List<string> stringInput, int reverseStart, int reverseCount)
        {
            var reverseArray = stringInput
                .Skip(reverseStart)
                .Take(reverseCount)
                .Reverse()
                .ToList();

            stringInput.RemoveRange(reverseStart, reverseCount);
            stringInput.InsertRange(reverseStart, reverseArray);
        }

        public static bool isValid(List<string> stringInput, int start, int count)
        {
            if (start >= 0 && start < stringInput.Count && count >= 0 && (start + count) <= stringInput.Count)
            {
                return true;
            }

            return false;
        }
    }
}
