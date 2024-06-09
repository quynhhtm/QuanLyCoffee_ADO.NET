using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLLoaiNguyenLieu
    {
        DBMain db = null;
        public BLLoaiNguyenLieu()
        {
            db = new DBMain();
        }
        public DataSet DSLoaiNguyenLieu()
        {
            return db.ExecuteQueryDataSet("SELECT* FROM LoaiNguyenLieu", CommandType.Text);
        }
        public bool ThemLoaiNguyenLieu(string TenLoaiNL, ref string err)
        {
            string sqlString = "INSERT INTO LoaiNguyenLieu Values('LNL' + cast(next value for loainguyenlieuSeq as varchar(5))" + ",N'" + TenLoaiNL + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaLoaiNguyenLieu(ref string err, string MaLoaiNL)
        {
            string sqlString = "delete from ChiTietHoaDonCungCap " +
                               "where MaNL in (select b.MaNL from LoaiNguyenLieu a, NguyenLieu b where a.MaLoaiNL=b.MaLoaiNL and a.MaLoaiNL='"+ MaLoaiNL +"')\r\n" +
                               "delete from PhaChe where MaNL in (select b.MaNL from LoaiNguyenLieu a, NguyenLieu b where a.MaLoaiNL=b.MaLoaiNL and a.MaLoaiNL='" + MaLoaiNL +"')\r\n" +
                               "delete from NguyenLieu where MaLoaiNL='" + MaLoaiNL +"'\r\n" +
                               "delete from LoaiNguyenLieu where MaLoaiNL='" + MaLoaiNL +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThongTin(string MaLoaiNL, string TenLoaiNL, ref string err)
        {
            string sqlString = "UPDATE LoaiNguyenLieu " +
                               "SET TenLoaiNL=N'" + TenLoaiNL + "'" +
                               "WHERE MaLoaiNL='" + MaLoaiNL + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemThongTin(string text)
        {
            return db.ExecuteQueryDataSet(
                "select *\r\n" +
                "from LoaiNguyenLieu\r\n" +
                "where MaLoaiNL like '%" + text + "%' or " +
                "TenLoaiNL like '%" + text + "%'", CommandType.Text);
        }
    }
}
