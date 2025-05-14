using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranferObject
{
    public class BorrowBook
    {
        public int id { get; set; }
        public string hoten { get; set; }
        public string mssv { get; set; }
        public string coso { get; set; }
        public string namhoc { get; set; }
        public int dienthoai { get; set; }
        public string email { get; set; }
        public string tensach { get; set; }
        public string ngaymuon { get; set; }
        public string ngaytra { get; set; }
        public BorrowBook(int id, string hoten, string mssv, string coso, string namhoc, int dienthoai, string email, string tensach, string ngaytra, string ngaymuon)
        {
            this.id = id;
            this.hoten = hoten;
            this.mssv = mssv;
            this.coso = coso;
            this.namhoc = namhoc;
            this.dienthoai = dienthoai;
            this.email = email;
            this.tensach = tensach;
            this.ngaytra = ngaytra;
            this.ngaymuon = ngaymuon;
           
        }
        public BorrowBook(string mssv, string hoten, string coso, string namhoc, int dienthoai, string email, string tensach, string ngaymuon,string ngaytra)
        {
 
            this.mssv = mssv;
            this.hoten = hoten;
            this.coso = coso;
            this.namhoc = namhoc;
            this.dienthoai = dienthoai;
            this.email = email;
            this.tensach = tensach;
            this.ngaymuon = ngaymuon;
            this.ngaytra=ngaytra;
        }
        public BorrowBook(string mssv, string hoten, string coso, string namhoc, int dienthoai, string email, string tensach,  string ngaymuon)
        {
        
            this.mssv = mssv;
            this.hoten = hoten;
            this.coso = coso;
            this.namhoc = namhoc;
            this.dienthoai = dienthoai;
            this.email = email;
            this.tensach = tensach;   
            this.ngaymuon = ngaymuon;
        }
        public BorrowBook(int id)
        {
           this.id = id;
        }

    }
}
