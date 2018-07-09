using System;
using System.Collections.Generic;
using System.Linq;

namespace p09TeamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfTeams = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < countOfTeams; i++)
            {
                string[] info = Console.ReadLine().Split('-');
                string creator = info[0];
                string teamName = info[1];

                Team team = teams.FirstOrDefault(x => x.Name == teamName);
                if (team != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                team = teams.FirstOrDefault(x => x.Creator == creator);
                if (team != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }

                Team currTeam = new Team(teamName, creator);
                teams.Add(currTeam);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of assignment")
                {
                    break;
                }

                string[] tokens = command.Split("->");
                string member = tokens[0];
                string teamName = tokens[1];

                Team team = teams.FirstOrDefault(x => x.Name == teamName);
                if (team == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                bool isCrearor = teams.Any(x => x.Creator == member);
                bool isMemeberInOtherTeam = teams.Any(x => x.Members.Contains(member));

                if(isCrearor||isMemeberInOtherTeam)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }
                team.Members.Add(member);
            }

            List<Team> disbandTeams = teams.Where(x => x.Members.Count == 0).ToList();
            List<Team> validTeams = teams.Where(x => x.Members.Count > 0).ToList();

            foreach (var team in validTeams.OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.Creator);
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var disband in disbandTeams.OrderBy(x => x.Name))
            {
                Console.WriteLine(disband.Name);
            }
        }

        class Team
        {
            public string Name { get; set; }
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public Team(string name, string creator)
            {
                this.Name = name;
                this.Creator = creator;
                this.Members = new List<string>();
            }
        }
    }
}
