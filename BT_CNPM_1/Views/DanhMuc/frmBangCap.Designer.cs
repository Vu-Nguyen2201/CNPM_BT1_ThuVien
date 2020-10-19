namespace ThuVien.Views
{
    partial class frmBangCap
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
            this.groupBoxThongTinBangCap = new System.Windows.Forms.GroupBox();
            this.lvBangCap = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenBangCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txtTenBangCap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSoanLai = new System.Windows.Forms.Button();
            this.btnCapNhatBangCap = new System.Windows.Forms.Button();
            this.btnXoaBangCap = new System.Windows.Forms.Button();
            this.btnThemBangCap = new System.Windows.Forms.Button();
            this.groupBoxThongTinBangCap.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxThongTinBangCap
            // 
            this.groupBoxThongTinBangCap.Controls.Add(this.lvBangCap);
            this.groupBoxThongTinBangCap.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinBangCap.Name = "groupBoxThongTinBangCap";
            this.groupBoxThongTinBangCap.Size = new System.Drawing.Size(561, 340);
            this.groupBoxThongTinBangCap.TabIndex = 0;
            this.groupBoxThongTinBangCap.TabStop = false;
            this.groupBoxThongTinBangCap.Text = "Thông tin bằng cấp";
            // 
            // lvBangCap
            // 
            this.lvBangCap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenBangCap});
            this.lvBangCap.HideSelection = false;
            this.lvBangCap.Location = new System.Drawing.Point(6, 19);
            this.lvBangCap.Name = "lvBangCap";
            this.lvBangCap.Size = new System.Drawing.Size(549, 315);
            this.lvBangCap.TabIndex = 0;
            this.lvBangCap.UseCompatibleStateImageBehavior = false;
            this.lvBangCap.SelectedIndexChanged += new System.EventHandler(this.lvBangCap_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colTenBangCap
            // 
            this.colTenBangCap.Text = "Tên";
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtTenBangCap);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label1);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 358);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(561, 100);
            this.groupBoxThongTinChiTiet.TabIndex = 1;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // txtTenBangCap
            // 
            this.txtTenBangCap.Location = new System.Drawing.Point(149, 38);
            this.txtTenBangCap.Name = "txtTenBangCap";
            this.txtTenBangCap.Size = new System.Drawing.Size(100, 20);
            this.txtTenBangCap.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bằng cấp";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoanLai);
            this.groupBox3.Controls.Add(this.btnCapNhatBangCap);
            this.groupBox3.Controls.Add(this.btnXoaBangCap);
            this.groupBox3.Controls.Add(this.btnThemBangCap);
            this.groupBox3.Location = new System.Drawing.Point(12, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(561, 85);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnSoanLai
            // 
            this.btnSoanLai.Location = new System.Drawing.Point(440, 35);
            this.btnSoanLai.Name = "btnSoanLai";
            this.btnSoanLai.Size = new System.Drawing.Size(75, 23);
            this.btnSoanLai.TabIndex = 3;
            this.btnSoanLai.Text = "Soạn lại";
            this.btnSoanLai.UseVisualStyleBackColor = true;
            this.btnSoanLai.Click += new System.EventHandler(this.btnSoanLai_Click);
            // 
            // btnCapNhatBangCap
            // 
            this.btnCapNhatBangCap.Location = new System.Drawing.Point(307, 35);
            this.btnCapNhatBangCap.Name = "btnCapNhatBangCap";
            this.btnCapNhatBangCap.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatBangCap.TabIndex = 2;
            this.btnCapNhatBangCap.Text = "Cập nhật";
            this.btnCapNhatBangCap.UseVisualStyleBackColor = true;
            this.btnCapNhatBangCap.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoaBangCap
            // 
            this.btnXoaBangCap.Location = new System.Drawing.Point(174, 35);
            this.btnXoaBangCap.Name = "btnXoaBangCap";
            this.btnXoaBangCap.Size = new System.Drawing.Size(75, 23);
            this.btnXoaBangCap.TabIndex = 1;
            this.btnXoaBangCap.Text = "Xoá";
            this.btnXoaBangCap.UseVisualStyleBackColor = true;
            this.btnXoaBangCap.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemBangCap
            // 
            this.btnThemBangCap.Location = new System.Drawing.Point(41, 35);
            this.btnThemBangCap.Name = "btnThemBangCap";
            this.btnThemBangCap.Size = new System.Drawing.Size(75, 23);
            this.btnThemBangCap.TabIndex = 0;
            this.btnThemBangCap.Text = "Thêm";
            this.btnThemBangCap.UseVisualStyleBackColor = true;
            this.btnThemBangCap.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmBangCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Controls.Add(this.groupBoxThongTinBangCap);
            this.Name = "frmBangCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bằng cấp";
            this.Load += new System.EventHandler(this.frmBangCap_Load);
            this.groupBoxThongTinBangCap.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinBangCap;
        private System.Windows.Forms.ListView lvBangCap;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenBangCap;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.TextBox txtTenBangCap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSoanLai;
        private System.Windows.Forms.Button btnCapNhatBangCap;
        private System.Windows.Forms.Button btnXoaBangCap;
        private System.Windows.Forms.Button btnThemBangCap;
    }
}

