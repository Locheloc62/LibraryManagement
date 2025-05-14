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
        
            pass = txtPass.Text;
            repass = txtRePass.Text;
            hoten = txtHoten.Text;

            if (pass != repass)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!");
                return;
            }
            user = txtTK.Text;

            // Kiểm tra tên người dùng đã tồn tại chưa
       
            
            if (loginBL.CheckHotenExists(user))
            {
                MessageBox.Show("Tài khoản này đã tồn tại. Vui lòng chọn tên người dùng khác.");
            }
            else
            {
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
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            }
           
        }

    }
}
