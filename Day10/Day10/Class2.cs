using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day10
{
    class Book
    {
        public string Title;
        public string Author;
        public string Publisher;
        public DateTime ReleaseDate;
        public string ISBNnumber;

    }
    class Library
    {
        public string Name;
        public List<Book> Books = new List<Book>();
        public void AddBook(string title, string author, string publisher, DateTime releaseDate, string iSBNnumber)
        {
            Book newBook = new Book
            {
                Author = author,
                Title = title,
                ISBNnumber = iSBNnumber,
                Publisher = publisher,
                ReleaseDate = releaseDate
            };
            Books.Add(newBook);
        }
        public void DisplayBookInfo(Book book)
        {
            Console.WriteLine($"Title-{book.Title}, Author-{book.Author}, ISBNnumber-{book.ISBNnumber}");
        }
        public void DeleteBook(Book book)
        {
            Books.Remove(book);
        }
        public List<Book> SearchBook()
        {
            var authorName = "Stephen King";
            return Books.Where(x => x.Author == authorName).ToList();

        }
    }
    class Class2
    {
        static void Main(string[] args)
        {
            Library library = new Library();//Create Library object  
            library.AddBook("CSharp Programming", "Stephen King", "Pub1", DateTime.Now, "ISBN001"); //Add book 1  
            library.AddBook("Java Programming", "Avnish", "Pub1", DateTime.Now, "ISBN002"); //Add book 2  
            library.AddBook("Php Programming", "Avnish", "Pub1", DateTime.Now, "ISBN003"); //Add book 3  
            library.AddBook("Ml Programming", "Stephen King", "Pub1", DateTime.Now, "ISBN004"); //Add book 4  
            Console.WriteLine("Total books in Library");
            if (library.Books.Count > 0)
            {
                foreach (var book in library.Books)
                {
                    library.DisplayBookInfo(book);// display all books  
                }

                Console.WriteLine("Search for all books authored by Stephen King");
                var seachedBooks = library.SearchBook();
                Console.WriteLine(seachedBooks.Count + " books found and deleted");
                foreach (var book in seachedBooks)
                {
                    library.DeleteBook(book);// delete books  
                }
                Console.WriteLine("Remaining books in Library");
                foreach (var book in library.Books)
                {
                    library.DisplayBookInfo(book);// display all books  
                }
            }
            Console.ReadKey();
        }
    }
}
