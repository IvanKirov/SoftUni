using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    public class WormsWorldParty
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var teamsList = new Dictionary<string, long>();
            var wormsList = new List<string>();
            var teamPlayersList = new Dictionary<string, Dictionary<string, int>>();

            while (inputLine != "quit")
            {
                var wormData = inputLine
                    .Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var wormName = wormData[0];
                var wormTeam = wormData[1];
                var wormScore = int.Parse(wormData[2]);

                if (!wormsList.Contains(wormName))
                {
                    wormsList.Add(wormName);
                    if (!teamsList.ContainsKey(wormTeam))
                    {
                        teamsList.Add(wormTeam, wormScore);
                        var playerList = new Dictionary<string, int>();
                        playerList.Add(wormName, wormScore);
                        teamPlayersList.Add(wormTeam, playerList);
                    }
                    else
                    {
                        teamsList[wormTeam] += wormScore;
                        teamPlayersList[wormTeam].Add(wormName, wormScore);
                    }
                }

                inputLine = Console.ReadLine();
            }

            var count = 1;
            foreach (var kvp in teamsList.OrderByDescending(s => s.Value))
            {
                Console.WriteLine($"{count}. Team: {kvp.Key} - {kvp.Value}");
                foreach (var worm in teamPlayersList[kvp.Key].OrderByDescending(s => s.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
                count++;
            }
        }
    }
}
