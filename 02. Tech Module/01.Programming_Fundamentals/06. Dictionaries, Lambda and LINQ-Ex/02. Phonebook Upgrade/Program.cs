using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Phonebook_Upgrade
{
    public class PhonebookUpgrade
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

                else if (command == "ListAll")
                {
                    List<KeyValuePair<string, string>> orderedPhoneBook = phoneBook.OrderBy(x => x.Key).ToList();
                    foreach (var name in orderedPhoneBook)
                    {
                        Console.WriteLine($"{name.Key} -> {name.Value}");
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
