using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLNhaCungCap
    {
        DBMain db = null;
        public BLNhaCungCap()
        {
            db = new DBMain();
        }
        public DataSet DSNhaCungCap()
        {
            return db.ExecuteQueryDataSet("SELECT* FROM NhaCungCap", CommandType.Text);
        }
        public bool ThemNhaCungCap(string TenNCC, ref string err)
        {
            string sqlString = "INSERT INTO NhaCungCap Values('NCC' + cast(next value for nhacungcapSeq as varchar(5))" + ",N'" + TenNCC + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaNhaCungCap(ref string err, string MaNCC)
        {
            string sqlString = "delete from ChiTietHoaDonCungCap where MaHD in (select b.MaHD from NhaCungCap a, HoaDonCungCap b where a.MaNCC=b.MaNCC and a.MaNCC='" +  MaNCC + "')\r\n" +
                "delete from HoaDonCungCap where MaNCC='" +  MaNCC + "'\r\n" +
                "delete from NhaCungCap where MaNCC='" +  MaNCC + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatThongTin(string MaNCC, string TenNCC, ref string err)
        {
            string sqlString = "UPDATE NhaCungCap " +
                               "SET TenNCC=N'" + TenNCC + "'" + 
                               "WHERE MaNCC=N'" + MaNCC + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemThongTin(string text)
        {
            return db.ExecuteQueryDataSet(
                "select * " +
                "from NhaCungCap " +
                "where MaNCC like '%"+ text + "%' or " +
                      "TenNCC like N'%"+ text +"%'", CommandType.Text);
        }
    }
}
