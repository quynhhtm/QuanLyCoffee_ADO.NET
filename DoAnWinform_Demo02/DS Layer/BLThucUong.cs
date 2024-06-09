using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLThucUong
    {
        DBMain db = null;
        public BLThucUong()
        {
            db = new DBMain();
        }
        public DataSet DSThucUong()
        {
            return db.ExecuteQueryDataSet("select ThucUong.MaThucUong, ThucUong.TenThucUong, NhomThucUong.TenNhom, ThucUong.DonGia  " +
                                          "from ThucUong inner join NhomThucUong on ThucUong.MaNhom = NhomThucUong.MaNhom", CommandType.Text);
        }
        public bool ThemThucUong(string TenThucUong, float DonGia, string MaNhom, ref string err)
        {
            string sqlString = "INSERT INTO ThucUong Values('TU' + cast(next value for thucuongSeq as varchar(5))" + ",N'" + TenThucUong + "','" + MaNhom + "'," + DonGia + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaThucUong(ref string err, string MaThucUong)
        {
            string sqlString = "DELETE FROM ChiTietHoaDonThanhToan \r\n" +
                               "WHERE MaHD in (\r\n" +
                                                "select ChiTietHoaDonThanhToan.MaHD\r\n" +
                                                "from ChiTietHoaDonThanhToan\r\n" +
                                                "where ChiTietHoaDonThanhToan.MaThucUong = '" + MaThucUong + "')\r\n\r\n" +
                               "DELETE FROM PhaChe \r\nWHERE MaThucUong = '" + MaThucUong + "'\r\n\r\n" +
                               "DELETE FROM ThucUong \r\nWHERE MaThucUong = '" + MaThucUong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThongTin(string MaThucUong, string TenThucUong, float DonGia, string MaNhom, ref string err)
        {
            string sqlString = "UPDATE ThucUong " +
                               "SET TenThucUong=N'" + TenThucUong + "',MaNhom='" + MaNhom + "', DonGia=" + DonGia + " " + 
                               "WHERE MaThucUong='" + MaThucUong + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemThongTin(string text)
        {
            int DonGia;
            int.TryParse(text, out DonGia);
            return db.ExecuteQueryDataSet("select ThucUong.MaThucUong, ThucUong.TenThucUong, NhomThucUong.TenNhom, ThucUong.DonGia " +
                                          "from ThucUong inner join NhomThucUong on ThucUong.MaNhom = NhomThucUong.MaNhom\r\n" +
                                          "where ThucUong.MaThucUong like '%" + text + "%' or " +
                                                 "ThucUong.TenThucUong like N'%" + text + "%' or " +
                                                 "NhomThucUong.TenNhom like N'%" + text + "%' or " +
                                                 "DonGia = " + DonGia, CommandType.Text);
        }
    }
}
