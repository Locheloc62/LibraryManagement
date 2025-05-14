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
    public class StatusDL:DataProvider
    {
        public List<Status> GetStatusBooks()
        {

            string trangthai;
            int id;
            List<Status> books = new List<Status>();
            string sql = "SELECT * FROM status";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {

                    trangthai = reader["trangthai"].ToString();
                    id = int.Parse(reader["id"].ToString());

                    Status book = new Status(id,trangthai);
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
      
    }
}
