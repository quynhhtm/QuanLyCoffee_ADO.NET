using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLGiaoDichKhachHang
    {
        DBMain db = null;
        public BLGiaoDichKhachHang()
        {
            db = new DBMain();
        }
        public void ThemGiaoDichKhachHangMoi(string HoTenKH, string DiaChi, string SDT, string NgayLap, string MaNV, List<Pair> dsThucUong, ref string err)
        {
            BLKhachHang blKhachHang = new BLKhachHang();
            BLHoaDonThanhToan blHoaDonThanhToan = new BLHoaDonThanhToan();
            BLChiTietHoaDonThanhToan blChiTietHoaDonThanhToan = new BLChiTietHoaDonThanhToan();
            DataTable dtKhachHang = new DataTable();
            DataTable dtHoaDonThanhToan = new DataTable();

            blKhachHang.ThemKhachHang(HoTenKH, DiaChi, SDT, ref err);
            dtKhachHang = blKhachHang.KhachHangMoi().Tables[0];
            string MaKH_New = dtKhachHang.Rows[0][0].ToString();

            blHoaDonThanhToan.ThemHoaDonThanhToan(NgayLap, MaKH_New, MaNV, ref err);
            dtHoaDonThanhToan = blHoaDonThanhToan.HoaDonMoi().Tables[0];
            string MaHD_New = dtHoaDonThanhToan.Rows[0][0].ToString();

            foreach (var item in dsThucUong)
            {
                blChiTietHoaDonThanhToan.ThemChiTietHoaDonThanhToan(item.V, MaHD_New, item.S, ref err);
            }
        }
        public void ThemGiaoDichKhachHangCu(string MaKH, string NgayLap, string MaNV, List<Pair> dsThucUong, ref string err)
        {
            BLHoaDonThanhToan blHoaDonThanhToan = new BLHoaDonThanhToan();
            BLChiTietHoaDonThanhToan blChiTietHoaDonThanhToan = new BLChiTietHoaDonThanhToan();
            DataTable dtHoaDonThanhToan = new DataTable();

            blHoaDonThanhToan.ThemHoaDonThanhToan(NgayLap, MaKH, MaNV, ref err);
            dtHoaDonThanhToan = blHoaDonThanhToan.DSHoaDonThanhToan().Tables[0];
            string MaHD_New = dtHoaDonThanhToan.Rows[dtHoaDonThanhToan.Rows.Count - 1][0].ToString();

            foreach (var item in dsThucUong)
            {
                blChiTietHoaDonThanhToan.ThemChiTietHoaDonThanhToan(item.V, MaHD_New, item.S, ref err);
            }
        }
        public DataSet TimKiem(string text)
        {
            return db.ExecuteQueryDataSet("select* from KhachHang where MaKH = '" + text + "'", CommandType.Text);
        }
    }
}
