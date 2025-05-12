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

    }
}
