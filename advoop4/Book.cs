using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static advoop4.BookFunctions;

namespace advoop4
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(string _ISBN, string _Title, string[] _Authors, DateTime _PublicationDate, decimal _Price)
        {
            ISBN = _ISBN;
            Title = _Title;
            Authors = _Authors;
            PublicationDate = _PublicationDate;
            Price = _Price;
        }
        public override string ToString()
        {
            string authors = string.Join(", ", Authors);
            return $"ISBN: {ISBN}, Title: {Title}, Authors: {authors}, Publication Date: {PublicationDate.ToShortDateString()}, Price: {Price:C}";
        }
    }
    public class BookFunctions
    {
        //public delegate string BookFunctionDelegate(Book B);
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            return string.Join(", ", B.Authors);
        }

        public static string GetPrice(Book B)
        {
            return $"{B.Price:C}";
        }
    }
    //public class LibraryEngine
    //{
    //    public static void ProcessBooks(List<Book> blist, BookFunctionDelegate fPtr)
    //    {
    //        foreach (Book B in blist)
    //        {
    //            Console.WriteLine(fPtr(B));
    //        }
    //    }
    //}
    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> blist, Func<Book, string> fPtr)
        {
            foreach (Book B in blist)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }

}
