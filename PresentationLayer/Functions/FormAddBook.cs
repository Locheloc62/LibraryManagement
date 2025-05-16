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

namespace PresentationLayer.Functions
{
    public partial class FormAddBook : Form
    {
        private BookBL bookBL;
        private statusBL statusBL;
        public FormAddBook()
        {
            InitializeComponent();
            statusBL = new statusBL();
            bookBL = new BookBL();
        }
        private void LoadStatusBook()
        {
            try
            {
                List<Status> list = statusBL.GetStatuses();
                comboBox1.DataSource = list;
                comboBox1.DisplayMember="name";
                comboBox1.ValueMember="id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormAddBook_Load(object sender, EventArgs e)
        {
            LoadStatusBook();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string masach, tensach, tacgia, theloai, trangthai;
            int soluong,soluonghientai;

            masach = txtMasach.Text.Trim();
            tensach = txtTensach.Text;
            tacgia = txtTacgia.Text.Trim();
            theloai = txtTheloai.Text;  
            soluonghientai = int.Parse(txtSoluong.Text);
            soluong = int.Parse(txtSoluong.Text);
            trangthai = comboBox1.Text.Trim();

            Book book = new Book(masach, tensach, tacgia, theloai, soluonghientai,soluong, trangthai);
            try
            {
                int NumOfRows = bookBL.Add(book);


                if (NumOfRows > 0)
                    this.DialogResult = DialogResult.OK;
                else
                    this.DialogResult = DialogResult.Cancel;

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
