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
    public partial class frmTheLoaiSach : Form
    {
        TheLoaiSach tls = new TheLoaiSach();
        public frmTheLoaiSach()
        {
            InitializeComponent();
        }

        private void frmTheLoaiSach_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTheLoaiSach();
        }

        public void HienThiDanhSachTheLoaiSach()
        {
            lvTheLoaiSach.View = View.Details;
            lvTheLoaiSach.FullRowSelect = true;
            lvTheLoaiSach.Columns[1].Width = 273;
            lvTheLoaiSach.Items.Clear();
            string str;
            DataTable dt;
            dt = tls.LayDanhSachTheLoaiSach();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvTheLoaiSach.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["TenTheLoai"].ToString();
                lvi.SubItems.Add(str);
            }
        }

        private void lvTheLoaiSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvTheLoaiSach.SelectedIndices.Count > 0)
            {
                txtTenTheLoaiSach.Text = lvTheLoaiSach.Items[lvTheLoaiSach.SelectedIndices[0]].SubItems[1].Text;
            }
        }

        private void btnThemTheLoaiSach_Click(object sender, EventArgs e)
        {
            if (txtTenTheLoaiSach.Text != "")
            {
                tls.ThemTheLoaiSach(txtTenTheLoaiSach.Text);
                HienThiDanhSachTheLoaiSach();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenTheLoaiSach.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên thể loại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaTheLoaiSach_Click(object sender, EventArgs e)
        {
            if (lvTheLoaiSach.SelectedIndices.Count > 0)
            {
                string str = lvTheLoaiSach.Items[lvTheLoaiSach.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa thể loại ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lvTheLoaiSach.SelectedIndices[0];
                    tls.XoaTheLoaiSach(deleteIndex);
                    lvTheLoaiSach.Items.Remove(lvTheLoaiSach.SelectedItems[0]);
                    MessageBox.Show("Thể loại ’" + txtTenTheLoaiSach.Text + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenTheLoaiSach.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 thể loại sách trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCapNhatTheLoaiSach_Click(object sender, EventArgs e)
        {
            if (lvTheLoaiSach.SelectedIndices.Count > 0)
            {
                if (txtTenTheLoaiSach.Text != "")
                {
                    tls.CapNhatTheLoaiSach(lvTheLoaiSach.SelectedIndices[0], txtTenTheLoaiSach.Text);
                    HienThiDanhSachTheLoaiSach();
                    MessageBox.Show("Thể loại ’" + txtTenTheLoaiSach.Text + "’ đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenTheLoaiSach.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 thể loại sách trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLaiTheLoaiSach_Click(object sender, EventArgs e)
        {
            txtTenTheLoaiSach.Text = "";
        }
    }
}
