using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TranferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PresentationLayer
{
    public partial class FormResgister : Form
    {
        private LoginBL loginBL;
        public FormResgister()
        {
            InitializeComponent();
            loginBL=new LoginBL();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string user, pass, repass, hoten;
            user=txtTK.Text;
            pass=txtPass.Text;
            repass=txtRePass.Text;
            hoten=txtHoten.Text;
            if (pass != repass)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }
            Account account = new Account(user, pass, hoten);
            try
            {
                int result = loginBL.AddLogin(account);
                if (result > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại!");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
        }
    }
}
