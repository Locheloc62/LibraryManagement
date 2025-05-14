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
    public class LoginDL:DataProvider
    {
        public bool Login(Account account)
        {
            string sql = "SELECT COUNT(username) FROM LoginTable WHERE username ='" + account.username + "' and password ='" + account.password + "'";
            try
            {
                return (int)MyExcuteScalar(sql, CommandType.Text) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int AddLogin(Account account)
        {
            string sql = "uspAddAccount"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@username", account.username));
            parameters.Add(new SqlParameter("@password", account.password));
            parameters.Add(new SqlParameter("@role", account.role));
            parameters.Add(new SqlParameter("@hoten", account.hoten));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool CheckUsernameExists(string username)
        {
            string sql = "SELECT COUNT(*) FROM LoginTable WHERE username = @username"; // Câu lệnh SQL kiểm tra sự tồn tại của username
            List<SqlParameter> parameters = new List<SqlParameter>
    {
        new SqlParameter("@username", SqlDbType.NVarChar) { Value = username } // Thêm tham số username vào câu lệnh
    };

            // Gọi phương thức MyExecuteScalar từ DataProvider để thực hiện truy vấn
            object result = MyExcuteScalar(sql, CommandType.Text, parameters);

            // Kiểm tra kết quả trả về (result) nếu không phải null và ép kiểu thành int
            if (result != null && result != DBNull.Value)
            {
                int count = Convert.ToInt32(result);
                return count > 0; // Nếu count > 0, nghĩa là username đã tồn tại trong cơ sở dữ liệu
            }

            return false; // Nếu không có kết quả hoặc count = 0, tài khoản không tồn tại
        }



    }
}
