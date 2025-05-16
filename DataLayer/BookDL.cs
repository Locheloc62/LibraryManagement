using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranferObject;

namespace DataLayer
{
    public class BookDL : DataProvider
    {
        /*Book cac ham cho load tat ca cac sach co tren he thong len datagidview*/
        public List<Book> GetBooks()
        {
            int soluonghientai, soluong;
            string masach,tensach, tacGia, theloai, trangthai;
            List<Book> books = new List<Book>();
            string sql = "SELECT * FROM NewBook";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    masach =reader["masach"].ToString();
                    tensach = reader["tensach"].ToString();
                    tacGia = reader["tacgia"].ToString();
                    theloai = reader["theloai"].ToString();
                    soluonghientai = int.Parse(reader["soluonghientai"].ToString());
                    soluong = int.Parse(reader["soluong"].ToString());
                    trangthai = reader["trangthai"].ToString();

                    Book book = new Book(masach, tensach, tacGia, theloai, soluonghientai, soluong, trangthai);
                    books.Add(book);
                }
                reader.Close();
                return books;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        public int Add(Book book)
        {
            string sql = "uspAddBook"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@masach",   book.masach ));
            parameters.Add(new SqlParameter("@tensach", book.tensach));
            parameters.Add(new SqlParameter("@tacgia",  book.tacGia ));
            parameters.Add(new SqlParameter("@theloai", book.theloai));
            parameters.Add(new SqlParameter("@soluonghientai", book.soluong));
            parameters.Add(new SqlParameter("@soluong", book.soluong));
            parameters.Add(new SqlParameter("@trangthai", book.trangthai));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(Book book)
        {
            string sql = "uspDeleteBook"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@masach", book.masach));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(Book book)
        {
            string sql = "uspUpdateBook"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@masach",book.masach ));
            parameters.Add(new SqlParameter("@tensach", book.tensach));
            parameters.Add(new SqlParameter("@tacgia",  book.tacGia ));
            parameters.Add(new SqlParameter("@theloai", book.theloai));
            parameters.Add(new SqlParameter("@soluonghientai", book.soluonghientai));
            parameters.Add(new SqlParameter("@soluong", book.soluong));
            parameters.Add(new SqlParameter("@trangthai", book.trangthai));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        /*BorrowBook cac ham cho lop muon sach*/
        public List<BorrowBook> GetBorrowBooks()
        {
            int id, dienthoai;
            string hoten, mssv, coso, namhoc, email, tensach, ngaymuon, ngaytra;
            List<BorrowBook> borrowBooks = new List<BorrowBook>();
            string sql = "SELECT * FROM ISBook";
            try
            {
                    Connect();
                    SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                    while (reader.Read())
                    {
                        id = int.Parse(reader["id"].ToString());
                        mssv = reader["mssv"].ToString();
                        hoten = reader["hoten"].ToString();
                        tensach = reader["tensach"].ToString();
                        coso = reader["coso"].ToString();
                        namhoc = reader["namhoc"].ToString();
                        dienthoai = int.Parse(reader["dienthoai"].ToString());
                        email = reader["email"].ToString();
                        tensach = reader["tensach"].ToString();
                        ngaymuon = reader["ngaymuon"].ToString();
                        ngaytra = reader["ngaytra"].ToString();

                        BorrowBook borrowBook = new BorrowBook(id, hoten, mssv, coso, namhoc, dienthoai, email, tensach, ngaytra, ngaymuon);
                        borrowBooks.Add(borrowBook);
                    }
                    reader.Close();
                    return borrowBooks;
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    DisConnect();
                }
        }
        public List<Book> GetNameBooks()
        {

            string tensach,masach;
         
            List<Book> books = new List<Book>();
            string sql = "SELECT * FROM NewBook";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {

                    tensach = reader["tensach"].ToString();
                    masach = reader["masach"].ToString();

                    Book book = new Book(masach, tensach);
                    books.Add(book);
                }
                reader.Close();
                return books;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
        DataProvider dp=new DataProvider();
        public List<BorrowBook> GetBorrowBooksByMSSAndIDV(int id,string mssv)
        {
            List<BorrowBook> result = new List<BorrowBook>();
            string sql = "SELECT * FROM ISBook WHERE id = @id and mssv=@mssv";

            try
            {
                dp.Connect();
                SqlCommand cmd = new SqlCommand(sql, dp.Connection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@mssv", mssv);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  
                    string hoten = reader["hoten"].ToString();
                    string tensach = reader["tensach"].ToString();
                    string coso = reader["coso"].ToString();
                    string namhoc = reader["namhoc"].ToString();
                    int dienthoai = int.Parse(reader["dienthoai"].ToString());
                    string email = reader["email"].ToString();
                    string ngaymuon = reader["ngaymuon"].ToString();
                    string ngaytra = reader["ngaytra"].ToString();

                    BorrowBook bb = new BorrowBook(id, hoten, mssv, coso, namhoc, dienthoai, email, tensach, ngaytra, ngaymuon);
                    result.Add(bb);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
               dp.DisConnect();
            }

            return result;
        }
       
        public int AddStudentBorrowBook(BorrowBook borrowBook)
        {
            string sql = "uspAddStudentBorrowBook"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@mssv", borrowBook.mssv));
            parameters.Add(new SqlParameter("@hoten", borrowBook.hoten));
            parameters.Add(new SqlParameter("@coso", borrowBook.coso));
            parameters.Add(new SqlParameter("@namhoc", borrowBook.namhoc));
            parameters.Add(new SqlParameter("@dienthoai", borrowBook.dienthoai));
            parameters.Add(new SqlParameter("@email", borrowBook.email));
            parameters.Add(new SqlParameter("@tensach", borrowBook.tensach));
            parameters.Add(new SqlParameter("@ngaymuon", borrowBook.ngaymuon));
        
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        /*ReturnBook cac ham cho lop tra sach*/
        public int ReturnBook(BorrowBook borrowBook)
        {
            string sql = "uspUpdateReturnBook"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
          
            parameters.Add(new SqlParameter("@id", borrowBook.id));
            parameters.Add(new SqlParameter("@mssv", borrowBook.mssv));
            parameters.Add(new SqlParameter("@ngaytra", borrowBook.ngaytra));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int DeleteReturnBook(BorrowBook borrowBook)
        {
            string sql = "uspDeleteReturnBook"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", borrowBook.id));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}