using System;
using System.Collections.Generic;
using System.Linq;

namespace p04Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words=Console.ReadLine().Split(new char[] {' ',',','!','.','?' },
                StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach (var word in words)
            {
                bool isPalindreme;
                isPalindreme = IsPalindreme(word);
                if(isPalindreme)
                {
                    palindromes.Add(word);
                }
            }
            palindromes = palindromes.OrderBy(x => x).Distinct().ToList();
            Console.WriteLine(string.Join(", ",palindromes));
        }

        private static bool IsPalindreme(string word)
        {
            for (int i = 0; i < word.Length/2; i++)
            {
                if(word[i]!=word[word.Length-i-1])
                {
                    return false;
                }
            }

            return true;
           
        }
    }
}
