using System;

namespace p02RandomWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int index = rnd.Next(words.Length);
                string temp = words[i];
                words[i] = words[index];
                words[index] = temp;
            }
            Console.WriteLine(string.Join(Environment.NewLine,words));
        }
    }
}
