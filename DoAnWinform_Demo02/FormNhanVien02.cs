using DoAnWinform_Demo02.DS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnWinform_Demo02
{
    public partial class FormNhanVien02 : Form
    {
        DataTable dtNV = null;
        DataTable dtLLV = null;

        BLNhanVien blNV = null;
        BLLichLV blLLV = null;

        string err;
        public FormNhanVien02()
        {
            InitializeComponent();
        }
        public void SetProperties(string MaNV, string HoTenNV, string NgSinh, string DiaChi, string Phai, string MaLLV)
        {
            LoadData();
            txtMaNV.Text = MaNV;
            txtTenNV.Text = HoTenNV;
            mtbNgaySinh.Text = NgSinh;
            txtDiaChi.Text = DiaChi;
            cbbPhai.Text = Phai;
            cbbTenLLV.Text = MaLLV;

            this.ShowDialog();
        }

        private void LoadData()
        {
            dtLLV = new DataTable();
            blLLV = new BLLichLV();
            dtLLV.Clear();
            dtLLV = blLLV.DSLichLV().Tables[0];
            cbbTenLLV.DataSource = dtLLV;
            cbbTenLLV.DisplayMember = "TenLLV";
            cbbTenLLV.ValueMember = "MaLLV";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                try
                {
                    blNV = new BLNhanVien();
                    DateTime parsedDate;
                    string NgSinh = null;
                    DateTime date;
                    if (DateTime.TryParseExact(mtbNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        NgSinh = date.ToString("yyyy-MM-dd");
                    }
                    blNV.ThemNhanVien(txtTenNV.Text.Trim(), NgSinh, txtDiaChi.Text.Trim(), cbbPhai.Text.Trim(), cbbTenLLV.SelectedValue.ToString(), ref err);

                    MessageBox.Show("Thêm thành công!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Khong the them duoc!");
                }
            }
            else
            {
                try
                {
                    blNV = new BLNhanVien();
                    DateTime parsedDate;
                    string NgSinh = null;
                    DateTime date;
                    if (DateTime.TryParseExact(mtbNgaySinh.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                    {
                        NgSinh = date.ToString("yyyy-MM-dd");
                    }
                    blNV.CapNhatThongTin(txtMaNV.Text, txtTenNV.Text.Trim(), NgSinh, txtDiaChi.Text.Trim(), cbbPhai.Text.Trim(), cbbTenLLV.SelectedValue.ToString(), ref err);

                    MessageBox.Show("Cập nhật thông tin thành công!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Khong the sua!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNhanVien02_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
