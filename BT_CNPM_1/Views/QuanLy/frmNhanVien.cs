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
    public partial class frmNhanVien : Form
    {
        NhanVien nv;
        BangCap bc;
        BoPhan bp;
        ChucVu cv;

        public frmNhanVien()
        {
            InitializeComponent();
            //Khởi tạo lớp
            nv = new NhanVien();
            bc = new BangCap();
            bp = new BoPhan();
            cv = new ChucVu();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            //Load dữ liệu lên Form.
            HienThiDanhSachBangCap();
            HienThiDanhSachBoPhan();
            HienThiDanhSachChucVu();
            HienThiDanhSachNhanVien();
        }

        private void HienThiDanhSachBangCap()
        {
            DataTable dt = bc.LayDanhSachBangCap();
            //Việc lấy dữ liệu được ủy nhiệm cho biến thuộc lớp xử lý (lớp NhanVien) chứ không trực tiếp thực hiện ở đây
            int i;
            string str;
            //Nạp dữ liệu lên combobox
            for (i = 0; i < dt.Rows.Count; i++)
            {
                str = dt.Rows[i]["TenBangCap"].ToString();
                cbBangCap.Items.Add(str);
            }
            if (cbBangCap.Items.Count > 0)
                cbBangCap.SelectedIndex = 0;
        }

        private void HienThiDanhSachBoPhan()
        {
            DataTable dt = bp.LayDanhSachBoPhan();
            int i;
            string str;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                str = dt.Rows[i]["TenBoPhan"].ToString();
                cbBoPhan.Items.Add(str);
            }
            if (cbBoPhan.Items.Count > 0)
                cbBoPhan.SelectedIndex = 0;
        }

        private void HienThiDanhSachChucVu()
        {
            DataTable dt = cv.LayDanhSachChucVu();
            int i;
            string str;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                str = dt.Rows[i]["TenChucVu"].ToString();
                cbChucVu.Items.Add(str);
            }
            if (cbChucVu.Items.Count > 0)
                cbChucVu.SelectedIndex = 0;
        }

        private void HienThiDanhSachNhanVien()
        {
            lvNhanVien.View = View.Details;
            lvNhanVien.FullRowSelect = true;
            lvNhanVien.Items.Clear();
            DataTable dt = nv.LayDanhSachNhanVien();
            int i;
            string str;
            int ma;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvNhanVien.Items.Add((i + 1).ToString()); //Số thứ tự của nhân viên
                str = dt.Rows[i]["HoTenNhanVien"].ToString();
                lvi.SubItems.Add(str);

                ma = (int)dt.Rows[i]["MaBangCap"];
                str = cbBangCap.GetItemText(cbBangCap.Items[ma - 1]);
                lvi.SubItems.Add(str);

                ma = (int)dt.Rows[i]["MaBoPhan"];
                str = cbBoPhan.GetItemText(cbBoPhan.Items[ma - 1]);
                lvi.SubItems.Add(str);

                ma = (int)dt.Rows[i]["MaChucVu"];
                str = cbChucVu.GetItemText(cbChucVu.Items[ma - 1]);
                lvi.SubItems.Add(str);
            }
            //Hiển thị tổng số nhân viên
            lblTong.Text = dt.Rows.Count.ToString();
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedIndices.Count > 0)
                HienThiThongTinChiTiet(lvNhanVien.SelectedIndices[0]);
        }
        private void HienThiThongTinChiTiet(int index)
        {
            DataTable dt;
            dt = nv.LayDanhSachNhanVien();
            txtHoTen.Text = dt.Rows[index]["HoTenNhanVien"].ToString();
            dtNgaySinh.Value = (DateTime)dt.Rows[index]["NgaySinh"];
            txtDiaChi.Text = dt.Rows[index]["Diachi"].ToString();
            txtDienThoai.Text = dt.Rows[index]["DienThoai"].ToString();
            cbBangCap.SelectedIndex = cbBangCap.FindString(lvNhanVien.Items[index].SubItems[2].Text);
            cbBoPhan.SelectedIndex = cbBoPhan.FindString(lvNhanVien.Items[index].SubItems[3].Text);
            cbChucVu.SelectedIndex = cbChucVu.FindString(lvNhanVien.Items[index].SubItems[4].Text);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KiemTraNhap() == true)
            {
                nv.ThemNhanVien(txtHoTen.Text, dtNgaySinh.Value.ToString("MM/dd/yyyy"),
                txtDiaChi.Text, txtDienThoai.Text, cbBangCap.SelectedIndex, cbBoPhan.SelectedIndex,
                cbChucVu.SelectedIndex);
                //Hiển thị lại danh sách nhân viên
                HienThiDanhSachNhanVien();
                MessageBox.Show("Nhân viên ’" + txtHoTen.Text + "’ đã được thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoanLai();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa nhân viên ’" +
                txtHoTen.Text + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
                nv.XoaNhanVien(lvNhanVien.SelectedIndices[0]);
                HienThiDanhSachNhanVien();
                //Thông báo xóa thành công
                MessageBox.Show("Nhân viên ’" + txtHoTen.Text + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SoanLai();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 nhân viên trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedIndices.Count > 0)
            {
                if (KiemTraNhap() == true)
                {
                    nv.CapNhatNhanVien(lvNhanVien.SelectedIndices[0], txtHoTen.Text,
                    dtNgaySinh.Value.ToString("MM/dd/yyyy"), txtDiaChi.Text, txtDienThoai.Text, cbBangCap.SelectedIndex,
                    cbBoPhan.SelectedIndex, cbChucVu.SelectedIndex);
                    //Hiển thị lại danh sách nhân viên
                    HienThiDanhSachNhanVien();
                    //Thông báo cập nhật thành công
                    MessageBox.Show("Nhân viên ’" + txtHoTen.Text + "’đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
            txtHoTen.Text = "";
            dtNgaySinh.Value = DateTime.Today;
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            cbBangCap.SelectedIndex = 0;
        }

        public bool KiemTraNhap()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên nhân viên", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
