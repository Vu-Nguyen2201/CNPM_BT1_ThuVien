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
    class PhieuMuonSach
    {
        Database db;

        DataTable pms_dt;
        DataTable dg_dt;

        DocGia dg;

        public PhieuMuonSach()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
            dg = new DocGia();
            dg_dt = dg.LayDanhSachDocGia();
        }

        public DataTable LayDanhSachPhieuMuonSach()
        {
            pms_dt = db.Execute("Select * from PHIEUMUONSACH");
            return pms_dt;
        }

        public bool ThemPhieuMuon(string ngaymuon, int index_dg)
        {
            DataTable dt;
            dt = db.Execute("select MaPhieuMuon from PHIEUMUONSACH where MaPhieuMuon >= all (select MaPhieuMuon from PHIEUMUONSACH)");
            
            int MaPM;
            MaPM = (int)dt.Rows[0][0] + 1;
            string str;
            str = "Insert into PHIEUMUONSACH values(" +
            MaPM.ToString() + ",'" +
            ngaymuon + "'," + 
            dg_dt.Rows[index_dg]["MaDocGia"].ToString() + ")";
            db.ExecuteNonQuery(str);
            LayDanhSachPhieuMuonSach();
            return true;
        }
        public void CapNhatPhieuMuon(int index, string ngaymuon, int index_dg)
        {
            string str;
            str = "Update PHIEUMUONSACH set " +
                "NgayMuon ='" + ngaymuon + "'," +
                "MaDocGia = " + dg_dt.Rows[index_dg]["MaDocGia"].ToString() + " " +
                "where MaPhieuMuon = " + pms_dt.Rows[index]["MaPhieuMuon"].ToString();

            db.ExecuteNonQuery(str);
            LayDanhSachPhieuMuonSach();
        }
        public bool XoaPhieuMuonSach(int index)
        {
            string str;
            str = "Delete from PHIEUMUONSACH where MaPhieuMuon = " + pms_dt.Rows[index]["MaPhieuMuon"].ToString();
            db.ExecuteNonQuery(str);
            pms_dt.Rows.RemoveAt(index);
            return true;
        }
    }
}
