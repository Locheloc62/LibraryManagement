using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BusinessLayer;
using TranferObject;

namespace PresentationLayer.Functions
{
    public partial class FormStudent : Form
    {
        private StudentBL studentBL;
        public FormStudent()
        {
            InitializeComponent();
            studentBL=new StudentBL();
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

        private void FormStudent_Load(object sender, EventArgs e)
        {
            LoadStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Functions.FormAddStudent frmAddStudent= new FormAddStudent();
            DialogResult result = frmAddStudent.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadStudent();
            }
        }
        private void DeleteStudent(string mssv)
        {
            try
            {
                Student student = new Student(mssv);
                int rowsAffected = studentBL.Delete(student);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xoa thanh cong");
                    LoadStudent();
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
        private void UpdateStudent(string hoten,string mssv, string coso, string namhoc,int dienthoai,string email)
        {
            try
            {
                Student student = new Student(hoten, mssv, coso,namhoc,dienthoai,email);
                int rowsAffected = studentBL.Update(student);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Da cap nhat thanh cong");
                    LoadStudent();
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

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            int row = e.RowIndex;
            if (row >= 0 && dgvStudent.Columns[col] is DataGridViewImageColumn)
            {
                //int row=e.RowIndex;
                //if (row >= 0)
                //{
                string columnName = dgvStudent.Columns[col].Name;

                string hoten = dgvStudent.Rows[row].Cells["hoten"].Value.ToString();
                string mssv = dgvStudent.Rows[row].Cells["mssv"].Value.ToString();
                string coso = dgvStudent.Rows[row].Cells["coso"].Value.ToString();
                string namhoc = dgvStudent.Rows[row].Cells["namhoc"].Value.ToString();
                int dienthoai = int.Parse(dgvStudent.Rows[row].Cells["dienthoai"].Value.ToString());
                string email = dgvStudent.Rows[row].Cells["email"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure?", "Update Information", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (columnName == "Delete")
                {
                    if (result == DialogResult.Yes)
                    {
                        DeleteStudent(mssv);
                    }

                }
                if (columnName == "Update")
                {
                    if (result == DialogResult.Yes)
                    {
                        UpdateStudent(hoten, mssv, coso,namhoc,dienthoai,email);
                    }
                }
            } 
        }
    }
}
