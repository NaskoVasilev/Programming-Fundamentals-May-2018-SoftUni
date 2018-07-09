using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ', }, StringSplitOptions.RemoveEmptyEntries);
            string pattern = @"#+|\$+|\^+|@+";
            Regex regex = new Regex(pattern);
            List<string> checkedTickets = new List<string>(tickets.Length);

            for (int i = 0; i < tickets.Length; i++)
            {
                string ticketResult = string.Empty;
                if (tickets[i].Length != 20)
                {
                    ticketResult = "invalid ticket";
                }
                else
                {
                    string currentTicket = tickets[i];
                    string leftHalf = currentTicket.Substring(0, 10);
                    string rightHalf = currentTicket.Substring(10);
                    int leftLength = 0;
                    int rightLength = 0;
                    char rightSymbol = ' ';
                    char leftSymbol = ' ';
                    MatchCollection leftMatches
                        = regex.Matches(leftHalf);
                    foreach (Match match in leftMatches)
                    {
                        if (match.Length >= 6)
                        {
                            leftLength = match.Length;
                            leftSymbol = match.Value[0];
                            break;
                        }
                    }

                    MatchCollection rightMatches = regex.Matches(rightHalf);
                    foreach (Match match in rightMatches)
                    {
                        if (match.Length >= 6)
                        {
                            rightLength = match.Length;
                            rightSymbol = match.Value[0];
                            break;
                        }
                    }

                    if (rightSymbol == leftSymbol && rightLength == 10 && leftLength == 10)
                    {
                        ticketResult = $"ticket \"{currentTicket}\" - 10{rightSymbol} Jackpot!";
                    }
                    else if (rightSymbol == leftSymbol && rightLength >= 6 && leftLength >= 6)
                    {
                        ticketResult = $"ticket \"{currentTicket}\" - {Math.Min(rightLength, leftLength)}{rightSymbol}";
                    }
                    else
                    {
                        ticketResult = $"ticket \"{currentTicket}\" - no match";
                    }
                }
                checkedTickets.Add(ticketResult);
            }

            foreach (string ticket in checkedTickets)
            {
                Console.WriteLine(ticket);
            }
        }


    }
}
