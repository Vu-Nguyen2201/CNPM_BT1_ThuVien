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
    public partial class frmBoPhan : Form
    {
        BoPhan bp = new BoPhan();
        public frmBoPhan()
        {
            InitializeComponent();
        }
        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBoPhan();
        }
        public void HienThiDanhSachBoPhan()
        {
            lvBoPhan.View = View.Details;
            lvBoPhan.FullRowSelect = true;
            lvBoPhan.Columns[1].Width = 273;
            lvBoPhan.Items.Clear();
            string str;
            DataTable dt;
            dt = bp.LayDanhSachBoPhan ();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvBoPhan.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["TenBoPhan"].ToString();
                lvi.SubItems.Add(str);
            }
        }
        private void lvBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvBoPhan.SelectedIndices.Count > 0)
            {
                txtTenBoPhan.Text = lvBoPhan.Items[lvBoPhan.SelectedIndices[0]].SubItems[1].Text;
            }
        }

        private void btnThemBoPhan_Click(object sender, EventArgs e)
        {
            if (txtTenBoPhan.Text != "")
            {
                bp.ThemBoPhan(txtTenBoPhan.Text);
                HienThiDanhSachBoPhan();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenBoPhan.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên bộ phận", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaBoPhan_Click(object sender, EventArgs e)
        {
            if (lvBoPhan.SelectedIndices.Count > 0)
            {
                string str = lvBoPhan.Items[lvBoPhan.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa bộ phận ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lvBoPhan.SelectedIndices[0];
                    bp.XoaBoPhan(deleteIndex);
                    lvBoPhan.Items.Remove(lvBoPhan.SelectedItems[0]);
                    MessageBox.Show("Bộ phận ’" + txtTenBoPhan.Text + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenBoPhan.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 bộ phận trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCapNhatBoPhan_Click(object sender, EventArgs e)
        {
            if (lvBoPhan.SelectedIndices.Count > 0)
            {
                if (txtTenBoPhan.Text != "")
                {
                    bp.CapNhatBoPhan(lvBoPhan.SelectedIndices[0], txtTenBoPhan.Text);
                    HienThiDanhSachBoPhan();
                    MessageBox.Show("Bộ phận ’" + txtTenBoPhan.Text + "’ đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenBoPhan.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 bộ phận trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLaiBoPhan_Click(object sender, EventArgs e)
        {
            txtTenBoPhan.Text = "";
        }

    }
}
