using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TranferObject;
using System.Data.SqlClient;
using System.Collections.Generic;
using System;

namespace BusinessLayer
{
    public class SeatBL
    {

        private SeatDL seatDL;
        public SeatBL()
        {
            seatDL = new SeatDL();
        }
        public List<Seat> GetSeats()
        {
            try
            {
                return seatDL.GetSeats();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int Update(Seat seat)
        {
            try
            {
                return seatDL.Update(seat);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
       
       
        public List<Seat> GetstatusSeats()
        {
            try
            {
                return seatDL.GetstatusSeats();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }

    }
}