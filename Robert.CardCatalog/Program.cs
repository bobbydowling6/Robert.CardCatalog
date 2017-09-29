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
            string choice = "";

            //TODO: work on the Menu
            do
            {
                Console.WriteLine("1. List All books");
                Console.WriteLine("2. Add A Book");
                Console.WriteLine("3. Save and Exit");
                choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":

                        cc.ListBooks();
                        break;
                    case "2":
                        {
							Console.WriteLine("Enter the title of a Book");
							string title = Console.ReadLine();

							Console.WriteLine("Enter the author of a Book");
							string author = Console.ReadLine();

							Console.WriteLine("Enter the genre of a Book");
							string genre = Console.ReadLine();

							cc.AddBook(title, author, genre);
                            break;
                        }
                    case "3":
                        cc.Save();
                        break;
                }

            } while (choice != "3");
            return;

        }
    }
}
