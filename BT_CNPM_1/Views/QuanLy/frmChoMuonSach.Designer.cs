namespace ThuVien.Views
{
    partial class frmChoMuonSach
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
            this.lvChoMuonSach = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgayMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTongNguoiMuon = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lblTongPM = new System.Windows.Forms.Label();
            this.btnChiTietPhieuMuon = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnSoanLai = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.cbDocGia = new System.Windows.Forms.ComboBox();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvChoMuonSach
            // 
            this.lvChoMuonSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colHoTen,
            this.colNgayMuon});
            this.lvChoMuonSach.HideSelection = false;
            this.lvChoMuonSach.Location = new System.Drawing.Point(9, 19);
            this.lvChoMuonSach.Name = "lvChoMuonSach";
            this.lvChoMuonSach.Size = new System.Drawing.Size(645, 315);
            this.lvChoMuonSach.TabIndex = 0;
            this.lvChoMuonSach.UseCompatibleStateImageBehavior = false;
            this.lvChoMuonSach.View = System.Windows.Forms.View.Details;
            this.lvChoMuonSach.SelectedIndexChanged += new System.EventHandler(this.lvChoMuonSach_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ tên";
            this.colHoTen.Width = 133;
            // 
            // colNgayMuon
            // 
            this.colNgayMuon.Text = "Ngày mượn";
            this.colNgayMuon.Width = 131;
            // 
            // lblTongNguoiMuon
            // 
            this.lblTongNguoiMuon.AutoSize = true;
            this.lblTongNguoiMuon.Location = new System.Drawing.Point(6, 346);
            this.lblTongNguoiMuon.Name = "lblTongNguoiMuon";
            this.lblTongNguoiMuon.Size = new System.Drawing.Size(104, 13);
            this.lblTongNguoiMuon.TabIndex = 1;
            this.lblTongNguoiMuon.Text = "Tổng số phiếu mượn";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(379, 337);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(0, 13);
            this.lblTong.TabIndex = 3;
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lblTongPM);
            this.groupBoxThongTinBoPhan.Controls.Add(this.btnChiTietPhieuMuon);
            this.groupBoxThongTinBoPhan.Controls.Add(this.lblTong);
            this.groupBoxThongTinBoPhan.Controls.Add(this.lblTongNguoiMuon);
            this.groupBoxThongTinBoPhan.Controls.Add(this.lvChoMuonSach);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(660, 371);
            this.groupBoxThongTinBoPhan.TabIndex = 13;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin chung";
            // 
            // lblTongPM
            // 
            this.lblTongPM.AutoSize = true;
            this.lblTongPM.Location = new System.Drawing.Point(116, 346);
            this.lblTongPM.Name = "lblTongPM";
            this.lblTongPM.Size = new System.Drawing.Size(13, 13);
            this.lblTongPM.TabIndex = 5;
            this.lblTongPM.Text = "0";
            // 
            // btnChiTietPhieuMuon
            // 
            this.btnChiTietPhieuMuon.Location = new System.Drawing.Point(450, 340);
            this.btnChiTietPhieuMuon.Name = "btnChiTietPhieuMuon";
            this.btnChiTietPhieuMuon.Size = new System.Drawing.Size(169, 23);
            this.btnChiTietPhieuMuon.TabIndex = 4;
            this.btnChiTietPhieuMuon.Text = "Chi tiết phiếu mượn";
            this.btnChiTietPhieuMuon.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(72, 17);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(205, 17);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 40);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(338, 17);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 40);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnSoanLai
            // 
            this.btnSoanLai.Location = new System.Drawing.Point(471, 17);
            this.btnSoanLai.Name = "btnSoanLai";
            this.btnSoanLai.Size = new System.Drawing.Size(100, 40);
            this.btnSoanLai.TabIndex = 3;
            this.btnSoanLai.Text = "Soạn lại";
            this.btnSoanLai.UseVisualStyleBackColor = true;
            this.btnSoanLai.Click += new System.EventHandler(this.btnSoanLai_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoanLai);
            this.groupBox3.Controls.Add(this.btnCapNhat);
            this.groupBox3.Controls.Add(this.btnXoa);
            this.groupBox3.Controls.Add(this.btnThem);
            this.groupBox3.Location = new System.Drawing.Point(12, 456);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 71);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 22);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(42, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Họ tên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ngày mượn:";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.Location = new System.Drawing.Point(450, 16);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(169, 20);
            this.dtNgayMuon.TabIndex = 13;
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.cbDocGia);
            this.groupBoxThongTinChiTiet.Controls.Add(this.dtNgayMuon);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label5);
            this.groupBoxThongTinChiTiet.Controls.Add(this.lbl);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 389);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(660, 52);
            this.groupBoxThongTinChiTiet.TabIndex = 14;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // cbDocGia
            // 
            this.cbDocGia.FormattingEnabled = true;
            this.cbDocGia.Location = new System.Drawing.Point(72, 19);
            this.cbDocGia.Name = "cbDocGia";
            this.cbDocGia.Size = new System.Drawing.Size(169, 21);
            this.cbDocGia.TabIndex = 14;
            // 
            // frmChoMuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Name = "frmChoMuonSach";
            this.Text = "Cho mượn sách";
            this.Load += new System.EventHandler(this.frmChoMuonSach_Load);
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.groupBoxThongTinBoPhan.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvChoMuonSach;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colNgayMuon;
        private System.Windows.Forms.Label lblTongNguoiMuon;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnSoanLai;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.Button btnChiTietPhieuMuon;
        private System.Windows.Forms.Label lblTongPM;
        private System.Windows.Forms.ComboBox cbDocGia;
    }
}