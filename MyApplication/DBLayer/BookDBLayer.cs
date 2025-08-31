using AjaxControlToolkit.HtmlEditor.ToolbarButtons;
using MyApplication.ObjectDB;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyApplication
{
    public class BookDBLayer
    {
        private static readonly string con = ConfigurationManager.ConnectionStrings["BookDB"].ConnectionString;

        public static List<Book> GetAllBooks()
         {
            var books = new List<Book>();
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM BookApp", connection))
                {
                   
                    connection.Open();
                    var result = sqlCommand.ExecuteReader();
                    while (result.Read())
                    {
                        var book = new Book();
                        book.BookId = (int)result["BookID"];
                        book.BookName = result["BookTitle"].ToString();
                        book.Price = (decimal)result["Price"];
                        book.BookDescription= result["BookDEscerption"].ToString();
                        books.Add(book);
                    }

                  
                }
            }
            return books;
        }
        public static bool AddBook(Book book)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(con))
            {

                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO BookApp values(@bookTitle,@price,@Descreption) ", connection))
                {
                    sqlCommand.Parameters.AddWithValue("bookTitle", book.BookName);
                    sqlCommand.Parameters.AddWithValue("price", book.Price);
                    sqlCommand.Parameters.AddWithValue("Descreption", book.BookDescription);
                    connection.Open();
                    result = sqlCommand.ExecuteNonQuery();
                }
            }
           return result>0;
        }
        public static bool DeleteBook(int bookId)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(con))
            {

                using (SqlCommand sqlCommand = new SqlCommand("DELETE FROM BookApp  WHERE BookID=@id ", connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id",bookId);
                  
                    connection.Open();
                    result = sqlCommand.ExecuteNonQuery();
                }
            }
            return result > 0;
        }
        public static bool UpdateBook(Book book)
        {
            int result;
            using (SqlConnection connection = new SqlConnection(con))
            {

                using (SqlCommand sqlCommand = new SqlCommand("UPDATE BookApp  Set BookTitle=@bookTitle ,Price=@price ,BookDEscerption=@Descreption WHERE BookID=@id ", connection))
                {
                    sqlCommand.Parameters.AddWithValue("@bookTitle", book.BookName);
                    sqlCommand.Parameters.AddWithValue("@id", book.BookId);
                    sqlCommand.Parameters.AddWithValue("@price", book.Price);
                    sqlCommand.Parameters.AddWithValue("@Descreption", book.BookDescription);
                    connection.Open();
                    result = sqlCommand.ExecuteNonQuery();
                }
            }
            return result > 0;
        }
        public static Book GetBookById(int bookId)
        {
            Book result;
            using (SqlConnection connection = new SqlConnection(con))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM BookApp WHERE BookID=@id ", connection))
                {
                    sqlCommand.Parameters.AddWithValue("@id", bookId);

                    connection.Open();
                    result = (Book)sqlCommand.ExecuteScalar();
                }
            }
            return result;
        }
    }
}