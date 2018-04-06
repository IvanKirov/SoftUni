using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUni_Karaoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(p => p.Trim())
                .ToArray();     // po dobre e hashset

            var songs = Console.ReadLine()
               .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(p => p.Trim())
               .ToArray();

            var result = new Dictionary<string, List<string>>();

            string line = Console.ReadLine();

            while (line != "dawn")
            {
                var performance = line
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(p => p.Trim())
                    .ToArray();

                var participant = performance[0];
                var song = performance[1];
                var award = performance[2];

                if (participants.Contains(participant))
                {
                    if (!result.ContainsKey(participant) && songs.Contains(song))
                    {
                        result[participant] = new List<string>();
                    }

                    var awards = result[participant];
                    if (songs.Contains(song) && !awards.Contains(award))
                    {
                        awards.Add(award);
                    }
                }

                line = Console.ReadLine();
            }

            if (result.Any())
            {
                foreach (var kvp in result
                    .OrderByDescending(p => p.Value.Count)
                    .ThenBy(p => p.Key))
                {
                    var participant = kvp.Key;
                    var awards = kvp.Value;
                    Console.WriteLine($"{participant}: {awards.Count} awards");

                    foreach (var award in awards.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }                    
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
