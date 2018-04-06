using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var exit = true;
            var phoneBook = new Dictionary<string, string>();

            while (exit)
            {
                List<string> inputList = Console.ReadLine()
                .Split(' ')
                .ToList();

                var command = inputList[0];
                
                if (command == "A")
                {
                    phoneBook[inputList[1]] = inputList[2];
                }

                else if (command == "S")
                {
                    var name = inputList[1];
                    if (phoneBook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phoneBook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                else if (command == "END")
                {
                    exit = false;
                }
            }
        }
    }
}
