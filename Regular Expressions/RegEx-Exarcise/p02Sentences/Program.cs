using System;
using System.Text.RegularExpressions;

namespace p02Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = $@"\b{keyWord}\b";         

            string[] sentences = text.Split(new char[] { '.', '?', '!' }
            , StringSplitOptions.RemoveEmptyEntries);
            Regex regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if(regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
