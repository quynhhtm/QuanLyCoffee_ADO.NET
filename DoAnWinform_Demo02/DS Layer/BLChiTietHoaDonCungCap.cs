using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLChiTietHoaDonCungCap
    {
        DBMain db = null;
        public BLChiTietHoaDonCungCap()
        {
            db = new DBMain();
        }
        public DataSet DSChiTietHoaDonCungCap()
        {
            return db.ExecuteQueryDataSet("SELECT* FROM ChiTietHoaDonCungCap", CommandType.Text);
        }
        public bool ThemChiTietHoaDonCungCap(string MaNL, string MaHD, int SoLuong, float DonGia, ref string err)
        {
            string sqlString = "INSERT INTO ChiTietHoaDonCungCap Values('" + MaNL + "','" + MaHD + "'," + SoLuong + "," + DonGia + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaChiTietHoaDonCungCap(ref string err, string MaNL, string MaHD)
        {
            string sqlString = "DELETE FROM ChiTietHoaDonCungCap WHERE MaHD='" + MaHD + "' or MaNL='" + MaNL + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThongTin(string MaNL, string MaHD, int SoLuong, float DonGia, ref string err)
        {
            string sqlString = "UPDATE ChiTietHoaDonCungCap SET SoLuong=" +
                            SoLuong + ", DonGia=" + DonGia + " " +
                            "WHERE MaHD='" + MaHD + "' and MaNL='" + MaNL + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
