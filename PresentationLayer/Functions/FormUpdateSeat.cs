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

namespace PresentationLayer.Functions
{
    public partial class FormUpdateSeat : Form
    {
        private SeatBL seatBL;
        public FormUpdateSeat()
        {
            InitializeComponent();
            seatBL=new SeatBL();
        }
        private void LoadStatusSeat()
        {
            try
            {
                List<Seat> list = seatBL.GetstatusSeats();
                cbChoNgoi.DataSource = list;
                cbChoNgoi.DisplayMember = "maso";
                cbChoNgoi.ValueMember = "maso";

                // Gán khu vực (distinct)
                cbKhuVuc.DataSource = list
                    .Select(s => s.khuVuc)
                    .Distinct()
                    .ToList();
                cbKhuVuc.DisplayMember = cbKhuVuc.ValueMember = null; // Không cần DisplayMember khi là List<string>

                // Gán loại (distinct)
                cbLoai.DataSource = list
                    .Select(s => s.loai)
                    .Distinct()
                    .ToList();
                cbLoai.DisplayMember = cbLoai.ValueMember = null;

                // Gán trạng thái (distinct)
                cbTrangThai.DataSource = list
                    .Select(s => s.trangThai)
                    .Distinct()
                    .ToList();
                cbTrangThai.DisplayMember = cbTrangThai.ValueMember = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormUpdateSeat_Load(object sender, EventArgs e)
        {
            LoadStatusSeat();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string maso,khuvuc,loai, trangthai;


            maso = cbChoNgoi.Text.Trim();
            khuvuc = cbKhuVuc.Text;
            loai = cbLoai.Text.Trim();
            trangthai = cbTrangThai.Text;
         

            Seat seat = new Seat(maso, khuvuc, loai, trangthai);
            try
            {
                int NumOfRows = seatBL.Update(seat);


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
    }
}
