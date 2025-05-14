using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranferObject
{
    public class Seat
    {
        public string maSo { get; set; }
        public string khuVuc { get; set; }
        public string loai { get; set; }
        public string trangThai { get; set; }

        public Seat(string maSo, string khuVuc, string loai, string trangThai)
        {
            this.maSo = maSo;
            this.khuVuc = khuVuc;
            this.loai = loai;
            this.trangThai = trangThai;
        }
    }
}