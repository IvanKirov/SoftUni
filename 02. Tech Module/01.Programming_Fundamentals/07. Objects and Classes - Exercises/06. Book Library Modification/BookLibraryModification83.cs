using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.Book_Library_Modification
{
    public class BookLibraryModification
    {
        public static void Main()
        {
            var numberBooks = int.Parse(Console.ReadLine());

            var library = new Library();

            library.Books = new List<Book>();

            for (int i = 0; i < numberBooks; i++)
            {
                var inputBookInfo = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var title = inputBookInfo[0];
                var author = inputBookInfo[1];
                var date = DateTime.ParseExact(inputBookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                if (!library.Books.Any(a => a.Author == author))
                {
                    Book newBook = new Book();
                    newBook.Author = author;
                    newBook.Title = title;
                    newBook.Date = date;

                    library.Books.Add(newBook);
                }
                else
                {
                    Book newBook = new Book();
                    newBook.Title = title;
                    newBook.Date = date;

                    library.Books.Add(newBook);
                }
            }

            var afterDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (Book book in library.Books
                .FindAll(d => d.Date >= afterDate)
                .OrderBy(d => d.Date)
                .ThenBy(t => t.Title))
            {
                Console.WriteLine($"{book.Title} -> {book.Date:dd.MM.yyyy}");
            }
        }
    }
}
