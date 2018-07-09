using System;
using System.Collections.Generic;
using System.Linq;

namespace p04SplitByWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']' },
                StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> lowercase = new List<string>();
            List<string> uppercase = new List<string>();
            List<string> mixed = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                string currentWord = words[i];
                if (IsUppercase(currentWord))
                {
                    uppercase.Add(currentWord);
                }
                else if (IsLowercase(currentWord))
                {
                    lowercase.Add(currentWord);
                }
                else
                {
                    mixed.Add(currentWord);
                }
            }
            Console.WriteLine($"Lower-case: {string.Join(", ",lowercase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixed)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", uppercase)}");

        }

        private static bool IsLowercase(string currentWord)
        {
            int count = 0;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (char.IsLower(currentWord[i]))
                {
                    count++;
                }
            }
            if (count==currentWord.Length)
            {
                return true;
            }
            return false;
        }

        private static bool IsUppercase(string currentWord)
        {
            int count = 0;
            for (int i = 0; i < currentWord.Length; i++)
            {
                if (char.IsUpper(currentWord[i]))
                {
                    count++;
                }
            }
            if (count == currentWord.Length)
            {
                return true;
            }
            return false;
        }
    }
}
