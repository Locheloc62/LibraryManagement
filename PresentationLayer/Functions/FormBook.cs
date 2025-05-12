using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TranferObject;

namespace PresentationLayer.Functions
{
    public partial class FormBook : Form
    {
        private BookBL bookBL;
        public FormBook()
        {
            InitializeComponent();
            bookBL = new BookBL();
        }

        private void LoadBook()
        {
            try
            {
                dgvBook.DataSource = bookBL.GetBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormBook_Load(object sender, EventArgs e)
        {
            LoadBook();
        }
      
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Functions.FormAddBook frmAddBook = new FormAddBook();
            DialogResult result = frmAddBook.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadBook();
            }
        }

        private void DeleteBook(string masach)
        {
            try
            {
                Book book = new Book(masach);
                int rowsAffected = bookBL.Delete(book);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                    LoadBook();
                }
                else
                {
                    MessageBox.Show("Xoa that bai");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi khi xoa" + ex.Message);
            }
        }
        private void UpdateBook(string masach, string tensach, string tacgia, string theloai, int soluonghientai, int soluong, string trangthai)
        {
            try
            {
                Book book = new Book(masach, tensach, tacgia, theloai, soluonghientai, soluong, trangthai);
                int rowsAffected = bookBL.Update(book);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Da cap nhat thanh cong");
                    LoadBook();
                }
                else
                {
                    MessageBox.Show("Cap nhat that bai");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Loi khi Cap nhat" + ex.Message);
            }
        }

        private void dgvBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if (row >= 0 && dgvBook.Columns[col] is DataGridViewImageColumn)
            {
                //int row=e.RowIndex;
                //if (row >= 0)
                //{
                string columnName = dgvBook.Columns[col].Name;

                string masach = dgvBook.Rows[row].Cells["masach"].Value.ToString();
                string tensach = dgvBook.Rows[row].Cells["tensach"].Value.ToString();
                string tacgia = dgvBook.Rows[row].Cells["tacgia"].Value.ToString();
                string theloai = dgvBook.Rows[row].Cells["theloai"].Value.ToString();
                int soluonghientai = int.Parse(dgvBook.Rows[row].Cells["soluonghientai"].Value.ToString());
                int soluong = int.Parse(dgvBook.Rows[row].Cells["soluong"].Value.ToString());
                string trangthai = dgvBook.Rows[row].Cells["trangthai"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure?", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (columnName == "Delete")
                {
                    if (result == DialogResult.Yes)
                    {
                        DeleteBook(masach);
                    }

                }
                if (columnName == "Update")
                {
                    if (result == DialogResult.Yes)
                    {
                        UpdateBook(masach, tensach, tacgia, theloai, soluonghientai, soluong, trangthai);
                    }
                }
            }
        }
    }
}
