using System;
using System.Linq;

namespace Hornet_Assault
{
    public class HornetAssault
    {
        public static void Main()
        {
            var beeHives = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToList();

            long hornetsPower = hornets.Sum();

            for (int i = 0; i < beeHives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                var currentHive = beeHives[i];
                if (currentHive < hornetsPower)
                {
                    beeHives[i] = 0;
                }
                else if (currentHive == hornetsPower)
                {
                    beeHives[i] = 0;                    
                    hornets.RemoveAt(0);
                    hornetsPower = hornets.Sum();
                }
                else            // beeHives[i] > power
                {
                    beeHives[i] -= hornetsPower;
                    hornets.RemoveAt(0);
                    hornetsPower = hornets.Sum();
                }
            }

            if (beeHives.Sum() > 0)
            {
                foreach (var hive in beeHives.Where(v => v > 0))
                {
                    Console.Write(hive + " ");
                }
            }
            else
            {
                foreach (var hornet in hornets)
                {
                    Console.Write(hornet + " ");
                }
            }
        }        
    }
}
