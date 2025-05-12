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

namespace PresentationLayer.Functions
{
    public partial class FormAddStudent : Form
    {
        private StudentBL studentBL;
        public FormAddStudent()
        {
            InitializeComponent();
            studentBL=new StudentBL();
        }

    

        private void FormAddStudent_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string  name, mssv,coso, namhoc,email;
            int dienthoai;
      
            name = txtHoten.Text.Trim();
            mssv = txtMssv.Text;
            coso = txtCoso.Text.Trim();
            namhoc = txtNamhoc.Text;
            dienthoai = int.Parse(txtDienthoai.Text);
            email=txtEmail.Text.Trim();

            Student student = new Student(name,mssv,coso,namhoc,dienthoai,email);
            try
            {
                int NumOfRows = studentBL.Add(student);
            

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
                MessageBox.Show(ex.Message, "Id of Supplier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
