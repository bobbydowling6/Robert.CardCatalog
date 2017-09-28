using System;

namespace Robert.CardCatalog
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of a file");
            string fileName = Console.ReadLine();
            CardCatalog cc = new CardCatalog(fileName);
            string title = null;
            while (title != "")
            {
                Console.WriteLine("Enter the title of a Book");
                title = Console.ReadLine();

                Console.WriteLine("Enter the author of a Book");
                string author = Console.ReadLine();

                Console.WriteLine("Enter the genre of a Book");
                string genre = Console.ReadLine();

                cc.AddBook(title, author, genre);
            }

            Console.ReadLine();
        }
    }
}
