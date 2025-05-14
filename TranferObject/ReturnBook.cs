using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranferObject
{
    public class ReturnBook
    {
        public int id { get; set; }
        public string trangthai { get; set; }

        public ReturnBook(int id, string trangthai)
        {
            this.id = id;
            this.trangthai = trangthai;
        }
    }
}
