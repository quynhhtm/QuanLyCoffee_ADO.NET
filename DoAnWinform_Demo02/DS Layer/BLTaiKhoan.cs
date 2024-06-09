using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLTaiKhoan
    {
        DBMain db = null;
        public BLTaiKhoan()
        {
            db = new DBMain();
        }
        public DataSet DSTaiKhoan()
        {
            return db.ExecuteQueryDataSet("select TenTK, MatKhau from TaiKhoan where QuanLy is not null", CommandType.Text);
        }

        public bool KiemTra(string TenTK, string MatKhau)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            ds = db.ExecuteQueryDataSet("select* " +
                                        "from TaiKhoan " +
                                        "where TenTK = '" + TenTK + "' and " +
                                              "MatKhau = '" + MatKhau + "' and " +
                                              "QuanLy is not null", CommandType.Text);
            dt = ds.Tables[0];
            return dt.Rows.Count > 0;
        }

        public bool TaoTaiKhoan(string TenTK, string MatKhau, ref string err)
        {
            DataSet ds = new DataSet();
            ds = db.ExecuteQueryDataSet("select TOP 1 TenTK from TaiKhoan where QuanLy is null", CommandType.Text);
            string TenNQL = ds.Tables[0].Rows[0][0].ToString();
            string sqlString = "INSERT INTO TaiKhoan VALUES ('" + TenTK + "', '" + MatKhau + "', '" + TenNQL + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool KTQuanLy(string TenNQL, string MatKhauNQL)
        {
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            string sqlString = "select* " +
                               "from TaiKhoan " +
                               "where TenTK='" + TenNQL + "' and " +
                                     "MatKhau='" + MatKhauNQL + "' " +
                                     "and QuanLy is null";
            ds = db.ExecuteQueryDataSet(sqlString, CommandType.Text);
            dt = ds.Tables[0];
            return dt.Rows.Count > 0;
        }

        public bool ThayDoiMatKhau(string TenTK, string MatKhau, ref string err)
        {
            string sqlString = "update TaiKhoan set MatKhau='" + MatKhau + "' where TenTK='" + TenTK + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet TimKiem(string text)
        {
            return db.ExecuteQueryDataSet("select TenTK, MatKhau " +
                                          "from TaiKhoan " +
                                          "where TenTK like '%" + text + "%' and " +
                                                "QuanLy is not null", CommandType.Text);
        }

        public bool XoaTaiKhoan(string TenTK, ref string err)
        {
            string sqlString = "delete from TaiKhoan where TenTK='" + TenTK + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
