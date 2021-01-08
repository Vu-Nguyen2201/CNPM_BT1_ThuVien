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
    class DocGia
    {
        Database db;

        DataTable ldg_dt;
        DataTable nv_dt;
        DataTable dg_dt;

        LoaiDocGia ldg;
        NhanVien nv;

        public DocGia()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);

            ldg = new LoaiDocGia();
            nv = new NhanVien();

            ldg_dt = ldg.LayDanhSachLoaiDocGia();
            nv_dt = nv.LayDanhSachNhanVien();
        }
        
        public DataTable LayDanhSachDocGia()
        {
            dg_dt = db.Execute("Select * from DOCGIA");
            return dg_dt;
        }

        public bool ThemDocGia(string ten, int index_ldg, string ngaysinh, string diachi, string email, string ngaylapthe, string ngayhethan, int index_nv, int tienno)
        {
            DataTable dt;
            dt = db.Execute("select MaDocGia from DOCGIA where MaDocGia >= all (select MaDocGia from DOCGIA)");

            int MaDG;
            MaDG = (int)dt.Rows[0][0] + 1;
            string str;

            str = "Insert into DOCGIA values(" +
            MaDG.ToString() + ",N'" + 
            ten + "'," +
            ldg_dt.Rows[index_ldg]["MaLoaiDocGia"].ToString() + ",'" +
            ngaysinh + "',N'" + 
            diachi + "','" + 
            email + "','" +
            ngaylapthe + "','" +
            ngayhethan + "'," +
            nv_dt.Rows[index_nv]["MaNhanVien"].ToString() + "," +
            tienno + ")";

            db.ExecuteNonQuery(str);
            LayDanhSachDocGia();
            return true;
        }
        public bool XoaDocGia(int index)
        {
            string str;
            str = "Delete from DOCGIA where MaDocGia = " + dg_dt.Rows[index]["MaDocGia"].ToString();
            db.ExecuteNonQuery(str);
            dg_dt.Rows.RemoveAt(index);
            return true;
        }
        public void CapNhatDocGia(int index, string ten, int index_ldg, string ngaysinh, string diachi, string email, string ngaylapthe, string ngayhethan, int index_nv, int tienno)
        {
            string str;
            //Chuẩn bị câu lẹnh truy vấn
            str = "Update DOCGIA set " +
                "HoTenDocGia = N'" + ten + "', " +
                "LoaiDocGia =" + ldg_dt.Rows[index_ldg]["MaLoaiDocGia"].ToString() + "," +
                "NgaySinh ='" + ngaysinh + "'," +
                "DiaChi = N'" + diachi + "', " +
                "Email = '" + email + "', " +
                "NgayLapThe ='" + ngaylapthe + "'," +
                "NgayHetHan ='" + ngayhethan + "'," +
                "MaNhanVien =" + nv_dt.Rows[index_nv]["MaNhanVien"].ToString() + "," +
                "TienNo =" + tienno + " " +
                "where MaDocGia = " + dg_dt.Rows[index]["MaLoaiDocGia"].ToString();

            db.ExecuteNonQuery(str);
            //Cập nhật lại data table nv_dt
            LayDanhSachDocGia();
        }
    }
}
