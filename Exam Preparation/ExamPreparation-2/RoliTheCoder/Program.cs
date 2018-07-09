using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\d+) #(\w+)( @[A-Za-z0-9'-]+)*";
            Dictionary<string, Event> events = new Dictionary<string, Event>();
            string input = Console.ReadLine();
            Regex regex = new Regex(pattern);
            while (input != "Time for Code")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    string id = match.Groups[1].Value;
                    string eventName = match.Groups[2].Value;
                    string participantsAsSreing = "";
                    int index = match.Value.IndexOf('@');
                    if (index >= 0)
                    {
                        participantsAsSreing = match.Value.Substring(index);
                    }
                    List<string> parisipants = participantsAsSreing.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();

                    if (events.ContainsKey(id) == false)
                    {
                        Event currEvent = new Event(eventName);
                        currEvent.Participants = parisipants;
                        events.Add(id, currEvent);
                    }
                    else
                    {
                        if (events[id].Name == eventName)
                        {
                            foreach (var participant in parisipants)
                            {
                                if(events[id].Participants.Contains(participant)==false)
                                {
                                    events[id].Participants.Add(participant);
                                }
                            }
                        }
                    }

                }

                input = Console.ReadLine();
            }

            foreach (var pair in events.OrderByDescending(x => x.Value.Participants.Count).ThenBy(n=>n.Value.Name))
            {
                Console.WriteLine($"{pair.Value.Name} - {pair.Value.Participants.Count}");
                foreach (var participant in pair.Value.Participants)
                {
                    Console.WriteLine(participant);
                }
            }
        }

        class Event
        {
            public Event(string name)
            {
                this.Name = name;
                this.Participants = new List<string>();
            }

            public string Name { get; set; }
            public List<string> Participants { get; set; }
        }
    }
}
