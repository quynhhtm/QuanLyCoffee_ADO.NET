using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCKy_Demo01.DB_Layer
{
    public class DBMain
    {
        string strConnection = "Data Source=LAPTOP-Q7RU1PPE\\TRINHMANHQUYNH;Initial Catalog = DOAN02; Integrated Security = True";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(strConnection);
            cmd = conn.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;
            da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
            conn.Open();
            cmd.CommandText = strSQL;
            cmd.CommandType = ct;

            try
            {
                cmd.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

    }
}
