using MyApplication.ObjectDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyApplication.ServicerLayer
{
    public class BookServiceLayer
    {
        public static List<Book> GetAllBooks()
        {

            return BookDBLayer.GetAllBooks();
        }
        public static bool AddBook(Book book)
        {

            return BookDBLayer.AddBook(book);
        }
        public static bool DeletBook(int bookid)
        {

            return BookDBLayer.DeleteBook(bookid);
        }
        public static bool UpdateBook(Book book)
        {

            return BookDBLayer.UpdateBook(book);
        }
        public static Book GetBookById(int bookid)
        {

            return BookDBLayer.GetBookById(bookid);
        }

    }
}