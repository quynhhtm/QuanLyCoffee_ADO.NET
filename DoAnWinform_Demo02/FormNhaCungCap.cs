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
    public partial class FormNhaCungCap : Form
    {
        DataTable dtNhaCungCap = null;
        BLNhaCungCap blNhaCungCap = new BLNhaCungCap();
        string err = null;

        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                dtNhaCungCap = new DataTable();
                dtNhaCungCap.Clear();

                DataSet ds = blNhaCungCap.DSNhaCungCap();
                dtNhaCungCap = ds.Tables[0];
                dgvNhaCungCap.DataSource = dtNhaCungCap;

                txtMaNCC.ResetText();
                txtTenNCC.ResetText();
                txtMaNCC.Enabled = false;
                txtTenNCC.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtNhaCungCap = new DataTable();
            dtNhaCungCap.Clear();
            DataSet dsNhaCungCap = new DataSet();
            dsNhaCungCap = blNhaCungCap.TimKiemThongTin(txtThongTin.Text.Trim());
            dtNhaCungCap = dsNhaCungCap.Tables[0];
            dgvNhaCungCap.DataSource = dtNhaCungCap;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtTenNCC.Enabled=true;
            txtTenNCC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                try
                {
                    blNhaCungCap = new BLNhaCungCap();
                    blNhaCungCap.ThemNhaCungCap(txtTenNCC.Text.Trim(), ref err);
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thể thực hiện!");
                }
            }
            else
            {
                try
                {
                    blNhaCungCap = new BLNhaCungCap();
                    blNhaCungCap.CapNhatThongTin(txtMaNCC.Text.Trim(), txtTenNCC.Text.Trim(), ref err);

                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thể thực hiện!");
                }
            }
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhaCungCap.CurrentCell.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNhaCungCap.Rows[r];
            if (!row.IsNewRow)
            {
                string MaNCC = dgvNhaCungCap.Rows[r].Cells[2].Value.ToString();
                string TenNCC = dgvNhaCungCap.Rows[r].Cells[3].Value.ToString();
                txtMaNCC.Text = MaNCC;
                txtTenNCC.Text = TenNCC;

                if(e.ColumnIndex == 0)
                {
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    txtTenNCC.Enabled = true;
                    txtTenNCC.Focus();
                }
                if(e.ColumnIndex == 1)
                {
                    try
                    {
                        DialogResult thongbao;
                        thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (thongbao == DialogResult.OK)
                        {
                            BLNhaCungCap NhaCungCap = new BLNhaCungCap();
                            NhaCungCap.XoaNhaCungCap(ref err, MaNCC);
                            LoadData();
                            MessageBox.Show("Xóa thành công!");
                        }
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Không thể thực hiện!");
                    }
                }
            }
        }
    }
}
