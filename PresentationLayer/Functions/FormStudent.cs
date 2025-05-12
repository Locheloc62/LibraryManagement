using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

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
    }
}
