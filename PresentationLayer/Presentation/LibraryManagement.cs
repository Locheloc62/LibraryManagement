using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LibraryManagement : Form
    {
        public LibraryManagement()
        {
            InitializeComponent();
        }

        private void LibraryManagement_Load(object sender, EventArgs e)
        {
            this.Hide();
            this.Enabled = false;
            FormLogin login = new FormLogin();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.Enabled = true;
                label1.Text = "Xin chào, " + login.LoggedInUsername;
            }
            else
            {
                Application.Exit();
            }
        }
        private void AddForm(Form form)
        {
            form.TopLevel = false;
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(form);
            form.Show();
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            AddForm(new Functions.FormStudent());
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            AddForm(new Functions.FormBook());
        }

        private void btnMuon_Click(object sender, EventArgs e)
        {
            AddForm(new Functions.FormBorrowBook());
        }

        private void btnTra_Click(object sender, EventArgs e)
        {
            AddForm(new Functions.FormReturnBook());
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            AddForm(new Functions.FormSeat());
        }
    }
}
