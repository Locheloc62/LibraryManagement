﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranferObject;
using BusinessLayer;
using System.Data.SqlClient;

namespace PresentationLayer
{
    public partial class FormLogin : Form
    {
        private LoginBL loginBL;
        public string LoggedInUsername { get; private set; }
        public FormLogin()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }
        private bool UserLogin(Account account)
        {
            try
            {
                return loginBL.Login(account);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUsername.Text.Trim();
            pass = txtPassword.Text;

            Account account = new Account(user, pass);

            if (UserLogin(account) == true)
            {
                this.LoggedInUsername = txtUsername.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                string msg = "Tài khoản hoặc mật khẩu không đúng!";
                DialogResult result = MessageBox.Show(msg, "Đăng nhập", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }
        private void btnRes_Click(object sender, EventArgs e)
        {
            FormResgister formResgister = new FormResgister();
            formResgister.ShowDialog();
        }
    }
}
