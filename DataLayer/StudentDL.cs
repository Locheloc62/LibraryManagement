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
            int dienthoai,id;
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
        public int Add(Student student)
        {
            string sql = "uspAddStudent"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@hoten", student.hoten));
            parameters.Add(new SqlParameter("@mssv", student.mssv));
            parameters.Add(new SqlParameter("@coso",  student.coso));
            parameters.Add(new SqlParameter("@namhoc", student.namhoc));
            parameters.Add(new SqlParameter("@dienthoai", student.dienthoai));
            parameters.Add(new SqlParameter("@email", student.email));

            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(Student student)
        {
            string sql = "uspDeleteStudent"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@mssv", student.mssv));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(Student student)
        {
            string sql = "uspUpdateStudent"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@hoten", student.hoten));
            parameters.Add(new SqlParameter("@mssv", student.mssv));
            parameters.Add(new SqlParameter("@coso", student.coso));
            parameters.Add(new SqlParameter("@namhoc", student.namhoc));
            parameters.Add(new SqlParameter("@dienthoai", student.dienthoai));
            parameters.Add(new SqlParameter("@email", student.email));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        DataProvider dp = new DataProvider();
        public List<Student> GetStudentByMSS(string mssv)
        {
            List<Student> result = new List<Student>();
            string sql = "SELECT * FROM NewStudent WHERE  mssv=@mssv";

            try
            {
                dp.Connect();
                SqlCommand cmd = new SqlCommand(sql, dp.Connection);

                cmd.Parameters.AddWithValue("@mssv", mssv);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    string hoten = reader["hoten"].ToString();
                    string coso = reader["coso"].ToString();
                    string namhoc = reader["namhoc"].ToString();
                    int dienthoai = int.Parse(reader["dienthoai"].ToString());
                    string email = reader["email"].ToString();
                   

                    Student bb = new Student(hoten, mssv, coso, namhoc, dienthoai, email);
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

    }
}
