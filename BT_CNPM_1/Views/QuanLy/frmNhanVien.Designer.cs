namespace ThuVien.Views
{
    partial class frmNhanVien
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
            this.btnSoanLai = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbBangCap = new System.Windows.Forms.ComboBox();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.cbBoPhan = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lblTong = new System.Windows.Forms.Label();
            this.lblTongNhanVien = new System.Windows.Forms.Label();
            this.lvNhanVien = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBangCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBoPhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoanLai);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(12, 569);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 80);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // btnSoanLai
            // 
            this.btnSoanLai.Location = new System.Drawing.Point(474, 19);
            this.btnSoanLai.Name = "btnSoanLai";
            this.btnSoanLai.Size = new System.Drawing.Size(100, 40);
            this.btnSoanLai.TabIndex = 3;
            this.btnSoanLai.Text = "Soạn lại";
            this.btnSoanLai.UseVisualStyleBackColor = true;
            this.btnSoanLai.Click += new System.EventHandler(this.btnSoanLai_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(341, 19);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 40);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(208, 19);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(75, 19);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.dtNgaySinh);
            this.groupBoxThongTinChiTiet.Controls.Add(this.cbBangCap);
            this.groupBoxThongTinChiTiet.Controls.Add(this.cbChucVu);
            this.groupBoxThongTinChiTiet.Controls.Add(this.cbBoPhan);
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtDiaChi);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label6);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label5);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label4);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label3);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label1);
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtDienThoai);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label2);
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtHoTen);
            this.groupBoxThongTinChiTiet.Controls.Add(this.lbl);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 389);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(660, 174);
            this.groupBoxThongTinChiTiet.TabIndex = 8;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Location = new System.Drawing.Point(104, 101);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(169, 20);
            this.dtNgaySinh.TabIndex = 13;
            // 
            // cbBangCap
            // 
            this.cbBangCap.FormattingEnabled = true;
            this.cbBangCap.Location = new System.Drawing.Point(474, 22);
            this.cbBangCap.Name = "cbBangCap";
            this.cbBangCap.Size = new System.Drawing.Size(169, 21);
            this.cbBangCap.TabIndex = 12;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(474, 60);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(169, 21);
            this.cbChucVu.TabIndex = 11;
            // 
            // cbBoPhan
            // 
            this.cbBoPhan.FormattingEnabled = true;
            this.cbBoPhan.Location = new System.Drawing.Point(104, 63);
            this.cbBoPhan.Name = "cbBoPhan";
            this.cbBoPhan.Size = new System.Drawing.Size(169, 21);
            this.cbBoPhan.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(104, 136);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(539, 20);
            this.txtDiaChi.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Chức vụ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bộ phận:";
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(474, 98);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(169, 20);
            this.txtDienThoai.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bằng cấp:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(104, 19);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(169, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 25);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Họ tên:";
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lblTong);
            this.groupBoxThongTinBoPhan.Controls.Add(this.lblTongNhanVien);
            this.groupBoxThongTinBoPhan.Controls.Add(this.lvNhanVien);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(660, 371);
            this.groupBoxThongTinBoPhan.TabIndex = 7;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin chung";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(101, 346);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(0, 13);
            this.lblTong.TabIndex = 3;
            // 
            // lblTongNhanVien
            // 
            this.lblTongNhanVien.AutoSize = true;
            this.lblTongNhanVien.Location = new System.Drawing.Point(6, 346);
            this.lblTongNhanVien.Name = "lblTongNhanVien";
            this.lblTongNhanVien.Size = new System.Drawing.Size(96, 13);
            this.lblTongNhanVien.TabIndex = 1;
            this.lblTongNhanVien.Text = "Tổng số nhân viên";
            // 
            // lvNhanVien
            // 
            this.lvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colHoTen,
            this.colBangCap,
            this.colBoPhan,
            this.colChucVu});
            this.lvNhanVien.HideSelection = false;
            this.lvNhanVien.Location = new System.Drawing.Point(9, 19);
            this.lvNhanVien.Name = "lvNhanVien";
            this.lvNhanVien.Size = new System.Drawing.Size(645, 315);
            this.lvNhanVien.TabIndex = 0;
            this.lvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lvNhanVien.View = System.Windows.Forms.View.Details;
            this.lvNhanVien.SelectedIndexChanged += new System.EventHandler(this.lvNhanVien_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            // 
            // colBangCap
            // 
            this.colBangCap.Text = "Bằng cấp";
            // 
            // colBoPhan
            // 
            this.colBoPhan.Text = "Bộ phận";
            // 
            // colChucVu
            // 
            this.colChucVu.Text = "Chức vụ";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Name = "frmNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.groupBoxThongTinBoPhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSoanLai;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.ComboBox cbBangCap;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.ComboBox cbBoPhan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Label lblTongNhanVien;
        private System.Windows.Forms.ListView lvNhanVien;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colBangCap;
        private System.Windows.Forms.ColumnHeader colBoPhan;
        private System.Windows.Forms.ColumnHeader colChucVu;
    }
}