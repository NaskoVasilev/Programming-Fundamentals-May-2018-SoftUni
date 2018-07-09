using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p06Books
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
            DateTime dateTime = DateTime.ParseExact(Console.ReadLine(),
                "dd.MM.yyyy", CultureInfo.InvariantCulture);

            books = books.Where(x => x.ReleaseDate > dateTime)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title)
                .ToArray();

            foreach (Book book in books)
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy") }");
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
            string[] info = input.Split();
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

