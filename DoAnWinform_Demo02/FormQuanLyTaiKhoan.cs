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
    public partial class FormQuanLyTaiKhoan : Form
    {
        DataTable dtTaiKhoan = null;
        BLTaiKhoan blTaiKhoan = null;
        DataSet ds = null;
        string err = null;
        public FormQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                blTaiKhoan = new BLTaiKhoan();
                dtTaiKhoan = new DataTable();
                dtTaiKhoan.Clear();
                ds = blTaiKhoan.DSTaiKhoan();
                dtTaiKhoan = ds.Tables[0];
                dgvTaiKhoan.DataSource = dtTaiKhoan;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtTaiKhoan = new DataTable();
            dtTaiKhoan.Clear();
            DataSet ds = blTaiKhoan.TimKiem(txtThongTin.Text.Trim());
            dtTaiKhoan = ds.Tables[0];
            dgvTaiKhoan.DataSource = dtTaiKhoan;
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DialogResult thongbao;
                thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (thongbao == DialogResult.OK)
                {
                    int r = dgvTaiKhoan.CurrentCell.RowIndex;
                    string TenTK = dgvTaiKhoan.Rows[r].Cells[1].Value.ToString();
                    blTaiKhoan = new BLTaiKhoan();
                    bool flag = blTaiKhoan.XoaTaiKhoan(TenTK, ref err);
                    if (flag)
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

        private void FormQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormDangKyTaiKhoan form = new FormDangKyTaiKhoan();
            form.ShowDialog();
            LoadData();
        }
    }
}
