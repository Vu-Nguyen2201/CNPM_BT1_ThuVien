namespace ThuVien.Views
{
    partial class frmTheLoaiSach
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSoanLaiTheLoaiSach = new System.Windows.Forms.Button();
            this.btnCapNhatTheLoaiSach = new System.Windows.Forms.Button();
            this.btnXoaTheLoaiSach = new System.Windows.Forms.Button();
            this.btnThemTheLoaiSach = new System.Windows.Forms.Button();
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txtTenTheLoaiSach = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lvTheLoaiSach = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenTheLoaiSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoanLaiTheLoaiSach);
            this.groupBox3.Controls.Add(this.btnCapNhatTheLoaiSach);
            this.groupBox3.Controls.Add(this.btnXoaTheLoaiSach);
            this.groupBox3.Controls.Add(this.btnThemTheLoaiSach);
            this.groupBox3.Location = new System.Drawing.Point(12, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnSoanLaiTheLoaiSach
            // 
            this.btnSoanLaiTheLoaiSach.Location = new System.Drawing.Point(440, 35);
            this.btnSoanLaiTheLoaiSach.Name = "btnSoanLaiTheLoaiSach";
            this.btnSoanLaiTheLoaiSach.Size = new System.Drawing.Size(75, 23);
            this.btnSoanLaiTheLoaiSach.TabIndex = 3;
            this.btnSoanLaiTheLoaiSach.Text = "Soạn lại";
            this.btnSoanLaiTheLoaiSach.UseVisualStyleBackColor = true;
            this.btnSoanLaiTheLoaiSach.Click += new System.EventHandler(this.btnSoanLaiTheLoaiSach_Click);
            // 
            // btnCapNhatTheLoaiSach
            // 
            this.btnCapNhatTheLoaiSach.Location = new System.Drawing.Point(307, 35);
            this.btnCapNhatTheLoaiSach.Name = "btnCapNhatTheLoaiSach";
            this.btnCapNhatTheLoaiSach.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatTheLoaiSach.TabIndex = 2;
            this.btnCapNhatTheLoaiSach.Text = "Cập nhật";
            this.btnCapNhatTheLoaiSach.UseVisualStyleBackColor = true;
            this.btnCapNhatTheLoaiSach.Click += new System.EventHandler(this.btnCapNhatTheLoaiSach_Click);
            // 
            // btnXoaTheLoaiSach
            // 
            this.btnXoaTheLoaiSach.Location = new System.Drawing.Point(174, 35);
            this.btnXoaTheLoaiSach.Name = "btnXoaTheLoaiSach";
            this.btnXoaTheLoaiSach.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTheLoaiSach.TabIndex = 1;
            this.btnXoaTheLoaiSach.Text = "Xoá";
            this.btnXoaTheLoaiSach.UseVisualStyleBackColor = true;
            this.btnXoaTheLoaiSach.Click += new System.EventHandler(this.btnXoaTheLoaiSach_Click);
            // 
            // btnThemTheLoaiSach
            // 
            this.btnThemTheLoaiSach.Location = new System.Drawing.Point(41, 35);
            this.btnThemTheLoaiSach.Name = "btnThemTheLoaiSach";
            this.btnThemTheLoaiSach.Size = new System.Drawing.Size(75, 23);
            this.btnThemTheLoaiSach.TabIndex = 0;
            this.btnThemTheLoaiSach.Text = "Thêm";
            this.btnThemTheLoaiSach.UseVisualStyleBackColor = true;
            this.btnThemTheLoaiSach.Click += new System.EventHandler(this.btnThemTheLoaiSach_Click);
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtTenTheLoaiSach);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label1);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 358);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(560, 100);
            this.groupBoxThongTinChiTiet.TabIndex = 5;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // txtTenTheLoaiSach
            // 
            this.txtTenTheLoaiSach.Location = new System.Drawing.Point(149, 38);
            this.txtTenTheLoaiSach.Name = "txtTenTheLoaiSach";
            this.txtTenTheLoaiSach.Size = new System.Drawing.Size(100, 20);
            this.txtTenTheLoaiSach.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thể loại sách";
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lvTheLoaiSach);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(560, 340);
            this.groupBoxThongTinBoPhan.TabIndex = 4;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin thể loại sách";
            // 
            // lvTheLoaiSach
            // 
            this.lvTheLoaiSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenTheLoaiSach});
            this.lvTheLoaiSach.HideSelection = false;
            this.lvTheLoaiSach.Location = new System.Drawing.Point(6, 19);
            this.lvTheLoaiSach.Name = "lvTheLoaiSach";
            this.lvTheLoaiSach.Size = new System.Drawing.Size(548, 315);
            this.lvTheLoaiSach.TabIndex = 0;
            this.lvTheLoaiSach.UseCompatibleStateImageBehavior = false;
            this.lvTheLoaiSach.SelectedIndexChanged += new System.EventHandler(this.lvTheLoaiSach_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colTenTheLoaiSach
            // 
            this.colTenTheLoaiSach.Text = "Tên thể loại sách";
            // 
            // frmTheLoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Name = "frmTheLoaiSach";
            this.Text = "Thể loại sách";
            this.Load += new System.EventHandler(this.frmTheLoaiSach_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSoanLaiTheLoaiSach;
        private System.Windows.Forms.Button btnCapNhatTheLoaiSach;
        private System.Windows.Forms.Button btnXoaTheLoaiSach;
        private System.Windows.Forms.Button btnThemTheLoaiSach;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.TextBox txtTenTheLoaiSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.ListView lvTheLoaiSach;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenTheLoaiSach;
    }
}