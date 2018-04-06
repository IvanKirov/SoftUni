using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Append_Lists
{
    public class AppendLists
    {
        public static void Main()
        {
            List<string> inputList = Console.ReadLine().Split('|').ToList();

            inputList.Reverse();

            var outputList = new List<string>();
            foreach (var item in inputList)
            {
                List<string> numbers = item.Split(' ').ToList();
                foreach (var number in numbers)
                {
                    if (number != "")
                    {
                        outputList.Add(number);
                    }
                }
            }

            inputList.ForEach(Console.WriteLine);
        }
    }
}
