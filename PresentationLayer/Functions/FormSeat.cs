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
    public partial class FormSeat : Form
    {
        private SeatBL seatBL;
        public FormSeat()
        {
            InitializeComponent();
            seatBL = new SeatBL();
        }

        private void LoadSeat()
        {
            try
            {
                dgvSeat.DataSource = seatBL.GetSeats();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

      

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            Functions.FormUpdateSeat formUpdateSeat = new FormUpdateSeat();
            DialogResult result = formUpdateSeat.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadSeat();
            }
        }

        private void FormSeat_Load(object sender, EventArgs e)
        {
            LoadSeat();
        }
    }
}