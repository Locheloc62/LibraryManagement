using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranferObject
{
    public class Account
    {
        public string Username { get; set; }
        public string Password { get; set; }
        //public int Type { get; set; }
        public Account(string user, string pass)//, int type)
        {
            this.Username = user;
            this.Password = pass;
            //this.Type = type;
        }
    }
}
