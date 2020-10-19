namespace ThuVien.Views
{
    partial class frmBoPhan
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
            this.groupBoxThongTinBoPhan = new System.Windows.Forms.GroupBox();
            this.lvBoPhan = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenBoPhan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxThongTinChiTiet = new System.Windows.Forms.GroupBox();
            this.txtTenBoPhan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSoanLaiBoPhan = new System.Windows.Forms.Button();
            this.btnCapNhatBoPhan = new System.Windows.Forms.Button();
            this.btnXoaBoPhan = new System.Windows.Forms.Button();
            this.btnThemBoPhan = new System.Windows.Forms.Button();
            this.groupBoxThongTinBoPhan.SuspendLayout();
            this.groupBoxThongTinChiTiet.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxThongTinBoPhan
            // 
            this.groupBoxThongTinBoPhan.Controls.Add(this.lvBoPhan);
            this.groupBoxThongTinBoPhan.Location = new System.Drawing.Point(12, 12);
            this.groupBoxThongTinBoPhan.Name = "groupBoxThongTinBoPhan";
            this.groupBoxThongTinBoPhan.Size = new System.Drawing.Size(560, 340);
            this.groupBoxThongTinBoPhan.TabIndex = 1;
            this.groupBoxThongTinBoPhan.TabStop = false;
            this.groupBoxThongTinBoPhan.Text = "Thông tin bộ phận";
            // 
            // lvBoPhan
            // 
            this.lvBoPhan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colTenBoPhan});
            this.lvBoPhan.HideSelection = false;
            this.lvBoPhan.Location = new System.Drawing.Point(6, 19);
            this.lvBoPhan.Name = "lvBoPhan";
            this.lvBoPhan.Size = new System.Drawing.Size(548, 315);
            this.lvBoPhan.TabIndex = 0;
            this.lvBoPhan.UseCompatibleStateImageBehavior = false;
            this.lvBoPhan.SelectedIndexChanged += new System.EventHandler(this.lvBoPhan_SelectedIndexChanged);
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colTenBoPhan
            // 
            this.colTenBoPhan.Text = "Tên bộ phận";
            // 
            // groupBoxThongTinChiTiet
            // 
            this.groupBoxThongTinChiTiet.Controls.Add(this.txtTenBoPhan);
            this.groupBoxThongTinChiTiet.Controls.Add(this.label1);
            this.groupBoxThongTinChiTiet.Location = new System.Drawing.Point(12, 358);
            this.groupBoxThongTinChiTiet.Name = "groupBoxThongTinChiTiet";
            this.groupBoxThongTinChiTiet.Size = new System.Drawing.Size(560, 100);
            this.groupBoxThongTinChiTiet.TabIndex = 2;
            this.groupBoxThongTinChiTiet.TabStop = false;
            this.groupBoxThongTinChiTiet.Text = "Thông tin chi tiết";
            // 
            // txtTenBoPhan
            // 
            this.txtTenBoPhan.Location = new System.Drawing.Point(149, 38);
            this.txtTenBoPhan.Name = "txtTenBoPhan";
            this.txtTenBoPhan.Size = new System.Drawing.Size(100, 20);
            this.txtTenBoPhan.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bộ phận";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSoanLaiBoPhan);
            this.groupBox3.Controls.Add(this.btnCapNhatBoPhan);
            this.groupBox3.Controls.Add(this.btnXoaBoPhan);
            this.groupBox3.Controls.Add(this.btnThemBoPhan);
            this.groupBox3.Location = new System.Drawing.Point(12, 464);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(560, 85);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btnSoanLaiBoPhan
            // 
            this.btnSoanLaiBoPhan.Location = new System.Drawing.Point(440, 35);
            this.btnSoanLaiBoPhan.Name = "btnSoanLaiBoPhan";
            this.btnSoanLaiBoPhan.Size = new System.Drawing.Size(75, 23);
            this.btnSoanLaiBoPhan.TabIndex = 3;
            this.btnSoanLaiBoPhan.Text = "Soạn lại";
            this.btnSoanLaiBoPhan.UseVisualStyleBackColor = true;
            this.btnSoanLaiBoPhan.Click += new System.EventHandler(this.btnSoanLaiBoPhan_Click);
            // 
            // btnCapNhatBoPhan
            // 
            this.btnCapNhatBoPhan.Location = new System.Drawing.Point(307, 35);
            this.btnCapNhatBoPhan.Name = "btnCapNhatBoPhan";
            this.btnCapNhatBoPhan.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhatBoPhan.TabIndex = 2;
            this.btnCapNhatBoPhan.Text = "Cập nhật";
            this.btnCapNhatBoPhan.UseVisualStyleBackColor = true;
            this.btnCapNhatBoPhan.Click += new System.EventHandler(this.btnCapNhatBoPhan_Click);
            // 
            // btnXoaBoPhan
            // 
            this.btnXoaBoPhan.Location = new System.Drawing.Point(174, 35);
            this.btnXoaBoPhan.Name = "btnXoaBoPhan";
            this.btnXoaBoPhan.Size = new System.Drawing.Size(75, 23);
            this.btnXoaBoPhan.TabIndex = 1;
            this.btnXoaBoPhan.Text = "Xoá";
            this.btnXoaBoPhan.UseVisualStyleBackColor = true;
            this.btnXoaBoPhan.Click += new System.EventHandler(this.btnXoaBoPhan_Click);
            // 
            // btnThemBoPhan
            // 
            this.btnThemBoPhan.Location = new System.Drawing.Point(41, 35);
            this.btnThemBoPhan.Name = "btnThemBoPhan";
            this.btnThemBoPhan.Size = new System.Drawing.Size(75, 23);
            this.btnThemBoPhan.TabIndex = 0;
            this.btnThemBoPhan.Text = "Thêm";
            this.btnThemBoPhan.UseVisualStyleBackColor = true;
            this.btnThemBoPhan.Click += new System.EventHandler(this.btnThemBoPhan_Click);
            // 
            // frmBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBoxThongTinChiTiet);
            this.Controls.Add(this.groupBoxThongTinBoPhan);
            this.Name = "frmBoPhan";
            this.Text = "Bộ phận";
            this.Load += new System.EventHandler(this.frmBoPhan_Load);
            this.groupBoxThongTinBoPhan.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.ResumeLayout(false);
            this.groupBoxThongTinChiTiet.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxThongTinBoPhan;
        private System.Windows.Forms.ListView lvBoPhan;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colTenBoPhan;
        private System.Windows.Forms.GroupBox groupBoxThongTinChiTiet;
        private System.Windows.Forms.TextBox txtTenBoPhan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSoanLaiBoPhan;
        private System.Windows.Forms.Button btnCapNhatBoPhan;
        private System.Windows.Forms.Button btnXoaBoPhan;
        private System.Windows.Forms.Button btnThemBoPhan;
    }
}