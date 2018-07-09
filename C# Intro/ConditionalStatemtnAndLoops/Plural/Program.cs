using System;

namespace Plural
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if(word.EndsWith("y"))
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            }
            else if(word.EndsWith("s")||word.EndsWith("ch")|| word.EndsWith("o")|| word.EndsWith("sh")|| 
                word.EndsWith("z")|| word.EndsWith("x"))
            {
                word += "es";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
