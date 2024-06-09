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
    public partial class FormNguyenLieu01 : Form
    {
        DataTable dtNguyenLieu = null;
        BLNguyenLieu blNguyenLieu = new BLNguyenLieu();
        string err = null;
        public FormNguyenLieu01()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dtNguyenLieu = new DataTable();
                dtNguyenLieu.Clear();
                DataSet ds = blNguyenLieu.DSNguyenLieu();
                dtNguyenLieu = ds.Tables[0];
                dgvNguyenLieu.DataSource = dtNguyenLieu;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...!");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtNguyenLieu = new DataTable();
            dtNguyenLieu.Clear();
            DataSet dsNguyenLieu = new DataSet();
            dsNguyenLieu = blNguyenLieu.TimKiemThongTin(txtThongTin.Text.Trim());
            dtNguyenLieu = dsNguyenLieu.Tables[0];
            dgvNguyenLieu.DataSource = dtNguyenLieu;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormNguyenLieu02 new_form = new FormNguyenLieu02();
            new_form.Text = "Thêm nguyên liệu";
            new_form.LoadData();
            new_form.ShowDialog();
            LoadData();
        }

        private void FormNguyenLieu01_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvNguyenLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNguyenLieu.CurrentCell.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvNguyenLieu.Rows[r];
            if (!row.IsNewRow)
            {
                string MaNL = dgvNguyenLieu.Rows[r].Cells[2].Value.ToString();
                string TenNL = dgvNguyenLieu.Rows[r].Cells[3].Value.ToString();
                string TenLoaiNL = dgvNguyenLieu.Rows[r].Cells[4].Value.ToString();
                if (e.ColumnIndex == 0)
                {
                    FormNguyenLieu02 new_form = new FormNguyenLieu02();
                    new_form.Text = "Cập nhật thông tin";
                    new_form.SetProperties(MaNL, TenNL, TenLoaiNL);
                    LoadData();
                }
                if(e.ColumnIndex == 1)
                {
                    try
                    {
                        DialogResult thongbao;
                        thongbao = MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (thongbao == DialogResult.OK)
                        {
                            blNguyenLieu.XoaNguyenLieu(ref err, MaNL);
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
