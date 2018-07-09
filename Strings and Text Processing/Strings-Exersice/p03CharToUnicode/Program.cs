using System;

namespace p03CharToUnicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            foreach (var symbol in word)
            {
                Console.Write(GetEscapeSequence(symbol).ToLower());
            }
            Console.WriteLine();
        }

        static string GetEscapeSequence(char c)
        {
            return "\\u" + ((int)c).ToString("X4");
        }
    }
}
