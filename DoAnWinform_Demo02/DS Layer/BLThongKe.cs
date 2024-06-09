using DoAnCKy_Demo01.DB_Layer;
using Microsoft.ReportingServices.DataProcessing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLThongKe
    {
        DBMain db = null;
        public BLThongKe()
        {
            db = new DBMain();
        }
        public DataSet DoanhThuThang(string Nam)
        {
            return db.ExecuteQueryDataSet("select DATEPART(MONTH, c.NgayLap) as thang, sum(a.SoLuong*b.DonGia) as doanhthu\r\n" +
                                          "from ChiTietHoaDonThanhToan a, ThucUong b, HoaDonThanhToan c\r\n" +
                                          "where a.MaThucUong=b.MaThucUong and a.MaHD=c.MaHD and DATEPART(YEAR, c.NgayLap)='"+ Nam +"'\r\n" +
                                          "group by DATEPART(MONTH, c.NgayLap)", System.Data.CommandType.Text);
        }

        public DataSet ChiPhiNguyenLieu(string Nam)
        {
            return db.ExecuteQueryDataSet("select DATEPART(MONTH, a.NgayLap) as Thang, sum(b.DonGia*b.SoLuong) as ChiPhi\r\n" +
                                          "from HoaDonCungCap a, ChiTietHoaDonCungCap b\r\n" +
                                          "where a.MaHD=b.MaHD and DATEPART(YEAR, a.NgayLap)='" + Nam + "'\r\n" +
                                          "group by DATEPART(MONTH, a.NgayLap)", System.Data.CommandType.Text);
        }

        public DataSet TiLeNhomThucUongBanRa(string Thang, string Nam)
        {
            return db.ExecuteQueryDataSet("select c.TenNhom, sum(a.SoLuong) as SoLuong\r\n" +
                                          "from ChiTietHoaDonThanhToan a, ThucUong b, NhomThucUong c, HoaDonThanhToan d\r\n" +
                                          "where a.MaThucUong=b.MaThucUong and c.MaNhom=b.MaNhom and d.MaHD=a.MaHD and DATEPART(MONTH, d.NgayLap)='" +Thang+ "' and DATEPART(YEAR, d.NgayLap)='" + Nam +"'\r\n" +
                                          "group by c.MaNhom, c.TenNhom", System.Data.CommandType.Text);
        }

        public DataSet DSNam()
        {
            return db.ExecuteQueryDataSet("SELECT DISTINCT DATEPART(YEAR, NgayLap) as Nam FROM HoaDonThanhToan;", System.Data.CommandType.Text);
        }

        public DataSet DSThang()
        {
            return db.ExecuteQueryDataSet("SELECT DISTINCT DATEPART(MONTH, NgayLap) as Thang FROM HoaDonThanhToan;", System.Data.CommandType.Text);
        }
    }
}
