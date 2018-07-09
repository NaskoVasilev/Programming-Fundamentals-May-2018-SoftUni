using System;
using System.Collections.Generic;
using System.Linq;

namespace p05ExachangableWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            string word1 = tokens[0];
            string word2 = tokens[1];
            bool isExchangable = true;
            int length = Math.Min(word1.Length, word2.Length);

            if (word1.Distinct().ToList().Count != word2.Distinct().ToList().Count)
            {
                Console.WriteLine("false");
                return;
            }
            Dictionary<char, char> characters = new Dictionary<char, char>();

            for (int i = 0; i < length; i++)
            {
                char key = word1[i];
                char value = word2[i];

                if (characters.ContainsKey(key) == false)
                {
                    characters.Add(key, value);
                }
                else
                {
                    if (characters[key] != value)
                    {
                        isExchangable = false;
                        break;
                    }
                }
            }

            if(word1.Length<word2.Length)
            {
                for (int i = word1.Length; i < word2.Length; i++)
                {
                    if (characters.ContainsValue(word2[i]) == false)
                    {
                        isExchangable = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = word2.Length; i < word1.Length; i++)
                {
                    if (characters.ContainsKey(word1[i]) == false)
                    {
                        isExchangable = false;
                        break;
                    }
                }
            }
           
            Console.WriteLine(isExchangable.ToString().ToLower());
        }
    }
}
