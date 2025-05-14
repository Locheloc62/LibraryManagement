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
    public class ReturnBookDL:DataProvider
    {
        public List<ReturnBook> GetReturnBooks()
        {

            string trangthai;
            int id;
            List<ReturnBook> returnBooks = new List<ReturnBook>();
            string sql = "SELECT * FROM ReturnBook";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    id = int.Parse(reader["id"].ToString());
                    trangthai = reader["trangthai"].ToString();


                    ReturnBook returnBook = new ReturnBook(id, trangthai);
                    returnBooks.Add(returnBook);
                }
                reader.Close();
                return returnBooks;
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
    }
}
