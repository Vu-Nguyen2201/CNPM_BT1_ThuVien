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
    class LoaiDocGia
    {
        Database db;
        DataTable ldg_dt;

        public LoaiDocGia()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
        }
        
        public DataTable LayDanhSachLoaiDocGia()
        {
            ldg_dt = db.Execute("select * from LOAIDOCGIA order by MaLoaiDocGia");
            return ldg_dt;
        }

        public void ThemLoaiDocGia(string ten)
        {
            DataTable dt = db.Execute("select MaLoaiDocGia from LOAIDOCGIA where MaLoaiDocGia >= all(select MaLoaiDocGia from LOAIDOCGIA)");
            int MaLDG = int.Parse(dt.Rows[0][0].ToString()) + 1;
            string str = "insert into LOAIDOCGIA values(" + MaLDG.ToString() + ",N'" + ten + "')";
            db.ExecuteNonQuery(str);
        }
        public void XoaLoaiDocGia(int index)
        {
            string str = "delete from LOAIDOCGIA where MaLoaiDocGia = " + ldg_dt.Rows[index]["MaLoaiDocGia"].ToString();
            db.ExecuteNonQuery(str);
        }
        public void CapNhatLoaiDocGia(int index, string ten)
        {
            string str = "update LOAIDOCGIA set TenLoaiDocGia = N'" + ten + "' where MaLoaiDocGia = " + ldg_dt.Rows[index]["MaLoaiDocGia"].ToString();
            db.ExecuteNonQuery(str);
        }
    }
}
