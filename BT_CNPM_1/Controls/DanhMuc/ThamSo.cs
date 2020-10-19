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
    class ThamSo
    {
        Database db;
        DataTable ts_dt;

        public ThamSo()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
        }
        
        public DataTable LayDanhSachThamSo()
        {
            ts_dt = db.Execute("select * from THAMSO");
            return ts_dt;
        }

        public void ThemThamSo(string tenThamSo, int giaTri)
        {
            //string str = "insert into THAMSO values(N'" + tenThamSo + "'," + giaTri.ToString() + ")";
            //db.ExecuteNonQuery(str);

            //Insert by using Adapter Update
            DataRow dr = ts_dt.NewRow();
            dr[0] = tenThamSo;
            dr[1] = giaTri.ToString();
            ts_dt.Rows.Add(dr);
            db.ExecuteNonQueryAdapter(ts_dt, "select * from THAMSO");
        }
        public void XoaThamSo(int index)
        {
            string str = "delete from THAMSO where TenThamSo = N'" + ts_dt.Rows[index]["TenThamSo"].ToString() + "'";
            db.ExecuteNonQuery(str);

            //Delete by using Adapter Update
            //DataRow dr = ts_dt.Rows[index];
            //ts_dt.Rows.Remove(dr);
            ////ts_dt.Rows.RemoveAt(index);
            ////ts_dt.Rows.Find(index).Delete();
            //db.ExecuteNonQueryAdapter(ts_dt, "select * from THAMSO");

        }
        public void CapNhatThamSo(int index, string tenThamSo, int giaTri)
        {
            //string str = "update THAMSO set TenThamSo = N'" + tenThamSo + "' , GiaTri = " + giaTri + " where TenThamSo = N'" + ts_dt.Rows[index]["TenThamSo"].ToString() + "'";
            //db.ExecuteNonQuery(str);

            //Update by using Adapter Update
            ts_dt.Rows[index]["TenThamSo"] = tenThamSo;
            ts_dt.Rows[index]["GiaTri"] = giaTri;
            db.ExecuteNonQueryAdapter(ts_dt, "select * from THAMSO");
        }
    }
}