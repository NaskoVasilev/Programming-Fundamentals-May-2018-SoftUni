using System;

namespace p02AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.", "Such a great product."
                , "I always use that product."
                , "Best product of its category.", "Exceptional product."
                , "I can’t live without this product."
            };

            string[] events =
                {

                    "Now I feel good.", "I have succeeded with this product."
                    , "Makes miracles. I am happy of the results!"
                    , "I cannot believe but now I feel awesome."
                        , "Try it yourself, I am very satisfied."
                       , "I feel great!"
            };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] towns = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            int numberOfMessage = int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < numberOfMessage; i++)
            {
                int index1 = random.Next(phrases.Length);
                int index2 = random.Next(events.Length);
                int index3 = random.Next(authors.Length);
                int index4 = random.Next(towns.Length);

                Console.WriteLine($"{phrases[index1]} {events[index2]} {authors[index3]} - {towns[index4]}");
            }
        }
    }
}
