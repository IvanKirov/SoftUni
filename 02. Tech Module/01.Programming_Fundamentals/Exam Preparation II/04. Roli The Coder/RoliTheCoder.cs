using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Roli_The_Coder
{
    public class RoliTheCoder
    {
        public static void Main()
        {
            var inputText = Console.ReadLine();

            var events = new Dictionary<int, Event>();

            const string pattern = @"(?<id>\d+)\s+#(?<eventName>[\w\d]+)(\s+(?:@\w+\s*)+)?";
            while (inputText != "Time for Code")
            {
                var eventsDetails = Regex.Match(inputText, pattern);

                if (eventsDetails.Success)
                {
                    var id = int.Parse(eventsDetails.Groups["id"].Value);
                    var eventName = eventsDetails.Groups["eventName"].Value;

                    var participants = new string[0];
                    var eventHasParticipants = inputText.Contains("@");
                    if (eventHasParticipants)
                    {
                        participants = inputText
                            .Substring(inputText.IndexOf('@'))
                            .Split()
                            .Where(e => e != "")
                            .ToArray();
                    }

                    if (!events.ContainsKey(id))
                    {
                        events[id] = new Event()
                        {
                            Name = eventName,
                            Participants = new List<string>(new string[0])
                        };
                    }

                    if (events[id].Name == eventName)
                    {
                        events[id].Participants.AddRange(participants);
                        events[id].Participants = events[id]
                            .Participants
                            .Distinct()
                            .ToList();
                    }
                } 

                inputText = Console.ReadLine();
            }

            var sortedEvents = events
                .OrderByDescending(p => p.Value.Participants.Count)
                .ThenBy(n => n.Value.Name)
                .ToArray();

            foreach (var @event in sortedEvents)
            {
                var eventName = @event.Value.Name;
                var sortedParticipants = @event.Value.Participants.OrderBy(n => n);
                Console.WriteLine(eventName + " - " + sortedParticipants.Count());
                foreach (var participant in sortedParticipants)
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }

    internal class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
}
