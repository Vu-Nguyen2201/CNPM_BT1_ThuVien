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
    public partial class frmLyDoThanhLy : Form
    {
        LyDoThanhLy ld = new LyDoThanhLy();

        public frmLyDoThanhLy()
        {
            InitializeComponent();
        }

        private void frmLyDoThanhLy_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLyDo();
        }

        public void HienThiDanhSachLyDo()
        {
            lvLyDoThanhLy.View = View.Details;
            lvLyDoThanhLy.FullRowSelect = true;
            lvLyDoThanhLy.Columns[1].Width = 273;
            lvLyDoThanhLy.Items.Clear();
            string str;
            DataTable dt;
            dt = ld.LayDanhSachLyDoThanhLy();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvLyDoThanhLy.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["TenLyDo"].ToString();
                lvi.SubItems.Add(str);
            }
        }

        private void btnThemLyDoThanhLy_Click(object sender, EventArgs e)
        {
            if (txtLyDoThanhLy.Text != "")
            {
                ld.ThemLyDoThanhLy(txtLyDoThanhLy.Text);
                HienThiDanhSachLyDo();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLyDoThanhLy.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên lý do", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaLyDoThanhLy_Click(object sender, EventArgs e)
        {
            if (lvLyDoThanhLy.SelectedIndices.Count > 0)
            {
                string str = lvLyDoThanhLy.Items[lvLyDoThanhLy.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa lý do ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lvLyDoThanhLy.SelectedIndices[0];
                    ld.XoaLyDoThanhLy(deleteIndex);
                    lvLyDoThanhLy.Items.Remove(lvLyDoThanhLy.SelectedItems[0]);
                    MessageBox.Show("Lý do ’" + txtLyDoThanhLy.Text + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLyDoThanhLy.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 lý do trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCapNhatLyDoThanhLy_Click(object sender, EventArgs e)
        {
            if (lvLyDoThanhLy.SelectedIndices.Count > 0)
            {
                if (txtLyDoThanhLy.Text != "")
                {
                    ld.CapNhatLyDoThanhLy(lvLyDoThanhLy.SelectedIndices[0], txtLyDoThanhLy.Text);
                    HienThiDanhSachLyDo();
                    MessageBox.Show("Lý do ’" + txtLyDoThanhLy.Text + "’ đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLyDoThanhLy.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 lý do trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLaiLyDoThanhLy_Click(object sender, EventArgs e)
        {
            txtLyDoThanhLy.Text = "";
        }

        private void lvLyDoThanhLy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvLyDoThanhLy.SelectedIndices.Count > 0)
            {
                txtLyDoThanhLy.Text = lvLyDoThanhLy.Items[lvLyDoThanhLy.SelectedIndices[0]].SubItems[1].Text;
            }
        }
    }
}
