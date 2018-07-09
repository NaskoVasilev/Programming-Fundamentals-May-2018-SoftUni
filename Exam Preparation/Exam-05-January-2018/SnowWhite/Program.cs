using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();

            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] tokens = input.Split(new string[] { " <:> " }
                , StringSplitOptions.None);
                string name = tokens[0];
                string hatColour = tokens[1];
                int physics = int.Parse(tokens[2]);

                List<Dwarf> currDwarfs = dwarfs.Where(x => x.Name == name).ToList();

                if (currDwarfs.Count == 0)
                {
                    Dwarf dwarf = new Dwarf(name, hatColour, physics);
                    dwarfs.Add(dwarf);
                }
                else
                {
                    Dwarf currDwarf = currDwarfs.FirstOrDefault(x => x.HatColour == hatColour);
                    if (currDwarf != null)
                    {
                        if (currDwarf.Physics < physics)
                        {
                            currDwarf.Physics = physics;
                        }
                    }
                    else
                    {
                        Dwarf dwarf = new Dwarf(name, hatColour, physics);
                        dwarfs.Add(dwarf);
                    }

                }
                input = Console.ReadLine();
            }

            foreach (Dwarf dwarf in dwarfs.OrderByDescending(x => x.Physics)
                .ThenByDescending(x => dwarfs.Count(h => h.HatColour == x.HatColour)))
            {
                Console.WriteLine($"({dwarf.HatColour}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }

        class Dwarf
        {
            public string Name { get; set; }
            public string HatColour { get; set; }
            public int Physics { get; set; }

            public Dwarf(string name, string hatColour, int physics)
            {
                this.Name = name;
                this.HatColour = hatColour;
                this.Physics = physics;
            }
        }
    }
}
