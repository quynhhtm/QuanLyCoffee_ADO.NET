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
    public partial class FormNhomThucUong : Form
    {
        DataTable dtNhomThucUong = null;
        BLNhomThucUong blNhomThucUong = null;
        string err = null;

        public FormNhomThucUong()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            try
            {
                blNhomThucUong = new BLNhomThucUong();
                dtNhomThucUong = new DataTable();
                dtNhomThucUong.Clear();

                DataSet ds = blNhomThucUong.DSNhomThucUong();
                dtNhomThucUong = ds.Tables[0];

                dgvNhomThucUong.DataSource = dtNhomThucUong;

                txtMaNhom.ResetText();
                txtTenNhom.ResetText();
                txtMaNhom.Enabled = false;
                txtTenNhom.Enabled = false; 
                btnHuy.Enabled = false;
                btnLuu.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtNhomThucUong = new DataTable();
            dtNhomThucUong.Clear();
            DataSet dsNhomThucUong = new DataSet();
            dsNhomThucUong = blNhomThucUong.TimKiemThongTin(txtThongTin.Text.Trim());
            dtNhomThucUong = dsNhomThucUong.Tables[0];
            dgvNhomThucUong.DataSource = dtNhomThucUong;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaNhom.ResetText();
            txtTenNhom.Enabled = true;
            txtTenNhom.Focus();
            btnLuu.Enabled=true;
            btnHuy.Enabled=true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhom.Text))
            {
                try
                {
                    blNhomThucUong = new BLNhomThucUong();
                    blNhomThucUong.ThemNhomThucUong(txtTenNhom.Text.Trim(), ref err);
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
                    blNhomThucUong = new BLNhomThucUong();
                    blNhomThucUong.CapNhatThongTin(txtMaNhom.Text.Trim(), txtTenNhom.Text.Trim(), ref err);

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

        private void FormNhomThucUong01_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNhomThucUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhomThucUong.CurrentCell.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNhomThucUong.Rows[r];
            if (!row.IsNewRow)
            {
                string MaNhom = dgvNhomThucUong.Rows[r].Cells[2].Value.ToString();
                string TenNhom = dgvNhomThucUong.Rows[r].Cells[3].Value.ToString();
                txtMaNhom.Text = MaNhom;
                txtTenNhom.Text = TenNhom;

                if (e.ColumnIndex == 0) // Chinh sua
                {
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    txtTenNhom.Enabled = true;
                    txtTenNhom.Focus();
                }

                if (e.ColumnIndex == 1) // Xoa
                {
                    try
                    {
                        DialogResult thongbao;
                        thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (thongbao == DialogResult.OK)
                        {
                            blNhomThucUong.XoaNhomThucUong(ref err, MaNhom);
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
