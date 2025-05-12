using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranferObject
{
    public class Student
    {
        public string hoten { get; set; }
        public string mssv { get; set; }
        public string coso { get; set; }
        public string namhoc { get; set; }
        public int dienthoai { get; set; }
        public string email { get; set; }
        public Student(string hoten, string mssv, string coso, string namhoc, int dienthoai, string email)
        {
            this.hoten = hoten;
            this.mssv = mssv;
            this.coso = coso;
            this.namhoc = namhoc;
            this.dienthoai = dienthoai;
            this.email = email;
        }
    }
}
