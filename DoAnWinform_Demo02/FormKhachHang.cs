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
    public partial class FormKhachHang : Form
    {
        DataTable dtKH = null;
        BLKhachHang blKH = null;
        DataSet ds = null;
        string err = null;
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                blKH = new BLKhachHang();
                dtKH = new DataTable();
                dtKH.Clear();
                ds = blKH.DSKhachHang();
                dtKH = ds.Tables[0];
                dgvKH.DataSource = dtKH;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtKH = new DataTable();
            dtKH.Clear();
            DataSet ds = blKH.TimKiemThongTin(txtThongTin.Text.Trim());
            dtKH = ds.Tables[0];
            dgvKH.DataSource = dtKH;
        }

        private void FormKhachHang01_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                int r = dgvKH.CurrentCell.RowIndex;
                string MaKH = dgvKH.Rows[r].Cells[2].Value.ToString();
                FormReportChiTietGDKH form = new FormReportChiTietGDKH(MaKH);
                form.ShowDialog();
            }
            if(e.ColumnIndex == 1)
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (thongbao == DialogResult.OK)
                {
                    int r = dgvKH.CurrentCell.RowIndex;
                    string MaKH = dgvKH.Rows[r].Cells[2].Value.ToString();
                    blKH = new BLKhachHang();
                    bool flag = blKH.XoaKhachHang(ref err, MaKH);
                    if(flag)
                    {
                        MessageBox.Show("Xóa thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Thực hiện không thành công!");
                    }
                    LoadData();
                }
            }
        }
        
    }
}
