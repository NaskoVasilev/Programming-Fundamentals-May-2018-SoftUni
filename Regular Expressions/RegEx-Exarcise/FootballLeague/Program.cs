using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FootballLeague
{
    class Program
    {
        static void Main(string[] args)
        {
            string key = Console.ReadLine();
            string resultPattern = @"(\d+):(\d+)";
            string pattern = $@"{key}([A-Za-z ]+?){key}";
            Regex regex = new Regex(pattern);
            Regex resultRegex = new Regex(resultPattern);
            Dictionary<string, List<long>> teams = new Dictionary<string, List<long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "final")
                {
                    break;
                }

                string[] currentTeams = new string[5];
                int index = 0;
                MatchCollection matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    if (match.Success)
                    {
                        currentTeams[index] = match.Groups[1].Value;
                        index++;
                    }
                }
                Match result = resultRegex.Match(input);
                long[] scores = new long[5];
                if (result.Success)
                {
                    scores[0] = long.Parse(result.Groups[1].Value);
                    scores[1] = long.Parse(result.Groups[2].Value);
                }
                else
                {
                    continue;
                }
                long firstTeamScore = 0;
                long secondTeamScore = 0;

                string firstTeam = ReverseName(currentTeams[0]);
                string secondTeam = ReverseName(currentTeams[1]);
                if (scores[0] == scores[1])
                {
                    firstTeamScore = 1;
                    secondTeamScore = 1;
                }
                else if (scores[0] > scores[1])
                {
                    firstTeamScore = 3;
                }
                else
                {
                    secondTeamScore = 3;
                }

                if (teams.ContainsKey(firstTeam) == false)
                {
                    teams.Add(firstTeam, new List<long>() { 0, 0 });
                }
                teams[firstTeam][0] += firstTeamScore;
                teams[firstTeam][1] += scores[0];

                if (teams.ContainsKey(secondTeam) == false)
                {
                    teams.Add(secondTeam, new List<long>() { 0, 0 });
                }
                teams[secondTeam][0] += secondTeamScore;
                teams[secondTeam][1] += scores[1];

            }

            Console.WriteLine("League standings:");
            int position = 1;
            foreach (var team in teams.OrderByDescending(x => x.Value[0]).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{position}. {team.Key} {team.Value[0]}");
                position++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in teams.OrderByDescending(x => x.Value[1]).ThenBy(x=>x.Key).Take(3))
            {
                Console.WriteLine($"- {team.Key} -> {team.Value[1]}");
            }
        }

        static string ReverseName(string name)
        {
            string reversedName = new string(name.Reverse().ToArray());
            return reversedName.ToUpper();
        }
    }
}
