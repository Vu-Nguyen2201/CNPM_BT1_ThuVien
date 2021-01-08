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
    class NhanVien
    {
        Database db;

        DataTable nv_dt;
        DataTable bc_dt;
        DataTable bp_dt;
        DataTable cv_dt;

        BangCap bc;
        BoPhan bp;
        ChucVu cv;

        public NhanVien()
        {
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
            //Khởi tạo lớp
            bc = new BangCap();
            bp = new BoPhan();
            cv = new ChucVu();
            //Lấy danh sách các đối tượng
            bc_dt = bc.LayDanhSachBangCap();
            bp_dt = bp.LayDanhSachBoPhan();
            cv_dt = cv.LayDanhSachChucVu();
        }
        
        public DataTable LayDanhSachNhanVien()
        {
            nv_dt = db.Execute("Select * from NHANVIEN");
            return nv_dt;
        }

        public bool ThemNhanVien(string ten, string ngaysinh, string diachi, string dienthoai, int index_bc, int index_bp, int index_cv)
        {
            //Mã nhân viên mới = Mã nhân viên lớn nhật hiện tại + 1
            DataTable dt;
            dt = db.Execute("select MaNhanVien from NHANVIEN where MaNhanVien >= all (select MaNhanVien from NHANVIEN)");
            //dt chỉ có 1 dòng chữa mã nhân viên lớn nhất
            int MaNV;
            MaNV = (int)dt.Rows[0][0] + 1;
            string str;
            //Tạo câu lệnh truy vấn
            str = "Insert into NHANVIEN values(" +
            MaNV.ToString() + ",N'" + ten + "','" +
            ngaysinh + "',N'" + 
            diachi + "','" + 
            dienthoai + "'," +
            bc_dt.Rows[index_bc]["MaBangCap"].ToString() + "," +
            bp_dt.Rows[index_bp]["MaBoPhan"].ToString() + "," +
            cv_dt.Rows[index_cv]["MaChucVu"].ToString() + ")";
            db.ExecuteNonQuery(str);
            //Cập nhật lại nv_dt
            LayDanhSachNhanVien();
            return true;
        }
        public bool XoaNhanVien(int index)
        {
            string str;
            //Chuẩn bị câu lệnh truy vấn
            str = "Delete from NHANVIEN where MaNhanVien = " + nv_dt.Rows[index]["MaNhanVien"].ToString();
            db.ExecuteNonQuery(str);
            //Cập nhật lại nv_dt
            nv_dt.Rows.RemoveAt(index);
            return true;
        }
        public void CapNhatNhanVien(int index, string hoten, string ngaysinh, string diachi, string dienthoai, int index_bc, int index_bp, int index_cv)
        {
            string str;
            //Chuẩn bị câu lẹnh truy vấn
            str = "Update NHANVIEN set HoTenNhanVien = N'" + hoten + "', NgaySinh ='" +
            ngaysinh + "',diachi = N'" + diachi + "', dienthoai = '" + dienthoai + "', MaBangCap = " +
            bc_dt.Rows[index_bc]["MaBangCap"].ToString() + ",MaBoPhan = " +
            bp_dt.Rows[index_bp]["MaBoPhan"].ToString() + ", MaChucVu = " +
            cv_dt.Rows[index_cv]["MaChucVu"].ToString() + " where MaNhanVien = " +
            nv_dt.Rows[index]["MaNhanVien"].ToString();
            db.ExecuteNonQuery(str);
            //Cập nhật lại data table nv_dt
            LayDanhSachNhanVien();
        }
    }
}
