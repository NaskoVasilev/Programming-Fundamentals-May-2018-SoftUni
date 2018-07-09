using System;
using System.Collections.Generic;

namespace p04FixEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> emails = new Dictionary<string, string>();
            string name = "";
            int line = 0;
            while (input != "stop")
            {
                string mail  = "";
                if (line % 2 == 0)
                {
                    name = input;
                }
                else
                {
                    mail = input;
                    if(!mail.EndsWith("us")&&!mail.EndsWith("uk"))
                    {
                        emails.Add(name, mail);
                    }
                }
                line++;
                input = Console.ReadLine();
            }
            foreach (var pair in emails)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }

        }
    }
}
