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
        public int Delete(Student student)
        {
            string sql = "uspDeleteSupplier"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@id", student.));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(Supplier supplier)
        {
            string sql = "uspUpdateSupplier"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter> {
            //parameters.Add(new SqlParameter("@id", supplier.Id));
            //parameters.Add(new SqlParameter("@name", supplier.Name));
            //parameters.Add(new SqlParameter("@address", supplier.Address));
            new SqlParameter("@id", supplier.Id),
            new SqlParameter("name",supplier.Name),
            new SqlParameter("address",supplier.Address)
            };
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
