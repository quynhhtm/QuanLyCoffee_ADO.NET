using DoAnWinform_Demo02.DS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform_Demo02
{
    public partial class FormPhaChe01 : Form
    {
        BLPhaChe blPhaChe = null;
        DataTable dtPhaChe = null;
        DataTable dtThucUong = null;
        DataTable dtNguyenLieu = null;
        BLThucUong blThucUong = null;
        DataSet ds = null;
        string err = null;

        public FormPhaChe01()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                blThucUong = new BLThucUong();
                dtThucUong = new DataTable();
                dtThucUong.Clear();
                ds = blThucUong.DSThucUong();
                dtThucUong = ds.Tables[0];
                dgvThucUong.DataSource = dtThucUong;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...!");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtPhaChe = new DataTable();
            ds = new DataSet();
            blPhaChe = new BLPhaChe();
            dtPhaChe.Clear();
            ds = blPhaChe.TimKiemThongTin(txtThongTin.Text.Trim());
            dtPhaChe = ds.Tables[0];
            dgvThucUong.DataSource= dtPhaChe;

        }

        private void FormPhaChe01_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvThucUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                int r = dgvThucUong.CurrentCell.RowIndex;
                string MaThucUong = dgvThucUong.Rows[r].Cells[1].Value.ToString();
                string TenThucUong = dgvThucUong.Rows[r].Cells[2].Value.ToString();
                FormPhaChe02 form = new FormPhaChe02();
                form.SetProperties(MaThucUong, TenThucUong);
            }
            LoadDSNguyenLieu();
        }

        private void LoadDSNguyenLieu()
        {
            int r = dgvThucUong.CurrentCell.RowIndex;
            string MaThucUong = dgvThucUong.Rows[r].Cells[1].Value.ToString();
            blPhaChe = new BLPhaChe();
            dtNguyenLieu = blPhaChe.DSNguyenLieu(MaThucUong).Tables[0];
            dgvNguyenLieu.DataSource = dtNguyenLieu;
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                int r = dgvNguyenLieu.CurrentCell.RowIndex;
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNguyenLieu.Rows[r];
                if(!row.IsNewRow)
                {
                    string MaNL = dgvNguyenLieu.Rows[r].Cells[1].Value.ToString();
                    blPhaChe = new BLPhaChe();
                    blPhaChe.XoaPhaChe(ref err, "", MaNL);
                    LoadDSNguyenLieu();
                }
                
            }
        }
    }
}
