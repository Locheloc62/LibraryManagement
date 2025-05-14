using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TranferObject;

namespace BusinessLayer
{
    public class ReturnBookBL
    {
            private ReturnBookDL returnBookDL;
            public ReturnBookBL()
            {
            returnBookDL = new ReturnBookDL();
            }
            public List<ReturnBook> GetReturnBooks()
            {
                try
                {
                    return returnBookDL.GetReturnBooks();
                }
                catch (SqlException ex)
                {

                    throw ex;
                }
            }
    }
}
