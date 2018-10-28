using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;
        public string Title
        {
            get => this.title;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                title = value;
            }
        }
        public string Author
        {
            get => this.author;
            set
            {
                var splitNames = value.Trim().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (splitNames.Length > 1 && char.IsDigit(splitNames[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                author = value;
            }
        }
        public virtual decimal Price
        {
            get => this.price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            this.Author = author;
            this.Title = title;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"Type: {this.GetType().Name}\n" +
                 $"Title: {this.Title}\n" +
                $"Author: {this.Author}\n" +
                $"Price: {this.Price:f2}";
        }
    }
}
