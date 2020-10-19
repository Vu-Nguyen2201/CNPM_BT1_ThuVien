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
    class LyDoThanhLy
    {
        Database db;
        DataTable ldtl_dt;

        public LyDoThanhLy()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
        }
        
        public DataTable LayDanhSachLyDoThanhLy()
        {
            ldtl_dt = db.Execute("select * from LYDOTHANHLY order by MaLyDo");
            return  ldtl_dt;
        }

        public void ThemLyDoThanhLy(string ten)
        {
            DataTable dt = db.Execute("select MaLyDo from LYDOTHANHLY where MaLyDo >= all(select MaLyDo from LYDOTHANHLY)");
            int MaBP = int.Parse(dt.Rows[0][0].ToString()) + 1;
            string str = "insert into LYDOTHANHLY values(" + MaBP.ToString() + ",N'" + ten + "')";
            db.ExecuteNonQuery(str);
        }
        public void XoaLyDoThanhLy(int index)
        {
            string str = "delete from LYDOTHANHLY where MaLyDo = " + ldtl_dt.Rows[index]["MaLyDo"].ToString();
            db.ExecuteNonQuery(str);
        }
        public void CapNhatLyDoThanhLy(int index, string ten)
        {
            string str = "update LYDOTHANHLY set TenLyDo = N'" + ten + "' where MaLyDo = " + ldtl_dt.Rows[index]["MaLyDo"].ToString();
            db.ExecuteNonQuery(str);
        }
    }
}
