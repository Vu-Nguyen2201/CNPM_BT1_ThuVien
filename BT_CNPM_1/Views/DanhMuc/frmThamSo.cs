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
    public partial class frmThamSo : Form
    {
        ThamSo ts = new ThamSo();

        public frmThamSo()
        {
            InitializeComponent();
        }

        private void frmThamSo_Load(object sender, EventArgs e)
        {
            HienThiDanhSachThamSo();
        }

        public void HienThiDanhSachThamSo()
        {
            lvThamSo.View = View.Details;
            lvThamSo.FullRowSelect = true;
            lvThamSo.Columns[1].Width = 200;
            lvThamSo.Columns[2].Width = 200;
            lvThamSo.Items.Clear();
            string str;
            DataTable dt;
            dt = ts.LayDanhSachThamSo();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvThamSo.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["TenThamSo"].ToString();
                lvi.SubItems.Add(str);
                str = dt.Rows[i]["GiaTri"].ToString();
                lvi.SubItems.Add(str);
            }
        }

        private void lvThamSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvThamSo.SelectedIndices.Count > 0)
            {
                txtTenThamSo.Text = lvThamSo.Items[lvThamSo.SelectedIndices[0]].SubItems[1].Text;
                txtGiaTri.Text = lvThamSo.Items[lvThamSo.SelectedIndices[0]].SubItems[2].Text;
            }
        }

        private void btnThemThamSo_Click(object sender, EventArgs e)
        {
            if (txtTenThamSo.Text != "" && txtGiaTri.Text != "")
            {
                ts.ThemThamSo(txtTenThamSo.Text, int.Parse(txtGiaTri.Text));
                HienThiDanhSachThamSo();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenThamSo.Text = "";
                txtGiaTri.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên tham số hoặc giá trị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoaThamSo_Click(object sender, EventArgs e)
        {
            if (lvThamSo.SelectedIndices.Count > 0)
            {
                string str = lvThamSo.Items[lvThamSo.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa tham số ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lvThamSo.SelectedIndices[0];
                    ts.XoaThamSo(deleteIndex);
                    //lvThamSo.Items.Remove(lvThamSo.SelectedItems[0]);
                    MessageBox.Show("Tham số ’" + txtTenThamSo.Text + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDanhSachThamSo();
                    txtTenThamSo.Text = "";
                    txtGiaTri.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 tham số trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCapNhatThamSo_Click(object sender, EventArgs e)
        {
            if (lvThamSo.SelectedIndices.Count > 0)
            {
                if (txtGiaTri.Text != "" && txtTenThamSo.Text != "")
                {
                    ts.CapNhatThamSo(lvThamSo.SelectedIndices[0], txtTenThamSo.Text, int.Parse(txtGiaTri.Text));
                    HienThiDanhSachThamSo();
                    MessageBox.Show("Tham số ’" + txtTenThamSo.Text + "’ đã được cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenThamSo.Text = "";
                    txtGiaTri.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bạn phải chọn 1 tham số trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSoanLaiThamSo_Click(object sender, EventArgs e)
        {
            txtTenThamSo.Text = "";
            txtGiaTri.Text = "";
        }
    }
}
