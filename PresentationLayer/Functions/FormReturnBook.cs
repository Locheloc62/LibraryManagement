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
using static BusinessLayer.BookBL;

namespace PresentationLayer.Functions
{
    public partial class FormReturnBook : Form
    {
        private BookBL bookBL;
        private ReturnBookBL returnBookBL;
        public FormReturnBook()
        {
            InitializeComponent();
            bookBL = new BookBL();
            returnBookBL=new ReturnBookBL();
        }
        private void LoadBorrowBook()
        {
            try
            {
                dgvReturn.DataSource = bookBL.GetBorrowBooks();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
        private void LoadReturnBook()
        {
            try
            {
                List<ReturnBook> list = returnBookBL.GetReturnBooks();
                cbNgayTra.DataSource = list;
                cbNgayTra.DisplayMember = "trangthai";
                cbNgayTra.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormReturnBook_Load(object sender, EventArgs e)
        {
            LoadBorrowBook();
            LoadBookNames();
            LoadReturnBook();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ngaytra, mssv;
            int id;

            if (string.IsNullOrWhiteSpace(txtHoten.Text))
            {
                MessageBox.Show("Vui lòng nhập thông tin","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            try
            {
                id = int.Parse(txtID.Text);
                ngaytra = cbNgayTra.Text;
                mssv = txtMssv.Text;

                BorrowBook borrowBook = new BorrowBook(id, mssv, ngaytra);

                int NumOfRows = bookBL.UpdateBookReturn(borrowBook);

                if (NumOfRows > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Trả sách thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBorrowBook();
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                    MessageBox.Show("Trả sách thất bại!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID phải là số.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void txtMssv_TextChanged(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            txtID.Clear();
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
            if (txtTimkiem.Text != "" && txtID.Text != "")
            {
                int id;
                if (!int.TryParse(txtID.Text.Trim(), out id))
                {
                    MessageBox.Show("ID không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string mssv = txtTimkiem.Text.Trim();
                GetMSSVAndIDBL bus = new GetMSSVAndIDBL();
                List<BorrowBook> dsMuonSach = bus.GetBorrowBooksByMSSAndIDV(id, mssv);

                // Kiểm tra danh sách kết quả
                if (dsMuonSach.Count > 0)
                {
                    // Kiểm tra nếu có kết quả nhưng mssv hoặc id không khớp DataGridView
                    bool matchFound = false;
                    foreach (DataGridViewRow row in dgvReturn.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string rowMSSV = row.Cells["mssv"].Value?.ToString();
                            int rowID = Convert.ToInt32(row.Cells["id"].Value);

                            if (rowMSSV == mssv && rowID == id)
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
                        dgvReturn.DataSource = null;
                        return;
                    }

                    // Nếu khớp, hiển thị dữ liệu
                    dgvReturn.DataSource = dsMuonSach;
                    BorrowBook bb = dsMuonSach[0];

                    txtID.Text = bb.id.ToString();
                    txtHoten.Text = bb.hoten;
                    txtMssv.Text = bb.mssv;
                    txtCoso.Text = bb.coso;
                    txtNamhoc.Text = bb.namhoc;
                    txtDienthoai.Text = bb.dienthoai.ToString();
                    cbTensach.Text = bb.tensach;
                    txtEmail.Text = bb.email;
                }
            }
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {
            txtTimkiem.Clear();
            LoadBorrowBook();
        }
        private void DeleteReturnBook(int id)
        {
            try
            {
                BorrowBook borrowBook = new BorrowBook(id);
                int rowsAffected = bookBL.DeleteReturnBook(borrowBook);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa thành công","Thành công",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadBorrowBook();
                }
                else
                {
                    MessageBox.Show("Xóa thất","Thất bại",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi xóa" + ex.Message);
            }
        }

        private void dgvReturn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if (row >= 0 && dgvReturn.Columns[col] is DataGridViewImageColumn)
            {
                //int row=e.RowIndex;
                //if (row >= 0)
                //{
                string columnName = dgvReturn.Columns[col].Name;
                int id = int.Parse(dgvReturn.Rows[row].Cells["id"].Value.ToString());
                string mssv = dgvReturn.Rows[row].Cells["mssv"].Value.ToString();
                string hoten = dgvReturn.Rows[row].Cells["hoten"].Value.ToString();
                string coso = dgvReturn.Rows[row].Cells["coso"].Value.ToString();
                string namhoc = dgvReturn.Rows[row].Cells["namhoc"].Value.ToString();
                int dienthoai = int.Parse(dgvReturn.Rows[row].Cells["dienthoai"].Value.ToString());
                string email = dgvReturn.Rows[row].Cells["email"].Value.ToString();
                string tensach = dgvReturn.Rows[row].Cells["tensach"].Value.ToString();
                string ngaymuon = dgvReturn.Rows[row].Cells["ngaymuon"].Value.ToString();
                string ngaytra = dgvReturn.Rows[row].Cells["ngaytra"].Value.ToString();

                DialogResult result = MessageBox.Show("Bạn chắc chứ?", "Cập nhật thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (columnName == "Delete")
                {
                    if (result == DialogResult.Yes)
                    {
                        DeleteReturnBook(id);
                    }

                }
            }
        }
    }
}
