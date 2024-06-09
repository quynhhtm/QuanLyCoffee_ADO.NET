using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLHoaDonCungCap
    {
        DBMain db = null;
        public BLHoaDonCungCap()
        {
            db = new DBMain();
        }
        public DataSet DSHoaDonCungCap()
        {
            return db.ExecuteQueryDataSet("select * from HoaDonCungCap", CommandType.Text);
        }
        public bool ThemHoaDonCungCap(DateTime NgayLap, string MaNCC, ref string err)
        {
            string sqlString = "INSERT INTO HoaDonCungCap Values('HDCC' + cast(next value for hoadoncungcapSeq as varchar(5))" + ",'" + NgayLap.Date + "','" + MaNCC + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaHoaDonCungCap(ref string err, string MaHD)
        {
            string sqlString = "DELETE FROM HoaDonCungCap WHERE MaHD='" + MaHD + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThongTin(string MaHD, string MaNCC, ref string err)
        {
            string sqlString = "UPDATE HoaDonCungCap SET MaNCC='" + MaNCC + "'" +
                            "WHERE MaHD=N'" + MaHD + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemThongTin(string MaHD)
        {
            return db.ExecuteQueryDataSet(
                "select *\r\n" +
                "from (select Q1.MaHD, Q1.TenNL, Q1.SoLuong, Q1.DonGia, Q2.TenNCC, Q2.NgayLap\r\n" +
                "from (select NguyenLieu.TenNL, ChiTietHoaDonCungCap.SoLuong, ChiTietHoaDonCungCap.MaHD, ChiTietHoaDonCungCap.DonGia\r\n" +
                "from NguyenLieu, ChiTietHoaDonCungCap where NguyenLieu.MaNL = ChiTietHoaDonCungCap.MaNL) as Q1 inner join\r\n" +
                "(select HoaDonCungCap.MaHD, HoaDonCungCap.NgayLap, NhaCungCap.TenNCC from HoaDonCungCap, NhaCungCap where HoaDonCungCap.MaNCC = NhaCungCap.MaNCC)  as Q2 on Q1.MaHD = Q2.MaHD) as HD\r\n" +
                "where HD.MaHD like '" + MaHD + "'", CommandType.Text);
        }

        public DataSet HoaDonCungCapMoi()
        {
            return db.ExecuteQueryDataSet("select TOP 1 MaHD from HoaDonCungCap order by MaHD desc", CommandType.Text);
        }
    }
}
