using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranferObject
{
    public class Book
    {
        public string masach { get; set; }
        public string tensach { get; set; }
        public string tacGia { get; set; }
        public string theloai { get; set; }
        public int soluonghientai { get; set; }
        public int soluong { get; set; }
        public string trangthai { get; set; }
        public Book(string masach, string tensach, string tacGia, string theloai, int soluonghientai, int soluong, string trangthai)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.tacGia = tacGia;
            this.theloai = theloai;
            this.soluonghientai = soluonghientai;
            this.soluong = soluong;
            this.trangthai = trangthai;
        }
        public Book(string masach)
        {
            this.masach = masach;
         
        }
        public Book(string masach, string tensach, string tacGia, string theloai, int soluong, string trangthai)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.tacGia = tacGia;
            this.theloai = theloai;
            this.soluong = soluong;
            this.trangthai = trangthai;
        }
    }
}