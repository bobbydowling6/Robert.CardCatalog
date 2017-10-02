using System;
using System.Collections.Generic;

namespace Robert.CardCatalog
{
    public class CardCatalog
    {
        public CardCatalog(string fileName)
        {
            _fileName = fileName;
            books = new List<Book>();
        }

        private string _fileName;

        private List<Book> books;

        //TODO: Correct return type and parameters
        public void ListBooks()
        {
            foreach(var b in books)
            {
                Console.WriteLine(b.Title);
            }

        }

        //TODO: Correct return type and parameters
        public void AddBook(string title, string author, string genre)
        {
            Book newBook = new Book
            {
                Title = title,
                Author = author,
                Genre = genre
            };

            books.Add(newBook);
        }

        //TODO: Correct return type and parameters
        public void Save()
        {

        }
    }
}
