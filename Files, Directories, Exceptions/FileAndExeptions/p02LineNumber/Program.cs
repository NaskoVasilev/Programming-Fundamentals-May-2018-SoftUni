using System;
using System.IO;

namespace p02LineNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("input.txt");
            string[] numericLines = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                numericLines[i] = $"{i + 1}. {lines[i]}";
            }

            File.WriteAllLines("output.txt", numericLines);
        }
    }
}
