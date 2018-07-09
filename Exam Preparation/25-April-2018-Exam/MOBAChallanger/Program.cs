using System;
using System.Collections.Generic;
using System.Linq;

namespace MOBAChallanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "Season end")
            {
                string[] tokens = input.Split();
                if (tokens.Contains("->"))
                {
                    string playerName = tokens[0];
                    string position = tokens[2];
                    int skill = int.Parse(tokens[4]);
                    if (players.ContainsKey(playerName) == false)
                    {
                        Dictionary<string, int> plyerInfo = new Dictionary<string, int>();
                        plyerInfo.Add(position, skill);
                        players.Add(playerName, plyerInfo);
                    }
                    else
                    {
                        if (players[playerName].ContainsKey(position) == false)
                        {
                            players[playerName].Add(position, skill);
                        }
                        else
                        {
                            if (players[playerName][position] < skill)
                            {
                                players[playerName][position] = skill;
                            }
                        }
                    }

                }
                else
                {
                    string firstPlayer = tokens[0];
                    string secondPlayer = tokens[2];

                    if (players.ContainsKey(firstPlayer) &&
                        players.ContainsKey(secondPlayer))
                    {
                        string commonPosition = HaveCommonPosition(players, firstPlayer, secondPlayer);
                        if (commonPosition!="")
                        {
                            if(players[firstPlayer][commonPosition]>players[secondPlayer][commonPosition])
                            {
                                players.Remove(secondPlayer);
                            }
                            else
                            {
                                players.Remove(firstPlayer);
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in players.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value.Values.Sum()} skill");
                foreach (var player in pair.Value.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
                {
                    Console.WriteLine($"- {player.Key} <::> {player.Value}");
                }

            }
        }

        static string HaveCommonPosition(Dictionary<string, Dictionary<string, int>> players, string firstPlayer, string secondPlayer)
        {
            foreach (var firstPlayerInfo in players[firstPlayer])
            {
                foreach (var secondPlayerInfo in players[secondPlayer])
                {
                    if (firstPlayerInfo.Key == secondPlayerInfo.Key)
                    {
                        return firstPlayerInfo.Key;
                    }
                }
            }
            return "";
        }
    }
}
