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

    public partial class frmChucVu : Form
    {
        ChucVu cv = new ChucVu();
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            HienThiDanhSachChucVu();
        }

        public void HienThiDanhSachChucVu()
        {
            lvChucVu.View = View.Details;
            lvChucVu.FullRowSelect = true;
            lvChucVu.Columns[1].Width = 273;
            lvChucVu.Items.Clear();
            string str;
            DataTable dt;
            dt = cv.LayDanhSachChucVu();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvChucVu.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["TenChucVu"].ToString();
                lvi.SubItems.Add(str);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtChucVu.Text != "")
            {
                cv.ThemChucVu(txtChucVu.Text);
                HienThiDanhSachChucVu();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChucVu.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên chức vụ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvChucVu.SelectedIndices.Count > 0)
            {
                if (txtChucVu.Text != "")
                {
                    cv.CapNhatChucVu(lvChucVu.SelectedIndices[0], txtChucVu.Text);
                    HienThiDanhSachChucVu();
                    MessageBox.Show("Chức vụ ’" + txtChucVu.Text + "’ đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChucVu.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 chức vụ trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvChucVu.SelectedIndices.Count > 0)
            {
                string str = lvChucVu.Items[lvChucVu.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa chức vụ ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lvChucVu.SelectedIndices[0];
                    cv.XoaChucVu(deleteIndex);
                    lvChucVu.Items.Remove(lvChucVu.SelectedItems[0]);
                    MessageBox.Show("Chức vụ ’" + txtChucVu.Text + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtChucVu.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 chức vụ trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            txtChucVu.Text = "";
        }

        private void lvChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvChucVu.SelectedIndices.Count > 0)
            {
                txtChucVu.Text = lvChucVu.Items[lvChucVu.SelectedIndices[0]].SubItems[1].Text;
            }
        }
    }
}
