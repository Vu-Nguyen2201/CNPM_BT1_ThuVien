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
    public partial class frmBangCap : Form
    {
        //Khai báo thuộc tính
        BangCap bc = new BangCap();

        //Contructor 
        public frmBangCap()
        {
            InitializeComponent();
        }
        private void frmBangCap_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBangCap();
        }
        public void HienThiDanhSachBangCap()
        {
            lvBangCap.View = View.Details;
            lvBangCap.FullRowSelect = true;
            lvBangCap.Items.Clear();
            lvBangCap.Columns[1].Width = 273;
            int i;
            string str;
            DataTable dt;
            dt = bc.LayDanhSachBangCap();
            for (i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem lvi;
                lvi = lvBangCap.Items.Add((i + 1).ToString());
                str = dt.Rows[i]["TenBangCap"].ToString();
                lvi.SubItems.Add(str);

                //ListViewItem lvi;
                //lvBangCap.Items.Add((i + 1).ToString());
                //var items = lvBangCap.Items;
                //ListViewItem last = items[items.Count - 1];
                //lvi = last;
                //str = dt.Rows[i]["TenBangCap"].ToString();
                //lvi.SubItems.Add(str);
            }
        }
        private void lvBangCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvBangCap.SelectedIndices.Count > 0)
            {
                txtTenBangCap.Text = lvBangCap.Items[lvBangCap.SelectedIndices[0]].SubItems[1].Text;
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenBangCap.Text != "")
            {
                //Dùng biến thuộc lớp LoaiDocGia để thực hiện việc thêm loại độc giả
                bc.ThemBangCap(txtTenBangCap.Text);
                //Cập nhật lại màn hình hiển thị
                HienThiDanhSachBangCap();
                MessageBox.Show("Thêm thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information); 
                txtTenBangCap.Text = "";
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập tên bằng cấp", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvBangCap.SelectedIndices.Count > 0)
            {
                //lvBangCap.SelectedIndices.Count là số lượng item của list view được chọn
                string str = "";
                str  = lvBangCap.Items[lvBangCap.SelectedIndices[0]].SubItems[1].Text;
                if (MessageBox.Show("Bạn có chắc chắn là muốn xóa bằng cấp ’" + str + "’ không ?", "Hỏi lại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int deleteIndex = lvBangCap.SelectedIndices[0];
                    bc.XoaBangCap(deleteIndex);
                    //Xóa loại bằng cấp này khỏi danh sách, việc xóa khỏi CSDL
                    //được thực hiện qua biến bc chứ không chạy truy vấn trực tiếp
                    lvBangCap.Items.Remove(lvBangCap.SelectedItems[0]);
                    //Thông báo xóa thành công
                    MessageBox.Show("Bằng cấp ’" + txtTenBangCap.Text + "’ đã được xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenBangCap.Text = "";
                }
            }
            else
            {
                //Nếu không có item nào được chọn thì hiển thị thông báo
                MessageBox.Show("Bạn phải chọn 1 bằng cấp trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvBangCap.SelectedIndices.Count > 0)
            {
                if (txtTenBangCap.Text != "")
                {
                    bc.CapNhatBangCap(lvBangCap.SelectedIndices[0], txtTenBangCap.Text);
                    //Cập nhật loại bằng cấp trong CSDL và trên list view
                    HienThiDanhSachBangCap();
                    MessageBox.Show("Bằng cấp ’" + txtTenBangCap.Text + "’ đã được cập nhật thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenBangCap.Text = "";
                }
            }
            else
            {
                //Nếu không có loại bằng cấp nào được chọn để tiến hành cập nhật thì hiên thị thống báo
                    MessageBox.Show("Bạn phải chọn 1 bằng cấp trong danh sách trước", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void btnSoanLai_Click(object sender, EventArgs e)
        {
            txtTenBangCap.Text = "";
        }

    }
}
