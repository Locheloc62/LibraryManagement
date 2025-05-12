using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranferObject
{
    public class Account
    {
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string hoten { get; set; }
        public Account(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public Account(string username, string password, string hoten)
        {
            this.username = username;
            this.password = password;
            role = "user";
            this.hoten = hoten;
        }
        public Account(string username, string password, string role, string hoten)
        {
            this.username = username;
            this.password = password;
            this.role = role;
            this.hoten = hoten;
        }
    }
}
