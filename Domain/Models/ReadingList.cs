using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ReadingList
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            books.Remove(book);
        }

        public bool ContainsBook(Book book)
        {
            return books.Contains(book);
        }
        public Book FindBookByTitle(string title)
        {
            return books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
        public bool ContainsBookByTitle(string title)
        {
            return books.Any(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }
        public Book this[int index]
        {
            get { return books[index]; }
        }

        public int Count
        {
            get { return books.Count; }
        }

    }
}
