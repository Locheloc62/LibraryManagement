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
    public class DataProvider
    {
        //Biến toàn cục cùa lớp sqlconnection 
        private SqlConnection cn;
        public SqlConnection Connection => cn;
        //Cung cấp đường dẫn đến cơ sở dữ liệu
        //Tạo 1 hàm cung cấp dữ liệu từ databse là dataprovider cho hàm này public 
        public DataProvider()
        {
            string cnstr = @"Data Source=LAPTOP_ACER;Initial Catalog=LibraryManagement;Integrated Security=True;Encrypt=False";
            cn = new SqlConnection(cnstr);

        }
        //Hàm kết nối
        //Dùng khối try catch để quăng lên cho giao diện xử lý
        public void Connect()
        {
            try
            {
                // Nếu mà kết nối đang ở trạng thấy đóng hoặc thì mở kết nối lên    
                if (cn != null && cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //Hàm ngắt kết nối
        public void DisConnect()
        {
            try
            {
                //Nếu mà kết nối đang ở trạng thái mở thì đóng kết nối lại  
                if (cn != null && cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        //private bool Login(string user,string pass)
        //{
        //    string sql = "SELECT COUNT()";
        //    SqlCommand cmd = new SqlCommand();
        //    cmd.ExecuteScalar();
        //}        
        public object MyExcuteScalar(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;

                // Thêm các tham số vào SqlCommand
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter); // Thêm tham số vào danh sách tham số của SqlCommand
                    }
                }

                return cmd.ExecuteScalar(); // Thực thi câu lệnh và trả về kết quả
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
        public SqlDataReader MyExecuteReader(string sql, CommandType type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        //INSERT, DELETE, UPDATE
        //Truyền theo kiểu query thì mình cho List<Parameter>=null, rồi sau đó mình đưa cái foreach vào if cái List đó khác null mới hợp lý
        public int MyExecuteNonQuery(string sql, CommandType type, List<SqlParameter> parameters = null)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandType = type;
                if (parameters != null)
                {
                    foreach (var parameter in parameters)
                    {
                        cmd.Parameters.Add(parameter);
                    }
                }
                return cmd.ExecuteNonQuery();
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
