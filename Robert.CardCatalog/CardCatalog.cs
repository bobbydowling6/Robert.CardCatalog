using System;
using System.Collections.Generic;

namespace Robert.CardCatalog
{
    public class CardCatalog
    {
        public CardCatalog(string fileName)
        {
            _fileName = fileName;
        }

        private string _fileName;

        private List<Book> books;
    }
}
