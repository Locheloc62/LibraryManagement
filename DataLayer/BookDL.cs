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

    }
}