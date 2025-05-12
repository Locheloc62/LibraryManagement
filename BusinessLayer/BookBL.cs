using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TranferObject;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace BusinessLayer
{
    public class BookBL
    {
        private BookDL bookDL;
        public BookBL()
        {
            bookDL = new BookDL();
        }
        public List<Book> GetBooks()
        {
            try
            {
                return bookDL.GetBooks();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Add(Book book)
        {
            if (book.masach.Length != 5)
            {
                throw new Exception("Id of supplier must be 5 character");
            }
            try
            {
                return bookDL.Add(book);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(Book book)
        {
            try
            {
                return bookDL.Delete(book);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(Book book)
        {
            try
            {
                return bookDL.Update(book);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}