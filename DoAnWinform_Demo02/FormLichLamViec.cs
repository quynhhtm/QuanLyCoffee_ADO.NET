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
    public partial class FormLichLamViec : Form
    {
        DataTable dtLichLVNhanVien = null;
        BLLichLV blLichLV = new BLLichLV();
        string err = null;
        public FormLichLamViec()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            try
            {
                dtLichLVNhanVien = new DataTable();
                dtLichLVNhanVien.Clear();

                DataSet ds = blLichLV.DSLichLVNhanVien();
                dtLichLVNhanVien = ds.Tables[0];
                dgvLichLV.DataSource = dtLichLVNhanVien;

                cbbCaLam.DataSource = blLichLV.DSLichLV().Tables[0];
                cbbCaLam.DisplayMember = "TenLLV";
                cbbCaLam.ValueMember = "MaLLV";

                mtbTgBatDau.Enabled = false;
                mtbTgKetThuc.Enabled = false;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
            }
            catch (SqlException)
            {
                MessageBox.Show("Loading...");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtLichLVNhanVien = new DataTable();
            dtLichLVNhanVien.Clear();
            DataSet dsLichLV = new DataSet();
            dsLichLV = blLichLV.TimKiemThongTin(txtThongTin.Text.Trim());
            dtLichLVNhanVien = dsLichLV.Tables[0];
            dgvLichLV.DataSource = dtLichLVNhanVien;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                blLichLV = new BLLichLV();
                bool flag = blLichLV.CapNhatThongTin(cbbCaLam.SelectedValue.ToString(), cbbCaLam.Text.ToString(), mtbTgBatDau.Text, mtbTgKetThuc.Text , ref err);
                if(flag)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thể thực hiện!");
            }
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FormLichLamViec_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cbbLoaiNL_SelectedIndexChanged(object sender, EventArgs e)
        {
            BLLichLV bLLichLV = new BLLichLV();
            DataTable dt = new DataTable();
            dt = blLichLV.DSLichLV().Tables[0];
            foreach (DataRow row in dt.Rows)
            {
                var value = row[0];
                if(value.ToString() == cbbCaLam.SelectedValue.ToString())
                {
                    mtbTgBatDau.Text = row[2].ToString();
                    mtbTgKetThuc.Text = row[3].ToString();
                    break;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            mtbTgBatDau.Enabled = true;
            mtbTgKetThuc.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }
    }
}
