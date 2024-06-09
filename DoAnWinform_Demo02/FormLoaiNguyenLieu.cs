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
    public partial class FormLoaiNguyenLieu : Form
    {
        DataTable dtLoaiNguyenLieu = null;
        BLLoaiNguyenLieu blLoaiNguyenLieu = new BLLoaiNguyenLieu();
        string err = null;
        public FormLoaiNguyenLieu()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dtLoaiNguyenLieu = new DataTable();
                dtLoaiNguyenLieu.Clear();

                DataSet ds = blLoaiNguyenLieu.DSLoaiNguyenLieu();
                dtLoaiNguyenLieu = ds.Tables[0];
                dgvLoaiNL.DataSource = dtLoaiNguyenLieu;

                txtMaLoaiNL.ResetText();
                txtTenLoaiNL.ResetText();
                txtMaLoaiNL.Enabled = false;
                txtTenLoaiNL.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtLoaiNguyenLieu = new DataTable();
            dtLoaiNguyenLieu.Clear();
            DataSet dsLoaiNguyenLieu = new DataSet();
            dsLoaiNguyenLieu = blLoaiNguyenLieu.TimKiemThongTin(txtThongTin.Text.Trim());
            dtLoaiNguyenLieu = dsLoaiNguyenLieu.Tables[0];
            dgvLoaiNL.DataSource = dtLoaiNguyenLieu;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            txtMaLoaiNL.ResetText();
            txtTenLoaiNL.ResetText();
            txtTenLoaiNL.Enabled = true;
            txtTenLoaiNL.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaLoaiNL.Text))
            {
                try
                {
                    blLoaiNguyenLieu = new BLLoaiNguyenLieu();
                    blLoaiNguyenLieu.ThemLoaiNguyenLieu(txtTenLoaiNL.Text.Trim(), ref err);
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
                    blLoaiNguyenLieu = new BLLoaiNguyenLieu();
                    blLoaiNguyenLieu.CapNhatThongTin(txtMaLoaiNL.Text.Trim(), txtTenLoaiNL.Text.Trim(), ref err);

                    MessageBox.Show("Cập nhật thành công!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thể thực hiện!");
                }
            }
            LoadData();
        }
        private void FormLoaiNguyenLieu01_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvLoaiNL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoaiNL.CurrentCell.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvLoaiNL.Rows[r];
            if (!row.IsNewRow)
            {
                string MaLoaiNL = dgvLoaiNL.Rows[r].Cells[2].Value.ToString();
                string TenLoaiNL = dgvLoaiNL.Rows[r].Cells[3].Value.ToString();
                txtMaLoaiNL.Text = MaLoaiNL;
                txtTenLoaiNL.Text = TenLoaiNL;

                if(e.ColumnIndex == 0)
                {
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                    txtTenLoaiNL.Enabled = true;
                    txtTenLoaiNL.Focus();
                }
                if(e.ColumnIndex == 1)
                {
                    try
                    {
                        DialogResult thongbao;
                        thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (thongbao == DialogResult.OK)
                        {
                            BLLoaiNguyenLieu LoaiNguyenLieu = new BLLoaiNguyenLieu();
                            LoaiNguyenLieu.XoaLoaiNguyenLieu(ref err, MaLoaiNL);
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
