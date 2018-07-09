using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p05Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            Book[] books = new Book[numberOfBooks];

            for (int i = 0; i < numberOfBooks; i++)
            {
                string info = Console.ReadLine();
                books[i] = ReadBook(info);
            }

            Dictionary<string, double> authors = new Dictionary<string, double>();

            foreach (var book in books)
            {
                if(authors.ContainsKey(book.Author)==false)
                {
                    authors.Add(book.Author, 0.0);
                }
                authors[book.Author] += book.Price;
            }

            foreach (var pair in authors.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBNNumber { get; set; }
            public double Price { get; set; }
        }

        static Book ReadBook(string input)
        {
            Book book = new Book();
            string []info = input.Split();
            book.Title = info[0];
            book.Author = info[1];
            book.Publisher = info[2];
            book.ReleaseDate = DateTime.ParseExact(info[3],
                "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBNNumber = info[4];
            book.Price = double.Parse(info[5]);
            return book;
        }
    }
}
