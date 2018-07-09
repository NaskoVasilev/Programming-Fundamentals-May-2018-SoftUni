using System;
using System.Collections.Generic;
using System.Linq;

namespace p05HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();
            while (input != "JOKER")
            {
                string[] tokens = input.Split(':');
                string name = tokens[0];
                List<string> cards = tokens[1].Split(new char[] { ' ', ',' }
                , StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!players.ContainsKey(name))
                {
                    players.Add(name, cards);
                }
                else
                {
                    players[name].AddRange(cards);
                }
                input = Console.ReadLine();
            }

            foreach (var pair in players)
            {
                List<string> cards = pair.Value;
                cards = cards.Distinct().ToList();
                int value = SumPower(cards);
                Console.WriteLine($"{pair.Key}: {value}");
            }
        }

        private static int SumPower(List<string>cards)
        {
            int value = 0;
            foreach (var card in cards)
            {
                int power = 0;
                char powerAsString;
                char type;
                if (card.Length > 2)
                {
                    power = 10;
                    type = card[2];
                }
                else
                {
                    powerAsString = card[0];
                    type = card[1];
                    if ((powerAsString >= '1') && (powerAsString <= '9'))
                    {
                        power = int.Parse(powerAsString.ToString());
                    }
                    else
                    {
                        switch (powerAsString)
                        {
                            case 'J':
                                power = 11;
                                break;
                            case 'Q':
                                power = 12;
                                break;
                            case 'K':
                                power = 13;
                                break;
                            case 'A':
                                power = 14;
                                break;
                        }
                    }
                }

                switch (type)
                {
                    case 'S':
                        power *= 4;
                        break;
                    case 'H':
                        power *= 3;
                        break;
                    case 'D':
                        power *= 2;
                        break;
                }
                value += power;
            }
            return value;
        }
    }
}
