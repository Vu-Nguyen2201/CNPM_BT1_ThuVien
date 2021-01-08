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
    class PhieuThanhLy
    {
        Database db;

        DataTable nv_dt;
        DataTable ptl_dt;

        NhanVien nv;

        public PhieuThanhLy()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
            nv = new NhanVien();
            nv_dt = nv.LayDanhSachNhanVien();
        }

        public DataTable LayDanhSachPhieuThanhLy()
        {
            ptl_dt = db.Execute("Select * from PHIEUTHANHLY");
            return ptl_dt;
        }

        public bool ThemPhieuThanhLy(string ngaythanhly, int index_nv)
        {
            DataTable dt;
            dt = db.Execute("select MaPhieuThanhLy from PHIEUTHANHLY where MaPhieuThanhLy >= all (select MaPhieuThanhLy from PHIEUTHANHLY)");
            
            int MaPM;
            MaPM = (int)dt.Rows[0][0] + 1;
            string str;
            str = "Insert into PHIEUTHANHLY values(" +
            MaPM.ToString() + ",'" +
            ngaythanhly + "'," + 
            nv_dt.Rows[index_nv]["MaNhanVien"].ToString() + ")";
            db.ExecuteNonQuery(str);
            LayDanhSachPhieuThanhLy();
            return true;
        }
        public void CapNhatPhieuThanhLy(int index, string ngaythanhly, int index_nv)
        {
            string str;
            str = "Update PHIEUTHANHLY set " +
                "NgayThanhLy ='" + ngaythanhly + "'," +
                "MaNhanVien = " + nv_dt.Rows[index_nv]["MaNhanVien"].ToString() + " " +
                "where MaPhieuThanhLy = " + ptl_dt.Rows[index]["MaPhieuThanhLy"].ToString();

            db.ExecuteNonQuery(str);
            LayDanhSachPhieuThanhLy();
        }
        public bool XoaPhieuThanhLy(int index)
        {
            string str;
            str = "Delete from PHIEUTHANHLY where MaPhieuThanhLy = " + ptl_dt.Rows[index]["MaPhieuThanhLy"].ToString();
            db.ExecuteNonQuery(str);
            ptl_dt.Rows.RemoveAt(index);
            return true;
        }
    }
}
