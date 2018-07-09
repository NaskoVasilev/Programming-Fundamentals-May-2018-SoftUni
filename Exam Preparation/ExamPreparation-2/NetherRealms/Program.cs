using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new char[] { ',', ' ' }
            , StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, Dragon> dragons = new SortedDictionary<string, Dragon>();

            foreach (string  name in names)
            {
                int health = GetHealth(name);
                double damage = GetDamage(name);
                Dragon dragon = new Dragon(health, damage);
                dragons.Add(name, dragon);
            }

            foreach (var pair in dragons)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value.Health} health, {pair.Value.Damage:f2} damage");
            }

        }

        private static double GetDamage(string name)
        {
            double damage = 0;
            Regex regex = new Regex(@"(-)?\d+(\.\d+)?");
            MatchCollection matches = regex.Matches(name);

            foreach (Match match in matches)
            {
                damage += double.Parse(match.Value);
            }

            MatchCollection multiplyOrDivide = Regex.Matches(name, @"[*\/]");

            foreach (Match symbol in multiplyOrDivide)
            {
                if(symbol.Value=="/")
                {
                    damage /= 2;
                }
                else if(symbol.Value=="*")
                {
                    damage *= 2;
                }
            }
            return damage;
        }

        private static int GetHealth(string name)
        {
            Regex regex = new Regex(@"[^0-9+\-*\/.]");
            int health = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if(regex.IsMatch(name[i].ToString()))
                {
                    health += name[i];
                }
            }

            return health;
        }

        class Dragon
        {
            public Dragon(int health, double damage)
            {
                Health = health;
                Damage = damage;
            }

            public int Health { get; set; }
            public double Damage { get; set; }
        }
    }
}
