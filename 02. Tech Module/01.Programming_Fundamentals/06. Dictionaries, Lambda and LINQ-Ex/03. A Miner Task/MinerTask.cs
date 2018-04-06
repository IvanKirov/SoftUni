using System;
using System.Collections.Generic;

namespace _03.A_Miner_Task
{
    public class MinerTask
    {
        public static void Main()
        {
            var oreDictionary = new Dictionary<string, long>();
             
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "stop") 
                {
                    break;
                }
                else if (!oreDictionary.ContainsKey(input))
                {
                    var number = uint.Parse(Console.ReadLine());
                    oreDictionary[input] = number;
                }
                else if (oreDictionary.ContainsKey(input))
                {
                    var number = long.Parse(Console.ReadLine());
                    oreDictionary[input] += number;
                }
            }

            foreach (var item in oreDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
