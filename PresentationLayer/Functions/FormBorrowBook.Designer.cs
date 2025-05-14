namespace PresentationLayer.Functions
{
    partial class FormBorrowBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrowBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.cbTensach = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.txtNamhoc = new System.Windows.Forms.TextBox();
            this.txtCoso = new System.Windows.Forms.TextBox();
            this.txtMssv = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvBorrow = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 100);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu mượn sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.dtpNgayMuon);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.btnLoad);
            this.panel2.Controls.Add(this.btnTimkiem);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTimkiem);
            this.panel2.Controls.Add(this.cbTensach);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.txtDienthoai);
            this.panel2.Controls.Add(this.txtNamhoc);
            this.panel2.Controls.Add(this.txtCoso);
            this.panel2.Controls.Add(this.txtMssv);
            this.panel2.Controls.Add(this.txtHoten);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 191);
            this.panel2.TabIndex = 4;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Location = new System.Drawing.Point(389, 97);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayMuon.TabIndex = 16;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(23, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.Location = new System.Drawing.Point(884, 48);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(37, 32);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(784, 108);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(133, 65);
            this.btnTimkiem.TabIndex = 13;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(576, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tìm kiếm MSSV:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(688, 53);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(190, 22);
            this.txtTimkiem.TabIndex = 11;
            // 
            // cbTensach
            // 
            this.cbTensach.FormattingEnabled = true;
            this.cbTensach.Location = new System.Drawing.Point(389, 51);
            this.cbTensach.Name = "cbTensach";
            this.cbTensach.Size = new System.Drawing.Size(171, 24);
            this.cbTensach.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(618, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 65);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Mượn sách";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(192, 151);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(171, 22);
            this.txtDienthoai.TabIndex = 5;
            // 
            // txtNamhoc
            // 
            this.txtNamhoc.Location = new System.Drawing.Point(192, 99);
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.Size = new System.Drawing.Size(171, 22);
            this.txtNamhoc.TabIndex = 4;
            // 
            // txtCoso
            // 
            this.txtCoso.Location = new System.Drawing.Point(192, 51);
            this.txtCoso.Name = "txtCoso";
            this.txtCoso.Size = new System.Drawing.Size(171, 22);
            this.txtCoso.TabIndex = 3;
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(23, 99);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(150, 22);
            this.txtMssv.TabIndex = 2;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(23, 48);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(150, 22);
            this.txtHoten.TabIndex = 1;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle1.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewImageColumn1.HeaderText = "Xóa";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewImageColumn2.HeaderText = "Sửa";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvBorrow
            // 
            this.dgvBorrow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBorrow.Location = new System.Drawing.Point(0, 100);
            this.dgvBorrow.Name = "dgvBorrow";
            this.dgvBorrow.RowHeadersWidth = 51;
            this.dgvBorrow.RowTemplate.Height = 24;
            this.dgvBorrow.Size = new System.Drawing.Size(937, 300);
            this.dgvBorrow.TabIndex = 6;
            this.dgvBorrow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBorrow_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "ID: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(58, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 22);
            this.txtID.TabIndex = 21;
            // 
            // FormBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 591);
            this.Controls.Add(this.dgvBorrow);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormBorrowBook";
            this.Text = "FormBorrowBook";
            this.Load += new System.EventHandler(this.FormBorrowBook_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.TextBox txtNamhoc;
        private System.Windows.Forms.TextBox txtCoso;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvBorrow;
        private System.Windows.Forms.ComboBox cbTensach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
    }
}