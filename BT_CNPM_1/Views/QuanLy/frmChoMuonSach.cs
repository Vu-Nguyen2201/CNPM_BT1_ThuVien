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
    public partial class frmChoMuonSach : Form
    {
        PhieuMuonSach pms;
        DocGia dg;
        public frmChoMuonSach()
        {
            InitializeComponent();
            pms = new PhieuMuonSach();
            dg = new DocGia();
        }

        private void frmChoMuonSach_Load(object sender, EventArgs e)
        {
            HienThiDanhSachDocGia();
            HienThiDanhSachPhieuMuon();
        }

        private void HienThiDanhSachDocGia()
        {
            DataTable dt = dg.LayDanhSachDocGia();
            string str;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                str = dt.Rows[i]["HoTenDocGia"].ToString();
                cbDocGia.Items.Add(str);
            }
            if(cbDocGia.Items.Count > 0)
            {
                cbDocGia.SelectedIndex = 0;
            }
        }

        private void HienThiDanhSachPhieuMuon()
        {
            lvChoMuonSach.View = View.Details;
            lvChoMuonSach.FullRowSelect = true;
            lvChoMuonSach.Items.Clear();
            DataTable dt = pms.LayDanhSachPhieuMuonSach();
            int i;
            string str;
            int ma;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvChoMuonSach.Items.Add((i + 1).ToString()); //Số thứ tự của nhân viên
                ma = (int)dt.Rows[i]["MaDocGia"];
                str = cbDocGia.GetItemText(cbDocGia.Items[ma - 1]);
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["NgayMuon"].ToString();
                lvi.SubItems.Add(str);
            }
            lblTong.Text = dt.Rows.Count.ToString();
        }

        private void lvChoMuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChoMuonSach.SelectedIndices.Count > 0)
                HienThiThongTinChiTiet(lvChoMuonSach.SelectedIndices[0]);
        }

        private void HienThiThongTinChiTiet(int index)
        {
            DataTable dt;
            dt = pms.LayDanhSachPhieuMuonSach();
            dtNgayMuon.Value = (DateTime)dt.Rows[index]["NgayMuon"];
            cbDocGia.SelectedIndex = cbDocGia.FindString(lvChoMuonSach.Items[index].SubItems[1].Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            pms.ThemPhieuMuon(
                dtNgayMuon.Value.ToString("MM/dd/yyyy"),
                cbDocGia.SelectedIndex);
            HienThiDanhSachPhieuMuon();

            MessageBox.Show("Phiếu mượn của ’" + cbDocGia.SelectedItem.ToString() + "’ đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SoanLai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvChoMuonSach.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa phiếu mượn của ’" +
                lvChoMuonSach.Items[lvChoMuonSach.SelectedIndices[0]].SubItems[1].Text + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                pms.XoaPhieuMuonSach(lvChoMuonSach.SelectedIndices[0]);
                HienThiDanhSachPhieuMuon();
                MessageBox.Show("Phiếu mượn của ’" + cbDocGia.SelectedItem.ToString() + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoanLai();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 phiếu mượn trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvChoMuonSach.SelectedIndices.Count > 0)
            {
                pms.CapNhatPhieuMuon(
                    lvChoMuonSach.SelectedIndices[0],
                    dtNgayMuon.Value.ToString("MM/dd/yyyy"), 
                    cbDocGia.SelectedIndex);

                HienThiDanhSachPhieuMuon();
                MessageBox.Show("Phiếu mượn của ’" + cbDocGia.SelectedItem.ToString() + "’đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            SoanLai();
        }
        private void SoanLai()
        {

            dtNgayMuon.Value = DateTime.Today;
            cbDocGia.SelectedIndex = 0;
        }
    }
}