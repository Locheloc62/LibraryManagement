namespace PresentationLayer.Functions
{
    partial class FormBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.Update = new System.Windows.Forms.DataGridViewImageColumn();
            this.Masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theloai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluonghientai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBook
            // 
            this.dgvBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete,
            this.Update,
            this.Masach,
            this.Tensach,
            this.Tacgia,
            this.Theloai,
            this.Soluonghientai,
            this.Soluong,
            this.Trangthai});
            this.dgvBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBook.Location = new System.Drawing.Point(0, 100);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.RowHeadersWidth = 51;
            this.dgvBook.RowTemplate.Height = 24;
            this.dgvBook.Size = new System.Drawing.Size(1223, 419);
            this.dgvBook.TabIndex = 6;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1223, 100);
            this.panel2.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(22, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 69);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1223, 100);
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
            this.label1.Text = "Quản lý Sách";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewImageColumn1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewImageColumn1.HeaderText = "Xóa";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImageColumn2.HeaderText = "Sửa";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.HeaderText = "Xóa";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Width = 125;
            // 
            // Update
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.Update.DefaultCellStyle = dataGridViewCellStyle3;
            this.Update.HeaderText = "Sửa";
            this.Update.Image = ((System.Drawing.Image)(resources.GetObject("Update.Image")));
            this.Update.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Update.MinimumWidth = 6;
            this.Update.Name = "Update";
            this.Update.Width = 125;
            // 
            // Masach
            // 
            this.Masach.DataPropertyName = "masach";
            this.Masach.HeaderText = "Mã sách";
            this.Masach.MinimumWidth = 6;
            this.Masach.Name = "Masach";
            this.Masach.Width = 150;
            // 
            // Tensach
            // 
            this.Tensach.DataPropertyName = "tensach";
            this.Tensach.HeaderText = "Tên sách";
            this.Tensach.MinimumWidth = 6;
            this.Tensach.Name = "Tensach";
            this.Tensach.Width = 125;
            // 
            // Tacgia
            // 
            this.Tacgia.DataPropertyName = "tacgia";
            this.Tacgia.HeaderText = "Tên tác giả";
            this.Tacgia.MinimumWidth = 6;
            this.Tacgia.Name = "Tacgia";
            this.Tacgia.Width = 125;
            // 
            // Theloai
            // 
            this.Theloai.DataPropertyName = "theloai";
            this.Theloai.HeaderText = "Thể loại";
            this.Theloai.MinimumWidth = 6;
            this.Theloai.Name = "Theloai";
            this.Theloai.Width = 125;
            // 
            // Soluonghientai
            // 
            this.Soluonghientai.DataPropertyName = "soluonghientai";
            this.Soluonghientai.HeaderText = "Số lượng hiện có";
            this.Soluonghientai.MinimumWidth = 6;
            this.Soluonghientai.Name = "Soluonghientai";
            this.Soluonghientai.Width = 125;
            // 
            // Soluong
            // 
            this.Soluong.DataPropertyName = "soluong";
            this.Soluong.HeaderText = "Số lượng kho";
            this.Soluong.MinimumWidth = 6;
            this.Soluong.Name = "Soluong";
            this.Soluong.Width = 125;
            // 
            // Trangthai
            // 
            this.Trangthai.DataPropertyName = "trangthai";
            this.Trangthai.HeaderText = "Trạng thái";
            this.Trangthai.MinimumWidth = 6;
            this.Trangthai.Name = "Trangthai";
            this.Trangthai.Width = 125;
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 619);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "FormBook";
            this.Text = "FormBook";
            this.Load += new System.EventHandler(this.FormBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewImageColumn Update;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theloai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluonghientai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Trangthai;
    }
}