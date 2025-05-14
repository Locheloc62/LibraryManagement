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
    public class SeatDL : DataProvider
    {
        public List<Seat> GetSeats()
        {
            string maSo, khuVuc, loai, trangThai;
            List<Seat> seats = new List<Seat>();
            string sql = "SELECT * FROM Seat";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {
                    maSo = reader["maso"].ToString();
                    khuVuc = reader["khuvuc"].ToString();
                    loai = reader["loai"].ToString();
                    trangThai = reader["trangthai"].ToString();

                    Seat seat = new Seat(maSo, khuVuc, loai, trangThai);
                    seats.Add(seat);
                }
                reader.Close();
                return seats;
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
        public int Update(Seat seat)
        {
            string sql = "uspUpdateSeat"; //(1)
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@maso", seat.maSo));
            parameters.Add(new SqlParameter("@khuvuc", seat.khuVuc));
            parameters.Add(new SqlParameter("@loai", seat.loai));
            parameters.Add(new SqlParameter("@trangthai", seat.trangThai));
            try
            {
                return MyExecuteNonQuery(sql, CommandType.StoredProcedure, parameters); //(2)
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public List<Seat> GetstatusSeats()
        {

            string maso, khuvuc,loai,trangthai ;
            
            List<Seat> seats = new List<Seat>();
            string sql = "SELECT * FROM Seat";
            try
            {
                Connect();
                SqlDataReader reader = MyExecuteReader(sql, CommandType.Text);
                while (reader.Read())
                {

                    maso = reader["maso"].ToString();
                    khuvuc = reader["khuvuc"].ToString();
                         loai = reader["loai"].ToString();
                    trangthai = reader["trangthai"].ToString();

                    Seat seat = new Seat(maso, khuvuc, loai, trangthai);
                    seats.Add(seat);
                }
                reader.Close();
                return seats;
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