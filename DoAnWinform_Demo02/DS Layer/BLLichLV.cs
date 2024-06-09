using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLLichLV
    {
        DBMain db = null;
        public BLLichLV()
        {
            db = new DBMain();
        }
        public DataSet DSLichLV()
        {
            return db.ExecuteQueryDataSet("select * from LichLamViec", CommandType.Text);
        }
        public DataSet DSLichLVNhanVien()
        {
            return db.ExecuteQueryDataSet("select b.MaNV, b.HoTenNV, a.MaLLV, a.TenLLV, a.TgBatDau, a.TgKetThuc\r\n" +
                                          "from LichLamViec a, NhanVien b\r\n" +
                                          "where a.MaLLV=b.MaLLV", CommandType.Text);
        }
        public bool ThemLichLamViec(string TenLichLV, ref string err)
        {
            string sqlString = "INSERT INTO LichLamViec Values('LLV' + cast(next value for lichlamviecSeq as varchar(5))" + "','" + TenLichLV + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        
        public bool CapNhatThongTin(string MaLLV, string TenLLV, string TgBatDau, string TgKetThuc, ref string err)
        {
            string sqlString = "UPDATE LichLamViec " +
                               "SET TenLLV=N'" + TenLLV + "', TgBatDau='" + TgBatDau + "', TgKetThuc='" + TgKetThuc+ "' " +
                               "where MaLLV = '"+ MaLLV +"'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public DataSet TimKiemThongTin(string text)
        {
            return db.ExecuteQueryDataSet("select *\r\n" +
                                          "from (\r\nselect b.MaNV, b.HoTenNV, a.MaLLV, a.TenLLV, a.TgBatDau, a.TgKetThuc\r\n" +
                                          "from LichLamViec a, NhanVien b\r\nwhere a.MaLLV=b.MaLLV \r\n) as q\r\n" +
                                          "where q.MaNV like '%" + text + "%' or " +
                                                "q.HoTenNV like N'%" + text + "%' or " +
                                                "q.TenLLV like N'%" + text + "%'", CommandType.Text);
        }
    }
}
