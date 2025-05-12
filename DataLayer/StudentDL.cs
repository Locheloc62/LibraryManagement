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
    public class StudentDL : DataProvider
    {
        public List<Student> GetStudents()
        {
            string name, mssv, coso, namhoc, email;
            int dienthoai;
            List<Student> students = new List<Student>();
            string sql = "SELECT * FROM NewStudent";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    name = reader["hoten"].ToString();
                    mssv = reader["mssv"].ToString();
                    coso = reader["coso"].ToString();
                    namhoc = reader["namhoc"].ToString();
                    dienthoai = int.Parse(reader["dienthoai"].ToString());
                    email = reader["email"].ToString();
                    Student student = new Student(name, mssv, coso, namhoc, dienthoai, email);
                    students.Add(student);
                }
                reader.Close();
                return students;
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
