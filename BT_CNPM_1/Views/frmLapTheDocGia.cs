using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.Controls;

namespace ThuVien.Views
{
    public partial class frmLapTheDocGia : Form
    {
        DocGia dg;
        NhanVien nv;
        LoaiDocGia ldg;
        public frmLapTheDocGia()
        {
            InitializeComponent();
            dg = new DocGia();
            nv = new NhanVien();
            ldg = new LoaiDocGia();
        }

        private void frmLapTheDocGia_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanVien();
            HienThiDanhSachLoaiDocGia();
            HienThiDanhSachDocGia();
        }

        private void HienThiDanhSachNhanVien()
        {
            DataTable dt = nv.LayDanhSachNhanVien();
            int i;
            string str;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                str = dt.Rows[i]["HoTenNhanVien"].ToString();
                cbNhanVien.Items.Add(str);
            }
            if (cbNhanVien.Items.Count > 0)
                cbNhanVien.SelectedIndex = 0;
        }

        private void HienThiDanhSachLoaiDocGia()
        {
            DataTable dt = ldg.LayDanhSachLoaiDocGia();
            int i;
            string str;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                str = dt.Rows[i]["TenLoaiDocGia"].ToString();
                cbLoaiDocGia.Items.Add(str);
            }
            if (cbLoaiDocGia.Items.Count > 0)
                cbLoaiDocGia.SelectedIndex = 0;
        }

        private void HienThiDanhSachDocGia()
        {
            lvDocGia.View = View.Details;
            lvDocGia.FullRowSelect = true;
            lvDocGia.Items.Clear();
            DataTable dt = dg.LayDanhSachDocGia();
            int i;
            string str;
            int ma;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvDocGia.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["HoTenDocGia"].ToString();
                lvi.SubItems.Add(str);

                ma = (int)dt.Rows[i]["LoaiDocGia"];
                str = cbLoaiDocGia.GetItemText(cbLoaiDocGia.Items[ma - 1]);
                lvi.SubItems.Add(str);

                ma = (int)dt.Rows[i]["MaNhanVien"];
                str = cbNhanVien.GetItemText(cbNhanVien.Items[ma - 1]);
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["TienNo"].ToString();
                lvi.SubItems.Add(str);
            }
            lblTong.Text = dt.Rows.Count.ToString();
        }

        private void lvDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDocGia.SelectedIndices.Count > 0)
                HienThiThongTinChiTiet(lvDocGia.SelectedIndices[0]);
        }
        private void HienThiThongTinChiTiet(int index)
        {
            DataTable dt;
            dt = dg.LayDanhSachDocGia();
            txtHoTenDocGia.Text = dt.Rows[index]["HoTenDocGia"].ToString();
            dtNgaySinh.Value = (DateTime)dt.Rows[index]["NgaySinh"];
            dtNgayLapThe.Value = (DateTime)dt.Rows[index]["NgayLapThe"];
            dtNgayHetHan.Value = (DateTime)dt.Rows[index]["NgayHetHan"];
            txtDiaChi.Text = dt.Rows[index]["Diachi"].ToString();
            txtEmail.Text = dt.Rows[index]["Email"].ToString();
            cbLoaiDocGia.SelectedIndex = cbLoaiDocGia.FindString(lvDocGia.Items[index].SubItems[2].Text);
            cbNhanVien.SelectedIndex = cbNhanVien.FindString(lvDocGia.Items[index].SubItems[3].Text);
            txtTienNo.Text = dt.Rows[index]["TienNo"].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {

        }
    }
}
