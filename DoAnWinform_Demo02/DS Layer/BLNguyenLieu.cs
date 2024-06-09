using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLNguyenLieu
    {
        DBMain db = null;
        public BLNguyenLieu()
        {
            db = new DBMain();
        }
        public DataSet DSNguyenLieu()
        {
            return db.ExecuteQueryDataSet("select NguyenLieu.MaNL, NguyenLieu.TenNL, LoaiNguyenLieu.TenLoaiNL " +
                                          "from NguyenLieu join LoaiNguyenLieu on NguyenLieu.MaLoaiNL = LoaiNguyenLieu.MaLoaiNL", CommandType.Text);
        }
        public bool ThemNguyenLieu(string TenNL, string MaLoaiNL, ref string err)
        {
            string sqlString = "INSERT INTO NguyenLieu Values('NL' + cast(next value for nguyenlieuSeq as varchar(5))" + ",N'" + TenNL + "','" + MaLoaiNL + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNguyenLieu(ref string err, string MaNL)
        {
            string sqlString = "delete from ChiTietHoaDonCungCap where MaNL='" + MaNL + "'\r\n" +
                               "delete from PhaChe where MaNL='" + MaNL + "'\r\n" +
                               "delete from NguyenLieu where MaNL='" + MaNL + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThongTin(string MaNL, string TenNL, string MaLoaiNL, ref string err)
        {
            string sqlString = "UPDATE NguyenLieu " +
                               "SET TenNL=N'" + TenNL + "',MaLoaiNL='" + MaLoaiNL + "' " + 
                               "WHERE MaNL='" + MaNL + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemThongTin(string text)
        {
            return db.ExecuteQueryDataSet(
                "select *\r\n" +
                "from NguyenLieu\r\n" +
                "where MaNL like '%" + text + "%' or " +
                      "TenNL like '%" + text + "%' or " +
                      "MaLoaiNL like '%" + text + "%'", CommandType.Text);
        }
    }
}
