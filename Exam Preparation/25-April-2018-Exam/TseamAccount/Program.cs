using System;
using System.Collections.Generic;
using System.Linq;

namespace TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> games = Console.ReadLine().Split().ToList();
            string command = Console.ReadLine();

            while(command!="Play!")
            {
                string[] tokens = command.Split();
                string action = tokens[0];
                string game = tokens[1];

                switch(action)
                {
                    case "Install":
                        if(!games.Contains(game))
                        {
                            games.Add(game);
                        }
                        break;
                    case "Uninstall":
                        if(games.Contains(game))
                        {
                            games.Remove(game);
                        }
                        break;
                    case "Update":
                        if(games.Contains(game))
                        {
                            games.Remove(game);
                            games.Add(game);
                        }
                        break;
                    case "Expansion":
                        string[] info = game.Split('-');
                        game = info[0];
                        string expansion = info[1];
                        int index = games.IndexOf(game);
                        if(index>=0)
                        {
                            string gameWithExpansion = $"{game}:{expansion}";
                            games.Insert(index + 1, gameWithExpansion);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ",games));
        }
    }
}
