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

        }

        //TODO: Correct return type and parameters
        public void AddBook()
        {

        }

        //TODO: Correct return type and parameters
        public void Save()
        {

        }
    }
}
