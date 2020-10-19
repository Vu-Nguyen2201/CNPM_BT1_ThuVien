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
    class ChucVu
    {
        Database db;
        DataTable cv_dt;

        public ChucVu()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
        }
        
        public DataTable LayDanhSachChucVu()
        {
            cv_dt = db.Execute("select * from CHUCVU order by MaChucVu");
            return cv_dt;
        }

        public void ThemChucVu(string ten)
        {
            DataTable dt = db.Execute("select MaChucVu from CHUCVU where MaChucVu >= all(select MaChucVu from CHUCVU)");
            int MaCV = int.Parse(dt.Rows[0][0].ToString()) + 1;
            string str = "insert into CHUCVU values(" + MaCV.ToString() + ",N'" + ten + "')";
            db.ExecuteNonQuery(str);
        }
        public void XoaChucVu(int index)
        {
            string str = "delete from CHUCVU where MaChucVu = " + cv_dt.Rows[index]["MaChucVu"].ToString();
            db.ExecuteNonQuery(str);
        }
        public void CapNhatChucVu(int index, string ten)
        {
            string str = "update CHUCVU set TenChucVu = N'" + ten + "' where MaChucVu = " + cv_dt.Rows[index]["MaChucVu"].ToString();
            db.ExecuteNonQuery(str);
        }
    }
}
