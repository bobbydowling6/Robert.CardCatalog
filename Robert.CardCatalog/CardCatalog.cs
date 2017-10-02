using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace Robert.CardCatalog
{
    public class CardCatalog
    {
        public CardCatalog(string fileName)
        {
            _fileName = fileName;

            //TODO: If the file you've added exists, deserialize it and put that data in your books variable

            if (File.Exists(fileName))
            {
				// Open the file containing the data that you want to deserialize.
                FileStream fs = new FileStream(_fileName, FileMode.Open);
				try
				{
					BinaryFormatter formatter = new BinaryFormatter();

                    // Deserialize the hashtable from the file and 
                    // assign the reference to the local variable.
                    books = (List<Book>) formatter.Deserialize(fs);
				}
				catch (SerializationException e)
				{
					Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
					throw;
				}
				finally
				{
					fs.Close();
				}

			}
            else
            {
				books = new List<Book>();
            }
        }

        private string _fileName;

        private List<Book> books;

        //TODO: Correct return type and parameters
        public void ListBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine(book.Title);
                //Console.WriteLine(book.Author);
                //Console.WriteLine(book.Genre);
            }


        }

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
            FileStream fs = new FileStream(_fileName, FileMode.Create);

			// Construct a BinaryFormatter and use it to serialize the data to the stream.
			BinaryFormatter formatter = new BinaryFormatter();
			try
			{
                formatter.Serialize(fs, books);
			}
			catch (SerializationException e)
			{
				Console.WriteLine("Failed to serialize. Reason: " + e.Message);
				throw;
			}
			finally
			{
				fs.Close();
			}
        }

    }
}
