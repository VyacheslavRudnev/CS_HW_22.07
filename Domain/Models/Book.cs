using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearOfPublishing { get; set; }
        private string Genre { get; set; }
        private string Description { get; set; }

        public Book() { }
        public Book(string title, string author, int yearOfPublishing)
        {
            Title = title;
            Author = author;
            YearOfPublishing = yearOfPublishing;
        }
        public Book(string title, string author, int yearOfPublishing, string genre, string description)
        {
            Title = title;
            Author = author;
            YearOfPublishing = yearOfPublishing;
            Genre = genre;
            Description = description;
        }

        public override string ToString()
        {
            return $"Назва: {Title}\n Автор: {Author}\nРік публікації: {YearOfPublishing}\n";
        }

    }
}
