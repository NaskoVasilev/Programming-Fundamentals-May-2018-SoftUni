using System;
using System.Collections.Generic;
using System.Linq;

namespace p02OddOcurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ocurrences = new Dictionary<string, int>();
            string[] words = Console.ReadLine().ToLower().Split();

            foreach (string word in words)
            {
                if(!ocurrences.ContainsKey(word))
                {
                    ocurrences.Add(word, 1);
                }
                else
                {
                    ocurrences[word]++;
                }
            }
            List<string> oddOcurrence = new List<string>();
            foreach (KeyValuePair<string,int> pair in ocurrences)
            {
                if(pair.Value%2!=0)
                {
                    oddOcurrence.Add(pair.Key);
                }
            }

            Console.WriteLine(string.Join(", ",oddOcurrence));
        }
    }
}
