namespace PresentationLayer.Functions
{
    partial class FormReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReturnBook));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.cbNgayTra = new System.Windows.Forms.ComboBox();
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
            this.dgvReturn = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 100);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(698, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiểu trả sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.dtpReturn);
            this.panel2.Controls.Add(this.cbNgayTra);
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
            this.panel2.Location = new System.Drawing.Point(0, 401);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 191);
            this.panel2.TabIndex = 6;
            // 
            // dtpReturn
            // 
            this.dtpReturn.Location = new System.Drawing.Point(383, 97);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(245, 22);
            this.dtpReturn.TabIndex = 18;
            // 
            // cbNgayTra
            // 
            this.cbNgayTra.FormattingEnabled = true;
            this.cbNgayTra.Location = new System.Drawing.Point(383, 149);
            this.cbNgayTra.Name = "cbNgayTra";
            this.cbNgayTra.Size = new System.Drawing.Size(171, 24);
            this.cbNgayTra.TabIndex = 17;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 151);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 22);
            this.txtEmail.TabIndex = 15;
            // 
            // btnLoad
            // 
            this.btnLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLoad.BackgroundImage")));
            this.btnLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoad.Location = new System.Drawing.Point(878, 48);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(37, 32);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(797, 108);
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
            this.label2.Location = new System.Drawing.Point(570, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tìm kiếm MSSV:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(682, 53);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(190, 22);
            this.txtTimkiem.TabIndex = 11;
            // 
            // cbTensach
            // 
            this.cbTensach.FormattingEnabled = true;
            this.cbTensach.Location = new System.Drawing.Point(383, 51);
            this.cbTensach.Name = "cbTensach";
            this.cbTensach.Size = new System.Drawing.Size(171, 24);
            this.cbTensach.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(647, 108);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 65);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Return";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(186, 151);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(171, 22);
            this.txtDienthoai.TabIndex = 5;
            // 
            // txtNamhoc
            // 
            this.txtNamhoc.Location = new System.Drawing.Point(186, 99);
            this.txtNamhoc.Name = "txtNamhoc";
            this.txtNamhoc.Size = new System.Drawing.Size(171, 22);
            this.txtNamhoc.TabIndex = 4;
            // 
            // txtCoso
            // 
            this.txtCoso.Location = new System.Drawing.Point(186, 51);
            this.txtCoso.Name = "txtCoso";
            this.txtCoso.Size = new System.Drawing.Size(171, 22);
            this.txtCoso.TabIndex = 3;
            // 
            // txtMssv
            // 
            this.txtMssv.Location = new System.Drawing.Point(17, 99);
            this.txtMssv.Name = "txtMssv";
            this.txtMssv.Size = new System.Drawing.Size(150, 22);
            this.txtMssv.TabIndex = 2;
            this.txtMssv.TextChanged += new System.EventHandler(this.txtMssv_TextChanged);
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(17, 48);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(150, 22);
            this.txtHoten.TabIndex = 1;
            // 
            // dgvReturn
            // 
            this.dgvReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dgvReturn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReturn.Location = new System.Drawing.Point(0, 100);
            this.dgvReturn.Name = "dgvReturn";
            this.dgvReturn.RowHeadersWidth = 51;
            this.dgvReturn.RowTemplate.Height = 24;
            this.dgvReturn.Size = new System.Drawing.Size(947, 301);
            this.dgvReturn.TabIndex = 8;
            this.dgvReturn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReturn_CellContentClick);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Xóa";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(57, 6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(56, 22);
            this.txtID.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "ID: ";
            // 
            // FormReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 592);
            this.Controls.Add(this.dgvReturn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "FormReturnBook";
            this.Text = "ReturnBook";
            this.Load += new System.EventHandler(this.FormReturnBook_Load);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ComboBox cbTensach;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.TextBox txtNamhoc;
        private System.Windows.Forms.TextBox txtCoso;
        private System.Windows.Forms.TextBox txtMssv;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.DataGridView dgvReturn;
        private System.Windows.Forms.ComboBox cbNgayTra;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
    }
}