using System;

namespace p03TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(new char[]{' ',','}
            ,StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var word in words)
            {
                if(text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }

    }
}
