using System;
using System.Collections.Generic;
using System.Linq;

namespace Hornet_Armada
{
    public class HornetArmada
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());

            var legions = new List<Legion>();

            for (int i = 0; i < number; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { "=", "-", ">", ":", " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var lastActivity = int.Parse(line[0]);
                var legionName = line[1];
                var soldierType = line[2];
                var soldierCount = int.Parse(line[3]);

                if (!legions.Any(n => n.Name == legionName))
                {
                    var newLegion = new Legion();
                    newLegion.Name = legionName;
                    newLegion.LastActivity = lastActivity;
                    newLegion.Soldier = new Dictionary<string, long>();
                    newLegion.Soldier.Add(soldierType, soldierCount);

                    legions.Add(newLegion);
                }
                else if (legions.Any(n => n.Name == legionName))
                {
                    var legionsIndex = legions.FindIndex(n => n.Name == legionName);
                    if (!legions[legionsIndex].Soldier.Any(n => n.Key == soldierType))
                    {
                        legions[legionsIndex].Soldier.Add(soldierType, soldierCount);

                        if (legions[legionsIndex].LastActivity < lastActivity)
                        {
                            legions[legionsIndex].LastActivity = lastActivity;
                        }
                    }
                    else
                    {
                        legions[legionsIndex].Soldier[soldierType] += soldierCount;

                        if (legions[legionsIndex].LastActivity < lastActivity)
                        {
                            legions[legionsIndex].LastActivity = lastActivity;
                        }
                    }
                }
            }

            var outputCondition = Console.ReadLine()
                .Split('\\')
                .ToArray();

            int digit;
            var firstChar = outputCondition[0].First().ToString();
            bool condition = int.TryParse(firstChar, out digit);

            if (condition)
            {
                var soldierType = outputCondition[1];
                var borderActivity = int.Parse(outputCondition[0]);

                foreach (var legion in legions
                    .Where(s => s.Soldier.ContainsKey(soldierType))
                    .Where(a => a.LastActivity < borderActivity)
                    .OrderByDescending(s => s.Soldier[soldierType]))
                {
                    Console.WriteLine($"{legion.Name} -> {legion.Soldier[soldierType]}");
                }
            }
            else
            {
                foreach (var legion in legions.OrderByDescending(a => a.LastActivity))
                {
                    Console.WriteLine($"{legion.LastActivity} : {legion.Name}");
                }
            }
             
        }
    }

    public class Legion
    {
        public string Name { get; set; }
        public long LastActivity { get; set; }
        public Dictionary<string, long> Soldier { get; set; }
    }
}
