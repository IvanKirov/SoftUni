using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Hornet_Comm_01
{
    public class HornetComm01
    {
        public static void Main()
        {
            var line = Console.ReadLine();

            var privatMessages = new List<string>();
            var broadcasts = new List<string>();

            while (line != "Hornet is Green")
            {
                var fullPatern = @"^(\d+|\D+) \<\-\> ([a-zA-Z0-9]+)$";
                var regexFullLine = new Regex(fullPatern);
                var matchFull = regexFullLine.Match(line);

                if (matchFull.Success)
                {
                    long recepientCode;
                    var firstQuery = matchFull.Groups[1].Value;
                    bool messageOrCode = long.TryParse(firstQuery, out recepientCode);
                    if (messageOrCode)
                    {
                        var reversedCode = string.Join("", matchFull.Groups[1].Value.Reverse());
                        var message = matchFull.Groups[2].Value;
                        privatMessages.Add(reversedCode + " -> " + message);
                    }
                    else
                    {
                        string frequency = DecryptFrequency(matchFull.Groups[2].Value);
                        broadcasts.Add(frequency + " -> " + firstQuery);
                    }
                }

                line = Console.ReadLine();
            }

            Console.WriteLine("Broadcasts:");
            PrintList(broadcasts);

            Console.WriteLine("Messages:");
            PrintList(privatMessages);
        }

        private static string DecryptFrequency(string encryptedFrequence)
        {
            var decryptedFrequency = string.Empty;

            foreach (char currentChar in encryptedFrequence)
            {
                if (currentChar >= 65 && currentChar <= 90)
                {
                    decryptedFrequency += (char)(currentChar + 32);
                }
                else if (currentChar >= 97 && currentChar <= 122)
                {
                    decryptedFrequency += (char)(currentChar - 32);
                }
                else
                {
                    decryptedFrequency += currentChar;
                }
            }
            //for (int i = 0; i < decryptedFrequence.Length; i++)
            //{
            //    var newChar = decryptedFrequence[i];
            //    if (char.IsLower(newChar))
            //    {
            //        decryptedFrequence.Append(char.ToUpper(newChar));
            //    }
            //    else if (char.IsUpper(newChar))
            //    {
            //        decryptedFrequence.Append(char.ToLower(newChar));
            //    }
            //    else
            //    {
            //        decryptedFrequence.Append(newChar);
            //    }                
            //}

            return decryptedFrequency;
        }

        private static void PrintList(List<string> collection)
        {
            if (collection.Count > 0)
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
