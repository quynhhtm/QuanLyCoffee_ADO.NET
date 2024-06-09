using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLKhachHang
    {
        DBMain db = null;
        public BLKhachHang()
        {
            db = new DBMain();
        }
        public DataSet DSKhachHang()
        {
            return db.ExecuteQueryDataSet("select* from KhachHang", CommandType.Text);
        }
        public bool ThemKhachHang(string TenKH, string DiaChi, string SDT, ref string err)
        {
            string sqlString = "INSERT INTO KhachHang Values('KH' + cast(next value for khachhangSeq as varchar(5))" + " ,N'" + TenKH + "', '" + SDT + "', N'" + DiaChi +"')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaKhachHang(ref string err, string MaKH)
        {
            string sqlString = "delete from ChiTietHoaDonThanhToan where MaHD in (select b.MaHD from KhachHang a, HoaDonThanhToan b where a.MaKH=b.MaKH and a.MaKH='" +MaKH+ "')\r\n" +
                               "delete from HoaDonThanhToan where MaKH='" + MaKH+ "'\r\n" +
                               "delete from KhachHang where MaKH='" + MaKH+ "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThongTin(string MaKH, string TenKH, string DiaChi, string SDT, ref string err)
        {
            string sqlString = "UPDATE KhachHang " +
                               "SET TenKH=N'" + TenKH + "', DiaChi=N'" + DiaChi + "', SDT='" + SDT + "' "+
                               "WHERE MaKH='" + MaKH + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemThongTin(string text)
        {
            return db.ExecuteQueryDataSet("select* " +
                                          "from KhachHang " +
                                          "where MaKH like '%" + text + "%' or " +
                                                 "TenKH like N'%" + text + "%' or " +
                                                 "SDT like '%" + text + "%' or " +
                                                 "DiaChi like N'%" + text + "%'", CommandType.Text);
        }
        public DataSet KhachHangMoi()
        {
            return db.ExecuteQueryDataSet("select TOP 1 MaKH from KhachHang order by MaKH desc", CommandType.Text);
        }
    }
}
