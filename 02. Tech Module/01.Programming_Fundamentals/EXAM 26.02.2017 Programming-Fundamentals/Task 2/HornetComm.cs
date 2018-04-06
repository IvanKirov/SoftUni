using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hornet_Comm
{
    public class HornetComm
    {
        public static void Main()
        {
            var privateMessages = new Dictionary<string, List<string>>();
            var broadcast = new Dictionary<string, List<string>>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Hornet is Green")
                {
                    break;
                }
                
                var regex = new Regex($@"(\D+|\d+)\s<->\s(\w+)");

                var match = regex.Match(line);

                if (match.Success)
                {
                    var firstQuery = match.Groups[1].Value;
                    var secondQuery = match.Groups[2].Value;

                    var digits = "0123456789".ToCharArray();

                    if (digits.Contains(firstQuery.First()))        //private message
                    {
                        var recepientsCodeReverse = firstQuery.Reverse().ToArray();
                        var recepientsCode = new string(recepientsCodeReverse);

                        if (!privateMessages.ContainsKey(recepientsCode))
                        {
                            privateMessages[recepientsCode] = new List<string>();
                        }

                        privateMessages[recepientsCode].Add(secondQuery);
                    }
                    else               //broadcast
                    {
                        var frequency = secondQuery.ToCharArray();
                        var changedFrequency = new StringBuilder();

                        for (int i = 0; i < frequency.Length; i++)
                        {
                            var upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXZ".ToCharArray();
                            var lowerCase = "abcdefghijklmnopqrstuvwxz".ToCharArray();
                            var newCahr = frequency[i];

                            if (upperCase.Contains(frequency[i]))
                            {
                                newCahr = char.ToLower(frequency[i]);
                            }
                            else if (lowerCase.Contains(frequency[i]))
                            {
                                newCahr = char.ToUpper(frequency[i]);
                            }
                            changedFrequency.Append(newCahr);
                        }

                        var inputFrequency = changedFrequency.ToString();
                        if (!broadcast.ContainsKey(inputFrequency))
                        {
                            broadcast[inputFrequency] = new List<string>();
                        }

                        broadcast[inputFrequency].Add(firstQuery);
                    }
                }
            }

            Console.WriteLine("Broadcasts:");
            PrintDictionary(broadcast);


            Console.WriteLine("Messages:");
            PrintDictionary(privateMessages);
        }

        private static void PrintDictionary(Dictionary<string, List<string>> dictionary)
        {
            if (dictionary.Any())
            {

                foreach (var kvp in dictionary)
                {
                    foreach (var item in kvp.Value)
                    {
                        Console.WriteLine($"{kvp.Key} -> {item}");
                    }
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
