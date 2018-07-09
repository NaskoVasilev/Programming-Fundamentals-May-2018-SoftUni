using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace p03WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words =File.ReadAllText("words.txt")
                .ToLower()
                .Split();

            string[] wordInText = File.ReadAllText("input.txt")
                .ToLower()
                .Split(new char[] { ' ', '-', ',', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> countOfWords = words.ToDictionary(x => x, x => 0);

            foreach (string word in wordInText)
            {
                if(countOfWords.ContainsKey(word))
                {
                    countOfWords[word]++;
                }
            }

            foreach (var pair in countOfWords.OrderByDescending(x=>x.Value))
            {
                string line = $"{pair.Key} -> {pair.Value}{Environment.NewLine}";
                File.AppendAllText("result.txt", line);
            }
        }
    }
}
