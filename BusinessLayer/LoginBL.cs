﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TranferObject;

namespace BusinessLayer
{
    public class LoginBL
    {
        private LoginDL loginDL;
   
        public LoginBL()
        {
            loginDL = new LoginDL();
        }
        public bool Login(Account account)
        {

            try
            {
                return loginDL.Login(account);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public int AddLogin(Account account)
        {
           try
            {
                return loginDL.AddLogin(account);

            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public bool CheckHotenExists(string username)
        {
            return loginDL.CheckUsernameExists(username);
        }
    }
}
