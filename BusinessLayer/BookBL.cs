using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TranferObject;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;
using static BusinessLayer.BookBL;

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
        public List<BorrowBook> GetBorrowBooks()
        {
            try
            {
                return bookDL.GetBorrowBooks();
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
                throw new Exception("Mã sách gồm 5 ký tự");
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
        public List<Book> GetNameBooks()
        {
            try
            {
                return bookDL.GetNameBooks();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        //public class GetMSSVBL
        //{
        //    private BookDL bookDL = new BookDL();

        //    public List<BorrowBook> GetBorrowBooksByMSSV(string mssv)
        //    {
        //        return bookDL.GetBorrowBooksByMSS(mssv);
        //    }
        //}
        public class GetMSSVAndIDBL
        {
            private BookDL bookDL = new BookDL();

            public List<BorrowBook> GetBorrowBooksByMSSAndIDV(int id,string mssv)
            {
                return bookDL.GetBorrowBooksByMSSAndIDV(id,mssv);
            }
        }
        public int AddBorrowBook(BorrowBook borrowBook)
        {
            
            try
            {
                return bookDL.AddStudentBorrowBook(borrowBook);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int UpdateBookReturn(BorrowBook borrowBook)
        {
            try
            {
                return bookDL.ReturnBook(borrowBook);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteReturnBook(BorrowBook borrowBook)
        {
            try
            {
                return bookDL.DeleteReturnBook(borrowBook);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}