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
    class BoPhan
    {
        Database db;
        DataTable bp_dt;

        public BoPhan()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
        }
        
        public DataTable LayDanhSachBoPhan()
        {
            bp_dt = db.Execute("select * from BOPHAN order by MaBoPhan");
            return bp_dt;
        }

        public void ThemBoPhan(string ten)
        {
            DataTable dt = db.Execute("select MaBoPhan from BOPHAN where MaBoPhan >= all(select MaBoPhan from BOPHAN)");
            int MaBP = int.Parse(dt.Rows[0][0].ToString()) + 1;
            string str = "insert into BOPHAN values(" + MaBP.ToString() + ",N'" + ten + "')";
            db.ExecuteNonQuery(str);
        }
        public void XoaBoPhan(int index)
        {
            string str = "delete from BOPHAN where MaBoPhan = " + bp_dt.Rows[index]["MaBoPhan"].ToString();
            db.ExecuteNonQuery(str);
        }
        public void CapNhatBoPhan(int index, string ten)
        {
            string str = "update BOPHAN set TenBoPhan = N'" + ten + "' where MaBoPhan = " + bp_dt.Rows[index]["MaBoPhan"].ToString();
            db.ExecuteNonQuery(str);
        }
    }
}
