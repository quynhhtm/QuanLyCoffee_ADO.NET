using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLChiTietHoaDonThanhToan
    {
        DBMain db = null;
        public BLChiTietHoaDonThanhToan()
        {
            db = new DBMain();
        }
        public DataSet DSChiTietHoaDonThanhToan()
        {
            return db.ExecuteQueryDataSet("SELECT* FROM ChiTietHoaDonThanhToan", CommandType.Text);
        }
        public bool ThemChiTietHoaDonThanhToan(string MaThucUong, string MaHD, int SoLuong, ref string err)
        {
            string sqlString = "INSERT INTO ChiTietHoaDonThanhToan Values('"+MaThucUong+"', '"+ MaHD +"'," + SoLuong +")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaChiTietHoaDonThanhToan(ref string err, string MaHD, string MaThucUong)
        {
            string sqlString = "DELETE FROM ChiTietHoaDonThanhToan WHERE MaHD='" + MaHD + "' and MaThucUong='" + MaThucUong +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
