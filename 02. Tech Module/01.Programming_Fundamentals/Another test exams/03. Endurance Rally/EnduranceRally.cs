using System;
using System.Linq;
using System.Text;

namespace _03.Endurance_Rally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            var participantsNames = Console.ReadLine()
                .Split()
                .ToArray();

            var trackZones = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            var checkpoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Select(x => x)
                .ToArray();

            foreach (var name in participantsNames)
            {                
                double racerFuel = Encoding.ASCII.GetBytes(name).First();
                for (int i = 0; i < trackZones.Length; i++)
                {
                    if (checkpoints.Contains(i))
                    {
                        racerFuel += trackZones[i];
                    }
                    else
                    {
                        racerFuel -= trackZones[i];
                    }

                    if (racerFuel <= 0)
                    {
                        Console.WriteLine($"{name} - reached {i}");
                        break;
                    }
                }

                if (racerFuel > 0)
                {
                    Console.WriteLine($"{name} - fuel left {racerFuel:f2}");
                }
            }
        }
    }
}
