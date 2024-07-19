using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;
using static task_6.Program;

namespace task_6
{
    internal class Program
    {
        public delegate string fPtr(Book b);
        static void Main(string[] args)
        {
            List<Book> mylist = new List<Book>() { new Book("978-3-16-148410-0", "Arabic", new string[] { "ahmed", "saleh" }, DateTime.Parse("7/18/2024 02:00:00 PM"), 200),
                                                   new Book("974-3-17-145410-0", "English", new string[] { "omnia", "mohamed" }, DateTime.Parse("7/19/2024 02:20:00 PM"), 300)
                                                 };
            Console.WriteLine("\nProcessing books with Anonymous method Delegate show ISBN:");
            LibraryEngine.ProcessBooksAnonymous(mylist);
            Console.WriteLine("\nProcessing books with Lambda expression Delegate show title:");
            LibraryEngine.ProcessBooksLambda(mylist, b => b.Title);
            Console.WriteLine("\nProcessing books with BCL Delegate show datetime:");
            LibraryEngine.ProcessBooksBCL(mylist);
        }
        public class Book
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string[] Authors { get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }
            public Book(string _ISBN, string _Title,
            string[] _Authors, DateTime _PublicationDate,
           decimal _Price)
            {
               this.ISBN = _ISBN;
               this.Title = _Title;
               this.Authors = _Authors;
               this.PublicationDate = _PublicationDate;
               this.Price = _Price;
            }
            public override string ToString()
            {
                return $"ISBN: {ISBN}\n" +
                $"Title: {Title}\n" +
               $"Authors: {string.Join(", ", Authors)}\n" +
               $"Publication Date: {PublicationDate.ToShortDateString()}\n" +
               $"Price: {Price:C}\n";
            }
        }
        public class BookFunctions
        {
            public static string GetISBN(Book B)
            {
                return B.ISBN;
            }
            public static string GetTitle(Book B)
            {
                return B.Title;
            }
            public static string GetAuthors(Book B)
            {
                return string.Join(", ", B.Authors);
            }
            public static decimal GetPrice(Book B)
            {
                return B.Price;
            }
        }
        public class LibraryEngine
        {
            public static void ProcessBooksLambda(List<Book> bList, fPtr del)
            {
                foreach (Book b in bList)
                {
                    Console.WriteLine(del(b));
                }
            }

            public static void ProcessBooksAnonymous(List<Book> bList)
            {
             fPtr del = delegate (Book b)
                 {
                     return(BookFunctions.GetISBN(b));
                     
                 };
                foreach (Book b in bList)
                {
                    Console.WriteLine(del(b));
                }
            }
    
            public static void ProcessBooksBCL(List<Book> bList)
            {
                DateTime fun(Book b) => b.PublicationDate;
                Func<Book, DateTime> del = fun;


                foreach (Book b in bList)
                {
                    Console.WriteLine(del(b));
                }
            }
        }

    }
}
