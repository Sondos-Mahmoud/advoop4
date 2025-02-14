namespace advoop4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> bookList = new List<Book>
        {
            new Book("123-456-789", "Book1", new string[] { "Author1" }, new DateTime(2020, 1, 1), 29.99m),
            new Book("987-654-321", "Book2", new string[] { "Author2", "Author3" }, new DateTime(2021, 2, 2), 39.99m)
        };

            LibraryEngine.ProcessBooks(bookList, B => B.Title);
            LibraryEngine.ProcessBooks(bookList, B => string.Join(", ", B.Authors));
            LibraryEngine.ProcessBooks(bookList, delegate (Book B) { return B.ISBN; });
            LibraryEngine.ProcessBooks(bookList, B => B.PublicationDate.ToShortDateString());
        }
    }
    }
