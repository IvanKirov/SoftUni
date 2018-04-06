using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.User_Logs
{
    public class UserLogs
    {
        public static void Main()
        {
            var usersLogs = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                var inputLine = input.Split(' ');
                var userName = inputLine[2]; //.Skip(5).ToString();
                var ipAdress = inputLine[0];

                if (!usersLogs.ContainsKey(userName))
                {
                    usersLogs[userName] = new Dictionary<string, int>();
                }
                if (!usersLogs[userName].ContainsKey(ipAdress))
                {
                    usersLogs[userName][ipAdress] = 0;
                }

                usersLogs[userName][ipAdress]++;
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> name in usersLogs)
            {
                Console.WriteLine(name);
                foreach (KeyValuePair<string, int> adress in name.Value)
                {
                    Console.WriteLine($"{adress.Key} => {adress.Value}");
                }
            }            
        }
    }
}
