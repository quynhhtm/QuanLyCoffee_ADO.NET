using DoAnCKy_Demo01.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnWinform_Demo02.DS_Layer
{
    public class BLPhaChe
    {
        DBMain db = null;
        public BLPhaChe()
        {
            db = new DBMain();
        }

        public bool ThemPhaChe(string MaThucUong, string MaNL, ref string err)
        {
            string sqlString = "INSERT INTO PhaChe Values('" + MaThucUong + "','" + MaNL + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaPhaChe(ref string err, string MaThucUong, string MaNL)
        {
            string sqlString = "DELETE FROM PhaChe WHERE MaThucUong='" + MaThucUong + "' or MaNL='" + MaNL + "'";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        
        public DataSet DSNguyenLieu(string MaThucUong)
        {
            return db.ExecuteQueryDataSet("select a.MaNL, a.MaThucUong as MaThucUongNL, c.TenNL\r\n" +
                                          "from PhaChe a, ThucUong b, NguyenLieu c\r\n" +
                                          "where a.MaThucUong=b.MaThucUong and " +
                                                "a.MaNL = c.MaNL and " +
                                                "a.MaThucUong='" + MaThucUong +"'", CommandType.Text);
        }
        public DataSet TimKiemThongTin(string text)
        {
            return db.ExecuteQueryDataSet("select * " +
                                          "from ThucUong " +
                                          "where MaThucUong like '%" + text + "%' or " +
                                                "TenThucUong like '%" + text + "%'", CommandType.Text);
        }
    }
}
