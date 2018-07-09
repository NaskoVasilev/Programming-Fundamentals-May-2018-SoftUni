using System;

namespace p15NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int GoshoDamage = int.Parse(Console.ReadLine());
            int PeshoDamage = int.Parse(Console.ReadLine());
            int count = 0;
            int initialDamageGosho = 100;
            int initialDamagePesho = 100;
            while(true)
            {
                count++;
                if(count%2==0)
                {
                    initialDamagePesho -= PeshoDamage;
                    if(initialDamagePesho<=0)
                    {
                        Console.WriteLine("Gosho won in {0}th round.", count);
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {initialDamagePesho} health.");
                }
                else if(count%2==1)
                {
                    initialDamageGosho -= GoshoDamage;
                    if(initialDamageGosho<=0)
                    {
                        Console.WriteLine("Pesho won in {0}th round.", count);
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {initialDamageGosho} health.");
                }
                if (count%3==0)
                {
                    initialDamageGosho += 10;
                    initialDamagePesho += 10;
                }     
            }
        }
    }
}
