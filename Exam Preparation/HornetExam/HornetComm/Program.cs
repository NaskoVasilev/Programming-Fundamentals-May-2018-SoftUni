using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            string privateMessagePattern = @"^([0-9]+) <-> ([A-Za-z0-9]+)$";
            string broadcastPattern = @"^([^0-9]+) <-> ([A-Za-z0-9]+)$";
            Regex privateRegex = new Regex(privateMessagePattern);
            Regex broadcastRegex = new Regex(broadcastPattern);
            List<string> privateMessages = new List<string>();
            List<string> broadcastMessages = new List<string>();
            string input = "";

            while ((input = Console.ReadLine()) != "Hornet is Green")
            {
                if (privateRegex.IsMatch(input))
                {
                    Match match = privateRegex.Match(input);
                    string code = match.Groups[1].Value;
                    code = new string(code.Reverse().ToArray());
                    string message = match.Groups[2].Value;
                    string privateMessage = code + " -> " + message;
                    privateMessages.Add(privateMessage);
                }
                else if (broadcastRegex.IsMatch(input))
                {
                    Match match = broadcastRegex.Match(input);
                    string message = match.Groups[1].Value;
                    string frequency = match.Groups[2].Value;
                    frequency = ChengeFrequency(frequency);
                    string broadcastMessage = frequency + " -> " + message;
                    broadcastMessages.Add(broadcastMessage);
                }

            }

            Console.WriteLine("Broadcasts:");
            if(broadcastMessages.Count==0)
            {
                Console.WriteLine("None");
            }
            foreach (string message in broadcastMessages)
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("Messages:");
            if (privateMessages.Count == 0)
            {
                Console.WriteLine("None");
            }
            foreach (string message in privateMessages)
            {
                Console.WriteLine(message);
            }
        }

        private static string ChengeFrequency(string frequency)
        {
            StringBuilder changedFrequency = new StringBuilder(frequency.Length);

            for (int i = 0; i < frequency.Length; i++)
            {
                char currentLetter = frequency[i];
                if(char.IsUpper(currentLetter))
                {
                    changedFrequency.Append(char.ToLower(currentLetter));
                }
                else if(char.IsLower(currentLetter))
                {
                    changedFrequency.Append(char.ToUpper(currentLetter));
                }
                else
                {
                    changedFrequency.Append(currentLetter);
                }
            }

            return changedFrequency.ToString();
        }
    }
}
