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
using System.Xml.Linq;
using BusinessLayer;
using TranferObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static BusinessLayer.BookBL;
using static BusinessLayer.StudentBL;

namespace PresentationLayer.Functions
{
    public partial class FormBorrowBook : Form
    {
        private BookBL bookBL;
        private StudentBL studentBL;
        public FormBorrowBook()
        {
            InitializeComponent();
            bookBL = new BookBL();
            studentBL=new StudentBL();

        }
        private void LoadBookNames()
        {
            try
            {
                List<Book> list = bookBL.GetNameBooks();
                cbTensach.DataSource = list;
                cbTensach.DisplayMember = "tensach";
                cbTensach.ValueMember = "masach";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadStudent()
        {
            try
            {
                dgvStudent.DataSource = studentBL.GetStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadBorrowBook()
        {
            try
            {
                dgvBorrow.DataSource =bookBL.GetBorrowBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormBorrowBook_Load(object sender, EventArgs e)
        {
            LoadBorrowBook();
            LoadBookNames();
            LoadStudent();
        }
        private void ClearFields()
        {
          
            txtHoten.Clear();
            txtMssv.Clear();
            txtCoso.Clear();
            txtNamhoc.Clear();
            txtDienthoai.Clear();
            txtEmail.Clear();
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            // Kiểm tra đầu vào
            if (txtTimkiem.Text != "" )
            {
                string mssv = txtTimkiem.Text.Trim();
                GetMSSVBL bus = new GetMSSVBL();
                List<Student> dsMuonSach = bus.GetStudentByMSS( mssv);

                // Kiểm tra danh sách kết quả
                if (dsMuonSach.Count > 0)
                {
                    // Kiểm tra nếu có kết quả nhưng mssv hoặc id không khớp DataGridView
                    bool matchFound = false;
                    foreach (DataGridViewRow row in dgvStudent.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string rowMSSV = row.Cells["mssv"].Value?.ToString();

                            if (rowMSSV == mssv)
                            {
                                matchFound = true;
                                break;
                            }
                        }
                    }

                    if (!matchFound)
                    {
                        MessageBox.Show("Không tìm thấy bản ghi khớp trong bảng hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ClearFields();
                        dgvStudent.DataSource = null;
                        return;
                    }

                    // Nếu khớp, hiển thị dữ liệu
                    dgvStudent.DataSource = dsMuonSach;
                    Student bb = dsMuonSach[0];

                 
                    txtHoten.Text = bb.hoten;
                    txtMssv.Text = bb.mssv;
                    txtCoso.Text = bb.coso;
                    txtNamhoc.Text = bb.namhoc;
                    txtDienthoai.Text = bb.dienthoai.ToString();
                    txtEmail.Text = bb.email;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên với ID và MSSV vừa nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    dgvBorrow.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ cả ID và MSSV để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTimkiem.Clear();
            LoadBorrowBook();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text == ""|| txtCoso.Text=="" || txtMssv.Text=="" || txtNamhoc.Text=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                string mssv = txtMssv.Text.Trim();
                string name = txtHoten.Text.Trim();
                string coso = txtCoso.Text.Trim();
                string namhoc = txtNamhoc.Text.Trim();
                string email = txtEmail.Text.Trim();
                string tensach = cbTensach.Text.Trim();
                string ngaymuon = dtpNgayMuon.Text.Trim();
                int dienthoai;
                if (!int.TryParse(txtDienthoai.Text, out dienthoai))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ.");
                    return;
                }

               
                foreach (DataGridViewRow row in dgvBorrow.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string existingMSSV = row.Cells["mssv"].Value?.ToString();
                        string existingTensach = row.Cells["tensach"].Value?.ToString();
                        string existingNgaymuon = row.Cells["ngaymuon"].Value?.ToString();

                        if (mssv == existingMSSV && tensach == existingTensach && ngaymuon == existingNgaymuon)
                        {
                            MessageBox.Show("Thông tin mượn sách này đã tồn tại. Vui lòng kiểm tra lại.", "Trùng thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                }

                BorrowBook borrowBook = new BorrowBook(mssv, name, coso, namhoc, dienthoai, email, tensach, ngaymuon);

                try
                {
                    int NumOfRows = bookBL.AddBorrowBook(borrowBook);

                    if (NumOfRows > 0)
                    {
                        this.DialogResult = DialogResult.OK;
                        MessageBox.Show("Mượn sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBorrowBook();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                        MessageBox.Show("Mượn sách thất bại.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}

