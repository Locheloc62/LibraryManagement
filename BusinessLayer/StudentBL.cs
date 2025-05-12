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
    }
}
