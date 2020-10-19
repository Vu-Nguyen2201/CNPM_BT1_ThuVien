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
    class BangCap
    {
        //Khai báo thuộc tính
        Database db;
        DataTable bc_dt;

        //Hàm Contructor khởi tạo giá trị cho thuộc tính
        public BangCap()
        {
            //SvrName và DbName là 2 biến tĩnh (shared) của lớp frmMDI)
            db = new Database(frmMDI.svrName, frmMDI.dbName, frmMDI.intergratedMode, frmMDI.usrName, frmMDI.pwd);
        }
        public DataTable LayDanhSachBangCap()
        {
            bc_dt = db.Execute("Select * from BANGCAP order by MaBangCap");
            //Chạy câu lệnh truy vấn và trả về DataTable kết quả
            //Lưu ý: Các loại bằng cấp được đưa lên ListView trên màn hình hiển thị
            //phải có thứ tự giống với thứ tự chúng được lấy ra bằng câu lệnh Select
            //ở đây (ListView không được có thuộc tính Sort), để khi người dùng chọn
            //1 dòng trong ListView và nhấn Delete, chúng ta có thể dễ dàng lấy được
            //Mã loại tương ứng với loại bằng cấp muốn xóa.
            return bc_dt;
        }
        public void ThemBangCap(string ten)
        {
            DataTable dt;
            dt = db.Execute("select MaBangCap from BANGCAP where MaBangCap >= all(select MaBangCap from BANGCAP)");
            //Chạy câu lệnh truy vấn lấy mã loại bằng cấp có giá trị lớn nhất
            //Kết quả trả về là một DataTable chỉ có 1 dòng duy nhất chứa mã loại
            //bằng cấp có giá trị lớn nhất này
            int MaBC = int.Parse(dt.Rows[0][0].ToString()) + 1;
            //Mã loại độc giả mới = mã loại độc giả lớn nhất + 1
            string str = "INSERT INTO BANGCAP VALUES(" + MaBC.ToString() + ",N'" + ten + "')";
            //Chuấn bị câu lệnh truy vấn thêm vào CSDL
            db.ExecuteNonQuery(str);
            //Cap nhat bc_dt
            DataRow dr = bc_dt.NewRow();
            dr[0] = MaBC;
            dr[1] = ten;
            bc_dt.Rows.Add(dr);
        }
        public void XoaBangCap(int index)
        {
            string str = "delete from BANGCAP where MaBangCap = " + bc_dt.Rows[index]["MaBangCap"].ToString();
            db.ExecuteNonQuery(str);
            //Cập nhật lại danh sách loại độc giả
            bc_dt.Rows.RemoveAt(index);
        }
        public void CapNhatBangCap(int index, string ten)
        {
            string str = "Update BANGCAP set TenBangCap = N'" + ten + "' where MaBangCap = " + bc_dt.Rows[index]["MaBangCap"].ToString();
            db.ExecuteNonQuery(str);
            //Cập nhật lại danh sách bằng cấp
            DataRow dr = bc_dt.Rows[index];
            dr[1] = ten;
        }
    }
}
