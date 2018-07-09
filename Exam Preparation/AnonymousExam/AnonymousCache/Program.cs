using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonymousCache
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> database = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "thetinggoesskrra")
                {
                    break;
                }

                string[] tokens = input
                    .Split(new char[] { '-', '>', ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length == 1)
                {
                    string dataSet = tokens[0];
                    
                    if (cache.ContainsKey(dataSet))
                    {
                        database[dataSet] = new Dictionary<string, long>(cache[dataSet]);
                        cache.Remove(dataSet);
                    }
                    else
                    {
                        database.Add(dataSet, new Dictionary<string, long>());
                    }
                }
                else
                {
                    string dataSet = tokens[2];
                    string dataKey = tokens[0];
                    long size = long.Parse(tokens[1]);
                    if (database.ContainsKey(dataSet))
                    {
                        if (database[dataSet].ContainsKey(dataKey) == false)
                        {
                            database[dataSet].Add(dataKey, size);
                        }
                        else
                        {
                            database[dataSet][dataKey] += size;
                        }
                    }
                    else
                    {
                        if (cache.ContainsKey(dataSet) == false)
                        {
                            Dictionary<string, long> currCache = new Dictionary<string, long>();
                            currCache.Add(dataKey, size);
                            cache.Add(dataSet, currCache);
                        }
                        else
                        {
                            if (cache[dataSet].ContainsKey(dataKey) == false)
                            {
                                cache[dataSet].Add(dataKey, size);
                            }
                            else
                            {
                                cache[dataSet][dataKey] += size;
                            }
                        }
                    }

                }
            }

            if (database.Count > 0)
            {
                KeyValuePair<string, Dictionary<string, long>> result = database
                    .OrderByDescending(x=>x.Value.Values.Sum()) 
                    .First();
                Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Values.Sum()}");
                foreach (var pair in result.Value)
                {
                    Console.WriteLine($"$.{pair.Key}");
                }
            }
        }
    }
}
