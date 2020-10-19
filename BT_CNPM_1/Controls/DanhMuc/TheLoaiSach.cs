using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThuVien.Models;
using ThuVien.Views;

namespace ThuVien.Controls
{
    class TheLoaiSach
    {
        Database db;
        DataTable tls_dt;

        public TheLoaiSach()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
        }
        
        public DataTable LayDanhSachTheLoaiSach()
        {
            tls_dt = db.Execute("select * from THELOAISACH order by MaTheLoai");
            return tls_dt;
        }

        public void ThemTheLoaiSach(string ten)
        {
            DataTable dt = db.Execute("select MaTheLoai from THELOAISACH where MaTheLoai >= all(select MaTheLoai from THELOAISACH)");
            int MaBP = int.Parse(dt.Rows[0][0].ToString()) + 1;
            string str = "insert into THELOAISACH values(" + MaBP.ToString() + ",N'" + ten + "')";
            db.ExecuteNonQuery(str);
        }
        public void XoaTheLoaiSach(int index)
        {
            string str = "delete from THELOAISACH where MaTheLoai = " + tls_dt.Rows[index]["MaTheLoai"].ToString();
            db.ExecuteNonQuery(str);
        }
        public void CapNhatTheLoaiSach(int index, string ten)
        {
            string str = "update THELOAISACH set TenTheLoai = N'" + ten + "' where MaTheLoai = " + tls_dt.Rows[index]["MaTheLoai"].ToString();
            db.ExecuteNonQuery(str);
        }
    }
}
