using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TranferObject;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class StudentBL
    {
        private StudentDL studentDL;
        public StudentBL()
        {
            studentDL = new StudentDL();
        }
        public List<Student> GetStudents()
        {
            try
            {
                return studentDL.GetStudents();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public int Add(Student student)
        {
            if (student.mssv.Length != 10)
            {
                throw new Exception("Mã số sinh viên phải 10 ký tự");
            }
            try
            {
                return studentDL.Add(student);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Delete(Student student)
        {
            try
            {
                return studentDL.Delete(student);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int Update(Student student)
        {
            try
            {
                return studentDL.Update(student);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public class GetMSSVBL
        {
            private StudentDL studentDL = new StudentDL();

            public List<Student> GetStudentByMSS(string mssv)
            {
                return studentDL.GetStudentByMSS(mssv);
            }
        }
    }
}
