namespace PresentationLayer
{
    partial class LibraryManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryManagement));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTra = new System.Windows.Forms.Button();
            this.btnMuon = new System.Windows.Forms.Button();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.btnPos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSach = new System.Windows.Forms.Button();
            this.btnSV = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(410, 0);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1514, 739);
            this.pnlMain.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnIn);
            this.panel2.Controls.Add(this.btnTra);
            this.panel2.Controls.Add(this.btnMuon);
            this.panel2.Controls.Add(this.pbExit);
            this.panel2.Controls.Add(this.btnPos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSach);
            this.panel2.Controls.Add(this.btnSV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 739);
            this.panel2.TabIndex = 3;
            // 
            // btnIn
            // 
            this.btnIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.Green;
            this.btnIn.Location = new System.Drawing.Point(24, 557);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(358, 60);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "danh sách sách mượn/trả";
            this.btnIn.UseVisualStyleBackColor = true;
            // 
            // btnTra
            // 
            this.btnTra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTra.ForeColor = System.Drawing.Color.Green;
            this.btnTra.Location = new System.Drawing.Point(24, 464);
            this.btnTra.Margin = new System.Windows.Forms.Padding(4);
            this.btnTra.Name = "btnTra";
            this.btnTra.Size = new System.Drawing.Size(358, 60);
            this.btnTra.TabIndex = 4;
            this.btnTra.Text = "Quản lý trả sách";
            this.btnTra.UseVisualStyleBackColor = true;
            // 
            // btnMuon
            // 
            this.btnMuon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuon.ForeColor = System.Drawing.Color.Green;
            this.btnMuon.Location = new System.Drawing.Point(24, 382);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(4);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.Size = new System.Drawing.Size(358, 60);
            this.btnMuon.TabIndex = 3;
            this.btnMuon.Text = "Quản lý mượn sách";
            this.btnMuon.UseVisualStyleBackColor = true;
            // 
            // pbExit
            // 
            this.pbExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pbExit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbExit.Image = ((System.Drawing.Image)(resources.GetObject("pbExit.Image")));
            this.pbExit.Location = new System.Drawing.Point(0, 659);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(410, 80);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // btnPos
            // 
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.ForeColor = System.Drawing.Color.Green;
            this.btnPos.Location = new System.Drawing.Point(24, 290);
            this.btnPos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPos.Name = "btnPos";
            this.btnPos.Size = new System.Drawing.Size(358, 60);
            this.btnPos.TabIndex = 2;
            this.btnPos.Text = "Quản lý chỗ ngồi";
            this.btnPos.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSach
            // 
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.ForeColor = System.Drawing.Color.Green;
            this.btnSach.Location = new System.Drawing.Point(24, 207);
            this.btnSach.Margin = new System.Windows.Forms.Padding(4);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(358, 60);
            this.btnSach.TabIndex = 1;
            this.btnSach.Text = "Quản lý sách";
            this.btnSach.UseVisualStyleBackColor = true;
            this.btnSach.Click += new System.EventHandler(this.btnSach_Click);
            // 
            // btnSV
            // 
            this.btnSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSV.ForeColor = System.Drawing.Color.Green;
            this.btnSV.Location = new System.Drawing.Point(24, 118);
            this.btnSV.Margin = new System.Windows.Forms.Padding(4);
            this.btnSV.Name = "btnSV";
            this.btnSV.Size = new System.Drawing.Size(358, 60);
            this.btnSV.TabIndex = 0;
            this.btnSV.Text = "Quản lý sinh viên";
            this.btnSV.UseVisualStyleBackColor = true;
            this.btnSV.Click += new System.EventHandler(this.btnSV_Click);
            // 
            // LibraryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 739);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel2);
            this.Name = "LibraryManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryManagement";
            this.Load += new System.EventHandler(this.LibraryManagement_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnSV;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTra;
        private System.Windows.Forms.Button btnMuon;
        private System.Windows.Forms.PictureBox pbExit;
    }
}