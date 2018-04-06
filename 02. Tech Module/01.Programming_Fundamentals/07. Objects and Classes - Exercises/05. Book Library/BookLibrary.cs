using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Book_Library
{
    public class BookLibrary
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
                decimal price = decimal.Parse(inputBookInfo[5]);

                if (!library.Books.Any(a => a.Author == author))
                {
                    Book newBook = new Book();
                    newBook.Author = author;
                    newBook.Price = price;

                    library.Books.Add(newBook);
                }
                else
                {
                    Book notNewAuthor = library.Books.First(a => a.Author == author);
                    notNewAuthor.Price += price;
                }
            }

            foreach (Book book in library.Books
                .OrderByDescending(p => p.Price)
                .ThenBy(a => a.Author))
            {
                Console.WriteLine($"{book.Author} -> {book.Price:f2}");
            }
        }
    }
}
