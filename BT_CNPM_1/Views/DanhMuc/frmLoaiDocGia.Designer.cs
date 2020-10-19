namespace ThuVien.Views
{
    partial class frmLoaiDocGia
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
            this.btnSoanLaiLoaiDocGia = new System.Windows.Forms.Button();
            this.btnCapNhatLoaiDocGia = new System.Windows.Forms.Button();
            this.btnXoaLoaiDocGia = new System.Windows.Forms.Button();
            this.btnThemLoaiDocGia = new System.Windows.Forms.Button();
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txtTenLoaiDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lvLoaiDocGia = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenLoaiDocGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoanLaiLoaiDocGia);
            this.groupBox3.Controls.Add(this.btnCapNhatLoaiDocGia);
            this.groupBox3.Controls.Add(this.btnXoaLoaiDocGia);
            this.groupBox3.Controls.Add(this.btnThemLoaiDocGia);
            this.groupBox3.Location = new System.Drawing.Point(12, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 85);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btnSoanLaiLoaiDocGia
            // 
            this.btnSoanLaiLoaiDocGia.Location = new System.Drawing.Point(440, 35);
            this.btnSoanLaiLoaiDocGia.Name = "btnSoanLaiLoaiDocGia";
            this.btnSoanLaiLoaiDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnSoanLaiLoaiDocGia.TabIndex = 3;
            this.btnSoanLaiLoaiDocGia.Text = "Soạn lại";
            this.btnSoanLaiLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnSoanLaiLoaiDocGia.Click += new System.EventHandler(this.btnSoanLaiLoaiDocGia_Click);
            // 
            // btnCapNhatLoaiDocGia
            // 
            this.btnCapNhatLoaiDocGia.Location = new System.Drawing.Point(307, 35);
            this.btnCapNhatLoaiDocGia.Name = "btnCapNhatLoaiDocGia";
            this.btnCapNhatLoaiDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatLoaiDocGia.TabIndex = 2;
            this.btnCapNhatLoaiDocGia.Text = "Cập nhật";
            this.btnCapNhatLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnCapNhatLoaiDocGia.Click += new System.EventHandler(this.btnCapNhatLoaiDocGia_Click);
            // 
            // btnXoaLoaiDocGia
            // 
            this.btnXoaLoaiDocGia.Location = new System.Drawing.Point(174, 35);
            this.btnXoaLoaiDocGia.Name = "btnXoaLoaiDocGia";
            this.btnXoaLoaiDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLoaiDocGia.TabIndex = 1;
            this.btnXoaLoaiDocGia.Text = "Xoá";
            this.btnXoaLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnXoaLoaiDocGia.Click += new System.EventHandler(this.btnXoaLoaiDocGia_Click);
            // 
            // btnThemLoaiDocGia
            // 
            this.btnThemLoaiDocGia.Location = new System.Drawing.Point(41, 35);
            this.btnThemLoaiDocGia.Name = "btnThemLoaiDocGia";
            this.btnThemLoaiDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnThemLoaiDocGia.TabIndex = 0;
            this.btnThemLoaiDocGia.Text = "Thêm";
            this.btnThemLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnThemLoaiDocGia.Click += new System.EventHandler(this.btnThemLoaiDocGia_Click);
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtTenLoaiDocGia);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label1);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 358);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(560, 100);
            this.groupBoxThongTinChiTiet.TabIndex = 8;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // txtTenLoaiDocGia
            // 
            this.txtTenLoaiDocGia.Location = new System.Drawing.Point(149, 38);
            this.txtTenLoaiDocGia.Name = "txtTenLoaiDocGia";
            this.txtTenLoaiDocGia.Size = new System.Drawing.Size(100, 20);
            this.txtTenLoaiDocGia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên loại độc giả";
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lvLoaiDocGia);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(560, 340);
            this.groupBoxThongTinBoPhan.TabIndex = 7;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin loại độc giả";
            // 
            // lvLoaiDocGia
            // 
            this.lvLoaiDocGia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenLoaiDocGia});
            this.lvLoaiDocGia.HideSelection = false;
            this.lvLoaiDocGia.Location = new System.Drawing.Point(6, 19);
            this.lvLoaiDocGia.Name = "lvLoaiDocGia";
            this.lvLoaiDocGia.Size = new System.Drawing.Size(548, 315);
            this.lvLoaiDocGia.TabIndex = 0;
            this.lvLoaiDocGia.UseCompatibleStateImageBehavior = false;
            this.lvLoaiDocGia.SelectedIndexChanged += new System.EventHandler(this.lvLoaiDocGia_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colTenLoaiDocGia
            // 
            this.colTenLoaiDocGia.Text = "Tên loại độc giả";
            // 
            // frmLoaiDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Name = "frmLoaiDocGia";
            this.Text = "Loại độc giả";
            this.Load += new System.EventHandler(this.frmLoaiDocGia_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSoanLaiLoaiDocGia;
        private System.Windows.Forms.Button btnCapNhatLoaiDocGia;
        private System.Windows.Forms.Button btnXoaLoaiDocGia;
        private System.Windows.Forms.Button btnThemLoaiDocGia;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.TextBox txtTenLoaiDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.ListView lvLoaiDocGia;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenLoaiDocGia;
    }
}