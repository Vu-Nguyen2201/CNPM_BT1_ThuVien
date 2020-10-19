namespace ThuVien.Views
{
    partial class frmThamSo
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
            this.btnSoanLaiThamSo = new System.Windows.Forms.Button();
            this.btnCapNhatThamSo = new System.Windows.Forms.Button();
            this.btnXoaThamSo = new System.Windows.Forms.Button();
            this.btnThemThamSo = new System.Windows.Forms.Button();
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txtGiaTri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenThamSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lvThamSo = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenThamSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGiaTri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoanLaiThamSo);
            this.groupBox3.Controls.Add(this.btnCapNhatThamSo);
            this.groupBox3.Controls.Add(this.btnXoaThamSo);
            this.groupBox3.Controls.Add(this.btnThemThamSo);
            this.groupBox3.Location = new System.Drawing.Point(12, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 85);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // btnSoanLaiThamSo
            // 
            this.btnSoanLaiThamSo.Location = new System.Drawing.Point(440, 35);
            this.btnSoanLaiThamSo.Name = "btnSoanLaiThamSo";
            this.btnSoanLaiThamSo.Size = new System.Drawing.Size(75, 23);
            this.btnSoanLaiThamSo.TabIndex = 3;
            this.btnSoanLaiThamSo.Text = "Soạn lại";
            this.btnSoanLaiThamSo.UseVisualStyleBackColor = true;
            this.btnSoanLaiThamSo.Click += new System.EventHandler(this.btnSoanLaiThamSo_Click);
            // 
            // btnCapNhatThamSo
            // 
            this.btnCapNhatThamSo.Location = new System.Drawing.Point(307, 35);
            this.btnCapNhatThamSo.Name = "btnCapNhatThamSo";
            this.btnCapNhatThamSo.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatThamSo.TabIndex = 2;
            this.btnCapNhatThamSo.Text = "Cập nhật";
            this.btnCapNhatThamSo.UseVisualStyleBackColor = true;
            this.btnCapNhatThamSo.Click += new System.EventHandler(this.btnCapNhatThamSo_Click);
            // 
            // btnXoaThamSo
            // 
            this.btnXoaThamSo.Location = new System.Drawing.Point(174, 35);
            this.btnXoaThamSo.Name = "btnXoaThamSo";
            this.btnXoaThamSo.Size = new System.Drawing.Size(75, 23);
            this.btnXoaThamSo.TabIndex = 1;
            this.btnXoaThamSo.Text = "Xoá";
            this.btnXoaThamSo.UseVisualStyleBackColor = true;
            this.btnXoaThamSo.Click += new System.EventHandler(this.btnXoaThamSo_Click);
            // 
            // btnThemThamSo
            // 
            this.btnThemThamSo.Location = new System.Drawing.Point(41, 35);
            this.btnThemThamSo.Name = "btnThemThamSo";
            this.btnThemThamSo.Size = new System.Drawing.Size(75, 23);
            this.btnThemThamSo.TabIndex = 0;
            this.btnThemThamSo.Text = "Thêm";
            this.btnThemThamSo.UseVisualStyleBackColor = true;
            this.btnThemThamSo.Click += new System.EventHandler(this.btnThemThamSo_Click);
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtGiaTri);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label2);
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtTenThamSo);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label1);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 358);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(560, 100);
            this.groupBoxThongTinChiTiet.TabIndex = 5;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // txtGiaTri
            // 
            this.txtGiaTri.Location = new System.Drawing.Point(415, 38);
            this.txtGiaTri.Name = "txtGiaTri";
            this.txtGiaTri.Size = new System.Drawing.Size(100, 20);
            this.txtGiaTri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giá trị";
            // 
            // txtTenThamSo
            // 
            this.txtTenThamSo.Location = new System.Drawing.Point(149, 38);
            this.txtTenThamSo.Name = "txtTenThamSo";
            this.txtTenThamSo.Size = new System.Drawing.Size(100, 20);
            this.txtTenThamSo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tham số";
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lvThamSo);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(560, 340);
            this.groupBoxThongTinBoPhan.TabIndex = 4;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin tham số";
            // 
            // lvThamSo
            // 
            this.lvThamSo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenThamSo,
            this.colGiaTri});
            this.lvThamSo.HideSelection = false;
            this.lvThamSo.Location = new System.Drawing.Point(6, 19);
            this.lvThamSo.Name = "lvThamSo";
            this.lvThamSo.Size = new System.Drawing.Size(548, 315);
            this.lvThamSo.TabIndex = 0;
            this.lvThamSo.UseCompatibleStateImageBehavior = false;
            this.lvThamSo.SelectedIndexChanged += new System.EventHandler(this.lvThamSo_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colTenThamSo
            // 
            this.colTenThamSo.Text = "Tên tham số";
            // 
            // colGiaTri
            // 
            this.colGiaTri.Text = "Giá trị";
            // 
            // frmThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Name = "frmThamSo";
            this.Text = "Tham số";
            this.Load += new System.EventHandler(this.frmThamSo_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSoanLaiThamSo;
        private System.Windows.Forms.Button btnCapNhatThamSo;
        private System.Windows.Forms.Button btnXoaThamSo;
        private System.Windows.Forms.Button btnThemThamSo;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.TextBox txtTenThamSo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.ListView lvThamSo;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenThamSo;
        private System.Windows.Forms.ColumnHeader colGiaTri;
        private System.Windows.Forms.TextBox txtGiaTri;
        private System.Windows.Forms.Label label2;
    }
}