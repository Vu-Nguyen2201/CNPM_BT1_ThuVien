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
    public partial class frmMDI : Form
    {
        public static string svrName = "DESKTOP-GNULQ63";
        public static string dbName = "ThuVien";
        public static bool intergratedMode = false;
        public static string usrName = "thuvien";
        public static string pwd = "12345";
        private int childFormNumber = 0;

        public frmMDI()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnBangCap_Click(object sender, EventArgs e)
        {
            frmBangCap f = new frmBangCap();
            f.MdiParent = this;
            f.Show();
        }

        private void btnBoPhan_Click(object sender, EventArgs e)
        {
            frmBoPhan f = new frmBoPhan();
            f.Show();
        }

        private void btnChucVu_Click(object sender, EventArgs e)
        {
            frmChucVu f = new frmChucVu();
            f.Show();
        }

        private void btnLoaiDocGia_Click(object sender, EventArgs e)
        {
            frmLoaiDocGia f = new frmLoaiDocGia();
            f.Show();
        }

        private void btnTheLoaiSach_Click(object sender, EventArgs e)
        {
            frmTheLoaiSach f = new frmTheLoaiSach();
            f.Show();
        }

        private void btnLyDoThanhLy_Click(object sender, EventArgs e)
        {
            frmLyDoThanhLy f = new frmLyDoThanhLy();
            f.Show();
        }

        private void btnBangThamSo_Click(object sender, EventArgs e)
        {
            frmThamSo f = new frmThamSo();
            f.Show();
        }

        private void btnTiepNhanNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.Show();
        }

        private void btnLapTheDocSach_Click(object sender, EventArgs e)
        {
            frmLapTheDocGia f = new frmLapTheDocGia();
            f.Show();
        }

        private void btnChoMuonSach_Click(object sender, EventArgs e)
        {
            frmChoMuonSach f = new frmChoMuonSach();
            f.Show();
        }
    }
}
