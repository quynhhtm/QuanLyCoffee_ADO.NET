using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLNhomThucUong
    {
        DBMain db = null;
        public BLNhomThucUong()
        {
            db = new DBMain();
        }
        public DataSet DSNhomThucUong()
        {
            return db.ExecuteQueryDataSet("SELECT* FROM NhomThucUong", CommandType.Text);
        }
        public bool ThemNhomThucUong(string TenNhom, ref string err)
        {
            string sqlString = "INSERT INTO NhomThucUong Values('NTU' + cast(next value for nhomthucuongSeq as varchar(5))" + ",N'" + TenNhom + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhomThucUong(ref string err, string MaNhom)
        {
            string sqlString = "delete from ChiTietHoaDonThanhToan where MaThucUong in (select b.MaThucUong from NhomThucUong a, ThucUong b where a.MaNhom=b.MaNhom and a.MaNhom='" + MaNhom + "')\r\n" +
                               "delete from PhaChe where MaThucUong in (select b.MaThucUong from NhomThucUong a, ThucUong b where a.MaNhom=b.MaNhom and a.MaNhom='" + MaNhom + "')\r\n" +
                               "delete from ThucUong where MaNhom='" + MaNhom + "'\r\n" +
                               "delete from NhomThucUong where MaNhom='" + MaNhom + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThongTin(string MaNhom, string TenNhom, ref string err)
        {
            string sqlString = "UPDATE NhomThucUong SET TenNhom=N'" +
                            TenNhom + "'" +
                            "WHERE MaNhom=N'" + MaNhom + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemThongTin(string text)
        {
            return db.ExecuteQueryDataSet(
                "select *\r\n" +
                "from NhomThucUong\r\n" +
                "where MaNhom like '%" + text + "%' or " +
                      "TenNhom like N'%" + text + "%'", CommandType.Text);
        }
    }
}
