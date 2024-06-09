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
    public partial class FormThucUong01 : Form
    {
        DataTable dtThucUong = null;
        BLThucUong blThucUong = new BLThucUong();
        string err = null;
        public FormThucUong01()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dtThucUong = new DataTable();
                dtThucUong.Clear();
                DataSet ds = blThucUong.DSThucUong();
                dtThucUong = ds.Tables[0];
                dgvThucUong.DataSource = dtThucUong;

            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...");
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtThucUong = new DataTable();
            dtThucUong.Clear();
            DataSet dsThucUong = new DataSet();
            dsThucUong = blThucUong.TimKiemThongTin(txtThongTin.Text.Trim());
            dtThucUong = dsThucUong.Tables[0];
            dgvThucUong.DataSource = dtThucUong;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormThucUong02 new_form = new FormThucUong02();
            new_form.Text = "Thêm thức uống";
            new_form.LoadData();
            new_form.ShowDialog();
            LoadData();
        }

        private void FormThucUong01_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvThucUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvThucUong.CurrentCell.RowIndex;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvThucUong.Rows[r];
            if (!row.IsNewRow)
            {
                string MaThucUong = dgvThucUong.Rows[r].Cells[2].Value.ToString();
                string TenThucUong = dgvThucUong.Rows[r].Cells[3].Value.ToString();
                string TenNhom = dgvThucUong.Rows[r].Cells[4].Value.ToString();
                string DonGia = dgvThucUong.Rows[r].Cells[5].Value.ToString();

                if(e.ColumnIndex == 0)
                {
                    FormThucUong02 new_form = new FormThucUong02();
                    new_form.Text = "Cập nhật thông tin";
                    new_form.SetProperties(MaThucUong, TenThucUong, DonGia, TenNhom);
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
                            blThucUong.XoaThucUong(ref err, MaThucUong);
                            MessageBox.Show("Xóa thành công!");
                            LoadData();
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
