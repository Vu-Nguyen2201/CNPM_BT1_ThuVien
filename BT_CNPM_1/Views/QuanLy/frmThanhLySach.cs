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
    public partial class frmThanhLySach : Form
    {
        PhieuThanhLy ptl;
        NhanVien nv;
        public frmThanhLySach()
        {
            InitializeComponent();
            ptl = new PhieuThanhLy();
            nv = new NhanVien();
        }

        private void frmThanhLySach_Load(object sender, EventArgs e)
        {
            HienThiDanhSachNhanvien();
            HienThiDanhSachPhieuThanhLy();
        }

        private void HienThiDanhSachNhanvien()
        {
            DataTable dt = nv.LayDanhSachNhanVien();
            string str;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                str = dt.Rows[i]["HoTenNhanVien"].ToString();
                cbNhanVien.Items.Add(str);
            }
            if (cbNhanVien.Items.Count > 0)
            {
                cbNhanVien.SelectedIndex = 0;
            }
        }

        private void HienThiDanhSachPhieuThanhLy()
        {
            lvThanhLySach.View = View.Details;
            lvThanhLySach.FullRowSelect = true;
            lvThanhLySach.Items.Clear();
            DataTable dt = ptl.LayDanhSachPhieuThanhLy();
            int i;
            string str;
            int ma;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvThanhLySach.Items.Add((i + 1).ToString()); //Số thứ tự của nhân viên

                ma = (int)dt.Rows[i]["MaNhanVien"];
                str = cbNhanVien.GetItemText(cbNhanVien.Items[ma - 1]);
                lvi.SubItems.Add(str);

                str = dt.Rows[i]["NgayThanhLy"].ToString();
                lvi.SubItems.Add(str);
            }
            //Hiển thị tổng số nhân viên
            lblTong.Text = dt.Rows.Count.ToString();
        }

        private void lvChoMuonSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThanhLySach.SelectedIndices.Count > 0)
                HienThiThongTinChiTiet(lvThanhLySach.SelectedIndices[0]);
        }

        private void HienThiThongTinChiTiet(int index)
        {
            DataTable dt;
            dt = ptl.LayDanhSachPhieuThanhLy();
            dtNgayThanhLy.Value = (DateTime)dt.Rows[index]["NgayThanhLy"];
            cbNhanVien.SelectedIndex = cbNhanVien.FindString(lvThanhLySach.Items[index].SubItems[1].Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ptl.ThemPhieuThanhLy(
                dtNgayThanhLy.Value.ToString("MM/dd/yyyy"),
                cbNhanVien.SelectedIndex);
            HienThiDanhSachPhieuThanhLy();
            MessageBox.Show("Phiếu thanh lý của nhân viên ’" + cbNhanVien.SelectedItem.ToString() + "’ đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SoanLai();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvThanhLySach.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa phiếu thanh lý của nhân viên ’" +
                lvThanhLySach.Items[lvThanhLySach.SelectedIndices[0]].SubItems[1].Text + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                    ptl.XoaPhieuThanhLy(lvThanhLySach.SelectedIndices[0]);
                HienThiDanhSachPhieuThanhLy();
                MessageBox.Show("Phiếu thanh lý của nhân viên ’" + cbNhanVien.SelectedItem.ToString() + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoanLai();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 phiếu thanh lý trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvThanhLySach.SelectedIndices.Count > 0)
            {
                ptl.CapNhatPhieuThanhLy(
                    lvThanhLySach.SelectedIndices[0],
                    dtNgayThanhLy.Value.ToString("MM/dd/yyyy"),
                    cbNhanVien.SelectedIndex);

                HienThiDanhSachPhieuThanhLy();
                MessageBox.Show("Phiếu thanh lý của nhân viên ’" + cbNhanVien.SelectedItem.ToString() + "’đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 phiếu thanh lý trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            SoanLai();
        }
        private void SoanLai()
        {

            dtNgayThanhLy.Value = DateTime.Today;
            cbNhanVien.SelectedIndex = 0;
        }
    }
}
