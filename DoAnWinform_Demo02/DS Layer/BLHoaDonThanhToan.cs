using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public  class BLHoaDonThanhToan
    {
        DBMain db = null;
        public BLHoaDonThanhToan()
        {
            db = new DBMain();
        }
        public DataSet DSHoaDonThanhToan()
        {
            return db.ExecuteQueryDataSet("SELECT* FROM HoaDonThanhToan", CommandType.Text);
        }
        public bool ThemHoaDonThanhToan(string NgayLap, string MaKH, string MaNV, ref string err)
        {
            string sqlString = "INSERT INTO HoaDonThanhToan Values('HDTT' + cast(next value for hoadonthanhtoanSeq as varchar(5)), '" + NgayLap +"', '"+ MaKH +"', '" + MaNV +"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaHoaDonThanhToan(ref string err, string MaHD)
        {
            string sqlString = "delete from ChiTietHoaDonThanhToan where MaHD='"+ MaHD + "'\r\n" +
                               "delete from HoaDonThanhToan where MaHD='"+ MaHD +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThongTin(string MaHD, string NgayLap, string MaKH, string MaNV, ref string err)
        {
            string sqlString = "UPDATE HoaDonThanhToan " +
                               "SET NgayLap = '" + NgayLap + "', MaKH = '" + MaKH +"', MaNV = '" + MaNV +"'\r\n" +
                               "where MaHD='"+MaHD+"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet HoaDonMoi()
        {
            return db.ExecuteQueryDataSet("select TOP 1 MaHD from HoaDonThanhToan order by MaHD desc", CommandType.Text);
        }
    }
}
