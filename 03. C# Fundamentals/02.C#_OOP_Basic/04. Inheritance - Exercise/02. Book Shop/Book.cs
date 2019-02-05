using System;
using System.Linq;
using System.Text;

namespace Book_Shop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string author, string title, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public virtual decimal Price
        {
            get => price;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public string Author
        {
            get => author;
            private set
            {
                string secondName = value.Split(' ').Last();
                if (char.IsDigit(secondName[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }

        public string Title
        {
            get => title;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }

        public override string ToString()
        {
            var bookInfo = new StringBuilder();
            bookInfo.AppendLine($"Type: {this.GetType().Name}");
            bookInfo.AppendLine($"Title: {this.Title}");
            bookInfo.AppendLine($"Author: {this.Author}");
            bookInfo.Append($"Price: {this.Price:F2}");

            return bookInfo.ToString();
            //return $"Type: {this.GetType().Name}{Environment.NewLine}" +
            //       $"Title: {this.Title}{Environment.NewLine}" +
            //       $"Author: {this.Author}{Environment.NewLine}" +
            //       $"Price: {this.Price:F2}{Environment.NewLine}";
        }
    }
}
