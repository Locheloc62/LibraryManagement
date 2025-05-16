using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TranferObject;
using DataLayer;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class statusBL
    {
        private StatusDL statusDL;
        public statusBL()
        {
            statusDL = new StatusDL();
        }
        public List<Status> GetStatuses()
        {
            try
            {
                return statusDL.GetStatusBooks();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
   

}
