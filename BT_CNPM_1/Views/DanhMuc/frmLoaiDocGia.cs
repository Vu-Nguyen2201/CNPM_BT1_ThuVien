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
    public partial class frmLoaiDocGia : Form
    {
        LoaiDocGia ldg = new LoaiDocGia();

        public frmLoaiDocGia()
        {
            InitializeComponent();
        }

        private void frmLoaiDocGia_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLoaiDocGia();
        }

        public void HienThiDanhSachLoaiDocGia()
        {
            lvLoaiDocGia.View = View.Details;
            lvLoaiDocGia.FullRowSelect = true;
            lvLoaiDocGia.Columns[1].Width = 273;
            lvLoaiDocGia.Items.Clear();
            string str;
            DataTable dt;
            dt = ldg.LayDanhSachLoaiDocGia();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvLoaiDocGia.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["TenLoaiDocGia"].ToString();
                lvi.SubItems.Add(str);
            }
        }

        private void lvLoaiDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvLoaiDocGia.SelectedIndices.Count > 0)
            {
                txtTenLoaiDocGia.Text = lvLoaiDocGia.Items[lvLoaiDocGia.SelectedIndices[0]].SubItems[1].Text;
            }
        }

        private void btnThemLoaiDocGia_Click(object sender, EventArgs e)
        {
            if (txtTenLoaiDocGia.Text != "")
            {
                ldg.ThemLoaiDocGia(txtTenLoaiDocGia.Text);
                HienThiDanhSachLoaiDocGia();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenLoaiDocGia.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên loại độc giả", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaLoaiDocGia_Click(object sender, EventArgs e)
        {
            if (lvLoaiDocGia.SelectedIndices.Count > 0)
            {
                string str = lvLoaiDocGia.Items[lvLoaiDocGia.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa loại độc giả ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lvLoaiDocGia.SelectedIndices[0];
                    ldg.XoaLoaiDocGia(deleteIndex);
                    lvLoaiDocGia.Items.Remove(lvLoaiDocGia.SelectedItems[0]);
                    MessageBox.Show("Loại độc giả ’" + txtTenLoaiDocGia.Text + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenLoaiDocGia.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 loại độc giả sách trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCapNhatLoaiDocGia_Click(object sender, EventArgs e)
        {
            if (lvLoaiDocGia.SelectedIndices.Count > 0)
            {
                if (txtTenLoaiDocGia.Text != "")
                {
                    ldg.CapNhatLoaiDocGia(lvLoaiDocGia.SelectedIndices[0], txtTenLoaiDocGia.Text);
                    HienThiDanhSachLoaiDocGia();
                    MessageBox.Show("Loại độc giả ’" + txtTenLoaiDocGia.Text + "’ đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenLoaiDocGia.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 loại độc giả sách trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLaiLoaiDocGia_Click(object sender, EventArgs e)
        {
            txtTenLoaiDocGia.Text = "";
        }
    }
}
