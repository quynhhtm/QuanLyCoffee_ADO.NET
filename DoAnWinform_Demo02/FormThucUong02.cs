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
    public partial class FormThucUong02 : Form
    {
        DataTable dtThucUong = null;
        DataTable dtNhomThucUong = null;
        BLNhomThucUong blNhomThucUong = new BLNhomThucUong();
        BLThucUong blThucUong = new BLThucUong();

        string err;
        public FormThucUong02()
        {
            InitializeComponent();
        }
        public void SetProperties(string MaThucUong, string TenThucUong, string DonGia, string TenNhom)
        {
            LoadData();
            txtMaThucUong.Text = MaThucUong;
            txtTenThucUong.Text = TenThucUong;
            txtDonGia.Text = DonGia;
            cbbNhomThucUong.Text = TenNhom;

            this.ShowDialog();
        }
        public void LoadData()
        {
            dtNhomThucUong = new DataTable();
            dtNhomThucUong.Clear();
            dtNhomThucUong = blNhomThucUong.DSNhomThucUong().Tables[0];
            cbbNhomThucUong.DataSource = dtNhomThucUong;
            cbbNhomThucUong.DisplayMember = "TenNhom";
            cbbNhomThucUong.ValueMember = "MaNhom";
        }

        private bool KiemTra(float DonGia)
        {
            if(string.IsNullOrEmpty(txtTenThucUong.Text))
            {
                txtTenThucUong.ResetText();
                txtTenThucUong.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDonGia.Text) || DonGia == 0)
            {
                txtDonGia.ResetText();
                txtDonGia.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float DonGia;
            float.TryParse(txtDonGia.Text.Trim(), out DonGia);
            if (string.IsNullOrEmpty(txtMaThucUong.Text))
            {
                try
                {
                    if(KiemTra(DonGia))
                    {
                        blThucUong.ThemThucUong(txtTenThucUong.Text.Trim(), DonGia, cbbNhomThucUong.SelectedValue.ToString(), ref err);
                        MessageBox.Show("Thêm dữ liệu thành công!");
                    }
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
                    if(KiemTra(DonGia))
                    {
                        blThucUong.CapNhatThongTin(txtMaThucUong.Text, txtTenThucUong.Text, DonGia, cbbNhomThucUong.SelectedValue.ToString(), ref err);
                        MessageBox.Show("Cập nhật dữ liệu thành công!");
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thể thực hiện!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
