using System;
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
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                string msg = "Username and password are incorrect!";
                DialogResult result = MessageBox.Show(msg, "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else
                    this.DialogResult = DialogResult.Cancel;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
