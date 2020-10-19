using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Khai báo thư viện cho các lớp
using System.Data.SqlClient; //SqlConnection,...
using System.Data;//DataSet, DataTable,... 

namespace ThuVien.Models
{
    class Database
    {
        //Thuộc tính
        SqlConnection sqlconn;
        //Contructor khởi tạo
        public Database(string svrName, string dbName, bool intergratedMode, string usrName, string pwd)
        {
            string connStr;
            if (intergratedMode == true)
            {
                //Đăng nhập SQL Server sử dụng Windows Authentication Mode.
                connStr = "server=" + svrName + "; database=" + dbName + "; Integrated Security = True";
            }
            else
            {
                //Đăng nhập SQL Server sử dụng SQL Server Authentication Mode.
                connStr = "server=" + svrName + "; uid=" + usrName + "; pwd=" + pwd + " ;database=" + dbName;
            }
            //Câu lệnh dùng để thiết lập kết nối đến SQL Server là server=tên_svr; database = tên_db;
            //Integrated Security = True hay server=tên_svr; database = tên_db; uid = tên_đăng_nhập;
            //pwd = mật_khẩu; database = tên_db .
            sqlconn = new SqlConnection(connStr);
        }
        public DataTable Execute(string strQuery)
        {
            //Câu lệnh này tạo mới một đối tượng SqlDataAdapter và
            //cung cấp cho nó câu truy vấn cùng với kết nối hiện hành
            //SqlDataAdapter da = new SqlDataAdapter(strQuery, sqlconn);
            SqlDataAdapter da = new SqlDataAdapter(strQuery, sqlconn);
            //DataSet đại diện cho một danh sách các DataTable (mỗi DataTable là 1 bảng dữ liệu)
            DataSet ds = new DataSet();
            //Dùng SqlDataAdapter đã tạo ra ở trên thực thi câu lệnh truy vấn đã cung cấp,
            //và đưa kết quả trả về vào ds
            da.Fill(ds);
            //Chúng ta chỉ lấy bảng đầu tiên
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string strquery)
        {
            //SqlCommand là đối tượng chuyên đảm nhận việc thực hiện các câu lệnh truy vấn
            SqlCommand sqlcom = new SqlCommand(strquery, sqlconn);
            sqlconn.Open(); //Mở kết nối
            sqlcom.ExecuteNonQuery(); //Thực hiện câu lệnh truy vấn đã cung cấp ở trên
            sqlconn.Close(); //Đóng kết nối
        }
        public void ExecuteNonQueryAdapter(DataTable dt, string strQuery)
        {
            //Lấy dữ liệu
            SqlDataAdapter da = new SqlDataAdapter(strQuery, sqlconn);
            //Thiết lập cập nhật
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.UpdateCommand = builder.GetUpdateCommand();
            //Match dữ liệu
            da.Update(dt);
        }
    }
}